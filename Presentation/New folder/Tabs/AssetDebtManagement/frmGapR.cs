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
using ERMSLib;
using Dundas.Charting.WinControl;
using ERMS.Logic;
using ERMS.Model;
using Presentation.Public;
using MyDialogButton = Utilize.MyDialogButton;
using ProgressBox = Presentation.Public.ProgressBox;
using Utilize.Helper;
//   

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
                        summaryDRow_TotalAsset,
                        summaryDRow_TotalDebt,
                        summaryDRow_TotalDebt_Cum,
                        summaryDRow_E,
                        summaryDRow_G,
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

        private const int CTE_NumSumNodes = 10;

        #endregion

        public frmGAP()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);

            #region State And Organization

            #region Add By AliZ

            // تابع برای تنظیم لیست شهر ها زمانی که نمایش داده می شود
            ucfCity.DropDownOpening += (ucfCity_DropDownOpening);

            #endregion

            ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;

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

                #region Add By Aliz

                //تنظیمات فیلتر بندی شهر
                var cityDataTable = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData();
                ucfCity.DisplayMember = "City_Name";
                ucfCity.ValueMember = "City_ID";
                ucfCity.DataSource = cityDataTable;

                #endregion
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

                #region Add By Aliz

                //تنظیمات فیلتر بندی شهر
                var cityDataTable = user.Rows.Cast<DataRow>().Select(item => new { City_ID = item["City_ID"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray(); new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData();
                ucfCity.DisplayMember = "City_Name";
                ucfCity.ValueMember = "City_ID";
                ucfCity.DataSource = cityDataTable;

                #endregion

            }

            #endregion
            
        }

        /// <summary>
        /// تابع برای تنظیم لیست شهر ها زمانی که نمایش داده می شود
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ucfCity_DropDownOpening(object sender, EventArgs e)
        {
            #region Add By Aliz

            try
            {

                ucfCity.DisplayMember = "City_Name";
                ucfCity.ValueMember = "City_Id";

                //بررسی اینکه فیلتر استان انتخاب شده باشد و
                // استان های انتخاب شده بیشتر از یک باشد
                if (cmbLimit.SelectedIndex == 0 && cmbLimitValue.SelectedIndex != -1)
                {
                    if (user.Rows.Count == 0)
                    {
                        var cities = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData().Where(
                            city => int.Parse(cmbLimitValue.SelectedValue.ToString().Trim()) == (int)city.State_ID_Fk);
                        DataTable dt = new DataTable();
                        dt.Columns.Add("City_Name");
                        dt.Columns.Add("City_Id");
                        foreach (var row in cities)
                        {
                            DataRow dr = dt.NewRow();
                            dr["City_Name"] = row["City_Name"];
                            dr["City_Id"] = row["City_Id"];
                            dt.Rows.Add(dr);
                        }
                        ucfCity.DataSource = dt;
                        ucfCity.Update();
                        ucfCity.Refresh();
                    }
                    else
                    {
                        var cities = user.Rows.Cast<DataRow>().Where(city => Convert.ToInt32(cmbLimitValue.SelectedValue) == Convert.ToInt32(city["State_Id"].ToString()))
                        .Select(item => new { City_Id = item["City_Id"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray();

                        ucfCity.DataSource = cities;
                    }
                    ucfOrganization.Enabled = true;
                    return;
                }

                if(ucfCity.GetSelectedItem().Count() > 0)
                    ucfOrganization.Enabled = true;
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
            #endregion
        }

        private void frmGAP_Load(object sender, EventArgs e)
        {

            user =
                new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(
                    ERMS.Model.GlobalInfo.UserID);

            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

            fdpStartDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate(); //DateTime.Now;
            GeneralDataGridView = dgvGAP;
            Init();
            rdbHistoric.Checked = true;
            if (cmbCurrencyValue.Items.Count > 0)
                cmbCurrencyValue.SelectedIndex = 0;
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
            if ((cmbFSM.SelectedIndex != -1) && (cmbTBM.SelectedIndex != -1) && (cmbCBM.SelectedIndex != -1))
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
                ProgressBox.Show();
                DataGridViewCell cell = dgvGAP.CurrentCell;
                frmDetail fx = new frmDetail();
                if (cell != null && cell.RowIndex <= dgvGAP.Rows.Count - 1 - CTE_NumSumNodes && cell.ColumnIndex != 0 &&
                    cell.ColumnIndex != dgvGAP.Columns.Count - 1)
                {
                    int fsModelElementID = (int) dgvGAP.CurrentRow.Cells["FSME_ID"].Value;
                    string title = dgvGAP.CurrentRow.Cells["FSME_Title"].Value.ToString();
                    if (title != string.Empty)
                    {
                        Presentation.Public.Routines.ShowMessageBoxFa(
                            "عملیات درخواست شده تحت یك عنوان گروه حساب قابل انجام نیست", "پیغام", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return;
                    }

                    int tbElementSeq = ((TBMElementInfo) cell.OwningColumn.Tag).Sequence;
                    int tbModelID = ((TBMElementInfo) cell.OwningColumn.Tag).ModelID;
                    var cbModelID = (int)cmbCBM.SelectedValue;

                    GAP gap = new GAP();
                    DateTime startDate;
                    // add for farsi date

                    if (FlagFullMode == 1)
                    {
                        startDate = fdpStartDate.SelectedDateTime; //StartDateFullMode;
                    }
                    else
                    {
                        startDate = fdpStartDate.SelectedDateTime;
                    }
                    bool IsSeperate = chkDescreteGapAnalisys.Checked;

                    fx.fsModelElementID = fsModelElementID;
                    fx.tbModelID = tbModelID;
                    fx.tbElementSeq = tbElementSeq;
                    fx.limitDetails = limitDetails;
                    fx.limitID = limitID;
                    fx.IsSeperate = IsSeperate;
                    fx.CurrencyID = (int) cmbCurrency.SelectedValue;
                    fx.Historic = rdbHistoric.Checked;
                    fx.dtpStartDateValue = startDate;
                    fx.chkIrrValue = chkIrr.Checked;
                    fx.cbModelID = cbModelID;
                    ProgressBox.Hide();
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
            cmbCBM.SelectedIndex = -1;
            cmbTBM.SelectedIndex = -1;
            cmbCurrency.SelectedIndex = cmbCurrency.Items.Count > 0 ? 0 : -1;
            cmbValType.SelectedIndex = cmbValType.Items.Count > 0 ? 0 : -1;

            chkColor.Checked = true;
            chkIrr.Checked = false;


            // add for farsi date
            //PersianTools.Dates.PersianDate P;
            //P = new PersianTools.Dates.PersianDate((DateTime)DateTime.Now);
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
                    cmbCBM.SelectedByDataValue(gi.CBModelID);

                    chkIrr.Checked = gi.IrrActive;

                    // add by soltani
                    //P = new PersianTools.Dates.PersianDate((DateTime)gi.StartDate);
                    //fdpStartDate.Text = P.FormatedDate("yyyy/MM/dd");
                    dateFarsi = fdpStartDate.Text; // fdpStartDate.Text;
                    //
                    //    dtpStartDate.Value = gi.StartDate;
                    fdpStartDate.SelectedDateTime = gi.StartDate;
                    curModelID = gi.ID;
                    cmbLimit.ResetText();
                    cmbLimitValue.ResetText();
                    ucfOrganization.ResetText();
                    return;
                }
            }

            dgvGAP.Columns.Clear();
        }

        private void cmbTBM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTBM.DataSource != null && cmbTBM.SelectedIndex != -1 && cmbTBM.SelectedValue is int)
            {
                int tbModelID = (int) cmbTBM.SelectedValue;

                DataTable dt = cbm.GetCBMs();
                dt.DefaultView.RowFilter = string.Format("{0}={1}", CBM.CTE_Alias_TBModelID, tbModelID);
                cmbCBM.DataSource = dt.DefaultView;
                cmbCBM.DisplayMember = CBM.CTE_Alias_ModelName;
                cmbCBM.ValueMember = CBM.CTE_Alias_ID;

            }
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
            //if (e.RowIndex != -1 && e.ColumnIndex == 0 && e.RowIndex <= dgvGAP.Rows.Count - 1 - CTE_NumSumNodes)
            //{
            //    DataGridViewRow dgvr = dgvGAP.Rows[e.RowIndex];

            //    int balance = (int)dgvr.Cells["FSME_Balance"].Value;
            //    int pointRight = 20 * balance;
            //    int pointLeft = 20 * (balance + 1);

            //    if (e.X > pointRight && e.X < pointLeft)
            //    {
            //        int dIndex = dtGAP.Rows.IndexOf(((DataRowView)dgvGAP.Rows[e.RowIndex].DataBoundItem).Row);
            //        if (dIndex < dtGAP.Rows.Count - 1 - CTE_NumSumNodes)
            //        {
            //            DataRow curDRow = dtGAP.Rows[dIndex];
            //            DataRow nextDRow = dtGAP.Rows[dIndex + 1];

            //            if ((bool)nextDRow["Hidden"] == false)
            //            {
            //                Collapse(dIndex, balance);
            //            }
            //            else
            //            {
            //                Expand(dIndex, balance);
            //            }
            //        }
            //    }
            //}
            //if (e.RowIndex != -1 && e.ColumnIndex == 0 && e.RowIndex <= dgvGAP.Rows.Count - 1 - CTE_NumSumNodes)
            //{
            //    DataGridViewRow dgvr = dgvGAP.Rows[e.RowIndex];

            //    int balance = (int)dgvr.Cells["FSME_Balance"].Value;
            //    int pointRight = 20 * balance;
            //    int pointLeft = 20 * (balance + 1);

            //    if (e.X > pointRight && e.X < pointLeft)
            //    {
            //        int dIndex = dtGAP.Rows.IndexOf(((DataRowView)dgvGAP.Rows[e.RowIndex].DataBoundItem).Row);
            //        if (dIndex < dtGAP.Rows.Count - 1 - CTE_NumSumNodes)
            //        {
            //            DataRow curDRow = dtGAP.Rows[dIndex];
            //            DataRow nextDRow = dtGAP.Rows[dIndex + 1];

            //            if ((bool)nextDRow["Hidden"] == false)
            //            {
            //                Collapse(dIndex, balance);
            //            }
            //            else
            //            {
            //                Expand(dIndex, balance);
            //            }
            //        }
            //    }
            //}

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
            //try
            //{
            //    if (e.RowIndex == -1 || e.ColumnIndex != 0 || e.RowIndex > dgvGAP.Rows.Count - 1 - CTE_NumSumNodes)
            //    {
            //        e.Handled = false;
            //        return;
            //    }

            //    DataGridViewRow row = dgvGAP.Rows[e.RowIndex];
            //    DataGridViewCell cell = row.Cells["FSME_Balance"];

            //    if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
            //        e.PaintBackground(e.ClipBounds, true);
            //    else if (row.Cells["FSME_Color"].Value != null)
            //    {
            //        Color color1 = Color.White;
            //        Color color2 = chkColor.Checked ? Color.FromArgb((int)row.Cells["FSME_Color"].Value) : Color.White;
            //        using (Brush bg = new System.Drawing.Drawing2D.LinearGradientBrush(e.CellBounds, color1, color2, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
            //        {
            //            //e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
            //            //Rectangle rect = new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
            //            e.Graphics.FillRectangle(bg, e.CellBounds);
            //        }
            //    }

            //    e.Paint(e.CellBounds, DataGridViewPaintParts.Focus | DataGridViewPaintParts.Border);

            //    //////////////////////////////
            //    int balance = (int)cell.Value;
            //    int indent = balance * 20;

            //    string groupName = row.Cells["FSME_GroupName"].Value.ToString();
            //    string title = row.Cells["FSME_Title"].Value.ToString();
            //    string caption = groupName != string.Empty ? groupName : title;

            //    Image nodeImage;
            //    int dIndex = dtGAP.Rows.IndexOf(((DataRowView)row.DataBoundItem).Row);

            //    DataRow curDRow = dtGAP.Rows[dIndex];
            //    if (dIndex < dtGAP.Rows.Count - 1 - CTE_NumSumNodes)
            //    {
            //        DataRow nextDRow = dtGAP.Rows[dIndex + 1];

            //        string curULevel = curDRow["FSME_ULevel"].ToString();
            //        string nextULevel = nextDRow["FSME_ULevel"].ToString();
            //        bool nextIsHidden = (bool)nextDRow["Hidden"];

            //        if (nextULevel.StartsWith(curULevel))
            //        {
            //            if (nextIsHidden)
            //                nodeImage = global::Presentation.Properties.Resources.Plus;
            //            else
            //                nodeImage = global::Presentation.Properties.Resources.Minus;
            //        }
            //        else
            //            nodeImage = global::Presentation.Properties.Resources.Lines;
            //    }
            //    else
            //        nodeImage = global::Presentation.Properties.Resources.Lines;


            //    e.Graphics.DrawString(caption.ToString(), e.CellStyle.Font, Brushes.DimGray, e.CellBounds.Location.X + indent + 20, e.CellBounds.Location.Y + 2);

            //    if (nodeImage != null)
            //    {
            //        System.Drawing.Drawing2D.GraphicsContainer container = e.Graphics.BeginContainer();
            //        e.Graphics.SetClip(e.ClipBounds);
            //        e.Graphics.DrawImageUnscaled(nodeImage, e.CellBounds.Location.X + indent, e.CellBounds.Location.Y);
            //        e.Graphics.EndContainer(container);
            //    }

            //    e.Handled = true;
            //}
            //catch(Exception ex)
            //{
            //}
        }

        private void dgvGAP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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


            //Before Edit : cmbValType.AddItemsRange(new string[] { "مبالغ اصلی", "مبالغ سود", "هردو" });
            //After Edit By Shala And Ali
            cmbValType.AddItemsRange(new string[] {"مبالغ قسط", "مبلغ سود", "مبلغ اصلی"});

            cmbValType.SelectedIndex = cmbValType.Items.Count > 0 ? 0 : -1;

            htFSMs = new Hashtable();

            var misc = new Misc();
            cmbCurrency.DataSource = misc.GetCurrencyDT();
            cmbCurrency.DisplayMember = Misc.CTE_Alias_CurrencyDescr;
            cmbCurrency.ValueMember = Misc.CTE_Alias_CurrencyID;
            cmbCurrency.SelectedIndex = cmbCurrency.Items.Count > 0 ? 0 : -1;
            cmbCurrency.SetDefaultCurrency("ریال ایران");

            cComboGAPCurr.DataSource = misc.GetCurrencyDT();
            cComboGAPCurr.DisplayMember = Misc.CTE_Alias_CurrencyDescr;
            cComboGAPCurr.ValueMember = Misc.CTE_Alias_CurrencyID;
            cComboGAPCurr.SelectedIndex = cmbCurrency.Items.Count > 0 ? 0 : -1;
            cComboGAPCurr.SetDefaultCurrency("ریال ایران");

            chkColor.Checked = true;
            chkIrr.Checked = false;
            dtpStartDate.Value = DateTime.Now;

            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd/MM/yyyy";

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


            cmbUnit.AddItemsRange(new string[] {"واحد", "هزار", "ميليون"});
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
            cmbCBM.DataSource = cbm.GetCBMs();
            cmbCBM.DisplayMember = CBM.CTE_Alias_ModelName;
            cmbCBM.ValueMember = CBM.CTE_Alias_ID;
            cmbCBM.SelectedIndex = -1;
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
                int cbModelID = (cmbCBM.SelectedIndex == -1) ? -1 : (int) cmbCBM.SelectedValue;
                int viewModeID = (int) cmbValType.SelectedIndex + 1;


                // add for farsi date
                //PersianTools.Dates.PersianDate p1;
                //p1 = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                //DateTime startDate = DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));


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
            if ((cmbFSM.SelectedIndex == -1) || (cmbTBM.SelectedIndex == -1) || (cmbCBM.SelectedIndex == -1) ||
                (cmbValType.SelectedIndex == -1))
            {
                Presentation.Public.Routines.ShowMessageBoxFa(
                    "تحلیل شکاف در یك مدل ترازنامه، بسته زمانی و مدل اقلام بدون سررسید اجرا می شود. مدلهای مناسب را انتخاب كرده و دوباره اجرا كنید",
                    "تحلیل شکاف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            FillGap();
            RefreshChart();
            System.Windows.Forms.Cursor.Current = Cursors.Default;

        }

        public void Reload(int gapModelID, int tbModelID, int currencyID, int currencyID2,int unitIndex, int fsModelId, int cbModelID,
                           int viewModeID, int unitID, bool bAutoSize, bool IsSeperate, int limitID, string limitDetails,
                           DateTime startDate, bool onlyShow=false)
        {
            //  DateTime startDate = dtpStartDate.Value;

            bool bIrr = chkIrr.Checked;
            

            //int limitID = cmbLimit.SelectedIndex;
            //string limitDetails = cmbLimitValue.SelectedValue.ToString();        
            //bool IsSeperate = chkDescreteGapAnalisys.Checked;


            dtTBElements = tbm.GetTBMelements(tbModelID);
            dtGAP = gap.GetGAP(gapModelID, fsModelId, tbModelID, cbModelID, startDate, bIrr, viewModeID, currencyID,currencyID2,
                               limitDetails, limitID, IsSeperate, rdbHistoric.Checked, cmbCurrencyValue.SelectedIndex,onlyShow);
            dtGAP.DefaultView.RowFilter = "(Hidden = 0)";

            //
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

            dgvGAP.DataSource = dtGAP;
            FormatGrid(dtTBElements, bAutoSize);

            dtGAP.AcceptChanges();

            if (cmbUnit.SelectedIndex != 0)
                NumberScale(unitID);
        }

        private void FillGap(bool onlyShow=false)
        {
            try
            {
                ProgressBox.Show();

                dgvGAP.Columns.Clear();

                var gapModelID = ((GAPDInfo) lsvModel.SelectedItems[0].Tag).ID;
                var fsModelID = (int) cmbFSM.SelectedValue;
                var tbModelID = (int) cmbTBM.SelectedValue;
                var cbModelID = (int) cmbCBM.SelectedValue;
                var currencyID = (int) cmbCurrency.SelectedValue;
                var currencyID2 = (int)cComboGAPCurr.SelectedValue;
                var viewModeID = (int) cmbValType.SelectedIndex + 1;
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
                    if (cmbLimit.SelectedIndex == 0 && cmbLimitValue.SelectedIndex != -1)
                    {
                        limitDetails = cmbLimitValue.SelectedValue.ToString().Trim();
                        limitID = 1;
                    }

                    // تفکیک استان و شهر
                    if (cmbLimit.SelectedIndex == 0 && ucfCity.IsChecked() == true && ucfCity.GetSelectedItem().Count() > 0)
                    {
                        limitDetails = GetFilterCity();
                        limitID = 2;
                    }

                    // تفکیک استان و شعب
                    if (cmbLimit.SelectedIndex == 0 && ucfOrganization.IsChecked() == true 
                            && ucfOrganization.GetSelectedItem().Count() > 0)
                    {
                        limitDetails = GetFilterBranchG();
                        limitID = 3;
                    }

                    //بخش اقتصادی
                    if (cmbLimit.SelectedIndex != 0)
                    {
                        limitDetails = cmbLimitValue.SelectedValue.ToString();
                        limitID = 0;
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

                    if (currencyID == 20 && cmbCurrencyValue.SelectedIndex == -1)
                    {

                        Presentation.Public.Routines.ShowMessageBoxFa("لطفاً نرخ ارز را انتخاب کنید", "مدل",
                                                                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    else
                    {
                        dtGAP = gap.GetGAP(gapModelID, fsModelID, tbModelID, cbModelID, fdpStartDate.SelectedDateTime,
                                           bIrr, viewModeID, currencyID,currencyID2, limitDetails, limitID, IsSeperate,rdbHistoric.Checked, 
                                           cmbCurrencyValue.SelectedIndex,onlyShow);
                        dtGAP.DefaultView.RowFilter = "(Hidden = 0)";

                        //
                        summaryDRow1 = dtGAP.NewRow();
                        dtGAP.Rows.Add(summaryDRow1);

                        summaryDRow2 = dtGAP.NewRow();
                        dtGAP.Rows.Add(summaryDRow2);

                        summaryDRow_TotalAsset = dtGAP.NewRow();
                        dtGAP.Rows.Add(summaryDRow_TotalAsset);

                        summaryDRow_TotalDebt = dtGAP.NewRow();
                        dtGAP.Rows.Add(summaryDRow_TotalDebt);

                        summaryDRow_TotalDebt_Cum = dtGAP.NewRow();
                        dtGAP.Rows.Add(summaryDRow_TotalDebt_Cum);

                        summaryDRow_E = dtGAP.NewRow();
                        dtGAP.Rows.Add(summaryDRow_E);

                        summaryDRow_G = dtGAP.NewRow();
                        dtGAP.Rows.Add(summaryDRow_G);

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

            foreach (DataGridViewColumn dgvc in dgvGAP.Columns)
            {
                if (dgvc.Tag is TBMElementInfo)
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
                    summaryDRow_TotalAsset[iCol] = 0;
                    summaryDRow_TotalDebt[iCol] = 0;
                    summaryDRow_TotalDebt_Cum[iCol] = 0;
                    summaryDRow_E[iCol] = 0;
                    summaryDRow_G[iCol] = 0;
                    summaryDRow2Limit[iCol] = 0;
                    summaryDRow2LimitUp[iCol] = 0;
                    summaryDRow2LimitDown[iCol] = 0;

                    for (int iRow = 0; iRow <= dtGAP.Rows.Count - 1 - CTE_NumSumNodes; iRow++)
                    {
                        int AL = (int) dtGAP.Rows[iRow]["FSME_AL"];
                        if (AL != -1)
                        {
                            if (AL == (int)EAL.Asset)
                            {
                                summaryDRow1[iCol] = (decimal)summaryDRow1[iCol] +
                                                     (+1) * (decimal)dtGAP.Rows[iRow][iCol];
                                summaryDRow_TotalAsset[iCol] = (decimal)summaryDRow_TotalAsset[iCol] +
                                                                    (+1) * (decimal)dtGAP.Rows[iRow][iCol];
                            }
                            else if (AL != (int)EAL.Asset)
                            {
                                summaryDRow1[iCol] = (decimal)summaryDRow1[iCol] +
                                                     (-1) * (decimal)dtGAP.Rows[iRow][iCol];
                                summaryDRow_TotalDebt[iCol] = (decimal)summaryDRow_TotalDebt[iCol] +
                                                     (+1) * (decimal)dtGAP.Rows[iRow][iCol];
                            }
                            //if (AL == (int) EAL.Liability)
                            //    summaryDRow1[iCol] = (decimal) summaryDRow1[iCol] +
                            //                         (-1)*(decimal) dtGAP.Rows[iRow][iCol];

                            //#region EDIT BY SHAHLA 91.06.08

                            //if (AL == (int) EAL.LG_IRR)
                            //    summaryDRow1[iCol] = (decimal) summaryDRow1[iCol] +
                            //                         (-1)*(decimal) dtGAP.Rows[iRow][iCol];
                            //if (AL == (int) EAL.LC_CUR)
                            //    summaryDRow1[iCol] = (decimal) summaryDRow1[iCol] +
                            //                         (-1)*(decimal) dtGAP.Rows[iRow][iCol];
                            //if (AL == (int) EAL.LG_CUR)
                            //    summaryDRow1[iCol] = (decimal) summaryDRow1[iCol] +
                            //                         (-1)*(decimal) dtGAP.Rows[iRow][iCol];

                            //#endregion

                        }

                        if (dtGAP.Rows[iRow].IsNull(totalDColumn))
                            dtGAP.Rows[iRow][totalDColumn] = 0;

                        if ((bIrr && chkIrr.Checked) || !bIrr)
                            dtGAP.Rows[iRow][totalDColumn] = (decimal) dtGAP.Rows[iRow][totalDColumn] +
                                                             (decimal) dtGAP.Rows[iRow][iCol];
                    }

                    //summaryDRow2[iCol] = (decimal) summaryDRow1[iCol] +
                    //                     ((iCol == 13) ? 0 : (decimal) summaryDRow2[iCol - 1]);
                    summaryDRow2[iCol] = (decimal)summaryDRow1[iCol] +
                                         (!(dtGAP.Columns[iCol-1].ColumnName.StartsWith("TB")) ? 0 : (decimal)summaryDRow2[iCol - 1]);
                    summaryDRow_TotalDebt_Cum[iCol] = (decimal)summaryDRow_TotalDebt[iCol] +
                                         (!(dtGAP.Columns[iCol - 1].ColumnName.StartsWith("TB")) ? 0 : (decimal)summaryDRow_TotalDebt_Cum[iCol - 1]);


                    summaryDRow_E[iCol] = (decimal)summaryDRow_TotalDebt[iCol] == 0 ? 0 : 
                                                ((decimal)summaryDRow1[iCol] / (decimal)summaryDRow_TotalDebt[iCol]) * 100;
                    summaryDRow_G[iCol] = (decimal)summaryDRow_TotalDebt_Cum[iCol] == 0 ? 0 : 
                                                ((decimal)summaryDRow2[iCol] / (decimal)summaryDRow_TotalDebt_Cum[iCol]) * 100;


                }
            }
            for (int iCol = 1; iCol < numColumns - 1; iCol++)
            {
                if (dtGAP.Columns[iCol].ColumnName.StartsWith("TB"))
                {
                    if ((decimal) dtGAP.Rows[0]["Total"] != 0)
                        summaryDRow2Limit[iCol] = (decimal)dtGAP.Rows[0]["Total"] == 0 ? 0 : 
                                                     ((decimal)summaryDRow2[iCol] / (decimal)dtGAP.Rows[0]["Total"]) * 100;
                }
            }

            summaryDRow1["Hidden"] = 0;
            summaryDRow2["Hidden"] = 0;
            summaryDRow2Limit["Hidden"] = 0;
            summaryDRow2LimitUp["Hidden"] = 0;
            summaryDRow2LimitDown["Hidden"] = 0;
            summaryDRow_E["Hidden"] = 0;
            summaryDRow_G["Hidden"] = 0;
            summaryDRow_TotalAsset["Hidden"] = 0;
            summaryDRow_TotalDebt["Hidden"] = 0;
            summaryDRow_TotalDebt_Cum["Hidden"] = 0;


            summaryDRow1["FSME_GroupName"] = " شکاف:";
            summaryDRow2["FSME_GroupName"] = "شکاف تجمعی :";
            summaryDRow2Limit["FSME_GroupName"] = "نسبت به دارایی:";

            summaryDRow_TotalAsset["FSME_GroupName"] = "جمع کل دارایی:";
            summaryDRow_TotalDebt["FSME_GroupName"] = "جمع کل بدهی:";
            summaryDRow_TotalDebt_Cum["FSME_GroupName"] = "جمع تجمعی کل بدهی:";
            summaryDRow_E["FSME_GroupName"] = "شکاف به جمع بدهی:";
            summaryDRow_G["FSME_GroupName"] = "شکاف تجمعی به بدهی تجمعی:";


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
                            row.Cells[col.Name].Value = (scale == 0 ? 0 :
                                                                (decimal)row.Cells[col.Name].Value / scale);
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
            // int limitID = cmbLimit.SelectedIndex;
            //string limitDetails = cmbLimitValue.SelectedValue.ToString();

            if (curModelID == -1)
                return;

            if (cmbFSM.SelectedIndex == -1 || cmbCBM.SelectedIndex == -1 || cmbTBM.SelectedIndex == -1)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(
                    "تحلیل شکاف در یك مدل ترازنامه، بسته زمانی و مدل اقلام بدون سررسید اجرا می شود. مدلهای مناسب را انتخاب كرده و دوباره اجرا كنید",
                    "تحليل شکاف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int gapModelID = (int) curModelID;
                int tbModelID = (int) cmbTBM.SelectedValue;
                int currencyID = (int) cmbCurrency.SelectedValue;
                int currencyID2=(int) cComboGAPCurr.SelectedValue;
                int unitIndex = cmbUnit.SelectedIndex;
                int fsModelID = (int) cmbFSM.SelectedValue;
                int cbModelID = (int) cmbCBM.SelectedValue;
                int viewModeID = (int) cmbValType.SelectedIndex + 1;
                
                int unitID = (int) cmbUnit.SelectedIndex;
                bool bAutoSize = (bool) chkAutoSize.Checked;
                bool bIrr = (bool) chkIrr.Checked;
                bool bDescreteGapAnalisys = (bool) chkDescreteGapAnalisys.Checked;

                int limitIndex = -1;
                string limitValue = string.Empty;

                if (bDescreteGapAnalisys)
                {
                    limitIndex = cmbLimit.SelectedIndex;
                    limitValue = cmbLimitValue.SelectedValue.ToString();
                }

                frmGAP fx = new frmGAP();
                fx.WindowState = FormWindowState.Maximized;

                fx.Init();

                fx.FlagFullMode = 1;
                fx.StartDateFullMode = fdpStartDate.SelectedDateTime;

                drGAPD = gap.GetGAPD(gapModelID);
                if (drGAPD["FSModelID"].ToString() == "-1" || drGAPD["TBModelID"].ToString() == "-1" ||
                    drGAPD["CBModelID"].ToString() == "-1")
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("لطفا ابتدا مدل شكاف خود را ذخیره كنيد", "هشدار",
                                                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                    fx.SetFullMode();

                    fx.Reload(gapModelID, tbModelID, currencyID,currencyID2, unitIndex, fsModelID, cbModelID, viewModeID, unitID,
                              bAutoSize, bDescreteGapAnalisys, limitIndex, limitValue, fdpStartDate.SelectedDateTime);

                    fx.RefreshChart(curModelID, bIrr);
                    fx.ShowDialog();
                    System.Windows.Forms.Cursor.Current = Cursors.Default;
                }
            }
        }

        public void SetFullMode()
        {
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

            ddChart.DataSource = gap.GetGAPSummary(curModelID, chkIrr.Checked);
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

            ddChart.DataSource = gap.GetGAPSummary(gapmodelID, bIrr);
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

        private void cmbLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lsvState.Items.Clear();
            if (cmbLimit.SelectedIndex == 0)
            {
                lblDesretionType.Text = "استان";
                //btnList.Enabled = true;
                chkAll.Enabled = true;
                chkAll.Enabled = false;
            }
            else
            {
                lblDesretionType.Text = "بخش";
                //btnList.Enabled = false;
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
            string filterexpression = string.Empty;
            DataTable dtDest = lm.GetTable(strId, strField, TableName, filterexpression);

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
                ucfCity.Enabled = false;
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
            P = new PersianTools.Dates.PersianDate(fdpStartDate.SelectedDateTime);
            string Strdate = P.FormatedDate("yyyy/MM/dd").ToString();

            if (lsvModel.SelectedItems.Count > 0)
            {
                int fsModelID = (cmbFSM.SelectedIndex == -1) ? -1 : (int) cmbFSM.SelectedValue;
                int tbModelID = (cmbTBM.SelectedIndex == -1) ? -1 : (int) cmbTBM.SelectedValue;
                int cbModelID = (cmbCBM.SelectedIndex == -1) ? -1 : (int) cmbCBM.SelectedValue;
                int viewModeID = (int) cmbValType.SelectedIndex + 1;

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
                gi.StartDate = fdpStartDate.SelectedDateTime;
                gi.IrrActive = bIrr;

                CurrentReportID = gap.InsertGAPReport(gi);
                SaveReportElement(CurrentReportID, curModelID);

                if (bMessage)
                    Presentation.Public.Routines.ShowMessageBoxFa(" مدل شما به تاريخ " + Strdate + "ذخیره شد ", "ذخیره",
                                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveReportElement(decimal CurrentReportID, int curModelID)
        {

            gap.InsertGAPElementReport(CurrentReportID, curModelID);
        }

        private void dgvGAP_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGAP_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            decimal GapLimit;

            Color color1 = Color.Red;
            Color color2 = Color.GreenYellow;

            if (e.RowIndex == dgvGAP.RowCount - 3 && e.ColumnIndex != 0)
            {
                if (fx.ShowDialog() == DialogResult.OK)
                {
                    GapUpLimit = fx.upLimit;
                    GapdownLimit = fx.downLimit;
                    dgvGAP.Rows[dgvGAP.RowCount - 2].Cells[e.ColumnIndex].Value = GapUpLimit; //حد مثبت
                    dgvGAP.Rows[dgvGAP.RowCount - 1].Cells[e.ColumnIndex].Value = GapdownLimit; //منفی

                    GapLimit = (decimal) dgvGAP.Rows[dgvGAP.RowCount - 3].Cells[e.ColumnIndex].Value;

                    if (GapdownLimit < GapLimit && GapLimit < GapUpLimit)
                    {
                        colorFlag = 1; //Green
                    }
                    else
                    {

                        colorFlag = 2; //Red
                    }
                    gap.InsertLimit(curModelID, e.ColumnIndex, GapUpLimit, GapdownLimit);
                    falgLimit = true;
                    columnLimit = e.ColumnIndex;

                }


            }
        }

        private void dgvGAP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbLimit.Enabled == false)
                    return;
                if (!(cmbLimitValue.SelectedIndex != -1 && chkAll.Checked == true))
                {
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
            ucfCity.DataSource = null;
            ucfCity.ResetText();
            if (cmbLimit.SelectedIndex == 0 && cmbLimitValue.SelectedIndex != -1)
            {
                ucfCity.Enabled = true;
                ucfOrganization.ResetText();
                ucfOrganization.DataSource = null;
                ucfOrganization.Enabled = false;

            }
            else if (cmbLimit.SelectedIndex == 0 && cmbLimitValue.SelectedIndex == -1)
            {
                ucfCity.Enabled = false;
                ucfOrganization.ResetText();
                ucfOrganization.DataSource = null;
                ucfOrganization.Enabled = false;
            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Enabled == true)
            //    cmbLimit.Enabled = true;
            //else
            //    cmbLimit.Enabled = false;
        }

        private void ucfOrganization_DropDownOpening(object sender, EventArgs e)
        {
            #region Add By Aliz
            try
            {
                ucfOrganization.DisplayMember = "Branch_Description";
                ucfOrganization.ValueMember = "Branch";

                //بررسی اینکه فیلتر شهر انتخاب شده باشد و
                // شهرهای انتخاب شده بیشتر از یک باشد
                if (ucfCity.IsChecked() && ucfCity.GetSelectedItem().Count() > 0)
                {
                    //بررسی اینکه فیلتر مکان برای این کاربر تنظیم شده است
                    if (user.Rows.Count == 0)
                    {
                        var branchs = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(item => ucfCity.GetSelectedItem().Any(city => city.DataValue.ToString().Equals(item.City_Of_Branch.ToString()))).ToArray();
                        ucfOrganization.DataSource = branchs;
                    }
                    else
                    {
                        var branchs = user.Rows.Cast<DataRow>().Where(
                             org => ucfCity.GetSelectedItem().Any(city => city.DataValue.ToString().Equals(org["City_Id"].ToString())))
                        .Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();
                        ucfOrganization.DataSource = branchs;
                    }

                    return;
                }

                //بررسی اینکه فیلتر استان انتخاب شده باشد و
                // استان های انتخاب شده بیشتر از یک باشد
                if (cmbLimit.SelectedIndex == 0 && cmbLimit.SelectedIndex != -1)
                {
                    if (user.Rows.Count == 0)
                    {
                        var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(
                           org => cmbLimitValue.CheckedItems.Any(sta => sta.DataValue.ToString().Equals(org.State_Of_Branch.ToString()))).ToArray();

                        ucfOrganization.DataSource = organizations;
                    }
                    else
                    {
                        var organizations = user.Rows.Cast<DataRow>().Where(
                             org =>
                               cmbLimitValue.CheckedItems.Any(sta => sta.DataValue.ToString().Equals(org["State_Id"].ToString())))
                        .Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();

                        ucfOrganization.DataSource = organizations;
                    }

                    return;
                }

                // در صورتی که نه فیلتر استان یا شهر انتخاب نشده باشد
                if (user.Rows.Count == 0)
                {
                    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();
                    ucfOrganization.DataSource = organizations;
                }
                else
                {
                    var organizationNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();
                    ucfOrganization.DataSource = organizationNew_DataTable;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
            #endregion
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
                                dgvRow.Cells[dgvCol.Name].Style.BackColor = Color.GreenYellow;
                            }
                            else
                            {
                                dgvRow.Cells[dgvCol.Name].Style.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            dgvGAP.EndEdit();
            dgvGAP.Refresh();
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

        private string GetFilterCity()
        {
            var fil_City = ucfCity.GetFilterStructureForSqlBranchG();

            bool isColl_Filter = false;
            var filter = "";
            if (fil_City.Trim().Length != 0)
            {
                if (filter.Trim().Length != 0) filter += " and ";
                filter += fil_City;
            }
            else if (user.Rows.Count != 0)
            {
                string fil = "";
                var organizationNew_DataTable =
                    user.Rows.Cast<DataRow>().Select(
                        item =>
                        new
                        {
                            Brach_Id = item["City_ID"].ToString(),
                            Branch_Description = item["City_Name"].ToString()
                        }).Distinct().ToArray();
                foreach (var item in organizationNew_DataTable)
                {


                    fil += fil.Trim().Length == 0
                               ? "City_Id = " + "'" + item.Brach_Id.Trim() + "' "
                               : " OR City_Id = '" + item.Brach_Id.Trim() + "' ";

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

        private void tsmiDetail_Delayed_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBox.Show();
                DataGridViewCell cell = dgvGAP.CurrentCell;
                frmDetail fx = new frmDetail();
                if (cell != null && cell.RowIndex <= dgvGAP.Rows.Count - 1 - CTE_NumSumNodes && cell.ColumnIndex != 0 && cell.ColumnIndex != dgvGAP.Columns.Count - 1)
                {
                    int fsModelElementID = (int)dgvGAP.CurrentRow.Cells["FSME_ID"].Value;
                    string title = dgvGAP.CurrentRow.Cells["FSME_Title"].Value.ToString();
                    if (title != string.Empty)
                    {
                        Presentation.Public.Routines.ShowMessageBoxFa("عملیات درخواست شده تحت یك عنوان گروه حساب قابل انجام نیست", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    int tbElementSeq = ((TBMElementInfo)cell.OwningColumn.Tag).Sequence;
                    int tbModelID = ((TBMElementInfo)cell.OwningColumn.Tag).ModelID;
                    var cbModelID = (int)cmbCBM.SelectedValue;

                    GAP gap = new GAP();
                    DateTime startDate;

                    if (FlagFullMode == 1)
                    {
                        startDate = fdpStartDate.SelectedDateTime;
                    }
                    else
                    {
                        startDate = fdpStartDate.SelectedDateTime;
                    }
                    bool IsSeperate = chkDescreteGapAnalisys.Checked;

                    fx.fsModelElementID = fsModelElementID;
                    fx.tbModelID = tbModelID;
                    fx.tbElementSeq = tbElementSeq;
                    fx.limitDetails = limitDetails;
                    fx.limitID = limitID;
                    fx.IsSeperate = IsSeperate;
                    fx.CurrencyID = (int)cmbCurrency.SelectedValue;
                    fx.dtpStartDateValue = startDate;
                    fx.chkIrrValue = chkIrr.Checked;
                    fx.Delayed = true;
                    fx.Historic = rdbHistoric.Checked;
                    fx.cbModelID = cbModelID;
                    ProgressBox.Hide();
                    fx.Show();
                }
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
             var gapModelID = ((GAPDInfo) lsvModel.SelectedItems[0].Tag).ID;
                var fsModelID = (int) cmbFSM.SelectedValue;
                var tbModelID = (int) cmbTBM.SelectedValue;
                var cbModelID = (int) cmbCBM.SelectedValue;
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
            cComboGAPCurr.SelectedIndex = cmbCurrency.SelectedIndex; 
            if ((int)cmbCurrency.SelectedValue == 20)
            {
                cmbCurrencyValue.Enabled = true;
            }
            else
            {
                //cmbCurrencyValue.Enabled = false;
            }
        }

        private void ucfCity_Load(object sender, EventArgs e)
        {

        }

        private void cmbCurrency_ValueChanged(object sender, EventArgs e)
        {

        }

      
        private void cComboGAPCurr_ValueChanged_1(object sender, EventArgs e)
        {
            

            
        }

        private void cComboGAPCurr_ValueChanged(object sender, EventArgs e)
        {

        }

        

    }


}