using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ERMS.Model;
using ERMSLib;
using ERMS.Logic;
using Presentation.Public;

namespace Presentation.Capital_Adequacy
{
    public partial class frmMarketRiskAsset : BaseForm, IPrintable
    {
        private FSM fsm;

        public frmMarketRiskAsset()
        {
            InitializeComponent();
        }

        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "Reconcile";
        }

        private void frmCapitalAdecuacy_Load(object sender, EventArgs e)
        {
            fdpDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate();
            RebindPortfolio();
            fsm = new FSM();
            RebindFSM();
        }

        private void RebindPortfolio()
        {
            cmbPortfolio.DataSource = new DAL.MR_DataSet().GetPortfolios();
            cmbPortfolio.DisplayMember = "Code";
            cmbPortfolio.ValueMember = "Id";
            cmbPortfolio.SelectedIndex = -1;
        }

        private void RebindFSM()
        {
            cmbFSM.DataSource = fsm.GetFSMs();
            cmbFSM.DisplayMember = FSM.CTE_Alias_ModelName;
            cmbFSM.ValueMember = FSM.CTE_Alias_ID;
            cmbFSM.SelectedIndex = -1;
        }

        private void cmbPortfolio_SelectionChanged(object sender, EventArgs e)
        {
            dgvRisk.DataSource = new DAL.CapitalAdequacy().Get_Market_Balanced_Asset(fdpDate.SelectedDateTime, (int)cmbPortfolio.SelectedValue);
        }

        private void cmbFSM_SelectionChanged(object sender, EventArgs e)
        {
            dgvArz.DataSource = new DAL.CapitalAdequacy().GetDT_FSMElementsValue((int)cmbFSM.SelectedValue, fdpDate.SelectedDateTime, 3, "");
            dgvArz.Columns["AL"].Visible = false;
        }

        private void cbStart_CButtonClicked(object sender, EventArgs e)
        {
            if (tabMain.Enabled == false)
                tabMain.Enabled = true;

            if (cmbFSM.SelectedIndex != -1)
            {
                dgvArz.DataSource = new DAL.CapitalAdequacy().GetDT_FSMElementsValue((int)cmbFSM.SelectedValue, fdpDate.SelectedDateTime, 2, "");
                dgvArz.Columns["AL"].Visible = false;
                dgvArz.Columns["بند"].Visible = false;
            }

            if (cmbPortfolio.SelectedIndex != -1)
            {
                dgvRisk.DataSource = new DAL.CapitalAdequacy().Get_Market_Balanced_Asset(fdpDate.SelectedDateTime, (int)cmbPortfolio.SelectedValue);
            }
        }

        private void SaveAmount(int band, DataGridView dgv)
        {
            double amount = Convert.ToDouble(dgv.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable()
                                   .Sum(x => double.Parse(x.Cells["مبلغ با احتساب ضریب ریسک"].Value.ToString())));
            new DAL.CapitalAdequacy().Insert_Amount_Historic(band, amount, fdpDate.SelectedDateTime);
        }

        private void cbConfirm_CButtonClicked(object sender, EventArgs e)
        {
            //ذخیره مجموع مبالغ بند 2-17
            double amount = Convert.ToDouble(dgvRisk.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable()
                                   .Sum(x => double.Parse(x.Cells["مبلغ با احتساب ضریب ریسک"].Value.ToString())));
            new DAL.CapitalAdequacy().Insert_Amount_Historic(217, amount, fdpDate.SelectedDateTime);

            //ذخیره مجموع مبالغ بند 1-17
            amount = amount * 0.05;
            new DAL.CapitalAdequacy().Insert_Amount_Historic(117, amount, fdpDate.SelectedDateTime);

            //ذخیره مجموع مبالغ بند 18
            double AL1Amount = Convert.ToDouble(dgvArz.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable().Where(r => r.Cells["AL"].Value.ToString() == "1")
                                   .Sum(x => double.Parse(x.Cells["مبلغ"].Value.ToString())));
            double AL2Amount = Convert.ToDouble(dgvArz.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable().Where(r => r.Cells["AL"].Value.ToString() == "2")
                                   .Sum(x => double.Parse(x.Cells["مبلغ"].Value.ToString())));
            amount = Math.Abs(AL1Amount - AL2Amount) * 0.08;
            new DAL.CapitalAdequacy().Insert_Amount_Historic(18, amount, fdpDate.SelectedDateTime);

            Routines.ShowMessageBoxFa("مجموع مبالغ بندها با موفقیت ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvRisk_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateRiskBalancedAmount(e, dgvRisk);
        }
        private void CalculateRiskBalancedAmount(DataGridViewCellEventArgs e, DataGridView dgv)
        {
            double Remaining, percent;
            if (dgv["مبلغ", e.RowIndex].Value.ToString() != "")
            {
                Remaining = Convert.ToDouble(dgv["مبلغ", e.RowIndex].Value);
                percent = Convert.ToDouble(dgv["ضریب ریسک", e.RowIndex].Value);
                Remaining = Remaining * (percent / 100);
                dgv["مبلغ با احتساب ضریب ریسک", e.RowIndex].Value = Remaining.ToString();
            }
        }
    }
}
