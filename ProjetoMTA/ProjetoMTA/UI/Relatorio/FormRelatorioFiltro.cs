using DataBase.Dto;
using ProjetoMTA.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMTA.UI.Relatorio
{
    public partial class FormRelatorioFiltro : FormBaseConsulta
    {
        RelatorioDto relatorioDto;

        public FormRelatorioFiltro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            relatorioDto = new RelatorioDto();
            var Result = relatorioDto.GetAll(GetConnectionString());
            Imprimir(Result);

        }

        private void Imprimir(List<RelatorioDto> result)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormFiltroCliente Frm = new FormFiltroCliente();
            Frm.ShowDialog();
            if (Frm.Gravou)
            {
                relatorioDto = new RelatorioDto();
                var Result = relatorioDto.GetServicoCliente(Frm.IdCliente ,GetConnectionString());
                Imprimir(Result);
            }
            Frm.Dispose();
        }
    }
}
