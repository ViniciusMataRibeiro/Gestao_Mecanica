
namespace ProjetoMTA.UI.Produto
{
    partial class FormProdutoConsulta
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
            this.PainelOpcao = new MetroFramework.Controls.MetroPanel();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.BtIncluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Grid = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PainelOpcao.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
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
            this.PainelOpcao.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.Grid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 373);
            this.panel1.TabIndex = 2;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.AutoGenerateColumns = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Quantidade,
            this.ValorUni});
            this.Grid.DataSource = this.bindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(800, 373);
            this.Grid.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 101.5228F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 99.49239F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.FillWeight = 99.49239F;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // ValorUni
            // 
            this.ValorUni.DataPropertyName = "ValorUni";
            this.ValorUni.FillWeight = 99.49239F;
            this.ValorUni.HeaderText = "Valor Unitario";
            this.ValorUni.Name = "ValorUni";
            this.ValorUni.ReadOnly = true;
            // 
            // FormProdutoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PainelOpcao);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormProdutoConsulta";
            this.Text = "ProdutoConsulta";
            this.Load += new System.EventHandler(this.ProdutoConsulta_Load);
            this.Controls.SetChildIndex(this.PainelOpcao, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.PainelOpcao.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PainelOpcao;
        public System.Windows.Forms.Button btExcluir;
        public System.Windows.Forms.Button btAlterar;
        public System.Windows.Forms.Button BtIncluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSource;
        private MetroFramework.Controls.MetroGrid Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUni;
    }
}