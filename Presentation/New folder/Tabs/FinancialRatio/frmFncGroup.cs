using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERMS.Logic;
using ERMS.Model;

//
using ERMSLib;
using Presentation.Public;

namespace Presentation.Tabs.FinancialRatio
{
    public partial class frmFncGroup : BaseForm
    {
        #region CONST
        private const string CTE_Asset = "دارايی";
        private const string CTE_Liability = "بدهی";

        private const string CTE_Account_GL = "حسابها - دفتر كل";
        private const string CTE_Account_NA = "حسابهای متفرقه";
        private const string CTE_Account_199 = "حسابها - دفتر كل 199 ";
        #endregion

        #region VAR

        private static Color prevColor = System.Drawing.Color.LightBlue;
        #endregion

        private FncRatioInfo info;
        public FncRatioInfo Info
        {
            get { return info; }
            set { info = value; }
        }

        public frmFncGroup()
        {
            InitializeComponent();

            cmbAccountCategory.AddItemsRange(new string[] { CTE_Account_GL, CTE_Account_NA, CTE_Account_199 });
            cmbAccountCategory.SelectedIndex = 0;

            cmbAccountType.AddItemsRange(new string[] { CTE_Asset, CTE_Liability });
            cmbAccountType.SelectedIndex = 0;

            lblColor.BackColor = prevColor;
        }

        private void frmFncGroup_Load(object sender, EventArgs e)
        {
            if (info.GroupName != string.Empty)
            {
                rdoGroup.Checked = info.GroupName != string.Empty;

                txtGroupName.Text = info.GroupName;

                if (info.GroupName != string.Empty)
                {
                    cmbAccountCategory.SelectedIndex = info.GL - 1;
                    cmbAccountType.SelectedIndex = info.AL - 1;
                }
                else
                {
                    cmbAccountCategory.SelectedIndex = 0;
                    cmbAccountType.SelectedIndex = 0;
                }
                lblColor.BackColor = Color.FromArgb(info.Color);
            }
            else
            {
                txtGroupName.Text = string.Empty;
                lblColor.BackColor = prevColor;
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGroup.Checked)
            {
                txtGroupName.Enabled = true;
                cmbAccountCategory.Enabled = true;
                cmbAccountType.Enabled = true;
            }
        }
       
        private bool CheckExist(string groupName)
        {
            bool flag = true;
            FncRatio_BL Fnc_BL = new FncRatio_BL();

            DataTable dt = new DataTable();
            dt = Fnc_BL.GetDTFncRatios();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["GroupName"].ToString().ToLower().Trim() == groupName.ToLower().Trim())
                {
                    flag = false;
                    break;
                }
            }
            return flag;

        }

        private void frmFncGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void frmFncGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((rdoGroup.Checked && txtGroupName.Text == string.Empty)) && DialogResult != DialogResult.Cancel)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("لطفا نام گروه يا عنوان خود را انتخاب كنيد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
            prevColor = lblColor.BackColor;
        }

        private void frmFncGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Confirm()
        {
            if (CheckExist(txtGroupName.Text))
            {
                info.GroupName = txtGroupName.Text;
                info.GL = cmbAccountCategory.SelectedIndex + 1;
                info.AL = cmbAccountType.SelectedIndex + 1;
                info.Color = lblColor.BackColor.ToArgb();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;

                Presentation.Public.Routines.ShowMessageBoxFa("گروهی با اين نام وجود دارد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblColor.BackColor = colorDialog.Color;
            }
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}