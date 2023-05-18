using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using Presentation.Public;
using Utilize.Helper;
using ERMSLib;
using Infragistics.Win.UltraWinGrid.DocumentExport;
using System.Drawing;


namespace Presentation.Report
{
    public partial class frmShowReprt : BaseForm
    {
        [DefaultValue(false)]
        public bool CompareEnable;

        public string ColNameOneForCompare;
        public string ColNameTwoForCompare;
        Infragistics.Shared.IKeyedSubObject[] filters = new Infragistics.Shared.IKeyedSubObject[50];
        public string SCA = "";
        public string SCAA = "";
        public string TN = "";
        public string F = "";
        public string OrderBy = "";
        public DateTime HistoricDate = DateTime.Now;
        private readonly DataTable DataSource;
        public frmShowReprt(object dataSource)
        {

            InitializeComponent();
            DataSource = (dataSource as DataTable);

            foreach (DataColumn col in DataSource.Columns)
            {
                if (col.ColumnName.Contains("شناسنامه") || col.ColumnName.Contains("ملی"))
                    col.DataType = typeof(string); 
            }

            cmbUnit.AddItemsRange(new string[] { "واحد", "هزار", "ميليون", "میلیارد" });
            cmbUnit.SelectedIndex = 0;


            //CrystaReportViewer 
            
            // Creating object of our report.
            //DataSet ds = new DataSet();
            
            //dt = (dataSource as DataTable).Copy();
            //ds.Tables.Clear();
            //ds.Tables.Add(dt);
            //objRpt = new frmShowReportCrystal();

            //objRpt.Database.Tables["Report"].SetDataSource(ds.Tables[0]);

            //objRpt.SetDataSource(ds.Tables[0]);
            //CrystalDecisions.CrystalReports.Engine.TextObject root;
            //root = (CrystalDecisions.CrystalReports.Engine.TextObject)
            //     objRpt.ReportDefinition.ReportObjects["txt_header"];
            //root.Text = "Sample Report By Using Data Table!!";
            //crystalReportViewer1.ReportSource = objRpt;

             //using (crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer())
             //   {
             //       using (CrystalDecisions.CrystalReports.Engine.ReportDocument ReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument())
             //       {
             //           ReportDocument.Load("E:\\Hosein\\SWRT-TAT\\SWART-TAT\\Presentation\\Report\\frmShowReportCrystal.rpt" );
             //           ReportDocument.Database.Tables[0].SetDataSource(ds.Tables[0]);
             //           crystalReportViewer1.ReportSource = ReportDocument;
             //           crystalReportViewer1.RefreshReport();
             //           crystalReportViewer1.Visible = true;
             //       }
             //   }

            //DataTable dt = new DataTable("Report123");
            //frmShowReportCrystal reportcr = new frmShowReportCrystal();
            //// Set data source to the crystal report. If the report contains multiple
            //// datatables, then we can index each tables by using the table
            //// name. Following code explains how table name is used for indexing.
            //reportcr.Database.Tables["Report123"].SetDataSource((DataTable)dt);
            //// Assign the report to the Crystal report viewer
            //crystalReportViewer1.ReportSource = reportcr;
        }
   

