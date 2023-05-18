using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using Dundas.Charting.WinControl;
//
using Presentation.Public;
using Utilize.Helper;

namespace Presentation.CHART
{
    public partial class frmChart : BaseForm
    {
        public frmChart()
        {
            InitializeComponent();
            cbCloseAll.TooltipText = "راهنما";
        }

        [DefaultValue("بدون مقدار")]
        private string _ReportType;

        private IEnumerable<DataColumn> columnsInt;
        private DataTable resoult;
        public long? Report_Id;
        readonly Collection<Series> _series = new Collection<Series>();
        private Size _size;
        private Point _location;

        public string ReportType
        {
            get { return _ReportType; }
            set { _ReportType = value; }
        }

        private void refresh_click(object sender, EventArgs e)
        {
           
            //cmbReport1.DataSource = null;
            //cmbReport1.ResetDisplayStyle();
            //cmbReport1.Clear();
            
            var swartReports = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataByReportTable(_ReportType, ERMS.Model.GlobalInfo.UserID);

            cmbReport1.DisplayMember = "ReportName";
            cmbReport1.ValueMember = "Id";
            cmbReport1.DataSource = swartReports;

            //if (!Report_Id.HasValue) return;
            //{
            //    var itemReport = cmbReport1.Items.Cast<Infragistics.Win.ValueListItem>().Where(item => item.DataValue.Equals(Report_Id)).
            //        FirstOrDefault();
            //    cmbReport1.SelectedIndex = itemReport.ListIndex;
            //}
            //cmbReport1.Enabled = false;
    
        }

        private void frmChart_Load(object sender, EventArgs e)
        {
         
            dgvChart.EnableHeadersVisualStyles = false;
            dgvChart.Columns[0].HeaderCell.Style.BackColor = Color.FromArgb(218, 185, 81);

            //dgvChart.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(218, 185, 81);
            //dgvChart.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(218, 185, 81);
            dgvChart.ColumnHeadersDefaultCellStyle.Font = new Font("B Nazanin", 12);
            
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("B Nazanin", 12);
            if (_ReportType.IsNullOrEmptyByTrim())
                Close();
            var swartReports = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataByReportTable(_ReportType, ERMS.Model.GlobalInfo.UserID);
            
            cmbReport1.DisplayMember = "ReportName";
            cmbReport1.ValueMember = "Id";
            cmbReport1.DataSource = swartReports;

            if (!Report_Id.HasValue) return;
            {
                var itemReport = cmbReport1.Items.Cast<Infragistics.Win.ValueListItem>().Where(item => item.DataValue.Equals(Report_Id)).
                    FirstOrDefault();
                cmbReport1.SelectedIndex = itemReport.ListIndex;
            }
            cmbReport1.Enabled = false;
        }

