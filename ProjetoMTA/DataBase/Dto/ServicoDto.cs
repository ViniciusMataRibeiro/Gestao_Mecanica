using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class ServicoDto
    {
        public int IdServico { get; set; }
        public int IdMercanico { get; set; }
        public int IdVeiculo { get; set; }
        public DateTime DataManutencao { get; set; }
        public decimal ValorMaoDeObra { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorPago { get; set; }

    }
}
