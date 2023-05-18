using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dundas.Charting.WinControl;

namespace Presentation.Public
{
    public partial class frmChart : Form
    {
        public object DataSource;
        public IEnumerable<string> columns;
        public string colYName;
        public frmChart()
        {
            InitializeComponent();
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            chart.ChartAreas[0].AxisX.LabelsAutoFit = true;
            chart.ChartAreas[0].AxisX.LabelStyle.FontAngle = 45;
            chart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Series[0].ValueMembersY = cmbItem.Text;
            chart.Series[0].ValueMemberX = colYName;
            chart.Series[0].ToolTip = "#VAL      #AXISLABEL";
            chart.DataBind();
        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            foreach (var item in columns)
            {
                cmbItem.Items.Add(item);
            }
            chart.DataSource = DataSource;
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
