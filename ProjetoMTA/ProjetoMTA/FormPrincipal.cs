using DataBase.Classes;
using ProjetoMTA.Base;
using ProjetoMTA.Components;
using ProjetoMTA.UI.Cliente;
using ProjetoMTA.UI.Mecanico;
using ProjetoMTA.UI.Produto;
using ProjetoMTA.UI.Relatorio;
using ProjetoMTA.UI.Serviços;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjetoMTA
{
    public partial class FormPrincipal : Form
    {
        private Button currentButton;
        private Random random;
        private int tempindex;
        private Form activeForm;
        private bool Checket = false;
        public FormPrincipal()
        {
            InitializeComponent();

            random = new Random();
            btClose.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelecionarThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempindex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempindex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelecionarThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitulo.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control controlBtn in metroPanel1.Controls)
            {
                if (controlBtn.GetType() == typeof(Button))
                {
                    controlBtn.BackColor = Color.FromArgb(224, 224, 224);
                    controlBtn.ForeColor = Color.Black;
                    controlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            metrolblTitulo.Text = childForm.Text;
        }
        
        private void btClose_Click(object sender, EventArgs e)
        {
            if (activeForm !=null)
                activeForm.Close();
            Reset();

            Checket = false;
            FormataButton(Checket, 4);
        }

        private void Reset()
        {
            DisableButton();
            metrolblTitulo.Text = "Tela Inicial";
            panelTitulo.BackColor = Color.FromArgb(0, 150, 136);
            currentButton = null;
            btClose.Visible = false;
        }
        private void btCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormataButton(bool Checket, int opcao)
        {
            //desabilitar buttons primarios
            BtCadastro.Visible = !Checket;
            BtCadastro.Enabled = !Checket;
            btServico.Visible = !Checket;
            btServico.Enabled = !Checket;
            btRelatorio.Visible = !Checket;
            btRelatorio.Enabled = !Checket;
            //
            //Habilitar Buttons Secundarios
            switch (opcao)
            {
                case 1://Cadastro
                    btProduto.Visible = Checket;
                    btProduto.Location = new Point(0, 170);
                    btMecanico.Visible = Checket;
                    btMecanico.Location = new Point(0, 248);
                    btCliente.Visible = Checket;
                    btCliente.Location = new Point(0, 326);
                    break;
                case 2://Servico

                    break;
                case 3://Relatorio

                    break;
                case 4://LimparTudo
                    btProduto.Visible = Checket;
                    btProduto.Location = new Point(0, 180);
                    btMecanico.Visible = Checket;
                    btMecanico.Location = new Point(0, 248);
                    btCliente.Visible = Checket;
                    btCliente.Location = new Point(0, 326);
                    break;
            }
            
        }
        private void btvoltar_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();

            Checket = false;
            FormataButton(Checket, 4);
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            Checket = true;
            FormataButton(Checket, 1);
        }
        private void btServico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btClose.Visible = true;
            openChildForm(new FormServicoConsulta(), sender);
        }

        private void btProduto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btClose.Visible = true;
            openChildForm(new FormProdutoConsulta(), sender);
        }

        private void btMecanico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btClose.Visible = true;
            openChildForm(new FormMecanicoConsulta(), sender);

        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            btClose.Visible = true;
            openChildForm(new FormClienteConsulta(), sender);
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
            ActivateButton(sender);
            FormRelatorioFiltro frm = new FormRelatorioFiltro();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
