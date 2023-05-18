using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilize.Helper;
using ERMSLib;
using ERMS.Logic;
using ERMS.Model;
using System.Data.SqlClient;
using ClosedXML.Excel;
using System.IO;
using Presentation.DAL;
using Presentation.Util;

namespace Presentation.Test
{
    public partial class frmGapDetails : Form
    {
        public frmGapDetails()
        {
            InitializeComponent();
        }

        string GetSelectedRow(int RowIndex, Control c)
        {
            var selectedRow = ((DataGridView)c).Rows[RowIndex];
            var selectedValue = selectedRow.Cells["ID"].Value.ToString();
            return selectedValue;
        }
        private void btnFinal_Click(object sender, EventArgs e)
        {
            gridFinal.DataSource = new GapDS().GetDT();
        }


        private void btnExcel_Click(object sender, EventArgs e)
        {
            new Export().Dgv2Xcl(gridFinal);
        }
        
        private void cComboCoxBaste_SelectionChanged(object sender, EventArgs e)
        {
            var selectedBaste = Convert.ToInt32(cComboCoxBaste.SelectedValue.ToString());
        }

        private void cmbCGroupAndReport_ValueChanged(object sender, EventArgs e)
        { }

        private void cComboCoxGroupName_SelectionChanged_1(object sender, EventArgs e)
        {
            var selectedBaste = Convert.ToInt32(cComboCoxGroupName.SelectedValue.ToString());

        }

        private void frmGapDetails_Load(object sender, EventArgs e)
        {
            cmbGrpTyp.Items.AddRange(new string[] { "لطفا انتخاب کنید", "تسهیلات", "سپرده" });
            cmbGrpTyp.SelectedIndex = 1;
        }
    }
}
