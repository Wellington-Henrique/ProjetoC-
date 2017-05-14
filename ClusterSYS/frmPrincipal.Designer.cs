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
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoDeVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadCli = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadProd = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pedidoToolStripMenuItem,
            this.msCadastro,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoDeVendaToolStripMenuItem,
            this.orçamentoToolStripMenuItem});
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // pedidoDeVendaToolStripMenuItem
            // 
            this.pedidoDeVendaToolStripMenuItem.Name = "pedidoDeVendaToolStripMenuItem";
            this.pedidoDeVendaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.pedidoDeVendaToolStripMenuItem.Text = "Venda";
            this.pedidoDeVendaToolStripMenuItem.Click += new System.EventHandler(this.pedidoDeVendaToolStripMenuItem_Click);
            // 
            // orçamentoToolStripMenuItem
            // 
            this.orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            this.orçamentoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.orçamentoToolStripMenuItem.Text = "Orçamento";
            this.orçamentoToolStripMenuItem.Click += new System.EventHandler(this.orçamentoToolStripMenuItem_Click);
            // 
            // msCadastro
            // 
            this.msCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCadCli,
            this.msCadProd,
            this.usuarioToolStripMenuItem});
            this.msCadastro.Name = "msCadastro";
            this.msCadastro.Size = new System.Drawing.Size(66, 20);
            this.msCadastro.Text = "Cadastro";
            // 
            // msCadCli
            // 
            this.msCadCli.Name = "msCadCli";
            this.msCadCli.Size = new System.Drawing.Size(152, 22);
            this.msCadCli.Text = "Pessoa";
            this.msCadCli.Click += new System.EventHandler(this.msCadCli_Click);
            // 
            // msCadProd
            // 
            this.msCadProd.Name = "msCadProd";
            this.msCadProd.Size = new System.Drawing.Size(152, 22);
            this.msCadProd.Text = "Produto";
            this.msCadProd.Click += new System.EventHandler(this.msCadProd_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuarioToolStripMenuItem.Text = "Usuário";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // pnlBaseFrm
            // 
            this.pnlBaseFrm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlBaseFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaseFrm.Location = new System.Drawing.Point(0, 25);
            this.pnlBaseFrm.Name = "pnlBaseFrm";
            this.pnlBaseFrm.Size = new System.Drawing.Size(784, 536);
            this.pnlBaseFrm.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlBaseFrm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facsis";
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
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoDeVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
    }
}