        private void frmShowReprt_Load(object sender, EventArgs e)
        {
            txtFrom.Text = Properties.Resources.StartIndexForReportShow;
            txtFrom.Value = Properties.Resources.StartIndexForReportShow;

            txtTo.Text = Properties.Resources.MaxSizeOfRowForReport;
            txtTo.Value = Properties.Resources.MaxSizeOfRowForReport;

            txtIncItem.Text = Properties.Resources.MaxSizeOfRowForReport;
            txtIncItem.Value = Properties.Resources.MaxSizeOfRowForReport;
            btnBefore.Enabled = false;
            var table = ((DataTable)DataSource).ConfigDateTimeToPersian();

            if (CompareEnable)
            {
                DataColumn colStatus = null;
                DataColumn colStatusNumber = null;
                try
                {
                    if (ColNameOneForCompare.IsNullOrEmptyByTrim() == false &&
                        ColNameTwoForCompare.IsNullOrEmptyByTrim() == false)
                    {
                        colStatus = new DataColumn("نمایش وضعیت", typeof(System.Drawing.Bitmap)) { ReadOnly = false };
                        colStatusNumber = new DataColumn("نمایش وضعیت عدد", typeof(string)) { ReadOnly = false };
                        table.Columns.Add(colStatus);
                        table.Columns.Add(colStatusNumber);
                    }
                    foreach (var row in table.Rows.Cast<DataRow>())
                    {
                        if (row[ColNameOneForCompare].ToString().ToDouble() >
                            row[ColNameTwoForCompare].ToString().ToDouble())
                        {
                            if (colStatus != null) row[colStatus] = Properties.Resources.Aqua_Ball_Green_16_16;
                            if (colStatusNumber != null) row[colStatusNumber] = "1";
                            continue;
                        }
                        if (row[ColNameOneForCompare].ToString().ToDouble() ==
                            row[ColNameTwoForCompare].ToString().ToDouble())
                        {
                            if (colStatus != null) row[colStatus] = Properties.Resources.Aqua_Ball_Yellow_16_16;
                            if (colStatusNumber != null) row[colStatusNumber] = "0";
                            continue;
                        }
                        if (row[ColNameOneForCompare].ToString().ToDouble() <
                            row[ColNameTwoForCompare].ToString().ToDouble())
                        {
                            if (colStatus != null) row[colStatus] = Properties.Resources.Aqua_Ball_Red_16_16;
                            if (colStatusNumber != null) row[colStatusNumber] = "-1";
                            continue;
                        }
                    }
                }
                catch (Exception)
                {
                    if (colStatus != null) table.Columns.Remove(colStatus);
                }
            }
            ugSWARTReport.DataSource = table;
            ugSWARTReport.DataBind();

            foreach (var column in
                ugSWARTReport.DisplayLayout.Bands[0].Columns.Cast<UltraGridColumn>().Where(column => Equals(column.DataType, typeof(decimal))))
            {
                column.Format = "#,###.##";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtFrom.Text = (txtTo.Value.ToString().ToInt() + 1).ToString();
            txtTo.Text = (txtTo.Value.ToString().ToInt() + txtIncItem.Value.ToString().ToInt()).ToString();
            btnBefore.Enabled = true;
            ConfReport();


            // Hosein : 91.02.31 -> baraye zakhire filtersazi va emal dar safehate bad
            ///
            //ProgressBox.Show();

            //var CreationFilter = ugSWARTReport.CreationFilter;
            //var CurrentState = ugSWARTReport.CurrentState;
            //var DrawFilter = ugSWARTReport.DrawFilter;
            //var selectionStrategyFilter = ugSWARTReport.SelectionStrategyFilter;
            //ugSWARTReport.ShowCustomFilterDialog(,

            //ColumnFiltersCollection cfc = new ColumnFiltersCollection();
            //ColumnFiltersCollection[] cfc=new ColumnFiltersCollection[100];
            //ugSWARTReport.Rows.ColumnFilters.CopyTo(cfc,0);
            //var filterrow = ugSWARTReport.Rows.FilterRow;

            
            
            //cfc[0].
            //foreach(var filter in filters)
            //{

            //}
            
            //ugSWARTReport.Rows.ColumnFilters.CopyFrom(cfc[0]);
            //var band = ugSWARTReport.Rows.Band;
            //band.ColumnFilters.
            
            //ugSWARTReport.Rows.ColumnFilters = filterrow;
            //UltraGridBand ub = new UltraGridBand();
            //ColumnsCollection cc = new ColumnsCollection(
            
            //ugSWARTReport.Rows.ColumnFilters.CopyFrom(
            //ugSWARTReport.SelectionStrategyFilter = selectionStrategyFilter;
            //ProgressBox.Hide();
            ///
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            //ProgressBox.Show();
            var selectionStrategyFilter = ugSWARTReport.SelectionStrategyFilter;

            txtFrom.Text = (txtFrom.Value.ToString().ToInt() - txtIncItem.Value.ToString().ToInt()).ToString();
            txtTo.Text = (txtTo.Value.ToString().ToInt() - txtIncItem.Value.ToString().ToInt()).ToString();
            if (txtFrom.Value.ToString().Trim().Equals(Properties.Resources.Key_OneNumber))
                btnBefore.Enabled = false;
            ConfReport();

            ugSWARTReport.SelectionStrategyFilter = selectionStrategyFilter;
            //ProgressBox.Hide();
        }

        private void ConfReport()
        {
            ProgressBox.Show();
            int dataTableCount = 0;
            ugSWARTReport.DataSource = null;
            try
            {
                if (TN.ToUpper().Equals(Properties.Resources.KEY_NameOfDepositReport.ToUpper()))
                {
                    using (var reportByPaging = new DAL.DepositDataSet().GetDepositHistoricReportByPaging(SCA, SCAA, F, OrderBy, txtFrom.Value.ToString(), txtTo.Value.ToString()))
                    {
                        ugSWARTReport.DataSource = reportByPaging.ConfigDateTimeToPersian();
                        ugSWARTReport.DataBind();
                        dataTableCount = ((DataTable)ugSWARTReport.DataSource).Rows.Count;
                        reportByPaging.Dispose();
                    }
                }
                if (TN.ToUpper().Equals(Properties.Resources.KEY_NameOfLoanReport.ToUpper()))
                {
                    using (var reportByPaging = new DAL.LoanDataSet().GetLoanReportByPaging(SCA, SCAA, F, txtFrom.Value.ToString(), txtTo.Value.ToString()))
                    {
                        ugSWARTReport.DataSource = reportByPaging.ConfigDateTimeToPersian();
                        ugSWARTReport.DataBind();
                        dataTableCount = ((DataTable)ugSWARTReport.DataSource).Rows.Count;
                        reportByPaging.Dispose();
                    }
                }
                if (TN.ToUpper().Equals(Properties.Resources.Key_NameOfVLoanByCollactDetailsReport.ToUpper()))
                {
                    using (var reportByPaging = new DAL.LoanDataSet().GetLoanReportWhitCollateralDetailsByPaging(SCA, SCAA, F, txtFrom.Value.ToString(), 
                                                                            txtTo.Value.ToString()))
                    {
                        ugSWARTReport.DataSource = reportByPaging.ConfigDateTimeToPersian();
                        ugSWARTReport.DataBind();
                        dataTableCount = ((DataTable)ugSWARTReport.DataSource).Rows.Count;
                        reportByPaging.Dispose();
                    }
                }
                if (TN.ToUpper().Equals(Properties.Resources.KEY_NameOfLoanComOverdueAndCollactVLReport.ToUpper()))
                {
                    var queryForReport = Properties.Resources.StructureQueryForReport_CompareOverdueAndCollateralTarhini;
                    queryForReport = queryForReport.Replace(Properties.Resources.KEY_WHERE, F.IsNullOrEmptyByTrim() ? "" : F);
                    queryForReport = queryForReport.Replace(Properties.Resources.KEY_SelectedColumn,
                                                            SCAA);
                    queryForReport = queryForReport.Replace(Properties.Resources.KEY_START_INDEX, txtFrom.Value.ToString()).Replace(Properties.Resources.KEY_FINISH_INDEX, txtTo.Value.ToString());
                    using (var dataTable = new DAL.Report().GetReportByQuery(queryForReport))
                    {
                        dataTable.ConfigDateTimeToPersian();
                        ugSWARTReport.DataSource = dataTable;
                        ugSWARTReport.DataBind();
                        dataTableCount = ((DataTable)ugSWARTReport.DataSource).Rows.Count;
                        dataTable.Dispose();
                    }
                }
                if (dataTableCount == 0)
                    Presentation.Public.Routines.ShowMessageBoxFa("داده بیشتری وجود ندارد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProgressBox.Hide();
            }
            catch (Exception exception)
            {
                ProgressBox.Hide();
                exception.ConfigLog(true);
            }
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            var frmSaveExcel = new FrmSaveExcel(true, true, true, true) 
                                   {
                                       SourceData = ugSWARTReport
                                   };
            frmSaveExcel.ShowDialog();
            frmSaveExcel.Dispose();
        }

        private Infragistics.Win.UltraWinGrid.UltraGridPrintDocument UltraGridDocumentExporter;
        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            //throw new Exception("Code Barae Zakhire PDF neveshte Nashode Ast");
            //private Infragistics.Win.ExcelExport.ultra UltraGridExcelExporter ultraGridExcelExporter;
            //Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter


            //UltraGridDocumentExporter tableExporter = new UltraGridDocumentExporter();
            //tableExporter.Export(ugSWARTReport, "C://pdftest.pdf", GridExportFileFormat.PDF);

            // UltraGridDocumentExporter.Print();
            //ultraGridDocumentExporter.Export(ultraGridBrani, @"C:\ExportBrani.pdf", GridExportFileFormat.PDF);

            var frmSavePDF = new frmSavePdf(true, true)
            {
                SourceData = ugSWARTReport
            };
            frmSavePDF.ShowDialog();
            frmSavePDF.Dispose();
            //objRpt.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\report.pdf");
        }
        
        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var frmInputText=new Utilize.frmInputText() {Text = "عنوان گزارش"};
                ugSWARTReport.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
                ugSWARTReport.DisplayLayout.Override.AllowRowSummaries = AllowRowSummaries.False;
                if(frmInputText.ShowDialog()==DialogResult.OK)
                {
                    ultraGridPrintDocument.Header.TextCenter = frmInputText.ReturnValue;
                }
                //this.ugSWARTReport.PrintPreview();
                //this.ugSWARTReport.Print();
                ultraPrintPreviewDialog.ShowDialog();
                ugSWARTReport.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
                ugSWARTReport.DisplayLayout.Override.AllowRowSummaries = AllowRowSummaries.True;
                //ultraGridPrintDocument.Print();
            }
            catch (Exception ex)
            {
                Routines.ShowErrorMessageFa("خطا", "برنامه با خطا مواجه شده است.", MyDialogButton.OK);
            }
        }

