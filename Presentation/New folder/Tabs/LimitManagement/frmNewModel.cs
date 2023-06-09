using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Tabs.LimitManagement
{
    public partial class frmNewModel : BaseForm
    {
        public string Description
        {
            get
            {
                return txtDesc.Text;
            }
            set
            {
                txtDesc.Text = value;
                txtDesc.SelectionStart = 0;
                txtDesc.SelectionLength = txtDesc.Text.Length;
            }
        }

        public int LimitBase
        {
            get
            {
                return cmbLimitBase.SelectedIndex;
            }
            //set
            //{
            //    lblTitle.Text = value;
            //}
        }
        public frmNewModel()
        {
            InitializeComponent();
        }

        private void frmNewModel_Load(object sender, EventArgs e)
        {

            cmbLimitBase.SelectedIndex =  0;

        }

        private void btnOK_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}