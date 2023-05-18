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
    public partial class frmCreditRiskBalancedAsset : BaseForm
    {
        #region Vars
        private FSM fsm;
        private string filter, Description;
        private double Amount;
        private DataTable dt;
        #endregion

        private void frmCapitalAdecuacy_Load(object sender, EventArgs e)
        {
            fdpDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate();
            filter = "";
            fsm = new FSM();
            RebindFSM();
            RebindPortfolio();
            RebindRanking();
        }

        public frmCreditRiskBalancedAsset()
        {
            InitializeComponent();
        }

        private void RebindFSM()
        {
            cmbFSM2.DataSource = cmbFSM.DataSource = fsm.GetFSMs();
            cmbFSM2.DisplayMember = cmbFSM.DisplayMember = FSM.CTE_Alias_ModelName;
            cmbFSM2.ValueMember = cmbFSM.ValueMember = FSM.CTE_Alias_ID;
            cmbFSM2.SelectedIndex = cmbFSM.SelectedIndex = -1;
        }

        private void RebindRanking()
        {
            var BanksRanking_DataTable = new DAL.CapitalAdequacy().GetDT_BanksRanking();
            cmbRank1.DisplayMember = cmbRank2.DisplayMember = cmbRank3.DisplayMember = cmbRank4.DisplayMember = "Rank";
            cmbRank1.ValueMember = cmbRank2.ValueMember = cmbRank3.ValueMember = cmbRank4.ValueMember = "Risk_Weight";
            cmbRank1.DataSource = cmbRank2.DataSource = cmbRank3.DataSource = cmbRank4.DataSource = BanksRanking_DataTable;
        }

        private void RebindPortfolio()
        {
            cmbPortfolio.DataSource = new DAL.MR_DataSet().GetPortfolios();
            cmbPortfolio.DisplayMember = "Code";
            cmbPortfolio.ValueMember = "Id";
            cmbPortfolio.SelectedIndex = -1;
        }

        private void cmbFSM_SelectionChanged(object sender, EventArgs e)
        {
            dt = new DAL.CapitalAdequacy().GetDT_FSMElementsValue((int)cmbFSM.SelectedValue, fdpDate.SelectedDateTime, 0, "");
            dgvUpLineData.DataSource = dt;
            dgvUpLineData.Columns["groupName"].Visible = false;
        }

        private void cmbPortfolio_SelectionChanged(object sender, EventArgs e)
        {
            filter = "and Portfolio.Id= " + cmbPortfolio.SelectedValue.ToString();
            dgvCorpCollab.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(611, 0, fdpDate.SelectedDateTime, filter);
        }

        private void cmbFSM2_SelectionChanged(object sender, EventArgs e)
        {
            dt = new DAL.CapitalAdequacy().GetDT_FSMElementsValue((int)cmbFSM2.SelectedValue, fdpDate.SelectedDateTime, 0, "");
            dgvOtherFSM.DataSource = dt;
            dgvOtherFSM.Columns["groupName"].Visible = false;
        }

        private void cbStart_CButtonClicked(object sender, EventArgs e)
        {
            if (tabMain.Enabled == false)
                tabMain.Enabled = true;

            if (cmbFSM.SelectedIndex != -1)
            {
                dt = new DAL.CapitalAdequacy().GetDT_FSMElementsValue((int)cmbFSM.SelectedValue, fdpDate.SelectedDateTime, 0, "");
                dgvUpLineData.DataSource = dt;
                dgvUpLineData.Columns["groupName"].Visible = false;
            }

            try
            {
                //بند 5-11- اصل تسهیلات اعطایی در قالب عقود مشارکتی
                dgvCollabLoans.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(511, 0, fdpDate.SelectedDateTime, filter);

                //بند 6-11- مشارکت حقوقی - سرمایه گذاری در سهام غیر تجاری
                if (cmbPortfolio.SelectedIndex != -1)
                    dgvCorpCollab.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(611, 0, fdpDate.SelectedDateTime, filter);

                //بند 7-11- مانده اصل و سود تسهیلات اعطایی در قالب عقود غیر مشارکتی
                dgvNonCollabLoans.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(711, 0, fdpDate.SelectedDateTime, filter);
                //dgvNonCollabLoans.Columns["مبلغ با احتساب ضریب ریسک"].ValueType = typeof(Int64);

                //بند 11-11- خالص مانده مطالبات غیر جاری
                dgvHR.DataSource = new DAL.CapitalAdequacy().GetDT_CA_Band_11_HR();
                dgvHR.Columns["ID"].Visible = false;

                //بند 6-14- ضمانتنامه های ریالی یا ارزی پس از کسر سپرده نقدی
                dgvGuarantee.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(14, 0, fdpDate.SelectedDateTime, filter);

                //بند 2-11- بخش مطالبات از مؤسسات اعتباری و بانکها
                dt = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(211, 0, fdpDate.SelectedDateTime, filter);


                //سپرده کوتاه مدت سایر بانکها
                var query = from myRow in dt.AsEnumerable()
                            where myRow.Field<int>("Type") == 2
                            select myRow;
                dgvDeposit1.DataSource = query.CopyToDataTable();
                dgvDeposit1.Columns["Type"].Visible = false;
                // سپرده ارزی دیداری نزد بانکهای داخلی
                query = from myRow in dt.AsEnumerable()
                        where myRow.Field<int>("Type") == 3
                        select myRow;
                dgvDeposit2.DataSource = query.CopyToDataTable();
                dgvDeposit2.Columns["Type"].Visible = false;
                //سپرده دیداری نزد بانکهای خارجی
                query = from myRow in dt.AsEnumerable()
                        where myRow.Field<int>("Type") == 4
                        select myRow;
                dgvDeposit3.DataSource = query.CopyToDataTable();
                dgvDeposit3.Columns["Type"].Visible = false;
                //تسهیلات اعطایی به بانکها
                query = from myRow in dt.AsEnumerable()
                        where myRow.Field<int>("Type") == 5
                        select myRow;
                dgvDeposit4.DataSource = query.CopyToDataTable();
                dgvDeposit4.Columns["Type"].Visible = false;
            }
            catch (Exception ex)
            { }
        }


        #region Load_Deatil_Information
        private void dgvUpLineData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUpLineData.CurrentCell.OwningColumn.Name != "ضریب ریسک")
            {
                try
                {
                    ProgressBox.Show();
                    string groupName = Convert.ToString(dgvUpLineData["groupName", e.RowIndex].Value);
                    dgvUpLineDataDetail.DataSource = new DAL.CapitalAdequacy().GetDT_FSMElementsValue((int)cmbFSM.SelectedValue, fdpDate.SelectedDateTime, 1, groupName);
                    ProgressBox.Hide();
                }
                catch (Exception ex)
                {
                    ProgressBox.Hide();
                }
            }
        }

        private void dgvCollabLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCollabLoans.CurrentCell.OwningColumn.Name != "ضریب ریسک")
            {
                try
                {
                    ProgressBox.Show();
                    //if (dgvCollabLoans.Rows[0].Selected)
                    if (dgvCollabLoans.CurrentCell.OwningRow.Index == 0)
                        dgvCollabLoansDetail.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(511, 1511, fdpDate.SelectedDateTime, filter);

                    //if (dgvCollabLoans.Rows[1].Selected)
                    if (dgvCollabLoans.CurrentCell.OwningRow.Index == 1)
                        dgvCollabLoansDetail.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(511, 2511, fdpDate.SelectedDateTime, filter);
                    ProgressBox.Hide();
                }
                catch (Exception ex)
                {
                    ProgressBox.Hide();
                }
            }
        }

        private void dgvCorpCollab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCorpCollab.CurrentCell.OwningColumn.Name != "ضریب ریسک")
            {
                try
                {
                    ProgressBox.Show();
                    dgvCorpCollabDetail.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(611, 1611, fdpDate.SelectedDateTime, filter);
                    ProgressBox.Hide();
                }
                catch (Exception ex)
                {
                    ProgressBox.Hide();
                }
            }
        }

        private void dgvNonCollabLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex > 0)
            {
                FillRanges(e.RowIndex, e);
            }

            else if (dgvNonCollabLoans.CurrentCell.OwningColumn.Name != "ضریب ریسک")
                
            {
                if (e.RowIndex == 0)
                {
                    try
                    {
                        ProgressBox.Show();
                        dgvNonCollabLoansDetail.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(711, 1711, fdpDate.SelectedDateTime, filter);
                        ProgressBox.Hide();
                    }
                    catch (Exception ex)
                    {
                        ProgressBox.Hide();
                    }
                }
                else
                {
                    LoadDetail(e);
                }
            }
        }

        private void dgvNetRemaining_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNetRemaining.CurrentCell.OwningColumn.Name != "ضریب ریسک")
            {
                try
                {
                    ProgressBox.Show();
                    //کمتر از 20 درصد مطالبات غیر جاری
                    if (dgvNetRemaining.CurrentCell.OwningRow.Index == 0)
                        dgvNetRemainingDetail.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(1111, 11111, fdpDate.SelectedDateTime, filter);

                    //از 20 تا 50 درصد مطالبات غیر جاری
                    if (dgvNetRemaining.CurrentCell.OwningRow.Index == 1)
                        dgvNetRemainingDetail.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(1111, 21111, fdpDate.SelectedDateTime, filter);

                    //پنجاه درصد مانده مطالبات غیر جاری و بالاتر از آن
                    if (dgvNetRemaining.CurrentCell.OwningRow.Index == 2)
                        dgvNetRemainingDetail.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(1111, 31111, fdpDate.SelectedDateTime, filter);
                    ProgressBox.Hide();
                }
                catch (Exception ex)
                {
                    ProgressBox.Hide();
                }
            }
        }

        private void dgvGuarantee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGuarantee.CurrentCell.OwningColumn.Name != "ضریب ریسک")
            {
                try
                {
                    ProgressBox.Show();
                    if (dgvGuarantee.CurrentCell.OwningRow.Index == 0)
                        dgvGuaranteeDetail.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(14, 414, fdpDate.SelectedDateTime, filter);
                    if (dgvGuarantee.CurrentCell.OwningRow.Index == 1)
                        dgvGuaranteeDetail.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(14, 514, fdpDate.SelectedDateTime, filter);
                    if (dgvGuarantee.CurrentCell.OwningRow.Index == 2)
                        dgvGuaranteeDetail.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(14, 614, fdpDate.SelectedDateTime, filter);
                    ProgressBox.Hide();
                }
                catch (Exception ex)
                {
                    ProgressBox.Hide();
                }
            }
        }

        private void LoadDetail(DataGridViewCellEventArgs e)
        {
            if (dgvNonCollabLoans[4, e.RowIndex].Value.ToString() == "" || dgvNonCollabLoans[5, e.RowIndex].Value.ToString() == "")
            {
                Routines.ShowErrorMessageFa("خطا در ورودی", "حدود پایین و بالا مشخص نشده است.",
                                            MyDialogButton.OK);
                return;
            }
            else
            {
                try
                {
                    ProgressBox.Show();
                    double min = Convert.ToDouble(dgvNonCollabLoans[4, e.RowIndex].Value);
                    double max = Convert.ToDouble(dgvNonCollabLoans[5, e.RowIndex].Value);
                    dt = new DAL.CapitalAdequacy().Calculate_CreditRisk_Band711(e.RowIndex, 1, fdpDate.SelectedDateTime, min, max, out Amount, out Description);
                    dgvNonCollabLoansDetail.DataSource = dt;
                    ProgressBox.Hide();
                }
                catch (Exception ex)
                {
                    ProgressBox.Hide();
                }
            }
        }
        #endregion

        #region Edit_Risk_Rates
        private void dgvUpLineData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateRiskBalancedAmount(e, dgvUpLineData);
        }

        private void dgvCollabLoans_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateRiskBalancedAmount(e, dgvCollabLoans);
        }

        private void dgvCorpCollab_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateRiskBalancedAmount(e, dgvCorpCollab);
        }

        private void dgvNonCollabLoans_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateRiskBalancedAmount(e, dgvNonCollabLoans);
        }

        private void dgvHR_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string condition = Convert.ToString(dgvHR["شرح وثیقه", e.RowIndex].Value);
            double rate = Convert.ToDouble(dgvHR["ضریب تعدیل وثیقه", e.RowIndex].Value);
            new DAL.CapitalAdequacy().Update_CA_Band_11_HR(condition, rate);
        }

        private void dgvNetRemaining_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateRiskBalancedAmount(e, dgvNetRemaining);
        }

        private void dgvOtherFSM_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateRiskBalancedAmount(e, dgvOtherFSM);
        }

        private void dgvGuarantee_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateRiskBalancedAmount(e, dgvGuarantee);
        }
        #endregion

        private void FillRanges(int RowIndex, DataGridViewCellEventArgs e)
        {
            double MinLimit, MaxLimit;

            frmAddRange addrange = new frmAddRange();
            addrange.ShowDialog();
            if (addrange.From != -1)
            {
                MinLimit = addrange.From;
                MaxLimit = addrange.To;

                dt = new DAL.CapitalAdequacy().Calculate_CreditRisk_Band711(e.RowIndex, 0, fdpDate.SelectedDateTime, MinLimit, MaxLimit, out Amount, out Description);
                dgvNonCollabLoans[e.ColumnIndex + 2, e.RowIndex].Value = Description;
                dgvNonCollabLoans[e.ColumnIndex + 3, e.RowIndex].Value = Amount.ToString();
                dgvNonCollabLoans[e.ColumnIndex + 4, e.RowIndex].Value = MinLimit.ToString();
                dgvNonCollabLoans[e.ColumnIndex + 5, e.RowIndex].Value = MaxLimit.ToString();

                CalculateRiskBalancedAmount(e, dgvNonCollabLoans);
            }
        }

        private void CalculateRiskBalancedAmount(DataGridViewCellEventArgs e, DataGridView dgv)
        {
            double Remaining, percent;
            if (dgv["مبلغ", e.RowIndex].Value.ToString() != "")
            {
                Remaining = Convert.ToDouble(dgv["مبلغ", e.RowIndex].Value);
                percent = Convert.ToDouble(dgv["ضریب ریسک", e.RowIndex].Value);
                Remaining = Remaining * (percent / 100);
                dgv["مبلغ با احتساب ضریب ریسک", e.RowIndex].Value = Remaining;
            }
        }

        #region Save_Final_Amounts
        private void cbConfirm_CButtonClicked(object sender, EventArgs e)
        {
            dgvNetRemaining.DataSource = new DAL.CapitalAdequacy().Calculate_CreditRisk_Balanced_Asset(1111, 0, fdpDate.SelectedDateTime, filter);
        }

        private void cbConfirm1_CButtonClicked(object sender, EventArgs e)
        {
            SaveAmount(111, dgvUpLineData);
        }

        private void cbConfirm2_CButtonClicked(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(dgvDeposit1.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable()
                                   .Sum(x => double.Parse(x.Cells["مبلغ با احتساب ضریب ریسک"].Value.ToString())));
            amount += Convert.ToDouble(dgvDeposit2.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable()
                                   .Sum(x => double.Parse(x.Cells["مبلغ با احتساب ضریب ریسک"].Value.ToString())));
            amount += Convert.ToDouble(dgvDeposit3.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable()
                                   .Sum(x => double.Parse(x.Cells["مبلغ با احتساب ضریب ریسک"].Value.ToString())));
            amount += Convert.ToDouble(dgvDeposit4.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable()
                                   .Sum(x => double.Parse(x.Cells["مبلغ با احتساب ضریب ریسک"].Value.ToString())));

            new DAL.CapitalAdequacy().Insert_Amount_Historic(211, amount, fdpDate.SelectedDateTime);
            Routines.ShowMessageBoxFa("مجموع مبالغ با موفقیت ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbConfirm3_CButtonClicked(object sender, EventArgs e)
        {
            SaveAmount(511, dgvCollabLoans);
        }

        private void cbConfirm4_CButtonClicked(object sender, EventArgs e)
        {
            SaveAmount(611, dgvCorpCollab);
        }

        private void cbConfirm5_CButtonClicked(object sender, EventArgs e)
        {
            SaveAmount(711, dgvNonCollabLoans);
        }

        private void cbConfirm6_CButtonClicked(object sender, EventArgs e)
        {
            SaveAmount(1111, dgvNetRemaining);
        }

        private void cbConfirm7_CButtonClicked(object sender, EventArgs e)
        {
            SaveAmount(811, dgvNetRemaining);
        }

        private void cbConfirm8_CButtonClicked(object sender, EventArgs e)
        {
            SaveAmount(614, dgvGuarantee);
        }

        private void SaveAmount(int band, DataGridView dgv)
        {
            double amount = Convert.ToDouble(dgv.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable()
                                   .Sum(x => double.Parse(x.Cells["مبلغ با احتساب ضریب ریسک"].Value.ToString())));
            new DAL.CapitalAdequacy().Insert_Amount_Historic(band, amount, fdpDate.SelectedDateTime);
            Routines.ShowMessageBoxFa("مجموع مبالغ با موفقیت ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        //تعیین ضرایب ریسک با توجه به رتبه موسسات اعتباری و بانکها
        private void dgvDeposit1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                dgvDeposit1["ضریب ریسک", e.RowIndex].Value = dgvDeposit1["cmbRank1", e.RowIndex].Value;
                CalculateRiskBalancedAmount(e, dgvDeposit1);
            }
        }

        private void dgvDeposit2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                dgvDeposit2["ضریب ریسک", e.RowIndex].Value = dgvDeposit2["cmbRank2", e.RowIndex].Value;
                CalculateRiskBalancedAmount(e, dgvDeposit2);
            }
        }

        private void dgvDeposit3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                dgvDeposit3["ضریب ریسک", e.RowIndex].Value = dgvDeposit3["cmbRank3", e.RowIndex].Value;
                CalculateRiskBalancedAmount(e, dgvDeposit3);
            }
        }

        private void dgvDeposit4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                dgvDeposit4["ضریب ریسک", e.RowIndex].Value = dgvDeposit4["cmbRank4", e.RowIndex].Value;
                CalculateRiskBalancedAmount(e, dgvDeposit4);
            }
        }
    }
}
