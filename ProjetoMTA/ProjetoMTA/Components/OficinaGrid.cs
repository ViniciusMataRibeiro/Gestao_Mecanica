using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ProjetoMTA.Components
{
    public class OficinaGrid : MetroFramework.Controls.MetroGrid
    {
        public BindingSource BindingSource { get; set; }

        public OficinaGrid()
        {
            BindingSource = new BindingSource();
            DataSource = BindingSource;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
