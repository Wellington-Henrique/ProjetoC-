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
    public partial class frmCadPes : Form
    {
        public frmCadPes()
        {
            InitializeComponent();

            cbPessoa.Items.Add("Física");
            cbPessoa.Items.Add("Jurídica");
        }

        private void alteraLabelPessoa(object sender, UICuesEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void alteraLabelPessoa(object sender, EventArgs e)
        {
            if (cbPessoa.Text == "Física")
                lblCpfCnpj.Text = "CPF";
            else
                lblCpfCnpj.Text = "CNPJ";
        }
    }
}
