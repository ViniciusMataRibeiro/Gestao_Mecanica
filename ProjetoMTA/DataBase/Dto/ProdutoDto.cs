using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    [Table("Produto")]
    public class ProdutoDto
    {
        private readonly string conn = "SERVER=VINICIUSMR\\SQLEXPRESS;Database=Mechanical Technology Automotive;UID=sa;PWD=8520;";

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Quantidade { get; set; }
        public string ValorUni { get; set; }
        public string Descricao { get; set; }

        public List<ProdutoDto> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                return connection.GetAll<ProdutoDto>().ToList();
            }
        }

        public bool Insert(ProdutoDto entity)
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
                    var Result = connection.Delete(new ProdutoDto() { Id = id });
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
