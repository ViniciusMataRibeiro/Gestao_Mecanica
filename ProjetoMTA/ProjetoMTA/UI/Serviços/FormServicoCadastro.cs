using DataBase;
using ProjetoMTA.Base;
using ProjetoMTA.Components;
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
    public partial class FormServicoCadastro : FormBaseCadastro
    {
        public ServicoDto servicodto;

        public ServicoDto Dto { get; set; }
        public bool ErroAoGravar { get; set; }

        public List<ProdutoDto> ListaProduto = new List<ProdutoDto>();

        public FormServicoCadastro(string Status, ServicoDto dto)
        {
            InitializeComponent();
            this.Text = Status;

            Dto = dto;
        }

        private void FormServicoCadastro_Load(object sender, EventArgs e)
        {
            CarregarProduto();
            CarregarCliente();
            CarregarMecanico();
        }

        private void CarregarMecanico()
        {
            MecanicoDto mecanicoDto = new MecanicoDto();
            var Result = mecanicoDto.GetAll(GetConnectionString());
            if (Result != null)
            {
                cbMecanico.DisplayMember = "Nome";
                cbMecanico.ValueMember = "Id";
                cbMecanico.DataSource = Result;
                cbMecanico.SelectedItem = null;
            }
        }

        private void CarregarVeiculo(int IdCliente)
        {

            VeiculoDto veiculoDto = new VeiculoDto();
            var Result = veiculoDto.GetVeiculoCliente(GetConnectionString(), IdCliente);
            cbEquipamento.DisplayMember = "Marca";
            cbEquipamento.ValueMember = "Id";
            cbEquipamento.DataSource = Result;
            cbEquipamento.SelectedItem = null;
        }

        private void CarregarCliente()
        {
            VeiculoDto veiculoDto = new VeiculoDto();
            var Result = veiculoDto.GetCombo(GetConnectionString());
            if (Result != null)
            {
                cbCliente.DisplayMember = "Nome";
                cbCliente.ValueMember = "Id";
                cbCliente.DataSource = Result;
                cbCliente.SelectedItem = null;

            }
        }

        private void CarregarProduto()
        {
            ProdutoDto produtoDto = new ProdutoDto();
            ListaProduto = produtoDto.GetAll(GetConnectionString());
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            var fmr = new FormPesquisa();
            fmr.ListaProdutos = ListaProduto;
            fmr.ShowDialog();
            if (fmr.gravou)
            {
                bindingSource.Add(fmr.Servico);
            }
            fmr.Dispose();
        }

        private void btExcluirProduto_Click(object sender, EventArgs e)
        {
            var obj = (ServicoDto)GridProduto.CurrentRow?.DataBoundItem;
            if (obj != null)
                bindingSource.Remove(obj);
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCliente.SelectedValue != null)
            {
                CarregarVeiculo((int)cbCliente.SelectedValue);
            }
            else
            {
                CarregarVeiculo(0);
            }
        }
    }
}
