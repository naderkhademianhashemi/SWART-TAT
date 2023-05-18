using Presentation.DAL;
using Presentation.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Print
{
    public partial class frmNdrPrint : Form
    {
        public frmNdrPrint()
        {
            InitializeComponent();
        }

        private void frmNdrPrint_Load(object sender, EventArgs e)
        {
            var DT = new GapDS().GetDT();
            dgvPrint.DataSource = DT;
        }

        private void btnPrintPre_Click(object sender, EventArgs e)
        {
            var ppd = new PrintPreviewDialog();
            ppd.Document = printDocument1;
            ppd.ShowDialog();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            var P = new Printer(dgvPrint);
            if (P.SetupThePrinting())
                printDocument1.Print();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var p = new Printer();
            p.Draw(dgvPrint, e);
        }
    }
}
