using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMTA.Components
{
    public partial class OFTextBox : TextBox, IGaComponents
    {
        public OFTextBox()
        {
            InitializeComponent();
        }

        public OFTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public int SoLetras(int KeyAscii)
        {
            int functionReturnValue = 0;
            //Transformar letras minusculas em Maiúsculas
            KeyAscii = Convert.ToChar(Convert.ToChar(KeyAscii).ToString().ToUpper());
            // Intercepta um código ASCII recebido e admite somente letras
            if (("AÃÁBCÇDEÉÊFGHIÍJKLMNOPQRSTUÚVWXYZ").Contains(Convert.ToChar(KeyAscii)))
            {
                functionReturnValue = 0;
            }
            else
            {
                functionReturnValue = KeyAscii;
            }
            // teclas adicionais permitidas
            if (KeyAscii == 8)
                functionReturnValue = KeyAscii;
            // Backspace
            if (KeyAscii == 13)
                functionReturnValue = KeyAscii;
            // Enter
            if (KeyAscii == 32)
                functionReturnValue = KeyAscii;
            return functionReturnValue;
            // Espace
        }

        public short SoNumeros(short Keyascii)
        {
            short functionReturnValue = 0;
            if (!("1234567890,").Contains(Convert.ToChar(Keyascii)))
            {
                functionReturnValue = 0;
            }
            else
            {
                functionReturnValue = Keyascii;
            }
            switch (Keyascii)
            {
                case 8:
                    functionReturnValue = Keyascii;
                    break;
                case 13:
                    functionReturnValue = Keyascii;
                    break;
                case 32:
                    functionReturnValue = Keyascii;
                    break;
            }
            return functionReturnValue;
        }

        private string Maiuscula()
        {
            string functionReturnValue = null;
            functionReturnValue = this.Text.ToUpper();
            this.Select(this.Text.Length, 1);
            return functionReturnValue;
        }

        private string IniciasMaiuscula()
        {
            string functionReturnValue = null;
            if (pode == false)
            {
                functionReturnValue = "";
                return functionReturnValue;
            }
            string oldString = this.Text;
            string newString = "";
            bool upcase = true;
            foreach (var carac in oldString)
            {
                if (upcase == true)
                {
                    upcase = false;
                    newString += carac.ToString().ToUpper();
                }
                else
                {
                    newString += carac.ToString().ToLower();
                }
                if (carac.ToString() == " ")
                    upcase = true;
            }
            pode = false;
            functionReturnValue = newString;
            this.Select(this.Text.Length, 1);
            pode = true;
            return functionReturnValue;
        }

        private void OFTextBox_GotFocus(object sender, System.EventArgs e)
        {
            Font fonte = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Bold);
            this.Font = fonte;
            if (!File.Exists(Application.StartupPath + "CaseSensitive.xml"))
            {
                var dt = new DataTable("caseSensitive");
                dt.Columns.Add("Tipo");
                DataRow nr = dt.NewRow();
                nr["Tipo"] = "Desativado";
                dt.Rows.Add(nr);
                dt.WriteXml(Application.StartupPath + "CaseSensitive.xml");
                menu_desativado.Checked = true;
                return;
            }
            else
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Application.StartupPath + "CaseSensitive.xml");
                DataTable dt = ds.Tables[0];
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        switch (r["Tipo"].ToString())
                        {
                            case "Desativado":
                                menu_desativado.Checked = true;
                                menu_iniciais.Checked = false;
                                menu_maisculo.Checked = false;
                                Case_Sensite = CaseSensitive.desativado;
                                break;
                            case "Iniciais":
                                menu_desativado.Checked = false;
                                menu_iniciais.Checked = true;
                                menu_maisculo.Checked = false;
                                Case_Sensite = CaseSensitive.iniciais;
                                break;
                            case "Maiusculo":
                                menu_desativado.Checked = false;
                                menu_iniciais.Checked = false;
                                menu_maisculo.Checked = true;
                                Case_Sensite = CaseSensitive.maiusculo;
                                break;
                        }
                    }
                }
            }
            OFTextBox_TextChanged(sender, e);
        }

        private void OFTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.Tipo_Controle == TipoControle.numerico)
            {
                short KeyAscii = Convert.ToInt16(e.KeyChar);

                KeyAscii = Convert.ToInt16(SoNumeros(KeyAscii));


                if (KeyAscii == 0)
                {
                    e.Handled = true;
                }
                else if (this.Tipo_Controle == TipoControle.texto)
                {
                    KeyAscii = Convert.ToInt16(e.KeyChar);

                    KeyAscii = Convert.ToInt16(SoLetras(KeyAscii));


                    if (KeyAscii == 0)
                    {
                        e.Handled = true;

                    }
                }
            }
        }

        private void OFTextBox_LostFocus(object sender, System.EventArgs e)
        {
            //Font fonte = new Font("", 8, FontStyle.Regular);
            //this.Font = fonte;
            //Me.BackColor = SystemColors.Window

            this.ForeColor = GaGlobal.LostFocus;
            if (Tipo_Controle == TipoControle.numerico)
            {
                var value = Text.Length == 0 ? 0 : Convert.ToDecimal(Text);
                this.Text = value.ToString($"N{CasasDecimais}");
            }
        }

        private void OFTextBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Focus();
                //GaTextBox_GotFocus(sender, e)
                //GaTextBox_TextChanged(sender, e)
            }
        }

        private void OFTextBox_TextChanged(object sender, System.EventArgs e)
        {
            switch (Case_Sensite)
            {
                case  // ERROR: Case labels with binary operators are unsupported : Equality
        CaseSensitive.desativado:
                    break;
                case  // ERROR: Case labels with binary operators are unsupported : Equality
        CaseSensitive.iniciais:
                    this.Text = IniciasMaiuscula();
                    break;
                case  // ERROR: Case labels with binary operators are unsupported : Equality
        CaseSensitive.maiusculo:
                    this.Text = Maiuscula();
                    break;
            }
        }

        private void menu_desativado_Click(object sender, EventArgs e)
        {
            menu_desativado.Checked = true;
            menu_iniciais.Checked = false;
            menu_maisculo.Checked = false;
            Case_Sensite = CaseSensitive.desativado;
            DataTable dt = new DataTable("caseSensitive");
            dt.Columns.Add("Tipo");
            DataRow nr = dt.NewRow();
            nr["Tipo"] = "Desativado";
            dt.Rows.Add(nr);
            dt.WriteXml(Application.StartupPath + "CaseSensitive.xml");
            OFTextBox_TextChanged(sender, e);
        }

        private void menu_iniciais_Click(object sender, System.EventArgs e)
        {
            menu_desativado.Checked = false;
            menu_iniciais.Checked = true;
            menu_maisculo.Checked = false;
            Case_Sensite = CaseSensitive.iniciais;
            DataTable dt = new DataTable("caseSensitive");
            dt.Columns.Add("Tipo");
            DataRow nr = dt.NewRow();
            nr["Tipo"] = "Iniciais";
            dt.Rows.Add(nr);
            dt.WriteXml(Application.StartupPath + "CaseSensitive.xml");
            OFTextBox_TextChanged(sender, e);
        }

        private void menu_maisculo_Click(object sender, System.EventArgs e)
        {
            menu_desativado.Checked = false;
            menu_iniciais.Checked = false;
            menu_maisculo.Checked = true;
            Case_Sensite = CaseSensitive.maiusculo;
            DataTable dt = new DataTable("caseSensitive");
            dt.Columns.Add("Tipo");
            DataRow nr = dt.NewRow();
            nr["Tipo"] = "Maiusculo";
            dt.Rows.Add(nr);
            dt.WriteXml(Application.StartupPath + "CaseSensitive.xml");
            OFTextBox_TextChanged(sender, e);
        }

        public class Numericortext
        {


        }

        public bool SaveLayout { get; set; }
    }

    public interface IGaComponents
    {
        bool SaveLayout { get; set; }
    }

    public class GaGlobal
    {
        //public static string ThemeName = "Material"; //Material
        public static string ThemeName = "ControlDefault";

        //public static Color GotFocus = Color.Khaki;
        public static Color GotFocus = Color.FromArgb(255, 217, 135);

        public static Color LostFocus = Color.White;
        public static Color Background = Color.FromArgb(143, 216, 212);
    }
}
