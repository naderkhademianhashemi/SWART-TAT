using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.UltraWinTree;
using ERMSLib;
using Utilize;
using Utilize.Helper;
using System.Linq;
using System.Collections.ObjectModel;
using ERMS.Logic;
using ERMS.Model;
using Presentation.Public;
using Presentation.Tabs.LimitManagement;
using MyDialogButton = Presentation.Public.MyDialogButton;

namespace Presentation.Tabs.FinancialRatio
{
    public partial class frmFncRatioDefination : BaseForm, IPrintable
    {
        #region VARS
        private const int CTE_Icon_CT = 0;
        private const int CTE_Icon_CTGroup = 1;
        private FncRatio_BL Fnc_BL;
        private PersianTools.Dates.PersianDate P;
        //string stID;
        private int FncRatio_Type;
        string LastStID = string.Empty;
        //string LastTextFormula = string.Empty;
        int formulaID = 0;
        bool NewFormula = false;
        bool EditFormula = false;
        MList<string> formulaList = new MList<string>();
        MList<string> stID = new MList<string>();
        //string formulaText = "";

        #endregion

        public frmFncRatioDefination()
        {
            
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
            
            GeneralDataGridView=dgvFncRatio;

            formulaList.ItemChanged += new EventHandler<EventArgs>(formulaChanged);
        }


        #region Function

