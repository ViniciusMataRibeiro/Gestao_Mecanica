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

namespace ProjetoMTA.UI.Serviços
{
    public partial class FormServicoConsulta : FormBaseConsulta
    {
        ServicoDto servicodto;
        public FormServicoConsulta()
        {
            InitializeComponent();
            InitGridBaseConsulta<ServicoDto>(Grid);
        }
        private void FormServicoConsulta_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void carregarGrid()
        {
            servicodto = new ServicoDto();
            var Result = servicodto.GetAll(GetConnectionString());
            if (Result != null)
            {
                Grid.DataSource = Result;
            }
        }

        private void BtIncluir_Click(object sender, EventArgs e)
        {

        }

        
    }
}
