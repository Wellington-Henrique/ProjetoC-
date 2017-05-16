using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facsis.Properties;

namespace ClusterSYS
{
    

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin login = new frmLogin();

            login = new frmLogin
            {
                TopLevel = true,
                Dock = DockStyle.Fill
            };

            if (login.ShowDialog() == DialogResult.OK)
            {

                frmSplash splash = new frmSplash();

                if (splash.ShowDialog() == DialogResult.OK)
                    Application.Run(new frmPrincipal());
            }
        }
    }
}
