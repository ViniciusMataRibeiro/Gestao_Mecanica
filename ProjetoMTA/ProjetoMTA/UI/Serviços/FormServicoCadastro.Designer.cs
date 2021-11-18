namespace ProjetoMTA.UI.Serviços
{
    partial class FormServicoCadastro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.npdValorPago = new System.Windows.Forms.NumericUpDown();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.npdTotal = new System.Windows.Forms.NumericUpDown();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.npdValorOS = new System.Windows.Forms.NumericUpDown();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAdicionar = new MetroFramework.Controls.MetroButton();
            this.btExcluirProduto = new MetroFramework.Controls.MetroButton();
            this.GridProduto = new MetroFramework.Controls.MetroGrid();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMecanico = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbCliente = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbEquipamento = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.btGravarContinuar = new MetroFramework.Controls.MetroButton();
            this.BtGravar = new MetroFramework.Controls.MetroButton();
            this.btCancelar = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdValorPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdValorOS)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.npdValorPago);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.npdTotal);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.npdValorOS);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbMecanico);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.cbEquipamento);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroDateTime1);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 471);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // npdValorPago
            // 
            this.npdValorPago.DecimalPlaces = 2;
            this.npdValorPago.Enabled = false;
            this.npdValorPago.Location = new System.Drawing.Point(485, 426);
            this.npdValorPago.Name = "npdValorPago";
            this.npdValorPago.Size = new System.Drawing.Size(71, 20);
            this.npdValorPago.TabIndex = 54;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(409, 426);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 53;
            this.metroLabel4.Text = "Valor Pago:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // npdTotal
            // 
            this.npdTotal.DecimalPlaces = 2;
            this.npdTotal.Enabled = false;
            this.npdTotal.Location = new System.Drawing.Point(322, 426);
            this.npdTotal.Name = "npdTotal";
            this.npdTotal.Size = new System.Drawing.Size(71, 20);
            this.npdTotal.TabIndex = 52;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(244, 426);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 19);
            this.metroLabel6.TabIndex = 51;
            this.metroLabel6.Text = "Valor Total:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // npdValorOS
            // 
            this.npdValorOS.DecimalPlaces = 2;
            this.npdValorOS.Location = new System.Drawing.Point(151, 426);
            this.npdValorOS.Name = "npdValorOS";
            this.npdValorOS.Size = new System.Drawing.Size(71, 20);
            this.npdValorOS.TabIndex = 50;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(19, 426);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(126, 19);
            this.metroLabel5.TabIndex = 49;
            this.metroLabel5.Text = "Valor Mão de Obra:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.btAdicionar);
            this.groupBox2.Controls.Add(this.btExcluirProduto);
            this.groupBox2.Controls.Add(this.GridProduto);
            this.groupBox2.Location = new System.Drawing.Point(16, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 246);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(414, 207);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(120, 30);
            this.btAdicionar.TabIndex = 45;
            this.btAdicionar.Text = "Adcionar Produto";
            this.btAdicionar.UseSelectable = true;
            // 
            // btExcluirProduto
            // 
            this.btExcluirProduto.BackColor = System.Drawing.Color.Transparent;
            this.btExcluirProduto.ForeColor = System.Drawing.Color.Transparent;
            this.btExcluirProduto.Location = new System.Drawing.Point(285, 207);
            this.btExcluirProduto.Name = "btExcluirProduto";
            this.btExcluirProduto.Size = new System.Drawing.Size(123, 30);
            this.btExcluirProduto.TabIndex = 44;
            this.btExcluirProduto.Text = "Excluir Produto";
            this.btExcluirProduto.UseSelectable = true;
            // 
            // GridProduto
            // 
            this.GridProduto.AllowUserToResizeRows = false;
            this.GridProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeProduto,
            this.QuantidadeProduto,
            this.ValorUn,
            this.ValorTotal});
            this.GridProduto.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridProduto.EnableHeadersVisualStyles = false;
            this.GridProduto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridProduto.GridColor = System.Drawing.Color.White;
            this.GridProduto.Location = new System.Drawing.Point(3, 16);
            this.GridProduto.Name = "GridProduto";
            this.GridProduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProduto.Size = new System.Drawing.Size(534, 185);
            this.GridProduto.TabIndex = 5;
            this.GridProduto.UseCustomBackColor = true;
            this.GridProduto.UseCustomForeColor = true;
            this.GridProduto.Visible = false;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            // 
            // QuantidadeProduto
            // 
            this.QuantidadeProduto.HeaderText = "Quantidade";
            this.QuantidadeProduto.Name = "QuantidadeProduto";
            this.QuantidadeProduto.ReadOnly = true;
            // 
            // ValorUn
            // 
            this.ValorUn.HeaderText = "Valor Unitario";
            this.ValorUn.Name = "ValorUn";
            this.ValorUn.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // cbMecanico
            // 
            this.cbMecanico.FormattingEnabled = true;
            this.cbMecanico.ItemHeight = 23;
            this.cbMecanico.Location = new System.Drawing.Point(409, 114);
            this.cbMecanico.Name = "cbMecanico";
            this.cbMecanico.Size = new System.Drawing.Size(144, 29);
            this.cbMecanico.TabIndex = 33;
            this.cbMecanico.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(409, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Mecanico:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.ItemHeight = 23;
            this.cbCliente.Location = new System.Drawing.Point(16, 114);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(144, 29);
            this.cbCliente.TabIndex = 31;
            this.cbCliente.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Cliente:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // cbEquipamento
            // 
            this.cbEquipamento.FormattingEnabled = true;
            this.cbEquipamento.ItemHeight = 23;
            this.cbEquipamento.Location = new System.Drawing.Point(212, 114);
            this.cbEquipamento.Name = "cbEquipamento";
            this.cbEquipamento.Size = new System.Drawing.Size(153, 29);
            this.cbEquipamento.TabIndex = 29;
            this.cbEquipamento.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(212, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Equipamento:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(16, 47);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(120, 29);
            this.metroDateTime1.TabIndex = 27;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(106, 19);
            this.lblNome.TabIndex = 26;
            this.lblNome.Text = "Data do Serviço:";
            this.lblNome.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNome.UseCustomBackColor = true;
            this.lblNome.UseCustomForeColor = true;
            this.lblNome.UseStyleColors = true;
            // 
            // btGravarContinuar
            // 
            this.btGravarContinuar.Location = new System.Drawing.Point(232, 537);
            this.btGravarContinuar.Name = "btGravarContinuar";
            this.btGravarContinuar.Size = new System.Drawing.Size(130, 45);
            this.btGravarContinuar.TabIndex = 52;
            this.btGravarContinuar.Text = "Gravar e Continuar";
            this.btGravarContinuar.UseSelectable = true;
            // 
            // BtGravar
            // 
            this.BtGravar.Location = new System.Drawing.Point(368, 537);
            this.BtGravar.Name = "BtGravar";
            this.BtGravar.Size = new System.Drawing.Size(109, 45);
            this.BtGravar.TabIndex = 51;
            this.BtGravar.Text = "Gravar";
            this.BtGravar.UseSelectable = true;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btCancelar.Location = new System.Drawing.Point(483, 537);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(109, 45);
            this.btCancelar.TabIndex = 50;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseSelectable = true;
            // 
            // FormServicoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 594);
            this.Controls.Add(this.btGravarContinuar);
            this.Controls.Add(this.BtGravar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormServicoCadastro";
            this.Load += new System.EventHandler(this.FormServicoCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdValorPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdValorOS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox cbMecanico;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbCliente;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbEquipamento;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid GridProduto;
        private MetroFramework.Controls.MetroButton btAdicionar;
        private MetroFramework.Controls.MetroButton btExcluirProduto;
        private MetroFramework.Controls.MetroButton btGravarContinuar;
        private MetroFramework.Controls.MetroButton BtGravar;
        private MetroFramework.Controls.MetroButton btCancelar;
        private System.Windows.Forms.NumericUpDown npdTotal;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.NumericUpDown npdValorOS;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.NumericUpDown npdValorPago;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}