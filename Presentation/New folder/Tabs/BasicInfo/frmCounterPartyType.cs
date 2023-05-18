using System;
using System.Data;
using System.Windows.Forms;
using ERMS.Model;

//
using ERMSLib;
using Presentation.Public;


namespace Presentation.Tabs.BasicInfo
{
    public partial class frmCounterPartyType : BaseForm, IPrintable
    {

        #region Fields (7)

        readonly CounterpartyType counterpartyType;
        private const int detailHeight = 150;
        private int endIndex;
        private bool isCollapsed = false;
        private bool isNewItem = false;
        private int startIndex;
        private string text;

        #endregion Fields

        #region Constructors (1)

        public frmCounterPartyType()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
            counterpartyType = new CounterpartyType();
            GeneralDataGridView = dgvConterpartyTypes;
        }

        #endregion Constructors

        #region Methods (23)


        // Private Methods (23) 

        private void applyBinding()
        {
            bindingNavigator1.BindingSource = bngsrc;
            txtId.DataBindings.Add("Text", bngsrc, "Counterparty_Type", true);
            txtDesc.DataBindings.Add("Text", bngsrc, "Counterparty_Type_Desc", true);

        }



        private void beginEdit()
        {
            enableTextBoxes();
            foreach (ToolStripItem item in bindingNavigator1.Items)
            {

                item.Enabled = false;

            }

            tsbtnRefresh.Enabled = true;
            cbPages.Enabled = false;
            tsbtnSave.Enabled = true;
            dgvConterpartyTypes.Enabled = false;

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
                Presentation.Public.Routines.ShowMessageBoxFa("اين ركورد داراي ركورد هاي وابسته بوده و قابل حذف نيست ", "حذف ركورد",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (Presentation.Public.Routines.ShowMessageBoxFa("آيا مايل به حذف هستيد ؟ ", "حذف ركورد",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bngsrc.RemoveCurrent();

                counterpartyType.Update();
            }
        }

        private void btnHideDetails_Click(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                isCollapsed = true;
                grp.Hide();
                dgvConterpartyTypes.Height += detailHeight;
                
                //groupBox2.Height += detailHeight;
                splAll.SplitterDistance += detailHeight;

            }
            else
            {
                isCollapsed = false;
                grp.Show();
                dgvConterpartyTypes.Height -= detailHeight;
                //groupBox2.Height -= detailHeight;
                splAll.SplitterDistance -= detailHeight;
            }
        }

        private void cmbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            startIndex = cbPages.SelectedIndex * 100 + 1;
            endIndex = (cbPages.SelectedIndex + 1) * 100 - 1;
            fill_dgvCounterpartyType();
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
            this.txtId.ReadOnly = false;
            this.txtDesc.ReadOnly = false;
        }

        private void endEdit()
        {
            disableTextBoxes();
            foreach (ToolStripItem item in bindingNavigator1.Items)
            {

                item.Enabled = true;

            }


            cbPages.Enabled = true;
            tsbtnSave.Enabled = false;
            dgvConterpartyTypes.Enabled = true;
            isNewItem = false;
        }

        private void fill_cmbPages()
        {
            int count = counterpartyType.Count();

            for (int i = 1; i < count; i = i + 100)
            {
                cbPages.Items.Add(string.Format("{0} .. {1}", i, i + 100 - 1));
            }
            cbPages.SelectedIndex = cbPages.Items.Count == 0 ? -1 : 0;
            startIndex = cbPages.SelectedIndex * 100 + 1;
            endIndex = (cbPages.SelectedIndex + 1) * 100 - 1;
        }

        private void fill_dgvCounterpartyType()
        {
            DataSet ds = counterpartyType.SearchCounterpartyType(null, null, null, startIndex, endIndex);

            bngsrc.DataSource = ds;
            bngsrc.DataMember = ds.Tables[0].TableName;


            dgvConterpartyTypes.AutoGenerateColumns = true;
            dgvConterpartyTypes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvConterpartyTypes.DataSource = bngsrc;
            dgvConterpartyTypes.Columns[0].HeaderText = "كد";
            dgvConterpartyTypes.Columns[1].HeaderText = "نوع مشتري";

        }

        private void frmCounterPartyType_Load(object sender, EventArgs e)
        {
           
                Helper h = new Helper();
                h.FormatDataGridView(dgvConterpartyTypes);
                dgvConterpartyTypes.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                fill_cmbPages();
                fill_dgvCounterpartyType();
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

            dt = Presentation.Tabs.BasicInfo.Common.Grid2TableSearch(dgvConterpartyTypes);

            frmSearch frm = new frmSearch(dt);
            frm.TableName = "Counterparty_Type";

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               
                    if (frm.Field != string.Empty)
                    {
                        if (frm.Search != string.Empty)
                        {
                            DataSet ds = null;

                            if (frm.Field.ToLower().Equals("Counterparty_Type".ToLower()))
                            {
                                ds = counterpartyType.SearchCounterpartyType(frm.Search, null, frm.Operator);
                            }
                            else if (frm.Field.ToLower().Equals("Counterparty_Type_Desc".ToLower()))
                            {
                                ds = counterpartyType.SearchCounterpartyType(null, frm.Search, frm.Operator);
                            }

                            if (ds.Tables[0].Rows.Count == 0)
                            {
                                disableToolstripExeptRefresh();
                            }
                            bngsrc.DataSource = ds;
                            bngsrc.DataMember = ds.Tables[0].TableName;
                            bindingNavigator1.BindingSource = bngsrc;
                            dgvConterpartyTypes.DataSource = bngsrc;
                        }
                    }
               
            }
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {

            if (!isInEditing())
            {
                text = txtId.Text;
                beginEdit();
                txtId.ReadOnly = true;
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
                fill_dgvCounterpartyType();
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

                counterpartyType.Update();
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
                if (counterpartyType.Exist(txtId.Text))
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("كد وارد شده تكراري مي باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            //isNewItem = false;
            return true;
        }

        private bool hasChildRecord(int Counterparty_Type_id)
        {
            return counterpartyType.childRecordCount(Counterparty_Type_id) > 0 ? true : false;

        }

        #endregion Methods


        #region IPrintable Members

        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvConterpartyTypes;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "ConterpartyType";
        }
        #endregion

    }
}