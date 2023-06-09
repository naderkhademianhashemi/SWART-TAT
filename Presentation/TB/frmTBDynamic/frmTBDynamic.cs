using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using ERMS.Logic;
using ERMS.Model;


namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmTBDynamic : Form
    {
        #region VARS
        private const int CTE_Index_Day = 0;
        private const int CTE_Index_Week = 1;
        private const int CTE_Index_Month = 2;
        private const int CTE_Index_Year = 3;
        private const int CTE_Index_ToEnd = 4;
        private const int CTE_Index_Irr = 5;

        //Revised - 1.1
        private static Color prevColor = Color.Yellow;
        private TBMElementInfo tbmeInfo;
        #endregion

        public TBMElementInfo ElementInfo
        {
            get { return tbmeInfo; }
            set { tbmeInfo = value; }
        }
        DateTime from;
        DateTime to;
        public frmTBDynamic(DateTime from,DateTime to)
        {
            InitializeComponent();
            this.from = from;
            this.to = to;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (OK())
            {
                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private bool OK()
        {
            if (tbmeInfo == null)
                tbmeInfo = new TBMElementInfo();

            if (fdpFrom.SelectedDateTime > fdpTo.SelectedDateTime )
            {
                Presentation.Public.Routines.ShowMessageBoxFa("تاریخ معتبر نیست", "داده های نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return false;
            }

            try
            {
                int i = Convert.ToInt32(txtLength.Text);
                if (i < 1)
                    throw new Exception();
                
            }
            catch
            {
                Presentation.Public.Routines.ShowMessageBoxFa("طول بسته معتبر نیست", "داده های نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return false;
            }

            tbmeInfo.BucketType = cmbBucketType.Text;
            tbmeInfo.BucketLength = Convert.ToInt32(txtLength.Text);
            tbmeInfo.BucketName = txtTimeBucket.Text;
            tbmeInfo.BucketColor = lblColor.BackColor.ToArgb();
            tbmeInfo.StartDate = fdpFrom.SelectedDateTime;
            tbmeInfo.EndDate = fdpTo.SelectedDateTime;

            //Revised - 1.1
            prevColor = lblColor.BackColor;
            return true;
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
            cmbBucketType.Items.Add("Other");

            cmbBucketType.SelectedIndex = cmbBucketType.Items.Count > 0 ? 0 : -1;


            fdpFrom.SelectedDateTime = from;
            fdpTo.SelectedDateTime = to;

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
            //if(cmbBucketType.Text!="Day")
            //    txtLength.Visible = lblLength.Visible = false;
            //else
            //    txtLength.Visible = lblLength.Visible = true;
        }

        private void txtLength_ValueChanged(object sender, EventArgs e)
        {

        }
   }
}