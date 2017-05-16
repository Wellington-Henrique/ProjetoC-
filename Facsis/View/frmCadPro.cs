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
    public partial class frmCadPro : Form
    {
        public frmCadPro()
        {
            InitializeComponent();
        }

        private void frmCadPro_Load(object sender, EventArgs e)
        {
            cbCategoria.Items.Clear();
            cbCategoria.Items.Add("Mesas");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Cadastro de produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
