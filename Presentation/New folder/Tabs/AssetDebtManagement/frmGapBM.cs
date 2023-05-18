using System;
using System.Globalization;
using System.IO;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ERMSLib;

//
using Dundas.Charting.WinControl;
using PersianTools;
using Presentation.Public;
using MyDialogButton = Utilize.MyDialogButton;
using ProgressBox = Presentation.Public.ProgressBox;
using DAL;
using ERMS.Logic;
using ERMS.Model;
using Utilize.Helper;


namespace Presentation.Tabs.AssetDebtManagement
{

    public partial class frmGAPBM : BaseForm, IPrintable
    {
        #region VARS
        private FSM fsm;
        private TBM tbm;
        private CBM cbm;
        private GAPBM gapbm;
        private DBM dbm;
        private MBM mbm;
        private PD pd;
        private frmGapLimit fx;
        private TBOption tbOption;


        DataTable dtTBElements, dtGAPBM;

        private Hashtable htFSMs;
        private int curModelID = -1;
        private List<DataGridViewColumn> irrCols = new List<DataGridViewColumn>();

        DataColumn totalDColumn;
        DataRow summaryDRow1, summaryDRow2, summaryDRow2Limit, drGAPBM, summaryDRow2LimitUp, summaryDRow2LimitDown;
        DataGridViewColumn totalColumn;
        DataGridViewRow summaryRow1, summaryRow2;

        private decimal[] footerGap = new decimal[128];
        private decimal[] titleSum = new decimal[128];

        PersianTools.Dates.PersianDate P;
        string dateFarsi;

        bool TagFullMode = false;

        DataTable dtTableXml;
        LM lm;

        decimal CurrentReportID;

        public int FlagFullMode = 0;
        public DateTime StartDateFullMode;

        decimal GapUpLimit, GapdownLimit;
        bool falgLimit = false;
        int columnLimit = 0, colorFlag = 1;

        string limitDetails = string.Empty;
        int limitID = -1;
        ////////
        #endregion

        #region CONST
        private const int CTE_ValType_Principle = 0;
        private const int CTE_ValType_Interest = 1;
        private const int CTE_ValType_Both = 2;

        private const int CTE_NumSumNodes = 5;
        #endregion


