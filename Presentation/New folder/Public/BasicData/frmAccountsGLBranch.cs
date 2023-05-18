using System;
using System.Collections.Generic;
using DAL.Table_DataSetTableAdapters;
using System.Windows.Forms;
//
using Presentation.Public;
using Utilize;
using Utilize.Helper;
using System.Data;
using System.Linq;

namespace Presentation.Tabs.BasicData
{
    public partial class frmAccountsGLBranch : Form
    {
        DataTable dtAccountsGl;
        DataTable user;
        private const string ReportName = "VAGBranch";
        public frmAccountsGLBranch()
        {
            InitializeComponent();
            try
            {
                cmbCity.DisplayMember = "City_Name";
                cmbCity.ValueMember = "City_ID";

                cmbState.DisplayMember = "State_Name";
                cmbState.ValueMember = "State_Id";

                cmbBranch.DisplayMember = "Branch_Description";
                cmbBranch.ValueMember = "Branch";
            }
            catch (Exception ex)
            { }
            GeneralDataGridViewUltra = ugSWARTReport;
        }

        private void frmAccountsGLBranch_Load(object sender, EventArgs e)
        {
            try
            {
                fdpHistoricDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate();
                fdpStartDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate();
                fdpFinishDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate();

                //var branchs = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(item => ucfCity.GetSelectedItem().Any(city => city.DataValue.ToString().Equals(item.City_Of_Branch.ToString()))).ToArray();
                //cmbBranch.
                //cmbBranch.DataSource = branchs;
                user = new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(ERMS.Model.GlobalInfo.UserID);

                if (user.Rows.Count == 0)
                {
                    var state_DataTable = new DAL.GeneralDataSetTableAdapters.StateTableAdapter().GetData();
                    cmbState.DataSource = state_DataTable;

                    //var cityDataTable = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData();
                    //cmbCity.DataSource = cityDataTable;

                    //var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();
                    //cmbBranch.DataSource = organizations;
                }
                else
                {
                    var stateNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { State_Id = item["State_Id"].ToString(), State_Name = item["State_Name"].ToString() }).Distinct().ToArray();
                    cmbState.DataSource = stateNew_DataTable;

                    //var cityDataTable = user.Rows.Cast<DataRow>().Select(item => new { City_ID = item["City_ID"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray(); new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData();
                    //cmbCity.DataSource = cityDataTable;

                    //var organizations = user.Rows.Cast<DataRow>().Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();
                    //cmbBranch.DataSource = organizations;
                }
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowErrorMessageFa("خطا", ex.Message, Public.MyDialogButton.OK);
            }
            finally
            {
            }
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            var frmSaveExcel=new Report.FrmSaveExcel {SourceData = ugSWARTReport};
            frmSaveExcel.ShowDialog();
        }

