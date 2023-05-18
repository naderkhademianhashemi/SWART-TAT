using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using ERMS.Logic;
using ERMS.Model;
//     
using ERMSLib;
using Presentation.Public;


namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmGroup : BaseForm
    {
        #region CONST
        private const string CTE_Asset = "دارايی";
        private const string CTE_Liability = "بدهی";
        private const string CTE_Capital = "سرمایه";
        private const string CTE_UnderLineItems_LG = "ضمانتنامه ریالی";
        private const string CTE_UnderLineItems_LC = "اعتبارات اسنادی ارزی";   
        private const string CTE_Income = "درآمد";
        private const string CTE_Cost = "هزینه";
        private const string CTE_Currency_LG = "ضمانت نامه ارزی";
        private const string CTE_Underline = "اقلام زیرخط";   

        private const string CTE_Account_GL = "حسابها - دفتر كل";
        private const string CTE_Account_NA = "حسابهای متفرقه";
        private const string CTE_Account_199 = "حسابها - دفتر كل 199 ";
        private const string CTE_AccountGL_Cur = "حسابها-دفتر کل ارزی";
        #endregion

        #region VAR
        private AccountGroupInfo info;
        private static Color prevColor = System.Drawing.Color.LightBlue;
        #endregion

        public AccountGroupInfo Info
        {
            get { return info; }
            set { info = value; }
        }
        public frmGroup()
        {
            InitializeComponent();            

            //cmbAccountCategory.AddItemsRange(new string[] { CTE_Account_GL, CTE_Account_NA, CTE_Account_199 });
            cmbCurrency.DisplayMember = "Currency_Description";
            cmbCurrency.ValueMember = "Currency";

            cmbAccountCategory.AddItemsRange(new string[] { CTE_Account_GL, CTE_AccountGL_Cur});  
            cmbAccountCategory.SelectedIndex = 0;

            cmbAccountType.AddItemsRange(new string[] {CTE_Asset, CTE_Liability, CTE_UnderLineItems_LG, CTE_UnderLineItems_LC, 
                                                            CTE_Income, CTE_Cost, CTE_Currency_LG , CTE_Underline});
            cmbAccountType.SelectedIndex = 0;

            lblColor.BackColor = prevColor;
        }       
        private void frmGroup_Load(object sender, EventArgs e)
        {
            cmbCurrency.DataSource = new DAL.Table_DataSetTableAdapters.CurrencyTableAdapter().GetData();

            var _IRR_Currncy=new DAL.Table_DataSetTableAdapters.CurrencyTableAdapter().GetIRRCurrency().FirstOrDefault();

            if (_IRR_Currncy != null)
                cmbCurrency.SelectedByDataValue(_IRR_Currncy.Currency);

            if (info.GroupName != string.Empty || info.GroupTitle != string.Empty)
            {
                rdoGroup.Checked = info.GroupName != string.Empty;
                rdoTitle.Checked = info.GroupTitle != string.Empty;

                txtGroupName.Text = info.GroupName;
                txtTitle.Text = info.GroupTitle;

                if (info.GroupName != string.Empty)
                {
                    cmbAccountCategory.SelectedIndex = info.GL - 1;
                    cmbAccountType.SelectedIndex = info.AL - 1;
                    cmbCurrency.SelectedByDataValue(info.CurrencyId);
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
                txtTitle.Text = string.Empty;

                rdoTitle.Checked = true;
                lblColor.BackColor = prevColor;
            }
        }
        private void CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGroup.Checked)
            {
                txtTitle.Enabled = false;
                txtTitle.Text = string.Empty;
                txtGroupName.Enabled = true;
                cmbAccountCategory.Enabled = true;
                cmbAccountType.Enabled = true;
                cmbCurrency.Enabled = true;
            }
            if (rdoTitle.Checked)
            {
                txtTitle.Enabled = true;
                txtGroupName.Enabled = false;
                cmbAccountCategory.Enabled = false;
                cmbAccountType.Enabled = false;
                cmbCurrency.Enabled = false;
            }
        }        
        private void btnOK_Click(object sender, EventArgs e)
        {
            Confirm();

        }
        private void Confirm()
        {
            if (CheckExist(txtGroupName.Text))
            {
                info.GroupName = txtGroupName.Text;
                info.GroupTitle = txtTitle.Text;
                info.GL = cmbAccountCategory.SelectedIndex + 1;
                info.GL_Cur = cmbAccountCategory.SelectedIndex + 1;
                info.AL = cmbAccountType.SelectedIndex + 1;
                info.Color = lblColor.BackColor.ToArgb();
                info.CurrencyId = Convert.ToInt32(cmbCurrency.SelectedValue);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            { this.DialogResult = DialogResult.Cancel;

            Presentation.Public.Routines.ShowMessageBoxFa("گروهی با اين نام وجود دارد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        // add by soltani
        private bool CheckExist(string groupName)
        {
            bool flag = true;
            AGM agm = new AGM();

            DataTable dt = new DataTable();
            dt = agm.GetAccountGroupsTotal();
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
        private void frmGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK_Click(sender, e);
                //this.DialogResult = DialogResult.OK;
              //  this.Close();
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
        private void frmGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((rdoGroup.Checked && txtGroupName.Text == string.Empty) || (rdoTitle.Checked && txtTitle.Text == string.Empty)) && DialogResult != DialogResult.Cancel)
            {
                Presentation.Public.Routines.ShowMessageBoxFa( "لطفا نام گروه يا عنوان خود را انتخاب كنيد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;                
            }

            prevColor = lblColor.BackColor;
        }

        private void frmGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //  Confirm();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}