using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ERMS.Logic;
using ERMS.Model;

//
using Presentation.Public;
using MyDialogButton = Utilize.MyDialogButton;
using ProgressBox = Presentation.Public.ProgressBox;


namespace Presentation.Tabs.FinancialRatio
{
    public partial class frmFncRatioModel : BaseForm, IPrintable
    {
         #region VAR

        private const int CTE_Checked_ColIndex = 0;
        private const int CTE_AccountCode_ColIndex = 1;
        private const int CTE_AccountName_ColIndex = 2;
        private FncRatio_BL FncBL;
        private bool bDirty;
        private Hashtable htNodes;
        private frmFncGroup fxGroup;
        private TreeNode tnRoot;
        private List<int> lsRemovedGroupIDs, lsRemovedElementIDs;
        private List<string> VirtualTree;

        private DataTable dtDgvAccountGL;
        #endregion VAR

        public frmFncRatioModel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            ERMSLib.clsERMSGeneral.InitializeTheme(this);
        }
        private void frmFncRatioModel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            FncBL = new FncRatio_BL();
            htNodes = new Hashtable();
            fxGroup = new frmFncGroup();

            //*  bDirty = false;
            tsbSave.Enabled = false;
            lblProgress.Visible = false;

            trv.ItemHeight = 32;
            trv.Indent = 40;
            trv.TreeInfoEx.Width4MinBox = 240;


            lsRemovedGroupIDs = new List<int>();
            lsRemovedElementIDs = new List<int>();
            VirtualTree = new List<string>();

            // for filling the Account lists
            dgvAccountGL.Tag = EAccountCategory.AccountGL;

