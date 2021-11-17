using DataBase;
using ProjetoMTA.Base;
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
    }
}
