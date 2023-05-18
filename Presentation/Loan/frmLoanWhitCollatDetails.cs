using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DAL;
//
using Presentation.Public;
using Utilize.Helper;
using Utilize.Report;

namespace Presentation.Loan
{
    public partial class frmLoanWhitCollatDetails : Form
    {
        DataTable user;
        public frmLoanWhitCollatDetails()
        {
            
            InitializeComponent();
            cbCloseAll.TooltipText = "راهنما";
        }


        private void frmLoanWhitCollatDetails_Load(object sender, EventArgs e)
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

                var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                    "VLoanByCollactDetails");
                ucSselectColumn.NameOfDisplay = "AliasName";
                ucSselectColumn.NameOfValue = "NameColumn";
                ucSselectColumn.DataSource = columnsForShowInReport;




                #region Collateral

                var collatMajorType_DataTable = new DAL.Table_DataSetTableAdapters.Collat_Major_TypeTableAdapter().GetData();
                ucfCollatMajorType.DisplayMember = "Collat_Major_Type_Desc";
                ucfCollatMajorType.ValueMember = "Collat_Major_Type";
                ucfCollatMajorType.DataSource = collatMajorType_DataTable;
                ucfCollatMajorType.CheckedChanged += new EventHandler(ucfCollatMajorType_CheckedChanged);

                var collateral_TypeDataTable = new DAL.Table_DataSetTableAdapters.Collateral_TypeTableAdapter().GetData();
                ucfCollateralType.DisplayMember = "Collateral_Type_Desc";
                ucfCollateralType.ValueMember = "Collateral_Type";
                ucfCollateralType.DataSource = collateral_TypeDataTable;
                ucfCollateralType.DropDownOpening += new EventHandler(ucfCollateralType_DropDownOpening);

                var collateralStatus_DataTable = new DAL.Table_DataSetTableAdapters.Collateral_StatusTableAdapter().GetData();
                ucfCollateralStatus.DisplayMember = "Collat_Stat_Desc";
                ucfCollateralStatus.ValueMember = "Collat_Stat";
                ucfCollateralStatus.DataSource = collateralStatus_DataTable;

                #endregion

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


                //var contract_DataTable = new DAL.GeneralDataSetTableAdapters.Contract_TypeTableAdapter().GetDataByLoan();
                //var contract_Type_Group_DataTable = new DAL.GeneralDataSetTableAdapters.Contract_type_groupsTableAdapter().GetData();
                //ucfContractType.DisplayMember = "Contract_type_group_Desc";
                //ucfContractType.ValueMember = "Contract_type_group_id";
                //ucfContractType.DataSource = contract_Type_Group_DataTable;

                var contract_Type_Group_DataTable = new DAL.GeneralDataSetTableAdapters.ContractType().GetDT_ContractTypes(1);
                
                //Contract_type_groupsTableAdapter().GetData();

                ucfContractType.DisplayMember = "Contract_type_group_Desc";
                ucfContractType.ValueMember = "Contract_type_group_id";
                ucfContractType.DataSource = contract_Type_Group_DataTable;


                var contract_DataTable = new DAL.GeneralDataSetTableAdapters.Contract_TypeTableAdapter().GetDataByLoan();

                ucFilteringContractTypeCode.DisplayMember = "Contract_Type_Description";
                ucFilteringContractTypeCode.ValueMember = "Contract_Type";
                ucFilteringContractTypeCode.DataSource = contract_DataTable;


                //ucFilteringContractTypeCode.DisplayMember = "Contract_Type";
                //ucFilteringContractTypeCode.ValueMember = "Contract_Type";
                //ucFilteringContractTypeCode.DataSource = contract_DataTable;


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

                var contractStatusDataTable = new DAL.GeneralDataSetTableAdapters.Contract_StatusTableAdapter().GetData();
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