        private void btnMdl_CButtonClicked(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == false)
            {
                splitContainer1.Panel2Collapsed = true;
                btnMdl.DefaultImage = Properties.Resources.S_Panleft1;
                btnMdl.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (splitContainer1.Panel2Collapsed == true)
            {
                splitContainer1.Panel2Collapsed = false;
                btnMdl.DefaultImage = Properties.Resources.S_PanRight1;
                btnMdl.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }

        private void btnReload_CButtonClicked(object sender, EventArgs e)
        {
            fill_AccountsGL();
        }

        private void fill_AccountsGL()
        {
            ProgressBox.Show();
            string Filter = GetFilter();

            dtAccountsGl = new DAL.AGL_DataSet().GetAccountGLBranch(fdpHistoricDate.SelectedDateTime, Filter, 2);
            dtAccountsGl.Columns["State_Name"].Caption = "استان";
            dtAccountsGl.Columns["Branch_Id"].Caption = "کد شعبه";
            dtAccountsGl.Columns["Accounting_Date"].Caption = "تاریخ";
            dtAccountsGl.Columns["Branch_Description"].Caption = "شعبه";
            dtAccountsGl.Columns["Accounting_Code"].Caption = "شماره حساب";
            dtAccountsGl.Columns["Accounting_Name"].Caption = "عنوان حساب";
            dtAccountsGl.Columns["Level"].Caption = "سطح";
            dtAccountsGl.Columns["Credit_Amount"].Caption = "مبلغ بستانكار";
            dtAccountsGl.Columns["Debt_Amount"].Caption = "مبلغ بدهكار";
            if (ugSWARTReportTab.SelectedTab.Name == "uiTabPage_Daily")
            {
                ugSWARTReport.DataSource = dtAccountsGl;
            }
            else
            {
                ugSWARTReport_Trend.DataSource = dtAccountsGl;
                
                chtTotal.Series.Clear();
                chtTotal.Series.Add("Series1");
                chtTotal.Series.Add("Series2");
                chtTotal.Palette = Dundas.Charting.WinControl.ChartColorPalette.Chocolate;
                chtTotal.Titles[0].Text = "سیر تاریخی حساب " + txtAccountingCode.Text + " در شعبه " +  cmbBranch.Text
                                            + "\n" + " از " + fdpStartDate.Text + " تا " + fdpFinishDate.Text;
                chtTotal.Series["Series1"].Type = Dundas.Charting.WinControl.SeriesChartType.Line;
                chtTotal.Series["Series2"].Type = Dundas.Charting.WinControl.SeriesChartType.Line;

                chtTotal.Series["Series1"].ValueMemberX = "Accounting_Date";
                chtTotal.Series["Series1"].ValueMembersY = "Credit_Amount";
                chtTotal.Series["Series1"].XValueType = Dundas.Charting.WinControl.ChartValueTypes.Int;
                chtTotal.Series["Series1"].YValuesPerPoint = 1;
                chtTotal.Series["Series1"].ShowInLegend = false;
                chtTotal.Series["Series1"].LegendText = "مبلغ بستانكار";
                chtTotal.Series["Series1"].AxisLabel = "مبلغ بستانكار";


                chtTotal.Series["Series2"].ValueMemberX = "Accounting_Date";
                chtTotal.Series["Series2"].ValueMembersY = "Debt_Amount";
                chtTotal.Series["Series2"].XValueType = Dundas.Charting.WinControl.ChartValueTypes.Int;
                chtTotal.Series["Series2"].YValuesPerPoint = 1;
                chtTotal.Series["Series2"].ShowInLegend = false;
                chtTotal.Series["Series2"].LegendText = "مبلغ بدهكار";
                chtTotal.Series["Series2"].AxisLabel = "مبلغ بدهكار";

                chtTotal.DataSource = dtAccountsGl;
                chtTotal.DataBind();
            }
            
            ProgressBox.Hide();
        }

        private string GetFilter()
        {
            string fil = "";
            try
            {
                if (user.Rows.Count != 0)
                {
                    var organizationNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();
                    foreach (var item in organizationNew_DataTable)
                    {
                        fil += fil.Trim().Length == 0
                            ? "(branch_Id = " + item.Brach_Id.Trim() + " "
                                                    : " OR branch_Id = " + item.Brach_Id.Trim() + "  ";

                    }
                    if (fil.Trim().Length > 0)
                        fil += ")";
                }

                if (ugSWARTReportTab.SelectedTab.Name == "uiTabPage_Daily")
                {
                    fil += fil.Trim().Length == 0 ? " Accounting_Date = '" + 
                                    fdpHistoricDate.SelectedDateTime.ToShortDateString() + "'" :
                                        " AND Accounting_Date = '" +
                                                fdpHistoricDate.SelectedDateTime.ToShortDateString() + "'";
                }
                else
                {
                    fil += fil.Trim().Length == 0 ?
                        " Accounting_Date >= '" + fdpStartDate.SelectedDateTime.ToShortDateString() + "' AND "
                            + " Accounting_Date <= '" + fdpFinishDate.SelectedDateTime.ToShortDateString() + "' AND "
                             + " Accounting_Code = " + int.Parse(txtAccountingCode.Text) + " AND "
                             + " Branch_Id = " + int.Parse(cmbBranch.SelectedValue.ToString()) :
                        " AND Accounting_Date >= '" + fdpStartDate.SelectedDateTime.ToShortDateString() + "' AND "
                                + " Accounting_Date <= '" + fdpFinishDate.SelectedDateTime.ToShortDateString() + "' AND "
                                 + " Accounting_Code = " + int.Parse(txtAccountingCode.Text) + " AND "
                                  + " Branch_Id = " + int.Parse(cmbBranch.SelectedValue.ToString());
                }

                
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(
                    "مقادیر ورودی به درستی وارد نشده اند",
                    "خطا در ورود داده", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return fil;
        }

        private void btnReload2_CButtonClicked(object sender, EventArgs e)
        {
            if (txtAccountingCode.Text.Length == 0 || cmbBranch.SelectedIndex == -1)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(
                    "مقادیر ورودی به درستی وارد نشده اند",
                    "خطا در ورود داده", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            fill_AccountsGL();
        }

        private void btnSaveExcel2_CButtonClicked(object sender, EventArgs e)
        {
            var frmSaveExcel = new Report.FrmSaveExcel { SourceData = ugSWARTReport_Trend };
            frmSaveExcel.ShowDialog();
        }

        private void cmbCity_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            #region Add By Aliz

            try
            {
                //بررسی اینکه فیلتر استان انتخاب شده باشد و
                // استان های انتخاب شده بیشتر از یک باشد
                if (cmbState.CheckedItems.Count > 0)
                {
                    if (user.Rows.Count == 0)
                    {
                        var cities = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData().Where(
                           city => cmbState.CheckedItems.Any(sta => sta.DataValue.ToString().Equals(city.State_ID_Fk.ToString()))).ToArray();

                        cmbCity.DataSource = cities;
                    }
                    else
                    {
                        var cities = user.Rows.Cast<DataRow>().Where(
                             city =>
                               cmbState.CheckedItems.Any(sta => sta.DataValue.ToString().Equals(city["State_Id"].ToString())))
                        .Select(item => new { City_Id = item["City_Id"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray();

                        cmbCity.DataSource = cities;
                    }

                    return;
                }

                // در صورتی که نه فیلتر استان یا شهر انتخاب نشده باشد
                if (user.Rows.Count == 0)
                {
                    var cities = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData();
                    cmbCity.DataSource = cities;
                }
                else
                {
                    var cities = user.Rows.Cast<DataRow>().Select(item => new { City_Id = item["City_Id"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray();
                    cmbCity.DataSource = cities;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
            #endregion
        }

        private void cmbBranch_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            #region Add By Aliz
            try
            {
                //بررسی اینکه فیلتر شهر انتخاب شده باشد و
                // شهرهای انتخاب شده بیشتر از یک باشد
                if (cmbCity.CheckedItems.Count() > 0)
                {
                    //بررسی اینکه فیلتر مکان برای این کاربر تنظیم شده است
                    if (user.Rows.Count == 0)
                    {
                        var branchs = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(item => 
                                            cmbCity.CheckedItems.Any(city => city.DataValue.ToString().Equals(item.City_Of_Branch.ToString()))).ToArray();
                        cmbBranch.DataSource = branchs;
                    }
                    else
                    {
                        var branchs = user.Rows.Cast<DataRow>().Where(
                             org => cmbCity.CheckedItems.Any(city => city.DataValue.ToString().Equals(org["City_Id"].ToString())))
                        .Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();
                        cmbBranch.DataSource = branchs;
                    }

                    return;
                }

                ////بررسی اینکه فیلتر استان انتخاب شده باشد و
                //// استان های انتخاب شده بیشتر از یک باشد
                //if (ucfState.IsChecked() && ucfState.GetSelectedItem().Count() > 0)
                //{
                //    if (user.Rows.Count == 0)
                //    {
                //        var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(
                //           org => ucfState.GetSelectedItem().Any(sta => sta.DataValue.ToString().Equals(org.State_Of_Branch.ToString()))).ToArray();

                //        cmbBranch.DataSource = organizations;
                //    }
                //    else
                //    {
                //        var organizations = user.Rows.Cast<DataRow>().Where(
                //             org =>
                //               ucfState.GetSelectedItem().Any(sta => sta.DataValue.ToString().Equals(org["State_Id"].ToString())))
                //        .Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();

                //        ucfOrganization.DataSource = organizations;
                //    }

                //    return;
                //}

                //// در صورتی که نه فیلتر استان یا شهر انتخاب نشده باشد
                //if (user.Rows.Count == 0)
                //{
                //    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();
                //    ucfOrganization.DataSource = organizations;
                //}
                //else
                //{
                //    var organizationNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();
                //    ucfOrganization.DataSource = organizationNew_DataTable;
                //}
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
            #endregion
        }

        private void ugSWARTReportTab_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {

        }

        private void btnSaveExcel_Load(object sender, EventArgs e)
        {

        }

        private void ugSWARTReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
