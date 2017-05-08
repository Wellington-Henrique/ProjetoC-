namespace ClusterSYS
{
    partial class frmCadPro
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.R4 = new System.Windows.Forms.Panel();
            this.gbCusto = new System.Windows.Forms.GroupBox();
            this.txtCustoVenda = new System.Windows.Forms.TextBox();
            this.lblCustoVenda = new System.Windows.Forms.Label();
            this.txtCustoMedio = new System.Windows.Forms.TextBox();
            this.lblCustoMedio = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblUniMed = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbMedida = new System.Windows.Forms.ComboBox();
            this.cbFornecedores = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbLocacao = new System.Windows.Forms.ComboBox();
            this.lblLocacao = new System.Windows.Forms.Label();
            this.R4.SuspendLayout();
            this.gbCusto.SuspendLayout();
            this.gbProduto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Location = new System.Drawing.Point(520, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 25);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(650, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 25);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // R4
            // 
            this.R4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.R4.Controls.Add(this.gbCusto);
            this.R4.Controls.Add(this.gbProduto);
            this.R4.Controls.Add(this.panel1);
            this.R4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.R4.Location = new System.Drawing.Point(0, 0);
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(768, 499);
            this.R4.TabIndex = 8;
            // 
            // gbCusto
            // 
            this.gbCusto.Controls.Add(this.txtCustoVenda);
            this.gbCusto.Controls.Add(this.lblCustoVenda);
            this.gbCusto.Controls.Add(this.txtCustoMedio);
            this.gbCusto.Controls.Add(this.lblCustoMedio);
            this.gbCusto.Controls.Add(this.txtCusto);
            this.gbCusto.Controls.Add(this.lblCusto);
            this.gbCusto.Location = new System.Drawing.Point(12, 243);
            this.gbCusto.Name = "gbCusto";
            this.gbCusto.Size = new System.Drawing.Size(744, 64);
            this.gbCusto.TabIndex = 1;
            this.gbCusto.TabStop = false;
            this.gbCusto.Text = "Dados de custo";
            // 
            // txtCustoVenda
            // 
            this.txtCustoVenda.Location = new System.Drawing.Point(171, 34);
            this.txtCustoVenda.MaxLength = 3;
            this.txtCustoVenda.Name = "txtCustoVenda";
            this.txtCustoVenda.Size = new System.Drawing.Size(74, 20);
            this.txtCustoVenda.TabIndex = 9;
            // 
            // lblCustoVenda
            // 
            this.lblCustoVenda.AutoSize = true;
            this.lblCustoVenda.Location = new System.Drawing.Point(168, 18);
            this.lblCustoVenda.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblCustoVenda.Name = "lblCustoVenda";
            this.lblCustoVenda.Size = new System.Drawing.Size(38, 13);
            this.lblCustoVenda.TabIndex = 18;
            this.lblCustoVenda.Text = "Venda";
            // 
            // txtCustoMedio
            // 
            this.txtCustoMedio.Location = new System.Drawing.Point(91, 34);
            this.txtCustoMedio.MaxLength = 3;
            this.txtCustoMedio.Name = "txtCustoMedio";
            this.txtCustoMedio.Size = new System.Drawing.Size(74, 20);
            this.txtCustoMedio.TabIndex = 8;
            // 
            // lblCustoMedio
            // 
            this.lblCustoMedio.AutoSize = true;
            this.lblCustoMedio.Location = new System.Drawing.Point(88, 18);
            this.lblCustoMedio.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblCustoMedio.Name = "lblCustoMedio";
            this.lblCustoMedio.Size = new System.Drawing.Size(36, 13);
            this.lblCustoMedio.TabIndex = 18;
            this.lblCustoMedio.Text = "Médio";
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(11, 34);
            this.txtCusto.MaxLength = 3;
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(74, 20);
            this.txtCusto.TabIndex = 7;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(8, 18);
            this.lblCusto.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(34, 13);
            this.lblCusto.TabIndex = 18;
            this.lblCusto.Text = "Custo";
            // 
            // gbProduto
            // 
            this.gbProduto.Controls.Add(this.txtNome);
            this.gbProduto.Controls.Add(this.txtCodigo);
            this.gbProduto.Controls.Add(this.lblNome);
            this.gbProduto.Controls.Add(this.txtQtd);
            this.gbProduto.Controls.Add(this.lblFornecedor);
            this.gbProduto.Controls.Add(this.lblCodigo);
            this.gbProduto.Controls.Add(this.lblCategoria);
            this.gbProduto.Controls.Add(this.lblLocacao);
            this.gbProduto.Controls.Add(this.lblStatus);
            this.gbProduto.Controls.Add(this.lblUniMed);
            this.gbProduto.Controls.Add(this.lblQtd);
            this.gbProduto.Controls.Add(this.lblDescricao);
            this.gbProduto.Controls.Add(this.txtDescricao);
            this.gbProduto.Controls.Add(this.cbLocacao);
            this.gbProduto.Controls.Add(this.cbStatus);
            this.gbProduto.Controls.Add(this.cbMedida);
            this.gbProduto.Controls.Add(this.cbFornecedores);
            this.gbProduto.Controls.Add(this.cbCategoria);
            this.gbProduto.Location = new System.Drawing.Point(12, 12);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(744, 225);
            this.gbProduto.TabIndex = 0;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Dados do produto";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(11, 112);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(360, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(11, 34);
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(74, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 96);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(11, 73);
            this.txtQtd.MaxLength = 3;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(74, 20);
            this.txtQtd.TabIndex = 2;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(9, 174);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 7;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 18);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Código";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(88, 18);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblUniMed
            // 
            this.lblUniMed.AutoSize = true;
            this.lblUniMed.Location = new System.Drawing.Point(88, 58);
            this.lblUniMed.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblUniMed.Name = "lblUniMed";
            this.lblUniMed.Size = new System.Drawing.Size(42, 13);
            this.lblUniMed.TabIndex = 18;
            this.lblUniMed.Text = "Medida";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(8, 57);
            this.lblQtd.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(62, 13);
            this.lblQtd.TabIndex = 18;
            this.lblQtd.Text = "Quantidade";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(8, 135);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(11, 151);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(360, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // cbMedida
            // 
            this.cbMedida.FormattingEnabled = true;
            this.cbMedida.Location = new System.Drawing.Point(91, 73);
            this.cbMedida.Name = "cbMedida";
            this.cbMedida.Size = new System.Drawing.Size(74, 21);
            this.cbMedida.TabIndex = 3;
            // 
            // cbFornecedores
            // 
            this.cbFornecedores.FormattingEnabled = true;
            this.cbFornecedores.Location = new System.Drawing.Point(11, 190);
            this.cbFornecedores.Name = "cbFornecedores";
            this.cbFornecedores.Size = new System.Drawing.Size(357, 21);
            this.cbFornecedores.TabIndex = 6;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(91, 34);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(200, 21);
            this.cbCategoria.TabIndex = 1;
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
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(171, 72);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(52, 21);
            this.cbStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(168, 57);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            // 
            // cbLocacao
            // 
            this.cbLocacao.FormattingEnabled = true;
            this.cbLocacao.Location = new System.Drawing.Point(229, 73);
            this.cbLocacao.Name = "cbLocacao";
            this.cbLocacao.Size = new System.Drawing.Size(120, 21);
            this.cbLocacao.TabIndex = 3;
            // 
            // lblLocacao
            // 
            this.lblLocacao.AutoSize = true;
            this.lblLocacao.Location = new System.Drawing.Point(226, 58);
            this.lblLocacao.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblLocacao.Name = "lblLocacao";
            this.lblLocacao.Size = new System.Drawing.Size(49, 13);
            this.lblLocacao.TabIndex = 18;
            this.lblLocacao.Text = "Locação";
            // 
            // frmCadPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 499);
            this.Controls.Add(this.R4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(784, 537);
            this.MinimumSize = new System.Drawing.Size(784, 537);
            this.Name = "frmCadPro";
            this.Text = "Cadastro de produto";
            this.Load += new System.EventHandler(this.frmCadPro_Load);
            this.R4.ResumeLayout(false);
            this.gbCusto.ResumeLayout(false);
            this.gbCusto.PerformLayout();
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel R4;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblUniMed;
        private System.Windows.Forms.ComboBox cbMedida;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.ComboBox cbFornecedores;
        private System.Windows.Forms.GroupBox gbCusto;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.TextBox txtCustoVenda;
        private System.Windows.Forms.Label lblCustoVenda;
        private System.Windows.Forms.TextBox txtCustoMedio;
        private System.Windows.Forms.Label lblCustoMedio;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblLocacao;
        private System.Windows.Forms.ComboBox cbLocacao;
    }
}

