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
//
using ERMSLib;
using Infragistics.Win;
using Infragistics.Win.UltraWinTree;
using Presentation.Public;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmFSM : BaseForm, IPrintable
    {
        #region VAR/CONTROLS
        public delegate void ChangedDelegate();
        public event ChangedDelegate Changed;

        private FSM fsm;
        private Hashtable htNodes;
        private const int CTE_ItemHeight = 40;
        private const int CTE_Selected_ImageIndex = 8;
        private Label curLableSelected = null;
        private frmCaption fxCaption;
        private List<int> removedIDs;
        private int maxNodeWidth;
        private UltraTreeNode utnRoot;
        private UltraTreeNode draggedNode;
        private UltraTreeNode draggedOverNode;

        private DateTime prevDate = DateTime.Now;
        private int curModelID;
        private bool bDirty;
        private bool bLabelCT;
        #endregion VAR/CONTROLS

        public frmFSM()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
        }
        private void frmFSM_Load(object sender, EventArgs e)
        {
            fsm = new FSM();
            htNodes = new Hashtable();
            fxCaption = new frmCaption();

            maxNodeWidth = 400;
            ut.Indent = 50;
            ut.Override.ItemHeight = 32;
            ut.Override.SelectionType = SelectType.None;
            ut.AllowDrop = true;
            ut.Override.NodeAppearance.BorderColor = Color.Silver;
            ut.Override.NodeAppearance.BorderColor2 = Color.LightGray;
            ut.Override.BorderStyleNode = UIElementBorderStyle.Solid;
            ut.Override.NodeAppearance.BackGradientAlignment = GradientAlignment.Default;
            ut.Override.NodeAppearance.BackGradientStyle = GradientStyle.Horizontal;
            ut.Override.NodeAppearance.BackColor2 = Color.WhiteSmoke;
            ut.Override.NodeSpacingBefore = 8;
            ut.Override.NodeAppearance.TextVAlign = VAlign.Middle;
            ut.Override.MaxLabelWidth = maxNodeWidth;

            bLabelCT = false;
            tsbLabel.Checked = false;
            tsbLabel.Text = "نام گروه";
            bDirty = false;
            curModelID = -1;

            removedIDs = new List<int>();

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;

            FillModel();

        }
        public void SelectedModelID()
        {
            int modelID = -1;
            if (lsvModel.SelectedItems.Count > 0)
                modelID = ((FSMInfo)lsvModel.SelectedItems[0].Tag).ID;

            clsERMSGeneral.dtModel.Rows[0]["FS_Model"] = modelID;
        }
        private void frmFSM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SaveDiagram(curModelID, false);
            }
        }

        private void AddLabel(TreeNode tn)
        {
            if (!tn.IsVisible)
                tn.EnsureVisible();

            if (tn.Tag == null)
            {
                Label l = new Label();
                l.Text = (new Random()).Next().ToString();
                l.BackColor = Color.White;
                l.ImageList = imlTree;
                l.Visible = true;
                l.ImageIndex = (tn.Level % 8);
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Tag = tn;
                l.Click += new EventHandler(l_Click);
                l.DoubleClick += new EventHandler(l_DoubleClick);
                l.MouseEnter += new EventHandler(l_MouseEnter);
                l.MouseLeave += new EventHandler(l_MouseLeave);
                l.MouseHover += new EventHandler(l_MouseHover);

                tn.Tag = l;
                tn.Text = "";
            }
        }
        private void l_MouseHover(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            SetTooltip((UltraTreeNode)l.Tag);
        }
        private void l_MouseLeave(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.Font = new Font(l.Font, FontStyle.Regular);
        }
        private void l_MouseEnter(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.Font = new Font(l.Font, FontStyle.Bold);
        }
        private void l_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            if (l.Tag is TreeNode)
            {
                TreeNode tn = (TreeNode)l.Tag;

                if (curLableSelected != null)
                    curLableSelected.ImageIndex = ((TreeNode)curLableSelected.Tag).Level % 7;
                l.ImageIndex = CTE_Selected_ImageIndex;
                curLableSelected = l;
            }
        }
        private void l_DoubleClick(object sender, EventArgs e)
        {
            Label l = (Label)sender;

            if (l.Tag is TreeNode)
            {
                TreeNode tn = (TreeNode)l.Tag;
                if (tn.IsExpanded)
                    tn.Collapse();
                else
                    tn.Expand();
            }
        }

        private void ut_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void ut_MouseMove(object sender, MouseEventArgs e)
        {
        }
        private void ut_DoubleClick(object sender, EventArgs e)
        {
            CommandEdit();
        }
        private void ut_DragDrop(object sender, DragEventArgs e)
        {
            UltraTreeNode draggedNode = (UltraTreeNode)e.Data.GetData(typeof(UltraTreeNode));
            Point p = ut.PointToClient(new Point(e.X, e.Y));
            UltraTreeNode draggedOverNode = ut.GetNodeFromPoint(p);
            if (draggedOverNode == null || draggedNode == null)
                return;

            draggedOverNode.Override.NodeAppearance.BackColor = Color.White;

            bool bRecurse = false;
            UltraTreeNode xn = draggedOverNode;
            while (xn.Parent != utnRoot)
            {
                if (xn.Parent == draggedNode)
                    bRecurse = true;
                xn = xn.Parent;
            }

            if (!bRecurse)
            {
                if ((draggedOverNode != null) && (draggedOverNode != draggedNode))
                {
                    draggedNode.Remove();
                    draggedOverNode.Nodes.Insert(0, draggedNode);
                    draggedOverNode.Expanded = true;
                }
            }
            else
            {
                Presentation.Public.Routines.ShowMessageBoxFa("حركت درخواست شده مجاز نیست ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            draggedNode = null;
            draggedOverNode = null;
        }
        private void ut_DragOver(object sender, DragEventArgs e)
        {
            Point p = ut.PointToClient(new Point(e.X, e.Y));
            UltraTreeNode utn = ut.GetNodeFromPoint(p);

            if ((utn != null) && (utn != draggedNode))
            {
                if (utn != draggedOverNode)
                {
                    if (draggedOverNode != null)
                        draggedOverNode.Override.NodeAppearance.BackColor = Color.White;

                    draggedOverNode = utn;
                    draggedOverNode.Override.NodeAppearance.BackColor = Color.Red;
                }
            }
            else
            {
                if (draggedOverNode != null)
                    draggedOverNode.Override.NodeAppearance.BackColor = Color.White;
                draggedOverNode = null;
            }

            e.Effect = DragDropEffects.Move;
            this.Text = DateTime.Now.ToShortTimeString();
        }
        private void ut_DragLeave(object sender, EventArgs e)
        {
            if (draggedOverNode != null)
            {
                draggedOverNode.Override.NodeAppearance.BackColor = Color.White;
                draggedOverNode = null;
            }
        }
        private void ut_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if ((e.EscapePressed) || (e.Action == DragAction.Cancel))
            {
                e.Action = DragAction.Cancel;

                if (draggedOverNode != null)
                {
                    draggedOverNode.Override.NodeAppearance.BackColor = Color.White;
                    draggedOverNode = null;
                }
            }
        }
        private void ut_SelectionDragStart(object sender, EventArgs e)
        {
            if (ut.ActiveNode != null)
            {
                draggedNode = ut.ActiveNode;
                draggedOverNode = null;

                ut.DoDragDrop(ut.ActiveNode, DragDropEffects.Move);
            }
        }

        private bool EditCaption(UltraTreeNode utn)
        {
            Point loc = ut.PointToScreen(new Point(utn.Bounds.Left + ut.Indent, utn.Bounds.Y + utn.ItemHeightResolved));
            FSMElementInfo fei = (FSMElementInfo)utn.Tag;
            fxCaption.Location = loc;
            fxCaption.Color = fei.Color;
            fxCaption.GroupName = fei.GroupName;
            fxCaption.GroupTitle = fei.GroupTitle;
            this.DialogResult = DialogResult.OK;

            if (fxCaption.ShowDialog() == DialogResult.OK)
            {
                if (fxCaption.IsTitle)
                {
                    fei.GroupName = string.Empty;
                    fei.GroupTitle = fxCaption.GroupTitle;
                }
                else
                {
                    fei.GroupName = fxCaption.GroupName;
                    fei.GroupTitle = string.Empty;
                }

                fei.Color = fxCaption.Color;

                utn.Text = fei.Caption;
                SetNodeTextAndColor(utn, fei.Color);

                return true;
            }

            return false;
        }

        private void SetNodeTextAndColor(UltraTreeNode utn, int color)
        {
            utn.Override.NodeAppearance.BackColor = Color.FromArgb(color);

            int preferredWidth = maxNodeWidth;
            int width = TextRenderer.MeasureText(utn.Text, this.Font).Width;
            int extra = TextRenderer.MeasureText(Char.ConvertFromUtf32(8203) + Char.ConvertFromUtf32(8203), this.Font).Width;
            string s = utn.Text;
            if (width <= preferredWidth)
            {
                while (width <= preferredWidth - 2 * extra)
                {
                    s = " " + s + " ";
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
        private void SetTooltip(UltraTreeNode utn)
        {
            if (utn == null)
            {
                toolTip.SetToolTip(ut, "");
                return;
            }

            FSMElementInfo fei = (FSMElementInfo)utn.Tag;
            List<string> ls = fsm.GetAccoungGroupRelatedInfo(fei.GroupName);

            string hint = Environment.NewLine;
            foreach (string s in ls)
            {
                hint += s + Environment.NewLine;
            }

            toolTip.SetToolTip(ut, hint);
            toolTip.ToolTipTitle = fei.Caption;
        }

        private void CommandAdd()
        {
            if (lsvModel.SelectedItems.Count == 0)
                return;

            ut.BeginUpdate();
            UltraTreeNode utn = new UltraTreeNode();
            FSMElementInfo fei = new FSMElementInfo();
            fei.Color = Color.Yellow.ToArgb();

            utn.Text = "New Item";
            UltraTreeNode utnParent = ut.ActiveNode;
            if (utnParent != utnRoot)
            {
                utnParent.Nodes.Add(utn);
                utnParent.Expanded = true;
            }
            else
                utnRoot.Nodes.Add(utn);
            utn.BringIntoView();
            ut.ActiveNode = utn;
            ut.EndUpdate();

            //
            fei.ParentId = (utnParent == utnRoot) ? -1 : ((FSMElementInfo)utnParent.Tag).ID;
            fei.FSModelID = ((FSMInfo)lsvModel.SelectedItems[0].Tag).ID;
            fei.GroupTitle = string.Empty;
            fei.GroupName = string.Empty;
            utn.Tag = fei;
            if (EditCaption(utn) == false)
            {
                utn.Remove();
                return;
            }

            if (!fei.IsTitle)
            {
                UltraTreeNode utx = utn.Parent;
                while (utx != utnRoot)
                {
                    if (!((FSMElementInfo)utx.Tag).IsTitle)
                    {
                        Presentation.Public.Routines.ShowMessageBoxFa("یك گروه زمانیكه یك گروه در سطح بالاتر وجود دارد نمی تواند اضافه شود", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        utn.Remove();
                        break;
                    }

                    utx = utx.Parent;
                }
            }



            bDirty = true;
        }
        private void CommandEdit()
        {
            if (ut.ActiveNode != null)
            {
                if (ut.ActiveNode == utnRoot)
                    return;

                if (EditCaption(ut.ActiveNode) == true)
                    bDirty = true;
            }
        }
        private void CommandRemove()
        {
            if (ut.ActiveNode != null)
            {

                if (Presentation.Public.Routines.ShowMessageBoxFa("عنصر انتخاب شده شما حذف خواهد شد. آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (ut.ActiveNode == utnRoot)
                        return;

                    //Revised - 1.2
                    FSMElementInfo fei = ((FSMElementInfo)ut.ActiveNode.Tag);
                    if (!fei.IsTitle && fei.ID != -1)
                        if (Presentation.Miscs.CheckDependents.Show(CheckDep.CHECK_FSM_Element, fei.ID.ToString()) == DialogResult.Cancel)
                            return;
                    //

                    if (fei.ID != -1)
                        removedIDs.Add(fei.ID);

                    ut.BeginUpdate();
                    ut.ActiveNode.Remove();
                    ut.EndUpdate();

                    bDirty = true;
                }
            }
        }
        private void CommandMoveLeft()
        {
            ut.BeginUpdate();
            if (ut.ActiveNode != null)
                if (ut.ActiveNode.Parent != utnRoot)
                {
                    UltraTreeNode selNode = ut.ActiveNode,
                             selNodeParent = selNode.Parent,
                             selNodeGrandParent = selNodeParent.Parent;

                    selNode.Remove();
                    if (selNodeGrandParent != utnRoot)
                        selNodeGrandParent.Nodes.Insert(selNodeParent.Index + 1, selNode);
                    else
                        utnRoot.Nodes.Insert(selNodeParent.Index + 1, selNode);

                    ut.ActiveNode = selNode;
                    selNode.BringIntoView();
                    bDirty = true;
                }
            ut.EndUpdate();
        }
        private void CommandMoveRight()
        {
            ut.BeginUpdate();
            if (ut.ActiveNode != null)
                if (ut.ActiveNode.GetSibling(NodePosition.Previous) != null)
                {
                    UltraTreeNode selNode = ut.ActiveNode,
                    selNodePrevNode = selNode.GetSibling(NodePosition.Previous);

                    selNode.Remove();
                    selNodePrevNode.Nodes.Add(selNode);

                    ut.ActiveNode = selNode;
                    selNode.BringIntoView();
                    bDirty = true;
                }
            ut.EndUpdate();
        }
        private void CommandMoveUp()
        {
            ut.BeginUpdate();
            if (ut.ActiveNode != null)
                if (ut.ActiveNode.GetSibling(NodePosition.Previous) != null)
                {
                    UltraTreeNode selNode = ut.ActiveNode,
                    selNodeParent = selNode.Parent;
                    int prevNodeIndex = selNode.GetSibling(NodePosition.Previous).Index;

                    selNode.Remove();
                    if (selNodeParent != utnRoot)
                        selNodeParent.Nodes.Insert(prevNodeIndex, selNode);
                    else
                        utnRoot.Nodes.Insert(prevNodeIndex, selNode);

                    ut.ActiveNode = selNode;
                    selNode.BringIntoView();
                    bDirty = true;
                }
            ut.EndUpdate();
        }
        private void CommandMoveDown()
        {
            ut.BeginUpdate();
            if (ut.ActiveNode != null)
                if (ut.ActiveNode.GetSibling(NodePosition.Next) != null)
                {
                    UltraTreeNode selNode = ut.ActiveNode,
                             selNodeParent = selNode.Parent;
                    int nextNodeIndex = selNode.GetSibling(NodePosition.Next).Index;

                    selNode.Remove();
                    if (selNodeParent != utnRoot)
                        selNodeParent.Nodes.Insert(nextNodeIndex, selNode);
                    else
                        utnRoot.Nodes.Insert(nextNodeIndex, selNode);

                    ut.ActiveNode = selNode;
                    selNode.BringIntoView();
                    bDirty = true;
                }
            ut.EndUpdate();
        }

        private void miAddAccountGroup_Click(object sender, EventArgs e)
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
        private void miConvert_Click(object sender, EventArgs e)
        {

        }
        private void miMoveUp_Click(object sender, EventArgs e)
        {
            CommandMoveUp();
        }
        private void miMoveLeft_Click(object sender, EventArgs e)
        {
            CommandMoveLeft();
        }
        private void miMoveRight_Click(object sender, EventArgs e)
        {
            CommandMoveRight();
        }
        private void miMoveDown_Click(object sender, EventArgs e)
        {
            CommandMoveDown();
        }
        private void miCollapseAll_Click(object sender, EventArgs e)
        {
            ut.CollapseAll();
        }
        private void miExpandAll_Click(object sender, EventArgs e)
        {
            ut.ExpandAll();
        }

        private void tsbHintBaloon_Click(object sender, EventArgs e)
        {
            toolTip.Active = !toolTip.Active;
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
        private void tsbShowBaloon_Click(object sender, EventArgs e)
        {
            toolTip.Active = !toolTip.Active;
        }
        private void tsbLabel_Click(object sender, EventArgs e)
        {
            bLabelCT = tsbLabel.Checked;
            tsbLabel.Text = bLabelCT ? "نوع قرارداد" : "نام گروه";
            ut.Invalidate();
        }

        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
            {
                if (bDirty)
                {
                    if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        SaveDiagram(curModelID, false);
                }
                bDirty = false;

                if (lsvModel.SelectedItems.Count > 0)
                {
                    FSMInfo fi = (FSMInfo)lsvModel.SelectedItems[0].Tag;
                    curModelID = fi.ID;

                    ut.Nodes.Clear();
                    htNodes.Clear();
                    FillDiagram(fi.ID);
                    SelectedModelID();
                    return;
                }
            }

            //else..
            curModelID = -1;
            ut.Nodes.Clear();
            htNodes.Clear();
        }
        private void lsvModel_DoubleClick(object sender, EventArgs e)
        {
            CommandModelEdit();
        }
        private void FillDiagram(int fsModelID)
        {
            Cursor.Current = Cursors.WaitCursor;
            ut.BeginUpdate();

            utnRoot = ut.Nodes.Add("مدلسازی ترازنامه");
            utnRoot.Override.NodeAppearance.BackColor = Color.White;
            utnRoot.Override.NodeAppearance.ForeColor = Color.Black;
            utnRoot.Override.ItemHeight = 20;

            DataTable dt = fsm.GetFSMelements(fsModelID);
            foreach (DataRow dr in dt.Rows)
            {
                FSMElementInfo fei = new FSMElementInfo();
                fsm.CloneX(dr, fei, ECloneXdir.DR2Info);

                UltraTreeNode utn = new UltraTreeNode();
                utn.Tag = fei;
                utn.Text = fei.Caption;
                SetNodeTextAndColor(utn, fei.Color);

                htNodes.Add(fei.ID, utn);

                if (htNodes.Contains(fei.ParentId))
                {
                    UltraTreeNode parentNode = (UltraTreeNode)htNodes[fei.ParentId];
                    parentNode.Nodes.Add(utn);
                }
                else
                {
                    utnRoot.Nodes.Add(utn);
                }
            }
            ut.EndUpdate();
            Cursor.Current = Cursors.Default;

            removedIDs.Clear();
        }
        private void FillModel()
        {
            DataTable dt = fsm.GetFSMs();
            foreach (DataRow dr in dt.Rows)
            {
                FSMInfo fi = new FSMInfo();
                fsm.CloneX(dr, fi, ECloneXdir.DR2Info);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = fi.ModelName;
                lvi.Tag = fi;

                lsvModel.Items.Add(lvi);
            }
        }

        private void CommandModelNew()
        {
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SaveDiagram(curModelID, false);

            }

            string descr = Presentation.Public.Routines.ShowInputBox();
            if (descr != string.Empty)
            {
                ListViewItem lvi = new ListViewItem();
                FSMInfo fi = new FSMInfo();


                //                
                fi.ModelName = descr;
                fi.ID = fsm.InsertFSM(fi);
                curModelID = fi.ID;

                lvi.Text = descr;
                lvi.Tag = fi;
                lsvModel.Items.Add(lvi);
                lvi.Selected = true;
            }

        }
        private void CommandModelCreateCopy()
        {
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SaveDiagram(curModelID, false);

            }

            if (lsvModel.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvModel.SelectedItems[0];
                ListViewItem lviNew = new ListViewItem();
                FSMInfo fi = (FSMInfo)lvi.Tag;
                FSMInfo fiNew = new FSMInfo();

                fiNew.ModelName = "Copy of " + fi.ModelName;
                //fiNew.ProfileID = fi.ProfileID; //Removed Rev 1.01

                lviNew.Text = "Copy of " + lvi.Text;

                lviNew.Tag = fiNew;
                lsvModel.Items.Add(lviNew);
                lviNew.Selected = true;

                //                                
                fiNew.ID = fsm.InsertFSM(fiNew);
                fsm.CreateCopy(fi.ID, fiNew.ID);
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
                    FSMInfo fi = (FSMInfo)lvi.Tag;
                    fi.ModelName = descr;
                    fsm.UpdateFSM(fi);
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
                    FSMInfo fi = (FSMInfo)lvi.Tag;

                    lvi.Remove();
                    fsm.DeleteFSM(fi.ID);
                }
            }
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
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (curModelID != -1)
                SaveDiagram(curModelID, true);
        }
        private void SaveDiagram(int modelID, bool bMessage)
        {
            foreach (int id in removedIDs)
                fsm.DeleteFSMelement(id);

            foreach (UltraTreeNode utn in utnRoot.Nodes)
                SaveNodeElementInfo(utn);

            if (bMessage)
                Presentation.Public.Routines.ShowMessageBoxFa("مدل شما ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);

            removedIDs.Clear();

            if (Changed != null)
                Changed();
            bDirty = false;
        }
        private void SaveNodeElementInfo(UltraTreeNode utn)
        {
            FSMElementInfo fei = (FSMElementInfo)utn.Tag;

            fei.Seq = utn.Index + 1;
            fei.Balance = utn.Level + 1;
            fei.ParentId = (utn.Parent == utnRoot) ? -1 : ((FSMElementInfo)utn.Parent.Tag).ID;
            fei.ULevel = GetULevel(fei, utn); //Revised 1.3
            if (fei.ID == -1)
                fei.ID = fsm.InsertFSMelement(fei);
            else
                fsm.UpdateFSMelement(fei);
            foreach (UltraTreeNode utnChild in utn.Nodes)
                SaveNodeElementInfo(utnChild);
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

        private void frmFSM_KeyDown(object sender, KeyEventArgs e)
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
                if (curModelID != -1)
                    SaveDiagram(curModelID, true);
            }
            //Remove
            if (e.Control && e.KeyCode.ToString() == "D")
            {
                CommandModelRemove();

            }
            if (e.KeyCode == Keys.F5)
            {
                fxCaption = new frmCaption();
            }
            if (e.Alt && e.KeyCode.ToString() == "N")
            {
                CommandAdd();

            }
            if (e.Alt && e.KeyCode.ToString() == "D")
            {
                CommandRemove();

            }

            if (e.Alt && e.KeyCode.ToString() == "E")
            {
                CommandEdit();
            }
            //MoveUp
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
        //Revised 1.3 - Added
        private string GetULevel(FSMElementInfo fei, UltraTreeNode utn)
        {
            if (utn.Parent == utnRoot)
            {
                return ((fei.Balance * 1000) + fei.Seq).ToString();
            }
            else
            {
                FSMElementInfo feiParent = ((FSMElementInfo)utn.Parent.Tag);
                return feiParent.ULevel + ((fei.Balance * 1000) + fei.Seq).ToString();
            }
        }
        public void DoPrint()
        {
            //Empty Print
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "FSM";
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)

                    foreach (UltraTreeNode utn in utnRoot.Nodes)
                        Filter(utn, txtSearch.Text);

            }
            catch
            {
                Presentation.Public.Routines.ShowMessageBoxFa("هیج مدل ترازنامه انتخاب نشده است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbSearch_CButtonClicked(object sender, EventArgs e)
        {

            foreach (UltraTreeNode utn in utnRoot.Nodes)
                Filter(utn, txtSearch.Text);
        }

        private void Filter(UltraTreeNode utn, string criteria)
        {

            foreach (UltraTreeNode utnChild in utn.Nodes)
            {
                FSMElementInfo fei = (FSMElementInfo)utnChild.Tag;
                if (Convert.ToBoolean(fei.Caption.Contains(criteria)))
                {
                    utnRoot.ExpandAll();

                    utnChild.Override.NodeAppearance.BackColor = Color.Red;
                }
            }
        }

        private void tsbUpdateGL_Click(object sender, EventArgs e)
        {
            new DAL.FSMDataSet().UpdateGLTable();
        }
    }
}
