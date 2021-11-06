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
    public partial class FormProdutoConsulta : FormBaseConsulta
    {
        ProdutoDto produtoDto;
        public FormProdutoConsulta()
        {
            InitializeComponent();
            InitGridBaseConsulta<ProdutoDto>(Grid);
        }

        private void ProdutoConsulta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            produtoDto = new ProdutoDto();
            var Result = produtoDto.GetAll();
            if (Result != null)
            {
                Grid.DataSource = Result;
            }
        }

        private void BtIncluir_Click(object sender, EventArgs e)
         {
            AdicionarDado();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            var obj = (ProdutoDto)Grid.CurrentRow?.DataBoundItem;
            if (obj == null) return;

            FormProdutoCadastro frm = new FormProdutoCadastro("Alterar", obj);
            frm.ShowDialog();
            if (frm.ErroAoGravar) CarregarGrid();
            else
            {
                bindingSource.ResetBindings(false);
            }
            frm.Dispose();
            CarregarGrid();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var obj = (ProdutoDto)Grid.CurrentRow?.DataBoundItem;
            if (obj == null) return;

            produtoDto = new ProdutoDto();

            try
            {
                if (OficinaMessageBox.Show("Deseja realmente remover este Cliente?", "Delete", OFButtons.YesNo, OFIcon.Question) == DialogResult.No)
                    return;
                var deletou = produtoDto.Delete(obj.Id);
                if (deletou)
                {
                    bindingSource.Remove(obj);
                    DisplayMessage("Equipamento removido com sucesso", "Dado deletado");
                }
                else
                {
                    throw new Exception("Não foi possível deletar equipamento");
                }
            }
            catch (Exception x)
            {
                DisplayMessage(x.Message, "Problema ao deletar registro", OFIcon.Warning);
            }
            finally
            {
                CarregarGrid();
            }
        }

        private void AdicionarDado()
        {
            FormProdutoCadastro frm = new FormProdutoCadastro("incluir", new ProdutoDto());
            frm.ShowDialog();
            if (frm.Gravou)
            {
                bindingSource.Add(frm.Dto);
                if (frm.CriarNovo)
                {
                    CarregarGrid();
                    AdicionarDado();
                }
                else bindingSource.ResetBindings(false);
            }
            frm.Dispose();
            CarregarGrid();
        }
    }
}
