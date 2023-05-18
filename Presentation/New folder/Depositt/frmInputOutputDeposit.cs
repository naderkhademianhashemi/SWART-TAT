using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using Presentation.Public;
using SpannedDataGridView;
using ERMSLib;
using System.Globalization;
using System.Collections.ObjectModel;
using Utilize.Helper;
using MyDialogButton = Presentation.Public.MyDialogButton;


namespace Presentation.Deposit
{
    public partial class frmInputOutputDeposit : BaseForm
    {

        #region Parameter

        DataTable ChartDataSourcePrice = new DataTable();
        DataTable ChartDataSourceCount = new DataTable();
        readonly Collection<Dundas.Charting.WinControl.Series> _series = new Collection<Dundas.Charting.WinControl.Series>();
        DataTable report;
        #endregion
        DataTable user;
        DataTable dtdeposit3, dtdeposit1, dtdeposit2;
        public frmInputOutputDeposit()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
            GeneralDataGridView = this.dgvDMReport;
            Load += frmInputOutput_Load;
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

        void dgvResoult_eventSaveReportExcelClick1(object sender, EventArgs e)
        {
            var frmSaveExcel = new Report.FrmSaveExcel(false, false, false, false)
            {
                SourceData = dgvResoult1.ugd
            };
            frmSaveExcel.ShowDialog();
            frmSaveExcel.Dispose();
        }

        void dgvResoult_eventSaveReportExcelClick2(object sender, EventArgs e)
        {
            var frmSaveExcel = new Report.FrmSaveExcel(false, false, false, false)
            {
                SourceData = dgvResoult2.ugd
            };
            frmSaveExcel.ShowDialog();
            frmSaveExcel.Dispose();
        }



        void frmInputOutput_Load(object sender, EventArgs e)
        {
            dgvResoult.eventSaveReportExcelClick += dgvResoult_eventSaveReportExcelClick;
            dgvResoult1.eventSaveReportExcelClick += dgvResoult_eventSaveReportExcelClick1;
            dgvResoult2.eventSaveReportExcelClick += dgvResoult_eventSaveReportExcelClick2;
            user = new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(ERMS.Model.GlobalInfo.UserID);

            #region State And Organization

            cmbCity.DropDownOpening += cmbCity_DropDownOpening;

            cmbBranch.DropDownOpening += cmbBranch_DropDownOpening;


            user = new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(ERMS.Model.GlobalInfo.UserID);

            if (user.Rows.Count == 0)
            {
                var state_DataTable = new DAL.GeneralDataSetTableAdapters.StateTableAdapter().GetData();
                cmbStates.DisplayMember = "State_Name";
                cmbStates.ValueMember = "State_Id";
                cmbStates.DataSource = state_DataTable;

                var organization_DataTable = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();
                cmbBranch.DisplayMember = "Branch_Description";
                cmbBranch.ValueMember = "Branch";
                cmbBranch.DataSource = organization_DataTable;

                var cityDataTable = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData();
                cmbCity.DisplayMember = "City_Name";
                cmbCity.ValueMember = "City_ID";
                cmbCity.DataSource = cityDataTable;

            }
            else
            {
                var statesId = user.Rows.Cast<DataRow>().Select(item => new { Id = item["State_Id"].ToString() }).Distinct().ToArray();
                cmbStates.DisplayMember = "State_Name";
                cmbStates.ValueMember = "State_Id";
                cmbStates.DataSource = new DAL.GeneralDataSetTableAdapters.StateTableAdapter().GetData().Where(item => statesId.Any(stateId => stateId.Id.Equals(item.State_Id))).ToList();

                var branchesId = user.Rows.Cast<DataRow>().Select(item => new { Id = item["Branch"].ToString().ToInt() }).Distinct().ToArray();
                cmbBranch.DisplayMember = "Branch_Description";
                cmbBranch.ValueMember = "Branch";
                cmbBranch.DataSource = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(item => branchesId.Any(branchId => branchId.Id.Equals(item.Branch))).ToList();

                var cities = user.Rows.Cast<DataRow>().Select(item => new { Id = item["City_ID"].ToString().ToInt() }).Distinct().ToArray();
                cmbCity.DisplayMember = "City_Name";
                cmbCity.ValueMember = "City_ID";
                cmbCity.DataSource = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData().Where(item => cities.Any(cityId => cityId.Id.Equals(item.City_ID))).ToList();

            }

            #endregion
        }

