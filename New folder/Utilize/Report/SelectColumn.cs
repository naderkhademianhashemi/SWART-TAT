using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Utilize.Helper;

namespace Utilize.Report
{
    public partial class SelectColumn : UserControl
    {
        #region Params

        private string _NameOfDisplay;

        [Description("نام ستونی که در لیست به عنوان ستون انتخابی نمایش داده می شود")]
        public string NameOfDisplay
        {
            get { return _NameOfDisplay; }
            set { _NameOfDisplay = value; }
        }

        private string _NameOfValue;

        [Description("نام ستونی که در لیست به عنوان کلید ستون انتخابی نمایش داده می شود")]
        public string NameOfValue
        {
            get { return _NameOfValue; }
            set { _NameOfValue = value; }
        }

        private string _Title;

        [Description("عنوان لیست را مشخص می کند")]
        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                ugbSC.Text = _Title;
            }
        }

        private DataTable _dataSource;

        [Description("مجموعه داده برای نمایش ستون های انتخابی")]
        public DataTable DataSource
        {
            get { return _dataSource; }
            set
            {
                _dataSource = value;
                if (_dataSource != null)
                {
                    foreach (var row in _dataSource.Rows.Cast<DataRow>())
                    {
                        if (row[_NameOfValue].ToString().Equals("Row_Id")) continue;
                        chbColumnsOfShow.Items.Add(new ColumnOfList<string, string>(row[_NameOfDisplay].ToString(),
                            row[_NameOfValue].ToString()));
                    }
                }
                else
                    chbColumnsOfShow.Items.Clear();
            }
        }

        #endregion

        public SelectColumn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSource">مجموعه داده</param>
        /// <param name="NameOfDisplayColumn">نام ستون نمایش ستونهای گزارش</param>
        /// <param name="NameOfValueColumn">نام ستون کلید های نمایش ستونهای گزارش</param>
        public SelectColumn(DataTable dataSource, string NameOfDisplayColumn, string NameOfValueColumn)
        {
            InitializeComponent();
            _dataSource = dataSource;
            _NameOfDisplay = NameOfDisplayColumn;
            _NameOfValue = NameOfValueColumn;
        }

        public SelectColumn(DataTable dataSource)
        {
            InitializeComponent();
            _dataSource = dataSource;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < chbColumnsOfShow.Items.Count; i++)
            {
                chbColumnsOfShow.SetItemChecked(i, true);
            }
        }

        /// <summary>
        /// تمام ستونهای انتخاب شده را از انتخاب خارج میکند
        /// </summary>
        public void ClearSelectedColumn()
        {
            for (var i = 0; i < chbColumnsOfShow.Items.Count; i++)
            {
                chbColumnsOfShow.SetItemChecked(i, false);
            }
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            ClearSelectedColumn();
        }

        /// <summary>
        /// لیست ستونهای انتخاب شده را به صورت یک آرایه باز می گرداند
        /// </summary>
        /// <returns>مجموعۀ ستونهای انتخاب شده</returns>
        public IEnumerable<string> GetSelectedItems()
        {
            return chbColumnsOfShow.CheckedItems.Cast<ColumnOfList<string, string>>().Select(item => item.GetDisplay());
        }

        /// <summary>
        /// ستونهای انخاب شده را به صورت یک متن خروجی به صورت "[Item1],[Item2],... بر میگرداند
        /// </summary>
        /// <returns>ستونهای انتخاب شده</returns>
        public string GetSelectedItem()
        {
            var sca = "";
            foreach (
                var item in
                    chbColumnsOfShow.CheckedItems.Cast<ColumnOfList<string, string>>().Select(item => item.GetDisplay())
                )
            {
                sca = sca + (sca.IsNullOrEmptyByTrim() ? "[" : ",[") + item.Trim() + "]";
            }
            return sca;
        }


        public string GetSelectedItemPlusValue()
        {
            var sca = "";
            foreach (
                var item in
                    chbColumnsOfShow.CheckedItems.Cast<ColumnOfList<string, string>>()
                        .Select(item => item.GetDisplay() + ":" + item.GetValue()))
            {
                sca = sca + (sca.IsNullOrEmptyByTrim() ? "[" : ",[") + item.Trim() + "]";
            }
            return sca;
        }

        /// <summary>
        /// لیست ستونهای انتخاب شده را به صورت یک آرایه برای Query باز می گرداند
        /// </summary>
        /// <returns>مجموعۀ ستونهای انتخاب شده</returns>
        public IEnumerable<string> GetSelectedItemsForQuerySql()
        {
            return
                chbColumnsOfShow.CheckedItems.Cast<ColumnOfList<string, string>>().Select(
                    item => item.GetValue() + " AS [" + item.GetDisplay() + "] ");
        }

        /// <summary>
        /// ستونهای انخاب شده را به صورت یک متن خروجی به صورت "Item1 AS [Item1],Item2 AS [Item2],... برای Query بر میگرداند
        /// </summary>
        /// <returns>ستونهای انتخاب شده</returns>
        public string GetSelectedItemForQuerySql()
        {
            var scnac = "";
            foreach (var item in chbColumnsOfShow.CheckedItems.Cast<ColumnOfList<string, string>>())
            {
                scnac = scnac + (scnac.IsNullOrEmptyByTrim() ? "" : ",") + item.GetValue() + " AS [" +
                        item.GetDisplay().Trim() + "]";
            }
            return scnac;
        }

        /// <summary>
        /// ستونهای مورد نظر را انتخاب میکند
        /// </summary>
        /// <param name="Keys">آرایه ستونهای نمایش داده شده در Query</param>
        public void SetSelectedItem(IEnumerable<string> Keys)
        {
            ClearSelectedColumn();
            foreach (var key in Keys)
            {
                var chbIndex = 0;
                foreach (var item in chbColumnsOfShow.Items.Cast<ColumnOfList<string, string>>())
                {
                    var index = key.IndexOf(" AS ");
                    if (index != -1 && key.Substring(0, index).Trim().Equals(item.GetValue().Trim()))
                    {
                        chbColumnsOfShow.SetItemCheckState(chbIndex, CheckState.Checked);
                        break;
                    }
                    chbIndex++;
                }
            }
        }

        /// <summary>
        /// ستونهای مورد نظر را انتخاب میکند
        /// </summary>
        /// <param name="Keys"> ستونهای نمایش داده شده در Query</param>
        public void SetSelectedItem(string Keys)
        {
            ClearSelectedColumn();
            foreach (var key in Keys.Split(new[] {','}))
            {
                var chbIndex = 0;
                foreach (var item in chbColumnsOfShow.Items.Cast<ColumnOfList<string, string>>())
                {
                    var index = key.ToUpper().IndexOf(" AS ");
                    if (index != -1 && key.Substring(0, index).Trim().Equals(item.GetValue().Trim()))
                    {
                        chbColumnsOfShow.SetItemCheckState(chbIndex, CheckState.Checked);
                        break;
                    }
                    chbIndex++;
                }
            }
        }

        public void SetaItemSelected(string key)
        {
            

            var chbIndex = 0;
            foreach (var item in chbColumnsOfShow.Items.Cast<ColumnOfList<string, string>>())
            {
                var index = key.ToUpper().IndexOf(" AS ");
                if (index != -1 && key.Substring(0, index).Trim().Equals(item.GetValue().Trim()))
                {
                    chbColumnsOfShow.SetItemCheckState(chbIndex, CheckState.Checked);
                    break;
                }
                chbIndex++;
            }
        }
                public void SetaItemDisable(string key)
        {
            

            var chbIndex = 0;
            foreach (var item in chbColumnsOfShow.Items.Cast<ColumnOfList<string, string>>())
            {
                var index = key.ToUpper().IndexOf(" AS ");
                if (index != -1 && key.Substring(0, index).Trim().Equals(item.GetValue().Trim()))
                {
                    chbColumnsOfShow.Enabled = false;
                    break;
                }
                chbIndex++;
            }
        }
    }
}

internal class ColumnOfList<DType, VType>
{
    private readonly DType Display;
    private readonly VType Value;

    public ColumnOfList(DType display, VType value)
    {
        Display = display;
        Value = value;
    }

    public string GetDisplay()
    {
        return Display.ToString();
    }

    public string GetValue()
    {
        return Value.ToString();
    }

    public override string ToString()
    {
        return GetDisplay();
    }
}