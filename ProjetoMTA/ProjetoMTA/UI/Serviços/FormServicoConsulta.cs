using DataBase;
using ProjetoMTA.Base;
using ProjetoMTA.Components;
using ProjetoMTA.UI.Cliente;
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
    public partial class FormServicoConsulta : FormBaseConsulta
    {
        ServicoDto servicodto;
        public FormServicoConsulta()
        {
            InitializeComponent();
            InitGridBaseConsulta<ServicoDto>(Grid);
        }
        private void FormServicoConsulta_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }
        private void AdicionarDado()
        {
            FormServicoCadastro frm = new FormServicoCadastro("incluir", new ServicoDto());
            frm.ShowDialog();
            if (frm.Gravou)
            {
                bindingSource.Add(frm.Dto);
                if (frm.CriarNovo)
                {
                    carregarGrid();
                    AdicionarDado();
                }
                else bindingSource.ResetBindings(false);
            }
            frm.Dispose();
            carregarGrid();
        }
        private void carregarGrid()
        {
            servicodto = new ServicoDto();
            var Result = servicodto.GetAll(GetConnectionString());
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
            var obj = (ServicoDto)Grid.CurrentRow?.DataBoundItem;
            if (obj == null) return;

            FormServicoCadastro frm = new FormServicoCadastro("Alterar", obj);
            frm.ShowDialog();
            if (frm.ErroAoGravar) carregarGrid();
            else
            {
                bindingSource.ResetBindings(false);
            }
            frm.Dispose();
            carregarGrid();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var obj = (ServicoDto)Grid.CurrentRow?.DataBoundItem;
            if (obj == null) return;

            servicodto = new ServicoDto();

            try
            {
                if (OficinaMessageBox.Show("Deseja realmente remover este Serviço?", "Delete", OFButtons.YesNo, OFIcon.Question) == DialogResult.No)
                    return;
                var deletou = true;//ServicoDto.Delete(obj.Id, GetConnectionString());
                if (deletou)
                {
                    bindingSource.Remove(obj);
                    DisplayMessage("Serviço removido com sucesso", "Dado deletado");
                }
                else
                {
                    throw new Exception("Não foi possível deletar Serviço");
                }
            }
            catch (Exception x)
            {
                DisplayMessage(x.Message, "Problema ao deletar registro", OFIcon.Warning);
            }
            finally
            {
                carregarGrid();
            }
        }
    }
}
