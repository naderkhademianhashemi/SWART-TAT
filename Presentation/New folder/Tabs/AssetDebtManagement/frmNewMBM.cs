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
    public partial class frmNewMBM : BaseForm
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
            //set { cmbTimeBucket.SelectedValue = value; }
            set { cmbTimeBucket.SelectedByDataValue(value); }
        }
        public int fsModelID
        {
            get { return (int)cmbFSM.SelectedValue; }
            //set { cmbFSM.SelectedValue = value; }
            set { cmbFSM.SelectedByDataValue(value); }
        }
        public frmNewMBM()
        {
            InitializeComponent();
        }

        private void frmNewMBM_Load(object sender, EventArgs e)
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

        
        private void btnOK_Click(object sender, EventArgs e)
        {
       
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }


        private void frmNewMBM_KeyDown(object sender, KeyEventArgs e)
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

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}