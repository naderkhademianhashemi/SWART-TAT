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
    public partial class frmCollatMajorType : BaseForm, IPrintable
    {
        #region Variables
        DataTable ds;
        CollatMajorType  CollMajorType;
        private int intStartIndex;
        private int intEndIndex;
        private int intgbxHeight;
        private int intdgvHeight;
        private bool bolFormLoad; //ها هنگام eventمتغير براي شناسايي اينكه فرم اولين بار لود شده يا خير چون اكثر 
        //لود فرم به اجبار فراخواني مي شوند 
        private int intTarnsValue;
        private bool bolResult;
        private bool bolIsEdit;
        #endregion

        #region Constructor
        public frmCollatMajorType()
        {
            CollMajorType = new CollatMajorType();
            InitializeComponent();
            InitializeForm();
            clsERMSGeneral.InitializeTheme(this);
            bolFormLoad = false;
            ds = new DataTable();
            GeneralDataGridView = dgvCollat_Major_Type;
        }
        #endregion

        #region Form events
        private void frmCollat_Major_Type_Load(object sender, EventArgs e)
        {
            try
            {
                Form_Load();
                bindingToTxt();
                txtCollat_Major_Type.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCollat_Major_Type_KeyDown(object sender, KeyEventArgs e)
        {
            //Find
            if (e.Control && e.KeyCode.ToString() == "F")
            {
                Collat_Major_TypeSearch();

            }
        }
        #endregion

        #region Initial methods

        private void initGrid(int intStartIndex, int intEndIndex)
        {
            //DataSet ds = new DataSet();
            ds = CollMajorType.GetCollat_Major_Type(intStartIndex, intEndIndex);
            Helper h = new Helper();
            if (ds.Rows.Count > 0)
            {
                bindingSource1.DataSource = ds;
                
                bindingNavigator1.BindingSource = bindingSource1;
                dgvCollat_Major_Type.DataSource = bindingSource1;
                dgvCollat_Major_Type.Columns["Row"].HeaderText = "رديف";
                dgvCollat_Major_Type.Columns["Collat_Major_Type"].HeaderText = "نوع اصلي وثيقه";
                dgvCollat_Major_Type.Columns["Collat_Major_Type_Desc"].HeaderText = "شرح نوع اصلي وثيقه";

                h.FormatDataGridView(dgvCollat_Major_Type);
                dgvCollat_Major_Type.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            }
            // dgvApprovement_Reference.RightToLeft = RightToLeft.Yes ;
            dgvCollat_Major_Type.ReadOnly = true;
            dgvCollat_Major_Type.AllowUserToDeleteRows = true;
            dgvCollat_Major_Type.Columns["Row"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvCollat_Major_Type.Columns["Collat_Major_Type"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvCollat_Major_Type.Columns["Collat_Major_Type_Desc"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvApprovement_Reference.Columns[0].ReadOnly = true;
        }

        private void SetMaxLenght()
        {
            txtCollat_Major_Type.MaxLength = 4;
            txtCollat_Major_Type_Desc.MaxLength = 50;
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
            txtCollat_Major_Type.Text = string.Empty;
        }

        private void Form_Load()
        {
           
                
                SetMaxLenght();
                fill_cmbPages();
                bindingNavigatorAddNewItem.Tag = false;
                dgvCollat_Major_Type.Enabled = true;
                controlBtn();
                //intgbxHeight = groupBox1.Height;
                intdgvHeight = dgvCollat_Major_Type.Height;
                for (int intRow = 1; intRow < dgvCollat_Major_Type.Rows.Count; intRow++)
                {
                    if (dgvCollat_Major_Type.Rows[intRow].Selected)
                    {
                        dgvCollat_Major_Type.Rows[intRow].Selected = false;
                    }
                }
                dgvCollat_Major_Type.Rows[0].Selected = true;
                bindingNavigatorBtn(true);
                txtCollat_Major_Type.ReadOnly = true;
                txtCollat_Major_Type_Desc.ReadOnly = true;
                bolFormLoad = true;
                bolIsEdit = false; 
           
        }
        #endregion

        #region methods

        private void fill_cmbPages()
        {

            cmbPages.Items.Clear();
            int count = int.Parse(CollMajorType.Collat_Major_TypeCount());
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
            intTarnsValue = int.Parse(txtCollat_Major_Type.Text.Trim());
            if (CollMajorType.checkDuplicated(intTarnsValue))
            {
                Presentation.Public.Routines.ShowMessageBoxFa("كد وارد شده تكراري مي باشد ",
                    "پيغام", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                bolResult = false;
                txtCollat_Major_Type.Focus();
            }
            return bolResult;
        }

        private void bindingToTxt()
        {
            txtCollat_Major_Type.DataBindings.Add(new Binding("Text", bindingSource1, "Collat_Major_Type", true));
            txtCollat_Major_Type_Desc.DataBindings.Add(new Binding("Text", bindingSource1, "Collat_Major_Type_Desc", true));
            txtCollat_Major_Type.ReadOnly = false;
            //txtCollat_Major_Type_Desc.ReadOnly = false;
        }

        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvCollat_Major_Type;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "Collat_Major_Type";
        }  

        private void Collat_Major_TypeSearch()
        {
            DataTable dt = new DataTable();

            dt = Common.Grid2TableSearch(dgvCollat_Major_Type);

            frmSearch frm = new frmSearch(dt);
            frm.TableName = "Collat_Major_Type";

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    ProgressBox.Show();
                    if (frm.Field != string.Empty)
                    {
                        if (frm.Search != string.Empty)
                        {
                            ds = CollMajorType.Collat_Major_TypeSearch(frm.Search, frm.Field, frm.Operator);
                            bindingSource1.DataSource = ds;
                            bindingSource1.DataMember = ds.TableName;
                            bindingNavigator1.BindingSource = bindingSource1;
                            dgvCollat_Major_Type.DataSource = bindingSource1;
                            if (dgvCollat_Major_Type.RowCount == 0)
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
                    Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtCollat_Major_Type.Text.Trim() == string.Empty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آيا مايل به ادامه عمليات ثبت هستيد ؟ ",
                                                "نوع اصلي وثيقه وارد نشده", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    txtCollat_Major_Type.Text = string.Empty;
                    txtCollat_Major_Type_Desc.Text = string.Empty;
                    txtCollat_Major_Type.ReadOnly = false;
                    //txtCollat_Major_Type_Desc.ReadOnly = false;
                    txtCollat_Major_Type.Focus();
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
            txtCollat_Major_Type.ReadOnly = false;
            //txtCollat_Major_Type_Desc.ReadOnly = false;
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
        #endregion

        #region Button events

        #region btnModel
        private void btnModel_Click(object sender, EventArgs e)
        {
            if (!spcAll.Panel2Collapsed)
            {
                spcAll.Panel2Collapsed = true;
                spcAll.Panel2.Hide();
                dgvCollat_Major_Type.ScrollBars = ScrollBars.Vertical;
                //groupBox1.Height = Height - 130;
                //dgvCollat_Major_Type.Height = groupBox1.Height - 20;
            }
            else
            {
                spcAll.Panel2Collapsed = false;
                spcAll.Panel2.Show();
                //groupBox1.Height = intgbxHeight;
                dgvCollat_Major_Type.Height = intdgvHeight;

            }
        }
        #endregion
        
        #endregion

        #region bindingNavigator events
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                bindingNavigatorAddNewItem.Tag = true;
                bindingNavigatorBtn(false);
               // txtCollat_Major_Type.Text = string.Empty;
                //txtCollat_Major_Type_Desc.Text = string.Empty;
                //dgvCollat_Major_Type.Rows[dgvCollat_Major_Type.RowCount - 1].Cells[0].Value =
                //  ds.Rows.Count + 1;

                //if (dgvCollat_Major_Type.SelectedRows[0].Index ==
                //    dgvCollat_Major_Type.Rows.Count - 1)
                //{
                    txtCollat_Major_Type.ReadOnly = false;
                    txtCollat_Major_Type_Desc.ReadOnly = false;
                //}
                //dgvCollat_Major_Type.Rows[dgvCollat_Major_Type.Rows.Count - 1].Selected = true;
                //bindingNavigatorAddNewItem.Enabled = false;
                dgvCollat_Major_Type.Enabled = false;
                
                txtCollat_Major_Type.Focus();

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
                            if (CollMajorType.InsertCollat_Major_Type(int.Parse(txtCollat_Major_Type.Text),
                                                                      txtCollat_Major_Type_Desc.Text))
                                dgvCollat_Major_Type.Rows[dgvCollat_Major_Type.Rows.Count - 1].Cells[1].Value =
                                        txtCollat_Major_Type.Text;
                            dgvCollat_Major_Type.Rows[dgvCollat_Major_Type.Rows.Count - 1].Cells[2].Value =
                                    txtCollat_Major_Type_Desc.Text;
                            controlBtn();
                            txtCollat_Major_Type.ReadOnly = true;
                            bindingNavigatorAddNewItem.Tag = true;
                            Presentation.Public.Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ",
                                                      "پيغام", MessageBoxButtons.OK,
                                                      MessageBoxIcon.Exclamation);
                            bindingNavigatorBtn(true);
                        }
                        else
                        {
                            bindingNavigatorAddNewItem.Tag = false;
                            dgvCollat_Major_Type.Rows[dgvCollat_Major_Type.Rows.Count - 1].Cells[1].Value = DBNull.Value;
                            dgvCollat_Major_Type.Rows[dgvCollat_Major_Type.Rows.Count - 1].Cells[2].Value = DBNull.Value;
                            txtCollat_Major_Type.Text = string.Empty;
                            txtCollat_Major_Type_Desc.Text = string.Empty;
                            bindingNavigatorBtn(false);
                            bindingNavigatorReturnItem.Enabled = true;
                            return;
                        }
                    }
                    else   //اگر كاربر ركوردي را ويرايش كند
                    {
                        if (CollMajorType.InsertCollat_Major_Type(int.Parse(txtCollat_Major_Type.Text),
                                                                  txtCollat_Major_Type_Desc.Text))
                            Presentation.Public.Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ",
                                                      "پيغام", MessageBoxButtons.OK,
                                                      MessageBoxIcon.Exclamation);
                        //bindingNavigatorEditItem.Enabled = true;
                        //bindingNavigatorSaveItem.Enabled = false;
                        bolFormLoad = false;
                        initGrid(intStartIndex, intEndIndex);
                        bindingNavigatorBtn(true);
                        dgvCollat_Major_Type.Enabled = true;
                        bolFormLoad = true;
                        bolIsEdit = false;
                    }
                }
                else
                {

                    return;
                }
                dgvCollat_Major_Type.Enabled = true;
                bindingNavigatorAddNewItem.Tag = false;
                txtCollat_Major_Type_Desc.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "پیغام",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (bolFormLoad)
                {
                    if (Presentation.Public.Routines.ShowMessageBoxFa(" كليه اطلاعات جداول وابسته به اين جدول حذف خواهد شد .\n\t آيا مايل به حذف هستيد ؟",
                   "پيغام", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {

                        Refresh();
                        if (txtCollat_Major_Type.Text != string.Empty)
                        {
                            if (CollMajorType.DeleteCollat_Major_Type(int.Parse(txtCollat_Major_Type.Text)))
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
                dgvCollat_Major_Type.Enabled = false;
                txtCollat_Major_Type_Desc.ReadOnly = false;
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "پیغام",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            Collat_Major_TypeSearch();
        }

        private void bindingNavigatorReturnItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            bolFormLoad = false;
            Form_Load();
            Form_Load();
            bolFormLoad = true;
            txtCollat_Major_Type.ReadOnly = true;
            dgvCollat_Major_Type.Rows[dgvCollat_Major_Type.Rows.Count - 1].Selected = false;
            dgvCollat_Major_Type.Rows[0].Selected = true;
            dgvCollat_Major_Type.FirstDisplayedScrollingRowIndex = dgvCollat_Major_Type.Rows[0].Index;
            Cursor = Cursors.Default;
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
        #region txtCollat_Major_Type
        private void txtCollat_Major_Type_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }

        private void txtCollat_Major_Type_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (bolFormLoad && (bool)bindingNavigatorAddNewItem.Tag)
                {
                    if (txtCollat_Major_Type.Text.Trim() == string.Empty ||
                        txtCollat_Major_Type.Text == DBNull.Value.ToString())
                        return;
                    dgvCollat_Major_Type.Rows[dgvCollat_Major_Type.Rows.Count - 1].Cells[1].Value =
                    txtCollat_Major_Type.Text;
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

        private void txtCollat_Major_Type_KeyPress(object sender, KeyPressEventArgs e)
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

        #region txtCollat_Major_Type_Desc
        private void txtCollat_Major_Type_Desc_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }
        #endregion
        
        #endregion

        #region DataGrid events
        private void dgvCollat_Major_Type_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (!clsERMSGeneral.CloseForm)
                {
                    if (bolFormLoad && (bool)bindingNavigatorAddNewItem.Tag)
                    {

                        if (dgvCollat_Major_Type.SelectedRows[0].Index == dgvCollat_Major_Type.Rows.Count - 1)
                        {
                            txtCollat_Major_Type.ReadOnly = false;
                            //txtCollat_Major_Type_Desc.ReadOnly = false;
                        }
                        else
                        {
                            txtCollat_Major_Type.ReadOnly = true;
                            //txtCollat_Major_Type_Desc.ReadOnly = true;
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