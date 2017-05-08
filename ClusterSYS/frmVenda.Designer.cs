namespace ClusterSYS
{
    partial class frmVenda
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
            this.gbDadosVenda = new System.Windows.Forms.GroupBox();
            this.txtNVendedor = new System.Windows.Forms.TextBox();
            this.lblLegData = new System.Windows.Forms.Label();
            this.lblNVendedor = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lbItenPedido = new System.Windows.Forms.ListBox();
            this.gbDadosVenda.SuspendLayout();
            this.gbPedido.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosVenda
            // 
            this.gbDadosVenda.Controls.Add(this.txtNVendedor);
            this.gbDadosVenda.Controls.Add(this.lblLegData);
            this.gbDadosVenda.Controls.Add(this.lblNVendedor);
            this.gbDadosVenda.Controls.Add(this.txtCodCli);
            this.gbDadosVenda.Controls.Add(this.lblData);
            this.gbDadosVenda.Controls.Add(this.lblCodCli);
            this.gbDadosVenda.Location = new System.Drawing.Point(12, 12);
            this.gbDadosVenda.Name = "gbDadosVenda";
            this.gbDadosVenda.Size = new System.Drawing.Size(744, 70);
            this.gbDadosVenda.TabIndex = 30;
            this.gbDadosVenda.TabStop = false;
            this.gbDadosVenda.Text = "Dados da venda";
            // 
            // txtNVendedor
            // 
            this.txtNVendedor.Location = new System.Drawing.Point(91, 34);
            this.txtNVendedor.MaxLength = 3;
            this.txtNVendedor.Name = "txtNVendedor";
            this.txtNVendedor.Size = new System.Drawing.Size(75, 20);
            this.txtNVendedor.TabIndex = 29;
            // 
            // lblLegData
            // 
            this.lblLegData.AutoSize = true;
            this.lblLegData.Location = new System.Drawing.Point(179, 18);
            this.lblLegData.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblLegData.Name = "lblLegData";
            this.lblLegData.Size = new System.Drawing.Size(30, 13);
            this.lblLegData.TabIndex = 18;
            this.lblLegData.Text = "Data";
            // 
            // lblNVendedor
            // 
            this.lblNVendedor.AutoSize = true;
            this.lblNVendedor.Location = new System.Drawing.Point(88, 18);
            this.lblNVendedor.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblNVendedor.Name = "lblNVendedor";
            this.lblNVendedor.Size = new System.Drawing.Size(78, 13);
            this.lblNVendedor.TabIndex = 18;
            this.lblNVendedor.Text = "Cód. Vendedor";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(10, 34);
            this.txtCodCli.MaxLength = 3;
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(75, 20);
            this.txtCodCli.TabIndex = 29;
            // 
            // lblData
            // 
            this.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblData.Location = new System.Drawing.Point(179, 34);
            this.lblData.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(70, 20);
            this.lblData.TabIndex = 18;
            this.lblData.Text = "01/01/2017";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Location = new System.Drawing.Point(7, 18);
            this.lblCodCli.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(63, 13);
            this.lblCodCli.TabIndex = 18;
            this.lblCodCli.Text = "Cód. cliente";
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.lbItenPedido);
            this.gbPedido.Location = new System.Drawing.Point(13, 88);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(743, 365);
            this.gbPedido.TabIndex = 32;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Itens do pedido";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMain.Controls.Add(this.gbPedido);
            this.pnlMain.Controls.Add(this.gbDadosVenda);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(768, 499);
            this.pnlMain.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 40);
            this.panel1.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(650, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 25);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Location = new System.Drawing.Point(520, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 25);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lbItenPedido
            // 
            this.lbItenPedido.FormattingEnabled = true;
            this.lbItenPedido.Location = new System.Drawing.Point(9, 20);
            this.lbItenPedido.Name = "lbItenPedido";
            this.lbItenPedido.Size = new System.Drawing.Size(728, 342);
            this.lbItenPedido.TabIndex = 0;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 499);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(784, 537);
            this.Name = "frmVenda";
            this.Text = "frmVenda";
            this.gbDadosVenda.ResumeLayout(false);
            this.gbDadosVenda.PerformLayout();
            this.gbPedido.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDadosVenda;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNVendedor;
        private System.Windows.Forms.Label lblNVendedor;
        private System.Windows.Forms.Label lblLegData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ListBox lbItenPedido;
    }
}