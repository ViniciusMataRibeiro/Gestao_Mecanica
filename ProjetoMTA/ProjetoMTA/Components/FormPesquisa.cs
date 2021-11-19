using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMTA.Components
{
    public partial class FormPesquisa : MetroFramework.Forms.MetroForm
    {
        public bool gravou = false;
        public FormPesquisa()
        {
            InitializeComponent();
        }

        public List<ProdutoDto> ListaProdutos { get; set; }

        public Produto_Servico Servico;

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Servico.IdProduto = (int)cbProduto.SelectedValue;
            Servico.QuantidadePecas = (int)ndpQuantidade.Value;
            Servico.ValorProduto = npdValorUn.Value;
            Servico.ValorTotal = npdTotal.Value;

            gravou = true;
            Close();
        }

        private void FormPesquisa_Load(object sender, EventArgs e)
        {
            carregarCombo();

            if (Servico == null)
            {
                Servico = new Produto_Servico();
                this.Text = "Inclusao";
            }
            else
            {
                this.Text = "Alteração";

                cbProduto.SelectedIndex = Servico.IdProduto;
                ndpQuantidade.Value = Servico.QuantidadePecas;
                npdValorUn.Value = Servico.ValorProduto;
                npdTotal.Value = Servico.ValorTotal;
            }
        }

        private void carregarCombo()
        {
            cbProduto.ValueMember = "Id";
            cbProduto.DisplayMember = "Nome";
            cbProduto.DataSource = ListaProdutos;
        }

        private void ndpQuantidade_ValueChanged(object sender, EventArgs e)
        {
            npdTotal.Value = npdValorUn.Value * ndpQuantidade.Value;
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var IdProduto = (int)cbProduto.SelectedValue;
            var Result = ListaProdutos.Where(w=> w.Id == IdProduto).ToList();
            npdValorUn.Value = Convert.ToDecimal(Result[0].ValorUn);
        }
    }
}
