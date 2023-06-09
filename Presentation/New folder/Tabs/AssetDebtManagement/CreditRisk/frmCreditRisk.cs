using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Dundas.Charting.WinControl;
using ERMS.Logic;
using ERMS.Model;
using ERMSLib;
using Presentation.Public;
using ProgressBox = Presentation.Public.ProgressBox;


namespace Presentation.Tabs.CreditRisk
{
    public partial class frmCreditRisk : BaseForm, IPrintable
    {
        #region CONST
        private const int CTE_PageLength = 100;
        #endregion

        #region VARS
        bool pass = false;
        private CRP crp;
        private bool bDirty = false;
        private int curModelID = -1;
        private DataGridView dgvPrint;
        DialogResult dlgResult;
        OpenFileDialog dlg;
        DataSet dataSetPDExcel;
        double RialVolumel = 0; decimal cl = 0;
        decimal AlphaLevel = 0; int LossCount = 0;
        #endregion
       
        public frmCreditRisk()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
            
        }

        private void frmCreditRisk_Load(object sender, EventArgs e)
        {
            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

            fdpStartDate.SelectedDateTime = DateTime.Now;
            fdpStartDate.ResetSelectedDateTime();
            Init();
            splitContainer7.Panel2Collapsed = true;

            cmbSubGroupsChart.Items.Add(10003412);
            cmbSubGroupsChart.Items.Add(10006409);
            cmbSubGroupsChart.Items.Add(10006401);
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
            CommandModelSave(curModelID, true);
        }
        private void tsbImport_Click(object sender, EventArgs e)
        {
            //Import();
        }
        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
            {
                if (lsvModel.SelectedItems.Count > 0)
                {
                    if (bDirty)
                    {
                        if (Presentation.Public.Routines.ShowMessageBoxFa("آيا مدل ذخیره شود ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                            CommandModelSave(curModelID, false);

                    }
                
                    var ci = (CRPMInfo)lsvModel.SelectedItems[0].Tag;
                    txtAmountL.Text = (ci.ParamL == -1) ? string.Empty : ci.ParamL.ToString();
                    txtAmountCL.Text = (ci.ParamCL == -1) ? string.Empty : ci.ParamCL.ToString();
                    txtAlphaLevel.Text = (ci.AlphaLevel == -1) ? string.Empty : ci.AlphaLevel.ToString();
                    txtLossUnit.Text = (ci.LossCount == -1) ? string.Empty : ci.LossCount.ToString();
                    chkEnableGrouping.Checked = ci.IsGrouped;
                    //cmbGroupBy.SelectedIndex = ci.GroupBy;
                    fdpStartDate.SelectedDateTime = ci.StartDate;

                   
                    curModelID = ci.ID;
               
                    FillHR(curModelID);
                    //FillAV(curModelID);
                   
                    return;
                  
                }
           }

            scGroupResultContainer.Panel2Collapsed = !chkEnableGrouping.Checked;
        }
        private void chkShowDetail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowDetail.Checked)
                splitContainer7.Panel2Collapsed = false;
            else
                splitContainer7.Panel2Collapsed = true;
        }
        private void cmbGroupBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroupBy.SelectedIndex == -1)
                return;
            
            
            if (!CheckDataAvailability())
            {
                Routines.ShowMessageBoxFa("در تاریخ مورد نظر داده ای وجود ندارد، لطفا تاریخ دیگری انتخاب کنید", "داده", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ProgressBox.Show();

            splitContainer_GroupResult.Panel2Collapsed = true;
            Presentation.Public.Routines.GetNumericValue(txtAmountL.Text, out RialVolumel);
            int GroupBy = cmbGroupBy.SelectedIndex;
            // dar inja chon mikhahim har subgroup hajem riali khodesh ro dashte bashe, ebteda be soorate kheili sade
            // CRP_MODEL_DETAILS_NNP ra por mikonim ke group har contract moshakhas shode, va sepas ba tavajoh 
            // be an baraye har subgroup hajme riali hesab shavad
            DateTime StartDate = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(fdpStartDate.Text);
            DataTable dtGroups = crp.GetResultGroupsNNP(curModelID, 0, 0, GroupBy, RialVolumel, StartDate, chkManualPD.Checked, chkWithoutLG.Checked);

            lblGroup.Text = cmbGroupBy.Text;
            lblGroupChart.Text = cmbGroupBy.Text;

            cmbSubGroups.DataSource = dtGroups;
            cmbSubGroups.DisplayMember = "Group_Desc";
            cmbSubGroups.ValueMember = "GroupId";

            cmbSubGroupsChart.DataSource = dtGroups;
            cmbSubGroupsChart.DisplayMember = "Group_Desc";
            cmbSubGroupsChart.ValueMember = "GroupId";

            dgvGroup.DataSource = dtGroups;
            dgvGroup.Columns[0].Visible = false;
            dgvGroup.Columns[1].Visible = false;
            dgvGroup.Columns["Group_Desc"].HeaderText = cmbGroupBy.Text;
            dgvResult.DataSource = null;
            var h = new Helper();
            h.FormatDataGridView(dgvGroup);
            dgvGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvDetail.DataSource = null;
            ProgressBox.Hide();

        }
        private void cmbChartGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ProgressBox.Show();
            if (cmbChartGroup.SelectedValue is int)
            {
                if (cmbWhatToShow.Text != "")
                {

                    int groupID = (int)cmbChartGroup.SelectedValue;
                    RefreshChart(groupID);
                }
            }
            //ProgressBox.Hide();
        }
        private void CommandModelNew()
        {
         

            string descr = Presentation.Public.Routines.ShowInputBox();
            if (descr != string.Empty)
            {
                ListViewItem lvi = new ListViewItem();
                CRPMInfo ci = new CRPMInfo();
                lvi.Text = descr;
                lvi.Tag = ci;
                lsvModel.Items.Add(lvi);

                //                
                ci.ModelName = descr;
                ci.ID = crp.InsertCRPM(ci);
                curModelID = ci.ID;

                lvi.Selected = true;
            }
            //if (bDirty)
            //{
            //    if (Presentation.Public.Presentation.Public.Routines.ShowMessageBoxFa("آيا مدل ذخیره شود ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        CommandModelSave(curModelID, true);

            //}
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
                    CRPMInfo ci = (CRPMInfo)lvi.Tag;
                    ci.ModelName = descr;
                    crp.UpdateCRPM(ci);
                }
            }
        }
        private void CommandModelRemove()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("مدل انتخاب شده و تمامی مدلهای مرتبط به آن حذف خواهد شد. آيا مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem lvi = lsvModel.SelectedItems[0];
                    CRPMInfo ti = (CRPMInfo)lvi.Tag;

                    if (Presentation.Miscs.CheckDependents.Show(CheckDep.CHECK_TBM, ti.ID.ToString()) == DialogResult.Cancel)
                        return;

                    lvi.Remove();
                    crp.DeleteCRPM(ti.ID);
                }
            }
        }
        private void CommandModelSave(int modelID, bool bMsg)
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                //int l = 0; decimal cl = 0; 
                //Presentation.Public.Routines.GetNumericValue(txtAmountL.Text, out l);
                //Presentation.Public.Routines.GetNumericValue(txtAmountCL.Text, out cl);

                Presentation.Public.Routines.GetNumericValue(txtAmountL.Text, out RialVolumel);
                Presentation.Public.Routines.GetNumericValue(txtAmountCL.Text, out cl);
                Presentation.Public.Routines.GetNumericValue(txtAlphaLevel.Text, out AlphaLevel);
                Presentation.Public.Routines.GetNumericValue(txtLossUnit.Text, out LossCount);

                CRPMInfo ci = (CRPMInfo)lsvModel.SelectedItems[0].Tag;
                ci.ParamL = RialVolumel;
                ci.ParamCL = cl;
                ci.AlphaLevel = AlphaLevel;
                ci.LossCount = LossCount;
                ci.IsGrouped = chkEnableGrouping.Checked;
                ci.GroupBy = cmbGroupBy.SelectedIndex;
                ci.StartDate = fdpStartDate.SelectedDateTime;

                crp.UpdateCRPM(ci);

                //SaveAV(modelID);
                SaveHR(modelID);

               if (bMsg)
                    Presentation.Public.Routines.ShowMessageBoxFa("مدل با موفقیت ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bDirty = false;
            }
        }
        private int GroupID
        {
            get
            {
                int groupID = -1;
                if (dgvGroup.CurrentRow != null)
                {
                    object objGroupID = dgvGroup.CurrentRow.Cells[0].Value;
                    groupID = (objGroupID == DBNull.Value) ? -1 : Convert.ToInt32(objGroupID);
                }

                return groupID;
            }
        }
        private decimal RFME
        {
            get
            {
                decimal rfme = 0;
                //if (dgvResult.CurrentRow != null)
                //{
                //    object objRFME = dgvResult.CurrentRow.Cells[1].Value;
                //    rfme = (objRFME == DBNull.Value) ? -1 : Convert.ToDecimal(objRFME);

                //}
                //else
                //{
                //    Presentation.Public.Routines.ShowMessageBoxFa("مدل انتخاب شده شما، هيچ جزئياتی ندارد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                return rfme;
            }
        }
        private void Init()
        {
            crp = new CRP();

            //cmbGroupBy.AddItemsRange(new string[] { "نوع قرارداد", "بخش اقتصادی", "نوع مشتری", "گروه مشتری", "وضعیت قرارداد", "شعبه","نوع اصلی قرارداد تسهیلات","وضعیت قرارداد تسهیلات" });
            //cmbGroupBy.AddItemsRange(new string[] { "نوع قرارداد", "بخش اقتصادی", "نوع مشتری", "گروه مشتری", "وضعیت قرارداد", "شعبه", "نوع کلی قرارداد", "نوع اصلی قرارداد تسهیلات", "وضعیت قرارداد تسهیلات" });
            cmbGroupBy.AddItemsRange(new string[] { "نوع قرارداد", "بخش اقتصادی", "نوع مشتری", "گروه مشتری", "استان", "شعبه", "نوع کلی قرارداد", "نوع اصلی قرارداد", "وضعیت قرارداد"});
            
            tabParam.TabPages.Remove(tpAV);
            chkEnableGrouping.Checked = false;
            //cmbGroupBy.Enabled = false;

            chkShowDetail.Checked = false;
            
            scGroupResult.Panel1Collapsed = true;
            scGroupResultContainer.Panel2Collapsed = true;

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;

            //ddChart.Legends.Clear();

            FillModel();
        }

        private void FillModel()
        {
            DataTable dt = crp.GetCRPMs();
            foreach (DataRow dr in dt.Rows)
            { 
                CRPMInfo ci = new CRPMInfo();
                crp.CloneX(dr, ci, ECloneXdir.DR2Info);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = ci.ModelName;
                lvi.Tag = ci;

                lsvModel.Items.Add(lvi);
            }
        }
        private void FillHR(int modelID)
        {
            dgvHR.Columns.Clear();

            DataTable dt = crp.GetHRs(modelID);
            dgvHR.DataSource = dt;

            Helper h = new Helper();
            h.FormatDataGridView(dgvHR);
            dgvHR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
            tCol.MinimumWidth = 1023;
            tCol.Name = "Dummy";
            tCol.HeaderText = string.Empty;
            dgvHR.Columns.Add(tCol);

            dgvHR.ReadOnly = false;
            dgvHR.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvHR.Columns[CRP.CTE_Alias_HR_ID].Visible = false;
            dgvHR.Columns[CRP.CTE_Alias_HR_ModelID].Visible = false;
            dgvHR.Columns[CRP.CTE_Alias_HR_CollatTypeID].Visible = false;

            dgvHR.Columns[CRP.CTE_Alias_HR_CollatTypeDescr].ReadOnly = true;
            dgvHR.Columns[CRP.CTE_Alias_HR_CollatTypeDescr].Width = 150;
            dgvHR.Columns[CRP.CTE_Alias_HR_Val].Width = 100;

            dgvHR.Columns[CRP.CTE_Alias_HR_CollatTypeDescr].HeaderText = "مشخصات نوع وثیقه";
            dgvHR.Columns[CRP.CTE_Alias_HR_Val].HeaderText = "مقدار";


        }
        
        //private void FillAV(int modelID)
        //{
        //    if (!tabParam.TabPages.Contains(tpAV))
        //        return;

        //    dgvAV.Columns.Clear();

        //    DataTable dt = crp.GetAVs(modelID);
        //    dgvAV.DataSource = dt;

        //    dgvAV.Columns[CRP.CTE_Alias_AV_Descr].HeaderText = "عنوان";
        //    dgvAV.Columns[CRP.CTE_Alias_AV_From].HeaderText = "از";
        //    dgvAV.Columns[CRP.CTE_Alias_AV_To].HeaderText = "تا";

        //    Helper h = new Helper();
        //    h.FormatDataGridView(dgvAV);
        //    dgvAV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

        //    DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
        //    tCol.MinimumWidth = 1023;
        //    tCol.Name = "Dummy";
        //    tCol.HeaderText = string.Empty;
        //    dgvAV.Columns.Add(tCol);

        //    dgvAV.ReadOnly = false;
        //    dgvAV.AllowUserToAddRows = true;
        //    dgvAV.SelectionMode = DataGridViewSelectionMode.CellSelect;
        //    dgvAV.Columns[CRP.CTE_Alias_AV_ID].Visible = false;
        //    dgvAV.Columns[CRP.CTE_Alias_AV_ModelID].Visible = false;

        //    dgvAV.Columns[CRP.CTE_Alias_AV_Descr].ReadOnly = false;
        //    dgvAV.Columns[CRP.CTE_Alias_AV_Descr].Width = 150;
        //    dgvAV.Columns[CRP.CTE_Alias_AV_From].Width = 100;
        //    dgvAV.Columns[CRP.CTE_Alias_AV_To].Width = 100;
        //}
        
        private void SaveHR(int modelID)
        {
            foreach (DataRow dr in (dgvHR.DataSource as DataTable).Rows)
            {
                if (dr.RowState == DataRowState.Modified)
                {
                    int id = (int)dr[CRP.CTE_Alias_HR_ID];
                    int ModelId = (int)dr[CRP.CTE_Alias_HR_ModelID];
                    decimal val = (decimal)dr[CRP.CTE_Alias_HR_Val];

                    crp.UpdateHR(id, val);
                }
            }
        }
        
        //private void SaveAV(int modelID)
        //{
        //    if (!tabParam.TabPages.Contains(tpAV))
        //        return;

        //    foreach (DataRow dr in (dgvAV.DataSource as DataTable).Rows)
        //    {
        //        int id = dr.IsNull(CRP.CTE_Alias_AV_ID) ? -1 : (int)dr[CRP.CTE_Alias_AV_ID];
        //        string descr = dr.IsNull(CRP.CTE_Alias_AV_Descr) ? string.Empty : dr[CRP.CTE_Alias_AV_Descr].ToString();
        //        decimal valFrom = dr.IsNull(CRP.CTE_Alias_AV_From) ? 0 : (decimal)dr[CRP.CTE_Alias_AV_From];
        //        decimal valTo = dr.IsNull(CRP.CTE_Alias_AV_To) ? 0 : (decimal)dr[CRP.CTE_Alias_AV_To];

        //        if (dr.RowState == DataRowState.Added)
        //        {
        //            crp.InsertAV(curModelID, descr, valFrom, valTo);
        //        }

        //        if (dr.RowState == DataRowState.Modified)
        //        {
        //            crp.UpdateAV(id, descr, valFrom, valTo);
        //        }
        //    }

        //    //Refresh
        //    FillAV(curModelID);
        //}
        
        private void DoProcess(int GroupBy)
        {
            SaveHR(curModelID);
            //SaveAV(curModelID);
            
            Presentation.Public.Routines.GetNumericValue(txtAmountL.Text, out RialVolumel);
            Presentation.Public.Routines.GetNumericValue(txtAmountCL.Text, out cl);
            Presentation.Public.Routines.GetNumericValue(txtAlphaLevel.Text, out AlphaLevel);
            Presentation.Public.Routines.GetNumericValue(txtLossUnit.Text, out LossCount);
            double el = 0, ec = 0, rcg = 0, STDt = 0;
            int groupBy = cmbGroupBy.SelectedIndex;

            if (AlphaLevel > cl)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("مقدار سطح آلفا نمی تواند کوچکتر از سطح اطمینان باشد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                       
            int numResultItems = 0;
                       
            try
            {
                ProgressBox.Show();
                // Mohasebe EL va EC baraye RialVolume, CL, L va ALpha moshakhas
                DataTable dtDetail = new DataTable();
                double ECTotal =  lblTotalEC.Text.Equals("...") ? 0 : double.Parse(lblTotalEC.Text);
                DateTime StartDate = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(fdpStartDate.Text);

                dtDetail = crp.CreateCRP(curModelID, RialVolumel, cl, AlphaLevel, LossCount, GroupBy, 
                                            (DataTable)dgvGroup.DataSource, StartDate, chkManualPD.Checked, ECTotal, chkWithoutLG.Checked,
                                                out el, out ec, out rcg, out STDt);
                if (GroupBy == -1)
                {
                    if (ec < 0)
                        ec = 0;
                        
                    lblTotalEC.Text = ec.ToString("###,###.###");
                    lblVaR.Text = (ec + el).ToString("###,###.###");
                    lblEL.Text = (el).ToString("###,###.###");
                    lblStdVar.Text = (STDt).ToString("###,###.###");
                    //dgvDetail.DataSource = dtDetail;
                    
                    //Chart Total

                    DataTable dtChartTotal = new DataTable();
                    dtChartTotal = crp.GetDT_CRP_Model_PValues_Chart(curModelID, cl, AlphaLevel, LossCount, GroupBy, RialVolumel);
                    chtTotal.Series[0].ValueMembersY = "P";
                    chtTotal.Series[0].ValueMemberX = "Column1";
                    chtTotal.Series[0].ToolTip = "#VAL      #AXISLABEL";
                    chtTotal.DataSource = dtChartTotal;
                    chtTotal.DataBind();

                    ///

                    DataTable dtVaR = new DataTable();
                    dtVaR.Columns.Add("AlphaLevel",typeof(decimal));
                    dtVaR.Columns.Add("VaR", typeof(double));
                    dtVaR.Columns.Add("EC", typeof(double));
                    //dtVaR.Columns["AlphaLevel"].Caption = "AlphaLevel";
                    //dtVaR.Columns["VaR"].Caption = "VaR";

                    var AlphaArray = new[] { 50, 75, 90, 95, 99, 99.5, 99.75, 99.9 };
                    foreach (decimal alpha in AlphaArray)
                        if (alpha <= cl)
                        {
                            crp.Calculate_CRP_EC_ByGroupID(curModelID, RialVolumel, cl, LossCount, alpha, GroupBy, StartDate, chkManualPD.Checked, ECTotal,
                                                                out el, out ec, out rcg, out STDt);
                            double VaR = ec + el;
                            //if(pass)
                            //    MessageBox.Show("ec: " + ec.ToString() + "   el: " + el.ToString() + "        Var: " + VaR.ToString());
                            DataRow dr;
                            dr = dtVaR.NewRow();
                            dr["AlphaLevel"] = alpha.ToString();
                            dr["VaR"] = VaR.ToString();
                            if (ec < 0)
                                ec = 0;
                            dr["EC"] = ec.ToString();
                            dtVaR.Rows.Add(dr);
                        }
                    dgvVaR.DataSource = dtVaR;
                    dgvVaR.Columns["AlphaLevel"].HeaderText = "سطح آلفا";
                    dgvVaR.Columns["VaR"].HeaderText = " VaR ";
                    dgvVaR.Columns["EC"].HeaderText = "سرمایه اقتصادی";
                    dgvVaR.Refresh();
                    dgvVaR.Update();

                    Helper h = new Helper();
                    h.FormatDataGridView(dgvVaR);
                    dgvVaR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    
                    // آخر سر دوباره برای آلفای مورد نظر حساب می کنیم که مقادیر Var 
                    // برای هر قرارداد بر اساس آلفای مورد نظر باشد
                    crp.Calculate_CRP_EC_ByGroupID(curModelID, RialVolumel, cl, LossCount, AlphaLevel, GroupBy, StartDate, chkManualPD.Checked, ECTotal, out el, out ec, out rcg, out STDt);


                    RefreshPagingCombos(GroupBy, 0);
                }
                else
                {                   
                    dgvGroupDetail.DataSource = dtDetail;
                    dgvGroupDetail.Columns["Group_Desc"].HeaderText = cmbGroupBy.Text;
                    splitContainer_GroupResult.Panel1Collapsed = true;

                    Helper h = new Helper();
                    h.FormatDataGridView(dgvGroupDetail);
                    dgvGroupDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }

            //if (!chkEnableGrouping.Checked)
            //{
            //    cmbResultPage.BeginUpdate();
            //    cmbResultPage.Items.Clear();
            //    for (int i = 0; i <= numResultItems / CTE_PageLength; i++)
            //    {
            //        string fromIndex = (i * CTE_PageLength + 1).ToString();
            //        string toIndex = (i * CTE_PageLength + CTE_PageLength).ToString();
            //        cmbResultPage.Items.Add((i + 1).ToString());
            //    }
            //    cmbResultPage.EndUpdate();
            //}

            

            ////Chart Group
            //DataTable dtGroups4Chart = dtGroups.Copy();
            ////DataRow dr = dtGroups4Chart.NewRow();
            ////dr[CRP.CTE_Alias_Group_GroupID] = -1;
            ////dr[CRP.CTE_Alias_Group_GroupDescr] = "همه";
            ////dtGroups4Chart.Rows.InsertAt(dr, 0);


            //cmbChartGroup.DataSource = dtGroups4Chart;
            //cmbChartGroup.DisplayMember = CRP.CTE_Alias_Group_GroupDescr;
            //cmbChartGroup.ValueMember = CRP.CTE_Alias_Group_GroupID;

            ////Fill Group Grid
            //Helper h = new Helper();
            //h.FormatDataGridView(dgvGroup);
            //dgvGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvGroup.Columns[CRP.CTE_Alias_Group_GroupID].Visible = false;

            //Total EC
            //if (crp.GetTotalEC(curModelID, cl) == 0)
            //    lblTotalEC.Text = "0";
            //else
            //lblTotalEC.Text = crp.GetTotalEC(curModelID, cl).ToString("###,###.###");
        }


        private void cbRefreshGroups_CButtonClicked(object sender, EventArgs e)
        {
            try
            {
                if(lblTotalEC.Text.Equals("..."))
                {
                    Routines.ShowMessageBoxFa("لازم است ابتدا سرمایه اقتصادی کل را حساب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!CheckDataAvailability())
                {
                    Routines.ShowMessageBoxFa("در تاریخ مورد نظر داده ای وجود ندارد، لطفا تاریخ دیگری انتخاب کنید", "داده", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                float  tryInt = 0;
                //dgvGroup.Refresh();
                //dgvGroup.Update();
                foreach (DataRow dr in (dgvGroup.DataSource as DataTable).Rows)
                {
                    if (!float.TryParse(dr[3].ToString(), out tryInt))
                    {
                        Routines.ShowMessageBoxFa("حجم ریالی وارد شده معتبر نیست", "مدل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }
                crp.Insert_CRP_Model_Group_RialVolume(curModelID, dgvGroup.DataSource as DataTable);

                DoProcess(cmbGroupBy.SelectedIndex);
                splitContainer_GroupResult.Panel1Collapsed = true;
            }
            catch (Exception ex)
            {
                Routines.ShowMessageBoxFa(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void PageResult(int pageNum)
        {
            int fromIndex = pageNum * (CTE_PageLength);
            int toIndex = fromIndex + CTE_PageLength;

            //dgvResult.DataSource = crp.GetResult(curModelID, GroupID, fromIndex, toIndex);
            dgvResult.DataSource = crp.GetResultNNP(curModelID, GroupID, fromIndex, toIndex);

            Helper h = new Helper();
            h.FormatDataGridView(dgvResult);
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvResult.Columns["Row"].HeaderText = "رديف";
            dgvResult.Columns["RFME"].HeaderText = "شاخص محدوده";

            dgvResult.Columns["Expected Loss"].HeaderText = "زیان مورد انتظار";
            //dgvResult.Columns["Economic Capital"].HeaderText = "سرمايه اقتصادی";
            dgvResult.Columns["Economic Capital"].Visible = false;
            dgvResult.Columns["Count RMFE"].HeaderText = " تعداد وام  در هر محدوده";

            RefreshPagingCombos(GroupID, RFME);
        }
        private void RefreshGroupResult(int groupID)
        {
            ProgressBox.Show();
            int numPageResultItems = crp.GetGroupNumResult(curModelID, groupID);

            cmbResultPage.BeginUpdate();
            cmbResultPage.Items.Clear();
            for (int i = 0; i <= numPageResultItems / CTE_PageLength; i++)
            {
                string fromIndex = (i * CTE_PageLength + 1).ToString();
                string toIndex = (i * CTE_PageLength + CTE_PageLength).ToString();
                cmbResultPage.Items.Add((i + 1).ToString());
            }
            cmbResultPage.EndUpdate();

            if (cmbResultPage.Items.Count > 1)
                cmbResultPage.SelectedIndex = 1;
            else
            {
                dgvResult.DataSource = null;
                //dgvDetail.DataSource = null;
            }

            decimal cl = 0;
            Presentation.Public.Routines.GetNumericValue(txtAmountCL.Text, out cl);

            //if (crp.GetGroupEC(curModelID, groupID, cl) == 0)
            //    lblGroupEC.Text = "0";
            //else
            //    lblGroupEC.Text = crp.GetGroupEC(curModelID, groupID, cl).ToString("###,###.###");
            double el = 0, ec = 0, rcg = 0, eca = 0;
            DateTime StartDate = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(fdpStartDate.Text);
            double ECTotal = lblTotalEC.Text.Equals("...") ? 0 : double.Parse(lblTotalEC.Text);

            crp.Calculate_CRP_EC_ByGroupID(curModelID, RialVolumel, cl, LossCount, AlphaLevel, groupID, StartDate, chkManualPD.Checked, ECTotal, out el, out ec, out rcg, out eca);
            //lblGroupEC.Text = ec.ToString();
            //lblRCA.Text = eca.ToString();
            //lblRCg.Text = rcg.ToString();

            //var AlphaArray = new[] { 50, 75, 90, 95, 99, 99.5, 99.75, 99.9 };
            //DataTable dtVaR = dgvVaR.DataSource as DataTable;
            //foreach (decimal alpha in AlphaArray)
            //    if (alpha <= cl)
            //    {
            //        crp.Calculate_CRP_EC_ByGroupID(curModelID, RialVolumel, cl, LossCount, alpha, groupID, out el, out ec, out rcg, out eca);
            //        double VaR = ec + el;
            //        foreach (DataRow dr in dtVaR.Rows)
            //        {
            //            if (dr["AlphaLevel"].Equals(alpha.ToString()))
            //            {
            //                dr["VaRGroup"] = VaR;
            //            }
            //        }
            //    }
            //dgvVaR.DataSource = null;
            //dgvVaR.DataSource = dtVaR;
            //dgvVaR.Columns["AlphaLevel"].HeaderText = "سطح آلفا";
            //dgvVaR.Columns["VaR"].HeaderText = "مقدار VaR کل";
            //dgvVaR.Columns["VaR"].HeaderText = "مقدار VaR برای گروه";
            ProgressBox.Hide();
        }
        private void RefreshPagingCombos(int groupID, decimal rfme)
        { 
            if (groupID == -1)
            {
                //int groupBy = cmbGroupBy.SelectedIndex;
                int numPageDetailItems = crp.GetResultNumDetail(curModelID, -1, groupID, rfme);

                cmbDetailPage.BeginUpdate();
                cmbDetailPage.Items.Clear();

                cmbDetailPage.Items.Add("همه");

                for (int i = 0; i <= numPageDetailItems / CTE_PageLength; i++)
                {
                    string fromIndex = (i * CTE_PageLength + 1).ToString();
                    string toIndex = (i * CTE_PageLength + CTE_PageLength).ToString();
                    cmbDetailPage.Items.Add((i + 1).ToString());
                }
                cmbDetailPage.EndUpdate();

                if (cmbDetailPage.Items.Count > 1)
                    cmbDetailPage.SelectedIndex = 1;
            }
            else
            {

                int groupBy = cmbGroupBy.SelectedIndex;
                groupID = (int)cmbSubGroups.SelectedValue;
                int numPageDetailItems = crp.GetResultNumDetail(curModelID, groupBy, groupID, rfme);

                cmbGroupDetailPage.BeginUpdate();
                cmbGroupDetailPage.Items.Clear();

                cmbGroupDetailPage.Items.Add("همه");

                for (int i = 0; i <= numPageDetailItems / CTE_PageLength; i++)
                {
                    string fromIndex = (i * CTE_PageLength + 1).ToString();
                    string toIndex = (i * CTE_PageLength + CTE_PageLength).ToString();
                    cmbGroupDetailPage.Items.Add((i + 1).ToString());
                }
                cmbGroupDetailPage.EndUpdate();

                if (cmbGroupDetailPage.Items.Count > 1)
                    cmbGroupDetailPage.SelectedIndex = 1;
            }
            //else
                //dgvDetail.DataSource = null;

        }
        private void PageDetail(int pageNum)
        {
            int fromIndex;
            int toIndex;
            pageNum = pageNum - 1;
            
            if (pageNum == -1)
            {
                fromIndex = 0;
                toIndex = cmbDetailPage.Items.Count * (CTE_PageLength);
            }
            else
            {
                fromIndex = pageNum * (CTE_PageLength);
                toIndex = fromIndex + CTE_PageLength;
            }
            Cursor = Cursors.WaitCursor;
            int groupBy = cmbGroupBy.SelectedIndex;
            //dgvResultDetail.DataSource = crp.GetResultDetail(curModelID, groupBy, GroupID, RFME, fromIndex, toIndex);
            dgvDetail.DataSource = crp.GetResultDetailNNP(curModelID, -1, GroupID, RFME, fromIndex, toIndex);
            //dgvResultDetail.Columns[2].DefaultCellStyle.Format = "###,###.##";
            //dgvResultDetail.Columns[4].DefaultCellStyle.Format = "###,###.##";
            Cursor = Cursors.Default;

            Helper h = new Helper();
            h.FormatDataGridView(dgvDetail);
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvDetail.DataSource != null)
            {
                dgvDetail.Columns["Row"].HeaderText = "ردیف";
                dgvDetail.Columns["FE"].HeaderText = "اکسپوژر مؤثر";
                dgvDetail.Columns["FE"].Visible = false;
                dgvDetail.Columns["Contract"].Visible = false;
                dgvDetail.Columns["Exp"].Visible = false;
                dgvDetail.Columns["PD"].Visible = false;                
                dgvDetail.Columns["MFE"].Visible = false;
                dgvDetail.Columns["RFME"].Visible = false;
                dgvDetail.Columns["MND"].Visible = false;
            }
        }

        private void PageDetailGroups(int pageNum)
        {
            int fromIndex;
            int toIndex;
            pageNum = pageNum - 1;

            if (pageNum == -1)
            {
                fromIndex = 0;
                toIndex = cmbGroupDetailPage.Items.Count * (CTE_PageLength);
            }
            else
            {
                fromIndex = pageNum * (CTE_PageLength);
                toIndex = fromIndex + CTE_PageLength;
            }
            Cursor = Cursors.WaitCursor;
            int groupBy = (int)cmbSubGroups.SelectedValue;
            //dgvResultDetail.DataSource = crp.GetResultDetail(curModelID, groupBy, GroupID, RFME, fromIndex, toIndex);
            dgvResult.DataSource = crp.GetResultDetailNNP(curModelID, groupBy, GroupID, RFME, fromIndex, toIndex);
            //dgvResultDetail.Columns[2].DefaultCellStyle.Format = "###,###.##";
            //dgvResultDetail.Columns[4].DefaultCellStyle.Format = "###,###.##";
            Cursor = Cursors.Default;

            Helper h = new Helper();
            h.FormatDataGridView(dgvResult);
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvResult.DataSource != null)
            {
                dgvResult.Columns["Row"].HeaderText = "ردیف";
                dgvResult.Columns["FE"].HeaderText = "اکسپوژر مؤثر";
                dgvResult.Columns["FE"].Visible = false;
                dgvResult.Columns["Contract"].Visible = false;
                dgvResult.Columns["Exp"].Visible = false;
                dgvResult.Columns["PD"].Visible = false;
                dgvResult.Columns["MFE"].Visible = false;
                dgvResult.Columns["RFME"].Visible = false;
                dgvResult.Columns["MND"].Visible = false;

                try
                {
                    dgvResult.Columns["اکسپوژر مؤثر"].DisplayIndex = 1;
                }
                catch
                {
                }
            }
        }

        private void RefreshChart(int groupID)
        {
            //ddChart.Series[0].Points.Clear();
            //ddChart.Series[0].Type = Dundas.Charting.WinControl.SeriesChartType.Line;
            //ddChart.Series[0].MarkerStyle = Dundas.Charting.WinControl.MarkerStyle.Diamond;
            //ddChart.Series[0].MarkerSize = 3;
            //ddChart.Series[0].BorderWidth = 3;
            //ddChart.Series[1].Points.Clear();
            //ddChart.Series[1].Type = Dundas.Charting.WinControl.SeriesChartType.Line;
            //ddChart.Series[1].MarkerStyle = Dundas.Charting.WinControl.MarkerStyle.Diamond;
            //ddChart.Series[1].MarkerSize = 3;
            //ddChart.Series[1].BorderWidth = 3;
            //ddChart.Series[1].Label = "el";
            //ddChart.Series[1].ShowLabelAsValue = true;
            //ddChart.Series[2].Points.Clear();
            //ddChart.Series[2].Type = Dundas.Charting.WinControl.SeriesChartType.Line;
            //ddChart.Series[2].MarkerStyle = Dundas.Charting.WinControl.MarkerStyle.Diamond;
            //ddChart.Series[2].MarkerSize = 3;
            //ddChart.Series[2].BorderWidth = 3;
            //ddChart.ChartAreas["Default"].AxisX.MinorGrid.Enabled = false;
            //ddChart.ChartAreas["Default"].AxisY.MinorGrid.Enabled = false;
            //ddChart.ChartAreas["Default"].AxisX.MajorGrid.Enabled = false;
            //ddChart.ChartAreas["Default"].AxisY.MajorGrid.Enabled = false;
            //ddChart.ChartAreas["Default"].ShadowColor = Color.Gray;
            //ddChart.ChartAreas["Default"].AxisX.LabelStyle.ShowEndLabels = true;
            //ddChart.ChartAreas["Default"].AxisX.LabelStyle.Font = this.Font;
            //ddChart.ChartAreas["Default"].AxisY.LabelStyle.ShowEndLabels = true;
            //ddChart.ChartAreas["Default"].AxisY.LabelStyle.Font = this.Font;
            //double el = Convert.ToDouble(crp.GetEL(curModelID, groupID));
            //long right = Convert.ToInt64(el + Math.Floor(Math.Round(PoissonDistribution.INV(0.99999, el) - el)));
            //long left = Convert.ToInt64(el - Math.Floor(Math.Round(el - PoissonDistribution.INV(0.00001, el))));
            //int step = Convert.ToInt32(Math.Floor(Math.Round((right - left) / 100.0)));
            //for (long x = left; x < right; x += step)
            //{
            //    double y = PoissonDistribution.PDF(x, el);
            //    ddChart.Series[0].Points.AddXY(x, y);
            //}
            //double y1 = PoissonDistribution.PDF(el, el);
            //ddChart.Series[1].Points.AddXY(el, y1);
            //ddChart.Series[1].Points.AddXY(el, 0);
            //decimal cl = 0;
            //Presentation.Public.Routines.GetNumericValue(txtAmountCL.Text, out cl);
            //double ec = Convert.ToDouble(crp.GetGroupEC(curModelID, groupID, cl));
            //double p = el + ec;
            //double y2 = PoissonDistribution.PDF(p, p);
            //ddChart.Series[2].Points.AddXY(p, y2);
            //ddChart.Series[2].Points.AddXY(p, 0);
            ////ddChart.Series[2].Label = cl.ToString()+"th Percentile" ;
            ////ddChart.Series[2].ShowLabelAsValue= true;
            //  ddChart.Invalidate();        

            chtTotal.DataSource = null;
            chtTotal.ChartAreas[0].AxisX.Interval = 1;
            chtTotal.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            chtTotal.ChartAreas[0].AxisX.LabelsAutoFit = true;
            chtTotal.ChartAreas[0].AxisX.LabelStyle.FontAngle = 45;
            chtTotal.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chtTotal.Series[0].ToolTip = "#VAL      #AXISLABEL";

            //ddChart.DataSource = null;
            string s = cmbWhatToShow.Text;


            //ddChart.Series.Clear();
            //ddChart.Series.Add("Series1");

            switch (s)
            {
                case "شاخص محدوده":
                    s = "RFME";
                    chtTotal.Series[0].Color = Color.DarkOrange;
                    break;

                case "زيان مورد انتظار":
                    s = "Expected Loss";
                    chtTotal.Series[0].Color = Color.Red;

                    break;
                //case "سرمايه اقتصادي":
                //    s = "Economic Capital";
                //    chart.Series[0].Color = Color.Green;
                //    break;
                case "تعداد قرارداد در محدوده":
                    chtTotal.Series[0].Color = Color.Blue;
                    s = "Count RMFE";
                    break;
            }
            ;
            chtTotal.Series[0].ValueMembersY = s;// cmbItem.Text;
            chtTotal.Series[0].ValueMemberX = "Row";
            //ddChart.Series["Series1"].Type = SeriesChartType.Column;
            //ddChart.Series["Series1"].ValueMemberX = "Row";
            //ddChart.Series["Series1"].ValueMembersY = s;
           // ddChart.Series["Series1"].XValueType = ChartValueTypes.Int;
            //ddChart.Series["Series1"].YValuesPerPoint = 1;
            //ddChart.Series["Series1"].ShowInLegend = false;
            //ddChart.Series["Series1"].LegendText = cmbWhatToShow.Text;




            //decimal cl = 0;
            //Routines.GetNumericValue(txtAmountCL.Text, out cl);
            //double ec = Convert.ToDouble(crp.GetGroupEC(curModelID, groupID, cl));
            //double p = el + ec;

            //ddChart.Series["Series1"].XValueIndexed = true;

            //ddChart.Series["Series1"]["DrawingStyle"] = "Cylinder";

            //ddChart.ChartAreas["Default"].Area3DStyle.Enable3D = true;
            //ddChart.ChartAreas["Default"].Area3DStyle.Light = LightStyle.Realistic;
            //ddChart.ChartAreas["Default"].Area3DStyle.Perspective = 30;
            //ddChart.ChartAreas["Default"].Area3DStyle.XAngle = 10;
            //ddChart.ChartAreas["Default"].Area3DStyle.YAngle = 5;
            //ddChart.ChartAreas["Default"].Area3DStyle.PointDepth = 200;
            //ddChart.ChartAreas["Default"].Area3DStyle.PointGapDepth = 0;
            //ddChart.ChartAreas["Default"].Area3DStyle.RightAngleAxes = true;

            //ddChart.ChartAreas["Default"].BackColor = Color.White;

            //ddChart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            //ddChart.BackColor = Color.FromArgb(146, 180, 222);
            //ddChart.BackGradientEndColor = Color.White;
            //ddChart.BackGradientType = GradientType.TopBottom;
            //ddChart.BorderStyle = ChartDashStyle.Solid;
            //ddChart.BorderColor = Color.DarkBlue;
            //ddChart.BorderWidth = 2;


            //ddChart.ChartAreas["Default"].ShadowOffset = 5;
            //ddChart.ChartAreas["Default"].ShadowColor = Color.Gray;
            //ddChart.ChartAreas["Default"].AxisX.LabelStyle.ShowEndLabels = true;
            //ddChart.ChartAreas["Default"].AxisX.LabelStyle.Font = this.Font;
            //ddChart.ChartAreas["Default"].AxisY.LabelStyle.ShowEndLabels = true;
            //ddChart.ChartAreas["Default"].AxisY.LabelStyle.Font = this.Font;
            //ddChart.ChartAreas["Default"].AxisX.MinorGrid.Enabled = false;
            //ddChart.ChartAreas["Default"].AxisY.MinorGrid.Enabled = true;
            //ddChart.ChartAreas["Default"].AxisY.MinorGrid.LineColor = Color.LightGray;
            //ddChart.ChartAreas["Default"].AxisX.MajorGrid.Enabled = false;
            //ddChart.ChartAreas["Default"].AxisY.MajorGrid.Enabled = true;
            //ddChart.ChartAreas["Default"].AxisY.MajorGrid.LineColor = Color.Wheat;

            chtTotal.ChartAreas[0].AxisX.LabelStyle.Format = "###,###";
            chtTotal.ChartAreas[0].AxisY.LabelStyle.Format = "###,###";

            //ddChart.Series["Series1"].SmartLabels.Enabled = true;
            //ddChart.Series["Series1"].Font = this.Font;
            //ddChart.Series["Series1"].LabelFormat = "###,###";
            //ddChart.Series["Series1"].ShowLabelAsValue = false;

            //ddChart.Palette = ChartColorPalette.Dundas;
            DataTable Dt = crp.GetResult(curModelID, groupID, 1, 9999999);
            chtTotal.DataSource = null;
            //chart.DataBind();
            chtTotal.DataSource = Dt;
            chtTotal.DataBind();

        }
        private void btnHideModel_Click(object sender, EventArgs e)
        {
            ////scModel.Panel1Collapsed = !scModel.Panel1Collapsed;


            //if (scModel.Panel1.Width == 0)
            //{
            //    //btnHideModel Image = global::Presentation.Properties.Resources.panLeft;
            //    scModel.Panel1Collapsed = !scModel.Panel1Collapsed;
            //}
            //else
            //{
            //    //btnHideModel.Image = global::Presentation.Properties.Resources.PanRight;
            //    scModel.Panel1Collapsed = !scModel.Panel1Collapsed;
            //}
            if (scModel.Panel1Collapsed == false)
            {
                scModel.Panel1Collapsed = true;
                btnHideModel.DefaultImage = Properties.Resources.S_Panleft1;
                btnHideModel.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (scModel.Panel1Collapsed == true)
            {
                scModel.Panel1Collapsed = false;
                btnHideModel.DefaultImage = Properties.Resources.S_PanRight1;
                btnHideModel.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }
        private void btnHideParam_Click(object sender, EventArgs e)
        {
            //if (scParamResult.Panel1.Width == 0)
            //{
            //    //btnHideParam.Image = global::Presentation.Properties.Resources.panUp;
            //    scParamResult.Panel1Collapsed = !scParamResult.Panel1Collapsed;
            //}
            //else
            //{
            //    //btnHideParam.Image = global::Presentation.Properties.Resources.panDown;
            //    scParamResult.Panel1Collapsed = !scParamResult.Panel1Collapsed;
            //}
            if (scParamResult.Panel1Collapsed == false)
            {
                scParamResult.Panel1Collapsed = true;
                btnHideParam.DefaultImage = Properties.Resources.S_PanDown1;
                btnHideParam.HoverImage = Properties.Resources.S_PanDown_Hover1;
            }
            else if (scParamResult.Panel1Collapsed == true)
            {
                scParamResult.Panel1Collapsed = false;
                btnHideParam.DefaultImage = Properties.Resources.S_PanUp1;
                btnHideParam.HoverImage = Properties.Resources.S_PanUp_Hover1;
            }
        }
        private void chkResult_CheckedChanged(object sender, EventArgs e)
        {

            if (chkResult.Checked == true)
                chbOutPut_dgvDetail.Checked = false;
            GeneralDataGridView = dgvResult;
          
        }
        private void chkDetail_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOutPut_dgvDetail.Checked == true)
            
                chkResult.Checked = false;
            GeneralDataGridView = dgvDetail;
        }
        public void DoPrint()
        {

            if (chkResult.Checked == true)
            {
                if (dgvResult.DataSource != null)
                    DoPrintResult();

            }
            else
            {
                if (dgvDetail.DataSource != null)
                    DoPrintDetail();
            }
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "CreditRisk";
        }
        public void DoPrintResult()
        {
            DataGridView dgv = new DataGridView();
            //  dgv.DataSource = null;

            foreach (DataGridViewColumn c1 in dgvResult.Columns)
            {
                DataGridViewColumn c2 = (DataGridViewColumn)c1.Clone();
                dgv.Columns.Add(c2);
            }

            int i = 0;
            foreach (DataGridViewRow dgvr in dgvResult.Rows)
            {
                DataGridViewRow r = (DataGridViewRow)dgvr.Clone();
                i = 0;
                foreach (DataGridViewCell cell in dgvr.Cells)
                {

                    r.Cells[i].Value = cell.Value;
                    i++;
                }
                dgv.Rows.Add(r);
            }

            dgv.Columns["Row"].HeaderText = "سطر";
            dgv.Columns["RFME"].HeaderText = "شاخص گروه";

            dgv.Columns["Expected Loss"].HeaderText = "زیان مورد انتظار";
            //dgv.Columns["Economic Capital"].HeaderText = "سرمايه اقتصادی";
            dgv.Columns["Economic Capital"].Visible = false;


            clsERMSGeneral.dgvActive = dgv;
        }
        public void DoPrintDetail()
        {
            DataGridView dgv = new DataGridView();

            //  dgv.DataSource = null;
            foreach (DataGridViewColumn c1 in dgvDetail.Columns)
            {
                DataGridViewColumn c2 = (DataGridViewColumn)c1.Clone();
                dgv.Columns.Add(c2);
            }

            int i = 0;
            foreach (DataGridViewRow dgvr in dgvDetail.Rows)
            {
                DataGridViewRow r = (DataGridViewRow)dgvr.Clone();
                i = 0;
                foreach (DataGridViewCell cell in dgvr.Cells)
                {

                    r.Cells[i].Value = cell.Value;
                    i++;
                }
                dgv.Rows.Add(r);
            }

            dgv.Columns["Contract"].HeaderText = "قرارداد";
            dgv.Columns["Exp"].HeaderText = "مانده تسهيلات";
            dgv.Columns["PD"].HeaderText = "احتمال نكول";
            dgv.Columns["FE"].HeaderText = "محدوده در خطر";
            dgv.Columns["MFE"].HeaderText = "محدوده خطر در مقیاس واحد";
            dgv.Columns["RFME"].HeaderText = "شاخص محدوده";
            dgv.Columns["MND"].HeaderText = "زیان مورد انتظار در مقیاس واحد";
            dgv.Columns["LV"].HeaderText = "سهم ریسک";
            clsERMSGeneral.dgvActive = dgv;
        }
        private void tspDelete_Click(object sender, EventArgs e)
        {
            //int index = dgvAV.SelectedCells[0].RowIndex;


            //if (dgvAV.Rows.Count > index + 1)
            //{
            //    int AD_ID = int.Parse(dgvAV.Rows[index].Cells[CRP.CTE_Alias_AV_ID].Value.ToString());
            //    crp.DeleteAV(AD_ID);

            //    DataTable dt = crp.GetAVs(curModelID);
            //    dgvAV.DataSource = dt;
            //}

        }
        private void dgvAV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAV.SelectedCells.Count != 0)
            {

                int indexRow = dgvAV.SelectedCells[0].RowIndex;
                int indexCol = dgvAV.SelectedCells[0].ColumnIndex;
                if (indexCol == 5)
                {
                    if (decimal.Parse(dgvAV.Rows[indexRow].Cells[indexCol].Value.ToString()) < decimal.Parse(dgvAV.Rows[indexRow].Cells[indexCol - 1].Value.ToString()))
                    {
                        MessageBox.Show("كران حجم ريالی واردشده صحيح نمی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                if (indexCol == 4)
                {
                    if (indexRow != 0)
                    {
                        if (decimal.Parse(dgvAV.Rows[indexRow].Cells[indexCol].Value.ToString()) < decimal.Parse(dgvAV.Rows[indexRow - 1].Cells[indexCol + 1].Value.ToString()))
                        {
                            MessageBox.Show("كران حجم ريالی واردشده صحيح نمی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        private void ctxCredit_Click(object sender, EventArgs e)
        {

        }
        private void tsbRefresh_Click(object sender, EventArgs e)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (lsvModel.SelectedItems.Count == 0)
            {
                Routines.ShowMessageBoxFa("لطفاً یك مدل ریسك اعتباری انتخاب یا ایجاد كنید", "مدل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(!CheckDataAvailability())
            {
                Routines.ShowMessageBoxFa("در تاریخ مورد نظر داده ای وجود ندارد، لطفا تاریخ دیگری انتخاب کنید", "داده", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //if (!NP)
            //{
                DoProcess(-1);
                /*  if (bDirty)
                  {
                      if (Routines.ShowMessageBoxFa("آيا مدل ذخیره شود ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                          CommandModelSave(curModelID, true);

                  }*/

            //}
            //else
            //    DoProcessNP();
        }
        private void cmbResultPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!NP)
                PageResult(cmbResultPage.SelectedIndex);
            //else
            //    PageResultNP(cmbResultPage.SelectedIndex);
        }
        private void dgvResult_MouseClick(object sender, MouseEventArgs e)
        {
            //if (!NP)
            //RefreshDetail(GroupID, RFME);
            //else
            //    RefreshDetailNP(GroupID);
        }
        private void cmbDetailPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!NP)
            PageDetail(cmbDetailPage.SelectedIndex);
            //else
            //    PageDetailNP(cmbDetailPage.SelectedIndex);    
        }
        private void chkEnableGrouping_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableGrouping.Checked)
            {
                scGroupResult.Panel1Collapsed = false;
                scGroupResultContainer.Panel2Collapsed = false;
                cmbGroupBy.Enabled = true;

                //if (NP)
                    //panel2.Visible = false;
            }
            else
            {
                scGroupResult.Panel1Collapsed = true;
                scGroupResultContainer.Panel2Collapsed = true;
                cmbGroupBy.Enabled = false;
                cmbGroupBy.SelectedIndex = -1;

                //panel2.Visible = true;
            }
        }
        private void dgvGroup_MouseClick(object sender, MouseEventArgs e)
        {
            if (GroupID != -1)
                //if (!NP)
                    RefreshGroupResult(GroupID);
                //else
                //    RefreshGroupResultNP(GroupID);
        }

        //private bool NP
        //{
        //    get { return chkNonParametric.Checked; }
        //}

        private void chkNonParametric_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNonParametric.Checked)
            {
                tabDetailDown.TabPages.Remove(tpChart);
                //panel2.Visible = false;
            }
            else
            {
                tabDetailDown.TabPages.Add(tpChart);
                //panel2.Visible = true;
            }
        }

        //private void DoProcessNP()
        //{
        //    SaveHR(curModelID);
        //    SaveAV(curModelID);

        //    int l = 0; decimal cl = 0;
        //    Presentation.Public.Routines.GetNumericValue(txtAmountL.Text, out l);
        //    Presentation.Public.Routines.GetNumericValue(txtAmountCL.Text, out cl);
        //    int groupBy = cmbGroupBy.SelectedIndex;

        //    int numResultItems = -1;
        //    try
        //    {
        //        ProgressBox.Show();
        //        numResultItems = crp.CreateCRPNP(curModelID, l, cl, groupBy);
        //    }
        //    catch (Exception ex)
        //    {
        //        MsgBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        ProgressBox.Hide();
        //    }

        //    if (!chkEnableGrouping.Checked)
        //    {
        //        cmbResultPage.BeginUpdate();
        //        cmbResultPage.Items.Clear();
        //        for (int i = 0; i <= numResultItems / CTE_PageLength; i++)
        //        {
        //            string fromIndex = (i * CTE_PageLength + 1).ToString();
        //            string toIndex = (i * CTE_PageLength + CTE_PageLength).ToString();
        //            cmbResultPage.Items.Add((i + 1).ToString());
        //        }
        //        cmbResultPage.EndUpdate();
        //    }

        //    DataTable dtGroups = crp.GetResultGroupsNP(curModelID);
        //    dgvGroup.DataSource = dtGroups;
        //    dgvResult.DataSource = null;
        //    dgvDetail.DataSource = null;

        //    Helper h = new Helper();
        //    h.FormatDataGridView(dgvGroup);
        //    dgvGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dgvGroup.Columns[CRP.CTE_Alias_Group_GroupID].Visible = false;

        //    if (!chkEnableGrouping.Checked)
        //        RefreshGroupResultNP(-1);

        //    ////Total EC
        //    //if (crp.GetTotalEC(curModelID, cl) == 0)
        //    //    lblTotalEC.Text = "0";
        //    //else
        //    //    lblTotalEC.Text = crp.GetTotalEC(curModelID, cl).ToString("###,###.###");
        //}
        
        private void PageResultNP(int pageNum)
        {

        }
        private void RefreshGroupResultNP(int groupID)
        {
            int l = 0; decimal cl = 0;
            Presentation.Public.Routines.GetNumericValue(txtAmountL.Text, out l);
            Presentation.Public.Routines.GetNumericValue(txtAmountCL.Text, out cl);

            double el = 0, ec = 0;
            int numResultItems = -1;
            try
            {
                Presentation.Public.ProgressBox.Show();

                
                dgvResult.DataSource = crp.GetResultNP(curModelID, groupID, l, cl, out el, out ec);
                dgvResult.Columns["Row"].HeaderText = "رديف";
                dgvResult.Columns["Band"].HeaderText = "گروه";
                dgvResult.Columns["Loss"].HeaderText = "زيان";

            }
            catch (Exception ex)
            {
                MsgBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }

            Helper h = new Helper();
            h.FormatDataGridView(dgvResult);
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Total EC
            //if (chkEnableGrouping.Checked)
            //{
            //    if (ec == 0)
            //        lblGroupEC.Text = "0";
            //    else
            //        lblGroupEC.Text = ec.ToString("###,###.###");
            //}
            //else
            //{
            //    if (ec == 0)
            //        lblTotalEC.Text = "0";
            //    else
            //    lblTotalEC.Text = ec.ToString("###,###.###");
            //}
        }
        private void cmbWhatToShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            int r;
            if (cmbChartGroup.SelectedValue != null && int.TryParse(cmbChartGroup.SelectedValue.ToString(), out r))
            {
                if (cmbWhatToShow.Text.Trim() != "")
                {

                    int groupID = r;
                    RefreshChart(groupID);
                }
            }
            else
            {
                MessageBox.Show("Please select a Group");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void ddChart_AnnotationSelectionChanged(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chtTotal.Annotations.Count; i++)
                if (chtTotal.Annotations[i].Selected)
                    chtTotal.Annotations.RemoveAt(i);
        }

        #region "Report"
        private void tsbFinalSave_Click(object sender, EventArgs e)
        {
            ReportSave(curModelID, true);
        }
        private void ReportSave(int modelID, bool bMsg)
        {
            //if (fdpStartDate.Text.Length != 10)
            //{
            //    Presentation.Public.Routines.ShowMessageBoxFa("تاريخ ذخیره مدل مشخص نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
           
            //p1 = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            //DateTime ModelDate = DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));
            
            PersianTools.Dates.PersianDate P1;
            EventLog evlog = new EventLog();
            DataTable dt = new DataTable();
            dt = evlog.GetLastDate();

            P1 = new PersianTools.Dates.PersianDate((DateTime)dt.Rows[0][0]);
            DateTime ModelDate = DateTime.Parse(P1.ToGregorian.ToString("yyyy/MM/dd"));
            
            //float l = 0; decimal cl = 0;
            if (lsvModel.SelectedItems.Count > 0)
            {
                try
                {
                    //int numResultItems = 0;
                    Presentation.Public.ProgressBox.Show();
                    decimal tcl = 0;
                    if (txtAmountCL.Text != null && txtAmountCL.Text.Length > 0)
                        tcl = decimal.Parse(txtAmountCL.Text);
                    else
                        tcl = 99;
                    float TotalEC = float.Parse(lblTotalEC.Text);
                    float VaR = float.Parse(lblVaR.Text);
                    float EL = float.Parse(lblEL.Text);
                    float StdVar = float.Parse(lblStdVar.Text);
                    decimal cl = decimal.Parse(txtAmountCL.Text);
                    float l = float.Parse(txtAmountL.Text);
                    int LossCount = int.Parse(txtLossUnit.Text);
                    decimal AlphaLevel = decimal.Parse(txtAlphaLevel.Text);

                    DateTime ReportDateM = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(fdpStartDate.Text);
                    
                    int modelReport_Id = crp.InsertCRPM_Report(modelID, l, cl, AlphaLevel, LossCount, 
                                                                   fdpStartDate.Text, ReportDateM, TotalEC, VaR, EL, StdVar);
                    crp.InsertCRP_HR_Report(modelID, modelReport_Id);

                    //Presentation.Public.Routines.GetNumericValue(txtAmountL.Text, out l);
                    //Presentation.Public.Routines.GetNumericValue(txtAmountCL.Text, out cl);

                    for (int i = 0; i < 10; i++)
                    {
                        crp.CreateCRP_Report(modelReport_Id, curModelID, cl, ModelDate, i);
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        crp.UpdateTotalOverdueSummary(modelReport_Id, cl, i);
                    }
                    crp.UpdateTotalOverdueSummary(modelReport_Id, cl, -1);
                    Presentation.Public.Routines.ShowMessageBoxFa("مدل با موفقیت ذخیره نهايي شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                catch (Exception ex)
                {
                    MsgBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ProgressBox.Hide();
                }
                //if (bMsg)
                    
            }
        }
        #endregion

        //private void tsbUpdatePD_Click(object sender, EventArgs e)
        //{
        //    RPT rpt = new RPT();
        //    rpt.UpdatePD();

        //    crp.InserCrpModelElement();
        //}

       
        private void dgvHR_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bDirty = true;
        }

        private void txtAmountL_KeyUp(object sender, KeyEventArgs e)
        {
            bDirty = true;
        }

        private void txtAmountCL_KeyUp(object sender, KeyEventArgs e)
        {
            bDirty = true;
        }

        private void tsbImportExcel_Click(object sender, EventArgs e)
        {
            bool result = false;
            dlg = new OpenFileDialog();
            dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                ProgressBox.Show();
                GetExcel();
                if(dataSetPDExcel.Tables.Count == 1)
                    result = Save(dataSetPDExcel.Tables[0], "Contract_PD");
                ProgressBox.Hide();
                if(result)
                    Presentation.Public.Routines.ShowMessageBoxFa("عملیات ورود احتمال نکول با موفقیت انجام شد",
                                            "پایان عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GetExcel()
        {
            if (System.IO.File.Exists(dlg.FileName))
            {
                string HDR = string.Empty;
                if (Presentation.Public.Routines.ShowMessageBoxFa("آیا در فایل اکسل، ردیف عنوان برای ستون ها وجود دارد؟",
                                            "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HDR = "HDR=YES;IMEX=1;\"";
                }
                else
                    HDR = "HDR=NO;IMEX=1;\"";

                string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;" + HDR, dlg.FileName );
                string query = String.Format("select * from [{0}$]", "Sheet1");
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connectionString);
                dataSetPDExcel = new DataSet();
                dataAdapter.Fill(dataSetPDExcel);

                if (HDR == "HDR=NO;IMEX=1;\"")
                {
                    dataSetPDExcel.Tables[0].Columns[0].ColumnName = "شماره قرارداد";
                    for (int i = 1; i < dataSetPDExcel.Tables[0].Columns.Count; i++)
                    {
                        dataSetPDExcel.Tables[0].Columns[i].ColumnName = "PD" + i;
                    }
                }
                else
                {
                    //for (int i = 1; i < dataSet.Tables[0].Columns.Count; i++)
                    //{
                    //    //chbColumnsOfExcel.Items.Add(dataSet.Tables[0].Columns[i].ColumnName);
                    //    //chbColumnsOfExcel.SetItemChecked(i - 1, true);
                    //}
                }
            }
            else
            {
                Presentation.Public.Routines.ShowMessageBoxFa("هیج فایلی انتخاب نشده است.", "تایید", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        private bool Save(DataTable dtTable, String dtColumnName)
        {
            bool Result = true;
            try
            {
                crp.Delete_PD_CRPModelElemets();
                for (int i = 0; i < dtTable.Rows.Count; i++)
                {
                    string Contract = dtTable.Rows[i][0].ToString();
                    decimal Contract_PD = Convert.ToDecimal(dtTable.Rows[i][1].ToString());
                    crp.Insert_PD_CRPModelElemets(Contract, Contract_PD);
                }
                return Result;
            }
            catch (Exception ex)
            {
                Result = false;
                Routines.ShowMessageBoxFa(ex.Message, "تایید", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void cbCalcVaRs_CButtonClicked(object sender, EventArgs e)
        {
            Presentation.Public.Routines.GetNumericValue(txtAmountL.Text, out RialVolumel);
            Presentation.Public.Routines.GetNumericValue(txtAmountCL.Text, out cl);
            Presentation.Public.Routines.GetNumericValue(txtAlphaLevel.Text, out AlphaLevel);
            Presentation.Public.Routines.GetNumericValue(txtLossUnit.Text, out LossCount);
            double el = 0, ec = 0, rcg = 0, eca = 0;
            int groupBy = cmbGroupBy.SelectedIndex;
            DateTime StartDate = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(fdpStartDate.Text);
            double ECTotal = lblTotalEC.Text.Equals("...") ? 0 : double.Parse(lblTotalEC.Text);
            // Mohasebe VaR baraye ALpha haye az pish taein shode
            DataTable dtVaR = new DataTable();
            dtVaR.Columns.Add("AlphaLevel");
            dtVaR.Columns.Add("VaR");
            dtVaR.Columns.Add("VaRGroup");
            dtVaR.Columns["AlphaLevel"].Caption = "سطح آلفا (%)";
            dtVaR.Columns["VaR"].Caption = "VaR";
            dtVaR.Columns["VaRGroup"].Caption = "VaR مربوط به گروه";

            var AlphaArray = new[] { 50, 75, 90, 95, 99, 99.5, 99.75, 99.9 }; 
            foreach (decimal alpha in AlphaArray)
                if (alpha <= cl)
                {
                    crp.Calculate_CRP_EC_ByGroupID(curModelID, RialVolumel, cl, LossCount, alpha, groupBy, StartDate, chkManualPD.Checked, ECTotal,
                                                        out el, out ec, out rcg, out eca);
                    double VaR = ec + el;
                    DataRow dr;
                    dr = dtVaR.NewRow();
                    dr["AlphaLevel"] = alpha;
                    dr["VaR"] = VaR;
                    dr["VaRGroup"] = "-";
                    dtVaR.Rows.Add(dr);
                }
            dgvVaR.DataSource = dtVaR;
            dgvVaR.Columns["AlphaLevel"].HeaderText = "سطح آلفا";
            dgvVaR.Columns["VaR"].HeaderText = "مقدار VaR کل";
            dgvVaR.Columns["VaRGroup"].HeaderText = "مقدار VaR برای گروه";

            Helper h = new Helper();
            h.FormatDataGridView(dgvVaR);
            dgvVaR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmbSubGroups_SelectionChanged(object sender, EventArgs e)
        {
            //ProgressBox.Show();
            RefreshPagingCombos((int)cmbSubGroups.SelectedValue, 0);

             //DataTable dtDetail = new DataTable();
             //dtDetail = crp.GetDT_Report_CRP_Detail_NNP(curModelID, (int)cmbSubGroups.SelectedValue);
             //dgvResult.DataSource = dtDetail;
             //ProgressBox.Hide();
        }

        private void cmbSubGroupsChart_SelectionChanged(object sender, EventArgs e)
        {
            //Chart Group
            ProgressBox.Show();
            DataTable dtChartGroup = new DataTable();
            chtGroup.DataSource = dtChartGroup;
            chtGroup.Update();

            chtGroup.Dock = DockStyle.Fill;
            chtGroup.Visible = true;
            chtGroup.ChartAreas[0].AxisX.Interval = 1;
            chtGroup.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            chtGroup.ChartAreas[0].AxisX.LabelsAutoFit = true;
            chtGroup.ChartAreas[0].AxisX.LabelStyle.FontAngle = 45;
            chtGroup.ChartAreas[0].AxisX.ScrollBar.Enabled = true;

            dtChartGroup = crp.GetDT_CRP_Model_PValues_Chart(curModelID, cl, AlphaLevel, LossCount, (int)cmbSubGroupsChart.SelectedValue, RialVolumel);
            chtGroup.Series[0].ValueMembersY = "P";
            chtGroup.Series[0].ValueMemberX = "Column1";
            chtGroup.Series[0].ToolTip = "#VAL      #AXISLABEL";

            if (chtGroup.Titles.Count == 0)
                chtGroup.Titles.Add("نمودار تابع چگالی زیان اعتباری");
            chtGroup.Titles[0].Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chtGroup.ChartAreas[0].Axes[0].Title = "حجم زیان";
            chtGroup.ChartAreas[0].Axes[0].TitleFont = new System.Drawing.Font("B Nazanin",9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chtGroup.ChartAreas[0].Axes[0].Minimum = 0;
            chtGroup.ChartAreas[0].Axes[0].StartFromZero = true;
            chtGroup.ChartAreas[0].Axes[1].Title = "احتمال";
            chtGroup.ChartAreas[0].Axes[1].TitleFont = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chtGroup.ChartAreas[0].Axes[1].Minimum = 0;
            chtGroup.ChartAreas[0].Axes[1].StartFromZero = true;
            
            chtGroup.DataSource = dtChartGroup;
            chtGroup.DataBind();
            chtGroup.Update();
            ProgressBox.Hide();
            ///
        }

        private void cButton1_CButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
            pass = true;                 
        }

        private void chbOutput_dgvVaR_CheckedChanged(object sender, EventArgs e)
        {
            chbOutPut_dgvDetail.Checked = false;
            chbOutput_dgvGroupDetail.Checked = false;
            chbOutPut_dgvResult.Checked = false;
            //chbOutput_dgvVaR.Checked = false;

            GeneralDataGridView = dgvVaR;
        }

        private void chbOutPut_dgvDetail_CheckedChanged(object sender, EventArgs e)
        {
            //chbOutPut_dgvDetail.Checked = false;
            chbOutput_dgvGroupDetail.Checked = false;
            chbOutPut_dgvResult.Checked = false;
            chbOutput_dgvVaR.Checked = false;

            GeneralDataGridView = dgvDetail;
        }

        private void chbOutput_dgvGroupDetail_CheckedChanged(object sender, EventArgs e)
        {
            chbOutPut_dgvDetail.Checked = false;
            //chbOutput_dgvGroupDetail.Checked = false;
            chbOutPut_dgvResult.Checked = false;
            chbOutput_dgvVaR.Checked = false;

            GeneralDataGridView = dgvGroupDetail;
        }

        private void chbOutPut_dgvResult_CheckedChanged(object sender, EventArgs e)
        {
            chbOutPut_dgvDetail.Checked = false;
            chbOutput_dgvGroupDetail.Checked = false;
            //chbOutPut_dgvResult.Checked = false;
            chbOutput_dgvVaR.Checked = false;

            GeneralDataGridView = dgvResult;
        }

        private void cmbGroupDetailPage_SelectionChanged(object sender, EventArgs e)
        {
            PageDetailGroups(cmbGroupDetailPage.SelectedIndex);
        }

        private void cbProposalL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!CheckDataAvailability())
            {
                Routines.ShowMessageBoxFa("در تاریخ مورد نظر داده ای وجود ندارد، لطفا تاریخ دیگری انتخاب کنید", "داده", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            double RlVolume = 0;
            DateTime StartDate = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(fdpStartDate.Text);
            crp.GetProposalRialVolume(curModelID, StartDate, out RlVolume);
            txtAmountL.Text = RlVolume.ToString();
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            cbRefreshGroups1.Visible = true;
        }

        private void cbRefreshGroups1_Click(object sender, EventArgs e)
        {
            cbRefreshGroups_CButtonClicked(sender, e);
        }

        private bool CheckDataAvailability()
        {
            bool avail = false;
            DateTime StartDate = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(fdpStartDate.Text);
            if (StartDate.ToShortDateString().Equals(DateTime.Now.ToShortDateString()))
                return true;
            return crp.CheckDataAvailability(StartDate);
        }



        


       

      

        
    }

}