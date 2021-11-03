namespace ProjetoMTA.Base
{
    partial class FormBaseConsulta
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
            this.PainelOpcao = new MetroFramework.Controls.MetroPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtCadastro = new System.Windows.Forms.Button();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PainelOpcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelOpcao
            // 
            this.PainelOpcao.Controls.Add(this.button2);
            this.PainelOpcao.Controls.Add(this.button1);
            this.PainelOpcao.Controls.Add(this.BtCadastro);
            this.PainelOpcao.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelOpcao.HorizontalScrollbarBarColor = true;
            this.PainelOpcao.HorizontalScrollbarHighlightOnWheel = false;
            this.PainelOpcao.HorizontalScrollbarSize = 10;
            this.PainelOpcao.Location = new System.Drawing.Point(0, 0);
            this.PainelOpcao.Name = "PainelOpcao";
            this.PainelOpcao.Size = new System.Drawing.Size(800, 55);
            this.PainelOpcao.TabIndex = 0;
            this.PainelOpcao.UseCustomBackColor = true;
            this.PainelOpcao.UseCustomForeColor = true;
            this.PainelOpcao.UseStyleColors = true;
            this.PainelOpcao.UseWaitCursor = true;
            this.PainelOpcao.VerticalScrollbar = true;
            this.PainelOpcao.VerticalScrollbarBarColor = true;
            this.PainelOpcao.VerticalScrollbarHighlightOnWheel = true;
            this.PainelOpcao.VerticalScrollbarSize = 10;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button2.Image = global::ProjetoMTA.Properties.Resources.Delete_32;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(126, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 55);
            this.button2.TabIndex = 14;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.Image = global::ProjetoMTA.Properties.Resources.Change_32;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(63, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 55);
            this.button1.TabIndex = 13;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            // 
            // BtCadastro
            // 
            this.BtCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtCadastro.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtCadastro.FlatAppearance.BorderSize = 0;
            this.BtCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BtCadastro.Image = global::ProjetoMTA.Properties.Resources.Add_32;
            this.BtCadastro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtCadastro.Location = new System.Drawing.Point(0, 0);
            this.BtCadastro.Name = "BtCadastro";
            this.BtCadastro.Size = new System.Drawing.Size(63, 55);
            this.BtCadastro.TabIndex = 12;
            this.BtCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtCadastro.UseVisualStyleBackColor = true;
            this.BtCadastro.UseWaitCursor = true;
            // 
            // FormBaseConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PainelOpcao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaseConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaseConsulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PainelOpcao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private MetroFramework.Controls.MetroPanel PainelOpcao;
        private System.Windows.Forms.Button BtCadastro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}