using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL.Table_DataSetTableAdapters;
using ERMS.Data;
using ERMS.Logic;
using ERMS.Model;
using ERMSLib;
using Presentation.Public;
using MyDialogButton = Utilize.MyDialogButton;

namespace Presentation.Tabs.GuidanceTableu
{
    public partial class frmModelManagement : BaseForm, IPrintable
    {

        #region VAR/CONTROLS

        DAL.Table_DataSetTableAdapters.UsersTableAdapter user;
        FSM fsm;
        FSMInfo fsmi;
        private GCX gcx;
        private AGM agm;
        private TBM tbm;
        private CBM cbm;
        private CRP crp;
        private Hashtable htNodes;
        private int curModelID;
        TreeNode tnRoot;


        #endregion

        public frmModelManagement()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
        }
        private void frmTemplate_Load(object sender, EventArgs e)
        {
            user = new UsersTableAdapter();
            fsm = new FSM();
            gcx = new GCX();
            agm = new AGM();
            tbm = new TBM();
            cbm = new CBM();
            crp = new CRP();

            trv.ItemHeight = 32;
            trv.Indent = 40;
            trv.TreeInfoEx.Width4MinBox = 240;

            curModelID = -1;
            spcModels.Panel2Collapsed = true;
            htNodes = new Hashtable();
            FillUsers();
        }
        public const string CTE_Alias_ID = "User_ID";
        public const string CTE_Alias_UserName = "User_Name";
        public const string CTE_Alias_ActProfile = "Act_Profile_Id";
        public void CloneX(DataRow dr, UserInfo ui, ECloneXdir direction)
        {

            if (direction == ECloneXdir.Info2DR)
            {
                dr[CTE_Alias_ID] = ui.User_Id;
                dr[CTE_Alias_ActProfile] = ui.Act_Profile_Id;
                dr[CTE_Alias_UserName] = ui.User_Name;
            }
            else
            {
                ui.User_Id = DHelper.GetColumnValue(dr, CTE_Alias_ID, ui.User_Id);
                ui.Act_Profile_Id = DHelper.GetColumnValue(dr, CTE_Alias_ActProfile, ui.Act_Profile_Id);
                ui.User_Name = DHelper.GetColumnValue(dr, CTE_Alias_UserName, ui.User_Name);
            }
        }
        private void FillUsers()
        {
            DataTable dt = user.GetData();// .UserReader();
            trvUsers.Nodes.Clear();

            trvUsers.BeginUpdate();

            int profileId;
            foreach (DataRow dr in dt.Rows)
            {

                UserInfo ui = new UserInfo();
                CloneX(dr, ui, ECloneXdir.DR2Info);

                TreeNode UserNode = new TreeNode();
                UserNode.Tag = ui;
                UserNode.Text = ui.User_Name;

                trvUsers.Nodes.Add(UserNode);
                DataTable dtProfile = new DAL.Table_DataSetTableAdapters.ProfileTableAdapter().GetDataByUserId(ui.User_Id);// user.GetDataByUserId(ui.User_Id);)
                foreach (DataRow drProfile in dtProfile.Rows)
                {
                    profileId = int.Parse(drProfile["ID"].ToString());
                    var tnProfile = new TreeNode {Text = drProfile["Profile_Id"].ToString()};
                    UserNode.Nodes.Add(tnProfile);

                    // Account Group Model
                    TreeNode tnAGM = new TreeNode {Text = "مدل گروههای حساب"};
                    tnProfile.Nodes.Add(tnAGM);


                    AGM_DL dlAGM = new AGM_DL();
                    var dtAGM = dlAGM.GetAccountTitles(profileId);

                    foreach (DataRow drAGM in dtAGM.Rows)
                    {
                        AccountGroupInfo agi = new AccountGroupInfo();
                        agm.CloneX(drAGM, agi, ECloneXdir.DR2Info);
                        tnAGM.Tag = agi;
                    }


                    //Financial Statement Model
                    TreeNode tnFsm = new TreeNode {Text = "مدل صورت وضعیت مالی"};
                    tnProfile.Nodes.Add(tnFsm);

                    FSM_DL dl = new FSM_DL();
                    var dtFSM = dl.GetFSMs(profileId);

                    foreach (DataRow drFsm in dtFSM.Rows)
                    {
                        FSMInfo fi = new FSMInfo();
                        fsm.CloneX(drFsm, fi, ECloneXdir.DR2Info);

                        TreeNode tnFsm1 = new TreeNode {Text = fi.ModelName, Tag = fi};
                        tnFsm.Nodes.Add(tnFsm1);

                    }

                    //Time Bucket Model
                    TreeNode tnTbm = new TreeNode {Text = "مدل بسته زمانی"};
                    tnProfile.Nodes.Add(tnTbm);

                    TBM_DL tbm_dl = new TBM_DL();
                    DataTable dtTBM = tbm_dl.GetTBMs(profileId);

                    foreach (DataRow drTbm in dtTBM.Rows)
                    {
                        TBMInfo ti = new TBMInfo();
                        tbm.CloneX(drTbm, ti, ECloneXdir.DR2Info);

                        TreeNode tnTbm1 = new TreeNode {Text = ti.ModelName, Tag = ti};
                        tnTbm.Nodes.Add(tnTbm1);

                    }

                    //Time Bucket Fill Modeling
                    TreeNode tnCbm = new TreeNode();
                    tnCbm.Text = "مدل دلخواه پر كردن بسته زمانی";
                    tnProfile.Nodes.Add(tnCbm);

                    CBM_DL cbm_dl = new CBM_DL();
                    DataTable dtCbm = cbm_dl.GetCBMs(profileId);

                    foreach (DataRow drCbm in dtCbm.Rows)
                    {
                        CBMInfo ci = new CBMInfo();
                        cbm.CloneX(drCbm, ci, ECloneXdir.DR2Info);

                        TreeNode tnCbm1 = new TreeNode();
                        tnCbm1.Text = ci.ModelName;
                        tnCbm1.Tag = ci;
                        tnCbm.Nodes.Add(tnCbm1);

                    }

                    // Credit Risk

                    TreeNode tnCrp = new TreeNode();
                    tnCrp.Text = " ریسك اعتباری";
                    tnProfile.Nodes.Add(tnCrp);

                    CRP_DL crp_dl = new CRP_DL();
                    var dtCrp = CRP_DL.GetCRPMs(profileId);

                    foreach (DataRow drCrp in dtCrp.Rows)
                    {
                        CRPMInfo crpi = new CRPMInfo();
                        crp.CloneX(drCrp, crpi, ECloneXdir.DR2Info);

                        TreeNode tnCrp1 = new TreeNode {Text = crpi.ModelName, Tag = crpi};
                        tnCrp.Nodes.Add(tnCrp1);

                    }
                }
            }
            trvUsers.EndUpdate();
        }
        private void trvUsers_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            trv.Nodes.Clear();
            ClearBackColor();

