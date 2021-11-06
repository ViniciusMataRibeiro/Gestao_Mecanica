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
    [Table("Veiculo")]
    public class VeiculoDto
    {
        private readonly string conn = "SERVER=VINICIUSMR\\SQLEXPRESS;Database=Mechanical Technology Automotive;UID=sa;PWD=8520;";

        [Key]
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Marca { get; set; }
        public int TipoVeiculo { get; set; }
        public string Placa { get; set; }

        [Write(false)]
        public string Modelo { get; set; }

        [Write(false)]
        public string NomeClienteVeiculo { get; set; }

        public List<VeiculoDto> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                return (List<VeiculoDto>)connection.Query<VeiculoDto>("select v.*,c.Nome as NomeClienteVeiculo from Veiculo v inner join Cliente c on c.Id = v.IdCliente");
            }
        }

        public List<ClienteDto> GetCombo()
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                return (List<ClienteDto>)connection.Query<ClienteDto>("Select * from Cliente");
            }
        }

        public bool Insert(VeiculoDto entity)
        {
            try
            {
                if (entity.Id == 0)
                {
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        var Result = connection.Insert(entity);
                    }
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(conn))
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

        public bool Delete(int id)
        {
            var Sucesso = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    var Result = connection.Delete(new VeiculoDto() { Id = id });
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
