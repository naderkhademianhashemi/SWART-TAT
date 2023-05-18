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
    public partial class frmCaption: Form
    {
        #region CONST
        private const int CTE_Asset_ID = 1;
        private const int CTE_Liability_ID = 2;

        private const string CTE_Asset = "Asset";
        private const string CTE_Liability = "Liability";
        #endregion

        #region VAR
        private AGM agm;
        //Revised - 1.1
        private static Color prevColor = System.Drawing.Color.FromArgb(255,128,128);
        #endregion

        public frmCaption()
        {
            InitializeComponent();
            agm = new AGM();

            if (cmbGroupName.Items.Count == 0)
            {
        
                cmbGroupName.DataSource = agm.GetAccountGroups();
                cmbGroupName.DisplayMember = AGM.CTE_Alias_AccountGroup_GroupName;
            }
            //Revised - 1.1
           lblColor.BackColor = prevColor;
        }

        public string GroupName
        {
            get
            {
                return cmbGroupName.Text;
            }
            set
            {                
                cmbGroupName.Text = value;
                cmbGroupName.Enabled = true;
                rdoAccountGroup.Checked = true;                
            }
        }

        public string GroupTitle
        {
            get
            {
                return txtGroupTitle.Text;
            }
            set
            {
                if (value != string.Empty)
                {
                    txtGroupTitle.Text = value;
                    txtGroupTitle.Enabled = true;
                    rdoGroupTitle.Checked = true;                    
                }
            }
        }

        public int Color
        {
            get
            {
                return lblColor.BackColor.ToArgb();
            }
            set
            {
                lblColor.BackColor = System.Drawing.Color.FromArgb(value);
            }
        }

        public bool IsTitle
        {
            get { return rdoGroupTitle.Checked; }
        }

        private void frmCaption_Load(object sender, EventArgs e)
        {            
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAccountGroup.Checked)
            {
                txtGroupTitle.Enabled = false;
                txtGroupTitle.Text = string.Empty;
                cmbGroupName.Enabled = true;

            }
            if (rdoGroupTitle.Checked)
            {
                txtGroupTitle.Enabled = true;
                cmbGroupName.Enabled = false;
                cmbGroupName.SelectedIndex = -1;                
            }
        }

        private void frmCaption_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            if (e.KeyChar == (char)Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblColor.BackColor = colorDialog.Color;
            }
        }

        private void frmCaption_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((rdoGroupTitle.Checked && (txtGroupTitle.Text == string.Empty) && (this.DialogResult != DialogResult.Cancel)) || (rdoAccountGroup.Checked && (cmbGroupName.Text == string.Empty) && (this.DialogResult != DialogResult.Cancel)))
            {
                Presentation.Public.Routines.ShowMessageBoxFa("لطفاً عنوان گروه را وارد كنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
            //Revised - 1.1
            prevColor = lblColor.BackColor;
        }

        private void frmCaption_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbGroupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                cmbGroupName.SelectedText = cmbGroupName.Contains(e.KeyChar.ToString());
        }

    

       
    }
}