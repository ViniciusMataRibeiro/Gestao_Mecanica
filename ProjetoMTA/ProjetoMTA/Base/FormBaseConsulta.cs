using ProjetoMTA.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMTA.Base
{
    public partial class FormBaseConsulta : Form
    {
        public FormBaseConsulta()
        {
            InitializeComponent();
        }

        public void DisplayMessage(string x, string titulo = "Alerta", OFIcon icon = OFIcon.Application)
        {
            OficinaMessageBox.Show(x, titulo);
        }
        public void InitGridBaseConsulta<T>(DataGridView grid)
        {
            bindingSource.DataSource = new List<T>();
        }

        public static string GetConnectionString()
        {
            return "SERVER=VINICIUSMR\\SQLEXPRESS;Database=MTA;UID=sa;PWD=8520;";
        }
    }
}
