using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DAL;
using Infragistics.Win.UltraWinTree;
using Utilize;
//
using Utilize.Helper;
using Utilize.Report;
using Resources = Presentation.Properties.Resources;
namespace Presentation.Deposit
{
    public partial class frmDepositReportcs : BaseForm
    {
        private long? ReportId;
        DataTable user;
        public frmDepositReportcs()
        {
            InitializeComponent();

            try
            {

                var depositContractStatus_DataTable= new DAL.Table_DataSetTableAdapters.DepositContractStatusTableAdapter().GetData();
                ucfDepositContractStatus.DisplayMember = "Name";
                ucfDepositContractStatus.ValueMember = "StatusId";
                ucfDepositContractStatus.DataSource = depositContractStatus_DataTable;

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
                    ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;
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

                }
                #endregion


                var contract_Type_Group_DataTable = new DAL.GeneralDataSetTableAdapters.ContractType().GetDT_ContractTypes(2);
                    //Contract_type_groupsTableAdapter().GetData();
                ucfContractTypeDep.DisplayMember = "Contract_type_group_Desc";
                ucfContractTypeDep.ValueMember = "Contract_type_group_id";
                ucfContractTypeDep.DataSource = contract_Type_Group_DataTable;

                

                //ucfContractType.DisplayMember = "Contract_Type_Description";
                //ucfContractType.ValueMember = "Contract_Type";
                //ucfContractType.DataSource = contract_DataTable;
                var contract_DataTable = new DAL.DepositDataSetTableAdapters.Contract_TypeTableAdapter().GetDataByDeposit();
                ucFilteringContractTypeCodeDep.DisplayMember = "Contract_Type_Description";
                ucFilteringContractTypeCodeDep.ValueMember = "Contract_Type";
                ucFilteringContractTypeCodeDep.DataSource = contract_DataTable;
                


                var currency_DataTable = new DAL.DepositDataSetTableAdapters.CurrencyTableAdapter().GetData();

                ucfCurrency.DisplayMember = "Currency_Description";
                ucfCurrency.ValueMember = "Currency";
                ucfCurrency.DataSource = currency_DataTable;

                var customerGroup_DataTable = new DAL.DepositDataSetTableAdapters.Customer_GroupTableAdapter().GetData();

                ucfCustomerGroup.DisplayMember = "Customer_Group_Description";
                ucfCustomerGroup.ValueMember = "Customer_Group";
                ucfCustomerGroup.DataSource = customerGroup_DataTable;

                var counterparty_DataTable = new DAL.DepositDataSetTableAdapters.Counterparty_TypeTableAdapter().GetData();

                ucfCounterPartyType.DataSource = counterparty_DataTable;
                ucfCounterPartyType.DisplayMember = "Counterparty_Type_Desc";
                ucfCounterPartyType.ValueMember = "Counterparty_Type";

                #region new filters
                /*
                var national = new DAL.GeneralDataSetTableAdapters.Counterparty_NationalityTableAdapter().GetData();
                ucNationality.DisplayMember = "nationality";
                ucNationality.ValueMember = "nationality";
                ucNationality.DataSource = national;


                var ucSokunat_DataTable = new DAL.GeneralDataSetTableAdapters.Counterparty_residentTypeTableAdapter().GetData();
                ucSokunat.DisplayMember = "residentType_Desc";
                ucSokunat.ValueMember = "residentType_Desc";
                ucSokunat.DataSource = ucSokunat_DataTable;

                var ucJobType_DataTable = new DAL.GeneralDataSetTableAdapters.CounterpartyJob_TypeTableAdapter().GetData();
                ucJobType.DisplayMember = "Job_Type_Desc";
                ucJobType.ValueMember = "Job_Type_Desc";
                ucJobType.DataSource = ucJobType_DataTable;
                

                var ucCompanytype_DataTable = new DAL.GeneralDataSetTableAdapters.CounterpartyCompany_TypeTableAdapter().GetData();
                ucCompanyType.DisplayMember = "Company_Type_Desc";
                ucCompanyType.ValueMember = "Company_Type_Desc";
                ucCompanyType.DataSource = ucCompanytype_DataTable;


                var ucEducation_DataTable = new DAL.GeneralDataSetTableAdapters.Counterparty_EducationTableAdapter().GetData();
                ucEducation.DisplayMember = "education_Desc";
                ucEducation.ValueMember = "education_Desc";
                ucEducation.DataSource = ucEducation_DataTable;


                var ucEconomicSector_DataTable = new DAL.GeneralDataSetTableAdapters.Counterparty_EconomicTableAdapter().GetData();
                ucEconomicPart.DisplayMember = "Counterparty_eco_Desc";
                ucEconomicPart.ValueMember = "Counterparty_eco_Desc";
                ucEconomicPart.DataSource = ucEconomicSector_DataTable;


                DataTable marital=new DataTable();
                marital.Columns.Add("maritalStatus");

                DataRow r = marital.NewRow();
                r["maritalStatus"] = "متأهل";

                DataRow t = marital.NewRow();
                t["maritalStatus"] = "مجرد";

                marital.Rows.Add(r);
                marital.Rows.Add(t);
                ucMaritalStatus.DisplayMember = "maritalStatus";
                ucMaritalStatus.ValueMember = "maritalStatus";
                ucMaritalStatus.DataSource = marital;

               

                DataTable sex = new DataTable();
                sex.Columns.Add("sex");

                DataRow q1 = sex.NewRow();
                q1["sex"] = "مرد";

                DataRow q2 = sex.NewRow();
                q2["sex"] = "زن";

                sex.Rows.Add(q1);
                sex.Rows.Add(q2);
                ucSex.DisplayMember = "sex";
                ucSex.ValueMember = "sex";
                ucSex.DataSource = sex;



                */
                #endregion
            }
            catch (Exception exception)
            {
                exception.ConfigLog(false, "خطا در بارگزاری داده رخ");
                Close();
            }
        }

