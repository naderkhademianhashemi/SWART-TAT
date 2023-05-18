using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Presentation.Public;
using System.Data.OleDb;
using Excel= Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
//using DAL;

namespace Presentation.Capital_Adequacy
{
    public partial class frmImportCapitalData : BaseForm
    {
        DataTable dt;

        public frmImportCapitalData()
        {
            InitializeComponent();
        }

        private void frmImportCapitalData_Load(object sender, EventArgs e)
        {
            fdpUpdateDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate();
            dgvImportData.DataSource = new DAL.CapitalAdequacy().GetDT_ListOfImportData();
        }

        private void cbImport_CButtonClicked(object sender, EventArgs e)
        {
            try
            {
                ProgressBox.Show();
                long ReturnValue = new DAL.CapitalAdequacy().Run_Import_Package(fdpUpdateDate.SelectedDateTime);
                dgvImportData.DataSource = new DAL.CapitalAdequacy().GetDT_ListOfImportData();
                ProgressBox.Hide();
                Routines.ShowMessageBoxFa("داده های ورودی با موفقیت به روزرسانی شد.", "به روزرسانی", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                ProgressBox.Hide();
                Routines.ShowMessageBoxFa("خطا در به روزرسانی داده ها", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
