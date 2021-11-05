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

namespace ProjetoMTA.UI.Cliente
{
    public partial class FormClienteConsulta : FormBaseConsulta
    {
        public FormClienteConsulta()
        {
            InitializeComponent();
        }

        private void BtIncluir_Click(object sender, EventArgs e)
        {
            FormClienteCadastro FCC = new FormClienteCadastro("incluir");
            FCC.ShowDialog();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            FormClienteCadastro FCC = new FormClienteCadastro("Alterar");
            FCC.ShowDialog();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void FormClienteConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
