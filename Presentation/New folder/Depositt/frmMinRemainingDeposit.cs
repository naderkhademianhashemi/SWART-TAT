using System;
using System.Data;
using System.Globalization;
using Utilize.Helper;
using Presentation.Public;

namespace Presentation.Deposit
{
    public partial class frmMinRemainingDeposit : BaseForm
    {
        DataTable dtDeposit;
        public frmMinRemainingDeposit()
        {
            InitializeComponent();
            Load += frmTasvieshode_Load;
            cbCloseAll.TooltipText = "راهنما";
        }

        void frmTasvieshode_Load(object sender, EventArgs e)
        {
            dgvResoult.eventSaveReportExcelClick += dgvResoult_eventSaveReportExcelClick;
            

            fdpStartDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate();

            fdpFinishDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate();

            cbShowReport.Enabled = false;
        }

        void dgvResoult_eventSaveReportExcelClick(object sender, EventArgs e)
        {
            var frmSaveExcel = new Report.FrmSaveExcel(false, false, false, false)
                                   {
                                       SourceData = dgvResoult.ugd
                                   };
            frmSaveExcel.ShowDialog();
            frmSaveExcel.Dispose();
        }

        private void cbShowReport_CButtonClicked(object sender, EventArgs e)
        {
            if (txtDepNoName.Tag == null || txtDepNoName.Tag.ToString().Length == 0
                    || fdpStartDate.SelectedDateTime > fdpFinishDate.SelectedDateTime)
            {
                Utilize.Routines.ShowInfoMessageFa("اخطار", "اطلاعات ورودی کافی نیست و یا سپرده ای با این شماره وجود ندارد", Utilize.MyDialogButton.OK);
                return;
            }

            ProgressBox.Show();
            bool Filtered = false;
            string Filter = string.Empty;
            if (ERMS.Model.GlobalInfo.User_Group_Id != 1)
            {
                //if (filter.Trim().Length != 0) filter += " and ";
                Filter = " Branch <> 2525 ";
                Filtered = true;
            }

            dtDeposit = new DAL.DepositDataSet().GetMinRemainingDepositByContract
                                                                (fdpStartDate.SelectedDateTime,
                                                                    fdpFinishDate.SelectedDateTime,
                                                                        txtDepNoName.Tag.ToString(), Filtered, Filter);
            dgvResoult.DataSource = dtDeposit;

            var sumObject = Math.Round(Convert.ToDecimal(dtDeposit.Compute("Avg([کمینه موجودی در روز])", "").ToString()), 2);
            txtDepAvgerage.Text = sumObject.ToString(CultureInfo.InvariantCulture);

            ProgressBox.Hide();
        }


        private void txtCounterparty_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {

        }

        public string SafeFarsiStr(string input)
        {
            return input.Replace("ی", "ي").Replace("ک", "ك");
        }

        private void txtCounterpartyNameSearch_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {

        }

        private void chbCounterparty_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chbCounterpartyName_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chbDepNo_CheckedChanged(object sender, EventArgs e)
        {
            txtDepNo.Enabled = rbtDepNo.Checked;
            txtDepNoName.Enabled = rbtDepNo.Checked;
            if (!rbtDepNo.Checked)
            {
                txtDepNo.Text = "";
                txtDepNo.Tag = null;
                txtDepNoName.Tag = null;
                txtDepNoName.Text = "";
            }
        }

        private void txtDepNo_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            try
            {
                if (e.Button.Key == "Search")
                {
                    if (txtDepNo.Text.Trim().Length == 0 || !txtDepNo.Text.IsNumber())
                    {
                        Routines.ShowInfoMessageFa("خطا", "شماره معتبری برای شماره حساب وارد نشده است", MyDialogButton.OK);
                        return;
                    }
                    ProgressBox.Show();
                    DateTime dtHisDate = fdpStartDate.SelectedDateTime;
                    string strAccount = txtDepNo.Text;

                    var account =
                        new DAL.DepositDataSet().GetDepositByContract(dtHisDate, strAccount);

                    if (account.Rows.Count > 0)
                    {
                        txtDepNoName.Text = @" حساب " + account.Rows[0][0] + @" در تاریخ مورد نظر وجود دارد ";
                        txtDepNoName.Tag = account.Rows[0][0].ToString();
                        cbShowReport.Enabled = true;
                    }
                    else
                    {
                        txtDepNoName.Text = @"حسابی با این مشخصات در تاریخ " + fdpStartDate.Text + @" وجود ندارد ";
                        txtDepNoName.Tag = null;
                    }
                    ProgressBox.Hide();
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void fdpStartDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            cbShowReport.Enabled = false;
        }

        private void fdpFinishDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            cbShowReport.Enabled = false;
        }

        private void cbCloseAll_CButtonClicked(object sender, EventArgs e)
        {
            frmPDF frmpdf = new frmPDF("/DepositPDF/frmMinRemainingdeposit.pdf");
            frmpdf.ShowDialog();
        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

    }
}
