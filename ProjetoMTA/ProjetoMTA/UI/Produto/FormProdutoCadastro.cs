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

namespace ProjetoMTA.UI.Produto
{
    public partial class FormProdutoCadastro : FormBaseCadastro
    {
        ProdutoDto produtoDto;
        public ProdutoDto Dto { get; set; }
        public bool ErroAoGravar { get; set; }

        public FormProdutoCadastro(string Status, ProdutoDto dto)
        {
            InitializeComponent();
            this.Text = Status;
            txtObservacao.Clear();

            Dto = dto;
        }

        private void FormProdutoCadastro_Load(object sender, EventArgs e)
        {
            LerDados(true);
        }


        private void txtObservacao_TextChanged(object sender, EventArgs e)
        {
            var contagem = txtObservacao.Text.Count();
            lblContagemObservacao.Text = contagem.ToString("000") + "/200";
        }

        private void BtGravar_Click(object sender, EventArgs e)
        {
            produtoDto = new ProdutoDto();

            if (!VereficarDados())
                return;
            try
            {
                LerDados(false);
                Gravou = produtoDto.Insert(Dto, GetConnectionString());
                if (Gravou)
                {
                    Close();
                    DisplayMessage("Equipamento gravado com sucesso", "Salvo");
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
            produtoDto = new ProdutoDto();
            if (!VereficarDados())
                return;
            try
            {
                CriarNovo = Gravou = produtoDto.Insert(Dto, GetConnectionString());
                if (Gravou)
                {
                    Close();
                    DisplayMessage("Equipamento gravado com sucesso", "Salvo");
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

        private void LerDados(bool Load)
        {
            if (Load)
            {
                if (Dto.Id != 0)
                {
                    txtNome.Text = Dto.Nome;
                    ndQuantidade.Value = decimal.Parse(Dto.Quantidade);
                    ndValorUn.Value = decimal.Parse(Dto.ValorUni);
                    txtObservacao.Text = Dto.Descricao;
                }
                
            }
            else
            {
                Dto.Nome = txtNome.Text;
                Dto.Quantidade = ndQuantidade.Value.ToString();
                Dto.ValorUni = ndValorUn.Value.ToString();
                Dto.Descricao = txtObservacao.Text;

            }
        }
        private bool VereficarDados()
        {
            bool Valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "Campo Obrigatorio!!");
                Valido = false;
            }
            if (ndValorUn.Value < 0)
            {
                errorProvider1.SetError(ndValorUn, "Campo não pode ser negativo");
                Valido = false;
            }
            if (ndValorUn.Value == 0)
            {
                errorProvider1.SetError(ndValorUn, "Campo Obrigatorio!!");
                Valido = false;
            }
            if (ndQuantidade.Value < 0)
            {
                errorProvider1.SetError(ndQuantidade, "Campo não pode ser negativo");
                Valido = false;
            }
            if (ndQuantidade.Value == 0)
            {
                errorProvider1.SetError(ndQuantidade, "Campo Obrigatorio!!");
                Valido = false;
            }

            return Valido;
        }
    }
}
