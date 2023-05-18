using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Utilize.Grid
{
    public sealed partial class MyGrid_V2 : UserControl
    {
        public MyGrid_V2()
        {
            InitializeComponent();
        }
        public MyGrid_V2(DataTable dataSet)
        {
            InitializeComponent();
            ugd.DataSource = dataSet;
            foreach (var column in
                ugd.DisplayLayout.Bands[0].Columns.Cast<Infragistics.Win.UltraWinGrid.UltraGridColumn>().Where(column => Equals(column.DataType, typeof(decimal))))
            {
                column.Format = "#,###.##";
            }
            ugd.DataBind();
            Dock = DockStyle.Fill;
        }
        
        private bool _ShowMenu = true;
        public bool ShowMenu
        {
            get { return _ShowMenu; }
            set
            {
                _ShowMenu = value;
                ugd.ContextMenuStrip = _ShowMenu ? cntMain : null;
            }
        }

        public event EventHandler eventShowChart;
        public event EventHandler eventSaveReportExcelClick;
        public object DataSource
        {
            get
            {
                return ugd.DataSource;
            }
            set
            {
                ugd.DataSource = value;
                foreach (var column in
                ugd.DisplayLayout.Bands[0].Columns.Cast<Infragistics.Win.UltraWinGrid.UltraGridColumn>().Where(column => Equals(column.DataType, typeof(decimal))))
                {
                    column.Format = "#,###.##";
                }
                ugd.DataBind();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (eventSaveReportExcelClick != null)
            {
                eventSaveReportExcelClick.Invoke(ugd, e);
            }
        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            if (eventShowChart != null)
            {
                eventShowChart.Invoke(ugd.DataSource, e);
            }

        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            //btnSave.Image = Properties.Resources.BSSaveExcel;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            //btnSave.Image = Properties.Resources.BUSaveExcel;
        }

        private void ugd_Click(object sender, EventArgs e)
        {

        }

        private void ugd_AfterSummaryDialog(object sender, Infragistics.Win.UltraWinGrid.AfterSummaryDialogEventArgs e)
        {
            try
            {
                foreach (var summarySetting in ugd.DisplayLayout.Bands[0].Summaries.Cast<Infragistics.Win.UltraWinGrid.SummarySettings>())
                {
                    switch (summarySetting.SummaryType)
                    {
                        case SummaryType.Sum:
                            summarySetting.DisplayFormat = " جمع کل : {0}";
                            break;
                        case SummaryType.Average:
                            summarySetting.DisplayFormat = "میانگین : {0}";
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

        private void ugd_BeforeSummaryDialog(object sender, BeforeSummaryDialogEventArgs e)
        {
            try
            {
                e.SummaryDialog.Font = new Font("B Nazanin", 12);
                e.SummaryDialog.Text = @"توابع عملیاتی";
                e.SummaryDialog.ImageCount = Properties.Resources.Count;
                e.SummaryDialog.ImageSum = Properties.Resources.Sum;
                e.SummaryDialog.ImageMinimum = Properties.Resources.Min;
                e.SummaryDialog.ImageMaximum = Properties.Resources.Max;
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
