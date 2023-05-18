
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using ERMSLib;

using System.Drawing;
using ERMS.Model;
using Presentation.Public;
using Presentation.Tabs.BasicInfo;
using Utilize.Helper;

namespace Presentation.UI
{


    public partial class frmState : Form ,IPrintable
    {
        #region Variables
        private int intStartIndex;
        private int intEndIndex;
        private DataTable dataTable = new DataTable();
        private bool bolFormLoad;
        private bool bolIsEdit;
        private string strStateCode;
        private int intgbxHeight;

        #endregion

        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvState;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "State";
        }  

        public frmState()
        {
            InitializeComponent();
            InitializeForm();
            clsERMSGeneral.InitializeTheme(this);
        }

        private void InitializeForm()
        {
            this.Font = new Font("Tahoma", (float)8.25, FontStyle.Regular);
            this.groupBox1.Font = new Font("Tahoma", (float)8.25, FontStyle.Regular);
            this.groupBox2.Font = new Font("Tahoma", (float)8.25, FontStyle.Regular);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "استان";
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = false;
            this.groupBox1.Text = string.Empty;
            this.bindingNavigatorAddNewItem.ToolTipText = "جديد";
            this.tlsBtnRemove.ToolTipText = "حذف";
            this.bindingNavigatorMoveFirstItem.ToolTipText = "بازگشت به اول";
            this.bindingNavigatorMoveLastItem.ToolTipText = "بازگشت به آخر";
            this.bindingNavigatorMoveNextItem.ToolTipText = "بعدي";
            this.bindingNavigatorMovePreviousItem.ToolTipText = "قبلي";
            this.tlsBtnSave.ToolTipText = "ذخيره";
            this.tlsBtnEdit.ToolTipText = "ويرايش";
            this.tlsBtnSearch.ToolTipText = "جستجو";
            this.tlsBtnRefresh.ToolTipText = "بازگشت به حالت اوليه";
            this.txtStateID.Text = string.Empty;
        }

        private void frmState_Load(object sender, EventArgs e)
        {
            formLoad();
            bindingToTxt();
            txtStateID.ReadOnly = true;
        }
      

        private void formLoad()
        {
            bindingNavigatorAddNewItem.Tag = false;
            dgvState.Enabled = true;
            controlBtn();
            intgbxHeight = groupBox2.Height;
            fill_cmbPages();
            txtStateID.MaxLength = 10;
            bolFormLoad = false;
            for (int intRow = 1; intRow < dgvState.Rows.Count; intRow++)
            {
                if (dgvState.Rows[intRow].Selected)
                {
                    dgvState.Rows[intRow].Selected = false;
                }
            }
            if (dgvState.Rows.Count != 0)
            {
                dgvState.Rows[0].Selected = true;
                dgvState.FirstDisplayedScrollingRowIndex = dgvState.Rows[0].Index;
                dgvState.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

                bindingNavigatorBtn(true);
            }
            txtStateID.ReadOnly = true;
           
            txtStateName.Enabled = false;
            bolIsEdit = false;
            bolFormLoad = true;
        }
        #region CmbEvents
        private void fill_cmbPages()
        {

            int count = new DAL.Table_DataSetTableAdapters.StateTableAdapter().GetCount().Value;
                // int.Parse(clsState.StateCount());
            cmbPages.Items.Clear();
            for (int i = 1; i < count; i = i + 100)
            {
                cmbPages.Items.Add(string.Format("{0} .. {1}", i, i + 100 - 1));
            }
            cmbPages.SelectedIndex = cmbPages.Items.Count == 0 ? -1 : 0;
            intStartIndex = cmbPages.SelectedIndex*100 + 1;
            intEndIndex = (cmbPages.SelectedIndex + 1)*100 - 1;
            bolFormLoad = false;
            initGrid(intStartIndex, intEndIndex);
            bolFormLoad = true;
        }



        #endregion
       

