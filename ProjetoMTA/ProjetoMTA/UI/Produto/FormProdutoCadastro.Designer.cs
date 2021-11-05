namespace ProjetoMTA.UI.Produto
{
    partial class FormProdutoCadastro
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
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblContagemObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new ProjetoMTA.Components.OFTextBox(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btGravarContinuar = new MetroFramework.Controls.MetroButton();
            this.BtGravar = new MetroFramework.Controls.MetroButton();
            this.btCancelar = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.lblContagemObservacao);
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 218);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(424, 65);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown2.TabIndex = 44;
            // 
            // lblContagemObservacao
            // 
            this.lblContagemObservacao.AutoSize = true;
            this.lblContagemObservacao.Location = new System.Drawing.Point(455, 113);
            this.lblContagemObservacao.Name = "lblContagemObservacao";
            this.lblContagemObservacao.Size = new System.Drawing.Size(48, 13);
            this.lblContagemObservacao.TabIndex = 43;
            this.lblContagemObservacao.Text = "000/200";
            // 
            // txtObservacao
            // 
            this.txtObservacao.CasasDecimais = ((byte)(0));
            this.txtObservacao.Location = new System.Drawing.Point(25, 129);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.SaveLayout = false;
            this.txtObservacao.SetTag = null;
            this.txtObservacao.SetText = null;
            this.txtObservacao.Size = new System.Drawing.Size(478, 75);
            this.txtObservacao.TabIndex = 42;
            this.txtObservacao.Text = "OFTextBox";
            this.txtObservacao.Tipo_Controle = ProjetoMTA.Components.OFTextBox.TipoControle.texto;
            this.txtObservacao.TextChanged += new System.EventHandler(this.txtObservacao_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "Descrição:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            this.metroLabel2.UseWaitCursor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(354, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "Valor Un.:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(424, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 37;
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(80, 29);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(210, 23);
            this.txtNome.TabIndex = 25;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(337, 29);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "Quantidade:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            this.metroLabel4.UseWaitCursor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 19);
            this.lblNome.TabIndex = 26;
            this.lblNome.Text = "Nome:";
            this.lblNome.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNome.UseCustomBackColor = true;
            this.lblNome.UseCustomForeColor = true;
            this.lblNome.UseStyleColors = true;
            this.lblNome.UseWaitCursor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(36, 70);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Tipo:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            this.metroLabel5.UseWaitCursor = true;
            // 
            // btGravarContinuar
            // 
            this.btGravarContinuar.Location = new System.Drawing.Point(193, 284);
            this.btGravarContinuar.Name = "btGravarContinuar";
            this.btGravarContinuar.Size = new System.Drawing.Size(130, 45);
            this.btGravarContinuar.TabIndex = 40;
            this.btGravarContinuar.Text = "Gravar e Continuar";
            this.btGravarContinuar.UseSelectable = true;
            this.btGravarContinuar.Click += new System.EventHandler(this.btGravarContinuar_Click);
            // 
            // BtGravar
            // 
            this.BtGravar.Location = new System.Drawing.Point(329, 284);
            this.BtGravar.Name = "BtGravar";
            this.BtGravar.Size = new System.Drawing.Size(109, 45);
            this.BtGravar.TabIndex = 39;
            this.BtGravar.Text = "Gravar";
            this.BtGravar.UseSelectable = true;
            this.BtGravar.Click += new System.EventHandler(this.BtGravar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btCancelar.Location = new System.Drawing.Point(444, 284);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(109, 45);
            this.btCancelar.TabIndex = 38;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseSelectable = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FormProdutoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btGravarContinuar);
            this.Controls.Add(this.BtGravar);
            this.Controls.Add(this.btCancelar);
            this.Name = "FormProdutoCadastro";
            this.Load += new System.EventHandler(this.FormProdutoCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btGravarContinuar;
        private MetroFramework.Controls.MetroButton BtGravar;
        private MetroFramework.Controls.MetroButton btCancelar;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Components.OFTextBox txtObservacao;
        private System.Windows.Forms.Label lblContagemObservacao;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}