using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DAL;
using Infragistics.Win.UltraWinTree;
using Utilize;
using Utilize.Helper;
using Utilize.Report;
using Resources = Presentation.Properties.Resources;
using System.Data;
using Presentation.Public;

namespace Presentation.Loan
{
    public partial class frmLoanReportCs : Form
    {
        private long? ReportId;
        DataTable user;
        private string _status;
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }

        public frmLoanReportCs()
        {
            InitializeComponent();

           cbCloseAll.TooltipText = "راهنما";

            try
            {
                
                   
                if (status == "Guarantee")
                {
                    chbStartDate.Text = "تاریخ شروع ضمانتنامه";
                    chbMaturityDate.Text = "تاریخ سررسید ضمانتنامه";
                }
                #region Collateral

                //var collatMajorType_DataTable= new DAL.Table_DataSetTableAdapters.Collat_Major_TypeTableAdapter().GetData();
                //ucfCollatMajorType.DisplayMember = "Collat_Major_Type_Desc";
                //ucfCollatMajorType.ValueMember = "Collat_Major_Type";
                //ucfCollatMajorType.DataSource = collatMajorType_DataTable;
                //ucfCollatMajorType.CheckedChanged+=new EventHandler(ucfCollatMajorType_CheckedChanged);

                //var collateral_TypeDataTable= new DAL.Table_DataSetTableAdapters.Collateral_TypeTableAdapter().GetData();
                //ucfCollateralType.DisplayMember ="Collateral_Type_Desc";
                //ucfCollateralType.ValueMember = "Collateral_Type";
                //ucfCollateralType.DataSource = collateral_TypeDataTable;
                //ucfCollateralType.DropDownOpening+=new EventHandler(ucfCollateralType_DropDownOpening);

                //var collateralStatus_DataTable= new DAL.Table_DataSetTableAdapters.Collateral_StatusTableAdapter().GetData();
                //ucfCollateralStatus.DisplayMember = "Collat_Stat_Desc";
                //ucfCollateralStatus.ValueMember = "Collat_Stat";
                //ucfCollateralStatus.DataSource = collateralStatus_DataTable;

                #endregion

                #region State And Organization

                // تابع برای تنظیم لیست شهر ها زمانی که نمایش داده می شود
                ucfCity.DropDownOpening += (ucfCity_DropDownOpening);

                ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;


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


                    //تنظیمات فیلتر بندی شهر
                    var cityDataTable = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData();
                    ucfCity.DisplayMember = "City_Name";
                    ucfCity.ValueMember = "City_ID";
                    ucfCity.DataSource = cityDataTable;

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

                    //تنظیمات فیلتر بندی شهر
                    var cityDataTable = user.Rows.Cast<DataRow>().Select(item => new { City_ID = item["City_ID"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray();
                    ucfCity.DisplayMember = "City_Name";
                    ucfCity.ValueMember = "City_ID";
                    ucfCity.DataSource = cityDataTable;

                }

                #endregion



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
             
            }
            catch (Exception exception)
            {
                exception.ConfigLog(false, "خطا در بارگزاری داده رخ");
                Close();
            }
        }


        /// <summary>
        /// تابع برای تنظیم لیست شهر ها زمانی که نمایش داده می شود
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ucfCity_DropDownOpening(object sender, EventArgs e)
        {
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
        }

        void ucfCollatMajorType_CheckedChanged(object sender, EventArgs e)
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

        void ucfCollateralType_DropDownOpening(object sender, EventArgs e)
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

        /// <summary>
        /// تنظیم نمایش لیست شعبه ها با توجه به فیلتر های انتخاب شده استان و شهر
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private string GetFilter()
        {
            try
            {
                bool isColl_Filter = false;
                var coll_Filter = "";
                if (status == "Loan")

                    coll_Filter =
                        "(select count(*) from Collateral,Collat_Major_Type,Collateral_Type,Collateral_Status " +
                        " where Collateral.Collat_Status=Collateral_Status.Collat_Stat and Collateral.Collat_Type=Collateral_Type.Collateral_Type and" +
                        " Collateral_Type.Collateral_Major_Type=Collat_Major_Type.Collat_Major_Type and " +
                        " Collateral.Contract = VLReport.Contract ";

                else if (status == "Guarantee")

                    coll_Filter =
                           "(select count(*) from Collateral,Collat_Major_Type,Collateral_Type,Collateral_Status " +
                           " where Collateral.Collat_Status=Collateral_Status.Collat_Stat and Collateral.Collat_Type=Collateral_Type.Collateral_Type and" +
                           " Collateral_Type.Collateral_Major_Type=Collat_Major_Type.Collat_Major_Type and " +
                           " Collateral.Contract = VGReport.Contract ";

                var fill_CollateralStatus = ucfCollateralStatus.GetFilterStructureForSql();
                if (fill_CollateralStatus.IsNullOrEmptyByTrim() == false)
                {
                    isColl_Filter = true;
                    coll_Filter = coll_Filter + " and " + fill_CollateralStatus;
                }

                var fill_CollateralType = ucfCollateralType.GetFilterStructureForSql();
                if (fill_CollateralType.IsNullOrEmptyByTrim() == false)
                {
                    isColl_Filter = true;
                    coll_Filter = coll_Filter + " and " + fill_CollateralType;
                }
                var fill_CollatMajorType = ucfCollatMajorType.GetFilterStructureForSql();
                if (fill_CollatMajorType.IsNullOrEmptyByTrim() == false)
                {
                    isColl_Filter = true;
                    coll_Filter = coll_Filter + " and " + fill_CollatMajorType;
                }



                var fil_State = ucfState.GetFilterStructureForSql();

                #region Add By Aliz
                var fil_City = ucfCity.GetFilterStructureForSql();
                #endregion

                var fil_Organization = ucfOrganization.GetFilterStructureForSql();

                var fil_CustomerGroup = ucfCustomerGroup.GetFilterStructureForSql();

                var fil_CounterpartyType = ucfCounterPartyType.GetFilterStructureForSql();

                var fil_ContractType = ucfContractType.GetFilterStructureForSql();

                var fil_EconomicSector = ucEconomicSector.GetFilterStructureForSql();

                var fil_ContractTypeCode = ucFilteringContractTypeCode.GetFilterStructureForSql();

                var fil_ContractStatus = ucContractStatus.GetFilterStructureForSql();

                var fil_Nationality = ucNationality.GetFilterStructureForSql();

                var fil_Counterparty = "";
                if (chbCounterparty1.Checked && txtCounterPartyName.Tag != null && txtCounterPartyName.Tag.ToString().Length > 0)
                {
                    var item = txtCounterPartyName.Tag;
                    fil_Counterparty += fil_Counterparty.Trim().Length == 0
                                            ? "(Counterparty = " + item + " "
                                            : " OR Counterparty = " + item;
                    if (fil_Counterparty.Trim().IsNullOrEmptyByTrim() == false)
                        fil_Counterparty += ")";
                }

                var fil_DepNo = "";
                if (chbDepNo.Checked && txtDepNoName.Tag != null && txtDepNoName.Tag.ToString().Length > 0)
                {
                    var item = txtDepNoName.Tag;
                    if (status == "Loan")
                        fil_DepNo += fil_DepNo.Trim().Length == 0
                                            ? "(VLReport_Historic.Contract = " + item + " "
                                            : " OR VLReport_Historic.Contract = " + item;

                    else if (status == "Guarantee")
                        fil_DepNo += fil_DepNo.Trim().Length == 0
                                            ? "(VGReport_Historic.Contract = " + item + " "
                                            : " OR VGReport_Historic.Contract = " + item;

                    if (fil_DepNo.Trim().IsNullOrEmptyByTrim() == false)
                        fil_DepNo += ")";
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

                if (fil_DepNo.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_DepNo;
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

                if (fil_StartDate.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_StartDate;
                }

                if (fil_CustomerGroup.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_CustomerGroup;
                }


                if (fil_MaturityDate.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_MaturityDate;
                }

                if (fil_Nationality.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_Nationality;
                }

                if (fil_Organization.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_Organization;
                }
                // Pass the Branch Filteration
                else if (user.Rows.Count != 0 && !(chbCustCodeName.Checked &&
                                                    (dgvCounterpartiesNames.Rows.Count > 0 ||
                                                        (txtDepNoName.Text.Length > 0 && txtDepNoName.Tag != null) ||
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
                                                        (txtDepNoName.Text.Length > 0 && txtDepNoName.Tag != null) ||
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
                else if (user.Rows.Count != 0 && !(chbCustCodeName.Checked &&
                                                    (dgvCounterpartiesNames.Rows.Count > 0 ||
                                                    (txtDepNoName.Text.Length > 0 && txtDepNoName.Tag != null) ||
                                                        (txtCounterPartyName.Text.Length > 0 && !txtCounterPartyName.Text.Equals("مشتری با این مشخصات وجود ندارد")))))
                {
                    string fil = "";
                    var cityNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { City_Id = item["City_Id"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray();
                    foreach (var item in cityNew_DataTable)
                    {

                        fil += fil.Trim().Length == 0
                            ? "(City_Id = " + "'" + item.City_Id.Trim() + "' "
                                                    : " OR City_Id = '" + item.City_Id.Trim() + "' ";

                    }
                    if (fil.Trim().IsNullOrEmptyByTrim() == false)
                        fil += ")";

                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil;
                }

                #endregion

                if (isColl_Filter)
                {
                    coll_Filter = coll_Filter + ")<>0 ";
                    if (filter.IsNullOrEmptyByTrim() == false) filter += " and ";
                    filter += coll_Filter;
                }

                var fil_CounterParties = "";
                if (dgvCounterpartiesNames.DataSource != null && dgvCounterpartiesNames.Rows.Count > 0 && txtCounterpartyNameSearch.Text.Length > 0)
                {
                    var item = txtCounterPartyName.Tag;

                    foreach (DataGridViewRow dgvRow in dgvCounterpartiesNames.Rows)
                    {
                        if (fil_CounterParties.Trim().Length != 0) fil_CounterParties += " or ";
                        fil_CounterParties += "Counterparty = " + dgvRow.Cells[1].Value.ToString();
                    }

                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += " ( " + fil_CounterParties + " ) ";
                }
                if (radioButton1.Checked)
                {
                    //nothing :)))))
                }
                else if(radioButton2.Checked)
                if (filter == "" || !((filter.Length) > 0)) filter += "(VLReport_Historic.Resource_ID is null)";
                    else filter += "And (VLReport_Historic.Resource_ID is null)";
                else if (radioButton3.Checked)
                    if (filter == "" || !((filter.Length) > 0)) filter += "(VLReport_Historic.Resource_ID is not null)";
                    else filter += "And (VLReport_Historic.Resource_ID is not null)";


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

        private string GetOrderBy()
        {
            var fil_OrderBy = "";
            if (chbOrderBy.Checked && cmbOrderBy.SelectedIndex != -1)
            {
                fil_OrderBy += " " + cmbOrderBy.SelectedValue.ToString() +
                        (rdbAsc.Checked
                                        ? " asc "
                                        : " desc ");
            }
            else
            {
                fil_OrderBy += " Contract ";
            }
            return fil_OrderBy;
        }

        private void frmDepositReportcs_Load(object sender, EventArgs e)
        {
            try
            {
                fdpHistoricDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate();
                tabMain.TabPages[4].TabVisible = false;
                tabMain.TabPages[5].TabVisible = false;
                tabMain.TabPages[6].TabVisible = false;

                if (status.ToUpper().Equals(KEY_LOAN))
                {
                    var contract_Type_Group_DataTable = new DAL.GeneralDataSetTableAdapters.ContractType().GetDT_ContractTypes(1);
                    //Contract_type_groupsTableAdapter().GetData();

                    ucfContractType.DisplayMember = "Contract_type_group_Desc";
                    ucfContractType.ValueMember = "Contract_type_group_id";
                    ucfContractType.DataSource = contract_Type_Group_DataTable;
                }
                else if (status.ToUpper().Equals(KEY_GUARANTEE))
                {
                    // 3 => Guarantee
                    var contract_Type_Group_DataTable = new DAL.GeneralDataSetTableAdapters.ContractType().GetDT_ContractTypes(3);

                    ucfContractType.DisplayMember = "Contract_type_group_Desc";
                    ucfContractType.ValueMember = "Contract_type_group_id";
                    ucfContractType.DataSource = contract_Type_Group_DataTable;

                    chbStartDate.Text = "تاریخ شروع ضمانتنامه";
                    chbMaturityDate.Text = "تاریخ سررسید ضمانتنامه";
                }

                if (status.ToUpper().Equals(KEY_LOAN))
                {
                    var contract_DataTable = new DAL.GeneralDataSetTableAdapters.Contract_TypeTableAdapter().GetDataByLoan();

                    ucFilteringContractTypeCode.DisplayMember = "Contract_Type_Description";
                    ucFilteringContractTypeCode.ValueMember = "Contract_Type";
                    ucFilteringContractTypeCode.DataSource = contract_DataTable;

                }
                else if (status.ToUpper().Equals(KEY_GUARANTEE))
                {
                    var Gcontract_DataTable = new DAL.GeneralDataSetTableAdapters.Contract_TypeTableAdapter().GetDataByGuarantee();

                    ucFilteringContractTypeCode.DisplayMember = "Contract_Type_Description";
                    ucFilteringContractTypeCode.ValueMember = "Contract_Type";
                    ucFilteringContractTypeCode.DataSource = Gcontract_DataTable;

                }

                if (status.ToUpper().Equals(KEY_LOAN))
                {
                    var contractStatusDataTable = new DAL.GeneralDataSetTableAdapters.Contract_StatusTableAdapter().GetData();
                    ucContractStatus.DisplayMember = "Status_desc";
                    ucContractStatus.ValueMember = "Status";
                    ucContractStatus.DataSource = contractStatusDataTable;
                }
                else if (status.ToUpper().Equals(KEY_GUARANTEE))
                {
                    var contractStatusDataTable = new DAL.GeneralDataSetTableAdapters.ContractType().GetDT_GuaranteeStatus();
                    ucContractStatus.DisplayMember = "LG_M_desc";
                    ucContractStatus.ValueMember = "LG_M_Id";
                    ucContractStatus.DataSource = contractStatusDataTable;
                }

                if (status.ToUpper().Equals(KEY_LOAN))
                {
                    var contract_DataTable = new DAL.GeneralDataSetTableAdapters.Contract_TypeTableAdapter().GetDataByLoan();

                    ucFilteringContractTypeCode.DisplayMember = "Contract_Type_Description";
                    ucFilteringContractTypeCode.ValueMember = "Contract_Type";
                    ucFilteringContractTypeCode.DataSource = contract_DataTable;

                }
                else
                    if (status.ToUpper().Equals(KEY_GUARANTEE))
                    {
                        var Gcontract_DataTable = new DAL.GeneralDataSetTableAdapters.Contract_TypeTableAdapter().GetDataByGuarantee();
                        ucFilteringContractTypeCode.DisplayMember = "Contract_Type_Description";
                        ucFilteringContractTypeCode.ValueMember = "Contract_Type";
                        ucFilteringContractTypeCode.DataSource = Gcontract_DataTable;
                    }

                FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

                fdpFromStartDate.SelectedDateTime = DateTime.Now;
                fdpFromStartDate.ResetSelectedDateTime();

                fdpToStartDate.SelectedDateTime = DateTime.Now.AddDays(1);
                fdpToStartDate.ResetSelectedDateTime();

                fdpFromMaturityDate.SelectedDateTime = DateTime.Now;
                fdpFromMaturityDate.ResetSelectedDateTime();

                fdpToMaturityDate.SelectedDateTime = DateTime.Now.AddDays(1);
                fdpToMaturityDate.ResetSelectedDateTime();

                SetColumns();

                //if (status.ToUpper().Equals(KEY_LOAN))
                //{
                //    var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                //        Resources.KEY_NameOfLoanReport);
                //    ucSelectColumn.NameOfDisplay = "AliasName";
                //    ucSelectColumn.NameOfValue = "NameColumn";
                //    ucSelectColumn.DataSource = columnsForShowInReport;
                //    ConfReportsList();
                //}
                //else if (status.ToUpper().Equals(KEY_GUARANTEE))
                //{
                //    var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                //       Resources.KEY_NameOfGuaranteeReport);
                //    ucSelectColumn.NameOfDisplay = "AliasName";
                //    ucSelectColumn.NameOfValue = "NameColumn";
                //    ucSelectColumn.DataSource = columnsForShowInReport;
                //    ConfReportsList();
                //}
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void ConfReportsList()
        {
            if (status.ToUpper().Equals(KEY_LOAN))
            {
                try
                {
                    trnReport.Nodes.Clear();
                    var reportsTable = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetData().Where(item => item.IsUser_IdNull() == false && item.User_Id.Equals(ERMS.Model.GlobalInfo.UserID) && (item.ReportTable.Equals(KEY_VIEW_LOAN_HISTORIC) || item.ReportTable.Equals(KEY_VIEW_LOAN_HISTORIC))).ToList();
                    //    GetDataByReportTable(rdbDate_Historic.Checked ? KEY_VIEW_LOAN_HISTORIC : KEY_VIEW_LOAN, ERMS.Model.GlobalInfo.UserID);
                    reportsTable.ForEach(item => trnReport.Nodes.Add(new UltraTreeNode(item.Id.ToString(), item.ReportName)));
                }
                catch (Exception exception)
                {
                    exception.ConfigLog();
                }
            }
            else if (status.ToUpper().Equals(KEY_GUARANTEE))
            {
                try
                {
                    trnReport.Nodes.Clear();
                    //var reportsTable = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataByReportTable(rdbDate_Historic.Checked ? KEY_VIEW_GUARANTEE_HISTORIC : KEY_VIEW_GUARANTEE_HISTORIC, ERMS.Model.GlobalInfo.UserID);
                    var reportsTable = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetData().Where(item => item.IsUser_IdNull() == false && item.User_Id.Equals(ERMS.Model.GlobalInfo.UserID) && (item.ReportTable.Equals(KEY_VIEW_GUARANTEE_HISTORIC) || item.ReportTable.Equals(KEY_VIEW_GUARANTEE_HISTORIC)));
                    reportsTable.ForEach(item => trnReport.Nodes.Add(new UltraTreeNode(item.Id.ToString(), item.ReportName)));
                }
                catch (Exception exception)
                {
                    exception.ConfigLog();
                }
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

        private void chbCounterparty_CheckedChanged(object sender, EventArgs e)
        {
            txtCounterparty.Enabled = chbCounterparty1.Checked;
        }

        private void btnShowNormalReport_Click(object sender, EventArgs e)
        {
            try
            {
                
                ucSelectColumn.SetaItemSelected("کد نوع قرارداد");
                ucSelectColumn.SetaItemDisable("کد نوع قرارداد");
                var fil_HistoricDate = "";
                if (rdbDate_Historic.Checked)
                {
                    if (fdpHistoricDate.Text.Equals("[هیج مقداری انتخاب نشده]") || fdpHistoricDate.Text.Trim().Length == 0)
                    {
                        Utilize.Routines.ShowInfoMessageFa("خطا", "تاریخ معتبر وارد نشده است", Utilize.MyDialogButton.OK);
                        return;
                    }
                    else
                        fil_HistoricDate += fdpHistoricDate.SelectedDateTime.ToString("yyyy-MM-dd");
                }

                if (ucSelectColumn.GetSelectedItem().Count() < 1)
                {
                    Utilize.Routines.ShowInfoMessageFa("خطا", "هیچ ستونی برای نمایش انتخاب نشده است", Utilize.MyDialogButton.OK);
                    return;
                }


                //if (!ucSelectColumn.GetSelectedItem().Contains("کد نوع قرارداد") || !ucSelectColumn.GetSelectedItem().Contains("تاریخ ثبت قرارداد"))
                //{
                //    Presentation.Public.MyMessageBox.ShowMessage("خطا در ترتیب انتخاب ستونها",
                //        ".ستون «کد نوع قرارداد» و «تاریخ ثبت قرارداد» نیز باید انتخاب شود",
                //        Presentation.Public.MyDialogButton.OK, Presentation.Public.MyDialogIcon.Error, true);
                //    return;
                //}
                ProgressBox.Show();
                var filter = GetFilter();
                if (rdbDate_Today.Checked && status.ToUpper().Equals(KEY_LOAN))
                {
                    var report = new LoanDataSet().GetLoanReportByPaging(ucSelectColumn.GetSelectedItem(),
                                                                         ucSelectColumn.GetSelectedItemForQuerySql(),
                                                                         filter,
                                                                         Resources.StartIndexForReportShow,
                                                                         Resources.MaxSizeOfRowForReport);
                   
                    if (report.Columns.Contains("وثایق تسهیلات") )
                    {

                        //ucSelectColumn.SetaItemSelected("کد نوع قرارداد");
                        //ucSelectColumn.SetaItemDisable("کد نوع قرارداد");

                        var t = new DAL.Counterparty_DataSet().GetCollatByContract(rdbDate_Historic.Checked, filter, Resources.StartIndexForReportShow, Resources.MaxSizeOfRowForReport);
                       
                        foreach (DataRow dr in report.Rows)
                        {
                            int ii = 1;
                            var ds = t.AsEnumerable().Where(s => s.Field<string>("contract") == dr["وثایق تسهیلات"].ToString());
                            foreach (DataRow dr2 in ds)
                            {
                                if (ii > 9)
                                    break;
                                if (!report.Columns.Contains("وثیقه " + ii.ToString()))
                                    report.Columns.Add("وثیقه " + ii.ToString());
                                dr["وثیقه " + ii.ToString()] = dr2["Collateral_Type_Desc"];
                                if (!report.Columns.Contains("مبلغ وثیقه " + ii.ToString()))
                                    report.Columns.Add("مبلغ وثیقه " + ii.ToString());
                                dr["مبلغ وثیقه " + ii.ToString()] = dr2["Collat_Value"];
                                ii++;
                            }
                        }
                        report.Columns.Remove("وثایق تسهیلات");
                    }

                    ProgressBox.Hide();
                    var frmShowReprt = new Report.frmShowReprt(report)
                                           {
                                               SCA = ucSelectColumn.GetSelectedItem(),
                                               SCAA = ucSelectColumn.GetSelectedItemForQuerySql(),
                                               F = filter,
                                               TN = Resources.KEY_NameOfLoanReport
                                           };
                    frmShowReprt.ShowDialog();
                    return;
                }

                else if (rdbDate_Historic.Checked && status.ToUpper().Equals(KEY_LOAN))
                {
                    if (filter.Length > 0)
                    {
                        filter = filter + " and VLReport_Historic.Historic_Date = cast('" + fil_HistoricDate +
                                 "'as datetime) ";
                        //filter += " and col.HisDate = cast('" + fil_HistoricDate + "'as datetime) ";
                    }
                    else
                    {
                        filter = " where VLReport_Historic.Historic_Date = cast('" + fil_HistoricDate + "'as datetime) ";
                        //filter += " and col.HisDate = cast('" + fil_HistoricDate + "'as datetime) ";
                    }

                    var report = new LoanDataSet().GetLoanReportHistoricByPaging(ucSelectColumn.GetSelectedItem(),
                                                                         ucSelectColumn.GetSelectedItemForQuerySql(),
                                                                         filter,
                                                                         GetOrderBy(),
                                                                         Resources.StartIndexForReportShow,
                                                                         Resources.MaxSizeOfRowForReport);

                    if (report.Columns.Contains("وثایق تسهیلات") )
                    {

                        var t = new DAL.Counterparty_DataSet().GetCollatByContract(rdbDate_Historic.Checked, filter, Resources.StartIndexForReportShow, Resources.MaxSizeOfRowForReport);
                        foreach (DataRow dr in report.Rows)
                        {
                            int ii = 1;
                            var ds = t.AsEnumerable().Where(s => s.Field<string>("contract") == dr["وثایق تسهیلات"].ToString());
                            foreach (DataRow dr2 in ds)
                            {
                                if (ii > 9)
                                    break;
                                if (!report.Columns.Contains("وثیقه " + ii.ToString()))
                                    report.Columns.Add("وثیقه " + ii.ToString());
                                dr["وثیقه " + ii.ToString()] = dr2["Collateral_Type_Desc"];
                                if (!report.Columns.Contains("مبلغ وثیقه " + ii.ToString()))
                                    report.Columns.Add("مبلغ وثیقه " + ii.ToString());
                                dr["مبلغ وثیقه " + ii.ToString()] = dr2["Collat_Value"];
                                ii++;
                            }
                        }
                        report.Columns.Remove("وثایق تسهیلات");
                    }

                    ProgressBox.Hide();
                    var frmShowReprt = new Report.frmShowReprt(report)
                    {
                        SCA = ucSelectColumn.GetSelectedItem(),
                        SCAA = ucSelectColumn.GetSelectedItemForQuerySql(),
                        F = filter,
                        OrderBy = GetOrderBy(),
                        TN = Resources.KEY_NameOfLoanReport
                    };
                    frmShowReprt.ShowDialog();
                    return;
                }
                else if (rdbDate_Today.Checked && status.ToUpper().Equals(KEY_GUARANTEE))
                {
                    var report = new LoanDataSet().GetReportByPaging(KEY_VIEW_GUARANTEE_HISTORIC, ucSelectColumn.GetSelectedItem(),
                                                                         ucSelectColumn.GetSelectedItemForQuerySql(),
                                                                         filter,
                                                                         GetOrderBy(),
                                                                         Resources.StartIndexForReportShow,
                                                                         Resources.MaxSizeOfRowForReport);
                    ProgressBox.Hide();
                    var frmShowReprt = new Report.frmShowReprt(report)
                                           {
                                               SCA = ucSelectColumn.GetSelectedItem(),
                                               SCAA = ucSelectColumn.GetSelectedItemForQuerySql(),
                                               F = filter,
                                               OrderBy = GetOrderBy(),
                                               TN = Resources.KEY_NameOfGuaranteeReport
                                           };
                    frmShowReprt.ShowDialog();
                    return;
                }

                else if (rdbDate_Historic.Checked && status.ToUpper().Equals(KEY_GUARANTEE))
                {
                    if (filter.Length > 0)
                        filter = filter + " and VGReport_Historic.Historic_Date = cast('" + fil_HistoricDate + "'as datetime)";
                    else
                    {
                        filter = " where VGReport_Historic.Historic_Date = cast('" + fil_HistoricDate + "'as datetime)";
                    }
                    var report = new LoanDataSet().GetReportByPaging(KEY_VIEW_GUARANTEE_HISTORIC, ucSelectColumn.GetSelectedItem(),
                                                                         ucSelectColumn.GetSelectedItemForQuerySql(),
                                                                         filter,
                                                                         GetOrderBy(),
                                                                         Resources.StartIndexForReportShow,
                                                                         Resources.MaxSizeOfRowForReport);
                    ProgressBox.Hide();
                    var frmShowReprt = new Report.frmShowReprt(report)
                    {
                        SCA = ucSelectColumn.GetSelectedItem(),
                        SCAA = ucSelectColumn.GetSelectedItemForQuerySql(),
                        F = filter,
                        OrderBy = GetOrderBy(),
                        TN = Resources.KEY_NameOfGuaranteeReport
                    };
                    frmShowReprt.ShowDialog();
                    return;
                }
            }
            catch (Exception exception)
            {
                ProgressBox.Hide();
                exception.ConfigLog(true);
            }
        }



        private bool checkColExistence(DataTable dt, string ColumnName)
        {
            bool exist = false;

            foreach (DataColumn col in dt.Columns)
            {
                if (col.ColumnName.Equals(ColumnName))
                {
                    exist = true;
                    break;
                }
            }

            return exist;

        }

        const string KEY_LOAN = "LOAN";
        const string KEY_GUARANTEE = "GUARANTEE";

        const string KEY_VIEW_LOAN = "VLReport";
        const string KEY_VIEW_GUARANTEE = "VGReport";

        const string KEY_VIEW_LOAN_HISTORIC = "VLReport_Historic";
        const string KEY_VIEW_GUARANTEE_HISTORIC = "VGReport_Historic";


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ucSelectColumn.GetSelectedItem().Count() < 1)
                {
                    Utilize.Routines.ShowInfoMessageFa("خطا", "هیچ ستونی برای نمایش انتخاب نشده است", Utilize.MyDialogButton.OK);
                    return;
                }

                var fil_HistoricDate = "";
                if (rdbDate_Historic.Checked)
                {
                    if (fdpHistoricDate.Text.Equals("[هیج مقداری انتخاب نشده]") || fdpHistoricDate.Text.Trim().Length == 0)
                    {
                        Utilize.Routines.ShowInfoMessageFa("خطا", "تاریخ معتبر وارد نشده است", Utilize.MyDialogButton.OK);
                        return;
                    }
                    else
                        fil_HistoricDate += fdpHistoricDate.SelectedDateTime.ToString("yyyy-MM-dd");
                }

                switch (status.ToUpper())
                {
                    #region REPORT FOR LOAN
                    case KEY_LOAN:
                        if (ReportId.HasValue == false)
                        {
                            var filter = GetFilter();
                            if (rdbDate_Historic.Checked)
                            {
                                if (filter.Length > 0)
                                    filter = filter + string.Format(" and {0}.Historic_Date = cast('{1}' as datetime)", KEY_VIEW_LOAN_HISTORIC, fil_HistoricDate);
                                else
                                    filter = string.Format(" where {0}.Historic_Date = cast('{1}' as datetime)", KEY_VIEW_LOAN_HISTORIC, fil_HistoricDate);
                            }
                            var frmInputText = new frmInputText { Topic = "نام گزارش" };
                            frmInputText.ShowDialog();
                            var value = frmInputText.ReturnValue;
                            if (value == null) return;
                            var newRepor = new GeneralDataSet.SWART_ReportsDataTable().NewSWART_ReportsRow();
                            newRepor.ReportName = value;
                            newRepor.ReportTable = rdbDate_Historic.Checked ? KEY_VIEW_LOAN_HISTORIC : KEY_VIEW_LOAN_HISTORIC;
                            // Resources.KEY_NameOfLoanReport;
                            newRepor.ReportType = false;
                            newRepor.Filter = filter;
                            newRepor.SCAA = ucSelectColumn.GetSelectedItemForQuerySql();
                            newRepor.SC = ucSelectColumn.GetSelectedItem();
                            new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().Insert(newRepor.ReportName,
                                                                                                   newRepor.ReportTable,
                                                                                                   newRepor.ReportType,
                                                                                                   newRepor.SCAA,
                                                                                                   newRepor.Filter,
                                                                                                   null, newRepor.SC,
                                                                                                   ERMS.Model.GlobalInfo.
                                                                                                       UserID);
                            ConfReportsList();
                            ReportId =
                                new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetData().Max(
                                    item => item.Id);

                            Utilize.Routines.ShowInfoMessageFa("ایجاد گزارش", string.Format("گزارش {0} با موفقیت ثبت شد", value),
                                                       Utilize.MyDialogButton.OK);
                        }
                        else
                        {
                            var swartReport =
                                new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataById(ReportId.Value).
                                    FirstOrDefault();
                            swartReport.Filter = GetFilter();
                            swartReport.SCAA = ucSelectColumn.GetSelectedItemForQuerySql();
                            swartReport.SC = ucSelectColumn.GetSelectedItem();
                            swartReport.User_Id = ERMS.Model.GlobalInfo.UserID;
                            if (rdbDate_Historic.Checked)
                            {
                                swartReport.ReportTable = KEY_VIEW_LOAN_HISTORIC;
                                if (swartReport.Filter.Length > 0)
                                    swartReport.Filter += string.Format(" and {0}.Historic_Date = cast('{1}' as datetime)", KEY_VIEW_LOAN_HISTORIC, fil_HistoricDate);
                                else
                                    swartReport.Filter = string.Format(" where {0}.Historic_Date = cast('{1}' as datetime)", KEY_VIEW_LOAN_HISTORIC, fil_HistoricDate);
                            }
                            else
                            {
                                swartReport.ReportTable = KEY_VIEW_LOAN_HISTORIC;
                            }
                            new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().UpdateByReportTable(swartReport.SCAA
                                                                    , swartReport.Filter, swartReport.SC, swartReport.User_Id, swartReport.ReportTable, swartReport.Id);
                            ConfReportsList();
                            Utilize.Routines.ShowInfoMessageFa("تغییر گزارش",
                                                       string.Format("تغییرات گزارش {0} با موفقیت ثبت شد",
                                                                     swartReport.ReportName),
                                                       Utilize.MyDialogButton.OK);
                        }
                        break;
                    #endregion
                    #region REPORT FOR GUARANTEE
                    case KEY_GUARANTEE:
                        if (ReportId.HasValue == false)
                        {
                            var filter = GetFilter();
                            if (rdbDate_Historic.Checked)
                            {
                                if (filter.Length > 0)
                                    filter = filter + string.Format(" and {0}.Historic_Date = cast('{1}' as datetime)", KEY_VIEW_GUARANTEE_HISTORIC, fil_HistoricDate);
                                else
                                    filter = string.Format(" where {0}.Historic_Date = cast('{1}' as datetime)", KEY_VIEW_GUARANTEE_HISTORIC, fil_HistoricDate);
                            }
                            var frmInputText = new frmInputText { Topic = "نام گزارش" };
                            frmInputText.ShowDialog();
                            var value = frmInputText.ReturnValue;
                            if (value == null) return;
                            var newRepor = new GeneralDataSet.SWART_ReportsDataTable().NewSWART_ReportsRow();
                            newRepor.ReportName = value;
                            newRepor.ReportTable = rdbDate_Historic.Checked ? KEY_VIEW_GUARANTEE_HISTORIC : KEY_VIEW_GUARANTEE_HISTORIC;
                            newRepor.ReportType = false;
                            newRepor.Filter = filter;
                            newRepor.SCAA = ucSelectColumn.GetSelectedItemForQuerySql();
                            newRepor.SC = ucSelectColumn.GetSelectedItem();
                            new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().Insert(newRepor.ReportName,
                                                                                                   newRepor.ReportTable,
                                                                                                   newRepor.ReportType,
                                                                                                   newRepor.SCAA,
                                                                                                   newRepor.Filter,
                                                                                                   null, newRepor.SC,
                                                                                                   ERMS.Model.GlobalInfo.
                                                                                                       UserID);
                            ConfReportsList();
                            ReportId =
                                new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetData().Max(
                                    item => item.Id);

                            Utilize.Routines.ShowInfoMessageFa("ایجاد گزارش", string.Format("گزارش {0} با موفقیت ثبت شد", value),
                                                       Utilize.MyDialogButton.OK);
                        }
                        else
                        {
                            var swartReport =
                                new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataById(ReportId.Value).
                                    FirstOrDefault();
                            swartReport.Filter = GetFilter();
                            swartReport.SCAA = ucSelectColumn.GetSelectedItemForQuerySql();
                            swartReport.SC = ucSelectColumn.GetSelectedItem();
                            swartReport.User_Id = ERMS.Model.GlobalInfo.UserID;
                            if (rdbDate_Historic.Checked)
                            {
                                swartReport.ReportTable = KEY_VIEW_GUARANTEE_HISTORIC;
                                if (swartReport.Filter.Length > 0)
                                    swartReport.Filter += string.Format(" and {0}.Historic_Date = cast('{1}' as datetime)", KEY_VIEW_GUARANTEE_HISTORIC, fil_HistoricDate);
                                else
                                    swartReport.Filter = string.Format(" where {0}.Historic_Date = cast('{1}' as datetime)", KEY_VIEW_GUARANTEE_HISTORIC, fil_HistoricDate);
                            }
                            else
                            {
                                swartReport.ReportTable = KEY_VIEW_GUARANTEE_HISTORIC;
                            }
                            new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().UpdateByReportTable(swartReport.SCAA
                                                                    , swartReport.Filter, swartReport.SC, swartReport.User_Id, swartReport.ReportTable, swartReport.Id);
                            ConfReportsList();
                            Utilize.Routines.ShowInfoMessageFa("تغییر گزارش",
                                                       string.Format("تغییرات گزارش {0} با موفقیت ثبت شد",
                                                                     swartReport.ReportName),
                                                       Utilize.MyDialogButton.OK);
                        }
                        break;
                    #endregion
                    default:
                        break;
                }
            }

            catch (Exception exception)
            {
                exception.ConfigLog(false, "در هنگام ذخیره اطلاعات خطا رخ داده است");
            }

        }

        private void SetSelectedHisDate(string[] filters)
        {
            foreach (var filter in filters)
            {
                if (filter.Contains("Historic_Date ="))
                {
                    string dt = filter.Substring(filter.IndexOf("'") + 1, 10);
                    DateTime date = new DateTime(Int32.Parse(dt.Split('-')[0]), Int32.Parse(dt.Split('-')[1])
                                                    , Int32.Parse(dt.Split('-')[2]));
                    rdbDate_Historic.Checked = true;
                    fdpHistoricDate.SelectedDateTime = date;
                }
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
                var filters = report.Filter.Replace("where", "").Trim().Split(new[] { "and" }, StringSplitOptions.RemoveEmptyEntries);
                if (report.ReportTable.Equals(KEY_VIEW_LOAN_HISTORIC) || report.ReportTable.Equals(KEY_VIEW_GUARANTEE_HISTORIC))
                {
                    rdbDate_Historic.Checked = true;
                    rdbDate_Today.Checked = false;
                    SetSelectedHisDate(filters);
                }
                else
                {
                    rdbDate_Historic.Checked = false;
                    rdbDate_Today.Checked = true;
                }



                bool STATE_ID = false,
                     BRANCH = false,
                     CONTRACT_TYPE = false,
                     ECONOMIC_SECTOR = false,
                     CUSTOMER_GROUP = false,
                     COUNTERPARTY_TYPE = false,
                     START_DATE = false,
                     MATURITY_DATE = false,
                     COUNTERPARTY = false,
                     STATUS = false,
                     COLLAT_STAT = false,
                     COLLATERAL_TYPE = false,
                     COLLAT_MAJOR_TYPE = false,
                     SEX = false,
                     EDUCATION = false,
                     NIRU = false,
                     MaritalStatus = false,
                     SOKUNAT = false,
                     EGHAMAT = false,
                     NATIONALITY = false,
                     ECONOMIC_PART = false,
                     COMPANY_NAME = false,
                     JOB_TYPE = false,
                     RELATION = false;


                clearUCF();

                //if (!report.Filter.Contains("where dbo.VLReport_Historic.Historic_Date") && !report.Filter.Contains(" and dbo.VLReport_Historic.Historic_Date = cast('"))
                //{
                //    rdbDate_Today.Checked = true;
                //    fdpHistoricDate.SelectedDateTime = DateTime.Now;
                //    fdpHistoricDate.ResetSelectedDateTime();
                //}

                //if (!report.Filter.Contains("where dbo.VLReport_Historic.Historic_Date"))
                //{
                foreach (var filter in filters)
                {
                    # region HistoricDate
                    //if (filter.Contains("Historic_Date ="))
                    //{
                    //    rdbDate_Historic.Checked = true;
                    //    string dt = filter.Substring(filter.IndexOf("'") + 1, 10);
                    //    DateTime date = new DateTime(Int32.Parse(dt.Split('-')[0]), Int32.Parse(dt.Split('-')[1])
                    //                                    , Int32.Parse(dt.Split('-')[2]));
                    //    rdbDate_Historic.Checked = true;
                    //    fdpHistoricDate.SelectedDateTime = date;
                    //}
                    #endregion

                    #region sex

                    //if (filter.ToUpper().Contains("sex"))
                    //{
                    //    ucSex.SetSelectedItem(
                    //        filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                    //            new[] { "sex =" }, StringSplitOptions.RemoveEmptyEntries));
                    //    SEX = true;
                    //}
                    //else
                    //{
                    //    if (SEX == false)
                    //        ucSex.ClearItem();
                    //}
                    #endregion

                    #region Education

                    //if (filter.ToUpper().Contains("education_Desc"))
                    //{
                    //    ucEducation.SetSelectedItem(
                    //        filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                    //            new[] { "education_Desc =" }, StringSplitOptions.RemoveEmptyEntries));
                    //    EDUCATION = true;
                    //}
                    //else
                    //{
                    //    if (EDUCATION == false)
                    //        ucSex.ClearItem();
                    //}
                    #endregion



                    #region MaritalStatus

                    //if (filter.ToUpper().Contains("maritalStatus"))
                    //{
                    //    ucMaritalStatus.SetSelectedItem(
                    //        filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                    //            new[] { "maritalStatus =" }, StringSplitOptions.RemoveEmptyEntries));
                    //    MaritalStatus = true;
                    //}
                    //else
                    //{
                    //    if (MaritalStatus == false)
                    //        ucMaritalStatus.ClearItem();
                    //}
                    #endregion

                    #region SOKUNAT

                    //if (filter.ToUpper().Contains("residentType_Desc"))
                    //{
                    //    ucSokunat.SetSelectedItem(
                    //        filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                    //            new[] { "residentType_Desc =" }, StringSplitOptions.RemoveEmptyEntries));
                    //    SOKUNAT = true;
                    //}
                    //else
                    //{
                    //    if (SOKUNAT == false)
                    //        ucSokunat.ClearItem();
                    //}
                    #endregion



                    #region Nationality

                    if (filter.ToUpper().Contains("nationality"))
                    {
                        ucNationality.SetSelectedItem(
                            filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                new[] { "nationality =" }, StringSplitOptions.RemoveEmptyEntries));
                        NATIONALITY = true;
                    }
                    else
                    {
                        if (NATIONALITY == false)
                            ucNationality.ClearItem();
                    }
                    #endregion

                    #region EconomicPart

                    //if (filter.ToUpper().Contains("Counterparty_eco_Desc"))
                    //{
                    //    ucEconomicPart.SetSelectedItem(
                    //        filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                    //            new[] { "Counterparty_eco_Desc =" }, StringSplitOptions.RemoveEmptyEntries));
                    //    ECONOMIC_PART = true;
                    //}
                    //else
                    //{
                    //    if (ECONOMIC_PART == false)
                    //        ucEconomicPart.ClearItem();
                    //}
                    #endregion

                    #region CompanyType

                    //if (filter.ToUpper().Contains("Company_Type_Desc"))
                    //{
                    //    ucCompanyType.SetSelectedItem(
                    //        filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                    //            new[] { "Company_Type_Desc =" }, StringSplitOptions.RemoveEmptyEntries));
                    //    COMPANY_NAME = true;
                    //}
                    //else
                    //{
                    //    if (COMPANY_NAME == false)
                    //        ucCompanyType.ClearItem();
                    //}
                    #endregion

                    #region JobType

                    //if (filter.ToUpper().Contains("Job_Type_Desc"))
                    //{
                    //    ucJobType.SetSelectedItem(
                    //        filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                    //            new[] { "Job_Type_Desc =" }, StringSplitOptions.RemoveEmptyEntries));
                    //    JOB_TYPE = true;
                    //}
                    //else
                    //{
                    //    if (JOB_TYPE == false)
                    //        ucJobType.ClearItem();
                    //}
                    #endregion



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

                    #region STATE

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

                    #region COLLAT STATE

                    if (filter.ToUpper().Contains("COLLAT_STAT = '"))
                    {
                        ucfCollateralStatus.SetSelectedItem(
                            filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Replace("<>0", "").Split(
                                new[] { "COLLAT_STAT =" }, StringSplitOptions.RemoveEmptyEntries));
                        COLLAT_STAT = true;
                    }
                    else
                    {
                        if (COLLAT_STAT == false)
                            ucfCollateralStatus.ClearItem();
                    }
                    #endregion

                    #region COLLATERAL TYPE

                    if (filter.ToUpper().Contains("COLLATERAL_TYPE = '"))
                    {
                        ucfCollateralType.SetSelectedItem(
                            filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Replace("<>0", "").Split(
                                new[] { "COLLATERAL_TYPE =" }, StringSplitOptions.RemoveEmptyEntries));
                        COLLATERAL_TYPE = true;
                    }
                    else
                    {
                        if (COLLATERAL_TYPE == false)
                            ucfCollateralType.ClearItem();
                    }
                    #endregion

                    #region COLLAT MAJOR TYPE

                    if (filter.ToUpper().Contains("COLLAT_MAJOR_TYPE = '"))
                    {
                        ucfCollatMajorType.SetSelectedItem(
                            filter.ToUpper().Replace("(", "").Replace(")", "").Replace(" OR ", "").Replace("'", "").Replace("<>0", "").Split(
                                new[] { "COLLAT_MAJOR_TYPE =" }, StringSplitOptions.RemoveEmptyEntries));
                        COLLAT_MAJOR_TYPE = true;
                    }
                    else
                    {
                        if (COLLAT_MAJOR_TYPE == false)
                            ucfCollatMajorType.ClearItem();
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
                    int CountCounterparty = filter.ToUpper().Split(' ').Count(x => x.Contains("COUNTERPARTY"));

                    if (filter.ToUpper().Contains("COUNTERPARTY =") && CountCounterparty == 1)
                    {
                        chbCounterparty1.Checked = true;
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
                            chbCounterparty1.Checked = false;
                            txtCounterparty.Enabled = false;
                            txtCounterparty.Text = txtCounterPartyName.Text = "";
                        }
                    }
                    #endregion

                    #region CounterpartyName

                    //if (filter.ToUpper().Contains("COUNTERPARTY =") && CountCounterparty > 1)
                    //{
                    //    int AndIndex = filter.ToUpper().LastIndexOf("AND", filter.ToUpper().IndexOf("COUNTERPARTY ="));
                    //    string fil_CounterParty = filter.Substring(filter.ToUpper().IndexOf("COUNTERPARTY ="),
                    //                                               AndIndex);
                    //    chbCounterparty1.Checked = true;
                    //    txtCounterparty.Enabled = true;
                    //    txtCounterparty.Text =
                    //        filter.ToUpper().Replace("(", "").Replace(")", "").Replace("'", "").Trim().Substring(14).Trim();
                    //    var row = new DAL.DepositDataSetTableAdapters.CounterpartyTableAdapter().GetDataByCounterparty(
                    //        txtCounterparty.Text.Trim().ToInt()).FirstOrDefault();
                    //    txtCounterPartyName.Text = row.Name;
                    //    txtCounterPartyName.Tag = txtCounterparty.Text;
                    //    COUNTERPARTY = true;
                    //}
                    //else
                    //{
                    //    if (COUNTERPARTY == false)
                    //    {
                    //        chbCounterparty1.Checked = false;
                    //        txtCounterparty.Enabled = false;
                    //        txtCounterparty.Text = txtCounterPartyName.Text = "";
                    //    }
                    //}
                    #endregion
                }
                //}
                //else
                //{
                //    # region HistoricDate

                //    if (report.Filter.Contains("Historic_Date ="))
                //    {
                //        rdbDate_Historic.Checked = true;
                //        string dt = report.Filter.Substring(report.Filter.IndexOf("'") + 1, 10);
                //        DateTime date = new DateTime(Int32.Parse(dt.Split('-')[0]), Int32.Parse(dt.Split('-')[1])
                //                                        , Int32.Parse(dt.Split('-')[2]));
                //        rdbDate_Historic.Checked = true;
                //        fdpHistoricDate.SelectedDateTime = date;
                //    }

                //    #endregion
                //}

                ucSelectColumn.SetSelectedItem(report.SCAA);

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
            fdpFromMaturityDate.ResetText();

            clearUCF();
            ReportId = null;
        }

        private void clearUCF()
        {
            ucfOrganization.ClearItem();
            ucfState.ClearItem();
            ucfCustomerGroup.ClearItem();
            ucEconomicSector.ClearItem();
            ucfCounterPartyType.ClearItem();
            ucfContractType.ClearItem();
            ucContractStatus.ClearItem();
            ucFilteringContractTypeCode.ClearItem();
            ucfCollateralStatus.ClearItem();
            ucfCollateralType.ClearItem();
            ucfCollatMajorType.ClearItem();

            //ucJobType.ClearItem();
            //ucMaritalStatus.ClearItem();
            ucNationality.ClearItem();

            //ucSex.ClearItem();
            //ucSokunat.ClearItem();
            //ucCompanyType.ClearItem();
            //ucEducation.ClearItem();

            //ucEconomicPart.ClearItem();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            if (status == "Loan")
            {
                try
                {
                    if (trnReport.SelectedNodes.Count <= 0) return;
                    var chart = new CHART.frmChart
                                    {
                                        ReportType = Resources.KEY_NameOfLoanReport,
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
            else if (status == "Guarantee")
            {
                try
                {
                    if (trnReport.SelectedNodes.Count <= 0) return;
                    var chart = new CHART.frmChart
                    {
                        ReportType = Resources.KEY_NameOfGuaranteeReport,
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
        }

        private void btnRemoveReport_Click(object sender, EventArgs e)
        {
            if (trnReport.SelectedNodes.Count <= 0) return;
            if (Utilize.Routines.ShowQuestionMessageFa("حذف گزارش", "آیا از حذف گزارش مطمئن هستید؟", Utilize.MyDialogButton.YesNO) == Utilize.MyDialogResoult.No)
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

        private void rdbDate_Historic_CheckedChanged(object sender, EventArgs e)
        {
            ConfReportsList();
            if (status.ToUpper().Equals(KEY_LOAN))
            {
                if (rdbDate_Historic.Checked)
                {
                    fdpHistoricDate.Enabled = true;
                    var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                        KEY_VIEW_LOAN_HISTORIC);
                    ucSelectColumn.NameOfDisplay = "AliasName";
                    ucSelectColumn.NameOfValue = "NameColumn";
                    ucSelectColumn.DataSource = null;
                    ucSelectColumn.DataSource = columnsForShowInReport;

                    cmbOrderBy.DisplayMember = "AliasName";
                    cmbOrderBy.ValueMember = "NameColumn";
                    cmbOrderBy.DataSource = null;
                    cmbOrderBy.DataSource = columnsForShowInReport;
                }
                else
                {
                    fdpHistoricDate.Enabled = false;
                    var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                        Resources.KEY_NameOfLoanReport);
                    ucSelectColumn.NameOfDisplay = "AliasName";
                    ucSelectColumn.NameOfValue = "NameColumn";
                    ucSelectColumn.DataSource = null;
                    ucSelectColumn.DataSource = columnsForShowInReport;

                    cmbOrderBy.DisplayMember = "AliasName";
                    cmbOrderBy.ValueMember = "NameColumn";
                    cmbOrderBy.DataSource = null;
                    cmbOrderBy.DataSource = columnsForShowInReport;

                }
            }
            if (status.ToUpper().Equals(KEY_GUARANTEE))
            {
                if (rdbDate_Historic.Checked)
                {
                    fdpHistoricDate.Enabled = true;
                    var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                        KEY_VIEW_GUARANTEE_HISTORIC);
                    ucSelectColumn.NameOfDisplay = "AliasName";
                    ucSelectColumn.NameOfValue = "NameColumn";
                    ucSelectColumn.DataSource = null;
                    ucSelectColumn.DataSource = columnsForShowInReport;

                    cmbOrderBy.DisplayMember = "AliasName";
                    cmbOrderBy.ValueMember = "NameColumn";
                    cmbOrderBy.DataSource = null;
                    cmbOrderBy.DataSource = columnsForShowInReport;
                }
                else
                {
                    fdpHistoricDate.Enabled = false;
                    var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                        KEY_VIEW_GUARANTEE_HISTORIC);
                    ucSelectColumn.NameOfDisplay = "AliasName";
                    ucSelectColumn.NameOfValue = "NameColumn";
                    ucSelectColumn.DataSource = null;
                    ucSelectColumn.DataSource = columnsForShowInReport;

                    cmbOrderBy.DisplayMember = "AliasName";
                    cmbOrderBy.ValueMember = "NameColumn";
                    cmbOrderBy.DataSource = null;
                    cmbOrderBy.DataSource = columnsForShowInReport;

                }
            }
        }


        public void SetColumns()
        {
            ConfReportsList();
            if (status.ToUpper().Equals(KEY_LOAN))
            {
                if (rdbDate_Historic.Checked)
                {
                    fdpHistoricDate.Enabled = true;
                    var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                        KEY_VIEW_LOAN_HISTORIC);
                    ucSelectColumn.NameOfDisplay = "AliasName";
                    ucSelectColumn.NameOfValue = "NameColumn";
                    ucSelectColumn.DataSource = null;
                    ucSelectColumn.DataSource = columnsForShowInReport;

                    cmbOrderBy.DisplayMember = "AliasName";
                    cmbOrderBy.ValueMember = "NameColumn";
                    cmbOrderBy.DataSource = null;
                    cmbOrderBy.DataSource = columnsForShowInReport;
                }
                else
                {
                    fdpHistoricDate.Enabled = false;
                    var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                        Resources.KEY_NameOfLoanReport);
                    ucSelectColumn.NameOfDisplay = "AliasName";
                    ucSelectColumn.NameOfValue = "NameColumn";
                    ucSelectColumn.DataSource = null;
                    ucSelectColumn.DataSource = columnsForShowInReport;

                    cmbOrderBy.DisplayMember = "AliasName";
                    cmbOrderBy.ValueMember = "NameColumn";
                    cmbOrderBy.DataSource = null;
                    cmbOrderBy.DataSource = columnsForShowInReport;

                }
            }
            if (status.ToUpper().Equals(KEY_GUARANTEE))
            {
                if (rdbDate_Historic.Checked)
                {
                    fdpHistoricDate.Enabled = true;
                    var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                        KEY_VIEW_GUARANTEE_HISTORIC);
                    ucSelectColumn.NameOfDisplay = "AliasName";
                    ucSelectColumn.NameOfValue = "NameColumn";
                    ucSelectColumn.DataSource = null;
                    ucSelectColumn.DataSource = columnsForShowInReport;

                    cmbOrderBy.DisplayMember = "AliasName";
                    cmbOrderBy.ValueMember = "NameColumn";
                    cmbOrderBy.DataSource = null;
                    cmbOrderBy.DataSource = columnsForShowInReport;
                }
                else
                {
                    fdpHistoricDate.Enabled = false;
                    var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                        KEY_VIEW_GUARANTEE_HISTORIC);
                    ucSelectColumn.NameOfDisplay = "AliasName";
                    ucSelectColumn.NameOfValue = "NameColumn";
                    ucSelectColumn.DataSource = null;
                    ucSelectColumn.DataSource = columnsForShowInReport;

                    cmbOrderBy.DisplayMember = "AliasName";
                    cmbOrderBy.ValueMember = "NameColumn";
                    cmbOrderBy.DataSource = null;
                    cmbOrderBy.DataSource = columnsForShowInReport;

                }
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
                        txtCounterpartyNames.Text = "مشتری با این مشخصات وجود ندارد";
                        txtCounterpartyNames.Tag = null;
                        Utilize.Routines.ShowInfoMessageFa("خطا", "موردی یافت نشد", Utilize.MyDialogButton.OK);
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

        public string SafeFarsiStr(string input)
        {
            return input.Replace("ی", "ي").Replace("ک", "ك");
        }

        private void chbCounterpartyName_CheckedChanged(object sender, EventArgs e)
        {
            txtCounterpartyNameSearch.Enabled = chbCounterpartyName1.Checked;
        }

        private void chbCounterpartyName1_CheckedChanged(object sender, EventArgs e)
        {
            txtCounterpartyNameSearch.Enabled = chbCounterpartyName1.Checked;
            cgbCouterpartName.Enabled = chbCounterpartyName1.Checked;
            dgvCounterpartiesNames.Enabled = chbCounterpartyName1.Checked;
            if (!chbCounterpartyName1.Checked)
            {

                dgvCounterpartiesNames.DataSource = null;
                dgvCounterpartiesNames.Refresh();
                dgvCounterpartiesNames.Update();
                txtCounterpartyNameSearch.Text = string.Empty;
            }
        }

        private void chbCounterparty1_CheckedChanged(object sender, EventArgs e)
        {
            txtCounterparty.Enabled = chbCounterparty1.Checked;
            txtCounterPartyName.Enabled = chbCounterparty1.Checked;
            if (!chbCounterparty1.Checked)
            {
                txtCounterparty.Text = "";
                txtCounterPartyName.Tag = null;
                txtCounterPartyName.Text = "";
            }
        }

        private void chbCustCodeName_CheckedChanged(object sender, EventArgs e)
        {
            cgbCustCodeName.Enabled = chbCustCodeName.Checked;
            if (!chbCustCodeName.Checked)
            {
                chbCounterparty1.Checked = false;
                chbCounterpartyName1.Checked = false;
                chbDepNo.Checked = false;
            }
        }

        private void rdbDate_Today_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fdpHistoricDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {

        }

        private void ucfContractType_Load(object sender, EventArgs e)
        {

        }

        private void txtUpdateOverdue3Coef_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            try
            {
                string HisDate = "2000-01-01";
                double Coef = 0;
                if (!double.TryParse(txtUpdateOverdue3Coef.Text, out Coef))
                {
                    Utilize.Routines.ShowInfoMessageFa("خطا", "ضریب صحیحی وارد نشده است", Utilize.MyDialogButton.OK);
                    return;
                }
                else if (Coef < 0.5 || Coef > 1.0)
                {
                    Utilize.Routines.ShowInfoMessageFa("خطا", "ضریب می بایست مقداری بین 0.5 و 1 باشد", Utilize.MyDialogButton.OK);
                    return;
                }

                if (rdbDate_Historic.Checked && fdpHistoricDate.Text.Equals("[هیج مقداری انتخاب نشده]") || fdpHistoricDate.Text.Trim().Length == 0)
                {
                    Utilize.Routines.ShowInfoMessageFa("خطا", "تاریخ معتبر وارد نشده است", Utilize.MyDialogButton.OK);
                    return;
                }
                else if (fdpHistoricDate.SelectedDateTime > DateTime.Parse("2000-01-01"))
                    HisDate = fdpHistoricDate.SelectedDateTime.ToString("yyyy-MM-dd");
                ProgressBox.Show();
                new LoanDataSet().UpdateOverdue3Coef(rdbDate_Historic.Checked, DateTime.Parse(HisDate), Coef);
            }
            catch (Exception ex)
            {
                Utilize.Routines.ShowErrorMessageFa("خطا", ex.Message, Utilize.MyDialogButton.OK);
            }
            finally
            {
                ProgressBox.Hide();
            }

        }

        private void txtDepNo_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            try
            {
                if (e.Button.Key == "Search")
                {
                    if (txtDepNo.Text.Trim().Length == 0 || !txtDepNo.Text.IsNumber())
                    {
                        Utilize.Routines.ShowInfoMessageFa("خطا", "شماره معتبری وارد نشده است", Utilize.MyDialogButton.OK);
                        return;
                    }
                    DateTime dtHisDate = fdpHistoricDate.SelectedDateTime;
                    string strAccount = txtDepNo.Text;
                    //string strAccount = "'%" + txtDepNo.Text + "%'";
                    DataTable account = new DataTable();
                    if (status.ToUpper().Equals(KEY_LOAN))
                        account = new DAL.LoanDataSet().GetLoanByContract(dtHisDate, strAccount);
                    if (status.ToUpper().Equals(KEY_GUARANTEE))
                        account = new DAL.LoanDataSet().GetLGByContract(dtHisDate, strAccount);

                    if (account.Rows.Count > 0 && account != null)
                    {
                        txtDepNoName.Text = " شماره  " + account.Rows[0][0].ToString() + " در تاریخ مورد نظر وجود دارد ";
                        txtDepNoName.Tag = account.Rows[0][0].ToString();
                    }
                    else
                    {
                        txtDepNoName.Text = "قراردادی با این مشخصات در تاریخ مورد نظر وجود ندارد";
                        txtDepNoName.Tag = null;
                    }
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void chbDepNo_CheckedChanged(object sender, EventArgs e)
        {
            txtDepNo.Enabled = chbDepNo.Checked;
            txtDepNoName.Enabled = chbDepNo.Checked;
            if (!chbDepNo.Checked)
            {
                txtDepNo.Text = "";
                txtDepNo.Tag = null;
                txtDepNoName.Tag = null;
                txtDepNoName.Text = "";
            }
        }

        private void chbOrderBy_CheckedChanged(object sender, EventArgs e)
        {
            cmbOrderBy.Enabled = chbOrderBy.Checked;
            rdbAsc.Enabled = chbOrderBy.Checked;
            rdbDesc.Enabled = chbOrderBy.Checked;
            if (!chbOrderBy.Checked)
                cmbOrderBy.SelectedIndex = -1;
        }

        private void btnShowNormalReport_Load(object sender, EventArgs e)
        {

        }

        private void cbCloseAll_CButtonClicked(object sender, EventArgs e)
        {
            frmPDF frmpdf=null;
            if(status=="Guarantee")
                frmpdf = new frmPDF("/CreditRiskPDF/frmLoanReportCs-Guarantee.pdf");
            else if (status=="Loan")
                frmpdf = new frmPDF("/CreditRiskPDF/frmLoanReportCs-Loan.pdf");
            frmpdf.ShowDialog();
        }

        private void cbCloseAll_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


    }
}
