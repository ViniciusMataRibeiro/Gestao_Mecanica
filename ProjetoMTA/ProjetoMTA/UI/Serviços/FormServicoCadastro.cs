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
        decimal CalculaValor = 0;

        public List<ProdutoDto> ListaProduto = new List<ProdutoDto>();
        public List<Produto_Servico> ListaProdutoFinal = new List<Produto_Servico>();


        public FormServicoCadastro(string Status, ServicoDto dto)
        {
            InitializeComponent();
            this.Text = Status;

            InitGridBaseConsulta<Produto_Servico>(Grid);

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
            npdValorOS_ValueChanged(null, null);
        }

        private void btExcluirProduto_Click(object sender, EventArgs e)
        {
            var obj = (Produto_Servico)Grid.CurrentRow?.DataBoundItem;
            if (obj != null)
                bindingSource.Remove(obj);
            npdValorOS_ValueChanged(null, null);
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
            var Verif = true;
            return Verif;
        }

        private void LerDados(bool v)
        {
            if (v)
            {
                if (Dto.Id != 0)
                {
                    DtServico.Value = Dto.DataManutencao;
                    npdValorOS.Value = Dto.ValorMaoDeObra;
                    npdTotal.Value = Dto.ValorTotal;
                    npdValorPago.Value = Dto.ValorPago;
                    cbMecanico.SelectedValue = Dto.IdMecanico;

                    //Trazer o Cliente pelo Veiculo
                    try
                    {
                        servicodto = new ServicoDto();
                        var Cliente = servicodto.GetClientePeloVeiculo(GetConnectionString(), Dto.IdVeiculo);
                        cbCliente.SelectedValue = Cliente[0].Id;
                        cbEquipamento.SelectedValue = Dto.IdVeiculo;
                        foreach (var item in Dto.Produtos)
                        {
                            item.ValorTotal = item.ValorProduto * item.QtdPecas;
                            bindingSource.Add(item);
                        }
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
                Dto.ValorMaoDeObra = npdValorOS.Value;
                Dto.ValorTotal = npdTotal.Value;
                Dto.ValorPago = npdValorPago.Value;
                foreach (Produto_Servico item in bindingSource.List)
                {
                    ListaProdutoFinal.Add(item);
                }
                Dto.Produtos = ListaProdutoFinal;
            }
        }

        private void npdValorOS_ValueChanged(object sender, EventArgs e)
        {
             List<decimal> ValorProduto = new List<decimal>();

            foreach (Produto_Servico item in bindingSource.List)
            {
                ValorProduto.Add(item.ValorTotal);
            }
            var Soma = ValorProduto.Sum();
            npdTotal.Value = npdValorOS.Value + Soma;
        }
    }
}
