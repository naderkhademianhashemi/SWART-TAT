using ClosedXML.Excel;
using Presentation.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App = Microsoft.Office.Interop.Excel.Application;

namespace Presentation.Util
{
    public class Export
    {
        SaveFileDialog saveFileDialog;

        public Export()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)| *.xlsx|Xml Files (*.xml)| *.xml";
        }

        public void ExportDocument(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = null;
            Microsoft.Office.Interop.Excel._Application excelApplication = null;
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook = null;
            System.Data.DataTable dt;
            string filename;

            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                filename = saveFileDialog.FileName;
                dt = new System.Data.DataTable("tbl");

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    dt.Columns.Add(dgv.Columns[i].HeaderCell.Value.ToString());
                }

                for (int j = 0; j < dgv.Rows.Count; j++)
                {
                    DataRow dr = dt.NewRow();
                    dt.Rows.Add(dr);
                }

                if (filename.Substring(filename.Length - 3, 3) == "xls")
                {
                    var paramMissing = Type.Missing;
                    var oldCl = System.Threading.Thread.CurrentThread.CurrentCulture;
                    var _Application = new App();
                    var workbook = _Application.Workbooks.Add();
                    excelWorksheet = workbook.Worksheets.Add();
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        excelWorksheet.Cells[1, i + 1] = dt.Columns[i].Caption.ToString();
                    }

                    int row = 2;
                    while (row < dt.Rows.Count + 2)
                    {
                        for (int col = 0; col < dt.Columns.Count; col++)
                        {
                            excelWorksheet.Cells[row, col + 1] = dt.Rows[row - 2][col].ToString();
                        }
                        row++;
                    }

                    excelWorksheet.SaveAs(filename, paramMissing, paramMissing,
                                              paramMissing, paramMissing, paramMissing,
                                              paramMissing, paramMissing, paramMissing,
                                              paramMissing);
                    workbook.Close();
                    _Application.Quit();
                    excelApplication = null;
                    excelWorkbook = null;
                    excelWorksheet = null;

                }
                if (filename.Substring(filename.Length - 3, 3) == "xml")
                {
                    var myFileStream = new System.IO.FileStream
                       (filename, System.IO.FileMode.Create);
                    dt.WriteXml(myFileStream);
                }
                System.Windows.Forms.MessageBox.Show("Success");
            }
        }

        public void Dgv2Xcl(DataGridView DGV)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            var appPath = Path.GetDirectoryName(Application.ExecutablePath);
            var pathRun = appPath + "\\ExcelTemplate.xlsx";
            var pathSave = saveFileDialog.FileName;

            var DT = (DataTable)DGV.DataSource;

            using (var WB = new XLWorkbook(pathRun))
            {
                var sheet = WB.Worksheets.Worksheet(1);

                for (int col = 0; col < DGV.Columns.Count; col++)
                    if (DGV.Columns[col].Visible)
                        sheet.Cell(1, col + 1).SetValue(
                            DGV.Columns[col].HeaderCell.Value.ToString());

                for (int row = 0; row < DT.Rows.Count; row++)
                {
                    for (int col = 0; col < DT.Columns.Count; col++)
                    {
                        sheet.Cell(row + 2, col + 1).SetValue(DT.Rows[row][col].ToString());
                    }
                }
                sheet.Columns().AdjustToContents();
                WB.SaveAs(pathSave);
            }
            MessageBox.Show(RSRC.MSG.Success);
        }

        internal void ExportDocument(DataGridViewCellStyle dataGridViewCellStyle)
        {
            throw new NotImplementedException();
        }
    }
}
