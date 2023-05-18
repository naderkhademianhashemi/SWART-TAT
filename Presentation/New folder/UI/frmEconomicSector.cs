using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using ERMSLib;

using System.Drawing;
using ERMS.Model;
//
using Presentation.Public;
using Presentation.Tabs.BasicInfo;
using Utilize.Helper;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.UI
{
    public partial class frmEconomicSector : BaseForm ,IPrintable
    {
        #region Variables
        private int intStartIndex;
        private int intEndIndex;
        private DataTable ds = new DataTable();
        private bool bolFormLoad;
        private bool bolIsEdit;
        private int intEcoSecCode;
        private int intgbxHeight;
        
#endregion
        #region formEvent
        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvEconomicSector;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "EconomicSector";
        }  

        private void frmEconomicSector_Load(object sender, EventArgs e)
        {
            formLoad();
            bindingToTxt();
            TXTEcoSec.ReadOnly = true;
        }
        private void formLoad()
        {
            
            bindingNavigatorAddNewItem.Tag = false;
            dgvEconomicSector.Enabled = true;
            controlBtn();
            intgbxHeight = groupBox2.Height;
            rtxt.MaxLength = 50;
            TXTEcoSec.MaxLength = 4;
            fill_cmbPages();
           for(int intRow=1;intRow<dgvEconomicSector.Rows.Count;intRow++)
           {
                if (dgvEconomicSector.Rows[intRow].Selected)
                {
                    dgvEconomicSector.Rows[intRow].Selected = false;
                }
            }
            dgvEconomicSector.Rows[0].Selected = true;
            dgvEconomicSector.FirstDisplayedScrollingRowIndex = dgvEconomicSector.Rows[0].Index;
            dgvEconomicSector.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvEconomicSector.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvEconomicSector.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            bindingNavigatorBtn(true);
            rtxt.ReadOnly = true;
            TXTEcoSec.ReadOnly = true;
            bolIsEdit = false;
            bolFormLoad = true;
        }
        public frmEconomicSector()
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
            this.Text = "بخش اقتصادي";
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = false;
            this.groupBox1.Text = string.Empty;
            this.bindingNavigatorAddNewItem.ToolTipText = "جديد";
            //this.tlsBtnRemove.ToolTipText = "حذف";
            this.bindingNavigatorMoveFirstItem.ToolTipText = "بازگشت به اول";
            this.bindingNavigatorMoveLastItem.ToolTipText = "بازگشت به آخر";
            this.bindingNavigatorMoveNextItem.ToolTipText = "بعدي";
            this.bindingNavigatorMovePreviousItem.ToolTipText = "قبلي";
            //this.tlsBtnSave.ToolTipText = "ذخيره";
            //this.tlsBtnEdit.ToolTipText = "ويرايش";
            //this.tlsBtnSearch.ToolTipText = "جستجو";
            //this.tlsBtnRefresh.ToolTipText = "بازگشت به حالت اوليه";
            this.TXTEcoSec.Text = string.Empty;
        }
        #endregion
        #region cmbEvent
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
        private void controlBtn()
        {
            tlsBtnEdit.Enabled = true;
            tlsBtnRemove.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            tlsBtnSave.Enabled = false;
            TXTEcoSec.ReadOnly = false;
           // rtxt.ReadOnly = false;
        }
        private void fill_cmbPages()
        {
            var count = new DAL.Table_DataSetTableAdapters.Economic_SectorTableAdapter().GetCount().Value;
            cmbPages.Items.Clear();
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
        #endregion
        #region dgvEvent
        private void initGrid(int intStartIndex, int intEndIndex)
        {
            ds =  new DAL.General_DataSet().Get_EconomicSector(intStartIndex, intEndIndex);
            Helper h = new Helper();
            if (ds.Rows.Count > 0)
            {
                bindingSource1.DataSource = ds;
                bindingNavigator1.BindingSource = bindingSource1;
                dgvEconomicSector.DataSource = null;
                dgvEconomicSector.DataSource = bindingSource1;
                dgvEconomicSector.Columns["Row"].HeaderText = "سطر";
                dgvEconomicSector.Columns["Economic_Sector"].HeaderText = "شناسه بخش اقتصادي";
                dgvEconomicSector.Columns["Economic_Sector_Desc"].HeaderText = "شرح بخش اقتصادي";
                h.FormatDataGridView(dgvEconomicSector);
                dgvEconomicSector.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            }

            dgvEconomicSector.ReadOnly = true;
            dgvEconomicSector.AllowUserToDeleteRows = true;
        }
        private void dgvEconomicSector_SelectionChanged(object sender, EventArgs e)
        {
            if (!clsERMSGeneral.CloseForm)
            {
                if (bolFormLoad && (bool)bindingNavigatorAddNewItem.Tag)
                {

                    if (dgvEconomicSector.SelectedRows[0].Index == dgvEconomicSector.Rows.Count - 1)
                    {
                        TXTEcoSec.ReadOnly = false;
                        //  rtxt.ReadOnly = false;
                    }
                    else
                    {
                        TXTEcoSec.ReadOnly = true;
                        //  rtxt.ReadOnly = true;
                    }
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
                TXTEcoSec.Text = string.Empty;
                rtxt.Text = string.Empty;
                
                dgvEconomicSector.Rows[dgvEconomicSector.RowCount - 1].Cells[0].Value =
                  ds.Rows.Count + 1;

                if (dgvEconomicSector.SelectedRows[0].Index ==
                    dgvEconomicSector.Rows.Count - 1)
                {
                    TXTEcoSec.ReadOnly = false;
                    rtxt.ReadOnly = false;
                }
                dgvEconomicSector.Rows[dgvEconomicSector.Rows.Count - 1].Selected = true;
                dgvEconomicSector.Enabled = false;
                bindingNavigatorBtn(false);
                tlsBtnRefresh.Enabled = true;
                TXTEcoSec.Focus();
               
            }
            catch (Exception exp)
            {
                exp.ConfigLog(true);
            }
        }
        private void btnModel_Click(object sender, EventArgs e)
        {

        }
        private bool Vreify()
        {
            if (TXTEcoSec.Text==string.Empty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آيا مايل به ادامه عمليات ثبت هستيد ؟ ",
                                                "كد بخش اقتصادي  وارد نشده", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    
                    TXTEcoSec.Text = string.Empty;
                    rtxt.Text = string.Empty;
                    TXTEcoSec.ReadOnly = false;
                   // rtxt.ReadOnly = false;
                    TXTEcoSec.Focus();
                }
                else
                {
                    bolFormLoad = false;
                    formLoad();
                    bolFormLoad = true;
                }
                return false;
            }
            return true;
        }

        private void tlsBtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Vreify())
                {
                    if (!bolIsEdit)
                    {
                        if (addDataFromTxtToGrid())
                        {
                            if (new DAL.Table_DataSetTableAdapters.Economic_SectorTableAdapter().Insert(int.Parse(TXTEcoSec.Text),
                                rtxt.Text)!=-1)

                                dgvEconomicSector.Rows[dgvEconomicSector.Rows.Count - 1].Cells[1].Value =
                                    TXTEcoSec.Text;
                            dgvEconomicSector.Rows[dgvEconomicSector.Rows.Count - 1].Cells[2].Value =
                                   rtxt.Text;
                            controlBtn();

                            bindingNavigatorAddNewItem.Tag = true;
                            Presentation.Public.Routines.ShowMessageBoxFa("ثبت اطلاعات با موفقيت انجام شد ",
                                    "پيغام", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);


                            TXTEcoSec.ReadOnly = true;
                            bindingNavigatorAddNewItem.Tag = false;
                            bindingNavigatorBtn(true);
                        }
                        else
                        {
                            bindingNavigatorAddNewItem.Tag = false;
                            dgvEconomicSector.Rows[dgvEconomicSector.Rows.Count - 1].Cells[1].Value = DBNull.Value;
                            dgvEconomicSector.Rows[dgvEconomicSector.Rows.Count - 1].Cells[2].Value = DBNull.Value;
                            TXTEcoSec.Text = string.Empty;
                            rtxt.Text = string.Empty;
                            bindingNavigatorBtn(false);
                            tlsBtnRefresh.Enabled = true;
                            return;
                        }
                    }
                    else
                    {
                        if (new DAL.Table_DataSetTableAdapters.Economic_SectorTableAdapter().UpdateByEconomic_Sector(
                                   rtxt.Text,TXTEcoSec.Text.ToInt())!=-1)
                            Presentation.Public.Routines.ShowMessageBoxFa("ويرايش اطلاعات با موفقيت انجام شد ",
                                "پيغام", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                        bindingNavigatorBtn(true);
                        bolFormLoad = false;
                        initGrid(intStartIndex, intEndIndex);
                        dgvEconomicSector.Enabled = true;
                        bolFormLoad = true;
                        bolIsEdit = false;
                    }
                }
                else
                {
                    return;
                }
                dgvEconomicSector.Enabled = true;
                rtxt.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "پیغام",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //bolIsEdit = false;
            }
        }
        private void tlsBtnRemove_Click(object sender, EventArgs e)
        {
            if (bolFormLoad)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa(". كليه اطلاعات جداول وابسته به اين جدول حذف خواهد شد \n\t آيا مايل به حذف هستيد ؟",
                   "پيغام", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    this.Refresh();
                    if (TXTEcoSec.Text != string.Empty)
                    {
                        if (new DAL.Table_DataSetTableAdapters.Economic_SectorTableAdapter().DeleteById(int.Parse(TXTEcoSec.Text))!=-1)
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
            EconomicSectorSearch();
        }
        private void tlsBtnRefresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            bolFormLoad = false;
            formLoad();
            formLoad();
            bolFormLoad = true;
            dgvEconomicSector.Rows[dgvEconomicSector.Rows.Count - 1].Selected = false;
            Cursor = Cursors.Default;
        }
        private void tlsBtnEdit_Click(object sender, EventArgs e)
        {
            bolIsEdit = true;
            TXTEcoSec.ReadOnly = true;
            bindingNavigatorBtn(false);
            tlsBtnRefresh.Enabled = true;
            //tlsBtnEdit.Enabled = false;
            //tlsBtnRemove.Enabled = false;
            //tlsBtnSave.Enabled = true;
            //bindingNavigatorAddNewItem.Enabled = false;
            dgvEconomicSector.Enabled = false;
            rtxt.ReadOnly = false;
        }
        #endregion

        #region txtEvent
        private void TXTEcoSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (bolFormLoad)
            {
                if ((e.KeyChar < (char)48 || e.KeyChar > (char)57) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)32 && e.KeyChar != (char)59 && e.KeyChar != (char)45)
                {
                    e.Handled = true;
                }
            }
        }

        private void TXTEcoSec_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }

        private void rtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (bolFormLoad && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                SendKeys.SendWait("{tab}");
            }
        }
        private void bindingToTxt()
        {
            TXTEcoSec.DataBindings.Add(new Binding("Text",
                    bindingSource1, "Economic_Sector",true));
            rtxt.DataBindings.Add(new Binding("Text",
                bindingSource1, "Economic_Sector_Desc", true));
            TXTEcoSec.ReadOnly = false;
           // rtxt.ReadOnly = false;
        }
        private void TXTEcoSec_MouseLeave(object sender, EventArgs e)
        {
            if (bolFormLoad & dgvEconomicSector.RowCount > 0 &(bool)bindingNavigatorAddNewItem.Tag)
            {
                //bindingNavigatorAddNewItem.Enabled = false;
                if (TXTEcoSec.Text.Trim() == string.Empty ||
                    TXTEcoSec.Text == DBNull.Value.ToString())
                    return;
                dgvEconomicSector.Rows[dgvEconomicSector.Rows.Count - 1].Cells[1].Value =
                    TXTEcoSec.Text;
                
            }
        }

        private void rtxt_MouseLeave(object sender, EventArgs e)
        {
            if (bolFormLoad & dgvEconomicSector.RowCount > 0 & (bool)bindingNavigatorAddNewItem.Tag)
            {
                
                if (rtxt.Text.Trim() == string.Empty ||
                    rtxt.Text == DBNull.Value.ToString())
                    return;
                dgvEconomicSector.Rows[dgvEconomicSector.Rows.Count - 1].Cells[2].Value =
                    rtxt.Text;
                //Modify 87-04-09
                if(!(bool)bindingNavigatorAddNewItem.Tag)
                    bindingNavigatorAddNewItem.Enabled = false;

            }
        }


       
        #endregion
        private bool addDataFromTxtToGrid()
        {
            bool bolResult = true;
            intEcoSecCode = int.Parse(TXTEcoSec.Text);
            if (new DAL.Table_DataSetTableAdapters.Economic_SectorTableAdapter().GetData().Any(item=>item.Economic_Sector.Equals(intEcoSecCode)))
            {
                Presentation.Public.Routines.ShowMessageBoxFa("كد وارد شده تكراري مي باشد ",
                    "پيغام", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                TXTEcoSec.Focus();
                bolResult = false;
            }
            return bolResult;
        }
      
        private void EconomicSectorSearch()
        {
            var dt = dgvEconomicSector.Grid2TableSearch();

            frmSearch frm = new frmSearch(dt) {TableName = "Economic_Sector"};

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ProgressBox.Show();
                    if (frm.Field != string.Empty)
                    {
                        if (frm.Search != string.Empty)
                        {
                            ds = new DAL.General_DataSet().EconomicSectorSearch(frm.Search, frm.Field, frm.Operator);
                            bindingSource1.DataSource = ds;
                            //bindingSource1.DataMember = ds.Tables[0].TableName.ToString();
                            bindingNavigator1.BindingSource = bindingSource1;
                            dgvEconomicSector.DataSource = bindingSource1;
                            if (dgvEconomicSector.RowCount == 0)
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

        

       

       

       
      


       

    }
}