using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Infragistics.Win;
using Utilize.Helper;
using System.Data;

namespace Utilize.Report
{
    public partial class UCFilteringMini : UserControl
    {

        public event EventHandler CheckedChanged;
        public event EventHandler DropDownOpening;

        private Object _DataSource;
        public Object DataSource
        {
            get { return _DataSource; }
            set
            {
                _DataSource = value;
                cmbSource.DataSource = value;
            }
        }

        private string _DisplayMember;
        public string DisplayMember
        {
            get { return _DisplayMember; }
            set
            {
                _DisplayMember = value;
                cmbSource.DisplayMember = value;
            }
        }

        private string _ValueMember;
        public string ValueMember
        {
            get { return _ValueMember; }
            set
            {
                _ValueMember = value;
                cmbSource.ValueMember = value;
            }
        }


        [DefaultValue("بدون عنوان")]
        private string _Title;
        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                chbTitle.Text = value;
            }
        }

        [DefaultValue(true)]
        private bool _isPersian;
        public bool IsPersian
        {
            get { return _isPersian; }
            set
            {
                _isPersian = value;

            }
        }

        [DefaultValue(true)]
        private bool _EnableShowClearSelectedItem;
        public bool EnableShowClearSelectedItem
        {
            get { return _EnableShowClearSelectedItem; }
            set
            {
                _EnableShowClearSelectedItem = value;
                btnClearSelected.Visible = value;
            }
        }

        [DefaultValue(true)]
        private bool _EnableShowSelectedItem;


        public DataTable GetFilterforImport()
        {
            DataTable x = new DataTable();
            x.Columns.Add();
            var filter = "";
            if (chbTitle.Checked)
            {
                var items = GetSelectedItem();

                foreach (var item in items)
                {
                    filter = item.DataValue.ToString();
                    var row = x.NewRow();
                    x.Rows.Add(filter);

                }

            }
            return x;

        }

        public bool EnableShowSelectedItem
        {
            get { return _EnableShowSelectedItem; }
            set
            {
                _EnableShowSelectedItem = value;
                btnShowSelected.Visible = value;
            }
        }

        public bool IsChecked()
        {
            return chbTitle.Checked;
        }

        public string GetFilterStructureForSql()
        {
            var filter = "";
            if (chbTitle.Checked)
            {
                var items = GetSelectedItem();

                foreach (var item in items)
                {
                    filter += filter.Trim().Length == 0
                        ? "(" + _ValueMember + " = " + "'" + item.DataValue.ToString().Trim() + "' "
                                                : " OR " + _ValueMember + " = '" + item.DataValue.ToString().Trim() + "' ";
                }
                if (filter.Trim().IsNullOrEmptyByTrim() == false)
                    filter += ")";
            }
            return filter;
        }
        public string GetFilterStructureForSqlBranch()
        {

            var filter = "";
            if (chbTitle.Checked)
            {
                var items = GetSelectedItem();

                foreach (var item in items)
                {
                    if (IsPersian)
                    {
                        filter += filter.Trim().Length == 0
                            ? "(Organization." + _ValueMember + " = " + "N'" + item.DataValue.ToString().Trim() + "' "
                                                    : " OR Organization. " + _ValueMember + " = '" + item.DataValue.ToString().Trim() + "' ";

                    }
                    else
                    {

                        filter += filter.Trim().Length == 0
                            ? "(Organization." + _ValueMember + " = " + "'" + item.DataValue.ToString().Trim() + "' "
                                                    : " OR Organization." + _ValueMember + " = '" + item.DataValue.ToString().Trim() + "' ";
                    }
                }
                if (filter.Trim().IsNullOrEmptyByTrim() == false)
                    filter += ")";
            }
            return filter;
        }
        public string GetFilterStructureForSqlBranchG()
        {

            var filter = "";
            if (chbTitle.Checked)
            {
                var items = GetSelectedItem();

                foreach (var item in items)
                {
                    if (IsPersian)
                    {
                        filter += filter.Trim().Length == 0
                            ? "(" + _ValueMember + " = " + item.DataValue.ToString().Trim()
                                                    : " OR " + _ValueMember + " = " + item.DataValue.ToString().Trim();

                    }
                    else
                    {

                        filter += filter.Trim().Length == 0
                            ? "(" + _ValueMember + " = " + item.DataValue.ToString().Trim()
                                                    : " OR " + _ValueMember + " = " + item.DataValue.ToString().Trim();
                    }
                }
                if (filter.Trim().IsNullOrEmptyByTrim() == false)
                    filter += ")";
            }
            return filter;
        }

        public UCFilteringMini()
        {
            InitializeComponent();
        }

        public void OnlyShowColumns(IEnumerable<string> columnsValue)
        {
            for (int i = cmbSource.Items.Count-1; i < 0; i++)
            {
                if (columnsValue.Contains(cmbSource.Items[i].DataValue) == false)
                {
                    cmbSource.Items.Remove(i);
                }
            }
        }

        public IEnumerable<ValueListItem> GetSelectedItem()
        {
            return cmbSource.CheckedItems;
        }

        public void ClearItem()
        {
            cmbSource.Items.Cast<ValueListItem>().ForEach(item => item.ResetCheckState());
            chbTitle.Checked = false;
            cmbSource.Enabled = false;
        }

        public void SetSelectedItem(IEnumerable<string> keys)
        {
            cmbSource.Items.Cast<ValueListItem>().ForEach(item => item.ResetCheckState());
            chbTitle.Checked = true;
            cmbSource.Items.Cast<ValueListItem>().Where(
                item => keys.Where(key => key.Trim().Equals(item.DataValue.ToString().Trim())).Any()).ForEach(
                    item => item.CheckState = CheckState.Checked);
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            cmbSource.Items.Cast<ValueListItem>().ForEach(item => item.ResetCheckState());
        }

        private void chbTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckedChanged != null)
                CheckedChanged.Invoke(sender, e);
            if (chbTitle.Checked == false)
            {
                cmbSource.Enabled = btnShowSelected.Enabled = btnClearSelected.Enabled = false;
            }
            else
            {
                cmbSource.Enabled = true;
                btnShowSelected.Enabled = _EnableShowSelectedItem;
                btnClearSelected.Enabled = _EnableShowClearSelectedItem;
            }
        }

        private void cmbSource_BeforeDropDown(object sender, CancelEventArgs e)
        {
            if (DropDownOpening != null)
                DropDownOpening.Invoke(sender, e);
        }

        private void btnShowSelected_Click(object sender, EventArgs e)
        {
            new frmShowSelectionItem(_Title, GetSelectedItem()).ShowDialog();
        }
    }
}
