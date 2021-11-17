
namespace ProjetoMTA
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.metroPanelLogo = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btCliente = new System.Windows.Forms.Button();
            this.btMecanico = new System.Windows.Forms.Button();
            this.btProduto = new System.Windows.Forms.Button();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btServico = new System.Windows.Forms.Button();
            this.BtCadastro = new System.Windows.Forms.Button();
            this.panelTitulo = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMaximizar = new System.Windows.Forms.Button();
            this.btCloseForm = new System.Windows.Forms.Button();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.metrolblTitulo = new MetroFramework.Controls.MetroLabel();
            this.PanelDesktop = new MetroFramework.Controls.MetroPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btvoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanelLogo.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanelLogo
            // 
            this.metroPanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanelLogo.Controls.Add(this.pictureBox1);
            this.metroPanelLogo.Controls.Add(this.metroLabel1);
            resources.ApplyResources(this.metroPanelLogo, "metroPanelLogo");
            this.metroPanelLogo.HorizontalScrollbarBarColor = true;
            this.metroPanelLogo.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelLogo.HorizontalScrollbarSize = 10;
            this.metroPanelLogo.Name = "metroPanelLogo";
            this.metroPanelLogo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanelLogo.UseCustomBackColor = true;
            this.metroPanelLogo.UseCustomForeColor = true;
            this.metroPanelLogo.UseStyleColors = true;
            this.metroPanelLogo.VerticalScrollbarBarColor = true;
            this.metroPanelLogo.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelLogo.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseMnemonic = false;
            // 
            // metroPanel1
            // 
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel1.Controls.Add(this.btCliente);
            this.metroPanel1.Controls.Add(this.btMecanico);
            this.metroPanel1.Controls.Add(this.btProduto);
            this.metroPanel1.Controls.Add(this.btRelatorio);
            this.metroPanel1.Controls.Add(this.btServico);
            this.metroPanel1.Controls.Add(this.BtCadastro);
            this.metroPanel1.Controls.Add(this.btvoltar);
            this.metroPanel1.Controls.Add(this.metroPanelLogo);
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btCliente
            // 
            this.btCliente.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btCliente.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btCliente, "btCliente");
            this.btCliente.Name = "btCliente";
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // btMecanico
            // 
            this.btMecanico.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btMecanico.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btMecanico, "btMecanico");
            this.btMecanico.Name = "btMecanico";
            this.btMecanico.UseVisualStyleBackColor = true;
            this.btMecanico.Click += new System.EventHandler(this.btMecanico_Click);
            // 
            // btProduto
            // 
            this.btProduto.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btProduto.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btProduto, "btProduto");
            this.btProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btProduto.Name = "btProduto";
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Click += new System.EventHandler(this.btProduto_Click);
            // 
            // btRelatorio
            // 
            resources.ApplyResources(this.btRelatorio, "btRelatorio");
            this.btRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btRelatorio.FlatAppearance.BorderSize = 0;
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.UseVisualStyleBackColor = true;
            // 
            // btServico
            // 
            resources.ApplyResources(this.btServico, "btServico");
            this.btServico.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btServico.FlatAppearance.BorderSize = 0;
            this.btServico.Name = "btServico";
            this.btServico.UseVisualStyleBackColor = true;
            this.btServico.Click += new System.EventHandler(this.btServico_Click);
            // 
            // BtCadastro
            // 
            resources.ApplyResources(this.BtCadastro, "BtCadastro");
            this.BtCadastro.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtCadastro.FlatAppearance.BorderSize = 0;
            this.BtCadastro.Name = "BtCadastro";
            this.BtCadastro.UseVisualStyleBackColor = true;
            this.BtCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTitulo.Controls.Add(this.panel1);
            this.panelTitulo.Controls.Add(this.btClose);
            this.panelTitulo.Controls.Add(this.metrolblTitulo);
            resources.ApplyResources(this.panelTitulo, "panelTitulo");
            this.panelTitulo.HorizontalScrollbarBarColor = true;
            this.panelTitulo.HorizontalScrollbarHighlightOnWheel = false;
            this.panelTitulo.HorizontalScrollbarSize = 10;
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.UseCustomBackColor = true;
            this.panelTitulo.UseCustomForeColor = true;
            this.panelTitulo.UseStyleColors = true;
            this.panelTitulo.VerticalScrollbarBarColor = true;
            this.panelTitulo.VerticalScrollbarHighlightOnWheel = false;
            this.panelTitulo.VerticalScrollbarSize = 10;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btMaximizar);
            this.panel1.Controls.Add(this.btCloseForm);
            this.panel1.Controls.Add(this.btMinimizar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btMaximizar
            // 
            this.btMaximizar.AllowDrop = true;
            resources.ApplyResources(this.btMaximizar, "btMaximizar");
            this.btMaximizar.FlatAppearance.BorderSize = 0;
            this.btMaximizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btMaximizar.Name = "btMaximizar";
            this.btMaximizar.UseVisualStyleBackColor = true;
            this.btMaximizar.Click += new System.EventHandler(this.btMaximizar_Click);
            // 
            // btCloseForm
            // 
            this.btCloseForm.AllowDrop = true;
            resources.ApplyResources(this.btCloseForm, "btCloseForm");
            this.btCloseForm.FlatAppearance.BorderSize = 0;
            this.btCloseForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btCloseForm.Name = "btCloseForm";
            this.btCloseForm.UseVisualStyleBackColor = true;
            this.btCloseForm.Click += new System.EventHandler(this.btCloseForm_Click);
            // 
            // btMinimizar
            // 
            this.btMinimizar.AllowDrop = true;
            resources.ApplyResources(this.btMinimizar, "btMinimizar");
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.UseVisualStyleBackColor = true;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // metrolblTitulo
            // 
            resources.ApplyResources(this.metrolblTitulo, "metrolblTitulo");
            this.metrolblTitulo.ForeColor = System.Drawing.Color.White;
            this.metrolblTitulo.Name = "metrolblTitulo";
            this.metrolblTitulo.Style = MetroFramework.MetroColorStyle.White;
            this.metrolblTitulo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metrolblTitulo.UseCustomBackColor = true;
            this.metrolblTitulo.UseCustomForeColor = true;
            this.metrolblTitulo.UseMnemonic = false;
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.PanelDesktop, "PanelDesktop");
            this.PanelDesktop.HorizontalScrollbarBarColor = true;
            this.PanelDesktop.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelDesktop.HorizontalScrollbarSize = 10;
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.VerticalScrollbarBarColor = true;
            this.PanelDesktop.VerticalScrollbarHighlightOnWheel = false;
            this.PanelDesktop.VerticalScrollbarSize = 10;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // btClose
            // 
            resources.ApplyResources(this.btClose, "btClose");
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.Name = "btClose";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btvoltar
            // 
            resources.ApplyResources(this.btvoltar, "btvoltar");
            this.btvoltar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btvoltar.FlatAppearance.BorderSize = 0;
            this.btvoltar.Image = global::ProjetoMTA.Properties.Resources.arrow_left_icon;
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.metroPanelLogo.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PanelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanelLogo;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel panelTitulo;
        private MetroFramework.Controls.MetroLabel metrolblTitulo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel PanelDesktop;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btCloseForm;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Button btMaximizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btServico;
        private System.Windows.Forms.Button BtCadastro;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Button btMecanico;
        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

