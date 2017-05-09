namespace ClusterSYS
{
    partial class frmBuscaPessoa
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
            this.R4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.gbDadosUsuario = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.R4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbDadosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // R4
            // 
            this.R4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.R4.Controls.Add(this.panel2);
            this.R4.Controls.Add(this.dataGridView1);
            this.R4.Controls.Add(this.panel1);
            this.R4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.R4.Location = new System.Drawing.Point(0, 0);
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(584, 361);
            this.R4.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(72, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 361);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 361);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbDadosUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(72, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 100);
            this.panel2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Consultar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // gbDadosUsuario
            // 
            this.gbDadosUsuario.Controls.Add(this.button5);
            this.gbDadosUsuario.Controls.Add(this.lblCpfCnpj);
            this.gbDadosUsuario.Controls.Add(this.lblNome);
            this.gbDadosUsuario.Controls.Add(this.txtDescricao);
            this.gbDadosUsuario.Controls.Add(this.txtNome);
            this.gbDadosUsuario.Controls.Add(this.txtCodigo);
            this.gbDadosUsuario.Controls.Add(this.lblCodigo);
            this.gbDadosUsuario.Location = new System.Drawing.Point(6, 18);
            this.gbDadosUsuario.Name = "gbDadosUsuario";
            this.gbDadosUsuario.Size = new System.Drawing.Size(494, 70);
            this.gbDadosUsuario.TabIndex = 1;
            this.gbDadosUsuario.TabStop = false;
            this.gbDadosUsuario.Text = "Dados para busca";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(10, 34);
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(74, 20);
            this.txtCodigo.TabIndex = 0;
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
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(90, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 34);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 20);
            this.txtNome.TabIndex = 12;
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(325, 18);
            this.lblCpfCnpj.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(65, 13);
            this.lblCpfCnpj.TabIndex = 14;
            this.lblCpfCnpj.Text = "CPF / CNPJ";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(328, 34);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(92, 20);
            this.txtDescricao.TabIndex = 13;
            this.txtDescricao.Text = "00000000000100";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(426, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmBuscaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.R4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmBuscaPessoa";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Consulta Pessoa";
            this.R4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbDadosUsuario.ResumeLayout(false);
            this.gbDadosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel R4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox gbDadosUsuario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button5;
    }
}