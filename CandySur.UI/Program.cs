using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandySur.UI
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

            Application.Run(new Proveedor.Gestionar());

            //Login.Login formLogin = new Login.Login();
            //formLogin.DialogResult = formLogin.ShowDialog();

            //if (formLogin.DialogResult == DialogResult.OK)
            //{
            //    Application.Run(new Main());
            //}
            //else if (formLogin.DialogResult == DialogResult.Abort)
            //{
            //    Application.Run(new Backup_Restore.ReiniciarSistema());
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }
    }
}
