using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERMS.Logic;
//    
using Presentation.Public;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmNewDBM : BaseForm
    {
        private TBM tbm;
        public int TimeBucket = -1;

        public string Title
        {
            get { return txtDesc.Text; }
            set { txtDesc.Text = value; }
        }

        public int TimeBucketID
        {
            get { return (int)cmbTimeBucket.SelectedValue; }
            set { cmbTimeBucket.SelectedByDataValue(value);}
        }
        public decimal depositLimit
        {
            get { return (decimal)Convert.ToDecimal(this.tbDLimit.Text); }
              set { tbDLimit.Text = value.ToString(); }
        }
        public DateTime ModelDate
        {
            get { return (DateTime)fdpModelDate.SelectedDateTime; }
            set { fdpModelDate.SelectedDateTime = value; }
        }        

        public frmNewDBM()
        {
            InitializeComponent();
        }

        private void frmNewDBM_Load(object sender, EventArgs e)
        {
            RebindTBM();
            cmbTimeBucket.SelectedByDataValue(TimeBucket);
        }
        // add by soltani
        private void RebindTBM()
        {
            tbm = new TBM();

            cmbTimeBucket.DataSource = tbm.GetTBMs();
            cmbTimeBucket.DisplayMember = "ModelName";
            cmbTimeBucket.ValueMember = "ID";
        }


        //
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == string.Empty)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("لطفا نام مدل را انتخاب كنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.None;
            }
            this.DialogResult = DialogResult.OK;
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




        private void tbDLimit_TextChanged(object sender, EventArgs e)
        {

            //if (Utilize.Helper.GeneralHelper.IsNumber(tbDLimit.Text))
            //    return;
            //else
            //{
            //    Presentation.Public.Routines.ShowErrorMessageFa("خطا", "مقدار وارد شده عدد نمی باشد .", Public.MyDialogButton.OK);
            //}
        }

        private void btnCancel_CButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}