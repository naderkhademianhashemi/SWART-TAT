using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using Infragistics.Win.UltraDataGridView;
using Utilize.ExcelGeneratingClass;
using System.Xml.Linq;
using System.Xml;
using System.Linq;
using Application = Microsoft.Office.Interop.Excel.Application;
//using System.Drawing;
//using Spire.Xls;


namespace Utilize.Excel
{
    

    public class Export
    {
        private SaveFileDialog saveFileDialog;

        public Export()
        
        {
          
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xls)| *.xls|Xml Files (*.xml)| *.xml";

        }


        public void ExportDocument(Infragistics.Win.UltraWinGrid.UltraGrid dgv, String FileAddress)
        {

            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = null;
            Microsoft.Office.Interop.Excel._Application excelApplication = null;
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook = null;
            System.Data.DataTable dt;
            string filename = FileAddress;

            //if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            //{
            //    //ProgressBox.Show();
                //filename = saveFileDialog.FileName;
                dt = new System.Data.DataTable("tbl");
                dt =  (System.Data.DataTable)dgv.DataSource;
                dt.TableName = "tbl";
                for (int i = 0; i < dgv.DisplayLayout.Bands[0].Columns.Count; i++)
                {
                    //if (dgv.DisplayLayout.Bands[0].Columns[i].IsVisibleInLayout)
                    //    dt.Columns.Add(dgv.DisplayLayout.Bands[0].Columns[i].ToString());
                    if (!dgv.DisplayLayout.Bands[0].Columns[i].IsVisibleInLayout)
                        dt.Columns.Remove(dgv.DisplayLayout.Bands[0].Columns[i].ToString().Replace(" [hidden]", ""));
                }

                //for (int j = 0; j < dgv.Rows.Count; j++)
                //{

                //    DataRow dr = dt.NewRow();
                //    for (int i = 0; i < dgv.DisplayLayout.Bands[0].Columns.Count; i++)
                //    {
                //        if (dgv.DisplayLayout.Bands[0].Columns[i].IsVisibleInLayout)
                //        {
                //            for (int k = 0; k < dt.Columns.Count; k++)

                //                if (dt.Columns[k].ColumnName == dgv.DisplayLayout.Bands[0].Columns[i].ToString())
                //                { dr[k] = dgv.Rows[j].Cells[i].Value; break; }
                            
                //        }
                //    }
                //    dt.Rows.Add(dr);

                //}

                if (filename.Substring(filename.Length - 3, 3) == "xls" || filename.Substring(filename.Length - 4, 4) == "xlsx")
                {

                    object paramMissing = Type.Missing;

                    System.Globalization.CultureInfo oldCl = System.Threading.Thread.CurrentThread.CurrentCulture;

                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    var _Application = new Application();
                    var workbook=_Application.Workbooks.Add();
                    excelWorksheet = workbook.Worksheets.Add();
                    excelWorksheet.Cells.Font.Name = "B Nazanin";
                    excelWorksheet.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    excelWorksheet.Cells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    excelWorksheet.Cells.ColumnWidth = 25;
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        excelWorksheet.Cells[1, i + 1] = dt.Columns[i].Caption.ToString();
                        //if (dt.Columns[i].ColumnName.Equals("شماره تسهیلات"))
                        //    excelWorksheet.Cells[1, i + 1]. NumberFormat = "00";
                            //MessageBox.Show("CONTRACT");
                        excelWorksheet.Cells[1, i + 1].Interior.Color = Color.FromArgb(217, 156, 11);
                        excelWorksheet.Cells[1, i + 1].Font.Name = "Titr";
                        excelWorksheet.Cells[1, i + 1].Borders.Color = Color.Black;
                        excelWorksheet.Cells[1, i + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        excelWorksheet.Cells[1, i + 1].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }

                    int row = 2;
                    
                    var action=new Action<DataRow,int,int>((_row,_colCount,_rowIndex)=>{
                        System.Threading.Tasks.Parallel.For(0, _colCount, (index) => {
                            excelWorksheet.Cells[_rowIndex + 1, index + 1] = _row[index].ToString();
                            
                        });
                    });

                    var rowList = dt.Rows.Cast<DataRow>().Select(item => new { _row = item, _rowIndex = item.ItemArray[0] }).ToList();

                    System.Threading.Tasks.Parallel.ForEach(rowList, item => {
                        action(item._row,dt.Columns.Count,Convert.ToInt32(item._rowIndex));
                    });

                    //System.Threading.Tasks.Parallel.For(row, dt.Rows.Count + 1, (index) => {
                    //    action(dt.Rows[row - 2], dt.Columns.Count);
                    //    row++;
                    //});

                    //System.Threading.Tasks.Parallel.ForEach<DataRow>(dt.Rows.Cast<DataRow>,
                    //    item => action(item, dt.Columns.Count));

                    //while (row < dt.Rows.Count + 2)
                    //{
                    //    System.Threading.Tasks.Parallel.For(0, dt.Columns.Count, (index) => {
                    //        excelWorksheet.Cells[row, index + 1] = dt.Rows[row - 2][index].ToString();
                    //    });
                        //for (int col = 0; col < dt.Columns.Count; col++)
                        //{
                            
                        //    excelWorksheet.Cells[row, col + 1] = dt.Rows[row - 2][col].ToString();
                        //   // excelWorksheet.Columns.Borders.LineStyle = LineStyleType.Thick;


                        //    //double ff;
                        //    //if (Double.TryParse(dt.Rows[row - 2][col].ToString(), out ff))
                        //    //    helper.AddCell(XmlExcelHelper.CellType.Number, CELL_FONT_FORMAT, dt.Rows[row - 2][col].ToString());
                        //    //else
                        //    //    helper.AddCell(XmlExcelHelper.CellType.String, CELL_FONT_FORMAT, dt.Rows[row - 2][col].ToString());

 

                        //}
                    //    row++;
                    //}
                  //  helper.SaveDocument();
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

                    System.IO.FileStream myFileStream = new System.IO.FileStream
                       (filename, System.IO.FileMode.Create);
                    dt.WriteXml(myFileStream);
                }

                //ProgressBox.Hide();
                //Routines.ShowMessageBoxFa("فایل اکسل با موفقیت ایجاد شد",
                //   "اعلام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
           
        }


        internal void ExportDocument(DataGridViewCellStyle dataGridViewCellStyle)
        {
            throw new NotImplementedException();
        }
    }
   
}
