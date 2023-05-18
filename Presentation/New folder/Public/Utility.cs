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
using Utilize.ExcelGeneratingClass;
using Application = Microsoft.Office.Interop.Excel.Application;
//using System.Drawing;
//using Spire.Xls;


namespace Presentation.Public
{
    public class Routines
    {
		public static MyDialogResoult ShowErrorMessageFa(string title,string message,MyDialogButton buttons)
		{
			return MyMessageBox.ShowMessage(title, message, buttons, MyDialogIcon.Error, true);
		}

		public static MyDialogResoult ShowErrorMessageFa(string title, string message,string information,MyDialogButton buttons)
		{
			return MyMessageBox.ShowMessage(title, message,information, buttons, MyDialogIcon.Error, true);
		}

		public static MyDialogResoult ShowInfoMessageFa(string title, string message, MyDialogButton buttons)
		{
			return MyMessageBox.ShowMessage(title, message, buttons, MyDialogIcon.Information, true);
		}

		public static MyDialogResoult ShowInfoMessageFa(string title, string message, string information, MyDialogButton buttons)
		{
			return MyMessageBox.ShowMessage(title, message, information, buttons, MyDialogIcon.Information, true);
		}

		public static MyDialogResoult ShowQuestionMessageFa(string title, string message, MyDialogButton buttons)
		{
			return MyMessageBox.ShowMessage(title, message, buttons, MyDialogIcon.Question, true);
		}

		public static MyDialogResoult ShowQuestionMessageFa(string title, string message, string information, MyDialogButton buttons)
		{
			return MyMessageBox.ShowMessage(title, message, information, buttons, MyDialogIcon.Question, true);
		}

        public static void ShowErrorBox(string caption, string errorLog)
        {
            Presentation.Public.frmErrorBox fx = new Presentation.Public.frmErrorBox();
            //fx.lblCaption.Text = caption;
            fx.txtLog.Text = errorLog;

            fx.ShowDialog();    
        }
		
        public static string ShowInputBox()
        {
            Presentation.Public.frmInputBox fx = new Presentation.Public.frmInputBox();
            if (fx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return fx.Description;
            else
                return string.Empty;                
        }
        public static DialogResult ShowMessageBoxFa(string text, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            Presentation.Public.frmMessageBox fx = new Presentation.Public.frmMessageBox();

                fx.MsgCaption = title;
                fx.MsgText = text;
                fx.MsgIcon = icon;
                fx.MsgButtons = buttons;

                System.Windows.Forms.DialogResult dr = fx.ShowDialog();
                return dr;
            
           
        }


        public static DialogResult ShowMessageBoxFa(string text, string title, MessageBoxButtons buttons, MessageBoxIcon icon, Form owner)
        {
            Presentation.Public.frmMessageBox fx = new Presentation.Public.frmMessageBox();

            fx.MsgCaption = title;
            fx.MsgText = text;
            fx.MsgIcon = icon;
            fx.MsgButtons = buttons;
            if (owner != null)
                fx.Owner = owner;

            System.Windows.Forms.DialogResult dr = fx.ShowDialog();
            return dr;
        }
        public static string ShowInputBox(string descr)
        {
            Presentation.Public.frmInputBox fx = new Presentation.Public.frmInputBox();
            fx.Description = descr;
            if (fx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return fx.Description;
            else
                return string.Empty;
        }

        public static string ShowInputBox2(String title)
        {
            Presentation.Public.frmInputBox fx = new Presentation.Public.frmInputBox();
            fx.Title = title;

            if (fx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return fx.Description;
            else
                return string.Empty;
        }
        
        public static string GetExceptionString(Exception ex)
        {
            string exStr = String.Empty;

            //Exception Module
            exStr += "Exception Module			: " + ex.Source + Environment.NewLine;
            //Exception Target
            exStr += "Exception Target			: " + ((ex.TargetSite != null) ? ex.TargetSite.Name : "") + Environment.NewLine;
            //Exception Type
            exStr += "Exception Type			: " + ex.GetType().FullName + Environment.NewLine;
            //Exception Help Link
            exStr += "Help Link				: " + ex.HelpLink + Environment.NewLine;
            //Exception Message
            exStr += "Exception Message			: " + ex.Message + "	" + Environment.NewLine;

            exStr += Environment.NewLine;

            //Stack Trace				
            exStr += "Exception Stack Trace		: " + Environment.NewLine + ex.StackTrace;

            return exStr;
        }
        public static void Verbose(Exception ex)
        {
            try
            {
                //Date and Time	
                string err = "Date and Time			: " + DateTime.Now.ToString() + Environment.NewLine;

                //Machine Name
                err += "Machine Name			: " + Environment.MachineName + Environment.NewLine;

                //IP Address
                string ip = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList[0].ToString();
                err += "IP Address			: " + ip + Environment.NewLine;

                //User Identity
                string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                err += "User Identity			: " + user + Environment.NewLine;

                err += Environment.NewLine;
                err += GetExceptionString(ex);

                Routines.ShowErrorBox(ex.Message, err);
            }
            catch
            {
                Routines.ShowErrorBox(ex.Message, ex.Message);
            }
        }

        public static int GetNumericValue(string s, out int value)
        {
            try
            {
                value = Convert.ToInt32(s);
            }
            catch
            {
                value = 0;
            }

            return value;
        }
        public static double GetNumericValue(string s, out double value)
        {
            try
            {
                value = Convert.ToDouble(s);
            }
            catch
            {
                value = 0;
            }

            return value;
        }
        public static decimal GetNumericValue(string s, out decimal value)
        {
            try
            {
                value = Convert.ToDecimal(s);
            }
            catch
            {
                value = 0;
            }

            return value;
        }
    }

    public class Helper
    {
        public void FormatDataGridView(System.Windows.Forms.DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            //dgv.ReadOnly = true;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Font =  new System.Drawing.Font("B Nazanin",10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 18;
            dgv.RowTemplate.Height = 20;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            System.Windows.Forms.DataGridViewCellStyle style = new System.Windows.Forms.DataGridViewCellStyle();
            style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dgv.RowsDefaultCellStyle = style;
            dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AllowUserToResizeColumns = true;           
        }

        internal void FormatDataGridView(Infragistics.Win.UltraWinGrid.UltraGrid ugSWARTReport)
        {
            throw new NotImplementedException();
        }
    }
    public class Printer
    {
        PrintDocument prtDocument;
        PrintPreviewDialog prtPreviewDialog;
        DataGridViewPrinter dgvPrinter;

        public Printer()
        {
            prtDocument = new PrintDocument();
            prtDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prtDocument_PrintPage);

            prtPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            prtPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            prtPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            prtPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            prtPreviewDialog.Document = this.prtDocument;
            prtPreviewDialog.Enabled = true;
            prtPreviewDialog.Name = "prtPreviewDialog";
            prtPreviewDialog.Visible = false;

        }

        public bool SetupThePrinting(System.Windows.Forms.DataGridView dgv)
        {


            PrintDialog prtDialog = new PrintDialog();
            prtDialog.AllowCurrentPage = false;
            prtDialog.AllowPrintToFile = false;
            prtDialog.AllowSelection = false;
            prtDialog.AllowSomePages = false;
            prtDialog.PrintToFile = false;
            prtDialog.ShowHelp = false;
            prtDialog.ShowNetwork = false;
         

            if (prtDialog.ShowDialog() != DialogResult.OK)
                return false;

            prtDocument.DocumentName = "";
            prtDocument.PrinterSettings = prtDialog.PrinterSettings;
            prtDocument.DefaultPageSettings = prtDialog.PrinterSettings.DefaultPageSettings;
            prtDocument.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);

            dgvPrinter = new DataGridViewPrinter(dgv, prtDocument, true, true, "", new System.Drawing.Font("Tahoma", 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point), System.Drawing.Color.Black, true);

            return true;
        }
        public void PrintDocument()
        {
            prtPreviewDialog.ShowDialog();

        }
        public void prtDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            bool more = dgvPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }

    }

