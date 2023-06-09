using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using ERMS.Logic;
using ERMS.Model;
//
using ERMSLib;
using Presentation.Public;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmReconcile : BaseForm, IPrintable
    {
        #region VARS
        private int itemCount = -1;
        private EFilter filter = EFilter.All;
        private Reconcile reconcile;
        #endregion

        public frmReconcile()
		{
			InitializeComponent();
            //clsERMSGeneral.InitializeTheme(this);
		}

        private void frmReconcile_Load(object sender, EventArgs e)
        {
            reconcile = new Reconcile();
            Init();
            //hgr
            GeneralDataGridView = dgvList;
            fdpStartDate.SelectedDateTime = DateTime.Now;
        }

        private void Init()
        {
            cmbPageSize.AddItemsRange(new string[] { "10", "50", "100", "500", "1000"});
            cmbPageSize.SelectedIndex = 0; //First Item - 10 
            dspProgress.Visible = false;

            Helper h = new Helper();
            h.FormatDataGridView(dgvList);

            chkEnablePaging.Checked = true;
            rdoAll.Checked = true;           
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            frmMap fx = new frmMap();
            fx.cbClose.Visible = false;
            fx.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(fx);
            fx.Show();

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //Process();
            ProgressBox.Show();
            Rebind();
            ProgressBox.Hide();
        }
        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvList;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "Reconcile";
        }
        private void Process()
        {
            dspProgress.TransistionSegment = 0;
            dspProgress.AutoIncrement = true;
            dspProgress.Visible = true;
            
            cbProcess.Enabled = false;

            try
            {
                itemCount = reconcile.Create(fdpStartDate.SelectedDateTime);
                if (itemCount == 0)
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("داده ای در این تاریخ وجود ندارد" + "\n" +
                                                                      "لطفا آخرین تاریخ به روز رسانی بررسی گردد" , "پیغام",
                                                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                backgroundWorker.RunWorkerAsync();
                while (this.backgroundWorker.IsBusy)
                {
                    Application.DoEvents();
                }

                FillPageSelector();
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowErrorMessageFa("پیغام", ex.Message , MyDialogButton.OK);
            }

            dspProgress.Visible = false;
            cbProcess.Enabled = true;
        }

        private void FillPageSelector()
        {
            int start = 1, end = 0;            
            int pageSize = Convert.ToInt32(cmbPageSize.SelectedItem.ToString());

            cmbPage.Items.Clear();
            while (end < itemCount)
            {
                end += pageSize;
                end = (end > itemCount) ? itemCount : end;
                cmbPage.Items.Add(string.Format("{0,5:#####} .. {1,-5:#####}", start, end));
                start = end + 1;
            }
            
            cmbPage.SelectedIndex = cmbPage.Items.Count > 0 ? 0 : -1;
        }

        private void Filter_CheckChanged(object sender, EventArgs e)
        {
            if (rdoAll.Checked)
            {
                filter = EFilter.All;
            }
            if (rdoEQzero.Checked)
            {
                filter = EFilter.EQzero;
            }
            if (rdoNonEQzero.Checked)
            {
                filter = EFilter.NEQzero;
            }
            if (rdoLTzero.Checked)
            {
                filter = EFilter.LTzero;
            }
            if (rdoGTzero.Checked)
            {
                filter = EFilter.GTzero;
            }

            ReFilter();
        }

        private void ReFilter()
        {
            DataTable dt = (DataTable)dgvList.DataSource;
            if (dt != null && dt.Rows.Count > 0)
            switch (filter)
            {
                case EFilter.All:
                    dt.DefaultView.RowFilter = "";
                    break;

                case EFilter.EQzero:
                    dt.DefaultView.RowFilter = "Result = 0";
                    break;

                case EFilter.NEQzero:
                    dt.DefaultView.RowFilter = "Result <> 0";
                    break;

                case EFilter.LTzero:
                    dt.DefaultView.RowFilter = "Result < 0";
                    break;

                case EFilter.GTzero:
                    dt.DefaultView.RowFilter = "Result > 0";
                    break;
            }
        }

        private void chkEnablePaging_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkEnablePaging.Checked)
            //{
            //    cmbPage.Enabled = true;
            //    cmbPageSize.Enabled = true;
            //}
            //else
            //{
            //    cmbPage.Enabled = false;
            //    cmbPageSize.Enabled = false;
            //}

            //Rebind();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (cmbPage.SelectedIndex > 0)
                cmbPage.SelectedIndex = cmbPage.SelectedIndex - 1;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (cmbPage.SelectedIndex < cmbPage.Items.Count - 1)
                cmbPage.SelectedIndex = cmbPage.SelectedIndex + 1;
        }

        private void cmbPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Rebind();
        }

        private void Rebind()
        {
            //int startID, count;

            //if (chkEnablePaging.Checked)
            //{
            //    int index = cmbPage.SelectedIndex;
            //    int pageSize = Convert.ToInt32(cmbPageSize.SelectedItem.ToString());

            //    startID = (index) * pageSize + 1;
            //    count = pageSize;
            //}
            //else
            //{
            //    startID = 1;
            //    count = itemCount;
            //}
            int ReportType = 0;
            if (rdbCurrentLoan.Checked)
                ReportType = 1;
            else if (rdbOverdue1.Checked)
                ReportType = 2;
            else if (rdbOverdue2.Checked)
                ReportType = 3;
            else if (rdbOverdue3.Checked)
                ReportType = 4;
            else if (rdbDeposite.Checked)
                ReportType = 5;
            else if (rdbLG.Checked)
                ReportType = 6;
            else if (rdbCollateral.Checked)
                ReportType = 7;
            DateTime Historic_Date = fdpStartDate.SelectedDateTime;
        
            DataTable dt = reconcile.GetInstancesDT(ReportType, Historic_Date);//new DAL.SwartDataSetTableAdapters.GetDT_ReconcileTableAdapter().GetData(startID, count);

            dgvList.Columns.Clear();
            dgvList.DataSource = dt;
            //// add farsi caption
           
            dgvList.Columns[0].HeaderText = "شماره حساب";
            dgvList.Columns[1].HeaderText = "نام حساب";
            if (rdbCollateral.Checked)
            {
                dgvList.Columns[2].HeaderText = " مانده در فایل 053 ";
                dgvList.Columns[3].HeaderText = "مانده در فایل های 038-037";
            }
            else
            {
                dgvList.Columns[2].HeaderText = " مانده در گزارش GL";
                dgvList.Columns[3].HeaderText = "مانده در فایل های اطلاعاتی";
            }
            
            dgvList.Columns[4].HeaderText = "اختلاف مانده";

            dgvList.Columns["Remaining14D"].DefaultCellStyle.Format = "###,###.##";
            dgvList.Columns["RemainingOLTP"].DefaultCellStyle.Format = "###,###.##";
            dgvList.Columns["Result"].DefaultCellStyle.Format = "###,###.##";
            
            DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
            tCol.MinimumWidth = 512;
            dgvList.Columns[0].Width = 200;
            dgvList.Columns.Add(tCol);

            ReFilter();
        }

        private void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPageSelector();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            itemCount = reconcile.Create(fdpStartDate.SelectedDateTime);
        }

        private void frmReconcile_KeyDown(object sender, KeyEventArgs e)
        {
            //Load
            if (e.KeyCode == Keys.F5)
            {
                Process();
            }
        }

        private void cbMap_Load(object sender, EventArgs e)
        {

        }

	}

    internal enum EFilter
    {
        All = 1,
        EQzero = 2,
        NEQzero = 3,
        LTzero = 4,
        GTzero = 5
    }
}