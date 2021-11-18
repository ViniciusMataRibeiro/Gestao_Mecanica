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

        public List<Produto_Servico> ListaProdutos { get; set; }

        public Produto_Servico Servico;

        private void btAdicionar_Click(object sender, EventArgs e)
        {

            Servico.IdProduto = cbProduto.SelectedIndex;
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
    }
}
