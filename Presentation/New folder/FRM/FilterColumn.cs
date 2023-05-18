namespace Presentation
{
    public enum DateTypeSearch
    {
        Year = 0,
        YearAndMonth = 1,
        YearAndMonthAndDay = 2
    }

    public class FilterColumn
    {
        public FilterColumn(System.Data.DataRow row, System.Windows.Forms.ComboBox value, string condition)
        {
            _condition = condition;
            _value = value.DataSource != null ? (value.SelectedValue == null ? value.Text : value.SelectedValue.ToString()) : value.Text;
            _valueDisplay = value.Text;
            _row = row;
            CreateFilteringFilteringForSqlQuery();
        }

        // public static string GetWhereForForm(string[] where)
        //{
        //var generateReportTableTableAdapter = new ERMS.Logic.DAL.MyDataSetTableAdapters.GenerateReportTableTableAdapter();
        //foreach (var item in where)
        //{
        //    var rows = from a in generateReportTableTableAdapter.GetData()
        //               where a.NameOfTable.ToUpper().Equals("VIEW_2") &&
        //               a.NameOfRelationshipColumn.Contains(item.Split(new[]{'='})[0])

        //               select a;
        //}


        //foreach (var row in rows)
        //{
        //    if(where.Contains(row.NameOfRelationshipColumn))
        //    {

        //    }
        //}
        //return "";
        //}

        public FilterColumn(System.Data.DataRow row, string value, string condition)
        {
            _condition = condition;
            _value = value;
            _valueDisplay = value;
            _row = row;
            CreateFilteringFilteringForSqlQuery();
        }
        public FilterColumn(System.Data.DataRow row, string value, string condition, DateTypeSearch typeSearch)
        {
            _condition = condition;
            _value = value;
            _valueDisplay = value;
            _row = row;
            switch (typeSearch)
            {
                case DateTypeSearch.Year:
                    CreateFilteringFilteringForSqlQueryByYare();
                    break;
                case DateTypeSearch.YearAndMonth:
                    CreateFilteringFilteringForSqlQueryByYareAndMonth();
                    break;
                case DateTypeSearch.YearAndMonthAndDay:
                    CreateFilteringFilteringForSqlQueryByYareAndMonthAndDdDay();
                    break;
                default:
                    break;
            }
            //CreateFilteringFilteringForSqlQuery();
        }
        private void CreateFilteringFilteringForSqlQueryByYare()
        {
            //var date = System.Convert.ToDateTime(_value);
            //var persianDate=new PersianDate(_value);
            var date = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(_value);
            var column = _row["NameOfColumnForFilter"].ToString();
            var column2 = _row["NameOfSelectedColumn"].ToString();//cast(YEAR(GETDATE()) as nvarchar(max))
            _getFilteringForSqlQuery = _condition.ToUpper().CompareTo("LIKE") == 0
                                        ? " cast(Year(" + column2 + ") as nvarchar)" + _condition + " N'%" + date.Year + "%' "
                                        : " " + column + " " + _condition + " " + _value;
        }

        private void CreateFilteringFilteringForSqlQueryByYareAndMonth()
        {
            var date = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(_value);
            //var date = System.Convert.ToDateTime(_value);
            var column = _row["NameOfColumnForFilter"].ToString();
            var column2 = _row["NameOfSelectedColumn"].ToString();//cast(month(GETDATE())as nvarchar(max))
            _getFilteringForSqlQuery = _condition.ToUpper().CompareTo("LIKE") == 0
                                        ? " cast(Year(" + column2 + ") as nvarchar)" + _condition + " N'%" + date.Year + "%' and " +
                                        " cast(month(" + column2 + ") as nvarchar)" + _condition + " N'%" + date.Month + "%' "
                                        : " " + column + " " + _condition + " " + _value;
        }

        private void CreateFilteringFilteringForSqlQueryByYareAndMonthAndDdDay()
        {
            //var date = System.Convert.ToDateTime(_value);
            var date = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(_value);
            var column = _row["NameOfColumnForFilter"].ToString();
            var column2 = _row["NameOfSelectedColumn"].ToString();//cast(DAY(getdate())as nvarchar(max))
            _getFilteringForSqlQuery = _condition.ToUpper().CompareTo("LIKE") == 0
                                        ? " cast(YEAR(" + column2 + ") as nvarchar)" + _condition + " N'%" + date.Year + "%' and" +
                                        " cast(month(" + column2 + ") as nvarchar)" + _condition + " N'%" + date.Month + "%' and" +
                                        " cast(DAY(" + column2 + ") as nvarchar)" + _condition + " N'%" + date.Day + "%'"
                                        : " " + column + " " + _condition + " " + _value;
        }
        private void CreateFilteringFilteringForSqlQuery()
        {
			if (_row["AliasNameForDisplay"].ToString().Contains("تاریخ"))
			{
				var date =FarsiLibrary.Utils.PersianDate.Parse(_value);
				var dateTime=FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(date);
				_value = " CAST('" + dateTime.ToString("yyyy/MM/dd") + "' as datetime) ";
			}
            var column = _row["NameOfColumnForFilter"].ToString();
            var column2 = _row["NameOfSelectedColumn"].ToString();
            _getFilteringForSqlQuery = _condition.ToUpper().CompareTo("LIKE") == 0
                                        ? " cast(" + column2 + " as nvarchar)" + _condition + " N'%" + _value + "%' "
                                        : " " + column + " " + _condition + " " + _value;
        }

        private string _value;
        private readonly string _valueDisplay;
        private readonly string _condition;
        private readonly System.Data.DataRow _row;
        public int GetRowId
        {
            get { return (int)_row["id"]; }
        }
        private string _getFilteringForSqlQuery;
        public string GetFilteringForSqlQuery
        {
            get { return _getFilteringForSqlQuery; }
        }
        public string GetFilteringForShowInForm
        {
            get { return string.Format("{0} {1} {2}", _row["AliasNameForDisplay"], _condition, _valueDisplay); }
        }
    }
}

