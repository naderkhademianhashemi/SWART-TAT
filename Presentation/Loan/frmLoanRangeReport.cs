using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
//
using Infragistics.Win.UltraWinGrid;
using Presentation.Public;
using Presentation.Report;
using Utilize.Helper;

namespace Presentation.Loan
{
    public partial class frmLoanRangeReport : Form
    {
        public frmLoanRangeReport()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            cbCloseAll.TooltipText = "راهنما";
        }

        private const string TableName = "VLReport_Historic";
        private const string comName = "LONRANGE";

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
            try
            {
                ProgressBox.Show();
                tssLblStatus.Text = "در حال گزارش گیری... لطفاً تا پایان عملیات منتظر بمانید";
                grvResoultOfReport.DataSource = null;
                tspReprtBar.Visible = true;
                grbSetting.Enabled = tvnRange.Enabled = false;
                if (cmbReport.SelectedValue != null)
                {
                    var ReportId = Convert.ToInt32(cmbReport.SelectedValue);
                    var report =
                        new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataById(ReportId).FirstOrDefault();
                    var generateReportTableRow = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataById(
                        Convert.ToInt64(cmbBaseRange.SelectedValue)).FirstOrDefault();
                    var index = e.Node.Text.Split(new[] { '-' });
                    string strWhere;
                    if (report.Filter.IsNullOrEmptyByTrim())
                    {
                        strWhere = " Where " + generateReportTableRow.NameColumn + " between " + index[0].Replace(",", "") +
                                  " and " + index[1].Replace(",", "");
                    }
                    else
                    {
                        strWhere = report.Filter + " and (" + generateReportTableRow.NameColumn + " between " + index[0].Replace(",", "") +
                                   " and " + index[1].Replace(",", "") + ")";
                    }
                    var rModel = new DAL.LoanDataSet().GetLoanReportWhitOutPaging(report.SCAA,
                                                                                strWhere);
                    grvResoultOfReport.DataSource = rModel.ConfigDateTimeToPersian();
                    tssLblStatus.Text = "آماده برای گزارش گیری";
                
                    rModel.Dispose();
                    ProgressBox.Hide();
                }
                else
                {
                    Utilize.Routines.ShowErrorMessageFa("خطا در ورود اطلاعات","نام هیچ گزارشی انتخاب نشده است",Utilize.MyDialogButton.OK); 
                }

            }
            catch (Exception exception)
            {
                ProgressBox.Hide();
                exception.ConfigLog(true);
            }
            finally
            {
                tspReprtBar.Visible = false;
                grbSetting.Enabled = true;
                tvnRange.Enabled = true; 
            }
        }

        private void btnPrint_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            //ugpDocument.Grid = this.grvResoultOfReport;
            //ugpDocument.Print();

            if (grvResoultOfReport.DataSource == null)
            {
                Presentation.Public.Routines.ShowErrorMessageFa("اخطار", "ليستی برای چاپ وجود ندارد", Presentation.Public.MyDialogButton.OK);
            }
            else
            {
                var frmInputText = new Utilize.frmInputText() { Text = "عنوان گزارش" };
                if (frmInputText.ShowDialog() == DialogResult.OK)
                {
                    Infragistics.Win.UltraWinGrid.UltraGrid dgv = new UltraGrid();
                    DataTable dt2 = new DataTable();
                    DataTable dt = new DataTable();

                    if (grvResoultOfReport != null)
                    {
                        dt2 = (DataTable)grvResoultOfReport.DataSource;
                        dt = dt2.Copy();
                    }
                    dgv.DataSource = dt;
                    dgv.DataBind();
                    dgv.DisplayLayout.Override.HeaderAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(156)))), ((int)(((byte)(11)))));
                    dgv.DisplayLayout.Override.HeaderAppearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(156)))), ((int)(((byte)(11)))));
                    dgv.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                    this.Controls.Add(dgv);
                    ugpDocument.Grid = dgv;
                    ugpDocument.Header.TextCenter = frmInputText.ReturnValue;
                    this.Controls.Remove(dgv);
                    ultraPrintPreviewDialog.ShowDialog();
                }
            }
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
                Utilize.Routines.ShowErrorMessageFa("خطا در ذخیره اطلاعات", "فرایند خروجی اکسل با خطا روبرو شده است.", exception.Message,
                                            Utilize.MyDialogButton.OK);
            }
        }

        private void btnRemoveRange_Click(object sender, EventArgs e)
        {
            if (tvnRange.SelectedNode == null) return;
            tvnRange.SelectedNode.Remove();
            grvResoultOfReport.DataSource = null;
        }

        private void frmLoanRangeReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            tvnRange.RangeToXML(comName);
        }

        private void cmbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbReport.SelectedValue == null)
            //    return;
            //var report = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataById(
            //    cmbReport.SelectedValue.ToString().ToLong()).FirstOrDefault();


            //var columnsOfView =
            //    new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
            //        TableName).Where(item => item.IsShowInRangeForm);
            //var finColDataSet = columnsOfView.Where(item => report.SCAA.Contains(item.NameColumn));
            //cmbBaseRange.ValueMember = "Id";
            //cmbBaseRange.DisplayMember = "AliasName";
            //cmbBaseRange.DataSource = finColDataSet.ToArray();
        }

       private void btnToXML_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            SaveFileDialog svDialog = new SaveFileDialog();
            svDialog.Filter = "XPS Document (.xps)|All files (*.*)";
            svDialog.FilterIndex = 1;
            svDialog.ShowDialog();
            string sPath = svDialog.FileName;
            if (svDialog.ShowDialog() == DialogResult.OK)
            {
                ugeDocument.Export(grvResoultOfReport, sPath,
                                   Infragistics.Win.UltraWinGrid.DocumentExport.GridExportFileFormat.XPS);
            }
        }

       private void ugpDocument_PagePrinting(object sender, Infragistics.Win.Printing.PagePrintingEventArgs e)
       {
           e.Graphics.DrawImage(Properties.Resources.LogoPrint,
                                e.PageSettings.PaperSize.Width - e.PageSettings.Margins.Right -
                                Properties.Resources.LogoPrint.Size.Width, 10);
       }

       private void lblNameReport_Click(object sender, EventArgs e)
       {

       }

       private void cbCloseAll_CButtonClicked(object sender, EventArgs e)
       {
           frmPDF frmpdf = new frmPDF("/CreditRiskPDF/frmLoanRangeReport.pdf");
           frmpdf.ShowDialog();
       }

       
    }
}
