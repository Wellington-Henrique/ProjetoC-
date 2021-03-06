﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClusterSYS
{
    public partial class frmPrincipal : Form
    {
        private frmCadPro cadPro;
        private frmCadPes cadPes;
        private frmVenda venda;
        private frmBuscaPessoa consulta;
        private frmOrcamento orcamento;
        private frmCadUsuario usuario;

        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void msCadProd_Click(object sender, EventArgs e)
        {
            cadPes?.Close();
            cadPro?.Close();
            venda?.Close();
            usuario?.Close();

            cadPro = new frmCadPro
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlBaseFrm.Controls.Add(cadPro);
            cadPro.Show();
        }

        private void msCadCli_Click(object sender, EventArgs e)
        {
            cadPes?.Close();
            cadPro?.Close();
            venda?.Close();
            usuario?.Close();

            cadPes = new frmCadPes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlBaseFrm.Controls.Add(cadPes);
            cadPes.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulta?.Close();

            consulta = new frmBuscaPessoa
            {
                TopLevel = true,
                Dock = DockStyle.Fill
            };

            //pnlBaseFrm.Controls.Add(this);
            consulta.Show();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orcamento?.Close();

            orcamento = new frmOrcamento
            {
                TopLevel = true,
                Dock = DockStyle.Fill
            };

            //pnlBaseFrm.Controls.Add(orcamento);
            orcamento.Show();
        }

        private void pedidoDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadPes?.Close();
            cadPro?.Close();
            venda?.Close();
            usuario?.Close();

            venda = new frmVenda
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlBaseFrm.Controls.Add(venda);
            venda.Show();

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadPes?.Close();
            cadPro?.Close();
            venda?.Close();
            usuario?.Close();

            usuario = new frmCadUsuario
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlBaseFrm.Controls.Add(usuario);
            usuario.Show();
        }

        private void encerraSistema(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                if (MessageBox.Show(this, "Você tem certeza que deseja sair?",
                    "Facsis", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    Application.Exit(); //Encerra o sistema
                else
                    e.Cancel = true; //Permanece no sistema
        }
    }
}
