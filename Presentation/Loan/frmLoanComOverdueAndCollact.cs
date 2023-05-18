using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DAL;
using Infragistics.Win.UltraWinTree;
using Utilize;
using Utilize.Helper;
using Resources = Presentation.Properties.Resources;

namespace Presentation.Loan
{
    public partial class frmLoanComOverdueAndCollact : Form
    {
        DataTable user;
        private long? ReportId;
        public frmLoanComOverdueAndCollact()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            try
            {

                #region State And Organization

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
                    ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening_1;
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
                    ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening_1;
                }

                #region Add By AliZ

                // تابع برای تنظیم لیست شهر ها زمانی که نمایش داده می شود
                ucfCity.DropDownOpening += (ucfCity_DropDownOpening);

                #endregion

                ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening_1;


                user = new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(ERMS.Model.GlobalInfo.UserID);

                if (user.Rows.Count == 0)
                {
                    var state_DataTable = new DAL.GeneralDataSetTableAdapters.StateTableAdapter().GetData();
                    ucfState.DisplayMember = "State_Name";
                    ucfState.ValueMember = "State_Id";
                    ucfState.DataSource = state_DataTable;
                    
                    var organization_DataTable = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();

                    ucfOrganization.DisplayMember = "Branch_Description";
                    ucfOrganization.ValueMember = "Branch";
                    ucfOrganization.DataSource = organization_DataTable;

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

                    var organizationNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();

                    ucfOrganization.DisplayMember = "Branch_Description";
                    ucfOrganization.ValueMember = "Branch";
                    ucfOrganization.DataSource = organizationNew_DataTable;

                    #region Add By Aliz
                    
                    //تنظیمات فیلتر بندی شهر
                    var cityDataTable = user.Rows.Cast<DataRow>().Select(item => new { City_ID = item["City_ID"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray(); new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData();
                    ucfCity.DisplayMember = "City_Name";
                    ucfCity.ValueMember = "City_ID";
                    ucfCity.DataSource = cityDataTable; 
                    
                    #endregion
                }

                #endregion


                //var contract_DataTable = new DAL.GeneralDataSetTableAdapters.Contract_TypeTableAdapter().GetDataByLoan();
                var contract_Type_Group_DataTable = new DAL.GeneralDataSetTableAdapters.Contract_type_groupsTableAdapter().GetData();
                ucfContractType.DisplayMember = "Contract_type_group_Desc";
                ucfContractType.ValueMember = "Contract_type_group_id";
                ucfContractType.DataSource = contract_Type_Group_DataTable;

                var contract_DataTable = new DAL.GeneralDataSetTableAdapters.Contract_TypeTableAdapter().GetDataByLoan();
                ucFilteringContractTypeCode.DisplayMember = "Contract_Type_Description";
                ucFilteringContractTypeCode.ValueMember = "Contract_Type";
                ucFilteringContractTypeCode.DataSource = contract_DataTable;



                var economicSector_DataTable = new DAL.GeneralDataSetTableAdapters.Economic_SectorTableAdapter().GetData();

                ucEconomicSector.DisplayMember = "Economic_Sector_Desc";
                ucEconomicSector.ValueMember = "Economic_Sector";
                ucEconomicSector.DataSource = economicSector_DataTable;

                var customerGroup_DataTable = new DAL.GeneralDataSetTableAdapters.Customer_GroupTableAdapter().GetData();

                ucfCustomerGroup.DisplayMember = "Customer_Group_Description";
                ucfCustomerGroup.ValueMember = "Customer_Group";
                ucfCustomerGroup.DataSource = customerGroup_DataTable;

                var counterparty_DataTable = new DAL.GeneralDataSetTableAdapters.Counterparty_TypeTableAdapter().GetData();

                ucfCounterPartyType.DataSource = counterparty_DataTable;
                ucfCounterPartyType.DisplayMember = "Counterparty_Type_Desc";
                ucfCounterPartyType.ValueMember = "Counterparty_Type";

                var contractStatusDataTable =
                    new DAL.Table_DataSetTableAdapters.Contract_StatusTableAdapter().GetDataMOAVAGHAT();
                ucContractStatus.DisplayMember = "Status_desc";
                ucContractStatus.ValueMember = "Status";
                ucContractStatus.DataSource = contractStatusDataTable;
            }
            catch (Exception exception)
            {
                exception.ConfigLog(false, "خطا در بارگزاری داده رخ");
                Close();
            }
        }

        private void ucfOrganization_DropDownOpening(object sender, EventArgs e)
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
                        ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening_1;
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
                    ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening_1;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void ucfState_CheckedChanged(object sender, EventArgs e)
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
                        ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening_1;
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
                    ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening_1;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }


        }


