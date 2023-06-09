using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERMS.Logic;
using Presentation.Public;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmNewNII : BaseForm
    {
        #region VARS
        private bool bInUpdate = false;
        #endregion

        public frmNewNII()
        {
            InitializeComponent();
        }

        private void frmNewModel_Load(object sender, EventArgs e)
        {
            FSM fsm = new FSM();
            cmbFSM.DataSource = fsm.GetFSMs();
            cmbFSM.DisplayMember = FSM.CTE_Alias_ModelName;
            cmbFSM.ValueMember = FSM.CTE_Alias_ID;

            CBM cbm = new CBM();
            cmbCBM.DataSource = cbm.GetCBMs();
            cmbCBM.DisplayMember = CBM.CTE_Alias_ModelName;
            cmbCBM.ValueMember = CBM.CTE_Alias_ID;         
        }

        public bool InUpdate
        {
            get { return bInUpdate; }
            set 
            { 
                bInUpdate = value;
                cmbFSM.Enabled = !bInUpdate;
            }            
        }

        public int FSModelID
        {
            get { return (int)cmbFSM.SelectedValue; }
            set { cmbFSM.SelectedByDataValue(value); }      
        }

        public int CBModelID
        {
            get { return (int)cmbCBM.SelectedValue; }
            

        }
        public string Title
        {
            get { return txtTitle.Text; }
            set { txtTitle.Text = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

          

            if ((txtTitle.Text == string.Empty) || (cmbFSM.SelectedIndex == -1) )
            {
                Presentation.Public.Routines.ShowMessageBoxFa("لطفا نام مدل، مدل صورت وضعيت مالی و مدل دلخواه پركردن بسته های زمانی مرتبط با آن را انتخاب كنيد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.None;
            }
            else
             this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void frmNewNII_KeyDown(object sender, KeyEventArgs e)
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