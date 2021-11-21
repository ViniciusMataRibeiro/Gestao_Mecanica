using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Dto
{
    public class RelatorioDto
    {
        public string NomeCliente { get; set; }
        public string NomeVeiculo { get; set; }
        public string NomeMecanico { get; set; }
        public string DataManutencao { get; set; }
        public string ValorTotal { get; set; }
        public string ValorPago { get; set; }


        public List<RelatorioDto> GetAll(string Banco)
        {
            using (SqlConnection connection = new SqlConnection(Banco))
            {
                return (List<RelatorioDto>)connection.Query<RelatorioDto>(@"select c.Nome as NomeCliente, CONCAT(v.Marca, ' - ', v.Modelo) as NomeVeiculo, m.Nome as NomeMecanico,
		                                                                            s.DataManutencao, s.ValorTotal, s.ValorPago
                                                                            from Servico s
                                                                            inner join Mecanico m on m.Id = s.IdMecanico
                                                                            inner join Veiculo v on v.Id = s.IdVeiculo
                                                                            inner join Cliente c on c.Id = v.idCliente");
            }
        }

        public List<RelatorioDto> GetServicoCliente(int IdCliente, string Banco)
        {
            using (SqlConnection connection = new SqlConnection(Banco))
            {
                return (List<RelatorioDto>)connection.Query<RelatorioDto>($@"select c.Nome as NomeCliente, CONCAT(v.Marca, ' - ', v.Modelo) as NomeVeiculo, m.Nome as NomeMecanico,
		                                                                            s.DataManutencao, s.ValorTotal, s.ValorPago
                                                                            from Servico s
                                                                            inner join Mecanico m on m.Id = s.IdMecanico
                                                                            inner join Veiculo v on v.Id = s.IdVeiculo
                                                                            inner join Cliente c on c.Id = v.idCliente
                                                                            where c.Id = {IdCliente}");
            }
        }
    }
}
