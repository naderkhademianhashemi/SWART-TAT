using System;
using System.Windows.Forms;
using Utilize;
using Utilize.Helper;

namespace Presentation.Public
{
    public partial class frmAddRange : Form
    {
        public frmAddRange()
        {
            InitializeComponent();
        }

        public double To = -1;
        public double From = -1;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (untFrom.Text.Trim().Length == 0 || untTo.Text.Trim().Length == 0)
            {
                Routines.ShowErrorMessageFa("خطا در ورودی", "مقدار اولیه/پایانی وارد نشده است.", MyDialogButton.OK);
                return;
            }
            if (untFrom.Value.ToString().ToDouble() >= untTo.Value.ToString().ToDouble())
            {
                Routines.ShowErrorMessageFa("خطا در ورودی", "مقدار اولیه از مبلغ پایانی باید کمتر باشد.",
                                            MyDialogButton.OK);
                return;
            }

            this.DialogResult = DialogResult.OK;
            From = untFrom.Value.ToString().ToDouble();
            To = untTo.Value.ToString().ToDouble();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
