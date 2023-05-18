using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Chart.chart_win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FllWinChart(chart1);
        }
        private void FllWinChart(System.Windows.Forms.DataVisualization.Charting.Chart CH)
        {
            var DT = new DataTable();
            DT.Columns.AddRange(new DataColumn[] {
        new DataColumn("TagName"), new DataColumn("On",typeof(int)) });
            DT.Rows.Add("P1", 0);
            DT.Rows.Add("P1", 2);
            DT.Rows.Add("P1", 6);

            CH.DataSource = DT;
            CH.Series.Clear();
            for (int i = 0; i < DT.Columns.Count; i++)
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series();
                series.XValueMember = DT.Columns[0].ColumnName;
                series.YValueMembers = DT.Columns[i].ColumnName;
                series.LegendText = DT.Columns[i].ColumnName;
                CH.Series.Add(series);
            }
        }
    }
}