        private void SaveFormula()
        {
            if (ChechkValidate())
            {
                //MathExpression expr = new MathExpression();
                FncRatio_BL Fnc_BL = new FncRatio_BL();
                //PersianTools.Dates.PersianDate p1;
                //p1 = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                //DateTime FormulaDate = DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));
                if (NewFormula)
                {
                    if (FncRatio_Type == 1)
                        Fnc_BL.SaveFormula(txtDescr.Text,  formulaList.ToString().ReplaceArabicChar(), 100, fdpStartDate.SelectedDateTime, stID.ToString(), null);
                    else
                        Fnc_BL.SaveFormula(txtDescr.Text, formulaList.ToString().ReplaceArabicChar(), 100, fdpStartDate.SelectedDateTime, stID.ToString(), null);
                }
                else if (!NewFormula)
                {
                    ListViewItem lvi = lsvFormula.SelectedItems[0];
                    FncRationDefinitionInfo ti = (FncRationDefinitionInfo)lvi.Tag;
                    Fnc_BL.UpdateFormula(ti.ID, txtDescr.Text, formulaList.ToString().ReplaceArabicChar(), 100, fdpStartDate.SelectedDateTime, stID.ToString(), null);
                    FillModel();
                }

                Presentation.Public.Routines.ShowMessageBoxFa("مدل شما با موفقيت ذخيره شد", "ذخيره", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangeEnabled(false);
                FillFormula();
            }
        }
        private bool ChechkValidate()
        {
            if (txtDescr.Text == string.Empty)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("لطفاشرح فرمول نسبت مالی را انتخاب كنيد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (formulaList.List.Count == 0)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(" فرمولي تشكيل نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (fdpStartDate.Text.Length != 10)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("تاريخ تعريف حد مشخص نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        
        private void FillModel()
        {
            lsvFncRatio.Items.Clear();
            DataTable dt = Fnc_BL.GetDTFncRatios();
            foreach (DataRow dr in dt.Rows)
            {
                FncRatioInfo Fnc = new FncRatioInfo();
                Fnc_BL.CloneX(dr, Fnc, ECloneXdir.DR2Info);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = Fnc.GroupName;

                lvi.Tag = Fnc;
                lsvFncRatio.Items.Add(lvi);
            }
        }
        private void FillFormula()
        {
            lsvFormula.Items.Clear();
            DataTable dt = Fnc_BL.GetDTFncRatiosDefinition();
            foreach (DataRow dr in dt.Rows)
            {
                FncRationDefinitionInfo FncDefinition = new FncRationDefinitionInfo();
                Fnc_BL.CloneXDefinition(dr, FncDefinition, ECloneXdir.DR2Info);
                ListViewItem lvi = new ListViewItem();
                lvi.Text = FncDefinition.Descr;
                lvi.Tag = FncDefinition;
                lsvFormula.Items.Add(lvi);
            }
        }
        private void Init()
        {
            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

            fdpDate.SelectedDateTime = DateTime.Now;
            fdpDate.ResetSelectedDateTime();

            fdpStartDate.SelectedDateTime = DateTime.Now;
            fdpStartDate.ResetSelectedDateTime();

            lbOP.Items.AddRange(new object[] { "+", "-", "*", "/", "(", ")" });
            rdbAll.Checked = true;

        }
        private void RefreshDiagram()
        {

        }
        private void ClearObjects()
        {
            stID.Clear();
            txtDescr.Text = "";
            //formulaText = "";
            formulaList.Clear();
        }
        private void ChangeEnabled(bool flag)
        {
            //tsbCancel.Enabled = flag;
            tsbNew.Enabled = !flag;
            tsbSave.Enabled = flag;
            btnUndo.Enabled = flag;

            txtDescr.Enabled = flag;
            //txtFormula.Enabled = flag;
            txtValue1.Enabled = flag;
            lbOP.Enabled = flag;
            fdpStartDate.Enabled = flag;
           // PFormula.Enabled = flag;
            //lsvFormula.Enabled = flag;
            lsvFncRatio.Enabled = flag;
        }
        private void FillBranch(string StateId)
        {
            var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(
                           org => cmbState.CheckedItems.Any(sta => sta.DataValue.ToString().Equals(org.State_Of_Branch.ToString()))).ToArray();

            cmbBranch.DataSource = organizations;

                //DataSet ds = Fnc_BL.GetDTBranch(StateId);
                //DataView view = new DataView(ds.Tables[0]);
                //cmbBranch.DataSource = view;
                cmbBranch.DisplayMember = "Branch_Description";
                cmbBranch.ValueMember = "Branch";
                cmbBranch.SelectedIndex = -1;
           
        }
        private void FillState()
        {

            DataTable ds = Fnc_BL.GetDTState();
            cmbState.SelectedIndex = -1;
            cmbState.ValueMember = "State_Id";
            cmbState.DisplayMember = "State_Name";
            cmbState.DataSource = ds;

            //cmbState.Items.Clear();



        }
        private void FillGrid()
        {
            Helper h = new Helper();
            h.FormatDataGridView(dgvFncRatio);
            dgvFncRatio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dgvFncRatio.DataSource = Fnc_BL.GetDTFncRatiosDefinition();
            //try
            //{
            //    dgvFncRatio.Columns["Branch_desc"].HeaderText = "شعبه";
            //}
            //catch
            //{
            //    dgvFncRatio.Columns["Descr"].HeaderText = "شعبه";
            //}
            if (dgvFncRatio.Columns.Contains("Formula"))
                dgvFncRatio.Columns["Formula"].Visible = false;
            if (dgvFncRatio.Columns.Contains("ID"))
                dgvFncRatio.Columns["ID"].Visible = false;
            if (dgvFncRatio.Columns.Contains("Amount"))
                dgvFncRatio.Columns["Amount"].HeaderText = "مقدار";
            if (dgvFncRatio.Columns.Contains("Branch_Id"))
                dgvFncRatio.Columns["Branch_Id"].Visible = false;
            if (dgvFncRatio.Columns.Contains("Branch_Id"))
                dgvFncRatio.Columns["Branch_Id"].Visible = false;
            if (dgvFncRatio.Columns.Contains("Descr"))
                dgvFncRatio.Columns["Descr"].HeaderText = "شرح نسبت مالی";
            if (dgvFncRatio.Columns.Contains("FormulaDate"))
                dgvFncRatio.Columns["FormulaDate"].Visible = false;
            if (dgvFncRatio.Columns.Contains("FormulaID"))
                dgvFncRatio.Columns["FormulaID"].Visible = false;
            //dgvFncRatio.Columns["ID"].HeaderText = "شناسه فرمول";
            //dgvFncRatio.Columns["Amount"].HeaderText = "مقدار";
            //dgvFncRatio.Columns["Branch_Id"].HeaderText = "شناسه شعبه";

            //try
            //{
            //    dgvFncRatio.Columns["Branch_desc"].Visible = true;
            //}
            //catch
            //{
            //    dgvFncRatio.Columns["Descr"].Visible = true;
            //}
            //if(dgvFncRatio.Columns.Contains("Formula"))
            //    dgvFncRatio.Columns["Formula"].Visible = false;

            //try
            //{
            //    dgvFncRatio.Columns["ID"].Visible = false;
            //    dgvFncRatio.Columns["Amount"].Visible = true;
            //    dgvFncRatio.Columns["Branch_Id"].Visible = false;
            //    dgvFncRatio.Columns["FormulaDate"].Visible = false;
            //    dgvFncRatio.Columns["FormulaID"].Visible = false;
            //    dgvFncRatio.Columns["Branch_Id"].Visible = false;
            //}
            //catch(Exception ex)
            //{
            //}


        }
        private void FillGridBranch()
        {
            Helper h = new Helper();
            h.FormatDataGridView(dgvFncRatio);
            dgvFncRatio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvFncRatio.Columns["Branch_ID"].HeaderText = "کد شعبه";
            try
            {
                dgvFncRatio.Columns["Branch_desc"].HeaderText = "شعبه";
            }
            catch
            {
                dgvFncRatio.Columns["Descr"].HeaderText = "شعبه";
            }
            try
            {
                dgvFncRatio.Columns["Amount"].HeaderText = "مقدار";

                dgvFncRatio.Columns["ID"].Visible = false;
                dgvFncRatio.Columns["Formula"].Visible = false;
                dgvFncRatio.Columns["FormulaDate"].Visible = false;
                dgvFncRatio.Columns["FormulaID"].Visible = false;
                dgvFncRatio.Columns["Branch_Id"].Visible = false;
            }
            catch(Exception ex)
            {
            }
    }
        private void FillGridState()
        {
            Helper h = new Helper();
            h.FormatDataGridView(dgvFncRatio);
            dgvFncRatio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            if (dgvFncRatio.Columns.Contains("State_ID"))
                dgvFncRatio.Columns["State_ID"].Visible = false;
            if (dgvFncRatio.Columns.Contains("State_desc"))
                dgvFncRatio.Columns["State_desc"].HeaderText="استان";
            if (dgvFncRatio.Columns.Contains("ID"))
                dgvFncRatio.Columns["ID"].Visible = false;
            if (dgvFncRatio.Columns.Contains("Amount"))
                dgvFncRatio.Columns["Amount"].HeaderText="مقدار";


            //dgvFncRatio.Columns["State_ID"].HeaderText = "کد استان";
            //dgvFncRatio.Columns["State_desc"].HeaderText = "شرح";
            //dgvFncRatio.Columns["Amount"].HeaderText = "مقدار";

            //dgvFncRatio.Columns["ID"].Visible = false;

        }

        private void formulaChanged(object sender, EventArgs e)
        {
            pnlFormula.CreateGraphics().Clear(Color.White);
            lblFormula.CreateGraphics().Clear(Color.PapayaWhip);
            int loci = 0;
            int loci2 = 0;
            int locj = 0;
            foreach (var s in formulaList.List)
            {
                if (loci + TextRenderer.MeasureText(s, txtDescr.Font).Width > pnlFormula.Size.Width)
                {
                    loci = 0;
                    locj += TextRenderer.MeasureText(s, txtDescr.Font).Height;
                }
                TextRenderer.DrawText(pnlFormula.CreateGraphics(), s, txtDescr.Font, new Point(loci, locj), Color.Black);
                TextRenderer.DrawText(lblFormula.CreateGraphics(), s, txtDescr.Font, new Point(loci2, 0), Color.Black);
                loci += TextRenderer.MeasureText(s, txtDescr.Font).Width;
                loci2 += TextRenderer.MeasureText(s, txtDescr.Font).Width;
                
            }
        }
        private void FillFormulaList(string Formula)
        {
            formulaList.Clear();
            int index = 0;
            int index1 = 0;
            while (index1 < Formula.Length)
            {
                if (Formula[index1] == '*' || Formula[index1] == '+' || Formula[index1] == '-' ||
                        Formula[index1] == '/' || Formula[index1] == '(' || Formula[index1] == ')')
                {
                    if (Formula.Substring(index, index1 - index) != "")
                        formulaList.Add(Formula.Substring(index, index1 - index));
                    formulaList.Add(Formula[index1].ToString());
                    index = index1 + 1;
                }
                index1++;
            }
            formulaList.Add(Formula.Substring(index));
        }
        #endregion

        #region Event

        private void frmFncRatioDaefination_Load(object sender, EventArgs e)
        {
            Init();
            Fnc_BL = new FncRatio_BL();
            stID.Clear();
            FillModel();
            FillFormula();
            ClearObjects();
            ChangeEnabled(false);
            RefreshDiagram();
            FillState();
             //FillGrid();
            //lblFormula.Visible = false;

        }
        private void txtValue_DoubleClick(object sender, EventArgs e)
        {
            if (Utilize.Helper.GeneralHelper.IsNumber(txtValue1.Text))
            {
                //LastTextFormula = formulaText.ReplaceArabicChar();
                //LastStID = stID;
                //txtFormula.SelectionStart = txtFormula.Text.ReplaceArabicChar().Length + 1;
                //int selStart = txtFormula.SelectionStart;
                //formulaText = formulaText.ReplaceArabicChar().Insert(formulaText.Length - 1, txtValue1.Text.ToString());
                //txtFormula.SelectionStart = selStart + txtValue1.Text.ToString().Length;
                stID.Add(txtValue1.Text.ToString());
                //if (stID != null)
                //    stID = stID.ToString().Insert(stID.Length, txtValue1.Text.ToString());
                //else
                //    stID = stID.ToString().Insert(0, txtValue1.Text.ToString());
                //formulaCollection.Add(txtFormula.Text.ReplaceArabicChar());
                formulaList.Add(txtValue1.Text.ToString());
            }
            else
            {
                Presentation.Public.Routines.ShowErrorMessageFa("خطا", "مقدار وارد شده عدد نمی باشد .", Public.MyDialogButton.OK);
            }
        }
        private void lbOP_DoubleClick(object sender, EventArgs e)
        {
            //if (stID.List.Count == 0 || (lsvFncRatio.SelectedItems.Count == 0  && lbOP.SelectedItem.ToString() != "("))
            //{
            //    Presentation.Public.Routines.ShowMessageBoxFa("لطفا يك گروه نوع قرارداد يا يك فرمول راانتخاب كنيد", "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //} 
            //txtFormula.SelectionStart = txtFormula.Text.ReplaceArabicChar().Length + 1;
            //int selStart = txtFormula.SelectionStart;

            //formulaText = formulaText.ReplaceArabicChar().Insert(formulaText.Length - 1, lbOP.SelectedItem.ToString());
            //txtFormula.SelectionStart = selStart + lbOP.SelectedItem.ToString().Length;
             stID.Add(lbOP.SelectedItem.ToString());
            //if (stID != null)
            //    stID = stID.ToString().Insert(stID.Length, lbOP.SelectedItem.ToString());
            //else
            //    stID = stID.ToString().Insert(0, lbOP.SelectedItem.ToString());
            //formulaCollection.Add(txtFormula.Text.ReplaceArabicChar());           
            formulaList.Add(lbOP.SelectedItem.ToString());

        }
        private void lsvFncRatio_Click(object sender, EventArgs e)
        {
            if (lsvFncRatio.SelectedItems.Count != 0)
            {
                ListViewItem lvi = lsvFncRatio.SelectedItems[0];
                FncRatioInfo ti = (FncRatioInfo)lvi.Tag;
                //txtFormula.SelectionStart = txtFormula.Text.ReplaceArabicChar().Length + 1;
                //int selStart = txtFormula.SelectionStart;
                //formulaText = formulaText.ReplaceArabicChar().Insert(formulaText.Length- 1, lsvFncRatio.SelectedItems[0].Text);
                //txtFormula.SelectionStart = selStart + lsvFncRatio.SelectedItems[0].Text.Length;
                stID.Add("dbo.fxGetFncRatioAmount( " + ti.ID + " ,-1 )");
                //if (stID != string.Empty)
                //    // if (FncRatio_Type == 1)
                //    stID = stID.ToString().Insert(stID.Length, "dbo.fxGetFncRatioAmount( " + ti.ID + " ,-1 )");
                
                ////else
                ////{
                ////    if (cmbBranch.SelectedIndex != -1)
                ////    {
                ////        stID = stID.ToString().Insert(stID.Length, "dbo.fxGetFncRatioAmount( " + ti.ID + " ," + cmbBranch.SelectedValue + ")");
                ////    }
                ////}
                //else
                //{
                //    // if (FncRatio_Type == 1)
                //    stID = stID.ToString().Insert(stID.Length, "dbo.fxGetFncRatioAmount( " + ti.ID + " ,-1 )");
                //    //else
                //    //    if (cmbBranch.SelectedIndex != -1)
                //    //    {
                //    //        stID = stID.ToString().Insert(0, "dbo.fxGetFncRatioAmount( " + ti.ID + "," + cmbBranch.SelectedValue + " )");
                //    //    }
                //}
                //formulaCollection.Add(txtFormula.Text.ReplaceArabicChar());
                formulaList.Add(lsvFncRatio.SelectedItems[0].Text);
            }
        }
        private void rdbGL_Click(object sender, EventArgs e)
        {
            if (rdbAll.Checked)
            {
                FncRatio_Type = 1;
                grbBranch.Enabled = false;
                stID.Clear(); ;
                txtDescr.Text = "";
                //formulaText = "";
                formulaList.Clear();
                cmbBranch.SelectedIndex = -1;
                cmbState.SelectedIndex = -1;

            }

        }
        private void rdbBranch_GL_Click(object sender, EventArgs e)
        {

            if (rdbState.Checked)
            {
                FncRatio_Type = 2;
                grbBranch.Enabled = true;
                stID.Clear();
                txtDescr.Text = "";
                //formulaText = "";
                formulaList.Clear();
                cmbBranch.SelectedIndex = -1;
                cmbState.SelectedIndex = -1;

            }
        }
        private void cmbState_Leave(object sender, EventArgs e)
        {
            FillBranch(cmbState.SelectedValue.ToString());
        }
        private void tsbNew_Click(object sender, EventArgs e)
        {
            ClearObjects();
            ChangeEnabled(true);
            NewFormula = true;
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveFormula();
            NewFormula = false;
            EditFormula = false;
        }
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            if (lsvFormula.SelectedItems.Count == 0)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("فرمولی برای حذف انتخاب نشده است؟",
                                    "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem lvi = lsvFormula.SelectedItems[0];
            FncRationDefinitionInfo Fnc_Info = (FncRationDefinitionInfo)lvi.Tag;
            int id = Fnc_Info.ID;
            if (Presentation.Public.Routines.ShowMessageBoxFa("عنصر انتخاب شده حذف خواهد شد. آيا مطمئن هستيد؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Fnc_BL.DeleteFncRatioFormula(id);
                if (lsvFormula.Items.Count > 0)
                    lsvFormula.Items[0].Selected = true;
                FillFormula();

            }
            ClearObjects();
            ChangeEnabled(false);
            
        }
        private void lsvFormula_Click(object sender, EventArgs e)
        {
            //if (EditFormula)
            //    if (Routines.ShowErrorMessageFa("خطا", "تغییرات اعمال شده هنوز ذخیره نشده است" + "\n" +
            //                                                "؟آیا تغییرات را ذخیره می کنید ",
            //            Public.MyDialogButton.YesNO) == MyDialogResoult.Yes)
            //            {
            //                SaveFormula();
            //                ChangeEnabled(false);
            //                    return;
            //            }

            if (lsvFormula.SelectedItems.Count != 0)
            {
                ListViewItem lvi = lsvFormula.SelectedItems[0];
                FncRationDefinitionInfo ti = (FncRationDefinitionInfo)lvi.Tag;
                formulaID = ti.ID;
                lblSelectedFormula.Text = lsvFormula.SelectedItems[0].Text;// ti.Descr;
                //lbl.Text = ti.Formula;

                txtDescr.Text = lsvFormula.SelectedItems[0].Text;
                //txtFormula.Text = ti.Formula;
                //FillPriviosText();
                FillFormulaList(ti.Formula);
                fdpStartDate.SelectedDateTime = ti.FormulaDate;
                fdpFormulaDate.SelectedDateTime = ti.FormulaDate;
                EditFormula = false;
                NewFormula = false;
                //LastTextFormula = txtFormula.Text.ReplaceArabicChar();
                //LastStID = stID;
                //txtFormula.SelectionStart = txtFormula.Text.ReplaceArabicChar().Length + 1;
                //int selStart = txtFormula.SelectionStart;
                //txtFormula.Text = txtFormula.Text.ReplaceArabicChar().Insert(txtFormula.SelectionStart, lsvFormula.SelectedItems[0].Text);
                //txtFormula.SelectionStart = selStart + lsvFormula.SelectedItems[0].Text.Length;

                //stID = stID.ToString().Insert(stID.Length, "dbo.fxGetFncRatioAmount( " + ti.ID + " , -1 )");
            }
            ChangeEnabled(false);
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (formulaList.List.Count != 0)
            {
                formulaList.RemoveLast();
                stID.RemoveLast();
            }
        }
        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAll.Checked)
            {
                grbBranch.Enabled = false;
            }
        }
        private void rdbState_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbState.Checked)
            {
                grbBranch.Enabled = true;
                cmbBranch.Visible = false;
                lblBranch.Visible = false;
            }
        }
        private void rdbBranch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBranch.Checked)
            {
                grbBranch.Enabled = true;
                cmbBranch.Visible = true;
                lblBranch.Visible = true;
            }
            if (cmbState.SelectedIndex != -1)
            {
                FillBranch(cmbState.SelectedValue.ToString());
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            ProgressBox.Show();
            try
            {
                Fnc_BL.UpdateFncModel_FormulaDate(formulaID, fdpFormulaDate.SelectedDateTime);
                if (rdbAll.Checked)
                {
                    dgvFncRatio.DataSource = Fnc_BL.GetDTFncRatiosDefinition(-1, 1, formulaID);
                    FillGrid();
                }
                else if (rdbState.Checked)
                {
                    if (chkAll.Checked)
                    {
                        dgvFncRatio.DataSource = Fnc_BL.GetDTFncRatiosDefinitionState(formulaID);
                        FillGridState();
                    }
                    else
                    {
                        if (cmbState.CheckedItems.Count == 0 || cmbState.SelectedValue == null)
                        {
                            Presentation.Public.Routines.ShowMessageBoxFa("استانی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (cmbState.CheckedItems.Count > 1)
                        {
                            string selectedStates = GetComboSelectedItems(cmbState);
                            dgvFncRatio.DataSource = Fnc_BL.GetDTFncRatiosDefinitionSomeState(formulaID, selectedStates);
                            FillGridState();
                        }
                        else
                        {
                            dgvFncRatio.DataSource = Fnc_BL.GetDTFncRatiosDefinition(Convert.ToInt32(cmbState.SelectedValue), 2, formulaID);
                            FillGrid();
                        }

                    }
                }
                else if (rdbBranch.Checked)
                {
                    if (chkAll.Checked)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        string SelectedStates = GetComboSelectedItems(cmbState);
                        dgvFncRatio.DataSource = Fnc_BL.GetDTFncRatiosDefinitionBranch(formulaID, SelectedStates);
                        FillGridBranch();
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        if (cmbBranch.SelectedIndex == -1 || cmbBranch.SelectedValue == null)
                        {
                            Presentation.Public.Routines.ShowMessageBoxFa("شعبه ای انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (cmbBranch.CheckedItems.Count > 1)
                        {
                            string selectedBranches = GetComboSelectedItems(cmbBranch);
                            dgvFncRatio.DataSource = Fnc_BL.GetDTFncRatiosDefinitionSomeBranch(formulaID, selectedBranches);
                            FillGridBranch();
                        }
                        else
                        {
                            dgvFncRatio.DataSource = Fnc_BL.GetDTFncRatiosDefinition(Convert.ToInt32(cmbBranch.SelectedValue), 3, formulaID);
                            FillGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.ToString().ToUpper().Contains("DIVIDE BY ZERO"))
                {
                    Presentation.Public.Routines.ShowErrorMessageFa("خطا",
                                                                    "در یکی از حساب ها، برای یکی از شعب/استان ها مقدار وجود ندارد. لطفا مواردانتخابی خود از شعبه یا استان را محدودتر کنید ",
                                                                    MyDialogButton.OK);

                }
                else
                {
                    Presentation.Public.Routines.ShowErrorMessageFa("خطا",
                                                                    ex.Message,
                                                                    MyDialogButton.OK);
                }
            }
            
            ProgressBox.Hide();
        }

        private void FncRatioTab_Selected(object sender, TabControlEventArgs e)
        {
            if (FncRatioTab.SelectedIndex == 0)
            {
                lsvFncRatio.Visible = true;
                lsvFormula.Visible = false;
                //lblGroup.Visible = true;
                //lblFormula.Visible = false;
                //lsvFormula.Enabled = false;
                PFormula.Visible = false;
                //lsvFncRatio.Enabled = true;
            }
            else if (FncRatioTab.SelectedIndex == 1)
            {
                lsvFncRatio.Visible = false;
                lsvFormula.Visible = true;
               // lblFormula.Visible = true;
               // lblGroup.Visible = false;
                //lsvFormula.Enabled = true;
                PFormula.Visible = true;
                FillState();
                FillFormula();
            }
        }
        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbState.SelectedIndex != -1)
            {
                FillBranch(cmbState.SelectedValue.ToString());
            }
        }
        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbState.Checked)
            {
                if (chkAll.Checked)
                {
                    cmbState.Enabled = false;
                    cmbState.SelectedIndex = -1;
                }
                else
                {
                    cmbState.Enabled = true;
                }

            }
            else if (rdbBranch.Checked)
            {
                if (chkAll.Checked)
                {
                    cmbBranch.Enabled = false;
                    cmbBranch.SelectedIndex = -1;
                    cmbState.Enabled = true;
                }
                else
                {
                    cmbBranch.Enabled = true;
                    cmbState.Enabled = true;

                }

            }
        }
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ChangeEnabled(true);
            NewFormula = false;
            EditFormula = true;
            stID.Clear();
            //txtDescr.Text = "";
            //formulaText = "";
            formulaList.Clear();
            //ListViewItem lvi = lsvFormula.SelectedItems[0];
            //FncRatioInfo Fnc_Info = (FncRatioInfo)lvi.Tag;
            //FncRatio_BL Fnc_BL = new FncRatio_BL();
            //int ReportID = Fnc_Info.ID;
            //Fnc_BL.UpdateFncRatio(Fnc_Info);
            //UpdateFncRatio(ReportID);
            
        }
        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvFncRatio;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "CreditHistoric";
        }
        #endregion

