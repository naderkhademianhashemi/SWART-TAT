using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using ERMS.Logic;
using ERMS.Model;
using ERMSLib;
using Presentation.Public;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmCBM : BaseForm, IPrintable
    {
        #region CONST
        private const int CTE_COL_CBME_CheckTotal = 0;
        private const int CTE_COL_CBME_ID = 1;
        private const int CTE_COL_CBME_GroupName = 2;
        private int CTE_COL_CBME_Balance = 3;
        int suspendedCount = 0;
        private const int CTE_COL_ID = 0;
        private const int CTE_COL_TB_Model_ID = 1;
        private const int CTE_COL_BucketName = 2;
        private const int CTE_COL_BucketType = 3;
        private const int CTE_COL_Length = 4;
        private const int CTE_COL_Color = 5;
        #endregion

        #region VARS
        public delegate void ChangedDelegate();
        public event ChangedDelegate Changed;

        private TBM tbm;
        private CBM cbm;

        private int fsModelID, tbModelID;

        private bool bDirty = false;
        private int curModelID = -1;
        private int maxBoxWidth, minBoxWidth;
        private struct CBCell
        {
            public CBCell(int v1, int v2, decimal value)
            {
                CBElementID = v1;
                TBElementSeq = v2;
                Value = value;

            }
            public int CBElementID;
            public int TBElementSeq;
            public decimal Value;
        }
        private List<CBCell> changedItems = new List<CBCell>();
        #endregion
        public int TBModelID
        {
            get { return tbModelID; }
            set { tbModelID = value; }
        }

        public int FSModelID
        {
            get { return fsModelID; }
            set { fsModelID = value; }
        }

        public frmCBM()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
        }
        private void frmCBM_Load(object sender, EventArgs e)
        {
            tbm = new TBM();
            cbm = new CBM();

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;

            dgvListTB.MultiSelect = false;

            bDirty = false;
            curModelID = -1;

            maxBoxWidth = 250;
            minBoxWidth = 50;
            GeneralDataGridView = dgvList;
            FillModel();
        }
        public void SelectedModelID()
        {
            int modelID = -1;
            if (lsvModel.SelectedItems.Count > 0)
                modelID = ((CBMInfo)lsvModel.SelectedItems[0].Tag).ID;

            clsERMSGeneral.dtModel.Rows[0]["CB_Model"] = modelID;
        }
        private void frmCBM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Save(curModelID, false);

            }
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
            Save(curModelID, true);
        }
        private void lsvModel_DoubleClick(object sender, EventArgs e)
        {
            CommandModelEdit();
        }
        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
            {
                if (bDirty)
                {
                    if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        Save(curModelID, false);
                }
                bDirty = false;

                if (lsvModel.SelectedItems.Count > 0)
                {
                    CBMInfo ci = (CBMInfo)lsvModel.SelectedItems[0].Tag;
                    curModelID = ci.ID;
                    RefreshGrid();
                    SelectedModelID();
                    return;
                }
            }

            //else...
            {
                curModelID = -1;
                dgvList.Columns.Clear();
                pnlTimeBucket.Controls.Clear();
            }
        }
      

        private void CommandModelNew()
        {
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Save(curModelID, false);

            }
            TBM tbm = new TBM();
            FSM fsm = new FSM();

            DataTable dtTbm = tbm.GetTBMs();
            DataTable dtFsm = fsm.GetFSMs();
            if (dtTbm.Rows.Count != 0 && dtFsm.Rows.Count != 0)
            {
                frmNewCBM fx = new frmNewCBM();
                if (fx.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lvi = new ListViewItem();
                    CBMInfo ci = new CBMInfo();
                    lvi.Text = fx.Title;

                    lvi.Tag = ci;
                    lsvModel.Items.Add(lvi);

                    //                
                    ci.ModelName = fx.Title;
                    // ci.TBModelID = tbModelID;

                    ci.TBModelID = fx.TimeBucketID;
                    ci.FSModelID = fx.fsModelID;
                    ci.ID = cbm.InsertCBM(ci);
                    curModelID = ci.ID;

                    Save(ci.ID, false);
                    ReBind();
                    lvi.Selected = true;
                }
            }
            else
            {
                Presentation.Public.Routines.ShowMessageBoxFa("ابتدا مدل اقلام بدون سررسید و مدل ترازنامه را تولید كنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
                    CBMInfo ci = (CBMInfo)lvi.Tag;
                    ci.ModelName = descr;
                    cbm.UpdateCBM(ci);
                }
            }
        }
        private void CommandModelRemove()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("مدل انتخاب شده، حذف خواهد شد. آیا مطمئن هستید؟", "تایید", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem lvi = lsvModel.SelectedItems[0];
                    CBMInfo ci = (CBMInfo)lvi.Tag;

                    lvi.Remove();
                    cbm.DeleteCBM(ci.ID);
                }
            }
        }

        private void Save(int modelID, bool bMessage)
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                CBMInfo ci = (CBMInfo)lsvModel.SelectedItems[0].Tag;
                foreach (CBCell c in changedItems)
                {
                    cbm.ChangeValue(c.CBElementID, ci.TBModelID, c.TBElementSeq, c.Value);
                }

                if (bMessage)
                    Presentation.Public.Routines.ShowMessageBoxFa("مدل شما ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Changed != null)
                    Changed();
                bDirty = false;
            }
        }
        private void FillModel()
        {
            DataTable dt = cbm.GetCBMs();
            foreach (DataRow dr in dt.Rows)
            {
                CBMInfo ci = new CBMInfo();
                cbm.CloneX(dr, ci, ECloneXdir.DR2Info);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = ci.ModelName;
                lvi.Tag = ci;

                lsvModel.Items.Add(lvi);
            }
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
        private void RefreshDiagram()
        {
            pnlTimeBucket.Controls.Clear();
            Control c = new Control();
            c.Left = 1000;
            pnlTimeBucket.Controls.Add(c);

            int elementID = -1;
            int x = 5, y = 5, w = 0, h = 70, len = 0;
            string labelType = string.Empty, labelName = string.Empty;
            string type = string.Empty;

            int maxValue = 0;
            for (int i = 0; i <= dgvListTB.Rows.Count - 1; i++)
            {
                len = (int)dgvListTB.Rows[i].Cells[CTE_COL_Length].Value;
                type = dgvListTB.Rows[i].Cells[CTE_COL_BucketType].Value.ToString();
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

            for (int i = 0; i <= dgvListTB.Rows.Count - 1; i++)
            {
                Color fillColor = Color.FromArgb((int)dgvListTB.Rows[i].Cells[CTE_COL_Color].Value);

                elementID = (int)dgvListTB.Rows[i].Cells[CTE_COL_ID].Value;
                len = (int)dgvListTB.Rows[i].Cells[CTE_COL_Length].Value;
                labelName = dgvListTB.Rows[i].Cells[CTE_COL_BucketName].Value.ToString();
                type = dgvListTB.Rows[i].Cells[CTE_COL_BucketType].Value.ToString();
                if (type == "Year")
                {
                    w = 365;
                    labelType = string.Format("{0}Y", len.ToString());
                }
                if (type == "Month")
                {
                    w = 30;
                    labelType = string.Format("{0}M", len.ToString());
                }
                if (type == "Week")
                {
                    w = 7;
                    labelType = string.Format("{0}W", len.ToString());
                }
                if (type == "Day")
                {
                    w = 1;
                    labelType = string.Format("{0}D", len.ToString());
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

                RoundBox rb = new RoundBox();
                rb.Left = x;
                rb.Width = w;
                rb.Top = y;
                rb.Height = h;
                rb.Visible = true;
                rb.BackColor = Color.Transparent;
                rb.FillColor = fillColor;
                rb.Text = tsmiLabelName.Checked ? labelName : labelType;
                rb.AllowDrop = true;
                rb.IsArrowVisible = (type == "ToEnd");
                //rb.DoubleClick += new EventHandler(rb_DoubleClick);
                //rb.MouseDown += new MouseEventHandler(rb_MouseDown);
                //rb.MouseMove += new MouseEventHandler(rb_MouseMove);
                //rb.DragDrop += new DragEventHandler(rb_DragDrop);
                //rb.DragEnter += new DragEventHandler(rb_DragEnter);
                //rb.DragLeave += new EventHandler(rb_DragLeave);
                //rb.MouseUp += new MouseEventHandler(rb_MouseUp);

                x = x + w;

                //
                dgvListTB.Rows[i].Tag = rb;
                rb.Tag = dgvListTB.Rows[i];

                pnlTimeBucket.Controls.Add(rb);
            }
        }
        private void RefreshGrid()
        {
            Helper h = new Helper();
            h.FormatDataGridView(dgvListTB);
            h.FormatDataGridView(dgvList);
            dgvList.SelectionMode = DataGridViewSelectionMode.CellSelect;

            ReBind();
            RefreshDiagram();
        }
        private void ReBind()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                dgvList.Columns.Clear();
                CTE_COL_CBME_Balance = 3;
                int tbModelID = ((CBMInfo)lsvModel.SelectedItems[0].Tag).TBModelID;
                dgvListTB.DataSource = tbm.GetTBMelements(tbModelID);

                int modelID = ((CBMInfo)lsvModel.SelectedItems[0].Tag).ID;
                // calculate accounting again 
                dgvList.DataSource = new DAL.CbmDataSet().GetCBMElements(modelID, false, true, out suspendedCount);
                CTE_COL_CBME_Balance += suspendedCount;
                changedItems.Clear();
                bDirty = false;

                // add by soltani
                if (dgvList.DataSource != null)
                {
                    dgvList.Columns[1].HeaderText = "نام گروه";
                    dgvList.Columns[2].HeaderText = "مانده حساب";
                    dgvList.Columns[1].ReadOnly = true;
                    dgvList.Columns[2].ReadOnly = true;
                }
                txtGroupName.Text = "";
                txtBalance.Text = "";

                //Revised - 1.1
                //888  dgvList.Columns[2].DefaultCellStyle.Format = "###,###.##";
                //888  dgvList.Columns[CTE_COL_CBME_GroupName].Frozen = true;
                // dgvList.Columns[CTE_COL_CBME_Balance].Frozen = true;

                DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
                tCol.MinimumWidth = 1023;
                dgvList.Columns.Add(tCol);

                //Check Balance
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Image = global::Presentation.Properties.Resources.NOk;
                imgCol.Frozen = true;
                dgvList.Columns.Insert(0, imgCol);

                dgvList.Columns[CTE_COL_CBME_ID].Visible = false;

                foreach (DataGridViewRow dgvr in dgvList.Rows)
                    RecheckTotal(dgvr.Index);
            }
        }
        private void RefreshCBM()
        {
            if (curModelID != -1)
            {
              //  cbm.RefreshCBM(curModelID);
                RefreshGrid();
            }
        }
        public void DoPrint()
        {
            if (dgvList.DataSource != null)
            {
                DataGridView dgv = new DataGridView();

                dataGridView1.DataSource = (DataTable)dgvList.DataSource;
                dataGridView1.Columns[0].Visible = false;
                clsERMSGeneral.dgvActive = dataGridView1;

                //DataTable dt = (DataTable)dgvList.DataSource;
                //dgv.DataSource = dt;
                // dgv.Columns[0].Visible = false;
                clsERMSGeneral.dgvActive = dataGridView1;
                // clsERMSGeneral.dgvActive = dgvList;
            }
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "CBM";
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvList_CellClick(sender, e);
        }
        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("ColName: " + dgvList.Columns[e.ColumnIndex].Name);

            if ((e.RowIndex != -1) && e.ColumnIndex > CTE_COL_CBME_Balance && dgvList.Columns[e.ColumnIndex].Name.Length > 0)
                //e.ColumnIndex != dgvList.Columns.Count - 1            
            {
                Rectangle cellBound = dgvList.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                object objBalance = dgvList["Balance", e.RowIndex].Value;
                decimal balance = 0;
                try
                {
                    balance = Convert.ToDecimal(objBalance);
                }catch(Exception ex)
                {
                }
                
                frmAmount fx = new frmAmount();
    
                fx.Location = dgvList.PointToScreen(new Point(cellBound.Left, cellBound.Top + cellBound.Height));
                fx.Balance = balance;
                fx.Maximum = GetRemainMax(e.RowIndex, e.ColumnIndex);
                if (fx.ShowDialog() == DialogResult.OK)
                {
                    dgvList[e.ColumnIndex, e.RowIndex].Value = fx.Percent.ToString();

                    int CBElementID = (int)dgvList[CTE_COL_CBME_ID, e.RowIndex].Value;
                    int TBElementSeq = e.ColumnIndex - CTE_COL_CBME_Balance; //Sequence in TimeBucketElement
                    decimal value = Presentation.Public.Routines.GetNumericValue(dgvList[e.ColumnIndex, e.RowIndex].Value.ToString(), out value);
                    changedItems.Add(new CBCell(CBElementID, TBElementSeq, value));

                    RecheckTotal(e.RowIndex);
                    bDirty = true;
                }
            }
        }

        private int GetRemainMax(int rowIndex, int colIndex)
        {
            int val = 0, selfVal = 0;
            for (int i = CTE_COL_CBME_Balance + 1; i < dgvList.Columns.Count; i++)
            {
                object cellVal = dgvList[i, rowIndex].Value;
                val += (cellVal == DBNull.Value) ? 0 : Convert.ToInt32(cellVal);
            }

            object selfCellVal = dgvList[colIndex, rowIndex].Value;
            selfVal += (selfCellVal == DBNull.Value) ? 0 : Convert.ToInt32(selfCellVal);

            return 100 - val + selfVal;
        }
        private void RecheckTotal(int rowIndex)
        {
            try
            {
                int sum = 0;
                for (int i = CTE_COL_CBME_Balance + 1; i < dgvList.Columns.Count; i++)
                {
                    object cellVal = dgvList[i, rowIndex].Value;
                    sum += (cellVal == DBNull.Value) ? 0 : Convert.ToInt32(cellVal);
                }

                DataGridViewImageCell checkTotalImageCell = (DataGridViewImageCell)dgvList.Rows[rowIndex].Cells[CTE_COL_CBME_CheckTotal];
                if (sum == 100)
                    checkTotalImageCell.Value = global::Presentation.Properties.Resources.Ok;
                else
                    checkTotalImageCell.Value = global::Presentation.Properties.Resources.NOk;
            }
            catch(Exception ex)
            {
            }
        }

        //add by soltani
        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (!clsERMSGeneral.CloseForm)
            {
                if (dgvList.SelectedCells.Count > 0)
                {
                    int rowNo = (int)dgvList.SelectedCells[0].RowIndex;
                    txtGroupName.Text = dgvList[CTE_COL_CBME_GroupName, rowNo].Value.ToString();
                    txtBalance.Text = dgvList[CTE_COL_CBME_Balance, rowNo].Value.ToString();

                }
            }
        }
        private void btnModel_Click(object sender, EventArgs e)
        {
            
            if (spcAll.Panel2Collapsed == false)
            {
                spcAll.Panel2Collapsed = true;
                btnModel.DefaultImage = Properties.Resources.S_Panleft1;
                btnModel.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (spcAll.Panel2Collapsed == true)
            {
                spcAll.Panel2Collapsed = false;
                btnModel.DefaultImage = Properties.Resources.S_PanRight1;
                btnModel.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }
        private void frmCBM_KeyDown(object sender, KeyEventArgs e)
        {

            //New
            if (e.Control && e.KeyCode.ToString() == "N")
            {
                CommandModelNew();
            }
            //Copy
            if (e.Control && e.KeyCode.ToString() == "C")
            {

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
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            RefreshCBM();
        }

        private void txtBalance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chbOutput_dgvVaR_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOutput_dgvVaR.Checked)
                GeneralDataGridView = dgvList;
            else
                GeneralDataGridView = null;
        }


        private void dgvList_Validated(object sender, EventArgs e)
        {
            
        }


        private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //foreach (DataGridViewRow dgvr in dgvList.Rows)
            //    RecheckTotal(dgvr.Index);
        }

        private void dgvList_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgvList.Rows)
                RecheckTotal(dgvr.Index);

            int BalanceIndex = 0;
            foreach (DataGridViewColumn dgvCol in dgvList.Columns)
                if(dgvCol.Name.Equals("Balance"))
                    {
                        BalanceIndex = dgvCol.Index;
                        CTE_COL_CBME_Balance = BalanceIndex + suspendedCount;
                        break;
                    }

                //RecheckTotal(dgvr.Index);
        }
    }
}