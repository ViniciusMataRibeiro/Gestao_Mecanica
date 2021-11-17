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

namespace ProjetoMTA.UI.Serviços
{
    public partial class FormServicoConsulta : FormBaseConsulta
    {
        public FormServicoConsulta()
        {
            InitializeComponent();
        }
        private void FormServicoConsulta_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void carregarGrid()
        {

        }

        private void BtIncluir_Click(object sender, EventArgs e)
        {

        }

        
    }
}