        void ucfOrganization_DropDownOpening(object sender, EventArgs e)
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

        private void txtCounterparty_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            try
            {
                if (e.Button.Key == "Search")
                {
                    if (txtCounterparty.Text.Trim().Length == 0 || !txtCounterparty.Text.IsNumber())
                    {
                        Routines.ShowInfoMessageFa("خطا", "کد معتبری برای مشتری وارد نشده است", MyDialogButton.OK);
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
        public string SafeFarsiStr(string input)
        {
            return input.Replace("ی", "ي").Replace("ک", "ك");
        }

        private string GetFilter()
        {
            try
            {
                var fil_CounterpartyType = ucfCounterPartyType.GetFilterStructureForSql();
                var fil_ContractType = ucFilteringContractTypeCodeDep.GetFilterStructureForSql();
                var fil_Currency = ucfCurrency.GetFilterStructureForSql();
                var fil_ContractTypeCode = ucfContractTypeDep.GetFilterStructureForSql();

                var fil_DepositContractStatus = ucfDepositContractStatus.GetFilterStructureForSql();

                var fil_sex = ucSex.GetFilterStructureForSql();
                var fil_Sokunat = ucSokunat.GetFilterStructureForSql();
                
                var fil_Nationality = ucNationality.GetFilterStructureForSql();
                var fil_MaritalStatus = ucMaritalStatus.GetFilterStructureForSql();
                var fil_JobType = ucJobType.GetFilterStructureForSql();
                var fil_EconomicPart = ucEconomicPart.GetFilterStructureForSql();
                var fil_CompanyType = ucCompanyType.GetFilterStructureForSql();



                var fil_Counterparty = "";
                if (chbCounterparty.Checked && txtCounterPartyName.Tag != null && txtCounterPartyName.Tag.ToString().Length > 0)
                {
                    var item = txtCounterPartyName.Tag;
                    fil_Counterparty += fil_Counterparty.Trim().Length == 0
                                            ? "(Counterparty = " + item + " "
                                            : " OR Counterparty = " + item;
                    if (fil_Counterparty.Trim().IsNullOrEmptyByTrim() == false)
                        fil_Counterparty += ")";
                }



                var fil_State = ucfState.GetFilterStructureForSql();


                var fil_Organization = ucfOrganization.GetFilterStructureForSql();

                var fil_CustomerGroup = ucfCustomerGroup.GetFilterStructureForSql();





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


                if (fil_Currency.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_Currency;
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

                

                if (fil_DepositContractStatus.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_DepositContractStatus;
                }



                if (fil_sex.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_sex;
                }
                if (fil_Sokunat.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_Sokunat;
                }
                if (fil_Nationality.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_Nationality;
                }
                if (fil_MaritalStatus.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_MaritalStatus;
                }
                if (fil_JobType.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_JobType;
                }
                if (fil_EconomicPart.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_EconomicPart;
                }
                if (fil_CompanyType.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_CompanyType;
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

                // Darakhaste Monfared + Yousefi -> Ke tanha karabarane Arshad betavanand etelaate Shobe "منابع انسانی" ra bebinand
                if (ERMS.Model.GlobalInfo.User_Group_Id != 1)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += " Branch <> 2525 ";
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

        private void frmDepositReportcs_Load(object sender, EventArgs e)
        {
            string Error = "";
            try
            {
                FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

                fdpFromStartDate.SelectedDateTime = DateTime.Now;
                fdpFromStartDate.ResetSelectedDateTime();
                Error += "1,";
                fdpToStartDate.SelectedDateTime = DateTime.Now.AddDays(1);
                fdpToStartDate.ResetSelectedDateTime();
                Error += "2,";
                fdpFromMaturityDate.SelectedDateTime = DateTime.Now;
                fdpFromMaturityDate.ResetSelectedDateTime();
                Error += "3,";
                fdpToMaturityDate.SelectedDateTime = DateTime.Now.AddDays(1);
                fdpToMaturityDate.ResetSelectedDateTime();
                Error += "4,";
                var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                    "VDepositReport");
                Error += "5,";
                ucSelectColumn.NameOfDisplay = "AliasName";
                ucSelectColumn.NameOfValue = "NameColumn";
                ucSelectColumn.DataSource = columnsForShowInReport;
                Error += "6,";

                ConfReportsList();
            }
            catch (Exception exception)
            {
                Routines.ShowErrorMessageFa("Title", exception.Message + "\n" + Error, MyDialogButton.OK);
                exception.ConfigLog(true);
            }
        }

        private void ConfReportsList()
        {
            try
            {
                trnReport.Nodes.Clear();
                var reportsTable = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataByReportTable("VDepositReport", ERMS.Model.GlobalInfo.UserID);
                reportsTable.ForEach(item => trnReport.Nodes.Add(new UltraTreeNode(item.Id.ToString(), item.ReportName)));
            }
            catch (Exception exception)
            {
                exception.ConfigLog();
            }
        }

        private void chbStartDate_CheckedChanged(object sender, EventArgs e)
        {
            //pnlStartDate.Enabled = chbStartDate.Checked;
            fdpFromStartDate.Enabled = chbStartDate.Checked;
            fdpToStartDate.Enabled = chbStartDate.Checked;
        }

        private void chbMaturityDate_CheckedChanged(object sender, EventArgs e)
        {
            //pnlMaturityDate.Enabled = chbMaturityDate.Checked;
            fdpFromMaturityDate.Enabled = chbStartDate.Checked;
            fdpToMaturityDate.Enabled = chbStartDate.Checked;
        }

        private void chbCounterparty_CheckedChanged(object sender, EventArgs e)
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

        private void btnShowNormalReport_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    if (rdbDate_Today.Checked)
            //    {
            //        Routines.ShowProcess();
            //        var filter = GetFilter();
            //        var report = new DepositDataSet().GetDepositReportByPaging(ucSelectColumn.GetSelectedItem(),
            //                                                                   ucSelectColumn.GetSelectedItemForQuerySql
            //                                                                       (), filter, "1", "100000");
            //        Routines.HideProcess();
            //        var frmShowReprt = new Report.frmShowReprt(report)
            //                               {
            //                                   SCA = ucSelectColumn.GetSelectedItem(),
            //                                   SCAA = ucSelectColumn.GetSelectedItemForQuerySql(),
            //                                   F = filter,
            //                                   TN = "VDepositReport"
            //                               };
            //        frmShowReprt.ShowDialog();
            //    }
            // baraye historic sakhatane report
            //else if(rdbDate_Historic.Checked)
            //{
            //    Routines.ShowProcess();
            //    var filter = GetFilter();


            //    // Add Historic Date to Filter
            //    var fil_HistoricDate = "";
            //    if (rdbDate_Historic.Checked)
            //    {
            //        if (fdpHistoricDate.Text.Trim().Length != 0)
            //            fil_HistoricDate += "  Historic_Date ='" + fdpHistoricDate.SelectedDateTime.ToString("yyyy-MM-dd") + "' ";
            //    }
            //    if (fil_HistoricDate.Trim().Length != 0)
            //    {
            //        if (filter.Trim().Length != 0) filter += " and ";
            //        filter += fil_HistoricDate;
            //    }
            //}

            // }
            try
            {
                    var fil_HistoricDate = "";
                    if (rdbDate_Historic.Checked)
                    {
                        if (fdpHistoricDate.Text.Equals("[هیج مقداری انتخاب نشده]") || fdpHistoricDate.Text.Trim().Length == 0)
                        {
                            Routines.ShowInfoMessageFa("خطا", "تاریخ معتبر وارد نشده است", MyDialogButton.OK);
                            return;
                        }
                        else
                            fil_HistoricDate += fdpHistoricDate.SelectedDateTime.ToString("yyyy-MM-dd");
                        //fil_HistoricDate += "  Historic_Date ='" + fdpHistoricDate.SelectedDateTime.ToString("yyyy-MM-dd") + "' ";
                    }

                    if (ucSelectColumn.GetSelectedItem().Count() < 1)
                    {
                        Routines.ShowInfoMessageFa("خطا", "هیچ ستونی برای نمایش انتخاب نشده است", MyDialogButton.OK);
                        return;
                    }

                    Routines.ShowProcess();
                    var filter = GetFilter();
                    if (rdbDate_Today.Checked)
                    {
                        var report = new DepositDataSet().GetDepositReportByPaging(ucSelectColumn.GetSelectedItem(),
                                                                             ucSelectColumn.GetSelectedItemForQuerySql(),
                                                                             filter,
                                                                             Resources.StartIndexForReportShow,
                                                                             Resources.MaxSizeOfRowForReport);
                        Routines.HideProcess();
                       var frmShowReprt = new Report.frmShowReprt(report)
                        {
                            SCA = ucSelectColumn.GetSelectedItem(),
                            SCAA = ucSelectColumn.GetSelectedItemForQuerySql(),
                            F = filter,
                            TN = Resources.KEY_NameOfDepositReport
                            //.KEY_NameOfLoanReport
                        };
                        frmShowReprt.ShowDialog();
                    }
                    else if (rdbDate_Historic.Checked)
                    {
                        // baraye historic sakhatane report
                        // Add Historic Date to Filter

                        //if (fil_HistoricDate.Trim().Length != 0)
                        //{
                        //    if (filter.Trim().Length != 0) filter += " and ";
                        //    filter += fil_HistoricDate;
                        //}

                        if (filter.Length > 0)
                            filter = filter + " and VDepositReport_Historic.Historic_Date = cast('" + fil_HistoricDate + "'as datetime)";
                        else
                        {
                            filter = " where VDepositReport_Historic.Historic_Date = cast('" + fil_HistoricDate + "'as datetime)";
                        }
                        var report = new DepositDataSet().GetDepositHistoricReportByPaging(ucSelectColumn.GetSelectedItem(),
                                                                             ucSelectColumn.GetSelectedItemForQuerySql(),
                                                                             filter,
                                                                             null,
                                                                             Resources.StartIndexForReportShow,
                                                                             Resources.MaxSizeOfRowForReport);

                        Routines.HideProcess();
                        var frmShowReprt = new Report.frmShowReprt(report)
                        {
                            SCA = ucSelectColumn.GetSelectedItem(),
                            SCAA = ucSelectColumn.GetSelectedItemForQuerySql(),
                            F = filter,
                            TN = Resources.KEY_NameOfDepositReport
                            //KEY_NameOfLoanReport
                        };
                        frmShowReprt.ShowDialog();
                    }
                }
                catch (Exception exception)
                {
                    Routines.HideProcess();
                    exception.ConfigLog(true);
                }            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ucSelectColumn.GetSelectedItem().Count() < 1)
                {
                    Utilize.Routines.ShowInfoMessageFa("خطا", "هیچ ستونی برای نمایش انتخاب نشده است", Utilize.MyDialogButton.OK);
                    return;
                }

                if (rdbDate_Today.Checked)
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
                        newRepor.ReportTable = "VDepositReport";
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
                        ReportId = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetData().Max(item => item.Id);
                        Routines.ShowInfoMessageFa("ایجاد گزارش", string.Format("گزارش {0} با موفقیت ثبت شد", value), MyDialogButton.OK);
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

                        new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().Update(swartReport.SCAA
                                                                , swartReport.Filter, swartReport.SC, swartReport.User_Id, swartReport.Id);
                        ConfReportsList();
                        Routines.ShowInfoMessageFa("تغییر گزارش",
                                                   string.Format("تغییرات گزارش {0} با موفقیت ثبت شد",
                                                                 swartReport.ReportName),
                                                   MyDialogButton.OK);
                    }
                }
                else if (rdbDate_Historic.Checked)
                {
                    if (ReportId.HasValue == false)
                    {
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
                            //fil_HistoricDate += "  Historic_Date ='" + fdpHistoricDate.SelectedDateTime.ToString("yyyy-MM-dd") + "' ";
                        }


                        var filter = GetFilter();

                        if (filter.Length > 0)
                            filter = filter + " and VDepositReport_Historic.Historic_Date = cast('" + fil_HistoricDate + "'as datetime)";
                        else
                        {
                            filter = " where VDepositReport_Historic.Historic_Date = cast('" + fil_HistoricDate + "'as datetime)";
                        }

                        var frmInputText = new frmInputText { Topic = "نام گزارش" };
                        frmInputText.ShowDialog();
                        var value = frmInputText.ReturnValue;
                        if (value == null) return;
                        var newRepor = new GeneralDataSet.SWART_ReportsDataTable().NewSWART_ReportsRow();
                        newRepor.ReportName = value;
                        newRepor.ReportTable = "VDepositReport";
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
                            //fil_HistoricDate += "  Historic_Date ='" + fdpHistoricDate.SelectedDateTime.ToString("yyyy-MM-dd") + "' ";
                        }


                        var filter = GetFilter();

                        if (filter.Length > 0)
                            filter = filter + " and VDepositReport_Historic.Historic_Date = cast('" + fil_HistoricDate + "'as datetime)";
                        else
                        {
                            filter = " where VDepositReport_Historic.Historic_Date = cast('" + fil_HistoricDate + "'as datetime)";
                        }

                        swartReport.Filter = filter;
                        swartReport.SCAA = ucSelectColumn.GetSelectedItemForQuerySql();
                        swartReport.SC = ucSelectColumn.GetSelectedItem();
                        swartReport.User_Id = ERMS.Model.GlobalInfo.UserID;

                        new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().Update(swartReport.SCAA
                                        , swartReport.Filter, swartReport.SC, swartReport.User_Id, swartReport.Id);

                        ConfReportsList();
                        Utilize.Routines.ShowInfoMessageFa("تغییر گزارش",
                                                   string.Format("تغییرات گزارش {0} با موفقیت ثبت شد",
                                                                 swartReport.ReportName),
                                                   Utilize.MyDialogButton.OK);
                    }
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
                if (trnReport.SelectedNodes.Count <= 0)
                {
                    ReportId = null;
                    return;
                }
                CLEARALL();
                var node = trnReport.SelectedNodes[0];
                var index = node.Key.ToLong();
                ReportId = index;
                var report = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataById(index).FirstOrDefault();
                ucSelectColumn.SetSelectedItem(report.SCAA);

                var filters = report.Filter.Replace("where", "").Trim().Split(new[] { "and" }, StringSplitOptions.RemoveEmptyEntries);

                bool STATE_ID = false,
                     BRANCH = false,
                     CONTRACT_TYPE = false,
                     CURRENCY = false,
                     CUSTOMER_GROUP = false,
                     COUNTERPARTY_TYPE = false,
                     START_DATE = false,
                     MATURITY_DATE = false,
                     COUNTERPARTY = false,
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

                if (!report.Filter.Contains("where VDepositReport_Historic.Historic_Date") && !report.Filter.Contains(" and VDepositReport_Historic.Historic_Date = cast('"))
                {
                    rdbDate_Today.Checked = true;
                    fdpHistoricDate.SelectedDateTime = DateTime.Now;
                    fdpHistoricDate.ResetSelectedDateTime();
                }

                if (!report.Filter.Contains("where VDepositReport_Historic.Historic_Date"))
                {

                    foreach (var filter in filters)
                    {
                        # region HistoricDate
                        if (filter.Contains("Historic_Date ="))
                        {
                            rdbDate_Historic.Checked = true;
                            string dt = filter.Substring(filter.IndexOf("'") + 1, 10);
                            DateTime date = new DateTime(Int32.Parse(dt.Split('-')[0]), Int32.Parse(dt.Split('-')[1])
                                                            , Int32.Parse(dt.Split('-')[2]));
                            rdbDate_Historic.Checked = true;
                            fdpHistoricDate.SelectedDateTime = date;
                        }
                        #endregion


                        #region sex

                        if (filter.ToUpper().Contains("sex"))
                        {
                            ucSex.SetSelectedItem(
                                filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                    new[] { "sex =" }, StringSplitOptions.RemoveEmptyEntries));
                            SEX = true;
                        }
                        else
                        {
                            if (SEX == false)
                                ucSex.ClearItem();
                        }
                        #endregion

                        #region Education

                        if (filter.ToUpper().Contains("education_Desc"))
                        {
                            ucEducation.SetSelectedItem(
                                filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                    new[] { "education_Desc =" }, StringSplitOptions.RemoveEmptyEntries));
                            EDUCATION = true;
                        }
                        else
                        {
                            if (EDUCATION == false)
                                ucSex.ClearItem();
                        }
                        #endregion



                        #region MaritalStatus

                        if (filter.ToUpper().Contains("maritalStatus"))
                        {
                            ucMaritalStatus.SetSelectedItem(
                                filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                    new[] { "maritalStatus =" }, StringSplitOptions.RemoveEmptyEntries));
                            MaritalStatus = true;
                        }
                        else
                        {
                            if (MaritalStatus == false)
                                ucMaritalStatus.ClearItem();
                        }
                        #endregion

                        #region SOKUNAT

                        if (filter.ToUpper().Contains("residentType_Desc"))
                        {
                            ucSokunat.SetSelectedItem(
                                filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                    new[] { "residentType_Desc =" }, StringSplitOptions.RemoveEmptyEntries));
                            SOKUNAT = true;
                        }
                        else
                        {
                            if (SOKUNAT == false)
                                ucSokunat.ClearItem();
                        }
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

