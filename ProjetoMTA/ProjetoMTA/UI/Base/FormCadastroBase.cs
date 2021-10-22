using ProjetoMTA.Components;
using ProjetoMTA.UI.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMTA.UI.Base
{
    public partial class FormCadastroBase : FormBase
    {
        public FormCadastroBase()
        {
            InitializeComponent();
        }
        
        public bool Gravou { get; set; }
        public bool CriarNovo { get; set; }

        private void FormBaseCadastro_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (!Gravou)
            {
                if (OficinaMessageBox.Show("Deseja fechar essa tela?\nAs informações lançadas serão perdidas.", "Fechar Tela", OFButtons.YesNo, OFIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
