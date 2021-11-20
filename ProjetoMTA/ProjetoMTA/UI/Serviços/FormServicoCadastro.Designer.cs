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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Grid = new MetroFramework.Controls.MetroGrid();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdPecas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMecanico = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbCliente = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbEquipamento = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DtServico = new MetroFramework.Controls.MetroDateTime();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.btGravarContinuar = new MetroFramework.Controls.MetroButton();
            this.BtGravar = new MetroFramework.Controls.MetroButton();
            this.btCancelar = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdValorPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdValorOS)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.DtServico);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(36, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(744, 580);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // npdValorPago
            // 
            this.npdValorPago.DecimalPlaces = 2;
            this.npdValorPago.Location = new System.Drawing.Point(647, 524);
            this.npdValorPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npdValorPago.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.npdValorPago.Name = "npdValorPago";
            this.npdValorPago.Size = new System.Drawing.Size(95, 22);
            this.npdValorPago.TabIndex = 54;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(545, 524);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 20);
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
            this.npdTotal.Location = new System.Drawing.Point(429, 524);
            this.npdTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npdTotal.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.npdTotal.Name = "npdTotal";
            this.npdTotal.Size = new System.Drawing.Size(95, 22);
            this.npdTotal.TabIndex = 52;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(325, 524);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(74, 20);
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
            this.npdValorOS.Location = new System.Drawing.Point(201, 524);
            this.npdValorOS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npdValorOS.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.npdValorOS.Name = "npdValorOS";
            this.npdValorOS.Size = new System.Drawing.Size(95, 22);
            this.npdValorOS.TabIndex = 50;
            this.npdValorOS.ValueChanged += new System.EventHandler(this.npdValorOS_ValueChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(25, 524);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 20);
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
            this.groupBox2.Controls.Add(this.Grid);
            this.groupBox2.Location = new System.Drawing.Point(21, 197);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(720, 303);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(380, 255);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(160, 37);
            this.btAdicionar.TabIndex = 45;
            this.btAdicionar.Text = "Adicionar Produto";
            this.btAdicionar.UseSelectable = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btExcluirProduto
            // 
            this.btExcluirProduto.BackColor = System.Drawing.Color.Transparent;
            this.btExcluirProduto.ForeColor = System.Drawing.Color.Transparent;
            this.btExcluirProduto.Location = new System.Drawing.Point(548, 255);
            this.btExcluirProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btExcluirProduto.Name = "btExcluirProduto";
            this.btExcluirProduto.Size = new System.Drawing.Size(164, 37);
            this.btExcluirProduto.TabIndex = 44;
            this.btExcluirProduto.Text = "Excluir Produto";
            this.btExcluirProduto.UseSelectable = true;
            this.btExcluirProduto.Click += new System.EventHandler(this.btExcluirProduto_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.AutoGenerateColumns = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeProduto,
            this.ValorProduto,
            this.QtdPecas,
            this.ValorTotal});
            this.Grid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Grid.DataSource = this.bindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid.GridColor = System.Drawing.Color.White;
            this.Grid.Location = new System.Drawing.Point(4, 19);
            this.Grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(712, 228);
            this.Grid.TabIndex = 5;
            this.Grid.UseCustomBackColor = true;
            this.Grid.UseCustomForeColor = true;
            // 
            // NomeProduto
            // 
            this.NomeProduto.DataPropertyName = "NomeProduto";
            this.NomeProduto.HeaderText = "Produto";
            this.NomeProduto.MinimumWidth = 6;
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            // 
            // ValorProduto
            // 
            this.ValorProduto.DataPropertyName = "ValorProduto";
            this.ValorProduto.HeaderText = "Valor Unitario";
            this.ValorProduto.MinimumWidth = 6;
            this.ValorProduto.Name = "ValorProduto";
            this.ValorProduto.ReadOnly = true;
            // 
            // QtdPecas
            // 
            this.QtdPecas.DataPropertyName = "QtdPecas";
            this.QtdPecas.HeaderText = "Quantidade";
            this.QtdPecas.MinimumWidth = 6;
            this.QtdPecas.Name = "QtdPecas";
            this.QtdPecas.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            this.ValorTotal.HeaderText = "Total";
            this.ValorTotal.MinimumWidth = 6;
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // cbMecanico
            // 
            this.cbMecanico.FormattingEnabled = true;
            this.cbMecanico.ItemHeight = 24;
            this.cbMecanico.Location = new System.Drawing.Point(545, 140);
            this.cbMecanico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMecanico.MaxDropDownItems = 10;
            this.cbMecanico.Name = "cbMecanico";
            this.cbMecanico.Size = new System.Drawing.Size(191, 30);
            this.cbMecanico.TabIndex = 33;
            this.cbMecanico.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(545, 113);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 20);
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
            this.cbCliente.ItemHeight = 24;
            this.cbCliente.Location = new System.Drawing.Point(21, 140);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCliente.MaxDropDownItems = 10;
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(191, 30);
            this.cbCliente.TabIndex = 31;
            this.cbCliente.UseSelectable = true;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 113);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 20);
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
            this.cbEquipamento.ItemHeight = 24;
            this.cbEquipamento.Location = new System.Drawing.Point(283, 140);
            this.cbEquipamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEquipamento.MaxDropDownItems = 10;
            this.cbEquipamento.Name = "cbEquipamento";
            this.cbEquipamento.Size = new System.Drawing.Size(203, 30);
            this.cbEquipamento.TabIndex = 29;
            this.cbEquipamento.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(283, 113);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 20);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Veiculo:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // DtServico
            // 
            this.DtServico.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtServico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtServico.Location = new System.Drawing.Point(21, 58);
            this.DtServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtServico.MinimumSize = new System.Drawing.Size(0, 30);
            this.DtServico.Name = "DtServico";
            this.DtServico.Size = new System.Drawing.Size(159, 30);
            this.DtServico.TabIndex = 27;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 20);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(110, 20);
            this.lblNome.TabIndex = 26;
            this.lblNome.Text = "Data do Serviço:";
            this.lblNome.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNome.UseCustomBackColor = true;
            this.lblNome.UseCustomForeColor = true;
            this.lblNome.UseStyleColors = true;
            // 
            // btGravarContinuar
            // 
            this.btGravarContinuar.Location = new System.Drawing.Point(309, 661);
            this.btGravarContinuar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGravarContinuar.Name = "btGravarContinuar";
            this.btGravarContinuar.Size = new System.Drawing.Size(173, 55);
            this.btGravarContinuar.TabIndex = 52;
            this.btGravarContinuar.Text = "Gravar e Continuar";
            this.btGravarContinuar.UseSelectable = true;
            this.btGravarContinuar.Click += new System.EventHandler(this.btGravarContinuar_Click);
            // 
            // BtGravar
            // 
            this.BtGravar.Location = new System.Drawing.Point(491, 661);
            this.BtGravar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtGravar.Name = "BtGravar";
            this.BtGravar.Size = new System.Drawing.Size(145, 55);
            this.BtGravar.TabIndex = 51;
            this.BtGravar.Text = "Gravar";
            this.BtGravar.UseSelectable = true;
            this.BtGravar.Click += new System.EventHandler(this.BtGravar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btCancelar.Location = new System.Drawing.Point(644, 661);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(145, 55);
            this.btCancelar.TabIndex = 50;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseSelectable = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormServicoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 731);
            this.Controls.Add(this.btGravarContinuar);
            this.Controls.Add(this.BtGravar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormServicoCadastro";
            this.Padding = new System.Windows.Forms.Padding(36, 91, 36, 31);
            this.Load += new System.EventHandler(this.FormServicoCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdValorPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdValorOS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime DtServico;
        private MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox cbMecanico;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbCliente;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbEquipamento;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid Grid;
        private MetroFramework.Controls.MetroButton btAdicionar;
        private MetroFramework.Controls.MetroButton btExcluirProduto;
        private MetroFramework.Controls.MetroButton btGravarContinuar;
        private MetroFramework.Controls.MetroButton BtGravar;
        private MetroFramework.Controls.MetroButton btCancelar;
        private System.Windows.Forms.NumericUpDown npdTotal;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.NumericUpDown npdValorOS;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.NumericUpDown npdValorPago;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdPecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}