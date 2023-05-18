using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Utilize.Helper;
using Utilize.Report;

namespace Presentation.Loan
{
    public partial class frmTasvieshode : Form
    {
        DataTable user;

        public frmTasvieshode()
        {
            
            InitializeComponent();
            Load += frmTasvieshode_Load;
            cbCloseAll.TooltipText = "راهنما";
        }

        void frmTasvieshode_Load(object sender, EventArgs e)
        {
            dgvResoult.ugd.ContextMenuStrip = cmsGrid;
            dgvResoult.eventSaveReportExcelClick += dgvResoult_eventSaveReportExcelClick;

            #region State And Organization

            #region Add By AliZ

            // تابع برای تنظیم لیست شهر ها زمانی که نمایش داده می شود
            ucfCity.DropDownOpening += (ucfCity_DropDownOpening);

            #endregion

            user = new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(ERMS.Model.GlobalInfo.UserID);

            if (user.Rows.Count == 0)
            {
                var state_DataTable = new DAL.GeneralDataSetTableAdapters.StateTableAdapter().GetData();
                ucfState.DisplayMember = "State_Name";
                ucfState.ValueMember = "State_Id";
                ucfState.DataSource = state_DataTable;
                ucfState.CheckedChanged += ucfState_CheckedChanged;

                var organization_DataTable = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();

                ucfOrganization.DisplayMember = "Branch_Description";
                ucfOrganization.ValueMember = "Branch";
                ucfOrganization.DataSource = organization_DataTable;
                ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;

                #region Add By Aliz

                //تنظیمات فیلتر بندی شهر
                var cityDataTable = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData();
                ucfCity.DisplayMember = "City_Name";
                ucfCity.ValueMember = "City_ID";
                ucfCity.DataSource = cityDataTable;

                #endregion
            }
            else
            {
                var stateNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { State_Id = item["State_Id"].ToString(), State_Name = item["State_Name"].ToString() }).Distinct().ToArray();
                ucfState.DisplayMember = "State_Name";
                ucfState.ValueMember = "State_Id";
                ucfState.DataSource = stateNew_DataTable;
                ucfState.CheckedChanged += ucfState_CheckedChanged;

                var organizationNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();

                ucfOrganization.DisplayMember = "Branch_Description";
                ucfOrganization.ValueMember = "Branch";
                ucfOrganization.DataSource = organizationNew_DataTable;
                ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;

                #region Add By Aliz

                //تنظیمات فیلتر بندی شهر
                var cityDataTable = user.Rows.Cast<DataRow>().Select(item => new { City_ID = item["City_ID"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray(); new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData();
                ucfCity.DisplayMember = "City_Name";
                ucfCity.ValueMember = "City_ID";
                ucfCity.DataSource = cityDataTable;

                #endregion

            }
            #endregion

            ucEconomicSector.DisplayMember = "Economic_Sector_Desc";
            ucEconomicSector.ValueMember = "Economic_Sector";
            ucEconomicSector.DataSource = new DAL.GeneralDataSetTableAdapters.Economic_Sector_BKTableAdapter().GetData();

            ucContractType.DisplayMember = "Contract_Type_Description";
            ucContractType.ValueMember = "Contract_Type";
            ucContractType.DataSource = new DAL.GeneralDataSetTableAdapters.Contract_Type_BKTableAdapter().GetData();

        }

        void dgvResoult_eventSaveReportExcelClick(object sender, EventArgs e)
        {
            var frmSaveExcel = new Report.FrmSaveExcel(false, false, false, false)
                                   {
                                       SourceData = dgvResoult.ugd
                                   };
            frmSaveExcel.ShowDialog();
            frmSaveExcel.Dispose();
        }

        void ucfCity_DropDownOpening(object sender, EventArgs e)
        {
            #region Add By Aliz

            try
            {
                ucfCity.DisplayMember = "City_Name";
                ucfCity.ValueMember = "City_Id";

                //بررسی اینکه فیلتر استان انتخاب شده باشد و
                // استان های انتخاب شده بیشتر از یک باشد
                if (ucfState.IsChecked() && ucfState.GetSelectedItem().Count() > 0)
                {
                    if (user.Rows.Count == 0)
                    {
                        var cities = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData().Where(
                           city => ucfState.GetSelectedItem().Any(sta => sta.DataValue.ToString().Equals(city.State_ID_Fk.ToString()))).ToArray();

                        ucfCity.DataSource = cities;
                    }
                    else
                    {
                        var cities = user.Rows.Cast<DataRow>().Where(
                             city =>
                               ucfState.GetSelectedItem().Any(sta => sta.DataValue.ToString().Equals(city["State_Id"].ToString())))
                        .Select(item => new { City_Id = item["City_Id"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray();

                        ucfCity.DataSource = cities;
                    }

                    return;
                }

                // در صورتی که نه فیلتر استان یا شهر انتخاب نشده باشد
                if (user.Rows.Count == 0)
                {
                    var cities = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData();
                    ucfCity.DataSource = cities;
                }
                else
                {
                    var cities = user.Rows.Cast<DataRow>().Select(item => new { City_Id = item["City_Id"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray();
                    ucfCity.DataSource = cities;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
            #endregion
        }

        void ucfOrganization_DropDownOpening(object sender, EventArgs e)
        {
            #region Add By Aliz
            try
            {
                ucfOrganization.DisplayMember = "Branch_Description";
                ucfOrganization.ValueMember = "Branch";

                //بررسی اینکه فیلتر شهر انتخاب شده باشد و
                // شهرهای انتخاب شده بیشتر از یک باشد
                if (ucfCity.IsChecked() && ucfCity.GetSelectedItem().Count() > 0)
                {
                    //بررسی اینکه فیلتر مکان برای این کاربر تنظیم شده است
                    if (user.Rows.Count == 0)
                    {
                        var branchs = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(item => ucfCity.GetSelectedItem().Any(city => city.DataValue.ToString().Equals(item.City_Of_Branch.ToString()))).ToArray();
                        ucfOrganization.DataSource = branchs;
                    }
                    else
                    {
                        var branchs = user.Rows.Cast<DataRow>().Where(
                             org => ucfCity.GetSelectedItem().Any(city => city.DataValue.ToString().Equals(org["City_Id"].ToString())))
                        .Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();
                        ucfOrganization.DataSource = branchs;
                    }

                    return;
                }

                //بررسی اینکه فیلتر استان انتخاب شده باشد و
                // استان های انتخاب شده بیشتر از یک باشد
                if (ucfState.IsChecked() && ucfState.GetSelectedItem().Count() > 0)
                {
                    if (user.Rows.Count == 0)
                    {
                        var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(
                           org => ucfState.GetSelectedItem().Any(sta => sta.DataValue.ToString().Equals(org.State_Of_Branch.ToString()))).ToArray();

                        ucfOrganization.DataSource = organizations;
                    }
                    else
                    {
                        var organizations = user.Rows.Cast<DataRow>().Where(
                             org =>
                               ucfState.GetSelectedItem().Any(sta => sta.DataValue.ToString().Equals(org["State_Id"].ToString())))
                        .Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();

                        ucfOrganization.DataSource = organizations;
                    }

                    return;
                }

                // در صورتی که نه فیلتر استان یا شهر انتخاب نشده باشد
                if (user.Rows.Count == 0)
                {
                    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();
                    ucfOrganization.DataSource = organizations;
                }
                else
                {
                    var organizationNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();
                    ucfOrganization.DataSource = organizationNew_DataTable;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
            #endregion
        }

        void ucfState_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucfState.IsChecked() && ucfState.GetSelectedItem().Count() > 0)
                {
                    if (user.Rows.Count == 0)
                    {
                        var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(
                           org => ucfState.GetSelectedItem().Any(sta => sta.DataValue.ToString().Equals(org.State_Of_Branch.ToString()))).ToArray();

                        ucfOrganization.DisplayMember = "Branch_Description";
                        ucfOrganization.ValueMember = "Branch";
                        ucfOrganization.DataSource = organizations;
                    }
                    else
                    {
                        var organizationNew_DataTable = user.Rows.Cast<DataRow>().Where(
                             org =>
                               ucfState.GetSelectedItem().Any(
                               sta => sta.DataValue.ToString().Equals(org["State_Id"].ToString())))
                        .Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();

                        ucfOrganization.DisplayMember = "Branch_Description";
                        ucfOrganization.ValueMember = "Branch";
                        ucfOrganization.DataSource = organizationNew_DataTable;
                        ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;
                    }
                }
                else if (user.Rows.Count == 0)
                {
                    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();
                    ucfOrganization.DisplayMember = "Branch_Description";
                    ucfOrganization.ValueMember = "Branch";
                    ucfOrganization.DataSource = organizations;
                }
                else
                {
                    var organizationNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();

                    ucfOrganization.DisplayMember = "Branch_Description";
                    ucfOrganization.ValueMember = "Branch";
                    ucfOrganization.DataSource = organizationNew_DataTable;
                    ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void cbShowReport_CButtonClicked(object sender, EventArgs e)
        {
            var filter = "";
            if (chbCustCodeName.Checked)
            {
                if (rbtCounterparty.Checked)
                {
                    if (txtCounterPartyName.Tag != null)
                    {
                        var customerCode = txtCounterPartyName.Tag.ToString();
                        filter = string.Format(" CounterParty = {0}", customerCode);
                        ShowReport(filter);
                    }
                    else
                    {
                        Utilize.Routines.ShowInfoMessageFa("اخطار", "اطلاعات ورودی کافی نیست و یا اینکه با این اطلاعات مشتری وجود ندارد", Utilize.MyDialogButton.OK);
                        return;
                    }
                }
                if (rbtCounterpartyName.Checked)
                {
                    filter = "";
                    if (dgvCounterpartiesNames.DataSource != null && dgvCounterpartiesNames.Rows.Count > 0 && txtCounterpartyNameSearch.Text.Length > 0)
                    {
                        foreach (DataGridViewRow dgvRow in dgvCounterpartiesNames.Rows)
                        {
                            if (filter.Trim().Length != 0) filter += " or ";
                            filter += " Counterparty = " + dgvRow.Cells[1].Value;
                        }
                        ShowReport(filter);
                    }
                    else
                    {
                        Utilize.Routines.ShowInfoMessageFa("اخطار", "اطلاعات ورودی کافی نیست و یا اینکه با این اطلاعات مشتری وجود ندارد", Utilize.MyDialogButton.OK);
                        return;
                    }
                }
                return;
            }
            if (ucfState.IsChecked())
            {
                filter = string.Format("{0} {1} {2}", filter, filter.Trim().Length == 0 ? "" : " and ",
                                       ucfState.GetFilterStructureForSql());
            }
            if (ucfCity.IsChecked())
            {
                filter = string.Format("{0} {1} {2}", filter, filter.Trim().Length == 0 ? "" : " and ",
                                       ucfCity.GetFilterStructureForSql());

            }
            if (ucfOrganization.IsChecked())
            {
                filter = string.Format("{0} {1} {2}", filter, filter.Trim().Length == 0 ? "" : " and ",
                                       ucfOrganization.GetFilterStructureForSql());
            }
            else
            {
                if (user.Rows.Count != 0)
                {
                    string fil = "";
                    var organizationNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();
                    foreach (var item in organizationNew_DataTable)
                    {


                        fil += fil.Trim().Length == 0
                            ? "(Branch = " + "'" + item.Brach_Id.Trim() + "' "
                                                    : " OR Branch = '" + item.Brach_Id.Trim() + "' ";

                    }
                    if (fil.Trim().IsNullOrEmptyByTrim() == false)
                        fil += ")";

                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil;

                }
            }

            if (ucEconomicSector.IsChecked())
            {
                filter = string.Format("{0} {1} {2}", filter, filter.Trim().Length == 0 ? "" : " and ",
                                       ucEconomicSector.GetFilterStructureForSql());
            }

            if (ucContractType.IsChecked())
            {
                filter = string.Format("{0} {1} {2}", filter, filter.Trim().Length == 0 ? "" : " and ",
                                       ucContractType.GetFilterStructureForSql());
            }

            ShowReport(filter);
        }

        private void ShowReport(string filter)
        {
            Public.ProgressBox.Show();
            var report = new DAL.LoanDataSet().Get_TasvieShode_Loan_Letter_Guarantee(filter);
            Public.ProgressBox.Hide();
            dgvResoult.DataSource = report;
        }

        private void chbCustCodeName_CheckedChanged(object sender, EventArgs e)
        {
            cgbCustomer.Enabled = chbCustCodeName.Checked;
            cgbBranch.Enabled = chbCustCodeName.Checked ? (cgbContract.Enabled = false) : (cgbContract.Enabled = true);
        }

        private void txtCounterparty_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            try
            {
                if (e.Button.Key == "Search")
                {
                    if (txtCounterparty.Text.Trim().Length == 0 || !txtCounterparty.Text.IsNumber())
                    {
                        Utilize.Routines.ShowInfoMessageFa("خطا", "کد معتبری برای مشتری وارد نشده است", Utilize.MyDialogButton.OK);
                        return;
                    }

                    var counterparty =
                        new DAL.GeneralDataSetTableAdapters.CounterpartyTableAdapter().GetDataByCounterparty(
                            txtCounterparty.Text.ToInt()).FirstOrDefault();
                    if (counterparty != null)
                    {
                        txtCounterPartyName.Text = counterparty.Name;
                        txtCounterPartyName.Tag = counterparty.Counterparty;
                    }
                    else
                    {
                        txtCounterPartyName.Text = @"مشتری با این مشخصات وجود ندارد";
                        txtCounterPartyName.Tag = null;
                    }
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        public string SafeFarsiStr(string input)
        {
            return input.Replace("ی", "ي").Replace("ک", "ك");
        }

        private void txtCounterpartyNameSearch_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            try
            {
                if (e.Button.Key == "Search")
                {
                    if (txtCounterpartyNameSearch.Text.Trim().Length == 0)
                    {
                        Utilize.Routines.ShowInfoMessageFa("خطا", "واژه معتبری برای نام مشتری وارد نشده است", Utilize.MyDialogButton.OK);
                        return;
                    }

                    string searchText = txtCounterpartyNameSearch.Text.Trim();
                    if (rdbContains.Checked)
                        searchText = "%" + searchText + "%";
                    else if (rdbStartsWith.Checked)
                        searchText = searchText + "%";
                    else if (rdbEndsWith.Checked)
                        searchText = "%" + searchText;

                    var counterpartyNames =
                        new DAL.GeneralDataSetTableAdapters.CounterpartyTableAdapter().GetCounterPartyNameBySearch(
                            SafeFarsiStr(searchText));

                    if (counterpartyNames.Rows.Count == 0)
                    {
                        txtCounterpartyNames.Text = @"مشتری با این مشخصات وجود ندارد";
                        txtCounterpartyNames.Tag = null;
                        Utilize.Routines.ShowInfoMessageFa("خطا", "موردی یافت نشد", Utilize.MyDialogButton.OK);
                        return;
                    }

                    var frmSelCol = new frmSelectColumn(counterpartyNames, "Name", "Counterparty", "لیست مشتریان");

                    frmSelCol.ShowDialog();
                    if (frmSelCol.DialogResult == DialogResult.OK)
                    {
                        var SelectedCounterParties = frmSelCol.ReturnValue;

                        var SelectedCounterPartiesItems = SelectedCounterParties.Split(',');

                        var dtSelectedCounterParties = new DataTable();
                        dtSelectedCounterParties.Columns.Add("Name", typeof(string));
                        dtSelectedCounterParties.Columns.Add("Counterparty", typeof(int));


                        foreach (string selectedCounterPartiesItem in SelectedCounterPartiesItems)
                        {
                            var dr = dtSelectedCounterParties.NewRow();
                            dr["Name"] = selectedCounterPartiesItem.Split(':')[0].Replace("[", "");
                            dr["Counterparty"] = selectedCounterPartiesItem.Split(':')[1].Replace("]", "");
                            dtSelectedCounterParties.Rows.Add(dr);
                        }
                        dgvCounterpartiesNames.DataSource = dtSelectedCounterParties;
                        dgvCounterpartiesNames.Columns[1].Visible = false;
                        dgvCounterpartiesNames.Columns[0].Width = 400;
                        dgvCounterpartiesNames.Columns[0].HeaderText = @"نام مشتری";

                        if (SelectedCounterParties.Length < 2)
                        {
                            Utilize.Routines.ShowErrorMessageFa("خطا", "موردی انتخاب نشده است", Utilize.MyDialogButton.OK);
                            return;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void chbCounterparty_CheckedChanged(object sender, EventArgs e)
        {
            txtCounterparty.Enabled = rbtCounterparty.Checked;
            txtCounterPartyName.Enabled = rbtCounterparty.Checked;
            if (!rbtCounterparty.Checked)
            {
                txtCounterparty.Text = "";
                txtCounterPartyName.Tag = null;
                txtCounterPartyName.Text = "";
            }
        }

        private void chbCounterpartyName_CheckedChanged(object sender, EventArgs e)
        {
            txtCounterpartyNameSearch.Enabled = rbtCounterpartyName.Checked;
            if (!chbCustCodeName.Checked)
            {
                rbtCounterparty.Checked = false;
                rbtCounterpartyName.Checked = false;
            }
        }

        private Size dgvResoultSize;
        private void btnFulScreenGrid_Click(object sender, EventArgs e)
        {
            btnFulScreenGrid.Checked = !btnFulScreenGrid.Checked;
            if (btnFulScreenGrid.Checked)
            {
                dgvResoultSize = dgvResoult.Size;
                cbShowReport.Visible = false;
                dgvResoult.Dock = DockStyle.Fill;
            }
            else
            {
                dgvResoult.Dock = DockStyle.None;
                cbShowReport.Visible = true;
                dgvResoult.Size = dgvResoultSize;
            }
        }

        private void cbCloseAll_CButtonClicked(object sender, EventArgs e)
        {
            frmPDF frmpdf = new frmPDF("/CreditRiskPDF/frmTasvieshode.pdf");
            frmpdf.ShowDialog();
        }
    }
}
