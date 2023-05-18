using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using Infragistics.Win.UltraWinGrid;
using Janus.Windows.UI.Tab;
using Presentation.Public;
using Utilize.Grid;
using Utilize.Helper;
using MyDialogButton = Utilize.MyDialogButton;
using Routines = Utilize.Routines;

namespace Presentation.Loan
{
    public partial class frmTotalLoanReport :Form
    {
        public frmTotalLoanReport()
        {
            InitializeComponent();
        }

        private void frmTotalLoanReport_Load(object sender, EventArgs e)
        {
            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

            fdpFrom.SelectedDateTime = DateTime.Now;
            fdpFrom.ResetSelectedDateTime();

            fdpTo.SelectedDateTime = DateTime.Now.AddDays(1);
            fdpTo.ResetSelectedDateTime();
        }

        private string _strWhere = "";
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (fdpFrom.Text.TryDateTime() && fdpTo.Text.TryDateTime())
            {
                if (fdpTo.SelectedDateTime.CompareTo(fdpFrom.SelectedDateTime) <= 0)
                {
                    Routines.ShowErrorMessageFa("خطا در ورود اطلاعات", "تاریخ شروع باید از تاریخ پایان کوچکتر باشد.", MyDialogButton.OK);
                    return;
                }
                _strWhere = " where Start_Date between '" + fdpFrom.SelectedDateTime.ToString("yyyy-MM-dd") + "' and '" + fdpTo.SelectedDateTime.ToString("yyyy-MM-dd") + "' ";
                groupBox1.Enabled = tabMain.Enabled = true;
                //chbTotal.Checked = true;
            }
            else
            {
                Routines.ShowErrorMessageFa("خطا در ورود اطلاعات", "تاریخ شروع/پایان گزارش وارد نشده است.",
                                                    MyDialogButton.OK);
            }
        }

