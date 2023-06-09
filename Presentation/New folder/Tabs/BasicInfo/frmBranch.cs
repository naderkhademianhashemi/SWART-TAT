using System;
using System.Data;
using System.Windows.Forms;
using DAL;
using ERMS.Model;
using ERMSLib;

//
using Presentation.Public;
using Utilize.Helper;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.Tabs.BasicInfo
{
    public partial class frmBranch : BaseForm, IPrintable
    {
        #region " Var"

        DataSet ds;
        BranchDataSet clsBranch;
        int startIndex, endIndex;

        #endregion

        public frmBranch()
        {
            InitializeComponent();
            InitializeForm();
            GeneralDataGridView = dgvBranch;
        }

        private void InitializeForm()
        {
            this.bindingNavigatorSearchItem.ToolTipText = "جستجو";
            this.bindingNavigatorReturnItem.ToolTipText = "بازگشت به حالت اول";
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
            var count = new DAL.Table_DataSetTableAdapters.OrganizationTableAdapter().GetCount();
            //int count = int.Parse(clsBranch.BranchCount());
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
            ds = clsBranch.GetBranch(startIndex, endIndex);

            bngBranch.DataSource = ds;
            bngBranch.DataMember = ds.Tables[0].TableName;
            bngNBranch.BindingSource = bngBranch;

            dgvBranch.DataSource = bngBranch;

            dgvBranch.Columns["Row"].HeaderText = "رديف";
            dgvBranch.Columns["Branch"].HeaderText = "كد شعبه";
            dgvBranch.Columns["Branch_Description"].HeaderText = "نام شعبه";
            dgvBranch.Columns["State_Of_Branch"].HeaderText = "استان شعبه";
            dgvBranch.Columns["Branch_Rank"].HeaderText = "رتبه شعبه";
        }


        private void fill_txt_Branch()
        {
            txtBranch_Code.DataBindings.Add(new Binding("Text", this.bngBranch, "Branch", true));
            txtBranch_Name.DataBindings.Add(new Binding("Text", this.bngBranch, "Branch_Description", true));
            txtStateBranch.DataBindings.Add(new Binding("Text", this.bngBranch, "State_Of_Branch", true));
        }

        private void cmbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            startIndex = cmbPages.SelectedIndex * 100 + 1;
            endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
            fill_Branch(startIndex, endIndex);
        }
       
        private void BranchSearch()
        {
            DataTable dt = dgvBranch.Grid2TableSearch();
            //dt = Risk_Manegment.Common.Grid2TableSearch(dgvBranch);

            frmSearch frm = new frmSearch(dt) {TableName = "Organization"};

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ProgressBox.Show();
                    if (frm.Field != string.Empty)
                    {
                        if (frm.Search != string.Empty)
                        {
                            ds = clsBranch.BranchSearch(frm.Search, frm.Field, frm.Operator);
                            bngBranch.DataSource = ds;
                            bngBranch.DataMember = ds.Tables[0].TableName;
                            bngNBranch.BindingSource = bngBranch;
                            dgvBranch.DataSource = bngBranch;
                        }
                    }
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
            BranchSearch();
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
    }
}