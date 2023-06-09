using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Utilize.Helper;
using ERMSLib;
using Dundas.Charting.WinControl;
using System.Linq;
using ERMS.Logic;
using ERMS.Model;
using Presentation.Public;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmDBMG : BaseForm, IPrintable
    {


        #region CONST
        private const int CTE_COL_DBME_CheckTotal = 0;
        private const int CTE_COL_DBME_ID = 1;
        private const int CTE_COL_DBME_GroupName = 2;
        private const int CTE_COL_DBME_Opening = 3;
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
        private DBM dbm;

        private int tbModelID;
        private decimal depositLimit;

        private bool bDirty = false;
        private int curModelID = -1;
        private int maxBoxWidth, minBoxWidth;
        readonly Collection<Series> _series = new Collection<Series>();
        readonly Collection<Series> _series1 = new Collection<Series>();
        readonly Collection<Series> _series2 = new Collection<Series>();
        private IEnumerable<DataColumn> columnsInt;
        private DataTable result;
        private DataTable result1;
        private DataTable result2;

        private struct DBCell
        {
            public DBCell(int v1, int v2, decimal value)
            {
                DBElementID = v1;
                TBElementSeq = v2;
                Value = value;

            }
            public int DBElementID;
            public int TBElementSeq;
            public decimal Value;
        }
        private List<DBCell> changedItems = new List<DBCell>();

        private struct DBNMCell
        {
            public DBNMCell(int v1, int v2, decimal value)
            {
                DBElementID = v1;
                TBElementSeq = v2;
                Value = value;

            }
            public int DBElementID;
            public int TBElementSeq;
            public decimal Value;
        }
        private List<DBNMCell> changedItemsNM = new List<DBNMCell>();
        #endregion

        public int TBModelID
        {
            get { return tbModelID; }
            set { tbModelID = value; }
        }
        public decimal DepositLimit
        {
            get { return depositLimit; }
            set { depositLimit = value; }

        }
        public frmDBMG()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
        }
        private void frmDBM_Load(object sender, EventArgs e)
        {
            var ctrtype = new DAL.GeneralDataSetTableAdapters.Contract_TypeTableAdapter().GetDataByGuarantee();
            ccmbDepType.DisplayMember = "Contract_Type_Description";
            ccmbDepType.ValueMember = "Contract_Type";
            ccmbDepType.DataSource = ctrtype;
            tbm = new TBM();
            dbm = new DBM();

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
            GeneralDataGridView = dgvMCReport;

            // 
            FillModel();

        }
        private void frmDBM_KeyDown(object sender, KeyEventArgs e)
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
        private void frmDBM_FormClosing(object sender, FormClosingEventArgs e)
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
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            RefreshDBM();
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
                    ProgressBox.Show();
                    DBMInfo di = (DBMInfo)lsvModel.SelectedItems[0].Tag;
                    curModelID = di.ID;
                    fdpStartDate.SelectedDateTime = di.Model_Date;
                    RefreshGrid();
                    SelectedModelID();
                    ProgressBox.Hide();
                    return;


                }
            }

            curModelID = -1;
            dgvMCReport.Columns.Clear();
            pnlTimeBucket.Controls.Clear();

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
        private void dgvMCReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMCReport_CellClick(sender, e);
        }
        private void dgvMCReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMCReport.Columns[0].ReadOnly = true;
            dgvMCReport.Columns[1].ReadOnly = true;

            if ((e.RowIndex != -1) && e.ColumnIndex > CTE_COL_DBME_Opening && e.ColumnIndex != dgvMCReport.Columns.Count - 1)
            {
                Rectangle cellBound = dgvMCReport.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                object objBalance = dgvMCReport[CTE_COL_DBME_Opening, e.RowIndex].Value;
                decimal balance = (objBalance == DBNull.Value) ? 0 : Convert.ToDecimal(objBalance);

                frmAmount fx = new frmAmount();
                fx.Location = dgvMCReport.PointToScreen(new Point(cellBound.Left, cellBound.Top + cellBound.Height));
                fx.Balance = balance;
                fx.Maximum = GetRemainMax(e.RowIndex, e.ColumnIndex);
                if (fx.ShowDialog() == DialogResult.OK)
                {
                    dgvMCReport[e.ColumnIndex, e.RowIndex].Value = fx.Percent.ToString();

                    int CBElementID = (int)dgvMCReport[CTE_COL_DBME_ID, e.RowIndex].Value;
                    int TBElementSeq = e.ColumnIndex - CTE_COL_DBME_Opening; //Sequence in TimeBucketElement
                    decimal value = Presentation.Public.Routines.GetNumericValue(dgvMCReport[e.ColumnIndex, e.RowIndex].Value.ToString(), out value);
                    changedItems.Add(new DBCell(CBElementID, TBElementSeq, value));

                    RecheckTotal(e.RowIndex);
                    bDirty = true;
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
        private void tbDLimit_TextChanged(object sender, EventArgs e)
        {


        }
        public void SelectedModelID()
        {
            int modelID = -1;
            if (lsvModel.SelectedItems.Count > 0)
                modelID = ((DBMInfo)lsvModel.SelectedItems[0].Tag).ID;

            clsERMSGeneral.dtModel.Rows[0]["DB_Model"] = modelID;
        }
        private void CommandModelNew()
        {


            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Save(curModelID, false);

            }
            TBM tbm = new TBM();


            DataTable dtTbm = tbm.GetTBMs();

            if (dtTbm.Rows.Count != 0)
            {
                frmNewDBM fx = new frmNewDBM();
                if (fx.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lvi = new ListViewItem();
                    DBMInfo di = new DBMInfo();
                    lvi.Text = fx.Title;
                    lvi.Tag = di;
                    lsvModel.Items.Add(lvi);
                    di.DB_Model = fx.Title;
                    di.TB_Model_Id = fx.TimeBucketID;
                    di.Deposit_Limit = fx.depositLimit;
                    di.Model_Date = fx.ModelDate;
                    di.Type = "G";
                    di.ID = dbm.InsertDBM(di);
                    curModelID = di.ID;
                    Save(di.ID, false);
                    ReBind();
                    ReBind_NMClient();
                    lvi.Selected = true;
                    SelectedModelID();
                    chart.Series.Clear();
                    chart1.Series.Clear();
                    chart2.Series.Clear();
                }
            }
            else
            {
                Presentation.Public.Routines.ShowMessageBoxFa("ابتدا مدل اقلام بدون سررسید را تولید كنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void CommandModelEdit()
        {

            frmNewDBM fx = new frmNewDBM();

            fx.Title = ((DBMInfo)lsvModel.SelectedItems[0].Tag).DB_Model;
            fx.depositLimit = ((DBMInfo)lsvModel.SelectedItems[0].Tag).Deposit_Limit;
            fx.TimeBucketID = ((DBMInfo)lsvModel.SelectedItems[0].Tag).TB_Model_Id;
            fx.ModelDate = ((DBMInfo)lsvModel.SelectedItems[0].Tag).Model_Date;
            fx.TimeBucket = ((DBMInfo)lsvModel.SelectedItems[0].Tag).TB_Model_Id;


            if (fx.ShowDialog() == DialogResult.OK)
            {
                dbm.Delete_DBM_Element(((DBMInfo)lsvModel.SelectedItems[0].Tag).ID);
                curModelID = ((DBMInfo)lsvModel.SelectedItems[0].Tag).ID;

                DBMInfo di = (DBMInfo)lsvModel.SelectedItems[0].Tag;
                ListViewItem lvi = new ListViewItem();
                di.Deposit_Limit = fx.depositLimit;
                di.Model_Date = fx.ModelDate;
                di.Type = "G";
                dbm.UpdateDBM(di);
                dbm.CreateDBM(Convert.ToInt32(((DBMInfo)lsvModel.SelectedItems[0].Tag).ID), Convert.ToDecimal(fx.depositLimit), "G");
                Save(((DBMInfo)lsvModel.SelectedItems[0].Tag).ID, false);
                ReBind();
                ReBind_NMClient();
                lvi.Selected = true;
                SelectedModelID();
                chart.Series.Clear();
                chart1.Series.Clear();
                chart2.Series.Clear();
                fdpStartDate.SelectedDateTime = fx.ModelDate;
                tbDepositLimit.Text = fx.depositLimit.ToString();
            }

            











            //if (lsvModel.SelectedItems.Count > 0)
            //{
            //    ListViewItem lvi = lsvModel.SelectedItems[0];

            //    string descr = Presentation.Public.Routines.ShowInputBox(lvi.Text);
            //    if (descr != string.Empty)
            //    {
            //        lvi.Text = descr;

            //        //
            //        DBMInfo di = (DBMInfo)lvi.Tag;
            //        di.DB_Model = descr;
            //        dbm.UpdateDBM(di);
            //    }
            //}
        }
        private void CommandModelRemove()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("مدل انتخاب شده، حذف خواهد شد. آیا مطمئن هستید؟", "تایید", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem lvi = lsvModel.SelectedItems[0];
                    DBMInfo di = (DBMInfo)lvi.Tag;

                    lvi.Remove();
                    dbm.DeleteDBM(di.ID);
                }
            }
        }
        private void Save(int modelID, bool bMessage)
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                DBMInfo di = (DBMInfo)lsvModel.SelectedItems[0].Tag;
                foreach (DBCell d in changedItems)
                {
                    dbm.ChangeValue(d.DBElementID, di.TB_Model_Id, d.TBElementSeq, d.Value);
                }

                //foreach (DataRow dr in (dgvNMCReport.DataSource as DataTable).Rows)
                //    if (dr[3] != "" && dr[4] != "")
                //    {
                //        int dbmodelID = ((DBMInfo)lsvModel.SelectedItems[0].Tag).ID;
                //        int DB_Model_Id = Convert.ToInt32(dbmodelID.ToString());
                //        int Contract_Type = Convert.ToInt32(dr[2].ToString());
                //        int Percent_NM = Convert.ToInt32(dr[3].ToString());
                //        int Add_Date = Convert.ToInt32(dr[4].ToString());
                //        dbm.Update_DBModelElementNMClient(DB_Model_Id, Contract_Type, Percent_NM, Add_Date);
                //    }
                //    else
                //        continue;



                if (bMessage)
                    Presentation.Public.Routines.ShowMessageBoxFa("مدل شما ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Changed != null)
                    Changed();
                bDirty = false;
            }

        }
        private void FillModel()
        {
            DataTable dt = dbm.GetDBM("G");

            foreach (DataRow dr in dt.Rows)
            {
                DBMInfo di = new DBMInfo();
                dbm.CloneX(dr, di, ECloneXdir.DR2Info);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = di.DB_Model;
                lvi.Tag = di;

                lsvModel.Items.Add(lvi);
            }
            //if (lsvModel.Items.Count == 0) return;
            //lsvModel.Items[0].Selected = true;
            //int modelID = ((DBMInfo)lsvModel.SelectedItems[0].Tag).ID;
            //dgvNMCReport.DataSource = dbm.GetDBNMElements(modelID);


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
            h.FormatDataGridView(dgvMCReport);
            dgvMCReport.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvNMCReport.SelectionMode = DataGridViewSelectionMode.CellSelect;
            ReBind();
            ReBind_NMClient();
            ReBind_NMClient_Detail();
            ReBindNMChart();
            RefreshDiagram();
        }
        private void ReBind()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {

                dgvMCReport.Columns.Clear();
                int tbModelID = ((DBMInfo)lsvModel.SelectedItems[0].Tag).TB_Model_Id;
                dgvListTB.DataSource = tbm.GetTBMelements(tbModelID);

                int modelID = ((DBMInfo)lsvModel.SelectedItems[0].Tag).ID;
                decimal DeposotLimit = ((DBMInfo)lsvModel.SelectedItems[0].Tag).Deposit_Limit;

                // calculate accounting again 
                // Presentation.Public.Routines.ShowProcess();
                dgvMCReport.DataSource = dbm.GetDBMElements(modelID, false, true);
                // Presentation.Public.Routines.HideProcess();
                changedItems.Clear();
                bDirty = false;
                tbDepositLimit.Text = Convert.ToString(DeposotLimit);

                if (dgvMCReport.DataSource != null)
                {
                    dgvMCReport.Columns[1].HeaderText = "نام مشتری";
                    dgvMCReport.Columns[2].HeaderText = "مبلغ حساب";
                    dgvMCReport.Columns[1].ReadOnly = true;
                    dgvMCReport.Columns[2].ReadOnly = true;
                }

                DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
                tCol.MinimumWidth = 1023;
                //dgvMCReport.Columns.Add(tCol);
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();

                imgCol.Image = global::Presentation.Properties.Resources.NOk;
                imgCol.Frozen = true;
                dgvMCReport.Columns.Insert(0, imgCol);

                dgvMCReport.Columns[CTE_COL_DBME_ID].Visible = false;

                foreach (DataGridViewRow dgvr in dgvMCReport.Rows)
                    RecheckTotal(dgvr.Index);


            }
        }
        private void ReBind_NMClient()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {


                int modelID = ((DBMInfo)lsvModel.SelectedItems[0].Tag).ID;
                //  dgvNMCReport.DataSource = dbm.GetDBNMElements(modelID);
                var DBNMElements = dbm.GetDBNMElements(modelID);
                if (DBNMElements != null)
                {
                    dgvNMCReport.DataSource = DBNMElements;
                    bDirty = false;
                }

                bDirty = false;
            }
        }
        private void ReBind_NMClient_Detail()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {


                int modelID = ((DBMInfo)lsvModel.SelectedItems[0].Tag).ID;
                //  dgvNMCReport.DataSource = dbm.GetDBNMElements(modelID);
                var DBNMElements = new DAL.DBMDataSet().GetDBNMClientsElements(modelID);
                if (DBNMElements != null)
                {
                    cmbDepType.DataSource = DBNMElements;
                    cmbDepType.ValueMember = "Id";
                    cmbDepType.DisplayMember = "Contract_Type_Description";
                }


            }
        }
        private void RefreshDBM()
        {
            if (curModelID != -1)
            {
                // dbm.RefreshDBM(curModelID);
                RefreshGrid();
            }
        }
        public void DoPrint()
        {
            if (dgvMCReport.DataSource != null)
            {
                DataGridView dgv = new DataGridView();

                dataGridView1.DataSource = (DataTable)dgvMCReport.DataSource;
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
            clsERMSGeneral.strHelp = "DBM";
        }
        private int GetRemainMax(int rowIndex, int colIndex)
        {
            int val = 0, selfVal = 0;
            for (int i = CTE_COL_DBME_Opening + 1; i < dgvMCReport.Columns.Count; i++)
            {
                object cellVal = dgvMCReport[i, rowIndex].Value;
                val += (cellVal == DBNull.Value) ? 0 : Convert.ToInt32(cellVal);
            }

            object selfCellVal = dgvMCReport[colIndex, rowIndex].Value;
            selfVal += (selfCellVal == DBNull.Value) ? 0 : Convert.ToInt32(selfCellVal);

            return 100 - val + selfVal;
        }
        private void RecheckTotal(int rowIndex)
        {
            int sum = 0;
            for (int i = CTE_COL_DBME_Opening + 1; i < dgvMCReport.Columns.Count; i++)
            {
                object cellVal = dgvMCReport[i, rowIndex].Value;
                sum += (cellVal == DBNull.Value) ? 0 : Convert.ToInt32(cellVal);
            }

            DataGridViewImageCell checkTotalImageCell = (DataGridViewImageCell)dgvMCReport.Rows[rowIndex].Cells[CTE_COL_DBME_CheckTotal];
            if (sum == 100)
                checkTotalImageCell.Value = global::Presentation.Properties.Resources.Ok;
            else
                checkTotalImageCell.Value = global::Presentation.Properties.Resources.NOk;
        }
        private void dgvNMCReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if ((e.RowIndex != -1) && e.ColumnIndex != dgvNMCReport.Columns.Count - 1 && Convert.ToInt32(e.ColumnIndex.ToString()) == 3)
            {
                Rectangle cellBound = dgvNMCReport.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                object objBalance = dgvNMCReport[2, e.RowIndex].Value;


                //   (int)dgvMCReport[CTE_COL_DBME_ID, e.RowIndex].Value;

                frmAmount fx = new frmAmount();
                fx.Location = dgvNMCReport.PointToScreen(new Point(cellBound.Left, cellBound.Top + cellBound.Height));
                fx.Contract = objBalance.ToString();
                fx.Maximum = RecheckTotalNM(e.RowIndex, e.ColumnIndex);
                if (fx.ShowDialog() == DialogResult.OK)
                {
                    dgvNMCReport[e.ColumnIndex, e.RowIndex].Value = fx.Percent.ToString();
                    bDirty = true;
                }
            }



        }

        private int RecheckTotalNM(int rowIndex, int colIndex)
        {
            if (dgvNMCReport[2, rowIndex].Value.ToString() != "")
            {

                int modelID = ((DBMInfo)lsvModel.SelectedItems[0].Tag).ID;
                int contract = Convert.ToInt32(dgvNMCReport[2, rowIndex].Value.ToString());
                int cellval = Convert.ToInt32(dbm.GETDT_DBNM(modelID, contract).ToString());
                return 100 - cellval;
            }
            else
                return 0;
            Presentation.Public.Routines.ShowMessageBoxFa("نوع سپرده را مشخص کنید.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void btnLoad_Click(object sender, EventArgs e)
        {

            //int modelID = ((DBMInfo)lsvModel.SelectedItems[0].Tag).ID;
            //var DBNMElements = new DAL.Table_DataSetTableAdapters.DB_Model_Element_NMClientTableAdapter().GetData(modelID);
            //dgvNMCReport.DataSource = DBNMElements;
            //Utilize.Routines.ShowProcess();
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Save(curModelID, false);

                    //var DBNMElements = dbm.GetDBNMElements(curModelID);
                    //if (DBNMElements != null)
                    //{
                    //    dgvNMCReport.DataSource = DBNMElements;
                    //    bDirty = false;
                    //}

                    bDirty = false;
                }
            }

            var DBNMElements = dbm.GetDBNMElements(curModelID);
            if (DBNMElements != null)
            {
                dgvNMCReport.DataSource = DBNMElements;
                bDirty = false;
            }

            ProgressBox.Show();
            dgvNMCReport.Refresh();

            //dgvDepositRandom.DataSource = new DAL.DBMDataSet().GetDTDepositRandom(curModelID).ConfigDateTimeToPersian();
            //dgvDepositRandom.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            foreach (DataRow dr in (dgvNMCReport.DataSource as DataTable).Rows)
            {
                if (dr[0].ToString() != "")
                {
                    int ID = Convert.ToInt32(dr[0].ToString());
                    int i = dbm.DBNMRandom(ID);
                }

            }
            ProgressBox.Hide();
            Presentation.Public.Routines.ShowMessageBoxFa("عملیات بارگذاری باموفقیت انجام شد.", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private void ReBindNMChart()
        {

            if (lsvModel.SelectedItems.Count > 0)
            {


                int modelID = ((DBMInfo)lsvModel.SelectedItems[0].Tag).ID;
                var DBNMElements = new DAL.Table_DataSetTableAdapters.DB_Model_Element_NMClientTableAdapter().GetData(modelID);
                if (DBNMElements != null)
                {
                    dgvNMChart.DataSource = DBNMElements;
                    dgvNMChart.Columns[0].Visible = false;
                    dgvNMChart.Columns[3].HeaderText = "نوع قرارداد";
                    dgvNMChart.Columns[1].HeaderText = "درصد";
                    dgvNMChart.Columns[2].HeaderText = "تاریخ";

                    bDirty = false;
                    DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
                    tCol.MinimumWidth = 1023;


                    dgvMCReport.Columns.Add(tCol);
                    DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                }

            }

        }
        private void dgvNMChart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tbSelectedPeriod.Text == "")
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("مقدار بازه را مشخص کنید.", "اخطار",
                                                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    _series.Clear();
                    chart.Series.Clear();
                    chart.ChartAreas[0].AxisX.Interval = 1;
                    chart.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
                    chart.ChartAreas[0].AxisX.LabelsAutoFit = true;
                    chart.ChartAreas[0].AxisX.LabelStyle.FontAngle = 45;
                    chart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    //chart.ChartAreas[0].AxisY.LabelStyle.Format = "N0";

                    //chart.ChartAreas[0].AxisY.Interval = 1;
                    chart.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
                    chart.ChartAreas[0].AxisY.LabelsAutoFit = true;
                    //chart.ChartAreas[0].AxisY.LabelStyle.FontAngle = 45;
                    chart.ChartAreas[0].AxisY.ScrollBar.Enabled = true;
                    //chart.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
                    // chart.ChartAreas[0].AxisX.


                    var ser = new Series();
                    var z = dgvNMChart.DataSource;

                    result = dbm.GETDT_DBNM_Random(Convert.ToInt32(dgvNMChart[0, e.RowIndex].Value.ToString()),
                                                   Convert.ToInt16(tbSelectedPeriod.Text));
                    ser.ValueMembersY = "count";
                    ser.ValueMemberX = "Range";
                    ser.ToolTip = "#VAL      #AXISLABEL";
                    ser.LabelFormat = "##,####.##";
                    ser.SmartLabels.Enabled = true;
                    ser.ShowLabelAsValue = true;
                    chart.Series.Add(ser);
                    //_series[0].ShowLabelAsValue
                    _series.Add(ser);

                    chart.DataSource = result;
                    chart.DataBind();





                    _series1.Clear();
                    chart1.Series.Clear();
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
                    chart1.ChartAreas[0].AxisX.LabelsAutoFit = true;
                    chart1.ChartAreas[0].AxisX.LabelStyle.FontAngle = 45;
                    chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    //chart1.ChartAreas[0].AxisY.LabelStyle.Format = "N0";


                    var ser1 = new Series();
                    var z1 = dgvNMChart.DataSource;

                    result1 = dbm.GETDT_DBNM_Random1(
                        Convert.ToInt32(dgvNMChart[0, e.RowIndex].Value.ToString()),
                        Convert.ToInt16(tbSelectedPeriod.Text));
                    ser1.ValueMembersY = "count";
                    ser1.ValueMemberX = "Range";
                    ser1.ToolTip = "#VAL      #AXISLABEL";
                    ser1.LabelFormat = "##,####.##";
                    ser1.SmartLabels.Enabled = true;
                    ser1.SmartLabels.Enabled = true;
                    ser1.ShowLabelAsValue = true;
                    chart1.Series.Add(ser1);
                    _series1.Add(ser1);
                    chart1.DataSource = result1;
                    chart1.DataBind();



                    _series2.Clear();
                    chart2.Series.Clear();
                    chart2.ChartAreas[0].AxisX.Interval = 1;
                    chart2.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
                    chart2.ChartAreas[0].AxisX.LabelsAutoFit = true;
                    chart2.ChartAreas[0].AxisX.LabelStyle.FontAngle = 45;
                    chart2.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    //chart1.ChartAreas[0].AxisY.LabelStyle.Format = "N0";


                    var ser2 = new Series();
                    var z2 = dgvNMChart.DataSource;
                    result2 = dbm.GETDT_DBNM_Random2(
                        Convert.ToInt32(dgvNMChart[0, e.RowIndex].Value.ToString()),
                        Convert.ToInt16(tbSelectedPeriod.Text));
                    ser2.ValueMembersY = "count";
                    ser2.ValueMemberX = "Range";
                    ser2.ToolTip = "#VAL      #AXISLABEL";
                    ser2.SmartLabels.Enabled = true;
                    ser2.ShowLabelAsValue = true;
                    ser2.LabelFormat = "##,####.##";
                    chart2.Series.Add(ser2);
                    _series2.Add(ser2);
                    chart2.DataSource = result2;
                    chart2.DataBind();


                }

            }
            catch (Exception exception)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(exception.Message + "\nبرنامه با خطا مواجه شده است.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void miRemove_Click(object sender, EventArgs e)
        {
            CommandRemove();
        }

        private void CommandRemove()
        {

            DataGridViewRow row = dgvNMCReport.CurrentRow;

            if (dgvNMCReport.CurrentRow != null)
            {
                int x = Convert.ToInt32(row.Cells[0].Value);
                dbm.Delete_DBNM_Element(x);


                dgvNMCReport.Rows.RemoveAt(row.Index);
                ReBind_NMClient();


            }




        }



        private void dgvNMCReport_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dr = (dgvNMCReport.DataSource as DataTable).Rows;
                if ((dgvNMCReport.DataSource as DataTable).Rows.Count != 0)
                {
                    int dbmodelID = ((DBMInfo)lsvModel.SelectedItems[0].Tag).ID;
                    int DB_Model_Id = Convert.ToInt32(dbmodelID.ToString());
                    int Contract_Type = Convert.ToInt32(dgvNMCReport[2, e.RowIndex].Value.ToString());
                    int Percent_NM = Convert.ToInt32(dgvNMCReport[3, e.RowIndex].Value.ToString());
                    int Add_Date = Convert.ToInt32(dgvNMCReport[4, e.RowIndex].Value.ToString());
                    dbm.Update_DBModelElementNMClient(DB_Model_Id, Contract_Type, Percent_NM, Add_Date);
                    dgvNMCReport.Refresh();
                }
            }
            catch
            {
                Presentation.Public.Routines.ShowMessageBoxFa("می بایست همه فیلدها پر باشد.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btnRefresh_CButtonClicked(object sender, EventArgs e)
        {
            if (curModelID != -1)
            {

                RefreshGrid();
            }
        }

        private void dgvNMCReport_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void cButton1_CButtonClicked(object sender, EventArgs e)
        {
            if (curModelID != -1)
            {

                RefreshGrid();
            }
        }



        private void chbdgMC_CheckedChanged(object sender, EventArgs e)
        {
            if (chbdgMC.Checked == true)
            {
                chbdgNMC.Checked = false;
                chkRandom.Checked = false;
                GeneralDataGridView = dgvMCReport;
            }
        }

        private void chbdgNMC_CheckedChanged(object sender, EventArgs e)
        {
            if (chbdgNMC.Checked == true)
            {
                chbdgMC.Checked = false;
                chkRandom.Checked = false;
                GeneralDataGridView = dgvNMCReport;
            }
        }

        private void tabMain_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {

        }

        private void chkRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRandom.Checked)
            {
                chbdgMC.Checked = false;
                chbdgNMC.Checked = false;
                GeneralDataGridView = dgvDepositRandom;
            }
        }

        private void cButton1_CButtonClicked_1(object sender, EventArgs e)
        {
            if (cmbDepType.SelectedValue == null)
                return;
            ProgressBox.Show();
            dgvDepositRandom.DataSource = new DAL.DBMDataSet().GetDTDepositRandom((int)cmbDepType.SelectedValue).ConfigDateTimeToPersian();
            dgvDepositRandom.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            ProgressBox.Hide();

        }

        private void cmbDepType_ValueChanged(object sender, EventArgs e)
        {
            //cButton1_CButtonClicked_1(null, null);
        }





    }
}