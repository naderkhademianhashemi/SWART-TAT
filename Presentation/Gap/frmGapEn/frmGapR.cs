using System;
using System.Globalization;
using System.IO;
using ERMS.Logic;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using ERMSLib;
using ERMS.Model;
using DChart = Dundas.Charting.WinControl;
using ClosedXML.Excel;
using Presentation.DAL;
using DevComponents.DotNetBar.Controls;
using Presentation.Util;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmGAP : Form
    {

        public frmGAP()
        {
            InitializeComponent();

        }

        private void RefreshChart(DChart.Chart CH, DataTable DT)
        {
            CH.Series.Clear();
            CH.Series.Add("Series1");
            CH.Series["Series1"].ValueMemberX = "Row";
            CH.Series["Series1"].ValueMembersY = "Row";
            CH.Series["Series1"].XValueType = DChart.ChartValueTypes.Int;
            CH.Series["Series1"].YValuesPerPoint = 1;
            CH.Series["Series1"].LegendText = "دارایی";
            CH.DataSource = DT;
            CH.DataBind();
        }
        private void RefreshStylChart(DChart.Chart CH, DataTable DT)
        {
            CH.Series.Clear();
            CH.Series.Add("Series1");
            CH.Series["Series1"].ValueMemberX = "Row";
            CH.Series["Series1"].ValueMembersY = "Row";
            CH.Series["Series1"].XValueType = DChart.ChartValueTypes.Int;
            CH.Series["Series1"].YValuesPerPoint = 1;
            CH.DataSource = DT;
            CH.DataBind();
            CH.Series["Series1"].XValueIndexed = true;
            CH.Series["Series1"]["DrawingStyle"] = "Cylinder";
            CH.ChartAreas["Default"].Area3DStyle.Enable3D = true;
            CH.ChartAreas["Default"].Area3DStyle.Light = DChart.LightStyle.Realistic;
            CH.ChartAreas["Default"].Area3DStyle.Perspective = 30;
            CH.ChartAreas["Default"].Area3DStyle.XAngle = 10;
            CH.ChartAreas["Default"].Area3DStyle.YAngle = 5;
            CH.ChartAreas["Default"].Area3DStyle.PointDepth = 200;
            CH.ChartAreas["Default"].Area3DStyle.PointGapDepth = 0;
            CH.ChartAreas["Default"].Area3DStyle.RightAngleAxes = true;
            CH.ChartAreas["Default"].BackColor = Color.White;
            CH.BorderSkin.SkinStyle = DChart.BorderSkinStyle.Emboss;
            CH.BackColor = Color.FromArgb(146, 180, 222);
            CH.BackGradientEndColor = Color.White;
            CH.BackGradientType = DChart.GradientType.TopBottom;
            CH.BorderStyle = DChart.ChartDashStyle.Solid;
            CH.BorderColor = Color.DarkBlue;
            CH.BorderWidth = 2;
            CH.ChartAreas["Default"].ShadowOffset = 5;
            CH.ChartAreas["Default"].ShadowColor = Color.Gray;
            CH.ChartAreas["Default"].AxisX.LabelStyle.ShowEndLabels = true;
            CH.ChartAreas["Default"].AxisX.LabelStyle.Font = this.Font;
            CH.ChartAreas["Default"].AxisY.LabelStyle.ShowEndLabels = true;
            CH.ChartAreas["Default"].AxisY.LabelStyle.Font = this.Font;
            CH.ChartAreas["Default"].AxisX.MinorGrid.Enabled = false;
            CH.ChartAreas["Default"].AxisY.MinorGrid.Enabled = true;
            CH.ChartAreas["Default"].AxisY.MinorGrid.LineColor = Color.LightGray;
            CH.ChartAreas["Default"].AxisX.MajorGrid.Enabled = false;
            CH.ChartAreas["Default"].AxisY.MajorGrid.Enabled = true;
            CH.ChartAreas["Default"].AxisY.MajorGrid.LineColor = Color.Wheat;
            CH.ChartAreas["Default"].AxisX.LabelStyle.Format = "###,###";
            CH.ChartAreas["Default"].AxisY.LabelStyle.Format = "###,###";
            CH.Series["Series1"].SmartLabels.Enabled = true;
            CH.Series["Series1"].Font = this.Font;
            CH.Series["Series1"].LabelFormat = "###,###";
            CH.Series["Series1"].ShowLabelAsValue = false;
            CH.Palette = DChart.ChartColorPalette.Dundas;
        }
        private void RefreshStyleChart(DChart.Chart CH, DataTable DT)
        {
            CH.Series.Clear();
            CH.Series.Add("Series1");
            CH.Series.Add("Series2");

            CH.Series["Series1"].Type = DChart.SeriesChartType.StackedColumn;
            CH.Series["Series2"].Type = DChart.SeriesChartType.StackedColumn;

            CH.Series["Series1"].ValueMemberX = "Row";
            CH.Series["Series1"].ValueMembersY = "Row";
            CH.Series["Series1"].XValueType = DChart.ChartValueTypes.Int;
            CH.Series["Series1"].YValuesPerPoint = 1;
            CH.Series["Series1"].ShowInLegend = true;
            CH.Series["Series1"].LegendText = "دارایی";

            CH.Series["Series2"].ValueMemberX = "Row";
            CH.Series["Series2"].ValueMembersY = "Row";
            CH.Series["Series2"].XValueType = DChart.ChartValueTypes.Int;
            CH.Series["Series2"].YValuesPerPoint = 1;
            CH.Series["Series2"].ShowInLegend = true;
            CH.Series["Series2"].LegendText = "شكاف";

            CH.DataSource = DT;
            CH.DataBind();

            CH.Series["Series1"].XValueIndexed = true;
            CH.Series["Series2"].XValueIndexed = true;

            CH.Series["Series1"]["DrawingStyle"] = "Cylinder";
            CH.Series["Series2"]["DrawingStyle"] = "Cylinder";

            CH.ChartAreas["Default"].Area3DStyle.Enable3D = true;
            CH.ChartAreas["Default"].Area3DStyle.Light = DChart.LightStyle.Realistic;
            CH.ChartAreas["Default"].Area3DStyle.Perspective = 30;
            CH.ChartAreas["Default"].Area3DStyle.XAngle = 10;
            CH.ChartAreas["Default"].Area3DStyle.YAngle = 5;
            CH.ChartAreas["Default"].Area3DStyle.PointDepth = 200;
            CH.ChartAreas["Default"].Area3DStyle.PointGapDepth = 0;
            CH.ChartAreas["Default"].Area3DStyle.RightAngleAxes = true;

            CH.ChartAreas["Default"].BackColor = Color.White;

            CH.BorderSkin.SkinStyle = DChart.BorderSkinStyle.Emboss;
            CH.BackColor = Color.FromArgb(146, 180, 222);
            CH.BackGradientEndColor = Color.White;
            CH.BackGradientType = DChart.GradientType.TopBottom;
            CH.BorderStyle = DChart.ChartDashStyle.Solid;
            CH.BorderColor = Color.DarkBlue;
            CH.BorderWidth = 2;

            CH.ChartAreas["Default"].ShadowOffset = 5;
            CH.ChartAreas["Default"].ShadowColor = Color.Gray;
            CH.ChartAreas["Default"].AxisX.LabelStyle.ShowEndLabels = true;
            CH.ChartAreas["Default"].AxisX.LabelStyle.Font = this.Font;
            CH.ChartAreas["Default"].AxisY.LabelStyle.ShowEndLabels = true;
            CH.ChartAreas["Default"].AxisY.LabelStyle.Font = this.Font;
            CH.ChartAreas["Default"].AxisX.MinorGrid.Enabled = false;
            CH.ChartAreas["Default"].AxisY.MinorGrid.Enabled = true;
            CH.ChartAreas["Default"].AxisY.MinorGrid.LineColor = Color.LightGray;
            CH.ChartAreas["Default"].AxisX.MajorGrid.Enabled = false;
            CH.ChartAreas["Default"].AxisY.MajorGrid.Enabled = true;
            CH.ChartAreas["Default"].AxisY.MajorGrid.LineColor = Color.Wheat;

            CH.ChartAreas["Default"].AxisX.LabelStyle.Format = "###,###";
            CH.ChartAreas["Default"].AxisY.LabelStyle.Format = "###,###";

            CH.Series["Series1"].SmartLabels.Enabled = true;
            CH.Series["Series1"].Font = this.Font;
            CH.Series["Series1"].LabelFormat = "###,###";
            CH.Series["Series1"].ShowLabelAsValue = false;
            CH.Series["Series2"].SmartLabels.Enabled = true;
            CH.Series["Series2"].Font = this.Font;
            CH.Series["Series2"].LabelFormat = "###,###";
            CH.Series["Series2"].ShowLabelAsValue = false;

            CH.Palette = DChart.ChartColorPalette.Dundas;
        }
        private void FillModel()
        {
            var DT = new GapDS().GetDT();
            foreach (DataRow dr in DT.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "11";
                lvi.Tag = "11";

                lsvModel.Items.Add(lvi);
            }

        }

        private void CommandModelRemove()
        {
            var RES = MessageBox.Show(RSRC.MSG.Sure, RSRC.MSG.Confirm, MessageBoxButtons.YesNo);
            if (RES != DialogResult.Yes || lsvModel.SelectedItems.Count < 1)
                return;
            ListViewItem lvi = lsvModel.SelectedItems[0];
            lvi.Remove();
        }
        private void CommandModelNew()
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "desc";
            lvi.Tag = "desc";
            lsvModel.Items.Add(lvi);
            lvi.Selected = true;
        }
        void Init()
        {
            var ArrVal = new string[] { "مبلغ قسط", "مبلغ اصل", "هر دو", "تراز" };
            cmbValType.Items.AddRange(ArrVal);

            var ArrCur = new string[] { "ريالی", "ارزی", "هر دو" };
            cmbCurrency.Items.AddRange(ArrCur);

            cmbCurrency.SelectedIndex = cmbCurrency.Items.Count >= 3 ? 2 : -1;
            cmbValType.SelectedIndex = cmbValType.Items.Count >= 4 ? 3 : -1;


            lsvModel.View = View.Details;
            var ch = new ColumnHeader { Width = lsvModel.Width - 5 };
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;

            var ArrUnit = new string[] { "واحد", "هزار", "ميليون" };
            cmbUnit.Items.AddRange(ArrUnit);
            cmbUnit.SelectedIndex = 0;

            FillModel();
        }
        private void frmGAP_Load(object sender, EventArgs e)
        {
            Init();
            fdpStartDate.SelectedDateTime = DateTime.Now;
        }


        private void btnFSM_Click(object sender, EventArgs e) { }



        private void btnTBM_Click(object sender, EventArgs e) { }




        private void tsbModelNew_Click(object sender, EventArgs e)
        {
            CommandModelNew();
        }

        private void tsbModelEdit_Click(object sender, EventArgs e) { }

        private void tsbModelRemove_Click(object sender, EventArgs e)
        {
            CommandModelRemove();
        }

        private void tsbModelSave_Click(object sender, EventArgs e) { }

        private void tsmiDetail_Click(object sender, EventArgs e) { }

        private void tsmiClear_Click(object sender, EventArgs e) { }

        private void tsmiReset_Click(object sender, EventArgs e) { }

        private void lsvModel_DoubleClick(object sender, EventArgs e) { }

        private void frmGAP_FormClosing(object sender, FormClosingEventArgs e) { }

        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e) { }



        private void chkIrr_CheckedChanged(object sender, EventArgs e) { }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e) { }



        private void dgvGAP_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) { }

        private void dgvGAP_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) { }

        private void dgvGAP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) { }

        private void chkAutoSize_CheckedChanged(object sender, EventArgs e) { }

        private void Btn_GAP_FullScr_Click(object sender, EventArgs e) { }



        private void frmGAP_KeyDown(object sender, KeyEventArgs e) { }

        private void tsbRefresh_Click(object sender, EventArgs e) { }

        private void tsmiPrint_Click(object sender, EventArgs e) { }

        private void tsmiExport_Click(object sender, EventArgs e) { }



        private void chkShowHideValue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowHideValue.Checked)
            {
                ddChart.Series["Series1"].ShowLabelAsValue = true;
                ddChart.Series["Series2"].ShowLabelAsValue = true;
            }
            else
            {
                ddChart.Series["Series1"].ShowLabelAsValue = false;
                ddChart.Series["Series2"].ShowLabelAsValue = false;
            }
        }

        private void chkLegend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLegend.Checked)
            {
                ddChart.Series["Series1"].ShowInLegend = true;
                ddChart.Series["Series2"].ShowInLegend = true;
            }
            else
            {
                ddChart.Series["Series1"].ShowInLegend = false;
                ddChart.Series["Series2"].ShowInLegend = false;
            }
        }

        private void cmbLimit_SelectedIndexChanged(object sender, EventArgs e) { }




        private void chkDescreteGapAnalisys_CheckedChanged(object sender, EventArgs e) { }


        // Save in Final Report of Gap
        private void tsbfinalSave_Click(object sender, EventArgs e) { }

        private void btnList_Click(object sender, EventArgs e) { }

        private void cmbLimitValue_SelectedIndexChanged(object sender, EventArgs e) { }

        private void chkAll_CheckStateChanged(object sender, EventArgs e) { }

        private void grpParam_Click(object sender, EventArgs e) { }

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModel_CButtonClicked(object sender, EventArgs e)
        { }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }

        private void ucfOrganization_DropDownOpening(object sender, EventArgs e) { }

        private void cButton1_CButtonClicked(object sender, EventArgs e)
        {
        }

        private void dgvGAP_Paint(object sender, PaintEventArgs e) { }


        private void ctxGap_Opening(object sender, System.ComponentModel.CancelEventArgs e) { }



        private void panel2_Click(object sender, EventArgs e) { }

        private void rdbHistoric_CheckedChanged(object sender, EventArgs e) { }

        private void cmbCurrency_SelectionChanged(object sender, EventArgs e) { }
        private void cbExcel_Click(object sender, EventArgs e)
        {
            new Export().Dgv2Xcl(dgvGAP);
        }

        private void cmbFSM_ValueChanged(object sender, EventArgs e) { }

        private void cbExcel_CButtonClicked(object sender, EventArgs e) { }

        private void splitContainer1_Panel1_DoubleClick(object sender, EventArgs e) { }



        private void btnGAPFullScr_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            var DT = new GapDS().GetDT();
            dgvGAP.DataSource = DT;
            RefreshStyleChart(ddChart, DT);
        }

        private void chkColor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fdpStartDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {

        }
    }
    class TableTemplate
    {
        public int DataSetIndex;
        public int SheetIndex;
        public int FirstRow;
        public int FirstCol;
        public string Name;
        public bool isEnable;

    }
    class RowTemplate
    {
        public int Row;
        public string GroupName;
        public bool isCurrency;
        public bool onlyThreeStatus;
        public bool kahande;

    }

}