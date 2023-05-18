using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilize.Grid
{
    public partial class frmAddGroups : Form
    {
        public void SetItemColumns(IEnumerable<string> enumerable)
        {
            cmbColumns.Items.Clear();
            foreach (var item in enumerable)
            {
                cmbColumns.Items.Add(item);
            }
        }
        public frmAddGroups()
        {
            InitializeComponent();
        }

        private string _SelectedColumn = string.Empty;
        public string SelectedColumn
        {
            get { return _SelectedColumn; }
            private set { _SelectedColumn = value; }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbColumns.SelectedIndex == -1)
            {
                Routines.ShowErrorMessageFa("خطا", "ستونی انتخاب نشده است", MyDialogButton.OK);
                return;
            }
            _SelectedColumn = cmbColumns.Text;
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _SelectedColumn = string.Empty;
        }
    }
}
