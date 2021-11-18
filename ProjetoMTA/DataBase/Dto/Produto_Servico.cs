using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    [Table("Produto_Servico")]
    public class Produto_Servico
    {
        [Key]
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdServico { get; set; }
        public int QuantidadePecas { get; set; }
        public decimal ValorProduto { get; set; }
        [Write(false)]
        public decimal ValorTotal { get; set; }
    }
}
