using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ERMS.Model;

//
using ERMSLib;
using Presentation.Public;
using Utilize.Helper;
using ProgressBox = Presentation.Public.ProgressBox;
using Presentation.Tabs.BasicInfo;

namespace Presentation.UI
{
    public partial class frmApprovement_Reference : BaseForm, IPrintable
    {
        #region Variables

        private bool bolFormLoad; //ها هنگام eventمتغير براي شناسايي اينكه فرم اولين بار لود شده يا خير چون اكثر 
                                 //لود فرم به اجبار فراخواني مي شوند
        private bool bolResult;
        private DataTable ds;
        private int intdgvHeight;
        private int intEndIndex;
        private int intgbxHeight;
        private int intStartIndex;
        private string strTarnsValue;
        private bool bolIsEdit;

        #endregion

        #region Constructor

        public frmApprovement_Reference()
        {
            InitializeComponent();
            InitializeForm();
            clsERMSGeneral.InitializeTheme(this);
            bolFormLoad = false;
            bolIsEdit = false;
            ds = new DataTable();
        }

        #endregion

        #region Form events

        private void FrmApprovement_Reference_Load(object sender, EventArgs e)
        {
            try
            {
                Form_Load();
                bindingToTxt();
                txtApp_ref.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmApprovement_Reference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "F")
            {
                Approvement_RefSearch();
            }
        }

        #endregion

        #region Initial methods

        private void initGrid(int intStartIndex, int intEndIndex)
        {
            ds = new DAL.SwartDataSetTableAdapters.GetDT_Approvement_ReferenceTableAdapter().GetData(intStartIndex, intEndIndex);
            Helper h = new Helper();
            if (ds.Rows.Count > 0)
            {
                bindingSource1.DataSource = ds;
                bindingNavigator1.BindingSource = bindingSource1;
                dgvApprovement_Reference.DataSource = bindingSource1;
                dgvApprovement_Reference.Columns["Row"].HeaderText = "رديف";
                dgvApprovement_Reference.Columns["App_ref"].HeaderText = "مرجع تصويب";
                dgvApprovement_Reference.Columns["App_Ref_Desc"].HeaderText = "شرح مرجع تصويب";

                h.FormatDataGridView(dgvApprovement_Reference);
                dgvApprovement_Reference.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            }
            dgvApprovement_Reference.ReadOnly = true;
            dgvApprovement_Reference.AllowUserToDeleteRows = true;
            dgvApprovement_Reference.Columns["Row"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void SetMaxLenght()
        {
            txtApp_ref.MaxLength = 255;
            txtApp_Ref_Desc.MaxLength = 255;
        }

        private void InitializeForm()
        {
            Font = new Font("Tahoma", (float) 8.25, FontStyle.Regular);
            groupBox1.Font = new Font("Tahoma", (float) 8.25, FontStyle.Regular);
            groupBox2.Font = new Font("Tahoma", (float) 8.25, FontStyle.Regular);
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
            txtApp_ref.Text = string.Empty;
        }

        private void Form_Load()
        {
                SetMaxLenght();
                fill_cmbPages();
                bindingNavigatorAddNewItem.Tag = false;
                dgvApprovement_Reference.Enabled = true;
                controlBtn();
                intgbxHeight = groupBox1.Height;
                intdgvHeight = dgvApprovement_Reference.Height;
                for (int intRow = 1; intRow < dgvApprovement_Reference.Rows.Count; intRow++)
                {
                    if (dgvApprovement_Reference.Rows[intRow].Selected)
                    {
                        dgvApprovement_Reference.Rows[intRow].Selected = false;
                    }
                }
                dgvApprovement_Reference.Rows[0].Selected = true;
                bindingNavigatorBtn(true);
                txtApp_ref.ReadOnly = true;
                txtApp_Ref_Desc.ReadOnly = true;
                bolFormLoad = true;
                bolIsEdit = false;
        }

        #endregion

        #region methods

        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvApprovement_Reference;
        }

        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "Approvement_Reference";
        }

