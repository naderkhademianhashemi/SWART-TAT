using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DAL;
using Presentation.Report;
using Utilize;
using Utilize.Helper;

namespace Presentation.Deposit
{
    public partial class frmRangeReport : BaseForm
    {
        public frmRangeReport()
        {
            InitializeComponent();
            cbCloseAll.TooltipText = "راهنما";
        }

        private const string TableName = "VDepositReport_Historic";
        private readonly Type[] SqlDbTypes = { typeof(Int32), typeof(Decimal), typeof(Double), typeof(Int16), typeof(Int64) };
        private readonly string[] SqlDbTypesStr = { "Int32", "Decimal", "Double", "Int16", "Int64", "numeric", "float" };
        private const string comName = "DEPRANGE";

        private void frmRangeReport_Load(object sender, EventArgs e)
        {
            tvnRange.XMLToRange(comName);
            var reportDataSet =
                new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataByReportTable(TableName, ERMS.Model.GlobalInfo.UserID);
            cmbReport.DisplayMember = "ReportName";
            cmbReport.ValueMember = "Id";
            cmbReport.DataSource = reportDataSet;

            DataTable dtColNames = new DataTable();
            DataTable dtBaseRange = new DataTable();
            dtBaseRange.Columns.Add("Id");
            dtBaseRange.Columns.Add("AliasName");
            dtColNames = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetTableColumnNames("Deposit_Contract");
            var columnsOfView =
                new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(TableName);

           
            foreach (DataRow drClShow in (columnsOfView as DataTable).Rows)
            {
                if ((Boolean)drClShow["IsShowInRangeForm"] == true)
                {
                    DataRow dr;
                    dr = dtBaseRange.NewRow();
                    dr["Id"] = drClShow["Id"];
                    dr["AliasName"] = drClShow["AliasName"];
                    dtBaseRange.Rows.Add(dr);
                }
            }
            cmbBaseRange.ValueMember = "Id";
            cmbBaseRange.DisplayMember = "AliasName";
            cmbBaseRange.DataSource = dtBaseRange;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var addRange = new Public.frmAddRange();
            addRange.ShowDialog();
            if (addRange.From != -1)
            {
                tvnRange.Nodes.Add(string.Format("{0:0,0}-{1:0,0}", addRange.From, addRange.To));
            }
        }

        private void tvnRange_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
                tssLblStatus.Text = "در حال گزارش گیری... لطفاً تا پایان عملیات منتظر بمانید";
            grvResoultOfReport.DataSource = null;
            tspReprtBar.Visible = true;
            grbSetting.Enabled = tvnRange.Enabled = false;
            var ReportId = Convert.ToInt32(cmbReport.SelectedValue);
            var report =
                new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataById(ReportId).FirstOrDefault();
            var generateReportTableRow = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataById(
                Convert.ToInt64(cmbBaseRange.SelectedValue)).FirstOrDefault();
            var index = e.Node.Text.Split(new[] { '-' });
            string strWhere;
            //if (report.Filter.IsNullOrEmptyByTrim())
            //{
            //    strWhere = " Where " + generateReportTableRow.NameColumn + " between " + index[0].Replace(",", "") +
            //                  " and " + index[1].Replace(",", "");
            //}
            //else
            //{
            //    strWhere = report.Filter + " and (" + generateReportTableRow.NameColumn + " between " + index[0].Replace(",", "") +
            //                   " and " + index[1].Replace(",", "") + ")";
            //}
            if (report.Filter.IsNullOrEmptyByTrim())
            {
                strWhere = " Where " + generateReportTableRow.NameColumn + " >= " + index[0].Replace(",", "") +
                              " and " + generateReportTableRow.NameColumn + " < " + index[1].Replace(",", "");
            }
            else
            {
                strWhere = report.Filter + " and (" + generateReportTableRow.NameColumn + " >= " + index[0].Replace(",", "") +
                               " and " + generateReportTableRow.NameColumn + " < " + index[1].Replace(",", "") + ")";
            }
            //Action action = delegate
            //                    {
            var rModel = new DepositDataSet().GetDepositReportWhitOutPaging(report.SCAA,strWhere);
            if (rModel == null)
                Routines.ShowErrorMessageFa("خطا ", "انتخاب معیار نادرست برای بازه سازی","",MyDialogButton.OK);

            grvResoultOfReport.DataSource = rModel.ConfigDateTimeToPersian();
            //ssRangeReport.Invoke(new Action(() =>
            //                                    {
            tssLblStatus.Text = "آماده برای گزارش گیری";
            tspReprtBar.Visible = false;
            //                                    }));
            //grbSetting.Invoke(new Action(() =>
            //                                {
            grbSetting.Enabled = true;
            //                                }));
            //tvnRange.Invoke(new Action(() =>
            //                               {
            tvnRange.Enabled = true;
            //                               }));
            Routines.ShowInfoMessageFa("پایان گزارش گیری", "عملیات گزارش گیری با موفقیت به پایان رسید", MyDialogButton.OK);
            //                   };
            //new Thread(new ThreadStart(action)).Start();
        }

        private void btnPrint_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            ugpDocument.Grid = this.grvResoultOfReport;
            ugpDocument.Print();
        }

        private void btnSaveExcell_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            try
            {
                var frmSaveExcel = new FrmSaveExcel
                    {
                        SourceData = grvResoultOfReport
                    };
                frmSaveExcel.ShowDialog();
            }
            catch (Exception exception)
            {
                Routines.ShowErrorMessageFa("خطا در ذخیره اطلاعات", "فرایند خروجی اکسل با خطا روبرو شده است.", exception.Message,
                                            MyDialogButton.OK);
            }
        }

        private void btnRemoveRange_Click(object sender, EventArgs e)
        {
            if (tvnRange.SelectedNode == null) return;
            tvnRange.SelectedNode.Remove();
            grvResoultOfReport.DataSource = null;
        }

        private void frmRangeReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            tvnRange.RangeToXML(comName);
        }

        private void btnToXML_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            SaveFileDialog svDialog = new SaveFileDialog();
            svDialog.Filter = "xps files (*.xps)|All files (*.*)";
            svDialog.FilterIndex = 2;
            svDialog.ShowDialog();
            string sPath = svDialog.FileName;
            if (svDialog.ShowDialog() == DialogResult.OK)
            {
                ugeDocument.Export(grvResoultOfReport, sPath,
                                   Infragistics.Win.UltraWinGrid.DocumentExport.GridExportFileFormat.XPS);
            }

        }

        private void cbCloseAll_CButtonClicked(object sender, EventArgs e)
        {
            frmPDF frmpdf = new frmPDF("/DepositPDF/frmRangeReport.pdf");
            frmpdf.ShowDialog();
        }
    }
}
