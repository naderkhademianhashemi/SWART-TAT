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

namespace Presentation.Excel
{
    public partial class frmExcel : Form
    {
        public frmExcel()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var path = "d:";
            var sheet = "تراز";
            path = txtPath.Text = new Import().GetPath(path);
            sheet = txtSheet.Text;
            var DT = new Xcl().ToDT(sheet, path);
            dataGridView1.DataSource = DT;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            new Export().Dgv2Xcl(dataGridView1);
        }

        private void frmExcel_Load(object sender, EventArgs e)
        {
            var DT = new GapDS().GetDT();
            dataGridView1.DataSource = DT;
        }
    }
}