        private void fill_cmbPages()
        {
            cmbPages.Items.Clear();
            var count = new DAL.Table_DataSetTableAdapters.Approvement_ReferenceTableAdapter().GetCount().ToString();
            for (var i = 1; i < Convert.ToInt32(count); i = i + 100)
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
            strTarnsValue = txtApp_ref.Text.Trim();
            if (new DAL.Table_DataSetTableAdapters.Approvement_ReferenceTableAdapter().GetDataById(strTarnsValue).Any())
            {Presentation.Public.Routines.ShowErrorMessageFa("خطا", "كد وارد شده تكراري مي باشد ", Public.MyDialogButton.OK);
                bolResult = false;
                txtApp_ref.Focus();
            }
            return bolResult;
        }

        private void bindingToTxt()
        {
            txtApp_ref.DataBindings.Add(new Binding("Text", bindingSource1, "App_ref", true));
            txtApp_Ref_Desc.DataBindings.Add(new Binding("Text", bindingSource1, "App_Ref_Desc", true));
            txtApp_ref.ReadOnly = false;
        }

        private void Approvement_RefSearch()
        {
            var dt = dgvApprovement_Reference.Grid2TableSearch();

            var frm = new frmSearch(dt) {TableName = "Approvement_Reference"};

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ProgressBox.Show();
                    if (frm.Field != string.Empty)
                    {
                        if (frm.Search != string.Empty)
                        {
                            string str;
                            switch (frm.Field)
                            {
                                case "App_Ref_Desc":
                                    str = frm.Search.Trim();
                                    break;

                                default: str = frm.Field + "  like '%" + frm.Search + "%' ";
                                    break;
                            }
                            ds = new DAL.SwartDataSetTableAdapters.GetDT_Approvement_ReferenceSearchTableAdapter().GetData( str,frm.Field);
                            bindingSource1.DataSource = ds;
                            bindingNavigator1.BindingSource = bindingSource1;
                            dgvApprovement_Reference.DataSource = bindingSource1;
                            if (dgvApprovement_Reference.RowCount == 0)
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
                    ex.ConfigLog(false);
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
            if (txtApp_ref.Text.Trim() == string.Empty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آيا مايل به ادامه عمليات ثبت هستيد ؟ ",
                                              "مرجع تصويب وارد نشده", MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    txtApp_ref.Text = string.Empty;
                    txtApp_Ref_Desc.Text = string.Empty;
                    txtApp_ref.ReadOnly = false;
                    txtApp_ref.Focus();
                }
                else
                {
                    bolFormLoad = false;
                    Form_Load();
                    bolFormLoad = true;
                }
                return false;
            }
            return true;
        }

        private void controlBtn()
        {
            bindingNavigatorEditItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorSaveItem.Enabled = false;
            txtApp_ref.ReadOnly = false;
        }

        #endregion

        #region ComboBox events

        private void cmbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bolFormLoad)
            {
                intStartIndex = cmbPages.SelectedIndex*100 + 1;
                intEndIndex = (cmbPages.SelectedIndex + 1)*100 - 1;
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
                dgvApprovement_Reference.ScrollBars = ScrollBars.Vertical;
                groupBox1.Height = Height - 130;
                dgvApprovement_Reference.Height = groupBox1.Height - 20;
            }
            else
            {
                spcAll.Panel2Collapsed = false;
                spcAll.Panel2.Show();
                groupBox1.Height = intgbxHeight;
                dgvApprovement_Reference.Height = intdgvHeight;
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
                //txtApp_ref.Text = string.Empty;
                //txtApp_Ref_Desc.Text = string.Empty;
                //dgvApprovement_Reference.Rows[dgvApprovement_Reference.RowCount - 1].Cells[0].Value =
                //    ds.Rows.Count + 1;

                //if (dgvApprovement_Reference.SelectedRows[0].Index ==
                //    dgvApprovement_Reference.Rows.Count - 1)
                //{
                    txtApp_ref.ReadOnly = false;
                    txtApp_Ref_Desc.ReadOnly = false;
                //}
                //dgvApprovement_Reference.Rows[dgvApprovement_Reference.Rows.Count - 1].Selected = true;
                dgvApprovement_Reference.Enabled = false;
               
                txtApp_ref.Focus();
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
                            if (new DAL.Table_DataSetTableAdapters.Approvement_ReferenceTableAdapter().Insert(txtApp_ref.Text,
                                                                   txtApp_Ref_Desc.Text)!=-1)
                                dgvApprovement_Reference.Rows[dgvApprovement_Reference.Rows.Count - 1].Cells[1].Value =
                                        txtApp_ref.Text;
                            dgvApprovement_Reference.Rows[dgvApprovement_Reference.Rows.Count - 1].Cells[2].Value =
                                    txtApp_Ref_Desc.Text;
                            controlBtn();
                            txtApp_ref.ReadOnly = true;
                            bindingNavigatorAddNewItem.Tag = true;
                            Presentation.Public.Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ",
                                                      "پيغام", MessageBoxButtons.OK,
                                                      MessageBoxIcon.Exclamation);
                            bindingNavigatorBtn(true);
                        }
                        else
                        {
                            bindingNavigatorAddNewItem.Tag = false;
                            dgvApprovement_Reference.Rows[dgvApprovement_Reference.Rows.Count - 1].Cells[1].Value =
                                    DBNull.Value;
                            dgvApprovement_Reference.Rows[dgvApprovement_Reference.Rows.Count - 1].Cells[2].Value =
                                    DBNull.Value;
                            txtApp_ref.Text = string.Empty;
                            txtApp_Ref_Desc.Text = string.Empty;
                            bindingNavigatorBtn(false);
                            bindingNavigatorReturnItem.Enabled = true;
                            return;
                        }
                    }
                    else   //اگر كاربر ركوردي را ويرايش كند
                    {
                        if (new DAL.Table_DataSetTableAdapters.Approvement_ReferenceTableAdapter().UpdateQueryAPP( txtApp_Ref_Desc.Text,txtApp_ref.Text)
                                                               !=-1)
                            Presentation.Public.Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ",
                                                      "پيغام", MessageBoxButtons.OK,
                                                      MessageBoxIcon.Exclamation);
                        bolFormLoad = false;
                        initGrid(intStartIndex, intEndIndex);
                        bindingNavigatorBtn(true);
                        dgvApprovement_Reference.Enabled = true;
                        bolFormLoad = true;
                        bolIsEdit = false;
                    }
                }
                else
                {
                    return;
                }
                dgvApprovement_Reference.Enabled = true;
                bindingNavigatorAddNewItem.Tag = false;
                txtApp_Ref_Desc.ReadOnly = true ;
              
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
                    if (Presentation.Public.Routines.ShowMessageBoxFa(
                            " كليه اطلاعات جداول وابسته به اين جدول حذف خواهد شد .\n\t آيا مايل به حذف هستيد ؟",
                            "پيغام", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Refresh();
                        if (txtApp_ref.Text != string.Empty)
                        {
                            if (new DAL.Table_DataSetTableAdapters.Approvement_ReferenceTableAdapter().DeleteById(txtApp_ref.Text)!=-1)
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
                dgvApprovement_Reference.Enabled = false;
                txtApp_Ref_Desc.ReadOnly  = false ;
                
         
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "پیغام",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            Approvement_RefSearch();
        }

        private void bindingNavigatorReturnItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            bolFormLoad = false;
            Form_Load();
            Form_Load();
            bolFormLoad = true;
            txtApp_ref.ReadOnly = true;
            dgvApprovement_Reference.Rows[dgvApprovement_Reference.Rows.Count - 1].Selected = false;
            dgvApprovement_Reference.Rows[0].Selected = true;
            dgvApprovement_Reference.FirstDisplayedScrollingRowIndex = dgvApprovement_Reference.Rows[0].Index;
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

        #region txtApp_ref

        private void txtApp_ref_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }

        private void txtApp_ref_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (bolFormLoad && (bool) bindingNavigatorAddNewItem.Tag)
                {
                    if (txtApp_ref.Text.Trim() == string.Empty ||
                        txtApp_ref.Text == DBNull.Value.ToString())
                        return;
                    dgvApprovement_Reference.Rows[dgvApprovement_Reference.Rows.Count - 1].Cells[1].Value =
                        txtApp_ref.Text;
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

        #region txtApp_Ref_Desc

        private void txtApp_Ref_Desc_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }

        #endregion

        #endregion

        #region DataGrid events

        private void dgvApprovement_Reference_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (!clsERMSGeneral.CloseForm)
                {
                    if (bolFormLoad && (bool) bindingNavigatorAddNewItem.Tag)
                    {
                        if (dgvApprovement_Reference.SelectedRows[0].Index == dgvApprovement_Reference.Rows.Count - 1)
                        {
                            txtApp_ref.ReadOnly = false;
                        }
                        else
                        {
                            txtApp_ref.ReadOnly = true;
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