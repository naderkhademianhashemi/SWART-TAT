using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Presentation.DAL
{
    public class LoanDS
    {
        public System.Data.DataTable GetDT_LoanCashFlow()
        {
            var table = new System.Data.DataTable();

            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Row";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ID";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Contract";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.DateTime");
            column.ColumnName = "Annuity_Date";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int64");
            column.ColumnName = "Annuity_Amount";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int64");
            column.ColumnName = "Interest_Amount";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Contract_Type";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Annuity_Serial";
            table.Columns.Add(column);

            for (int i = 0; i < 10; i++)
            {
                row = table.NewRow();
                row["Row"] = i;
                row["ID"] = i;
                row["Contract"] = "آیتم " + i.ToString();
                row["Annuity_Date"] = DateTime.Now;
                row["Annuity_Amount"] = i;
                row["Interest_Amount"] = i;
                row["Contract_Type"] = i;
                row["Annuity_Serial"] = i;
                table.Rows.Add(row);
            }
            return table;
        }

        public System.Data.DataTable GetDT_State()
        {
            var table = new System.Data.DataTable();

            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Row";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Name";
            table.Columns.Add(column);

            for (int i = 0; i < 10; i++)
            {
                row = table.NewRow();
                row["Row"] = i;
                row["Name"] = "Tehran";
                table.Rows.Add(row);
            }
            return table;
        }

        public System.Data.DataTable GetDT()
        {
            var table = new System.Data.DataTable();

            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Row";
            table.Columns.Add(column);

            for (int i = 0; i < 10; i++)
            {
                row = table.NewRow();
                row["Row"] = i;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