        private void ucfCollatMajorType_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucfCollatMajorType.IsChecked() && ucfCollatMajorType.GetSelectedItem().Count() > 0)
                {
                    var collateralTypeRows = new DAL.Table_DataSetTableAdapters.Collateral_TypeTableAdapter().GetData().Where(
                        colT =>
                            ucfCollatMajorType.GetSelectedItem().Any(
                            cmt => cmt.DataValue.ToString().Equals(colT.Collateral_Major_Type.ToString()))).ToArray();
                    ucfCollateralType.DisplayMember = "Collateral_Type_Desc";
                    ucfCollateralType.ValueMember = "Collateral_Type";
                    ucfCollateralType.DataSource = collateralTypeRows;
                }
                else
                {
                    var collateral_TypeDataTable = new DAL.Table_DataSetTableAdapters.Collateral_TypeTableAdapter().GetData();
                    ucfCollateralType.DisplayMember = "Collateral_Type_Desc";
                    ucfCollateralType.ValueMember = "Collateral_Type";
                    ucfCollateralType.DataSource = collateral_TypeDataTable;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void ucfCollateralType_DropDownOpening(object sender, EventArgs e)
        {
            try
            {
                if (ucfCollatMajorType.IsChecked() && ucfCollatMajorType.GetSelectedItem().Count() > 0)
                {
                    var collateralTypeRows = new DAL.Table_DataSetTableAdapters.Collateral_TypeTableAdapter().GetData().Where(
                        ct =>
                            ucfCollatMajorType.GetSelectedItem().Any(
                            cmt => cmt.DataValue.ToString().Equals(ct.Collateral_Major_Type.ToString()))).ToArray();
                    ucfCollateralType.DisplayMember = "Collateral_Type_Desc";
                    ucfCollateralType.ValueMember = "Collateral_Type";
                    ucfCollateralType.DataSource = collateralTypeRows;
                }
                else
                {
                    var collateralTypeRows = new DAL.Table_DataSetTableAdapters.Collateral_TypeTableAdapter().GetData();
                    ucfCollateralType.DisplayMember = "Collateral_Type_Desc";
                    ucfCollateralType.ValueMember = "Collateral_Type";
                    ucfCollateralType.DataSource = collateralTypeRows;
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

        private void ucfOrganization_DropDownOpening(object sender, EventArgs e)
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

        private string GetFilter()
        {
            try
            {
                var fill_CollateralStatus = ucfCollateralStatus.GetFilterStructureForSql();
                var fill_CollateralType = ucfCollateralType.GetFilterStructureForSql();
                var fill_CollatMajorType = ucfCollatMajorType.GetFilterStructureForSql();
                var fil_State = ucfState.GetFilterStructureForSql();
                var fil_Organization = ucfOrganization.GetFilterStructureForSql();
                var fil_CustomerGroup = ucfCustomerGroup.GetFilterStructureForSql();
                var fil_CounterpartyType = ucfCounterPartyType.GetFilterStructureForSql();
                var fil_ContractType = ucfContractType.GetFilterStructureForSql();
                var fil_EconomicSector = ucEconomicSector.GetFilterStructureForSql();
                var fil_ContractTypeCode = ucFilteringContractTypeCode.GetFilterStructureForSql();
                var fil_ContractStatus = ucContractStatus.GetFilterStructureForSql();

                #region Add By Aliz
                var fil_City = ucfCity.GetFilterStructureForSql();
                #endregion

                var fil_Counterparty = "";
                if (chbCounterparty.Checked)
                {
                    var item = txtCounterPartyName.Tag;
                    fil_Counterparty += fil_Counterparty.Trim().Length == 0
                                            ? "(Counterparty = " + item + " "
                                            : " OR Counterparty = " + item;
                    if (fil_Counterparty.Trim().IsNullOrEmptyByTrim() == false)
                        fil_Counterparty += ")";
                }

                var fil_StartDate = "";
                if (chbStartDate.Checked)
                {
                    if (fdpFromStartDate.Text.Trim().Length != 0)
                        fil_StartDate += " Start_Date>='" + fdpFromStartDate.SelectedDateTime.ToString("yyyy-MM-dd") + "' ";
                    if (fdpToStartDate.Text.Trim().Length != 0)
                    {
                        if (fil_StartDate.Trim().Length != 0) fil_StartDate += " and ";
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
                        if (fil_MaturityDate.Trim().Length != 0) fil_MaturityDate += " and ";
                        fil_MaturityDate += " Maturity_Date <='" + fdpToMaturityDate.SelectedDateTime.ToString("yyyy-MM-dd") + "' ";
                    }
                }

                var filter = "";


                if (fil_EconomicSector.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_EconomicSector;
                }

                if (fil_ContractStatus.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_ContractStatus;
                }

                if (fil_Counterparty.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_Counterparty;
                }

                if (fil_CounterpartyType.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_CounterpartyType;
                }

                if (fil_ContractType.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_ContractType;
                }

                if (fil_ContractTypeCode.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_ContractTypeCode;
                }


                if (fil_CustomerGroup.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_CustomerGroup;
                }

                if (fil_Organization.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_Organization;
                }
                else if (user.Rows.Count != 0 && !(chbCustCodeName.Checked &&
                                                    (dgvCounterpartiesNames.Rows.Count > 0 ||
                                                        (txtCounterPartyName.Text.Length > 0 && !txtCounterPartyName.Text.Equals("مشتری با این مشخصات وجود ندارد")))))
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



                if (fil_State.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_State;
                }
                else if (user.Rows.Count != 0 && !(chbCustCodeName.Checked &&
                                                    (dgvCounterpartiesNames.Rows.Count > 0 ||
                                                        (txtCounterPartyName.Text.Length > 0 && !txtCounterPartyName.Text.Equals("مشتری با این مشخصات وجود ندارد")))))
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
                if (user.Rows.Count != 0 && !(chbCustCodeName.Checked &&
                                                    (dgvCounterpartiesNames.Rows.Count > 0 ||
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

                    //if (filter.Trim().Length != 0) filter += " and ";
                    //filter += fil;
                }

                #endregion


                if (fil_StartDate.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_StartDate;
                }

                if (fil_MaturityDate.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_MaturityDate;
                }

                if (fill_CollatMajorType.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fill_CollatMajorType;
                }

                if (fill_CollateralStatus.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fill_CollateralStatus;
                }

                if (fill_CollateralType.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fill_CollateralType;
                }

                var fil_CounterParties = "";
                if (dgvCounterpartiesNames.Rows.Count > 0 && txtCounterpartyNameSearch.Text.Length > 0)
                {
                    var item = txtCounterPartyName.Tag;

                    foreach (DataGridViewRow dgvRow in dgvCounterpartiesNames.Rows)
                    {
                        if (fil_CounterParties.Trim().Length != 0) fil_CounterParties += " or ";
                        fil_CounterParties += "Counterparty = " + dgvRow.Cells[1].Value.ToString();
                    }

                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_CounterParties;
                }

                if (filter.IsNullOrEmptyByTrim())
                    filter += " Historic_date ='" + fdpHistoricDate.SelectedDateTime.ToString("yyyy-MM-dd")+"'";
                else
                    filter += " and Historic_date ='" + fdpHistoricDate.SelectedDateTime.ToString("yyyy-MM-dd")+"'";

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

        private void btnShowNormalReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (ucSselectColumn.GetSelectedItem().Count() < 1)
                {
                    Utilize.Routines.ShowInfoMessageFa("خطا", "هیچ ستونی برای نمایش انتخاب نشده است", Utilize.MyDialogButton.OK);
                    return;
                }

                if (fdpHistoricDate.IsNull)
                {
                    Utilize.Routines.ShowInfoMessageFa("خطا", "هیچ تاریخی انتخاب نشده است", Utilize.MyDialogButton.OK);
                    return;
                }

                ProgressBox.Show();
                var filter = GetFilter();

                LoanDataSet ld = new LoanDataSet();

                var KEY_Name_COLUMN_COLLAT_NO_IN_REPORT_TABLE = "اطلاعات تسهیلات وثیقه";// "Collat_No";
                var KEY_Name_COLUMN_BRANCH_IN_REPORT_TABLE = "کد شعبه";// "Branch";

                ld.PrepareCollateralData(fdpHistoricDate.SelectedDateTime);

                var report = new LoanDataSet().GetCollateralWhitFilter(ucSselectColumn.GetSelectedItemForQuerySql(), filter, "1", "1000000");
                //GetLoanReportWhitCollateralDetailsByPaging(ucSselectColumn.GetSelectedItem(), 
                //ucSselectColumn.GetSelectedItemForQuerySql(), filter, "1", "1000000" );

                //ProgressBox.Hide();
                //var frmShowReprt = new Report.frmShowReprt(report) { SCA = ucSselectColumn.GetSelectedItem(), SCAA = ucSselectColumn.GetSelectedItemForQuerySql(), F = filter, TN = "VLoanByCollactDetails" };
                //frmShowReprt.ShowDialog();
                //return;

                if (report.Columns.Contains(KEY_Name_COLUMN_COLLAT_NO_IN_REPORT_TABLE) && !report.Columns.Contains(KEY_Name_COLUMN_BRANCH_IN_REPORT_TABLE) && !report.Columns.Contains("شماره وثیقه"))
                {
                    Routines.ShowMessageBoxFa("برای نمایش اطلاعات تسهیلات مربوط به وثیقه، لازم است که شعبه و شماره وثیقه نیز انتخاب شود", "خطا در فیلدهای انتخابی"
                        , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (report.Columns.Contains(KEY_Name_COLUMN_COLLAT_NO_IN_REPORT_TABLE) && report.Columns.Contains(KEY_Name_COLUMN_BRANCH_IN_REPORT_TABLE) && report.Columns.Contains("شماره وثیقه"))
                {
                    var _loanByCollatDataTable = new LoanDataSet().GetLoanByCollat(fdpHistoricDate.SelectedDateTime);
                    foreach (DataRow dr in report.Rows)
                    {
                        int ii = 1;
                        var ds = _loanByCollatDataTable.AsEnumerable().Where(s => s["Collat_No"].ToString() == dr[KEY_Name_COLUMN_COLLAT_NO_IN_REPORT_TABLE].ToString() &&
                                                                                s["Branch"].ToString() == dr[KEY_Name_COLUMN_BRANCH_IN_REPORT_TABLE].ToString());
                        foreach (DataRow dr2 in ds)
                        {
                            if (ii > 21)
                                break;
                            if (!report.Columns.Contains("تسهیلات " + ii.ToString()))
                                report.Columns.Add("تسهیلات " + ii.ToString());
                            dr["تسهیلات " + ii.ToString()] = System.Convert.ToString(dr2["Contract"]);

                            //if (!report.Columns.Contains("شماره انتظامی " + ii.ToString()))
                            //    report.Columns.Add("شماره انتظامی " + ii.ToString());
                            //dr["شماره انتظامی  " + ii.ToString()] = System.Convert.ToString(dr2["EntezamiNo"]);

                            if (!report.Columns.Contains("مبلغ تخصیصی به تسهیلات " + ii.ToString()))
                                report.Columns.Add("مبلغ تخصیصی به تسهیلات " + ii.ToString());
                            dr["مبلغ تخصیصی به تسهیلات " + ii.ToString()] = System.Convert.ToString(dr2["Collat_Value_Allocated"]);

                            if (!report.Columns.Contains("تاریخ تخصیصی تسهیلات " + ii.ToString()))
                                report.Columns.Add("تاریخ تخصیصی تسهیلات " + ii.ToString());
                            dr["تاریخ تخصیصی تسهیلات " + ii.ToString()] = System.Convert.ToString(dr2["Collat_AllocationDate"]);
                            ii++;
                        }
                    }
                    //report.Columns.Remove("اطلاعات تسهیلات وثیقه");
                    report.Columns.Remove(KEY_Name_COLUMN_COLLAT_NO_IN_REPORT_TABLE);
                    //report.Columns.Remove("Branch");
                    //report.Columns.Remove("Collat_No");
                }

                ProgressBox.Hide();
                var frmShowReprt = new Report.frmShowReprt(report) { SCA = ucSselectColumn.GetSelectedItem(), SCAA = ucSselectColumn.GetSelectedItemForQuerySql(), F = filter, TN = "VLoanByCollactDetails" };
                frmShowReprt.ShowDialog();
            }
            catch (Exception exception)
            {
                ProgressBox.Hide();
                exception.ConfigLog(true);
            }
        }

        private void txtCounterparty_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            try
            {
                if (e.Button.Key == "Search")
                {
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
                        txtCounterPartyName.Text = "مشتری با این مشخصات وجود ندارد";
                        txtCounterPartyName.Tag = null;
                    }
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
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

        private void chbCustCodeName_CheckedChanged(object sender, EventArgs e)
        {
            cgbCustCodeName.Enabled = chbCustCodeName.Checked;
            if (!chbCustCodeName.Checked)
            {
                chbCounterparty.Checked = false;
                chbCounterpartyName.Checked = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtCounterparty.Enabled = chbCounterparty.Checked;
            txtCounterPartyName.Enabled = chbCounterparty.Checked;
            if (!chbCounterparty.Checked)
            {
                txtCounterparty.Text = "";
                txtCounterPartyName.Tag = null;
                txtCounterPartyName.Text = "";
            }
        }

        private void chbCounterpartyName_CheckedChanged(object sender, EventArgs e)
        {
            txtCounterpartyNameSearch.Enabled = chbCounterpartyName.Checked;
            cgbCouterpartName.Enabled = chbCounterpartyName.Checked;
            dgvCounterpartiesNames.Enabled = chbCounterpartyName.Checked;
            if (!chbCounterpartyName.Checked)
            {
                //dgvCounterpartiesNames.Rows.Clear();
                dgvCounterpartiesNames.DataSource = null;
                dgvCounterpartiesNames.Refresh();
                dgvCounterpartiesNames.Update();
                txtCounterpartyNameSearch.Text = string.Empty;
            }
        }

        private void txtCounterpartyNameSearch_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            try
            {
                if (e.Button.Key == "Search")
                {
                    if (txtCounterpartyNameSearch.Text.Trim().Length == 0)
                    {
                        Routines.ShowInfoMessageFa("خطا", "واژه معتبری برای نام مشتری وارد نشده است", MyDialogButton.OK);
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
                        txtCounterpartyNames.Text = "مشتری با این مشخصات وجود ندارد";
                        txtCounterpartyNames.Tag = null;
                        Routines.ShowInfoMessageFa("خطا", "موردی یافت نشد", MyDialogButton.OK);
                        return;
                    }

                    var frmSelCol = new frmSelectColumn(counterpartyNames, "Name", "Counterparty", "لیست مشتریان");

                    frmSelCol.ShowDialog();
                    if (frmSelCol.DialogResult == DialogResult.OK)
                    {
                        string SelectedCounterParties = frmSelCol.ReturnValue;

                        string[] SelectedCounterPartiesItems = SelectedCounterParties.Split(',');

                        DataTable dtSelectedCounterParties = new DataTable();
                        dtSelectedCounterParties.Columns.Add("Name", typeof(string));
                        dtSelectedCounterParties.Columns.Add("Counterparty", typeof(int));


                        foreach (string selectedCounterPartiesItem in SelectedCounterPartiesItems)
                        {
                            DataRow dr;
                            dr = dtSelectedCounterParties.NewRow();
                            dr["Name"] = selectedCounterPartiesItem.Split(':')[0].Replace("[", "");
                            dr["Counterparty"] = selectedCounterPartiesItem.Split(':')[1].Replace("]", "");
                            dtSelectedCounterParties.Rows.Add(dr);
                        }
                        dgvCounterpartiesNames.DataSource = dtSelectedCounterParties;
                        dgvCounterpartiesNames.Columns[1].Visible = false;
                        dgvCounterpartiesNames.Columns[0].Width = 400;
                        dgvCounterpartiesNames.Columns[0].HeaderText = "نام مشتری";

                        if (SelectedCounterParties.Length < 2)
                        {
                            Routines.ShowErrorMessageFa("خطا", "موردی انتخاب نشده است", MyDialogButton.OK);
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

        public string SafeFarsiStr(string input)
        {
            return input.Replace("ی", "ي").Replace("ک", "ك");
        }

        private void cbCloseAll_CButtonClicked(object sender, EventArgs e)
        {
            frmPDF frmpdf = new frmPDF("/CreditRiskPDF/frmLoanWhitCollatDetails.pdf");
            frmpdf.ShowDialog();
           
        }

        private void btnShowNormalReport_Load(object sender, EventArgs e)
        {

        }
    }
}
