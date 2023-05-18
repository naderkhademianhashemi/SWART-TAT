using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dundas.Charting.WinControl;
using Microsoft.Reporting.WinForms;
using Presentation.DAL;
using Utilize;

namespace Presentation
{
    public partial class frmReportChart : Form
    {
        public frmReportChart()
        {
            InitializeComponent();
        }

        private void ReportChart_Load(object sender, EventArgs e)
        {

        }

        private void cmbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbY.Items.Clear();
            cmbX.Items.Clear();
            var report = "";
            var columns = "";
            var orgColumns = "";
            for (var i = 0; i < columns.Length; i++)
            {
                var col = "";
                cmbY.Items.Add("");
                cmbX.Items.Add("");
            }
        }
        private void btnShowChart_Click(object sender, EventArgs e)
        {
            FllChart(CH);
        }

         void FllFAChart(Dundas.Charting.WinControl.Chart CH)
        {
            CH.Series.Clear();
            var ARR = new string[2] { "ستون 1", "ستون 2" };
            var DT = new ReportDS().GetDT(ARR);
            for (var i = 0; i < ARR.Length; i++)
            {
                var SR = new Series(ARR[i]);
                SR.ValueMembersY = ARR[i];
                SR.ValueMemberX = ARR[i];
                CH.Series.Add(SR);
            }
            CH.DataSource = DT;
            CH.Series[0].LegendText = "نمودار 1";
            CH.Series[1].LegendText = "نمودار 2";
            CH.ChartAreas[0].AxisY.Interval = 1;
            CH.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount;
            CH.ChartAreas[0].AxisY.Title = "محور عمودی";
            CH.ChartAreas[0].AxisX.Title = "محور افقی";
            CH.ChartAreas[0].AxisX.TitleFont = new Font("Tahoma", 20);
            CH.ChartAreas[0].AxisX.LabelStyle.FontAngle = 45;
            CH.ChartAreas[0].AxisX.LabelsAutoFit = true;
            CH.DataBind();
        }

         void FllChart(Dundas.Charting.WinControl.Chart CH)
        {
            CH.Series.Clear();
            var ARR = new string[2] { "Col1", "Col2" };
            var DT = new ReportDS().GetDT(ARR);
            for (var i = 0; i < ARR.Length; i++)
            {
                var SR = new Dundas.Charting.WinControl.Series(ARR[i]);
                SR.ValueMembersY = ARR[i];
                SR.ValueMemberX = ARR[i];
                CH.Series.Add(SR);
            }
            CH.DataSource = DT;
            CH.DataBind();
        }
    }
}
