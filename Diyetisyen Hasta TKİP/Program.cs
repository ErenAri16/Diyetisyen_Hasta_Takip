using System;
using System.Windows.Forms;

namespace Diyetisyen_Hasta_TKİP
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

            // Show login form first
            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // If login successful, show main form
                    Application.Run(new Form1());
                }
            }
        }
    }
}
