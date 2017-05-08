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
        int contaTentativas = 0;

        public frmLogin()
        {
            
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();

            if (txtLogin.Text == "adm" && txtSenha.Text == "123")
            {
                Hide();
                principal.Show();             
            }
            else if (contaTentativas == 2)
            {
                MessageBox.Show("Você excedeu a quantidade de tentativas permitidas", "Login de usurio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }

            else
            {
                lblMsg.Text = "Usuário ou senha inválida!";
                contaTentativas++;
            }

        }
    }
}
