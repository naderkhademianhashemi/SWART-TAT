using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace Utilize
{
    public class SaveDataTable
    {
        public  void SaveInToExcel( DataTable table, string fileName)
        {

            /////////
            var exporter=new UltraGridExcelExporter();
            exporter.Export(new UltraGrid() {DataSource = table}, fileName);
            return;
            /////////
            var xlApp = new Microsoft.Office.Interop.Excel.Application { Visible = false };
            //var table = _ultraGrid.DataSource as DataTable;
            var allCount = table.Rows.Count;
            var incItem = table.Rows.Count > 1000000 ? Convert.ToInt32(1000000) : table.Rows.Count;
            var colCount = table.Columns.Count;
            long countInItem = 0;
            var workbook = xlApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            //Parallel.For(0, Convert.ToInt32(Math.Ceiling((decimal)allCount / incItem)), i =>
            for (int i = 0; i <= Convert.ToInt32(Math.Ceiling((decimal)allCount / incItem)); i++)
            {
                var worksheet = (Microsoft.Office.Interop.Excel.Worksheet) workbook.Sheets[1];
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
                        if (iRow + i*incItem >= table.Rows.Count)
                            break;
                        field.Formula =
                            table.Rows[iRow + i*incItem].ItemArray[j].ToString
                                ();
                        field.Font.Name = "Tahoma";
                    }
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
            xlApp.Quit();
            xlApp.Application.Quit();
            return;
        }
    }
}
