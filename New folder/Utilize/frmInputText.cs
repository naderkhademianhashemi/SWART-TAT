using System;
using System.Windows.Forms;
using Utilize.Helper;

namespace Utilize
{
    public partial class frmInputText : Form
    {
        public frmInputText()
        {
            InitializeComponent();
        }

        public string ReturnValue;

        private string _topic = "عنوان";
        public string Topic
        {
            get { return _topic; }
            set
            {
                _topic = value;
                lblTopic.Text = value;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.IsNullOrEmptyByTrim())
            {
                Routines.ShowErrorMessageFa("خطا", "نام گزارش وارد نشده است", MyDialogButton.OK);
                return;
            }
            ReturnValue = txtValue.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
