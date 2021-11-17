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

namespace ProjetoMTA.UI.Mecanico
{
    public partial class FormMecanicoCadastro : FormBaseCadastro
    {
        MecanicoDto mecanicoDto;

        public MecanicoDto Dto { get; set; }
        public bool ErroAoGravar { get; set; }

        public FormMecanicoCadastro(string Status, MecanicoDto dto)
        {
            InitializeComponent();
            this.Text = Status;

            Dto = dto;
        }

        private void FormMecanicoCadastro_Load(object sender, EventArgs e)
        {
            LerDados(true);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtGravar_Click(object sender, EventArgs e)
        {
            mecanicoDto = new MecanicoDto();
            if (!VereficarDados())
                return;
            try
            {
                LerDados(false);
                Gravou = mecanicoDto.Insert(Dto, GetConnectionString());
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
            mecanicoDto = new MecanicoDto();
            if (!VereficarDados())
                return;
            try
            {
                LerDados(false);
                CriarNovo = Gravou = mecanicoDto.Insert(Dto, GetConnectionString());
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

        private void LerDados(bool Load)
        {
            if (Load)
            {
                txtNome.Text = Dto.Nome;
                txtCpf.Text = Dto.CPF;
                txtTelefone.Text = Dto.Telefone;
            }
            else
            {
                Dto.Nome = txtNome.Text;
                Dto.CPF = txtCpf.Text.Replace(',', '.');
                Dto.Telefone = txtTelefone.Text;
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
            var Cpf = txtCpf.Text.Replace(',', ' ').Replace('-', ' ').Trim();
            if (string.IsNullOrEmpty(Cpf))
            {
                errorProvider1.SetError(txtCpf, "Campo Obrigatorio!!");
                Valido = false;
            }
            var telefone = txtTelefone.Text.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Trim();
            if (string.IsNullOrEmpty(telefone))
            {
                errorProvider1.SetError(txtTelefone, "Campo Obrigatorio!!");
                Valido = false;
            }
            

            return Valido;
        }
    }
}
