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
        private List<Produto_Servico> ListaProduto;

        public ServicoDto Dto { get; set; }
        public bool ErroAoGravar { get; set; }

        public FormServicoCadastro(string Status, ServicoDto dto)
        {
            InitializeComponent();
            this.Text = Status;

            Dto = dto;
        }

        private void FormServicoCadastro_Load(object sender, EventArgs e)
        {

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
    }
}
