using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ERMS.Model;

//
using ERMSLib;
using Presentation.Public;
using ProgressBox = Presentation.Public.ProgressBox;


namespace Presentation.Tabs.BasicInfo
{
    public partial class frmContractMajorType : BaseForm, IPrintable
    {

        #region Fields (7)

        readonly ContractMajorTypes contractMType;
        private const int detailHeight = 140;
        private int endIndex;
        private bool isCollapsed = false;
        private bool isNewItem;
        private int startIndex;
        private string text;

        #endregion Fields

        #region Constructors (1)

        public frmContractMajorType()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
            contractMType = new ContractMajorTypes();
            GeneralDataGridView = dgvContractMajorType;
        }

        #endregion Constructors

        #region Methods (22)


        // Private Methods (22) 

        private void applyBinding()
        {
            bindingNavigator1.BindingSource = bngsrc;
            txtId.DataBindings.Add("Text", bngsrc, "Contract_MType_id", true);
            txtDesc.DataBindings.Add("Text", bngsrc, "Contract_MType_Desc", true);

        }

        private void beginEdit()
        {
            enableTextBoxes();
            foreach (ToolStripItem item in bindingNavigator1.Items)
            {

                item.Enabled = false;

            }
            cbPages.Enabled = false;
            tsbtnSave.Enabled = true;
            tsbtnRefresh.Enabled = true;
            dgvContractMajorType.Enabled = false;

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
                    contractMType.updateChildRecords(Convert.ToInt32(txtId.Text));
                    bngsrc.RemoveCurrent();
                }
            }
            
            else if (Presentation.Public.Routines.ShowMessageBoxFa("آيا مايل به حذف هستيد ؟ ", "حذف ركورد",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                bngsrc.RemoveCurrent();


            contractMType.Update();

        }

        private void btnHideDetails_Click(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                isCollapsed = true;
                grp.Hide();
                dgvContractMajorType.Height += detailHeight;
                //groupBox2.Height += detailHeight;
                spcAll.SplitterDistance += detailHeight;

            }
            else
            {
                isCollapsed = false;
                grp.Show();
                dgvContractMajorType.Height -= detailHeight;
                //groupBox2.Height -= detailHeight;
                spcAll.SplitterDistance -= detailHeight;
            }
        }

        private void cmbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            startIndex = cbPages.SelectedIndex * 100 + 1;
            endIndex = (cbPages.SelectedIndex + 1) * 100 - 1;
            fill_dgvContractMajorType();
        }

        private void disableTextBoxes()
        {
            txtId.ReadOnly = true;
            txtDesc.ReadOnly = true;
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
            txtId.ReadOnly = false;
            txtDesc.ReadOnly = false;
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
            dgvContractMajorType.Enabled = true;
            isNewItem = false;
        }

        private void fill_cmbPages()
        {
            int count = contractMType.Count();

            for (int i = 1; i < count; i = i + 100)
            {
                cbPages.Items.Add(string.Format("{0} .. {1}", i, i + 100 - 1));
            }
            cbPages.SelectedIndex = cbPages.Items.Count == 0 ? -1 : 0;
            startIndex = cbPages.SelectedIndex * 100 + 1;
            endIndex = (cbPages.SelectedIndex + 1) * 100 - 1;

        }

        private void fill_dgvContractMajorType()
        {
            DataSet ds = contractMType.SearchContractMajorType(null, null, null, startIndex, endIndex);

            bngsrc.DataSource = ds;
            bngsrc.DataMember = ds.Tables[0].TableName;


            dgvContractMajorType.AutoGenerateColumns = true;
            dgvContractMajorType.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvContractMajorType.DataSource = bngsrc;
            dgvContractMajorType.Columns[0].HeaderText = "كد";
            dgvContractMajorType.Columns[1].HeaderText = " نوع عقد";

        }

        private void frmContractMajorType_Load(object sender, EventArgs e)
        {
            
                Helper h = new Helper();
                h.FormatDataGridView(dgvContractMajorType);
                dgvContractMajorType.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                fill_cmbPages();
                fill_dgvContractMajorType();
                applyBinding();
                bindingNavigator1.DeleteItem = null;

            
        }

        private bool isInEditing()
        {
            return ((!txtId.Enabled) && (!txtDesc.Enabled));

        }

        private void search()
        {
            DataTable dt;

            dt = Common.Grid2TableSearch(dgvContractMajorType);

            frmSearch frm = new frmSearch(dt);
            frm.TableName = "Contract_Major_Type";

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

                            if (frm.Field.ToLower().Equals("Contract_MType_id".ToLower()))
                            {

                                ds = contractMType.SearchContractMajorType(frm.Search, null, frm.Operator);
                            }
                            else if (frm.Field.ToLower().Equals("Contract_MType_Desc".ToLower()))
                            {
                                ds = contractMType.SearchContractMajorType(null, frm.Search, frm.Operator);
                            }

                            if (ds.Tables[0].Rows.Count == 0)
                            {
                                disableToolstripExeptRefresh();
                            }
                            bngsrc.DataSource = ds;
                            bngsrc.DataMember = ds.Tables[0].TableName;
                            bindingNavigator1.BindingSource = bngsrc;
                            dgvContractMajorType.DataSource = bngsrc;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ProgressBox.Hide();
                }
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
                fill_dgvContractMajorType();
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
                cancelCurrentEdit();
                endEdit();
                return;
            }

            doSaving();
            

            endEdit();
            tsbtnRefresh_Click(null, null);
        }

        private void doSaving()
        {
            try
            {
                txtId.DataBindings["Text"].BindingManagerBase.EndCurrentEdit();
                txtDesc.DataBindings["Text"].BindingManagerBase.EndCurrentEdit();

                contractMType.Update();
                Presentation.Public.Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ", "ذخيره سازي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindingNavigatorDeleteItem.Enabled = true;
                tsbtnEdit.Enabled = true;

            }
            catch (SqlException)
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
                if (contractMType.Exist(txtId.Text))
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("كد وارد شده تكراري مي باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            //isNewItem = false;
            return true;
        }

        private bool hasChildRecord(int contrtactMtypeId)
        {
            return contractMType.childRecordCount(contrtactMtypeId) > 0 ? true : false;
            
        }


        #endregion Methods

        #region IPrintable Members

        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvContractMajorType;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "ContractMajorType";
        }

        #endregion

        private void spcAll_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}