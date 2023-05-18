using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilize.Helper;
using Utilize;
using System.Collections.ObjectModel;


namespace Presentation.Loan
{
    public partial class frmHistorCopy : Form
    {
        DataTable user;
        readonly Collection<Dundas.Charting.WinControl.Series> _series = new Collection<Dundas.Charting.WinControl.Series>();


        public frmHistoricalLoanReport()
        {
            InitializeComponent();

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
               
               

            }
            catch (Exception exception)
            {
                exception.ConfigLog(false, "خطا در بارگزاری داده رخ");
                Close();
            }
            #endregion
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


        private void txtContract_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            try
            {
                if (e.Button.Key == "Search")
                {
                    var Contract =
                        new DAL.LoanDataSetTableAdapters.Loan_ContractTableAdapter().GetDataByContract(
                            txtContractNo.Text).FirstOrDefault();
                    if (Contract != null)
                    {
                        txtContractName.Text = Contract.Contract;
                       
                    }
                    else
                    {
                        txtContractName.Text = "قراردادی با این مشخصات وجود ندارد";
                     
                    }
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


        private void btnShowReport_Click(object sender, EventArgs e)
        {

            try
            {
                var filter = "";
                var fil_Counterparty = "";
                _series.Clear();

                if (rbStateBranch.Checked)
                {
                    if (ucfState.IsChecked())
                        filter += ucfState.GetFilterStructureForSql();
                    else if (ucfOrganization.IsChecked())
                    {
                        filter += ucfState.IsChecked() ? (" and " + ucfOrganization.GetFilterStructureForSql()) : ucfOrganization.GetFilterStructureForSql();
                    }
                    else
                    {
                        Routines.ShowErrorMessageFa("خطا", "یکی از گزینه ها حتما باید انتخاب شود",
                                               MyDialogButton.OK);
                        return;
                    }

                }
                else if (rbCounterparty.Checked)
                {
                    var item = txtCounterPartyName.Tag;
                    fil_Counterparty += fil_Counterparty.Trim().Length == 0
                                            ? "(Counterparty = " + item + " "
                                            : " OR Counterparty = " + item;
                    if (fil_Counterparty.Trim().IsNullOrEmptyByTrim() == false)
                        fil_Counterparty += ")";
                }



                var fil_contract = "";
                if (rbContract.Checked)
                {
                    var item = txtContractNo.Text;
                    fil_contract += fil_contract.Trim().Length == 0
                                            ? "(Contract = '" + item + "' "
                                            : " OR Contract = '" + item + "'";
                    if (fil_contract.Trim().IsNullOrEmptyByTrim() == false)
                        fil_contract += ")";
                }



                if (fil_Counterparty.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_Counterparty;
                }



                if (fil_contract.Trim().Length != 0)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += fil_contract;
                }

                //filter += " and (Contract_Status.Status = '" + cbContractStatus.SelectedValue + "' )";
                Routines.ShowProcess();
                var oldData = new DAL.LoanDataSet().GetHisLoanReport(false, "Count(*)", filter);
                var newData = new DAL.LoanDataSet().GetHisLoanReport(true, "Count(*)", filter);


                var status = oldData.Columns["StatusId"];
                DataTable oldRevisedTable = new DataTable();
                oldRevisedTable.Columns.Add("Date");
                oldRevisedTable.Columns["Date"].DataType = oldData.Columns["DateOfReport"].DataType;
                
                foreach (DataRow item in newData.Rows)
                {
                    var column = new DataColumn() { ColumnName = item["StatusId"].ToString(), DataType = oldData.Columns["TypeOfGroupBy"].DataType, Caption = item["Status_Desc"].ToString() };
                    oldRevisedTable.Columns.Add(column);
                }

                



                int index = 0;
                foreach (DataRow item in oldData.Rows)
                {
                    index = 0;
                    foreach (DataRow row in oldRevisedTable.Rows)
                    {

                        if (oldRevisedTable.Rows[index].ItemArray.GetValue(0).Equals(item["DateOfReport"]))
                        {
                            if (!oldRevisedTable.Columns.Cast<DataColumn>().Any(item1 => item1.ColumnName.Equals(item["StatusId"].ToString())))
                            { 
                                oldRevisedTable.Columns.Add(new DataColumn() { ColumnName = item["StatusId"].ToString(), DataType = oldData.Columns["TypeOfGroupBy"].DataType, Caption = item["Status_Desc"].ToString() });
                            }
                            row[item["StatusId"].ToString()] = item["TypeOfGroupBy"];
                            break;
                        }
                        index++;
                    }
                    if (index == oldRevisedTable.Rows.Count)
                    {
                        DataRow row = oldRevisedTable.NewRow();
                        row["Date"] = item["DateOfReport"];
                        if (!oldRevisedTable.Columns.Cast<DataColumn>().Any(item1 => item1.ColumnName.Equals(item["StatusId"].ToString())))
                        {
                            oldRevisedTable.Columns.Add(new DataColumn() { ColumnName = item["StatusId"].ToString(), DataType = oldData.Columns["TypeOfGroupBy"].DataType, Caption = item["Status_Desc"].ToString() });
                        }
                        row[item["StatusId"].ToString()] = item["TypeOfGroupBy"];
                        oldRevisedTable.Rows.Add(row);
                    }
                }


                DataTable newRevisedTable = new DataTable();
                newRevisedTable.Columns.Add("Date");
                newRevisedTable.Columns["Date"].DataType = newData.Columns["DateOfReport"].DataType;


                foreach (DataColumn item in oldRevisedTable.Columns)
                {
                    if(!item.ColumnName.Equals("Date"))
                        newRevisedTable.Columns.Add(new DataColumn() { ColumnName = item.ColumnName, DataType = oldData.Columns["TypeOfGroupBy"].DataType });
                }


                foreach (DataRow item in newData.Rows)
                {

                    if (newRevisedTable.Rows.Count == 0)
                    {
                        DataRow row = newRevisedTable.NewRow();
                        row["Date"] = item["DateOfReport"];
                        row[item["StatusId"].ToString()] = item["TypeOfGroupBy"];
                        newRevisedTable.Rows.Add(row);
                    }
                    else if (newRevisedTable.Rows[0].ItemArray.GetValue(0).Equals(item["DateOfReport"]))
                    {
                        newRevisedTable.Rows[0][item["StatusId"].ToString()] = item["TypeOfGroupBy"];

                    }

                }


                DataTable WholeData = oldRevisedTable;

                foreach (DataRow item in newRevisedTable.Rows)
                {
                    WholeData.Rows.Add(item.ItemArray);
                }


                foreach (DataRow item in WholeData.Rows)
                {
                    foreach (DataColumn col in WholeData.Columns)
                    {
                        if (col.DataType.Name.Equals("Int32"))
                        {
                            if (item[col.ColumnName].ToString().Equals(""))
                                item[col.ColumnName] = 0;
                        }
                    }

                }
              

                foreach(DataRow item in newRevisedTable.Rows)
                {
                    var a = WholeData.NewRow();
                    foreach(var col in item.Table.Columns.Cast<DataColumn>())
                    {
                        a[col.ColumnName] = item[col.ColumnName];
                    }

                } 
                


                int i = 0;
                chart.Series.Clear();
                _series.Clear();
                chbSerries.Items.Clear();
                var Data=WholeData.ConfigDateTimeToPersian();
                chart.DataSource = Data;
                foreach (DataColumn item in Data.Columns)
                {
                    if (!item.ColumnName.Equals("Date"))
                    {

                        var s = new Dundas.Charting.WinControl.Series(item.Caption);
                        s.ValueMembersY = item.ColumnName;
                        s.ValueMemberX = "Date";
                        chart.Series.Add(s);
                        s.Type = Dundas.Charting.WinControl.SeriesChartType.Line;
                        s.ToolTip = "#VAL      #AXISLABEL";
                        chbSerries.Items.Add(item.Caption.Trim(), CheckState.Checked);
                        _series.Add(s);
                        i++;
                    }
                }
                //chart.DataSource = WholeData.ConfigDateTimeToPersian();
                chart.DataBind();

                Routines.HideProcess();
            }
            catch (Exception ex)
            {
                Routines.HideProcess();
                Routines.ShowErrorMessageFa("خطا", "خطا در بارگذاری اطلاعات",ex.Message,
                                               MyDialogButton.OK);
                
            }
        }


        private void rbStateBranch_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                if (rbStateBranch.Checked)
                {
                    txtContractNo.Enabled = false;
                    txtCounterparty.Enabled = false;
                    gbStateBranch.Enabled=true;
                }
                else if (rbCounterparty.Checked)
                {
                    txtContractNo.Enabled = false;
                    txtCounterparty.Enabled = true;
                    gbStateBranch.Enabled = false;
                }
                else if (rbContract.Checked)
                {
                    txtContractNo.Enabled = true;
                    txtCounterparty.Enabled = false;
                    gbStateBranch.Enabled = false;
                }
            }
        }