        void cmbCity_DropDownOpening(object sender, EventArgs e)
        {
            try
            {
                cmbCity.DisplayMember = "City_Name";
                cmbCity.ValueMember = "City_Id";

                //بررسی اینکه فیلتر استان انتخاب شده باشد و
                // استان های انتخاب شده بیشتر از یک باشد
                if (cmbStates.IsChecked() && cmbStates.GetSelectedItem().Any())
                {
                    if (user.Rows.Count == 0)
                    {
                        var cities = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData().Where(
                           city => cmbStates.GetSelectedItem().Any(sta => sta.DataValue.ToString().Equals(city.State_ID_Fk.ToString(CultureInfo.InvariantCulture)))).ToArray();

                        cmbCity.DataSource = cities;
                    }
                    else
                    {
                        var cities = user.Rows.Cast<DataRow>().Where(city => cmbStates.GetSelectedItem().Any(sta => sta.DataValue.ToString().Equals(city["State_Id"].ToString())))
                        .Select(item => new { Id = item["City_Id"].ToString().ToInt() }).Distinct().ToArray();

                        cmbCity.DataSource = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData().Where(item => cities.Any(cityId => cityId.Id.Equals(item.City_ID))).ToList();
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
                    var cities = user.Rows.Cast<DataRow>().Select(item => new { Id = item["City_Id"].ToString().ToInt() }).Distinct().ToArray();
                    cmbCity.DataSource = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData().Where(item => cities.Any(cityId => cityId.Id.Equals(item.City_ID))).ToList();
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        void cmbBranch_DropDownOpening(object sender, EventArgs e)
        {
            try
            {
                cmbBranch.DisplayMember = "Branch_Description";
                cmbBranch.ValueMember = "Branch";

                //بررسی اینکه فیلتر شهر انتخاب شده باشد و
                // شهرهای انتخاب شده بیشتر از یک باشد
                if (cmbCity.IsChecked() && cmbCity.GetSelectedItem().Any())
                {
                    //بررسی اینکه فیلتر مکان برای این کاربر تنظیم شده است
                    if (user.Rows.Count == 0)
                    {
                        var branchs = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(item => cmbCity.GetSelectedItem().Any(city => city.DataValue.ToString().Equals(item.City_Of_Branch.ToString(CultureInfo.InvariantCulture)))).ToArray();
                        cmbBranch.DataSource = branchs;
                    }
                    else
                    {
                        var branchs = user.Rows.Cast<DataRow>().Where(org => cmbCity.GetSelectedItem().Any(city => city.DataValue.ToString().Equals(org["City_Id"].ToString())))
                        .Select(item => new { Id = item["Branch"].ToString().ToInt() }).Distinct().ToArray();

                        cmbBranch.DataSource = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(item => branchs.Any(branchId => branchId.Id.Equals(item.Branch))).ToList();
                    }

                    return;
                }

                //بررسی اینکه فیلتر استان انتخاب شده باشد و
                // استان های انتخاب شده بیشتر از یک باشد
                if (cmbStates.IsChecked() && cmbStates.GetSelectedItem().Any())
                {
                    if (user.Rows.Count == 0)
                    {
                        var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(
                           org => cmbStates.GetSelectedItem().Any(sta => sta.DataValue.ToString().Equals(org.State_Of_Branch.ToString(CultureInfo.InvariantCulture)))).ToArray();

                        cmbBranch.DataSource = organizations;
                    }
                    else
                    {
                        var branchs = user.Rows.Cast<DataRow>().Where(org => cmbStates.GetSelectedItem().Any(sta => sta.DataValue.ToString().Equals(org["State_Id"].ToString())))
                        .Select(item => new { Id = item["Branch"].ToString().ToInt() }).Distinct().ToArray();

                        cmbBranch.DataSource = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(item => branchs.Any(branchId => branchId.Id.Equals(item.Branch))).ToList();
                    }

                    return;
                }

                // در صورتی که نه فیلتر استان یا شهر انتخاب نشده باشد
                if (user.Rows.Count == 0)
                {
                    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();
                    cmbBranch.DataSource = organizations;
                }
                else
                {
                    var branchs =
                        user.Rows.Cast<DataRow>().Select(item => new { Id = item["Branch"].ToString().ToInt() }).Distinct().ToArray();
                    cmbBranch.DataSource = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(item => branchs.Any(branchId => branchId.Id.Equals(item.Branch))).ToList();
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        private void btnShowRpt_Click(object sender, EventArgs e)
        {
            ProgressBox.Show();
            dtdeposit1 = new DAL.DepositDataSet().GetInputOutputDeposit(fdpFrom.SelectedDateTime, fdpTo.SelectedDateTime,
                                                                        GetFilter());

            var dtdeposit_Input = dtdeposit1.Select("TRAN_IND = 'C'");//Rows.Cast<DataRow>().Where(row => row["TRAN_IND"].ToString().Equals("C"));
            var dtdeposit_output = dtdeposit1.Select("TRAN_IND = 'D'");//Rows.Cast<DataRow>().Where(row => row["TRAN_IND"].ToString().Equals("D"));

            
            var dataTableInput = new DataTable();
            var dataTableOutput = new DataTable();
            var dataTableSum = new DataTable();

            foreach (DataColumn item in dtdeposit1.Columns)
            {
                dataTableInput.Columns.Add(new DataColumn() { ColumnName = item.ColumnName, DataType = item.DataType });
                dataTableOutput.Columns.Add(new DataColumn() { ColumnName = item.ColumnName, DataType = item.DataType });
            }

            foreach (var item in dtdeposit_Input)
            {
                var row = dataTableInput.NewRow();
                row.ItemArray = item.
                    ItemArray;
                dataTableInput.Rows.Add(row);
            }

            foreach (var item in dtdeposit_output)
            {
                var row = dataTableOutput.NewRow();
                row.ItemArray = item.ItemArray;
                dataTableOutput.Rows.Add(row);
            }

            
            dataTableInput.Columns.Remove("TRAN_IND");
            dgvResoult1.DataSource = dataTableInput;

            dataTableOutput.Columns.Remove("TRAN_IND");
            dgvResoult2.DataSource = dataTableOutput;

            
            dataTableSum.Columns.Add(new DataColumn() { ColumnName = "نام شعبه", DataType = typeof(string) });
            dataTableSum.Columns.Add(new DataColumn() { ColumnName = "کد شعبه", DataType = typeof(string) });
            dataTableSum.Columns.Add(new DataColumn() { ColumnName = "مقدار ورود ", DataType = typeof(double) });
            dataTableSum.Columns.Add(new DataColumn() { ColumnName = "مقدار خروج", DataType = typeof(double) });

            var items = dtdeposit1.Rows.Cast<DataRow>().Select(row => new
            {
                branchId = row["شعبه"].ToString(),
                branchname=row["نام شعبه"].ToString(),
                Amount = Convert.ToDouble(row["مقدار ورود/خروج"].ToString()),
                Type = row["TRAN_IND"].ToString()
            });

            var res =items.GroupBy(p => new { p.branchId, p.Type,p.branchname }).Select(p =>
                new
                {
                    p.Key.branchId,
                    p.Key.branchname,
                    p.Key.Type,
                    am = p.Sum(i => i.Amount)
                });

            var branches = res.Select(item =>  item.branchId ).Distinct().ToArray();


            foreach (var id in branches)
            {
                var branchData = res.Where(p=>p.branchId.Equals(id));

                 dataTableSum.Rows.Add(branchData.First().branchname,id,
                     branchData.Any(p=>p.Type.Equals("C")) ?  branchData.FirstOrDefault(p=>p.Type.Equals("C")).am : 0,
                     branchData.Any(p=>p.Type.Equals("D")) ?  branchData.FirstOrDefault(p=>p.Type.Equals("D")).am : 0);
               
            }
            
            dgvResoult.DataSource = dataTableSum;
            ProgressBox.Hide();
        }

        private string GetFilter()
        {
            var fil = string.Empty;
            var allbranchs = cmbBranch.GetAllItems<DAL.GeneralDataSet.OrganizationRow>().ToList();

            if (cmbStates.IsChecked())
            {
                var selectedStateIds = cmbStates.GetCheckedObjects().OfType<string>();
                allbranchs.RemoveAll(item => selectedStateIds.Any(stateId => stateId.ToInt().Equals(item.State_Of_Branch)) == false);
            }

            if (cmbCity.IsChecked())
            {
                var selectedCityIds = cmbCity.GetCheckedObjects().OfType<int>();
                allbranchs.RemoveAll(item => selectedCityIds.Any(cityId => cityId.Equals(item.City_Of_Branch)) == false);
            }

            if (cmbBranch.IsChecked())
            {
                var selectedBranchIds = cmbBranch.GetCheckedObjects().OfType<int>();
                allbranchs.RemoveAll(item => selectedBranchIds.Any(branchId => branchId.Equals(item.Branch)) == false);
            }
            else
            {
                if (user.Rows.Count != 0)
                {
                    var branchesId = user.Rows.Cast<DataRow>().Select(item => new { Id = item["Branch"].ToString().ToInt() });
                    allbranchs.RemoveAll(item => branchesId.Any(branchId => branchId.Id.Equals(item.Branch)) == false);
                }
            }

            foreach (var item in allbranchs)
            {
                if (fil.IsNullOrEmptyByTrim() == false)
                    fil += ",";
                fil += item.Branch;

            }

            return fil;
        }

        private void btnShowReport_Load(object sender, EventArgs e)
        {

        }

        private void dgvResoult_Click(object sender, EventArgs e)
        {
            
        }






    }
}