            if (e.Node.Tag is FSMInfo)
            {
                e.Node.BackColor = Color.FromArgb(148, 183, 233);
                spcModels.Panel2Collapsed = true;
                fsmi = (FSMInfo)e.Node.Tag;
                FillDiagramFsm(fsmi.ID);

            }
            if (e.Node.Tag is AccountGroupInfo)
            {
                e.Node.BackColor = Color.FromArgb(148, 183, 233);
                spcModels.Panel2Collapsed = true;
                AccountGroupInfo agmi = (AccountGroupInfo)e.Node.Tag;
                FillDiagramAGM(agmi.ProfileId);
            }
            if (e.Node.Tag is TBMInfo)
            {
                e.Node.BackColor = Color.FromArgb(148, 183, 233);
                spcModels.Panel1Collapsed = true;
                spcTbm.Panel1Collapsed = false;
                spcTbm.Panel2Collapsed = false;
                FillDiagramTbm((TBMInfo)e.Node.Tag);

            }
            if (e.Node.Tag is CBMInfo)
            {
                e.Node.BackColor = Color.FromArgb(148, 183, 233);
                spcModels.Panel1Collapsed = true;
                spcTbm.Panel1Collapsed = true;
                FillDiagramCbm((CBMInfo)e.Node.Tag);

            }
            if (e.Node.Tag is CRPMInfo)
            {
                e.Node.BackColor = Color.FromArgb(148, 183, 233);
                spcModels.Panel1Collapsed = true;
                spcTbm.Panel1Collapsed = true;
                FillDiagramCrp((CRPMInfo)e.Node.Tag);

            }
        }

        #region Account Group Modeling
        private void FillDiagramAGM(int profileId)
        {

            trv.BeginUpdate();

            tnRoot = trv.Nodes.Add("مدل گروههای حساب");

            AGM_DL agm_dl = new AGM_DL();
            DataTable dt = agm_dl.GetAccountTitles(profileId);

            htNodes.Clear();
            foreach (DataRow dr in dt.Rows)
            {
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
                    DataTable dtAGs = agm_dl.GetAGs(profileId, agi.GroupName);
                    foreach (DataRow drAG in dtAGs.Rows)
                    {
                        AGInfo ai = new AGInfo();
                        ai.ObjectState = EObjectState.Clean;
                        agm.CloneX(drAG, ai, ECloneXdir.DR2Info);

                        TreeNode tnAG = new TreeNode();
                        tnAG.Text = ai.AccountName.ToString();
                        tnAG.ToolTipText = tnAG.Text;
                        tnAG.Tag = ai;
                        tnAG.BackColor = Color.LightBlue;

                        tn.Nodes.Add(tnAG);
                    }
                }
            }
            trv.EndUpdate();
        }
        private void SaveDiagramAGM(int ProfileID)
        {


            foreach (TreeNode tn in tnRoot.Nodes)
                SaveNodeElementInfo(tn, ProfileID);

            SaveGC(ProfileID);
            Presentation.Public.Routines.ShowMessageBoxFa("مدل با موفقیت ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
        // save all of the accounting groups that reconciled

        private void SaveGC(int ProfileID)
        {
            AccountGroupInfo agmi = (AccountGroupInfo)trvUsers.SelectedNode.Tag;
            GC_DL gct = new GC_DL();

            DataTable dt = gct.GetInstancesDT_D(agmi.ProfileId);
            //DataTable dt = gct.GetInstancesDT_D(ProfileID);
            foreach (DataRow dr in dt.Rows)
            {
                string groupName = dr["GroupDescr"].ToString();
                int ContractType = int.Parse(dr["Contract_Type"].ToString());

                if (!CheckExsistGC(groupName, ContractType, ProfileID))
                {
                    DataRow dr1 = gcx.InsertInstance_M(groupName, ContractType, ProfileID);
                }
            }


        }
        private bool CheckExsistGC(string strGroupName, int ContractType, int ProfileID)
        {
            DataTable dt = gcx.GetInstancesDT_D_M(ProfileID);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (((string)dt.Rows[i]["GroupDescr"].ToString().ToLower() == strGroupName.ToLower()) && (int.Parse(dt.Rows[i]["Contract_Type"].ToString().ToLower()) == ContractType))
                {
                    return true;

                }

            }
            return false;
        }

        private void SaveNodeElementInfo(TreeNode tn, int ProfileID)
        {
            if (tn.Tag is AccountGroupInfo)
            {
                AccountGroupInfo agi = (AccountGroupInfo)tn.Tag;

                agi.Sequence = tn.Index + 1;
                agi.Balance = tn.Level + 1;
                agi.ParentId = (tn.Parent == tnRoot) ? -1 : ((AccountGroupInfo)tn.Parent.Tag).TitleID;
                agi.ULevel = GetULevel(agi, tn);
                agi.ProfileId = ProfileID;

                if (!agi.IsTitle)
                {
                    if (CheckExsist(agi.GroupName, ProfileID))

                    { agi.GroupName = MakeString(agi.GroupName, ProfileID); }

                    agi.ProfileId = ProfileID;
                    agi.GroupID = agm.InsertAccountGroup_M(agi);
                }

                // if (CheckExsistTitle(agi.GroupTitle))
                // { agi.GroupTitle = MakeStringTitle(agi.GroupTitle); }

                agi.ProfileId = ProfileID;
                agi.TitleID = agm.InsertAccountTitle_M(agi);





                foreach (TreeNode tnChild in tn.Nodes)
                    SaveNodeElementInfo(tnChild, ProfileID);
            }
            else
                if (tn.Tag is AGInfo)
                {
                    AGInfo agi = (AGInfo)tn.Tag;
                    agi.GroupName = ((AccountGroupInfo)tn.Parent.Tag).GroupName;

                    agi.ID = agm.InsertAG_M(agi, ProfileID);

                }

        }
        //private bool CheckExsistTitle(string strTitle)
        //{
        //    DataTable dt = agm.GetAccountTitles();

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        if ((string)dt.Rows[i]["GroupTitle"].ToString().ToLower() == strTitle.ToLower())
        //        {
        //            return true;

        //        }

        //    }
        //    return false;
        //}
        private bool CheckExsist(string strGroupName, int ProfileID)
        {

            DataTable dt = agm.GetAccountGroups_M(ProfileID);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ((string)dt.Rows[i]["GroupName"].ToString().ToLower() == strGroupName.ToLower())
                {
                    return true;

                }

            }
            return false;
        }

        //private string MakeStringTitle(string strTitle)
        //{
        //    DataTable dt = agm.GetAccountTitles();

        //    string strTitleNew = strTitle;

        //    for (int j = 0; j < dt.Rows.Count; j++)
        //    {
        //        if (dt.Rows[j]["GroupTitle"].ToString().StartsWith(strTitle + "_Copy"))
        //        { strTitleNew = dt.Rows[j]["GroupTitle"].ToString(); }
        //    }
        //    strTitleNew = strTitleNew + "_Copy";
        //    return strTitleNew;
        //}

        private string MakeString(string strGroupName, int ProfileID)
        {
            DataTable dt = agm.GetAccountGroups_M(ProfileID);

            string strGroupNameNew = strGroupName;

            for (int j = 0; j < dt.Rows.Count; j++)
            {
                if (dt.Rows[j]["GroupName"].ToString().StartsWith(strGroupName + "_Copy"))
                { strGroupNameNew = dt.Rows[j]["GroupName"].ToString(); }
            }
            strGroupNameNew = strGroupNameNew + "_Copy";
            return strGroupNameNew;
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

        #endregion

        #region "Financial Statement Modeling"

        private void FillDiagramFsm(int fsModelID)
        {
            Cursor.Current = Cursors.WaitCursor;


            trv.BeginUpdate();
            tnRoot = trv.Nodes.Add("مدل صورت وضعیت مالی");
            htNodes.Clear();

            DataTable dt = fsm.GetFSMelements(fsModelID);

            foreach (DataRow dr in dt.Rows)
            {
                FSMElementInfo fei = new FSMElementInfo();
                fsm.CloneX(dr, fei, ECloneXdir.DR2Info);

                TreeNode tn = new TreeNode();
                tn.Tag = fei;
                tn.Text = fei.Caption;
                tn.ToolTipText = fei.Caption;
                tn.BackColor = Color.FromArgb(fei.Color);

                htNodes.Add(fei.ID, tn);

                if (htNodes.Contains(fei.ParentId))
                {
                    TreeNode parentNode = (TreeNode)htNodes[fei.ParentId];
                    parentNode.Nodes.Add(tn);
                }
                else
                {
                    tnRoot.Nodes.Add(tn);
                }

                trv.EndUpdate();
                Cursor.Current = Cursors.Default;


            }

        }

        private void SaveDiagramFsm(int modelID)
        {

            foreach (TreeNode tn in tnRoot.Nodes)
                SaveNodeElementInfoFsm(tn, modelID);

            Presentation.Public.Routines.ShowMessageBoxFa("مدل با موفقیت ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void SaveNodeElementInfoFsm(TreeNode tn, int modelID)
        {
            FSMElementInfo fei = new FSMElementInfo();
            fei = (FSMElementInfo)tn.Tag;
            //fei.GroupName
            fei.FSModelID = modelID;
            fei.Seq = tn.Index + 1;
            fei.Balance = tn.Level + 1;
            fei.ParentId = (tn.Parent == tnRoot) ? -1 : ((FSMElementInfo)tn.Parent.Tag).ID;
            fei.ULevel = GetULevel(fei, tn); //Revised 1.3
            fei.ID = fsm.InsertFSMelement(fei);
            //  fei.ParentId = profileID;


            foreach (TreeNode tnChild in tn.Nodes)
                SaveNodeElementInfoFsm(tnChild, modelID);


        }
        private string GetULevel(FSMElementInfo fei, TreeNode tn)
        {
            if (tn.Parent == tnRoot)
            {
                return ((fei.Balance * 1000) + fei.Seq).ToString();
            }
            else
            {
                FSMElementInfo feiParent = ((FSMElementInfo)tn.Parent.Tag);
                return feiParent.ULevel + ((fei.Balance * 1000) + fei.Seq).ToString();
            }
        }

        #endregion

        #region "Time Bucket Modeling"

        #region CONST
        private const int CTE_COL_ID = 0;
        private const int CTE_COL_TB_Model_ID = 1;
        private const int CTE_COL_BucketName = 2;
        private const int CTE_COL_BucketType = 3;
        private const int CTE_COL_Length = 4;
        private const int CTE_COL_Color = 5;
        private const int CTE_COL_Sequence = 6;
        private const int CTE_COL_StartDate = 7;
        private const int CTE_COL_EndDate = 8;
        #endregion

        #region VARS

        private int maxBoxWidth, minBoxWidth;

        #endregion
        private void FillDiagramTbm(TBMInfo ti)
        {
            Helper h = new Helper();
            h.FormatDataGridView(dgvList);
            maxBoxWidth = 250;
            minBoxWidth = 50;
            ReBindTbm(ti);
            RefreshDiagramTbm();

        }

        private void ReBindTbm(TBMInfo ti)
        {
            dgvList.Columns.Clear();


            dgvList.DataSource = tbm.GetTBMelements(ti.ID);
            dgvList.Columns[CTE_COL_ID].Visible = false;
            dgvList.Columns[CTE_COL_TB_Model_ID].Visible = false;
            dgvList.Columns[CTE_COL_Color].Visible = false;
            dgvList.Columns[CTE_COL_Sequence].Visible = false; //Revised 1.3


            DataGridViewTextBoxColumn startDateCol = new DataGridViewTextBoxColumn();
            startDateCol.MinimumWidth = 100;
            startDateCol.HeaderText = "Start Date";
            dgvList.Columns.Add(startDateCol);
            DataGridViewTextBoxColumn endDateCol = new DataGridViewTextBoxColumn();
            endDateCol.MinimumWidth = 100;
            endDateCol.HeaderText = "End Date";
            dgvList.Columns.Add(endDateCol);

            DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
            tCol.MinimumWidth = 1023;
            dgvList.Columns.Add(tCol);

            foreach (DataGridViewColumn col in dgvList.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;


            ReCalcDates();
        }
        private void ReCalcDates()
        {
            DateTime dt = DateTime.Now.AddDays(-1);
            for (int i = 0; i <= dgvList.Rows.Count - 1; i++)
            {
                int len = (int)dgvList.Rows[i].Cells[CTE_COL_Length].Value;
                string type = dgvList.Rows[i].Cells[CTE_COL_BucketType].Value.ToString();

                if (type != "Irr")
                    dgvList.Rows[i].Cells[CTE_COL_StartDate].Value = dt.AddDays(1).ToString("MMMM dd, yyyy");
                else
                    dgvList.Rows[i].Cells[CTE_COL_StartDate].Value = string.Empty;

                if (type == "Day") dt = dt.AddDays(len);
                if (type == "Week") dt = dt.AddDays(len * 7);
                if (type == "Month") dt = dt.AddMonths(len);
                if (type == "Year") dt = dt.AddYears(len);

                if ((type != "ToEnd") && (type != "Irr"))
                    dgvList.Rows[i].Cells[CTE_COL_EndDate].Value = dt.ToString("MMMM dd, yyyy");
                else
                    dgvList.Rows[i].Cells[CTE_COL_EndDate].Value = string.Empty;
            }
        }
        private void RefreshDiagramTbm()
        {
            pnlTimeBucket.Controls.Clear();
            System.Windows.Forms.Control c = new System.Windows.Forms.Control();
            c.Left = 1000;
            pnlTimeBucket.Controls.Add(c);

            int elementID = -1;
            int x = 5, y = 5, w = 0, h = 70, len = 0;
            string labelType = string.Empty, labelName = string.Empty;
            string type = string.Empty;

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

                elementID = (int)dgvList.Rows[i].Cells[CTE_COL_ID].Value;
                len = (int)dgvList.Rows[i].Cells[CTE_COL_Length].Value;
                labelName = dgvList.Rows[i].Cells[CTE_COL_BucketName].Value.ToString();
                type = dgvList.Rows[i].Cells[CTE_COL_BucketType].Value.ToString();
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
                rb.Text = labelName;
                rb.AllowDrop = true;
                rb.IsArrowVisible = (type == "ToEnd");
                x = x + w;

                //
                dgvList.Rows[i].Tag = rb;
                rb.Tag = dgvList.Rows[i];

                pnlTimeBucket.Controls.Add(rb);
            }
        }
        private void SaveDiagramTBM(int ProfileID)
        {
            int curModelID = -1;
            string descr = Presentation.Public.Routines.ShowInputBox();
            TBM_DL tbdl = new TBM_DL();

            if (descr != string.Empty)
            {

                TBMInfo ti = new TBMInfo();
                ti.ProfileID = ProfileID;
                ti.ModelName = descr;

                ti.ID = tbdl.InsertTBM(ti);
                curModelID = ti.ID;
            }

            int i = 1;
            foreach (DataGridViewRow dgvr in dgvList.Rows)
            {
                DataRow dr = ((DataRowView)dgvr.DataBoundItem).Row;

                TBMElementInfo tei = new TBMElementInfo();
                tbm.CloneX(dr, tei, ECloneXdir.DR2Info);

                tei.Sequence = i++;
                if (curModelID != -1)
                {
                    tei.ModelID = curModelID;
                    tbm.InsertTBMelement(tei);
                }
            }
            tbm.InitTBM(curModelID);

            Presentation.Public.Routines.ShowMessageBoxFa("مدل با موفقیت ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        #endregion

        #region "Time Bucket Fill Modeling"

        #region CONST

        private const int CTE_COL_CBME_ID = 0;
        private const int CTE_COL_CBME_GroupName = 1;
        private const int CTE_COL_CBME_Balance = 2;

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
        private void FillDiagramCbm(CBMInfo ci)
        {
            Helper h = new Helper();
            h.FormatDataGridView(dgvList);
            ReBindCbm(ci);
        }

        private int suspendedCount = 0;
        private void ReBindCbm(CBMInfo ci)
        {

            dgvList.Columns.Clear();


            int modelID = ci.ID;
            dgvList.DataSource = new DAL.CbmDataSet().GetCBMElements(modelID, false, true, out suspendedCount);

            //Revised - 1.1
            dgvList.Columns[2].DefaultCellStyle.Format = "###,###.##";
            dgvList.Columns[CTE_COL_CBME_GroupName].Frozen = true;
            dgvList.Columns[CTE_COL_CBME_Balance].Frozen = true;

            DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
            tCol.MinimumWidth = 1023;
            dgvList.Columns.Add(tCol);

            dgvList.Columns[CTE_COL_CBME_ID].Visible = false;


        }

        private void SaveDiagramCBM(int profileID)
        {
            int curModelID = -1;

            CBMInfo ci = new CBMInfo();
            ci = (CBMInfo)trvUsers.SelectedNode.Tag;

            DataRow dr = fsm.GetFSM(ci.FSModelID);
            FSMInfo fi = new FSMInfo();
            fsm.CloneX(dr, fi, ECloneXdir.DR2Info);

            DataRow drtbm = tbm.GetTBM(ci.TBModelID);
            TBMInfo ti = new TBMInfo();
            tbm.CloneX(drtbm, ti, ECloneXdir.DR2Info);

            int FSModelID = CheckFSM(ci.FSModelID, ci.ProfileID, profileID);
            int TBModelID = CheckTBM(ci.TBModelID, ci.ProfileID, profileID);

            if (FSModelID == -1)
            {
                MessageBox.Show(fi.ModelName + "  لطفا مدل صورت وضعیت مالی مربوط به این نمایه را وارد كنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (TBModelID == -1)
                {
                    MessageBox.Show(ti.ModelName + "لطفا مدل بسته زمانی مربوط به این نمایه را وارد كنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    // Reconcile
                    // GC_DL ct = new GC_DL();
                    // return ct.InsertInstance(groupName, ctID, profileID);

                    string descr = Presentation.Public.Routines.ShowInputBox();
                    CBM_DL cbmdl = new CBM_DL();
                    if (descr != string.Empty)
                    {
                        ci.ModelName = descr;
                        ci.TBModelID = TBModelID;
                        ci.FSModelID = FSModelID;
                        ci.ProfileID = profileID;
                        ci.ID = cbmdl.InsertCBM(ci);

                        curModelID = ci.ID;

                        DataTable dtCBMEMy = new DAL.CbmDataSet().GetCBMElements(curModelID, false, true, out suspendedCount);
                        foreach (DataRow drCBMEMy in dtCBMEMy.Rows)
                        {
                            CBMElementInfo cei = new CBMElementInfo();
                            cbm.CloneX(drCBMEMy, cei, ECloneXdir.DR2Info);

                            // int CBElementID = int.Parse(drCBM["ID"].ToString());
                            // string GroupName = drCBM["GroupName"].ToString();
                            InsertCbmTBElement(cei.ID, TBModelID, cei.GroupName);

                        }
                    }
                }
            }



        }

        private void InsertCbmTBElement(int CBModelIDMy, int TBModelIDMy, string GroupNameMy)
        {
            int TBElementSeqMy = -1;
            int Rowindex = -1;

            for (int j = 0; j < dgvList.Rows.Count; j++)
            {
                if (dgvList[1, j].Value.ToString() == GroupNameMy)
                { Rowindex = j; break; }
            }
            if (Rowindex != -1)
            {
                for (int i = 3; i < dgvList.Columns.Count - 1; i++)
                {
                    string BucketName = dgvList.Columns[i].HeaderText;
                    decimal percentValue = Presentation.Public.Routines.GetNumericValue(dgvList[i, Rowindex].Value.ToString(), out percentValue);

                    DataTable dtTBEMy = tbm.GetTBMelements(TBModelIDMy);

                    foreach (DataRow drTBEMy in dtTBEMy.Rows)
                    {
                        TBMElementInfo tbei = new TBMElementInfo();
                        tbm.CloneX(drTBEMy, tbei, ECloneXdir.DR2Info);

                        if (tbei.BucketName == BucketName)

                        { TBElementSeqMy = tbei.Sequence; break; }
                    }

                    if (percentValue != 0)
                        cbm.ChangeValue(CBModelIDMy, TBModelIDMy, TBElementSeqMy, percentValue);
                }
            }

        }


        private int CheckFSM(int FSModelID, int SelectedProfile, int MyProfile)
        {
            bool FSM = false;
            FSM_DL fsm_dl = new FSM_DL();

            int FSModelID_My = -1;

            DataTable dtFSESelected = fsm_dl.GetFSMelements(FSModelID);
            DataTable dtFSMy = fsm_dl.GetFSMs(MyProfile);

            foreach (DataRow drFSESelected in dtFSESelected.Rows)
            {

                FSMElementInfo feiSelected = new FSMElementInfo();
                fsm.CloneX(drFSESelected, feiSelected, ECloneXdir.DR2Info);

                foreach (DataRow drFSMy in dtFSMy.Rows)
                {
                    FSMInfo fsMy = new FSMInfo();
                    fsm.CloneX(drFSMy, fsMy, ECloneXdir.DR2Info);

                    DataTable dtFSEMy = fsm_dl.GetFSMelements(fsMy.ID);
                    foreach (DataRow drFSEMy in dtFSEMy.Rows)
                    {
                        FSMElementInfo feiMy = new FSMElementInfo();
                        fsm.CloneX(drFSEMy, feiMy, ECloneXdir.DR2Info);


                        if (feiMy.GroupName == feiSelected.GroupName)

                        { FSModelID_My = feiMy.FSModelID; FSM = true; break; }
                        else
                            if (feiMy.GroupTitle == feiSelected.GroupTitle)
                            { FSM = true; break; }
                            else
                            { FSM = false; }
                    }

                }
                if (!FSM) break;

            }
            return FSModelID_My;
        }

        private int CheckTBM(int tbModelID, int SelectedProfile, int MyProfile)
        {
            bool TBM = false;
            TBM_DL tbm_dl = new TBM_DL();

            int tbModelID_My = -1;

            DataTable dtTBESelected = tbm_dl.GetTBMelements(tbModelID);
            DataTable dtTBMy = tbm_dl.GetTBMs(MyProfile);

            foreach (DataRow drTBESelected in dtTBESelected.Rows)
            {
                TBMElementInfo teiSelected = new TBMElementInfo();
                tbm.CloneX(drTBESelected, teiSelected, ECloneXdir.DR2Info);

                foreach (DataRow drTBMy in dtTBMy.Rows)
                {
                    TBMInfo tbMy = new TBMInfo();
                    tbm.CloneX(drTBMy, tbMy, ECloneXdir.DR2Info);

                    DataTable dtTBEMy = tbm_dl.GetTBMelements(tbMy.ID);

                    foreach (DataRow drTBEMy in dtTBEMy.Rows)
                    {

                        TBMElementInfo teiMY = new TBMElementInfo();
                        tbm.CloneX(drTBEMy, teiMY, ECloneXdir.DR2Info);

                        if (teiSelected.BucketName == teiMY.BucketName && teiSelected.BucketType == teiMY.BucketType && teiSelected.BucketLength == teiMY.BucketLength)
                        { tbModelID_My = teiMY.ModelID; TBM = true; break; }
                        else
                        { TBM = false; }
                    }

                }
                if (!TBM) break;

            }
            return tbModelID_My;
        }



        #endregion

        #region "Credit Risk"
        private void FillDiagramCrp(CRPMInfo hi)
        {
            dgvList.Columns.Clear();
            DataTable dt = crp.GetHRs(hi.ID);
            dgvList.DataSource = dt;

            Helper h = new Helper();
            h.FormatDataGridView(dgvList);
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvList.Columns[CRP.CTE_Alias_HR_ID].Visible = false;
            dgvList.Columns[CRP.CTE_Alias_HR_ModelID].Visible = false;
            dgvList.Columns[CRP.CTE_Alias_HR_CollatTypeID].Visible = false;
            dgvList.Columns[CRP.CTE_Alias_HR_CollatTypeDescr].Width = 150;
            dgvList.Columns[CRP.CTE_Alias_HR_Val].Width = 100;

            dgvList.Columns[CRP.CTE_Alias_HR_CollatTypeDescr].HeaderText = "مشخصات نوع وثیقه";
            dgvList.Columns[CRP.CTE_Alias_HR_Val].HeaderText = "مقدار";
        }
        private void SaveDiagramCRP(int profileID)
        {

            CRPMInfo ci = new CRPMInfo();
            CRP_DL crdl = new CRP_DL();
            decimal Haircut;
            ci = (CRPMInfo)trvUsers.SelectedNode.Tag;

            string descr = Presentation.Public.Routines.ShowInputBox();
            if (descr != string.Empty)
            {

                CRPMInfo cin = new CRPMInfo();
                cin.ParamL = ci.ParamL;
                cin.ParamCL = ci.ParamCL;
                cin.GroupBy = ci.GroupBy;
                cin.ModelName = descr;
                //  cin.ProfileID = GlobalInfo.ProfileID;
                cin.ProfileID = profileID;


                int modelID = CRP_DL.InsertCRPM(cin);

                DataTable dt = new DataTable();
                dt = crp.GetHRs(ci.ID);

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["Haircut Ratio"].ToString() != string.Empty)
                    { Haircut = decimal.Parse(dr["Haircut Ratio"].ToString()); }
                    else
                    { Haircut = 100; }
                    //  Presentation.Public.Routines.GetNumericValue(dr[CRP.CTE_Alias_HR_Val].ToString(), out Haircut);
                    int Collat_Type = Presentation.Public.Routines.GetNumericValue(dr["CollatTypeID"].ToString(), out Collat_Type);
                    crp.InsertHR(modelID, Collat_Type, Haircut);
                }

                DataTable dtAV = new DataTable();
                //dtAV = crp.GetAVs(ci.ID);
                //foreach (DataRow dr in dtAV.Rows)
                //{
                //    decimal ValFrom, ValTo;
                //    Presentation.Public.Routines.GetNumericValue(dr[CRP.CTE_Alias_AV_From].ToString(), out ValFrom);
                //    Presentation.Public.Routines.GetNumericValue(dr[CRP.CTE_Alias_AV_To].ToString(), out ValTo);
                //    crp.InsertAV(modelID, dr[CRP.CTE_Alias_AV_Descr].ToString(), ValFrom, ValTo);
                //}


                //crp.InsertHR(modelID,,a);

                Presentation.Public.Routines.ShowMessageBoxFa("مدل با موفقیت ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void btnExport_Click(object sender, EventArgs e)
        {
            string strSelectedUser = string.Empty;
            string strSelectedActProfile = string.Empty;
            int intSelectedProfileID;
            frmModelManagementUser frmMUser = new frmModelManagementUser();
            if(trvUsers.SelectedNode==null)
            {
               Presentation.Public.Routines.ShowErrorMessageFa("خطا", "کاربری انتخاب نشده است.", Public.MyDialogButton.OK);
                return;
            }
            if(trvUsers.SelectedNode.Parent==null)
            {
                Presentation.Public.Routines.ShowErrorMessageFa("خطا", "نوع مدل انتخاب نشده است",Public.MyDialogButton.OK);
                return;
            }
            if(trvUsers.SelectedNode.Parent.Parent==null)
            {
               Presentation.Public.Routines.ShowErrorMessageFa("خطا", "مدلی انتخاب نشده است", Public.MyDialogButton.OK);
                return;
            }

            frmMUser.SourceUser = trvUsers.SelectedNode.Parent.Parent.Text;
            if (frmMUser.ShowDialog() == DialogResult.OK)
            {
                strSelectedUser = frmMUser.User;
                strSelectedActProfile = frmMUser.ActProfile;
                intSelectedProfileID = frmMUser.ActProfileId;

                if (trvUsers.SelectedNode.Parent.Text == strSelectedActProfile)
                { MessageBox.Show("مدل در نمايه شما موجود است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {

                    if (trvUsers.SelectedNode.Parent.Parent.Text == strSelectedActProfile)
                    { MessageBox.Show("مدل در نمايه شما موجود است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                    else
                    {
                        if (trvUsers.SelectedNode.Tag is AccountGroupInfo)
                        { Cursor.Current = Cursors.WaitCursor; SaveDiagramAGM(intSelectedProfileID); Cursor.Current = Cursors.Default; }

                        if (trvUsers.SelectedNode.Tag is FSMInfo)
                        {
                            FSMInfo fi = new FSMInfo();
                            FSM_DL fsmdl = new FSM_DL();

                            fi = (FSMInfo)trvUsers.SelectedNode.Tag;

                            if (!CheckAGM(fi.ProfileID, intSelectedProfileID))
                            {
                                MessageBox.Show(".لطفا مدل گروههای حساب مربوط به این نمایه را وارد كنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                string descr = Presentation.Public.Routines.ShowInputBox();
                                if (descr != string.Empty)
                                {
                                    fi.ModelName = descr;
                                    fi.ProfileID = intSelectedProfileID;

                                    fi.ID = fsmdl.InsertFSM(fi);

                                    //fi.ID = fsm.InsertFSM(fi);
                                    curModelID = fi.ID;
                                }
                                if (curModelID != -1)
                                    SaveDiagramFsm(curModelID);

                            }
                        }

                        if (trvUsers.SelectedNode.Tag is TBMInfo)
                            SaveDiagramTBM(intSelectedProfileID);

                        if (trvUsers.SelectedNode.Tag is CBMInfo)
                            SaveDiagramCBM(intSelectedProfileID);

                        if (trvUsers.SelectedNode.Tag is CRPMInfo)
                            SaveDiagramCRP(intSelectedProfileID);


                    }
                }



            }
        }


        private bool CheckAGM(int SelectedProfile, int MyProfile)
        {
            bool AGM = false;
            AGM_DL dl = new AGM_DL();

            DataTable dtAGMSelectedProfile = dl.GetAccountGroups(SelectedProfile);
            DataTable dtAGMMyProfile = dl.GetAccountGroups(MyProfile);


            if (dtAGMMyProfile.Rows.Count < dtAGMSelectedProfile.Rows.Count)
            {
                AGM = false;
            }
            else
            {
                foreach (DataRow drAGMSelectedProfile in dtAGMSelectedProfile.Rows)
                {
                    foreach (DataRow drAGMMyProfile in dtAGMMyProfile.Rows)
                    {
                        AGM = false;
                        if (drAGMSelectedProfile["GroupName"].ToString() == drAGMMyProfile["GroupName"].ToString())
                        {
                            //if (CheckAGs(SelectedProfile, MyProfile, drAGMSelectedProfile["GroupName"].ToString(), drAGMMyProfile["GroupName"].ToString()))
                            //{ AGM = true; break; }
                            //else
                            //{ AGM = false; }
                            { AGM = true; break; }

                        }
                    }
                    if (!AGM) break;

                }
            }
            return AGM;
        }

        private bool CheckAGs(int SelectedProfile, int MyProfile, string GroupNameSelected, string GroupNameMy)
        {
            bool AGs = false;
            AGM_DL dl = new AGM_DL();
            DataTable dtAGMSelectedProfile = dl.GetAGs(SelectedProfile, GroupNameSelected);
            DataTable dtAGMyProfile = dl.GetAGs(MyProfile, GroupNameMy);

            if (dtAGMSelectedProfile.Rows.Count == dtAGMyProfile.Rows.Count)
            {
                foreach (DataRow dr1 in dtAGMyProfile.Rows)
                {
                    AGs = false;
                    foreach (DataRow dr2 in dtAGMSelectedProfile.Rows)
                    {
                        if (dr1["AccountingName"].ToString() == dr2["AccountingName"].ToString())
                        {
                            AGs = true; break;
                        }
                        else
                        { AGs = false; }
                    }
                    if (!AGs) break;
                }
            }
            return AGs;

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

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            FillUsers();
        }


        #region Remove BackColor

        private void ClearBackColor()
        {

            TreeNodeCollection nodes = trvUsers.Nodes;

            foreach (TreeNode n in nodes)
            {

                ClearRecursive(n);

            }

        }

        private void ClearRecursive(TreeNode treeNode)
        {

            foreach (TreeNode tn in treeNode.Nodes)
            {

                tn.BackColor = Color.White;

                ClearRecursive(tn);

            }

        }

        #endregion
        public void DoPrint()
        {
            //Empty Print
        }

        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "ModelManagement";
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

