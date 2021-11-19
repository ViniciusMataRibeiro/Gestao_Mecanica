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
                var sql = @"select s.*,
                                                                        m.Nome as NomeMecanico, 
                                                                        c.Nome as NomeCliente, 
                                                                        CONCAT(v.Marca, ' - ' ,v.Modelo) as NomeVeiculo,
                                                                        s.DataManutencao, 
                                                                        s.ValorTotal, 
                                                                            
                                                                            ps.IdServico Produtos_IdServico,
                                                                            ps.IdProduto Produtos_IdProduto,
                                                                            ps.QtdPecas Produtos_QtdPecas,
                                                                            ps.ValorProduto Produtos_ValorProduto,
                                                                            p.Nome as Produtos_NomeProduto

                                                                        from Servico s 
                                                                        inner join Mecanico m on s.IdMecanico = m.Id 
                                                                        inner join Veiculo v on s.IdVeiculo = v.Id 
                                                                        inner join Cliente c on c.Id = v.IdCliente
                                                                        inner join Produto_Servico ps on ps.IdServico = s.Id
                                                                        inner join Produto p on p.Id = ps.IdProduto";

                return (List<ServicoDto>)connection.Query<ServicoDto>(@"select s.*,
                                                                        m.Nome as NomeMecanico, 
                                                                        c.Nome as NomeCliente, 
                                                                        CONCAT(v.Marca, ' - ' ,v.Modelo) as NomeVeiculo,
                                                                        s.DataManutencao, 
                                                                        s.ValorTotal, 
                                                                            
                                                                            ps.IdServico Produtos_IdServico,
                                                                            ps.IdProduto Produtos_IdProduto,
                                                                            ps.QtdPecas Produtos_QtdPecas,
                                                                            ps.ValorProduto Produtos_ValorProduto,
                                                                            p.Nome as Produtos_NomeProduto

                                                                        from Servico s 
                                                                        inner join Mecanico m on s.IdMecanico = m.Id 
                                                                        inner join Veiculo v on s.IdVeiculo = v.Id 
                                                                        inner join Cliente c on c.Id = v.IdCliente
                                                                        inner join Produto_Servico ps on ps.IdServico = s.Id
                                                                        inner join Produto p on p.Id = ps.IdProduto");
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
                            var a = (List<Produto_Servico>)connection.Query<ServicoDto>($@"Delete from Produto_Servico where IdServico = {result}");
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
                            //var b = (List<Produto_Servico>)connection.Query<Produto_Servico>($@"Insert into Produto_Servico ( IdProduto, IdServico, QtdPecas, ValorProduto) values ({produto.IdProduto}, {produto.IdServico}, {produto.QuantidadePecas}, {produto.ValorProduto})");
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