        #region dgvEvent
        private void initGrid(int intStartIndex, int intEndIndex)
        {
            dataTable = new DAL.SwartDataSetTableAdapters.GetDT_StateTableAdapter().GetData(intStartIndex, intEndIndex);
            Helper h = new Helper();
            if (dataTable.Rows.Count > 0)
            {
                bindingSource1.DataSource = dataTable;
                bindingNavigator1.BindingSource =bindingSource1;
                dgvState.DataSource = bindingSource1;
                dgvState.Columns["Row"].HeaderText = "سطر";
                dgvState.Columns["State_Id"].HeaderText = "كد استان";
                dgvState.Columns["State_Name"].HeaderText = "نام استان";
                h.FormatDataGridView(dgvState);
            
                dgvState.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvState.ReadOnly = true;
                dgvState.AllowUserToDeleteRows = true;

            }

            
        }

        private void dgvState_SelectionChanged(object sender, EventArgs e)
        {
            if (!clsERMSGeneral.CloseForm)
            {
                if (bolFormLoad && (bool)bindingNavigatorAddNewItem.Tag)
                {

                    //if (dgvState.SelectedRows[0].Index == dgvState.Rows.Count - 1)
                    //{
                    //    txtStateID.ReadOnly = false;
                    //}
                    //else
                    //{
                    //    txtStateID.ReadOnly = true;
                    //}
                }
            }
        }
       
        #endregion

