using System;
using System.Data;
using System.Windows.Forms;
using DAL;
using ERMS.Model;
using ERMSLib;

//
using Presentation.Public;
using Presentation.Tabs.BasicInfo;
using Utilize.Helper;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.Tabs.BasicData
{
    public partial class frmState : Form
    {
        #region " Var"

        DataTable ds;
        BranchDataSet clsBranch;
        //Organization clsOrganization;
        //City clsCity;
        //State clsState;
        Table_DataSet clsTableDataSet;
        int startIndex, endIndex;
        bool EditMode = false;
        bool NewMode = false;
        #endregion

        public frmState()
        {
            InitializeComponent();
            InitializeForm();
            GeneralDataGridView = dgvBranch;
        }

        private void InitializeForm()
        {
            //this.bindingNavigatorSearchItem.ToolTipText = "جستجو";
            //this.bindingNavigatorReturnItem.ToolTipText = "بازگشت به حالت اول";

            //DataTable dt = new DAL.State().GetDT_State(1, 1000);
            //cmbState.DataSource = dt;
            //cmbState.DisplayMember = "State_Name";
            //cmbState.ValueMember = "State_Id"; 
        }
        private void frmBranch_Load(object sender, EventArgs e)
        {
           clsBranch=new BranchDataSet();
            dgvBranch.FormatDataGridView();
                dgvBranch.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                fill_cmbPages();
                fill_txt_Branch();
                GeneralDataGridView = dgvBranch;
               
           
        }

        private void fill_cmbPages()
        {

            //clsBranch = new Branch();
            //var count = new DAL.Table_DataSetTableAdapters.OrganizationTableAdapter().GetCount();
            //int count = int.Parse(clsBranch.BranchCount());
            var count = new DAL.Table_DataSet().GetTableCount("State");
            for (int i = 1; i < count; i = i + 100)
            {
                cmbPages.Items.Add(string.Format("{0} .. {1}", i, i + 100 - 1));
            }
            cmbPages.SelectedIndex = cmbPages.Items.Count == 0 ? -1 : 0;
            startIndex = cmbPages.SelectedIndex * 100 + 1;
            endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
            fill_Branch(startIndex, endIndex);
        }

        private void fill_Branch(int startIndex, int endIndex)
        {
            ds = new DAL.State().GetDT_State(startIndex, endIndex);
            
            dgvBranch.DataSource = ds;

            dgvBranch.Columns["Row"].HeaderText = "رديف";
            dgvBranch.Columns["State_Name"].HeaderText = "استان";
            dgvBranch.Columns["State_Id"].Visible = false;
        }


        private void fill_txt_Branch()
        {
            //txtBranch_Code.DataBindings.Add(new Binding("Text", this.bngBranch, "Branch", true));
            //txtBranch_Name.DataBindings.Add(new Binding("Text", this.bngBranch, "Branch_Description", true));
            //txtStateBranch.DataBindings.Add(new Binding("Text", this.bngBranch, "State_Of_Branch", true));
        }

        private void cmbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            startIndex = cmbPages.SelectedIndex * 100 + 1;
            endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
            fill_Branch(startIndex, endIndex);
        }
       
        private void BranchSearch()
        {
            //DataTable dt = dgvBranch.Grid2TableSearch();
            ////dt = Risk_Manegment.Common.Grid2TableSearch(dgvBranch);

            //Presentation.Tabs.BasicInfo.frmSearch frm = new Presentation.Tabs.BasicInfo.frmSearch(dt) {TableName = "Organization"};

            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        //ProgressBox.Show();
            //        if (frm.Field != string.Empty)
            //        {
            //            if (frm.Search != string.Empty)
            //            {
            //                ds = clsBranch.BranchSearch(frm.Search, frm.Field, frm.Operator);
            //                bngBranch.DataSource = ds;
            //                bngBranch.DataMember = ds.Tables[0].TableName;
            //                bngNBranch.BindingSource = bngBranch;
            //                dgvBranch.DataSource = bngBranch;
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    finally
            //    {
            //        //ProgressBox.Hide();
            //    }
          //}
        }

        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvBranch;
        }

        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "Branch";
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            //BranchSearch();
        }

        private void bindingNavigatorReturnItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBox.Show();
                Helper h = new Helper();
                h.FormatDataGridView(dgvBranch);
                dgvBranch.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                fill_cmbPages();

            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void cmbState_SelectionChanged(object sender, EventArgs e)
        {
            //if (cmbState.SelectedIndex == -1)
            //    return;
            //cmbCity.DataSource = new DAL.City().GetDT_City_ByState(Convert.ToInt32(cmbState.SelectedValue));
            //cmbCity.DisplayMember = "City_Name";
            //cmbCity.ValueMember = "City_Id"; 
        }

        private void dgvBranch_SelectionChanged(object sender, EventArgs e)
        {
            NewMode = false;
            EditMode = false;

            if (dgvBranch.CurrentRow != null)
            {
                txtState_Name.Text = dgvBranch.CurrentRow.Cells["State_Name"].Value.ToString();
                InfoFieldSettings(false, false);
            }
            else
            {
                InfoFieldSettings(true, false);
            }
        }

        private void InfoFieldSettings(bool Clear, bool Enable)
        {
            if(Clear)
            {
                txtState_Name.Text = string.Empty;
            }

            txtState_Name.Enabled = Enable;
        }

        private void tsbModelNew_Click(object sender, EventArgs e)
        {
            NewMode = true;
            InfoFieldSettings(true, true);
        }

        private void tsbModelEdit_Click(object sender, EventArgs e)
        {
            EditMode = true;
            InfoFieldSettings(false, true);
        }

        private void tsbModelRemove_Click(object sender, EventArgs e)
        {
            if (Presentation.Public.Routines.ShowMessageBoxFa(
                     "آیا از حذف استان اطمینان دارید",
                     "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    int StateID = -1;
                    StateID = int.Parse(dgvBranch.CurrentRow.Cells["State_Id"].Value.ToString());
                    new DAL.State().Delete_State(StateID);
                    startIndex = cmbPages.SelectedIndex * 100 + 1;
                    endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
                    fill_Branch(startIndex, endIndex);
                    Routines.ShowMessageBoxFa("داده به درستی حذف شد", "ثبت داده", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Routines.ShowErrorMessageFa("خطا در حذف داده", ex.Message, MyDialogButton.OK);
                }
            }
        }

        private void tsbModelSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtState_Name.Text.Trim().Length == 0)
                {
                    Routines.ShowErrorMessageFa("خطا در ذخیره سازی", "اطلاعات وارد شده ناقص است", MyDialogButton.OK);
                    return;
                }
                int StateID = -1;
                StateID = int.Parse(dgvBranch.CurrentRow.Cells["State_Id"].Value.ToString());
                if (NewMode)
                    new DAL.State().Insert_State(txtState_Name.Text.Trim());
                else if (EditMode)
                    new DAL.State().Update_State(StateID, txtState_Name.Text.Trim());

                NewMode = EditMode = false;
                startIndex = cmbPages.SelectedIndex * 100 + 1;
                endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
                fill_Branch(startIndex, endIndex);
                Routines.ShowMessageBoxFa("داده به درستی ثبت شد", "ثبت داده", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Routines.ShowErrorMessageFa("خطا در ذخیره سازی", ex.Message, MyDialogButton.OK);
            }
            finally
            {
                
            }

        }
    }
}