            Reload();
        }
        private void frmFncRatioModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید تغییرات خود را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SaveDiagram(false);
            }
        }
        private void frmFncRatioModel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode.ToString() == "N")
            {
                CommandAdd();
            }
            if (e.Alt && e.KeyCode.ToString() == "E")
            {
                CommandEdit();
            }
            if (e.Alt && e.KeyCode.ToString() == "S")
            {
                SaveDiagram(true);
            }
            if (e.Shift && e.KeyCode == Keys.Up)
            {
                CommandMoveUp();
            }
            if (e.Shift && e.KeyCode == Keys.Down)
            {
                CommandMoveDown();
            }
            if (e.Shift && e.KeyCode == Keys.Right)
            {
                CommandMoveRight();
            }
            if (e.Shift && e.KeyCode == Keys.Left)
            {
                CommandMoveLeft();
            }
            //Load, Refresh
            if (e.KeyCode == Keys.F5)
            {
                Reload();
            }
            //Delete
            if (e.Alt && e.KeyCode.ToString() == "D")
            {
                CommandRemove();
            }
        }

        #region General Function

        private void ShowProgress(string msg)
        {
            Application.DoEvents();
            lblProgress.Text = msg;
            Application.DoEvents();
        }
        private void Reload()
        {
            try
            {
                ProgressBox.Show();
                Cursor.Current = Cursors.WaitCursor;
                lblProgress.Visible = true;
                trv.Nodes.Clear();
                VirtualTree.Clear();
                ShowProgress("Loading...");

                FillAccounts();
                FillDiagram();

                lsRemovedGroupIDs.Clear();
                lsRemovedElementIDs.Clear();

                tsbSave.Enabled = true;

                lblProgress.Visible = false;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }
        }
        private void Filter(string criteria)
        {
            string filter = (criteria != string.Empty) ? string.Format("Name LIKE '%{0}%' OR Code LIKE '%{0}%'", criteria) : string.Empty;

            ((DataTable)dgvAccountGL.DataSource).DefaultView.RowFilter = filter;
            //((DataTable)dgvNonAccount.DataSource).DefaultView.RowFilter = filter;
            //((DataTable)dgvAGL199.DataSource).DefaultView.RowFilter = filter;
        }
        private bool AddAccount(string accountCode, String accountName, EAccountCategory eAccountCategory)
        {
            FncRatioInfo Fnc;

            var selNode = trv.SelectedNode;
            if (selNode != null && (selNode != tnRoot || ModifierKeys == Keys.Alt))
            {

                if (ModifierKeys == Keys.Alt)
                {
                    if (selNode.Tag is FncRatioInfo && selNode == tnRoot)
                    {
                        Fnc = new FncRatioInfo();
                        if (eAccountCategory == EAccountCategory.AccountGL) Fnc.GL = (int)EGL.GL;
                        if (eAccountCategory == EAccountCategory.NonAccount) Fnc.GL = (int)EGL.NA;
                        if (eAccountCategory == EAccountCategory.AGL199) Fnc.GL = (int)EGL.GL199;
                        Fnc.GroupName = accountName;
                        Fnc.Color = Color.Orange.ToArgb();

                        var tnGroup = new TreeNode {Text = accountName};
                        tnGroup.ToolTipText = tnGroup.Text;
                        tnGroup.Tag = Fnc;
                        tnGroup.BackColor = Color.FromArgb(Fnc.Color);
                        selNode.Nodes.Add(tnGroup);
                        tnGroup.EnsureVisible();

                        return true;
                    }
                }

                if (selNode != tnRoot)
                {
                    var tnParent = (selNode.Tag is FncRatioInfo) ? selNode : selNode.Parent;
                    Fnc = (FncRatioInfo)tnParent.Tag;
                    if (eAccountCategory != Fnc.AccountCategory)
                    {
                        Presentation.Public.Routines.ShowMessageBoxFa("نوع حساب نمی تواند با گروه حساب متفاوت باشد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    var FncElement = new FncRatioElementInfo
                                         {
                                             AccountCode = accountCode,
                                             AccountName = accountName,
                                             GroupID = Fnc.ID,
                                             ObjectState = EObjectState.New
                                         };

                    var tnNew = new TreeNode
                                    {
                                        Text =
                                            tsbNameCode.Checked
                                                ? FncElement.AccountName
                                                : FncElement.AccountCode
                                    };
                    tnNew.Text = (ModifierKeys == Keys.Shift ? "(-) " : "") + tnNew.Text;
                    if (ModifierKeys == Keys.Shift)
                        FncElement.Coef = -1;
                    else
                        FncElement.Coef = +1;

                    tnNew.ToolTipText = tnNew.Text;
                    tnNew.Tag = FncElement;
                    tnNew.BackColor = Color.LightBlue;
                    if (tnParent.Nodes.Cast<TreeNode>().Any(node=>node.Text.Equals(tnNew.Text)))
                    {
                        Presentation.Public.Routines.ShowErrorMessageFa("پیغام", "حساب انتخابی قبلاً وارد شده است",
                                                            Public.MyDialogButton.OK);
                        return false;
                    }
                    tnParent.Nodes.Add(tnNew);
                    tnNew.EnsureVisible();

                    return true;
                }
            }
            else
            {
                Presentation.Public.Routines.ShowMessageBoxFa("لطفا يك گروه حساب انتخاب كنيد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return false;
        }
        private bool EditCaption(TreeNode tn)
        {
            Point loc = trv.PointToScreen(new Point(tn.Bounds.Left + trv.Indent, tn.Bounds.Y + trv.ItemHeight));

            FncRatioInfo FncPrev = (FncRatioInfo)tn.Tag;
            FncRatioInfo Fnc = FncPrev.Clone();
            fxGroup.Location = loc;
            fxGroup.Info = Fnc;

            if (fxGroup.ShowDialog() == DialogResult.OK)
            {
                Fnc = fxGroup.Info;

                TreeNode tnParent = tn.Parent;

                if (tnParent != tnRoot)
                {

                    Presentation.Public.Routines.ShowMessageBoxFa("گروههاي حساب تنها در بالا ترين سطح مي تواند قرار بگيرد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;

                }
                tn.Text = tn.ToolTipText = Fnc.GroupName;


                tn.BackColor = Color.FromArgb(Fnc.Color);
                tn.Tag = Fnc;

                return true;
            }
            return false;
        }
        private void CommandAdd()
        {
            if (trv.SelectedNode == null)
                return;

            if (trv.SelectedNode.Tag is FncRatioElementInfo)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("زماني كه عنصر انتخاب شده يك حساب باشد، عمليات فوق امكان پذير نمی باشد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            trv.BeginUpdate();
            TreeNode tn = new TreeNode();
            FncRatioInfo Fnc = new FncRatioInfo {Color = Color.LightBlue.ToArgb()};
            tn.Tag = Fnc;
            tn.Text = "New Item";


            TreeNode tnParent = trv.SelectedNode;
            if (tnParent != tnRoot)
            {
                tnParent.Nodes.Add(tn);
                tnParent.Expand();
            }
            else
                tnRoot.Nodes.Add(tn);
            tn.EnsureVisible();
            trv.SelectedNode = tn;
            trv.EndUpdate();

            Fnc.Parent_Id = (tnParent == tnRoot) ? -1 : ((FncRatioInfo)tnParent.Tag).Parent_Id;
            Fnc.GroupName = string.Empty;

            if (EditCaption(tn) == false)
            {
                tn.Remove();
                return;
            }
            VirtualTree.Add(tn.Text);

            if (!CheckExist(tn.Text))
            {
                RemoveNode(trv.SelectedNode);
                return;
            }

            bDirty = true;
        }
        private bool CheckExist(string newNodName)
        {
            for (int i = 0; i < VirtualTree.Count - 1; i++)
            {
                if ((VirtualTree[i].ToLower().Trim() == newNodName.ToLower().Trim()))
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("عنصر وارد شده تكراري است!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void CommandEdit()
        {
            if (trv.SelectedNode != null && trv.SelectedNode != tnRoot && trv.SelectedNode.Tag is FncRatioInfo)
            {
                FncRatioInfo FncPrev = (FncRatioInfo)trv.SelectedNode.Tag;
                // object agiPrev = trv.SelectedNode.Tag ;
                string strPreNodeName = trv.SelectedNode.Text;
                if (EditCaption(trv.SelectedNode))
                {
                    VirtualTree.Remove(strPreNodeName);
                    VirtualTree.Add(trv.SelectedNode.Text);
                    if (!CheckExist(trv.SelectedNode.Text))
                    {
                        trv.SelectedNode.Text = strPreNodeName;
                        trv.SelectedNode.Tag = FncPrev;
                        return;
                    }
                    bDirty = true;
                }
            }
        }
        private void CommandRemove()
        {
            if (trv.SelectedNode != null && trv.SelectedNode != tnRoot)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("عنصر انتخاب شده حذف خواهد شد. آيا مطمئن هستيد؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    //  bResumeCheckDep = true;
                    // CheckChildren(trv.SelectedNode, false);
                    //CheckChildren(trv.SelectedNode, true);
                    //if (bResumeCheckDep == false)
                    //    return;
                    foreach (TreeNode tnChild in trv.SelectedNode.Nodes)
                        RemoveChildren(tnChild);
                    RemoveNode(trv.SelectedNode);
                }
            }
        }
        private void RemoveChildren(TreeNode tn)
        {
            while (tn.Nodes.Count > 0)
            {
                TreeNode tnChild = tn.Nodes[0];

                if (tnChild.Nodes.Count == 0)
                    RemoveNode(tnChild);
                else
                    RemoveChildren(tnChild);
            }
            RemoveNode(tn);
        }
        private void RemoveNode(TreeNode tn)
        {
            if (tn.Tag is FncRatioInfo)
            {
                FncRatioInfo Fnc = (FncRatioInfo)tn.Tag;

                //lsRemovedTitleIDs.Add(agi.TitleID);
                //if (!agi.IsTitle)
                //lsRemovedGroupIDs.Add(Fnc.Parent_Id);
                lsRemovedGroupIDs.Add(Fnc.ID);
            }
            else
                if (tn.Tag is FncRatioElementInfo)
                {

                    FncRatioElementInfo FncElement = (FncRatioElementInfo)tn.Tag;
                    lsRemovedElementIDs.Add(FncElement.ID);

                    int rowIndex = ((DataTable)dgvAccountGL.DataSource).DefaultView.Find(FncElement.AccountCode);
                    if (rowIndex != -1)
                    {
                        dgvAccountGL.Rows[rowIndex].Selected = true;
                        dgvAccountGL.Rows[rowIndex].Cells[CTE_Checked_ColIndex].Value = false;
                        dgvAccountGL.FirstDisplayedScrollingRowIndex = rowIndex;
                    }

                }
            tn.Remove();
        }
        private void CommandMoveLeft()
        {
            if (this.trv.Focused)
            {
                TreeNode selNode = trv.SelectedNode;
                if (selNode.Tag is FncRatioElementInfo)
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("يك حساب نمی تواند ذيل يك حساب ديگر قرار بگيرد ", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (trv.SelectedNode != null)
                    if (trv.SelectedNode.Parent != tnRoot)
                    {
                        TreeNode selNodeParent = selNode.Parent,
                                 selNodeGrandParent = selNodeParent.Parent;

                        //if (selNodeGrandParent.Tag is FncRatioInfo && ((FncRatioInfo)selNodeGrandParent.Tag).IsGroup)
                        //{
                        //    Presentation.Public.Routines.ShowMessageBoxFa("گروه حساب نمی تواند ذيل يك گروه حساب ديگر قرار بگيرد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    return;
                        //}

                        trv.BeginUpdate();
                        selNode.Remove();
                        if (selNodeGrandParent != tnRoot)
                            selNodeGrandParent.Nodes.Insert(selNodeParent.Index + 1, selNode);
                        else
                            tnRoot.Nodes.Insert(selNodeParent.Index + 1, selNode);

                        trv.SelectedNode = selNode;
                        selNode.EnsureVisible();
                        trv.EndUpdate();

                        bDirty = true;
                    }
            }
        }
        private void CommandMoveRight()
        {
            if (this.trv.Focused)
            {
                TreeNode selNode = trv.SelectedNode;
                if (selNode.Tag is FncRatioElementInfo)
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("يك حساب نمی تواند ذيل يك حساب ديگر قرار بگيرد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (trv.SelectedNode != null)
                    if (trv.SelectedNode.PrevNode != null)
                    {
                        TreeNode selNodePrevNode = selNode.PrevNode;

                        if (((FncRatioInfo)selNode.Tag).IsGroup && ((FncRatioInfo)selNodePrevNode.Tag).IsGroup)
                        {
                            Presentation.Public.Routines.ShowMessageBoxFa("گروه حساب نمی تواند ذيل يك گروه حساب ديگر قرار بگيرد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        trv.BeginUpdate();
                        selNode.Remove();
                        selNodePrevNode.Nodes.Add(selNode);
                        trv.SelectedNode = selNode;
                        selNode.EnsureVisible();
                        trv.EndUpdate();
                        bDirty = true;
                    }
            }
        }
        private void CommandMoveUp()
        {
            if (this.trv.Focused)
            {
                trv.BeginUpdate();
                if (trv.SelectedNode != null)
                    if (trv.SelectedNode.PrevNode != null)
                    {
                        TreeNode selNode = trv.SelectedNode,
                        selNodeParent = selNode.Parent;
                        int prevNodeIndex = selNode.PrevNode.Index;

                        selNode.Remove();
                        if (selNodeParent != tnRoot)
                            selNodeParent.Nodes.Insert(prevNodeIndex, selNode);
                        else
                            tnRoot.Nodes.Insert(prevNodeIndex, selNode);

                        trv.SelectedNode = selNode;
                        selNode.EnsureVisible();
                        bDirty = true;
                    }
                trv.EndUpdate();
            }
        }
        private void CommandMoveDown()
        {
            if (this.trv.Focused)
            {
                trv.BeginUpdate();
                if (trv.SelectedNode != null)
                    if (trv.SelectedNode.NextNode != null)
                    {
                        TreeNode selNode = trv.SelectedNode,
                                 selNodeParent = selNode.Parent;
                        int nextNodeIndex = selNode.NextNode.Index;

                        selNode.Remove();
                        if (selNodeParent != tnRoot)
                            selNodeParent.Nodes.Insert(nextNodeIndex, selNode);
                        else
                            tnRoot.Nodes.Insert(nextNodeIndex, selNode);

                        trv.SelectedNode = selNode;
                        selNode.EnsureVisible();
                        bDirty = true;
                    }
                trv.EndUpdate();
            }
        }
        private void SaveDiagram(bool bMessage)
        {
            foreach (int id in lsRemovedElementIDs)
                FncBL.DeleteFncRatioElement(id);
            //foreach (int id in lsRemovedTitleIDs)
            //    FncBL.DeleteFncRatio(id);
            foreach (int id in lsRemovedGroupIDs)
                FncBL.DeleteFncRatioModel(id);
            foreach (TreeNode tn in tnRoot.Nodes)
                SaveNodeElementInfo(tn);

            if (bMessage)
                Presentation.Public.Routines.ShowMessageBoxFa("تمامی تغييرات ذخيره شد", "ذخيره", MessageBoxButtons.OK, MessageBoxIcon.Information);


            lsRemovedGroupIDs.Clear();
            //lsRemovedAGIDs.Clear();

            VirtualTree.Clear();

            bDirty = false;
        }
        private void SaveNodeElementInfo(TreeNode tn)
        {
            if (tn.Tag is FncRatioInfo)
            {
                FncRatioInfo Fnc = (FncRatioInfo)tn.Tag;

                Fnc.Sequence = tn.Index + 1;
                Fnc.Balance = tn.Level + 1;
                Fnc.Parent_Id = (tn.Parent == tnRoot) ? -1 : ((FncRatioInfo)tn.Parent.Tag).ID;
                Fnc.ULevel = GetULevel(Fnc, tn);

                if (Fnc.ID == -1)
                {
                    Fnc.ID = FncBL.InsertFncRatioModel(Fnc);
                }
                else
                {
                    FncBL.UpdateFncRatioModel(Fnc);
                }

                foreach (TreeNode tnChild in tn.Nodes)
                    SaveNodeElementInfo(tnChild);
            }
            else
                if (tn.Tag is FncRatioElementInfo)
                {
                    FncRatioElementInfo FncRatio = (FncRatioElementInfo)tn.Tag;
                    FncRatio.GroupID = ((FncRatioInfo)tn.Parent.Tag).ID;

                    switch (FncRatio.ObjectState)
                    {
                        case EObjectState.New:
                            FncRatio.ID = FncBL.InsertFncRatioElement(FncRatio);
                            FncRatio.ObjectState = EObjectState.Clean;
                            break;
                        case EObjectState.Dirty:
                            FncBL.InsertFncRatioElement(FncRatio);
                            FncRatio.ObjectState = EObjectState.Clean;
                            break;
                    }
                }

        }
        private string GetULevel(FncRatioInfo Fnc, TreeNode tn)
        {
            if (tn.Parent == tnRoot)
            {
                return ((Fnc.Balance * 1000) + Fnc.Sequence).ToString();
            }
            FncRatioInfo agiParent = ((FncRatioInfo)tn.Parent.Tag);
            return agiParent.ULevel + ((Fnc.Balance * 1000) + Fnc.Sequence);
        }
        public void DoHelp()
        {
            ERMSLib.clsERMSGeneral.strHelp = "FncRatio";
        }
        public void DoPrint()
        {

        }
        private void FillDiagram()
        {
            ShowProgress("...بارگذارِی :نسبتهاي مالي");
            trv.BeginUpdate();
            tnRoot = trv.Nodes.Add("مدلسازی نسبتهاي مالي");
            DataTable dt = FncBL.GetDTFncRatios();
            htNodes.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                FncRatioInfo Fnc = new FncRatioInfo();
                FncBL.CloneX(dr, Fnc, ECloneXdir.DR2Info);

                TreeNode tn = new TreeNode
                                  {
                                      Tag = Fnc,
                                      Text = Fnc.GroupName,
                                      ToolTipText = Fnc.GroupName,
                                      BackColor = Color.FromArgb(Fnc.Color)
                                  };


                try
                {
                    tnRoot.Nodes.Add(tn);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                // fill the element 
                DataTable dtElement = FncBL.GetDTFncRatiosElement(Fnc.ID);
                foreach (DataRow drElement in dtElement.Rows)
                {
                    FncRatioElementInfo FncElement = new FncRatioElementInfo {ObjectState = EObjectState.Clean};
                    FncBL.CloneXElement(drElement, FncElement, ECloneXdir.DR2Info);

                    TreeNode tnElement = new TreeNode
                                             {
                                                 Text =
                                                     tsbNameCode.Checked
                                                         ? FncElement.AccountName
                                                         : FncElement.AccountCode
                                             };
                    tnElement.Text = (FncElement.Coef == -1 ? "(-) " : "") + tnElement.Text;
                    tnElement.ToolTipText = tnElement.Text;
                    tnElement.Tag = FncElement;
                    tnElement.BackColor = Color.LightBlue;
                    tn.Nodes.Add(tnElement);
                }
                VirtualTree.Add(Fnc.GroupName);
            }
            trv.EndUpdate();
        }
        private void FillAccounts()
        {
            ShowProgress("بارگذارِی :گروه حساب");

            var h = new Helper();
            h.FormatDataGridView(dgvAccountGL);

            dgvAccountGL.ColumnHeadersVisible = dgvNonAccount.ColumnHeadersVisible = dgvAGL199.ColumnHeadersVisible = true;
            dgvAccountGL.AllowUserToResizeColumns = dgvNonAccount.AllowUserToResizeColumns = dgvAGL199.AllowUserToResizeColumns = true;
            dgvAccountGL.AutoSizeColumnsMode = dgvNonAccount.AutoSizeColumnsMode = dgvAGL199.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvAccountGL.MultiSelect = dgvNonAccount.MultiSelect = dgvAGL199.MultiSelect = false;
            dgvAccountGL.SelectionMode = dgvNonAccount.SelectionMode = dgvAGL199.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ShowProgress("بارگذارِی :حسابهای دفتر كل");
            var dt = FncBL.GetAccountCodesDT(EAccountCategory.AccountGL);
            dt.PrimaryKey = new[] { dt.Columns[CTE_AccountCode_ColIndex] };
            dt.DefaultView.Sort = "Code";
            dt.Columns.Add(new DataColumn("LevelStr", typeof(String)));
            foreach (DataColumn column in dt.Columns)
                column.ReadOnly = false;
            foreach (DataRow dr in dt.Rows)
            {
                switch (dr["Level"].ToString())
                {
                    case "0":
                        dr["LevelStr"] = "کل";
                        break;
                    case "1":
                        dr["LevelStr"] = "معین 1";
                        break;
                    case "2":
                        dr["LevelStr"] = "معین 2";
                        break;
                }
            }
            dgvAccountGL.DataSource = dt;
            // in data table baraye filtering dar Grid estefade mishavad
            dtDgvAccountGL = new DataTable();
            dtDgvAccountGL = dt;
            dtDgvAccountGL.Columns[0].ColumnName = "Grouped";
            //
            dgvAccountGL.Columns[CTE_AccountCode_ColIndex].HeaderText = "كد";
            dgvAccountGL.Columns[CTE_AccountName_ColIndex].HeaderText = "نام";
            dgvAccountGL.Columns["TYPE"].HeaderText = "گونه";
            dgvAccountGL.Columns["TYPE"].Visible = false;
            dgvAccountGL.Columns["Level"].Visible = false;
            dgvAccountGL.Columns["LevelStr"].HeaderText = "سطح";
            dgvAccountGL.Columns[0].HeaderText = "گروه بندی شده/نشده";
            dgvAccountGL.Columns[CTE_AccountCode_ColIndex].MinimumWidth = (dgvAccountGL.Width) / 6;
            dgvAccountGL.Columns[CTE_AccountName_ColIndex].MinimumWidth = (dgvAccountGL.Width) / 2;
            dgvAccountGL.Columns["TYPE"].MinimumWidth = (dgvAccountGL.Width) / 7;
            dgvAccountGL.Columns[0].Width = 50;


        }
        #endregion

        #region ContexMenu

        private void miAdd_Click(object sender, EventArgs e)
        {
            CommandAdd();
        }
        private void miEdit_Click(object sender, EventArgs e)
        {
            CommandEdit();
        }
        private void miRemove_Click(object sender, EventArgs e)
        {
            CommandRemove();
        }
        private void miCollapseAll_Click(object sender, EventArgs e)
        {
            trv.CollapseAll();
        }
        private void miExpandAll_Click(object sender, EventArgs e)
        {
            trv.ExpandAll();
        }

        #endregion

        #region  Tab

        private void tsbLoad_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void tsbNew_Click(object sender, EventArgs e)
        {
            CommandAdd();
        }
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            CommandEdit();
        }
        private void tsbRemove_Click(object sender, EventArgs e)
        {
            CommandRemove();
        }
        private void tsbMoveUp_Click(object sender, EventArgs e)
        {
            CommandMoveUp();
        }
        private void tsbMoveDown_Click(object sender, EventArgs e)
        {
            CommandMoveDown();
        }
        private void tsbMoveLeft_Click(object sender, EventArgs e)
        {
            CommandMoveLeft();
        }
        private void tsbMoveRight_Click(object sender, EventArgs e)
        {
            CommandMoveRight();
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveDiagram(true);
        }

        #endregion

        #region Component Event

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Filter(txtSearch.Text);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filter(txtSearch.Text);
        }
        private void dgvAccountGL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((bool)dgvAccountGL.Rows[e.RowIndex].Cells[0].Value)
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("این حساب پیش از این گروه بندی شده است " + "\n" +
                        "امکان افزودن به گروه جدید وجود ندارد", "پيام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                var accountCode = dgvAccountGL.Rows[e.RowIndex].Cells[CTE_AccountCode_ColIndex].Value.ToString();
                var accountName = dgvAccountGL.Rows[e.RowIndex].Cells[CTE_AccountName_ColIndex].Value.ToString();

                if (AddAccount(accountCode, accountName, EAccountCategory.AccountGL))
                {
                    dgvAccountGL.Rows[e.RowIndex].Cells[CTE_Checked_ColIndex].Value = true;
                }
            }
            catch (Exception exception)
            {
               Utilize.Helper.ExceptionHelper.ConfigLog(exception,false);
            }
        }


        #endregion

        private void trv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is FncRatioElementInfo)
            {
                FncRatioElementInfo agi = (FncRatioElementInfo)e.Node.Tag;


                int i = 0;
                            foreach (DataGridViewRow row in dgvAccountGL.Rows)
                            {
                                i = i + 1;
                                if (row.Cells[CTE_AccountName_ColIndex].Value.ToString() == agi.AccountName)
                                {
                                    row.Selected = true;
                                    dgvAccountGL.FirstDisplayedScrollingRowIndex = i - 1;
                                    dgvSelected(dgvNonAccount);
                                    dgvSelected(dgvAGL199);
                                    break;
                                }
                            }
               
            }
        }
        private void dgvSelected(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count != 0)
                dgv.SelectedRows[0].Selected = false;
        }

        private void btnModel_Load(object sender, EventArgs e)
        {
            
        }

        private void btnModel_CButtonClicked(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed == false)
            {
                splitContainer1.Panel1Collapsed = true;
                btnModel.DefaultImage = Properties.Resources.S_PanRight1;
                btnModel.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
            else if (splitContainer1.Panel1Collapsed == true)
            {
                splitContainer1.Panel1Collapsed = false;
                btnModel.DefaultImage = Properties.Resources.S_Panleft1;
                btnModel.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
        }

        private void rdbShowAllAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbShowAllAcc.Checked)
            {
                dgvAccountGL.DataSource = dtDgvAccountGL;
            }
            else if (rdbShowGroupedAcc.Checked)
            {
                DataRow[] dRows = dtDgvAccountGL.Select("Grouped = True");
                DataTable dt = dtDgvAccountGL.Clone();
                foreach (DataRow dRow in dRows)
                {
                    dt.ImportRow(dRow);
                }
                dgvAccountGL.DataSource = dt;
                //var ssss=((DataTable)dgvAccountGL.DataSource).Rows.Cast<DataRow>().Where(row => Convert.ToBoolean(row[0]) == true);
                //dgvAccountGL.DataSource = ssss.Select(item=>item.ItemArray);
            }
            else if (rdbShowUnGroupedAcc.Checked)
            {
                DataRow[] dRows = dtDgvAccountGL.Select("Grouped = False");
                DataTable dt = dtDgvAccountGL.Clone();
                foreach (DataRow dRow in dRows)
                {
                    dt.ImportRow(dRow);
                }
                dgvAccountGL.DataSource = dt;
            }
        }

    }
}