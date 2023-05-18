using DevComponents.DotNetBar.Controls;
using Infragistics.Win.Printing;
using Infragistics.Win.UltraWinGrid;
using Presentation.DAL;
using Presentation.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Print
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            var p = new Printer(dgvPrint);
            p.prtDocument_PrintPage(sender, e);
        }

        private void btnPrintPre_Click(object sender, EventArgs e)
        {
            var p = new Printer(dgvPrint);
            p.PrintDocument();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            var p = new Printer(dgvPrint);
            p.SetupThePrinting();
            printDocument1.Print();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            var DT = new GapDS().GetDT();
            dgvPrint.DataSource = DT;
        }
    }
}
