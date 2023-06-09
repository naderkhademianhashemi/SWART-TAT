using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERMS.Logic;


namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmNewCBM : BaseForm
    {
        private TBM tbm;
        private FSM fsm;
        public string Title
        {
            get { return txtDesc.Text; }
            set { txtDesc.Text = value; }
        }

        public int TimeBucketID
        {
            get { return (int)cmbTimeBucket.SelectedValue; }
            set { cmbTimeBucket.SelectedByDataValue(value); }
        }
        public int fsModelID
        {
            get { return (int)cmbFSM.SelectedValue; }
            set { cmbFSM.SelectedByDataValue(value); }
        }
        public frmNewCBM()
        {
            InitializeComponent();
        }

        private void frmNewCBM_Load(object sender, EventArgs e)
        {
            RebindTBM();
            RebindFSM();

        }
        // add by soltani
        private void RebindTBM()
        {
            tbm = new TBM();

            cmbTimeBucket.DataSource = tbm.GetTBMs();
            cmbTimeBucket.DisplayMember = "ModelName";
            cmbTimeBucket.ValueMember = "ID";
        }
        private void RebindFSM()
        {
            fsm = new FSM();

            cmbFSM.DataSource = fsm.GetFSMs();
            cmbFSM.DisplayMember = FSM.CTE_Alias_ModelName;
            cmbFSM.ValueMember = FSM.CTE_Alias_ID;
        }

        //
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text.Trim().Length == 0)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("عنوان درستی برای مدل اقلام بدون سررسید وارد نشده است ",
                                                                    "خطا در ورود اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cmbFSM.SelectedIndex == -1 || cmbTimeBucket.SelectedIndex == -1)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("برای تعریف مدل اقلام بدون سررسید، انتخاب بسته زمانی و صورت وضعیت مالی الزامی است",
                                                                    "خطا در ورود اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void frmNewCBM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                btnOK_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }
        }

        private void btnCancel_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}