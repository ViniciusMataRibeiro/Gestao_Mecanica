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
    public partial class FormProdutoCadastro : FormBaseCadastro
    {
        public FormProdutoCadastro(string Status)
        {
            InitializeComponent();
            this.Text = Status;
        }

        private void FormProdutoCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
