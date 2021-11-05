using DataBase;
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

namespace ProjetoMTA.UI.Produto
{
    public partial class FormProdutoConsulta : FormBaseConsulta
    {
        public FormProdutoConsulta()
        {
            InitializeComponent();
        }

        private void ProdutoConsulta_Load(object sender, EventArgs e)
        {
           
        }

        private void BtIncluir_Click(object sender, EventArgs e)
        {
            FormProdutoCadastro FPC = new FormProdutoCadastro("Incluir");
            FPC.ShowDialog();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            FormProdutoCadastro FPC = new FormProdutoCadastro("Alterar");
            FPC.ShowDialog();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        
    }
}
