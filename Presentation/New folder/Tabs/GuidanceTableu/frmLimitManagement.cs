using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERMSLib;
using System.Reflection;
using System.IO;
using ERMS.Logic;
using ERMS.Model;

//
using Infragistics.Win;
using Infragistics.Win.UltraWinTree;
using Presentation.Public;


namespace Presentation.Tabs.GuidanceTableu
{
    public partial class frmLimitManagement :   BaseForm, IPrintable
    {
        #region VAR/CONTROLS

        private int curModelID;
        private LM lm;
        private int maxNodeWidth;

        private Hashtable htNodes;
        private UltraTreeNode utnRoot;

        private int limitBase;
        private Presentation.Tabs.LimitManagement.frmNewLimit fxNewLimit;
        private List<int> removedIDs;
        private bool bDirty;
        
        DataTable dtTableXml;
        //private RPT rpt;
        Presentation.Tabs.LimitManagement.frmLimitAmount fxLimitAmount;
        private AGM agm;
        #endregion
        public frmLimitManagement()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
        }

        private void frmLimitManagement_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            Init();
            this.ResumeLayout();
            this.Dock = DockStyle.Fill;
        }

        private void Init()
        {
            htNodes = new Hashtable();
            lm = new LM();
            //rpt = new RPT();
            fxLimitAmount = new Presentation.Tabs.LimitManagement.frmLimitAmount();
           

            maxNodeWidth = 200;
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

            curModelID = -1;
            removedIDs = new List<int>();
            bDirty = false;
            //trv.ItemHeight = 32;
            //trv.Indent = 40;
            //trv.TreeInfoEx.Width4MinBox = 240;
            bDirty = false;
            ReadXml();
            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;

            FillModel();

            fxNewLimit = new Presentation.Tabs.LimitManagement.frmNewLimit();
         
        }
        private void ReadXml()
        {
            string s = Assembly.GetExecutingAssembly().Location;
            s = s.Substring(0, s.LastIndexOf("\\")) + "\\" + "TableProperty.xml";
            DataSet dset = new DataSet();
            FileStream fstr = new FileStream(s, FileMode.Open, FileAccess.Read);
            dset.ReadXml(fstr);
            dtTableXml = dset.Tables[0];
        }
        private void FillModel()
        {
            DataTable dt = lm.GetLMModels();
            foreach (DataRow dr in dt.Rows)
            {
                LMInfo li = new LMInfo();
                lm.CloneX(dr, li, ECloneXdir.DR2Info);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = li.LMModelName;
                lvi.Tag = li;

                lsvModel.Items.Add(lvi);
            }
        }
        private void tsbModelNew_Click(object sender, EventArgs e)
        {
            CommandModelNew();
        }
        private void CommandModelNew()
        {
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SaveDiagram(curModelID, false);

            }

            string descr = string.Empty;

            Presentation.Tabs.LimitManagement.frmNewModel fx = new Presentation.Tabs.LimitManagement.frmNewModel();
            if (fx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               
                 descr = fx.Description;
                 limitBase = fx.LimitBase;
            }
            if (descr != string.Empty)
            {
                ListViewItem lvi = new ListViewItem();
                LMInfo li = new LMInfo();
                lvi.Text = descr;
                li.LMModelName = descr;
                li.LMBase = fx.LimitBase;
                lvi.Tag = li;
                lsvModel.Items.Add(lvi);
                lvi.Selected = true;
                
                
               // DataRow[] dr = dtTableXml.Select("TableNameFarsi like '" + limitBase + "' ");
                //li.LMBase = dr[0]["TableNameEnglish"].ToString();
                
                li.ID = lm.InsertLM(li);
                lvi.Tag = li;
                curModelID = li.ID;
                
            }

        }
        private void tsbModelRemove_Click(object sender, EventArgs e)
        {
            CommandModelRemove();
        }
        private void CommandModelRemove()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("مدل انتخاب شده شما حذف خواهد شد. آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem lvi = lsvModel.SelectedItems[0];
                    LMInfo li = (LMInfo)lvi.Tag;

                    lvi.Remove();
                    lm.DeleteLM(li.ID);
                }
            }
        }

        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
            {
                
                //try
                //{
                //    ProgressBox.Show();
           //     Cursor = Cursors.WaitCursor;
                    if (bDirty)
                    {
                        if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Cursor = Cursors.WaitCursor;
                            SaveDiagram(curModelID, false);
                            Cursor = Cursors.Default;
                        }
                    }
                    bDirty = false;

                    if (lsvModel.SelectedItems.Count > 0)
                    {
                        LMInfo li = (LMInfo)lsvModel.SelectedItems[0].Tag;
                        curModelID = li.ID;
                        ut.Nodes.Clear();
                        htNodes.Clear();
                        
                        FillDiagram(li.ID);
                       // Cursor = Cursors.Default;
                      //  SelectedModelID();
                        return;
                    }
                    
                //}
                //catch (Exception ex)
                //{
                //    Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //finally
                //{
                //    ProgressBox.Hide();
                //}
            }

            //else..
            curModelID = -1;
            ut.Nodes.Clear();
            htNodes.Clear();
            
        }
        private void FillDiagram(int lsModelID)
        {
            Cursor.Current = Cursors.WaitCursor;
            ut.BeginUpdate();
            string strLimitBase = string.Empty;

            limitBase = ((LMInfo)lsvModel.SelectedItems[0].Tag).LMBase;
            if (limitBase == 0)
                strLimitBase = "داخلی";
            else
                strLimitBase = "بانك مركزی";

            utnRoot = ut.Nodes.Add("  محدودیت حدود   " + strLimitBase);
            utnRoot.Override.NodeAppearance.BackColor = Color.White;
            utnRoot.Override.NodeAppearance.ForeColor = Color.Black;
            utnRoot.Override.ItemHeight = 20;
            utnRoot.Override.MaxLabelWidth = maxNodeWidth;

            DataTable dt = lm.GetLMElements(curModelID);
            foreach (DataRow dr in dt.Rows)
            {
                LMElementInfo lei = new LMElementInfo();
                lm.CloneX(dr, lei, ECloneXdir.DR2Info);

                UltraTreeNode utn = new UltraTreeNode();
                utn.Tag = lei;
                utn.Text = lei.LMElementName;
                SetNodeTextAndColor(utn, lei.Color);

                htNodes.Add(lei.Id, utn);

                if (htNodes.Contains(lei.ParentId))
                {
                    UltraTreeNode parentNode = (UltraTreeNode)htNodes[lei.ParentId];
                    parentNode.Nodes.Add(utn);
                }
                else
                {
                    utnRoot.Nodes.Add(utn);
                }
            }
            ut.EndUpdate();
            Cursor.Current = Cursors.Default;

         //   removedIDs.Clear();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            CommandAdd();   

        }
        private void CommandAdd()
        {
            if (lsvModel.SelectedItems.Count == 0)
                return;
            		
            if (ut.ActiveNode.Text.Trim() != "مشتری :همه" && ut.ActiveNode.Text.Trim() != "تسهيلات :همه")
            {

                fxNewLimit.Color = Color.LightBlue.ToArgb();
                //  fxNewLimit.LimitBase = ((LMInfo)lsvModel.SelectedItems[0].Tag).LMBase;
                //  fxNewLimit.LimitBase = "Loan_Contract";

                fxNewLimit.LimitBase = "Collateral";
                if (fxNewLimit.ShowDialog() == DialogResult.OK)
                {
                    //try
                    //{
                    //    ProgressBox.Show();
                    Cursor = Cursors.WaitCursor;
                    if (fxNewLimit.LimitValue != "همه" || fxNewLimit.Limit == "مشتری" || fxNewLimit.Limit == "تسهيلات")
                    // if (fxNewLimit.LimitValue != "همه")
                    {
                        if (!fxNewLimit.ApplyAll)
                        {
                          //  AddOneNode(fxNewLimit.Limit + " :" + fxNewLimit.LimitValue, fxNewLimit.Color, ut.ActiveNode);
                            AddOneNode(fxNewLimit.Limit + " " + fxNewLimit.Operator + " " + fxNewLimit.LimitValue, fxNewLimit.Color, ut.ActiveNode);
                        }
                        else
                        {

                            foreach (UltraTreeNode ut1 in ut.ActiveNode.Parent.Nodes)

                                AddOneNode(fxNewLimit.Limit + " " + fxNewLimit.Operator + " " + fxNewLimit.LimitValue, fxNewLimit.Color, ut1);

                        }
                    }
                    else
                    {
                        if (!fxNewLimit.ApplyAll)
                        {
                            AddAllNodes(fxNewLimit.Limit, fxNewLimit.Color, ut.ActiveNode);
                        }
                        else
                        {

                            if (ut.ActiveNode.Parent != null)
                            {
                                foreach (UltraTreeNode ut1 in ut.ActiveNode.Parent.Nodes)
                                {


                                    AddAllNodes(fxNewLimit.Limit, fxNewLimit.Color, ut1);

                                }
                            }
                            else
                            { AddAllNodes(fxNewLimit.Limit, fxNewLimit.Color, ut.ActiveNode); }

                        }
                    }

                    //}
                    //catch (Exception ex)
                    //{
                    //    Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //finally
                    //{
                    //    ProgressBox.Hide();
                    //}    

                }
            }
            else
            { Presentation.Public.Routines.ShowMessageBoxFa("گروه  انتخاب شده بايد در آخرين سطح باشد ", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error); }
             bDirty = true;
             Cursor = Cursors.Default;
        }
        private void AddOneNode(string TextName, int Color, UltraTreeNode utnParent)
        {
             
       
                ut.BeginUpdate();
                UltraTreeNode utn = new UltraTreeNode();
                LMElementInfo lei = new LMElementInfo();
                lei.Color = Color;
                lei.LMElementName = TextName;
                lei.LMTable = fxNewLimit.Table_Name;
                lei.LMFieldId = fxNewLimit.Field_Id;
                lei.LMOperator = fxNewLimit.Operator;
 
                      
                utn.Tag = lei;

                 utn.Text = TextName;
               
                SetNodeTextAndColor(utn, lei.Color);

                utnParent.Nodes.Add(utn);
       
                if (lei.Id == -1)
                {
                    lei.LMElementName = utn.Text;
                    lei.ParentId = (utn.Parent == utnRoot) ? -1 : ((LMElementInfo)utn.Parent.Tag).Id;
                    lei.Seq = utn.Index + 1;
                    lei.Balance = utn.Level + 1;
                    lei.ULevel = GetULevel(lei, utn);
                    lei.LMId = curModelID;
                    lei.Id = lm.InsertElement(lei);
                }

                utnParent.Expanded = true;

                utn.BringIntoView();
                ut.ActiveNode = utn;
       
                ut.EndUpdate();

                lei.ParentId = (utnParent == utnRoot) ? -1 : ((LMElementInfo)utn.Parent.Tag).Id;
                lei.LMId = ((LMInfo)lsvModel.SelectedItems[0].Tag).ID;
              
                   

            
         }
        private void AddAllNodes(string TableName, int Color, UltraTreeNode utnParent)
        {
            string str = "TableNameFarsi like '" + TableName + "' ";
            DataRow[] dr = dtTableXml.Select(str);

            string strField = dr[0]["Field"].ToString();

            string filterexpression = string.Empty;
            DataTable dtDest = lm.GetTable(dr[0]["Id"].ToString(), strField, dr[0]["TableNameEnglish"].ToString(), filterexpression);


                ut.BeginUpdate();
                UltraTreeNode utn = new UltraTreeNode();
                LMElementInfo lei;

                for (int i = 0; i < dtDest.Rows.Count; i++)
                {

                    utn = new UltraTreeNode();
                    lei = new LMElementInfo();
                    lei.Color = Color;
       
                    lei.LMElementName = dr[0]["TableNameFarsi"].ToString()+ " " + fxNewLimit.Operator + " " + dtDest.Rows[i][strField].ToString();
                    lei.LMTable =  dr[0]["Id"].ToString();
                    lei.LMFieldId = dtDest.Rows[i][0].ToString();
                    lei.LMOperator = fxNewLimit.Operator;
                    utn.Tag = lei;

                  
                    utn.Text = dr[0]["TableNameFarsi"].ToString() + " " + fxNewLimit.Operator + " " + dtDest.Rows[i][strField].ToString();
                    SetNodeTextAndColor(utn, Color);

                    utnParent.Nodes.Add(utn);

                    if (lei.Id == -1)
                    {
                        lei.LMElementName = utn.Text;
                        lei.ParentId = (utn.Parent == utnRoot) ? -1 : ((LMElementInfo)utn.Parent.Tag).Id;
                        lei.Seq = utn.Index + 1;
                        lei.Balance = utn.Level + 1;
                        lei.ULevel = GetULevel(lei, utn);
                        lei.LMId = curModelID;
                        lei.Id = lm.InsertElement(lei);
                    }
                           
                    utnParent.Expanded = true;
                    lei.ParentId = (utnParent == utnRoot) ? -1 : ((LMElementInfo)utnParent.Tag).Id;
                    lei.LMId = ((LMInfo)lsvModel.SelectedItems[0].Tag).ID;
       
                    lei.LMElementName = dr[0]["TableNameFarsi"].ToString() + " " + fxNewLimit.Operator + " " + dtDest.Rows[i][strField].ToString();

                    // }
                }

                utn.BringIntoView();
                ut.EndUpdate();
           

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
        private void tsbRemove_Click(object sender, EventArgs e)
        {
            CommandRemove();
        }
        private void CommandRemove()
        {
            if (ut.ActiveNode != null)
            {

                if (Presentation.Public.Routines.ShowMessageBoxFa("عنصر انتخاب شده شما حذف خواهد شد. آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (ut.ActiveNode == utnRoot)
                        
                        return;

                    LMElementInfo lei = ((LMElementInfo)ut.ActiveNode.Tag);
                    if (lei.Id != -1)
                    {
                        removedIDs.Add(lei.Id);
                        RemovedChildID(ut.ActiveNode);
                       
                    }
                  
                    ut.BeginUpdate();
                    ut.ActiveNode.Remove();
                    ut.EndUpdate();

                    bDirty = true;
                }
            }
        }
        private void RemovedChildID(UltraTreeNode utn)
        { 
            LMElementInfo lei = ((LMElementInfo)utn.Tag);
            removedIDs.Add(lei.Id);
                       
                    foreach (UltraTreeNode utnChild in utn.Nodes)
                        RemovedChildID(utnChild);

        }
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            CommandEdit();
           
        }
        private void CommandEdit()
        {
            if (ut.ActiveNode.Tag != null)
            {
                fxNewLimit.Color = ((LMElementInfo)ut.ActiveNode.Tag).Color;
#warning این قسمت نبود من اضافه کردم               
                fxNewLimit.LimitBase = "Collateral";
                // fxNewLimit.LimitBase = ((LMInfo)lsvModel.SelectedItems[0].Tag).LMBase;
                //fxNewLimit.LimitBase =
                //fxNewLimit.Limit = ((LMElementInfo)ut.ActiveNode.Tag).LMTable;
                fxNewLimit.LimitValue = ((LMElementInfo)ut.ActiveNode.Tag).LMFieldId;

                if (fxNewLimit.ShowDialog() == DialogResult.OK)
                {

                    ut.BeginUpdate();
                    UltraTreeNode utn = new UltraTreeNode();
                    utn = ut.ActiveNode;

                    LMElementInfo lei = new LMElementInfo();
                    lei = (LMElementInfo)utn.Tag;

                    lei.Color = fxNewLimit.Color;
                    lei.LMElementName = fxNewLimit.Limit + " :" + fxNewLimit.LimitValue;
                    lei.LMTable = fxNewLimit.Table_Name;
                    lei.LMFieldId = fxNewLimit.Field_Id;
                    utn.Tag = lei;
                    utn.Text = fxNewLimit.Limit + " :" + fxNewLimit.LimitValue; ;
                    SetNodeTextAndColor(utn, lei.Color);


                    utn.BringIntoView();
                    ut.EndUpdate();
                    bDirty = true;
                    //
                  }
            }
        }



        private void tsbModelEdit_Click(object sender, EventArgs e)
        {
            CommandModelEdit();
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

                    LMInfo li = (LMInfo)lvi.Tag;
                    li.LMModelName = descr;
                    lm.UpdateLM(li);
                    
                }
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (curModelID != -1)
                SaveDiagram(curModelID, true);
        }
        private void SaveDiagram(int modelID, bool bMessage)
        {
          
            foreach (int id in removedIDs)
                lm.DeleteElement(id);
           
            foreach (UltraTreeNode utn in utnRoot.Nodes)
                SaveNodeElementInfo(utn);

            if (bMessage)
                Presentation.Public.Routines.ShowMessageBoxFa("مدل شما ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);

            removedIDs.Clear();

             bDirty = false;
        }
        private void SaveNodeElementInfo(UltraTreeNode utn)
        {
            LMElementInfo lei = (LMElementInfo)utn.Tag;

            lei.LMElementName = utn.Text;
            lei.ParentId = (utn.Parent == utnRoot) ? -1 : ((LMElementInfo)utn.Parent.Tag).Id;
            lei.Seq = utn.Index + 1;
            lei.Balance = utn.Level + 1;
            lei.ULevel = GetULevel(lei, utn);
            lei.LMId = curModelID;
            if (lei.Id == -1)
                lei.Id = lm.InsertElement(lei);
           else
                lm.UpdateLMElement(lei);

            foreach (UltraTreeNode utnChild in utn.Nodes)
                SaveNodeElementInfo(utnChild);
        }


     

        private void frmLimitManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bDirty)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SaveDiagram(curModelID, false);
            }
        }

        private void miAdd_Click(object sender, EventArgs e)
        {
            CommandAdd();
        }
        private void miRemove_Click(object sender, EventArgs e)
        {
            CommandRemove();
        }
        private void miEdit_Click(object sender, EventArgs e)
        {
            CommandEdit();
        }
        private void miCollapseAll_Click(object sender, EventArgs e)
        {
            ut.CollapseAll();
        }

        private void miExpandAll_Click(object sender, EventArgs e)
        {
            ut.ExpandAll();
        }

        private void ut_DoubleClick(object sender, EventArgs e)
        {
           if (lm.GetLMElements(curModelID).Rows.Count != 0)
            {
                if (!ut.ActiveNode.Selected)
                {
                    if (ut.ActiveNode.HasNodes)
                    {
                        Presentation.Public.Routines.ShowMessageBoxFa("عدم امکان تعریف حد" + "\n" + "تعریف حد تنها برای گره های پایانی امکانپذیر است",
                                "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    LMElementInfo lmeInfo = new LMElementInfo();
                    lmeInfo = (LMElementInfo)ut.ActiveNode.Tag;
                    
                    fxLimitAmount.ElementId = lmeInfo.Id;

                                      
                    if (fxLimitAmount.ShowDialog() == DialogResult.OK)
                    {
                      
                        lmeInfo.Amount = fxLimitAmount.Amount;
                        lmeInfo.AmountOperand = fxLimitAmount.Amount_Operand;
                        lmeInfo.AmountPercent = fxLimitAmount.Amount_Percent;
                        lmeInfo.AmountType = fxLimitAmount.Amount_Type;
                       
                        lmeInfo.Id = ((LMElementInfo)ut.ActiveNode.Tag).Id;
                        lmeInfo.LMId = ((LMElementInfo)ut.ActiveNode.Tag).LMId;

                        if (CheckAmount(ut.ActiveNode, lmeInfo))
                        {
                            if (fxLimitAmount.ApplyAll)
                                 foreach (UltraTreeNode utnChild in ut.ActiveNode.Parent.Nodes)
                                       UpdateAmount(utnChild);
                                                             
                            else
                                UpdateAmount(ut.ActiveNode);
                                
                            
                            Presentation.Public.Routines.ShowMessageBoxFa("حدود وارد شده اعمال شد ", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                         Presentation.Public.Routines.ShowMessageBoxFa("مقدار وارد شده مجاز نمی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    }
                    
                }
            }
            else
            { Presentation.Public.Routines.ShowMessageBoxFa("ابتدا مدل را ذخيره كنيد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }
        private void UpdateAmount(UltraTreeNode utn)
        {
            LMElementInfo lmeInfo = new LMElementInfo();
            lmeInfo.Id = ((LMElementInfo)utn.Tag).Id;
            lmeInfo.LMId = ((LMElementInfo)utn.Tag).LMId;
            lmeInfo.LMTable = ((LMElementInfo)utn.Tag).LMTable;
            lmeInfo.LMElementName = ((LMElementInfo)utn.Tag).LMElementName;
            lmeInfo.ParentId = ((LMElementInfo)utn.Tag).ParentId;
            lmeInfo.Seq = utn.Index + 1;
            lmeInfo.Balance = utn.Level + 1;
            lmeInfo.ULevel = GetULevel(lmeInfo, utn);

            lmeInfo.LMFieldId = ((LMElementInfo)utn.Tag).LMFieldId;

            ((LMElementInfo)utn.Tag).Amount =lmeInfo.Amount = fxLimitAmount.Amount;
            ((LMElementInfo)utn.Tag).AmountOperand = lmeInfo.AmountOperand = fxLimitAmount.Amount_Operand;
            ((LMElementInfo)utn.Tag).AmountPercent = lmeInfo.AmountPercent = fxLimitAmount.Amount_Percent;
            ((LMElementInfo)utn.Tag).AmountType = lmeInfo.AmountType = fxLimitAmount.Amount_Type;

            lmeInfo.Color = ((LMElementInfo)ut.ActiveNode.Tag).Color;
            lm.UpdateLMElement(lmeInfo);
        
        }
       
        private bool CheckAmount(UltraTreeNode utn, LMElementInfo lmeInfo)
        {
            bool flag = true;
            
            DataRow drChild = lm.GetLMElement(lmeInfo.Id);
           
                if (int.Parse(drChild["ParentId"].ToString()) != -1)
                {
                    DataRow drParent = Parent(lmeInfo.Id);
                    DataTable dtchilld = lm.GetLMElementsChilds(lmeInfo.LMId, lmeInfo.ParentId);
                    
                    if (drParent != null)
                    {
                        decimal ParentAmount = CalculateAmount(int.Parse(drChild["ParentId"].ToString()), drParent["AmountType"].ToString(), drParent["Amount"].ToString(), decimal.Parse(drParent["AmountPercent"].ToString()));

                        decimal NodeAmount = CalculateAmount(lmeInfo.Id, lmeInfo.AmountType, lmeInfo.Amount, lmeInfo.AmountPercent);


                        if (fxLimitAmount.ApplyAll)
                        {
                            NodeAmount = utn.Parent.Nodes.Count * NodeAmount;
                        }
                        else
                        {
                            //NodeAmount = 0;
                            for (int i = 0; i < dtchilld.Rows.Count; i++)
                            {
                                if (int.Parse(dtchilld.Rows[i][0].ToString()) != lmeInfo.Id)
                                NodeAmount = NodeAmount + CalculateAmount(int.Parse(dtchilld.Rows[i][0].ToString()), dtchilld.Rows[i]["amounttype"].ToString().Trim(), dtchilld.Rows[i]["Amount"].ToString(), decimal.Parse(dtchilld.Rows[i]["AmountPercent"].ToString()));

                            }
                        }
                        if (NodeAmount > ParentAmount)
                        { flag = false; }
                    }
                }
             return flag;

        }
        private decimal CalculateAmount(int id,string Amount_Type,string Amount,decimal Amount_Percent)
        {
            decimal Amount_LM=0;
            if (Amount_Type.Trim() == "A")
            { Amount_LM =  (Amount_Percent / 100) * decimal.Parse(Amount);}

            if (Amount_Type.Trim() == "AG")
            { Amount_LM = (Amount_Percent / 100) * lm.CalculateAmount(Amount, Amount_LM); }
            return Amount_LM;
        
        }
        DataRow dr;
        private DataRow Parent(int id)
        {
           
            DataRow drChild = lm.GetLMElement(id);
            if (int.Parse(drChild["ParentId"].ToString()) != -1)
            {
                DataRow drParent = lm.GetLMElement(int.Parse(drChild["ParentId"].ToString()));

                if (drParent["Amount"].ToString() == string.Empty)
                    Parent(int.Parse(drParent["Id"].ToString()));
                else
                    dr = drParent;
            }
            return dr;

        }


        private string GetULevel(LMElementInfo lei, UltraTreeNode utn)
        {
            if (utn.Parent == utnRoot)
            {
                return ((lei.Balance * 1000) + lei.Seq).ToString();
            }
            else
            {
                LMElementInfo leiParent = ((LMElementInfo)utn.Parent.Tag);
                return leiParent.ULevel + ((lei.Balance * 1000) + lei.Seq).ToString();
            }
        }

        public void DoPrint()
        {
            //Empty Print
        }

        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "LimitManagement";
        }

        private void spcAll_Panel2_Paint(object sender, PaintEventArgs e)
        {

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
       
          

    }
}