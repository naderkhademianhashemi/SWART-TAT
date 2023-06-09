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
    public partial class frmBranch : Form
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

        public frmBranch()
        {
            InitializeComponent();
            InitializeForm();
            GeneralDataGridView = dgvBranch;
        }

        private void InitializeForm()
        {
            //this.bindingNavigatorSearchItem.ToolTipText = "جستجو";
            //this.bindingNavigatorReturnItem.ToolTipText = "بازگشت به حالت اول";

            DataTable dt = new DAL.State().GetDT_State(1, 100);
            cmbState.DataSource = dt;
            cmbState.DisplayMember = "State_Name";
            cmbState.ValueMember = "State_Id"; 
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
            var count = new DAL.Table_DataSet().GetTableCount("Organization");
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
            ds = new DAL.Organization().GetDT_Organization(startIndex, endIndex);

            //bngBranch.DataSource = ds;
            //bngBranch.DataMember = ds.TableName;
            //bngNBranch.BindingSource = bngBranch;

            dgvBranch.DataSource = ds;

            dgvBranch.Columns["Row"].HeaderText = "رديف";
            dgvBranch.Columns["Branch"].HeaderText = "كد شعبه";
            dgvBranch.Columns["Branch_Description"].HeaderText = "نام شعبه";
            dgvBranch.Columns["State_Name"].HeaderText = "استان شعبه";
            dgvBranch.Columns["City_Name"].HeaderText = "شهر شعبه";
            dgvBranch.Columns["Branch_Rank"].HeaderText = "رتبه شعبه";
            dgvBranch.Columns["Limit"].HeaderText = "حدود شعبه";
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
            if (cmbState.SelectedIndex == -1)
                return;
            cmbCity.DataSource = new DAL.City().GetDT_City_ByState(Convert.ToInt32(cmbState.SelectedValue));
            cmbCity.DisplayMember = "City_Name";
            cmbCity.ValueMember = "City_Id"; 
        }

        private void dgvBranch_SelectionChanged(object sender, EventArgs e)
        {
            NewMode = false;
            EditMode = false;

            if (dgvBranch.CurrentRow != null)
            {
                txtBranch_Code.Text = dgvBranch.CurrentRow.Cells["Branch"].Value.ToString();
                txtBranch_Limit.Text = dgvBranch.CurrentRow.Cells["Limit"].Value.ToString();
                txtBranch_Name.Text = dgvBranch.CurrentRow.Cells["Branch_Description"].Value.ToString();
                txtBranch_Rank.Text = dgvBranch.CurrentRow.Cells["Branch_Rank"].Value.ToString();
                cmbState.Text = dgvBranch.CurrentRow.Cells["State_Name"].Value.ToString();
                cmbCity.Text = dgvBranch.CurrentRow.Cells["City_Name"].Value.ToString();
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
                txtBranch_Code.Text = string.Empty;
                txtBranch_Limit.Text = string.Empty;
                txtBranch_Name.Text = string.Empty;
                txtBranch_Rank.Text = string.Empty;
                cmbState.SelectedIndex = -1;
                cmbCity.SelectedIndex = -1;
            }

            if(!EditMode)
                txtBranch_Code.Enabled = Enable;
            txtBranch_Limit.Enabled = Enable;
            txtBranch_Name.Enabled = Enable;
            txtBranch_Rank.Enabled = Enable;
            cmbState.Enabled = Enable;
            cmbCity.Enabled = Enable;
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
                     "آیا از حذف شعبه اطمینان دارید",
                     "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    int branhCode = -1;
                    branhCode = int.Parse(txtBranch_Code.Text);
                    new DAL.Organization().Delete_Organization(branhCode);
                    startIndex = cmbPages.SelectedIndex * 100 + 1;
                    endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
                    fill_Branch(startIndex, endIndex);
                    Routines.ShowMessageBoxFa(" داده به درستی حذف شد", "ثبت داده", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Routines.ShowErrorMessageFa("خطا در حذف داده", ex.Message, MyDialogButton.OK);
                }
            }
        }

        private void tsbModelSave_Click(object sender, EventArgs e)
        {
            int BranchCode = 0;
            int BranchRank = 0;
            int BranchLimit = 0;
            try
            {
                if (!int.TryParse(txtBranch_Code.Text, out BranchCode) || cmbState.SelectedIndex == -1 || cmbCity.SelectedIndex == -1)
                {
                    Routines.ShowErrorMessageFa("خطا در ذخیره سازی", "اطلاعات وارد شده ناقص است", MyDialogButton.OK);
                    return;
                }

                int.TryParse(txtBranch_Rank.Text, out BranchRank);
                int.TryParse(txtBranch_Limit.Text, out BranchLimit);

                if (NewMode)
                    new DAL.Organization().Insert_Organization(BranchCode,
                                                        txtBranch_Name.Text, BranchRank, BranchLimit,
                                                        Convert.ToInt32(cmbCity.SelectedValue), Convert.ToInt32(cmbState.SelectedValue));
                else if (EditMode)
                    new DAL.Organization().Update_Organization(BranchCode,
                                                        txtBranch_Name.Text, BranchRank, BranchLimit,
                                                        Convert.ToInt32(cmbCity.SelectedValue), Convert.ToInt32(cmbState.SelectedValue));
                NewMode = EditMode = false;
                startIndex = cmbPages.SelectedIndex * 100 + 1;
                endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
                fill_Branch(startIndex, endIndex);
                Routines.ShowMessageBoxFa(" داده به درستی ثبت شد", "ثبت داده", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

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