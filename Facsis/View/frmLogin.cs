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
        bool login = false;

        public frmLogin()
        {
            
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "adm" && txtSenha.Text == "123")
            {
                DialogResult = DialogResult.OK;
                login = true;
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

        private void encerraSistema(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && login == false)
                if (MessageBox.Show(this, "Você tem certeza que deseja sair?",
                    "Facsis", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    Application.Exit(); //Encerra o sistema
                else
                    e.Cancel = true; //Permanece no sistema
        }
    }
}
