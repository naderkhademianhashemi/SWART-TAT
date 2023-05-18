using System;
using System.IO;
using System.Data;
using System.Text;
using System.Drawing;
using System.Reflection;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

using ERMSLib;

//

using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinTree;

using Dundas.Charting.WinControl;
using Dundas.Charting.WinControl.ChartTypes;
using Dundas.Charting.WinControl.Design;
//using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using ERMS.Logic;
using Presentation.Public;

namespace Presentation.Tabs.RPTAssetsDebts
{

    public partial class frmGapTrendingReport : BaseForm
    {
        #region vars

        private TBM tbm;
        private GAP gap;
        private DataTable dtSelectedGap;

        private string[] arSelectedGap = new string[50];
        private string[] StrSelectedGap = new string[50];

        #endregion
        public frmGapTrendingReport()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
        }
        private void Init()
        {
            tbm = new TBM();
            gap = new GAP();
            RebindTBM();
        }

        private void RebindTBM()
        {
            cmbTBM.DisplayMember = TBM.CTE_Alias_ModelName;
            cmbTBM.ValueMember = TBM.CTE_Alias_ID;
            cmbTBM.SelectedIndex = -1;
            cmbTBM.DataSource = tbm.GetTBMs();
         
        }
        private void RebindListGap()
        {
            dtSelectedGap = gap.GetGAPReport();
            dtSelectedGap.DefaultView.RowFilter = "TBModelID = " + cmbTBM.SelectedValue.ToString();
            chkLstGap.DataSource = dtSelectedGap;
         
            chkLstGap.DisplayMember = "ModelName";
            //chkLstGap.SelectedIndex = 0;

        }
        private void RefreshChart(int TypeOfReport)
        {
            string SeriesStr = "";
            string StrGapSelected = "";
            ddChart.Series.Clear();

            for (int nSeri = 1; nSeri <= chkLstGap.CheckedItems.Count; nSeri++)
            {
                SeriesStr = SeriesStr + nSeri.ToString();
                ddChart.Series.Add(SeriesStr);
                ddChart.Series[SeriesStr].Type = SeriesChartType.Column;
                ddChart.Series[SeriesStr].XValueType = ChartValueTypes.Int;
                ddChart.Series[SeriesStr].YValuesPerPoint = 1;
                ddChart.Series[SeriesStr].ShowInLegend = true;
                ddChart.Series[SeriesStr].ValueMembersY = "Y" + nSeri.ToString();
                ddChart.Series[SeriesStr].ValueMemberX = "X";
                ddChart.Series[SeriesStr].XValueIndexed = true;
                ddChart.Series[SeriesStr]["DrawingStyle"] = "Cylinder";
                ddChart.Series[SeriesStr].SmartLabels.Enabled = true;
                ddChart.Series[SeriesStr].Font = this.Font;
                ddChart.Series[SeriesStr].LabelFormat = "###,###";
                ddChart.Series[SeriesStr].ShowLabelAsValue = false;
            }
            int k = 1;
            string str = "";
            for (int i = 0; i < StrSelectedGap.Length; ++i)
            {
                if (StrSelectedGap[i] != null)
                {
                    str = str + k.ToString();
                    ddChart.Series[str].LegendText = StrSelectedGap[i].ToString();
                    k = k + 1;
                }
            }
            ddChart.ChartAreas["Default"].Area3DStyle.Enable3D = true;
            ddChart.ChartAreas["Default"].Area3DStyle.Enable3D = false;
            ddChart.ChartAreas["Default"].Area3DStyle.Light = LightStyle.Realistic;
            ddChart.ChartAreas["Default"].Area3DStyle.Perspective = 30;
            ddChart.ChartAreas["Default"].Area3DStyle.XAngle = 10;
            ddChart.ChartAreas["Default"].Area3DStyle.YAngle = 5;
            ddChart.ChartAreas["Default"].Area3DStyle.PointDepth = 200;
            ddChart.ChartAreas["Default"].Area3DStyle.PointGapDepth = 0;
            ddChart.ChartAreas["Default"].Area3DStyle.RightAngleAxes = true;
            ddChart.ChartAreas["Default"].ShadowOffset = 5;
            ddChart.ChartAreas["Default"].ShadowColor = Color.Gray;
            ddChart.ChartAreas["Default"].AxisX.LabelStyle.ShowEndLabels = true;
            ddChart.ChartAreas["Default"].AxisX.LabelStyle.Font = this.Font;
            ddChart.ChartAreas["Default"].AxisY.LabelStyle.ShowEndLabels = true;
            ddChart.ChartAreas["Default"].AxisY.LabelStyle.Font = this.Font;
            ddChart.ChartAreas["Default"].AxisX.MinorGrid.Enabled = false;
            ddChart.ChartAreas["Default"].AxisY.MinorGrid.Enabled = true;
            ddChart.ChartAreas["Default"].AxisY.MinorGrid.LineColor = Color.LightGray;
            ddChart.ChartAreas["Default"].AxisX.MajorGrid.Enabled = false;
            ddChart.ChartAreas["Default"].AxisY.MajorGrid.Enabled = true;
            ddChart.ChartAreas["Default"].AxisY.MajorGrid.LineColor = Color.Wheat;
            ddChart.ChartAreas["Default"].AxisX.LabelStyle.Format = "###,###";
            ddChart.ChartAreas["Default"].AxisY.LabelStyle.Format = "###,###";
            ddChart.ChartAreas["Default"].BackColor = Color.White;

            ddChart.Palette = ChartColorPalette.Dundas;
            ddChart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            ddChart.BackColor = Color.FromArgb(146, 180, 222);
            ddChart.BackGradientEndColor = Color.White;
            ddChart.BackGradientType = GradientType.TopBottom;
            ddChart.BorderStyle = ChartDashStyle.Solid;
            ddChart.BorderColor = Color.DarkBlue;
            ddChart.BorderWidth = 2;



            for (int i = 0; i < arSelectedGap.Length; ++i)
            {
                if (arSelectedGap[i] != null)
                {
                    StrGapSelected = StrGapSelected + "'" + arSelectedGap[i].ToString() + "'" + ",";
                }
            }
            StrGapSelected = StrGapSelected.Substring(0, StrGapSelected.Length - 1);

            DataTable dt = gap.GetGAPReportSummary(StrGapSelected, chkLstGap.CheckedItems.Count, TypeOfReport, false);
            ddChart.DataSource = dt;
            ddChart.DataBind();
        }