        public frmGAPBM()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);

        }
        private void frmGAPBM_Load(object sender, EventArgs e)
        {
            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

            fdpStartDate.SelectedDateTime = DateTime.Now;
            //fdpStartDate.ResetSelectedDateTime();
            
            GeneralDataGridView = dgvGAPBM;
            Init();
            RebindPD();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            if (splitContainer4.Panel1Collapsed == false)
            {
                splitContainer4.Panel1Collapsed = true;
                btnModel.DefaultImage = Properties.Resources.S_Panleft1;
                btnModel.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (splitContainer4.Panel1Collapsed == true)
            {
                splitContainer4.Panel1Collapsed = false;
                btnModel.DefaultImage = Properties.Resources.S_PanRight1;
                btnModel.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }

        private void btnFSM_Click(object sender, EventArgs e)
        {
            frmFSM fx = new frmFSM() { FormBorderStyle = FormBorderStyle.Sizable };
            fx.Changed += new frmFSM.ChangedDelegate(fxFSM_Changed);
            fx.ShowDialog();
        }
        private void fxFSM_Changed()
        {
            RebindFSM();
        }

        private void btnTBM_Click(object sender, EventArgs e)
        {
            frmTBM fx = new frmTBM() { FormBorderStyle = FormBorderStyle.Sizable };
            fx.Changed += new frmTBM.ChangedDelegate(fxTBM_Changed);
            fx.ShowDialog();
        }
        private void fxTBM_Changed()
        {
            RebindTBM();
        }
        private void fxCBM_Changed()
        {
            RebindCBM();
        }

        //private void btnDBM_Click(object sender, EventArgs e)
        //{
        //    if ( cmbTBM.SelectedIndex == -1)
        //    {
        //        Presentation.Public.Routines.ShowMessageBoxFa("لطفاً مدل بسته زمانی را انتخاب كنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return;
        //    }
        //    frmDBM fx = new frmDBM() { FormBorderStyle = FormBorderStyle.Sizable };
        //    fx.TBModelID = (int)cmbTBM.SelectedValue;
        //   //fx.FSModelID = (int)cmbFSM.SelectedValue;
        //    fx.Changed += new frmDBM.ChangedDelegate(fxDBM_Changed);
        //    fx.ShowDialog();
        //}
        private void fxDBM_Changed()
        {
            RebindDBM();
        }

        private void btnMBM_Click(object sender, EventArgs e)
        {
            if (cmbFSM.SelectedIndex == -1 || cmbTBM.SelectedIndex == -1)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("لطفاً مدل تراز نامه و بسته زمانی را انتخاب كنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmMBM fx = new frmMBM() { FormBorderStyle = FormBorderStyle.Sizable };
            fx.TBModelID = (int)cmbTBM.SelectedValue;
            //fx.FSModelID = (int)cmbFSM.SelectedValue;
            fx.Changed += new frmMBM.ChangedDelegate(fxMBM_Changed);
            fx.ShowDialog();
        }
        private void fxMBM_Changed()
        {
            RebindMBM();
        }

        private void tsbModelNew_Click(object sender, EventArgs e)
        {
            CommandModelNew();
        }
        private void tsbModelEdit_Click(object sender, EventArgs e)
        {
            CommandModelEdit();
        }
        private void tsbModelRemove_Click(object sender, EventArgs e)
        {
            CommandModelRemove();
        }
        private void tsbModelSave_Click(object sender, EventArgs e)
        {
            if ((cmbFSM.SelectedIndex != -1) && (cmbTBM.SelectedIndex != -1) //&& (cmbCBM.SelectedIndex != -1) 
                        && (cmbDBM.SelectedIndex != -1) && (cmbPD.SelectedIndex != -1))
            {
                Save(curModelID, true);
            }
            else
            {
                Presentation.Public.Routines.ShowMessageBoxFa("مدل رفتاری تحلیل شکاف در یک مدل بسته زمانی،رفتار مشتری، رفتار بازار و مدل احتمال نکول اجرا می شود.مدلها را انتخاب کرده و دوباره اجرا کنید.", "مدل رفتاری تحلیل شکاف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void tsmiDetail_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBox.Show();
                DataGridViewCell cell = dgvGAPBM.CurrentCell;
                frmDetail fx = new frmDetail();
                fx.Parent = "GAPBM";
                if (cell != null && cell.RowIndex <= dgvGAPBM.Rows.Count - 1 - CTE_NumSumNodes && cell.ColumnIndex != 0 && cell.ColumnIndex != dgvGAPBM.Columns.Count - 1)
                {
                    int fsModelElementID = (int)dgvGAPBM.CurrentRow.Cells["FSME_ID"].Value;
                    string title = dgvGAPBM.CurrentRow.Cells["FSME_Title"].Value.ToString();
                    if (title != string.Empty)
                    {
                        Presentation.Public.Routines.ShowMessageBoxFa("عملیات درخواست شده تحت یك عنوان گروه حساب قابل انجام نیست", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    int tbElementSeq = ((TBMElementInfo)cell.OwningColumn.Tag).Sequence;
                    int tbModelID = ((TBMElementInfo)cell.OwningColumn.Tag).ModelID;

                    GAP gap = new GAP();
                    DateTime startDate;
                    // add for farsi date

                    if (FlagFullMode == 1)
                    {
                        startDate = fdpStartDate.SelectedDateTime; //StartDateFullMode;
                    }
                    else
                    {
                        //PersianTools.Dates.PersianDate p1;
                        //p1 = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                        startDate = fdpStartDate.SelectedDateTime; //DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));
                    }
                    //bool IsSeperate = chkDescreteGapAnalisys.Checked;

                    //int limitID = -1;
                    //string limitDetails = string.Empty;

                    //if (IsSeperate)
                    //{
                    //    limitID = cmbLimit.SelectedIndex;
                    //    limitDetails = cmbLimitValue.SelectedValue.ToString();
                    //}
                    //  fx.dtCount = gap.GetDetailCount(fsModelElementID, tbModelID, tbElementSeq, startDate, chkIrr.Checked, limitDetails, limitID, IsSeperate);
                    //fx.DetailDT = gap.GetGapDetail(fsModelElementID, tbModelID, tbElementSeq, dtpStartDate.Value, chkIrr.Checked, limitDetails, limitID, IsSeperate,1,100);
                    fx.fsModelElementID = fsModelElementID;
                    fx.tbModelID = tbModelID;
                    fx.tbElementSeq = tbElementSeq;
                    fx.limitDetails = limitDetails;
                    fx.limitID = limitID;
                    //fx.IsSeperate = IsSeperate;
                    //fx.dtpStartDateValue = dtpStartDate.Value;
                    fx.dtpStartDateValue = startDate;
                    fx.chkIrrValue = chkIrr.Checked;

                    ProgressBox.Hide();
                    fx.Show();
                }
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }
        private void tsmiReset_Click(object sender, EventArgs e)
        {
            /* cmbFSM.SelectedIndex = -1;
             cmbCBM.SelectedIndex = -1;
             cmbTBM.SelectedIndex = -1;
             cmbCurrency.SelectedIndex = cmbCurrency.Items.Count > 0 ? 0 : -1;
             cmbValType.SelectedIndex = cmbValType.Items.Count > 0 ? 0 : -1;

             chkColor.Checked = true;
             chkIrr.Checked = false;
             dtpStartDate.Value = DateTime.Now;

             // add for farsi date
             //PersianTools.Dates.PersianDate P;
             //P = new PersianTools.Dates.PersianDate((DateTime)DateTime.Now);
             fdpStartDate.SelectedDateTime = DateTime.Now;// P.FormatedDate("yyyy/MM/dd");
             //

             dgvGAPBM.Columns.Clear();*/
            this.Close();
        }

        private void lsvModel_DoubleClick(object sender, EventArgs e)
        {
            CommandModelEdit();
        }
        private void frmGAPBM_FormClosing(object sender, FormClosingEventArgs e)
        {
            TagFullMode = false;
        }
        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
            {
                if (lsvModel.SelectedItems.Count > 0)
                {
                    GAPBMInfo gi = (GAPBMInfo)lsvModel.SelectedItems[0].Tag;
                    cmbFSM.SelectedByDataValue(gi.FSModelID);
                    cmbTBM.SelectedByDataValue(gi.TBModelID);
                    //cmbCBM.SelectedByDataValue(gi.CBModelID);
                    cmbDBM.SelectedByDataValue(gi.DBModelID);
                    cmbMBM.SelectedByDataValue(gi.MBModelID);
                    cmbPD.SelectedByDataValue(gi.PDModelID);
                    if (gi.DBGModelID != -1)
                    {
                        rdbDBMLG.Checked = true;
                        cmbDBMG.SelectedByDataValue(gi.DBGModelID);
                        cmbPDG.SelectedIndex = -1;
                    }
                    else
                    {
                        rdbPDLG.Checked = true;
                        cmbPDG.SelectedByDataValue(gi.PDGModelID);
                        cmbDBMG.SelectedIndex = -1;
                    }
                    chkIrr.Checked = gi.IrrActive;


                    dateFarsi = fdpStartDate.Text;


                    curModelID = gi.ID;
                    return;
                }
            }

            dgvGAPBM.Columns.Clear();
        }
        private void chkIrr_CheckedChanged(object sender, EventArgs e)
        {
            ToggleIrr();
        }
        private void Collapse(int dIndex, int balance)
        {
            for (int i = dIndex + 1; i <= dtGAPBM.Rows.Count - CTE_NumSumNodes - 1; i++)
            {
                DataRow dr = dtGAPBM.Rows[i];
                if ((int)dr["FSME_Balance"] <= balance)
                    break;

                dr["Hidden"] = true;
            }
        }
        private void Expand(int dIndex, int balance)
        {
            for (int i = dIndex + 1; i <= dtGAPBM.Rows.Count - CTE_NumSumNodes - 1; i++)
            {
                DataRow dr = dtGAPBM.Rows[i];
                if ((int)dr["FSME_Balance"] <= balance)
                    break;

                dr["Hidden"] = false;
            }
        }
        private void dgvGAPBM_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 0 && e.RowIndex <= dgvGAPBM.Rows.Count - 1 - CTE_NumSumNodes)
            {
                DataGridViewRow dgvr = dgvGAPBM.Rows[e.RowIndex];

                int balance = (int)dgvr.Cells["FSME_Balance"].Value;
                int pointRight = 20 * balance;
                int pointLeft = 20 * (balance + 1);

                if (e.X > pointRight && e.X < pointLeft)
                {
                    int dIndex = dtGAPBM.Rows.IndexOf(((DataRowView)dgvGAPBM.Rows[e.RowIndex].DataBoundItem).Row);
                    if (dIndex < dtGAPBM.Rows.Count - 1 - CTE_NumSumNodes)
                    {
                        DataRow curDRow = dtGAPBM.Rows[dIndex];
                        DataRow nextDRow = dtGAPBM.Rows[dIndex + 1];

                        if ((bool)nextDRow["Hidden"] == false)
                        {
                            Collapse(dIndex, balance);
                        }
                        else
                        {
                            Expand(dIndex, balance);
                        }
                    }
                }
            }
        }



        private void dgvGAPBM_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0 || e.RowIndex > dgvGAPBM.Rows.Count - 1 - CTE_NumSumNodes)
            {
                e.Handled = false;
                return;
            }

            DataGridViewRow row = dgvGAPBM.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells["FSME_Balance"];

            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
                e.PaintBackground(e.ClipBounds, true);
            else
            {//chkColor.Checked ? Color.FromArgb((int)row.Cells["FSME_Color"].Value) : 
                Color color1 = Color.White;
                Color color2 = Color.FromArgb((int)row.Cells["FSME_Color"].Value);
                using (Brush bg = new System.Drawing.Drawing2D.LinearGradientBrush(e.CellBounds, color1, color2, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
                {
                    //e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
                    //Rectangle rect = new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
                    e.Graphics.FillRectangle(bg, e.CellBounds);
                }
            }

            e.Paint(e.CellBounds, DataGridViewPaintParts.Focus | DataGridViewPaintParts.Border);

            //////////////////////////////
            int balance = (int)cell.Value;
            int indent = balance * 20;

            string groupName = row.Cells["FSME_GroupName"].Value.ToString();
            string title = row.Cells["FSME_Title"].Value.ToString();
            string caption = groupName != string.Empty ? groupName : title;

            Image nodeImage;
            int dIndex = dtGAPBM.Rows.IndexOf(((DataRowView)row.DataBoundItem).Row);

            DataRow curDRow = dtGAPBM.Rows[dIndex];
            if (dIndex < dtGAPBM.Rows.Count - 1 - CTE_NumSumNodes)
            {
                DataRow nextDRow = dtGAPBM.Rows[dIndex + 1];

                string curULevel = curDRow["FSME_ULevel"].ToString();
                string nextULevel = nextDRow["FSME_ULevel"].ToString();
                bool nextIsHidden = (bool)nextDRow["Hidden"];

                if (nextULevel.StartsWith(curULevel))
                {
                    if (nextIsHidden)
                        nodeImage = global::Presentation.Properties.Resources.Plus;
                    else
                        nodeImage = global::Presentation.Properties.Resources.Minus;
                }
                else
                    nodeImage = global::Presentation.Properties.Resources.Lines;
            }
            else
                nodeImage = global::Presentation.Properties.Resources.Lines;


            e.Graphics.DrawString(caption.ToString(), e.CellStyle.Font, Brushes.DimGray, e.CellBounds.Location.X + indent + 20, e.CellBounds.Location.Y + 2);

            if (nodeImage != null)
            {
                System.Drawing.Drawing2D.GraphicsContainer container = e.Graphics.BeginContainer();
                e.Graphics.SetClip(e.ClipBounds);
                e.Graphics.DrawImageUnscaled(nodeImage, e.CellBounds.Location.X + indent, e.CellBounds.Location.Y);
                e.Graphics.EndContainer(container);
            }

            e.Handled = true;
        }
        private void dgvGAPBM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= dgvGAPBM.Rows.Count - CTE_NumSumNodes || e.ColumnIndex == dgvGAPBM.Columns.Count - 1)
            {
                e.CellStyle.ForeColor = Color.Green;
                e.CellStyle.BackColor = Color.Ivory;

                using (Font boldFont = new Font(dgvGAPBM.Font, FontStyle.Bold))
                {
                    e.CellStyle.Font = boldFont;
                }
            }
            if (e.RowIndex >= dgvGAPBM.Rows.Count - CTE_NumSumNodes && e.ColumnIndex == 0)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (e.RowIndex > -1 && e.RowIndex < dgvGAPBM.Rows.Count - CTE_NumSumNodes && e.ColumnIndex == 0)
            {
                Font boldFont = new Font(dgvGAPBM.Font, FontStyle.Bold);
                e.CellStyle.Font = boldFont;
            }
            if (falgLimit)
            {

                if (e.RowIndex == dgvGAPBM.RowCount - 3 && e.ColumnIndex == columnLimit)
                {
                    if (colorFlag == 1)
                        e.CellStyle.BackColor = Color.GreenYellow;
                    else
                        e.CellStyle.BackColor = Color.Red;
                }
            }
            //    dgvGAPBM.Rows[40].Cells[15].Style.BackColor = Color.Red;


        }

        private void Init()
        {
            fsm = new FSM();
            tbm = new TBM();
            cbm = new CBM();
            gapbm = new GAPBM();
            dbm = new DBM();
            mbm = new MBM();
            pd = new PD();
            //fx = new frmGapLimit();
            tbOption = new TBOption();
            tbOption.MaxBoxWidth = 325;

            RebindAll();

            cmbValType.AddItemsRange(new string[] { "مبالغ اصلی", "مبالغ سود", "هردو" });
            cmbValType.SelectedIndex = cmbValType.Items.Count > 0 ? 0 : -1;
            htFSMs = new Hashtable();

            Misc misc = new Misc();
            cmbCurrency.DataSource = misc.GetCurrencyDT();
            cmbCurrency.DisplayMember = Misc.CTE_Alias_CurrencyDescr;
            cmbCurrency.ValueMember = Misc.CTE_Alias_CurrencyID;
            cmbCurrency.SelectedIndex = cmbCurrency.Items.Count > 0 ? 0 : -1;
            cmbCurrency.SetDefaultCurrency("ریال ایران");

           // chkColor.Checked = true;
            chkIrr.Checked = false;
            dtpStartDate.Value = DateTime.Now;

            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd/MM/yyyy";

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;

            //GAPBM Grid
            dgvGAPBM.ReadOnly = true;
            dgvGAPBM.AllowUserToAddRows = false;
            dgvGAPBM.AllowUserToDeleteRows = false;
            dgvGAPBM.AllowUserToResizeRows = false;
            dgvGAPBM.AllowUserToResizeColumns = true;
            dgvGAPBM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dgvGAPBM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvGAPBM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dgvGAPBM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dgvGAPBM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvGAPBM.RowHeadersVisible = false;
            dgvGAPBM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            System.Windows.Forms.DataGridViewCellStyle style = new System.Windows.Forms.DataGridViewCellStyle();
            style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dgvGAPBM.RowsDefaultCellStyle = style;
            dgvGAPBM.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvGAPBM.EnableHeadersVisualStyles = false;

            cmbUnit.AddItemsRange(new string[] { "واحد", "هزار", "ميليون" });
            cmbUnit.SelectedIndex = 0;

            FillModel();
        }
        private void RebindAll()
        {
            RebindFSM();
            RebindTBM();
            RebindCBM();
            //RebindDBM();
            //RebindMBM();
            RebindPD();
            //RebindLimit();
            //RebindDBMLG();
            RebindPDLG();
        }
        private void RebindFSM()
        {
            cmbFSM.DataSource = fsm.GetFSMs();
            cmbFSM.DisplayMember = FSM.CTE_Alias_ModelName;
            cmbFSM.ValueMember = FSM.CTE_Alias_ID;
            cmbFSM.SelectedIndex = -1;
        }
        private void RebindTBM()
        {
            cmbTBM.DataSource = tbm.GetTBMs();
            cmbTBM.DisplayMember = TBM.CTE_Alias_ModelName;
            cmbTBM.ValueMember = TBM.CTE_Alias_ID;
            cmbTBM.SelectedIndex = -1;
        }
        private void RebindCBM()
        {
            //cmbCBM.DataSource = cbm.GetCBMs();
            //cmbCBM.DisplayMember = CBM.CTE_Alias_ModelName;
            //cmbCBM.ValueMember = CBM.CTE_Alias_ID;
            //cmbCBM.SelectedIndex = -1;
        }
        private void RebindDBM()
        {
            cmbDBM.DataSource = dbm.GetDBM("D");
            cmbDBM.DisplayMember = DBM.CTE_Alias_ModelName;
            cmbDBM.ValueMember = DBM.CTE_Alias_ID;
            cmbDBM.SelectedIndex = -1;
            lblBMDDate.Text = "تاریخ مدل: " + "---";
        }
        private void RebindPD()
        {
            cmbPD.DataSource = pd.GetPD("L");
            cmbPD.DisplayMember = "PD_Model";
            cmbPD.ValueMember = "ID";
            cmbPD.SelectedIndex = -1;
        }

        private void RebindPDLG()
        {
            cmbPDG.DataSource = pd.GetPD("G");
            cmbPDG.DisplayMember = "PD_Model";
            cmbPDG.ValueMember = "ID";
            cmbPDG.SelectedIndex = -1;
        }
        private void RebindDBMLG()
        {
            cmbDBMG.DataSource = dbm.GetDBM("G");
            cmbDBMG.DisplayMember = DBM.CTE_Alias_ModelName;
            cmbDBMG.ValueMember = DBM.CTE_Alias_ID;
            cmbDBMG.SelectedIndex = -1;
            lblBMGDate.Text = "تاریخ مدل: " + "---";
        }
        private void RebindMBM()
        {
            try
            {

                if (cmbTBM.SelectedValue != null || cmbFSM.SelectedValue != null)
                {
                    cmbMBM.DataSource = null;
                    DataTable dt = mbm.GetMBMs();
                    dt = dt.AsEnumerable().Where(s => s.Field<int>("TBModelID") == (int)cmbTBM.SelectedValue).Where(s => s.Field<int>("FSModelID") == (int)cmbFSM.SelectedValue).CopyToDataTable();
                    cmbMBM.DataSource = dt;
                    cmbMBM.DisplayMember = MBM.CTE_Alias_ModelName;
                    cmbMBM.ValueMember = MBM.CTE_Alias_ID;
                    cmbMBM.SelectedIndex = -1;
                }
            }            
            catch (Exception ex) { }

            
            if (cmbTBM.SelectedValue != null)
            {
                try
                {
                    cmbDBM.DataSource = null;
                    DataTable dt = dbm.GetDBM("D");
                    dt = dt.AsEnumerable().Where(s => s.Field<int>("TB_Model_ID") == (int)cmbTBM.SelectedValue).CopyToDataTable();
                    cmbDBM.DataSource = dt;
                    cmbDBM.DisplayMember = DBM.CTE_Alias_ModelName;
                    cmbDBM.ValueMember = DBM.CTE_Alias_ID;
                    cmbDBM.SelectedIndex = -1;
                    lblBMDDate.Text = "تاریخ مدل: " + "---";
                }
                catch (Exception ex) { lblBMDDate.Text = "تاریخ مدل: " + "---"; }

                try
                {
                    cmbDBMG.DataSource = null;
                    DataTable dt = dbm.GetDBM("G");
                    dt = dt.AsEnumerable().Where(s => s.Field<int>("TB_Model_ID") == (int)cmbTBM.SelectedValue).CopyToDataTable();
                    cmbDBMG.DataSource = dt;
                    cmbDBMG.DisplayMember = DBM.CTE_Alias_ModelName;
                    cmbDBMG.ValueMember = DBM.CTE_Alias_ID;
                    cmbDBMG.SelectedIndex = -1;
                    lblBMGDate.Text = "تاریخ مدل: " + "---";
                }
                catch (Exception ex) { lblBMGDate.Text = "تاریخ مدل: " + "---"; }
            }            
        }

      
        //private void RebindLimit()
        //{
        //    ReadXml();
        //    cmbLimit.DataSource = dtTableXml;
        //    cmbLimit.DisplayMember = "TableNameFarsi";
        //    cmbLimit.ValueMember = "TableNameEnglish";


        //}
        private void ReadXml()
        {
            string s = Assembly.GetExecutingAssembly().Location;
            s = s.Substring(0, s.LastIndexOf("\\")) + "\\" + "GapTableProperty.xml";
            DataSet dset = new DataSet();
            FileStream fstr = new FileStream(s, FileMode.Open, FileAccess.Read);
            dset.ReadXml(fstr);
            dtTableXml = dset.Tables[0];
        }
        private void CommandModelNew()
        {
            string descr = Presentation.Public.Routines.ShowInputBox();
            if (descr != string.Empty)
            {
                ListViewItem lvi = new ListViewItem();
                GAPBMInfo gi = new GAPBMInfo();
                lvi.Text = descr;
                lvi.Tag = gi;
                lsvModel.Items.Add(lvi);
                lvi.Selected = true;

                //                
                gi.ModelName = descr;
                gi.ID = gapbm.InsertGAPBM(gi);
                curModelID = gi.ID;
            }
        }
        private void CommandModelEdit()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvModel.SelectedItems[0];

                string descr = Presentation.Public.Routines.ShowInputBox(lvi.Text);
                if (descr != string.Empty)
                {
                    lvi.Text = descr;

                    //
                    GAPBMInfo gi = (GAPBMInfo)lvi.Tag;
                    gi.ModelName = descr;
                    gapbm.UpdateGAPBM(gi);
                }
            }
        }
        private void CommandModelRemove()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("این مدل انتخاب شده، حذف خواهد شد. آیا مطمئن هستید؟", "تایید", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem lvi = lsvModel.SelectedItems[0];
                    GAPBMInfo gi = (GAPBMInfo)lvi.Tag;

                    lvi.Remove();
                    gapbm.DeleteGAPBM(gi.ID);
                }
            }
        }

        private void Save(int modelID, bool bMessage)
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                int fsModelID = (cmbFSM.SelectedIndex == -1) ? -1 : (int)cmbFSM.SelectedValue;
                int tbModelID = (cmbTBM.SelectedIndex == -1) ? -1 : (int)cmbTBM.SelectedValue;
                //int cbModelID = (cmbCBM.SelectedIndex == -1) ? -1 : (int)cmbCBM.SelectedValue;
                int dbModelID = (cmbDBM.SelectedIndex == -1) ? -1 : (int)cmbDBM.SelectedValue;
                int mbModelID = (cmbMBM.SelectedIndex == -1) ? -1 : (int)cmbMBM.SelectedValue;
                int pdmodelID = (cmbPD.SelectedIndex == -1)  ? -1 : (int)cmbPD.SelectedValue;
                int dbgmodelID = (cmbDBMG.SelectedIndex == -1) ? -1 : (int)cmbDBMG.SelectedValue;
                int pdgmodelID = (cmbPDG.SelectedIndex == -1) ? -1 : (int)cmbPDG.SelectedValue;
                int viewModeID = (int)cmbValType.SelectedIndex + 1;

                bool bIrr = chkIrr.Checked;

                GAPBMInfo gi = (GAPBMInfo)lsvModel.SelectedItems[0].Tag;
                gi.TBModelID = tbModelID;
                //gi.CBModelID = cbModelID;
                gi.DBModelID = dbModelID;
                gi.MBModelID = mbModelID;
                gi.FSModelID = fsModelID;
                gi.StartDate = fdpStartDate.SelectedDateTime;//startDate;
                gi.IrrActive = bIrr;
                gi.PDModelID = pdmodelID;
                gi.DBGModelID = dbgmodelID;
                gi.PDGModelID = pdgmodelID;

                if (gi.ID != -1)
                    gapbm.UpdateGAPBM(gi);
                else
                    gi.ID = gapbm.InsertGAPBM(gi);

                if (bMessage)
                    Presentation.Public.Routines.ShowMessageBoxFa("مدل شما ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void FillModel()
        {
            DataTable dt = gapbm.GetGAPBMs();
            foreach (DataRow dr in dt.Rows)
            {
                GAPBMInfo gi = new GAPBMInfo();
                gapbm.CloneX(dr, gi, ECloneXdir.DR2Info);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = gi.ModelName;
                lvi.Tag = gi;

                lsvModel.Items.Add(lvi);
            }

        }
        private void ReLoad()
        {
            if ((cmbFSM.SelectedIndex == -1) || (cmbTBM.SelectedIndex == -1) // || (cmbCBM.SelectedIndex == -1) 
                    || (cmbDBM.SelectedIndex == -1) )
            {
                Presentation.Public.Routines.ShowMessageBoxFa("مدل رفتاری تحلیل شکاف در یک مدل بسته زمانی،رفتار مشتری و رفتار بازاراجرا می شود.مدلها را انتخاب کرده و دوباره اجرا کنید", "تحلیل شکاف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }   


            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            FillGapBM();
            RefreshChart();
            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }
        public void Reload(int gapbModelID, int tbModelID, int currencyID, int unitIndex, int fsModelId, //int cbModelID, 
                            int dbModelID, int mbModelID, int viewModeID, int unitID, bool bAutoSize, DateTime startDate, int pdModelID)
        {
           //  DateTime startDate = dtpStartDate.Value;

            bool bIrr = chkIrr.Checked;

            //int limitID = cmbLimit.SelectedIndex;
            //string limitDetails = cmbLimitValue.SelectedValue.ToString();        
            //bool IsSeperate = chkDescreteGapAnalisys.Checked;


            int dblgModelID = (cmbDBMG.SelectedIndex != -1) ? (int)cmbDBMG.SelectedValue : -1;
            int pdlgModelID = (cmbPDG.SelectedIndex != -1) ? (int)cmbPDG.SelectedValue : -1;

            dtTBElements = tbm.GetTBMelements(tbModelID);
            //dtGAPBM = gapbm.GetGAPBMT(gapbModelID, fsModelId, tbModelID, //cbModelID, 
                            //startDate, bIrr, viewModeID, currencyID, dbModelID, pdModelID, dblgModelID, pdlgModelID);
            //dtGAPBM = new GAP().GetGAP(42, fsModelId, tbModelID, cbModelID, fdpStartDate.SelectedDateTime /*startDate*/, bIrr, viewModeID, currencyID, limitDetails, limitID, true);
            dtGAPBM = gapbm.GetGAPBMT(gapbModelID, fsModelId, tbModelID, //cbModelID, 
                                        startDate, bIrr, viewModeID, currencyID, dbModelID, pdModelID, mbModelID, dblgModelID, pdlgModelID, 
                                            cmbCurrencyValue.SelectedIndex);
            dtGAPBM.DefaultView.RowFilter = "(Hidden = 0)";

            //
            summaryDRow1 = dtGAPBM.NewRow();
            dtGAPBM.Rows.Add(summaryDRow1);

            summaryDRow2 = dtGAPBM.NewRow();
            dtGAPBM.Rows.Add(summaryDRow2);

            summaryDRow2Limit = dtGAPBM.NewRow();
            dtGAPBM.Rows.Add(summaryDRow2Limit);

            summaryDRow2LimitUp = dtGAPBM.NewRow();
            dtGAPBM.Rows.Add(summaryDRow2LimitUp);

            summaryDRow2LimitDown = dtGAPBM.NewRow();
            dtGAPBM.Rows.Add(summaryDRow2LimitDown);


            PrepareSummary();
            //

            dgvGAPBM.DataSource = dtGAPBM;
            FormatGrid(dtTBElements, bAutoSize);

            dtGAPBM.AcceptChanges();

            if (cmbUnit.SelectedIndex != 0)
                NumberScale(unitID);
        }

        private void FillGapBM()
        {
            try
            {
                ProgressBox.Show();

                dgvGAPBM.Columns.Clear();

                int gapbModelID = ((GAPBMInfo)lsvModel.SelectedItems[0].Tag).ID;
                int fsModelID = (int)cmbFSM.SelectedValue;
                int tbModelID = (int)cmbTBM.SelectedValue;
                //int cbModelID = (int)cmbCBM.SelectedValue;
                int dbModelID = (int)cmbDBM.SelectedValue;
                int mbModelID = (int)cmbMBM.SelectedValue;
                int currencyID = (int)cmbCurrency.SelectedValue;
                int viewModeID = (int)cmbValType.SelectedIndex + 1;
                int pdModelID = (int)cmbPD.SelectedValue;
                int dblgModelID = (cmbDBMG.SelectedIndex != -1) ? (int)cmbDBMG.SelectedValue : -1;
                int pdlgModelID = (cmbPDG.SelectedIndex != -1) ? (int)cmbPDG.SelectedValue : -1;
                int MarketCurrencyValueID = (cmbCurrencyValue.SelectedIndex != -1) ? (int)cmbCurrencyValue.SelectedIndex : -1;
                bool bIrr = chkIrr.Checked;
                //PersianTools.Dates.PersianDate p1;
                //p1 = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                //DateTime startDate = DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));
                //	DateTime startDate = dtpStartDate.Value;



                //bool IsSeperate = chkDescreteGapAnalisys.Checked;

                //limitID = -1;

                //limitID = cmbLimit.SelectedIndex;
                //if (cmbLimit.SelectedIndex == 2 && chkAll.Checked == false)
                //    limitID = 0; // شعب

                //if (chkDescreteGapAnalisys.Checked && cmbLimit.SelectedIndex == 2 && chkAll.Checked == true && cmbLimitValue.SelectedIndex != -1)
                //    limitDetails = " State = " + cmbLimitValue.SelectedValue.ToString(); // کل شعب استان

                //if (chkDescreteGapAnalisys.Checked && cmbLimit.SelectedIndex == 2 && limitDetails == string.Empty && chkAll.Checked == false)
                //{ limitDetails = " State = " + cmbLimitValue.SelectedValue.ToString(); limitID = 2; } // کل شعب استان


                //if (IsSeperate && cmbLimit.SelectedIndex != 2 && chkAll.Checked == false)
                //{
                //    //if(cmbLimitValue.SelectedValue==null)
                //    //{
                //    //    cmbLimit.SelectedIndex = 0;
                //    //}
                //    limitDetails = " State = " + cmbLimitValue.SelectedValue.ToString();
                //}


                dtTBElements = tbm.GetTBMelements(tbModelID);
                var temp = new DAL.Table_DataSetTableAdapters.GAPB_ModelTableAdapter().GetDataByByGAPB_Model_Id(gapbModelID).FirstOrDefault();

                if (temp != null)


                    if (temp.IsGAPB_FS_Model_IdNull() || temp.IsGAPB_TB_Model_IdNull() || temp.IsGAPB_DB_Model_IdNull() || temp.IsGAPB_MB_Model_IdNull())
                    {

                        Presentation.Public.Routines.ShowMessageBoxFa("لطفاً ابتدا مدل را ذخیره کنید", "مدل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (currencyID == 20 && cmbCurrencyValue.SelectedIndex == -1)
                    {

                        Presentation.Public.Routines.ShowMessageBoxFa("لطفاً نرخ ارز را انتخاب کنید", "مدل",
                                                                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    else
                    {
                        dtGAPBM = gapbm.GetGAPBMT(gapbModelID, fsModelID, tbModelID, //cbModelID, 
                                                    fdpStartDate.SelectedDateTime , bIrr, viewModeID, currencyID,
                                                        dbModelID, pdModelID, mbModelID, dblgModelID, pdlgModelID, cmbCurrencyValue.SelectedIndex);
                        
                        dtGAPBM.DefaultView.RowFilter = "(Hidden = 0)";

                        //
                        summaryDRow1 = dtGAPBM.NewRow();
                        dtGAPBM.Rows.Add(summaryDRow1);

                        summaryDRow2 = dtGAPBM.NewRow();
                        dtGAPBM.Rows.Add(summaryDRow2);

                        summaryDRow2Limit = dtGAPBM.NewRow();
                        dtGAPBM.Rows.Add(summaryDRow2Limit);

                        summaryDRow2LimitUp = dtGAPBM.NewRow();
                        dtGAPBM.Rows.Add(summaryDRow2LimitUp);

                        summaryDRow2LimitDown = dtGAPBM.NewRow();
                        dtGAPBM.Rows.Add(summaryDRow2LimitDown);
                        PrepareSummary();
                        //
                        // GetLimit();
                        dtGAPBM.AcceptChanges();
                        dgvGAPBM.DataSource = dtGAPBM;
                        FormatGrid(dtTBElements, chkAutoSize.Checked); ;

                        dtGAPBM.AcceptChanges();

                        if (cmbUnit.SelectedIndex != 0)
                            NumberScale(cmbUnit.SelectedIndex);

                    }
            }








            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowErrorMessageFa("اخطار", "دستور اجرایی با خطا روبرو شده است.", ex.Message,
                                                    Presentation.Public.MyDialogButton.OK);
            }
            finally
            {
                ProgressBox.Hide();
            }

        }

 
        private void FormatGrid(DataTable dtTBElements, bool bAutoSize)
        {
            irrCols.Clear();

            int maxColumnWidth = GetColumnMaxWidthProportional(dtTBElements);
            foreach (DataRow dr in dtTBElements.Rows) //Time Bucket Columns
            {
                TBMElementInfo tei = new TBMElementInfo();
                tbm.CloneX(dr, tei, ECloneXdir.DR2Info);

                DataGridViewColumn col = dgvGAPBM.Columns["TB" + tei.ID];
                if (col != null)
                {
                    if (tei.BucketType == "Irr")
                        irrCols.Add(col);

                    if (tei.BucketType == "Irr" && !chkIrr.Checked)
                        col.Visible = false;

                    col.HeaderText = tei.BucketName;
                    col.Tag = tei;
                    if (!bAutoSize)
                        col.Width = GetColumnWidthProportional(tei, maxColumnWidth);
                    else
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    col.DefaultCellStyle.Format = "###,###.##";

                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    //if (chkColor.Checked)
                    //    col.HeaderCell.Style.BackColor = Color.FromArgb(tei.BucketColor);
                }
            }

            foreach (DataGridViewColumn dgvc in dgvGAPBM.Columns)
            {
                if (dgvc.Tag is TBMElementInfo)
                {
                }
                else
                    if (dgvc.DataPropertyName == "FSME_GroupName")
                    {
                        dgvc.Frozen = true;
                        dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgvc.MinimumWidth = 200;
                        dgvc.HeaderText = "";
                    }

                    else
                        if (dgvc.DataPropertyName == "Total")
                        {
                            dgvc.DefaultCellStyle.Format = "###,###.##";
                            dgvc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgvc.DefaultCellStyle.BackColor = Color.Ivory;
                            dgvc.DefaultCellStyle.ForeColor = Color.Green;
                            dgvc.MinimumWidth = 100;
                        }
                        else
                            dgvc.Visible = false;
            }

            dgvGAPBM.ColumnHeadersHeight = 40;
        }
        private int GetColumnMaxWidthProportional(DataTable dtTBM)
        {
            int maxWidth = 0;
            foreach (DataRow dr in dtTBM.Rows)
            {
                TBMElementInfo tei = new TBMElementInfo();
                tbm.CloneX(dr, tei, ECloneXdir.DR2Info);

                int len = tei.BucketLength;
                int w = tbOption.GetBucketWidth(tei.BucketType);

                maxWidth = (w * len > maxWidth) ? w * len : maxWidth;
            }

            return maxWidth;
        }
        private int GetColumnWidthProportional(TBMElementInfo tei, int maxWidthValue)
        {
            int len = tei.BucketLength;
            int w = tbOption.GetBucketWidth(tei.BucketType);
            return Convert.ToInt32(
                    (tbOption.MaxBoxWidth - tbOption.MinBoxWidth)
                                * (w * len * 1.0 - 1.0)
                                / (maxWidthValue - 1.01) + tbOption.MinBoxWidth);
        }
        private void @PrepareSummary()
        {
            totalDColumn = dtGAPBM.Columns["Total"];
            int numColumns = dtGAPBM.Columns.Count;

            for (int r = 0; r <= dtGAPBM.Rows.Count - 1; r++)
                //for (int r = 0; r <= dtGAPBM.Rows.Count - 3; r++)
                dtGAPBM.Rows[r][totalDColumn] = 0;

            for (int iCol = 1; iCol < numColumns - 1; iCol++)
            {
                if (dtGAPBM.Columns[iCol].ColumnName.StartsWith("TB"))
                {
                    string columnName = dtGAPBM.Columns[iCol].ColumnName;
                    DataGridViewColumn dgvc = dgvGAPBM.Columns[columnName];
                    bool bIrr = false;
                    foreach (DataGridViewColumn col in irrCols)
                        if (col.DataPropertyName == columnName)
                            bIrr = true;

                    summaryDRow1[iCol] = 0;
                    summaryDRow2[iCol] = 0;
                    summaryDRow2Limit[iCol] = 0;
                    summaryDRow2LimitUp[iCol] = 0;
                    summaryDRow2LimitDown[iCol] = 0;

                    for (int iRow = 0; iRow <= dtGAPBM.Rows.Count - 1 - CTE_NumSumNodes; iRow++)
                    {
                        int AL = (int)dtGAPBM.Rows[iRow]["FSME_AL"];
                        if (AL != -1)
                        {
                            if (AL == (int)EAL.Asset)
                                summaryDRow1[iCol] = (decimal)summaryDRow1[iCol] + (+1) * (decimal)dtGAPBM.Rows[iRow][iCol];
                            if (AL == (int)EAL.Liability)
                                summaryDRow1[iCol] = (decimal)summaryDRow1[iCol] + (-1) * (decimal)dtGAPBM.Rows[iRow][iCol];
                        }

                        if (dtGAPBM.Rows[iRow].IsNull(totalDColumn))
                            dtGAPBM.Rows[iRow][totalDColumn] = 0;

                        if ((bIrr && chkIrr.Checked) || !bIrr)
                            dtGAPBM.Rows[iRow][totalDColumn] = (decimal)dtGAPBM.Rows[iRow][totalDColumn] + (decimal)dtGAPBM.Rows[iRow][iCol];
                    }

                    summaryDRow2[iCol] = (decimal)summaryDRow1[iCol] + ((iCol == 13) ? 0 : (decimal)summaryDRow2[iCol - 1]);

                }
            }
            for (int iCol = 1; iCol < numColumns - 1; iCol++)
            {
                if (dtGAPBM.Columns[iCol].ColumnName.StartsWith("TB"))
                {
                    if ((decimal)dtGAPBM.Rows[0]["Total"] != 0)
                        summaryDRow2Limit[iCol] = ((decimal)summaryDRow2[iCol] / (decimal)dtGAPBM.Rows[0]["Total"]) * 100;
                }
            }

            summaryDRow1["Hidden"] = 0;
            summaryDRow2["Hidden"] = 0;
            summaryDRow2Limit["Hidden"] = 1;
            summaryDRow2LimitUp["Hidden"] = 1;
            summaryDRow2LimitDown["Hidden"] = 1;

            summaryDRow1["FSME_GroupName"] = " شکاف:";
            summaryDRow2["FSME_GroupName"] = "شکاف تجمعی :";
            summaryDRow2Limit["FSME_GroupName"] = "نسبت به دارایی:";

            summaryDRow2LimitUp["FSME_GroupName"] = "حد مثبت:";
            summaryDRow2LimitDown["FSME_GroupName"] = "حد منفی:";
        }

        private void ToggleIrr()
        {
            foreach (DataGridViewColumn col in irrCols)
            {
                if (chkIrr.Checked)
                    col.Visible = true;
                else
                    col.Visible = false;
            }
        }
        public void DoPrint()
        {
            if (frmDetail.Detailprint)
            {
                frmDetail.DoPrint();
            }
            else
            {
                DataGridView dgv = new DataGridView();

                if (dgvGAPBM.DataSource != null)
                {
                    foreach (DataGridViewColumn c1 in dgvGAPBM.Columns)
                    {
                        DataGridViewColumn c2 = (DataGridViewColumn)c1.Clone();
                        dgv.Columns.Add(c2);
                    }

                    int i = 0;
                    foreach (DataGridViewRow dgvr in dgvGAPBM.Rows)
                    {
                        DataGridViewRow r = (DataGridViewRow)dgvr.Clone();
                        i = 0;
                        foreach (DataGridViewCell cell in dgvr.Cells)
                        {

                            r.Cells[i].Value = cell.Value;
                            i++;
                        }
                        dgv.Rows.Add(r);
                    }



                    string str;
                    for (int k = 0; k < dgv.Rows.Count - 1; ++k)
                    {
                        str = dgv.Rows[k].Cells["FSME_Title"].Value.ToString();
                        dgv.Rows[k].Cells["FSME_Title"].Value = dgv.Rows[k].Cells["FSME_GroupName"].Value;
                        dgv.Rows[k].Cells["FSME_GroupName"].Value = str;
                    }
                    dgv.Columns["FSME_Title"].Visible = true;
                    dgv.Columns["FSME_GroupName"].HeaderText = "عنوان";
                    dgv.Columns["FSME_Title"].HeaderText = "نام گروه";

                    clsERMSGeneral.dgvActive = dgv;
                }
            }
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "GapBM";
        }
        private void NumberScale(int unit)
        {
            int scale = 1;
            switch (unit)
            {
                case 0:
                    scale = 1;
                    break;
                case 1:
                    scale = 1000;
                    break;
                case 2:
                    scale = 1000000;
                    break;
            }

            //Restore DataTable
            dtGAPBM.RejectChanges();

            foreach (DataGridViewRow row in dgvGAPBM.Rows)
            {
                foreach (DataGridViewColumn col in dgvGAPBM.Columns)
                    if (col.Index != 0 && col.Visible)
                        try
                        {
                            row.Cells[col.Name].Value = (decimal)row.Cells[col.Name].Value / scale;
                        }
                        catch
                        {
                        }
            }
        }
        private void Btn_GAPBM_FullScr_Click(object sender, EventArgs e)
        {
            // int limitID = cmbLimit.SelectedIndex;
            //string limitDetails = cmbLimitValue.SelectedValue.ToString();

            if (curModelID == -1)
                return;

            if (cmbFSM.SelectedIndex == -1 //|| cmbCBM.SelectedIndex == -1 
                        || cmbTBM.SelectedIndex == -1 || cmbDBM.SelectedIndex == -1 || cmbMBM.SelectedIndex == -1)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("تحلیل شکاف در یك مدل بسته زمانی و مدل اقلام بدون سررسید اجرا می شود. مدلهای مناسب را انتخاب كرده و دوباره اجرا كنید", "تحليل شکاف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int gapbModelID = (int)curModelID;
                int tbModelID = (int)cmbTBM.SelectedValue;
                int currencyID = (int)cmbCurrency.SelectedValue;
                int unitIndex = cmbUnit.SelectedIndex;
                int fsModelID = (int)cmbFSM.SelectedValue;
                int cbModelID = (int)cmbCBM.SelectedValue;
                int dbModelID = (int)cmbDBM.SelectedValue;
                int mbModelID = (int)cmbMBM.SelectedValue;
                int viewModeID = (int)cmbValType.SelectedIndex + 1;
                int pdModelID = (int)cmbPD.SelectedValue;

                //PersianTools.Dates.PersianDate p1;
                //p1 = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                //DateTime startDate = DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));


                int unitID = (int)cmbUnit.SelectedIndex;
                bool bAutoSize = (bool)chkAutoSize.Checked;
                bool bIrr = (bool)chkIrr.Checked;
               // bool bDescreteGapAnalisys = (bool)chkDescreteGapAnalisys.Checked;
                ///
                //int limitIndex = cmbLimit.SelectedIndex ;
                //string limitValue;
                //if (cmbLimitValue.SelectedValue == null)
                //     limitValue = "";
                //else
                //     limitValue = cmbLimitValue.SelectedValue.ToString();
                ///
                int limitIndex = -1;
                string limitValue = string.Empty;

                //if (bDescreteGapAnalisys)
                //{
                //    limitIndex = cmbLimit.SelectedIndex;
                //    limitValue = cmbLimitValue.SelectedValue.ToString();
                //}
                ////
                frmGAPBM fx = new frmGAPBM();
                fx.WindowState = FormWindowState.Maximized;

                fx.Init();

                fx.FlagFullMode = 1;
                fx.StartDateFullMode = fdpStartDate.SelectedDateTime;// startDate;

                drGAPBM = gapbm.GetGAPBM(gapbModelID);
                if (drGAPBM["FSModelID"].ToString() == "-1" || drGAPBM["TBModelID"].ToString() == "-1" || drGAPBM["CBModelID"].ToString() == "-1" || drGAPBM["DBModelID"].ToString() == "-1" || drGAPBM["MBModelID"].ToString() == "-1")
                { Presentation.Public.Routines.ShowMessageBoxFa("لطفا ابتدا مدل شكاف خود را ذخیره كنيد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                    fx.SetFullMode();

                    fx.Reload(gapbModelID, tbModelID, currencyID, unitIndex, fsModelID, //cbModelID, 
                                dbModelID, mbModelID, viewModeID, unitID, bAutoSize, fdpStartDate.SelectedDateTime /*startDate*/, pdModelID);

                    fx.RefreshChart(curModelID, bIrr);
                    fx.ShowDialog();
                    System.Windows.Forms.Cursor.Current = Cursors.Default;
                }
            }
        }
        public void SetFullMode()
        {
            //spcAll.Panel1Collapsed = true;
            //spc4All.Panel1Collapsed = true;
            //tabControl1.Dock = DockStyle.Fill;
            TagFullMode = true;

        }
        private void frmGAPBM_KeyDown(object sender, KeyEventArgs e)
        {
            //New
            if (e.Control && e.KeyCode.ToString() == "N")
            {
                CommandModelNew();
            }
            //Edit
            if (e.Control && e.KeyCode.ToString() == "E")
            {
                CommandModelEdit();
            }
            //save
            if (e.Control && e.KeyCode.ToString() == "S")
            {
                Save(curModelID, true);
            }
            //Remove
            if (e.Control && e.KeyCode.ToString() == "D")
            {
                CommandModelRemove();
            }
            //MoveUp
            if (e.KeyCode == Keys.F5)
            {
                if (lsvModel.SelectedItems.Count == 0)
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("ابتدا مدل را ايجاد كنيد", "مدل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                ReLoad();
            }
        }
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            lsvModel.Clear();

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader { Width = lsvModel.Width - 5 };
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;
            FillModel();
        }

        private void tsmiPrint_Click(object sender, EventArgs e)
        {

        }

        private void tsmiExport_Click(object sender, EventArgs e)
        {

        }
        private void RefreshChart()
        {
            ddChart.Series.Clear();
            ddChart.Series.Add("Series1");
            ddChart.Series.Add("Series2");
            ddChart.Series.Add("Series3");


            ddChart.Series["Series1"].Type = SeriesChartType.StackedColumn;
            ddChart.Series["Series2"].Type = SeriesChartType.StackedColumn;
            ddChart.Series["Series3"].Type = SeriesChartType.StackedColumn;


            ddChart.Series["Series1"].ValueMemberX = "X";
            ddChart.Series["Series1"].ValueMembersY = "Y1";
            ddChart.Series["Series1"].XValueType = ChartValueTypes.Int;
            ddChart.Series["Series1"].YValuesPerPoint = 1;
            ddChart.Series["Series1"].ShowInLegend = false;
            ddChart.Series["Series1"].LegendText = "دارایی";

            ddChart.Series["Series2"].ValueMemberX = "X";
            ddChart.Series["Series2"].ValueMembersY = "Y2";
            ddChart.Series["Series2"].XValueType = ChartValueTypes.Int;
            ddChart.Series["Series2"].YValuesPerPoint = 1;
            ddChart.Series["Series2"].ShowInLegend = false;
            ddChart.Series["Series2"].LegendText = "شكاف";

            ddChart.Series["Series3"].ValueMemberX = "X";
            ddChart.Series["Series3"].ValueMembersY = "Y3";
            ddChart.Series["Series3"].XValueType = ChartValueTypes.Int;
            ddChart.Series["Series3"].YValuesPerPoint = 1;
            ddChart.Series["Series3"].ShowInLegend = false;
            ddChart.Series["Series3"].LegendText = "بدهی";

            ddChart.DataSource = gapbm.GetGAPBMSummary(curModelID, chkIrr.Checked);
            ddChart.DataBind();

            ddChart.Series["Series1"].XValueIndexed = true;
            ddChart.Series["Series2"].XValueIndexed = true;
            ddChart.Series["Series3"].XValueIndexed = true;

            ddChart.Series["Series1"]["DrawingStyle"] = "Cylinder";
            ddChart.Series["Series2"]["DrawingStyle"] = "Cylinder";
            ddChart.Series["Series3"]["DrawingStyle"] = "Cylinder";

            ddChart.ChartAreas["Default"].Area3DStyle.Enable3D = true;
            ddChart.ChartAreas["Default"].Area3DStyle.Light = LightStyle.Realistic;
            ddChart.ChartAreas["Default"].Area3DStyle.Perspective = 30;
            ddChart.ChartAreas["Default"].Area3DStyle.XAngle = 10;
            ddChart.ChartAreas["Default"].Area3DStyle.YAngle = 5;
            ddChart.ChartAreas["Default"].Area3DStyle.PointDepth = 200;
            ddChart.ChartAreas["Default"].Area3DStyle.PointGapDepth = 0;
            ddChart.ChartAreas["Default"].Area3DStyle.RightAngleAxes = true;

            ddChart.ChartAreas["Default"].BackColor = Color.White;

            ddChart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            ddChart.BackColor = Color.FromArgb(146, 180, 222);
            ddChart.BackGradientEndColor = Color.White;
            ddChart.BackGradientType = GradientType.TopBottom;
            ddChart.BorderStyle = ChartDashStyle.Solid;
            ddChart.BorderColor = Color.DarkBlue;
            ddChart.BorderWidth = 2;


            ddChart.ChartAreas["Default"].ShadowOffset = 5;
            ddChart.ChartAreas["Default"].ShadowColor = Color.Gray;
            ddChart.ChartAreas["Default"].AxisX.LabelStyle.ShowEndLabels = true;
            ddChart.ChartAreas["Default"].AxisX.LabelStyle.Font = this.Font;
            ddChart.ChartAreas["Default"].AxisY.LabelStyle.ShowEndLabels = true;
            ddChart.ChartAreas["Default"].AxisY.LabelStyle.Font = this.Font;
            ddChart.ChartAreas["Default"].AxisX.MinorGrid.Enabled = false;
            ddChart.ChartAreas["Default"].AxisY.MinorGrid.Enabled = true;
            ddChart.ChartAreas["Default"].AxisY.MinorGrid.LineColor = Color.LightGray;
            ddChart.ChartAreas["Default"].AxisX.MajorGrid.Enabled = false;
            ddChart.ChartAreas["Default"].AxisY.MajorGrid.Enabled = true;
            ddChart.ChartAreas["Default"].AxisY.MajorGrid.LineColor = Color.Wheat;

            ddChart.ChartAreas["Default"].AxisX.LabelStyle.Format = "###,###";
            ddChart.ChartAreas["Default"].AxisY.LabelStyle.Format = "###,###";

            ddChart.Series["Series1"].SmartLabels.Enabled = true;
            ddChart.Series["Series1"].Font = this.Font;
            ddChart.Series["Series1"].LabelFormat = "###,###";
            ddChart.Series["Series1"].ShowLabelAsValue = false;
            ddChart.Series["Series2"].SmartLabels.Enabled = true;
            ddChart.Series["Series2"].Font = this.Font;
            ddChart.Series["Series2"].LabelFormat = "###,###";
            ddChart.Series["Series2"].ShowLabelAsValue = false;
            ddChart.Series["Series3"].SmartLabels.Enabled = true;
            ddChart.Series["Series3"].Font = this.Font;
            ddChart.Series["Series3"].LabelFormat = "###,###";
            ddChart.Series["Series3"].ShowLabelAsValue = false;

            ddChart.Palette = ChartColorPalette.Dundas;

        }
        private void RefreshChart(int gapmodelID, bool bIrr)
        {
            ddChart.Series.Clear();
            ddChart.Series.Add("Series1");
            ddChart.Series.Add("Series2");
            ddChart.Series.Add("Series3");

            ddChart.Series["Series1"].Type = SeriesChartType.StackedColumn;
            ddChart.Series["Series2"].Type = SeriesChartType.StackedColumn;
            ddChart.Series["Series3"].Type = SeriesChartType.StackedColumn;

            ddChart.Series["Series1"].ValueMemberX = "X";
            ddChart.Series["Series1"].ValueMembersY = "Y1";
            ddChart.Series["Series1"].XValueType = ChartValueTypes.Int;
            ddChart.Series["Series1"].YValuesPerPoint = 1;
            ddChart.Series["Series1"].ShowInLegend = false;
            ddChart.Series["Series1"].LegendText = "دارایی";

            ddChart.Series["Series2"].ValueMemberX = "X";
            ddChart.Series["Series2"].ValueMembersY = "Y2";
            ddChart.Series["Series2"].XValueType = ChartValueTypes.Int;
            ddChart.Series["Series2"].YValuesPerPoint = 1;
            ddChart.Series["Series2"].ShowInLegend = false;
            ddChart.Series["Series2"].LegendText = "شكاف";

            ddChart.Series["Series3"].ValueMemberX = "X";
            ddChart.Series["Series3"].ValueMembersY = "Y3";
            ddChart.Series["Series3"].XValueType = ChartValueTypes.Int;
            ddChart.Series["Series3"].YValuesPerPoint = 1;
            ddChart.Series["Series3"].ShowInLegend = false;
            ddChart.Series["Series3"].LegendText = "بدهی";

            ddChart.DataSource = gapbm.GetGAPBMSummary(gapmodelID, bIrr);
            ddChart.DataBind();

            ddChart.Series["Series1"].XValueIndexed = true;
            ddChart.Series["Series2"].XValueIndexed = true;
            ddChart.Series["Series3"].XValueIndexed = true;

            ddChart.Series["Series1"]["DrawingStyle"] = "Cylinder";
            ddChart.Series["Series2"]["DrawingStyle"] = "Cylinder";
            ddChart.Series["Series3"]["DrawingStyle"] = "Cylinder";

            ddChart.ChartAreas["Default"].Area3DStyle.Enable3D = true;
            ddChart.ChartAreas["Default"].Area3DStyle.Light = LightStyle.Realistic;
            ddChart.ChartAreas["Default"].Area3DStyle.Perspective = 30;
            ddChart.ChartAreas["Default"].Area3DStyle.XAngle = 10;
            ddChart.ChartAreas["Default"].Area3DStyle.YAngle = 5;
            ddChart.ChartAreas["Default"].Area3DStyle.PointDepth = 200;
            ddChart.ChartAreas["Default"].Area3DStyle.PointGapDepth = 0;
            ddChart.ChartAreas["Default"].Area3DStyle.RightAngleAxes = true;

            ddChart.ChartAreas["Default"].BackColor = Color.White;

            ddChart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            ddChart.BackColor = Color.FromArgb(146, 180, 222);
            ddChart.BackGradientEndColor = Color.White;
            ddChart.BackGradientType = GradientType.TopBottom;
            ddChart.BorderStyle = ChartDashStyle.Solid;
            ddChart.BorderColor = Color.DarkBlue;
            ddChart.BorderWidth = 2;


            ddChart.ChartAreas["Default"].ShadowOffset = 5;
            ddChart.ChartAreas["Default"].ShadowColor = Color.Gray;
            ddChart.ChartAreas["Default"].AxisX.LabelStyle.ShowEndLabels = true;
            ddChart.ChartAreas["Default"].AxisX.LabelStyle.Font = this.Font;
            ddChart.ChartAreas["Default"].AxisY.LabelStyle.ShowEndLabels = true;
            ddChart.ChartAreas["Default"].AxisY.LabelStyle.Font = this.Font;
            ddChart.ChartAreas["Default"].AxisX.MinorGrid.Enabled = false;
            ddChart.ChartAreas["Default"].AxisY.MinorGrid.Enabled = true;
            ddChart.ChartAreas["Default"].AxisY.MinorGrid.LineColor = Color.LightGray;
            ddChart.ChartAreas["Default"].AxisX.MajorGrid.Enabled = false;
            ddChart.ChartAreas["Default"].AxisY.MajorGrid.Enabled = true;
            ddChart.ChartAreas["Default"].AxisY.MajorGrid.LineColor = Color.Wheat;

            ddChart.ChartAreas["Default"].AxisX.LabelStyle.Format = "###,###";
            ddChart.ChartAreas["Default"].AxisY.LabelStyle.Format = "###,###";

            ddChart.Series["Series1"].SmartLabels.Enabled = true;
            ddChart.Series["Series1"].Font = this.Font;
            ddChart.Series["Series1"].LabelFormat = "###,###";
            ddChart.Series["Series1"].ShowLabelAsValue = false;
            ddChart.Series["Series2"].SmartLabels.Enabled = true;
            ddChart.Series["Series2"].Font = this.Font;
            ddChart.Series["Series2"].LabelFormat = "###,###";
            ddChart.Series["Series2"].ShowLabelAsValue = false;
            ddChart.Series["Series3"].SmartLabels.Enabled = true;
            ddChart.Series["Series3"].Font = this.Font;
            ddChart.Series["Series3"].LabelFormat = "###,###";
            ddChart.Series["Series3"].ShowLabelAsValue = false;

            ddChart.Palette = ChartColorPalette.Dundas;

        }

        private void chkShowHideValue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowHideValue.Checked)
            {
                ddChart.Series["Series1"].ShowLabelAsValue = true;
                ddChart.Series["Series2"].ShowLabelAsValue = true;
                ddChart.Series["Series3"].ShowLabelAsValue = true;
            }
            else
            {
                ddChart.Series["Series1"].ShowLabelAsValue = false;
                ddChart.Series["Series2"].ShowLabelAsValue = false;
                ddChart.Series["Series3"].ShowLabelAsValue = false;

            }

        }

        private void chkLegend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLegend.Checked)
            {
                ddChart.Series["Series1"].ShowInLegend = true;
                ddChart.Series["Series2"].ShowInLegend = true;
                ddChart.Series["Series3"].ShowInLegend = true;
            }
            else
            {
                ddChart.Series["Series1"].ShowInLegend = false;
                ddChart.Series["Series2"].ShowInLegend = false;
                ddChart.Series["Series3"].ShowInLegend = false;
            }
        }

        //private void cmbLimit_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    lsvState.Items.Clear();
        //    if (cmbLimit.SelectedIndex == 2)
        //    {
        //        btnList.Enabled = true;
        //        chkAll.Enabled = true;
        //    }
        //    else
        //    {
        //        btnList.Enabled = false;
        //        chkAll.Enabled = false;
        //    }
        //    if (cmbLimit.SelectedValue.ToString() != "System.Data.DataRowView")

        //        FillDest(cmbLimit.SelectedValue.ToString());


        //}
        //private void FillDest(string TableName)
        //{
        //    string str = "TableNameEnglish like '" + TableName + "' ";
        //    DataRow[] dr = dtTableXml.Select(str);


        //    string strField = dr[0]["Field"].ToString();
        //    string strId = dr[0]["Id"].ToString();
        //    string strTable_Name = TableName + "." + strId;

        //    lm = new LM();
        //    DataTable dtDest = lm.GetTable(strId, strField, TableName);

        //    cmbLimitValue.DataSource = dtDest;
        //    cmbLimitValue.DisplayMember = strField;
        //    cmbLimitValue.ValueMember = strId;
        //    cmbLimitValue.SelectedIndex = -1;
        //}
        //private void chkDescreteGapAnalisys_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkDescreteGapAnalisys.Checked)
        //    {
        //        cmbLimit.Enabled = true;
        //        cmbLimitValue.Enabled = true;
        //    }
        //    else
        //    {
        //        lsvState.Items.Clear();
        //        cmbLimit.Enabled = false;
        //        cmbLimitValue.Enabled = false;
        //        cmbLimitValue.SelectedIndex = -1;

        //    }

        //}


        // Save in Final Report of Gap
        private void tsbfinalSave_Click(object sender, EventArgs e)
        {

            SaveReport(curModelID, true);
        }
        private bool CheckExists(int modelID, int fsModelID, int tbModelID, int cbModelID)
        {
            DataTable dt = gapbm.GetGAPBMDTReport(modelID);
            bool flag = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                if (int.Parse(dt.Rows[i]["ModelID"].ToString()) == modelID && int.Parse(dt.Rows[i]["FSModelID"].ToString()) == fsModelID &&
                   int.Parse(dt.Rows[i]["TBModelID"].ToString()) == tbModelID && int.Parse(dt.Rows[i]["CBModelID"].ToString()) == cbModelID &&
                   DateTime.Parse(dt.Rows[i]["ReportDate"].ToString()).ToShortDateString() == fdpStartDate.SelectedDateTime.ToShortDateString())
                // DateTime.Today.ToShortDateString())
                { flag = true; }
            }

            return flag;

        }
        private void SaveReport(int modelID, bool bMessage)
        {

            //P = new PersianTools.Dates.PersianDate((DateTime)DateTime.Today);
            P = new PersianTools.Dates.PersianDate(fdpStartDate.SelectedDateTime);
            string Strdate = P.FormatedDate("yyyy/MM/dd").ToString();

            if (lsvModel.SelectedItems.Count > 0)
            {
                int fsModelID = (cmbFSM.SelectedIndex == -1) ? -1 : (int)cmbFSM.SelectedValue;
                int tbModelID = (cmbTBM.SelectedIndex == -1) ? -1 : (int)cmbTBM.SelectedValue;
                int cbModelID = (cmbCBM.SelectedIndex == -1) ? -1 : (int)cmbCBM.SelectedValue;
                int viewModeID = (int)cmbValType.SelectedIndex + 1;

                // add for farsi date
                //PersianTools.Dates.PersianDate p1;
                //p1 = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                //DateTime startDate = DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));

                //if (!CheckExists(modelID, fsModelID, tbModelID, cbModelID))
                //{

                bool bIrr = chkIrr.Checked;

                GAPBMInfo GAPbmInfo = (GAPBMInfo)lsvModel.SelectedItems[0].Tag;
                GAPBMReportInfo gi = new GAPBMReportInfo();
                gi.ModelID = modelID;
                var mName = new Utilize.frmInputText() { Text = "نام مدل" };
                mName.ShowDialog();
                gi.ModelName = GAPbmInfo.ModelName + " - " +
                               (string.IsNullOrEmpty(mName.ReturnValue) ? "بدون عنوان" : mName.ReturnValue);
                gi.TBModelID = tbModelID;
                gi.CBModelID = cbModelID;
                gi.FSModelID = fsModelID;
                gi.StartDate = fdpStartDate.SelectedDateTime;//startDate;
                gi.IrrActive = bIrr;

                CurrentReportID = gapbm.InsertGAPBMReport(gi);
                SaveReportElement(CurrentReportID, curModelID);

                if (bMessage)
                    Presentation.Public.Routines.ShowMessageBoxFa(" مدل شما به تاريخ " + Strdate + "ذخیره شد ", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    Presentation.Public.Routines.ShowMessageBoxFa(" مدل شما به تاريخ " + Strdate + "وجود دارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
        }
        private void SaveReportElement(decimal CurrentReportID, int curModelID)
        {

            gapbm.InsertGAPBMElementReport(CurrentReportID, curModelID);
        }
     
        //private void dgvGAPB_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    decimal GapLimit;

        //    Color color1 = Color.Red;
        //    Color color2 = Color.GreenYellow;

        //    if (e.RowIndex == dgvGAPBM.RowCount - 3 && e.ColumnIndex != 0)
        //    {
        //        //fx.Show();

        //        if (fx.ShowDialog() == DialogResult.OK)
        //        {
        //            GapUpLimit = fx.upLimit;
        //            GapdownLimit = fx.downLimit;
        //            dgvGAPBM.Rows[dgvGAPBM.RowCount - 2].Cells[e.ColumnIndex].Value = GapUpLimit; //حد مثبت
        //            dgvGAPBM.Rows[dgvGAPBM.RowCount - 1].Cells[e.ColumnIndex].Value = GapdownLimit; //منفی

        //            GapLimit = (decimal)dgvGAPBM.Rows[dgvGAPBM.RowCount - 3].Cells[e.ColumnIndex].Value;

        //            if (GapdownLimit < GapLimit && GapLimit < GapUpLimit)
        //            {
        //                colorFlag = 1;//Green
        //            }
        //            else
        //            {

        //                colorFlag = 2;//Red
        //            }
        //            gapbm.InsertLimit(curModelID, e.ColumnIndex, GapUpLimit, GapdownLimit);
        //            falgLimit = true; 
        //            columnLimit = e.ColumnIndex;

        //        }


        //    }
        //}
      
        private void cmbLimitValue_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  lsvState.Items.Clear();
          
        }

        private void btnMBM_Load(object sender, EventArgs e)
        {

        }

        private void btnDBM_Load(object sender, EventArgs e)
        {

        }

        private void btnReload_CButtonClicked(object sender, EventArgs e)
        {
            if (lsvModel.SelectedItems.Count == 0)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("لطفاً یك مدل تحلیل شکاف انتخاب یا ایجاد كنید", "مدل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ReLoad();
        }

        private void tsmiClear_Click(object sender, EventArgs e)
        {
            dgvGAPBM.Columns.Clear();
        }

        private void btnModel_CButtonClicked(object sender, EventArgs e)
        {
            if (splitContainer4.Panel1Collapsed == false)
            {
                splitContainer4.Panel1Collapsed = true;
                btnModel.DefaultImage = Properties.Resources.S_Panleft1;
                btnModel.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (splitContainer4.Panel1Collapsed == true)
            {
                splitContainer4.Panel1Collapsed = false;
                btnModel.DefaultImage = Properties.Resources.S_PanRight1;
                btnModel.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }

        private void cbUpdate_CButtonClicked(object sender, EventArgs e)
        {
            RebindAll();
            RebindPD();
        }

        private void grpParam_Click(object sender, EventArgs e)
        {

        }

        private void dgvGAPBM_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.RowIndex >= dgvGAP.Rows.Count - CTE_NumSumNodes || e.ColumnIndex == dgvGAP.Columns.Count - 1)
            //{
            //    e.CellStyle.ForeColor = Color.Green;
            //    e.CellStyle.BackColor = Color.Ivory;

            //    using (Font boldFont = new Font(dgvGAP.Font, FontStyle.Bold))
            //    {
            //        e.CellStyle.Font = boldFont;
            //    }
            //}
            //if (e.RowIndex >= dgvGAP.Rows.Count - CTE_NumSumNodes && e.ColumnIndex == 0)
            //{
            //    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //}

            //if (e.RowIndex > -1 && e.RowIndex < dgvGAP.Rows.Count - CTE_NumSumNodes && e.ColumnIndex == 0)
            //{
            //    Font boldFont = new Font(dgvGAP.Font, FontStyle.Bold);
            //    e.CellStyle.Font = boldFont;
            //}

            //if (true)
            //{
            //    if (!dgvGAP.Columns[e.ColumnIndex].Name.Contains("TB") || e.RowIndex != dgvGAP.Rows.Count - 3) return;

            //    int GapLimit = Convert.ToInt32(dgvGAP.Rows[dgvGAP.RowCount - 3].Cells[e.ColumnIndex].Value); //حد مثبت
            //    int GapUpLimitCur = Convert.ToInt32(dgvGAP.Rows[dgvGAP.RowCount - 2].Cells[e.ColumnIndex].Value); //حد مثبت
            //    int GapdownLimitCur = Convert.ToInt32(dgvGAP.Rows[dgvGAP.RowCount - 1].Cells[e.ColumnIndex].Value); //منفی

            //    if (GapUpLimitCur == 0 && GapdownLimitCur == 0) return;

            //    if (GapLimit > GapdownLimitCur && GapLimit < GapUpLimitCur)
            //        e.CellStyle.BackColor = Color.GreenYellow;
            //    else
            //        e.CellStyle.BackColor = Color.Red;
            //}
            if (e.RowIndex >= dgvGAPBM.Rows.Count - CTE_NumSumNodes || e.ColumnIndex == dgvGAPBM.Columns.Count - 1)
            {
                e.CellStyle.ForeColor = Color.Green;
                e.CellStyle.BackColor = Color.Ivory;

                using (Font boldFont = new Font(dgvGAPBM.Font, FontStyle.Bold))
                {
                    e.CellStyle.Font = boldFont;
                }
            }
            if (e.RowIndex >= dgvGAPBM.Rows.Count - CTE_NumSumNodes && e.ColumnIndex == 0)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (e.RowIndex > -1 && e.RowIndex < dgvGAPBM.Rows.Count - CTE_NumSumNodes && e.ColumnIndex == 0)
            {
                Font boldFont = new Font(dgvGAPBM.Font, FontStyle.Bold);
                e.CellStyle.Font = boldFont;
            }
            if (falgLimit)
            {

                if (e.RowIndex == dgvGAPBM.RowCount - 3 && e.ColumnIndex == columnLimit)
                {
                    if (colorFlag == 1)
                        e.CellStyle.BackColor = Color.GreenYellow;
                    else
                        e.CellStyle.BackColor = Color.Red;
                }
            }
            //    dgvGAP.Rows[40].Cells[15].Style.BackColor = Color.Red;
            if (true)
            {
                if (!dgvGAPBM.Columns[e.ColumnIndex].Name.Contains("TB") || e.RowIndex != dgvGAPBM.Rows.Count - 3) return;

                double GapLimit = Convert.ToDouble(dgvGAPBM.Rows[dgvGAPBM.RowCount - 3].Cells[e.ColumnIndex].Value); //حد مثبت
                double GapUpLimitCur = Convert.ToDouble(dgvGAPBM.Rows[dgvGAPBM.RowCount - 2].Cells[e.ColumnIndex].Value); //حد مثبت
                double GapdownLimitCur = Convert.ToDouble(dgvGAPBM.Rows[dgvGAPBM.RowCount - 1].Cells[e.ColumnIndex].Value); //منفی

                if (GapUpLimitCur == 0 && GapdownLimitCur == 0) return;

                if (GapLimit > GapdownLimitCur && GapLimit < GapUpLimitCur)
                    e.CellStyle.BackColor = Color.GreenYellow;
                else if (GapLimit > GapdownLimitCur)
                    e.CellStyle.BackColor = Color.Red;
                else if (GapLimit < GapUpLimitCur)
                    e.CellStyle.BackColor = Color.Blue;
            }

        }

        private void cmbFSM_ValueChanged(object sender, EventArgs e)
        {
            RebindMBM();
        }

        private void cmbTBM_ValueChanged(object sender, EventArgs e)
        {
            RebindMBM();
        }

        private void rdbPDLG_CheckedChanged(object sender, EventArgs e)
        {
            cmbPDG.Enabled = rdbPDLG.Checked;
            cmbDBMG.Enabled = !rdbPDLG.Checked;

            if (!cmbDBMG.Enabled)
                cmbDBMG.SelectedIndex = -1;
            if (!cmbPDG.Enabled)
                cmbPDG.SelectedIndex = -1;
        }

        private void cmbDBM_ValueChanged(object sender, EventArgs e)
        {
            if (cmbDBM.SelectedIndex > -1 && cmbDBM.SelectedValue != null)
            {
                DataTable dt = (DataTable) cmbDBM.DataSource;
                dt =
                    dt.AsEnumerable()
                      .Where(s => s.Field<int>(DBM.CTE_Alias_ID.ToString()) == (int) cmbDBM.SelectedValue)
                      .CopyToDataTable();
                fdtTemp.SelectedDateTime = (DateTime) dt.Rows[0]["Model_Date"];
                lblBMDDate.Text = "تاریخ مدل: " + fdtTemp.Text;
                //cmbDBM.DataSource = dt;
                //cmbDBM.DisplayMember = DBM.CTE_Alias_ModelName;
                //cmbDBM.ValueMember = DBM.CTE_Alias_ID;
                //cmbDBM.SelectedIndex = -1;
            }
            else
            {
                lblBMDDate.Text = "تاریخ مدل: " + "---";   
            }
        }

        private void cmbDBMG_ValueChanged(object sender, EventArgs e)
        {
            if (cmbDBMG.SelectedIndex > -1 && cmbDBMG.SelectedValue != null)
            {
                DataTable dt = (DataTable)cmbDBMG.DataSource;
                dt = dt.AsEnumerable().Where(s => s.Field<int>(DBM.CTE_Alias_ID.ToString()) == (int)cmbDBMG.SelectedValue).CopyToDataTable();
                fdtTemp.SelectedDateTime = (DateTime) dt.Rows[0]["Model_Date"];
                lblBMGDate.Text = "تاریخ مدل: " + fdtTemp.Text;
                //cmbDBM.DataSource = dt;
                //cmbDBM.DisplayMember = DBM.CTE_Alias_ModelName;
                //cmbDBM.ValueMember = DBM.CTE_Alias_ID;
                //cmbDBM.SelectedIndex = -1;
            }
            else
            {
                lblBMGDate.Text = "تاریخ مدل: " + "---";
            }
        }

        private void cmbCurrency_SelectionChanged(object sender, EventArgs e)
        {
            if ((int)cmbCurrency.SelectedValue == 20)
            {
                cmbCurrencyValue.Enabled = true;
            }
            else
            {
                cmbCurrencyValue.Enabled = false;
            }
        }




        //private void btnNLoan_Click(object sender, EventArgs e)
        //{
        //    Excel.Application xlApp;
        //    Excel.Workbook xlWorkBook;
        //    Excel.Worksheet xlWorkSheet;
        //    object misValue = System.Reflection.Missing.Value;

        //    xlApp = new Excel.Application();
        //    xlWorkBook = xlApp.Workbooks.Open("csharp.net-informations.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
        //    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

        //    MessageBox.Show(xlWorkSheet.get_Range("A1", "A1000").Value2.ToString());

        //    xlWorkBook.Close(true, misValue, misValue);
        //    xlApp.Quit();

        //    releaseObject(xlWorkSheet);
        //    releaseObject(xlWorkBook);
        //    releaseObject(xlApp);
        //}

        //private void releaseObject(object obj)
        //{
        //    try
        //    {
        //        System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
        //        obj = null;
        //    }
        //    catch (Exception ex)
        //    {
        //        obj = null;
        //        MessageBox.Show("Unable to release the Object " + ex.ToString());
        //    }
        //    finally
        //    {
        //        GC.Collect();
        //    }
        //}



    }
}