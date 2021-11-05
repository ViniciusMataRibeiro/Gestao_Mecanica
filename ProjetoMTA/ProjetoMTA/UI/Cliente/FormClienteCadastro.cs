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
    public partial class FormClienteCadastro : FormBaseCadastro
    {
        public FormClienteCadastro(string Status)
        {
            InitializeComponent();
            this.Text = Status;
        }
    }
}
