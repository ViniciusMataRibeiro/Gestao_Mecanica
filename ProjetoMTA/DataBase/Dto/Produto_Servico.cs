using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Produto_Servico
    {
        public int IdProduto_Servico { get; set; }
        public int IdProduto { get; set; }
        public int IdServico { get; set; }
        public int QuantidadePecas { get; set; }
        public decimal ValorProduto { get; set; }
    }
}
