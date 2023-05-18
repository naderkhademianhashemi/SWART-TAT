using System.Linq;
using System.Windows.Forms;
using DevComponents.AdvTree;
////
using Infragistics.Win.UltraWinGrid;
using Utilize.Helper;
using Presentation.Public;
using MyDialogButton = Utilize.MyDialogButton;
using ProgressBox = Presentation.Public.ProgressBox;
using System;

namespace Presentation.Public
{
    public partial class frmSpecialReport : Form
    {
        private readonly string RepParent = "";
        public frmSpecialReport(string parent)
        {
            InitializeComponent();

            RepParent = parent;
            lblReport.Text = parent;
            if (parent == "Loan_Contract")
            {
                cbClose.Visible = false;
                splitContainer2.Panel1Collapsed = true;
                dgvReport.btnShowChart.Visible = false;
                pnlDate.Visible = true;
                //fdpStartDate.SelectedDateTime = DateTime.Now;
                fdpStartDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate();
            }
        }

        private void frmSpecialReport_Load(object sender, System.EventArgs e)
        {
            var reportsDataTable = new DAL.Table_DataSetTableAdapters.SpecialReportsTableAdapter().GetDataByParentName(RepParent);
            foreach (var row in reportsDataTable)
            {
                tvnReports.Nodes.Add(new Node(row.NameReport) { Tag = row.Id });
            }
            dgvReport.eventSaveReportExcelClick += new System.EventHandler(dgvReport_eventSaveReportExcelClick);
            dgvReport.eventShowChart += new System.EventHandler(dgvReport_eventShowChart);
        }

        void dgvReport_eventShowChart(object sender, System.EventArgs e)
        {
            try
            {
                //if (trnReport.SelectedNodes.Count <= 0)
                //{
                //    ReportId = null;
                //    return;
                //}
                var chart = new CHART.frmChart
                {
                    ReportType = "VDepositReport",
                    MdiParent = this.MdiParent,
                    Report_Id = long.Parse(tvnReports.SelectedNodes[0].Tag.ToString())
                };
                chart.Show();
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
            //throw new System.NotImplementedException();
        }

        static void dgvReport_eventSaveReportExcelClick(object sender, System.EventArgs e)
        {
            var frmSe = new Report.FrmSaveExcel(true, true, true, true) { SourceData = sender as UltraGrid };
            frmSe.ShowDialog();
        }

        private void tvnReports_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            try
            {
                ProgressBox.Show();
                if (e.Node.Tag == null) return;

                var specialReports =
                    new DAL.Table_DataSetTableAdapters.SpecialReportsTableAdapter().GetDataById(
                        e.Node.Tag.ToString().ToLong()).FirstOrDefault();
                if (specialReports == null) return;
                var datatable = new DAL.SpecialReports_DataSet().GetResoult(specialReports.NameOfView, fdpStartDate.SelectedDateTime);

                dgvReport.DataSource = datatable.ConfigDateTimeToPersian();
                datatable.Dispose();
                ProgressBox.Hide();
            }
            catch (Exception exception)
            {
                ProgressBox.Hide();
                exception.ConfigLog();
                Routines.ShowErrorMessageFa("خطا", "خطا در جمع آوری اطلاعات گزارش رخ داده است.",
                                            exception.Message, MyDialogButton.OK);
            }
        }

        private void cbClose_CButtonClicked(object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
