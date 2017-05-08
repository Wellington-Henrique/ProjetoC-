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

        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void msCadProd_Click(object sender, EventArgs e)
        {
            cadPes?.Close();
            cadPro?.Close();
            venda?.Close();

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

            cadPes = new frmCadPes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlBaseFrm.Controls.Add(cadPes);
            cadPes.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadPes?.Close();
            cadPro?.Close();
            venda?.Close();

            venda = new frmVenda
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlBaseFrm.Controls.Add(venda);
            venda.Show();
        }
    }

}