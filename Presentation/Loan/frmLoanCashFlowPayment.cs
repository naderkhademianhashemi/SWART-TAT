using System;
using System.Data;
using System.Globalization;
using System.Linq;
using Utilize.Helper;
using System.Windows.Forms;
using Presentation.DAL;

namespace Presentation.Loan
{
    public partial class frmLoanCashFlowPayment : Form
    {
        public frmLoanCashFlowPayment()
        {
            InitializeComponent();
            Load += frmTasvieshode_Load;
            cmbBranch.DropDown += CmbBranch_DropDown;
        }

        private void CmbBranch_DropDown(object sender, EventArgs e)
        {
            if (cmbStates.SelectedIndex == 2)
            {
                MessageBox.Show("Test");
            }
        }

        void frmTasvieshode_Load(object sender, EventArgs e)
        {
            FllCmbStates();
            fdpStartDate.SelectedDateTime = DateTime.Now;
        }

        private void FllCmbStates()
        {
            var DT = new LoanDS().GetDT_State();
            cmbStates.DisplayMember = "Name";
            cmbStates.ValueMember = "ID";
            cmbStates.DataSource = DT;
        }

        void dgvResoult_eventSaveReportExcelClick(object sender, EventArgs e)
        {

        }

        private void cbShowReport_CButtonClicked(object sender, EventArgs e)
        {
            var DT = new LoanDS().GetDT_LoanCashFlow();
            dgvResoult.DataSource = DT;
        }

        private string GetFilter()
        {
            return "";
        }

    }
}