        #region btnEvent
        private void bindingNavigatorBtn(bool bolState)
        {
            bindingNavigatorMoveFirstItem.Enabled = bolState;
            bindingNavigatorMoveLastItem.Enabled = bolState;
            bindingNavigatorMoveNextItem.Enabled = bolState;
            bindingNavigatorMovePreviousItem.Enabled = bolState;
            bindingNavigatorAddNewItem.Enabled = bolState;
            tlsBtnEdit.Enabled = bolState;
            tlsBtnRemove.Enabled = bolState;
            tlsBtnSave.Enabled = !bolState;
            tlsBtnSearch.Enabled = bolState;
            tlsBtnRefresh.Enabled = bolState;
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
              
                bindingNavigatorAddNewItem.Tag = true;
                txtStateID.Text = string.Empty;
                dgvState.Rows[dgvState.RowCount - 1].Cells[0].Value =
                  dataTable.Rows.Count + 1;

                if (dgvState.SelectedRows[0].Index ==
                    dgvState.Rows.Count - 1)
                {
                    txtStateID.ReadOnly = false;
                   // txtStateID.Enabled = true;

                    txtStateName.Enabled = true;
               
                }
                dgvState.Rows[dgvState.Rows.Count - 1].Selected = true;
                dgvState.Enabled = false;
                bindingNavigatorBtn(false);
                tlsBtnRefresh.Enabled = true;
                txtStateID.Focus();
            }
            catch (Exception)
            {
            }
        }
        private void btnModel_Click_1(object sender, EventArgs e)
        {
            if (!spcAll.Panel2Collapsed)
            {
                spcAll.Panel2Collapsed = true;
                spcAll.Panel2.Hide();
                groupBox2.Height = this.Height - 150;
                dgvState.Height = groupBox2.Height - 30;
            }
            else
            {
                spcAll.Panel2Collapsed = false;
                spcAll.Panel2.Show();
                groupBox2.Height = intgbxHeight;
                dgvState.Height = groupBox2.Height - 30;//intgbxHeight;

            }
        }
        private bool Vreify()
        {
            if (txtStateID.Text == string.Empty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آيا مايل به ادامه عمليات ثبت هستيد ؟ ",
                                                "كد استان  وارد نشده", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Error) == DialogResult.Yes)
                {

                    txtStateID.Text = string.Empty;
                    txtStateID.ReadOnly = false;
                    txtStateID.Focus();
                }
                else
                {
                    bolFormLoad = false;
                    formLoad();
                    bolFormLoad = true;
                }
                return false;
            }
            if (string.IsNullOrEmpty(txtStateName.Text))
            {
                txtStateName.Text = DBNull.Value.ToString();
            }
                
            return true;
        }
        private void controlBtn()
        {
            tlsBtnEdit.Enabled = true;
            tlsBtnRemove.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            tlsBtnSave.Enabled = false;
            txtStateID.ReadOnly = false;
        }
        private void tlsBtnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Vreify())
                {
                    if (!bolIsEdit)
                    {
                        if (addDataFromTxtToGrid())
                        {
                            if (new DAL.General_DataSet().InsertAndEditState(txtStateID.Text,
                              
                                txtStateName.Text.Trim()))

                                dgvState.Rows[dgvState.Rows.Count - 1].Cells[1].Value =
                                        txtStateID.Text;
                            //dgvState.Rows[dgvState.Rows.Count - 1].Cells[2].Value =
                            //       objGeoState;
                            //dgvState.Rows[dgvState.Rows.Count - 1].Cells[3].Value =
                            //       objStateIncomGrp;
                            dgvState.Rows[dgvState.Rows.Count - 1].Cells[2].Value =
                                   txtStateName.Text.Trim();
                            controlBtn();

                            bindingNavigatorAddNewItem.Tag = true;
                            Presentation.Public.Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ",
                                    "پيغام", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                            bindingNavigatorBtn(true);
                            txtStateID.ReadOnly = true;
                            bindingNavigatorAddNewItem.Tag = false;
                        }
                        else
                        {
                            bindingNavigatorAddNewItem.Tag = false;
                            dgvState.Rows[dgvState.Rows.Count - 1].Cells[1].Value = DBNull.Value;
                            dgvState.Rows[dgvState.Rows.Count - 1].Cells[2].Value = DBNull.Value;
                            //dgvState.Rows[dgvState.Rows.Count - 1].Cells[3].Value = DBNull.Value;
                            //dgvState.Rows[dgvState.Rows.Count - 1].Cells[4].Value = DBNull.Value;
                            txtStateID.Text = string.Empty;
                            bolFormLoad = false;

                            txtStateName.Text = "";
                            bolFormLoad = true;
                            bindingNavigatorBtn(false);
                            tlsBtnRefresh.Enabled = true;
                            return;
                        }
                    }
                    else
                    {
                        if (new DAL.General_DataSet().InsertAndEditState(txtStateID.Text.Trim(),
                          
                           txtStateName.Text.Trim()))

                            Presentation.Public.Routines.ShowMessageBoxFa("ويرايش اطلاعات با موفقيت انجام شد ",
                                "پيغام", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                        //tlsBtnEdit.Enabled = true;
                        //tlsBtnSave.Enabled = false;
                        //tlsBtnRemove.Enabled = true;
                        //bindingNavigatorAddNewItem.Enabled = true;
                        bindingNavigatorBtn(true);
                        
                        dgvState.Enabled = true;
                        bolFormLoad = false;
                        initGrid(intStartIndex, intEndIndex);
                        bolFormLoad = true;
                        bolIsEdit = false;
                    }
                }
                else
                {
                    return;
                }
                dgvState.Enabled = true;
                txtStateID.ReadOnly = true;

                txtStateName.Enabled = false;
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "پیغام",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tlsBtnRemove_Click_1(object sender, EventArgs e)
        {
            if (bolFormLoad)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa(". كليه اطلاعات جداول وابسته به اين جدول حذف خواهد شد \n\t آيا مايل به حذف هستيد ؟",
                   "پيغام", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    this.Refresh();
                    if (txtStateID.Text != string.Empty)
                    {
                        if (new DAL.Table_DataSetTableAdapters.StateTableAdapter().DeleteById(txtStateID.Text.Trim())!=-1)
                        {
                            bolFormLoad = false;
                            initGrid(intStartIndex, intEndIndex);
                            bolFormLoad = true;
                            this.Refresh();
                        }
                        else
                        {
                            bolFormLoad = false;
                            initGrid(intStartIndex, intEndIndex);
                            bolFormLoad = true;
                            return;
                        }
                    }

                    tlsBtnSave.Enabled = false;
                    this.Refresh();
                }
            }
        }
        private void tlsBtnSearch_Click(object sender, EventArgs e)
        {
            StateSearch();
        }
        private void tlsBtnRefresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            bolFormLoad = false;
            formLoad();
            formLoad();
            bolFormLoad = true;
           
            dgvState.Rows[dgvState.Rows.Count - 1].Selected = false;
            Cursor = Cursors.Default;
        }
        private void tlsBtnEdit_Click_1(object sender, EventArgs e)
        {
            bolIsEdit = true;
          //  txtStateID.Enabled = false;
            txtStateID.ReadOnly = true;

            txtStateName.Enabled = true;
       
            //tlsBtnRemove.Enabled = false;
            //bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorBtn(false);
            tlsBtnRefresh.Enabled = true;
            dgvState.Enabled = false;
            //tlsBtnEdit.Enabled = false;
            //tlsBtnSave.Enabled = true;
        }
        #endregion

        #region txtEvent
        private void txtStateID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (bolFormLoad)
            {
                if ((e.KeyChar < (char)48 || e.KeyChar > (char)57) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)32 && e.KeyChar != (char)59 && e.KeyChar != (char)45)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtStateID_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }


        private void txtStateID_MouseLeave(object sender, EventArgs e)
        {
            if (bolFormLoad & dgvState.RowCount > 0 & (bool)bindingNavigatorAddNewItem.Tag)
            {
               // bindingNavigatorAddNewItem.Enabled = false;
                if (txtStateID.Text.Trim() == string.Empty ||
                    txtStateID.Text == DBNull.Value.ToString())
                    return;
                dgvState.Rows[dgvState.Rows.Count - 1].Cells[1].Value =
                    txtStateID.Text;

            }
        }
        private void bindingToTxt()
        {
            if (dgvState.Rows.Count != 0)
            {
                txtStateID.DataBindings.Add(new Binding("Text",
                        bindingSource1, "State_Id", true));
                txtStateName.DataBindings.Add(new Binding("Text",
                    bindingSource1, "State_Name", true));
               
                txtStateID.ReadOnly = false;
            }
        }
        

        #endregion

        private bool addDataFromTxtToGrid()
        {
            bool bolResult = true;
            strStateCode = txtStateID.Text.Trim();
            if (new DAL.Table_DataSetTableAdapters.StateTableAdapter().GetData().Any(item=>item.State_Id.Equals(strStateCode)))
            {
                Presentation.Public.Routines.ShowMessageBoxFa("كد وارد شده تكراري مي باشد ",
                    "پيغام", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                bolResult = false;
            }
            return bolResult;
        }

        private void StateSearch()
        {
            var dt = dgvState.Grid2TableSearch();

            frmSearch frm = new frmSearch(dt) {TableName = "State"};

            if (frm.ShowDialog() == DialogResult.OK)
            {
               
                    if (frm.Field != string.Empty)
                    {
                        if (frm.Search != string.Empty)
                        {
                            dataTable = new DataTable();
                            dataTable = new DAL.General_DataSet().StateSearch(frm.Search, frm.Field, frm.Operator);
                            bindingSource1.DataSource = dataTable;
                            bindingNavigator1.BindingSource = bindingSource1;
                            dgvState.DataSource = bindingSource1;
                            if (dgvState.RowCount == 0)
                            {
                                bindingNavigatorBtn(false);
                                tlsBtnRefresh.Enabled = true;
                                tlsBtnSave.Enabled = false;
                            }
                            else
                                bindingNavigatorBtn(true);
                        }
                    }
               
            }
        }

        private void cmbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bolFormLoad)
            {
                intStartIndex = cmbPages.SelectedIndex * 100 + 1;
                intEndIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
                bolFormLoad = false;
                initGrid(intStartIndex, intEndIndex);
                bolFormLoad = true;
            }
        }

        

       

       

        

       

       


       
       

        

        

       

     

      

      

      

       
       
    }
}