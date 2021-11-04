using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class ServicoDto
    {
        public int IdServico { get; set; }
        public int IdMercanico { get; set; }
        public int IdVeiculo { get; set; }
        public DateTime DataManutencao { get; set; }
        public float ValorMaoDeObra { get; set; }
        public float ValorTotal { get; set; }
        public float ValorPago { get; set; }

        public Servico() { }
    }
}
