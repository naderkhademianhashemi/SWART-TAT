using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace Utilize.Helper
{
    public static class DataTableHelper
    {
        public static DataTable ConfigDateTimeToPersian(this DataTable table)
        {
            var myTable = new DataTable();
            foreach (var column in table.Columns.Cast<DataColumn>())
            {
                var col = new DataColumn(column.ColumnName, column.DataType.Equals(typeof(DateTime)) ? typeof(string) : column.DataType) { Caption = column.Caption };
                myTable.Columns.Add(col);
            }

            foreach (var row in table.Rows.Cast<DataRow>())
            {

                var newRow = myTable.NewRow();
                foreach (var column in table.Columns.Cast<DataColumn>())
                {
                    if (column.DataType.Equals(typeof(DateTime)))
                    {
                        if (row[column.ColumnName].ToString().Trim().Length != 0)
                            newRow[column.ColumnName] =
                                Convert.ToDateTime(row[column.ColumnName].ToString()).ToPersianDate();
                    }
                    else
                    {
                        newRow[column.ColumnName] = row[column.ColumnName];
                    }
                }
                myTable.Rows.Add(newRow);
            }
            return myTable;
        }
        public static DataTable Trim(this DataTable table)
        {

            foreach (var column in table.Columns.Cast<DataColumn>())
            {
                column.Caption = column.Caption.Trim();
                column.ColumnName = column.ColumnName.Trim();
            }

            var colsStringType = table.Columns.Cast<DataColumn>().Where(colItem => colItem.DataType.Equals(typeof(string))).ToList();

            foreach (var row in table.Rows.Cast<DataRow>())
            {
                foreach (var column in colsStringType)
                {
                    row[column] = row[column].ToString().Trim();
                }
            }
            return table;
        }

        public static DataTable RenameCaption(this DataTable table, Dictionary<string, string> columns)
        {
            foreach (var column in columns)
            {
                table.Columns[column.Key].Caption = column.Value;
                table.Columns[column.Key].ColumnName = column.Value;
            }

            return table;
        }

        public static DataTable Grid2TableSearch(this System.Windows.Forms.DataGridView dgv)
        {
            var dt = new DataTable();

            var dcolFarsiField = new DataColumn("FarsiField", typeof(String));
            dt.Columns.Add(dcolFarsiField);

            var dcolField = new DataColumn("Field", typeof(String));
            dt.Columns.Add(dcolField);

            var dcolType = new DataColumn("Type", typeof(String));
            dt.Columns.Add(dcolType);

            foreach (System.Windows.Forms.DataGridViewColumn dcv in dgv.Columns)
            {
                if (dcv.Visible)
                {
                    if (dcv.Name != "dummy" && dcv.Name != "Row")
                    {
                        DataRow dr = dt.NewRow();
                        dr["FarsiField"] = dcv.HeaderText;
                        dr["Field"] = dcv.Name;
                        dr["Type"] = dcv.ValueType.ToString();
                        dt.Rows.Add(dr);
                    }
                }

            }
            return dt;
        }

        public static void FormatDataGridView(this System.Windows.Forms.DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.BackgroundColor = Color.FromArgb(250, 255, 250);
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 18;
            dgv.RowTemplate.Height = 20;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            var style = new System.Windows.Forms.DataGridViewCellStyle
                                                                   {
                                                                       BackColor =
                                                                           Color.FromArgb(
                                                                               250,
                                                                               255,
                                                                               250)
                                                                   };
            dgv.RowsDefaultCellStyle = style;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AllowUserToResizeColumns = true;
        }

        public static void SaveInToExcel(this DataTable table, string fileName)
        {
            var xlApp = new Microsoft.Office.Interop.Excel.Application { Visible = false };
            //var table = _ultraGrid.DataSource as DataTable;
            var allCount = table.Rows.Count;
            var incItem = Convert.ToInt32(10000);
            var colCount = table.Columns.Count;
            int i = 0;
            //Parallel.For(0, Convert.ToInt32(Math.Ceiling((decimal)allCount / incItem)), i =>
            //{
            var workbook = xlApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            worksheet.Cells.EntireColumn.AutoFit();
            worksheet.Name = string.Format("{0}-{1}", i, i + incItem);
            for (var r = 0; r < colCount; r++)
            {
                var field =
                    (Microsoft.Office.Interop.Excel.Range)
                    worksheet.Cells[1, r + 1];
                field.Formula = table.Columns[r].Caption;
                field.Font.Name = "Tahoma";
                field.Borders.Color = Color.Red;
            }
            for (var iRow = 0; iRow < incItem; iRow++)
            {
                for (var j = 0; j < colCount; j++)
                {
                    var field =
                        (Microsoft.Office.Interop.Excel.Range)
                        worksheet.Cells[iRow + 2, j + 1];
                    if (iRow + i * incItem >= table.Rows.Count)
                        break;
                    field.Formula =
                        table.Rows[iRow + i * incItem].ItemArray[j].ToString
                            ();
                    field.Font.Name = "Tahoma";
                }
            }
            workbook.SaveAs(
                fileName, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.
                    xlNoChange,
                Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value);
            workbook.Close(true, Missing.Value, Missing.Value);
            //});
            xlApp.Quit();
            xlApp.Application.Quit();
            return;
        }
    }
}
