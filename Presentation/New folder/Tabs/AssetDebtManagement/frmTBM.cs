using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ERMS.Logic;
using ERMS.Model;
using ERMSLib;
using Presentation.Public;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmTBM : BaseForm, IPrintable
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
            tbm = new TBM();

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader { Width = lsvModel.Width - 5 };
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;


            dgvList.MultiSelect = false;

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
                if (bDirty)
                {
                    if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل خود را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        Save(curModelID, false);
                }
                bDirty = false;

                if (lsvModel.SelectedItems.Count > 0)
                {
                    TBMInfo ti = (TBMInfo)lsvModel.SelectedItems[0].Tag;
                    curModelID = ti.ID;
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

        private void Delete(int rowIndex)
        {
            if (lsvModel.SelectedItems.Count == 0)
                return;

            if (Presentation.Public.Routines.ShowMessageBoxFa("بازه زمانی انتخاب شده حذف خواهد شد. آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                DataRow dr = ((DataRowView)dgvList.Rows[rowIndex].DataBoundItem).Row;
                TBMElementInfo tei = new TBMElementInfo();
                tbm.CloneX(dr, tei, ECloneXdir.DR2Info);

                if (tei.ID != -1)
                    if (Presentation.Miscs.CheckDependents.Show(CheckDep.CHECK_TBM_Element, tei.ID.ToString()) == DialogResult.Cancel)
                        return;

                dr.Delete();
                try
                {
                    dr.AcceptChanges();
                }
                catch { }
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
            TBMElementInfo tei = new TBMElementInfo();
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

            frmTB fx = new frmTB();
            if (fx.ShowDialog() == DialogResult.OK)
            {
                TBMInfo ti = (TBMInfo)lsvModel.SelectedItems[0].Tag;
                TBMElementInfo tei = fx.ElementInfo;
                tei.ModelID = ti.ID;

                DataTable dt = (DataTable)dgvList.DataSource;

                foreach(DataRow drs in dt.Rows)
                {
                    //if(dr["Name"]. )
                }
                

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
                        Presentation.Public.Routines.ShowMessageBoxFa("مدل شما یك زمان پایانی دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                dr.ItemArray = new object[] { tei.ID, tei.ModelID, tei.BucketName, tei.BucketType, tei.BucketLength, tei.BucketColor };
                dt.Rows.InsertAt(dr, pos + 1);

                bDirty = true;

                ReCalcDates();
                RefreshDiagram();

                try
                {
                    dgvList.Rows[dgvList.Rows.Count - 1].Selected = true;
                }
                catch { }
                Save(curModelID, false);
            }
        }

        private void Save(int modelID, bool bMessage)
        {
            //tbm.DeleteTBMelements(modelID);
            int i = 1;
            foreach (DataGridViewRow dgvr in dgvList.Rows)
            {
                DataRow dr = ((DataRowView)dgvr.DataBoundItem).Row;

                TBMElementInfo tei = new TBMElementInfo();
                tbm.CloneX(dr, tei, ECloneXdir.DR2Info);
                if (tei.BucketType == "Suspended")
                    tei.Sequence = 0;
                else
                    tei.Sequence = i++;
                if (tei.ID == -1)
                    tbm.InsertTBMelement(tei);
                else
                    tbm.UpdateTBMelement(tei);
            }

            foreach (int id in removedIDs)
                tbm.DeleteTBMelement(id);
            removedIDs.Clear();

            tbm.InitTBM(modelID);

            if (bMessage)
                Presentation.Public.Routines.ShowMessageBoxFa("مدل شما ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            string descr = Presentation.Public.Routines.ShowInputBox();
            if (descr != string.Empty)
            {
                ListViewItem lvi = new ListViewItem();
                TBMInfo fi = new TBMInfo();
                lvi.Text = descr;
                lvi.Tag = fi;
                lsvModel.Items.Add(lvi);
                lvi.Selected = true;

                //                
                fi.ModelName = descr;
                fi.ID = tbm.InsertTBM(fi);
                curModelID = fi.ID;
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
                TBMInfo tiNew = new TBMInfo { ModelName = "Copy of " + ti.ModelName };

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
            pnlTimeBucket.Controls.Clear();
            Control c = new Control { Left = 1000 };
            pnlTimeBucket.Controls.Add(c);

            int x = 5;
            const int y = 5;
            int w = 0;
            const int h = 70;
            int len;
            string labelType = string.Empty;
            string type;

            int maxValue = 0;
            for (int i = 0; i <= dgvList.Rows.Count - 1; i++)
            {
                len = (int)dgvList.Rows[i].Cells[CTE_COL_Length].Value;
                type = dgvList.Rows[i].Cells[CTE_COL_BucketType].Value.ToString();
                if (type == "Year")
                    w = 365;
                if (type == "Month")
                    w = 30;
                if (type == "Week")
                    w = 7;
                if (type == "Day")
                    w = 1;

                maxValue = (w * len > maxValue) ? w * len : maxValue;
            }

            for (int i = 0; i <= dgvList.Rows.Count - 1; i++)
            {
                Color fillColor = Color.FromArgb((int)dgvList.Rows[i].Cells[CTE_COL_Color].Value);

                //var value = (int)dgvList.Rows[i].Cells[CTE_COL_ID].Value;
                len = (int)dgvList.Rows[i].Cells[CTE_COL_Length].Value;
                string labelName = dgvList.Rows[i].Cells[CTE_COL_BucketName].Value.ToString();
                type = dgvList.Rows[i].Cells[CTE_COL_BucketType].Value.ToString();
                if (type == "Year")
                {
                    w = 365;
                    labelType = string.Format("{0}Y", len);
                }
                if (type == "Month")
                {
                    w = 30;
                    labelType = string.Format("{0}M", len);
                }
                if (type == "Week")
                {
                    w = 7;
                    labelType = string.Format("{0}W", len);
                }
                if (type == "Day")
                {
                    w = 1;
                    labelType = string.Format("{0}D", len);
                }
                if (type == "ToEnd")
                {
                    fillColor = Color.Yellow;
                    labelType = string.Format("ToEnd");
                    labelName = "ToEnd";
                }
                if (type == "Irr")
                {
                    fillColor = Color.White;
                    labelType = string.Format("Irr");
                    labelName = "Irr";
                }

                //                
                w = Convert.ToInt32((maxBoxWidth - minBoxWidth) * (w * len * 1.0 - 1.0) / (maxValue - 1.001) + minBoxWidth);
                if (type == "Irr") w = minBoxWidth / 2;
                if (type == "ToEnd") w = maxBoxWidth;

                RoundBox rb = new RoundBox
                {
                    Left = x,
                    Width = w,
                    Top = y,
                    Height = h,
                    Visible = true,
                    BackColor = Color.Transparent,
                    FillColor = fillColor,
                    Text = tsmiLabelName.Checked ? labelName : labelType,
                    AllowDrop = true,
                    IsArrowVisible = (type == "ToEnd")
                };
                rb.DoubleClick += new EventHandler(rb_DoubleClick);
                rb.MouseDown += new MouseEventHandler(rb_MouseDown);
                rb.MouseMove += new MouseEventHandler(rb_MouseMove);
                rb.DragDrop += new DragEventHandler(rb_DragDrop);
                rb.DragEnter += new DragEventHandler(rb_DragEnter);
                rb.DragLeave += new EventHandler(rb_DragLeave);
                rb.MouseUp += new MouseEventHandler(rb_MouseUp);

                x = x + w;

                //
                dgvList.Rows[i].Tag = rb;
                rb.Tag = dgvList.Rows[i];

                pnlTimeBucket.Controls.Add(rb);
            }
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
            DataTable dt = tbm.GetTBMs();
            foreach (DataRow dr in dt.Rows)
            {
                TBMInfo fi = new TBMInfo();
                tbm.CloneX(dr, fi, ECloneXdir.DR2Info);

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

                dgvList.Columns[CTE_COL_BucketName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvList.Columns[CTE_COL_BucketType].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvList.Columns[CTE_COL_Length].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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

                DataGridViewTextBoxColumn startDateCol = new DataGridViewTextBoxColumn
                {
                    MinimumWidth = 100,
                    HeaderText = "تاریخ شروع",
                    Name = "CTE_COL_StartDate",
                    DefaultCellStyle =
                    {
                        Alignment =
                            DataGridViewContentAlignment.MiddleCenter
                    }
                };
                startDateCol.MinimumWidth = (dgvList.Width) / 5;
                dgvList.Columns.Add(startDateCol);

                DataGridViewTextBoxColumn endDateCol = new DataGridViewTextBoxColumn
                {
                    MinimumWidth = 100,
                    HeaderText = "تاریخ پایان",
                    Name = "CTE_COL_EndDate",
                    DefaultCellStyle =
                    {
                        Alignment =
                            DataGridViewContentAlignment.MiddleCenter
                    }
                };
                endDateCol.MinimumWidth = (dgvList.Width) / 5;
                dgvList.Columns.Add(endDateCol);

                foreach (DataGridViewColumn col in dgvList.Columns)
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;

                dtpDate.Visible = false;
                ReCalcDates();
            }
        }
        private void ReCalcDates()
        {
            DateTime dt = DateTime.Now.AddDays(-1);
            PersianTools.Dates.PersianDate P;
            PersianTools.Dates.PersianDate PE;

            for (int i = 0; i <= dgvList.Rows.Count - 1; i++)
            {
                int len = (int)dgvList.Rows[i].Cells["Bucket Length"].Value;
                string type = dgvList.Rows[i].Cells["Bucket Type"].Value.ToString();


                if (type != "Irr" && (type != "Suspended"))
                //   dgvList.Rows[i].Cells[CTE_COL_StartDate].Value = dt.AddDays(1).ToString("MMMM dd, yyyy");
                {
                    P = new PersianTools.Dates.PersianDate(dt.AddDays(1));
                    dgvList.Rows[i].Cells["CTE_COL_StartDate"].Value = P.FormatedDate("yyyy/MM/dd");
                    // dgvList.Rows[i].Cells[CTE_COL_StartDate].Value =  P.FormatedDate("yyyy/MM/dd");
                }
                else
                    dgvList.Rows[i].Cells["CTE_COL_StartDate"].Value = string.Empty;

                if (type == "Day") dt = dt.AddDays(len + 1); //by solmaz 87/07/23
                if (type == "Week") dt = dt.AddDays(len * 7);
                if (type == "Month") dt = dt.AddMonths(len);
                if (type == "Year") dt = dt.AddYears(len);

                if ((type != "ToEnd") && (type != "Irr") && (type != "Suspended"))
                {
                    PE = new PersianTools.Dates.PersianDate(dt);
                    dgvList.Rows[i].Cells["CTE_COL_EndDate"].Value = PE.FormatedDate("yyyy/MM/dd");
                    //  dgvList.Rows[i].Cells[CTE_COL_EndDate].Value = dt.ToString("MMMM dd, yyyy");
                }

                   // dgvList.Rows[i].Cells[CTE_COL_EndDate].Value = dt.ToString("MMMM dd, yyyy");
                else
                    dgvList.Rows[i].Cells["CTE_COL_EndDate"].Value = string.Empty;
            }
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
        private void dgvList_Click(object sender, EventArgs e)
        {
            dtpDate.Visible = false;
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDate.Visible) //Ignore manual value set in CellClick Event
            {
                DateTime dtNew = dtpDate.Value;
                Convert.ToDateTime(dgvList.Rows[dtpRowIndex].Cells[CTE_COL_EndDate].Value);
                DateTime dtOldBeg = Convert.ToDateTime(dgvList.Rows[dtpRowIndex].Cells[CTE_COL_StartDate].Value);

                if (dtNew.CompareTo(dtOldBeg) > 0)
                {
                    string type = dgvList.Rows[dtpRowIndex].Cells[CTE_COL_BucketType].Value.ToString();

                    int diff = 0;
                    int days = dtNew.Subtract(dtOldBeg).Days;
                    if (type == "Day") diff = days;
                    if (type == "Week") diff = days / 7;
                    if (type == "Month") diff = days / 30;
                    if (type == "Year") diff = days / 365;

                    dgvList.Rows[dtpRowIndex].Cells[CTE_COL_Length].Value = diff;
                    ReCalcDates();
                    bDirty = true;
                }
            }
        }
        private void dtpDate_Leave(object sender, EventArgs e)
        {
            dtpDate.Visible = false;
            RefreshDiagram();
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
                if (Presentation.Public.Routines.ShowMessageBoxFa("عنصر انتخاب شده حذف خواهد شد. آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int rowIndex = dgvList.SelectedRows[0].Index;
                    Delete(rowIndex);
                }
            }
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
            if (e.Alt && e.KeyCode.ToString() == "D")
            {
                if (dgvList.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvList.SelectedRows[0].Index;
                    Delete(rowIndex);
                }
            }

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
                btnModel.DefaultImage = Properties.Resources.S_Panleft1;
                btnModel.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (spcAll.Panel1Collapsed == true)
            {
                spcAll.Panel1Collapsed = false;
                btnModel.DefaultImage = Properties.Resources.S_PanRight1;
                btnModel.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }

        private void dgvList_Click_1(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow dgvr in dgvList.Rows)
            ReCalcDates();
            //ReBind();
            //int BalanceIndex = 0;
            //foreach (DataGridViewColumn dgvCol in dgvList.Columns)
            //    if (dgvCol.Name.Equals("Balance"))
            //    {
            //        BalanceIndex = dgvCol.Index;
            //        CTE_COL_CBME_Balance = BalanceIndex + suspendedCount;
            //        break;
            //    }
        }


    }
}