namespace ClusterSYS
{
    partial class frmCadPes
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTelefone1 = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbPessoa = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.txtTelefone2 = new System.Windows.Forms.TextBox();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.gbDadosUsuario = new System.Windows.Forms.GroupBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.gbDadosPessoais.SuspendLayout();
            this.gbDadosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(10, 34);
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(74, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Location = new System.Drawing.Point(382, 32);
            this.txtTelefone1.MaxLength = 3;
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(79, 20);
            this.txtTelefone1.TabIndex = 6;
            this.txtTelefone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 18);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Código";
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Location = new System.Drawing.Point(379, 16);
            this.lblTelefone1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(58, 13);
            this.lblTelefone1.TabIndex = 18;
            this.lblTelefone1.Text = "Telefone 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 458);
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
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Location = new System.Drawing.Point(520, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 25);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // cbPessoa
            // 
            this.cbPessoa.FormattingEnabled = true;
            this.cbPessoa.Location = new System.Drawing.Point(135, 33);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Size = new System.Drawing.Size(124, 21);
            this.cbPessoa.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(13, 72);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(81, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(13, 56);
            this.lblCpfCnpj.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(65, 13);
            this.lblCpfCnpj.TabIndex = 5;
            this.lblCpfCnpj.Text = "CPF / CNPJ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 32);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(360, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Location = new System.Drawing.Point(134, 17);
            this.lblPessoa.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(80, 13);
            this.lblPessoa.TabIndex = 6;
            this.lblPessoa.Text = "Tipo de pessoa";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(10, 32);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(367, 20);
            this.txtRua.TabIndex = 8;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(7, 16);
            this.lblRua.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 7;
            this.lblRua.Text = "Rua";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMain.Controls.Add(this.gbEndereco);
            this.pnlMain.Controls.Add(this.gbContato);
            this.pnlMain.Controls.Add(this.gbDadosPessoais);
            this.pnlMain.Controls.Add(this.gbDadosUsuario);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(768, 498);
            this.pnlMain.TabIndex = 9;
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.lblCidade);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.lblRua);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.textBox1);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Location = new System.Drawing.Point(12, 276);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(744, 102);
            this.gbEndereco.TabIndex = 3;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Dados de endereços";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(7, 55);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 7;
            this.lblCidade.Text = "Cidade";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(380, 16);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(19, 13);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Nº";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(10, 71);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(367, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 32);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.txtTelefone2);
            this.gbContato.Controls.Add(this.lblTelefone2);
            this.gbContato.Controls.Add(this.txtTelefone1);
            this.gbContato.Controls.Add(this.lblTelefone1);
            this.gbContato.Controls.Add(this.lblEmail);
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.Location = new System.Drawing.Point(13, 200);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(743, 69);
            this.gbContato.TabIndex = 2;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Dados de contato";
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Location = new System.Drawing.Point(467, 32);
            this.txtTelefone2.MaxLength = 3;
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(79, 20);
            this.txtTelefone2.TabIndex = 7;
            this.txtTelefone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Location = new System.Drawing.Point(464, 16);
            this.lblTelefone2.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(58, 13);
            this.lblTelefone2.TabIndex = 18;
            this.lblTelefone2.Text = "Telefone 2";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 16);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 32);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.lblNome);
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.Controls.Add(this.lblCpfCnpj);
            this.gbDadosPessoais.Controls.Add(this.txtDescricao);
            this.gbDadosPessoais.Location = new System.Drawing.Point(13, 88);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(743, 106);
            this.gbDadosPessoais.TabIndex = 1;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados pessois";
            // 
            // gbDadosUsuario
            // 
            this.gbDadosUsuario.Controls.Add(this.cbPessoa);
            this.gbDadosUsuario.Controls.Add(this.txtCodigo);
            this.gbDadosUsuario.Controls.Add(this.lblPessoa);
            this.gbDadosUsuario.Controls.Add(this.cbUsuario);
            this.gbDadosUsuario.Controls.Add(this.lblUsuario);
            this.gbDadosUsuario.Controls.Add(this.lblCodigo);
            this.gbDadosUsuario.Location = new System.Drawing.Point(12, 12);
            this.gbDadosUsuario.Name = "gbDadosUsuario";
            this.gbDadosUsuario.Size = new System.Drawing.Size(744, 70);
            this.gbDadosUsuario.TabIndex = 0;
            this.gbDadosUsuario.TabStop = false;
            this.gbDadosUsuario.Text = "Dados de usuário";
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(90, 33);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(39, 21);
            this.cbUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(87, 18);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 18;
            this.lblUsuario.Text = "Usuário";
            // 
            // frmCadPes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 498);
            this.Controls.Add(this.pnlMain);
            this.MaximumSize = new System.Drawing.Size(784, 537);
            this.Name = "frmCadPes";
            this.Text = "FormCadPes";
            this.panel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbDadosUsuario.ResumeLayout(false);
            this.gbDadosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTelefone1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTelefone1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbPessoa;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.GroupBox gbDadosUsuario;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.TextBox txtTelefone2;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox textBox1;
    }
}