using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Utilize.Helper;

namespace Utilize.Report
{
    public partial class UCSearchFiltering : UserControl
    {
        public UCSearchFiltering()
        {
            InitializeComponent();
        }

        private bool isValid;

        private string _txtTitle;
        [Description("عنوان جستجو")]
        public string txtTitle
        {
            get { return _txtTitle; }
            set
            {
                _txtTitle = value;
                chbItem.Text = _txtTitle;
            }
        }

        private string _txtExceptionMessage;
        [Description("پیغام خطا")]
        public string txtExceptionMessage
        {
            get { return _txtExceptionMessage; }
            set { _txtExceptionMessage = value; }
        }

        private string _txtSearchItem;
        [Description("نام ستون مورد جستجو")]
        public string txtSearchItem
        {
            get { return _txtSearchItem; }
            set { _txtSearchItem = value; }
        }

        private string _txtNameItem;
        [Description("نام ستون فیلد برای نمایش در توضیحات")]
        public string txtNameItem
        {
            get { return _txtNameItem; }
            set { _txtNameItem = value; }
        }

        private string _txtTagItem;
        [Description("نام ستون فیلد برای برچسب در توضیحات")]
        public string txtTagItem
        {
            get { return _txtTagItem; }
            set { _txtTagItem = value; }
        }

        private DataTable _dataTable;
        [Description("نام مجموعه داده ها")]
        public DataTable DataTable
        {
            get { return _dataTable; }
            set { _dataTable = value; }
        }
        private void txtItem_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            try
            {
                if (e.Button.Key == "Search")
                {
                    var dataRow=
                        _dataTable.Rows.Cast<DataRow>().Where(row => row[_txtSearchItem].ToString().Equals(txtItem.Text))
                            .FirstOrDefault();
                    if (dataRow == null)
                    {
                        txtItemMessage.Text = _txtExceptionMessage.IsNullOrEmptyByTrim()
                                                  ? "اطلاعات وجود ندارد"
                                                  : _txtExceptionMessage;
                        txtItem.Text = null;
                        txtItem.Tag = null;
                        isValid = false;
                    }
                    else
                    {
                        txtItem.Text = dataRow[_txtNameItem].ToString();
                        txtItem.Tag = dataRow[_txtTagItem].ToString();
                        isValid = true;
                    }
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void chbItem_CheckedChanged(object sender, EventArgs e)
        {
            txtItem.Enabled = chbItem.Checked;
        }

        public bool IsChecked()
        {
            return chbItem.Checked;
        }

        public string GetQueryForSql()
        {
            if (IsChecked())
            {
                if (isValid)
                    return " (" + _txtSearchItem + "='" + txtItem.Tag + "') ";
                return "";
            }
            return "";
        }
    }
}
