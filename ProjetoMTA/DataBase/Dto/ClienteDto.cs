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
    [Table("Cliente")]
    public class ClienteDto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public List<ClienteDto> GetAll(string Banco)
        {
            using (SqlConnection connection = new SqlConnection(Banco))
            {
                return connection.GetAll<ClienteDto>().ToList();
            }
        }

        public List<VeiculoDto> GetVeiculoCliente(int IdCliente, string Banco)
        {
            using (SqlConnection connection = new SqlConnection(Banco))
            {
                return (List<VeiculoDto>)connection.Query<VeiculoDto>($"select * from Veiculo where IdCliente = {IdCliente}");
            }
        }

        public bool Insert(ClienteDto entity, string Banco)
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
                    var Result = connection.Delete(new ClienteDto() { Id = id });
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
