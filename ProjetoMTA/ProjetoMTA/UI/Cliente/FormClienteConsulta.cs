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

namespace ProjetoMTA.UI.Cliente
{
    public partial class FormClienteConsulta : FormBaseConsulta
    {
        public List<ClienteDto> a { get; set; }
        public FormClienteConsulta()
        {
            InitializeComponent();
            a = new List<ClienteDto>();
            InitGridBaseConsulta<ClienteDto>(Grid);
        }

        private void FormClienteConsulta_Load(object sender, EventArgs e)
        {
            ClienteDto Ob = new ClienteDto();
            Ob.NomeCliente = "VInicius";
            Ob.CPF = "15222569624";
            Ob.Telefone = "35999086268";
            
            a.Add(Ob);

            Ob = new ClienteDto();
            Ob.NomeCliente = "VInicius";
            Ob.CPF = "15222569624";
            Ob.Telefone = "35999086268";
            a.Add(Ob);
            SetDadosGrid(Grid, a);
            Grid.DataSource = a;

            //var obj = (ClienteDto)Grid.CurrentRow?.DataBoundItem;
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
    }
}