        private void dgvChart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                if (e.ColumnIndex == -1) return;
                if (dgvChart.Columns[e.ColumnIndex].Equals(cAxisX))
                {
                    dgvChart.Rows[e.RowIndex].Cells[cAxisX.Name].Value =
                        !Convert.ToBoolean(dgvChart.Rows[e.RowIndex].Cells[cAxisX.Name].Value);
                    dgvChart.EndEdit();
                }
                if (dgvChart.Columns[e.ColumnIndex].Equals(cAxisY))
                {
                    dgvChart.Rows[e.RowIndex].Cells[cAxisY.Name].Value =
                        !Convert.ToBoolean(dgvChart.Rows[e.RowIndex].Cells[cAxisY.Name].Value);
                    dgvChart.EndEdit();
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private string GetSelectedColumn(GeneralDataSet.SWART_ReportsRow reportRow)
        {
            try
            {
                var SCAAs = reportRow.SCAA.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                var sc = "";
                foreach (var row in dgvChart.Rows.Cast<DataGridViewRow>())
                {
                    if (Convert.ToBoolean(row.Cells[cAxisX.Name].Value))
                    {
                        var opn = row.Cells[cOperation.Name].Value.ToString();
                        if (opn.IsNullOrEmptyByTrim() == false)
                        {
                            var test = SCAAs.Where(
                                item =>
                                item.ToUpper().Split(new[] { "AS" }, StringSplitOptions.RemoveEmptyEntries)[1].Trim().Contains(
                                    "[" + row.Cells[cName.Name].Value.ToString().Trim() + "]")).FirstOrDefault();
                            if (test.IsNullOrEmptyByTrim())
                                continue;
                            test = test.Substring(0, test.ToUpper().LastIndexOf("AS")).Trim();
                            sc += (sc.IsNullOrEmptyByTrim() ? "" : ",") + opn + "(" + test + ")";
                            if (row.Cells[cAliasName.Name].Value.ToString().IsNullOrEmptyByTrim() == false)
                            {
                                sc += " as [" + row.Cells[cAliasName.Name].Value.ToString().Trim() + "]";
                            }
                            else
                            {
                                sc += " as [" + row.Cells[cName.Name].Value.ToString().Trim() + "]";
                            }
                        }
                    }
                    if (Convert.ToBoolean(row.Cells[cAxisY.Name].Value))
                    {
                        var test = SCAAs.Where(
                                 item =>
                                 item.ToUpper().Split(new[] { "AS" }, StringSplitOptions.RemoveEmptyEntries)[1].Trim().Contains(
                                     "[" + row.Cells[cName.Name].Value.ToString().Trim() + "]")).FirstOrDefault();
                        test = test.Substring(0, test.ToUpper().LastIndexOf("AS")).Trim();
                        sc += (sc.IsNullOrEmptyByTrim() ? "" : ",") + test;
                        sc += " as [" + row.Cells[cName.Name].Value.ToString().Trim() + "]";
                    }
                }
                return " " + sc + " ";
            }
            catch (Exception exception)
            {

                exception.ConfigLog();
                return string.Empty;
            }
        }

        private string GetGroupByColumn(GeneralDataSet.SWART_ReportsRow reportRow)
        {
            try
            {
                var SCAAs = reportRow.SCAA.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                var gb = "";
                foreach (var row in dgvChart.Rows.Cast<DataGridViewRow>())
                {
                    var test = SCAAs.Where(
                               item =>
                               item.ToUpper().Split(new[] { "AS" }, StringSplitOptions.RemoveEmptyEntries)[1].Trim().Contains(
                                   "[" + row.Cells[cName.Name].Value.ToString().Trim() + "]")).FirstOrDefault();
                    if (test.IsNullOrEmptyByTrim())
                        continue;
                    test = test.Substring(0, test.ToUpper().LastIndexOf("AS")).Trim();
                    if (Convert.ToBoolean(row.Cells[cAxisY.Name].Value))
                    {
                        gb += (gb.IsNullOrEmptyByTrim() ? " group by " : ",") + test;
                    }
                }
                return gb;
            }
            catch (Exception exception)
            {
                exception.ConfigLog();
                return string.Empty;
            }
        }


        private void btnShowChart_Click(object sender, EventArgs e)
        {
            try
            {
                
                ProgressBox.Show();
                var reportRow = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataById(
                        cmbReport1.SelectedItem.DataValue.ToString().ToLong()).FirstOrDefault();
                if (_ReportType.Equals(Properties.Resources.KEY_NameOfLoanComOverdueAndCollactVLReport))
                {
                    var sc = reportRow.SCAA;
                    while (sc.Contains(" AS "))
                    {
                        var sI = sc.IndexOf(" AS ");
                        var fI = sc.IndexOf(",", sI);
                        sc = sc.Remove(sI, fI != -1 ? fI - sI : sc.Length - sI);
                    }
                    var query = Properties.Resources.StructureQueryForReport_CompareOverdueAndCollateralTarhini.Replace(
                        Properties.Resources.KEY_WHERE, reportRow.Filter).Replace(
                            Properties.Resources.KEY_SelectedColumn, sc);

                    var sIndex = query.IndexOf("dec");
                    var fIndex = query.IndexOf(Properties.Resources.KEY_FINISH_INDEX) + Properties.Resources.KEY_FINISH_INDEX.Length;
                    query = query.Remove(sIndex, fIndex - sIndex);
                    resoult = new DepositDataSet().GetResoult(GetSelectedColumn(reportRow), " ", GetGroupByColumn(reportRow), string.Empty,
                                                    Properties.Resources.ParantezBaz + query + " dec " + Properties.Resources.Key_Parantez_Baste + " dec ");
                    dataGridView1.DataSource = resoult;

                    columnsInt = resoult.Columns.Cast<DataColumn>().Where(item => item.DataType.Equals(typeof(int)) ||
                                                                    item.DataType.Equals(typeof(long)) ||
                                                                    item.DataType.Equals(typeof(double)) ||
                                                                    item.DataType.Equals(typeof(float)) ||
                                                                    item.DataType.Equals(typeof(decimal)));
                    cmbYAxis1.Items.Clear();
                    cmbYAxis1.Items.AddRange(
                        resoult.Columns.Cast<DataColumn>().Where(item => columnsInt.Contains(item) == false).Select(
                            c => new Infragistics.Win.ValueListItem {DisplayText = c.ColumnName.Trim()}).ToArray());
                    
                    return;
                }
                resoult = new DepositDataSet().GetResoult(GetSelectedColumn(reportRow), " ", GetGroupByColumn(reportRow), reportRow.Filter,
                                                    ReportType);
                dataGridView1.DataSource = resoult;

                columnsInt = resoult.Columns.Cast<DataColumn>().Where(item => item.DataType.Equals(typeof(int)) ||
                                                                item.DataType.Equals(typeof(long)) ||
                                                                item.DataType.Equals(typeof(double)) ||
                                                                item.DataType.Equals(typeof(float)) ||
                                                                item.DataType.Equals(typeof(decimal)));
                cmbYAxis1.Items.Clear();
                cmbYAxis1.Items.AddRange(
                    resoult.Columns.Cast<DataColumn>().Where(item => columnsInt.Contains(item) == false).Select(
                        c => new Infragistics.Win.ValueListItem {DisplayText = c.ColumnName.Trim()}).ToArray());
                ProgressBox.Hide();
                dataGridView1.DefaultCellStyle.Font = new Font("B Nazanin", 11);
            }
            catch (Exception exception)
            {
                ProgressBox.Hide();
                exception.ConfigLog("گزارش گیری");
            }
        }

        private void btnShowChart_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbYAxis1.SelectedIndex == -1 & cmbYAxis1.Items.Count > 0)
                    cmbYAxis1.SelectedIndex = 0;
                chbSerries.Items.Clear();
                _series.Clear();
                chart.Series.Clear();
                chart.ChartAreas[0].AxisX.Interval = 1;
                chart.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
                chart.ChartAreas[0].AxisX.LabelsAutoFit = true;
                chart.ChartAreas[0].AxisX.LabelStyle.FontAngle = 45;
                chart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                foreach (var column in columnsInt)
                {
                    var ser = new Series(column.ColumnName.Trim());
                    var _name = resoult.Columns.Cast<DataColumn>().Where(c => c.ColumnName.Trim().Equals(cmbYAxis1.SelectedItem.DisplayText.Trim())).
                            FirstOrDefault().ColumnName;
                    ser.ValueMembersY = column.ColumnName;
                    ser.ValueMemberX = _name;
                    ser.ToolTip = "#VAL      #AXISLABEL";
                    ser.LabelFormat = "##,####.##";
                    chbSerries.Items.Add(column.ColumnName.Trim(), CheckState.Checked);
                    chart.Series.Add(ser);
                    _series.Add(ser);
                    chart.DataSource = resoult;
                    chart.DataBind();
                    chart.Palette = ChartColorPalette.Dundas;
                }
                
            }
            catch (Exception exception)
            {
                exception.ConfigLog(false, "ساختار ایجاد شده برای نمایش نمودار رعایت نشده است");
            }
        }

        private void chbSerries_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbSerries.GetItemCheckState(chbSerries.SelectedIndex).Equals(CheckState.Checked))
                {
                    chart.Series.Add(_series.Where(item => item.Name.Equals(chbSerries.SelectedItem.ToString())).FirstOrDefault());

                }
                else
                {
                    chart.Series.Remove(_series.Where(item => item.Name.Equals(chbSerries.SelectedItem.ToString())).FirstOrDefault());
                }
                chart.DataBind();
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void btnFullScreenChart_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnFullScreenChart.Checked)
                {
                    splitContainer1.Panel1Collapsed = true;
                    chart.Dock = DockStyle.Fill;
                    btnFullScreenChart.Checked = false;
                    //chart.Dock = DockStyle.None;
                    chart.Location = _location;
                    chart.Size = _size;
                }
                else
                {
                    splitContainer1.Panel1Collapsed = false;
                    btnFullScreenChart.Checked = true;
                    _size = chart.Size;
                    _location = chart.Location;
                    chart.Dock = DockStyle.Fill;
                }
            }
            catch (Exception exception)
            {

                exception.ConfigLog();
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ccmbReport_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgvChart.Rows.Clear();
                
                if (cmbReport1.SelectedItem == null)
                    return;

                var swartReport = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataById(
                    cmbReport1.SelectedItem.DataValue.ToString().ToLong()).FirstOrDefault();
                var columns = swartReport.SC.Replace("[", "").Replace("]", "").Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                var index = 0;
                foreach (var column in columns)
                {
                    dgvChart.Rows.Add(new[] { index.ToString(), column, "", "false", "false", "" });
                    index++;
                }
                dgvChart.DefaultCellStyle.Font = new Font("B Nazanin", 11);
            }
            catch (Exception exception)
            {

                exception.ConfigLog(true);
            }
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void cbCloseAll_CButtonClicked(object sender, EventArgs e)
        {
            frmPDF frmpdf = new frmPDF("/DepositPDF/frmChart.pdf");
            frmpdf.ShowDialog();
        }

        

       

    }
}
