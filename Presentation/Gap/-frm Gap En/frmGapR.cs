using System;
using System.Globalization;
using System.IO;
using DAL;
using ERMS.Logic;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using ERMSLib;
using ERMS.Model;
using Dundas.Charting.WinControl;
using Presentation.Public;
using MyDialogButton = Utilize.MyDialogButton;
using ProgressBox = Presentation.Public.ProgressBox;
using Utilize.Helper;
using OfficeOpenXml;
using ClosedXML.Excel;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmGAP : BaseForm, IPrintable
    {
        #region VARS

        private FSM fsm;
        private TBM tbm;
        private CBM cbm;
        private GAP gap;
        private frmGapLimit fx;
        private TBOption tbOption;
        private DataTable user;
        private DataTable branch;


        private DataTable dtTBElements, dtGAP;

        private Hashtable htFSMs;
        private int curModelID = -1;
        private List<DataGridViewColumn> irrCols = new List<DataGridViewColumn>();

        private DataColumn totalDColumn;

        private DataRow summaryDRow1,
                        summaryDRow2,
                        summaryDRow2Limit,
                        drGAPD,
                        summaryDRow2LimitUp,
                        summaryDRow2LimitDown;

        private DataGridViewColumn totalColumn;
        private DataGridViewRow summaryRow1, summaryRow2;

        private decimal[] footerGap = new decimal[128];
        private decimal[] titleSum = new decimal[128];

        private PersianTools.Dates.PersianDate P;
        private string dateFarsi;

        private bool TagFullMode = false;

        private DataTable dtTableXml;
        private LM lm;

        private decimal CurrentReportID;

        public int FlagFullMode = 0;
        public DateTime StartDateFullMode;

        private decimal GapUpLimit, GapdownLimit;
        private bool falgLimit = false;
        private int columnLimit = 0, colorFlag = 1;

        private string limitDetails = string.Empty;
        private int limitID = -1;
        ////////

        #endregion

        #region CONST

        private const int CTE_ValType_Principle = 0;
        private const int CTE_ValType_Interest = 1;
        private const int CTE_ValType_Both = 2;

        private const int CTE_NumSumNodes = 5;

        #endregion

        public frmGAP()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);

            #region State And Organization

            user =
                new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(
                    ERMS.Model.GlobalInfo.UserID);

            if (user.Rows.Count == 0)
            {
                var organization_DataTable = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();

                ucfOrganization.DisplayMember = "Branch_Description";
                ucfOrganization.ValueMember = "Branch";
                ucfOrganization.DataSource = organization_DataTable;
                ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;
            }
            else
            {

                var organizationNew_DataTable =
                    user.Rows.Cast<DataRow>().Select(
                        item =>
                        new
                            {
                                Brach_Id = item["Branch"].ToString(),
                                Branch_Description = item["Branch_Description"].ToString()
                            }).Distinct().ToArray();

                ucfOrganization.DisplayMember = "Branch_Description";
                ucfOrganization.ValueMember = "Branch";
                ucfOrganization.DataSource = organizationNew_DataTable;
                ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;

            }

            #endregion

        }

        private void frmGAP_Load(object sender, EventArgs e)
        {
            user =
                new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(
                    ERMS.Model.GlobalInfo.UserID);

            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

            fdpStartDate.SelectedDateTime = DateTime.Now;
            GeneralDataGridView = dgvGAP;
            Init();

        }


        private void btnFSM_Click(object sender, EventArgs e)
        {
            frmFSM fx = new frmFSM() {FormBorderStyle = FormBorderStyle.Sizable};
            fx.Changed += new frmFSM.ChangedDelegate(fxFSM_Changed);
            fx.ShowDialog();
        }

        private void fxFSM_Changed()
        {
            RebindFSM();
        }

        private void btnTBM_Click(object sender, EventArgs e)
        {
            frmTBM fx = new frmTBM() {FormBorderStyle = FormBorderStyle.Sizable};
            fx.Changed += new frmTBM.ChangedDelegate(fxTBM_Changed);
            fx.ShowDialog();
        }

        private void fxTBM_Changed()
        {
            RebindTBM();
        }

        private void btnCBM_Click(object sender, EventArgs e)
        {
            if (cmbFSM.SelectedIndex == -1 || cmbTBM.SelectedIndex == -1)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("لطفاً مدل تراز نامه و بسته زمانی را انتخاب كنید", "پیغام",
                                                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmCBM fx = new frmCBM() {FormBorderStyle = FormBorderStyle.Sizable};
            fx.TBModelID = (int) cmbTBM.SelectedValue;
            fx.FSModelID = (int) cmbFSM.SelectedValue;
            fx.Changed += new frmCBM.ChangedDelegate(fxCBM_Changed);
            fx.ShowDialog();
        }

        private void fxCBM_Changed()
        {
            RebindCBM();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (lsvModel.SelectedItems.Count == 0)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("لطفاً یك مدل تحلیل شکاف انتخاب یا ایجاد كنید", "مدل",
                                                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ReLoad();
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
            if ((cmbFSM.SelectedIndex != -1) && (cmbTBM.SelectedIndex != -1) && (cmbPM.SelectedIndex != -1))
            {
                Save(curModelID, true);
            }
            else
            {
                Presentation.Public.Routines.ShowMessageBoxFa(
                    "تحلیل شکاف در یك مدل ترازنامه، بسته زمانی و مدل اقلام بدون سررسید اجرا می شود. مدلهای مناسب را انتخاب كرده و دوباره اجرا كنید",
                    "تحلیل شکاف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void tsmiDetail_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataGridViewCell cell = dgvGAP.CurrentCell;
                var fx = new frmDetail();
                if (cell != null && cell.RowIndex <= dgvGAP.Rows.Count - 1 - CTE_NumSumNodes && cell.ColumnIndex != 0 &&
                    cell.ColumnIndex != dgvGAP.Columns.Count - 1)
                {
                    int fsModelElementID = (int)dgvGAP.CurrentRow.Cells["FSME_ID"].Value;
                    int TBModelElementID = ((TBMElementInfo)cell.OwningColumn.Tag).ID;
                    var status = dgvGAP.CurrentRow.Cells["Status"].Value.ToString();
                    string title = dgvGAP.CurrentRow.Cells["FSME_Title"].Value.ToString();
                    if (title != string.Empty)
                    {
                        Routines.ShowMessageBoxFa(
                            "عملیات درخواست شده تحت یك عنوان گروه حساب قابل انجام نیست", "پیغام", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return;
                    }

                   
                     
                   
                   fx.fsModelElementID = fsModelElementID;
                   fx.tbModelID = TBModelElementID;
                    fx.status = status;
                    fx.CurrencyID = (int)dgvGAP.CurrentRow.Cells["Currency"].Value;
                    fx.CounterPartyType
                        = (int)dgvGAP.CurrentRow.Cells["CounterParty_type"].Value;

                    //ProgressBox.Hide();
                    fx.Show();
                }
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK,
                                                              MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        private void tsmiClear_Click(object sender, EventArgs e)
        {
            dgvGAP.Columns.Clear();
        }

        private void tsmiReset_Click(object sender, EventArgs e)
        {
            cmbFSM.SelectedIndex = -1;
            cmbPM.SelectedIndex = -1;
            cmbTBM.SelectedIndex = -1;
            cmbCurrency.SelectedIndex = cmbCurrency.Items.Count >=3 ? 2 : -1;
            cmbValType.SelectedIndex = cmbValType.Items.Count >=4 ? 3 : -1;

            chkColor.Checked = true;
            chkIrr.Checked = false;


            // add for farsi date
            fdpStartDate.SelectedDateTime = DateTime.Now; // P.FormatedDate("yyyy/MM/dd");
            //

            dgvGAP.Columns.Clear();
            this.Close();
        }

        private void lsvModel_DoubleClick(object sender, EventArgs e)
        {
            CommandModelEdit();
        }

        private void frmGAP_FormClosing(object sender, FormClosingEventArgs e)
        {
            TagFullMode = false;
        }

        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
            {
                if (lsvModel.SelectedItems.Count > 0)
                {
                    GAPDInfo gi = (GAPDInfo) lsvModel.SelectedItems[0].Tag;
                    //cmbFSM.SelectedValue = gi.FSModelID;
                    //cmbTBM.SelectedValue = gi.TBModelID;
                    //cmbCBM.SelectedValue = gi.CBModelID;

                    cmbFSM.SelectedByDataValue(gi.FSModelID);
                    cmbTBM.SelectedByDataValue(gi.TBModelID);
                    cmbPM.SelectedByDataValue(gi.CBModelID);

                    chkIrr.Checked = gi.IrrActive;

                    // add by soltani
                    //P = new PersianTools.Dates.PersianDate((DateTime)gi.StartDate);
                    //fdpStartDate.Text = P.FormatedDate("yyyy/MM/dd");
                    dateFarsi = fdpStartDate.Text; // fdpStartDate.Text;
                    //
                    //    dtpStartDate.Value = gi.StartDate;

                    curModelID = gi.ID;
                    cmbLimit.ResetText();
                    cmbLimitValue.ResetText();
                    ucfOrganization.ResetText();
                    return;
                }
            }

            dgvGAP.Columns.Clear();
        }

        

        private void chkIrr_CheckedChanged(object sender, EventArgs e)
        {
            ToggleIrr();
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtGAP != null)
                NumberScale(cmbUnit.SelectedIndex);
        }

        private void Collapse(int dIndex, int balance)
        {
            for (int i = dIndex + 1; i <= dtGAP.Rows.Count - CTE_NumSumNodes - 1; i++)
            {
                DataRow dr = dtGAP.Rows[i];
                if ((int) dr["FSME_Balance"] <= balance)
                    break;

                dr["Hidden"] = true;
            }
        }

        private void Expand(int dIndex, int balance)
        {
            for (int i = dIndex + 1; i <= dtGAP.Rows.Count - CTE_NumSumNodes - 1; i++)
            {
                DataRow dr = dtGAP.Rows[i];
                if ((int) dr["FSME_Balance"] <= balance)
                    break;

                dr["Hidden"] = false;
            }
        }

        private void dgvGAP_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }

        private void dgvGAP_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0 || e.RowIndex > dgvGAP.Rows.Count - 1 - CTE_NumSumNodes)
            {
                e.Handled = false;
                return;
            }

            DataGridViewRow row = dgvGAP.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells["FSME_Balance"];

            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
                e.PaintBackground(e.ClipBounds, true);
            else
            {
                Color color1 = Color.White;
                Color color2 = chkColor.Checked ? Color.FromArgb((int) row.Cells["FSME_Color"].Value) : Color.White;
                using (
                    Brush bg = new System.Drawing.Drawing2D.LinearGradientBrush(e.CellBounds, color1, color2,
                                                                                System.Drawing.Drawing2D.
                                                                                    LinearGradientMode.Horizontal))
                {
                    //e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
                    //Rectangle rect = new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
                    e.Graphics.FillRectangle(bg, e.CellBounds);
                }
            }

            e.Paint(e.CellBounds, DataGridViewPaintParts.Focus | DataGridViewPaintParts.Border);

            //////////////////////////////
            int balance = (int) cell.Value;
            int indent = balance*20;

            string groupName = row.Cells["FSME_GroupName"].Value.ToString();
            string title = row.Cells["FSME_Title"].Value.ToString();
            string caption = groupName != string.Empty ? groupName : title;

            Image nodeImage;
            int dIndex = dtGAP.Rows.IndexOf(((DataRowView) row.DataBoundItem).Row);

            DataRow curDRow = dtGAP.Rows[dIndex];
            if (dIndex < dtGAP.Rows.Count - 1 - CTE_NumSumNodes)
            {
                DataRow nextDRow = dtGAP.Rows[dIndex + 1];

                string curULevel = curDRow["FSME_ULevel"].ToString();
                string nextULevel = nextDRow["FSME_ULevel"].ToString();
                bool nextIsHidden = (bool) nextDRow["Hidden"];

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


            e.Graphics.DrawString(caption.ToString(), e.CellStyle.Font, Brushes.DimGray,
                                  e.CellBounds.Location.X + indent + 20, e.CellBounds.Location.Y + 2);

            if (nodeImage != null)
            {
                System.Drawing.Drawing2D.GraphicsContainer container = e.Graphics.BeginContainer();
                e.Graphics.SetClip(e.ClipBounds);
                e.Graphics.DrawImageUnscaled(nodeImage, e.CellBounds.Location.X + indent, e.CellBounds.Location.Y);
                e.Graphics.EndContainer(container);
            }

            e.Handled = true;
            
        }

        private void dgvGAP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= dgvGAP.Rows.Count - CTE_NumSumNodes || e.ColumnIndex == dgvGAP.Columns.Count - 1)
            {
                e.CellStyle.ForeColor = Color.Green;
                e.CellStyle.BackColor = Color.Ivory;

                using (Font boldFont = new Font(dgvGAP.Font, FontStyle.Bold))
                {
                    e.CellStyle.Font = boldFont;
                }
            }
            if (e.RowIndex >= dgvGAP.Rows.Count - CTE_NumSumNodes && e.ColumnIndex == 0)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (e.RowIndex > -1 && e.RowIndex < dgvGAP.Rows.Count - CTE_NumSumNodes && e.ColumnIndex == 0)
            {
                Font boldFont = new Font(dgvGAP.Font, FontStyle.Bold);
                e.CellStyle.Font = boldFont;
            }
            if (falgLimit)
            {

                if (e.RowIndex == dgvGAP.RowCount - 3 && e.ColumnIndex == columnLimit)
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
                if (!dgvGAP.Columns[e.ColumnIndex].Name.Contains("TB") || e.RowIndex != dgvGAP.Rows.Count - 3) return;

                double GapLimit = Convert.ToDouble(dgvGAP.Rows[dgvGAP.RowCount - 3].Cells[e.ColumnIndex].Value);
                    //حد مثبت
                double GapUpLimitCur = Convert.ToDouble(dgvGAP.Rows[dgvGAP.RowCount - 2].Cells[e.ColumnIndex].Value);
                    //حد مثبت
                double GapdownLimitCur = Convert.ToDouble(dgvGAP.Rows[dgvGAP.RowCount - 1].Cells[e.ColumnIndex].Value);
                    //منفی

                if (GapUpLimitCur == 0 && GapdownLimitCur == 0) return;

                if (GapLimit > GapdownLimitCur && GapLimit < GapUpLimitCur)
                    e.CellStyle.BackColor = Color.GreenYellow;
                else if (GapLimit > GapdownLimitCur)
                    e.CellStyle.BackColor = Color.Red;
                else if (GapLimit < GapUpLimitCur)
                    e.CellStyle.BackColor = Color.Blue;
            }

        }

        private void Init()
        {
            fsm = new FSM();
            tbm = new TBM();
            cbm = new CBM();
            gap = new GAP();
            fx = new frmGapLimit();
            tbOption = new TBOption {MaxBoxWidth = 325};

            RebindAll();

            var ArrVal = new string[] { "مبلغ قسط", "مبلغ اصل", "هر دو", "تراز" };
            cmbValType.AddItemsRange(ArrVal);
            
            htFSMs = new Hashtable();

            var misc = new Misc();
            //cmbCurrency.DataSource = misc.GetCurrencyDT();
            var ArrCur = new string[] { "ريالی", "ارزی", "هر دو" };
            cmbCurrency.AddItemsRange(ArrCur);
            cmbCurrency.SelectedIndex = cmbCurrency.Items.Count >= 3 ? 2 : -1;
            cmbValType.SelectedIndex = cmbValType.Items.Count >= 4 ? 3 : -1;

            chkColor.Checked = true;
            chkIrr.Checked = false;

            lsvModel.View = View.Details;
            var ch = new ColumnHeader {Width = lsvModel.Width - 5};
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;

            //GAP Grid
            dgvGAP.ReadOnly = true;
            dgvGAP.AllowUserToAddRows = false;
            dgvGAP.AllowUserToDeleteRows = false;
            dgvGAP.AllowUserToResizeRows = false;
            dgvGAP.AllowUserToResizeColumns = true;
            dgvGAP.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (250)))), ((int) (((byte) (255)))),
                                                                   ((int) (((byte) (250)))));
            dgvGAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvGAP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dgvGAP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dgvGAP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvGAP.RowHeadersVisible = false;
            dgvGAP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            var style = new System.Windows.Forms.DataGridViewCellStyle
                            {
                                BackColor =
                                    System.Drawing.Color.FromArgb(((int) (((byte) (250)))), ((int) (((byte) (255)))),
                                                                  ((int) (((byte) (250)))))
                            };
            dgvGAP.RowsDefaultCellStyle = style;
            dgvGAP.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvGAP.EnableHeadersVisualStyles = false;

            var ArrUnit= new string[] { "واحد", "هزار", "ميليون" };
            cmbUnit.AddItemsRange(ArrUnit);
            cmbUnit.SelectedIndex = 0;

            FillModel();
        }

        private void RebindAll()
        {
            RebindFSM();
            RebindTBM();
            RebindCBM();
            RebindLimit();
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
            var fsm = cmbFSM.SelectedValue ?? -1;
            var l = new Predict_Entities(Predict.Predict.getEntityConnection()).Predict_Gap_Model
               .ToList().Where(a => a.Profile_ID == GlobalInfo.ProfileID && a.FS_Model_ID == (int)fsm)
               .Select(a => new { a.Name, a.ID }).ToList().ToDataTable();
            l.Rows.Add(new object[] { "No Model", -1 });
            
            cmbPM.DataSource = l;
            cmbPM.DisplayMember = "Name";
            cmbPM.ValueMember = "ID";
            cmbPM.SelectedIndex = -1;
           
        }

        private void RebindLimit()
        {
            ReadXml();
            cmbLimit.DataSource = dtTableXml;
            cmbLimit.DisplayMember = "TableNameFarsi";
            cmbLimit.ValueMember = "TableNameEnglish";


        }

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
                GAPDInfo gi = new GAPDInfo();
                lvi.Text = descr;
                lvi.Tag = gi;
                lsvModel.Items.Add(lvi);
                lvi.Selected = true;

                //                
                gi.ModelName = descr;
                gi.ID = gap.InsertGAPD(gi);
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
                    GAPDInfo gi = (GAPDInfo) lvi.Tag;
                    gi.ModelName = descr;
                    gap.UpdateGAPD(gi);
                }
            }
        }

        private void CommandModelRemove()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                if (
                    Presentation.Public.Routines.ShowMessageBoxFa("این مدل انتخاب شده، حذف خواهد شد. آیا مطمئن هستید؟",
                                                                  "تایید", MessageBoxButtons.OKCancel,
                                                                  MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem lvi = lsvModel.SelectedItems[0];
                    GAPDInfo gi = (GAPDInfo) lvi.Tag;

                    lvi.Remove();
                    gap.DeleteGAPD(gi.ID);
                }
            }
        }

        private void Save(int modelID, bool bMessage)
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                int fsModelID = (cmbFSM.SelectedIndex == -1) ? -1 : (int) cmbFSM.SelectedValue;
                int tbModelID = (cmbTBM.SelectedIndex == -1) ? -1 : (int) cmbTBM.SelectedValue;
                int cbModelID = (cmbPM.SelectedIndex == -1) ? -1 : (int) cmbPM.SelectedValue;
                int viewModeID = (int) cmbValType.SelectedIndex + 1;

                bool bIrr = chkIrr.Checked;

                GAPDInfo gi = (GAPDInfo) lsvModel.SelectedItems[0].Tag;
                gi.TBModelID = tbModelID;
                gi.CBModelID = cbModelID;
                gi.FSModelID = fsModelID;
                gi.StartDate = fdpStartDate.SelectedDateTime; //startDate;
                gi.IrrActive = bIrr;
                if (gi.ID != -1)
                    gap.UpdateGAPD(gi);
                else
                    gi.ID = gap.InsertGAPD(gi);

                if (bMessage)
                    Presentation.Public.Routines.ShowMessageBoxFa("مدل شما ذخیره شد", "ذخیره", MessageBoxButtons.OK,
                                                                  MessageBoxIcon.Information);
            }

        }

        private void FillModel()
        {
            DataTable dt = gap.GetGAPDs();
            foreach (DataRow dr in dt.Rows)
            {
                GAPDInfo gi = new GAPDInfo();
                gap.CloneX(dr, gi, ECloneXdir.DR2Info);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = gi.ModelName;
                lvi.Tag = gi;

                lsvModel.Items.Add(lvi);
            }

        }

        private void ReLoad()
        {
            if ((cmbFSM.SelectedIndex == -1) || (cmbTBM.SelectedIndex == -1) || (cmbPM.SelectedIndex == -1) || (cmbValType.SelectedIndex == -1))
            {
                Presentation.Public.Routines.ShowMessageBoxFa(
                    "تحلیل شکاف در یك مدل ترازنامه، بسته زمانی و مدل اقلام بدون سررسید اجرا می شود. مدلهای مناسب را انتخاب كرده و دوباره اجرا كنید",
                    "تحلیل شکاف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            FillGap(true);
            RefreshChart();
            System.Windows.Forms.Cursor.Current = Cursors.Default;

        }

        //public void Reload(int gapModelID, int tbModelID, int currencyID, int unitIndex, int fsModelId, int cbModelID,
        //                   int viewModeID, int unitID, bool bAutoSize, bool IsSeperate, int limitID, string limitDetails,
        //                   DateTime startDate)
        //{
        //    //  DateTime startDate = dtpStartDate.Value;

        //    bool bIrr = chkIrr.Checked;

        //    //int limitID = cmbLimit.SelectedIndex;
        //    //string limitDetails = cmbLimitValue.SelectedValue.ToString();        
        //    //bool IsSeperate = chkDescreteGapAnalisys.Checked;


        //    dtTBElements = tbm.GetTBMelements(tbModelID);
        //    dtGAP = gap.GetGAP(gapModelID, fsModelId, tbModelID, cbModelID, startDate, bIrr, viewModeID, currencyID,
        //                       limitDetails, limitID, IsSeperate, rdbHistoric.Checked, chkCurrencyMarketValue.Checked,fil_LoanContractStatus,fil_DepositContractStatus);
        //    dtGAP.DefaultView.RowFilter = "(Hidden = 0)";

        //    //
        //    summaryDRow1 = dtGAP.NewRow();
        //    dtGAP.Rows.Add(summaryDRow1);

        //    summaryDRow2 = dtGAP.NewRow();
        //    dtGAP.Rows.Add(summaryDRow2);

        //    summaryDRow2Limit = dtGAP.NewRow();
        //    dtGAP.Rows.Add(summaryDRow2Limit);

        //    summaryDRow2LimitUp = dtGAP.NewRow();
        //    dtGAP.Rows.Add(summaryDRow2LimitUp);

        //    summaryDRow2LimitDown = dtGAP.NewRow();
        //    dtGAP.Rows.Add(summaryDRow2LimitDown);


        //    PrepareSummary();
        //    //

        //    dgvGAP.DataSource = dtGAP;
        //    FormatGrid(dtTBElements, bAutoSize);

        //    dtGAP.AcceptChanges();

        //    if (cmbUnit.SelectedIndex != 0)
        //        NumberScale(unitID);
        //}

        private void FillGap(bool calcGap)
        {
            try
            {
                ProgressBox.Show();

                dgvGAP.Columns.Clear();

                var gapModelID = ((GAPDInfo) lsvModel.SelectedItems[0].Tag).ID;
                var fsModelID = (int) cmbFSM.SelectedValue;
                var tbModelID = (int) cmbTBM.SelectedValue;
                var cbModelID = (int) cmbPM.SelectedValue;
                var currencyID =  cmbCurrency.SelectedIndex+1;
                var viewModeID =  cmbValType.SelectedIndex + 1;

                var bIrr = chkIrr.Checked;
                

                

                // barresi mishavad ke tafkiki entekhab shode ya na
                var IsSeperate = chkDescreteGapAnalisys.Checked;

                limitID = -1;

                // no-e tafkik (ostani ya bakhsh) maloom mishavad

                if (chkDescreteGapAnalisys.Checked)
                {
                    //limitID = cmbLimit.SelectedIndex;

                    //if (cmbLimit.SelectedIndex == 0 && chkAll.Checked == false)
                    //{
                    //    limitID = 0; // شعب
                    //    limitDetails = cmbLimitValue.SelectedValue.ToString().Trim();
                    //}
                    //limitDetails = GetFilterBranchG();

                    //تفکیک استان
                    if (cmbLimit.SelectedIndex == 0 && ucfOrganization.IsChecked() == false &&
                        cmbLimitValue.SelectedIndex != -1)
                    {
                        limitDetails = cmbLimitValue.SelectedValue.ToString().Trim();
                        limitID = 2;
                    }

                    // تفکیک استان و شعب
                    if (cmbLimit.SelectedIndex == 0 && ucfOrganization.IsChecked() == true && chkAll.Checked == false)
                    {
                        limitDetails = GetFilterBranchG();
                        limitID = 0;
                    }

                    //بخش اقتصادی
                    if (cmbLimit.SelectedIndex != 0 && chkAll.Checked == false)
                    {
                        limitDetails = cmbLimitValue.SelectedValue.ToString();
                        limitID = 1;
                    }
                }

                dtTBElements = tbm.GetTBMelements(tbModelID);
                var temp =
                    new DAL.Table_DataSetTableAdapters.GAPD_ModelTableAdapter().GetDataByGAPD_Model_Id(gapModelID).
                        FirstOrDefault();

                if (temp != null)
                {

                    if (temp.IsGAPD_CB_Model_IdNull() || temp.IsGAPD_FS_Model_IdNull() || temp.IsGAPD_TB_Model_IdNull())
                    {

                        Presentation.Public.Routines.ShowMessageBoxFa("لطفاً ابتدا مدل را ذخیره کنید", "مدل",
                                                                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    else
                    {

                        if (cmbPM.SelectedIndex!=-1 && (int)cmbPM.SelectedValue != -1)
                        {

                            Predict.Predict.RunForGap((int)cmbPM.SelectedValue, (DateTime)new DAL.UserInfo().GetDt_UpdateDate().Rows[0][0]);
                        }

                        dtGAP = gap.GetGAP(gapModelID, fsModelID, tbModelID, cbModelID, fdpStartDate.SelectedDateTime,
                                           bIrr, viewModeID, currencyID, limitDetails, limitID, IsSeperate, rdbHistoric.Checked, chkCurrencyMarketValue.Checked, calcGap);
                        dtGAP.DefaultView.RowFilter = "(Hidden = 0)";

                        
                        summaryDRow1 = dtGAP.NewRow();
                        dtGAP.Rows.Add(summaryDRow1);

                        summaryDRow2 = dtGAP.NewRow();
                        dtGAP.Rows.Add(summaryDRow2);

                        summaryDRow2Limit = dtGAP.NewRow();
                        dtGAP.Rows.Add(summaryDRow2Limit);

                        summaryDRow2LimitUp = dtGAP.NewRow();
                        dtGAP.Rows.Add(summaryDRow2LimitUp);

                        summaryDRow2LimitDown = dtGAP.NewRow();
                        dtGAP.Rows.Add(summaryDRow2LimitDown);
                        PrepareSummary();
                        //
                        GetLimit();
                        dtGAP.AcceptChanges();
                        dgvGAP.DataSource = dtGAP;
                        FormatGrid(dtTBElements, chkAutoSize.Checked);

                        dtGAP.AcceptChanges();

                        if (cmbUnit.SelectedIndex != 0)
                            NumberScale(cmbUnit.SelectedIndex);

                    }
                }
            }







            catch (Exception ex)
            {
                Utilize.Routines.ShowErrorMessageFa("اخطار", "دستور اجرایی با خطا روبرو شده است.", ex.Message,
                                                    MyDialogButton.OK);
            }
            finally
            {
                ProgressBox.Hide();
            }

        }

        private void GetLimit()
        {
            int numColumns = dtGAP.Columns.Count;
            DataTable dt = gap.GetGapLimit(curModelID);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int iCol = 1; iCol < numColumns - 1; iCol++)
                {
                    if (dtGAP.Columns[iCol].ColumnName.StartsWith("TB"))
                    {
                        if (iCol == int.Parse(dt.Rows[i]["ColumnIndex"].ToString()))
                        {
                            summaryDRow2LimitUp[iCol] = (decimal) dt.Rows[i]["LimitUp"];
                            summaryDRow2LimitDown[iCol] = (decimal) dt.Rows[i]["LimitDown"];
                        }
                    }
                }
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

                DataGridViewColumn col = dgvGAP.Columns["TB" + tei.ID];
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
                        //dgvGAP.
                    else
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    col.DefaultCellStyle.Format = "###,###.##";

                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    if (chkColor.Checked)
                        col.HeaderCell.Style.BackColor = Color.FromArgb(tei.BucketColor);
                }
            }
            var col2 = dgvGAP.Columns["Status_Desc"];
            if (col2 != null)
            {
                col2.HeaderText = "وضعیت";
                col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col2.SortMode = DataGridViewColumnSortMode.NotSortable;
                if (chkColor.Checked)
                    col2.HeaderCell.Style.BackColor = Color.Azure;
            }

            col2 = dgvGAP.Columns["type2"];
            if (col2 != null)
            {
                col2.HeaderText = "نوع گپ";
                col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col2.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            col2 = dgvGAP.Columns["Currency_Description"];
            if (col2 != null)
            {
                col2.HeaderText = "ارز";
                col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col2.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            col2 = dgvGAP.Columns["Counterparty_Type_Desc"];
            if (col2 != null)
            {
                col2.HeaderText = "نوع مشتری";
                col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col2.SortMode = DataGridViewColumnSortMode.NotSortable;


                col2.HeaderCell.Style.BackColor = Color.BlueViolet;
            }

            foreach (DataGridViewColumn dgvc in dgvGAP.Columns)
            {
                if (dgvc.Tag is TBMElementInfo)
                {
                }
                else if (dgvc.DataPropertyName == "Status_Desc" || dgvc.DataPropertyName == "type2"
                    || dgvc.DataPropertyName == "Currency_Description" || dgvc.DataPropertyName == "Counterparty_Type_Desc")
                {
                }
                else if (dgvc.DataPropertyName == "FSME_GroupName")
                {
                    dgvc.Frozen = true;
                    dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvc.MinimumWidth = 200;
                    dgvc.HeaderText = "";
                }

                else if (dgvc.DataPropertyName == "Total")
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

            dgvGAP.ColumnHeadersHeight = 40;

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

                maxWidth = (w*len > maxWidth) ? w*len : maxWidth;
            }

            return maxWidth;
        }

        private int GetColumnWidthProportional(TBMElementInfo tei, int maxWidthValue)
        {
            int len = tei.BucketLength;
            int w = tbOption.GetBucketWidth(tei.BucketType);
            return Convert.ToInt32(
                (tbOption.MaxBoxWidth - tbOption.MinBoxWidth)
                *(w*len*1.0 - 1.0)
                /(maxWidthValue - 1.01) + tbOption.MinBoxWidth);
        }

        private void @PrepareSummary()
        {
            totalDColumn = dtGAP.Columns["Total"];
            int numColumns = dtGAP.Columns.Count;

            for (int r = 0; r <= dtGAP.Rows.Count - 1; r++)
                //for (int r = 0; r <= dtGAP.Rows.Count - 3; r++)
                dtGAP.Rows[r][totalDColumn] = 0;

            for (int iCol = 1; iCol < numColumns - 1; iCol++)
            {
                if (dtGAP.Columns[iCol].ColumnName.StartsWith("TB"))
                {
                    string columnName = dtGAP.Columns[iCol].ColumnName;
                    DataGridViewColumn dgvc = dgvGAP.Columns[columnName];
                    bool bIrr = false;
                    foreach (DataGridViewColumn col in irrCols)
                        if (col.DataPropertyName == columnName)
                            bIrr = true;

                    summaryDRow1[iCol] = 0;
                    summaryDRow2[iCol] = 0;
                    summaryDRow2Limit[iCol] = 0;
                    summaryDRow2LimitUp[iCol] = 0;
                    summaryDRow2LimitDown[iCol] = 0;

                    for (int iRow = 0; iRow <= dtGAP.Rows.Count - 1 - CTE_NumSumNodes; iRow++)
                    {
                        int AL = (int) dtGAP.Rows[iRow]["FSME_AL"];
                        if (AL != -1)
                        {
                            if (AL == (int) EAL.Asset)
                                summaryDRow1[iCol] = (decimal) summaryDRow1[iCol] +
                                                     (+1)*(decimal) dtGAP.Rows[iRow][iCol];
                            if (AL == (int) EAL.Liability)
                                summaryDRow1[iCol] = (decimal) summaryDRow1[iCol] +
                                                     (-1)*(decimal) dtGAP.Rows[iRow][iCol];

                            #region EDIT BY SHAHLA 91.06.08

                            if (AL == (int) EAL.LG_IRR)
                                summaryDRow1[iCol] = (decimal) summaryDRow1[iCol] +
                                                     (-1)*(decimal) dtGAP.Rows[iRow][iCol];
                            if (AL == (int) EAL.LC_CUR)
                                summaryDRow1[iCol] = (decimal) summaryDRow1[iCol] +
                                                     (-1)*(decimal) dtGAP.Rows[iRow][iCol];
                            if (AL == (int) EAL.LG_CUR)
                                summaryDRow1[iCol] = (decimal) summaryDRow1[iCol] +
                                                     (-1)*(decimal) dtGAP.Rows[iRow][iCol];

                            #endregion

                        }

                        if (dtGAP.Rows[iRow].IsNull(totalDColumn))
                            dtGAP.Rows[iRow][totalDColumn] = 0;

                        if ((bIrr && chkIrr.Checked) || !bIrr)
                            dtGAP.Rows[iRow][totalDColumn] = (decimal) dtGAP.Rows[iRow][totalDColumn] +
                                                             (decimal) dtGAP.Rows[iRow][iCol];
                    }

                    summaryDRow2[iCol] = (decimal) summaryDRow1[iCol] +
                                         ((iCol == 15) ? 0 : (decimal) summaryDRow2[iCol]);

                }
            }
            for (int iCol = 1; iCol < numColumns - 1; iCol++)
            {
                if (dtGAP.Columns[iCol].ColumnName.StartsWith("TB"))
                {
                    if ((decimal) dtGAP.Rows[0]["Total"] != 0)
                        summaryDRow2Limit[iCol] = ((decimal) summaryDRow2[iCol]/(decimal) dtGAP.Rows[0]["Total"])*100;
                }
            }

            summaryDRow1["Hidden"] = 0;
            summaryDRow2["Hidden"] = 0;
            summaryDRow2Limit["Hidden"] = 0;
            summaryDRow2LimitUp["Hidden"] = 0;
            summaryDRow2LimitDown["Hidden"] = 0;

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
           
            {
                DataGridView dgv = new DataGridView();

                if (dgvGAP.DataSource != null)
                {
                    foreach (DataGridViewColumn c1 in dgvGAP.Columns)
                    {
                        DataGridViewColumn c2 = (DataGridViewColumn) c1.Clone();
                        dgv.Columns.Add(c2);
                    }

                    int i = 0;
                    foreach (DataGridViewRow dgvr in dgvGAP.Rows)
                    {
                        DataGridViewRow r = (DataGridViewRow) dgvr.Clone();
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
            clsERMSGeneral.strHelp = "Gap";
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
            dtGAP.RejectChanges();

            foreach (DataGridViewRow row in dgvGAP.Rows)
            {
                foreach (DataGridViewColumn col in dgvGAP.Columns)
                    if (col.Index != 0 && col.Visible)
                        try
                        {
                            row.Cells[col.Name].Value = (decimal) row.Cells[col.Name].Value/scale;
                        }
                        catch
                        {
                        }
            }
        }

        private void chkAutoSize_CheckedChanged(object sender, EventArgs e)
        {
            int tbModelID = (int) cmbTBM.SelectedValue;
            DataTable dtTBElements = tbm.GetTBMelements(tbModelID);
            int maxColumnWidth = GetColumnMaxWidthProportional(dtTBElements);
            foreach (DataGridViewColumn col in dgvGAP.Columns)
            {
                if (col.DataPropertyName.StartsWith("TB"))
                    if (!chkAutoSize.Checked)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        col.Width = GetColumnWidthProportional((TBMElementInfo) col.Tag, maxColumnWidth);
                    }
                    else
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
            }
        }

        private void Btn_GAP_FullScr_Click(object sender, EventArgs e)
        {
            if (lsvModel.SelectedItems.Count == 0)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("لطفاً یك مدل تحلیل شکاف انتخاب یا ایجاد كنید", "مدل",
                                                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ReLoad();
            //// int limitID = cmbLimit.SelectedIndex;
            ////string limitDetails = cmbLimitValue.SelectedValue.ToString();

            //if (curModelID == -1)
            //    return;

            //if (cmbFSM.SelectedIndex == -1 || cmbCBM.SelectedIndex == -1 || cmbTBM.SelectedIndex == -1)
            //{
            //    Presentation.Public.Routines.ShowMessageBoxFa(
            //        "تحلیل شکاف در یك مدل ترازنامه، بسته زمانی و مدل اقلام بدون سررسید اجرا می شود. مدلهای مناسب را انتخاب كرده و دوباره اجرا كنید",
            //        "تحليل شکاف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
            //    int gapModelID = (int) curModelID;
            //    int tbModelID = (int) cmbTBM.SelectedValue;
            //    int currencyID = (int) cmbCurrency.SelectedValue;
            //    int unitIndex = cmbUnit.SelectedIndex;
            //    int fsModelID = (int) cmbFSM.SelectedValue;
            //    int cbModelID = (int) cmbCBM.SelectedValue;
            //    int viewModeID = (int) cmbValType.SelectedIndex + 1;

            //    //PersianTools.Dates.PersianDate p1;
            //    //p1 = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            //    //DateTime startDate = DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));


            //    int unitID = (int) cmbUnit.SelectedIndex;
            //    bool bAutoSize = (bool) chkAutoSize.Checked;
            //    bool bIrr = (bool) chkIrr.Checked;
            //    bool bDescreteGapAnalisys = (bool) chkDescreteGapAnalisys.Checked;
            //    ///
            //    //int limitIndex = cmbLimit.SelectedIndex ;
            //    //string limitValue;
            //    //if (cmbLimitValue.SelectedValue == null)
            //    //     limitValue = "";
            //    //else
            //    //     limitValue = cmbLimitValue.SelectedValue.ToString();
            //    ///
            //    int limitIndex = -1;
            //    string limitValue = string.Empty;

            //    if (bDescreteGapAnalisys)
            //    {
            //        limitIndex = cmbLimit.SelectedIndex;
            //        limitValue = cmbLimitValue.SelectedValue.ToString();
            //    }
            //    ////
            //    frmGAP fx = new frmGAP();
            //    fx.WindowState = FormWindowState.Maximized;

            //    fx.Init();

            //    fx.FlagFullMode = 1;
            //    fx.StartDateFullMode = fdpStartDate.SelectedDateTime; // startDate;

            //    drGAPD = gap.GetGAPD(gapModelID);
            //    if (drGAPD["FSModelID"].ToString() == "-1" || drGAPD["TBModelID"].ToString() == "-1" ||
            //        drGAPD["CBModelID"].ToString() == "-1")
            //    {
            //        Presentation.Public.Routines.ShowMessageBoxFa("لطفا ابتدا مدل شكاف خود را ذخیره كنيد", "هشدار",
            //                                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            //        fx.SetFullMode();

            //        fx.Reload(gapModelID, tbModelID, currencyID, unitIndex, fsModelID, cbModelID, viewModeID, unitID,
            //                  bAutoSize, bDescreteGapAnalisys, limitIndex, limitValue, fdpStartDate.SelectedDateTime
            //            /*startDate*/);

            //        fx.RefreshChart(curModelID, bIrr);
            //        fx.ShowDialog();
            //        System.Windows.Forms.Cursor.Current = Cursors.Default;
            //    }
            //}
        }

        public void SetFullMode()
        {
            //hgr
            //scAll.Panel1Collapsed = true;
            //spc4All.Panel1Collapsed = true;
            //tabControl1.Dock = DockStyle.Fill;
            TagFullMode = true;

        }

        private void frmGAP_KeyDown(object sender, KeyEventArgs e)
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
                    Presentation.Public.Routines.ShowMessageBoxFa("ابتدا مدل را ايجاد كنيد", "مدل", MessageBoxButtons.OK,
                                                                  MessageBoxIcon.Exclamation);
                    return;
                }
                ReLoad();
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            lsvModel.Clear();

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader {Width = lsvModel.Width - 5};
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;
            RebindAll();
            FillModel();
        }

        private void tsmiPrint_Click(object sender, EventArgs e)
        {
            if (TagFullMode)
            {
                DoPrint();
                Printer P = new Printer();
                if (P.SetupThePrinting(clsERMSGeneral.dgvActive))
                    P.PrintDocument();
            }
        }

        private void tsmiExport_Click(object sender, EventArgs e)
        {
            if (TagFullMode)
            {
                DoPrint();
                Export ex = new Export();
                ex.ExportDocument(clsERMSGeneral.dgvActive);
            }
        }

        private void RefreshChart()
        {
            ddChart.Series.Clear();
            ddChart.Series.Add("Series1");

            ddChart.Series["Series1"].ValueMemberX = "Row";
            ddChart.Series["Series1"].ValueMembersY = "Row";
            ddChart.Series["Series1"].XValueType = ChartValueTypes.Int;
            ddChart.Series["Series1"].YValuesPerPoint = 1;

            ddChart.DataSource = new GapDS().GetDT();
            ddChart.DataBind();
        }
        private void RefreshChart(DataTable DT)
        {
            ddChart.Series.Clear();
            ddChart.Series.Add("Series1");

            ddChart.Series["Series1"].Type = SeriesChartType.StackedColumn;

            ddChart.Series["Series1"].ValueMemberX = "X";
            ddChart.Series["Series1"].ValueMembersY = "Y1";
            ddChart.Series["Series1"].XValueType = ChartValueTypes.Int;
            ddChart.Series["Series1"].YValuesPerPoint = 1;
            ddChart.Series["Series1"].ShowInLegend = false;
            ddChart.Series["Series1"].LegendText = "دارایی";

            ddChart.DataSource = DT;
            ddChart.DataBind();

            ddChart.Series["Series1"].XValueIndexed = true;

            ddChart.Series["Series1"]["DrawingStyle"] = "Cylinder";

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

            ddChart.Palette = ChartColorPalette.Dundas;
        }

        private void RefreshStyleChart(DataTable DT)
        {
            ddChart.Series.Clear();
            ddChart.Series.Add("Series1");
            ddChart.Series.Add("Series2");

            ddChart.Series["Series1"].Type = SeriesChartType.StackedColumn;
            ddChart.Series["Series2"].Type = SeriesChartType.StackedColumn;

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

            ddChart.DataSource = DT;
            ddChart.DataBind();

            ddChart.Series["Series1"].XValueIndexed = true;
            ddChart.Series["Series2"].XValueIndexed = true;

            ddChart.Series["Series1"]["DrawingStyle"] = "Cylinder";
            ddChart.Series["Series2"]["DrawingStyle"] = "Cylinder";

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

        private void cmbLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lsvState.Items.Clear();
            if (cmbLimit.SelectedIndex == 0)
            {
                lblDesretionType.Text = "استان";
                btnList.Enabled = true;
                chkAll.Enabled = true;
                chkAll.Enabled = false;
            }
            else
            {
                lblDesretionType.Text = "بخش";
                btnList.Enabled = false;
                ucfOrganization.Enabled = false;
            }
            if (cmbLimit.SelectedValue.ToString() != "System.Data.DataRowView")

                FillDest(cmbLimit.SelectedValue.ToString());


        }

        private void FillDest(string TableName)
        {
            string str = "TableNameEnglish like '" + TableName + "' ";
            DataRow[] dr = dtTableXml.Select(str);
            branch =
                new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(
                    ERMS.Model.GlobalInfo.UserID);

            string strField = dr[0]["Field"].ToString();
            string strId = dr[0]["Id"].ToString();
            string strTable_Name = TableName + "." + strId;

            lm = new LM();
            DataTable dtDest = lm.GetTable(strId, strField, TableName);

            if (branch.Rows.Count != 0)
            {
                if (strId.Equals("State_Id"))
                {
                    var dt = dtDest.Rows.Cast<DataRow>().Where(
                        org =>
                        branch.Rows.Cast<DataRow>().Any(
                            sta => sta["State_Id"].ToString().Equals(org["State_Id"].ToString())));

                    cmbLimitValue.DataSource =
                        dt.Select(
                            item =>
                            new {State_Id = item["State_Id"].ToString(), State_Name = item["State_Name"].ToString()}).
                            ToList();
                }
                if (strId.Equals("Branch"))
                {
                    var dt = dtDest.Rows.Cast<DataRow>().Where(
                        org =>
                        branch.Rows.Cast<DataRow>().Any(
                            sta => sta["Branch"].ToString().Equals(org["Branch"].ToString())));

                    cmbLimitValue.DataSource =
                        dt.Select(
                            item =>
                            new
                                {
                                    Branch = item["Branch"].ToString(),
                                    Branch_Description = item["Branch_Description"].ToString()
                                }).ToList();
                }

            }
            else
                cmbLimitValue.DataSource = dtDest;

            cmbLimitValue.DisplayMember = strField;
            cmbLimitValue.ValueMember = strId;
            cmbLimitValue.SelectedIndex = -1;
        }


        private void chkDescreteGapAnalisys_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescreteGapAnalisys.Checked)
            {
                cmbLimit.Enabled = true;
                cmbLimitValue.Enabled = true;
                cmbLimitValue.SelectedIndex = -1;
            }
            else
            {

                cmbLimit.Enabled = false;
                cmbLimitValue.Enabled = false;
                cmbLimitValue.SelectedIndex = -1;
                ucfOrganization.Enabled = false;

            }

        }


        // Save in Final Report of Gap
        private void tsbfinalSave_Click(object sender, EventArgs e)
        {

            SaveReport(curModelID, true);
        }

        private bool CheckExists(int modelID, int fsModelID, int tbModelID, int cbModelID)
        {
            DataTable dt = gap.GetGAPDTReport(modelID);
            bool flag = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                if (int.Parse(dt.Rows[i]["ModelID"].ToString()) == modelID &&
                    int.Parse(dt.Rows[i]["FSModelID"].ToString()) == fsModelID &&
                    int.Parse(dt.Rows[i]["TBModelID"].ToString()) == tbModelID &&
                    int.Parse(dt.Rows[i]["CBModelID"].ToString()) == cbModelID &&
                    DateTime.Parse(dt.Rows[i]["ReportDate"].ToString()).ToShortDateString() ==
                    fdpStartDate.SelectedDateTime.ToShortDateString())
                    // DateTime.Today.ToShortDateString())
                {
                    flag = true;
                }
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
                int fsModelID = (cmbFSM.SelectedIndex == -1) ? -1 : (int) cmbFSM.SelectedValue;
                int tbModelID = (cmbTBM.SelectedIndex == -1) ? -1 : (int) cmbTBM.SelectedValue;
                int cbModelID = (cmbPM.SelectedIndex == -1) ? -1 : (int) cmbPM.SelectedValue;
                int viewModeID = (int) cmbValType.SelectedIndex + 1;

                // add for farsi date
                //PersianTools.Dates.PersianDate p1;
                //p1 = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                //DateTime startDate = DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));

                //if (!CheckExists(modelID, fsModelID, tbModelID, cbModelID))
                //{

                bool bIrr = chkIrr.Checked;

                GAPDInfo GAPdInfo = (GAPDInfo) lsvModel.SelectedItems[0].Tag;
                GAPReportInfo gi = new GAPReportInfo();
                gi.ModelID = modelID;
                var mName = new Utilize.frmInputText() {Text = "نام مدل"};
                mName.ShowDialog();
                gi.ModelName = GAPdInfo.ModelName + " - " +
                               (string.IsNullOrEmpty(mName.ReturnValue) ? "بدون عنوان" : mName.ReturnValue);
                gi.TBModelID = tbModelID;
                gi.CBModelID = cbModelID;
                gi.FSModelID = fsModelID;
                gi.StartDate = fdpStartDate.SelectedDateTime; //startDate;
                gi.IrrActive = bIrr;

                CurrentReportID = gap.InsertGAPReport(gi);
                SaveReportElement(CurrentReportID, curModelID);

                if (bMessage)
                    Presentation.Public.Routines.ShowMessageBoxFa(" مدل شما به تاريخ " + Strdate + "ذخیره شد ", "ذخیره",
                                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    Routines.ShowMessageBoxFa(" مدل شما به تاريخ " + Strdate + "وجود دارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
        }

        private void SaveReportElement(decimal CurrentReportID, int curModelID)
        {

            gap.InsertGAPElementReport(CurrentReportID, curModelID);
        }

     

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbLimit.Enabled == false)
                    return;
                if (!(cmbLimitValue.SelectedIndex != -1 && chkAll.Checked == true))
                {

                    //lsvState.Clear();
                    Presentation.Tabs.AssetDebtManagement.frmlist frm =
                        new Presentation.Tabs.AssetDebtManagement.frmlist();
                    frm.LimitID = cmbLimit.SelectedIndex;

                    if (chkAll.Checked)
                        frm.Type = 1;
                    else
                    {
                        frm.Type = 2;
                        frm.StateID = cmbLimitValue.SelectedValue.ToString().Trim();
                    }
                    // frm.Show();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        limitDetails = frm.strLimitDetail;

                        foreach (DataRow dr in frm.dtSelected.Rows)
                        {
                            //lsvState.Items.Add(dr[0].ToString().Trim());

                        }
                    }
                }
            }
            catch (Exception exception)
            {
                if (cmbLimitValue.SelectedIndex == -1)
                    Utilize.Routines.ShowErrorMessageFa("خطا", "لطفاً ابتدا استان مورد نظر را انتخاب نمایید.",
                                                        MyDialogButton.OK);
                else
                    Utilize.Routines.ShowErrorMessageFa("خطا", "در اجرای دستور شما،خطا رخ داده است", exception.Message,
                                                        MyDialogButton.OK);
            }

        }

        private void cmbLimitValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkAll.Checked = false;
            ucfOrganization.DataSource = null;
            ucfOrganization.ResetText();
            if (cmbLimit.SelectedIndex == 0 && cmbLimitValue.SelectedIndex != -1)
            {
                ucfOrganization.Enabled = true;
            }
            else if (cmbLimit.SelectedIndex == 0 && cmbLimitValue.SelectedIndex == -1)
                ucfOrganization.Enabled = false;
        }

        private void chkAll_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void grpParam_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModel_CButtonClicked(object sender, EventArgs e)
        {
            if (splitContainer4.Panel1Collapsed == false)
            {
                splitContainer4.Panel1Collapsed = true;
                btnModel.DefaultImage = Properties.Resources.S_Panleft2;
                btnModel.HoverImage = Properties.Resources.S_Panleft_Hover2;
            }
            else if (splitContainer4.Panel1Collapsed == true)
            {
                splitContainer4.Panel1Collapsed = false;
                btnModel.DefaultImage = Properties.Resources.S_PanRight3;
                btnModel.HoverImage = Properties.Resources.S_PanRight_Hover;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Enabled == true)
            //    cmbLimit.Enabled = true;
            //else
            //    cmbLimit.Enabled = false;
        }

        private void ucfOrganization_DropDownOpening(object sender, EventArgs e)
        {
            try
            {
                if (cmbLimit.SelectedIndex == 0)
                {
                    if (user.Rows.Count == 0)
                    {
                        var state =
                            new DAL.Table_DataSetTableAdapters.StateTableAdapter().GetId(
                                cmbLimitValue.SelectedItem.ToString());
                        var branch =
                            new DAL.Table_DataSetTableAdapters.OrganizationTableAdapter().GetDataByStateID(
                                state.ToString());

                        ucfOrganization.DisplayMember = "Branch_Description";
                        ucfOrganization.ValueMember = "Branch";
                        ucfOrganization.DataSource = branch;
                    }
                    else
                    {

                        var branch =
                            new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(
                                ERMS.Model.GlobalInfo.UserID);

                        ucfOrganization.DisplayMember = "Branch_Description";
                        ucfOrganization.ValueMember = "Branch";
                        ucfOrganization.DataSource = branch;
                        ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;
                    }
                }

            }
            catch (Exception exception)
            {
                Utilize.Routines.ShowErrorMessageFa("خطا", "در اجرای دستور شما،خطا رخ داده است", exception.Message,
                                                    MyDialogButton.OK);
            }
        }



        private void SetDGVCelColor()
        {
            //int i = 0;
            falgLimit = true;
            foreach (DataGridViewColumn dgvCol in dgvGAP.Columns)
            {
                if (dgvCol.Name.Contains("TB"))
                {
                    foreach (DataGridViewRow dgvRow in dgvGAP.Rows)
                    {

                        if (dgvRow.Index == dgvGAP.RowCount - 3 &&
                            dgvGAP.Rows[dgvGAP.RowCount - 3].Cells[dgvCol.Name].Value != null &&
                            dgvGAP.Rows[dgvGAP.RowCount - 2].Cells[dgvCol.Name].Value != null &&
                            dgvGAP.Rows[dgvGAP.RowCount - 1].Cells[dgvCol.Name].Value != null)
                        {
                            int GapLimit = Convert.ToInt32(dgvGAP.Rows[dgvGAP.RowCount - 3].Cells[dgvCol.Name].Value);
                                //حد مثبت
                            GapUpLimit = Convert.ToInt32(dgvGAP.Rows[dgvGAP.RowCount - 2].Cells[dgvCol.Name].Value);
                                //حد مثبت
                            GapdownLimit = Convert.ToInt32(dgvGAP.Rows[dgvGAP.RowCount - 1].Cells[dgvCol.Name].Value);
                                //منفی


                            if (GapdownLimit < GapLimit && GapLimit < GapUpLimit)
                            {
                                //dgvGAP.CurrentCell = dgvRow.Cells[dgvCol.Name];
                                //dgvGAP.BeginEdit(true);
                                dgvRow.Cells[dgvCol.Name].Style.BackColor = Color.GreenYellow;
                                //dgvGAP.EndEdit();
                            }
                            else
                            {
                                //dgvGAP.CurrentCell = dgvRow.Cells[dgvCol.Name];
                                //dgvGAP.BeginEdit(true);
                                dgvRow.Cells[dgvCol.Name].Style.BackColor = Color.Red;
                                //dgvGAP.EndEdit();
                            }
                        }
                    }
                }
            }
            dgvGAP.EndEdit();
            dgvGAP.Refresh();
            //dgvGAP.Update();
        }

        private void cButton1_CButtonClicked(object sender, EventArgs e)
        {
            SetDGVCelColor();
        }

        private void dgvGAP_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewColumn dgvCol in dgvGAP.Columns)
            {
                if (dgvCol.Visible)
                {
                    dgvCol.Width += 50;
                }
            }
        }



        private string GetFilterBranchG()
        {
            var fil_Organization = ucfOrganization.GetFilterStructureForSqlBranchG();

            bool isColl_Filter = false;
            var filter = "";
            if (fil_Organization.Trim().Length != 0)
            {
                if (filter.Trim().Length != 0) filter += " and ";
                filter += fil_Organization;
            }
            else if (user.Rows.Count != 0)
            {
                string fil = "";
                var organizationNew_DataTable =
                    user.Rows.Cast<DataRow>().Select(
                        item =>
                        new
                            {
                                Brach_Id = item["Branch"].ToString(),
                                Branch_Description = item["Branch_Description"].ToString()
                            }).Distinct().ToArray();
                foreach (var item in organizationNew_DataTable)
                {


                    fil += fil.Trim().Length == 0
                               ? "Branch = " + "'" + item.Brach_Id.Trim() + "' "
                               : " OR Branch = '" + item.Brach_Id.Trim() + "' ";

                }
                if (fil.Trim().IsNullOrEmptyByTrim() == false)
                    fil += "";

                if (filter.Trim().Length != 0) filter += " and ";
                filter += fil;

            }



            return filter;

        }

        private void ctxGap_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

       

        private void panel2_Click(object sender, EventArgs e)
        {
             var gapModelID = ((GAPDInfo) lsvModel.SelectedItems[0].Tag).ID;
                var fsModelID = (int) cmbFSM.SelectedValue;
                var tbModelID = (int) cmbTBM.SelectedValue;
                var cbModelID = (int) cmbPM.SelectedValue;
                var currencyID = (int) cmbCurrency.SelectedValue;
                var viewModeID = (int) cmbValType.SelectedIndex + 1;

                var bIrr = chkIrr.Checked;


                // barresi mishavad ke tafkiki entekhab shode ya na
                var IsSeperate = chkDescreteGapAnalisys.Checked;

                limitID = -1;


                MessageBox.Show(" gapModelID: " + gapModelID.ToString() + "    fsModelID: " + fsModelID.ToString() + "    tbModelID: " + tbModelID.ToString()
                                    + "     cbModelID: " + cbModelID.ToString() + "    fdpStartDate: " + fdpStartDate.SelectedDateTime.ToString() +
                                            " bIrr: " + bIrr.ToString() + "  viewModeID" + viewModeID.ToString() + "    currencyID:  " + currencyID.ToString() +
                                            "   limitDetails: " + limitDetails.ToString() + "   limitID: " + limitID.ToString() + "   IsSeperate: " + IsSeperate.ToString());
        }

        private void rdbHistoric_CheckedChanged(object sender, EventArgs e)
        {
            fdpStartDate.Enabled = rdbHistoric.Checked;
        }

        private void cmbCurrency_SelectionChanged(object sender, EventArgs e)
        {
            //if ((int)cmbCurrency.SelectedValue == 20)
            //{
            //    chkCurrencyMarketValue.Enabled = true;
            //}
            //else
            //{
            //    chkCurrencyMarketValue.Enabled = false;
            //    chkCurrencyMarketValue.Checked = false;
            //}
        }
        private void cbExcel_Click(object sender, EventArgs e)
        {
           

        }

        private void btnReload_Load(object sender, EventArgs e)
        {

        }

        private void cmbFSM_ValueChanged(object sender, EventArgs e)
        {
            RebindCBM();
        }

       private void cbExcel_CButtonClicked(object sender, EventArgs e)
       {
           //FillGap(true);
           

           #region Vars

           List<TableTemplate> TableTemplates = new List<TableTemplate>();
           List<RowTemplate> RowTemplatesTashilat = new List<RowTemplate>();
           List<RowTemplate> RowTemplatesMoghayeratTashilat = new List<RowTemplate>();
           TableTemplates.Add(new TableTemplate
                                  {
                                      DataSetIndex = 0,
                                      Name = "ريز گپ",
                                      SheetIndex = 2,
                                      FirstRow = 1,
                                      FirstCol = 1,
                                      isEnable = true

                                  });
           TableTemplates.Add(new TableTemplate
                                  {
                                      DataSetIndex = 0,
                                      Name = "ريز سپرده",
                                      SheetIndex = 3,
                                      FirstRow = 1,
                                      FirstCol = 6,
                                      isEnable = true

                                  });
           TableTemplates.Add(new TableTemplate
                                  {
                                      DataSetIndex = 0,
                                      Name = "ريز تسهيلات",
                                      SheetIndex = 4,
                                      FirstRow = 1,
                                      FirstCol = 4,
                                      isEnable = true

                                  });
           TableTemplates.Add(new TableTemplate
                                  {
                                      DataSetIndex = 0,
                                      Name = "مغايرت تسهيلات",
                                      SheetIndex = 5,
                                      FirstRow = 2,
                                      FirstCol = 4,
                                      isEnable = true

                                  });

           TableTemplates.Add(new TableTemplate
                                  {
                                      DataSetIndex = 0,
                                      Name = "Other",
                                      SheetIndex = 6,
                                      FirstRow = 1,
                                      FirstCol = 3,
                                      isEnable = true

                                  });
           TableTemplates.Add(new TableTemplate
                                  {
                                      DataSetIndex = 0,
                                      Name = "تراز",
                                      SheetIndex = 1,
                                      FirstRow = 2,
                                      FirstCol = 1,
                                      isEnable = true

                                  });

           TableTemplates.Add(new TableTemplate
                                  {
                                      DataSetIndex = 0,
                                      Name = "سود سالهاي آينده",
                                      SheetIndex = 8,
                                      FirstRow = 1,
                                      FirstCol = 1,
                                      isEnable = true

                                  });

           var index = 0;
           const int GROUP_NAME_COLUMN = 0;
           const int STATUS_COLUMN = 12;
           const int CURRENCY_COLUMN = 13;
           var path = GlobalInfo.appPath + "\\Gap_Template.xlsx";
           var path2 = GlobalInfo.appPath + "\\Gap_Template2.xlsx";
           if (saveFileDialog1.ShowDialog() != DialogResult.OK)
               return;
           ProgressBox.Show();
           path2 = saveFileDialog1.FileName;

           #endregion)

           using (var workbook = new XLWorkbook(path))
           {
               // load the existing excel file
               //foreach (var a in workbook.Worksheets)
               //{
               //    a.RightToLeft = true;
               //}

               #region   ريز گپ

               //////////////////////////////////////////////////////////   ريز گپ
               var st = TableTemplates[index++];
               if (st.isEnable)
               {
                   int col = 0;
                   var ws = workbook.Worksheets.Worksheet(st.SheetIndex);
                   for (int i = 0; i < dgvGAP.Columns.Count; i++)
                       if (dgvGAP.Columns[i].Visible)
                           ws.Cell(st.FirstRow, st.FirstCol + col++).SetValue(
                               dgvGAP.Columns[i].HeaderCell.Value.ToString());

                   for (int j = 0; j < dgvGAP.Rows.Count; j++)
                   {
                       col = 0;
                       for (int i = 0; i < dgvGAP.Columns.Count; i++)
                           if (dgvGAP.Columns[i].Visible)
                               //ws.Cell(st.FirstRow + j + 1, st.FirstCol + col++)/
                               ws.Cell(st.FirstRow + j + 1, st.FirstCol + col++).SetValue(dgvGAP.Rows[j].Cells[i].Value);
                   }
               }

               #endregion

               #region ريز سپرده

               ///////////////////////////////////////////////////////////   ريز سپرده

               st = TableTemplates[index++];
               if (st.isEnable)
               {
                   int col = 0;
                   var ws = workbook.Worksheets.Worksheet(st.SheetIndex);
                   for (int i = 0; i < dgvGAP.Columns.Count; i++)
                   {
                       if (
                           new[] {"سررسیدگذشته", "معوق", "مشکوک الوصول"}.Contains(
                               dgvGAP.Columns[i].HeaderCell.Value.ToString()))
                           continue;
                       if (dgvGAP.Columns[i].Name.StartsWith("TB"))
                           ws.Cell(st.FirstRow, st.FirstCol + col++).SetValue(
                               dgvGAP.Columns[i].HeaderCell.Value.ToString());
                   }

                   col = -1;
                   for (int j = 0; j < dgvGAP.Columns.Count; j++)
                   {

                       if (dgvGAP.Columns[j].Name.StartsWith("TB"))
                       {
                           if (
                               new[] {"سررسیدگذشته", "معوق", "مشکوک الوصول"}.Contains(
                                   dgvGAP.Columns[j].HeaderCell.Value.ToString()))
                               continue;
                           col++;
                           for (int i = 0; i < dgvGAP.Rows.Count; i++)
                           {
                               if (
                                   (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Equals(
                                       "سپرده بلند مدت يکساله") ||
                                    dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Equals("يکساله-مسدودي"))
                                   &&
                                   dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("مجموع ريالي ارزي ها"))
                               {
                                   var cellValue = ws.Cell(2, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(2, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                          decimal.Parse(cellValue));
                               }
                               if (
                                   (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Equals(
                                       "سپرده بلند مدت يکساله") ||
                                    dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Equals("يکساله-مسدودي"))
                                   && dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران"))
                               {
                                   var cellValue = ws.Cell(3, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(3, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                          decimal.Parse(cellValue));
                               }
                               if (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains("سپند")
                                   && dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران"))
                               {
                                   var cellValue = ws.Cell(5, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(5, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                          decimal.Parse(cellValue));
                               }
                               if (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains("دو سال")
                                   && dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران"))
                               {
                                   var cellValue = ws.Cell(7, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(7, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                          decimal.Parse(cellValue));
                               }
                               if (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains("سه سال")
                                   && dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران"))
                               {
                                   var cellValue = ws.Cell(9, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(9, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                          decimal.Parse(cellValue));
                               }
                               if (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains("چهار سال")
                                   && dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران"))
                               {
                                   var cellValue = ws.Cell(11, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(11, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                               if (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains("پنج سال")
                                   && dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران"))
                               {
                                   var cellValue = ws.Cell(13, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(13, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                               if (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                   "سپرده بلند مدت- گواهي سپرده")
                                   && dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران"))
                               {
                                   var cellValue = ws.Cell(15, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(15, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                               if ((dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                   "سپرده کوتاه مدت ويژه")
                                    ||
                                    dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                        "کوتاه مدت ويژه-مسدودي"))
                                   &&
                                   dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("مجموع ريالي ارزي ها"))
                               {
                                   var cellValue = ws.Cell(17, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(17, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                               if ((dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                   "سپرده کوتاه مدت ويژه")
                                    ||
                                    dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                        "کوتاه مدت ويژه-مسدودي"))
                                   && dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران"))
                               {
                                   var cellValue = ws.Cell(18, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(18, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                               if ((dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                   "سپرده هاي کوتاه مدت")
                                    ||
                                    dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                        "کوتاه مدت-مسدودي"))
                                   && dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران"))
                               {
                                   var cellValue = ws.Cell(21, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(21, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                               if ((dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                   "سپرده هاي کوتاه مدت")
                                    ||
                                    dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                        "کوتاه مدت-مسدودي"))
                                   &&
                                   dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("مجموع ريالي ارزي ها"))
                               {
                                   var cellValue = ws.Cell(20, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(20, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                               if (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains("مسدودي:2654+2691")
                                   &&
                                   dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("مجموع ريالي ارزي ها"))
                               {
                                   var cellValue = ws.Cell(23, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(23, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                               if (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains("مسدودي:2654+2691")
                                   && dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران"))
                               {
                                   var cellValue = ws.Cell(24, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(24, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                               if (
                                   dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                       "ساير سپرده ها ريالي"))
                               {
                                   var cellValue = ws.Cell(33, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(33, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                               if (
                                   dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                       "ساير سپرده ها-ارزي"))
                               {
                                   var cellValue = ws.Cell(32, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";
                                   if (st.FirstCol + col == 6) //فقط تراز
                                       ws.Cell(32, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*
                                                                               -1 +
                                                                               decimal.Parse(cellValue));
                               }
                               if (
                                   (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                       "سپرده قرض الحسنه جاري-ريالي") ||
                                    (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                        "قرض الحسنه جاري ريالي-مسدودي")))
                                   && dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران"))
                               {
                                   var cellValue = ws.Cell(30, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(30, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                               if (
                                   (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                       "سپرده قرض الحسنه جاري-ريالي") ||
                                    (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                        "قرض الحسنه جاري ريالي-مسدودي")))
                                   &&
                                   dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("مجموع ريالي ارزي ها"))
                               {
                                   var cellValue = ws.Cell(29, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(29, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                               if (
                                   (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                       "سپرده قرض الحسنه پس انداز-ريالي") ||
                                    (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                        "قرض الحسنه پس انداز ريالي-مسدودي")))
                                   && dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران"))
                               {
                                   var cellValue = ws.Cell(27, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(27, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                               if (
                                   (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                       "سپرده قرض الحسنه پس انداز-ريالي") ||
                                    (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                        "قرض الحسنه پس انداز ريالي-مسدودي")))
                                   &&
                                   dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("مجموع ريالي ارزي ها"))
                               {
                                   var cellValue = ws.Cell(26, st.FirstCol + col).GetValue<string>();
                                   if (string.IsNullOrEmpty(cellValue))
                                       cellValue = "0";

                                   ws.Cell(26, st.FirstCol + col).SetValue((decimal) dgvGAP.Rows[i].Cells[j].Value*-1 +
                                                                           decimal.Parse(cellValue));
                               }
                           }
                       }
                   }
               }

               #endregion

               #region ريز تسهيلات

               ///////////////////////////////////////////////////////////   ريز تسهيلات
               int u = 1;
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "ذخيره خاص مطالبات طبقات",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = ++u,
                   kahande = true
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "ذخيره مطالبات مشکوک الوصول",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = ++u,
                   kahande = true
               });
               ++u;
               ++u;
               //RowTemplatesTashilat.Add(new RowTemplate
               //{
               //    GroupName = "سود سال هاي آينده",
               //    isCurrency = false,
               //    onlyThreeStatus = false,
               //    Row = ++u,
               //    kahande = true
               //});
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "سود معوق",
                   isCurrency = true,
                   onlyThreeStatus = false,
                   Row = ++u,
                   kahande = true
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "سود معوق",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = ++u,
                   kahande = true
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "بستانکاران",
                   isCurrency = true,
                   onlyThreeStatus = false,
                   Row = ++u,
                   kahande = true
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "بستانکاران",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = ++u,
                   kahande = true
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "بدهکاران ارزي",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = ++u
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "بدهکاران ريالي",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = ++u
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "مطالبات مشکوک الوصول -ارز- غ د",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = ++u
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "مطالبات معوق - ارز - غ د",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = u
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "مطالبات سررسيد گذشته - ارز-غ د",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = u
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "مطالبات مشکوک الوصول- ع د",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = ++u
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "مطالبات معوق - غ د",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = u
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "مطالبات سررسيد گذشته- غ د",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = u
               });
               ++u;
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "جريمه تعهدي",
                   isCurrency = true,
                   onlyThreeStatus = false,
                   Row = ++u
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "جريمه تعهدي",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = ++u
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "سود تعهدي",
                   isCurrency = true,
                   onlyThreeStatus = false,
                   Row = ++u
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "سود تعهدي",
                   isCurrency = false,
                   onlyThreeStatus = false,
                   Row = ++u
               });
               ++u;
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "تسهيلات اعطايي - احاره به شرط تمليک - غ د",
                   isCurrency = false,
                   onlyThreeStatus = true,
                   Row = ++u
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "تسهيلات اعطايي - فروش اقساطي - غ د",
                   isCurrency = true,
                   onlyThreeStatus = true,
                   Row = ++u
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "تسهيلات اعطايي - فروش اقساطي - غ د",
                   isCurrency = false,
                   onlyThreeStatus = true,
                   Row = ++u
               });
               RowTemplatesTashilat.Add(new RowTemplate
               {
                   GroupName = "تسهيلات اعطايي - قرض الحسنه-غ  د",
                   isCurrency = false,
                   onlyThreeStatus = true,
                   Row = ++u
               });
                RowTemplatesTashilat.Add(new RowTemplate
                    {
                        GroupName = "تسهيلات اعطايي - مشارکت مدني - غ د",
                        isCurrency = true,
                        onlyThreeStatus = true,
                        Row = ++u
                    });
                RowTemplatesTashilat.Add(new RowTemplate
                    {
                        GroupName = "تسهيلات اعطايي - مشارکت مدني - غ د",
                        isCurrency = false,
                        onlyThreeStatus = true,
                        Row = ++u
                    });
                RowTemplatesTashilat.Add(new RowTemplate
                    {
                        GroupName = "تسهيلات اعطايي جعاله  - غ د",
                        isCurrency = true,
                        onlyThreeStatus = true,
                        Row = ++u
                    });
                RowTemplatesTashilat.Add(new RowTemplate
                    {
                        GroupName = "تسهيلات اعطايي جعاله  - غ د",
                        isCurrency = false,
                        onlyThreeStatus = true,
                        Row = ++u
                    });
                RowTemplatesTashilat.Add(new RowTemplate
                {
                    GroupName = "تسهيلات اعطايي مرابحه-غ د",
                    isCurrency = true,
                    onlyThreeStatus = true,
                    Row = ++u
                });
                RowTemplatesTashilat.Add(new RowTemplate
                {
                    GroupName = "تسهيلات اعطايي مرابحه-غ د",
                    isCurrency = false,
                    onlyThreeStatus = true,
                    Row = ++u
                });
                RowTemplatesTashilat.Add(new RowTemplate
                    {
                        GroupName = "تسهيلات اعطايي مضاربه - غ د",
                        isCurrency = false,
                        onlyThreeStatus = true,
                        Row = ++u
                    });
               RowTemplatesTashilat.Add(new RowTemplate
                    {
                        GroupName = "تسهيلات اعطايي خرید دین  - غ د",
                        isCurrency = false,
                        onlyThreeStatus = true,
                        Row = ++u
                    });
               RowTemplatesTashilat.Add(new RowTemplate
                    {
                        GroupName = "تسهيلات اعطايي - سلف - غ د",
                        isCurrency = false,
                        onlyThreeStatus = true,
                        Row = ++u
                    });
               st = TableTemplates[index++];
               if (st.isEnable)
               {
                   int col = 0;
                   var ws = workbook.Worksheets.Worksheet(st.SheetIndex);
                   for (int i = 0; i < dgvGAP.Columns.Count; i++)
                   {
                       if (
                           new[] {"سررسیدگذشته", "معوق", "مشکوک الوصول"}.Contains(
                               dgvGAP.Columns[i].HeaderCell.Value.ToString()))
                           continue;
                       if (dgvGAP.Columns[i].Name.StartsWith("TB"))
                           ws.Cell(st.FirstRow, st.FirstCol + col++).SetValue(
                               dgvGAP.Columns[i].HeaderCell.Value.ToString());
                   }
                   
                   col = -1;
                   for (int j = 0; j < dgvGAP.Columns.Count; j++)
                   {

                       if (dgvGAP.Columns[j].Name.StartsWith("TB"))
                       {
                           if (
                               new[] {"سررسیدگذشته", "معوق", "مشکوک الوصول"}.Contains(
                                   dgvGAP.Columns[j].HeaderCell.Value.ToString()))
                               continue;
                           col++;

                           foreach (var rowTemplate in RowTemplatesTashilat)
                           {
                               for (int i = 0; i < dgvGAP.Rows.Count; i++)
                               {
                                   if (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                       rowTemplate.GroupName)
                                       &&
                                       (!rowTemplate.onlyThreeStatus ||
                                        !new[] {"تصويب شده", "صدور قرارداد", "مشکوک الوصول"}.Contains(
                                            dgvGAP.Rows[i].Cells[STATUS_COLUMN].Value.ToString())))
                                   {
                                       if ((!rowTemplate.isCurrency &&
                                            dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران")) ||
                                           (rowTemplate.isCurrency &&
                                            !dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران") &&
                                            !dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals(
                                                "مجموع ريالي ارزي ها")))
                                       {
                                           decimal cellValue = 0;
                                           try
                                           {
                                               cellValue =
                                                   ws.Cell(rowTemplate.Row, st.FirstCol + col).GetValue<decimal>();
                                           }
                                           catch (Exception)
                                           {


                                           }

                                           //if (string.IsNullOrEmpty(cellValue))
                                           //    cellValue = "0";
                                           int sign = rowTemplate.kahande ? -1 : 1;

                                           ws.Cell(rowTemplate.Row, st.FirstCol + col).SetValue(
                                               (decimal) dgvGAP.Rows[i].Cells[j].Value*sign +
                                               (cellValue));
                                           //if (rowTemplate.Row == 17 && col==5)
                                           //{
                                           //    temp += (decimal) dgvGAP.Rows[i].Cells[j].Value;
                                           //    tt++;
                                           //}
                                       }
                                   }
                               }
                           }
                       }
                   }
               }

               #endregion

               #region مغايرت تسهيلات

               st = TableTemplates[index++];
               if (st.isEnable)
               {
                   u = 1;
                   RowTemplatesMoghayeratTashilat.Add(new RowTemplate
                   {
                       GroupName = "تسهيلات اعطايي - احاره به شرط تمليک - غ د",
                       isCurrency = false,
                       Row = ++u
                   });
                   RowTemplatesMoghayeratTashilat.Add(new RowTemplate
                   {
                       GroupName = "تسهيلات اعطايي - فروش اقساطي - غ د",
                       isCurrency = true,
                       Row = ++u
                   });
                   RowTemplatesMoghayeratTashilat.Add(new RowTemplate
                   {
                       GroupName = "تسهيلات اعطايي - فروش اقساطي - غ د",
                       isCurrency = false,
                       Row = ++u
                   });
                   RowTemplatesMoghayeratTashilat.Add(new RowTemplate
                   {
                       GroupName = "تسهيلات اعطايي - قرض الحسنه-غ  د",
                       isCurrency = false,
                       Row = ++u
                   });
                   RowTemplatesMoghayeratTashilat.Add(new RowTemplate
                   {
                       GroupName = "تسهيلات اعطايي - مشارکت مدني - غ د",
                       isCurrency = true,
                       Row = ++u
                   });
                   RowTemplatesMoghayeratTashilat.Add(new RowTemplate
                   {
                       GroupName = "تسهيلات اعطايي - مشارکت مدني - غ د",
                       isCurrency = false,
                       Row = ++u
                   });
                   RowTemplatesMoghayeratTashilat.Add(new RowTemplate
                   {
                       GroupName = "تسهيلات اعطايي جعاله  - غ د",
                       isCurrency = true,
                       Row = ++u
                   });
                   RowTemplatesMoghayeratTashilat.Add(new RowTemplate
                   {
                       GroupName = "تسهيلات اعطايي جعاله  - غ د",
                       isCurrency = false,
                       Row = ++u
                   });
                   RowTemplatesMoghayeratTashilat.Add(new RowTemplate
                   {
                       GroupName = "تسهيلات اعطايي مرابحه-غ د",
                       isCurrency = true,
                       Row = ++u
                   });
                   RowTemplatesMoghayeratTashilat.Add(new RowTemplate
                   {
                       GroupName = "تسهيلات اعطايي مرابحه-غ د",
                       isCurrency = false,
                       Row = ++u
                   });
                   RowTemplatesMoghayeratTashilat.Add(new RowTemplate
                   {
                       GroupName = "تسهيلات اعطايي مضاربه - غ د",
                       isCurrency = false,
                       Row = ++u
                   });

                   RowTemplatesMoghayeratTashilat.Add(new RowTemplate
                   {
                       GroupName = "تسهيلات اعطايي خرید دین  - غ د",
                       isCurrency = false,
                       Row = ++u
                   });

                   RowTemplatesMoghayeratTashilat.Add(new RowTemplate
                   {
                       GroupName = "تسهيلات اعطايي - سلف - غ د",
                       isCurrency = false,
                       Row = ++u
                   });


                   var wsTas = workbook.Worksheets.Worksheet(st.SheetIndex - 1);
                   var ws = workbook.Worksheets.Worksheet(st.SheetIndex);

                   for (int j = 0; j < dgvGAP.Columns.Count; j++)
                   {

                       if (dgvGAP.Columns[j].HeaderCell.Value.Equals("سایر"))
                       {

                           foreach (var rowTemplate in RowTemplatesMoghayeratTashilat)
                           {
                               for (int i = 0; i < dgvGAP.Rows.Count; i++)
                               {
                                   if (dgvGAP.Rows[i].Cells[GROUP_NAME_COLUMN].Value.ToString().Contains(
                                       rowTemplate.GroupName)
                                       &&
                                       (new[] {"سررسيدگذشته", "معوق"}.Contains(
                                           dgvGAP.Rows[i].Cells[STATUS_COLUMN].Value.ToString())))
                                   {
                                       if ((!rowTemplate.isCurrency &&
                                            dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران")) ||
                                           (rowTemplate.isCurrency &&
                                            !dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals("ريال ايران") &&
                                            !dgvGAP.Rows[i].Cells[CURRENCY_COLUMN].Value.ToString().Equals(
                                                "مجموع ريالي ارزي ها")))
                                       {
                                           var cellValue =
                                               ws.Cell(rowTemplate.Row, st.FirstCol).GetValue<string>();
                                           if (string.IsNullOrEmpty(cellValue))
                                               cellValue = "0";


                                           ws.Cell(rowTemplate.Row, st.FirstCol).SetValue(
                                               (decimal) dgvGAP.Rows[i].Cells[j].Value +
                                               decimal.Parse(cellValue));


                                           var cellValue2 =
                                               wsTas.Cell(rowTemplate.Row + 18, st.FirstCol + 1).GetValue<string>();
                                           if (string.IsNullOrEmpty(cellValue2))
                                               cellValue2 = "0";
                                           wsTas.Cell(rowTemplate.Row + 18, st.FirstCol + 1).SetValue(
                                               decimal.Parse(cellValue2) - (decimal) dgvGAP.Rows[i].Cells[j].Value);

                                       }
                                   }
                               }
                           }
                       }
                   }
               }

               #endregion

               #region Other

               st = TableTemplates[index++];
               if (st.isEnable)
               {
                   var ws = workbook.Worksheets.Worksheet(st.SheetIndex);
                   ws.Cell(st.FirstRow, st.FirstCol).SetValue(
                       FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(
                           ((DateTime) new DAL.UserInfo().GetDt_UpdateDate().Rows[0][0]).AddDays(-1)).ToString("D").
                           ToFarsi());
               }

               #endregion

               #region تراز

               st = TableTemplates[index++];
               if (st.isEnable)
               {
                   var ws = workbook.Worksheets.Worksheet(st.SheetIndex);
                   var dt = new DAL.GeneralDataSetTableAdapters.SWART_ReportsTableAdapter().GetDT_Taraz();
                   int ii = 0;
                   foreach (DataRow r in dt.Rows)
                   {
                       ws.Cell(st.FirstRow + ii, st.FirstCol).SetValue(int.Parse(r[0].ToString()));
                       ws.Cell(st.FirstRow + ii, st.FirstCol + 1).SetValue((decimal) r[1]);
                       ws.Cell(st.FirstRow + ii, st.FirstCol + 2).SetValue((decimal) r[2]);
                       ws.Cell(st.FirstRow + ii, st.FirstCol + 3).SetValue(r[3].ToString());
                       ws.Cell(st.FirstRow + ii, st.FirstCol + 4).SetValue((int) r[4]);
                       ii++;
                   }

               }

               #endregion
               
               #region سود سالهای آتی

               st = TableTemplates[index++];
               if (st.isEnable)
               {
                   var gapModelID = ((GAPDInfo) lsvModel.SelectedItems[0].Tag).ID;
                   var currencyID = cmbCurrency.SelectedIndex + 1;
                   var viewModeID = cmbValType.SelectedIndex + 1;

                   new GapDataSet().GetDT_GAP_Create_GAP_2_Soud_Salhaye_Ati(GlobalInfo.appPath, gapModelID, currencyID);
                   var dt = new GapDataSet().GetGapElements(GlobalInfo.appPath, gapModelID, viewModeID);

                   var ws = workbook.Worksheets.Worksheet(st.SheetIndex);
                   var wsTas = workbook.Worksheets.Worksheet(st.SheetIndex-4);
                   int col = 0;
                   for (int i = 0; i < dgvGAP.Columns.Count; i++)
                       if (dgvGAP.Columns[i].Visible)
                           ws.Cell(st.FirstRow, st.FirstCol + col++).SetValue(
                               dgvGAP.Columns[i].HeaderCell.Value.ToString());

                   int ii = 1;
                   
                   foreach (DataRow r in dt.Rows)
                   {
                       ws.Cell(st.FirstRow + ii, st.FirstCol).SetValue(r[0].ToString());
                       ws.Cell(st.FirstRow + ii, st.FirstCol + 1).SetValue("سود");
                       ws.Cell(st.FirstRow + ii, st.FirstCol + 2).SetValue(r[12].ToString());
                       ws.Cell(st.FirstRow + ii, st.FirstCol + 3).SetValue(r[13].ToString());
                       ws.Cell(st.FirstRow + ii, st.FirstCol + 4).SetValue(r[14].ToString());
                       for (int i = 0; i < dt.Columns.Count-23; i++)
                       {
                           ws.Cell(st.FirstRow + ii, st.FirstCol + 5 + i).SetValue((decimal)r[16 + i]);
                       }

                       ii++;
                   }

                   var RowTemplatesSood = new List<RowTemplate>();
                   RowTemplatesSood.Add(new RowTemplate
                   {
                       GroupName = "سود سال هاي آينده",
                       isCurrency = true,
                       onlyThreeStatus = true,
                       Row = 4,
                       kahande = true
                   });
                   RowTemplatesSood.Add(new RowTemplate
                   {
                       GroupName = "سود سال هاي آينده",
                       isCurrency = false,
                       onlyThreeStatus = true,
                       Row = 5,
                       kahande = true
                   });
                   col = -1;
                   
                   for (int j = 0; j < dt.Columns.Count; j++)
                   {

                       if (dt.Columns[j].Caption.StartsWith("TB"))
                       {
                          
                           col++;
                           if(col==0)
                               continue;
                           foreach (var rowTemplate in RowTemplatesSood)
                           {
                               foreach (DataRow r in dt.Rows)
                               {
                                   if ((r[13].ToString().Equals("ريال ايران") && !rowTemplate.isCurrency) ||
                                       (!r[13].ToString().Equals("ريال ايران") &&
                                        !r[13].ToString().Equals("مجموع ريالي ارزي ها") && rowTemplate.isCurrency))
                                   {

                                       decimal cellValue = 0;
                                       try
                                       {
                                           cellValue =
                                               wsTas.Cell(rowTemplate.Row, 4 + col).GetValue<decimal>();
                                       }
                                       catch (Exception)
                                       {


                                       }

                                       int sign = rowTemplate.kahande ? -1 : 1;

                                       wsTas.Cell(rowTemplate.Row,4 + col).SetValue(
                                           (decimal) r[j]*sign +
                                           (cellValue));

                                   }
                               }
                               
                           }
                       }
                   }

               }

               #endregion
               

               workbook.Dispose();
               workbook.SaveAs(path2);

               ProgressBox.Hide();
               Routines.ShowMessageBoxFa("پایان عملیات", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }

        private void splitContainer1_Panel1_DoubleClick(object sender, EventArgs e)
       {
           FillGap(false);
       }

    }
    class TableTemplate
    {
        public int DataSetIndex;
        public int SheetIndex;
        public int FirstRow;
        public int FirstCol;
        public string Name;
        public bool isEnable;

    }
    class RowTemplate
    {
        public int Row;
        public string GroupName;
        public bool isCurrency;
        public bool onlyThreeStatus;
        public bool kahande;
        
    }

}