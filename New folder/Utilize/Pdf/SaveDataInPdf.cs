using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Excel;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using Utilize.Helper;
using System.IO;

namespace Utilize.Pdf
{
    public partial class SaveDataInPdf : UserControl
    {
        //[DefaultValue(true)]
        //public bool ShowSplitSheetByColumn
        //{
        //    get
        //    {
        //        return rbtSheetByColumn.Enabled;
        //    }
        //    set
        //    {
        //        rbtSheetByColumn.Enabled = value;
        //    }
        //}
        [DefaultValue(true)]
        public bool ShowSplitFileByColumn
        {
            get
            {
                return rbtFileByColumn.Enabled;
            }
            set
            {
                rbtFileByColumn.Enabled = value;
            }
        }
        [DefaultValue(true)]
        public bool ShowSplitFileByCount
        {
            get
            {
                return rbtFileByCountRow.Enabled;
            }
            set
            {
                rbtFileByCountRow.Enabled = value;
            }
        }
        //[DefaultValue(true)]
        //public bool ShowSplitSheetByCount
        //{
        //    get
        //    {
        //        return rbtSheetByCountRow.Enabled;
        //    }
        //    set
        //    {
        //        rbtSheetByCountRow.Enabled = value;
        //    }
        //}



        private UltraGrid _ultraGrid;
        public UltraGrid Grid
        {
            get { return _ultraGrid; }
            set
            {
                _ultraGrid = value;

            }
        }

        public SaveDataInPdf()
        {
            InitializeComponent();
        }

        private void rbtSheetByColumn_CheckedChanged(object sender, EventArgs e)
        {
            //cmbSheetByColumn.Enabled = rbtSheetByColumn.Checked;
        }

        private void rbtSheetByCountRow_CheckedChanged(object sender, EventArgs e)
        {
            //txtSheetByCountRow.Enabled = rbtSheetByCountRow.Checked;
        }

        private void rbtFileByColumn_CheckedChanged(object sender, EventArgs e)
        {
            cmbFileByColumn.Enabled = rbtFileByColumn.Checked;
        }

        private void rbtFileByCountRow_CheckedChanged(object sender, EventArgs e)
        {
            txtFileByCountRow.Enabled = rbtFileByCountRow.Checked;
        }