        private void frmGapTrendingReport_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void cmbTBM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTBM.SelectedIndex != -1)
            {
                RebindListGap();
            }
        }
        private void chkLstGap_SelectedValueChanged(object sender, EventArgs e)
        {
            if (chkLstGap.SelectedIndex != -1)
            {
                if (chkLstGap.GetItemChecked(chkLstGap.SelectedIndex))
                {
                    arSelectedGap[chkLstGap.SelectedIndex] = ((DataRowView)chkLstGap.SelectedItem)[0].ToString();
                    StrSelectedGap[chkLstGap.SelectedIndex] = ((DataRowView)chkLstGap.SelectedItem)[2].ToString();
                }
                else
                {
                    arSelectedGap[chkLstGap.SelectedIndex] = null;
                    StrSelectedGap[chkLstGap.SelectedIndex] = null;
                }
            }
        }
        private void btnReportDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                ddChart.Series.Clear();

                if (rdoAsset.Checked == false && rdoDebit.Checked == false && rdoGap.Checked == false)
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("هيچ نوع گزارشي انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (cmbTBM.SelectedIndex == -1)
                    {
                        Presentation.Public.Routines.ShowMessageBoxFa("هيچ مدل بسته زماني انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (chkLstGap.SelectedItems.Count == 0 || chkLstGap.CheckedItems.Count == 0)
                        {
                            Presentation.Public.Routines.ShowMessageBoxFa("هيچ گزارشي انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (rdoGap.Checked)
                            {
                                RefreshChart(1);
                            }
                            if (rdoAsset.Checked)
                            {
                                RefreshChart(2);
                            }
                            if (rdoDebit.Checked)
                            {
                                RefreshChart(3);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("برنامه با خطا روبرو شده است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReportDisplay_Load(object sender, EventArgs e)
        {

        }

        private void cbCollapseRight_CButtonClicked(object sender, EventArgs e)
        {
            if (splitContainer2.Panel1Collapsed == false)
            {
                splitContainer2.Panel1Collapsed = true;
                cbCollapseRight.DefaultImage = Properties.Resources.S_Panleft1;
                cbCollapseRight.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (splitContainer2.Panel1Collapsed == true)
            {
                splitContainer2.Panel1Collapsed = false;
                cbCollapseRight.DefaultImage = Properties.Resources.S_PanRight1;
                cbCollapseRight.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }
    }
}