using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmNewPD : Form
    {
        public DataTable dtReturnValue;


        public frmNewPD(DataTable DataTableForShow, string Title)
        {
            InitializeComponent();
            dtReturnValue = DataTableForShow;
            dgvColumns.DataSource = dtReturnValue;
            lblTitle.Text = Title;
        }

        
        private void btnOK_CButtonClicked(object sender, EventArgs e)
        {
            dgvColumns.Refresh();
            for (int i = 0; i < dgvColumns.Rows.Count; i++)
            {
                if (dgvColumns.Rows[i].Cells[1].Value == null || dgvColumns.Rows[i].Cells[1].Value.ToString().Length == 0)
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("اطلاعات وارد شده ناقص است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

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
