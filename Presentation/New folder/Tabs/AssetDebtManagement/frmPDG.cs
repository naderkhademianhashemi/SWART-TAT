using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using ERMS.Logic;
using ERMS.Model;
using ERMSLib;
using Presentation.Public;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmPDG : BaseForm, IPrintable
    {

        #region VARS

        public delegate void ChangedDelegate();
        public event ChangedDelegate Changed;
        private int maxBoxWidth, minBoxWidth;
        private bool bDirty = false;
        private int curModelID = -1;
        private PD pd;
        private DataTable dtColumnsAndScenario;
        private DataTable dtExcelFile;
        private bool NewExcelFile = false;
        #endregion  
        public frmPDG()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
        }
       
        private void frmPD_KeyDown(object sender, KeyEventArgs e)
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

        private void frmPD_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Save(curModelID, false);

            }
        }
        private void tsbModelNew_Click(object sender, EventArgs e)
        {
            if (!NewExcelFile)
            {
               Presentation.Public.Routines.ShowMessageBoxFa("هیج فایل جدیدی وارد نشده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
            }
            CommandModelNew();
        }
        private void tsbModelEdit_Click(object sender, EventArgs e)
        {
            CommandModelEdit();
        }
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            RefreshPD();
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
                    PDInfo di = (PDInfo)lsvModel.SelectedItems[0].Tag;
                    curModelID = di.ID;
                    RefreshGrid();
                    SelectedModelID();

                  
                 
                    return;
                }
            }

            curModelID = -1;
            //dgvList.DataSource = null;
            dgvList.Columns[0].HeaderText = "شماره قرارداد";
            dgvList.Columns[1].HeaderText = "احتمال نکول";
        
         

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

            
        }
        private void btnModel_Click(object sender, EventArgs e)
        {
            //if (spcAll.Panel2.Width == 0)
            //{
            //    //btnModel.Image = global::Presentation.Properties.Resources.panLeft;
            //    spcAll.Panel2Collapsed = false;
            //}
            //else
            //{
            //    //btnModel.Image = global::Presentation.Properties.Resources.PanRight;
            //    spcAll.Panel2Collapsed = true;
            //}
        }
        public void SelectedModelID()
        {
            int modelID = -1;
            if (lsvModel.SelectedItems.Count > 0)
                modelID = ((PDInfo)lsvModel.SelectedItems[0].Tag).ID;

            clsERMSGeneral.dtModel.Rows[0]["PD_Model"] = modelID;
        }
        private void CommandModelNew()
        {
            try
            {
                if (bDirty)
                {
                    if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        Save(curModelID, false);
                }

                CreateDtColumnsAndScenario();
                frmNewPD frmNPD = new frmNewPD(dtColumnsAndScenario, "ستون های انتخابی برای ایجاد سناریو");
                frmNPD.ShowDialog();
                if (frmNPD.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    dtColumnsAndScenario = frmNPD.dtReturnValue;

                    Utilize.Routines.ShowProcess();
                    foreach (DataRow dr in dtColumnsAndScenario.Rows)
                    {
                        ListViewItem lvi = new ListViewItem();
                        PDInfo pi = new PDInfo();

                        lvi.Text = dr[1].ToString();
                        lvi.Tag = pi;
                        lsvModel.Items.Add(lvi);

                        pi.PD_Model = lvi.Text;
                        pi.Type = "G";
                        pi.ID = pd.InsertPD(pi);

                        curModelID = pi.ID;

                        Save(curModelID, dtExcelFile, dr[0].ToString(), false);
                    }
                    ReBind();
                    NewExcelFile = false;
                    splitContainer4.Panel2Collapsed = true;
                    cbCollapseLeft.Visible = false;
                    tbOpenPD.Text = string.Empty;
                    Utilize.Routines.HideProcess();
                    Presentation.Public.Routines.ShowMessageBoxFa("سناریو(های) مورد نظر ذخیره شد", "ذخیره", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    dgvList.ReadOnly = false;
                    lsvModel.Items[lsvModel.Items.Count - 1].Selected=true;
                }
            }
            catch(Exception ex)
            {
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
                    PDInfo pi = (PDInfo)lvi.Tag;
                    pi.PD_Model = descr;
                    pd.UpdatePD(pi);
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
                    PDInfo pi = (PDInfo)lvi.Tag;

                    lvi.Remove();
                    pd.DeletePD(pi.ID);
                }
            }
        }
        private void Save(int modelID, bool bMessage)
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                PDInfo di = (PDInfo)lsvModel.SelectedItems[0].Tag;
                
                int pdmodelID = ((PDInfo)lsvModel.SelectedItems[0].Tag).ID;
                int PD_Model_Id = Convert.ToInt32(pdmodelID.ToString());                 
                Utilize.Routines.ShowProcess();
                pd.DeletePDElements(PD_Model_Id);
                //Save(PD_Model_Id, (DataTable)dgvList.DataSource, dgvList.Columns[1].HeaderText, false);
                Save(PD_Model_Id, (DataTable)dgvList.DataSource, "Contract_PD", false);
                Utilize.Routines.HideProcess();
                
                if (Changed != null)
                    Changed();
                bDirty = false;
            }

        }

        private void Save(int Pd_modelID, DataTable dtTable, string dtColumnName, bool bMessage)
        {
            try
            {
                for (int i = 0; i < dtTable.Rows.Count; i++)
                {
                    string Contract = dtTable.Rows[i][0].ToString();
                    decimal Contract_PD = Convert.ToDecimal(dtTable.Rows[i][dtColumnName].ToString());
                    pd.Update_PDModelElement(Pd_modelID, Contract, Contract_PD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillModel()
        {
            DataTable dt = pd.GetPD("G");

            foreach (DataRow dr in dt.Rows)
            {
                PDInfo pi = new PDInfo();
                pd.CloneX(dr, pi, ECloneXdir.DR2Info);
                ListViewItem lvi = new ListViewItem();
                lvi.Text = pi.PD_Model;
                lvi.Tag = pi;

                lsvModel.Items.Add(lvi);
            }
        
        }
        private void RefreshGrid()
         {
            Helper h = new Helper();
            //h.FormatDataGridView(dgvList);
            dgvList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            ReBind();
       
        }
        private void ReBind()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                int modelID = ((PDInfo)lsvModel.SelectedItems[0].Tag).ID;
                var PDElements = pd.GetPDElements(modelID);
                if (PDElements != null)
                {
                    
                
                    dgvList.DataSource = PDElements;
                    bDirty = false;
                }
         
            }
        }
        private void RefreshPD()
        {
            if (curModelID != -1)
            {
                pd.RefreshPD(curModelID);
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
                clsERMSGeneral.dgvActive = dataGridView1;
                
            }
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "PD";
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                tbOpenPD.Text = dlg.FileName;
                GetExcel();
                dgvList.ReadOnly = true;
            }
        }
        public void GetExcel()
        {
            if (System.IO.File.Exists(tbOpenPD.Text))
            {
                string HDR = string.Empty;
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا در فایل اکسل، ردیف عنوان برای ستون ها وجود دارد؟",
                                            "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    HDR = "HDR=YES;IMEX=1;\"";
                }
                else
                    HDR = "HDR=NO;IMEX=1;\"";

                string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;" + HDR, tbOpenPD.Text);
                string query = String.Format("select * from [{0}$]", "Sheet1");
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dgvList.Columns.Clear();
                dgvList.DataSource = null;
                chbColumnsOfExcel.Items.Clear();

                if (HDR == "HDR=NO;IMEX=1;\"")
                {
                    dataSet.Tables[0].Columns[0].ColumnName = "شماره قرارداد";
                    for (int i = 1; i < dataSet.Tables[0].Columns.Count; i++)
                    {
                        dataSet.Tables[0].Columns[i].ColumnName = "PD" + i;
                        chbColumnsOfExcel.Items.Add("PD" + i);
                        chbColumnsOfExcel.SetItemChecked(i - 1, true);
                    }
                }
                else
                {
                    for (int i = 1; i < dataSet.Tables[0].Columns.Count; i++)
                    {
                        chbColumnsOfExcel.Items.Add(dataSet.Tables[0].Columns[i].ColumnName);
                        chbColumnsOfExcel.SetItemChecked(i - 1, true);
                    }
                }

                dgvList.DataSource = dataSet.Tables[0];
                dtExcelFile = new DataTable();
                dtExcelFile = dataSet.Tables[0];
                NewExcelFile = true;
                splitContainer4.Panel2Collapsed = false;
                cbCollapseLeft.Visible = true;
            }
            else
            {
                Presentation.Public.Routines.ShowMessageBoxFa("هیج فایلی انتخاب نشده است.", "تایید", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        private void frmPD_Load(object sender, EventArgs e)
        {
          
            pd = new PD();

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;
            bDirty = false;
            curModelID = -1;
            maxBoxWidth = 250;
            minBoxWidth = 50;
            GeneralDataGridView = dgvList;
            FillModel();
        }

        private void btnModel_Click_1(object sender, EventArgs e)
        {
            if (splitContainer3.Panel1Collapsed == false)
            {
                splitContainer3.Panel1Collapsed = true;
                btnModel.DefaultImage = Properties.Resources.S_Panleft1;
                btnModel.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (splitContainer3.Panel1Collapsed == true)
            {
                splitContainer3.Panel1Collapsed = false;
                btnModel.DefaultImage = Properties.Resources.S_PanRight1;
                btnModel.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }

        private void cbCollapseLeft_CButtonClicked(object sender, EventArgs e)
        {
            if (splitContainer4.Panel2Collapsed == false)
            {
                splitContainer4.Panel2Collapsed = true;
                cbCollapseLeft.DefaultImage = Properties.Resources.S_Panleft1;
                cbCollapseLeft.HoverImage = Properties.Resources.S_Panleft_Hover1;                
            }
            else if (splitContainer4.Panel2Collapsed == true)
            {
                splitContainer4.Panel2Collapsed = false;
                cbCollapseLeft.DefaultImage = Properties.Resources.S_PanRight1;
                cbCollapseLeft.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }

        private void chbColumnsOfExcel_SelectedIndexChanged(object sender, EventArgs e)
        {
          //
          //  MessageBox.Show(chbColumnsOfExcel.SelectedItem.ToString());
        }

        private void chbColumnsOfExcel_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue.ToString() == "Checked" && dgvList.DataSource != null)
                dgvList.Columns[chbColumnsOfExcel.Items[e.Index].ToString()].Visible = true;
            else if (dgvList.DataSource != null)
                dgvList.Columns[chbColumnsOfExcel.Items[e.Index].ToString()].Visible = false;

        }


        private void CreateDtColumnsAndScenario()
        {
            dtColumnsAndScenario = new DataTable();
            dtColumnsAndScenario.Columns.Add("نام ستون انتخابی");
            dtColumnsAndScenario.Columns.Add("نام سناریو متناظر");

            for (int i = 1; i < dgvList.Columns.Count; i++)
            {
                if (dgvList.Columns[i].Visible)
                {
                    DataRow dr;
                    dr = dtColumnsAndScenario.NewRow();
                    dr["نام ستون انتخابی"] = dgvList.Columns[i].Name;
                    dr["نام سناریو متناظر"] = string.Empty;
                    dtColumnsAndScenario.Rows.Add(dr);
                }
            }
        }

        private void dgvList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //bDirty = true;
        }


    }
}









