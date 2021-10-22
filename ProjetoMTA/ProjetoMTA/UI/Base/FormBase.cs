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

namespace ProjetoMTA.UI.Base
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        public void DisplayMessage(string x, string titulo = "Alerta", OFIcon icon = OFIcon.Application)
        {
            OficinaMessageBox.Show(x, titulo);
        }

        public static T DirectCast<T>(object o, Type type) where T : class
        {
            if (!(type.IsInstanceOfType(o)))
            {
                throw new ArgumentException();
            }
            T value = o as T;
            if (value == null && o != null)
            {
                throw new InvalidCastException();
            }
            return value;
        }
    }
}
