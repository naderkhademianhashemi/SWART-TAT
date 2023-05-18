using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using Dundas.Charting.WinControl;
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
            var reportsTable = new DAL.DepositDataSetTableAdapters.ReportsTableAdapter().GetData();
            cmbReport.DisplayMember = "ReportName";
            cmbReport.ValueMember = "Id";
            cmbReport.DataSource = reportsTable;
        }

        private DAL.DepositDataSet.ReportsRow report;
        //private DataTable table;
        private readonly Type[] SqlDbTypes = { typeof(Int32), typeof(Decimal), typeof(Double), typeof(Int16), typeof(Int64) };
        private void cmbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbY.Items.Clear();
            cmbX.Items.Clear();
            report =
               new DAL.DepositDataSetTableAdapters.ReportsTableAdapter().GetDataById(
                   Convert.ToInt64(cmbReport.SelectedValue)).FirstOrDefault();
            var columns = report.SelectColumn.Split(new[] { ',' });

            var columnNames = new string[columns.Length];
            var columnAliesNames = new string[columns.Length];
            for (int i = 0; i < columns.Length; i++)
            {
                var index = columns[i].ToUpper().LastIndexOf("AS");
                columnNames[i] = columns[i].Substring(0, index).Trim();
                columnAliesNames[i] = columns[i].Substring(index + 2).Replace("[", "").Replace("]", "").Trim();
            }

            var orgColumns = new DepositDataSet.VDepositReportDataTable().Columns;
            for (var i = 0; i < columns.Length; i++)
            {
                var col = orgColumns.Cast<DataColumn>().Where(item => item.ColumnName.ToUpper().Equals(columnNames[i].ToUpper())).FirstOrDefault();
                if (col != null)
                {
                    if (SqlDbTypes.Contains(col.DataType))
                    {
                        cmbY.Items.Add(columnAliesNames[i]);
                    }
                    else
                    {
                        cmbX.Items.Add(columnAliesNames[i]);
                    }
                }
                else
                {
                    if (columnNames[i].ToUpper().Contains("COUNT(") || columnNames[i].ToUpper().Contains("SUM(") || columnNames[i].ToUpper().Contains("AVG("))
                    {
                        cmbY.Items.Add(columnAliesNames[i]);
                    }
                    else
                    {
                        if (columnNames[i].ToUpper().Contains("MAX(") || columnNames[i].ToUpper().Contains("MIN("))
                        {
                            if (columnNames[i].ToUpper().Contains("MAX("))
                            {
                                var index = columnNames[i].ToUpper().LastIndexOf("MAX(");
                                var _col = columnNames[i].Substring(index + 4).Trim();
                                _col = _col.Substring(0, _col.Length - 1);
                                var _col2 = orgColumns.Cast<DataColumn>().Where(item => item.ColumnName.ToUpper().Equals(_col.ToUpper())).FirstOrDefault();
                                if (_col2 != null)
                                {
                                    if (SqlDbTypes.Contains(_col2.DataType))
                                    {
                                        cmbY.Items.Add(columnAliesNames[i]);
                                    }
                                    else
                                    {
                                        cmbX.Items.Add(columnAliesNames[i]);
                                    }
                                }
                            }
                        }
                    }

                }

            }


            //var colTable = new DAL.DepositDataSet().GetResoultColumn(report.SelectColumn, report.OrderBy, report.GroupBy, report.Where,
            //                                                               report.TableName);
            //cmbY.Items.Clear();
            //cmbX.Items.Clear();
            //colTable.Columns.Cast<DataColumn>().Where(col => SqlDbTypes.Contains(col.DataType)).ForEach(item => cmbY.Items.Add(item.ColumnName));
            //colTable.Columns.Cast<DataColumn>().Where(col => SqlDbTypes.Contains(col.DataType) == false).ForEach(item => cmbX.Items.Add(item.ColumnName));
        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            LoadingClass.ShowProcecing(() =>
                                           {
                                               //pnlSetting.Invoke(new Action(() => { pnlSetting.Enabled = false; }));
                                               var table = new DAL.DepositDataSet().GetResoult(report.SelectColumn,
                                                                                               report.OrderBy,
                                                                                               report.GroupBy,
                                                                                               report.Where,
                                                                                               report.TableName);
                                               chart1.Invoke(new Action(() =>
                                                                            {
                                                                                chart1.Series[0].LegendText =
                                                                                    cmbReport.Text;
                                                                                chart1.ChartAreas[0].AxisX.Interval = 1;
                                                                                chart1.ChartAreas[0].AxisX.
                                                                                    IntervalAutoMode =
                                                                                    IntervalAutoMode.FixedCount;
                                                                                chart1.ChartAreas[0].AxisX.LabelsAutoFit
                                                                                    = true;
                                                                                chart1.ChartAreas[0].AxisX.LabelStyle.
                                                                                    FontAngle = 45;
                                                                                chart1.DataSource = table;
                                                                                chart1.Series[0].Font =
                                                                                    new Font("tahoma", 9);
                                                                                chart1.Series[0].ValueMemberX =
                                                                                    cmbX.SelectedItem.ToString();
                                                                                chart1.Series[0].ValueMembersY =
                                                                                    cmbY.SelectedItem.ToString();
                                                                                chart1.ChartAreas[0].AxisX.Title =
                                                                                    cmbX.SelectedItem.ToString();
                                                                                chart1.ChartAreas[0].AxisX.TitleFont =
                                                                                    new Font("Tahoma", 9);
                                                                                chart1.ChartAreas[0].AxisY.TitleFont =
                                                                                    new Font("Tahoma", 9);
                                                                                chart1.ChartAreas[0].AxisY.Title =
                                                                                    cmbY.SelectedItem.ToString();
                                                                                chart1.DataBind();
                                                                                pnlSetting.Invoke(
                                                                                    new Action(
                                                                                        () =>
                                                                                            { pnlSetting.Enabled = true;
                                                                                            }));
                                                                            }));
                                           }, new[] { pnlSetting });
        }
    }
}
