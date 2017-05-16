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
    public partial class frmLogin : Form
    {
        int contaTentativas = 0; //Conta os erros de login são permitidos apenas três tentativas

        public frmLogin()
        {
            
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "adm" && txtSenha.Text == "123")
            {
                DialogResult = DialogResult.OK;
                this.Close();           
            }
            else if (contaTentativas == 2)
            {
                MessageBox.Show("Você excedeu a quantidade de tentativas permitidas", "Login de usurio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }

            else
            {
                lblMsg.Visible = true;
                contaTentativas++;
            }
        }
    }
}
