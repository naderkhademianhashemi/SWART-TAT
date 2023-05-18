using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Infragistics.Excel;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using Utilize.Helper;

namespace Utilize.Excel
{
    public partial class frmGrid : Form
    {
        public frmGrid(DataTable table,string fileName)
        {
            InitializeComponent();
            dgvExcel.DataSource = table;
            dgvExcel.DataBind();
            var exporter= new UltraGridExcelExporter();
            exporter.RowExporting += new RowExportingEventHandler(exporter_RowExporting);
            exporter.EndExport += new EndExportEventHandler(exporter_EndExport);
            exporter.Export(dgvExcel, fileName);
        }

        void exporter_EndExport(object sender, EndExportEventArgs e)
        {
            dgvExcel.Dispose();
            this.Close();
        }

        [DefaultValue(1000000)] public int SheetByCountRow = 1000000;

        private WorksheetRow HeaderRow;
        private int count;
        private long CountOfRow;
        void exporter_RowExporting(object sender, RowExportingEventArgs e)
        {
            if (HeaderRow == null)
            {
                HeaderRow = e.Workbook.Worksheets["Sheet1"].Rows[0];
                count = HeaderRow.Cells.Where(item => item.Value.ToString().Trim().Length != 0).Count();
            }
            var indexSheet = "1-" + SheetByCountRow;
            if (e.CurrentRowIndex > Convert.ToInt64(SheetByCountRow))
            {
                CountOfRow = CountOfRow + Convert.ToInt64(SheetByCountRow);
                indexSheet = (CountOfRow + 1) + "-" + (CountOfRow + Convert.ToInt64(SheetByCountRow));
            }
            if (e.Workbook.Worksheets[0].Name.Equals("Sheet1"))
                e.Workbook.Worksheets[0].Name = indexSheet;
            var worksheet = e.Workbook.Worksheets.Where(ws => ws.Name.Equals(indexSheet)).FirstOrDefault();
            if (worksheet == null)
            {
                worksheet = e.Workbook.Worksheets.Add(indexSheet);
                e.CurrentWorksheet = worksheet;
                  
                for (var i = 1; i < count + 1; i++)
                {
                    worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).Value = HeaderRow.Cells[i - 1].Value;
                    worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).Value = HeaderRow.Cells[i - 1].Value;
                    worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.Alignment =
                        HeaderRow.Cells[i - 1].CellFormat.Alignment;
                    worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.FillPatternBackgroundColor =
                        HeaderRow.Cells[i - 1].CellFormat.FillPatternBackgroundColor;
                    worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.FillPatternForegroundColor =
                        HeaderRow.Cells[i - 1].CellFormat.FillPatternForegroundColor;

                    worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.Font.Name =
                        HeaderRow.Cells[i - 1].CellFormat.Font.Name;
                    worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.Font.Bold =
                        HeaderRow.Cells[i - 1].CellFormat.Font.Bold;
                    worksheet.GetCell(string.Format("{0}1", (EnglishAlphabet)(i - 1))).CellFormat.Font.Color =
                        HeaderRow.Cells[i - 1].CellFormat.Font.Color;
                }
                e.CurrentRowIndex = 1;
            }
        }
    }
}
