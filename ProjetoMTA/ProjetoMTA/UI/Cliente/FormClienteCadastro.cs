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
    public partial class FormClienteCadastro : FormBaseCadastro
    {
        ClienteDto clienteDto;
        public ClienteDto Dto { get; set; }
        public bool ErroAoGravar { get; set; }

        public FormClienteCadastro(string Status, ClienteDto dto)
        {
            InitializeComponent();
            this.Text = Status;

            Dto = dto;
        }
        private void FormClienteCadastro_Load(object sender, EventArgs e)
        {
            LerDados(true);
        }

        private void BtGravar_Click(object sender, EventArgs e)
        {
            clienteDto = new ClienteDto();
            if (!VereficarDados())
                return;
            try
            {
                LerDados(false);
                Gravou = clienteDto.Insert(Dto);
                if (Gravou)
                {
                    Close();
                    DisplayMessage("Cliente gravado com sucesso", "Salvo");
                }
            }
            catch (Exception x)
            {
                ErroAoGravar = true;
                DisplayMessage(x.Message, "Operação cancelada", OFIcon.Warning);
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
            var Rg = txtRg.Text.Replace(',', ' ').Replace('-', ' ').Trim();
            if (string.IsNullOrEmpty(Rg))
            {
                errorProvider1.SetError(txtRg, "Campo Obrigatorio!!");
                Valido = false;
            }
            var telefone = txtTelefone.Text.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Trim();
            if (string.IsNullOrEmpty(telefone))
            {
                errorProvider1.SetError(txtTelefone, "Campo Obrigatorio!!");
                Valido = false;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                errorProvider1.SetError(txtEndereco, "Campo Obrigatorio!!");
                Valido = false;
            }

            return Valido;
        }

        private void LerDados(bool Load)
        {
            if (Load)
            {
                txtNome.Text = Dto.Nome;
                txtCpf.Text = Dto.CPF;
                txtRg.Text = Dto.RG;
                txtTelefone.Text = Dto.Telefone;
                txtEmail.Text = Dto.Email;
                txtEndereco.Text = Dto.Endereco;
            }
            else
            {
                Dto.Nome = txtNome.Text;
                Dto.CPF = txtCpf.Text.Replace(',', '.');
                Dto.RG = txtRg.Text.Replace(',', '.');
                Dto.Telefone = txtTelefone.Text;
                Dto.Email = txtEmail.Text;
                Dto.Endereco = txtEndereco.Text;
            }
            
        }

        private void btGravarContinuar_Click(object sender, EventArgs e)
        {
            clienteDto = new ClienteDto();
            if (!VereficarDados())
                return;
            LerDados(false);
            try
            {
                CriarNovo = Gravou = clienteDto.Insert(Dto);
                if (Gravou)
                {
                    Close();
                    DisplayMessage("Cliente gravado com sucesso", "Salvo");
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
    }
}
