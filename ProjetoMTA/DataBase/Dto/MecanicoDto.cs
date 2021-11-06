using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    [Table("Mecanico")]
    public class MecanicoDto
    {
        private readonly string conn = "SERVER=VINICIUSMR\\SQLEXPRESS;Database=Mechanical Technology Automotive;UID=sa;PWD=8520;";

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        public List<MecanicoDto> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                return connection.GetAll<MecanicoDto>().ToList();
            }
        }

        public bool Insert(MecanicoDto entity)
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
                    var Result = connection.Delete(new MecanicoDto() { Id = id });
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
