using System;
using System.Data;
using System.Windows.Forms;
using ERMS.Model;

//
using ERMSLib;
using Presentation.Public;
using Presentation.UI;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.Tabs.BasicInfo
{
    public partial class frmCustomerGroup : BaseForm, IPrintable
    {

		#region Fields (7) 

        readonly CustomerGroup customerGroup;
        private const int detailHeight = 150;
        private int endIndex;
        private bool isCollapsed = false;
        private bool isNewItem = false;
        private int startIndex;
        private string text = "";

		#endregion Fields 

		#region Constructors (1) 

        public frmCustomerGroup()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
            customerGroup = new CustomerGroup();
            GeneralDataGridView = dgvCustomerGroups;
        }

		#endregion Constructors 

		#region Methods (24) 


		// Public Methods (1) 

        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvCustomerGroups;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "CustomerGroup";
        }


		// Private Methods (23) 

        private void applyBinding()
        {
            bindingNavigator1.BindingSource = bngsrc;
            txtId.DataBindings.Add("Text", bngsrc, "Customer_Group", true);
            txtDesc.DataBindings.Add("Text", bngsrc, "Customer_Group_Description", true);

        }

        private void beginEdit()
        {
            enableTextBoxes();
            foreach (ToolStripItem item in bindingNavigator1.Items)
            {
               
                    item.Enabled = false;
                
            }

            tsbtnSearch.Enabled = false;
            tsbtnRefresh.Enabled = true;
            cbPages.Enabled = false;
            tsbtnSave.Enabled = true;
            dgvCustomerGroups.Enabled = false;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (!isInEditing())
            {
                isNewItem = true;
                beginEdit();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {


            if (hasChildRecord(Convert.ToInt32(txtId.Text)))
            {

                if (Presentation.Public.Routines.ShowMessageBoxFa("اين ركورد داراي ركورد هاي وابسته است، " +
                    "آيا مايل به حذف هستيد ؟ ", "حذف ركورد",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    customerGroup.updateChildRecords(Convert.ToInt32(txtId.Text));
                    bngsrc.RemoveCurrent();
                }
            }

            else if (Presentation.Public.Routines.ShowMessageBoxFa("آيا مايل به حذف هستيد ؟ ", "حذف ركورد",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                bngsrc.RemoveCurrent();
            
            
            customerGroup.Update();
        }

        private void btnHideDetails_Click(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                isCollapsed = true;
                grp.Hide();
                dgvCustomerGroups.Height += detailHeight;
                //groupBox2.Height += detailHeight;
               
                splAll.SplitterDistance += detailHeight;

            }
            else
            {
                isCollapsed = false;
                grp.Show();
               
                dgvCustomerGroups.Height -= detailHeight;
                //groupBox2.Height -= detailHeight;
                splAll.SplitterDistance -= detailHeight;
            }
        }

        private void cmbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            startIndex = cbPages.SelectedIndex * 100 + 1;
            endIndex = (cbPages.SelectedIndex + 1) * 100 - 1;
            fill_dgvCustomerGroups();
        }

        private void disableTextBoxes()
        {
            this.txtId.ReadOnly = true;
            this.txtDesc.ReadOnly = true;
        }

        private void disableToolstripExeptRefresh()
        {
            foreach (ToolStripItem item in bindingNavigator1.Items)
            {
                item.Enabled = false;
            }
            tsbtnRefresh.Enabled = true;
        }

        private void enableTextBoxes()
        {
            this.txtId.ReadOnly = false;
            this.txtDesc.ReadOnly = false;
        }

        private void endEdit()
        {
            disableTextBoxes();
            foreach (ToolStripItem item in bindingNavigator1.Items)
            {
                if (item != tsbtnSave)
                {
                    item.Enabled = true;
                }
            }

            tsbtnSearch.Enabled = true;
            cbPages.Enabled = true;
            tsbtnSave.Enabled = false;
            dgvCustomerGroups.Enabled = true;
            isNewItem = false;
        }

        private void fill_cmbPages()
        {
            int count = customerGroup.Count();
            
            for (int i = 1; i < count; i = i + 100)
            {
                cbPages.Items.Add(string.Format("{0} .. {1}", i, i + 100 - 1));
            }
            cbPages.SelectedIndex = cbPages.Items.Count == 0 ? -1 : 0;
            startIndex = cbPages.SelectedIndex * 100 + 1;
            endIndex = (cbPages.SelectedIndex + 1) * 100 - 1;
        }

        private void fill_dgvCustomerGroups()
        {
            DataSet ds = customerGroup.SearchCustomerGroup(null, null, null, startIndex, endIndex);

            bngsrc.DataSource = ds;
            bngsrc.DataMember = ds.Tables[0].TableName;

            dgvCustomerGroups.AutoGenerateColumns = true;
            dgvCustomerGroups.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCustomerGroups.DataSource = bngsrc;
            dgvCustomerGroups.Columns[0].HeaderText = "كد";
            dgvCustomerGroups.Columns[1].HeaderText = "گروه مشتري";

        }

        private void frmCustomerGroup_Load(object sender, EventArgs e)
        {
         
                Helper h = new Helper();
                h.FormatDataGridView(dgvCustomerGroups);
                dgvCustomerGroups.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                fill_cmbPages();
                fill_dgvCustomerGroups();
                applyBinding();
                bindingNavigator1.DeleteItem = null;

         
        }

        private bool isInEditing()
        {
            return ((!txtId.Enabled) && (!txtDesc.Enabled));

        }

        private void search()
        {
            DataTable dt = new DataTable();

            dt = Presentation.Tabs.BasicInfo.Common.Grid2TableSearch(dgvCustomerGroups);

            frmSearch frm = new frmSearch(dt);
            frm.TableName = "Customer_Group";

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    ProgressBox.Show();
                    if (frm.Field != string.Empty)
                    {
                        if (frm.Search != string.Empty)
                        {
                            DataSet ds = null;

                            if (frm.Field.ToLower().Equals("Customer_Group".ToLower()))
                            {
                                ds = customerGroup.SearchCustomerGroup(frm.Search, null, frm.Operator);
                            }
                            else if (frm.Field.ToLower().Equals("Customer_Group_description".ToLower()))
                            {
                                ds = customerGroup.SearchCustomerGroup(null, frm.Search, frm.Operator);
                            }

                            if (ds.Tables[0].Rows.Count == 0)
                            {
                                disableToolstripExeptRefresh();
                            }
                            bngsrc.DataSource = ds;
                            bngsrc.DataMember = ds.Tables[0].TableName;
                            bindingNavigator1.BindingSource = bngsrc;
                            dgvCustomerGroups.DataSource = bngsrc;
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

        private void tsbtn_Click(object sender, EventArgs e)
        {
            if (!isInEditing())
            {
                text = txtId.Text;
                beginEdit();
            }
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (!isInEditing())
            {
                text = txtId.Text;
                beginEdit();
                this.txtId.ReadOnly = true;
            }
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            if (isInEditing())
            {
                cancelCurrentEdit();
                endEdit();
            }
            else
            {
                //startIndex Modify 1387-04-03 modifyer:A_Abbsi
                //fill_cmbPages();
                //End modify
                fill_dgvCustomerGroups();
                endEdit();
            }
            bngsrc.MoveFirst();
        }

        private void cancelCurrentEdit()
        {
            txtId.DataBindings["Text"].BindingManagerBase.CancelCurrentEdit();
            txtDesc.DataBindings["Text"].BindingManagerBase.CancelCurrentEdit();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
           if (!validateTextfields())
            {
                endEdit();
                tsbtnRefresh_Click(null, null);
                return;
            }

            
            else doSaving();

            endEdit();
            tsbtnRefresh_Click(null, null);
            
        }

        private void doSaving()
        {
            try
            {
                txtId.DataBindings["Text"].BindingManagerBase.EndCurrentEdit();
                txtDesc.DataBindings["Text"].BindingManagerBase.EndCurrentEdit();

                customerGroup.Update();
                Presentation.Public.Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد", "ذخيره سازي", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("اشكال در ذخيره كردن تغييرات!", "خطا", MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
            }
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDesc.Text.Length > 49 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private bool validateTextfields()
        {

            if (txtId.Text == string.Empty || txtDesc.Text == string.Empty)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("بايد هر دو فيلد را پر كنيد!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            
            if (isNewItem)// || text != txtId.Text)
            {
                if (customerGroup.Exist(txtId.Text))
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("كد وارد شده تكراري مي باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            
            
            //isNewItem = false;
            return true;
        }


        private bool hasChildRecord(int Customer_Group_id)
        {
            return customerGroup.childRecordCount(Customer_Group_id) > 0 ? true : false;

        }

		#endregion Methods 

    }
}