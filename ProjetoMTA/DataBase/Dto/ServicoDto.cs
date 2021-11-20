using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    [Table("Servico")]
    public class ServicoDto
    {
        public ServicoDto()
        {
            Produtos = new List<Produto_Servico>();
        }

        [Key]
        public int Id { get; set; }
        public int IdMecanico { get; set; }
        public int IdVeiculo { get; set; }
        public DateTime DataManutencao { get; set; }
        public decimal ValorMaoDeObra { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorPago { get; set; }

        [Write(false)]
        public string NomeMecanico { get; set; }
        [Write(false)]
        public string NomeCliente { get; set; }
        [Write(false)]
        public string NomeVeiculo { get; set; }
        [Write(false)]
        public List<Produto_Servico> Produtos { get; set; }
        [Write(false)]
        public bool Gravou { get; private set; }

        public List<ServicoDto> GetAll(string Banco)
        {
            using (SqlConnection connection = new SqlConnection(Banco))
            {
                var Servico =  (List<ServicoDto>)connection.Query<ServicoDto>(@"select s.*,
                                                                                m.Nome as NomeMecanico, 
                                                                                c.Nome as NomeCliente, 
                                                                                CONCAT(v.Marca, ' - ' ,v.Modelo) as NomeVeiculo,
                                                                                s.DataManutencao, 
                                                                                s.ValorTotal
                                                                                from Servico s 
                                                                                inner join Mecanico m on s.IdMecanico = m.Id 
                                                                                inner join Veiculo v on s.IdVeiculo = v.Id 
                                                                                inner join Cliente c on c.Id = v.IdCliente");

                var produto = (List<Produto_Servico>)connection.Query<Produto_Servico>(@"select ps.*, p.Nome as NomeProduto
                                                                                            from Produto_Servico ps
                                                                                            inner join Produto p on p.Id = ps.IdProduto");


                foreach (var item in Servico)
                {
                    foreach (var item2 in produto)
                    {
                        if (item.Id == item2.IdServico)
                        {
                            item.Produtos.Add(item2);
                        }
                    }
                }


                return Servico;
            }
        }

        public List<ClienteDto> GetClientePeloVeiculo(string Banco, int IdVeiculo)
        {
            using (SqlConnection connection = new SqlConnection(Banco))
            {
                return (List<ClienteDto>)connection.Query<ClienteDto>($@"select Top 1 c.* From veiculo v
                                                                  inner join Cliente c on c.Id = v.IdCliente 
                                                                  where v.Id = {IdVeiculo}");
            }
        }

        public bool Insert(ServicoDto entity, string Banco)
        {
            try
            {
                if (entity.Id == 0)
                {
                    using (SqlConnection connection = new SqlConnection(Banco))
                    {
                        var Result = connection.Insert(entity);
                        Gravou = ProdutosInsertUpdate((int)Result, entity.Produtos, Banco);
                    }
                    if (!Gravou) return false;
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(Banco))
                    {
                        var Result = connection.Update(entity);
                        Gravou = ProdutosInsertUpdate(entity.Id, entity.Produtos, Banco);
                    }
                    if (!Gravou) return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool ProdutosInsertUpdate(int result, List<Produto_Servico> produtos, string Banco)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Banco))
                {
                    var resultado = (List<Produto_Servico>)connection.Query<Produto_Servico>($@"Select * from Produto_Servico where IdServico = {result}");

                    if (resultado.Count != 0)
                    {
                        foreach (var item in resultado)
                        {
                            var a = (List<Produto_Servico>)connection.Query<Produto_Servico>($@"Delete from Produto_Servico where IdServico = {result}");
                        }
                    }
                }

                foreach (Produto_Servico produto in produtos)
                {
                    if (produto.IdProduto != 0)
                    {
                        produto.IdServico = (int)result;
                        using (SqlConnection connection = new SqlConnection(Banco))
                        {
                            var Result = connection.Insert(produto);
                        }
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id, string Banco)
        {
            var Sucesso = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(Banco))
                {
                    var resultado = (List<Produto_Servico>)connection.Query<Produto_Servico>($@"Select * from Produto_Servico where IdServico = {id}");

                    if (resultado.Count != 0)
                    {
                        foreach (var item in resultado)
                        {
                            var a = (List<Produto_Servico>)connection.Query<Produto_Servico>($@"Delete from Produto_Servico where IdServico = {id}");
                        }
                    }

                    var Result = connection.Delete(new ServicoDto() { Id = id });
                    
                    Sucesso = Result;
                }
            }
            catch (Exception)
            {
                return Sucesso;

            }
            return Sucesso;
        }
    }
}