                        if (filter.ToUpper().Contains("Counterparty_eco_Desc"))
                        {
                            ucEconomicPart.SetSelectedItem(
                                filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                    new[] { "Counterparty_eco_Desc =" }, StringSplitOptions.RemoveEmptyEntries));
                            ECONOMIC_PART = true;
                        }
                        else
                        {
                            if (ECONOMIC_PART == false)
                                ucEconomicPart.ClearItem();
                        }
                        #endregion

                        #region CompanyType

                        if (filter.ToUpper().Contains("Company_Type_Desc"))
                        {
                            ucCompanyType.SetSelectedItem(
                                filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                    new[] { "Company_Type_Desc =" }, StringSplitOptions.RemoveEmptyEntries));
                            COMPANY_NAME = true;
                        }
                        else
                        {
                            if (COMPANY_NAME == false)
                                ucCompanyType.ClearItem();
                        }
                        #endregion

                        #region JobType

                        if (filter.ToUpper().Contains("Job_Type_Desc"))
                        {
                            ucJobType.SetSelectedItem(
                                filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                    new[] { "Job_Type_Desc =" }, StringSplitOptions.RemoveEmptyEntries));
                            JOB_TYPE = true;
                        }
                        else
                        {
                            if (JOB_TYPE == false)
                                ucJobType.ClearItem();
                        }
                        #endregion



                        #region State

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
                            ucFilteringContractTypeCodeDep.SetSelectedItem(
                                filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                    new[] { "CONTRACT_TYPE =" }, StringSplitOptions.RemoveEmptyEntries));
                            ucfContractTypeDep.SetSelectedItem(
                                filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                    new[] { "CONTRACT_TYPE =" }, StringSplitOptions.RemoveEmptyEntries));
                            CONTRACT_TYPE = true;
                        }
                        else
                        {
                            if (CONTRACT_TYPE == false)
                                ucFilteringContractTypeCodeDep.ClearItem();
                        }
                        #endregion

                        #region Currency

                        if (filter.ToUpper().Contains("CURRENCY"))
                        {
                            ucfCurrency.SetSelectedItem(
                                filter.ToUpper().Replace("(", "").Replace(")", "").Replace("OR", "").Replace("'", "").Split(
                                    new[] { "CURRENCY =" }, StringSplitOptions.RemoveEmptyEntries));
                            CURRENCY = true;
                        }
                        else
                        {
                            if (CURRENCY == false)
                                ucfCurrency.ClearItem();
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
                                filter.ToUpper().Replace("(", "").Replace(")", "").Trim().Substring(14).Trim();
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
                else
                {
                    # region HistoricDate

                    if (report.Filter.Contains("Historic_Date ="))
                    {
                        rdbDate_Historic.Checked = true;
                        string dt = report.Filter.Substring(report.Filter.IndexOf("'") + 1, 10);
                        DateTime date = new DateTime(Int32.Parse(dt.Split('-')[0]), Int32.Parse(dt.Split('-')[1])
                                                        , Int32.Parse(dt.Split('-')[2]));
                        rdbDate_Historic.Checked = true;
                        fdpHistoricDate.SelectedDateTime = date;
                    }

                    #endregion
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void CLEARALL()
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

            clearUCF();
            ReportId = null;
        }



        private void clearUCF()
        {
            ucfOrganization.ClearItem();
            ucfState.ClearItem();
            ucfCustomerGroup.ClearItem();
            ucfCurrency.ClearItem();
            ucfCounterPartyType.ClearItem();
            ucFilteringContractTypeCodeDep.ClearItem();
            ucfContractTypeDep.ClearItem();

            ucJobType.ClearItem();
            ucMaritalStatus.ClearItem();
            ucNationality.ClearItem();
            
            ucSex.ClearItem();
            ucSokunat.ClearItem();
            ucCompanyType.ClearItem();
            ucEducation.ClearItem();
           
            ucEconomicPart.ClearItem();
        }
        private void btnNewReport_Click(object sender, EventArgs e)
        {
            trnReport.SelectedNodes.Clear();
            CLEARALL();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            try
            {
                if (trnReport.SelectedNodes.Count <= 0)
                {
                    ReportId = null;
                    return;
                }
                var chart = new CHART.frmChart
                                {
                                    ReportType = "VDepositReport",
                                    MdiParent = this.MdiParent,
                                    Report_Id = trnReport.SelectedNodes[0].Key.ToLong()
                                };
                chart.Show();
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void btnRemoveReport_Click(object sender, EventArgs e)
        {
            if (trnReport.SelectedNodes.Count <= 0)
            {
                ReportId = null;
                return;
            }
            if (Routines.ShowQuestionMessageFa("حذف گزارش", "آیا از حذف گزارش مطمئن هستید؟", MyDialogButton.YesNO) == MyDialogResoult.No)
                return;
            try
            {
                var key = trnReport.SelectedNodes[0].Key;
                var row = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDataById(key.ToLong()).
                    FirstOrDefault();
                new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().Delete( row.Id);
                ConfReportsList();
                ReportId = null;
            }
            catch (Exception exception)
            {
                exception.ConfigLog(false, "حذف گزارش انتخاب شده با خطا روبرو شد");
            }
        }

        private void btnShowReport_2_Click(object sender, EventArgs e)
        {
            try
            {
                if (trnReport.SelectedNodes.Count <= 0)
                {
                    ReportId = null;
                    return;
                }
                var filter = GetFilter();
                var report = new DepositDataSet().GetDepositReportByPaging(ucSelectColumn.GetSelectedItem(), ucSelectColumn.GetSelectedItemForQuerySql(), filter, "1", "100000");
                var frmShowReprt = new Report.frmShowReprt(report) { SCA = ucSelectColumn.GetSelectedItem(), SCAA = ucSelectColumn.GetSelectedItemForQuerySql(), F = filter, TN = "VDepositReport" };
                frmShowReprt.ShowDialog();
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void cmsReport_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (trnReport.SelectedNodes.Count == 0)

                btnShowReport_2.Enabled = btnChart.Enabled = btnRemoveReport.Enabled = false;
            else
                btnShowReport_2.Enabled = btnChart.Enabled = btnRemoveReport.Enabled = true;
        }

        private void rdbDate_Historic_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbDate_Historic.Checked)
            {
                fdpHistoricDate.Enabled = true;
            }
            else
            {
                fdpHistoricDate.Enabled = true;
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

        private void chbCustCodeName_CheckedChanged(object sender, EventArgs e)
        {
            cgbCustCodeName.Enabled = chbCustCodeName.Checked;
            if (!chbCustCodeName.Checked)
            {
                chbCounterparty.Checked = false;
                chbCounterpartyName.Checked = false;
            }
        }

        private void rdbDate_Today_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDate_Historic.Checked)
            {
                fdpHistoricDate.Enabled = true;
                var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                    "VDepositReport_Historic");
                ucSelectColumn.NameOfDisplay = "AliasName";
                ucSelectColumn.NameOfValue = "NameColumn";
                ucSelectColumn.DataSource = null;
                ucSelectColumn.DataSource = columnsForShowInReport;
            }
            else
            {
                fdpHistoricDate.Enabled = false;
                var columnsForShowInReport = new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByNameReport(
                    "VDepositReport");
                ucSelectColumn.NameOfDisplay = "AliasName";
                ucSelectColumn.NameOfValue = "NameColumn";
                ucSelectColumn.DataSource = null;
                ucSelectColumn.DataSource = columnsForShowInReport;
            }
        }

    }
}
