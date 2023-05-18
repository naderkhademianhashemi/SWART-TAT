using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Tabs.AssetDebtManagement
{

    public partial class frmGapLimit : BaseForm
    {
        private decimal _upLimit;

        public decimal upLimit
        {
            get { return _upLimit; }
            set { _upLimit = value; }
        }

        private decimal _downLimit;

        public decimal downLimit
        {
            get { return _downLimit; }
            set { _downLimit = value; }
        }

        public frmGapLimit()
        {
            InitializeComponent();
        }

        private void frmGapLimit_Load(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtLimitUp.Text != string.Empty && txtLimitdown.Text != string.Empty)
            {
                _upLimit = decimal.Parse(txtLimitUp.Text.ToString());
                _downLimit = decimal.Parse(txtLimitdown.Text.ToString());
            }
            txtLimitUp.Text = string.Empty;
            txtLimitdown.Text = string.Empty;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}