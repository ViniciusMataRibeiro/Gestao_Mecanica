using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class ProdutoDto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public string TipoProduto { get; set; }
        public float ValorUni { get; set; }
        public string Descricao { get; set; }
    }
}
