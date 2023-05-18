using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dundas.Charting.WinControl;
using Presentation.DAL;
//

namespace Presentation.CHART
{
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
        }
        #region methods
        void FllChart(Dundas.Charting.WinControl.Chart CH)
        {
            CH.Series.Clear();
            var ARR = new string[2] { "Col1", "Col2" };
            var DT = new ReportDS().GetDT(ARR);
            for (var i = 0; i < ARR.Length; i++)
            {
                var SR = new Series(ARR[i]);
                SR.ValueMembersY = ARR[i];
                SR.ValueMemberX = ARR[i];
                CH.Series.Add(SR);
            }
            CH.DataSource = DT;
            CH.DataBind();
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
        #endregion

        private void frmChart_Load(object sender, EventArgs e)
        { }

        private void dgvChart_CellClick(object sender, DataGridViewCellEventArgs e)
        { }




        private void chbSerries_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void btnFullScreenChart_Click(object sender, EventArgs e)
        { }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ccmbReport_ValueChanged(object sender, EventArgs e)
        { }



        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void btnShowChart_Click_2(object sender, EventArgs e)
        {
            FllChart(chart);
        }
        
        private void btnConfChart_Click(object sender, EventArgs e)
        {

        }

        private void cbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
