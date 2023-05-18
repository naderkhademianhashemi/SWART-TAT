using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dundas.Charting.WinControl;

namespace Utilize.Report
{
    public partial class UCChart : UserControl
    {


        /// <summary>
        ///نام محور افقی در DataSourse
        /// </summary>
        [Description("نام محور افقی در DataSourse")]
        [DefaultValue("X")]
        string _x;
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }
        /// <summary>
        ///نوع نمودار
        /// </summary>
        [Description("نوع نمودار")]
        [DefaultValue(SeriesChartType.Spline)]
        SeriesChartType _chartType;
        public SeriesChartType ChartType
        {
            get { return _chartType; }
            set { _chartType = value; }
        }


        /// <summary>
        /// شامل یک ستون برای محور افقی و ستون های دلخواه برای محور عمودی
        /// </summary>
        private DataTable _dataSource;
        public DataTable DataSource
        {
            get { return _dataSource; }
            set
            {
                _dataSource = value;
                int id = 0;
                //if (_dataSource != null)
                //{
                //    foreach (DataRow dr in _dataSource.Rows)
                //    {
                //        dr[X] = id++.ToString().Trim();
                //    }
                //}
                chbColumnsOfShow.Items.Clear();
                if (_dataSource != null)
                {
                    int i = 0;
                    foreach (var col in _dataSource.Columns.Cast<DataColumn>())
                    {
                        if (col.ColumnName.Equals(X)) continue;
                        chbColumnsOfShow.Items.Add(new ColumnOfList<string, string>(col.ColumnName, i.ToString()));
                        i++;
                    }
                }
                splc1.SplitterDistance= chbColumnsOfShow.GetPreferredSize(new System.Drawing.Size()).Width;
                RefreshChart();
            }
        }

        private void RefreshChart()
        {
            try
            {
                if (_dataSource != null)
                {
                    ddChart.Series.Clear();
                    foreach (var item in chbColumnsOfShow.CheckedItems)
                    {
                        string name = ((ColumnOfList<string, string>)item).GetDisplay();
                        ddChart.Series.Add(name);
                        ddChart.Series[name].Type = ChartType;

                        ddChart.Series[name].ValueMemberX = X;
                        ddChart.Series[name].ValueMembersY = name;
                        ddChart.Series[name].XValueType = ChartValueTypes.Double;
                        ddChart.Series[name].YValuesPerPoint = 1;
                        //ddChart.Series[name].ShowInLegend = false;

                        //ddChart.Series[name].XValueIndexed = true;
                        ddChart.Series[name].SmartLabels.Enabled = true;
                        ddChart.Series[name].Font = this.Font;
                        ddChart.Series[name].LabelFormat = "###,###.##";
                        ddChart.Series[name].ShowLabelAsValue = true;
                        ddChart.Series[name].LegendText = name;
                        ddChart.Series[name].ToolTip = "#VAL      #AXISLABEL";


                    }
                    ddChart.DataSource = _dataSource;
                    ddChart.DataBind();

                }
            }
            catch(ArgumentException ae)
            {
            }
        }

        /// <summary>
        /// ستونهای مورد نظر را انتخاب میکند
        /// </summary>
        /// <param name="Keys">آرایه ستونهای نمایش داده شده در Query</param>
        public void SetSelectedItem(IEnumerable<string> Keys)
        {
            ClearSelectedColumn();
            foreach (var key in Keys)
            {
                var chbIndex = 0;
                foreach (var item in chbColumnsOfShow.Items.Cast<ColumnOfList<string, string>>())
                {
                    var index = key.ToUpper().IndexOf(" AS");
                    index = index == -1 ? key.Length : index;
                    if (key.Substring(0, index).Trim().Equals(item.GetValue().Trim()))
                    {
                        chbColumnsOfShow.SetItemCheckState(chbIndex, CheckState.Checked);
                        break;
                    }
                    chbIndex++;
                }

            }
            RefreshChart();
        }

        /// <summary>
        /// ستونهای مورد نظر را انتخاب میکند
        /// </summary>
        /// <param name="Keys"> ستونهای نمایش داده شده در Query به صورت "Item1 AS [Item1],Item2 AS [Item2],...</param>
        public void SetSelectedItem(string Keys)
        {
            ClearSelectedColumn();
            foreach (var key in Keys.Split(new[] { ',' }))
            {
                var chbIndex = 0;
                foreach (var item in chbColumnsOfShow.Items.Cast<ColumnOfList<string, string>>())
                {
                    var index = key.ToUpper().IndexOf(" AS");
                    index = index == -1 ? key.Length : index;
                        if (key.Substring(0, index).Trim().Equals(item.GetValue().Trim()))
                        {
                            chbColumnsOfShow.SetItemCheckState(chbIndex, CheckState.Checked);
                            break;
                        }
                    chbIndex++;
                }
            }
            RefreshChart();
        }


        public void ClearSelectedColumn()
        {
            for (var i = 0; i < chbColumnsOfShow.Items.Count; i++)
            {
                chbColumnsOfShow.SetItemChecked(i, false);
            }
        }

        public UCChart()
        {
            InitializeComponent();
            ddChart.ChartAreas["Default"].BackColor = Color.White;

            ddChart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            ddChart.BackColor = Color.FromArgb(146, 180, 222);
            ddChart.BackGradientEndColor = Color.White;
            ddChart.BackGradientType = GradientType.TopBottom;
            ddChart.BorderStyle = ChartDashStyle.Solid;
            ddChart.BorderColor = Color.DarkBlue;
            ddChart.BorderWidth = 2;

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

            ddChart.ChartAreas["Default"].AxisX.LabelStyle.Format = "###,###.##";
            ddChart.ChartAreas["Default"].AxisY.LabelStyle.Format = "###,###.##";


            ddChart.Palette = ChartColorPalette.Pastel;

            this.Dock = DockStyle.Fill;

        }

        private void chbColumnsOfShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshChart();
        }

    }


}
