using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DAL.GeneralDataSetTableAdapters;
using ERMS.Logic;
using ERMS.Model;
using System.Linq;
using ERMSLib;
using Presentation.Public;
using Utilize;
using Utilize.Helper;
using MyDialogButton = Utilize.MyDialogButton;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmTBM : Form
    {
        #region CONST
        private const int CTE_COL_ID = 0;
        private const int CTE_COL_TB_Model_ID = 1;
        private const int CTE_COL_BucketName = 2;
        private const int CTE_COL_BucketType = 3;
        private const string CTE_COL_Length = "Bucket Length";
        private const int CTE_COL_Color = 5;
        private const int CTE_COL_Sequence = 6;
        private const int CTE_COL_StartDate = 7;
        private const int CTE_COL_EndDate = 8;
        #endregion

        #region VARS
        public delegate void ChangedDelegate();
        public event ChangedDelegate Changed;

        private TBM tbm;
        private bool bMouseIsDown;
        private bool bDirty;
        private int curModelID = -1;
        private string curModelType = "";
        private int dtpRowIndex = -1;
        private RoundBox rbDraggedBox, rbDraggedOver;
        private int maxBoxWidth, minBoxWidth;

        private List<int> removedIDs;
        #endregion

        public frmTBM()
        {
            InitializeComponent();
        }
        private void frmTimeBucket_Load(object sender, EventArgs e)
        {
            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader { Width = lsvModel.Width - 5 };
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;

            dgvList.MultiSelect = true;

            bMouseIsDown = false;
            bDirty = false;
            curModelID = -1;

            dtpDate.Visible = false;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpRowIndex = -1;


            maxBoxWidth = 250;
            minBoxWidth = 50;
            removedIDs = new List<int>();

            FillModel();
        }
        public void SelectedModelID()
        {
            int modelID = -1;
            if (lsvModel.SelectedItems.Count > 0)
                modelID = ((TBMInfo)lsvModel.SelectedItems[0].Tag).ID;

            clsERMSGeneral.dtModel.Rows[0]["TB_Model"] = modelID;
        }
        private void frmTBM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل خود را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Save(curModelID, false);

            }
        }

        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
            {
                //66576120 66576167 
                if (bDirty)
                {
                    if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل خود را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        Save(curModelID, false);
                }
                bDirty = false;

                if (lsvModel.SelectedItems.Count > 0)
                {
                    TBMInfo ti = (TBMInfo)lsvModel.SelectedItems[0].Tag;
                    curModelType = ti.Type;
                    curModelID = ti.ID;
                    if (curModelType == "Dynamic")
                        tsbEdit.Visible = tsbMoveUp.Visible = tsbMoveDown.Visible = false;
                    else
                        tsbEdit.Visible = tsbMoveUp.Visible = tsbMoveDown.Visible = true;

                    RefreshGrid();
                    SelectedModelID();
                    return;
                }
            }

            //else...
            curModelID = -1;
            pnlTimeBucket.Controls.Clear();
            dgvList.Columns.Clear();
        }
        private void lsvModel_DoubleClick(object sender, EventArgs e)
        {
            CommandModelEdit();
        }
        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                int rowIndex = dgvList.SelectedRows[0].Index;
                Edit(rowIndex);
            }
        }
        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (!clsERMSGeneral.CloseForm)
            {
                if (dgvList.SelectedRows.Count > 0)
                {
                    RoundBox rb = (RoundBox)dgvList.SelectedRows[0].Tag;
                    if (rb != null)
                        rb.Focus();
                }
            }
        }

        private void Delete(TBMElementInfo tei)
        {
            if (lsvModel.SelectedItems.Count == 0)
                return;

            //if (Presentation.Public.Routines.ShowMessageBoxFa("بازه زمانی انتخاب شده حذف خواهد شد. آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                if (tei.ID != -1)
                    if (Presentation.Miscs.CheckDependents.Show(CheckDep.CHECK_TBM_Element, tei.ID.ToString()) == DialogResult.Cancel)
                        return;

                //dr.Delete();
                //try
                //{
                //    dr.AcceptChanges();
                //}
                //catch { }
                if (curModelType == "Dynamic")
                {
                    tbm.DeleteTBMelement(tei.ID);


                    return;
                }
                bDirty = true;

                removedIDs.Add(tei.ID);

                ReCalcDates();
                RefreshDiagram();

                //Maybe Redundant
                dtpDate.Visible = false;
            }
        }
        private void Edit(int rowIndex)
        {
            if (lsvModel.SelectedItems.Count == 0)
                return;

            string type = dgvList.Rows[rowIndex].Cells[CTE_COL_BucketType].Value.ToString();
            if ((type == "Irr") || (type == "ToEnd"))
                return;

            DataRow dr = ((DataRowView)dgvList.Rows[rowIndex].DataBoundItem).Row;
            var tei = new TBMElementInfo();
            tbm.CloneX(dr, tei, ECloneXdir.DR2Info);

            frmTB fx = new frmTB { ElementInfo = tei };
            if (fx.ShowDialog() == DialogResult.OK)
            {
                tei = fx.ElementInfo;
                //dr.ItemArray = new object[] { tei.ID, tei.ModelID, tei.BucketName, tei.BucketType, tei.BucketLength, tei.BucketColor };

                dgvList.Rows[rowIndex].Cells[1].Value = tei.ModelID;
                dgvList.Rows[rowIndex].Cells[2].Value = tei.BucketName;
                dgvList.Rows[rowIndex].Cells[3].Value = tei.BucketType;
                dgvList.Rows[rowIndex].Cells[4].Value = tei.BucketLength;
                dgvList.Rows[rowIndex].Cells[5].Value = tei.BucketColor;
                bDirty = true;
                RefreshDiagram();
                ReCalcDates();

                try
                {
                    ((RoundBox)dgvList.Rows[rowIndex].Tag).Focus();
                }
                catch { }
                Save(curModelID, false);
            }
        }
        private void NewItem()
        {
            if (lsvModel.SelectedItems.Count == 0)
                return;
            TBMInfo ti = (TBMInfo)lsvModel.SelectedItems[0].Tag;
            if (ti.Type.Equals("Static"))
            {
                frmTB fx = new frmTB();
                if (fx.ShowDialog() == DialogResult.OK)
                {

                    TBMElementInfo tei = fx.ElementInfo;
                    tei.ModelID = ti.ID;

                    DataTable dt = (DataTable)dgvList.DataSource;

                    int pos = dt.Rows.Count - 1;
                    while (pos >= 0)
                    {
                        if (tei.BucketType == "Suspended")
                        {
                            pos = 0;
                            break;
                        }
                        string type = dgvList.Rows[pos].Cells[CTE_COL_BucketType].Value.ToString();
                        if ((type == "ToEnd") && (tei.BucketType == "ToEnd"))
                        {
                            Presentation.Public.Routines.ShowMessageBoxFa("مدل شما یك زمان پایانی دارد", "خطا",
                                                                          MessageBoxButtons.OK,
                                                                          MessageBoxIcon.Exclamation);
                            return;
                        }

                        if (tei.BucketType == "Irr")
                            break;

                        if ((type != "Irr") && (type != "Suspended") && (type != "ToEnd"))
                            break;

                        pos--;
                    }
                    DataRow dr = dt.NewRow();
                    tei.ID = -1; //New Item
                    dr.ItemArray = new object[]
                                       {
                                           tei.ID, tei.ModelID, tei.BucketName, tei.BucketType, tei.BucketLength,
                                           tei.BucketColor
                                       };
                    dt.Rows.InsertAt(dr, pos + 1);

                    bDirty = true;

                    ReCalcDates();
                    RefreshDiagram();

                    try
                    {
                        dgvList.Rows[dgvList.Rows.Count - 1].Selected = true;
                    }
                    catch
                    {
                    }
                    Save(curModelID, false);
                }
            }
            else
            {
                DateTime from = (DateTime)new DAL.UserInfo().GetDt_UpdateDate().Rows[0][0];
                try
                {
                    string date = "";
                    if (dgvList.RowCount > 0)
                        date = dgvList.Rows[dgvList.RowCount - 2].Cells[CTE_COL_EndDate].Value.ToString();
                    var year = Int32.Parse(date.Substring(0, date.IndexOf('/')));
                    date = date.Substring(date.IndexOf('/') + 1);
                    var month = Int32.Parse(date.Substring(0, date.IndexOf('/')));
                    date = date.Substring(date.IndexOf('/') + 1);
                    var day = Int32.Parse(date);
                    from = new PersianTools.Dates.PersianDate(year, month, day, PersianTools.Dates.CalendarsMode.Persian).ToGregorian;
                }
                catch { }
                frmTBDynamic fx = new frmTBDynamic(from, from);
                if (fx.ShowDialog() == DialogResult.OK)
                {




                    TBMElementInfo tei2 = fx.ElementInfo;
                    //tei.ModelID = ti.ID;


                    var items = calculateDynamicBuckets(tei2.StartDate, tei2.EndDate.Date, tei2.BucketType, tei2.BucketLength,
                                            tei2.BucketColor, ti.ID);

                    DataTable dt = (DataTable)dgvList.DataSource;

                    int pos = dt.Rows.Count - 2;
                    int i = -1;
                    foreach (var tei in items)
                    {
                        DataRow dr = dt.NewRow();
                        tei.ID = i--; //New Item
                        dr.ItemArray = new object[]
                                           {
                                               tei.ID, tei.ModelID, tei.BucketName, tei.BucketType, tei.BucketLength,
                                               tei.BucketColor,1,tei.StartDate.ToPersianDate(),tei.EndDate.ToPersianDate()
                                           };
                        dt.Rows.InsertAt(dr, ++pos);
                    }

                    dgvList.DataSource = dt;
                    bDirty = true;

                    //ReCalcDates();
                    //RefreshDiagram();

                    try
                    {
                        dgvList.Rows[dgvList.Rows.Count - 1].Selected = true;
                    }
                    catch
                    {
                    }
                    //SaveDynamic( false,items);
                }
            }
        }
        private List<TBMElementInfo> calculateDynamicBuckets(DateTime dtStart, DateTime dtEnd, string bucketType, int length, int color, int ID)
        {
            var start = dtStart.Date;
            var Items = new List<TBMElementInfo>();
            switch (bucketType)
            {
                case "Day":
                    while (start < dtEnd)
                    {
                        var tmp = new TBMElementInfo
                        {
                            ModelID = ID,
                            BucketColor = color,
                            BucketType = bucketType,
                            StartDate = start
                        };
                        var i = 0;
                        while (start < dtEnd && i++ < length)
                        {
                            start = start.AddDays(1);
                        }
                        //start = start.AddDays(length);
                        tmp.EndDate = start;
                        tmp.BucketLength = tmp.EndDate.Subtract(tmp.StartDate).Days;
                        //tmp.BucketName = length +" روز " + (Items.Count + 1);
                        if (length == 1)
                            tmp.BucketName = tmp.StartDate.ToPersianDate();
                        else
                            tmp.BucketName = tmp.StartDate.ToPersianDate() + " تا " + tmp.EndDate.ToPersianDate();
                        Items.Add(tmp);

                    }
                    break;
                case "Week":
                    while (start < dtEnd)
                    {
                        var tmp = new TBMElementInfo
                        {
                            ModelID = ID,
                            BucketColor = color,
                            BucketType = bucketType,
                            StartDate = start
                        };

                        if (new PersianTools.Dates.PersianDate(start).DayOfWeek == 6)
                            start = start.AddDays(1);
                        var i = 0;
                        while (start < dtEnd && i < length)
                        {
                            if (new PersianTools.Dates.PersianDate(start).DayOfWeek == 6)
                                i++;
                            start = start.AddDays(1);
                        }
                        if (start != dtEnd)
                            start = start.AddDays(-1);

                        tmp.EndDate = start;
                        tmp.BucketLength = tmp.EndDate.Subtract(tmp.StartDate).Days;
                        //tmp.BucketName = "هفته " + (Items.Count + 1);
                        tmp.BucketName = tmp.StartDate.ToPersianDate() + " تا " + tmp.EndDate.ToPersianDate();
                        Items.Add(tmp);

                    }
                    break;
                case "Month":
                    while (start < dtEnd)
                    {
                        var tmp = new TBMElementInfo
                        {
                            ModelID = ID,
                            BucketColor = color,
                            BucketType = bucketType,
                            StartDate = start
                        };
                        if (new PersianTools.Dates.PersianDate(start).Day == 1)
                            start = start.AddDays(1);
                        var i = 0;
                        while (start < dtEnd && i < length)
                        {
                            if (new PersianTools.Dates.PersianDate(start).Day == 1)
                                i++;
                            start = start.AddDays(1);
                        }
                        if (start != dtEnd)
                            start = start.AddDays(-1);
                        tmp.EndDate = start;
                        tmp.BucketLength = tmp.EndDate.Subtract(tmp.StartDate).Days;
                        //tmp.BucketName = "ماه " + (Items.Count + 1);
                        tmp.BucketName = tmp.StartDate.ToPersianDate() + " تا " + tmp.EndDate.ToPersianDate();
                        if (length == 1)
                            tmp.BucketName += string.Format(" ({0})", FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(tmp.StartDate).LocalizedMonthName);
                        Items.Add(tmp);
                        //start = start.AddDays(-1);

                    }
                    break;
                case "Year":
                    while (start < dtEnd)
                    {
                        var tmp = new TBMElementInfo
                        {
                            ModelID = ID,
                            BucketColor = color,
                            BucketType = bucketType,
                            StartDate = start
                        };
                        if (new PersianTools.Dates.PersianDate(start).DayOfYear == 1)
                            start = start.AddDays(1);

                        var i = 0;
                        while (start < dtEnd && i < length)
                        {
                            if (new PersianTools.Dates.PersianDate(start).DayOfYear == 1)
                                i++;
                            start = start.AddDays(1);
                        }
                        if (start != dtEnd)
                            start = start.AddDays(-1);

                        //start = start.AddDays(1);
                        tmp.EndDate = start;
                        tmp.BucketLength = tmp.EndDate.Subtract(tmp.StartDate).Days;
                        //tmp.BucketName = "سال " + (Items.Count + 1);
                        tmp.BucketName = tmp.StartDate.ToPersianDate() + " تا " + tmp.EndDate.ToPersianDate();
                        if (length == 1)
                            tmp.BucketName += string.Format(" ({0})", FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(tmp.StartDate).Year);
                        Items.Add(tmp);
                        //start = start.AddDays(-1);

                    }
                    break;
                case "Other":
                    if (start <= dtEnd)
                    {
                        var tmp = new TBMElementInfo
                        {
                            ModelID = ID,
                            BucketColor = color,
                            BucketType = bucketType,
                            StartDate = start
                        };

                        tmp.EndDate = dtEnd;
                        tmp.BucketLength = tmp.EndDate.Subtract(tmp.StartDate).Days;
                        tmp.BucketName = tmp.StartDate.ToPersianDate() + " تا " + tmp.EndDate.ToPersianDate();
                        Items.Add(tmp);

                    }
                    break;
            }
            return Items;

        }

        private void Save(int modelID, bool bMessage)
        {
            if (curModelType == "Dynamic")
            {
                var items =
                    ((DataTable)dgvList.DataSource).AsEnumerable().Where(a => a[7].ToString().Length != 0)
                    .Select(
                        a => new TBMElementInfo
                        {
                            ID = (int)a[0],
                            ModelID = (int)a[1],
                            BucketName = a[2].ToString()
                                     ,
                            BucketType = a[3].ToString(),
                            BucketLength = (int)a[4],
                            BucketColor = (int)a[5]
                                     ,
                            Sequence = (int)a[6],
                            StartDate =
                                         FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(a[7].ToString()).Date
                                     ,
                            EndDate =
                                         FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(a[8].ToString()).Date
                        }).ToList();
                items[items.Count - 1].StartDate = items[items.Count - 2].EndDate;
                SaveDynamic(bMessage, items);
                return;
            }
            //tbm.DeleteTBMelements(modelID);
            int i = 1;
            foreach (DataGridViewRow dgvr in dgvList.Rows)
            {
                DataRow dr = ((DataRowView)dgvr.DataBoundItem).Row;

                TBMElementInfo tei = new TBMElementInfo();
                tbm.CloneX(dr, tei, ECloneXdir.DR2Info);
                tei.Sequence = tei.BucketType == "Suspended" ? 0 : i++;
                if (tei.ID < 0)
                    tbm.InsertTBMelement(tei);
                else
                    tbm.UpdateTBMelement(tei);
            }

            foreach (int id in removedIDs)
                tbm.DeleteTBMelement(id);
            removedIDs.Clear();
            if (curModelType != "Dynamic")
                tbm.InitTBM(modelID);

            if (bMessage)
                Public.Routines.ShowMessageBoxFa("مدل شما ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGrid(); //reget all items

            if (Changed != null)
                Changed();
            bDirty = false;
        }
        private void SaveDynamic(bool bMessage, List<TBMElementInfo> Items)
        {
            //tbm.DeleteTBMelements(modelID);
            int i = 1;
            foreach (var tei in Items)
            {

                if (tei.ID < 0)
                    tbm.InsertTBMelement(tei);
                else
                    tbm.UpdateTBMelement(tei);
            }
            var dt = new DataTable();

            const string q = "[Update_Dynamic_TB]";
            var db = new SqlCommand(q, new SqlConnection(DAL.Properties.Settings.Default.Risk_Mng_MehrConnectionString)) { CommandType = CommandType.StoredProcedure, CommandTimeout = 0 };
            db.Parameters.Add(new SqlParameter("@TB_Model_Id", SqlDbType.Int) { Value = Items[0].ModelID });
            db.Parameters.Add(new SqlParameter("@StartDate", SqlDbType.Date) { Value = (DateTime)new DAL.UserInfo().GetDt_UpdateDate().Rows[0][0] });


            db.Connection.Open();
            db.ExecuteNonQuery();
            db.Connection.Close();



            foreach (int id in removedIDs)
                tbm.DeleteTBMelement(id);
            removedIDs.Clear();

            if (bMessage)
                Public.Routines.ShowMessageBoxFa("مدل شما ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGrid(); //reget all items

            if (Changed != null)
                Changed();
            bDirty = false;
        }

        private void tsbModelNew_Click(object sender, EventArgs e)
        {
            CommandModelNew();
        }
        private void tsbModelNewCopy_Click(object sender, EventArgs e)
        {
            CommandModelCreateCopy();
        }
        private void tsbModelEdit_Click(object sender, EventArgs e)
        {
            CommandModelEdit();
        }
        private void tsbModelRemove_Click(object sender, EventArgs e)
        {
            CommandModelRemove();
        }

        private void CommandModelNew()
        {
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل خود را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Save(curModelID, false);

            }

            //string descr = Presentation.Public.Routines.ShowInputBox();
            frmInputTextTB fx = new frmInputTextTB();
            fx.ShowDialog();

            string descr = fx.ReturnValue;
            if (!string.IsNullOrEmpty(descr))
            {
                ListViewItem lvi = new ListViewItem();
                TBMInfo fi = new TBMInfo();
                lvi.Text = descr;
                lvi.Tag = fi;
                lsvModel.Items.Add(lvi);
                lvi.Selected = true;


                fi.ModelName = descr;
                fi.Type = fx.Type;
                fi.ID = tbm.InsertTBM(fi);
                curModelID = fi.ID;
                curModelType = fi.Type;

                lsvModel_SelectedIndexChanged(null, null);
                if (curModelType == "Dynamic")
                {
                    var now = (DateTime)new DAL.UserInfo().GetDt_UpdateDate().Rows[0][0];
                    var dt = (DataTable)dgvList.DataSource;
                    var dr2 = dt.NewRow();
                    var dr3 = dt.NewRow();


                    dr2.ItemArray = new object[]
                                       {
                                           -1, fi.ID, "سررسید تا 2 ماه قبل", "Year", 1,
                                           -255, 0, FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(now.AddDays(-60)).ToString()
                                               .Substring(0, 10),
                                           FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(now).ToString()
                                               .Substring(0, 10)
                                       };
                    dr3.ItemArray = new object[]
                                       {
                                           -1, fi.ID, "تا انتها", "Year", 1,
                                           -255, 1,
                                           FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(now).ToString()
                                               .Substring(0, 10)
                                               ,"1500/01/01"
                                       };

                    dt.Rows.InsertAt(dr2, 1);
                    dt.Rows.InsertAt(dr3, 2);
                    dgvList.DataSource = dt;
                    Save(fi.ID, false);
                }
            }


        }
        private void CommandModelCreateCopy()
        {
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل خود را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Save(curModelID, false);

            }

            if (lsvModel.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvModel.SelectedItems[0];
                ListViewItem lviNew = new ListViewItem();
                TBMInfo ti = (TBMInfo)lvi.Tag;
                TBMInfo tiNew = new TBMInfo { ModelName = "Copy of " + ti.ModelName, Type = ti.Type };

                //Rev 1.01 - Removed
                //tiNew.ProfileID = ti.ProfileID; 

                lviNew.Text = "Copy of " + lvi.Text;

                lviNew.Tag = tiNew;
                lsvModel.Items.Add(lviNew);
                lviNew.Selected = true;

                //                                
                tiNew.ID = tbm.InsertTBM(tiNew);
                tbm.CreateCopy(ti.ID, tiNew.ID);

                lviNew.Selected = true;
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
                    TBMInfo fi = (TBMInfo)lvi.Tag;
                    fi.ModelName = descr;
                    tbm.UpdateTBM(fi);
                }
            }
        }
        private void CommandModelRemove()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("مدل انتخاب شده و تمامی مدلهای دلخواه پركردن بسته های زمانی حذف خواهد شد. آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem lvi = lsvModel.SelectedItems[0];
                    TBMInfo ti = (TBMInfo)lvi.Tag;

                    if (Presentation.Miscs.CheckDependents.Show(CheckDep.CHECK_TBM, ti.ID.ToString()) == DialogResult.Cancel)
                        return;

                    lvi.Remove();
                    tbm.DeleteTBM(ti.ID);
                }
            }
        }
        private void tsbModelSave_Click(object sender, EventArgs e)
        {
            if (lsvModel.SelectedItems.Count > 0)
                Save(curModelID, true);
        }

        private void RefreshDiagram()
        {
           

        }

        void rb_MouseUp(object sender, MouseEventArgs e)
        {
            bMouseIsDown = false;
        }
        void rb_DoubleClick(object sender, EventArgs e)
        {
            RoundBox rb = (RoundBox)sender;
            int rowIndex = ((DataGridViewRow)rb.Tag).Index;

            Edit(rowIndex);
        }
        void rb_DragLeave(object sender, EventArgs e)
        {
            rbDraggedBox.ForeColor = Color.Blue;
        }
        void rb_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            rbDraggedOver = (RoundBox)sender;
            rbDraggedBox.ForeColor = Color.Red;
        }
        void rb_DragDrop(object sender, DragEventArgs e)
        {
            string bucketType = ((DataGridViewRow)rbDraggedOver.Tag).Cells[CTE_COL_BucketType].Value.ToString();
            if ((bucketType == "Irr") || (bucketType == "ToEnd"))
                return;

            DataGridViewRow dgvrBox = (DataGridViewRow)rbDraggedBox.Tag;
            DataRowView drvBox = (DataRowView)dgvrBox.DataBoundItem;
            DataTable dt = drvBox.DataView.Table;
            int indexBox = dt.Rows.IndexOf(drvBox.Row);

            DataGridViewRow dgvrOver = (DataGridViewRow)rbDraggedOver.Tag;
            DataRowView drvOver = (DataRowView)dgvrOver.DataBoundItem;
            int indexOver = dt.Rows.IndexOf(drvOver.Row);

            if (indexBox != indexOver)
            {

                object[] boxAR = dt.Rows[indexBox].ItemArray;
                //var objects = dt.Rows[indexOver].ItemArray;
                dt.Rows.RemoveAt(indexBox);
                DataRow dr = dt.NewRow();
                dr.ItemArray = boxAR;
                dt.Rows.InsertAt(dr, indexOver);

                ReCalcDates();
                RefreshDiagram();
            }
        }
        void rb_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && (e.Clicks == 1))
            {
                bMouseIsDown = true;

                RoundBox rb = (RoundBox)sender;
                ((DataGridViewRow)rb.Tag).Selected = true;
            }
        }
        void rb_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMouseIsDown)
            {
                rbDraggedBox = (RoundBox)sender;
                string bucketType = ((DataGridViewRow)rbDraggedBox.Tag).Cells[CTE_COL_BucketType].Value.ToString();
                if ((bucketType == "Irr") || (bucketType == "ToEnd"))
                    return;

                if (rbDraggedBox != null)
                    pnlTimeBucket.DoDragDrop(rbDraggedBox.Tag, DragDropEffects.Move);
            }
            bMouseIsDown = false;
        }

        private void FillModel()
        {
            DataTable dt = new DataTable();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem { Text = fi.ModelName, Tag = fi };
                lsvModel.Items.Add(lvi);
            }
        }
        private void RefreshGrid()
        {
            Presentation.Public.Helper h = new Presentation.Public.Helper();
            h.FormatDataGridView(dgvList);

            dgvList.RightToLeft = RightToLeft.Yes;
            removedIDs.Clear();

            ReBind();
            RefreshDiagram();
        }
        private void ReBind()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                dgvList.Columns.Clear();

                TBMInfo ti = (TBMInfo)lsvModel.SelectedItems[0].Tag;
                dgvList.DataSource = tbm.GetTBMelements(ti.ID);

                //dgvList.Columns[CTE_COL_BucketName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvList.Columns[CTE_COL_BucketType].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvList.Columns[CTE_COL_Length].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvList.Columns[CTE_COL_BucketName].MinimumWidth = (dgvList.Width) / 5;
                dgvList.Columns[CTE_COL_BucketType].MinimumWidth = (dgvList.Width) / 5;
                dgvList.Columns[CTE_COL_Length].MinimumWidth = (dgvList.Width) / 5;

                dgvList.Columns[CTE_COL_BucketName].HeaderText = "نام بسته";
                dgvList.Columns[CTE_COL_BucketType].HeaderText = "نوع بسته";
                dgvList.Columns[CTE_COL_Length].HeaderText = "طول بسته";

                dgvList.Columns[CTE_COL_ID].Visible = false;
                dgvList.Columns[CTE_COL_TB_Model_ID].Visible = false;
                dgvList.Columns[CTE_COL_Color].Visible = false;
                dgvList.Columns[CTE_COL_Sequence].Visible = false; //Revised 1.3

                var startDateCol = dgvList.Columns[CTE_COL_StartDate];
                {
                    startDateCol.MinimumWidth = 50;
                    startDateCol.HeaderText = "تاریخ شروع";
                };
                startDateCol.MinimumWidth = (dgvList.Width) / 5;

                var endDateCol = dgvList.Columns[CTE_COL_EndDate];
                {
                    endDateCol.MinimumWidth = 50;
                    endDateCol.HeaderText = "تاریخ پایان";
                };
                endDateCol.MinimumWidth = (dgvList.Width) / 5;

                foreach (DataGridViewColumn col in dgvList.Columns)
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;

                dtpDate.Visible = false;

                ReCalcDates();
            }
        }
        private void ReCalcDates()
        {
            if (curModelType != "Dynamic")
            {
                DateTime dt = DateTime.Now.AddDays(-1);
                PersianTools.Dates.PersianDate P;
                PersianTools.Dates.PersianDate PE;

                for (int i = 0; i <= dgvList.Rows.Count - 1; i++)
                {
                    int len = (int)dgvList.Rows[i].Cells[CTE_COL_Length].Value;
                    string type = dgvList.Rows[i].Cells[CTE_COL_BucketType].Value.ToString();


                    if (type != "Irr" && (type != "Suspended"))
                    //   dgvList.Rows[i].Cells[CTE_COL_StartDate].Value = dt.AddDays(1).ToString("MMMM dd, yyyy");
                    {
                        P = new PersianTools.Dates.PersianDate(dt.AddDays(1));
                        dgvList.Rows[i].Cells[CTE_COL_StartDate].Value = dt.AddDays(1);
                        // dgvList.Rows[i].Cells[CTE_COL_StartDate].Value =  P.FormatedDate("yyyy/MM/dd");
                    }
                    else
                        dgvList.Rows[i].Cells[CTE_COL_StartDate].Value = string.Empty;

                    if (type == "Day") dt = dt.AddDays(len + 1); //by solmaz 87/07/23
                    if (type == "Week") dt = dt.AddDays(len * 7);
                    if (type == "Month") dt = dt.AddMonths(len);
                    if (type == "Year") dt = dt.AddYears(len);

                    if ((type != "ToEnd") && (type != "Irr") && (type != "Suspended"))
                    {
                        PE = new PersianTools.Dates.PersianDate(dt);
                        dgvList.Rows[i].Cells[CTE_COL_EndDate].Value = dt;
                        //  dgvList.Rows[i].Cells[CTE_COL_EndDate].Value = dt.ToString("MMMM dd, yyyy");
                    }

                    // dgvList.Rows[i].Cells[CTE_COL_EndDate].Value = dt.ToString("MMMM dd, yyyy");
                    else
                        dgvList.Rows[i].Cells[CTE_COL_EndDate].Value = string.Empty;

                }
            }
            DataTable d = (DataTable)dgvList.DataSource;
            dgvList.DataSource = d.ConfigDateTimeToPersian();
        }
        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if ((e.ColumnIndex == CTE_COL_EndDate) && (e.RowIndex != -1)) 
            //{
            //    string type = dgvList.Rows[e.RowIndex].Cells[CTE_COL_BucketType].Value.ToString();
            //    if ((type != "ToEnd") && (type != "Irr"))                
            //    {
            //        Rectangle cellBound = dgvList.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            //        dtpDate.Location = new Point(dgvList.Left + cellBound.Left, dgvList.Top + cellBound.Top);
            //        dtpDate.Size = new Size(dgvList.Columns[CTE_COL_EndDate].Width, dgvList.RowTemplate.MinimumHeight);

            //        dtpRowIndex = e.RowIndex;
            //        dtpDate.Value = Convert.ToDateTime(dgvList.Rows[e.RowIndex].Cells[CTE_COL_EndDate].Value);
            //        dtpDate.Visible = true;

            //    }         
            //    else
            //        dtpDate.Visible = false;
            //}
            //else
            //{
            //    dtpDate.Visible = false;
            //}
        }
        private void tsmiZoom_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;

            int zoom = Convert.ToInt32(tsmi.Tag);
            switch (zoom)
            {
                case 50:
                    minBoxWidth = 60;
                    maxBoxWidth = 200;
                    tsmi50.Checked = tsmi100.Checked = tsmi200.Checked = tsmi300.Checked = tsmi400.Checked = tsmi500.Checked = false;
                    tsmi50.Checked = true;
                    break;
                case 100:
                    minBoxWidth = 60;
                    maxBoxWidth = 300;
                    tsmi50.Checked = tsmi100.Checked = tsmi200.Checked = tsmi300.Checked = tsmi400.Checked = tsmi500.Checked = false;
                    tsmi100.Checked = true;
                    break;
                case 200:
                    minBoxWidth = 65;
                    maxBoxWidth = 400;
                    tsmi50.Checked = tsmi100.Checked = tsmi200.Checked = tsmi300.Checked = tsmi400.Checked = tsmi500.Checked = false;
                    tsmi200.Checked = true;
                    break;
                case 300:
                    minBoxWidth = 75;
                    maxBoxWidth = 500;
                    tsmi50.Checked = tsmi100.Checked = tsmi200.Checked = tsmi300.Checked = tsmi400.Checked = tsmi500.Checked = false;
                    tsmi300.Checked = true;
                    break;
                case 400:
                    minBoxWidth = 90;
                    maxBoxWidth = 700;
                    tsmi50.Checked = tsmi100.Checked = tsmi200.Checked = tsmi300.Checked = tsmi400.Checked = tsmi500.Checked = false;
                    tsmi400.Checked = true;
                    break;
                case 500:
                    minBoxWidth = 110;
                    maxBoxWidth = 1000;
                    tsmi50.Checked = tsmi100.Checked = tsmi200.Checked = tsmi300.Checked = tsmi400.Checked = tsmi500.Checked = false;
                    tsmi500.Checked = true;
                    break;
            }

            RefreshDiagram();
        }
        private void tsmiLabel_Click(object sender, EventArgs e)
        {
            if (sender == tsmiLabelName)
            {
                tsmiLabelName.Checked = true;
                tsmiLabelType.Checked = false;
            }
            else
            {
                tsmiLabelName.Checked = false;
                tsmiLabelType.Checked = true;
            }

            RefreshDiagram();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            if (spcAll.Panel1.Width == 0)
            {
                //btnModel.Image = Properties.Resources.panLeft;
                spcAll.Panel1Collapsed = false;
            }
            else
            {
                //btnModel.Image = Properties.Resources.PanRight;
                spcAll.Panel1Collapsed = true;
            }
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            NewItem();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                int rowIndex = dgvList.SelectedRows[0].Index;
                Edit(rowIndex);
            }
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("عناصر انتخاب شده حذف خواهد شد. آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {

                    List<TBMElementInfo> ls = new List<TBMElementInfo>();
                    for (int i = 0; i < dgvList.SelectedRows.Count; i++)
                    {
                        int rowIndex = dgvList.SelectedRows[i].Index;
                        DataRow dr = ((DataRowView)dgvList.Rows[rowIndex].DataBoundItem).Row;
                        TBMElementInfo tei = new TBMElementInfo();
                        tbm.CloneX(dr, tei, ECloneXdir.DR2Info);
                        ls.Add(tei);

                    }
                    foreach (var l in ls)
                        Delete(l);
                }
            }
            ReBind();
            RefreshDiagram();
        }

        private void tsbMoveDown_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void MoveDown()
        {
            if (dgvList.CurrentRow == null || dgvList.CurrentRow.Index == dgvList.Rows.Count - 1)
                return;
            string bucketType = dgvList.CurrentRow.Cells[CTE_COL_BucketType].Value.ToString();
            if ((bucketType == "Irr") || (bucketType == "ToEnd"))
                return;

            DataGridViewRow dgvrBox = dgvList.CurrentRow;
            int rowIndex = dgvrBox.Index;
            DataRowView drvBox = (DataRowView)dgvrBox.DataBoundItem;
            DataTable dt = drvBox.DataView.Table;
            int indexBox = dt.Rows.IndexOf(drvBox.Row);

            DataGridViewRow dgvrOver = dgvList.Rows[dgvList.CurrentRow.Index + 1];
            DataRowView drvOver = (DataRowView)dgvrOver.DataBoundItem;
            int indexOver = dt.Rows.IndexOf(drvOver.Row);

            bucketType = dgvrOver.Cells[CTE_COL_BucketType].Value.ToString();
            if ((bucketType == "Irr") || (bucketType == "ToEnd"))
                return;

            if (indexBox != indexOver)
            {

                object[] boxAR = dt.Rows[indexBox].ItemArray;
                //var objects = dt.Rows[indexOver].ItemArray;
                dt.Rows.RemoveAt(indexBox);
                DataRow dr = dt.NewRow();
                dr.ItemArray = boxAR;
                dt.Rows.InsertAt(dr, indexOver);

                ReCalcDates();
                RefreshDiagram();

                dgvList.CurrentCell = dgvList.Rows[rowIndex + 1].Cells[CTE_COL_BucketName];
            }
        }
        private void tsbMoveUp_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void MoveUp()
        {
            if (dgvList.CurrentRow == null || dgvList.CurrentRow.Index == 0)
                return;
            string bucketType = dgvList.CurrentRow.Cells[CTE_COL_BucketType].Value.ToString();
            if ((bucketType == "Irr") || (bucketType == "ToEnd"))
                return;

            DataGridViewRow dgvrBox = dgvList.CurrentRow;
            int rowIndex = dgvrBox.Index;
            DataRowView drvBox = (DataRowView)dgvrBox.DataBoundItem;
            DataTable dt = drvBox.DataView.Table;
            int indexBox = dt.Rows.IndexOf(drvBox.Row);

            DataGridViewRow dgvrOver = dgvList.Rows[dgvList.CurrentRow.Index - 1];
            DataRowView drvOver = (DataRowView)dgvrOver.DataBoundItem;
            int indexOver = dt.Rows.IndexOf(drvOver.Row);

            if (indexBox != indexOver)
            {

                object[] boxAR = dt.Rows[indexBox].ItemArray;
                //var objects = dt.Rows[indexOver].ItemArray;
                dt.Rows.RemoveAt(indexBox);
                DataRow dr = dt.NewRow();
                dr.ItemArray = boxAR;
                dt.Rows.InsertAt(dr, indexOver);

                ReCalcDates();
                RefreshDiagram();

                dgvList.CurrentCell = dgvList.Rows[rowIndex - 1].Cells[CTE_COL_BucketName];
            }
        }

        private void frmTBM_KeyDown(object sender, KeyEventArgs e)
        {
            //New
            if (e.Control && e.KeyCode.ToString() == "N")
            {
                CommandModelNew();
            }
            //Copy
            if (e.Control && e.KeyCode.ToString() == "C")
            {
                CommandModelCreateCopy();
            }
            //Edit
            if (e.Control && e.KeyCode.ToString() == "E")
            {
                CommandModelEdit();
            }
            //save
            if (e.Control && e.KeyCode.ToString() == "S")
            {
                if (lsvModel.SelectedItems.Count > 0)
                    Save(curModelID, true);
            }
            //Remove
            if (e.Control && e.KeyCode.ToString() == "D")
            {
                CommandModelRemove();
            }

            if (e.Alt && e.KeyCode.ToString() == "N")
            {
                NewItem();
            }
            //if (e.Alt && e.KeyCode.ToString() == "D")
            //{
            //    if (dgvList.SelectedRows.Count > 0)
            //    {
            //        int rowIndex = dgvList.SelectedRows[0].Index;
            //        Delete(rowIndex);
            //    }
            //}

            if (e.Alt && e.KeyCode.ToString() == "E")
            {
                if (dgvList.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvList.SelectedRows[0].Index;
                    Edit(rowIndex);
                }
            }
            //MoveUp
            if (e.Shift && e.KeyCode == Keys.Up)
            {
                MoveUp();
            }
            if (e.Shift && e.KeyCode == Keys.Down)
            {
                MoveDown();
            }
        }
        public void DoPrint()
        {

            clsERMSGeneral.dgvActive = dgvList;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "TBM";
        }

        private void tsbModelRefres_Click(object sender, EventArgs e)
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

        private void cbMdl_CButtonClicked(object sender, EventArgs e)
        {
            if (spcAll.Panel1Collapsed == false)
            {
                spcAll.Panel1Collapsed = true;
                btnModel.DefaultImage = Properties.Resources.S_Panleft2;
                btnModel.HoverImage = Properties.Resources.S_Panleft_Hover2;
            }
            else if (spcAll.Panel1Collapsed == true)
            {
                spcAll.Panel1Collapsed = false;
                btnModel.DefaultImage = Properties.Resources.S_PanRight3;
                btnModel.HoverImage = Properties.Resources.S_PanRight_Hover;

            }
        }

        private void tsbShowBaloon_Click(object sender, EventArgs e)
        {

        }

        private void tsbAutomaticCreate_Click(object sender, EventArgs e)
        {
            ProgressBox.Show();
            try
            {
                new SWART_ReportsTableAdapter().Create_Dynamic_TB(GlobalInfo.appPath);
                Public.Routines.ShowMessageBoxFa("مدل شما ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tsbRefresh_Click(null, null);

            }
            catch (Exception exception)
            {
                Utilize.Routines.ShowErrorMessageFa("خطا", "در اجرای دستور شما،خطا رخ داده است", exception.Message,
                                                        MyDialogButton.OK);

            }
            finally { ProgressBox.Hide(); }
        }

    }
}