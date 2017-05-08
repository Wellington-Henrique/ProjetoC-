namespace ClusterSYS
{
    partial class frmPrincipal
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
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadCli = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadProd = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBaseFrm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 25);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem,
            this.msCadastro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // msCadastro
            // 
            this.msCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCadCli,
            this.msCadProd});
            this.msCadastro.Name = "msCadastro";
            this.msCadastro.Size = new System.Drawing.Size(66, 20);
            this.msCadastro.Text = "Cadastro";
            // 
            // msCadCli
            // 
            this.msCadCli.Name = "msCadCli";
            this.msCadCli.Size = new System.Drawing.Size(117, 22);
            this.msCadCli.Text = "Pessoa";
            this.msCadCli.Click += new System.EventHandler(this.msCadCli_Click);
            // 
            // msCadProd
            // 
            this.msCadProd.Name = "msCadProd";
            this.msCadProd.Size = new System.Drawing.Size(117, 22);
            this.msCadProd.Text = "Produto";
            this.msCadProd.Click += new System.EventHandler(this.msCadProd_Click);
            // 
            // pnlBaseFrm
            // 
            this.pnlBaseFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaseFrm.Location = new System.Drawing.Point(0, 25);
            this.pnlBaseFrm.Name = "pnlBaseFrm";
            this.pnlBaseFrm.Size = new System.Drawing.Size(784, 537);
            this.pnlBaseFrm.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnlBaseFrm);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmPrincipal";
            this.Text = "ClusterSYS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msCadastro;
        private System.Windows.Forms.ToolStripMenuItem msCadCli;
        private System.Windows.Forms.ToolStripMenuItem msCadProd;
        private System.Windows.Forms.Panel pnlBaseFrm;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
    }
}