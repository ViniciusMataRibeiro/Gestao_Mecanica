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
        [Key]
        public int Id { get; set; }
        public int IdMecanico { get; set; }
        public int IdVeiculo { get; set; }
        public DateTime DataManutencao { get; set; }
        public decimal ValorOS { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorPago { get; set; }

        [Write(false)]
        public string NomeMecanico { get; set; }
        [Write(false)]
        public string NomeCliente { get; set; }
        [Write(false)]
        public string NomeVeiculo { get; set; }

        public List<ServicoDto> GetAll(string Banco)
        {
            using (SqlConnection connection = new SqlConnection(Banco))
            {
                return (List<ServicoDto>)connection.Query<ServicoDto>(@"select s.*,
                                                                        m.Nome as NomeMecanico, 
                                                                        c.Nome as NomeCliente, 
                                                                        CONCAT(v.Marca, ' - '  ) as NomeVeiculo,
                                                                        s.DataManutencao, 
                                                                        s.ValorTotal 
                                                                        from Servico s 
                                                                        inner join Mecanico m on s.IdMecanico = m.Id 
                                                                        inner join Veiculo v on s.IdVeiculo = v.Id 
                                                                        inner join Cliente c on c.Id = v.IdCliente");
            }//, v.Modelo
        }

        public bool Insert(ProdutoDto entity, string Banco)
        {
            try
            {
                if (entity.Id == 0)
                {
                    using (SqlConnection connection = new SqlConnection(Banco))
                    {
                        var Result = connection.Insert(entity);
                    }
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(Banco))
                    {
                        var Result = connection.Update(entity);
                    }
                }

                return true;
            }
            catch (Exception x)
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
            catch (Exception x)
            {
                return Sucesso;

            }
            return Sucesso;
        }
    }
}
