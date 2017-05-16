using System;
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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void rdBtnCancelar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnCancelar.Checked == true)
            {
                if (MessageBox.Show("Deseja realmente cancelar este pedido?", "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void lblLegNomeCli_Click(object sender, EventArgs e)
        {

        }
    }
}