        private void frmLoanComOverdueAndCollact_Load(object sender, EventArgs e)
        {
            try
            {
                FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

                fdpFromStartDate.SelectedDateTime = DateTime.Now;
                fdpFromStartDate.ResetSelectedDateTime();

                fdpToStartDate.SelectedDateTime = DateTime.Now.AddDays(1);
                fdpToStartDate.ResetSelectedDateTime();

                fdpFromMaturityDate.SelectedDateTime = DateTime.Now;
                fdpFromMaturityDate.ResetSelectedDateTime();

                fdpToMaturityDate.SelectedDateTime = DateTime.Now.AddDays(1);
                fdpToMaturityDate.ResetSelectedDateTime();

                var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.
                                                                  SelectedColumnForShowInReportTableAdapter().
                                                                  GetDataByNameReport(
                                                                      Resources.
                                                                          KEY_NameOfLoanComOverdueAndCollactVLReport);
                ucSelectColumn.NameOfDisplay = Resources.AliasNameColumnForReport;
                ucSelectColumn.NameOfValue = Resources.NameColumnForReport;
                ucSelectColumn.DataSource = columnsForShowInReport;
                ConfReportsList();
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void ConfReportsList()
        {
            try
            {
                trnReport.Nodes.Clear();
                var reportsTable = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataByReportTable(Resources.KEY_NameOfLoanComOverdueAndCollactVLReport, ERMS.Model.GlobalInfo.UserID);
                reportsTable.ForEach(item => trnReport.Nodes.Add(new UltraTreeNode(item.Id.ToString(), item.ReportName)));
            }
            catch (Exception exception)
            {
                exception.ConfigLog();
            }
        }

        private void chbStartDate_CheckedChanged(object sender, EventArgs e)
        {
            fdpFromStartDate.Enabled = chbStartDate.Checked;
            fdpToStartDate.Enabled = chbStartDate.Checked;
        }

        private void chbMaturityDate_CheckedChanged(object sender, EventArgs e)
        {
            fdpFromMaturityDate.Enabled = chbMaturityDate.Checked;
            fdpToMaturityDate.Enabled = chbMaturityDate.Checked;
        }

        private void btnShowNormalReport_Click(object sender, EventArgs e)
        {
            try
            {
                Routines.ShowProcess();
                var filter = GetFilter();
                var queryForReport = Resources.StructureQueryForReport_CompareOverdueAndCollateralTarhini;
                queryForReport = queryForReport.Replace(Resources.KEY_WHERE, filter.IsNullOrEmptyByTrim() ? "" : filter);
                queryForReport = queryForReport.Replace(Resources.KEY_SelectedColumn,
                                                        ucSelectColumn.GetSelectedItemForQuerySql());
                var maxSizeOfRowForReport = Resources.MaxSizeOfRowForReport;
                bool filterStatus = false;
                if (chbCompareFilter.Checked)
                {
                    if (cmbCompareFilter.SelectedIndex == 0)
                        maxSizeOfRowForReport = maxSizeOfRowForReport + " and Collat_Value_Tarhini<TotalOverdue ";
                    if (cmbCompareFilter.SelectedIndex == 1)
                        maxSizeOfRowForReport = maxSizeOfRowForReport + " and Collat_Value_Tarhini=TotalOverdue ";
                    if (cmbCompareFilter.SelectedIndex == 2)
                        maxSizeOfRowForReport = maxSizeOfRowForReport + " and Collat_Value_Tarhini>TotalOverdue ";
                    filterStatus = true;
                }
                if (filterStatus == false)
                    queryForReport = queryForReport.Replace(Resources.KEY_START_INDEX, Resources.StartIndexForReportShow).Replace(Resources.KEY_FINISH_INDEX,
                                                                                   maxSizeOfRowForReport);
                else
                {
                    queryForReport = queryForReport.Replace(Resources.KEY_START_INDEX, Resources.StartIndexForReportShow).Replace(Resources.KEY_FINISH_INDEX,
                                                                                  maxSizeOfRowForReport);
                    queryForReport = queryForReport.Replace("row_id between 1 and 100000 and", " ");
                }
                //and Collat_Value_Tarhini>TotalOverdue
                var dataTable = new DAL.Report().GetReportByQuery(queryForReport);
                var colReport = new DAL.Table_DataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByGetNameReport(
                    Resources.KEY_NameOfLoanComOverdueAndCollactVLReport);
                var colNameFirstCompare = colReport.Where(item => item.NameColumn.Equals("Collat_Value_Tarhini")).FirstOrDefault();
                var colNameTwoCompare = colReport.Where(item => item.NameColumn.Equals("TotalOverdue")).FirstOrDefault();
                dataTable.ConfigDateTimeToPersian();
                Routines.HideProcess();
                var frmShowReprt = new Report.frmShowReprt(dataTable)
                                       {
                                           CompareEnable = true,
                                           ColNameOneForCompare = colNameFirstCompare.AliasName,
                                           ColNameTwoForCompare = colNameTwoCompare.AliasName,
                                           SCA = ucSelectColumn.GetSelectedItem(),
                                           SCAA = ucSelectColumn.GetSelectedItemForQuerySql(),
                                           F = filter,
                                           TN = Resources.KEY_NameOfLoanComOverdueAndCollactVLReport
                                       };
                frmShowReprt.ShowDialog();
            }
            catch (Exception exception)
            {
                Routines.HideProcess();
                exception.ConfigLog(true);
            }
        }

        private string GetFilter()
        {
            try
            {

                var fil_State = ucfState.GetFilterStructureForSql();

                #region Add By Aliz
                var fil_City = ucfCity.GetFilterStructureForSql(); 
                #endregion

                var fil_Organization = ucfOrganization.GetFilterStructureForSqlBranch();
                var fil_CustomerGroup = ucfCustomerGroup.GetFilterStructureForSql();
                var fil_CounterpartyType = ucfCounterPartyType.GetFilterStructureForSql();
                var fil_ContractType = ucfContractType.GetFilterStructureForSql().Replace("Contract_type_group_id" , "Contract_type_groups.Contract_type_group_id");
                var fil_EconomicSector = ucEconomicSector.GetFilterStructureForSql();
                var fil_ContractTypeCode = ucFilteringContractTypeCode.GetFilterStructureForSql().Replace("Contract_Type", "Contract_Type.Contract_Type");
                var fil_ContractStatus = ucContractStatus.GetFilterStructureForSql();

                var fil_Counterparty = "";
                if (chbCounterparty.Checked)
                {
                    var item = txtCounterPartyName.Tag;
                    fil_Counterparty += fil_Counterparty.Trim().Length == 0
                                            ? Resources.ParantezBaz + Resources.Key_Counterparty + Resources.Key_Mosavi + item + Resources.Key_SpaceString
                                            : Resources.Key_OR + Resources.Key_Counterparty + Resources.Key_Mosavi + item;
                    if (fil_Counterparty.Trim().IsNullOrEmptyByTrim() == false)
                        fil_Counterparty += Resources.Key_Parantez_Baste;
                }

                var fil_StartDate = "";
                if (chbStartDate.Checked)
                {
                    if (fdpFromStartDate.Text.Trim().Length != 0)
                        fil_StartDate += " Start_Date>='" + fdpFromStartDate.SelectedDateTime.ToString("yyyy-MM-dd") + "' ";
                    if (fdpToStartDate.Text.Trim().Length != 0)
                    {
                        if (fil_StartDate.Trim().Length != 0) fil_StartDate += Resources.Key_And;
                        fil_StartDate += " Start_Date <='" + fdpToStartDate.SelectedDateTime.ToString("yyyy-MM-dd") + "' ";
                    }
                }

                var fil_MaturityDate = "";
                if (chbMaturityDate.Checked)
                {
                    if (fdpFromMaturityDate.Text.Trim().Length != 0)
                        fil_MaturityDate += " Maturity_Date>='" + fdpFromMaturityDate.SelectedDateTime.ToString("yyyy-MM-dd") + "' ";
                    if (fdpToMaturityDate.Text.Trim().Length != 0)
                    {
                        if (fil_MaturityDate.Trim().Length != 0) fil_MaturityDate += Resources.Key_And;
                        fil_MaturityDate += " Maturity_Date <='" + fdpToMaturityDate.SelectedDateTime.ToString("yyyy-MM-dd") + "' ";
                    }
                }

                var filter = "";


                if (fil_EconomicSector.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += Resources.Key_And;
                    filter += fil_EconomicSector;
                }

                if (fil_ContractStatus.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += Resources.Key_And;
                    filter += fil_ContractStatus;
                }

                if (fil_Counterparty.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += Resources.Key_And;
                    filter += fil_Counterparty;
                }

                if (fil_CounterpartyType.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += Resources.Key_And;
                    filter += fil_CounterpartyType;
                }

                if (fil_ContractType.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += Resources.Key_And;
                    filter += fil_ContractType;
                }

                if (fil_ContractTypeCode.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += Resources.Key_And;
                    filter += fil_ContractTypeCode;
                }

                if (fil_State.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_State;
                }
                else if (user.Rows.Count != 0)
                {
                    string fil = "";
                    var stateNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { State_Id = item["State_Id"].ToString(), State_Name = item["State_Name"].ToString() }).Distinct().ToArray();
                    foreach (var item in stateNew_DataTable)
                    {


                        fil += fil.Trim().Length == 0
                            ? "(State_Id = " + "'" + item.State_Id.Trim() + "' "
                                                    : " OR State_Id = '" + item.State_Id.Trim() + "' ";

                    }
                    if (fil.Trim().IsNullOrEmptyByTrim() == false)
                        fil += ")";

                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil;

                }


                #region Add By Aliz
                if (fil_City.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_City;
                }
                //if (user.Rows.Count != 0 && !(chbCustCodeName.Checked &&
                //                                    (dgvCounterpartiesNames.Rows.Count > 0 ||
                //                                        (txtCounterPartyName.Text.Length > 0 && !txtCounterPartyName.Text.Equals("مشتری با این مشخصات وجود ندارد")))))
                if (user.Rows.Count != 0 && !(chbCounterparty.Checked &&
                                                    (
                                                    //dgvCounterpartiesNames.Rows.Count > 0 ||
                                                        (txtCounterPartyName.Text.Length > 0 && !txtCounterPartyName.Text.Equals("مشتری با این مشخصات وجود ندارد")))))
                
                {
                    string fil = "";
                    var cityNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { City_Id = item["City_Id"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray();
                    foreach (var item in cityNew_DataTable)
                    {
                        fil += fil.Trim().Length == 0
                            ? "(City_Id = " + "'" + item.City_Id.Trim() + "' "
                                                    : " OR City_Name = '" + item.City_Name.Trim() + "' ";
                    }
                    if (fil.Trim().IsNullOrEmptyByTrim() == false)
                        fil += ")";

                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil;
                }
                
                #endregion


                if (fil_CustomerGroup.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += Resources.Key_And;
                    filter += fil_CustomerGroup;
                }

                if (fil_Organization.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_Organization;
                }
                else if (user.Rows.Count != 0)
                {
                    string fil = "";
                    var organizationNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();
                    foreach (var item in organizationNew_DataTable)
                    {


                        fil += fil.Trim().Length == 0
                            ? "(Organization.Branch = " + "'" + item.Brach_Id.Trim() + "' "
                                                    : " OR Organization.Branch = '" + item.Brach_Id.Trim() + "' ";

                    }
                    if (fil.Trim().IsNullOrEmptyByTrim() == false)
                        fil += ")";

                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil;

                }
                if (fil_StartDate.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += Resources.Key_And;
                    filter += fil_StartDate;
                }

                if (fil_MaturityDate.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += Resources.Key_And;
                    filter += fil_MaturityDate;
                }

                if (filter.Trim().Length != 0)
                    filter = " where " + filter;
                return filter;
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
                return string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (ReportId.HasValue == false)
                {
                    var filter = GetFilter();
                    var frmInputText = new frmInputText { Topic = "نام گزارش" };
                    frmInputText.ShowDialog();
                    var value = frmInputText.ReturnValue;
                    if (value == null) return;
                    var newRepor = new GeneralDataSet.SWART_ReportsDataTable().NewSWART_ReportsRow();
                    newRepor.ReportName = value;
                    newRepor.ReportTable = Resources.KEY_NameOfLoanComOverdueAndCollactVLReport;
                    newRepor.ReportType = false;
                    newRepor.Filter = filter;
                    newRepor.SCAA = ucSelectColumn.GetSelectedItemForQuerySql();
                    newRepor.SC = ucSelectColumn.GetSelectedItem();
                    new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().Insert(newRepor.ReportName,
                                                                                           newRepor.ReportTable,
                                                                                           newRepor.ReportType,
                                                                                           newRepor.SCAA, newRepor.Filter,
                                                                                           null, newRepor.SC, ERMS.Model.GlobalInfo.UserID);
                    ConfReportsList();
                    ReportId =
                        new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetData().Where(
                            rep =>
                            rep.ReportTable.Equals(Resources.KEY_NameOfLoanComOverdueAndCollactVLReport)).Max(
                                item => item.Id);
                    Routines.ShowInfoMessageFa("ایجاد گزارش", string.Format("گزارش {0} با موفقیت ثبت شد", value), MyDialogButton.OK);
                }
                else
                {
                    var swartReport = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataById(ReportId.Value).FirstOrDefault();
                    swartReport.Filter = GetFilter();
                    swartReport.SCAA = ucSelectColumn.GetSelectedItemForQuerySql();
                    swartReport.SC = ucSelectColumn.GetSelectedItem();
                    new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().Update(swartReport);
                    ConfReportsList();
                    Routines.ShowInfoMessageFa("تغییر گزارش",
                                               string.Format("تغییرات گزارش {0} با موفقیت ثبت شد", swartReport.ReportName),
                                               MyDialogButton.OK);
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(false, "در هنگام ذخیره اطلاعات خطا رخ داده است");
            }
        }

        private void trnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (trnReport.SelectedNodes.Count <= 0) return;
                var node = trnReport.SelectedNodes[0];
                var index = node.Key.ToLong();
                ReportId = index;
                var report = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataById(index).FirstOrDefault();
                ucSelectColumn.SetSelectedItem(report.SCAA);

                var filters = report.Filter.Replace("where", "").Trim().Split(new[] { "and" }, StringSplitOptions.RemoveEmptyEntries);

                bool STATE_ID = false,
                     BRANCH = false,
                     CONTRACT_TYPE = false,
                     ECONOMIC_SECTOR = false,
                     CUSTOMER_GROUP = false,
                     COUNTERPARTY_TYPE = false,
                     START_DATE = false,
                     MATURITY_DATE = false,
                     COUNTERPARTY = false,
                     STATUS = false;

                foreach (var filter in filters)
                {
                    #region Contract STATUS

                    if (filter.ToUpper().Contains("STATUS") && filter.ToUpper().Contains("_STATUS") == false)
                    {
                        ucContractStatus.SetSelectedItem(
                            filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                new[] { "STATUS =" }, StringSplitOptions.RemoveEmptyEntries));
                        STATUS = true;
                    }
                    else
                    {
                        if (STATUS == false)
                            ucContractStatus.ClearItem();
                    }

                    #endregion

                    #region START DATE

                    if (filter.ToUpper().Contains("STATE_ID"))
                    {
                        ucfState.SetSelectedItem(
                            filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                new[] { "STATE_ID =" }, StringSplitOptions.RemoveEmptyEntries));
                        STATE_ID = true;
                    }
                    else
                    {
                        if (STATE_ID == false)
                            ucfState.ClearItem();
                    }

                    #endregion

                    #region BRANCH

                    if (filter.ToUpper().Contains("BRANCH"))
                    {
                        ucfOrganization.SetSelectedItem(
                            filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                new[] { "BRANCH =" }, StringSplitOptions.RemoveEmptyEntries));
                        BRANCH = true;
                    }
                    else
                    {
                        if (BRANCH == false)
                            ucfOrganization.ClearItem();
                    }
                    #endregion


                    #region Contract Type

                    if (filter.ToUpper().Contains("CONTRACT_TYPE"))
                    {
                        ucfContractType.SetSelectedItem(
                            filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                new[] { "CONTRACT_TYPE =" }, StringSplitOptions.RemoveEmptyEntries));
                        ucFilteringContractTypeCode.SetSelectedItem(
                            filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                new[] { "CONTRACT_TYPE =" }, StringSplitOptions.RemoveEmptyEntries));
                        CONTRACT_TYPE = true;
                    }
                    else
                    {
                        if (CONTRACT_TYPE == false)
                        {
                            ucfContractType.ClearItem();
                            ucFilteringContractTypeCode.ClearItem();
                        }
                    }
                    #endregion

