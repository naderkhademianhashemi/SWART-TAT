using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ERMS.Logic;
using Utilize;

namespace Presentation.Tabs.FinancialRatio
{
    public partial class frmHistoricFncRatio : BaseForm
    {

        private string[] SelectedCRPList = new string[50];
        

        public frmHistoricFncRatio()
        {
            InitializeComponent();

            try
            {
                var state_DataTable = new DAL.DepositDataSetTableAdapters.StateTableAdapter().GetData();
                ucfState.DisplayMember = "State_Name";
                ucfState.ValueMember = "StateId";
                ucfState.DataSource = state_DataTable;
                ucfState.CheckedChanged += ucfState_CheckedChanged;

                var organization_DataTable = new DAL.DepositDataSetTableAdapters.OrganizationTableAdapter().GetData();

                ucfOrganization.DisplayMember = "Branch_Description";
                ucfOrganization.ValueMember = "BranchId";
                ucfOrganization.DataSource = organization_DataTable;
                ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;
            }
            catch (Exception exception)
            {
                
                Close();
            }
        }

       


        void ucfState_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucfState.IsChecked() && ucfState.GetSelectedItem().Count() > 0)
                {
                    var organizations = new DAL.DepositDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(
                        org =>
                            ucfState.GetSelectedItem().Any(
                            sta => sta.DataValue.ToString().Equals(org.State_Of_Branch.ToString()))).ToArray();
                    ucfOrganization.DisplayMember = "Branch_Description";
                    ucfOrganization.ValueMember = "Branch";
                    ucfOrganization.DataSource = organizations;
                }
                else
                {
                    var organizations = new DAL.DepositDataSetTableAdapters.OrganizationTableAdapter().GetData();
                    ucfOrganization.DisplayMember = "Branch_Description";
                    ucfOrganization.ValueMember = "Branch";
                    ucfOrganization.DataSource = organizations;
                }
            }
            catch (Exception exception)
            {
               
            }
        }


        void ucfOrganization_DropDownOpening(object sender, EventArgs e)
        {

        }

        private FncRatio_BL Fnc_BL;
        private void frmHistoricFncRatio_Load(object sender, EventArgs e)
        {
            FncRatio_BL Fnc_BL = new FncRatio_BL();

            DataTable dt = Fnc_BL.GetDTFncRatiosDefinition();

            cmbReportType.DisplayMember = "Descr";
            cmbReportType.ValueMember = "Id";
            cmbReportType.DataSource = dt;

            dt = new DAL.SwartDataSetTableAdapters.FncRatio_HistoricTableAdapter().GetDataByDate();
           
            chkLstHD.DataSource = dt;
            chkLstHD.DisplayMember = "Date";
        }

        private void btnReportDisplay_Click(object sender, EventArgs e)
        {
            DataTable dt=null;
            var filter = getFilter();
            if (!filter.Equals(""))
            {
                dt = new DAL.FncDataSet().GetHistoricFunc(filter);

            }
            else
            {
                return;
            }

            DataTable oldRevisedTable = new DataTable();
            oldRevisedTable.Columns.Add("StateId");
            oldRevisedTable.Columns["StateId"].DataType = dt.Columns["StateId"].DataType;

            oldRevisedTable.Columns.Add("BranchId");
            oldRevisedTable.Columns["BranchId"].DataType = dt.Columns["BranchId"].DataType;

            oldRevisedTable.Columns.Add("State_Name");
            oldRevisedTable.Columns["State_Name"].DataType = dt.Columns["State_Name"].DataType;

            oldRevisedTable.Columns.Add("Branch_Description");
            oldRevisedTable.Columns["Branch_Description"].DataType = dt.Columns["Branch_Description"].DataType;


            oldRevisedTable.Columns.Add("DaftarKol");
            oldRevisedTable.Columns["DaftarKol"].DataType = dt.Columns["DaftarKol"].DataType;



            int index = 0;
            foreach (DataRow item in dt.Rows)
            {
                index = 0;
                foreach (DataRow row in oldRevisedTable.Rows)
                {

                    if (oldRevisedTable.Rows[index].ItemArray.GetValue(0).Equals(item["StateId"]) && oldRevisedTable.Rows[index].ItemArray.GetValue(1).Equals(item["BranchId"]))
                    {
                        if (!oldRevisedTable.Columns.Cast<DataColumn>().Any(item1 => item1.ColumnName.Equals(item["Date"].ToString())))
                        {
                            oldRevisedTable.Columns.Add(new DataColumn() { ColumnName = item["Date"].ToString(), DataType = dt.Columns["Date"].DataType, Caption = item["Date"].ToString() });
                        }
                        row[item["Date"].ToString()] = item["Amount"];
                        break;
                    }
                    index++;
                }
                if (index == oldRevisedTable.Rows.Count)
                {
                    DataRow row = oldRevisedTable.NewRow();
                    row["StateId"] = item["StateId"];
                    row["BranchId"] = item["BranchId"];
                    row["State_Name"] = item["State_Name"];
                    row["Branch_Description"] = item["Branch_Description"];
                    row["DaftarKol"] = item["DaftarKol"];
                    
                    if (!oldRevisedTable.Columns.Cast<DataColumn>().Any(item1 => item1.ColumnName.Equals(item["Date"].ToString())))
                    {
                        oldRevisedTable.Columns.Add(new DataColumn() { ColumnName = item["Date"].ToString(), DataType = dt.Columns["Date"].DataType, Caption = item["Date"].ToString() });
                    }
                    row[item["Date"].ToString()] = item["Amount"];
                    oldRevisedTable.Rows.Add(row);
                }
            }

            int type=0;
            if (oldRevisedTable.Rows[0]["BranchId"].ToString().Equals("-1"))
            {
                if (oldRevisedTable.Rows[0]["StateId"].ToString().Equals("-1"))
                    type = 0;// filter on daftar kol
                else
                    type = 1; //filter on state

            }
            else
                type = 2; //filter on branch



            int i = 0;
            chart.Series.Clear();

           
            chart.DataSource = oldRevisedTable;
            foreach (DataColumn item in oldRevisedTable.Columns)
            {
                if (!(item.ColumnName.Equals("StateId")) && !item.ColumnName.Equals("BranchId") && !item.ColumnName.Equals("State_Name") && !item.ColumnName.Equals("Branch_Description") && !item.ColumnName.Equals("DaftarKol"))
                {

                    var s = new Dundas.Charting.WinControl.Series(item.Caption);
                    s.ValueMembersY = item.ColumnName;
                    s.ValueMemberX = type == 0 ? "DaftarKol" : (type == 1 ? "State_Name" : "Branch_Description");
                    chart.Series.Add(s);
                    s.Type = Dundas.Charting.WinControl.SeriesChartType.Column;
                    s.ToolTip = "#VAL      #AXISLABEL";
                   
                    i++;
                }
            }
            //chart.DataSource = WholeData.ConfigDateTimeToPersian();
            chart.DataBind();


        }

        private String getFilter()
        {
            var filter = "";
            var select = "";
            var fil_State = ucfState.GetFilterStructureForSql();

            String fil_Func = "FncRatio_Definition_Id="+cmbReportType.SelectedValue.ToString();

            var fil_Organization = ucfOrganization.GetFilterStructureForSql();

            if (rdbAll.Checked)
            {
                if (filter.Trim().Length != 0) filter += " and ";
                filter += "StateId='-1'";

                if (filter.Trim().Length != 0) filter += " and ";
                filter += "BranchId='-1'";
            }
            else if (rdbState.Checked)
            {
                if (chkAll.Checked)
                {
                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += "StateId!='-1'";

                    if (filter.Trim().Length != 0) filter += " and ";
                    filter += "BranchId='-1'";
                }
                else 
                {
                    if (fil_State.Trim().Length != 0)
                    {

                        if (filter.Trim().Length != 0) filter += " and ";
                        filter += fil_State;

                        if (filter.Trim().Length != 0) filter += " and ";
                        filter += "BranchId='-1'";
                    }
                    else 
                    {
                        Presentation.Public.Routines.ShowErrorMessageFa("هشدار", "حداقل یک استان یا گزینه همه باید انتخاب شده باشد",Public.MyDialogButton.OK);
                        return "";
                    }

                }
            }
            else if (rdbBranch.Checked)
            {
                if (chkAll.Checked)
                {
                    if (fil_State.Trim().Length != 0)
                    {
                        if (filter.Trim().Length != 0) filter += " and ";
                        filter += fil_State;


                        if (filter.Trim().Length != 0) filter += " and ";
                        filter += "BranchId!='-1'";
                    }
                    else
                    {
                        if (filter.Trim().Length != 0) filter += " and ";
                        filter += "StateId!='-1'";

                        if (filter.Trim().Length != 0) filter += " and ";
                        filter += "BranchId!='-1'";
                    }

                }
                else
                {
                    if (fil_State.Trim().Length != 0)
                    {
                        if (filter.Trim().Length != 0) filter += " and ";
                        filter += fil_State;

                        if (fil_Organization.Trim().Length != 0)
                        {
                            if (filter.Trim().Length != 0) filter += " and ";
                            filter += fil_Organization;
                        }
                        else
                        {
                            Presentation.Public.Routines.ShowErrorMessageFa("هشدار", "حداقل یک شعبه یا گزینه همه باید انتخاب شده باشد",Public.MyDialogButton.OK);
                            return "";
                        }
                    }
                    else
                    {
                        if (filter.Trim().Length != 0) filter += " and ";
                        filter += "StateId!='-1'";
                        if (fil_Organization.Trim().Length != 0)
                        {
                            if (filter.Trim().Length != 0) filter += " and ";
                            filter += fil_Organization;
                        }
                        else
                        {
                            Presentation.Public.Routines.ShowErrorMessageFa("هشدار", "حداقل یک شعبه یا گزینه همه باید انتخاب شده باشد", Public.MyDialogButton.OK);
                            return "";
                        }
                    }
                }
            }


            
            




            if (fil_Func.Trim().Length != 0)
            {
                if (filter.Trim().Length != 0) filter += " and ";
                filter += fil_Func;
            }

           

            String dateFilter = "";
            for (int i = 0; i < SelectedCRPList.Length; ++i)
            {
                if (SelectedCRPList[i] != null)
                {
                    dateFilter += dateFilter.Trim().Length == 0
                             ? "( Date = [dbo].[GetChrisDateEQ]('" + SelectedCRPList[i] + "') "
                                                     : " OR Date = [dbo].[GetChrisDateEQ]('" + SelectedCRPList[i] + "') ";
                    
                }
            }
            if (!dateFilter.Trim().Equals(""))
                dateFilter += ")";

            if (chkLstHD.CheckedItems.Count > 0)
            {
                if (filter.Trim().Length != 0) filter += " and ";
                filter += dateFilter;
            }
           
                
            
          
            return filter;

        }

        private void chkLstHD_SelectedValueChanged(object sender, EventArgs e)
        {

            if (chkLstHD.SelectedIndex != -1)
            {
                if (chkLstHD.GetItemChecked(chkLstHD.SelectedIndex))
                {
                    SelectedCRPList[chkLstHD.SelectedIndex] = ((DataRowView)chkLstHD.SelectedItem)[3].ToString();
                    
                }
                else
                {
                    SelectedCRPList[chkLstHD.SelectedIndex] = null;
                    
                }
            }
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAll.Checked)
            {
                grbBranch.Visible = false;
            }
        }

        private void rdbState_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbState.Checked)
            {
                grbBranch.Visible = true;
                ucfOrganization.Visible = false;
                
            }
        }

        private void rdbBranch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBranch.Checked)
            {
                grbBranch.Visible = true;
                
                ucfOrganization.Visible = true;
            }
           
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbState.Checked)
            {
                if (chkAll.Checked)
                {
                    ucfState.Enabled = false;
                }
                else
                {
                    ucfState.Enabled = true;
                }

            }
            else if (rdbBranch.Checked)
            {
                if (chkAll.Checked)
                {
                    ucfOrganization.Enabled = false;
                    ucfState.Enabled = true;
                }
                else
                {
                    ucfOrganization.Enabled = true;
                    ucfState.Enabled = true;

                }

            }
        }

        private void cbCollapseRight_CButtonClicked(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2Collapsed == false)
            {
                splitContainer2.Panel2Collapsed = true;
                cbCollapseRight.DefaultImage = Properties.Resources.S_Panleft1;
                cbCollapseRight.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (splitContainer2.Panel2Collapsed == true)
            {
                splitContainer2.Panel2Collapsed = false;
                cbCollapseRight.DefaultImage = Properties.Resources.S_PanRight1;
                cbCollapseRight.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }

        private void cbCollapseUp_CButtonClicked(object sender, EventArgs e)
        {
            if (splitContainer5.Panel1Collapsed == false)
            {
                splitContainer5.Panel1Collapsed = true;
                cbCollapseUp.DefaultImage = Properties.Resources.S_PanDown1;
                cbCollapseUp.HoverImage = Properties.Resources.S_PanDown_Hover1;
            }
            else if (splitContainer2.Panel2Collapsed == true)
            {
                splitContainer5.Panel1Collapsed = false;
                cbCollapseUp.DefaultImage = Properties.Resources.S_PanUp1;
                cbCollapseUp.HoverImage = Properties.Resources.S_PanUp_Hover1;
            }
        }

       
    }
}
