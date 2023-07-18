using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERMSLib;
using System.Data.SqlClient;
using System.Data.OleDb;
using Presentation.Util;
using System.Threading;
using System.IO;

namespace Presentation.LCR
{
    public partial class frmLCR : Form
    {
        public frmLCR()
        {
            InitializeComponent();
        }
        #region methods
        string GetExcelPath()
        {
            var path = "";
            var fdlg = new OpenFileDialog();
            fdlg.Title = "Select file";
            fdlg.InitialDirectory = @"d:\";
            fdlg.FileName = txtFileExcel.Text;
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
                path = txtFileExcel.Text = fdlg.FileName;
            return path;
        }
        void FillGridLevel1()
        {
            var ARR = new string[2] { "Id", "Name" };
            dgvLevel1.DataSource = new DAL.LcrDS().GetDT(ARR);
            FormatGrid(dgvLevel1);
            HighLightRow(dgvLevel1);
        }

        void HighLightRow(DataGridView DGV)
        {
            for (int i = 0; i < dgvLevel1.Columns.Count; i++)
            {
                DGV.Rows[0].Cells[i].Style.BackColor = Color.Cyan;
            }
        }

        void FormatGrid(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv.DefaultCellStyle.Format = "###,##0";
            dgv.Columns[0].DefaultCellStyle.Format = "###";
        }

        void FormatGridSort(DataGridView dgv)
        {
            
            dgv.DefaultCellStyle.Format = "###,##0";
            dgv.Columns[0].DefaultCellStyle.Format = "###";
        }
        #endregion

        private void frmLCR_Load(object sender, EventArgs e)
        {
           fdpDate.SelectedDateTime= DateTime.Now;
        }

        private void dgvLevel1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var INDX = dgvLevel1.CurrentCell.OwningColumn.Index;
            var VAL = dgvLevel1.CurrentCell.OwningRow.Cells[0].Value;
        }

        private void dgvLevel1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsmiExcel_Click(object sender, EventArgs e)
        { }

        #region ExcelImport

        private void cbSelectExcel_Click(object sender, EventArgs e)
        {
            var path = new Import().GetPath(txtFileExcel.Text);
            txtFileExcel.Text = path;   
            var sheetName = txtSheet.Text;
            dgvImportLevel1.DataSource = new Xcl().ToDT(sheetName, path);
        }


        #endregion

        private void dgvImportLevel1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiTab_sub_voroud_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {

        }

        private void cbStart_Click(object sender, EventArgs e)
        {
            FillGridLevel1();
        }

        private void cbSave_Click(object sender, EventArgs e)
        {

        }
    }
}