        private void ugSWARTReport_BeforePrint(object sender, Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs e)
        {

            DialogResult result = (Presentation.Public.Routines.ShowMessageBoxFa("عملیات چاپ انجام شود؟", "تایید",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning));

            if (DialogResult.Cancel == result)
                e.Cancel = true;

        }

        private void ultraGridPrintDocument_PagePrinting(object sender, Infragistics.Win.Printing.PagePrintingEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.LogoPrint,
                                 e.PageSettings.PaperSize.Width - e.PageSettings.Margins.Right -
                                 Properties.Resources.LogoPrint.Size.Width, 10);
            
        }

        private void ugSWARTReport_AfterRowFilterChanged(object sender, AfterRowFilterChangedEventArgs e)
        {
            int i = 0;
            
            
            //var cfilter = ugSWARTReport.Rows.ColumnFilters;
        }

        private void ugSWARTReport_AfterRowFilterDropDownPopulate(object sender, AfterRowFilterDropDownPopulateEventArgs e)
        {
            int i = 0;
        }

        private void ugSWARTReport_FilterCellValueChanged(object sender, FilterCellValueChangedEventArgs e)
        {
            int i = 0;
        }

        private void ugSWARTReport_FilterRow(object sender, FilterRowEventArgs e)
        {
            int i = 0;
        }      

        private void cmbUnit_SelectionChanged(object sender, EventArgs e)
        {
            //NumberScale(cmbUnit.SelectedIndex);
            ugSWARTReport.ApplyScale(cmbUnit.SelectedIndex);
        }

        private void ugSWARTReport_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            foreach (var s in e.Layout.Bands[0].Columns)
            {
                s.PerformAutoResize();
                s.Width += 8;
            }

        }

        private void ugSWARTReport_AfterSummaryDialog(object sender, Infragistics.Win.UltraWinGrid.AfterSummaryDialogEventArgs e)
        {
            try
            {
                //UltraGridBand ugrow = new UltraGridBand("aaa", 0);
                //e.SummaryDialog.Controls[0].Controls[0].Controls[1].Controls["Variance"]
                foreach (var summarySetting in ugSWARTReport.DisplayLayout.Bands[0].Summaries.Cast<Infragistics.Win.UltraWinGrid.SummarySettings>())
                {
                    switch (summarySetting.SummaryType)
                    {
                        case SummaryType.Sum:
                            summarySetting.DisplayFormat = " جمع کل : {0}";
                            break;
                        case SummaryType.Average:
                            summarySetting.DisplayFormat = "میانگین : {0:#####.0000}";
                            break;
                        case SummaryType.Count:
                            summarySetting.DisplayFormat = "تعداد : {0}";
                            break;
                        case SummaryType.Maximum:
                            summarySetting.DisplayFormat = "بیشترین مقدار : {0}";
                            break;
                        case SummaryType.Minimum:
                            summarySetting.DisplayFormat = "کمترین مقدار : {0}";
                            break;
                    }
                }
            }
            catch
            {
            }
        }

        private void ugSWARTReport_BeforeSummaryDialog(object sender, BeforeSummaryDialogEventArgs e)
        {
            try
            {
                //Label lbl =  new Label();
                //lbl.Text = "hello";
                //lbl.Location = new Point(10,10);
                ////e.SummaryDialog.Controls.Add(lbl);
                //CheckBox chk = new CheckBox();
                //chk.Text = " :واریانس ";
                //chk.Name = "Variance";

                //e.SummaryDialog.Controls[0].Controls[0].Controls[1].Controls[0].Controls.Add(chk);
                //e.SummaryDialog.Controls[0].Controls[0].Controls[1].Controls.Add(chk);
                //e.SummaryDialog.Controls[0].Controls[0].Controls[1].Controls["Variance"].BringToFront();
                //e.SummaryDialog.Controls[0].Controls[0].Controls[1].Controls["Variance"].Location = new Point(100,50);
                e.SummaryDialog.Font = new Font("B Nazanin", 12);
                e.SummaryDialog.Text = @"توابع عملیاتی";
                e.SummaryDialog.ImageCount = Properties.Resources.Count;
                e.SummaryDialog.ImageSum = Properties.Resources.Sum;
                e.SummaryDialog.ImageMinimum = Properties.Resources.Min2;
                e.SummaryDialog.ImageMaximum = Properties.Resources.Max2;
                e.SummaryDialog.ImageAverage = Properties.Resources.AVG;
                
                foreach (Control control in e.SummaryDialog.Controls[0].Controls[0].Controls[1].Controls)
                {
                    switch (control.Text.ToUpper())
                    {
                        case "COUNT":
                            control.Text = @"تعداد";
                            break;
                        case "SUM":
                            control.Text = @"جمع کل";
                            break;
                        case "MINIMUM":
                            control.Text = @"کمترین مقدار";
                            break;
                        case "MAXIMUM":
                            control.Text = @"بیشترین مقدار";
                            break;
                        case "AVERAGE":
                            control.Text = @"میانگین";
                            break;
                        case "FORMULA":
                            control.Text = @"فرمول";
                            break;
                    }
                }
                e.SummaryDialog.Controls[0].Controls[0].Controls[2].Text = @"انصراف";
                e.SummaryDialog.Controls[0].Controls[0].Controls[3].Text = @"تأیید";
            }
            catch
            {
            }
        }
    }
}
    
    

      