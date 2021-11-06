namespace ProjetoMTA.UI.Veiculo
{
    partial class FormVeiculocadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtModelo = new MetroFramework.Controls.MetroTextBox();
            this.lblMarca = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPlaca = new MetroFramework.Controls.MetroTextBox();
            this.btGravarContinuar = new MetroFramework.Controls.MetroButton();
            this.BtGravar = new MetroFramework.Controls.MetroButton();
            this.btCancelar = new MetroFramework.Controls.MetroButton();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.txtMarca = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 118);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // txtModelo
            // 
            // 
            // 
            // 
            this.txtModelo.CustomButton.Image = null;
            this.txtModelo.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.txtModelo.CustomButton.Name = "";
            this.txtModelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModelo.CustomButton.TabIndex = 1;
            this.txtModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModelo.CustomButton.UseSelectable = true;
            this.txtModelo.CustomButton.Visible = false;
            this.txtModelo.Lines = new string[0];
            this.txtModelo.Location = new System.Drawing.Point(310, 25);
            this.txtModelo.MaxLength = 32767;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModelo.SelectedText = "";
            this.txtModelo.SelectionLength = 0;
            this.txtModelo.SelectionStart = 0;
            this.txtModelo.ShortcutsEnabled = true;
            this.txtModelo.Size = new System.Drawing.Size(176, 23);
            this.txtModelo.TabIndex = 40;
            this.txtModelo.UseSelectable = true;
            this.txtModelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(246, 27);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(58, 19);
            this.lblMarca.TabIndex = 36;
            this.lblMarca.Text = "Modelo:";
            this.lblMarca.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMarca.UseCustomBackColor = true;
            this.lblMarca.UseCustomForeColor = true;
            this.lblMarca.UseStyleColors = true;
            this.lblMarca.UseWaitCursor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 19);
            this.lblNome.TabIndex = 26;
            this.lblNome.Text = "Cliente:";
            this.lblNome.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNome.UseCustomBackColor = true;
            this.lblNome.UseCustomForeColor = true;
            this.lblNome.UseStyleColors = true;
            this.lblNome.UseWaitCursor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(31, 70);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Placa:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            this.metroLabel5.UseWaitCursor = true;
            // 
            // txtPlaca
            // 
            // 
            // 
            // 
            this.txtPlaca.CustomButton.Image = null;
            this.txtPlaca.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtPlaca.CustomButton.Name = "";
            this.txtPlaca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPlaca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPlaca.CustomButton.TabIndex = 1;
            this.txtPlaca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPlaca.CustomButton.UseSelectable = true;
            this.txtPlaca.CustomButton.Visible = false;
            this.txtPlaca.Lines = new string[0];
            this.txtPlaca.Location = new System.Drawing.Point(80, 70);
            this.txtPlaca.MaxLength = 32767;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.PasswordChar = '\0';
            this.txtPlaca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPlaca.SelectedText = "";
            this.txtPlaca.SelectionLength = 0;
            this.txtPlaca.SelectionStart = 0;
            this.txtPlaca.ShortcutsEnabled = true;
            this.txtPlaca.Size = new System.Drawing.Size(148, 23);
            this.txtPlaca.TabIndex = 33;
            this.txtPlaca.UseSelectable = true;
            this.txtPlaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPlaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btGravarContinuar
            // 
            this.btGravarContinuar.Location = new System.Drawing.Point(166, 184);
            this.btGravarContinuar.Name = "btGravarContinuar";
            this.btGravarContinuar.Size = new System.Drawing.Size(130, 45);
            this.btGravarContinuar.TabIndex = 49;
            this.btGravarContinuar.Text = "Gravar e Criar Novo";
            this.btGravarContinuar.UseSelectable = true;
            this.btGravarContinuar.Click += new System.EventHandler(this.btGravarContinuar_Click);
            // 
            // BtGravar
            // 
            this.BtGravar.Location = new System.Drawing.Point(302, 184);
            this.BtGravar.Name = "BtGravar";
            this.BtGravar.Size = new System.Drawing.Size(109, 45);
            this.BtGravar.TabIndex = 48;
            this.BtGravar.Text = "Gravar";
            this.BtGravar.UseSelectable = true;
            this.BtGravar.Click += new System.EventHandler(this.BtGravar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btCancelar.Location = new System.Drawing.Point(417, 184);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(109, 45);
            this.btCancelar.TabIndex = 47;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseSelectable = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(80, 27);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(148, 21);
            this.cbCliente.TabIndex = 41;
            // 
            // txtMarca
            // 
            // 
            // 
            // 
            this.txtMarca.CustomButton.Image = null;
            this.txtMarca.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.txtMarca.CustomButton.Name = "";
            this.txtMarca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMarca.CustomButton.TabIndex = 1;
            this.txtMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMarca.CustomButton.UseSelectable = true;
            this.txtMarca.CustomButton.Visible = false;
            this.txtMarca.Lines = new string[0];
            this.txtMarca.Location = new System.Drawing.Point(310, 70);
            this.txtMarca.MaxLength = 32767;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.ShortcutsEnabled = true;
            this.txtMarca.Size = new System.Drawing.Size(176, 23);
            this.txtMarca.TabIndex = 43;
            this.txtMarca.UseSelectable = true;
            this.txtMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(246, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Marca:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.UseWaitCursor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormVeiculocadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 243);
            this.Controls.Add(this.btGravarContinuar);
            this.Controls.Add(this.BtGravar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVeiculocadastro";
            this.Load += new System.EventHandler(this.FormVeiculocadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtModelo;
        private MetroFramework.Controls.MetroLabel lblMarca;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPlaca;
        private System.Windows.Forms.ComboBox cbCliente;
        private MetroFramework.Controls.MetroButton btGravarContinuar;
        private MetroFramework.Controls.MetroButton BtGravar;
        private MetroFramework.Controls.MetroButton btCancelar;
        private MetroFramework.Controls.MetroTextBox txtMarca;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}