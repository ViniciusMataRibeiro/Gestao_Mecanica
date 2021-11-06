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

namespace ProjetoMTA.UI.Cliente
{
    public partial class FormClienteConsulta : FormBaseConsulta
    {
        ClienteDto clientedto;
        public FormClienteConsulta()
        {
            InitializeComponent();
            InitGridBaseConsulta<ClienteDto>(Grid);
        }

        private  void FormClienteConsulta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            clientedto = new ClienteDto();
            var Result = clientedto.GetAll();
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
            var obj = (ClienteDto)Grid.CurrentRow?.DataBoundItem;
            if (obj == null) return;

            FormClienteCadastro frm = new FormClienteCadastro("Alterar", obj);
            frm.ShowDialog();
            if (frm.ErroAoGravar) CarregarGrid();
            else
            {
                bindingSource.ResetBindings(false);
            }
            frm.Dispose();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var obj = (ClienteDto)Grid.CurrentRow?.DataBoundItem;
            if (obj == null) return;

            clientedto = new ClienteDto();

            try
            {
                if (OficinaMessageBox.Show("Deseja realmente remover este Cliente?", "Delete", OFButtons.YesNo, OFIcon.Question) == DialogResult.No)
                    return;
                var deletou = clientedto.Delete(obj.Id);
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
            FormClienteCadastro frm = new FormClienteCadastro("incluir", new ClienteDto());
            frm.ShowDialog();
            if (frm.Gravou)
            {
                bindingSource.Add(frm.Dto);
                if (frm.CriarNovo) AdicionarDado();
                else bindingSource.ResetBindings(false);
            }
            frm.Dispose();
            CarregarGrid();
        }
    }
}
