using DataBase;
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

namespace ProjetoMTA.UI.Relatorio
{
    public partial class FormFiltroCliente : FormBaseCadastro
    {
        public int IdCliente;
        public FormFiltroCliente()
        {
            InitializeComponent();
        }

        private void BtImprimir_Click(object sender, EventArgs e)
        {
            if (cbCliente.SelectedValue != null)
            {
                IdCliente = (int)cbCliente.SelectedValue;
            }
            Gravou = true;
            Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormFiltroCliente_Load(object sender, EventArgs e)
        {
            ClienteDto clientedto = new ClienteDto();
            var Result = clientedto.GetAll(GetConnectionString());
            if (Result != null)
            {
                cbCliente.DisplayMember = "Nome";
                cbCliente.ValueMember = "Id";
                cbCliente.DataSource = Result;
            }
        }
    }
}
