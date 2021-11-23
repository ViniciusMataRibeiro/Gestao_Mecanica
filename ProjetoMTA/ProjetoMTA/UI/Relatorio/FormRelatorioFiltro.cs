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
using System.Drawing.Printing;

namespace ProjetoMTA.UI.Relatorio
{
    public partial class FormRelatorioFiltro : MetroFramework.Forms.MetroForm
    {
        RelatorioDto relatorioDto;

        public List<RelatorioDto> Result;


        public FormRelatorioFiltro()
        {
            this.WindowState = FormWindowState.Normal;
            InitializeComponent();
        }

        private int i;
        private void button1_Click(object sender, EventArgs e)
        {
            relatorioDto = new RelatorioDto();
            Result = new List<RelatorioDto>();
            Result = relatorioDto.GetAll("SERVER = VINICIUSMR\\SQLEXPRESS;Database=MTA;UID=sa;PWD=8520;");

            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "";
            pd.BeginPrint += Pd_BeginPrint;
            pd.PrintPage += Imprimir;
            

            pd.DefaultPageSettings.Landscape = true;

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();

        }

        private void Pd_BeginPrint(object sender, PrintEventArgs e)
        {
            i = 0;
        }

        private void Imprimir(object sender, PrintPageEventArgs ev)
        {
            float linhaPorPagina = 0;
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsqueda = 20;
            float margemSuperior = 20;
            float alturaFonte = 0;
            string linha = "";

            Font fonte = new Font("Arial", 14);
            alturaFonte = fonte.GetHeight(ev.Graphics);
            linhaPorPagina = Convert.ToInt32(ev.MarginBounds.Height / alturaFonte);

            linha = "Lista de Serviços";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);

            contador += 4;

            linha = "Cliente";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);

            linha = "Veiculo";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);

            linha = "Mecanico";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 400, posicaoVertical);
            
            linha = "Realizado em";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 650, posicaoVertical);

            linha = "Valor Total";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 865, posicaoVertical);

            linha = "Valor Pago";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 1000, posicaoVertical);

            contador += 1;

            linha = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);

            contador++;

            if (Result != null)
            {
                while (i < Result.Count && contador < linhaPorPagina)
                {
                    var item = Result[i];

                    linha = item.NomeCliente.ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);


                    linha = item.NomeVeiculo.ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 200, posicaoVertical);

                    linha = item.NomeMecanico.ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 400, posicaoVertical);

                    linha = item.DataManutencao.ToString("dd/MM/yyyy");
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 650, posicaoVertical);

                    linha = "R$ " + item.ValorTotal.ToString().Replace('.',',');
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 900, posicaoVertical);

                    linha = "R$ " + item.ValorPago.ToString().Replace('.', ','); ;
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 1035, posicaoVertical);

                    contador += 2;

                    i++;
                }
            }
            else MessageBox.Show("Não existe Serviços cadastrados!");
            if (contador > linhaPorPagina)
            {
                ev.HasMorePages = true;
            }
            else
            {
                ev.HasMorePages = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormFiltroCliente Frm = new FormFiltroCliente();
            Frm.ShowDialog();
            if (Frm.Gravou)
            {
                relatorioDto = new RelatorioDto();
                Result = new List<RelatorioDto>();
                Result = relatorioDto.GetServicoCliente(Frm.IdCliente , "SERVER = VINICIUSMR\\SQLEXPRESS;Database=MTA;UID=sa;PWD=8520;");

                PrintDocument pd = new PrintDocument();
                pd.DocumentName = "Serviços";
                pd.BeginPrint += Pd_BeginPrint;
                pd.PrintPage += Imprimir;

                pd.DefaultPageSettings.Landscape = true;

                PrintPreviewDialog ppd = new PrintPreviewDialog();
                ppd.Document = pd;
                ppd.ShowDialog();
            }
            Frm.Dispose();
        }
    }
}