    public class Export
    {
        private SaveFileDialog saveFileDialog;

        public Export()
        
        {
          
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xls)| *.xls|Xml Files (*.xml)| *.xml";

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
                ProgressBox.Show();
                filename = saveFileDialog.FileName;
                dt = new System.Data.DataTable("tbl");

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].Visible)
                        dt.Columns.Add(dgv.Columns[i].HeaderCell.Value.ToString());
                    if(dgv.Columns[i].Name == "LMElementName")
                        dt.Columns.Add(dgv.Columns[i].HeaderCell.Value.ToString());
                }

                for (int j = 0; j < dgv.Rows.Count; j++)
                {

                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        if (dgv.Columns[i].Visible || dgv.Columns[i].Name == "LMElementName")
                        {
                            for (int k = 0; k < dt.Columns.Count; k++)

                                if (dt.Columns[k].ColumnName == dgv.Columns[i].HeaderText.ToString())
                                { dr[k] = dgv.Rows[j].Cells[i].Value; break; }
                            
                        }
                    }
                    dt.Rows.Add(dr);

                }

                if (filename.Substring(filename.Length - 3, 3) == "xls")
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
                    while (row < dt.Rows.Count + 2)
                    {

                       
                        for (int col = 0; col < dt.Columns.Count; col++)
                        {
                            excelWorksheet.Cells[row, col + 1] = dt.Rows[row - 2][col].ToString();
                           // excelWorksheet.Columns.Borders.LineStyle = LineStyleType.Thick;


                            //double ff;
                            //if (Double.TryParse(dt.Rows[row - 2][col].ToString(), out ff))
                            //    helper.AddCell(XmlExcelHelper.CellType.Number, CELL_FONT_FORMAT, dt.Rows[row - 2][col].ToString());
                            //else
                            //    helper.AddCell(XmlExcelHelper.CellType.String, CELL_FONT_FORMAT, dt.Rows[row - 2][col].ToString());

 

                        }
                        row++;
                    }
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

                ProgressBox.Hide();
                Routines.ShowMessageBoxFa("فایل اکسل با موفقیت ایجاد شد",
                   "اعلام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }


        internal void ExportDocument(DataGridViewCellStyle dataGridViewCellStyle)
        {
            throw new NotImplementedException();
        }
    }
   
}
