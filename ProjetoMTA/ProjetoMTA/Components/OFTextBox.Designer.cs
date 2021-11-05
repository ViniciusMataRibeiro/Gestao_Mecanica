namespace ProjetoMTA.Components
{
    partial class OFTextBox
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(100, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // OFTextBox
            // 
            this.Size = new System.Drawing.Size(804, 20);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem menu_desativado;
        internal System.Windows.Forms.ToolStripMenuItem menu_iniciais;
        internal System.Windows.Forms.ToolStripMenuItem menu_maisculo;
        private bool pode;
        public TipoControle Tipo_Controle { get; set; }
        public byte CasasDecimais { get; set; }
        private CaseSensitive Case_Sensite { get; set; }
        internal System.Windows.Forms.ToolTip ToolTip1;

        public string SetText { get; set; }
        public string SetTag { get; set; }


        public enum CaseSensitive
        {
            desativado,
            iniciais,
            maiusculo
        }

        public enum TipoControle
        {
            texto,
            numerico
        }
    }
}