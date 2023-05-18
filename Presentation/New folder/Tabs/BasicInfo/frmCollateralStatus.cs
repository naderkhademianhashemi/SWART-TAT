///
/// Created By Bahramian In 87/03/12**
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
    public partial class frmCollateralStatus : BaseForm, IPrintable
    {
        #region Variables
        DataTable ds;
        CollateralStatus collStatus;
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
        public frmCollateralStatus()
        {
            collStatus = new CollateralStatus();
            InitializeComponent();
            InitializeForm();
            clsERMSGeneral.InitializeTheme(this);
            bolFormLoad = false;
            ds = new DataTable();
            GeneralDataGridView = dgvCollateral_Status;
        }
        #endregion

        #region Form events
        private void frmCollateralStatus_Load(object sender, EventArgs e)
        {
            try
            {
                Form_Load();
                bindingToTxt();
                txtCollat_Stat.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCollateralStatus_KeyDown(object sender, KeyEventArgs e)
        {
            //Find
            if (e.Control && e.KeyCode.ToString() == "F")
            {
                Collateral_StatusSearch();

            }
        }
        #endregion

        #region Initial methods

        private void initGrid(int intStartIndex, int intEndIndex)
        {
            //DataSet ds = new DataSet();
            ds = collStatus.GetCollateral_Status(intStartIndex, intEndIndex);
            Helper h = new Helper();
            if (ds.Rows.Count > 0)
            {
                bindingSource1.DataSource = ds;
                
                bindingNavigator1.BindingSource = bindingSource1;
                dgvCollateral_Status.DataSource = bindingSource1;
                dgvCollateral_Status.Columns["Row"].HeaderText = "رديف";
                dgvCollateral_Status.Columns["Collat_Stat"].HeaderText = "وضعيت وثيقه";
                dgvCollateral_Status.Columns["Collat_Stat_Desc"].HeaderText = "شرح وضعيت وثيقه";

                h.FormatDataGridView(dgvCollateral_Status);
                dgvCollateral_Status.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                dgvCollateral_Status.ReadOnly = true;
                dgvCollateral_Status.AllowUserToDeleteRows = true;
                dgvCollateral_Status.Columns["Row"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            // dgvApprovement_Reference.RightToLeft = RightToLeft.Yes ;
          
            //dgvCollateral_Status.Columns["Collat_Stat"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvCollateral_Status.Columns["Collat_Stat_Desc"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void SetMaxLenght()
        {
            txtCollat_Stat.MaxLength = 4;
            txtCollat_Stat_Desc.MaxLength = 50;
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
            txtCollat_Stat.Text = string.Empty;
        }

        private void Form_Load()
        {
          
                SetMaxLenght();
                fill_cmbPages();
                bindingNavigatorAddNewItem.Tag = false;
                dgvCollateral_Status.Enabled = true;
                controlBtn();
                //intgbxHeight = groupBox1.Height;
                intdgvHeight = dgvCollateral_Status.Height;
                for (int intRow = 1; intRow < dgvCollateral_Status.Rows.Count; intRow++)
                {
                    if (dgvCollateral_Status.Rows[intRow].Selected)
                    {
                        dgvCollateral_Status.Rows[intRow].Selected = false;
                    }
                }
                if (dgvCollateral_Status.Rows.Count != 0)
                {
                    dgvCollateral_Status.Rows[0].Selected = true;
                    bindingNavigatorBtn(true);
                }
                txtCollat_Stat.ReadOnly = true;
                txtCollat_Stat_Desc.ReadOnly = true; 
                bolFormLoad = true;
                bolIsEdit = false;
           }
        #endregion

        #region methods

        private void fill_cmbPages()
        {

            cmbPages.Items.Clear();
            int count = int.Parse(collStatus.Collateral_StatusCount());
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
            intTarnsValue = int.Parse(txtCollat_Stat.Text.Trim());
            if (collStatus.checkDuplicated(intTarnsValue))
            {
                Presentation.Public.Routines.ShowMessageBoxFa("كد وارد شده تكراري مي باشد ",
                    "پيغام", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                bolResult = false;
                txtCollat_Stat.Focus();
            }
            return bolResult;
        }

        private void bindingToTxt()
        {
            if (dgvCollateral_Status.Rows.Count != 0)
            {
                txtCollat_Stat.DataBindings.Add(new Binding("Text", bindingSource1, "Collat_Stat", true));
                txtCollat_Stat_Desc.DataBindings.Add(new Binding("Text", bindingSource1, "Collat_Stat_Desc", true));
                txtCollat_Stat.ReadOnly = false;
            }
            //txtCollat_Major_Type_Desc.ReadOnly = false;
        }

        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvCollateral_Status;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "Collateral_Status";
        }  
        private void Collateral_StatusSearch()
        {
            DataTable dt = new DataTable();

            dt = Common.Grid2TableSearch(dgvCollateral_Status);

            frmSearch frm = new frmSearch(dt);
            frm.TableName = "Collateral_Status";

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    ProgressBox.Show();
                    if (frm.Field != string.Empty)
                    {
                        if (frm.Search != string.Empty)
                        {
                            ds = collStatus.Collateral_StatusSearch(frm.Search, frm.Field, frm.Operator);
                            bindingSource1.DataSource = ds;
                            bindingSource1.DataMember = ds.TableName;
                            bindingNavigator1.BindingSource = bindingSource1;
                            dgvCollateral_Status.DataSource = bindingSource1;
                            if (dgvCollateral_Status.RowCount == 0)
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
            if (txtCollat_Stat.Text.Trim() == string.Empty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آيا مايل به ادامه عمليات ثبت هستيد ؟ ",
                                                "وضعيت وثيقه وارد نشده", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    txtCollat_Stat.Text = string.Empty;
                    txtCollat_Stat_Desc.Text = string.Empty;
                    txtCollat_Stat.ReadOnly = false;
                    txtCollat_Stat.Focus();
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
            txtCollat_Stat.ReadOnly = false;
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

        #region btnModel
        private void btnModel_Click(object sender, EventArgs e)
        {
            if (!spcAll.Panel2Collapsed)
            {
                spcAll.Panel2Collapsed = true;
                spcAll.Panel2.Hide();
                dgvCollateral_Status.ScrollBars = ScrollBars.Vertical;
                //groupBox1.Height = Height - 130;
                //dgvCollateral_Status.Height = groupBox1.Height - 30;
            }
            else
            {
                spcAll.Panel2Collapsed = false;
                spcAll.Panel2.Show();
    
                dgvCollateral_Status.Height = intdgvHeight;

            }
        }
        #endregion

        #region bindingNavigator events
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                bindingNavigatorAddNewItem.Tag = true;
                txtCollat_Stat.Text = string.Empty;
                txtCollat_Stat_Desc.Text = string.Empty;
                dgvCollateral_Status.Rows[dgvCollateral_Status.RowCount - 1].Cells[0].Value =
                  ds.Rows.Count + 1;

                if (dgvCollateral_Status.SelectedRows[0].Index ==
                    dgvCollateral_Status.Rows.Count - 1)
                {
                    txtCollat_Stat.ReadOnly = false;
                    txtCollat_Stat_Desc.ReadOnly = false;
                }
                dgvCollateral_Status.Rows[dgvCollateral_Status.Rows.Count - 1].Selected = true;
                dgvCollateral_Status.Enabled = false;
                bindingNavigatorBtn(false);
                txtCollat_Stat.Focus();
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
                            if (collStatus.InsertCollateral_Status(int.Parse(txtCollat_Stat.Text),
                                                                   txtCollat_Stat_Desc.Text))
                                dgvCollateral_Status.Rows[dgvCollateral_Status.Rows.Count - 1].Cells[1].Value =
                                        txtCollat_Stat.Text;
                            dgvCollateral_Status.Rows[dgvCollateral_Status.Rows.Count - 1].Cells[2].Value =
                                    txtCollat_Stat_Desc.Text;
                            controlBtn();
                            txtCollat_Stat.ReadOnly = true;
                            bindingNavigatorAddNewItem.Tag = true;
                            Presentation.Public.Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ",
                                                      "پيغام", MessageBoxButtons.OK,
                                                      MessageBoxIcon.Exclamation);
                            bindingNavigatorBtn(true);
                        }
                        else
                        {
                            bindingNavigatorAddNewItem.Tag = false;
                            dgvCollateral_Status.Rows[dgvCollateral_Status.Rows.Count - 1].Cells[1].Value = DBNull.Value;
                            dgvCollateral_Status.Rows[dgvCollateral_Status.Rows.Count - 1].Cells[2].Value = DBNull.Value;
                            txtCollat_Stat.Text = string.Empty;
                            txtCollat_Stat_Desc.Text = string.Empty;
                            bindingNavigatorBtn(false);
                            bindingNavigatorReturnItem.Enabled = true;
                            return;
                        }
                    }
                    else   //اگر كاربر ركوردي را ويرايش كند
                    {
                        if (collStatus.InsertCollateral_Status(int.Parse(txtCollat_Stat.Text),
                                                                 txtCollat_Stat_Desc.Text))
                            Presentation.Public.Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ",
                                                      "پيغام", MessageBoxButtons.OK,
                                                      MessageBoxIcon.Exclamation);
                        //bindingNavigatorEditItem.Enabled = true;
                        //bindingNavigatorSaveItem.Enabled = false;
                        bolFormLoad = false;
                        initGrid(intStartIndex, intEndIndex);
                        bindingNavigatorBtn(true);
                        dgvCollateral_Status.Enabled = true;
                        bolFormLoad = true;
                        bolIsEdit = false;
                    }
                }
                else
                {

                    return;
                }
                dgvCollateral_Status.Enabled = true;
                bindingNavigatorAddNewItem.Tag = false;
                txtCollat_Stat_Desc.ReadOnly = true;
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
                        if (txtCollat_Stat.Text != string.Empty)
                        {
                            if (collStatus.DeleteCollateral_Status(int.Parse(txtCollat_Stat.Text)))
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
                dgvCollateral_Status.Enabled = false;
                txtCollat_Stat_Desc.ReadOnly = false;
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "پیغام",
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
            txtCollat_Stat.ReadOnly = true;
            dgvCollateral_Status.Rows[dgvCollateral_Status.Rows.Count - 1].Selected = false;
            dgvCollateral_Status.Rows[0].Selected = true;
            dgvCollateral_Status.FirstDisplayedScrollingRowIndex = dgvCollateral_Status.Rows[0].Index;
            Cursor = Cursors.Default;
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            Collateral_StatusSearch();
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
        #region txtCollat_Stat
        private void txtCollat_Stat_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }

        private void txtCollat_Stat_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (bolFormLoad && (bool)bindingNavigatorAddNewItem.Tag)
                {
                    if (txtCollat_Stat.Text.Trim() == string.Empty ||
                        txtCollat_Stat.Text == DBNull.Value.ToString())
                        return;
                    dgvCollateral_Status.Rows[dgvCollateral_Status.Rows.Count - 1].Cells[1].Value =
                    txtCollat_Stat.Text;
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

        private void txtCollat_Stat_KeyPress(object sender, KeyPressEventArgs e)
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
        #region txtCollat_Stat_Desc
        private void txtCollat_Stat_Desc_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }
        #endregion
        #endregion

        #region DataGrid events
        private void dgvCollateral_Status_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (!clsERMSGeneral.CloseForm)
                {
                    if (bolFormLoad && (bool)bindingNavigatorAddNewItem.Tag)
                    {

                        if (dgvCollateral_Status.SelectedRows[0].Index == dgvCollateral_Status.Rows.Count - 1)
                        {
                            txtCollat_Stat.ReadOnly = false;
                        }
                        else
                        {
                            txtCollat_Stat.ReadOnly = true;
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