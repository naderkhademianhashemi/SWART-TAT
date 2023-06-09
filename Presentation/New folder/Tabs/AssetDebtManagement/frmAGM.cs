using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using ERMS.Logic;
using ERMS.Model;

//      
using ERMSLib;
using Presentation.Public;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmAGM : BaseForm, IPrintable
    {
        #region VAR

        private const int CTE_Checked_ColIndex = 0;
        private const int CTE_AccountCode_ColIndex = 1;
        private const int CTE_AccountName_ColIndex = 2;


        private const int CTE_CheckedCur_ColIndex = 0;
        private const int CTE_AccountCurCode_ColIndex = 1;
        private const int CTE_AccountCurName_ColIndex = 2;
        private const int CTE_AccountCurrency_ColIndex = 3;

        private AGM agm;
        private bool bDirty;

        private bool bResumeCheckDep;
        private Hashtable htNodes;

        private frmGroup fxGroup;
        private TreeNode tnRoot;

        private List<int> lsRemovedTitleIDs, lsRemovedGroupIDs, lsRemovedAGIDs;
        private List<string> VirtualTree;

        private DataTable dtDgvAccountGL;
        private DataTable dtDgvAccountGL_Currency;

        string strError = "";
        #endregion VAR

        public frmAGM()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
        }

        private void frmAGM_Load(object sender, EventArgs e)
        {
            agm = new AGM();

            bDirty = false;
            tsbSave.Enabled = false;
            lblProgress.Visible = false;

            trv.ItemHeight = 32;
            trv.Indent = 40;
            trv.TreeInfoEx.Width4MinBox = 400;

            lsRemovedTitleIDs = new List<int>();
            lsRemovedGroupIDs = new List<int>();
            lsRemovedAGIDs = new List<int>();
            VirtualTree = new List<string>();

            dgvAccountGL.Tag = EAccountCategory.AccountGL;
            dgvAGL199.Tag = EAccountCategory.AGL199;
            dgvNonAccount.Tag = EAccountCategory.NonAccount;
            dgvAccount_Currency.Tag = EAccountCategory.AccountGL_Currency;

            htNodes = new Hashtable();
            fxGroup = new frmGroup();
          
        GeneralDataGridView = dgvAccountGL;
            Reload();
        }
        private void frmAGM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید تغییرات خود را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SaveDiagram(false);
            }
        }
        private void frmAGM_KeyDown(object sender, KeyEventArgs e)
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

        #region Tab
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
            Filter(SafeFarsiStr(txtSearch.Text));
        }
        private void ctxMenu_Opening(object sender, CancelEventArgs e)
        {
            if ((trv.SelectedNode == null) || trv.SelectedNode.Tag is AGInfo)
            {
            }
            else
            {
            }
        }
        private void trv_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
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
                string accountCode;
                string accountName;
                if (e.RowIndex != -1  )
                {
                    accountCode = dgvAccountGL.Rows[e.RowIndex].Cells[CTE_AccountCode_ColIndex].Value.ToString();
                    accountName = dgvAccountGL.Rows[e.RowIndex].Cells[CTE_AccountName_ColIndex].Value.ToString();

                    if (AddAccount(accountCode, accountName, EAccountCategory.AccountGL))
                    {
                        dgvAccountGL.Rows[e.RowIndex].Cells[CTE_Checked_ColIndex].Value = true;
                    }
                }
            }

            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("عنوان این جدول قابل انتخاب نیست.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvNonAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string accountCode = dgvNonAccount.Rows[e.RowIndex].Cells[CTE_AccountCode_ColIndex].Value.ToString();
            string accountName = dgvNonAccount.Rows[e.RowIndex].Cells[CTE_AccountName_ColIndex].Value.ToString();

            if (AddAccount(accountCode, accountName, EAccountCategory.NonAccount))
            {
                dgvNonAccount.Rows[e.RowIndex].Cells[CTE_Checked_ColIndex].Value = true;
            }
        }
        private void dgvAGL199_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string accountCode = dgvAGL199.Rows[e.RowIndex].Cells[CTE_AccountCode_ColIndex].Value.ToString();
            string accountName = dgvAGL199.Rows[e.RowIndex].Cells[CTE_AccountName_ColIndex].Value.ToString();

            if (AddAccount(accountCode, accountName, EAccountCategory.AGL199))
            {
                dgvAGL199.Rows[e.RowIndex].Cells[CTE_Checked_ColIndex].Value = true;
            }
        }


        #endregion

        #region General Function
        private void Filter(string criteria)
        {
            string filter = (criteria != string.Empty) ? string.Format("Name LIKE '%{0}%' OR Code LIKE '%{0}%'", criteria) : string.Empty;
            if ( tabTotal.Selected==true)
            {
                ((DataTable)dgvAccountGL.DataSource).DefaultView.RowFilter = filter;
                ((DataTable)dgvNonAccount.DataSource).DefaultView.RowFilter = filter;
                ((DataTable)dgvAGL199.DataSource).DefaultView.RowFilter = filter;
            }
            else if (tabDetail.Selected==true)
            ((DataTable)dgvAccount_Currency.DataSource).DefaultView.RowFilter = filter;
        }
        private bool AddAccount(string accountCode, String accountName, EAccountCategory eAccountCategory)
        {
            AccountGroupInfo agi;

            TreeNode selNode = trv.SelectedNode;
            if (selNode != null && (selNode != tnRoot || ModifierKeys == Keys.Alt))
            {

                if (ModifierKeys == Keys.Alt)
                {
                    if ((selNode.Tag is AccountGroupInfo && ((AccountGroupInfo)selNode.Tag).IsTitle) || (selNode == tnRoot))
                    {
                        agi = new AccountGroupInfo();
                        if (eAccountCategory == EAccountCategory.AccountGL) agi.GL = (int)EGL.GL;
                        if (eAccountCategory == EAccountCategory.NonAccount) agi.GL = (int)EGL.NA;
                        if (eAccountCategory == EAccountCategory.AGL199) agi.GL = (int)EGL.GL199;
                        if (eAccountCategory == EAccountCategory.AccountGL_Currency) agi.GL = (int)EGL.Currency;
                        agi.GroupName = accountName;
                        agi.Color = Color.Orange.ToArgb();

                        TreeNode tnGroup = new TreeNode();
                        tnGroup.Text = accountName.ToString();
                        tnGroup.ToolTipText = tnGroup.Text;
                        tnGroup.Tag = agi;
                        tnGroup.BackColor = Color.FromArgb(agi.Color);
                        selNode.Nodes.Add(tnGroup);
                        tnGroup.EnsureVisible();

                        return true;
                    }
                }

                if (selNode != tnRoot)
                {
                    TreeNode tnParent = (selNode.Tag is AccountGroupInfo) ? selNode : selNode.Parent;
                    agi = (AccountGroupInfo)tnParent.Tag;

                    if (agi.IsTitle)
                    {
                        Presentation.Public.Routines.ShowMessageBoxFa("حسابها  نمي توانند  زير مجموعه  يك گروه حساب باشد، لطفا يك گروه حساب انتخاب كنيد ", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (eAccountCategory != agi.AccountCategory)
                    {
                        Presentation.Public.Routines.ShowMessageBoxFa("نوع حساب نمی تواند با گروه حساب متفاوت باشد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    AGInfo gi = new AGInfo();
                    gi.AccountCode = accountCode;
                    gi.AccountName = accountName;
                    gi.GroupName = agi.GroupName;
                    gi.ObjectState = EObjectState.New;

                    TreeNode tnNew = new TreeNode();
                    tnNew.Text = tsbNameCode.Checked ? gi.AccountName.ToString() : gi.AccountCode.ToString();
                    tnNew.Text = (ModifierKeys == Keys.Shift ? "(-) " : "") + tnNew.Text;
                    if (ModifierKeys == Keys.Shift)
                        gi.Coef = -1;
                    else
                        gi.Coef = +1;

                    tnNew.ToolTipText = tnNew.Text;
                    tnNew.Tag = gi;
                    tnNew.BackColor = Color.Yellow;
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

            AccountGroupInfo agiPrev = (AccountGroupInfo)tn.Tag;
            AccountGroupInfo agi = agiPrev.Clone();
            fxGroup.Location = loc;
            fxGroup.Info = agi;
            if (fxGroup.ShowDialog() == DialogResult.OK)
            {
                agi = fxGroup.Info;

                TreeNode tnParent = tn.Parent;
                if (tnParent != tnRoot)
                {
                    AccountGroupInfo agiParent = (AccountGroupInfo)tnParent.Tag;
                    if (!agiParent.IsTitle && !agi.IsTitle)
                    {
                        Presentation.Public.Routines.ShowMessageBoxFa("گروههاي حساب تنها در پايين ترين سطح مي تواند قرار بگيرد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                if (tn.Nodes.Count > 0 && !agiPrev.IsTitle && (agiPrev.GL != agi.GL || agi.IsTitle))
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("زماني كه گروه حساب داراي زيرمجموعه باشد، عمليات فوق امكان پذير نمی باشد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                tn.Text = tn.ToolTipText = agi.Caption;
                tn.BackColor = Color.FromArgb(agi.Color);
                tn.Tag = agi;

                return true;
            }

            return false;
        }
        private void CommandAdd()
        {

            if (trv.SelectedNode == null)
                return;

            if (trv.SelectedNode.Tag is AGInfo)
            {
                Routines.ShowMessageBoxFa("زماني كه عنصر انتخاب شده يك حساب باشد، عمليات فوق امكان پذير نمی باشد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (trv.SelectedNode.Tag is AccountGroupInfo)
                if (!((AccountGroupInfo)trv.SelectedNode.Tag).IsTitle)
                {
                    Routines.ShowMessageBoxFa("تنها حسابها می توانند زيرمجموعه گروههای حساب قرار بگيرند", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            trv.BeginUpdate();
            TreeNode tn = new TreeNode();
            AccountGroupInfo agi = new AccountGroupInfo();
            agi.Color = Color.LightBlue.ToArgb();
            tn.Tag = agi;
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

            //
            agi.TitleID = -1;
            agi.ParentId = (tnParent == tnRoot) ? -1 : ((AccountGroupInfo)tnParent.Tag).TitleID;
            agi.GroupTitle = string.Empty;
            agi.GroupName = string.Empty;

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
            if (trv.SelectedNode != null && trv.SelectedNode != tnRoot && trv.SelectedNode.Tag is AccountGroupInfo)
            {
                AccountGroupInfo agiPrev = (AccountGroupInfo)trv.SelectedNode.Tag;
                // object agiPrev = trv.SelectedNode.Tag ;
                string strPreNodeName = trv.SelectedNode.Text;
                if (EditCaption(trv.SelectedNode))
                {
                    VirtualTree.Remove(strPreNodeName);
                    VirtualTree.Add(trv.SelectedNode.Text);
                    if (!CheckExist(trv.SelectedNode.Text))
                    {
                        trv.SelectedNode.Text = strPreNodeName;
                        trv.SelectedNode.Tag = agiPrev;
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
                    bResumeCheckDep = true;
                    CheckChildren(trv.SelectedNode, false);
                    CheckChildren(trv.SelectedNode, true);
                    if (bResumeCheckDep == false)
                        return;

                    foreach (TreeNode tnChild in trv.SelectedNode.Nodes)
                        RemoveChildren(tnChild);

                    RemoveNode(trv.SelectedNode);
                }
            }
        }
        private void CheckChildren(TreeNode tn, bool bChildren)
        {
            if (!bResumeCheckDep)
                return;

            if (!bChildren)
                if (tn.Tag is AccountGroupInfo)
                {
                    AccountGroupInfo agi = (AccountGroupInfo)tn.Tag;
                    if (!agi.IsTitle)
                        if (Presentation.Miscs.CheckDependents.Show(CheckDep.CHECK_AccountGroup, agi.GroupName) == DialogResult.Cancel)
                        {
                            bResumeCheckDep = false;
                            return;
                        }
                }

            if (bChildren)
                foreach (TreeNode tnChild in tn.Nodes)
                {
                    if (tnChild.Tag is AccountGroupInfo)
                    {
                        AccountGroupInfo agi = (AccountGroupInfo)tnChild.Tag;
                        if (!agi.IsTitle)
                            if (Presentation.Miscs.CheckDependents.Show(CheckDep.CHECK_AccountGroup, agi.GroupName) == DialogResult.Cancel)
                            {
                                bResumeCheckDep = false;
                                return;
                            }
                    }
                    CheckChildren(tnChild, true);
                }
        }
        private void RemoveChildren(TreeNode tn)
        {
            while (tn != null && (tn.Nodes.Count > 0))
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
            if (tn == null)
                return;
            if (tn.Tag is AccountGroupInfo)
            {
                AccountGroupInfo agi = (AccountGroupInfo)tn.Tag;

                lsRemovedTitleIDs.Add(agi.TitleID);
                if (!agi.IsTitle)
                    lsRemovedGroupIDs.Add(agi.GroupID);
            }
            else
                if (tn.Tag is AGInfo)
                {
                    AGInfo ai = (AGInfo)tn.Tag;
                    lsRemovedAGIDs.Add(ai.ID);

                    //AccountGroupInfo agiParent = (AccountGroupInfo)tn.Parent.Tag;
                    //int rowIndex = -1;
                    //if (!agiParent.IsTitle) //Always True
                    //{
                    //switch (agiParent.GL)
                    //{
                    //case (int)EGL.GL:
                    int rowIndex = -1;

                    rowIndex = ((DataTable)dgvAccountGL.DataSource).DefaultView.Find(ai.AccountCode.ToString());
                    if (rowIndex != -1)
                    {
                        dgvAccountGL.Rows[rowIndex].Selected = true;
                        dgvAccountGL.Rows[rowIndex].Cells[CTE_Checked_ColIndex].Value = false;
                        dgvAccountGL.FirstDisplayedScrollingRowIndex = rowIndex;
                    }
                    //break;

                    //case (int)EGL.NA:
                    rowIndex = ((DataTable)dgvNonAccount.DataSource).DefaultView.Find(ai.AccountCode.ToString());
                    if (rowIndex != -1)
                    {
                        dgvNonAccount.Rows[rowIndex].Selected = true;
                        dgvNonAccount.Rows[rowIndex].Cells[CTE_Checked_ColIndex].Value = false;
                        dgvNonAccount.FirstDisplayedScrollingRowIndex = rowIndex;
                    }
                    //break;

                    //case (int)EGL.GL199:
                    rowIndex = ((DataTable)dgvAGL199.DataSource).DefaultView.Find(ai.AccountCode.ToString());
                    if (rowIndex != -1)
                    {
                        dgvAGL199.Rows[rowIndex].Selected = true;
                        dgvAGL199.Rows[rowIndex].Cells[CTE_Checked_ColIndex].Value = false;
                        dgvAGL199.FirstDisplayedScrollingRowIndex = rowIndex;
                    }
                    //break;
                    //}
                    //}
                }

            tn.Remove();
        }
        private void CommandMoveLeft()
        {
            if (this.trv.Focused)
            {
                TreeNode selNode = trv.SelectedNode;
                if (selNode.Tag is AGInfo)
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("يك حساب نمی تواند ذيل يك حساب ديگر قرار بگيرد ", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (trv.SelectedNode != null)
                    if (trv.SelectedNode.Parent != tnRoot)
                    {
                        TreeNode selNodeParent = selNode.Parent,
                                 selNodeGrandParent = selNodeParent.Parent;

                        if (selNodeGrandParent.Tag is AccountGroupInfo && ((AccountGroupInfo)selNodeGrandParent.Tag).IsGroup)
                        {
                            Presentation.Public.Routines.ShowMessageBoxFa("گروه حساب نمی تواند ذيل يك گروه حساب ديگر قرار بگيرد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

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
                if (selNode == null) return;
                if (selNode.Tag is AGInfo)
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("يك حساب نمی تواند ذيل يك حساب ديگر قرار بگيرد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (trv.SelectedNode != null)
                    if (trv.SelectedNode.PrevNode != null)
                    {
                        TreeNode selNodePrevNode = selNode.PrevNode;

                        if (((AccountGroupInfo)selNode.Tag).IsGroup && ((AccountGroupInfo)selNodePrevNode.Tag).IsGroup)
                        {
                            Presentation.Public.Routines.ShowMessageBoxFa("گروه حساب نمی تواند ذيل يك گروه حساب ديگر قرار بگيرد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (((AccountGroupInfo)selNode.Tag).IsTitle && ((AccountGroupInfo)selNodePrevNode.Tag).IsGroup)
                        {
                            Presentation.Public.Routines.ShowMessageBoxFa("عنوان حساب نمی تواند ذيل يك گروه حساب قرار بگیرد ", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                lsRemovedTitleIDs.Clear();
                lsRemovedGroupIDs.Clear();
                lsRemovedAGIDs.Clear();


                bDirty = false;
                tsbSave.Enabled = true;

                lblProgress.Visible = false; 
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(strError + "\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }
        }
        private void FillDiagram()
        {
            strError += "20";
            ShowProgress("...بارگذارِی :گروه حسابها ");
            trv.BeginUpdate();
            tnRoot = trv.Nodes.Add("مدلسازی گروههای حساب");
            tnRoot.BackColor = Color.Yellow;
           
            DataTable dt = agm.GetAccountTitles();
            htNodes.Clear();
            strError += "21";
            foreach (DataRow dr in dt.Rows)
            {
                strError += "22";
                AccountGroupInfo agi = new AccountGroupInfo();
                agm.CloneX(dr, agi, ECloneXdir.DR2Info);

                TreeNode tn = new TreeNode();
                tn.Tag = agi;
                tn.Text = agi.Caption;
                tn.ToolTipText = agi.Caption;
                tn.BackColor = Color.FromArgb(agi.Color);

                htNodes.Add(agi.TitleID, tn);

                if (htNodes.Contains(agi.ParentId))
                {
                    TreeNode parentNode = (TreeNode)htNodes[agi.ParentId];
                    parentNode.Nodes.Add(tn);
                    
                }
                else
                {
                    tnRoot.Nodes.Add(tn);
                   
                }

                if (!agi.IsTitle)
                {
                    DataTable dtAGs = agm.GetAGs(agi.GroupName);
                    foreach (DataRow drAG in dtAGs.Rows)
                    {
                        AGInfo ai = new AGInfo();
                        ai.ObjectState = EObjectState.Clean;
                        agm.CloneX(drAG, ai, ECloneXdir.DR2Info);

                        TreeNode tnAG = new TreeNode();
                        tnAG.Text = tsbNameCode.Checked ? ai.AccountName.ToString() : ai.AccountCode.ToString();
                        tnAG.Text = (ai.Coef == -1 ? "(-) " : "") + tnAG.Text;
                        tnAG.ToolTipText = tnAG.Text;
                        tnAG.Tag = ai;
                        tnAG.BackColor = Color.Yellow;
                        tn.BackColor = Color.FromArgb(agi.Color);

                        tn.Nodes.Add(tnAG);
                    }
                    VirtualTree.Add(agi.GroupName);
                }
                else
                    VirtualTree.Add(agi.GroupTitle);
            }
            strError += "23";
            trv.EndUpdate();
        }
        private void FillAccounts()
        {
            ShowProgress("بارگذارِی :گروه حساب");

            strError += ", 1";

            Helper h = new Helper();
            h.FormatDataGridView(dgvAccountGL);
            h.FormatDataGridView(dgvNonAccount);
            h.FormatDataGridView(dgvAGL199);
            h.FormatDataGridView(dgvAccount_Currency);

            strError += ", 2";
            dgvAccountGL.ColumnHeadersVisible = dgvNonAccount.ColumnHeadersVisible = dgvAGL199.ColumnHeadersVisible=dgvAccount_Currency.ColumnHeadersVisible = true;
            dgvAccountGL.AllowUserToResizeColumns = dgvNonAccount.AllowUserToResizeColumns = dgvAGL199.AllowUserToResizeColumns=dgvAccount_Currency.AllowUserToResizeColumns = true;
            dgvAccountGL.AutoSizeColumnsMode = dgvNonAccount.AutoSizeColumnsMode = dgvAGL199.AutoSizeColumnsMode =  dgvAccount_Currency.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.None;
            dgvAccountGL.MultiSelect = dgvNonAccount.MultiSelect = dgvAGL199.MultiSelect=dgvAccount_Currency.MultiSelect = false;
            dgvAccountGL.SelectionMode = dgvNonAccount.SelectionMode = dgvAGL199.SelectionMode = dgvAccount_Currency.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ShowProgress("بارگذارِی :حسابهای دفتر كل");
            DataTable dt;
            dt = agm.GetAccountCodesDT(EAccountCategory.AccountGL);
            dt.PrimaryKey = new DataColumn[] { dt.Columns[CTE_AccountCode_ColIndex] };
            dt.DefaultView.Sort = "Code";
            dt.Columns.Add(new DataColumn("LevelStr", typeof(String)));
            foreach (DataColumn column in dt.Columns)
            {
                column.ReadOnly = false;
            }
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
            dgvAccountGL.Columns[0].Width = 100;

            strError += ", 9";

            dt = agm.GetAccountCodesDT(EAccountCategory.AccountGL_Currency);
            strError += ", 10";
            dt.PrimaryKey = new DataColumn[] { dt.Columns[CTE_AccountCode_ColIndex] };
            strError += ", 11";
            dt.DefaultView.Sort = "Code";
            foreach (DataColumn column in dt.Columns)
            {
                column.ReadOnly = false;
            }
            strError += ", 12";
            dtDgvAccountGL_Currency = new DataTable();
            dtDgvAccountGL_Currency = dt;
            dtDgvAccountGL_Currency.Columns[0].ColumnName = "Grouped";
            dgvAccount_Currency.DataSource = dtDgvAccountGL_Currency;
            dgvAccount_Currency.Columns[1].HeaderText = "كد";
            dgvAccount_Currency.Columns[2].HeaderText = "نام";
            dgvAccount_Currency.Columns[3].Visible = false;
            dgvAccount_Currency.Columns[4].HeaderText = "ارز";
            dgvAccount_Currency.Columns[0].HeaderText = "گروه بندی شده/نشده";
            dgvAccount_Currency.Columns[CTE_AccountCurCode_ColIndex].MinimumWidth = (dgvAccount_Currency.Width) / 6;
            dgvAccount_Currency.Columns[CTE_AccountCurName_ColIndex].MinimumWidth = (dgvAccount_Currency.Width) / 2;
            dgvAccount_Currency.Columns[CTE_AccountCurrency_ColIndex].MinimumWidth = (dgvAccount_Currency.Width) / 2;
            strError += ", 13";
            dgvAccount_Currency.Columns[0].Width = 100;

            ShowProgress("بارگذارِی :حسابهای متفرقه");
            dt = agm.GetAccountCodesDT(EAccountCategory.NonAccount);
            dt.PrimaryKey = new DataColumn[] { dt.Columns[CTE_AccountCode_ColIndex] };
            dt.DefaultView.Sort = "Code";
            dgvNonAccount.DataSource = dt;
            dgvNonAccount.Columns[CTE_AccountCode_ColIndex].HeaderText = "كد";
            dgvNonAccount.Columns[CTE_AccountName_ColIndex].HeaderText = "نام";
            dgvNonAccount.Columns[CTE_AccountCode_ColIndex].MinimumWidth = (dgvNonAccount.Width - 55) / 4;
            dgvNonAccount.Columns[CTE_AccountName_ColIndex].MinimumWidth = (dgvNonAccount.Width - 55) * 3 / 4;
            dgvNonAccount.Columns[0].Width = 50;
            strError += ", 14";
            ShowProgress("بارگذارِی :حسابهای دفتر كل شعبه 199");
            dt = agm.GetAccountCodesDT(EAccountCategory.AGL199);
            dt.PrimaryKey = new DataColumn[] { dt.Columns[CTE_AccountCode_ColIndex] };
            dt.DefaultView.Sort = "Code";
            dgvAGL199.DataSource = dt;
            dgvAGL199.Columns[CTE_AccountCode_ColIndex].HeaderText = "كد";
            dgvAGL199.Columns[CTE_AccountName_ColIndex].HeaderText = "نام";
            dgvAGL199.Columns[CTE_AccountCode_ColIndex].MinimumWidth = (dgvAGL199.Width - 55) / 4;
            dgvAGL199.Columns[CTE_AccountName_ColIndex].MinimumWidth = (dgvAGL199.Width - 55) * 3 / 4;
            dgvAGL199.Columns[0].Width = 50;
            strError += ", 15";
            //dgvAccountGL.Columns[CTE_Checked_ColIndex].MinimumWidth = dgvNonAccount.Columns[CTE_Checked_ColIndex].MinimumWidth = dgvAGL199.Columns[CTE_Checked_ColIndex].MinimumWidth = 16;
            //dgvAccountGL.Columns[CTE_AccountCode_ColIndex].MinimumWidth = dgvNonAccount.Columns[CTE_AccountCode_ColIndex].MinimumWidth = dgvAGL199.Columns[CTE_AccountCode_ColIndex].MinimumWidth = 128;
            //dgvAccountGL.Columns[CTE_AccountName_ColIndex].MinimumWidth = dgvNonAccount.Columns[CTE_AccountName_ColIndex].MinimumWidth = dgvAGL199.Columns[CTE_AccountName_ColIndex].MinimumWidth = 1024;
        }

        #endregion

        /// <summary>
        /// اين متد براي آنست كه كاربر نتواند دو نود با نام يكسان وارد كند
        /// اين متد در دو زمان وارد كردن نود جديد و ويرايش نود قديمي صدا زده مي شود.
        /// </summary>
        /// <param name="newNodName"></param>
        /// <returns></returns>
        private void ShowProgress(string msg)
        {
            Application.DoEvents();
            lblProgress.Text = msg;
            Application.DoEvents();
        }
        private void SaveDiagram(bool bMessage)
        {
            foreach (int id in lsRemovedAGIDs)
                agm.DeleteAG(id);
            foreach (int id in lsRemovedTitleIDs)
                agm.DeleteAccountTitle(id);
            foreach (int id in lsRemovedGroupIDs)
                agm.DeleteAccountGroup(id);

            foreach (TreeNode tn in tnRoot.Nodes)
                SaveNodeElementInfo(tn);

            if (bMessage)
                Routines.ShowMessageBoxFa("تمامی تغييرات ذخيره شد", "ذخيره", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lsRemovedTitleIDs.Clear();
            lsRemovedGroupIDs.Clear();
            lsRemovedAGIDs.Clear();
            //VirtualTree.Clear();

            bDirty = false;
        }
        private void SaveNodeElementInfo(TreeNode tn)
        {
            if (tn.Tag is AccountGroupInfo)
            {
                AccountGroupInfo agi = (AccountGroupInfo)tn.Tag;

                agi.Sequence = tn.Index + 1;
                agi.Balance = tn.Level + 1;
                agi.ParentId = (tn.Parent == tnRoot) ? -1 : ((AccountGroupInfo)tn.Parent.Tag).TitleID;
                agi.ULevel = GetULevel(agi, tn);
               
               
                if (agi.TitleID == -1)
                {
                    if (!agi.IsTitle)
                        agi.GroupID = agm.InsertAccountGroup(agi);
                

                    agi.TitleID = agm.InsertAccountTitle(agi);
                   
                }
                else
                {
                    if (!agi.IsTitle)
                        agm.UpdateAccountGroup(agi);
                   

                    agm.UpdateAccountTitle(agi);
                  
                }

                foreach (TreeNode tnChild in tn.Nodes)
                    SaveNodeElementInfo(tnChild);
              
            }
            else
                if (tn.Tag is AGInfo)
                {
                    AGInfo agi = (AGInfo)tn.Tag;
                    agi.GroupName = ((AccountGroupInfo)tn.Parent.Tag).GroupName;
                   

                    switch (agi.ObjectState)
                    {
                        case EObjectState.New:
                            agi.ID = agm.InsertAG(agi);
                            agi.ObjectState = EObjectState.Clean;
                            break;
                        case EObjectState.Dirty:
                            agm.UpdateAG(agi);
                            agi.ObjectState = EObjectState.Clean;
                            break;
                    }
                }
      
        }
        private string GetULevel(AccountGroupInfo agi, TreeNode tn)
        {
            if (tn.Parent == tnRoot)
            {
                return ((agi.Balance * 1000) + agi.Sequence).ToString();
            }
            else
            {
                AccountGroupInfo agiParent = ((AccountGroupInfo)tn.Parent.Tag);
                return agiParent.ULevel + ((agi.Balance * 1000) + agi.Sequence).ToString();
            }
        }

        // add by soltani
        private void trv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is AGInfo)
            {
                AGInfo agi = (AGInfo)e.Node.Tag;

                AccountGroupInfo agiParent = (AccountGroupInfo)e.Node.Parent.Tag;

                if (!agiParent.IsTitle) //Always True
                {
                    switch (agiParent.GL)
                    {
                        case (int)EGL.GL:

                            int i = 0;
                            foreach (DataGridViewRow row in dgvAccountGL.Rows)
                            {
                                i = i + 1;
                                if (row.Cells[CTE_AccountCode_ColIndex].Value.ToString() == agi.AccountCode)
                                {
                                    row.Selected = true;
                                    dgvAccountGL.FirstDisplayedScrollingRowIndex = i - 1;
                                    dgvSelected(dgvNonAccount);
                                    dgvSelected(dgvAGL199);
                                    break;
                                }
                            }
                            break;

                        case (int)EGL.GL199:

                            int j = 0;
                            foreach (DataGridViewRow row in dgvAGL199.Rows)
                            {
                                j = j + 1;
                                if (row.Cells[CTE_AccountName_ColIndex].Value.ToString() == agi.AccountName)
                                {
                                    row.Selected = true;
                                    dgvAGL199.FirstDisplayedScrollingRowIndex = j - 1;
                                    dgvSelected(dgvNonAccount);
                                    dgvSelected(dgvAccountGL);
                                    break;
                                }
                            }

                            break;

                        case (int)EGL.NA:

                            int k = 0;
                            foreach (DataGridViewRow row in dgvNonAccount.Rows)
                            {
                                k = k + 1;
                                if (row.Cells[CTE_AccountName_ColIndex].Value.ToString() == agi.AccountName)
                                {
                                    row.Selected = true;
                                    dgvNonAccount.FirstDisplayedScrollingRowIndex = k - 1;
                                    dgvSelected(dgvAGL199);
                                    dgvSelected(dgvAccountGL);
                                    break;
                                }
                            }
                            break;

                        case (int)EGL.Currency:

                            int z = 0;
                            foreach (DataGridViewRow row in dgvAccount_Currency.Rows)
                            {
                                z = z + 1;
                                if (row.Cells[CTE_AccountCurName_ColIndex].Value.ToString() == agi.AccountName)
                                {
                                    row.Selected = true;
                                    dgvAccount_Currency.FirstDisplayedScrollingRowIndex = z - 1;
                                    dgvSelected(dgvAGL199);
                                    dgvSelected(dgvAccountGL);
                                    break;
                                }
                            }
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
        private void btnModel_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == false)
            {
                splitContainer1.Panel2Collapsed = true;
                btnModel.DefaultImage = Properties.Resources.S_Panleft1;
                btnModel.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (splitContainer1.Panel2Collapsed == true)
            {
                splitContainer1.Panel2Collapsed = false;
                btnModel.DefaultImage = Properties.Resources.S_PanRight1;
                btnModel.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
    

        }
        public void DoPrint()
        {

        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "AGM";
        }

        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbShowAllAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbShowAllAcc.Checked)
            {
                dgvAccountGL.DataSource = dtDgvAccountGL;
                dgvAccount_Currency.DataSource = dtDgvAccountGL_Currency;
            }
            else if (rdbShowGroupedAcc.Checked)
            {
                DataRow[] dRows = dtDgvAccountGL.Select("Grouped = True");
                DataRow[] dRowsC = dtDgvAccountGL_Currency.Select("Grouped = True");
                DataTable dt = dtDgvAccountGL.Clone();
                DataTable dtC = dtDgvAccountGL_Currency.Clone();
                foreach (DataRow dRow in dRows)
                {
                    dt.ImportRow(dRow);
                }

                foreach (DataRow dRowC in dRowsC)
                {
                    dtC.ImportRow(dRowC);
                }
                dgvAccountGL.DataSource = dt;
                dtDgvAccountGL_Currency = dtC;
                //var ssss=((DataTable)dgvAccountGL.DataSource).Rows.Cast<DataRow>().Where(row => Convert.ToBoolean(row[0]) == true);
                //dgvAccountGL.DataSource = ssss.Select(item=>item.ItemArray);
            }
            else if (rdbShowUnGroupedAcc.Checked)
            {
                DataRow[] dRows = dtDgvAccountGL.Select("Grouped = False");
                DataRow[] dRowsC = dtDgvAccountGL_Currency.Select("Grouped = False");
                DataTable dt = dtDgvAccountGL.Clone();
                DataTable dtC = dtDgvAccountGL_Currency.Clone();
                foreach (DataRow dRow in dRows)
                {
                    dt.ImportRow(dRow);
                }
                foreach (DataRow dRowC in dRowsC)
                {
                    dtC.ImportRow(dRowC);
                }
                dgvAccountGL.DataSource = dt;
                dgvAccount_Currency.DataSource = dtC;
            }
          


        }

      

        private void chbHistoric_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chbHistoric.Checked)
            {
               DataTable dif = new DAL.SwartDataSetTableAdapters.GetDT_AccountsGL_BKTableAdapter().GetData();
               DataTable dt = agm.GetAccountCodesDT(EAccountCategory.AccountGL);

               //chbHistoric.Text = "مقایسه تاریخی در تاریخ";
               foreach (DataRow dr in dt.Rows)
                foreach (DataRow drd in dif.Rows)
                    if (dr[1].Equals(drd[0]))
                    {
                        for(int i=0;i< dgvAccountGL.RowCount;i++)
                            if (dgvAccountGL.Rows[i].Cells[1].Value.ToString().Equals(dr[1].ToString()))
                            {
                                dgvAccountGL.BeginEdit(true);
                                dgvAccountGL.Rows[i].DefaultCellStyle.BackColor =Color.Red;
                                dgvAccountGL.EndEdit();
                            }
                    }
               chbHistoric.Text += " ";
            
            }
            else
            {
                //chbHistoric.Text = "مقایسه تاریخی";
                for (int i = 0; i < dgvAccountGL.RowCount; i++)
                    {
                        dgvAccountGL.BeginEdit(true);
                        dgvAccountGL.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        dgvAccountGL.EndEdit();
                    }
            }
        }

        private void cbProcess_CButtonClicked(object sender, EventArgs e)
        {
            var bk = new DAL.SwartDataSetTableAdapters.QueriesTableAdapter().Insert_AccountsGL_BK();
        }

        public string SafeFarsiStr(string input)
        {
            return input.Replace("ی", "ي").Replace("ک", "ك");
        }

        private void dgvAccount_Currency_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((bool)dgvAccount_Currency.Rows[e.RowIndex].Cells[0].Value)
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("این حساب پیش از این گروه بندی شده است " + "\n" +
                        "امکان افزودن به گروه جدید وجود ندارد", "پيام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string accountCode;
                string accountName;
                if (e.RowIndex != -1)
                {
                    accountCode = dgvAccount_Currency.Rows[e.RowIndex].Cells[CTE_AccountCurCode_ColIndex].Value.ToString();
                    accountName = dgvAccount_Currency.Rows[e.RowIndex].Cells[CTE_AccountCurName_ColIndex].Value.ToString();

                    if (AddAccount(accountCode, accountName, EAccountCategory.AccountGL_Currency))
                    {
                        dgvAccount_Currency.Rows[e.RowIndex].Cells[0].Value = true;
                    }
                }
            }

            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("عنوان این جدول قابل انتخاب نیست.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

    }
}