        private void btnFolderBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderName.Text = folderBrowserDialog.SelectedPath;
            }
        }
        public void Config(UltraGrid grid)
        {
            _ultraGrid = grid;
            ultraGridPdfExporter.RowExporting += ultraGridPdfExporter_RowExporting;
            ultraGridPdfExporter.EndExport += ultraGridPdfExporter_EndExport;
            if (Grid == null) return;
            if (Grid.DataSource == null) return;
            var table = ((DataTable)Grid.DataSource);
            foreach (var column in table.Columns.Cast<DataColumn>())
            {
                cmbFileByColumn.Items.Add(column.ColumnName);
                //cmbSheetByColumn.Items.Add(column.ColumnName);
            }
        }

        

        private WorksheetRow HeaderRow;
        private int count;
        private long CountOfRow;
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        private readonly Dictionary<string, int> dictionaryIndexRow = new Dictionary<string, int>();

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFolderName.Text.Length == 0)
            {
                Routines.ShowInfoMessageFa("خطا", "مسیر ذخیره فایل به درستی مشخص نشده است", MyDialogButton.OK);
                return;
            }
            if (!Directory.Exists(txtFolderName.Text))
            {
                Routines.ShowInfoMessageFa("خطا", "مسیر ذخیره فایل به درستی مشخص نشده است", MyDialogButton.OK);
                return;
            }
            if (File.Exists(txtFolderName.Text + @"\" + txtDefaultName.Text + ".pdf"))
                if (Routines.ShowInfoMessageFa("خطا", "در مسیر انتخابی، فایلی با نام مورد نظر وجود دارد" + "\n" +
                                                        "آیا مایل به بازنویسی آن هستید؟",
                        MyDialogButton.YesNO) == MyDialogResoult.No)
                {
                    return;
                }

            ProgressBox.UtProgressBox.Show();

            dictionaryIndexRow.Clear();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            if (rbtFileByColumn.Checked)
            {
                var xlApp = new Microsoft.Office.Interop.Excel.Application { Visible = false };
                var indexFileByColumn = cmbFileByColumn.Text.Clone().ToString();
                var table = _ultraGrid.DataSource as DataTable;
                var ExFiles =
                    table.Rows.Cast<DataRow>().Select(
                        row =>
                        row[cmbFileByColumn.Text].
                            ToString()).Distinct().ToList();

                Parallel.ForEach(ExFiles, ExFile =>
                                              {
                                                  var wb =
                                                      xlApp.Workbooks.Add(
                                                          Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                                                  var ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Sheets[1];
                                                  ws.Cells.EntireColumn.AutoFit();
                                                  if (string.IsNullOrEmpty(ExFile))
                                                      ws.Name = "بدون عنوان";
                                                  else
                                                      ws.Name = ExFile.Length > 31
                                                                    ? ExFile.Substring(0, 28) + "..."
                                                                    : ExFile;
                                                  var dataRows =
                                                      table.Rows.Cast<DataRow>().Where(
                                                          row => row[indexFileByColumn].ToString().Trim().Equals(ExFile.Trim())).ToList();
                                                  for (var r = 0; r < table.Columns.Count; r++)
                                                  {
                                                      var field =
                                                          (Microsoft.Office.Interop.Excel.Range)ws.Cells[1, r + 1];
                                                      field.Formula = table.Columns[r].Caption;
                                                      field.Font.Name = "Tahoma";
                                                      field.Borders.Color = Color.Red;
                                                  }
                                                  for (var i = 0; i < dataRows.Count(); i++)
                                                  {
                                                      for (var j = 0;
                                                           j < dataRows.FirstOrDefault().ItemArray.Count();
                                                           j++)
                                                      {
                                                          var field =
                                                              (Microsoft.Office.Interop.Excel.Range)
                                                              ws.Cells[i + 2, j + 1];
                                                          field.Formula = dataRows.ElementAt(i).ItemArray[j].ToString();
                                                          field.Font.Name = "Tahoma";
                                                      }
                                                  }
                                                  wb.SaveAs(txtFolderName.Text + @"\" + ExFile.GetTitle() + ".xlsx", Missing.Value,
                                                            Missing.Value,
                                                            Missing.Value, Missing.Value, Missing.Value,
                                                            Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                                                            Missing.Value, Missing.Value, Missing.Value,
                                                            Missing.Value, Missing.Value);
                                                  wb.Close(true, Missing.Value, Missing.Value);

                                              });
                xlApp.Quit();
                xlApp.Application.Quit();
                //Routines.ShowInfoMessageFa("خروجی اکسل", "پایان عملیات خروجی اکسل", MyDialogButton.OK);
                return;
            }
            if (rbtFileByCountRow.Checked)
            {

                var xlApp = new Microsoft.Office.Interop.Excel.Application { Visible = false };
                var table = _ultraGrid.DataSource as DataTable;
                var allCount = table.Rows.Count;
                var incItem = Convert.ToInt32(txtFileByCountRow.Value);
                var colCount = table.Columns.Count;
                Parallel.For(0, Convert.ToInt32(Math.Ceiling((decimal)allCount / incItem)), i =>
                                                      {
                                                          var workbook =
                                                              xlApp.Workbooks.Add(
                                                                  Microsoft.Office.Interop.Excel.XlWBATemplate.
                                                                      xlWBATWorksheet);
                                                          var worksheet =
                                                              (Microsoft.Office.Interop.Excel.Worksheet)
                                                              workbook.Sheets[1];
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
                                                              txtFolderName.Text + @"\" +
                                                              string.Format("{0}-{1}", (i * incItem) + 1, (i + 1) * incItem) +
                                                              ".xlsx", Missing.Value, Missing.Value,
                                                              Missing.Value, Missing.Value, Missing.Value,
                                                              Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.
                                                                  xlNoChange,
                                                              Missing.Value, Missing.Value, Missing.Value,
                                                              Missing.Value, Missing.Value);
                                                          workbook.Close(true, Missing.Value, Missing.Value);
                                                      });
                xlApp.Quit();
                xlApp.Application.Quit();

                return;
            }

            ultraGridPdfExporter.RowExporting += (_sender, _args) =>
            {

                var _count = _args.GridRow.Cells.Count;
                long CodeMeli = 0;
                for (int i = 0; i < _count; i++)
                {
                    if (_args.GridRow.Cells[i].Column.Header.Caption.Equals("کد ملی"))// && _args.GridRow.Cells[i].Value is string)
                    {

                        if (_args.GridRow.Cells[i].Value.ToString().IsNullOrEmptyByTrim() == false &&
                            Int64.TryParse(_args.GridRow.Cells[i].Value.ToString().Trim(), out CodeMeli) == false)
                            _args.GridRow.Cells[i].Value = "نا معتبر است";
                    }
                }
            };

            ultraGridPdfExporter.Export(_ultraGrid, txtFolderName.Text + @"\" + txtDefaultName.Text + ".pdf",
                    Infragistics.Win.UltraWinGrid.DocumentExport.GridExportFileFormat.PDF);
            ProgressBox.UtProgressBox.Hide();
            Routines.ShowInfoMessageFa("pdf خروجی", " pdf پایان عملیات خروجی", MyDialogButton.OK);
            this.Parent.Dispose();
            return;
            //Response.ContentType = "application/pdf";
            //Response.AddHeader("content-disposition","attachment;filename=GridViewExport.pdf");
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //StringWriter sw = new StringWriter();
            //HtmlTextWriter hw = new HtmlTextWriter(sw);
            //_ultraGrid.AllowPaging = false;
            //_ultraGrid.DataBind();
            //_ultraGrid.RenderControl(hw);
            //StringReader sr = new StringReader(sw.ToString());

            //Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

            //HTMLWorker htmlparser = new HTMLWorker(pdfDoc);

            //PdfWriter.GetInstance(pdfDoc, Response.OutputStream);

            //pdfDoc.Open();

            //htmlparser.Parse(sr);

            //pdfDoc.Close();

            //Response.Write(pdfDoc);

            //Response.End();  

            //Document document = new Document();
            //try
            //{
            //    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("Chap1002.pdf", FileMode.Create));
            //    document.Open();
            //    document.Add(new Paragraph("Hello World"));
            //    PdfContentByte cb = writer.DirectContent;
            //    cb.BeginText();
            //    cb.SetTextMatrix(100, 400);
            //    cb.ShowText("Text at position 100,400.");
            //    cb.EndText();            
            //}

            //catch (DocumentException de)
            //{
            //    Console.Error.WriteLine(de.Message);
            //}
            //catch (IOException ioe)
            //{
            //    Console.Error.WriteLine(ioe.Message);
            //}
            //// step 5: we close the document
            //document.Close();
            Routines.ShowInfoMessageFa("PDf خروجی", "PDf پایان عملیات خروجی", MyDialogButton.OK);
        }

        private void ultraGridPdfExporter_RowExporting(object sender, Infragistics.Win.UltraWinGrid.DocumentExport.RowExportingEventArgs e)
        {
            if (HeaderRow == null)
            {
                //HeaderRow = e.Workbook.Worksheets["Sheet1"].Rows[0];
                //count = HeaderRow.Cells.Where(item => item.Value.ToString().Trim().Length != 0).Count();
            }
            #region ذخیره به صورت شیت های جداد جدا بر اساس ستون

            //if (rbtSheetByColumn.Checked)
            //{
            //    var row = e.GridRow;
            //    if (row.Cells == null) return;
            //    var indexSheet = row.Cells[cmbSheetByColumn.Text].Value.ToString();
            //    if (e.Workbook.Worksheets[0].Name.Equals("Sheet1"))
            //    {
            //        if (indexSheet.Length > 31)
            //        {
            //            var item = _dictionary.Where(ee => ee.Key.Equals(indexSheet.GetTitle())).FirstOrDefault();
            //            //  = _dictionary[indexSheet];
            //            if (item.Value == null)
            //            {
            //                var ins = indexSheet.Substring(0, 28 - _dictionary.Count.ToString().Length) +
            //                          (_dictionary.Count + 1);
            //                _dictionary.Add(indexSheet.GetTitle(), ins.GetTitle());
            //                //if (string.IsNullOrEmpty(ins))
            //                //    e.Workbook.Worksheets[0].Name = "بدون عنوان";
            //                //else
            //                e.Workbook.Worksheets[0].Name = ins.GetTitle();
            //            }
            //        }
            //        else
            //        {
            //            //if (string.IsNullOrEmpty(indexSheet.Trim()))
            //            //    e.Workbook.Worksheets[0].Name = "بدون عنوان";
            //            //else
            //            e.Workbook.Worksheets[0].Name = indexSheet.GetTitle();
            //        }
            //    }
            //    else
            //        if (indexSheet.Length > 31)
            //        {
            //            var item = _dictionary.Where(ee => ee.Key.Equals(indexSheet.GetTitle())).FirstOrDefault();
            //            if (item.Value == null)
            //            {
            //                var ins = indexSheet.Substring(0, 28 - _dictionary.Count.ToString().Length) +
            //                          (_dictionary.Count + 1);
            //                _dictionary.Add(indexSheet.GetTitle(), ins.GetTitle());
            //                indexSheet = ins.GetTitle();
            //            }
            //            else
            //                indexSheet = item.Value;
            //        }
            //    var worksheet = e.Workbook.Worksheets.Where(ws => ws.Name.Equals(indexSheet.GetTitle())).FirstOrDefault();
            //    if (worksheet == null)
            //    {
            //        dictionaryIndexRow.Add(indexSheet.GetTitle(), 1);
            //        worksheet = e.Workbook.Worksheets.Add(indexSheet.GetTitle());
            //        e.CurrentWorksheet = worksheet;

            //        for (var i = 1; i < count + 1; i++)
            //        {
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).Value = HeaderRow.Cells[i - 1].Value;
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).Value = HeaderRow.Cells[i - 1].Value;
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.Alignment =
            //                HeaderRow.Cells[i - 1].CellFormat.Alignment;
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.FillPatternBackgroundColor =
            //                HeaderRow.Cells[i - 1].CellFormat.FillPatternBackgroundColor;
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.FillPatternForegroundColor =
            //                HeaderRow.Cells[i - 1].CellFormat.FillPatternForegroundColor;

            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.Font.Name =
            //                HeaderRow.Cells[i - 1].CellFormat.Font.Name;
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.Font.Bold =
            //                HeaderRow.Cells[i - 1].CellFormat.Font.Bold;
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.Font.Color =
            //                HeaderRow.Cells[i - 1].CellFormat.Font.Color;
            //        }
            //        //e.CurrentRowIndex = 1;
            //        e.CurrentRowIndex = dictionaryIndexRow[indexSheet.GetTitle()];
            //        dictionaryIndexRow[indexSheet.GetTitle()] = dictionaryIndexRow[indexSheet.GetTitle()] + 1;
            //    }
            //    else
            //    {
            //        e.CurrentWorksheet = worksheet;
            //        if (dictionaryIndexRow.Any(item => item.Key.Equals(indexSheet.GetTitle())) == false)
            //            dictionaryIndexRow.Add(indexSheet.GetTitle(), e.CurrentRowIndex == 1 ? 1 : 2);
            //        e.CurrentRowIndex = dictionaryIndexRow[indexSheet.GetTitle()];
            //        dictionaryIndexRow[indexSheet.GetTitle()] = dictionaryIndexRow[indexSheet.GetTitle()] + 1;
            //        //e.CurrentRowIndex = 1;
            //    }
            //}
            #endregion

            #region ذخیره به صورت شیت های جدا جدا بر اساس تعداد ردیف ها

            //if (rbtSheetByCountRow.Checked)
            //{
            //    var indexSheet = "1-" + txtSheetByCountRow.Value;
            //    if (e.CurrentRowIndex > Convert.ToInt64(txtSheetByCountRow.Value))
            //    {
            //        CountOfRow = CountOfRow + Convert.ToInt64(txtSheetByCountRow.Value);
            //        indexSheet = (CountOfRow + 1) + "-" + (CountOfRow + Convert.ToInt64(txtSheetByCountRow.Value));
            //    }
            //    if (e.Workbook.Worksheets[0].Name.Equals("Sheet1"))
            //        e.Workbook.Worksheets[0].Name = indexSheet;
            //    var worksheet = e.Workbook.Worksheets.Where(ws => ws.Name.Equals(indexSheet)).FirstOrDefault();
            //    if (worksheet == null)
            //    {
            //        worksheet = e.Workbook.Worksheets.Add(indexSheet);
            //        e.CurrentWorksheet = worksheet;

            //        for (var i = 1; i < count + 1; i++)
            //        {
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).Value = HeaderRow.Cells[i - 1].Value;
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).Value = HeaderRow.Cells[i - 1].Value;
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.Alignment =
            //                HeaderRow.Cells[i - 1].CellFormat.Alignment;
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.FillPatternBackgroundColor =
            //                HeaderRow.Cells[i - 1].CellFormat.FillPatternBackgroundColor;
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.FillPatternForegroundColor =
            //                HeaderRow.Cells[i - 1].CellFormat.FillPatternForegroundColor;

            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.Font.Name =
            //                HeaderRow.Cells[i - 1].CellFormat.Font.Name;
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.Font.Bold =
            //                HeaderRow.Cells[i - 1].CellFormat.Font.Bold;
            //            worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.Font.Color =
            //                HeaderRow.Cells[i - 1].CellFormat.Font.Color;
            //        }
            //        e.CurrentRowIndex = 1;
            //    }
            //}
            #endregion
        }

        private void ultraGridPdfExporter_EndExport(object sender, Infragistics.Win.UltraWinGrid.DocumentExport.EndExportEventArgs e)
        {
            HeaderRow = null;
            //Routines.ShowInfoMessageFa("خروجی اکسل", "پایان عملیات خروجی اکسل", MyDialogButton.OK);
        }

        private void SaveDataInPdf_Load(object sender, EventArgs e)
        {
            if (_ultraGrid == null) return;
            ultraGridPdfExporter.RowExporting += ultraGridPdfExporter_RowExporting;
            ultraGridPdfExporter.EndExport += ultraGridPdfExporter_EndExport;
            //ultraGridPdfExporter.Container.
        }

        private void SaveDataInPdf_Validating(object sender, CancelEventArgs e)
        {
            if (Grid == null) return;
            if (Grid.DataSource == null) return;
            var table = ((DataTable)Grid.DataSource);
            foreach (var column in table.Columns.Cast<DataColumn>())
            {
                cmbFileByColumn.Items.Add(column.ColumnName);
                //cmbSheetByColumn.Items.Add(column.ColumnName);
            }
        }


    }

}