                    #region Currency

                    if (filter.ToUpper().Contains("ECONOMIC_SECTOR"))
                    {
                        ucEconomicSector.SetSelectedItem(
                            filter.ToUpper().Replace("(", "").Replace(")", "").Replace(" OR ", " ").Replace("'", "").Split(
                                new[] { "ECONOMIC_SECTOR =" }, StringSplitOptions.RemoveEmptyEntries));
                        ECONOMIC_SECTOR = true;
                    }
                    else
                    {
                        if (ECONOMIC_SECTOR == false)
                            ucEconomicSector.ClearItem();
                    }
                    #endregion

                    #region Customer Group

                    if (filter.ToUpper().Contains("CUSTOMER_GROUP"))
                    {
                        ucfCustomerGroup.SetSelectedItem(
                            filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                new[] { "CUSTOMER_GROUP =" }, StringSplitOptions.RemoveEmptyEntries));
                        CUSTOMER_GROUP = true;
                    }
                    else
                    {
                        if (CUSTOMER_GROUP == false)
                            ucfCustomerGroup.ClearItem();
                    }
                    #endregion

                    #region Counterparty Type

                    if (filter.ToUpper().Contains("COUNTERPARTY_TYPE"))
                    {
                        ucfCounterPartyType.SetSelectedItem(
                            filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                new[] { "COUNTERPARTY_TYPE =" }, StringSplitOptions.RemoveEmptyEntries));
                        COUNTERPARTY_TYPE = true;
                    }
                    else
                    {
                        if (COUNTERPARTY_TYPE == false)
                            ucfCounterPartyType.ClearItem();
                    }
                    #endregion

                    #region Start Date

                    if (filter.ToUpper().Contains("START_DATE"))
                    {
                        if (filter.ToUpper().Replace("START_DATE", "").Trim().Contains(">="))
                        {
                            fdpFromStartDate.SelectedDateTime =
                                Convert.ToDateTime(filter.ToUpper().Replace("START_DATE", "").Replace("'", "").Trim().Substring(2).Trim());
                        }

                        if (filter.ToUpper().Replace("START_DATE", "").Trim().Contains("<="))
                        {
                            fdpToStartDate.SelectedDateTime =
                                Convert.ToDateTime(filter.ToUpper().Replace("START_DATE", "").Replace("'", "").Trim().Substring(2).Trim());
                        }
                        chbStartDate.Checked = true;
                        START_DATE = true;
                    }
                    else
                    {
                        if (START_DATE == false)
                        {
                            chbStartDate.Checked = false;
                        }
                    }
                    #endregion

                    #region Maturity Date

                    if (filter.ToUpper().Contains("MATURITY_DATE"))
                    {
                        if (filter.ToUpper().Replace("MATURITY_DATE", "").Trim().Contains(">="))
                        {
                            fdpFromMaturityDate.SelectedDateTime =
                                Convert.ToDateTime(filter.ToUpper().Replace("MATURITY_DATE", "").Replace("'", "").Trim().Substring(2).Trim());
                        }

                        if (filter.ToUpper().Replace("MATURITY_DATE", "").Trim().Contains("<="))
                        {
                            fdpToMaturityDate.SelectedDateTime =
                                Convert.ToDateTime(filter.ToUpper().Replace("MATURITY_DATE", "").Replace("'", "").Trim().Substring(2).Trim());
                        }
                        chbMaturityDate.Checked = true;
                        MATURITY_DATE = true;
                    }
                    else
                    {
                        if (MATURITY_DATE == false)
                        {
                            chbMaturityDate.Checked = false;
                        }
                    }
                    #endregion

                    #region Counterparty
                    if (filter.ToUpper().Contains("COUNTERPARTY ="))
                    {
                        chbCounterparty.Checked = true;
                        txtCounterparty.Enabled = true;
                        txtCounterparty.Text =
                            filter.ToUpper().Replace("(", "").Replace(")", "").Replace("'", "").Trim().Substring(14).Trim();
                        var row = new DAL.DepositDataSetTableAdapters.CounterpartyTableAdapter().GetDataByCounterparty(
                            txtCounterparty.Text.Trim().ToInt()).FirstOrDefault();
                        txtCounterPartyName.Text = row.Name;
                        txtCounterPartyName.Tag = txtCounterparty.Text;
                        COUNTERPARTY = true;
                    }
                    else
                    {
                        if (COUNTERPARTY == false)
                        {
                            chbCounterparty.Checked = false;
                            txtCounterparty.Enabled = false;
                            txtCounterparty.Text = txtCounterPartyName.Text = "";
                        }
                    }
                    #endregion
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void btnNewReport_Click(object sender, EventArgs e)
        {
            ucSelectColumn.ClearSelectedColumn();
            txtCounterPartyName.Text = txtCounterparty.Text = "";
            txtCounterparty.Enabled = false;
            chbStartDate.Checked = chbMaturityDate.Checked = false;

            fdpToStartDate.ResetText();
            fdpToStartDate.UpdateTextValue();

            fdpToMaturityDate.ResetText();
            fdpToMaturityDate.UpdateTextValue();

            fdpFromStartDate.ResetText();
            fdpFromStartDate.UpdateTextValue();

            fdpFromMaturityDate.ResetText();
            fdpFromMaturityDate.UpdateTextValue();

            ucfOrganization.ClearItem();
            ucfState.ClearItem();
            ucfCustomerGroup.ClearItem();
            ucEconomicSector.ClearItem();
            ucfCounterPartyType.ClearItem();
            ucfContractType.ClearItem();
            ucContractStatus.ClearItem();
            ucFilteringContractTypeCode.ClearItem();
            ReportId = null;
        }

        private void btnRemoveReport_Click(object sender, EventArgs e)
        {
            if (trnReport.SelectedNodes.Count <= 0) return;
            if (Routines.ShowQuestionMessageFa("حذف گزارش", "آیا از حذف گزارش مطمئن هستید؟", MyDialogButton.YesNO) == MyDialogResoult.No)
                return;
            try
            {
                var key = trnReport.SelectedNodes[0].Key;
                var row = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataById(key.ToLong()).
                    FirstOrDefault();
                new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().Delete(row.Id);
                ConfReportsList();
            }
            catch (Exception exception)
            {
                exception.ConfigLog(false, "حذف گزارش انتخاب شده با خطا روبرو شد");
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            try
            {
                if (trnReport.SelectedNodes.Count <= 0) return;
                var chart = new CHART.frmChart
                {
                    ReportType = Resources.KEY_NameOfLoanComOverdueAndCollactVLReport,
                    MdiParent = MdiParent,
                    Report_Id = trnReport.SelectedNodes[0].Key.ToLong()
                };
                chart.Show();
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void chbCompareFilter_CheckedChanged(object sender, EventArgs e)
        {
            cmbCompareFilter.Enabled = chbCompareFilter.Checked;
        }

        private void ucfCity_DropDownOpening(object sender, EventArgs e)
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

        private void ucfOrganization_DropDownOpening_1(object sender, EventArgs e)
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
                if (ucfState.IsChecked()  && ucfState.GetSelectedItem().Count() > 0)
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
    }
}
