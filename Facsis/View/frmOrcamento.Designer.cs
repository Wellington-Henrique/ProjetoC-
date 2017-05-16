namespace ClusterSYS
{
    partial class frmOrcamento
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBtnCancelar = new System.Windows.Forms.RadioButton();
            this.rdBtnPendente = new System.Windows.Forms.RadioButton();
            this.rdBtnAtualizar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtVlrDesconto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVlrBruto = new System.Windows.Forms.TextBox();
            this.lblVlrBruto = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbItenPedido = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gbPgto = new System.Windows.Forms.GroupBox();
            this.cbFormaPgto = new System.Windows.Forms.ComboBox();
            this.lblFormaPgto = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNVendedor = new System.Windows.Forms.TextBox();
            this.lblLegDataNota = new System.Windows.Forms.Label();
            this.lblLegNomeCli = new System.Windows.Forms.Label();
            this.lblLegNPedido = new System.Windows.Forms.Label();
            this.lblLegDataPed = new System.Windows.Forms.Label();
            this.lblNVendedor = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.lblDataNota = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblNPedido = new System.Windows.Forms.Label();
            this.lblDataPed = new System.Windows.Forms.Label();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbPedido.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbPgto.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.gbPedido);
            this.pnlMain.Controls.Add(this.gbPgto);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(5, 0, 5, 20);
            this.pnlMain.Size = new System.Drawing.Size(768, 498);
            this.pnlMain.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 25);
            this.panel1.TabIndex = 37;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(658, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 25);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(552, 0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 25);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.lblMsg);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 330);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(758, 98);
            this.panel4.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBtnCancelar);
            this.groupBox2.Controls.Add(this.rdBtnPendente);
            this.groupBox2.Controls.Add(this.rdBtnAtualizar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(403, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(84, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // rdBtnCancelar
            // 
            this.rdBtnCancelar.AutoSize = true;
            this.rdBtnCancelar.Location = new System.Drawing.Point(10, 68);
            this.rdBtnCancelar.Name = "rdBtnCancelar";
            this.rdBtnCancelar.Size = new System.Drawing.Size(67, 17);
            this.rdBtnCancelar.TabIndex = 33;
            this.rdBtnCancelar.Text = "Cancelar";
            this.rdBtnCancelar.UseVisualStyleBackColor = true;
            // 
            // rdBtnPendente
            // 
            this.rdBtnPendente.AutoSize = true;
            this.rdBtnPendente.Location = new System.Drawing.Point(10, 45);
            this.rdBtnPendente.Name = "rdBtnPendente";
            this.rdBtnPendente.Size = new System.Drawing.Size(71, 17);
            this.rdBtnPendente.TabIndex = 33;
            this.rdBtnPendente.Text = "Pendente";
            this.rdBtnPendente.UseVisualStyleBackColor = true;
            // 
            // rdBtnAtualizar
            // 
            this.rdBtnAtualizar.AutoSize = true;
            this.rdBtnAtualizar.Checked = true;
            this.rdBtnAtualizar.Location = new System.Drawing.Point(10, 22);
            this.rdBtnAtualizar.Name = "rdBtnAtualizar";
            this.rdBtnAtualizar.Size = new System.Drawing.Size(65, 17);
            this.rdBtnAtualizar.TabIndex = 33;
            this.rdBtnAtualizar.TabStop = true;
            this.rdBtnAtualizar.Text = "Atualizar";
            this.rdBtnAtualizar.UseMnemonic = false;
            this.rdBtnAtualizar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtVlrDesconto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDesconto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtVlrBruto);
            this.groupBox1.Controls.Add(this.lblVlrBruto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(487, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 71);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 45);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 0;
            // 
            // txtVlrDesconto
            // 
            this.txtVlrDesconto.Location = new System.Drawing.Point(180, 45);
            this.txtVlrDesconto.MaxLength = 3;
            this.txtVlrDesconto.Name = "txtVlrDesconto";
            this.txtVlrDesconto.Size = new System.Drawing.Size(80, 20);
            this.txtVlrDesconto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Valor total";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(15, 48);
            this.lblDesconto.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(53, 13);
            this.lblDesconto.TabIndex = 18;
            this.lblDesconto.Text = "Desconto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "%";
            // 
            // txtVlrBruto
            // 
            this.txtVlrBruto.Location = new System.Drawing.Point(180, 19);
            this.txtVlrBruto.MaxLength = 3;
            this.txtVlrBruto.Name = "txtVlrBruto";
            this.txtVlrBruto.Size = new System.Drawing.Size(80, 20);
            this.txtVlrBruto.TabIndex = 0;
            // 
            // lblVlrBruto
            // 
            this.lblVlrBruto.AutoSize = true;
            this.lblVlrBruto.Location = new System.Drawing.Point(115, 22);
            this.lblVlrBruto.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblVlrBruto.Name = "lblVlrBruto";
            this.lblVlrBruto.Size = new System.Drawing.Size(59, 13);
            this.lblVlrBruto.TabIndex = 18;
            this.lblVlrBruto.Text = "Valor Bruto";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(6, 85);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(172, 13);
            this.lblMsg.TabIndex = 18;
            this.lblMsg.Text = "INCLUINDO NOVO ORÇAMENTO";
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.panel2);
            this.gbPedido.Controls.Add(this.panel3);
            this.gbPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPedido.Location = new System.Drawing.Point(5, 133);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(758, 197);
            this.gbPedido.TabIndex = 35;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Itens do pedido";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbItenPedido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 41);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(752, 153);
            this.panel2.TabIndex = 34;
            // 
            // lbItenPedido
            // 
            this.lbItenPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItenPedido.FormattingEnabled = true;
            this.lbItenPedido.Location = new System.Drawing.Point(5, 5);
            this.lbItenPedido.Name = "lbItenPedido";
            this.lbItenPedido.ScrollAlwaysVisible = true;
            this.lbItenPedido.Size = new System.Drawing.Size(742, 143);
            this.lbItenPedido.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExcluir);
            this.panel3.Controls.Add(this.btnInserir);
            this.panel3.Controls.Add(this.btnAlterar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 25);
            this.panel3.TabIndex = 33;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(452, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 25);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(552, 0);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 25);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(652, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 25);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // gbPgto
            // 
            this.gbPgto.Controls.Add(this.cbFormaPgto);
            this.gbPgto.Controls.Add(this.lblFormaPgto);
            this.gbPgto.Controls.Add(this.txtObs);
            this.gbPgto.Controls.Add(this.lblObs);
            this.gbPgto.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPgto.Location = new System.Drawing.Point(5, 63);
            this.gbPgto.Name = "gbPgto";
            this.gbPgto.Size = new System.Drawing.Size(758, 70);
            this.gbPgto.TabIndex = 34;
            this.gbPgto.TabStop = false;
            // 
            // cbFormaPgto
            // 
            this.cbFormaPgto.FormattingEnabled = true;
            this.cbFormaPgto.Location = new System.Drawing.Point(8, 33);
            this.cbFormaPgto.Name = "cbFormaPgto";
            this.cbFormaPgto.Size = new System.Drawing.Size(121, 21);
            this.cbFormaPgto.TabIndex = 27;
            // 
            // lblFormaPgto
            // 
            this.lblFormaPgto.AutoSize = true;
            this.lblFormaPgto.Location = new System.Drawing.Point(11, 17);
            this.lblFormaPgto.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblFormaPgto.Name = "lblFormaPgto";
            this.lblFormaPgto.Size = new System.Drawing.Size(107, 13);
            this.lblFormaPgto.TabIndex = 25;
            this.lblFormaPgto.Text = "Forma de pagamento";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(135, 33);
            this.txtObs.MaxLength = 3;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(615, 20);
            this.txtObs.TabIndex = 24;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(132, 17);
            this.lblObs.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(65, 13);
            this.lblObs.TabIndex = 26;
            this.lblObs.Text = "Observação";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNVendedor);
            this.groupBox3.Controls.Add(this.lblLegDataNota);
            this.groupBox3.Controls.Add(this.lblLegNomeCli);
            this.groupBox3.Controls.Add(this.lblLegNPedido);
            this.groupBox3.Controls.Add(this.lblLegDataPed);
            this.groupBox3.Controls.Add(this.lblNVendedor);
            this.groupBox3.Controls.Add(this.txtCodCli);
            this.groupBox3.Controls.Add(this.lblDataNota);
            this.groupBox3.Controls.Add(this.lblNomeCli);
            this.groupBox3.Controls.Add(this.lblNPedido);
            this.groupBox3.Controls.Add(this.lblDataPed);
            this.groupBox3.Controls.Add(this.lblCodCli);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox3.Location = new System.Drawing.Point(5, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(758, 63);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // txtNVendedor
            // 
            this.txtNVendedor.Location = new System.Drawing.Point(400, 30);
            this.txtNVendedor.MaxLength = 3;
            this.txtNVendedor.Name = "txtNVendedor";
            this.txtNVendedor.Size = new System.Drawing.Size(75, 20);
            this.txtNVendedor.TabIndex = 20;
            // 
            // lblLegDataNota
            // 
            this.lblLegDataNota.AutoSize = true;
            this.lblLegDataNota.Location = new System.Drawing.Point(656, 14);
            this.lblLegDataNota.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblLegDataNota.Name = "lblLegDataNota";
            this.lblLegDataNota.Size = new System.Drawing.Size(47, 13);
            this.lblLegDataNota.TabIndex = 21;
            this.lblLegDataNota.Text = "Dt. Nota";
            // 
            // lblLegNomeCli
            // 
            this.lblLegNomeCli.AutoSize = true;
            this.lblLegNomeCli.Location = new System.Drawing.Point(86, 14);
            this.lblLegNomeCli.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblLegNomeCli.Name = "lblLegNomeCli";
            this.lblLegNomeCli.Size = new System.Drawing.Size(35, 13);
            this.lblLegNomeCli.TabIndex = 22;
            this.lblLegNomeCli.Text = "Nome";
            // 
            // lblLegNPedido
            // 
            this.lblLegNPedido.AutoSize = true;
            this.lblLegNPedido.Location = new System.Drawing.Point(485, 14);
            this.lblLegNPedido.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblLegNPedido.Name = "lblLegNPedido";
            this.lblLegNPedido.Size = new System.Drawing.Size(55, 13);
            this.lblLegNPedido.TabIndex = 23;
            this.lblLegNPedido.Text = "Nº Pedido";
            // 
            // lblLegDataPed
            // 
            this.lblLegDataPed.AutoSize = true;
            this.lblLegDataPed.Location = new System.Drawing.Point(553, 14);
            this.lblLegDataPed.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblLegDataPed.Name = "lblLegDataPed";
            this.lblLegDataPed.Size = new System.Drawing.Size(57, 13);
            this.lblLegDataPed.TabIndex = 24;
            this.lblLegDataPed.Text = "Dt. Pedido";
            // 
            // lblNVendedor
            // 
            this.lblNVendedor.AutoSize = true;
            this.lblNVendedor.Location = new System.Drawing.Point(397, 13);
            this.lblNVendedor.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblNVendedor.Name = "lblNVendedor";
            this.lblNVendedor.Size = new System.Drawing.Size(78, 13);
            this.lblNVendedor.TabIndex = 25;
            this.lblNVendedor.Text = "Cód. Vendedor";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(7, 30);
            this.txtCodCli.MaxLength = 3;
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(75, 20);
            this.txtCodCli.TabIndex = 19;
            // 
            // lblDataNota
            // 
            this.lblDataNota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNota.Location = new System.Drawing.Point(659, 30);
            this.lblDataNota.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblDataNota.Name = "lblDataNota";
            this.lblDataNota.Size = new System.Drawing.Size(93, 20);
            this.lblDataNota.TabIndex = 26;
            this.lblDataNota.Text = "01/01/2017";
            this.lblDataNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCli.Location = new System.Drawing.Point(88, 30);
            this.lblNomeCli.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(306, 20);
            this.lblNomeCli.TabIndex = 27;
            this.lblNomeCli.Text = "Cliente teste";
            this.lblNomeCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNPedido
            // 
            this.lblNPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPedido.Location = new System.Drawing.Point(488, 30);
            this.lblNPedido.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblNPedido.Name = "lblNPedido";
            this.lblNPedido.Size = new System.Drawing.Size(52, 20);
            this.lblNPedido.TabIndex = 28;
            this.lblNPedido.Text = "0001";
            this.lblNPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataPed
            // 
            this.lblDataPed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPed.Location = new System.Drawing.Point(553, 30);
            this.lblDataPed.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblDataPed.Name = "lblDataPed";
            this.lblDataPed.Size = new System.Drawing.Size(93, 20);
            this.lblDataPed.TabIndex = 29;
            this.lblDataPed.Text = "01/01/2017";
            this.lblDataPed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Location = new System.Drawing.Point(10, 14);
            this.lblCodCli.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(63, 13);
            this.lblCodCli.TabIndex = 30;
            this.lblCodCli.Text = "Cód. cliente";
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 498);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(784, 537);
            this.Name = "frmOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamentos";
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPedido.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbPgto.ResumeLayout(false);
            this.gbPgto.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.GroupBox gbPgto;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbItenPedido;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBtnCancelar;
        private System.Windows.Forms.RadioButton rdBtnPendente;
        private System.Windows.Forms.RadioButton rdBtnAtualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtVlrDesconto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVlrBruto;
        private System.Windows.Forms.Label lblVlrBruto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNVendedor;
        private System.Windows.Forms.Label lblLegDataNota;
        private System.Windows.Forms.Label lblLegNomeCli;
        private System.Windows.Forms.Label lblLegNPedido;
        private System.Windows.Forms.Label lblLegDataPed;
        private System.Windows.Forms.Label lblNVendedor;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label lblDataNota;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblNPedido;
        private System.Windows.Forms.Label lblDataPed;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.ComboBox cbFormaPgto;
        private System.Windows.Forms.Label lblFormaPgto;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs;
    }
}