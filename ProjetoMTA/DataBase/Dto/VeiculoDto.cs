using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class VeiculoDto
    {
        public int IdVeiculo { get; set; }
        public int IdCliente { get; set; }
        public string MarcaVeiculo { get; set; }
        public int TipoVeiculo { get; set; }
        public string PlacaVeiculo { get; set; }
    }
}
