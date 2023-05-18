using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilize.Helper;
using Utilize;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic.ApplicationServices;
using Presentation.DAL;
using Dundas.Charting.WinControl;

namespace Presentation.Loan
{
    public partial class frmHistoricalLoanReport : Form
    {

        public frmHistoricalLoanReport()
        {
            InitializeComponent();
        }


        private void txtCounterparty_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            if (e.Button.Key == "Search")
            {

            }

        }


        private void txtContract_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            if (e.Button.Key == "Search")
            { }

        }


        void ucfState_CheckedChanged(object sender, EventArgs e)
        {
            var organizations = new DataTable();

            ucfOrganization.DisplayMember = "Branch_Description";
            ucfOrganization.ValueMember = "Branch";
            ucfOrganization.DataSource = organizations;
        }


        void ucfOrganization_DropDownOpening(object sender, EventArgs e)
        {
            var organizations = new DataTable();

            ucfOrganization.DisplayMember = "Branch_Description";
            ucfOrganization.ValueMember = "Branch";
            ucfOrganization.DataSource = organizations;
        }


        private void btnShowReport_Click(object sender, EventArgs e)
        {
            FllWinChart(chart1);
        }
        void FllChart(System.Windows.Forms.DataVisualization.Charting.Chart CH)
        {
            CH.Series.Clear();
            var ARR = new string[2] { "Col1", "Col2" };
            var DT = new ReportDS().GetDT(ARR);
            var series = new Collection<Dundas.Charting.WinControl.Series>();
            for (var i = 0; i < ARR.Length; i++)
            {
                var SR = new Dundas.Charting.WinControl.Series(ARR[i]);
                SR.ValueMembersY = ARR[i];
                SR.ValueMemberX = ARR[i];
                //SR.ToolTip = "#VAL      #AXISLABEL";
                //SR.Type= Dundas.Charting.WinControl.SeriesChartType.Line;
                series.Add(SR);
            }
            CH.Series.Add(series.ToString());
            CH.DataSource = DT;
            CH.DataBind();
        }

        private void rbStateBranch_CheckedChanged(object sender, EventArgs e)
        { }
        private void btnFullScreenChart_Click(object sender, EventArgs e)
        { }


        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbSerries_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void btnShowReport_Load(object sender, EventArgs e)
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
