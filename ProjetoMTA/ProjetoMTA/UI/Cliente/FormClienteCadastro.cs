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
        public ClienteDto Dto { get; set; }
        public bool ErroAoGravar { get; set; }

        public FormClienteCadastro(string Status, ClienteDto dto)
        {
            InitializeComponent();
            this.Text = Status;

            Dto = dto;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtGravar_Click(object sender, EventArgs e)
        {
            try
            {
                // Gravou = await Insert
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
            try
            {
                //CriarNovo = Gravou = await insert
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
    }
}