        private void chbTotal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbTotal.Checked)
                {
                    ProgressBox.Show();
                    var uiTab = new UITab { Text = chbTotal.Text, Name = chbTotal.Name, Dock = DockStyle.Fill };
                    var table = new DAL.LoanDataSet().GetTotalLoanReport(_strWhere);
                    uiTab.TabPages.Add(new UITabPage { Text = chbTotal.Text, Key = chbTotal.Name, Name = chbTotal.Name });
                    var newMyGrid_V2 = new MyGrid_V2(table.ConfigDateTimeToPersian()) { Dock = DockStyle.Fill };
                    newMyGrid_V2.eventShowChart += new EventHandler(newMyGrid_V2_eventShowChart);
                    newMyGrid_V2.eventSaveReportExcelClick += new EventHandler(newMyGrid_V2_eventSaveReportExcelClick);
                    uiTab.TabPages[chbTotal.Name].Controls.Add(newMyGrid_V2);
                    tabMain.TabPages.Add(new UITabPage { Text = chbTotal.Text, Key = chbTotal.Name, Name = chbTotal.Name });
                    tabMain.TabPages[chbTotal.Name].Controls.Add(uiTab);
                    table.Dispose();
                    ProgressBox.Hide();
                }
                else
                {
                    var tabPage=tabMain.TabPages.Cast<UITabPage>().Where(item => item.Key.Equals(chbTotal.Name)).FirstOrDefault();
                    tabMain.TabPages.Remove(tabPage);
                    tabPage.Dispose();
                }
            }
            catch (Exception exception)
            {

                ProgressBox.Hide();
                exception.ConfigLog(false);
            }
        }

        static void newMyGrid_V2_eventSaveReportExcelClick(object sender, EventArgs e)
        {
            var frmSe = new Report.FrmSaveExcel(false, false, false, false) { SourceData = sender as UltraGrid };
            frmSe.ShowDialog();
        }

        static void newMyGrid_V2_eventShowChart(object sender, EventArgs e)
        {
            var table = ((DataTable)sender);
            var frmchart = new Public.frmChart
                               {
                                   colYName = "سرپرستی",
                                   DataSource = table,
                                   columns =
                                       table.Columns.Cast<DataColumn>().Where(item => item.ColumnName != "سرپرستی").
                                       Select(item => item.ColumnName)
                               };
            frmchart.ShowDialog();
        }

        private void ConfReport(CheckBox checkBox, DataTable table, string ColName, string ColNameId, string ColNameValue)
        {
            try
            {
                ProgressBox.Show();
                if (checkBox.Checked)
                {
                    var uiTab = new UITab { Text = checkBox.Text, Name = checkBox.Name, Dock = DockStyle.Fill };
                    var result = Parallel.ForEach(table.Rows.Cast<DataRow>(),
                                     row =>
                                     {
                                         var _table =
                                             new DAL.LoanDataSet().GetTotalLoanReport(string.Format("{0} and {1} ",
                                                                                                    _strWhere,
                                                                                                    ColName + "='" +
                                                                                                    row[ColNameId] + "'"));
                                         if(_table.Rows.Count==0)return;
                                         uiTab.TabPages.Add(new UITabPage
                                                                {
                                                                    Name = row[ColNameId].ToString(),
                                                                    Text = row[ColNameValue].ToString(),
                                                                    Key = row[ColNameId].ToString()
                                                                });
                                         var newMyGrid_V2 = new MyGrid_V2(_table.ConfigDateTimeToPersian())
                                         {
                                             Dock = DockStyle.Fill
                                         };
                                         newMyGrid_V2.eventShowChart += new EventHandler(newMyGrid_V2_eventShowChart);
                                         newMyGrid_V2.eventSaveReportExcelClick += new EventHandler(newMyGrid_V2_eventSaveReportExcelClick);
                                         uiTab.TabPages[row[ColNameId].ToString()].Controls.Add(newMyGrid_V2);
                                         _table.Dispose();
                                     });
                    if (result.IsCompleted)
                    {
                        tabMain.TabPages.Add(new UITabPage { Name = checkBox.Name, Text = checkBox.Text, Key = checkBox.Name });
                        tabMain.TabPages[checkBox.Name].Controls.Add(uiTab);
                    }
                }
                else
                {
                    tabMain.TabPages.Remove(
                       tabMain.TabPages.Cast<UITabPage>().Where(item => item.Key.Equals(checkBox.Name)).FirstOrDefault());
                }
                ProgressBox.Hide();
            }
            catch (Exception exception)
            {

                ProgressBox.Hide();
                exception.ConfigLog(true);

            }
        }

        private void chbMajorTypeContract_CheckedChanged(object sender, EventArgs e)
        {
            ConfReport(chbMajorTypeContract,
                       new DAL.LoanDataSetTableAdapters.Contract_Major_TypeTableAdapter().GetData(), "Contract_MType",
                       "Contract_MType_id", "Contract_MType_Desc");
        }

        private void chbContractType_CheckedChanged(object sender, EventArgs e)
        {
            ConfReport(chbContractType,
                       new DAL.GeneralDataSetTableAdapters.Contract_TypeTableAdapter().GetDataByLoan(),
                       "Contract_Type",
                       "Contract_Type",
                       "Contract_Type_Description");
            //if (chbContractType.Checked)
            //{

            //    foreach (var row in new DAL.LoanDataSetTableAdapters.Contract_TypeTableAdapter().GetData().Where(item => item.Contract_LD == 1))
            //    {
            //        var table =
            //            new DAL.LoanDataSet().GetTotalLoanReport(string.Format("{0} and {1} ", _strWhere,
            //                                                                   "Contract_Type='" + row.Contract_Type + "'"));
            //        tabControl1.TabPages.Add(chbContractType.Name + "-" + row.Contract_Type, row.Contract_Type_Description);
            //        tabControl1.TabPages[chbContractType.Name + "-" + row.Contract_Type].Controls.Add(new MyGrid_V2(table));
            //    }
            //}
            //else
            //{
            //    foreach (var row in new DAL.LoanDataSetTableAdapters.Contract_TypeTableAdapter().GetData().Where(item => item.Contract_LD == 1))
            //    {
            //        tabControl1.TabPages.RemoveByKey(chbContractType.Name + "-" + row.Contract_Type);
            //    }
            //}
        }

        private void chbContractTypeGroups_CheckedChanged(object sender, EventArgs e)
        {
            ConfReport(chbContractTypeGroups,
                       new DAL.LoanDataSetTableAdapters.Contract_type_groupsTableAdapter().GetData(),
                       "Contract_Type_Group",
                       "Contract_type_group_id",
                       "Contract_type_group_Desc");
            //if (chbContractTypeGroups.Checked)
            //{

            //    foreach (var row in new DAL.LoanDataSetTableAdapters.Contract_type_groupsTableAdapter().GetData())
            //    {
            //        var table =
            //            new DAL.LoanDataSet().GetTotalLoanReport(string.Format("{0} and {1} ", _strWhere,
            //                                                                   "Contract_Type_Group='" + row.Contract_type_group_id + "'"));
            //        tabControl1.TabPages.Add(chbContractTypeGroups.Name + "-" + row.Contract_type_group_id, row.Contract_type_group_Desc);
            //        tabControl1.TabPages[chbContractTypeGroups.Name + "-" + row.Contract_type_group_id].Controls.Add(new MyGrid_V2(table));
            //    }
            //}
            //else
            //{
            //    foreach (var row in new DAL.LoanDataSetTableAdapters.Contract_type_groupsTableAdapter().GetData())
            //    {
            //        tabControl1.TabPages.RemoveByKey(chbContractTypeGroups.Name + "-" + row.Contract_type_group_id);
            //    }
            //}
        }

        private void chbEconomicSector_CheckedChanged(object sender, EventArgs e)
        {
            ConfReport(chbEconomicSector,
                       new DAL.GeneralDataSetTableAdapters.Economic_SectorTableAdapter().GetData(),
                       "Economic_Sector",
                       "Economic_Sector",
                       "Economic_Sector_Desc");
            //if (chbEconomicSector.Checked)
            //{

            //    foreach (var row in new DAL.LoanDataSetTableAdapters.Economic_SectorTableAdapter().GetData())
            //    {
            //        var table =
            //            new DAL.LoanDataSet().GetTotalLoanReport(string.Format("{0} and {1} ", _strWhere,
            //                                                                   "Economic_Sector='" + row.Economic_Sector + "'"));
            //        tabControl1.TabPages.Add(chbEconomicSector.Name + "-" + row.Economic_Sector, row.Economic_Sector_Desc);
            //        tabControl1.TabPages[chbEconomicSector.Name + "-" + row.Economic_Sector].Controls.Add(new MyGrid_V2(table));
            //    }
            //}
            //else
            //{
            //    foreach (var row in new DAL.LoanDataSetTableAdapters.Economic_SectorTableAdapter().GetData())
            //    {
            //        tabControl1.TabPages.RemoveByKey(chbMajorTypeContract.Name + "-" + row.Economic_Sector);
            //    }
            //}
        }

        private void chbCounterpartyType_CheckedChanged(object sender, EventArgs e)
        {
            ConfReport(chbCounterpartyType,
                       new DAL.GeneralDataSetTableAdapters.Counterparty_TypeTableAdapter().GetData(),
                       "Counterparty_Type",
                       "Counterparty_Type",
                       "Counterparty_Type_Desc");
            //if (chbCounterpartyType.Checked)
            //{

            //    foreach (var row in new DAL.LoanDataSetTableAdapters.Counterparty_TypeTableAdapter().GetData())
            //    {
            //        var table =
            //            new DAL.LoanDataSet().GetTotalLoanReport(string.Format("{0} and {1} ", _strWhere,
            //                                                                   "Counterparty_Type='" + row.Counterparty_Type + "'"));
            //        tabControl1.TabPages.Add(chbCounterpartyType.Name + "-" + row.Counterparty_Type, row.Counterparty_Type_Desc);
            //        tabControl1.TabPages[chbCounterpartyType.Name + "-" + row.Counterparty_Type].Controls.Add(new MyGrid_V2(table));
            //    }
            //}
            //else
            //{
            //    foreach (var row in new DAL.LoanDataSetTableAdapters.Counterparty_TypeTableAdapter().GetData())
            //    {
            //        tabControl1.TabPages.RemoveByKey(chbMajorTypeContract.Name + "-" + row.Counterparty_Type);
            //    }
            //}

        }

        private void chbCustomerGroup_CheckedChanged(object sender, EventArgs e)
        {
            ConfReport(chbCustomerGroup,
                      new DAL.GeneralDataSetTableAdapters.Customer_GroupTableAdapter().GetData(),
                       "Customer_Group",
                       "Customer_Group",
                       "Customer_Group_Description");
            //if (chbCustomerGroup.Checked)
            //{

            //    foreach (var row in new DAL.LoanDataSetTableAdapters.Customer_GroupTableAdapter().GetData())
            //    {
            //        var table =
            //            new DAL.LoanDataSet().GetTotalLoanReport(string.Format("{0} and {1} ", _strWhere,
            //                                                                   "Customer_Group='" + row.Customer_Group + "'"));
            //        tabControl1.TabPages.Add(chbCustomerGroup.Name + "-" + row.Customer_Group, row.Customer_Group_Description);
            //        tabControl1.TabPages[chbCustomerGroup.Name + "-" + row.Customer_Group].Controls.Add(new MyGrid_V2(table));
            //    }
            //}
            //else
            //{
            //    foreach (var row in new DAL.LoanDataSetTableAdapters.Customer_GroupTableAdapter().GetData())
            //    {
            //        tabControl1.TabPages.RemoveByKey(chbMajorTypeContract.Name + "-" + row.Customer_Group);
            //    }
            //}
        }

    }
}
