using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using Presentation.Public;
using SpannedDataGridView;
using ERMS;
using ERMS.Model;
using ERMSLib;
using System.Collections.ObjectModel;
using MyDialogButton = Presentation.Public.MyDialogButton;


namespace Presentation.Deposit
{
    public partial class frmHistoricalDepositReport : BaseForm
    {

        #region Parameter

        DataTable ChartDataSourcePrice = new DataTable();
        DataTable ChartDataSourceCount = new DataTable();
        readonly Collection<Dundas.Charting.WinControl.Series> _series = new Collection<Dundas.Charting.WinControl.Series>();
        DataTable report;
        #endregion
        
        public frmHistoricalDepositReport()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);            
            GeneralDataGridView = this.dgvDMReport;
        }

        private void btnShowRpt_Click(object sender, EventArgs e)
        {
            var yearFrom = txtYearFrom.Text;
            var yearTo = txtYearTo.Text;
            var year = txtYear.Text;

            if (rdbOneYear.Checked)
            {
                if (!year.StartsWith("13") || year.Length != 4)
                {
                    Routines.ShowErrorMessageFa("خطا", "فرمت تاریخ وارد شده اشتباه است.", "",
                                                Presentation.Public.MyDialogButton.OK);
                    return;
                }
            }
            else
            {
                if (!yearFrom.StartsWith("13") || yearFrom.Length != 4 || !yearTo.StartsWith("13") || yearTo.Length != 4)
                {
                    Routines.ShowErrorMessageFa("خطا", "فرمت تاریخ وارد شده اشتباه است.", "",
                                                Presentation.Public.MyDialogButton.OK);
                    return;
                }

                if (Convert.ToInt32(yearFrom) >= Convert.ToInt32(yearTo))
                {
                    Routines.ShowErrorMessageFa("خطا", "توالی تاریخ ها رعایت نشده است.", "",
                                                Presentation.Public.MyDialogButton.OK);
                    return;
                }
            }

            dgvDMReport.Rows.Clear();
            

            _series.Clear();
            ChartDataSourcePrice = new DataTable();
            ChartDataSourceCount = new DataTable();
            ChartDataSourcePrice.Columns.Add("Month");
            ChartDataSourceCount.Columns.Add("Month");

            Utilize.Routines.ShowProcess();
            report = new DataTable();
            if (rdbOneYear.Checked)
                report = new DepositDataSet().GetHistoricalDepositByYear(Convert.ToInt32(year), 0, GlobalInfo.ProfileID, GlobalInfo.UserID);
            else
            {
                report = new DepositDataSet().GetHistoricalDepositByYear(Convert.ToInt32(yearFrom), Convert.ToInt32(yearTo), GlobalInfo.ProfileID, GlobalInfo.UserID);                    
            }
            Utilize.Routines.HideProcess();


            // add items to list
            lstYears.Items.Clear();
            var distinctYears = (from row in report.AsEnumerable()
                                    select row.Field<string>("year")).Distinct();

            foreach (var years in distinctYears) { lstYears.Items.Add(years); }
            if (lstYears.Items.Count > 0)
                lstYears.SelectedIndex = 0;
            ///
            //

            FillChart();
            var distinctModels = (from row in report.AsEnumerable()
                                    select row.Field<string>("name")).Distinct();
            ///

            // Hosein 91.03.09
            // Taghtir dar namayeshe nemoodar -> baraye namayeshe seri zamani nemoodar
            //foreach (var years in distinctYears)
            //    foreach (var models in distinctModels)
            //    {
            //        ChartDataSourcePrice.Columns.Add(years.ToString() + models.ToString());
            //        ChartDataSourcePrice.Columns[years.ToString() + models.ToString()].Caption = years.ToString() + ", " + models.ToString();
                       
            //        ChartDataSourceCount.Columns.Add(years.ToString() + models.ToString());
            //        ChartDataSourceCount.Columns[years.ToString() + models.ToString()].Caption = years.ToString() + ", " + models.ToString();
            //    }        

            //foreach (DataRow item in report.Rows)
            //{
            //    ChartDataSourcePrice.Rows[Convert.ToInt32(item["mon"]) - 1][item["year"].ToString() + item["name"].ToString()] = item["price"];
            //    ChartDataSourceCount.Rows[Convert.ToInt32(item["mon"]) - 1][item["year"].ToString() + item["name"].ToString()] = item["number"];                    
            //}                


            //foreach (var years in distinctYears)
            //foreach (var models in distinctModels)
            //{
            //    ChartDataSourcePrice.Columns.Add(models.ToString());
            //    ChartDataSourcePrice.Columns[ models.ToString()].Caption = models.ToString();

            //    ChartDataSourceCount.Columns.Add(models.ToString());
            //    ChartDataSourceCount.Columns[models.ToString()].Caption = models.ToString();
            //}

            //foreach (var years in distinctYears)
            //    for(int i = 1; i<=12;i++)
            //    {                        
            //        ChartDataSourcePrice.Rows.Add();
            //        ChartDataSourcePrice.Rows[ChartDataSourcePrice.Rows.Count - 1][0] = years.ToString() + ", " + i;

            //        ChartDataSourceCount.Rows.Add();
            //        ChartDataSourceCount.Rows[ChartDataSourceCount.Rows.Count - 1][0] = years.ToString() + ", " + i;
            //    }


            //foreach (DataRow item in report.Rows)
            //{
            //    for (int i = 0; i < ChartDataSourcePrice.Rows.Count; i++)
            //        if (ChartDataSourcePrice.Rows[i]["Month"].Equals(item["year"].ToString() + ", " + item["mon"].ToString()))
            //        {
            //            ChartDataSourcePrice.Rows[i][item["name"].ToString()] = item["price"];
            //            ChartDataSourceCount.Rows[i][item["name"].ToString()] = item["number"];
            //            break;
            //        }
            //}

            //chart.Series.Clear();
            //_series.Clear();
            //chbSerries.Items.Clear();

            //if (rb_Count.Checked)
            //    chart.DataSource = ChartDataSourceCount;
            //else if (rb_Price.Checked)
            //    chart.DataSource = ChartDataSourcePrice;

            //foreach (DataColumn item in ChartDataSourcePrice.Columns)
            //{
            //    if (item.ColumnName.Equals("Month")) continue;
            //    var series = new Dundas.Charting.WinControl.Series(item.Caption)
            //                {
            //                    ValueMembersY = item.ColumnName,
            //                    ValueMemberX = "Month"
            //                };
            //    chart.Series.Add(series);
            //    series.Type = Dundas.Charting.WinControl.SeriesChartType.Line;
            //    series.ToolTip = "#VAL      #AXISLABEL";
            //    chbSerries.Items.Add(item.Caption.Trim(), CheckState.Checked);
            //    _series.Add(series);
            //}

            //chart.DataBind();
        }

        private void FillChart()
        {
            _series.Clear();
            ChartDataSourcePrice = new DataTable();
            ChartDataSourceCount = new DataTable();
            ChartDataSourcePrice.Columns.Add("Month");
            ChartDataSourceCount.Columns.Add("Month");

            var distinctYears = (from row in report.AsEnumerable()
                                 select row.Field<string>("year")).Distinct();

            var distinctModels = (from row in report.AsEnumerable()
                                  select row.Field<string>("name")).Distinct();

            if (rdbShowPartial.Checked)
            {
                // Hosein 91.03.09
                // Taghtir dar namayeshe nemoodar -> baraye namayeshe seri zamani nemoodar
                foreach (var years in distinctYears)
                    foreach (var models in distinctModels)
                    {
                        ChartDataSourcePrice.Columns.Add(years.ToString() + models.ToString());
                        ChartDataSourcePrice.Columns[years.ToString() + models.ToString()].Caption = years.ToString() + ", " + models.ToString();

                        ChartDataSourceCount.Columns.Add(years.ToString() + models.ToString());
                        ChartDataSourceCount.Columns[years.ToString() + models.ToString()].Caption = years.ToString() + ", " + models.ToString();
                    }

                for (int i = 1; i <= 12; i++)
                    {
                        ChartDataSourcePrice.Rows.Add();
                        ChartDataSourcePrice.Rows[ChartDataSourcePrice.Rows.Count - 1][0] = i;

                        ChartDataSourceCount.Rows.Add();
                        ChartDataSourceCount.Rows[ChartDataSourceCount.Rows.Count - 1][0] = i;
                    }

                foreach (DataRow item in report.Rows)
                {
                    ChartDataSourcePrice.Rows[Convert.ToInt32(item["mon"]) - 1][item["year"].ToString() + item["name"].ToString()] = item["price"];
                    ChartDataSourceCount.Rows[Convert.ToInt32(item["mon"]) - 1][item["year"].ToString() + item["name"].ToString()] = item["number"];                    
                }     

                chart.Series.Clear();
                _series.Clear();
                chbSerries.Items.Clear();

                if (rb_Count.Checked)
                    chart.DataSource = ChartDataSourceCount;
                else if (rb_Price.Checked)
                    chart.DataSource = ChartDataSourcePrice;

                foreach (DataColumn item in ChartDataSourcePrice.Columns)
                {
                    if (item.ColumnName.Equals("Month")) continue;
                    var series = new Dundas.Charting.WinControl.Series(item.Caption)
                    {
                        ValueMembersY = item.ColumnName,
                        ValueMemberX = "Month"
                    };
                    chart.Series.Add(series);
                    series.Type = Dundas.Charting.WinControl.SeriesChartType.Line;
                    series.ToolTip = "#VAL      #AXISLABEL";
                    chbSerries.Items.Add(item.Caption.Trim(), CheckState.Checked);
                    _series.Add(series);
                }

            }
            else if (rdbShowSequntial.Checked)
            {
                //foreach (var years in distinctYears)
                foreach (var models in distinctModels)
                {
                    ChartDataSourcePrice.Columns.Add(models.ToString());
                    ChartDataSourcePrice.Columns[models.ToString()].Caption = models.ToString();

                    ChartDataSourceCount.Columns.Add(models.ToString());
                    ChartDataSourceCount.Columns[models.ToString()].Caption = models.ToString();
                }

                foreach (var years in distinctYears)
                    for (int i = 1; i <= 12; i++)
                    {
                        ChartDataSourcePrice.Rows.Add();
                        ChartDataSourcePrice.Rows[ChartDataSourcePrice.Rows.Count - 1][0] = years.ToString() + ", " + i;

                        ChartDataSourceCount.Rows.Add();
                        ChartDataSourceCount.Rows[ChartDataSourceCount.Rows.Count - 1][0] = years.ToString() + ", " + i;
                    }


                foreach (DataRow item in report.Rows)
                {
                    for (int i = 0; i < ChartDataSourcePrice.Rows.Count; i++)
                        if (ChartDataSourcePrice.Rows[i]["Month"].Equals(item["year"].ToString() + ", " + item["mon"].ToString()))
                        {
                            ChartDataSourcePrice.Rows[i][item["name"].ToString()] = item["price"];
                            ChartDataSourceCount.Rows[i][item["name"].ToString()] = item["number"];
                            break;
                        }
                }

                chart.Series.Clear();
                _series.Clear();
                chbSerries.Items.Clear();

                if (rb_Count.Checked)
                    chart.DataSource = ChartDataSourceCount;
                else if (rb_Price.Checked)
                    chart.DataSource = ChartDataSourcePrice;

                foreach (DataColumn item in ChartDataSourcePrice.Columns)
                {
                    if (item.ColumnName.Equals("Month")) continue;
                    var series = new Dundas.Charting.WinControl.Series(item.Caption)
                    {
                        ValueMembersY = item.ColumnName,
                        ValueMemberX = "Month"
                    };
                    chart.Series.Add(series);
                    series.Type = Dundas.Charting.WinControl.SeriesChartType.Line;
                    series.ToolTip = "#VAL      #AXISLABEL";
                    chbSerries.Items.Add(item.Caption.Trim(), CheckState.Checked);
                    _series.Add(series);
                }
            }
            chart.DataBind();
        }

        private void chbSerries_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbSerries.GetItemCheckState(chbSerries.SelectedIndex).Equals(CheckState.Checked))
                {
                    var series = _series.Where(item => item.Name.Equals(chbSerries.SelectedItem.ToString())).FirstOrDefault();
                    chart.Series.Add(series);

                }
                else
                {

                    var series = chart.Series.Cast<Dundas.Charting.WinControl.Series>().Where(item => item.Name.Equals(chbSerries.SelectedItem.ToString())).FirstOrDefault();
                    chart.Series.Remove(series);
                }
                chart.DataBind();
            }
            catch (Exception)
            {

            }
        }

        private void rb_Count_CheckedChanged(object sender, EventArgs e)
        {
            if (!rb_Count.Checked) return;
            chart.Series.Clear();
            _series.Clear();
            chbSerries.Items.Clear();

            if (rb_Count.Checked)
                chart.DataSource = ChartDataSourceCount;

            foreach (DataColumn item in ChartDataSourceCount.Columns)
            {
                if (item.ColumnName.Equals("Month")) continue;
                var series = new Dundas.Charting.WinControl.Series(item.Caption)
                                 {
                                     ValueMembersY = item.ColumnName,
                                     ValueMemberX = "Month"
                                 };
                chart.Series.Add(series);
                series.Type = Dundas.Charting.WinControl.SeriesChartType.Line;
                series.ToolTip = "#VAL      #AXISLABEL";
                chbSerries.Items.Add(item.Caption.Trim(), CheckState.Checked);
                _series.Add(series);
            }

            chart.DataBind();
        }

        private void rb_Price_CheckedChanged(object sender, EventArgs e)
        {
            if (!rb_Price.Checked) return;
            chart.Series.Clear();
            _series.Clear();
            chbSerries.Items.Clear();

            if (rb_Price.Checked)
                chart.DataSource = ChartDataSourcePrice;

            foreach (DataColumn item in ChartDataSourcePrice.Columns)
            {
                if (item.ColumnName.Equals("Month")) continue;
                var series = new Dundas.Charting.WinControl.Series(item.Caption)
                                 {
                                     ValueMembersY = item.ColumnName,
                                     ValueMemberX = "Month"
                                 };
                chart.Series.Add(series);
                series.Type = Dundas.Charting.WinControl.SeriesChartType.Line;
                series.ToolTip = "#VAL      #AXISLABEL";
                chbSerries.Items.Add(item.Caption.Trim(), CheckState.Checked);
                _series.Add(series);
            }

            chart.DataBind();
        }

        private void rdbOneYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOneYear.Checked)
            {
                txtYear.Enabled = true;
                txtYearFrom.Enabled = false;
                txtYearTo.Enabled = false;
            }
            else
            {
                txtYear.Enabled = false;
                txtYearFrom.Enabled = true;
                txtYearTo.Enabled = true;
            }
        }

        private void lstYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDMReport.Rows.Clear();
            dgvDMReport.Columns.Clear();

            this.dgvDMReport.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            var index = this.dgvDMReport.Columns.Add(new DataGridViewTextBoxColumnEx());
            this.dgvDMReport.Columns[index].HeaderText = "DepositID";
            this.dgvDMReport.Columns[index].Name = "DepositID";
            this.dgvDMReport.Columns[index].Visible = false;


            index = this.dgvDMReport.Columns.Add(new DataGridViewTextBoxColumnEx());
            this.dgvDMReport.Columns[index].Name = "Name";
            dgvDMReport.Columns[index].HeaderText = "نوع سپرده";

            for (var i = 1; i <= 12; i++)
            {
                //ChartDataSourcePrice.Rows.Add();
                //ChartDataSourcePrice.Rows[ChartDataSourcePrice.Rows.Count - 1][0] = i;
                
                //ChartDataSourceCount.Rows.Add();
                //ChartDataSourceCount.Rows[ChartDataSourceCount.Rows.Count - 1][0] = i;


                int n = this.dgvDMReport.Columns.Add(new DataGridViewTextBoxColumnEx());
                this.dgvDMReport.Columns[n].HeaderText = "month " + i + "count";
                this.dgvDMReport.Columns[n].Name = "month " + i + "count";
                this.dgvDMReport.Columns[n].DefaultCellStyle.Format = "N";


                int m = this.dgvDMReport.Columns.Add(new DataGridViewTextBoxColumnEx());
                this.dgvDMReport.Columns[m].HeaderText = "month " + i + "price";
                this.dgvDMReport.Columns[m].Name = "month " + i + "price";
                this.dgvDMReport.Columns[m].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgvDMReport.Columns[m].DefaultCellStyle.Format = "N";
            }
            String[] str ={"","", "فروردین","", "اردیبهشت","", "خرداد","", "تیر","", "مرداد","", "شهریور","", "مهر","",
                                "آبان","", "آذر","", "دی","", "بهمن","", "اسفند"};
            index = dgvDMReport.Rows.Add(str);

            for (var i = 0; i < str.Length; i += 2)
            {
                var textBoxCellEx = (DataGridViewTextBoxCellEx)dgvDMReport[i, index];
                textBoxCellEx.Style.BackColor = Color.LightSlateGray;
                textBoxCellEx.Style.ForeColor = Color.White;
                textBoxCellEx.ColumnSpan = 2;
            }


            String[] value ={"DepositID","نوع سپرده","تعداد","مبلغ","تعداد","مبلغ","تعداد","مبلغ","تعداد","مبلغ","تعداد","مبلغ","تعداد","مبلغ",
                               "تعداد","مبلغ","تعداد","مبلغ","تعداد","مبلغ","تعداد","مبلغ","تعداد","مبلغ","تعداد","مبلغ"};
            index = dgvDMReport.Rows.Add(value);


            for (var i = 0; i < dgvDMReport.Rows[index].Cells.Count; i++)
            {
                dgvDMReport.Rows[index].Cells[i].Style.BackColor = Color.LightSteelBlue;
            }


            foreach (DataRow item in report.Rows)
            {
                if (item["year"].ToString().Equals(lstYears.SelectedItem.ToString()))
                {
                    var selectedRow = dgvDMReport.Rows.Cast<DataGridViewRow>().Where(item1 => item1.Cells["DepositID"].Value.Equals(item["Deposit_ID"])).FirstOrDefault();

                    if (selectedRow != null)
                    {
                        selectedRow.Cells["month " + item["mon"] + "count"].Value = item["number"];
                        selectedRow.Cells["month " + item["mon"] + "price"].Value = item["price"];
                    }
                    else
                    {

                        int n = dgvDMReport.Rows.Add();

                        dgvDMReport.Rows[n].Cells["DepositID"].Value = item["Deposit_ID"];
                        dgvDMReport.Rows[n].Cells["Name"].Value = item["Name"];
                        dgvDMReport.Rows[n].Cells["month " + item["mon"] + "count"].Value = item["number"];
                        dgvDMReport.Rows[n].Cells["month " + item["mon"] + "price"].Value = item["price"];
                    }
                }
            }

        }

        private void rdbShowSequntial_CheckedChanged(object sender, EventArgs e)
        {
            FillChart();
        }
    }
    }

