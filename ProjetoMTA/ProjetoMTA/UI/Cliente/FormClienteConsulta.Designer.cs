namespace ProjetoMTA.UI.Cliente
{
    partial class FormClienteConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PainelOpcao = new MetroFramework.Controls.MetroPanel();
            this.btOpcao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.BtIncluir = new System.Windows.Forms.Button();
            this.Grid = new MetroFramework.Controls.MetroGrid();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridVeiculo = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeClienteVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceVeiculo = new System.Windows.Forms.BindingSource(this.components);
            this.PainelOpcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelOpcao
            // 
            this.PainelOpcao.Controls.Add(this.btOpcao);
            this.PainelOpcao.Controls.Add(this.button1);
            this.PainelOpcao.Controls.Add(this.btExcluir);
            this.PainelOpcao.Controls.Add(this.btAlterar);
            this.PainelOpcao.Controls.Add(this.BtIncluir);
            this.PainelOpcao.Cursor = System.Windows.Forms.Cursors.Default;
            this.PainelOpcao.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelOpcao.HorizontalScrollbarBarColor = true;
            this.PainelOpcao.HorizontalScrollbarHighlightOnWheel = false;
            this.PainelOpcao.HorizontalScrollbarSize = 10;
            this.PainelOpcao.Location = new System.Drawing.Point(0, 0);
            this.PainelOpcao.Name = "PainelOpcao";
            this.PainelOpcao.Size = new System.Drawing.Size(800, 55);
            this.PainelOpcao.TabIndex = 2;
            this.PainelOpcao.UseCustomBackColor = true;
            this.PainelOpcao.UseCustomForeColor = true;
            this.PainelOpcao.UseStyleColors = true;
            this.PainelOpcao.VerticalScrollbarBarColor = false;
            this.PainelOpcao.VerticalScrollbarHighlightOnWheel = false;
            this.PainelOpcao.VerticalScrollbarSize = 10;
            // 
            // btOpcao
            // 
            this.btOpcao.Cursor = System.Windows.Forms.Cursors.Default;
            this.btOpcao.Dock = System.Windows.Forms.DockStyle.Left;
            this.btOpcao.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btOpcao.FlatAppearance.BorderSize = 0;
            this.btOpcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btOpcao.Image = global::ProjetoMTA.Properties.Resources.Carro_32;
            this.btOpcao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btOpcao.Location = new System.Drawing.Point(204, 0);
            this.btOpcao.Name = "btOpcao";
            this.btOpcao.Size = new System.Drawing.Size(118, 55);
            this.btOpcao.TabIndex = 16;
            this.btOpcao.Text = "   Veiculos";
            this.btOpcao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOpcao.UseVisualStyleBackColor = true;
            this.btOpcao.Click += new System.EventHandler(this.btOpcao_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.Image = global::ProjetoMTA.Properties.Resources.Menu_32;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(189, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 55);
            this.button1.TabIndex = 15;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btExcluir.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btExcluir.Image = global::ProjetoMTA.Properties.Resources.Delete_32;
            this.btExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btExcluir.Location = new System.Drawing.Point(126, 0);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(63, 55);
            this.btExcluir.TabIndex = 14;
            this.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btAlterar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAlterar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btAlterar.Image = global::ProjetoMTA.Properties.Resources.Change_32;
            this.btAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btAlterar.Location = new System.Drawing.Point(63, 0);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(63, 55);
            this.btAlterar.TabIndex = 13;
            this.btAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // BtIncluir
            // 
            this.BtIncluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtIncluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtIncluir.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtIncluir.FlatAppearance.BorderSize = 0;
            this.BtIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BtIncluir.Image = global::ProjetoMTA.Properties.Resources.Add_32;
            this.BtIncluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtIncluir.Location = new System.Drawing.Point(0, 0);
            this.BtIncluir.Name = "BtIncluir";
            this.BtIncluir.Size = new System.Drawing.Size(63, 55);
            this.BtIncluir.TabIndex = 12;
            this.BtIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtIncluir.UseVisualStyleBackColor = true;
            this.BtIncluir.Click += new System.EventHandler(this.BtIncluir_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.NomeCliente,
            this.CPF,
            this.RG,
            this.Telefone});
            this.Grid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Grid.DataSource = this.bindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid.GridColor = System.Drawing.Color.White;
            this.Grid.Location = new System.Drawing.Point(0, 55);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(800, 373);
            this.Grid.TabIndex = 3;
            this.Grid.UseCustomBackColor = true;
            this.Grid.UseCustomForeColor = true;
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "Id";
            this.IdCliente.HeaderText = "Id";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "Nome";
            this.NomeCliente.HeaderText = "Nome";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "RG";
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // GridVeiculo
            // 
            this.GridVeiculo.AllowUserToResizeRows = false;
            this.GridVeiculo.AutoGenerateColumns = false;
            this.GridVeiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVeiculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridVeiculo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridVeiculo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVeiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NomeClienteVeiculo,
            this.Marca,
            this.Placa});
            this.GridVeiculo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GridVeiculo.DataSource = this.bindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridVeiculo.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridVeiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridVeiculo.EnableHeadersVisualStyles = false;
            this.GridVeiculo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridVeiculo.GridColor = System.Drawing.Color.White;
            this.GridVeiculo.Location = new System.Drawing.Point(0, 55);
            this.GridVeiculo.Name = "GridVeiculo";
            this.GridVeiculo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVeiculo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridVeiculo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridVeiculo.Size = new System.Drawing.Size(800, 373);
            this.GridVeiculo.TabIndex = 4;
            this.GridVeiculo.UseCustomBackColor = true;
            this.GridVeiculo.UseCustomForeColor = true;
            this.GridVeiculo.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NomeClienteVeiculo
            // 
            this.NomeClienteVeiculo.DataPropertyName = "NomeClienteVeiculo";
            this.NomeClienteVeiculo.HeaderText = "Proprietário";
            this.NomeClienteVeiculo.Name = "NomeClienteVeiculo";
            this.NomeClienteVeiculo.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // FormClienteConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridVeiculo);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.PainelOpcao);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormClienteConsulta";
            this.Text = "FormClienteConsulta";
            this.Load += new System.EventHandler(this.FormClienteConsulta_Load);
            this.Controls.SetChildIndex(this.PainelOpcao, 0);
            this.Controls.SetChildIndex(this.Grid, 0);
            this.Controls.SetChildIndex(this.GridVeiculo, 0);
            this.PainelOpcao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PainelOpcao;
        public System.Windows.Forms.Button btExcluir;
        public System.Windows.Forms.Button btAlterar;
        public System.Windows.Forms.Button BtIncluir;
        private MetroFramework.Controls.MetroGrid Grid;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btOpcao;
        private MetroFramework.Controls.MetroGrid GridVeiculo;
        private System.Windows.Forms.BindingSource bindingSourceVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeClienteVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
    }
}