        private Size _size;
       private Point _location;
        private void btnFullScreenChart_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnFullScreenShow.Checked)
                {
                    btnFullScreenShow.Checked = false;
                    chart.Dock = DockStyle.None;
                   chart.Location = _location;
                   chart.Size = _size;
                }
                else
                {
                    btnFullScreenShow.Checked = true;
                   _size = chart.Size;
                    _location = chart.Location;
                    chart.Dock = DockStyle.Fill;
                }
            }
            catch (Exception exception)
            {

                exception.ConfigLog();
            }
            
        }


        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbSerries_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbSerries.GetItemCheckState(chbSerries.SelectedIndex).Equals(CheckState.Checked))
                {
                    var ssssss = _series.Where(item => item.Name.Equals(chbSerries.SelectedItem.ToString())).FirstOrDefault();
                    //var ssss = chart.Series.Cast<Dundas.Charting.WinControl.Series>().Where(item => item.Name.Equals(chbSerries.SelectedItem.ToString())).FirstOrDefault();
                    chart.Series.Add(ssssss);

                }
                else
                {

                    var ssss = chart.Series.Cast<Dundas.Charting.WinControl.Series>().Where(item => item.Name.Equals(chbSerries.SelectedItem.ToString())).FirstOrDefault();
                    chart.Series.Remove(ssss);
                }
                chart.DataBind();
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }


        
    }
}
