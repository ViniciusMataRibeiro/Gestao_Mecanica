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

namespace ProjetoMTA.UI.Veiculo
{
    public partial class FormVeiculocadastro : FormBaseCadastro
    {
        VeiculoDto veiculoDto;
        public VeiculoDto Dto { get; set; }
        public bool ErroAoGravar { get; set; }
        public FormVeiculocadastro(string Status, VeiculoDto dto)
        {
            InitializeComponent();
            this.Text = Status;

            Dto = dto;
        }
        private void FormVeiculocadastro_Load(object sender, EventArgs e)
        {
            CarregarCombo();
            LerDados(true);
        }

        private void CarregarCombo()
        {
            veiculoDto = new VeiculoDto();
            var Result = veiculoDto.GetCombo(GetConnectionString());
            if (Result != null)
            {
                cbCliente.DisplayMember = "Nome";
                cbCliente.ValueMember = "Id";
                cbCliente.DataSource = Result;
            }
            if (Dto.IdCliente != 0)
            {
                cbCliente.SelectedItem = Dto.IdCliente;
            }
        }

        private void BtGravar_Click(object sender, EventArgs e)
        {
            veiculoDto = new VeiculoDto();
            if (!VereficarDados())
                return;
            try
            {
                LerDados(false);
                Gravou = veiculoDto.Insert(Dto, GetConnectionString());
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

        private void btGravarContinuar_Click(object sender, EventArgs e)
        {
            veiculoDto = new VeiculoDto();
            if (!VereficarDados())
                return;
            LerDados(false);
            try
            {
                CriarNovo = Gravou = veiculoDto.Insert(Dto, GetConnectionString());
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

        
        private void LerDados(bool Load)
        {
            if (Load)
            {
                txtMarca.Text = Dto.Marca;
                txtModelo.Text = "Arrumar Banco";
                txtPlaca.Text = Dto.Placa;
            }
            else
            {
                Dto.Marca = txtMarca.Text;
                Dto.Modelo = txtModelo.Text;
                Dto.Placa = txtPlaca.Text;
                Dto.IdCliente = (int)cbCliente.SelectedValue;
            }
        }

        private bool VereficarDados()
        {
            bool Valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                errorProvider1.SetError(txtMarca, "Campo Obrigatorio!!");
                Valido = false;
            }
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                errorProvider1.SetError(txtPlaca, "Campo Obrigatorio!!");
                Valido = false;
            }
            if (cbCliente.SelectedItem == null)
            {
                errorProvider1.SetError(cbCliente, "Campo Obrigatorio!!");
                Valido = false;

            }
            //if (string.IsNullOrEmpty(txtModelo.Text))
            //{
            //    errorProvider1.SetError(txtModelo, "Campo Obrigatorio!!");
            //    Valido = false;
            //}
            return Valido;
        }
    }
}
