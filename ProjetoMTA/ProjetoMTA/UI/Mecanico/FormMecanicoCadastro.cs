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
    public partial class FormMecanicoCadastro : FormBaseCadastro
    {
        public FormMecanicoCadastro(string Status)
        {
            InitializeComponent();
            this.Text = Status;
        }

        private void FormMecanicoCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
