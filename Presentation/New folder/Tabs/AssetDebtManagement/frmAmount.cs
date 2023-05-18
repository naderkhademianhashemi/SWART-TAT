using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmAmount : BaseForm
    {
        #region VARS
        private int maximum;

        #endregion

        public int Maximum
        {
            get { return maximum; }
            set { maximum = value; }
        }

        public frmAmount()
        {
            InitializeComponent();

            maximum = 100;
        }

        public decimal Balance
        {
            set { txtBalance.Text = value.ToString(); }
        }

        public int Percent
        {
            get
            {
                return Convert.ToInt32(udPercent.Value);

            }
            set
            {
                udPercent.Value = value;
            }
        }

        private string _Contract;
        public string Contract
        {
            set { _Contract = value; }
        }

        public string per
        {
            get
            {
                return Convert.ToString(udPercent.Value);
            }
            set
            {

                udPercent.Value = Convert.ToInt32(value);
            }

        }

        private void frmCaption_Load(object sender, EventArgs e)
        {
            txtBalance.Enabled = false;
            udPercent.Maximum = maximum;
            trkPercent.Maximum = maximum;
            //this.AcceptButton = (Button) btnOK;

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

        private void trkPercent_Scroll(object sender, EventArgs e)
        {
            udPercent.Value = trkPercent.Value;
        }

        private void udPercent_ValueChanged(object sender, EventArgs e)
        {

            trkPercent.Value = Convert.ToInt32(udPercent.Value);


        }

        private void frmAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        public Boolean rbpositive
        {
            get { return this.rbPositive.Visible; }
            set { this.rbPositive.Visible = value; }
        }

        public Boolean rbnegative
        {
            get { return this.rbNegative.Visible; }
            set { this.rbNegative.Visible = value; }
        }

        public Boolean rbpositivecheck
        {
            get { return this.rbPositive.Checked; }
            set { this.rbPositive.Checked = value; }
        }

        public Boolean rbnegativecheck
        {
            get { return this.rbNegative.Checked; }
            set { this.rbNegative.Checked = value; }
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private void btnOK_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

