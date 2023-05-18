using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Dundas.Charting.WinControl;

//  

using ERMSLib;
using System.Xml;
using System.Linq;
using ERMS.Logic;
using ERMS.Model;
using Presentation.Public;
using Utilize.Helper;

namespace Presentation.Tabs.CreditRisk
{
    public partial class frmCreditReportHistoric : BaseForm, IPrintable
    { 
        #region vars
        private CRP crp;
        private int curModelID = -1;
        PersianTools.Dates.PersianDate P;
        private CRP CRP_BL;
        int obSelected;
        DataTable dtGroups = new DataTable();
        #endregion

        public frmCreditReportHistoric()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
            GeneralDataGridView = dgvGroup;
        }
        private void Init()
        {
            crp = new CRP();
            //cmbGroupBy.AddItemsRange(new string[] { "نوع قرارداد", "بخش اقتصادی", "نوع مشتری", "گروه مشتری", "استان", "شعبه", "نوع کلی قرارداد", "نوع اصلی قرارداد تسهیلات", "وضعیت قرارداد تسهیلات" });
            //cmbGroupBy.AddItemsRange(new string[] { "نوع قرارداد", "بخش اقتصادی", "نوع مشتری", "گروه مشتری", "وضعیت قرارداد", "شعبه", "نوع کلی قرارداد", "نوع اصلی قرارداد تسهیلات", "وضعیت قرارداد تسهیلات" });
            cmbGroupBy.AddItemsRange(new string[] { "نوع قرارداد", "بخش اقتصادی", "نوع مشتری", "گروه مشتری", "استان", "شعبه", "نوع کلی قرارداد", "نوع اصلی قرارداد", "وضعیت قرارداد" });
            cmbGroupBy.SelectedIndex = 1;
            //pnlGroup.Visible = false;

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;
            FillModel();

        }
        private void frmCreditReport_Load(object sender, EventArgs e)
        {
            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

            fdpStartDate.SelectedDateTime = DateTime.Now;
            fdpStartDate.ResetSelectedDateTime();
            Init();
            GeneralDataGridView = dgvGroup;
        }
        private void FillModel()
        {
            int flag = 0;
            if (fdpStartDate.Text.Length < 11)
            {
                flag = 1;
                //PersianTools.Dates.PersianDate p1;
                //p1 = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                //DateTime ModelDate = DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));
                FillModelDate(fdpStartDate.SelectedDateTime, flag);
            }
            else
            {
                FillModelDate(null, flag);
            }
        }
        private void FillModelDate(DateTime? ModelDate, int flag)
        {
            lsvModel.Items.Clear();
            DataTable dt = crp.GetCRPReport(ModelDate, flag);
            foreach (DataRow dr in dt.Rows)
            {
                CRPReportInfo ci = new CRPReportInfo();
                crp.CloneXCRPReport(dr, ci, ECloneXdir.DR2Info);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = ci.ModelName;
                lvi.Tag = ci;
                lsvModel.Items.Add(lvi);
            }
        }
        private void cmbGroupBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            obSelected = cmbGroupBy.SelectedIndex;
            if (rdoGapReportDate.Checked == true)
            {
                if (cmbGroupBy.SelectedIndex >= 2)
                { obSelected = cmbGroupBy.SelectedIndex + 1; }
                DoProcess(obSelected, 1);
            }
            else if (rdoFocusRisk.Checked == true)
            {
                if (cmbGroupBy.SelectedIndex >= 2)
                { obSelected = cmbGroupBy.SelectedIndex + 1; }
                DoProcess(obSelected, 2);
            }
        }
        private void DoProcess(int groupBy, int ReportType)
        {
            try
            {
                Helper h = new Helper();
                h.FormatDataGridView(dgvGroup);

                //dgvGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.;
                switch (ReportType)
                {
                    case 1:
                        //dgvGroup.DataSource = null; 
                        //DataTable dtGroups =new DAL.CRP_DataSet().GetDT_CRP_Report_Result(curModelID, groupBy);
                        //dtGroups.Columns["GroupDesc"].ColumnName = "عنوان گروه";
                        //dtGroups.Columns["EL"].ColumnName = "سرمايه اقتصادي";
                        //dtGroups.Columns.Remove("EC");
                        //dtGroups.Columns.Remove("ID");
                        //dtGroups.Columns.Remove("ReportModelId");
                        //dtGroups.Columns.Remove("GroupName");
                        //dtGroups.Columns.Remove("GroupId");
                        //dtGroups.Columns.Remove("ReportDate");
                        //dgvGroup.DataSource = dtGroups;
                        //lblTotalEC.Text = "";
                        //RefreshChart(dtGroups, "عنوان گروه");
                        break;
                    case 2:
                        dgvGroup.DataSource = null;

                        dtGroups = crp.GetFocusRiskReport(curModelID, groupBy);
                        dtGroups.Columns["Group_Desc"].ColumnName = "عنوان گروه";
                        dtGroups.Columns["Remaining_Amount"].ColumnName = "سهم  " + cmbGroupBy.Text.ToString() +
                                                                          "   از مانده تسهيلات";
                        dtGroups.Columns["TotalOverdue"].ColumnName = "سهم " + cmbGroupBy.Text.ToString() +
                                                                      "  از كل معوقات";
                        dtGroups.Columns["EL"].ColumnName = "سهم " + cmbGroupBy.Text.ToString() + " از ذخیره م.م";
                        dtGroups.Columns["TotalOverdueRemaining"].ColumnName = " نسبت معوقات به مانده تسهیلات  " +
                                                                               cmbGroupBy.Text.ToString();
                        dtGroups.Columns["Overdue1"].ColumnName = "سهم  " + cmbGroupBy.Text.ToString() +
                                                                  "   از مطالبات سررسیدگذشته";
                        dtGroups.Columns["Overdue2"].ColumnName = "سهم  " + cmbGroupBy.Text.ToString() +
                                                                  "   از مطالبات معوق";
                        dtGroups.Columns["Overdue3"].ColumnName = "سهم  " + cmbGroupBy.Text.ToString() +
                                                                  "   از مطالبات مشکوک الوصول";
                        dgvGroup.DataSource = dtGroups;
                        dtGroups = dtGroups.Trim();
                        RefreshChart(dtGroups, "عنوان گروه");
                        lblTotalEC.Text = crp.GetTotalECReport(curModelID).ToString("###,###.###");
                        break;
                    case 3:
                        dgvGroup.DataSource = null;
                        DataTable dtState = crp.GetCreditReportState(curModelID);
                        dtState.Columns["Group_Desc"].ColumnName = "نام استان";
                        dtState.Columns["CreditState"].ColumnName = "شاخص ریسک اعتباری";
                        dtState.Columns.Remove("Group_Id");
                        dgvGroup.DataSource = dtState;
                        dtState = dtState.Trim();
                        RefreshChart(dtState, "نام استان");

                        break;

                }
            }
            catch (Exception ex)
            {
                Utilize.Routines.ShowErrorMessageFa("خطا", ex.Message, Utilize.MyDialogButton.OK);
            }

        }

        private void RefreshChart(DataTable dtChart, string xColumn)
        {
            try
            {

                ucChart1.ChartType = SeriesChartType.Column;
                ucChart1.X = xColumn;
                ucChart1.DataSource = dtChart;
            }
            catch
            {
                Presentation.Public.Routines.ShowMessageBoxFa("برنامه با خطا روبرو شده است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        //private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (lsvModel.SelectedItems.Count > 0)
        //    {
        //        CRPReportInfo ci = (CRPReportInfo)lsvModel.SelectedItems[0].Tag;
        //        dgvGroup.DataSource = null;
        //        curModelID = ci.ID;

        //        int count = 0;
        //        // Warning in ContextMenu_LsModel chie akhe? hame ro cmt kardam
        //        //hgr Warn //ContextMenu_LsModel.Items.Clear();
        //        for (int i = 0; i < lsvModel.Items.Count; i++)
        //        {
        //            if (lsvModel.Items[i].Tag != lsvModel.SelectedItems[0].Tag)
        //            {
        //                //hgr Warn //ContextMenu_LsModel.Items.Add(lsvModel.Items[i].Text);
        //                //hgr Warn //ContextMenu_LsModel.Items[count].Tag = ((CRPReportInfo)lsvModel.Items[i].Tag).ID;
        //                //hgr Warn //ContextMenu_LsModel.Items[count].Click += new System.EventHandler(this.btnContextMenu_Click);

        //                count++;
        //            }


        //        }

        //        if (rdoGapReportDate.Checked == true)
        //        {
        //            //if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
        //            //{
        //            //    if (lsvModel.SelectedItems.Count > 0)
        //            //    {
        //            //        if (cmbGroupBy.SelectedIndex == -1)
        //            //        {
        //            //            cmbGroupBy.SelectedIndex = 1;
        //            //            DoProcess(cmbGroupBy.SelectedIndex, 1);
        //            //        }
        //            //        else if (cmbGroupBy.SelectedIndex == 0 || cmbGroupBy.SelectedIndex == 1)
        //            //        {

        //            //            DoProcess(cmbGroupBy.SelectedIndex, 1);
        //            //        }
        //            //        else
        //            //            DoProcess(cmbGroupBy.SelectedIndex + 1, 1);
        //            //        return;
        //            //    }
        //            //}
        //        }
        //        else if (rdoFocusRisk.Checked == true)
        //        {
        //            lblReport.Text = rdoFocusRisk.Text;
        //            dgvGroup.DataSource = "";
        //            if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
        //            {
        //                if (lsvModel.SelectedItems.Count > 0)
        //                {
        //                    if (cmbGroupBy.SelectedIndex == -1)
        //                    {
        //                        cmbGroupBy.SelectedIndex = 1;
        //                        DoProcess(cmbGroupBy.SelectedIndex, 2);
        //                    }
        //                    else if (cmbGroupBy.SelectedIndex == 0 || cmbGroupBy.SelectedIndex == 1)
        //                    {

        //                        DoProcess(cmbGroupBy.SelectedIndex, 2);
        //                    }
        //                    else
        //                        DoProcess(cmbGroupBy.SelectedIndex + 1, 2);
        //                    return;
        //                }
        //            }
        //        }
        //        else if (rdbState.Checked == true)
        //        {
        //            pnlGroup.Visible = false;
        //            // 5 for state is temporary
        //            DoProcess(5, 3);
        //        }



        //    }
        //}
        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                CRPReportInfo ci = (CRPReportInfo)lsvModel.SelectedItems[0].Tag;
                lblReport.Text = rdoGapReportDate.Text + "  در تاريخ";
                dgvGroup.DataSource = null;

                // P = new PersianTools.Dates.PersianDate((DateTime)ci.ReportDate);
                //lblDate.Text = P.ToGregorian.ToString();
                curModelID = ci.ID;

                int count = 0;
                ContextMenu_LsModel.Items.Clear();
                for (int i = 0; i < lsvModel.Items.Count; i++)
                {
                    if (lsvModel.Items[i].Tag != lsvModel.SelectedItems[0].Tag)
                    {
                        ContextMenu_LsModel.Items.Add(lsvModel.Items[i].Text);
                        ContextMenu_LsModel.Items[count].Tag = ((CRPReportInfo)lsvModel.Items[i].Tag).ID;
                        ContextMenu_LsModel.Items[count].Click += new System.EventHandler(this.btnContextMenu_Click);

                        count++;
                    }


                }

                if (rdoGapReportDate.Checked == true)
                {
                    if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
                    {
                        if (lsvModel.SelectedItems.Count > 0)
                        {
                            if (cmbGroupBy.SelectedIndex == -1)
                            {
                                cmbGroupBy.SelectedIndex = 1;
                                DoProcess(cmbGroupBy.SelectedIndex, 1);
                            }
                            else if (cmbGroupBy.SelectedIndex == 0 || cmbGroupBy.SelectedIndex == 1)
                            {

                                DoProcess(cmbGroupBy.SelectedIndex, 1);
                            }
                            else
                                DoProcess(cmbGroupBy.SelectedIndex + 1, 1);
                            return;
                        }
                    }
                }
                else if (rdoFocusRisk.Checked == true)
                {
                    lblReport.Text = rdoFocusRisk.Text;
                    dgvGroup.DataSource = "";
                    if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
                    {
                        if (lsvModel.SelectedItems.Count > 0)
                        {
                            if (cmbGroupBy.SelectedIndex == -1)
                            {
                                cmbGroupBy.SelectedIndex = 1;
                                DoProcess(cmbGroupBy.SelectedIndex, 2);
                            }
                            else if (cmbGroupBy.SelectedIndex == 0 || cmbGroupBy.SelectedIndex == 1)
                            {

                                DoProcess(cmbGroupBy.SelectedIndex, 2);
                            }
                            else
                                DoProcess(cmbGroupBy.SelectedIndex + 1, 2);
                            return;
                        }
                    }
                }
                else if (rdbState.Checked == true)
                {
                    pnlGroup.Visible = false;
                    // 5 for state is temporary
                    DoProcess(5, 3);
                }



            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            FillModel();
        }
        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvGroup;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "CreditHistoric";
        }
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (Presentation.Public.Routines.ShowMessageBoxFa("آیا از حذف مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListViewItem lvi = lsvModel.SelectedItems[0];
                CRPReportInfo CRP_Info = (CRPReportInfo)lvi.Tag;
                CRP_BL = new CRP();
                int ReportID = CRP_Info.ID;
                CRP_BL.DeleteCRP_Report(ReportID);
                FillModel();
            }
        }

        private void rdbState_Click(object sender, EventArgs e)
        {
            lblDate.Visible = false;
            //pnlGroup.Visible = false;l
            // 5 for state is temporary
            DoProcess(5, 3);

        }

        private void rdoFocusRisk_Click(object sender, EventArgs e)
        {
            //pnlGroup.Visible = true;
            lblDate.Visible = false;
        }

        private void rdoGapReportDate_Click(object sender, EventArgs e)
        {
            //pnlGroup.Visible = true;
            //lblDate.Visible = true;
        }

        String culomnName = "";

        bool isCell = true;

        private void dgvGroup_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (rdoFocusRisk.Checked)
            {
                //hgr Warn //ContextMenu_LsModel.Visible = true;
            }
            else
            {
                //hgr Warn //ContextMenu_LsModel.Visible = false;
            }
        }



        private void dgvGroup_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (rdoFocusRisk.Checked)
            {
                //hgr Warn //ContextMenu_LsModel.Visible = false;
            }
            else
            {
                //hgr Warn //ContextMenu_LsModel.Visible = false;
            }
        }

        private void btnContextMenu_Click(object sender, EventArgs e)
        {

            var dtGroupsOld = new DAL.SwartDataSetTableAdapters.GetDT_CRP_Focus_Risk_ReportTableAdapter().GetData((int)((System.Windows.Forms.ToolStripMenuItem)sender).Tag, cmbGroupBy.SelectedIndex); ;
            var dtGroupsCur = new DAL.SwartDataSetTableAdapters.GetDT_CRP_Focus_Risk_ReportTableAdapter().GetData(curModelID, cmbGroupBy.SelectedIndex); ;

            if (cmbGroupBy.SelectedIndex == -1)
            {
                cmbGroupBy.SelectedIndex = 1;

                dtGroupsOld = new DAL.SwartDataSetTableAdapters.GetDT_CRP_Focus_Risk_ReportTableAdapter().GetData((int)((System.Windows.Forms.ToolStripMenuItem)sender).Tag, cmbGroupBy.SelectedIndex);
                dtGroupsCur = new DAL.SwartDataSetTableAdapters.GetDT_CRP_Focus_Risk_ReportTableAdapter().GetData(curModelID, cmbGroupBy.SelectedIndex);

            }
            else if (cmbGroupBy.SelectedIndex == 0 || cmbGroupBy.SelectedIndex == 1)
            {

                dtGroupsOld = new DAL.SwartDataSetTableAdapters.GetDT_CRP_Focus_Risk_ReportTableAdapter().GetData((int)((System.Windows.Forms.ToolStripMenuItem)sender).Tag, cmbGroupBy.SelectedIndex);
                dtGroupsCur = new DAL.SwartDataSetTableAdapters.GetDT_CRP_Focus_Risk_ReportTableAdapter().GetData(curModelID, cmbGroupBy.SelectedIndex);

            }
            else
            {

                dtGroupsOld = new DAL.SwartDataSetTableAdapters.GetDT_CRP_Focus_Risk_ReportTableAdapter().GetData((int)((System.Windows.Forms.ToolStripMenuItem)sender).Tag, cmbGroupBy.SelectedIndex + 1);
                dtGroupsCur = new DAL.SwartDataSetTableAdapters.GetDT_CRP_Focus_Risk_ReportTableAdapter().GetData(curModelID, cmbGroupBy.SelectedIndex + 1);

            }

            Func<double, bool, string> getValue = new Func<double, bool, string>((value, isDif) =>
            {
                if (isDif)
                {
                    if (value > 100)
                        return string.Format("{0:##.##}", value - 100);
                    else if (value < 100)
                        return string.Format("{0:##.##}", 100 - value);
                }
                else
                {
                    return value.ToString();
                }
                return "";
            });


            Func<DAL.SwartDataSet.GetDT_CRP_Focus_Risk_ReportRow, DAL.SwartDataSet.GetDT_CRP_Focus_Risk_ReportRow, string, bool, string> getRatio =
                new Func<DAL.SwartDataSet.GetDT_CRP_Focus_Risk_ReportRow, DAL.SwartDataSet.GetDT_CRP_Focus_Risk_ReportRow, string, bool, string>((dgC, gOLD, ty, isDif) =>
                {

                    decimal value2;
                    double value;
                    switch (ty)
                    {


                        case "Remaining_Amount":
                            {

                                if (gOLD.IsRemaining_AmountNull())
                                    return "داده وجود ندارد";
                                else if (gOLD.Remaining_Amount == 0)
                                    return getValue(200, isDif);
                                else if (dgC.IsRemaining_AmountNull())
                                    return "داده وجود ندارد";
                                else
                                {

                                    value = Convert.ToDouble(dgC.Remaining_Amount / gOLD.Remaining_Amount) * 100;
                                    return getValue(value, isDif);
                                }

                            } break;
                        case "TotalOverdue":
                            {

                                if (gOLD.IsTotalOverdueNull())
                                    return "داده وجود ندارد";
                                else if (gOLD.TotalOverdue == 0)
                                    return getValue(200, isDif);
                                else if (dgC.IsTotalOverdueNull())
                                    return "داده وجود ندارد";
                                else
                                {

                                    value = Convert.ToDouble(dgC.TotalOverdue / gOLD.TotalOverdue) * 100;
                                    return getValue(value, isDif);
                                }
                            } break;
                        case "TotalOverdueRemaining":
                            {

                                if (gOLD.IsTotalOverdueRemainingNull())
                                    return "داده وجود ندارد";
                                else if (gOLD.TotalOverdueRemaining == 0)
                                    return getValue(200, isDif);
                                else if (dgC.IsTotalOverdueRemainingNull())
                                    return "داده وجود ندارد";
                                else
                                {

                                    value = Convert.ToDouble(dgC.TotalOverdueRemaining / gOLD.TotalOverdueRemaining) * 100;
                                    return getValue(value, isDif);

                                }
                            } break;
                        case "EL":
                            {

                                if (gOLD.IsTotalOverdueRemainingNull())
                                    return "داده وجود ندارد";
                                else if (gOLD.EL == 0)
                                    return getValue(200, isDif);
                                else if (dgC.IsELNull())
                                    return "داده وجود ندارد";
                                else
                                {

                                    value = Convert.ToDouble(dgC.EL / gOLD.EL) * 100;
                                    return getValue(value, isDif);

                                }

                            } break;
                        case "Overdue1":
                            {

                                if (gOLD.IsTotalOverdueRemainingNull())
                                    return "داده وجود ندارد";
                                else if (gOLD.Overdue1 == 0)
                                    return getValue(200, isDif);
                                else if (dgC.IsOverdue1Null())
                                    return "داده وجود ندارد";
                                else
                                {

                                    value = Convert.ToDouble(dgC.Overdue1 / gOLD.Overdue1) * 100;
                                    return getValue(value, isDif);

                                }
                            } break;
                        case "Overdue2":
                            {

                                if (gOLD.IsTotalOverdueRemainingNull())
                                    return "داده وجود ندارد";
                                else if (gOLD.Overdue2 == 0)
                                    return getValue(200, isDif);
                                else if (dgC.IsOverdue2Null())
                                    return "داده وجود ندارد";
                                else
                                {

                                    value = Convert.ToDouble(dgC.Overdue2 / gOLD.Overdue2) * 100;
                                    return getValue(value, isDif);

                                }
                            } break;
                        case "Overdue3":
                            {

                                if (gOLD.IsTotalOverdueRemainingNull())
                                    return "داده وجود ندارد";
                                else if (gOLD.Overdue3 == 0)
                                    return getValue(200, isDif);
                                else if (dgC.IsOverdue3Null())
                                    return "داده وجود ندارد";
                                else
                                {

                                    value = Convert.ToDouble(dgC.Overdue3 / gOLD.Overdue3) * 100;
                                    return getValue(value, isDif);
                                }
                            } break;
                    }
                    return "";
                });




            var aaa = dtGroupsOld.Join(dtGroupsCur, gOLD => gOLD.Group_Desc, dgC => dgC.Group_Desc,
                (gOLD, dgC) => new
                {
                    Group_Desc = dgC.Group_Desc,

                    Remaining_Amount = dgC.IsRemaining_AmountNull() ? 0 : dgC.Remaining_Amount,
                    Remaining_Amount_Dif = getRatio(dgC, gOLD, "Remaining_Amount", true),
                    TotalOverdue = dgC.IsTotalOverdueNull() ? 0 : dgC.TotalOverdue,
                    TotalOverdue_Dif = getRatio(dgC, gOLD, "TotalOverdue", true),
                    TotalOverdueRemaining = dgC.IsTotalOverdueRemainingNull() ? 0 : dgC.TotalOverdueRemaining,
                    TotalOverdueRemaining_Dif = getRatio(dgC, gOLD, "TotalOverdueRemaining", true),
                    EL = dgC.IsELNull() ? 0 : dgC.EL,
                    EL_Dif = getRatio(dgC, gOLD, "EL", true),
                    Overdue1 = dgC.IsOverdue1Null() ? 0 : dgC.Overdue1,
                    Overdue1_Dif = getRatio(dgC, gOLD, "Overdue1", true),
                    Overdue2 = dgC.IsOverdue2Null() ? 0 : dgC.Overdue2,
                    Overdue2_Dif = getRatio(dgC, gOLD, "Overdue2", true),
                    Overdue3 = dgC.IsOverdue3Null() ? 0 : dgC.Overdue3,
                    Overdue3_Dif = getRatio(dgC, gOLD, "Overdue3", true),
                });

            var Dif = dtGroupsOld.Join(dtGroupsCur, gOLD => gOLD.Group_Desc, dgC => dgC.Group_Desc,
             (gOLD, dgC) => new
             {
                 Group_Desc = dgC.Group_Desc,

                 Remaining_Amount_Dif = getRatio(dgC, gOLD, "Remaining_Amount", false),
                 TotalOverdue_Dif = getRatio(dgC, gOLD, "TotalOverdue", false),
                 TotalOverdueRemaining_Dif = getRatio(dgC, gOLD, "TotalOverdueRemaining", false),
                 EL_Dif = getRatio(dgC, gOLD, "EL", false),
                 Overdue1_Dif = getRatio(dgC, gOLD, "Overdue1", false),
                 Overdue2_Dif = getRatio(dgC, gOLD, "Overdue2", false),
                 Overdue3_Dif = getRatio(dgC, gOLD, "Overdue3", false)
             });

            Helper h = new Helper();
            h.FormatDataGridView(dgvGroup);
            //dgvGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGroup.DataSource = null;


            dgvGroup.DataSource = aaa.ToArray();
            dgvGroup.Columns["Group_Desc"].HeaderText = "عنوان گروه";
            dgvGroup.Columns["Remaining_Amount"].HeaderText = "سهم  " + cmbGroupBy.Text.ToString() + "   از مانده تسهيلات";
            dgvGroup.Columns["Remaining_Amount_Dif"].HeaderText = "درصد رشد  " + cmbGroupBy.Text.ToString() + "   از مانده تسهيلات";
            dgvGroup.Columns["TotalOverdue"].HeaderText = "سهم " + cmbGroupBy.Text.ToString() + "  از كل معوقات";
            dgvGroup.Columns["TotalOverdue_Dif"].HeaderText = "درصد رشد  " + cmbGroupBy.Text.ToString() + "  از كل معوقات";
            dgvGroup.Columns["EL"].HeaderText = "سهم " + cmbGroupBy.Text.ToString() + " از ذخیره م.م";
            dgvGroup.Columns["EL_Dif"].HeaderText = "درصد رشد  " + cmbGroupBy.Text.ToString() + " از ذخیره م.م";
            dgvGroup.Columns["TotalOverdueRemaining"].HeaderText = " نسبت معوقات به مانده تسهیلات  " + cmbGroupBy.Text.ToString();
            dgvGroup.Columns["TotalOverdueRemaining_Dif"].HeaderText = "درصد رشد  " + " نسبت معوقات به مانده تسهیلات  " + cmbGroupBy.Text.ToString(); ;
            dgvGroup.Columns["Overdue1"].HeaderText = "سهم  " + cmbGroupBy.Text.ToString() + "   از مطالبات سررسیدگذشته";
            dgvGroup.Columns["Overdue1_Dif"].HeaderText = "درصد رشد  " + cmbGroupBy.Text.ToString() + "   از مطالبات سررسیدگذشته";
            dgvGroup.Columns["Overdue2"].HeaderText = "سهم  " + cmbGroupBy.Text.ToString() + "   از مطالبات معوق";
            dgvGroup.Columns["Overdue2_Dif"].HeaderText = "درصد رشد  " + cmbGroupBy.Text.ToString() + "   از مطالبات معوق";
            dgvGroup.Columns["Overdue3"].HeaderText = "سهم  " + cmbGroupBy.Text.ToString() + "   از مطالبات مشکوک الوصول";
            dgvGroup.Columns["Overdue3_Dif"].HeaderText = "درصد رشد  " + cmbGroupBy.Text.ToString() + "   از مطالبات مشکوک الوصول";

            int index = 0;
            foreach (var item in Dif)
            {
                if (!item.EL_Dif.Equals(""))
                {
                    if (item.EL_Dif.Equals("داده وجود ندارد"))
                        dgvGroup.Rows[index].Cells["EL_Dif"].Style.BackColor = Color.Yellow;
                    else if (Convert.ToDouble(item.EL_Dif) < 100)
                        dgvGroup.Rows[index].Cells["EL_Dif"].Style.BackColor = Color.Red;
                    else if (Convert.ToDouble(item.EL_Dif) > 100)
                        dgvGroup.Rows[index].Cells["EL_Dif"].Style.BackColor = Color.Chartreuse;
                }


                if (!item.Overdue1_Dif.Equals(""))
                {
                    if (item.Overdue1_Dif.Equals("داده وجود ندارد"))
                        dgvGroup.Rows[index].Cells["Overdue1_Dif"].Style.BackColor = Color.Yellow;
                    else if (Convert.ToDouble(item.Overdue1_Dif) < 100)
                        dgvGroup.Rows[index].Cells["Overdue1_Dif"].Style.BackColor = Color.Red;
                    else if (Convert.ToDouble(item.Overdue1_Dif) > 100)
                        dgvGroup.Rows[index].Cells["Overdue1_Dif"].Style.BackColor = Color.Chartreuse;
                }

                if (!item.Overdue2_Dif.Equals(""))
                {
                    if (item.Overdue2_Dif.Equals("داده وجود ندارد"))
                        dgvGroup.Rows[index].Cells["Overdue2_Dif"].Style.BackColor = Color.Yellow;
                    else if (Convert.ToDouble(item.Overdue2_Dif) < 100)
                        dgvGroup.Rows[index].Cells["Overdue2_Dif"].Style.BackColor = Color.Red;
                    else if (Convert.ToDouble(item.Overdue2_Dif) > 100)
                        dgvGroup.Rows[index].Cells["Overdue2_Dif"].Style.BackColor = Color.Chartreuse;
                }

                if (!item.Overdue3_Dif.Equals(""))
                {
                    if (item.Overdue3_Dif.Equals("داده وجود ندارد"))
                        dgvGroup.Rows[index].Cells["Overdue3_Dif"].Style.BackColor = Color.Yellow;
                    else if (Convert.ToDouble(item.Overdue3_Dif) < 100)
                        dgvGroup.Rows[index].Cells["Overdue3_Dif"].Style.BackColor = Color.Red;
                    else if (Convert.ToDouble(item.Overdue3_Dif) > 100)
                        dgvGroup.Rows[index].Cells["Overdue3_Dif"].Style.BackColor = Color.Chartreuse;
                }

                if (!item.Remaining_Amount_Dif.Equals(""))
                {
                    if (item.Remaining_Amount_Dif.Equals("داده وجود ندارد"))
                        dgvGroup.Rows[index].Cells["Remaining_Amount_Dif"].Style.BackColor = Color.Yellow;
                    else if (Convert.ToDouble(item.Remaining_Amount_Dif) < 100)
                        dgvGroup.Rows[index].Cells["Remaining_Amount_Dif"].Style.BackColor = Color.Red;
                    else if (Convert.ToDouble(item.Remaining_Amount_Dif) > 100)
                        dgvGroup.Rows[index].Cells["Remaining_Amount_Dif"].Style.BackColor = Color.Chartreuse;
                }

                if (!item.TotalOverdue_Dif.Equals(""))
                {
                    if (item.TotalOverdue_Dif.Equals("داده وجود ندارد"))
                        dgvGroup.Rows[index].Cells["TotalOverdue_Dif"].Style.BackColor = Color.Yellow;
                    else if (Convert.ToDouble(item.TotalOverdue_Dif) < 100)
                        dgvGroup.Rows[index].Cells["TotalOverdue_Dif"].Style.BackColor = Color.Red;
                    else if (Convert.ToDouble(item.TotalOverdue_Dif) > 100)
                        dgvGroup.Rows[index].Cells["TotalOverdue_Dif"].Style.BackColor = Color.Chartreuse;
                }

                if (!item.TotalOverdueRemaining_Dif.Equals(""))
                {
                    if (item.TotalOverdueRemaining_Dif.Equals("داده وجود ندارد"))
                        dgvGroup.Rows[index].Cells["TotalOverdueRemaining_Dif"].Style.BackColor = Color.Yellow;
                    else if (Convert.ToDouble(item.TotalOverdueRemaining_Dif) < 100)
                        dgvGroup.Rows[index].Cells["TotalOverdueRemaining_Dif"].Style.BackColor = Color.Red;
                    else if (Convert.ToDouble(item.TotalOverdueRemaining_Dif) > 100)
                        dgvGroup.Rows[index].Cells["TotalOverdueRemaining_Dif"].Style.BackColor = Color.Chartreuse;
                }



                index++;
            }

            lblTotalEC.Text = crp.GetTotalECReport(curModelID).ToString("###,###.###");

        }

        private void dgvGroup_MouseClick(object sender, MouseEventArgs e)
        {
            //hgr Warn //ContextMenu_LsModel.Visible = false;

        }

        private void pnlGroup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdoGapReportDate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoGapReportDate_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoGapReportDate.Checked)
            {
                pnlGroup.Visible = false;
                spcAll.Panel1Collapsed = true;
                FillGridHistoricEC();
            }
            else
            {
                pnlGroup.Visible = true;
                spcAll.Panel1Collapsed = false;
            }
        }

        public void FillGridHistoricEC()
        {
            dgvGroup.DataSource = null;
            dtGroups = crp.GetDT_CRP_Report_HistoricEC();


            dtGroups.Columns["CRP_Model_Name"].ColumnName = "نام مدل";
            dtGroups.Columns["L"].ColumnName = "حجم ریالی";
            dtGroups.Columns["CL"].ColumnName = "سطح اطمینان";
            dtGroups.Columns["AlphaLevel"].ColumnName = "سطح آلفا";
            //dtGroups.Columns["LossCount"].ColumnName = "تعداد زیان";
            //dtGroups.Columns["ReportDate"].ColumnName = "تاریخ";
            dtGroups.Columns["TotalECBank"].ColumnName = "سرمایه اقتصادی کل";
            dtGroups.Columns["VaR"].ColumnName = "VaR";
            dtGroups.Columns["EL"].ColumnName = "زیان مورد انتظار کل";
            dtGroups.Columns["StdVar"].ColumnName = "انحراف معیار کل";
            dgvGroup.DataSource = dtGroups;
            dgvGroup.Columns["CRP_Model_Id"].Visible = false;
            dgvGroup.Columns["LossCount"].Visible = false;
            dgvGroup.Columns["ID"].Visible = false;
            dgvGroup.Columns["ReportDate"].Visible = false;



            DataTable dtChart = dtGroups.Copy();
            dtChart.Columns.Remove("حجم ریالی");
            dtChart.Columns.Remove("سطح اطمینان");
            dtChart.Columns.Remove("سطح آلفا");
            dtChart.Columns.Remove("LossCount");
            dtChart.Columns.Remove("CRP_Model_Id");
            dtChart.Columns.Remove("ID");
            dtChart.Columns.Remove("ReportDate");

            RefreshChart(dtChart, "نام مدل");
        }



    }
}