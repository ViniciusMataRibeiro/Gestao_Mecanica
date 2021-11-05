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

namespace ProjetoMTA.UI.Mecanico
{
    public partial class FormMecanicoConsulta : FormBaseConsulta
    {
        public FormMecanicoConsulta()
        {
            InitializeComponent();
        }
        private void FormMecanicoConsulta_Load(object sender, EventArgs e)
        {

        }
        private void BtIncluir_Click(object sender, EventArgs e)
        {
            FormMecanicoCadastro FMC = new FormMecanicoCadastro("Incluir");
            FMC.ShowDialog();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            FormMecanicoCadastro FMC = new FormMecanicoCadastro("Alterar");
            FMC.ShowDialog();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
