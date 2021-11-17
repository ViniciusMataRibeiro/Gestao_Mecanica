namespace ProjetoMTA.UI.Serviços
{
    partial class FormServicoConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid = new MetroFramework.Controls.MetroGrid();
            this.PainelOpcao = new MetroFramework.Controls.MetroPanel();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.BtIncluir = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataManutencao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.PainelOpcao.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Mecanico,
            this.Cliente,
            this.Veiculo,
            this.DataManutencao,
            this.ValorTotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid.Location = new System.Drawing.Point(0, 55);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(800, 373);
            this.Grid.TabIndex = 8;
            // 
            // PainelOpcao
            // 
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
            this.PainelOpcao.TabIndex = 7;
            this.PainelOpcao.UseCustomBackColor = true;
            this.PainelOpcao.UseCustomForeColor = true;
            this.PainelOpcao.UseStyleColors = true;
            this.PainelOpcao.VerticalScrollbarBarColor = false;
            this.PainelOpcao.VerticalScrollbarHighlightOnWheel = false;
            this.PainelOpcao.VerticalScrollbarSize = 10;
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 61.06829F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Mecanico
            // 
            this.Mecanico.DataPropertyName = "NomeMecanico";
            this.Mecanico.FillWeight = 108.0909F;
            this.Mecanico.HeaderText = "Mecanico";
            this.Mecanico.Name = "Mecanico";
            this.Mecanico.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NomeCliente";
            this.Cliente.FillWeight = 108.0909F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Veiculo
            // 
            this.Veiculo.DataPropertyName = "NomeVeiculo";
            this.Veiculo.FillWeight = 108.0909F;
            this.Veiculo.HeaderText = "Veiculo";
            this.Veiculo.Name = "Veiculo";
            this.Veiculo.ReadOnly = true;
            // 
            // DataManutencao
            // 
            this.DataManutencao.DataPropertyName = "DataManutencao";
            this.DataManutencao.FillWeight = 108.0909F;
            this.DataManutencao.HeaderText = "Data da Manutenção";
            this.DataManutencao.Name = "DataManutencao";
            this.DataManutencao.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            this.ValorTotal.FillWeight = 108.0909F;
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // FormServicoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.PainelOpcao);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormServicoConsulta";
            this.Text = "FormServicoConsulta";
            this.Load += new System.EventHandler(this.FormServicoConsulta_Load);
            this.Controls.SetChildIndex(this.PainelOpcao, 0);
            this.Controls.SetChildIndex(this.Grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.PainelOpcao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid Grid;
        private MetroFramework.Controls.MetroPanel PainelOpcao;
        public System.Windows.Forms.Button btExcluir;
        public System.Windows.Forms.Button btAlterar;
        public System.Windows.Forms.Button BtIncluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mecanico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataManutencao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
    }
}