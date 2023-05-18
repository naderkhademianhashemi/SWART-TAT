using System;
using System.Data;
using System.Windows.Forms;
using ERMS.Model;

//
using ERMSLib;
using Presentation.Public;
using Presentation.Tabs.BasicInfo;
using Utilize.Helper;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.UI
{
    public partial class frmCurrencyPairDataEntry : Form, IPrintable
    {
        #region Variables
        DataTable dt;
        DataTable ds1;
        private int intStartIndex;
        private int intEndIndex;
        private int intgbxHeight;
        private int intdgvHeight;
        private bool bolFormLoad; //ها هنگام eventمتغير براي شناسايي اينكه فرم اولين بار لود شده يا خير چون اكثر 
        //لود فرم به اجبار فراخواني مي شوند 
        private bool bolIsEdit;
        #endregion

        #region Constructor
        public frmCurrencyPairDataEntry()
        {
            //_currencyPairDataEntry = new CurrencyPairDataEntry();
            //_currencyPair = new CurrencyPair();
            InitializeComponent();
            InitializeForm();
            clsERMSGeneral.InitializeTheme(this);
            bolFormLoad = false;
            dt = new DataTable();
            ds1 = new DataTable();
        }

        #endregion

        private void frmCurrencyPairDataEntry_Load(object sender, EventArgs e)
        {
            try
            {
                Form_Load();
                bindingToTxt();
                //txtCollateral_Type.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCurrencyPairDataEntry_KeyDown(object sender, KeyEventArgs e)
        {
            //Find
            if (e.Control && e.KeyCode.ToString() == "F")
            {
                Currency_PairSearch();

            }
        }

        private void initGrid(int intStartIndex, int intEndIndex)
        {
            dt = new DAL.SwartDataSetTableAdapters.GetDT_Currency_PairTableAdapter().GetData(intStartIndex, intEndIndex);
            Helper h = new Helper();
            if (dt.Rows.Count > 0)
            {
                DataColumn dcolDate = new DataColumn("DateF", typeof(String));
                dt.Columns.Add(dcolDate);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["DateF"] = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(dt.Rows[i]["Date"].ToString()).ToString("yyyy/MM/dd");
                }
                bindingSource1.DataSource = dt;
                bindingNavigator1.BindingSource = bindingSource1;
                dgvCurrency_Pair.DataSource = bindingSource1;
                dgvCurrency_Pair.Columns["Row"].HeaderText = "رديف";
                dgvCurrency_Pair.Columns["Id"].HeaderText = "شناسه";
                dgvCurrency_Pair.Columns["Currency_1"].HeaderText = "Currency_1";
                dgvCurrency_Pair.Columns["Currency_2"].HeaderText = "Currency_2";
                dgvCurrency_Pair.Columns["Currency_Pair_Value"].HeaderText = "نرخ برابري ارز";
                dgvCurrency_Pair.Columns["Currency_Description"].HeaderText = "ارز اول";
                dgvCurrency_Pair.Columns["DateF"].HeaderText = "تاريخ";
                dgvCurrency_Pair.Columns["Currency_1"].Visible = false;
                dgvCurrency_Pair.Columns["Id"].Visible = false;
                dgvCurrency_Pair.Columns["Date"].Visible = false;
                dgvCurrency_Pair.Columns["Currency_2"].Visible = false;


                h.FormatDataGridView(dgvCurrency_Pair);
                dgvCurrency_Pair.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvCurrency_Pair.ReadOnly = true;
                dgvCurrency_Pair.AllowUserToDeleteRows = true;
                dgvCurrency_Pair.Columns["Row"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //dgvCollateral_Type.Columns["Collateral_Type"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvCollateral_Type.Columns["Collateral_Type_Desc"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvCollateral_Type.Columns["Collat_Major_Type_Desc"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvApprovement_Reference.Columns[0].ReadOnly = true;
        }

        private void SetMaxLenght()
        {
            txtCurrency_Pair_Value.MaxLength = 18;
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
            //txtCollateral_Type.Text = string.Empty;
        }

        private void Form_Load()
        {

            SetMaxLenght();
            fill_cmbPages();
            Fill_cmbCurrency_1();
            bindingNavigatorAddNewItem.Tag = false;
            dgvCurrency_Pair.Enabled = true;
            controlBtn();
            intgbxHeight = groupBox1.Height;
            intdgvHeight = dgvCurrency_Pair.Height;
            for (int intRow = 1; intRow < dgvCurrency_Pair.Rows.Count; intRow++)
            {
                if (dgvCurrency_Pair.Rows[intRow].Selected)
                {
                    dgvCurrency_Pair.Rows[intRow].Selected = false;
                }
            }
            if (dgvCurrency_Pair.Rows.Count != 0)
            {
                dgvCurrency_Pair.Rows[0].Selected = true;

                bindingNavigatorBtn(true);
            }
            txtCurrency2.ReadOnly = true;
            txtCurrency_Pair_Value.ReadOnly = true;
            cmbCurrency_1.Enabled = false;
            fdpDate.Enabled = false;
            txtCurrency2.Text = "ريال ايران";
            bolFormLoad = true;
            bolIsEdit = false;

        }

        private void fill_cmbPages()
        {

            cmbPages.Items.Clear();
            var count = new DAL.Table_DataSetTableAdapters.Currency_PairTableAdapter().GetCount().Value;
            for (var i = 1; i < count; i = i + 100)
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

        private void bindingToTxt()
        {
            if (dgvCurrency_Pair.Rows.Count != 0)
            {
                txtId.DataBindings.Add(new Binding("Text", bindingSource1, "Id", true));
                txtCurrency_Pair_Value.DataBindings.Add(new Binding("Text", bindingSource1, "Currency_Pair_Value", true));
                cmbCurrency_1.DataBindings.Add(new Binding("Text", bindingSource1, "Currency_Description", true));
                fdpDate.DataBindings.Add(new Binding("Text", this.bindingSource1, "DateF", true));
            }
        }

        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvCurrency_Pair;
        }

        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "Currency_Pair";
        }

        private void Currency_PairSearch()
        {
            var dataTable = dgvCurrency_Pair.Grid2TableSearch();

            frmSearch frm = new frmSearch(dataTable) { TableName = "Currency_Pair" };

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
                                case "Currency_Description":
                                    str = frm.Search.Trim();
                                    break;

                                case "Currency_Pair_Value":
                                    str = frm.Field + "  " + frm.Operator + " " + frm.Search;
                                    break;

                                default: str = frm.Field + "  like '%" + frm.Search + "%' ";
                                    break;
                            }
                            //_currencyPairDataEntry.Currency_PairSearch(frm.Search, frm.Field, frm.Operator);
                            this.dt = new DAL.SwartDataSetTableAdapters.GetDT_Currency_PairSearchTableAdapter().GetData(str, frm.Field);
                            if (this.dt.Rows.Count > 0)
                            {
                                //PersianTools.Dates.PersianDate P;
                                DataColumn dcolDate = new DataColumn("DateF", typeof(String));
                                this.dt.Columns.Add(dcolDate);
                                for (int i = 0; i < this.dt.Rows.Count; i++)
                                {

                                    this.dt.Rows[i]["DateF"] =
                                        FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(this.dt.Rows[i]["Date"].ToString()).ToString(
                                            "yyyy/MM/dd");
                                }
                                bindingSource1.DataSource = this.dt;
                                bindingSource1.DataMember = this.dt.TableName;
                                bindingNavigator1.BindingSource = bindingSource1;
                                dgvCurrency_Pair.DataSource = bindingSource1;
                            }
                            if (dgvCurrency_Pair.RowCount == 0)
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

        private void controlBtn()
        {
            bindingNavigatorEditItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorSaveItem.Enabled = false;
            txtCurrency2.ReadOnly = false;
            txtCurrency_Pair_Value.ReadOnly = false;
            fdpDate.Readonly = false;
        }

        private void Fill_cmbCurrency_1()
        {
            ds1 = new DAL.Table_DataSetTableAdapters.CurrencyTableAdapter().GetDataBySellCurrency();
            cmbCurrency_1.DataSource = ds1;
            cmbCurrency_1.DisplayMember = "Currency_Description";
            cmbCurrency_1.ValueMember = "Currency";
            cmbCurrency_1.DroppedDown = false;
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

        private void cmbCurrency_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }

        private void cmbCurrency_1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (bolFormLoad)
                {

                    dgvCurrency_Pair.SelectedRows[0].Cells[6].Value =
                    cmbCurrency_1.Text;
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

        private void btnModel_Click(object sender, EventArgs e)
        {
            if (!spcAll.Panel2Collapsed)
            {
                spcAll.Panel2Collapsed = true;
                spcAll.Panel2.Hide();
                dgvCurrency_Pair.ScrollBars = ScrollBars.Vertical;
                groupBox1.Height = Height - 130;
                dgvCurrency_Pair.Height = groupBox1.Height - 20;
            }
            else
            {
                spcAll.Panel2Collapsed = false;
                spcAll.Panel2.Show();
                groupBox1.Height = intgbxHeight;
                dgvCurrency_Pair.Height = intdgvHeight;

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                bindingNavigatorAddNewItem.Tag = true;
                txtId.Text = string.Empty;
                txtCurrency_Pair_Value.Text = string.Empty;
                cmbCurrency_1.SelectedIndex = -1;
                fdpDate.Text = string.Empty;
                txtCurrency2.Text = "ريال ايران";
                dgvCurrency_Pair.Rows[dgvCurrency_Pair.RowCount - 1].Cells[0].Value =
                  dt.Rows.Count + 1;

                if (dgvCurrency_Pair.SelectedRows[0].Index ==
                    dgvCurrency_Pair.Rows.Count - 1)
                {
                    txtCurrency_Pair_Value.ReadOnly = false;
                    //txtCurrency2.ReadOnly = false;
                    fdpDate.Enabled = true;
                    cmbCurrency_1.Enabled = true;

                }
                dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Selected = true;
                dgvCurrency_Pair.Enabled = false;
                bindingNavigatorBtn(false);
                cmbCurrency_1.Focus();
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
                int Currency_1 = (cmbCurrency_1.SelectedIndex == -1) ? -1 : (int)cmbCurrency_1.SelectedValue;
                decimal Currency_Pair_Value = (txtCurrency_Pair_Value.Text == string.Empty) ? 0 : decimal.Parse(txtCurrency_Pair_Value.Text);

                // add for farsi date
                DateTime startDate;
                if (fdpDate.Text == string.Empty)
                {
                    startDate = DateTime.Today;
                }
                else
                {
                    //PersianTools.Dates.PersianDate p1;
                    //p1 = new PersianTools.Dates.PersianDate(int.Parse(fdpDate.Text.Substring(0, 4)), int.Parse(fdpDate.Text.Substring(5, 2)), int.Parse(fdpDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                    startDate = fdpDate.SelectedDateTime;
                    //DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));
                }
                //if (Vreify())
                //{
                if (!bolIsEdit)  //اگر كاربر ركورد جديد وارد كند
                {
                    txtId.Text = new DAL.General_DataSet().InsertCurrency_Pair(Currency_1, 0, Currency_Pair_Value
                                                         , startDate).ToString();
                    if (txtId.Text != "-1")
                    {
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[1].Value =
                                txtId.Text;
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[2].Value =
                                Currency_1;
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[3].Value =
                                "0";
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[4].Value =
                               Currency_Pair_Value;
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[5].Value =
                                startDate;
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[6].Value =
                                cmbCurrency_1.Text;
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[7].Value =
                            fdpDate.Text;
                        controlBtn();
                        bindingNavigatorAddNewItem.Tag = true;
                        Presentation.Public.Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ",
                                                  "پيغام", MessageBoxButtons.OK,
                                                  MessageBoxIcon.Exclamation);
                        bindingNavigatorBtn(true);
                    }
                    else
                    {
                        Presentation.Public.Routines.ShowMessageBoxFa("اطلاعات براي ارز انتخاب شده به ازاي تاريخ مورد نظر موجود است.", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bindingNavigatorAddNewItem.Tag = false;
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[1].Value = DBNull.Value;
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[2].Value = DBNull.Value;
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[3].Value = DBNull.Value;
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[4].Value = DBNull.Value;
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[5].Value = DBNull.Value;
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[6].Value = DBNull.Value;
                        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[7].Value = DBNull.Value;
                        cmbCurrency_1.SelectedIndex = -1;
                        txtCurrency_Pair_Value.Text = string.Empty;
                        fdpDate.Text = string.Empty;
                        txtId.Text = string.Empty;
                        bindingNavigatorBtn(false);
                        bindingNavigatorReturnItem.Enabled = true;
                        return;
                    }
                }
                else   //اگر كاربر ركوردي را ويرايش كند
                {
                    new DAL.Table_DataSetTableAdapters.Currency_PairTableAdapter().
                        UpdateById(Currency_1, 0, Currency_Pair_Value, startDate, int.Parse(txtId.Text));
                    Presentation.Public.Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ",
                                              "پيغام", MessageBoxButtons.OK,
                                              MessageBoxIcon.Exclamation);
                    bolFormLoad = false;
                    initGrid(intStartIndex, intEndIndex);
                    bindingNavigatorBtn(true);
                    dgvCurrency_Pair.Enabled = true;
                    bolFormLoad = true;
                    bolIsEdit = false;
                }

                dgvCurrency_Pair.Enabled = true;
                bindingNavigatorAddNewItem.Tag = false;
                txtCurrency2.ReadOnly = true;
                txtCurrency_Pair_Value.ReadOnly = true;
                cmbCurrency_1.Enabled = false;
                fdpDate.Enabled = false;
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
                        if (txtId.Text != string.Empty)
                        {
                            if (new DAL.Table_DataSetTableAdapters.Currency_PairTableAdapter().DeleteById(int.Parse(txtId.Text)) != -1)
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
                dgvCurrency_Pair.Enabled = false;
                txtCurrency2.ReadOnly = true;
                txtCurrency_Pair_Value.ReadOnly = false;
                cmbCurrency_1.Enabled = true;
                fdpDate.Enabled = true;
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
            if (dgvCurrency_Pair.Rows.Count != 0)
            {
                dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Selected = false;
                dgvCurrency_Pair.Rows[0].Selected = true;
                dgvCurrency_Pair.FirstDisplayedScrollingRowIndex = dgvCurrency_Pair.Rows[0].Index;
            }
            Cursor = Cursors.Default;
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            Currency_PairSearch();
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

        private void cmbCurrency_1_MouseLeave(object sender, EventArgs e)
        {
            //try
            //{
            //    if (bolFormLoad && (bool)bindingNavigatorAddNewItem.Tag)
            //    {
            //        if (cmbCurrency_1.SelectedIndex == -1)
            //            return;
            //        dgvCurrency_Pair.Rows[dgvCurrency_Pair.Rows.Count - 1].Cells[6].Value =
            //        (object)cmbCurrency_1.Text;
            //        if (!(bool)bindingNavigatorAddNewItem.Tag)
            //            bindingNavigatorAddNewItem.Enabled = false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "message",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtCurrency_Pair_Value_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }

        private void txtCurrency_Pair_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (bolFormLoad)
            {
                if ((e.KeyChar < (char)48 || e.KeyChar > (char)57) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46 && e.KeyChar != (char)32 && e.KeyChar != (char)59 && e.KeyChar != (char)45)
                {
                    e.Handled = true;
                }
            }
        }

        private void dgvCurrency_Pair_SelectionChanged(object sender, EventArgs e)
        {

        }








    }
}