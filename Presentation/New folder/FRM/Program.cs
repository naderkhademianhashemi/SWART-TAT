using System;
using System.Windows.Forms;
using Utilize;
using Utilize.Company;
using Utilize.Helper;
using frmLogin = Presentation.Public.frmLogin;

namespace Presentation
{
    static class Program
    {
        public static SWART_TAT logo;

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            try
            {
                e.Exception.ConfigLog();
            }
            catch
            {
                MessageBox.Show("An unrecoverable error occured." + Environment.NewLine +
                    "Please verify environment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void LOG_Exception(Exception exception)
        {
            try
            {
                exception.ConfigLog();
            }
            catch
            {
                MessageBox.Show("An unrecoverable error occured." + Environment.NewLine +
                    "Please verify environment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
         
            Application.Run(new frmLogin(DAL.Properties.Settings.Default.Risk_Mng_MehrConnectionString, "users", "User_Name", "User_Password"));

            if (ERMS.Model.GlobalInfo.UserID == null || ERMS.Model.GlobalInfo.UserID < 1)
            {
                return;
            }
            var frmMain = new TAT_Main();
            
            Application.Run(frmMain);
        
            
            frmMain.Dispose();
            Application.Exit();
        }
    }
}
