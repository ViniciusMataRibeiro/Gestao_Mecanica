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
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Quantidade { get; set; }
        public float ValorUn { get; set; }
        public string Descricao { get; set; }

        public List<ProdutoDto> GetAll(string Banco)
        {
            using (SqlConnection connection = new SqlConnection(Banco))
            {
                return connection.GetAll<ProdutoDto>().ToList();
            }
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
