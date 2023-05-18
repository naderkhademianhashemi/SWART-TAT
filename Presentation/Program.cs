using Presentation.Chart.chart_win;
using Presentation.CHART;
using Presentation.Deposit;
using Presentation.Excel;
using Presentation.FRM_Routine;
using Presentation.Grid;
using Presentation.LCR;
using Presentation.Loan;
using Presentation.Print;
using Presentation.Tabs.AssetDebtManagement;
using Presentation.Test;
using Presentation.Tree_View;
using System;
using System.Globalization;
using System.Windows.Forms;
using Utilize;
using Utilize.Company;
using Utilize.Helper;

namespace Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLCR());
            Application.Exit();
        }
    }
}
