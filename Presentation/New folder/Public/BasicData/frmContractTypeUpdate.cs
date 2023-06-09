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
    public partial class frmContractTypeUpdate : Form
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

        public frmContractTypeUpdate()
        {
            InitializeComponent();
            InitializeForm();
            GeneralDataGridView = dgvBranch;
        }

        private void InitializeForm()
        {
            //this.bindingNavigatorSearchItem.ToolTipText = "جستجو";
            //this.bindingNavigatorReturnItem.ToolTipText = "بازگشت به حالت اول";

            DataTable dt = new DAL.Contract_Type().GetDT_ContractTypeGroup();
            cmbContractTypeGroup.DataSource = dt;
            cmbContractTypeGroup.DisplayMember = "contract_type_group_desc";
            cmbContractTypeGroup.ValueMember = "Contract_type_group_id";

            DataTable dtLD = new DAL.Contract_Type().GetDT_ContractTypeLD();
            cmbContractLD.DataSource = dtLD;
            cmbContractLD.DisplayMember = "ContractLD_Desc";
            cmbContractLD.ValueMember = "ContractLD_ID"; 
        }
        private void frmBranch_Load(object sender, EventArgs e)
        {
           clsBranch=new BranchDataSet();
            dgvBranch.FormatDataGridView();
                dgvBranch.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                fill_cmbPages();
                GeneralDataGridView = dgvBranch;
               
           
        }

        private void fill_cmbPages()
        {

            //clsBranch = new Branch();
            //var count = new DAL.Table_DataSetTableAdapters.OrganizationTableAdapter().GetCount();
            //int count = int.Parse(clsBranch.BranchCount());
            var count = new DAL.Table_DataSet().GetTableCount("Contract_Type");
            for (int i = 1; i < count; i = i + 100)
            {
                cmbPages.Items.Add(string.Format("{0} .. {1}", i, i + 100 - 1));
            }
            cmbPages.SelectedIndex = cmbPages.Items.Count == 0 ? -1 : 0;
            startIndex = cmbPages.SelectedIndex * 100 + 1;
            endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
            fill_ContractType(startIndex, endIndex);
        }

        private void fill_ContractType(int startIndex, int endIndex)
        {
            ds = new DAL.Contract_Type().GetDT_ContractType(startIndex, endIndex);

            dgvBranch.DataSource = ds;

            dgvBranch.Columns["Row"].HeaderText = "رديف";
            dgvBranch.Columns["contract_type"].HeaderText = "شماره نوع قرارداد";
            dgvBranch.Columns["contract_type_description"].HeaderText = "نوع قرارداد";         
            dgvBranch.Columns["Contract_Type_Group_Desc"].HeaderText = "گروه قرارداد";
            dgvBranch.Columns["ContractLD_Desc"].HeaderText = "نوع اصلی قرارداد";
            dgvBranch.Columns["ContractRate"].HeaderText = "نرخ سود";
            dgvBranch.Columns["Contract_Type_group_Id"].Visible = false;
            dgvBranch.Columns["contract_LD"].Visible = false;
        }


        private void cmbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            startIndex = cmbPages.SelectedIndex * 100 + 1;
            endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
            fill_ContractType(startIndex, endIndex);
        }


        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvBranch;
        }

        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "ContractType";
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            //BranchSearch();
        }

        private void bindingNavigatorReturnItem_Click(object sender, EventArgs e)
        {
            try
            {
                //ProgressBox.Show();
                //Helper h = new Helper();
                //h.FormatDataGridView(dgvBranch);
                //dgvBranch.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                //fill_cmbPages();
                startIndex = cmbPages.SelectedIndex * 100 + 1;
                endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
                fill_ContractType(startIndex, endIndex);

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


        private void dgvBranch_SelectionChanged(object sender, EventArgs e)
        {
            NewMode = false;
            EditMode = false;

            if (dgvBranch.CurrentRow != null)
            {
                txtContractType_Code.Text = dgvBranch.CurrentRow.Cells["contract_type"].Value.ToString();
                txtContractTypeDesc.Text = dgvBranch.CurrentRow.Cells["contract_type_description"].Value.ToString();
                txtContractRate.Text = dgvBranch.CurrentRow.Cells["ContractRate"].Value.ToString();
                cmbContractTypeGroup.Text = dgvBranch.CurrentRow.Cells["Contract_Type_Group_Desc"].Value.ToString();
                cmbContractLD.Text = dgvBranch.CurrentRow.Cells["ContractLD_Desc"].Value.ToString();
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
                txtContractType_Code.Text = string.Empty;
                txtContractTypeDesc.Text = string.Empty;
                txtContractRate.Text = string.Empty;
                cmbContractTypeGroup.SelectedIndex = -1;
                cmbContractLD.SelectedIndex = -1;
            }

            if(!EditMode)
                txtContractType_Code.Enabled = Enable;
            txtContractTypeDesc.Enabled = Enable;
            txtContractRate.Enabled = Enable;
            cmbContractTypeGroup.Enabled = Enable;
            cmbContractLD.Enabled = Enable;
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
                     "آیا از حذف نوع قرارداد اطمینان دارید",
                     "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    int ContractTypeCode = -1;
                    ContractTypeCode = int.Parse(txtContractType_Code.Text);
                    new DAL.Contract_Type().Delete_ContractType(ContractTypeCode);
                    startIndex = cmbPages.SelectedIndex * 100 + 1;
                    endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
                    fill_ContractType(startIndex, endIndex);
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
            int ContractType = 0;
            float ContractRate = 0;
            try
            {
                if (!int.TryParse(txtContractType_Code.Text, out ContractType) || txtContractTypeDesc.Text.Length == 0 || 
                        //!float.TryParse(txtContractRate.Text, out ContractRate) ||
                           cmbContractTypeGroup.SelectedIndex == -1 || cmbContractLD.SelectedIndex == -1)
                {
                    Routines.ShowErrorMessageFa("خطا در ذخیره سازی", "اطلاعات وارد شده ناقص است", MyDialogButton.OK);
                    return;
                }

                ContractRate = txtContractRate.Text.Length > 0 ? float.Parse(txtContractRate.Text) : 0;

                if (NewMode)
                    new DAL.Contract_Type().Insert_ContractType(ContractType, Convert.ToInt32(cmbContractLD.SelectedValue), txtContractTypeDesc.Text,
                                                                    Convert.ToInt32(cmbContractTypeGroup.SelectedValue), ContractRate);
                else if (EditMode)
                    new DAL.Contract_Type().Update_ContractType(ContractType, Convert.ToInt32(cmbContractLD.SelectedValue), txtContractTypeDesc.Text, 
                                                                    Convert.ToInt32(cmbContractTypeGroup.SelectedValue), ContractRate);
                
                NewMode = EditMode = false;
                startIndex = cmbPages.SelectedIndex * 100 + 1;
                endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
                fill_ContractType(startIndex, endIndex);
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