using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERMS.Model;

//

using ERMSLib;
using Presentation.Public;
using Presentation.UI;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.Tabs.BasicInfo
{
    public partial class frmContractStatus : BaseForm, IPrintable
    {

		#region Fields (7) 

        readonly ContractStatus contractStatus;
        private const int detailHeight = 150;
        private int endIndex;
        private bool isCollapsed = false;
        private bool isNewitem = false;
        private int startIndex;
        private string text;

		#endregion Fields 

		#region Constructors (1) 

        public frmContractStatus()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
            contractStatus = new ContractStatus();
            GeneralDataGridView = dgvContractStatus;
        }

		#endregion Constructors 

		#region Methods (22) 


		// Private Methods (22) 

        private void applyBinding()
        {
            bindingNavigator1.BindingSource = bngsrc;
            txtId.DataBindings.Add("Text", bngsrc, "status", true);
            txtDesc.DataBindings.Add("Text", bngsrc, "status_desc", true);

        }

        private void beginEdit()
        {
            enableTextBoxes();
            foreach (ToolStripItem item in bindingNavigator1.Items)
            {
                item.Enabled = false;    
            }


            tsbtnSearch.Enabled = false;
            cbPages.Enabled = false;
            tsbtnSave.Enabled = true;
            tsbtnRefresh.Enabled = true;
            dgvContractStatus.Enabled = false;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (!isInEditing())
            {
                isNewitem = true;
                beginEdit();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {



            if (hasChildRecord(txtId.Text))
            {

                if (Presentation.Public.Routines.ShowMessageBoxFa("اين ركورد داراي ركورد هاي وابسته است، " +
                    "آيا مايل به حذف هستيد ؟ ", "حذف ركورد",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contractStatus.updateChildRecords(txtId.Text);
                    bngsrc.RemoveCurrent();
                }
            }

            else if (Presentation.Public.Routines.ShowMessageBoxFa("آيا مايل به حذف هستيد ؟ ", "حذف ركورد",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                bngsrc.RemoveCurrent();
            
            
            contractStatus.Update();


        }

        private void btnHideDetails_Click(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                isCollapsed = true;
                grp.Hide();
                
                dgvContractStatus.Height += detailHeight;
                //groupBox2.Height += detailHeight;
                splAll.SplitterDistance += detailHeight;

            }
            else
            {
                isCollapsed = false;
                grp.Show();
                dgvContractStatus.Height -= detailHeight;
                //groupBox2.Height -= detailHeight;
                splAll.SplitterDistance -= detailHeight;
            }
        }

        private void cbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            startIndex = cbPages.SelectedIndex * 100 + 1;
            endIndex = (cbPages.SelectedIndex + 1) * 100 - 1;
            fill_dgvContractStatus();
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
            dgvContractStatus.Enabled = true;
            isNewitem = false;
        }

        private void fill_cmbPages()
        {
            int count = contractStatus.Count();

            for (int i = 1; i < count; i = i + 100)
            {
                cbPages.Items.Add(string.Format("{0} .. {1}", i, i + 100 - 1));
            }
            cbPages.SelectedIndex = cbPages.Items.Count == 0 ? -1 : 0;
            startIndex = cbPages.SelectedIndex * 100 + 1;
            endIndex = (cbPages.SelectedIndex + 1) * 100 - 1;
        }

        private void fill_dgvContractStatus()
        {
            DataSet ds = contractStatus.SearchContractStatus(null, null, startIndex, endIndex);

            bngsrc.DataSource = ds;
            bngsrc.DataMember = ds.Tables[0].TableName;


            dgvContractStatus.AutoGenerateColumns = true;
            dgvContractStatus.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvContractStatus.DataSource = bngsrc;
            dgvContractStatus.Columns[0].HeaderText = "كد";
            dgvContractStatus.Columns[1].HeaderText = "وضعيت قرارداد";

        }

        private void frmContractStatus_Load(object sender, EventArgs e)
        {

         
                Helper h = new Helper();
                h.FormatDataGridView(dgvContractStatus);
                dgvContractStatus.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                fill_cmbPages();
                fill_dgvContractStatus();
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

            dt = Common.Grid2TableSearch(dgvContractStatus);

            frmSearch frm = new frmSearch(dt);
            frm.TableName = "Contract_Status";

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

                            if (frm.Field.ToLower().Equals("status".ToLower()))
                            {
                                ds = contractStatus.SearchContractStatus(frm.Search, null);
                            }
                            else if (frm.Field.ToLower().Equals("status_desc".ToLower()))
                            {
                                ds = contractStatus.SearchContractStatus(null, frm.Search);
                            }

                            if (ds.Tables[0].Rows.Count == 0)
                            {
                                disableToolstripExeptRefresh();
                            }
                            bngsrc.DataSource = ds;
                            bngsrc.DataMember = ds.Tables[0].TableName;
                            bindingNavigator1.BindingSource = bngsrc;
                            dgvContractStatus.DataSource = bngsrc;
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
                fill_dgvContractStatus();
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
                contractStatus.Update();
                Presentation.Public.Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ", "ذخيره سازي", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
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

        //private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
        //    {
        //        e.Handled = true;
        //    }
        //}

        private bool validateTextfields()
        {

            if (txtId.Text == string.Empty || txtDesc.Text == string.Empty)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("بايد هر دو فيلد را پر كنيد!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (isNewitem)// || text != txtId.Text)
            {
                if (contractStatus.Exist(txtId.Text))
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("كد وارد شده تكراري مي باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            

            //isNewitem = false;
            return true;
        }

        private bool hasChildRecord(string status)
        {
            return contractStatus.childRecordCount(status) > 0 ? true : false;

        }

		#endregion Methods 


        #region IPrintable Members

        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvContractStatus;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "ContractStatus";
        }

        #endregion
    }
}