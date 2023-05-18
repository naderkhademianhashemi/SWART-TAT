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
    public partial class frmSupervisionCapital : BaseForm
    {
        #region Vars
        private FSM fsm;
        private DataTable dt, fsmSource;
        private string displayMember, valueMember;
        #endregion

        private void frmCapitalAdecuacy_Load(object sender, EventArgs e)
        {
            fdpDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate();
            fsm = new FSM();
            RebindFSM();

            cmbFSM1.DataSource = cmbFSM2.DataSource = fsmSource;
            cmbFSM1.DisplayMember = cmbFSM2.DisplayMember = displayMember;
            cmbFSM1.ValueMember = cmbFSM2.ValueMember = valueMember;
            cmbFSM1.SelectedIndex = cmbFSM2.SelectedIndex = -1;

            dgv24.DataSource = new DAL.CapitalAdequacy().Get_Imported_Data(24);
            dgv44.DataSource = new DAL.CapitalAdequacy().Get_Imported_Data(44);
            dgv84.DataSource = new DAL.CapitalAdequacy().Get_Imported_Data(84);
        }

        private void cbStart_CButtonClicked(object sender, EventArgs e)
        {
            if (tabMain.Enabled == false)
                tabMain.Enabled = true;

            if (cmbFSM1.SelectedIndex != -1)
            {
                GetFSMElements(dgvTadilat1, (int)cmbFSM1.SelectedValue);
            }

            if (cmbFSM2.SelectedIndex != -1)
            {
                GetFSMElements(dgvLayer2, (int)cmbFSM2.SelectedValue);
            }
        }

        private void cmbFSM1_SelectionChanged(object sender, EventArgs e)
        {
            GetFSMElements(dgvTadilat1, (int)cmbFSM1.SelectedValue);
        }

        private void cmbFSM2_SelectionChanged(object sender, EventArgs e)
        {
            GetFSMElements(dgvLayer2, (int)cmbFSM2.SelectedValue);
        }

        public frmSupervisionCapital()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
        }

        private void cbConfirm_CButtonClicked(object sender, EventArgs e)
        {
            if (dgvTadilat1.DataSource == null || dgvLayer2.DataSource == null)
            {
                Routines.ShowErrorMessageFa("خطا در ورودی", "اجزاء سرمایه تکمیل نشده است",
                                            MyDialogButton.OK);
                return;
            }
            else
            {
                //محاسبه مجموع مبالغ بند 3 و 4
                double Band13 = Convert.ToDouble(dgvTadilat1.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable().Where(r => r.Cells["بند"].Value.ToString() == "13" 
                                   || r.Cells["بند"].Value.ToString() == "33" || r.Cells["بند"].Value.ToString() == "34"
                                   || r.Cells["بند"].Value.ToString() == "36")
                                   .Sum(x => double.Parse(x.Cells["مبلغ"].Value.ToString())));
                double Band34 = Convert.ToDouble(dgvTadilat1.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable().Where(r => r.Cells["بند"].Value.ToString() == "34")
                                   .Sum(x => double.Parse(x.Cells["مبلغ"].Value.ToString())));
                new DAL.CapitalAdequacy().Insert_Amount_Historic(13, Band13, fdpDate.SelectedDateTime);
                new DAL.CapitalAdequacy().Insert_Amount_Historic(34, Band34, fdpDate.SelectedDateTime);

                //مجموع مبالغ 2-4
                double amount = Convert.ToDouble(dgv24.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable()
                                   .Sum(x => double.Parse(x.Cells["ارزش سرمایه گذاری"].Value.ToString())));
                new DAL.CapitalAdequacy().Insert_Amount_Historic(24, amount, fdpDate.SelectedDateTime);

                //مجموع مبالغ 8-4
                amount = Convert.ToDouble(dgv24.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable()
                                   .Sum(x => double.Parse(x.Cells["ارزش سرمایه گذاری"].Value.ToString())));
                new DAL.CapitalAdequacy().Insert_Amount_Historic(84, amount, fdpDate.SelectedDateTime);

                SaveAmount(25, dgvLayer2);
                Presentation.Public.Routines.ShowMessageBoxFa("مجموع مبالغ با موفقیت ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RebindFSM()
        {
            fsmSource = fsm.GetFSMs();
            displayMember = FSM.CTE_Alias_ModelName;
            valueMember = FSM.CTE_Alias_ID;
        }

        private void GetFSMElements(DataGridView dgv, int FSM)
        {
            dt = new DAL.CapitalAdequacy().GetDT_FSMElementsValue(FSM, fdpDate.SelectedDateTime, 2, "");
            dgv.DataSource = dt;
            dgv.Columns["AL"].Visible = false;
        }

        private void SaveAmount(int band, DataGridView dgv)
        {
            double amount = Convert.ToDouble(dgv.Rows.Cast<DataGridViewRow>()
                                   .AsEnumerable()
                                   .Sum(x => double.Parse(x.Cells["مبلغ"].Value.ToString())));
            new DAL.CapitalAdequacy().Insert_Amount_Historic(band, amount, fdpDate.SelectedDateTime);
        }

    }
}
