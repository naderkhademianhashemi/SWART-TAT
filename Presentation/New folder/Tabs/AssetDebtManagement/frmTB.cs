using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using ERMS.Model;


namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmTB : BaseForm
    {
        #region VARS
        private const int CTE_Index_Day = 0;
        private const int CTE_Index_Week = 1;
        private const int CTE_Index_Month = 2;
        private const int CTE_Index_Year = 3;
        private const int CTE_Index_ToEnd = 4;
        private const int CTE_Index_Irr = 5;
        private const int CTE_Index_Suspend = 6;

        //Revised - 1.1
        private static Color prevColor = Color.Yellow;
        private TBMElementInfo tbmeInfo;
        #endregion

        public TBMElementInfo ElementInfo
        {
            get { return tbmeInfo; }
            set { tbmeInfo = value; }
        }

        public frmTB()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OK();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
            
        }

        private void OK()
        {
            if (tbmeInfo == null)
                tbmeInfo = new TBMElementInfo();

            if (txtTimeBucket.Text == string.Empty)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("نام بسته معتبر نیست", "داده های نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return;
            }

            try
            {
                int i = Convert.ToInt32(txtLength.Text);
            }
            catch
            {
                Presentation.Public.Routines.ShowMessageBoxFa("طول بسته معتبر نیست", "داده های نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return;
            }

            tbmeInfo.BucketType = cmbBucketType.Text;
            tbmeInfo.BucketLength = Convert.ToInt32(txtLength.Text);
            tbmeInfo.BucketName = txtTimeBucket.Text;
            tbmeInfo.BucketColor = lblColor.BackColor.ToArgb();

            //Revised - 1.1
            prevColor = lblColor.BackColor;
        }

        private void frmTimeBucketDetail_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {
            cmbBucketType.Items.Add("Day");
            cmbBucketType.Items.Add("Week");
            cmbBucketType.Items.Add("Month");
            cmbBucketType.Items.Add("Year");
            if (tbmeInfo == null)
            {
                cmbBucketType.Items.Add("ToEnd");
                cmbBucketType.Items.Add("Irr");
                cmbBucketType.Items.Add("Suspended");
            }
            cmbBucketType.SelectedIndex = cmbBucketType.Items.Count > 0 ? 0 : -1;

            

            if (tbmeInfo != null)
            {                
                cmbBucketType.Text = tbmeInfo.BucketType;
                txtTimeBucket.Text = tbmeInfo.BucketName;
                txtLength.Text = tbmeInfo.BucketLength.ToString();                
                lblColor.BackColor = Color.FromArgb(tbmeInfo.BucketColor)  ;
            }
            //Revised - 1.1
            else
                lblColor.BackColor = prevColor;
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblColor.BackColor = colorDialog.Color;
            }
        }

        private void cmbBucketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (cmbBucketType.SelectedIndex)
            //{
            //    case CTE_Index_Day:
            //    case CTE_Index_Week:
            //    case CTE_Index_Month:
            //    case CTE_Index_Year:
            //        txtLength.Text = "0";
            //        txtLength.Visible = true;
            //        lblLength.Visible = true;
            //        break;

            //    case CTE_Index_Irr:                    
            //        txtLength.Text = "1";
            //        txtLength.Enabled = false;
            //        lblColor.Enabled = false;
            //        break;

            //    case CTE_Index_ToEnd:              
            //        txtLength.Text = "1";
            //        txtLength.Visible = false;
            //        lblLength.Visible = false;
            //        break;

            //    case CTE_Index_Suspend:
            //        txtLength.Text = "1";
            //        txtLength.Visible = false;
            //        lblLength.Visible = false;
            //        break;
            //}
        }

        private void frmTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                OK();

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

        private void cmbBucketType_ValueChanged(object sender, EventArgs e)
        {
            if (cmbBucketType.Text.Equals("Suspended") || cmbBucketType.Text.Equals("ToEnd"))
            {
                txtLength.Text = "1";
                txtLength.Visible = false;
                lblLength.Visible = false;
                pnlBucketLength.Visible = false;
                pnlBucketLength.Size = new Size(pnlBucketLength.Size.Width, 1);
                //MessageBox.Show("dd");
            }
            else
            {
                txtLength.Text = "0";
                txtLength.Visible = true;
                lblLength.Visible = true;
                pnlBucketLength.Visible = true;
                pnlBucketLength.Size = new Size(pnlBucketLength.Size.Width, 39);
            }
            
        }
   }
}