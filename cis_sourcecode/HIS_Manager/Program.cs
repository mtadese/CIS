using System;
using System.Windows.Forms;

namespace CIS.Presentation.UI.WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            frmLogin login = new frmLogin();
            System.Windows.Forms.Application.Run(login);
            if (login.DialogResult == DialogResult.OK)
            {
                System.Windows.Forms.Application.Run(new frmHome());
            }
        }
    }
}
