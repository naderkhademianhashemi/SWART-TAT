///
/// Created By Bahramian In 87/03/11**
///
using System;
using System.Data;
using System.Windows.Forms;
using ERMS.Model;

//
using ERMSLib;
using Presentation.Public;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.Tabs.BasicInfo
{
    public partial class frmCollateralType : BaseForm, IPrintable
    {
        #region Variables
        DataTable ds;
        DataSet ds1;
        CollateralType CollateralType;
        private int intStartIndex;
        private int intEndIndex;
        private int intgbxHeight;
        private int intdgvHeight;
        private bool bolFormLoad; //ها هنگام eventمتغير براي شناسايي اينكه فرم اولين بار لود شده يا خير چون اكثر 
        //لود فرم به اجبار فراخواني مي شوند 
        private int intTarnsValue;
        private bool bolResult;
        CollatMajorType collatMajorType;  //آماده در اين فرم مي باشد sp و استفاده از  combo اين براي پر كردن 
        private bool bolIsEdit;
        #endregion

        #region Constructor
        public frmCollateralType()
        {
            CollateralType = new CollateralType();
            collatMajorType = new CollatMajorType();
            InitializeComponent();
            InitializeForm();
            clsERMSGeneral.InitializeTheme(this);
            bolFormLoad = false;
            ds = new DataTable();
            ds1 = new DataSet();
            GeneralDataGridView = dgvCollateral_Type;
        }
        #endregion

        #region Form events

        private void frmCollateralType_Load(object sender, EventArgs e)
        {
            try
            {
                Form_Load();
                bindingToTxt();
                txtCollateral_Type.ReadOnly = true;
                //txtCollateral_Type_Desc.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Routines.ShowMessageBoxFa(ex.Message, "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCollateralType_KeyDown(object sender, KeyEventArgs e)
        {
            //Find
            if (e.Control && e.KeyCode.ToString() == "F")
            {
                Collateral_TypeSearch();

            }
        }
        #endregion

        #region Initial methods

        private void initGrid(int intStartIndex, int intEndIndex)
        {
            //DataSet ds = new DataSet();
            ds = CollateralType.GetCollateral_Type(intStartIndex, intEndIndex);
            Helper h = new Helper();
            if (ds.Rows.Count > 0)
            {
                bindingSource1.DataSource = ds;
                
                bindingNavigator1.BindingSource = bindingSource1;
                dgvCollateral_Type.DataSource = bindingSource1;
                dgvCollateral_Type.Columns["Row"].HeaderText = "رديف";
                dgvCollateral_Type.Columns["Collateral_Type"].HeaderText = "نوع وثيقه";
                dgvCollateral_Type.Columns["Collateral_Type_Desc"].HeaderText = "شرح نوع وثيقه";
                dgvCollateral_Type.Columns["Collat_Major_Type_Desc"].HeaderText = "نوع اصلي وثيقه";
                 //dgvCollateral_Type.Columns["Collateral_Major_Type"].Visible = false;

                h.FormatDataGridView(dgvCollateral_Type);
                dgvCollateral_Type.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            }
            // dgvApprovement_Reference.RightToLeft = RightToLeft.Yes ;
            dgvCollateral_Type.ReadOnly = true;
            dgvCollateral_Type.AllowUserToDeleteRows = true;
            dgvCollateral_Type.Columns["Row"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvCollateral_Type.Columns["Collateral_Type"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvCollateral_Type.Columns["Collateral_Type_Desc"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvCollateral_Type.Columns["Collat_Major_Type_Desc"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvApprovement_Reference.Columns[0].ReadOnly = true;
        }

        private void SetMaxLenght()
        {
            txtCollateral_Type.MaxLength = 4;
            txtCollateral_Type_Desc.MaxLength = 255;
        }

        private void InitializeForm()
        {
            bindingNavigatorAddNewItem.ToolTipText = "جديد";
            bindingNavigatorDeleteItem.ToolTipText = "حذف";
            bindingNavigatorMoveFirstItem.ToolTipText = "بازگشت به اول";
            bindingNavigatorMoveLastItem.ToolTipText = "بازگشت به آخر";
            bindingNavigatorMoveNextItem.ToolTipText = "بعدي";
            bindingNavigatorMovePreviousItem.ToolTipText = "قبلي";
            bindingNavigatorSaveItem.ToolTipText = "ذخيره";
            bindingNavigatorEditItem.ToolTipText = "ويرايش";
            bindingNavigatorSearchItem.ToolTipText = "جستجو";
            bindingNavigatorReturnItem.ToolTipText = "بازگشت به حالت اول";
            txtCollateral_Type.Text = string.Empty;
        }

        private void Form_Load()
        {
        
                SetMaxLenght();
                fill_cmbPages();
                Fill_cmbCollatMajorType();
                bindingNavigatorAddNewItem.Tag = false;
                dgvCollateral_Type.Enabled = true;
                controlBtn();
                //intgbxHeight = groupBox1.Height;
                intdgvHeight = dgvCollateral_Type.Height;
                for (int intRow = 1; intRow < dgvCollateral_Type.Rows.Count; intRow++)
                {
                    if (dgvCollateral_Type.Rows[intRow].Selected)
                    {
                        dgvCollateral_Type.Rows[intRow].Selected = false;
                    }
                }
                dgvCollateral_Type.Rows[0].Selected = true;
                bindingNavigatorBtn(true);
                txtCollateral_Type.ReadOnly = true;
                txtCollateral_Type_Desc.ReadOnly = true;
                cmbCollatMajorType.Enabled = false;
                bolFormLoad = true;
                bolIsEdit = false; 
        
        }
        #endregion

        #region methods

        private void fill_cmbPages()
        {

            cmbPages.Items.Clear();
            int count = int.Parse(CollateralType.Collateral_TypeCount());
            for (int i = 1; i < count; i = i + 100)
            {
                cmbPages.Items.Add(string.Format("{0} .. {1}", i, i + 100 - 1));
            }
            cmbPages.SelectedIndex = cmbPages.Items.Count == 0 ? -1 : 0;
            intStartIndex = cmbPages.SelectedIndex * 100 + 1;
            intEndIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
            bolFormLoad = false;
            initGrid(intStartIndex, intEndIndex);
            bolFormLoad = true;
        }

        /// <summary>
        /// اين تابع براي جلوگيري از ثبت كد تكراري در جدول مي باشد
        /// </summary>
        /// <returns>
        ///بر ميگرداند true و در حالت صحيح مقدار  false در صورتيكه كد تكراري باشد مقدار 
        /// </returns>
        private bool isDupplicate()
        {
            bolResult = true;
            intTarnsValue = int.Parse(txtCollateral_Type.Text.Trim());
            if (CollateralType.checkDuplicated(intTarnsValue))
            {
                Routines.ShowMessageBoxFa("كد وارد شده تكراري مي باشد ",
                    "پيغام", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                bolResult = false;
                txtCollateral_Type.Focus();
            }
            return bolResult;
        }

        private void bindingToTxt()
        {
            txtCollateral_Type.DataBindings.Add(new Binding("Text", bindingSource1, "Collateral_Type", true));
            txtCollateral_Type_Desc.DataBindings.Add(new Binding("Text", bindingSource1, "Collateral_Type_Desc", true));
            txtCollateral_Type.ReadOnly = false;
            cmbCollatMajorType.DataBindings.Add(new Binding("Text", bindingSource1, "Collat_Major_Type_Desc", true));
        }

        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvCollateral_Type;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "Collateral_Type";
        }  

        private void Collateral_TypeSearch()
        {
            DataTable dt = new DataTable();

            dt = Common.Grid2TableSearch(dgvCollateral_Type);

            frmSearch frm = new frmSearch(dt);
            frm.TableName = "Collateral_Type";

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    ProgressBox.Show();
                    if (frm.Field != string.Empty)
                    {
                        if (frm.Search != string.Empty)
                        {
                            ds = CollateralType.Collateral_TypeSearch(frm.Search, frm.Field, frm.Operator);
                            bindingSource1.DataSource = ds;
                            bindingSource1.DataMember = ds.TableName;
                            bindingNavigator1.BindingSource = bindingSource1;
                            dgvCollateral_Type.DataSource = bindingSource1;
                            if (dgvCollateral_Type.RowCount == 0)
                            {
                                bindingNavigatorBtn(false);
                                bindingNavigatorReturnItem.Enabled = true;
                                bindingNavigatorSaveItem.Enabled = false;
                            }
                            else
                                bindingNavigatorBtn(true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Routines.ShowMessageBoxFa(ex.Message, "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ProgressBox.Hide();
                }
            }
        }

        /// <summary>
        ///مي باشد Not Allow Null اين متد براي كنترل وارد كردن داده هاي ضروري در فيلدهاي 
        /// </summary>
        /// <returns>
        ///برميگرداند false برمي گرداند در غير اينصورت  true در صورتيكه كليه فيلدهاي ضروري وارد شده باشند مقدار 
        /// </returns>
        private bool Vreify()
        {
            if (txtCollateral_Type.Text.Trim() == string.Empty)
            {
                if (Routines.ShowMessageBoxFa("آيا مايل به ادامه عمليات ثبت هستيد ؟ ",
                                                "نوع وثيقه وارد نشده", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    txtCollateral_Type.Text = string.Empty;
                    txtCollateral_Type_Desc.Text = string.Empty;
                    txtCollateral_Type.ReadOnly = false;
                    //txtCollateral_Type_Desc.ReadOnly = false;
                    txtCollateral_Type.Focus();
                }
                else
                {
                    bolFormLoad = false;
                    Form_Load();
                    bolFormLoad = true;
                }
                return false;
            }
            else
                return true;
        }

        private void controlBtn()
        {
            bindingNavigatorEditItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorSaveItem.Enabled = false;
            txtCollateral_Type.ReadOnly = false;
            //txtCollateral_Type_Desc.ReadOnly = false;
        }

        private void Fill_cmbCollatMajorType()
        {
            ds1 = collatMajorType.Sel_Collat_Major_Type();
            cmbCollatMajorType.DataSource = ds1.Tables[0];
            cmbCollatMajorType.DisplayMember = "Collat_Major_Type_Desc";
            cmbCollatMajorType.ValueMember = "Collat_Major_Type";

            cmbCollatMajorType.DroppedDown = false;
        }

        #endregion

        #region ComboBox events
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

        private void cmbCollatMajorType_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }

        private void cmbCollatMajorType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (bolFormLoad)
                {

                    dgvCollateral_Type.SelectedRows[0].Cells[3].Value =
                    cmbCollatMajorType.Text;
                    //Modify 87-04-09
                    if (!(bool)bindingNavigatorAddNewItem.Tag)
                        bindingNavigatorAddNewItem.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Button events
       
        private void btnModel_Click(object sender, EventArgs e)
        {
            if (!spcAll.Panel2Collapsed)
            {
                spcAll.Panel2Collapsed = true;
                spcAll.Panel2.Hide();
                dgvCollateral_Type.ScrollBars = ScrollBars.Vertical;
                //groupBox1.Height = Height - 130;
                //dgvCollateral_Type.Height = groupBox1.Height - 20;
            }
            else
            {
                spcAll.Panel2Collapsed = false;
                spcAll.Panel2.Show();
                //groupBox1.Height = intgbxHeight;
                dgvCollateral_Type.Height = intdgvHeight;

            }
        }
        #endregion

        #region bindingNavigator events
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {

                bindingNavigatorAddNewItem.Tag = true;
                bindingNavigatorBtn(false);
                //txtCollateral_Type.Text = string.Empty;
                //txtCollateral_Type_Desc.Text = string.Empty;
                //cmbCollatMajorType.SelectedIndex = 0;
                //dgvCollateral_Type.Rows[dgvCollateral_Type.RowCount - 1].Cells[0].Value =
                 // ds.Rows.Count + 1;

                
                    txtCollateral_Type.ReadOnly = false;
                    txtCollateral_Type_Desc.ReadOnly = false;
                    //cmbCollatMajorType.Enabled = true;
                
                //dgvCollateral_Type.Rows[dgvCollateral_Type.Rows.Count - 1].Selected = true;
                //bindingNavigatorAddNewItem.Enabled = false;
                
                
                dgvCollateral_Type.Enabled = false;
                txtCollateral_Type.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Vreify())
                {
                    if (!bolIsEdit)  //اگر كاربر ركورد جديد وارد كند
                    {
                        if (isDupplicate())
                        {
                            if (CollateralType.InsertCollateral_Type(int.Parse(txtCollateral_Type.Text),
                                                                     txtCollateral_Type_Desc.Text, int.Parse(cmbCollatMajorType.SelectedValue.ToString())))
                                dgvCollateral_Type.Rows[dgvCollateral_Type.Rows.Count - 1].Cells[1].Value =
                                        txtCollateral_Type.Text;
                            dgvCollateral_Type.Rows[dgvCollateral_Type.Rows.Count - 1].Cells[2].Value =
                                    txtCollateral_Type_Desc.Text;
                            dgvCollateral_Type.Rows[dgvCollateral_Type.Rows.Count - 1].Cells[3].Value =
                                    cmbCollatMajorType.Text;
                            //dgvCollateral_Type.Rows[dgvCollateral_Type.Rows.Count - 1].Cells[4].Value =
                            //    /*(object)*/cmbCollatMajorType.SelectedValue ;
                            controlBtn();
                            txtCollateral_Type.ReadOnly = true;
                            bindingNavigatorAddNewItem.Tag = true;
                            Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ",
                                                      "پيغام", MessageBoxButtons.OK,
                                                      MessageBoxIcon.Exclamation);
                            bindingNavigatorBtn(true);
                        }
                        else
                        {
                            bindingNavigatorAddNewItem.Tag = false;
                            dgvCollateral_Type.Rows[dgvCollateral_Type.Rows.Count - 1].Cells[1].Value = DBNull.Value;
                            dgvCollateral_Type.Rows[dgvCollateral_Type.Rows.Count - 1].Cells[2].Value = DBNull.Value;
                            dgvCollateral_Type.Rows[dgvCollateral_Type.Rows.Count - 1].Cells[3].Value = DBNull.Value;
                            txtCollateral_Type.Text = string.Empty;
                            txtCollateral_Type_Desc.Text = string.Empty;
                            bindingNavigatorBtn(false);
                            bindingNavigatorReturnItem.Enabled = true;
                            return;
                        }
                    }
                    else   //اگر كاربر ركوردي را ويرايش كند
                    {
                        if (CollateralType.InsertCollateral_Type(int.Parse(txtCollateral_Type.Text),
                                         txtCollateral_Type_Desc.Text, int.Parse(cmbCollatMajorType.SelectedValue.ToString())))
                            Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ",
                                                      "پيغام", MessageBoxButtons.OK,
                                                      MessageBoxIcon.Exclamation);
                        //bindingNavigatorEditItem.Enabled = true;
                        //bindingNavigatorSaveItem.Enabled = false;
                        bolFormLoad = false;
                        initGrid(intStartIndex, intEndIndex);
                        bindingNavigatorBtn(true);
                        dgvCollateral_Type.Enabled = true;
                        bolFormLoad = true;
                        bolIsEdit = false;
                    }
                }
                else
                {

                    return;
                }
                dgvCollateral_Type.Enabled = true;
                bindingNavigatorAddNewItem.Tag = false;
                txtCollateral_Type_Desc.ReadOnly = true;
                cmbCollatMajorType.Enabled = false;
            }
            catch (Exception ex)
            {
                Routines.ShowMessageBoxFa(ex.Message, "پیغام",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (bolFormLoad)
                {
                    if (Routines.ShowMessageBoxFa(" كليه اطلاعات جداول وابسته به اين جدول حذف خواهد شد .\n\t آيا مايل به حذف هستيد ؟",
                   "پيغام", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {

                        Refresh();
                        if (txtCollateral_Type.Text != string.Empty)
                        {
                            if (CollateralType.DeleteCollateral_Type(int.Parse(txtCollateral_Type.Text)))
                            {
                                bolFormLoad = false;
                                initGrid(intStartIndex, intEndIndex);
                                bolFormLoad = true;
                               Refresh();
                            }
                            else
                            {
                                bolFormLoad = false;
                                initGrid(intStartIndex, intEndIndex);
                                bolFormLoad = true;
                                return;
                            }
                        }

                        bindingNavigatorSaveItem.Enabled = false;
                        Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            try
            {
                bolIsEdit = true;
                bindingNavigatorBtn(false);
                //bindingNavigatorEditItem.Enabled = false;
                //bindingNavigatorSaveItem.Enabled = true;
                dgvCollateral_Type.Enabled = false;
                txtCollateral_Type_Desc.ReadOnly = false;
                cmbCollatMajorType.Enabled = true;
            }
            catch (Exception ex)
            {
                Routines.ShowMessageBoxFa(ex.Message, "پیغام",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorReturnItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            bolFormLoad = false;
            Form_Load();
            Form_Load();
            bolFormLoad = true;
            txtCollateral_Type.ReadOnly = true;
            dgvCollateral_Type.Rows[dgvCollateral_Type.Rows.Count - 1].Selected = false;
            dgvCollateral_Type.Rows[0].Selected = true;
            dgvCollateral_Type.FirstDisplayedScrollingRowIndex = dgvCollateral_Type.Rows[0].Index;
            Cursor = Cursors.Default;
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            Collateral_TypeSearch();
        }
        

        private void bindingNavigatorBtn(bool bolState)
        {
            bindingNavigatorMoveFirstItem.Enabled = bolState;
            bindingNavigatorMoveLastItem.Enabled = bolState;
            bindingNavigatorMoveNextItem.Enabled = bolState;
            bindingNavigatorMovePreviousItem.Enabled = bolState;
            bindingNavigatorEditItem.Enabled = bolState;
            bindingNavigatorAddNewItem.Enabled = bolState;
            bindingNavigatorDeleteItem.Enabled = bolState;
            bindingNavigatorSaveItem.Enabled = !bolState;
            bindingNavigatorSearchItem.Enabled = bolState;
        }
        #endregion

        #region TextBox Events
        #region txtCollateral_Type
        private void txtCollateral_Type_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }

        private void txtCollateral_Type_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (bolFormLoad && (bool)bindingNavigatorAddNewItem.Tag)
                {
                    if (txtCollateral_Type.Text.Trim() == string.Empty ||
                        txtCollateral_Type.Text == DBNull.Value.ToString())
                        return;
                    dgvCollateral_Type.Rows[dgvCollateral_Type.Rows.Count - 1].Cells[1].Value =
                    txtCollateral_Type.Text;
                    //Modify 87-04-09
                    if (!(bool)bindingNavigatorAddNewItem.Tag)
                        bindingNavigatorAddNewItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCollateral_Type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (bolFormLoad)
            {
                if ((e.KeyChar < (char)48 || e.KeyChar > (char)57) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)32 && e.KeyChar != (char)59 && e.KeyChar != (char)45)
                {
                    e.Handled = true;
                }
            }
        }
        #endregion

        #region txtCollateral_Type_Desc
        private void txtCollateral_Type_Desc_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }
        #endregion
        #endregion

        #region DataGrid events
        private void dgvCollateral_Type_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (!clsERMSGeneral.CloseForm)
                {
                    if (bolFormLoad && (bool)bindingNavigatorAddNewItem.Tag)
                    {

                        if (dgvCollateral_Type.SelectedRows[0].Index == dgvCollateral_Type.Rows.Count - 1)
                        {
                            txtCollateral_Type.ReadOnly = false;
                            //txtCollateral_Type_Desc.ReadOnly = false;
                        }
                        else
                        {
                            txtCollateral_Type.ReadOnly = true;
                            //txtCollateral_Type_Desc.ReadOnly = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        

       

        

        

        

       


        
    }
}