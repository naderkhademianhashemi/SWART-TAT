using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using ERMS.Logic;
using ERMS.Model;

//

using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinTree;
using ERMSLib;
using FarsiLibrary.Utils;
using Presentation.Public;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmNII : BaseForm, IPrintable
    {
        #region CONST
        private const int CTE_Group_None = 0;
        private const int CTE_Group_Currency = 1;
        private const int CTE_Group_ContractType = 2;
        private const int CTE_Group_GroupName = 3;
        #endregion

        #region VAR
        private FSM fsm;
        private NII nii;
        private int maxNodeWidth;
        private int curModelID = 1;
        #endregion

        public frmNII()
        {
            this.SizeChanged += new EventHandler(frmNII_SizeChanged);
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
            
        }

        void frmNII_SizeChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Size.Width + " " + this.Size.Height);
            this.Dock = DockStyle.Fill;
        }
        private void frmNII_Load(object sender, EventArgs e)
        {
            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");
            fdpStartDate.SelectedDateTime = DateTime.Now;
            Init();
        }
        private void Init()
        {
            fsm = new FSM();
            nii = new NII();

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;

            btnAdd.Enabled = false;
            miAdd.Enabled = false;
            tabResult.Enabled = false;

            maxNodeWidth = 200;
            ut.Indent = 32;
            //ut.Override.ItemHeight = 32;
            ut.Override.SelectionType = SelectType.None;
            ut.Override.ActiveNodeAppearance.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            ut.Override.ActiveNodeAppearance.BackColor2 = Color.FromKnownColor(KnownColor.Highlight);
            ut.Override.ActiveNodeAppearance.ForeColor = Color.FromKnownColor(KnownColor.HighlightText);
            ut.Override.NodeAppearance.BorderColor = Color.Silver;
            ut.Override.NodeAppearance.BorderColor2 = Color.LightGray;
            ut.Override.BorderStyleNode = UIElementBorderStyle.Solid;
            ut.Override.NodeAppearance.BackGradientAlignment = GradientAlignment.Default;
            ut.Override.NodeAppearance.BackGradientStyle = GradientStyle.Horizontal;
            ut.Override.NodeAppearance.BackColor2 = Color.WhiteSmoke;
            ut.Override.NodeSpacingBefore = 4;
            ut.Override.NodeAppearance.TextVAlign = VAlign.Middle;
            ut.Override.MaxLabelWidth = maxNodeWidth;

            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            cmbGroupBy.AddItemsRange(new string[] { "همه", "ارز", "نوع قرارداد", "نام گروه" });
            //cmbGroupBy.SelectedIndex = 0;

            FillModel();

            //PersianTools.Dates.PersianDate p1;
            // add for farsi        
            ///p1 = new PersianTools.Dates.PersianDate(int.Parse(.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            //DateTime startDate = DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));
            fdpStartDate.Text = PersianDateConverter.ToPersianDate(DateTime.Now).ToString("yyyy/MM/dd");
        }

        public void SelectedModelID()
        {
            int modelID = -1;
            if (lsvModel.SelectedItems.Count > 0)
                modelID = ((NIIMInfo)lsvModel.SelectedItems[0].Tag).ID;

            clsERMSGeneral.dtModel.Rows[0]["NII_Model"] = modelID;
        }
        
        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
            {
                if (lsvModel.SelectedItems.Count > 0)
                {
                    NIIMInfo ni = (NIIMInfo)lsvModel.SelectedItems[0].Tag;
                    curModelID = ni.ID;

                    ut.Nodes.Clear();
                    tabResult.Enabled = true;
                    btnAdd.Enabled = true;
                    miAdd.Enabled = true;
                    FillFSM(ni.FSModelID);
                    SelectedModelID();
                    return;
                }
            }

            //else..
            curModelID = -1;
            ut.Nodes.Clear();            
            dgvList.Columns.Clear();
            dgvIRCurve.Columns.Clear();
            btnAdd.Enabled = false;
            miAdd.Enabled = false;
            tabResult.Enabled = false;
        }
        private void lsvModel_DoubleClick(object sender, EventArgs e)
        {
            CommandModelEdit();
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

        private void CommandModelNew()
        {
             frmNewNII fx = new frmNewNII();
            fx.InUpdate = false;
            if (fx.ShowDialog() == DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem();
                NIIMInfo ni = new NIIMInfo();
                lvi.Text = fx.Title;
                lvi.Tag = ni;
                lsvModel.Items.Add(lvi);

                //                
                ni.ModelName = fx.Title;
                ni.FSModelID = fx.FSModelID;
               ni.CBModelID = fx.CBModelID;
                ni.ID = nii.InsertNIIM(ni);

                curModelID = ni.ID;

                //
                lvi.Selected = true;
            }
        }        
        private void CommandModelEdit()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvModel.SelectedItems[0];

                frmNewNII fx = new frmNewNII();
                fx.InUpdate = true;  
                if (fx.ShowDialog() == DialogResult.OK)
                {
                    lvi.Text = fx.Title;

                    //
                    NIIMInfo ni = (NIIMInfo)lvi.Tag;
                    ni.ModelName = fx.Title;
                    nii.UpdateNIIM(ni);
                }
            }
        }
        private void CommandModelRemove()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("مدل انتخاب شده شما حذف خواهد شد. آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem lvi = lsvModel.SelectedItems[0];
                    NIIMInfo ni = (NIIMInfo)lvi.Tag;

                    if (Presentation.Miscs.CheckDependents.Show(CheckDep.CHECK_NII, ni.ID.ToString()) == DialogResult.Cancel)
                        return;

                    lvi.Remove();
                    nii.DeleteNIIM(ni.ID);
                }
            }
        }

        private void CommandAdd()
        {            
            if (lsvModel.SelectedItems.Count == 0 || ut.ActiveNode == null)
                return;

            NIIMInfo modelInfo = (NIIMInfo)lsvModel.SelectedItems[0].Tag;
            FSMElementInfo nodeInfo = ((FSMElementInfo)ut.ActiveNode.Tag);

            int niiModelID = modelInfo.ID;
            int fsModelElementID = nodeInfo.ID;
            string contractType = nodeInfo.ContractType;
            int cbModelID = modelInfo.CBModelID;
            int tbModelID = -1;
            int currencyID = -1;

            if (nodeInfo.IsTitle)
            {
                return;
            }

            frmInput fx = new frmInput();
            if (contractType == string.Empty)
            {
                CBM cbm = new CBM();
                CBMInfo cbmInfo = new CBMInfo();
                cbm.CloneX(cbm.GetCBM(cbModelID), cbmInfo, ECloneXdir.DR2Info);

                tbModelID = cbmInfo.TBModelID;
                currencyID = (int)ECurrency.Rial;
            }
            else
                if (fx.ShowDialog() == DialogResult.OK)
                {
                    tbModelID = fx.TBModelID;
                    currencyID = fx.CurrencyID;
                }
                else
                    return;

            NII nii = new NII();
            nii.CreateNiiCTElements(niiModelID, fsModelElementID, tbModelID, cbModelID, currencyID, false);

            DataTable dt = nii.GetNiiCTElements(niiModelID, fsModelElementID);
            Append(dt);

            ut.ActiveNode.Override.NodeAppearance.Image = global::Presentation.Properties.Resources.CheckMark;

        }
        private void CommandNext()
        {
            if ((cmbGroup.SelectedIndex < cmbGroup.Items.Count - 1) && cmbGroup.Items.Count > 0)
                cmbGroup.SelectedIndex = cmbGroup.SelectedIndex + 1; 
        }
        private void CommandPrev()
        {
            if (cmbGroup.SelectedIndex > 0 && cmbGroup.Items.Count > 0)
                cmbGroup.SelectedIndex = cmbGroup.SelectedIndex - 1; 
        }
        private void CommandDelete()
        {
            if (dgvList.CurrentCell != null)
            {
                try
                {
                    if (Presentation.Public.Routines.ShowMessageBoxFa(" همه آیتم ها حذف خواهند شد. آیا مطمئن هستید؟ ", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                        return;
                        
                    int colIndex = dgvList.CurrentCell.ColumnIndex;
                    int rowIndex = dgvList.CurrentCell.RowIndex;

                    int currency = Convert.ToInt32(dgvList.Rows[rowIndex].Cells[NII.CTE_Alias_NiiElement_Currency].Value);
                    int fsModelID = ((FSMElementInfo)ut.ActiveNode.Tag).ID;

                    nii.DeleteCurrency(curModelID, fsModelID, currency);
                    ReBindList();

                    if (dgvList.Rows.Count == 0)
                        ut.ActiveNode.Override.NodeAppearance.Image = global::Presentation.Properties.Resources.StarRed;
                }
                catch { }
            }
        }

        private void tsbPrev_Click(object sender, EventArgs e)
        {
            CommandPrev();
        }
        private void tsbNext_Click(object sender, EventArgs e)
        {
            CommandNext();
        }
        private void miAdd_Click(object sender, EventArgs e)
        {
            CommandAdd();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CommandAdd();
        }
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            CommandDelete();
        }
        private void tsmiNew_Click(object sender, EventArgs e)
        {
            CommandAdd();
        }

        private void ut_AfterActivate(object sender, NodeEventArgs e)
        {
            if (e.TreeNode != null)
            {
                FSMElementInfo fei = (FSMElementInfo)e.TreeNode.Tag;

                NII nii = new NII();
                DataTable dt = nii.GetNiiCTElements(curModelID, fei.ID);
                Append(dt);
            }
        }
   
        private void dgvList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ChangeValue(e.ColumnIndex, e.RowIndex);
        }
        private void cmbGroupBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareGrouping();
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvIRCurve.DataSource is DataTable)
            {
                DataTable dt = (DataTable)dgvIRCurve.DataSource;
                ApplyFilter(dt);
                                
                tsbPrev.Enabled = cmbGroup.SelectedIndex != 0;
                tsbNext.Enabled = cmbGroup.SelectedIndex != cmbGroup.Items.Count - 1;                
            } 
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshIRCurveGrid(true);
        }

        private void FillModel()
        {
            DataTable dt = nii.GetNIIMs();
            foreach (DataRow dr in dt.Rows)
            {
                NIIMInfo ni = new NIIMInfo();
                nii.CloneX(dr, ni, ECloneXdir.DR2Info);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = ni.ModelName;
                lvi.Tag = ni;

                lsvModel.Items.Add(lvi);
            }
        }    
        private void FillFSM(int fsModelID)
        {
   ut.Nodes.Clear();

            UltraTreeNode utn;

            Hashtable htFSMs = new Hashtable();
            DataTable dt = fsm.GetFSMelements(fsModelID);
            foreach (DataRow dr in dt.Rows)
            {
                FSMElementInfo fei = new FSMElementInfo();
                fsm.CloneX(dr, fei, ECloneXdir.DR2Info);

                string parentNodeKey = string.Empty;
                if (htFSMs.Contains(fei.ParentId))
                    parentNodeKey = htFSMs[fei.ParentId].ToString();

                if (parentNodeKey == string.Empty)
                {
                    utn = ut.Nodes.Add(fei.ID.ToString());
                }
                else
                {
                    UltraTreeNode utnParent = ut.GetNodeByKey(parentNodeKey);
                    utn = utnParent.Nodes.Add(fei.ID.ToString());
                }

                utn.Tag = fei;                
                utn.Text = fei.ContractType;
                if (fei.ContractType != string.Empty)
                    utn.Override.NodeAppearance.BackColor = Color.FromArgb(fei.Color);
                else
                {
                    utn.Text = fei.Caption;

                    if (fei.IsTitle)
                    {
                        utn.Override.NodeAppearance.ForeColor = Color.White;
                        utn.Override.NodeAppearance.BackColor = Color.LightGray;
                        utn.Override.NodeAppearance.BackColor2 = Color.LightGray;
                    }
                    else
                    {
                        utn.Override.NodeAppearance.ForeColor = Color.DimGray;
                        utn.Override.NodeAppearance.BackColor = Color.Ivory;
                        utn.Override.NodeAppearance.BackColor2 = Color.Ivory;
                    }
                }
                SetNodeText(utn);

                Check4Existance(utn);

                htFSMs.Add(fei.ID, utn.Key);
            }

            ut.ExpandAll();
        }

        private void Check4Existance(UltraTreeNode utn)
        {
            FSMElementInfo fei = (FSMElementInfo)utn.Tag;
            if (nii.ElementExists(curModelID, fei.ID))
            {
                utn.Override.NodeAppearance.Image = global::Presentation.Properties.Resources.StarGreen;
            }
            else
            {
                utn.Override.NodeAppearance.Image = global::Presentation.Properties.Resources.StarRed;
            }
        }
        private void SetNodeText(UltraTreeNode utn)
        {
            int preferredWidth = maxNodeWidth;
            int width = TextRenderer.MeasureText(utn.Text, this.Font).Width;
            int extra = TextRenderer.MeasureText(Char.ConvertFromUtf32(8203) + Char.ConvertFromUtf32(8203), this.Font).Width;
            string s = utn.Text;
            if (width <= preferredWidth)
            {
                while (width <= preferredWidth - 2 * extra)
                {
                    s = s + " ";
                    width = TextRenderer.MeasureText(s, this.Font).Width;
                }

                utn.Text = Char.ConvertFromUtf32(8203) + " " + s + Char.ConvertFromUtf32(8203);
                utn.Override.TipStyleNode = TipStyleNode.Hide;
            }
            else
            {
                utn.Override.NodeAppearance.TextTrimming = TextTrimming.EllipsisPath;
                utn.Override.TipStyleNode = TipStyleNode.Show;
            }
        }       

        private void ReBindList()
        {
            if (ut.ActiveNode != null)
            {
                FSMElementInfo fei = (FSMElementInfo)ut.ActiveNode.Tag;

                NII nii = new NII();
                DataTable dt = nii.GetNiiCTElements(curModelID, fei.ID);
                dgvList.Columns.Clear();
                Append(dt);
            }
        }
        private void ChangeValue(int columnIndex, int rowIndex)
        {
            if (dgvList.Columns[columnIndex].Name == NII.CTE_Alias_NiiElement_CurrentInterestRate)
            {
                try
                {
                    decimal val = Convert.ToDecimal(dgvList[columnIndex, rowIndex].Value);
                    int id = (int)dgvList[NII.CTE_Alias_NiiElement_ID, rowIndex].Value;
                    nii.UpdateNiiElement(id, val, -1);
                }
                catch { }
            }
            if (dgvList.Columns[columnIndex].Name == NII.CTE_Alias_NiiElement_ForecastedInterestRate)
            {
                try
                {
                    decimal val = Convert.ToDecimal(dgvList[columnIndex, rowIndex].Value);
                    int id = (int)dgvList[NII.CTE_Alias_NiiElement_ID, rowIndex].Value;
                    nii.UpdateNiiElement(id, -1, val);
                }
                catch { }
            }
        }
        private void ToggleDetail(bool bShow)
        {
            dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_RP].Visible = bShow;
            dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_TRP].Visible = bShow;
            dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_WPR].Visible = bShow;
            dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_IWPR].Visible = bShow;
            dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_IWPFR].Visible = bShow;
        }
        private void Append(DataTable dt)
        {
            DataTable curDT = (DataTable)dgvList.DataSource;

            if (curDT == null)
                dgvList.DataSource = dt;
            else
            {
                curDT.Merge(dt);
                dgvList.DataSource = dt;
            }

            RefreshCTGrid();
        }
        private void RefreshCTGrid()
        {
            Helper h = new Helper();
            h.FormatDataGridView(dgvList);           

            //if (!dgvList.Columns.Contains("Dummy"))
            //{
            //    DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
            //    tCol.MinimumWidth = 1023;
            //    tCol.Name = "Dummy";
            //    tCol.HeaderText = string.Empty;
            //    dgvList.Columns.Add(tCol);
            //}

            dgvList.ReadOnly = false;
            dgvList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            
            dgvList.Columns["Group Name"].HeaderText = "نام گروه";
            dgvList.Columns["Contract Type"].HeaderText = "نوع قرارداد";
            dgvList.Columns["Currency"].HeaderText = "ارز";
            dgvList.Columns[NII.CTE_Alias_NiiElement_CurrentInterestRate].HeaderText = "نرخ سود جاری";
            dgvList.Columns[NII.CTE_Alias_NiiElement_ForecastedInterestRate].HeaderText = "نرخ سود پیش بینی شده";

            dgvList.Columns["Group Name"].MinimumWidth = (dgvList.Width)*25 / 100;
            dgvList.Columns["Contract Type"].MinimumWidth = (dgvList.Width)*25 / 100;
            dgvList.Columns["Currency"].MinimumWidth = (dgvList.Width) *15/ 100;
            dgvList.Columns[NII.CTE_Alias_NiiElement_CurrentInterestRate].MinimumWidth = (dgvList.Width)*20 / 100;
            dgvList.Columns[NII.CTE_Alias_NiiElement_ForecastedInterestRate].MinimumWidth = (dgvList.Width)*15 / 100;

            dgvList.Columns[NII.CTE_Alias_NiiElement_CurrentInterestRate].ReadOnly = false;
            dgvList.Columns[NII.CTE_Alias_NiiElement_ForecastedInterestRate].ReadOnly = false;
            dgvList.Columns[NII.CTE_Alias_NiiElement_ContractTypeDescr].ReadOnly = true;
            dgvList.Columns[NII.CTE_Alias_NiiElement_BucketName].ReadOnly = true;
            dgvList.Columns[NII.CTE_Alias_NiiElement_CurrencyDescr].ReadOnly = true;

            dgvList.Columns[NII.CTE_Alias_NiiElement_ID].Visible = false;
            dgvList.Columns[NII.CTE_Alias_NiiElement_NIIModelID].Visible = false;
            dgvList.Columns[NII.CTE_Alias_NiiElement_FSModelElementID].Visible = false;
            dgvList.Columns[NII.CTE_Alias_NiiElement_TBModelElementID].Visible = false;
            dgvList.Columns[NII.CTE_Alias_NiiElement_Currency].Visible = false;
            dgvList.Columns[NII.CTE_Alias_NiiElement_ContractType].Visible = false;
            dgvList.Columns[NII.CTE_Alias_NiiElement_BucketName].Visible = false;
            dgvList.Columns[NII.CTE_Alias_NiiElement_ForecastedInterestRate].DefaultCellStyle.Format = "###,###.##";
            dgvList.Columns[NII.CTE_Alias_NiiElement_CurrentInterestRate].DefaultCellStyle.Format = "###,###.##";
        }
        private void PrepareGrouping()
        {
            if (cmbGroupBy.SelectedIndex == CTE_Group_None)
            {
                cmbGroup.DataSource = null;
                cmbGroup.Enabled = false;
                tsGroup.Enabled = false;

                //
                if (dgvIRCurve.DataSource is DataTable)
                {
                    ((DataTable)dgvIRCurve.DataSource).DefaultView.RowFilter = string.Empty;
                }
            }

            if (cmbGroupBy.SelectedIndex == CTE_Group_Currency)
            {
                cmbGroup.Enabled = true;
                tsGroup.Enabled = true;                                

                cmbGroup.DataSource = nii.GetNiiElements(curModelID, NII.CTE_Groups_Currency);
                cmbGroup.ValueMember = NII.CTE_Groups_ID;
                cmbGroup.DisplayMember = NII.CTE_Groups_Descr;                

                cmbGroup.SelectedIndex = -1;
                cmbGroup.SelectedIndex = cmbGroup.Items.Count > 0 ? 0 : -1;
            }

            if (cmbGroupBy.SelectedIndex == CTE_Group_ContractType)
            {
                cmbGroup.Enabled = true;
                tsGroup.Enabled = true;                
                
                cmbGroup.DataSource = nii.GetNiiElements(curModelID, NII.CTE_Groups_ContractType);
                cmbGroup.ValueMember = NII.CTE_Groups_ID;
                cmbGroup.DisplayMember = NII.CTE_Groups_Descr;

                cmbGroup.SelectedIndex = -1;
                cmbGroup.SelectedIndex = cmbGroup.Items.Count > 0 ? 0 : -1;
            }

            if (cmbGroupBy.SelectedIndex == CTE_Group_GroupName)
            {
                cmbGroup.Enabled = true;
                tsGroup.Enabled = true;

                cmbGroup.DataSource = nii.GetNiiElements(curModelID, NII.CTE_Groups_GroupName);
                cmbGroup.ValueMember = NII.CTE_Groups_ID;
                cmbGroup.DisplayMember = NII.CTE_Groups_Descr;

                cmbGroup.SelectedIndex = -1;
                cmbGroup.SelectedIndex = cmbGroup.Items.Count > 0 ? 0 : -1;
            }
        }
        private void ApplyFilter(DataTable dt)
        {
            if (cmbGroup.SelectedIndex == -1 || cmbGroup.SelectedValue is DataRowView)
                return;

            if (cmbGroupBy.SelectedIndex == CTE_Group_None || cmbGroup.Items.Count == 0)
            {
                dt.DefaultView.RowFilter = string.Empty;
                return;
            }

            if (cmbGroupBy.SelectedIndex == CTE_Group_Currency)
            {
                if (cmbGroup.SelectedValue != DBNull.Value)
                    dt.DefaultView.RowFilter = "[" + NII.CTE_Alias_NiiResult_CurrencyID + "] = " + cmbGroup.SelectedValue.ToString();
            }
            if (cmbGroupBy.SelectedIndex == CTE_Group_ContractType)
            {
                if (cmbGroup.SelectedValue == DBNull.Value)
                    dt.DefaultView.RowFilter = "[" + NII.CTE_Alias_NiiResult_ContractType + "] IS NULL";
                else
                    dt.DefaultView.RowFilter = "[" + NII.CTE_Alias_NiiResult_ContractType + "] = " + cmbGroup.SelectedValue.ToString();
            }
            if (cmbGroupBy.SelectedIndex == CTE_Group_GroupName)
            {
                if (cmbGroup.SelectedValue != DBNull.Value)
                    dt.DefaultView.RowFilter = "[" + NII.CTE_Alias_NiiResult_GroupName + "] = '" + cmbGroup.SelectedValue.ToString() + "'";
            }
        }

        //Revised - 1.1
        private void tsbModelSave_Click(object sender, EventArgs e)
        {
            Presentation.Public.Routines.ShowMessageBoxFa("مدل شما ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModel_Click(object sender, EventArgs e)
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

        private void chkDetail_CheckedChanged(object sender, EventArgs e)
        {
            ToggleDetail();
        }

        private void ToggleDetail()
        {
            RefreshIRCurveGrid(true);
        }

        private void RefreshIRCurveGrid(bool bRecalc)
        {
            try
            {
                ProgressBox.Show();

                Helper h = new Helper();
                h.FormatDataGridView(dgvIRCurve);

                //Hosein - Momkene in date lazem bashe farsi bashe
                if (bRecalc)
                    nii.UpdateNiiSummaryElements(curModelID, fdpStartDate.SelectedDateTime);

                DataTable dt = null;

                if (chkDetail.Checked)
                    dt = nii.GetNiiElements(curModelID, NII.CTE_Groups_None);
                else
                    dt = nii.GetNiiResult(curModelID);

                PrepareGrouping();
                 ApplyFilter(dt);

                dgvIRCurve.Columns.Clear();
                dgvIRCurve.DataSource = dt;

                //Dummy Column
                DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
                tCol.MinimumWidth = 1023;
                tCol.Name = "Dummy";
                tCol.HeaderText = string.Empty;
                dgvIRCurve.Columns.Add(tCol);

                if (chkDetail.Checked)
                {
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_Currency].Visible = false;
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_ContractType].Visible = false;
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_CurrentInterestRate].DefaultCellStyle.Format = "###,###.## ";
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_ForecastedInterestRate].DefaultCellStyle.Format = "###,###.## ";

                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_GroupName].HeaderText = "نام گروه";
                    dgvIRCurve.Columns["Source"].HeaderText = "منبع";
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_BucketName].HeaderText = "بسته زمانی";
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_CurrentInterestRate].HeaderText = "نرخ سود جاری";
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_ForecastedInterestRate].HeaderText = "نرخ سود پیش بینی شده";


                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_IWPFR].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_IWPFR].DefaultCellStyle.Format = "###,##0.## ";
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_IWPR].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_IWPR].DefaultCellStyle.Format = "###,##0.## ";
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_RP].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_RP].DefaultCellStyle.Format = "###,##0.##";
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_TRP].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_TRP].DefaultCellStyle.Format = "###,##0.##";
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_WPR].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_WPR].DefaultCellStyle.Format = "###,##0.## ";
                }
                else
                {

                    dgvIRCurve.Columns[NII.CTE_Alias_NiiResult_ID].Visible = false;
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiResult_NIIModelID].Visible = false;
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiResult_CurrencyID].Visible = false;
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_ContractType].Visible = false;
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiResult_TIWPR].DefaultCellStyle.Format = "###,##0.## ";
                    dgvIRCurve.Columns[NII.CTE_Alias_NiiResult_TIWPFR].DefaultCellStyle.Format = "###,##0.## ";
                }

                dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_CurrencyDescr].HeaderText = "ارز";
                dgvIRCurve.Columns["Contract Type"].HeaderText = "نوع قرارداد";
                dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_GroupName].HeaderText = "نام گروه";
                dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_CurrentInterestRate].HeaderText = "نرخ سود جاری";
                dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_ForecastedInterestRate].HeaderText = "نرخ سود پیش بینی شده";
                dgvIRCurve.Columns[NII.CTE_Alias_NiiElement_ContractType].Frozen = true;
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("برنامه با خطا مواجه شده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }
          

        }

        private void frmNII_KeyDown(object sender, KeyEventArgs e)
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
                Presentation.Public.Routines.ShowMessageBoxFa("مدل شما ذخيره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Remove
            if (e.Control && e.KeyCode.ToString() == "D")
            {
                CommandModelRemove();
            }

            //Refresh
            if (e.KeyCode == Keys.F5)
            {
                RefreshIRCurveGrid(true);
            }


            if (e.Shift && e.KeyCode == Keys.Right)
            {
                CommandNext();
            }
            if (e.Shift && e.KeyCode == Keys.Left)
            {
                CommandPrev();
            }
            if (e.Alt && e.KeyCode.ToString() == "N")
            {
                CommandAdd();

            }
          
        }

        private void chkDgvList2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIRCurve.Checked == true)
            {
                chkDgvList.Checked = false;
                clsERMSGeneral.dgvActive = dgvIRCurve;
                GeneralDataGridView = dgvIRCurve;                     
            }
        }

        private void chkDgvList1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDgvList.Checked == true)
            {
                chkIRCurve.Checked = false;
                clsERMSGeneral.dgvActive = dgvList;
                GeneralDataGridView = dgvList;
            }
        }

        private void tpVal_Click(object sender, EventArgs e)
        {

        }
        
        private void chkDgvList_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDgvList.Checked == true)
            {
                chkIRCurve.Checked = false;
                clsERMSGeneral.dgvActive = dgvList;
                GeneralDataGridView = dgvList;
            }
        }

        private void chkIRCurve_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIRCurve.Checked == true)
            {
                chkDgvList.Checked = false;
                clsERMSGeneral.dgvActive = dgvIRCurve;
                GeneralDataGridView = dgvIRCurve;
            }
        }
        public void DoPrint()
        {
            //empty print
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "NII";
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            lsvModel.Clear();
            
            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;

            FillModel();
        }

        private void btnAdd_Load(object sender, EventArgs e)
        {

        }
    }
}