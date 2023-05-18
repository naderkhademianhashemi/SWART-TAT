using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilize.Grid
{
    public partial class Grid_V3 : UserControl
    {
        public Grid_V3()
        {
            InitializeComponent();
        }

        private object _DataSource;
        public object DataSource
        {
            get { return _DataSource; }
            set
            {
                _DataSource = value;
                ugReport.DataSource = _DataSource;
                ugReport.DataBind();
            }
        }
        private void btnMinMax_Click(object sender, EventArgs e)
        {
            if (scMain.Panel1Collapsed == false)
            {
                scMain.Panel1Collapsed = true;
                btnMinMax.Text = ">>";
            }
            else
            {
                scMain.Panel1Collapsed = true;
                btnMinMax.Text = "<<";
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            var frmAddGroups = new frmAddGroups();
            var table = (DataTable)_DataSource;
            frmAddGroups.SetItemColumns(table.Columns.Cast<DataColumn>().Select(item => item.ColumnName));
            frmAddGroups.ShowDialog();
            var column =
                table.Columns.Cast<DataColumn>().Where(item => item.ColumnName.Equals(frmAddGroups.SelectedColumn)).
                    FirstOrDefault();
            var disRowItem =table.Rows.Cast<DataRow>().Select(item => item[column]).Distinct();
            
        }
    }
}