        private void tsbFourmulaRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            FillFormula();
        }

        private void tsbFormulaSave_Click(object sender, EventArgs e)
        {
            //if(fdpDate.TextSelectedDateTime==null)
            if (fdpDate.Text.Length != 10)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("تاريخ مشخص نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //PersianTools.Dates.PersianDate p2;
            //p2 = new PersianTools.Dates.PersianDate(int.Parse(fdpDate.Text.Substring(0, 4)), int.Parse(fdpDate.Text.Substring(5, 2)), int.Parse(fdpDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            //DateTime ReportDate = DateTime.Parse(p2.ToGregorian.ToString("yyyy/MM/dd"));
            if (formulaID == 0)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("فرمول مشخص نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            DataTable dt;

            dt = Fnc_BL.GetDTFncRatiosDefinition(-1, 1, formulaID);

            //    Fnc_BL.InsertFncRatioFormulaHistiric(int.Parse(dt.Rows[0]["ID"].ToString()), decimal.Parse(dt.Rows[0]["amount"].ToString()), ReportDate, -1, -1);
            Fnc_BL.InsertFncRatioFormulaHistiric(int.Parse(dt.Rows[0]["ID"].ToString()), decimal.Parse(dt.Rows[0]["amount"].ToString()), fdpDate.SelectedDateTime.ToString(), -1, -1);


            dt = Fnc_BL.GetDTState();
            DataTable dh, db;
            foreach (DataRow item in dt.Rows)
            {
                dh = Fnc_BL.GetDTFncRatiosDefinition(Convert.ToInt32(item["State_Id"]), 2, formulaID);
                /////////////////////////shoudl chek if is not null
                Fnc_BL.InsertFncRatioFormulaHistiric(int.Parse(dh.Rows[0]["ID"].ToString()), dh.Rows[0]["amount"].ToString() == "" ? 0 : decimal.Parse(dh.Rows[0]["amount"].ToString()), fdpDate.SelectedDateTime.ToString(), Convert.ToInt32(item["State_Id"]), -1);

                DataSet ds = Fnc_BL.GetDTBranch(item["State_Id"].ToString());
                foreach (DataRow t in ds.Tables[0].Rows)
                {

                    db = Fnc_BL.GetDTFncRatiosDefinition(Convert.ToInt32(t["Branch"]), 3, formulaID);
                    Fnc_BL.InsertFncRatioFormulaHistiric(int.Parse(db.Rows[0]["ID"].ToString()), db.Rows[0]["amount"].ToString() == "" ? 0 : decimal.Parse(db.Rows[0]["amount"].ToString()), fdpDate.SelectedDateTime.ToString(), Convert.ToInt32(item["State_Id"]), Convert.ToInt32(t["branch"]));
                    
                }

            }
            Presentation.Public.Routines.ShowMessageBoxFa("نسبت مالی با موفقيت ذخيره شد", "ذخيره", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgvFncRatio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FncRatioTab_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            if(FncRatioTab.SelectedIndex == 0)
            {
                //splitContainer3.Panel1Collapsed = true;
                //lsvFncRatio.Visible = true;
                //lsvFncRatio.Dock = DockStyle.Fill;
                //lsvFncRatio.BringToFront();
            }
        else
            {
                //splitContainer3.Panel1Collapsed = false;
                //lsvFormula.Visible = true;
                //lsvFormula.Dock = DockStyle.Fill;
                //lsvFormula.BringToFront();
                
            }
        }


        private void txtValue_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tsbRefreshFormula_Click(object sender, EventArgs e)
        {
            
        }


        private void tsbRefreshFormulas_Click(object sender, EventArgs e)
        {
            FillFormula();
        }



        private void cButton1_CButtonClicked(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(cButton1.Location.X, cButton1.Location.Y);
        }

        private void undoAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cButton1_Load(object sender, EventArgs e)
        {

        }

        private void cbInsertOp_CButtonClicked(object sender, EventArgs e)
        {
            lbOP_DoubleClick(sender, e); 
        }



        private void cmbBranch_VisibleChanged(object sender, EventArgs e)
        {
            if (cmbBranch.Visible)
            {
                chkAll.Location = new Point(chkAll.Location.X, cmbBranch.Location.Y);
            }
            else
            {
                chkAll.Location = new Point(chkAll.Location.X, cmbState.Location.Y);
            }
        }

        

        class MList<TEntity> where TEntity : class 
        {
            readonly List<TEntity> _list = new List<TEntity>();
            public event EventHandler<EventArgs> ItemChanging;
            public event EventHandler<EventArgs> ItemChanged;

            public void Add(TEntity entity)
            {
                if (ItemChanging != null)
                    ItemChanging.Invoke(this, new EventArgs());
                _list.Add(entity);
                if (ItemChanged != null)
                    ItemChanged.Invoke(this, new EventArgs());
            }
            public void RemoveLast()
            {
                if (ItemChanging != null)
                    ItemChanging.Invoke(this, new EventArgs());
                _list.RemoveAt(_list.Count-1);
                if (ItemChanged != null)
                    ItemChanged.Invoke(this, new EventArgs());
            }
            public void Clear()
            {
                if (ItemChanging != null)
                    ItemChanging.Invoke(this, new EventArgs());
                _list.Clear();
                if (ItemChanged != null)
                    ItemChanged.Invoke(this, new EventArgs());
            }
            public override string ToString()
            {
                string result = "";
                foreach (var s in _list)
                    result += s.ToString();
                return result;
            }
            public List<TEntity> List { get { return _list; } }
            //public static void ForEach<T>(this IEnumerable<T> data, Action<T> action)
            //{
            //    if (data == null) return;
            //    foreach (var variable in data)
            //    {
            //        action(variable);
            //    }
            //}

        }

        private void pnlFormula_Paint(object sender, PaintEventArgs e)
        {
            formulaChanged(null, null);
        }

        private void lblFormula_MouseHover(object sender, EventArgs e)
        {
        }

        public string GetComboSelectedItems(Utilize.Company.CComboCox ComBox)
        {
            string SelectedItems = "(";
            var SelectedItemsAr = ComBox.CheckedItems;
            foreach (var Item in SelectedItemsAr)
            {
                SelectedItems += Item.DataValue.ToString() + ",";
            }
            SelectedItems = SelectedItems.Remove(SelectedItems.Length - 1, 1);
            SelectedItems += ")";

            return SelectedItems;
        }


    }

    
}