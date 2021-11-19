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

        public decimal ValorTotalServico = 0;

        public ServicoDto Dto { get; set; }
        public bool ErroAoGravar { get; set; }

        public List<ProdutoDto> ListaProduto = new List<ProdutoDto>();

        public FormServicoCadastro(string Status, ServicoDto dto)
        {
            InitializeComponent();
            this.Text = Status;

            InitGridBaseConsulta<Produto_Servico>(GridProduto);

            Dto = dto;
        }
                                                                         
        private void FormServicoCadastro_Load(object sender, EventArgs e)
        {
            CarregarProduto();
            CarregarCliente();
            CarregarMecanico();
            LerDados(true);
        }
        #region CarregarCombos
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
        #endregion

        #region Produto
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

        #endregion 

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

        private void BtGravar_Click(object sender, EventArgs e)
        {
            servicodto = new ServicoDto();

            if (!VereficarDados())
                return;
            try
            {
                LerDados(false);
                Gravou = servicodto.Insert(Dto, GetConnectionString());
                if (Gravou)
                {
                    Close();
                    DisplayMessage("Serviço gravado com sucesso", "Salvo");
                }
            }
            catch (Exception x)
            {
                ErroAoGravar = true;
                DisplayMessage(x.Message, "Operação cancelada", OFIcon.Warning);
            }
        }

        private void btGravarContinuar_Click(object sender, EventArgs e)
        {
            servicodto = new ServicoDto();
            if (!VereficarDados())
                return;
            try
            {
                CriarNovo = Gravou = servicodto.Insert(Dto, GetConnectionString());
                if (Gravou)
                {
                    Close();
                    DisplayMessage("Serviço gravado com sucesso", "Salvo");
                }
            }
            catch (Exception x)
            {
                DisplayMessage(x.Message, "Operação cancelada", OFIcon.Warning);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool VereficarDados()
        {
            var Verif = false;

            return Verif;
        }

        private void LerDados(bool v)
        {
            if (v)
            {
                if (Dto.Id != 0)
                {
                    DtServico.Value = Dto.DataManutencao;
                    npdValorOS.Value = Dto.ValorOS;
                    ValorTotalServico = Dto.ValorTotal;
                    npdValorPago.Value = Dto.ValorPago;
                    cbEquipamento.SelectedItem = Dto.IdVeiculo;
                    cbMecanico.SelectedItem = Dto.IdMecanico;

                    //Trazer o Cliente pelo Veiculo
                    try
                    {
                        servicodto = new ServicoDto();
                        var Cliente = servicodto.GetClientePeloVeiculo(GetConnectionString(), Dto.IdVeiculo);
                        cbCliente.SelectedItem = Cliente.Id;
                    }
                    catch (Exception x)
                    {
                        DisplayMessage(x.Message, "Operação cancelada", OFIcon.Warning);
                    }
                }

            }
            else
            {
                Dto.IdMecanico = (int)cbMecanico.SelectedValue;
                Dto.IdVeiculo = (int)cbEquipamento.SelectedValue;
                Dto.DataManutencao = DtServico.Value;
                Dto.ValorOS = npdValorOS.Value;
                Dto.ValorTotal = ValorTotalServico;
                Dto.ValorPago = npdValorPago.Value;
            }
        }
    }
}
