using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilize.Report
{
    public partial class frmSelectColumn : Form
    {
        public frmSelectColumn(DataTable DataTableForShow, string NameOfDisplay, string NameOfValue, string Title)
        {
            InitializeComponent();
            ucSelectColumn.NameOfDisplay = NameOfDisplay;
            ucSelectColumn.NameOfValue = NameOfValue;
            ucSelectColumn.DataSource = DataTableForShow;
            lblTitle.Text = Title;
        }

        public string ReturnValue;

        private void btnOK_CButtonClicked(object sender, EventArgs e)
        {
            if(ucSelectColumn.GetSelectedItemPlusValue().Count()==0)
            {
                Utilize.Routines.ShowInfoMessageFa("اخطار", "موردی انتخاب نشده است.", Utilize.MyDialogButton.OK);
                return;
            }
            ReturnValue = ucSelectColumn.GetSelectedItemPlusValue();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
