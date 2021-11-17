using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    [Table("Servico")]
    public class ServicoDto
    {
        [Key]
        public int Id { get; set; }
        public int IdMercanico { get; set; }
        public int IdVeiculo { get; set; }
        public DateTime DataManutencao { get; set; }
        public decimal ValorMaoDeObra { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorPago { get; set; }

    }
}
