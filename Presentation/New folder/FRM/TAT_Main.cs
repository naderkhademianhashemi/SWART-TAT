using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Janus.Windows.UI.Tab;
using System.Collections.ObjectModel;
using Presentation.Public;
using Presentation.Tabs.AssetDebtManagement;
using Presentation.Tabs.CreditRisk;
using Presentation.Tabs.LimitManagement;
using Presentation.Tabs.RPTAssetsDebts;
using Utilize.Company;
using Utilize.Helper;
using Presentation.Tabs.GuidanceTableu;
using DAL.Table_DataSetTableAdapters;
using ERMS.Model;

namespace Presentation
{
    public partial class TAT_Main : Form
    {
        private readonly Collection<TabCSwart> TabCSwarts = new Collection<TabCSwart>();
        private bool IsTabVisible = true;
        private bool IsTabVisibleForEffect = false;
        private int PreSelectedTabKey = 100;
        private int CurSelectedTabKey = 101;
        private bool IsRestart = false;
        public TAT_Main()
        {
            try
            {
                this.DoubleBuffered = true;
                Visible = false;
                this.SuspendLayout();
                InitializeComponent();

                //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
                //System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa-IR");
                TabCSwarts.Add(tabCSwart_MngUser);
                TabCSwarts.Add(tabCSwart_MngDashboard);
                TabCSwarts.Add(tabCSwart_MngCustomize);
                TabCSwarts.Add(tabCSwart_AssetDebtManagement);
                TabCSwarts.Add(tabCSwart_BaseData);
                TabCSwarts.Add(tabCSwart_BaseInfo);
                TabCSwarts.Add(tabCSwart_CreditRisk);
                TabCSwarts.Add(tabCSwart_Deposit);
                TabCSwarts.Add(tabCSwart_NesbatMali);
                TabCSwarts.Add(tabCSwart_RiskArz);
                TabCSwarts.Add(tabCSwart_RiskSaham);
                TabCSwarts.Add(tabCSwart_RPTAssetsDebts);
                tabCSwart_AssetDebtManagement.Selected = true;
                lblTime.Text = DateTime.Now.Date.ToString("D").ToFarsi();
                //lblTime.Text = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(DateTime.Now.Date).ToString("D").ToFarsi();
                var user = new DAL.Table_DataSetTableAdapters.UsersTableAdapter().GetDataByUserId(ERMS.Model.GlobalInfo.UserID).FirstOrDefault();
                lblUser.Text = string.Format(Properties.ResLabel.User, user.User_Name);
                lblAccProf.Text = string.Format(Properties.ResLabel.Act_Profile, user.Act_Profile_Id);
                lblGroup.Text = string.Format(Properties.ResLabel.UserGroup,
                                              new DAL.SwartDataSetTableAdapters.GroupsTableAdapter().GetDataByID(
                                                  user.User_Group_Id).FirstOrDefault().GroupName);
                lblLastUpdateDate.Text = string.Format(Properties.ResLabel.LastUpdateDate, 
                                                FarsiLibrary.Utils.PersianDateConverter.
                                                ToPersianDate(new DAL.General_DataSet().GetLastUpdateDate()).ToString("d").ToFarsi());
                
                this.ResumeLayout();
               
            }
            catch (Exception ex)
            {
            }
        }

        private void CleanTabCSwartSelected(object tabCSwart)
        {
            var tswart = (TabCSwart)tabCSwart;
            foreach (var cSwart in TabCSwarts.Where(item => item.Name.Equals(tswart.Name) == false))
            {
                cSwart.Selected = false;
            }

        }

        private void TAT_Main_Load(object sender, EventArgs e)
        {
            if (GlobalInfo.UserID > 0)
            {
                ProgressBox.Show();
                this.WindowState = FormWindowState.Minimized;
                utForms.TabPages.Clear();
                FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");
                Visible = true;
                Init();

            }
        }

        private static void Init()
        {
            var dtModel = new System.Data.DataTable();

            var dcolTB = new System.Data.DataColumn("TB_Model", typeof(Int32));
            dtModel.Columns.Add(dcolTB);

            var dcolNII = new System.Data.DataColumn("NII_Model", typeof(Int32));
            dtModel.Columns.Add(dcolNII);

            var dcolCB = new System.Data.DataColumn("CB_Model", typeof(Int32));
            dtModel.Columns.Add(dcolCB);

            var dcolGap = new System.Data.DataColumn("GAPD_Model", typeof(Int32));
            dtModel.Columns.Add(dcolGap);

            var dcolFS = new System.Data.DataColumn("FS_Model", typeof(Int32));
            dtModel.Columns.Add(dcolFS);

            var dcolDB = new System.Data.DataColumn("DB_Model", typeof(Int32));
            dtModel.Columns.Add(dcolDB);

            var dcolMB = new System.Data.DataColumn("MB_Model", typeof(Int32));
            dtModel.Columns.Add(dcolMB);

            var dcolPD = new System.Data.DataColumn("PD_Model", typeof(Int32));
            dtModel.Columns.Add(dcolPD);

            System.Data.DataRow dr = dtModel.NewRow();
            dr["TB_Model"] = -1;
            dr["NII_Model"] = -1;
            dr["CB_Model"] = -1;
            dr["GAPD_Model"] = -1;
            dr["FS_Model"] = -1;
            dr["DB_Model"] = -1;
            dr["MB_Model"] = -1;
            dr["PD_Model"] = -1;
            dtModel.Rows.Add(dr);
            ERMSLib.clsERMSGeneral.dtModel = dtModel;
        }

        private void tabCSwart_TabSwartClicked(object sender, EventArgs e)
        {
            PreSelectedTabKey = tabMain.SelectedIndex;
            CleanTabCSwartSelected(sender);
            tabMain.SelectedIndex = ((TabCSwart)sender).Tag.ToString().ToInt();
            CurSelectedTabKey = tabMain.SelectedIndex;
            if (!IsTabVisible)
            {
                tabMain.Visible = true;
                pcbLogo.Visible = true;
                pcbArcBgMenu.Visible = true;
                panel3.Visible = true;
                cButton3.DefaultImage = Properties.Resources.S_ArUp;
                cButton3.HoverImage = Properties.Resources.S_ArUp_Hover;
                IsTabVisible = true;
                IsTabVisibleForEffect = true;
                tabMain.BackColor = System.Drawing.Color.FromArgb(244, 232, 192);
            }
            else if (IsTabVisibleForEffect && IsTabVisible && PreSelectedTabKey == CurSelectedTabKey)
            {
                tabMain.Visible = false;
                pcbLogo.Visible = false;
                pcbArcBgMenu.Visible = false;
                panel3.Visible = false;
                cButton3.DefaultImage = Properties.Resources.S_ArDown;
                cButton3.HoverImage = Properties.Resources.S_ArDown_Hover;
                IsTabVisible = false;
                IsTabVisibleForEffect = false;
            }

            
        }

        private void ConfBtnClickForShow(Form form)
        {
            if (new DAL.User_DataSet().UserAccessToForm(ERMS.Model.GlobalInfo.UserID.ToString(), form.GetType().Name) == false)
            {
                Utilize.Routines.ShwAccDenMessageFa("هشدار", "شما اجازۀ دسترسی به این قسمت را ندارید",
                                                    Utilize.MyDialogButton.OK);
                return;
            }
            if (utForms.TabPages.Cast<UITabPage>().Any(item => item.Key.Equals(form.Name)))
            {
                var tabPage = utForms.TabPages.Cast<UITabPage>().Where(item => item.Key.Equals(form.Name)).FirstOrDefault();
                tabPage.Selected = true;
            }
            else
            {
                if (IsTabVisible && IsTabVisibleForEffect)
                {
                    tabMain.Visible = false;
                    pcbLogo.Visible = false;
                    pcbArcBgMenu.Visible = false;
                    panel3.Visible = false;
                    IsTabVisible = false;
                }


                var tabPage = new UITabPage(form.Text) { Key = form.Name, Name = form.Name, AllowClose = true };

                tabPage.StateStyles.FormatStyle.BackgroundImage = Properties.Resources.S_tab_Home;

                tabPage.StateStyles.HotFormatStyle.BackgroundImage = Properties.Resources.S_tab_Home_Hover;

                tabPage.StateStyles.SelectedFormatStyle.BackgroundImage = Properties.Resources.S_tab_Home_Selected;

                tabPage.StateStyles.FormatStyle.Font = new Font("B Nazanin", 11, FontStyle.Bold);
                tabPage.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White;

                tabPage.StateStyles.HotFormatStyle.Font = new Font("B Nazanin", 11, FontStyle.Bold);
                tabPage.StateStyles.HotFormatStyle.ForeColor = System.Drawing.Color.White;

                tabPage.StateStyles.SelectedFormatStyle.Font = new Font("B Nazanin", 11, FontStyle.Bold);
                tabPage.StateStyles.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;


                utForms.TabPages.Add(tabPage);
                utForms.TabPages[tabPage.Key].Selected = true;
                form.TopLevel = false;
                tabPage.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.FormBorderStyle = FormBorderStyle.None;
                tabPage.AutoScroll = true;
                form.Dock = DockStyle.None;
                form.Size = new Size(10, 10);// tabPage.Size;
                form.Show();

                cbCloseAll.Visible = true;
                //cbCloseAllExce.Visible = true;
            }
        }

        private void cbReconciliation_CButtonClicked(object sender, EventArgs e)
        {
            var frmReconcile = new Tabs.AssetDebtManagement.frmReconcile
                                   {
                                       Name = cbReconciliation.Name,
                                       Text = Properties.ResLabel.Reconciliation
                                   };
            ConfBtnClickForShow(frmReconcile);
        }

        private void cbAccountGroupModel_CButtonClicked(object sender, EventArgs e)
        {
            var frmAgm = new Tabs.AssetDebtManagement.frmAGM
            {
                Name = cbAccountGroupModel.Name,
                Text = Properties.ResLabel.AccountGroupModel,
            };
            ConfBtnClickForShow(frmAgm);
        }

        private void cbFinancialStatement_CButtonClicked(object sender, EventArgs e)
        {
            var frmFsm = new Tabs.AssetDebtManagement.frmFSM
            {
                Name = cbFinancialStatement.Name,
                Text = Properties.ResLabel.FinancialStatement
            };
            ConfBtnClickForShow(frmFsm);
        }

        private void cbTimeBucket_CButtonClicked(object sender, EventArgs e)
        {
            //var tabPage = utForms.TabPages.Cast<UITabPage>().Where(item => item.Key.Equals(cbTimeBucket.Name)).FirstOrDefault();
            //if (tabPage != null)
            //{
            //    tabPage.Selected = true;
            //    return;
            //}
            var frmTbm = new Tabs.AssetDebtManagement.frmTBM
            {
                Name = cbTimeBucket.Name,
                Text = Properties.ResLabel.TimeBucket,
                //RightToLeft = RightToLeft.No
            };
            ConfBtnClickForShow(frmTbm);
        }

        private void cbCBM_CButtonClicked(object sender, EventArgs e)
        {
            var frmCbm = new Tabs.AssetDebtManagement.frmCBM
            {
                Name = cbCBM.Name,
                Text = Properties.ResLabel.ItemsWithNoMaturityModel
            };
            ConfBtnClickForShow(frmCbm);
        }

        private void cbGapAnalysis_CButtonClicked(object sender, EventArgs e)
        {
            var frmGap = new Tabs.AssetDebtManagement.frmGAP
            {
                Name = cbGapAnalysis.Name,
                Text = Properties.ResLabel.GapAnalysis,

            };
            ConfBtnClickForShow(frmGap);
        }

        private void cbInterestRateCurves_CButtonClicked(object sender, EventArgs e)
        {
            var frmNii = new Tabs.AssetDebtManagement.frmNII
            {
                Name = cbInterestRateCurves.Name,
                Text = Properties.ResLabel.InterestRateCurves,
            };

            ConfBtnClickForShow(frmNii);
            //frmNii.Size = new Size(800, 600);
        }

        private void cbNetInterestIncome_CButtonClicked(object sender, EventArgs e)
        {
            var frmNim = new Tabs.AssetDebtManagement.frmNIM
            {
                Name = cbNetInterestIncome.Name,
                Text = Properties.ResLabel.NetInterestIncome
            };
            ConfBtnClickForShow(frmNim);
        }

        private void cbGapReport_CButtonClicked(object sender, EventArgs e)
        {
            var frmGapReport = new Tabs.RPTAssetsDebts.frmGapReport
            {
                Name = cbGapReport.Name,
                Text = Properties.ResLabel.GapReport
            };
            ConfBtnClickForShow(frmGapReport);
        }

        private void cbGapTrendReport_Load(object sender, EventArgs e)
        {
            var frmGapTrendingReport = new frmGapTrendingReport
            {
                Name = cbGapTrendReport.Name,
                Text = Properties.ResLabel.GapTrendingReport
            };
            ConfBtnClickForShow(frmGapTrendingReport);
        }

        private void cbEconomicCapital_CButtonClicked(object sender, EventArgs e)
        {
            var frmCreditRisk = new Tabs.CreditRisk.frmCreditRisk
            {
                Name = cbEconomicCapital.Name,
                Text = Properties.ResLabel.EconomicCapital
            };
            ConfBtnClickForShow(frmCreditRisk);
        }

        private void cbCreditReportHistoric_Load(object sender, EventArgs e)
        {

        }

        private void cbLoanReportHistor_CButtonClicked(object sender, EventArgs e)
        {
            var frmHistoricalLoanReport = new Loan.frmHistoricalLoanReport()
            {
                Name = cbLoanReportHistor.Name,
                Text = Properties.ResLabel.LoanReportHistor
            };
            ConfBtnClickForShow(frmHistoricalLoanReport);
        }

        private void cbCollatOfLoan_CButtonClicked(object sender, EventArgs e)
        {
            var frmLoanWhitCollatDetail = new Loan.frmLoanWhitCollatDetails
            {
                Name = cbCollatOfLoan.Name,
                Text = Properties.ResLabel.CollateralOfLoanReport
            };
            ConfBtnClickForShow(frmLoanWhitCollatDetail);
        }

        private void cbSpecialReportLoan_CButtonClicked(object sender, EventArgs e)
        {
            var frmSpecialReport = new Public.frmSpecialReport("Loan_Contract")
            {
                Name = cbSpecialReportLoan.Name,
                Text = Properties.ResLabel.SpecialReportLoan
            };
            ConfBtnClickForShow(frmSpecialReport);
        }

        private void cbRangeLoan_CButtonClicked(object sender, EventArgs e)
        {
            var rangeReport = new Loan.frmLoanRangeReport
            {
                Name = cbRangeLoan.Name + "-LOAN",
                Text = Properties.ResLabel.RangeLoanReport
            };
            ConfBtnClickForShow(rangeReport);
        }

        private void cbLoanReport_CButtonClicked(object sender, EventArgs e)
        {
            //Hosein : Exclude shode
            var loanReport = new Loan.frmLoanReportCs
            {
                Name = cbLoanReport.Name,
                Text = Properties.ResLabel.LoanReportCs,
                status = "Loan"
            };
            ConfBtnClickForShow(loanReport);

        }

        private void cbLoanTotal_CButtonClicked(object sender, EventArgs e)
        {
            var frmTotalLoanReport = new Loan.frmTotalLoanReport
            {
                Name = cbLoanTotal.Name,
                Text = Properties.ResLabel.LoanTotalReport
            };
            ConfBtnClickForShow(frmTotalLoanReport);
        }

        private void cbLoanMngComCollateralTarhiniTotalOverdu_CButtonClicked(object sender, EventArgs e)
        {
            var frmSettingNameColumnOfReport = new Loan.frmLoanComOverdueAndCollact
            {
                Name = cbLoanMngComCollateralTarhiniTotalOverdu.Name,
                Text = Properties.ResLabel.CollateralTarhiniAndTotalOverdue
            };
            ConfBtnClickForShow(frmSettingNameColumnOfReport);
        }

        private void cbDepositReport_CButtonClicked(object sender, EventArgs e)
        {
            var depositReportcs = new Deposit.frmDepositReportcs
            {
                Name = cbDepositReport.Name,
                Text = Properties.ResLabel.DepositReport
            };
            ConfBtnClickForShow(depositReportcs);
        }

        private void cbDepositChart_CButtonClicked(object sender, EventArgs e)
        {
            var chart = new CHART.frmChart
            {
                ReportType = "VDepositReport_Historic",
                Name = cbDepositChart.Name,
                Text = Properties.ResLabel.DepositChart
            };
            ConfBtnClickForShow(chart);
        }

        private void cbDepositRangeReport_CButtonClicked(object sender, EventArgs e)
        {
            var rangeReport = new Deposit.frmRangeReport
            {
                Name = cbDepositRangeReport.Name,
                Text = Properties.ResLabel.DepositRangeReport
            };
            ConfBtnClickForShow(rangeReport);
        }

        private void cbDepositModeling_CButtonClicked(object sender, EventArgs e)
        {
            var frmSettingNameColumnOfReport = new Deposit.frmDepositModeling()
            {
                Name = cbDepositModeling.Name,
                Text = Properties.ResLabel.DepositModeling
            };
            ConfBtnClickForShow(frmSettingNameColumnOfReport);
        }

        private void cbHistoricalDeposit_CButtonClicked(object sender, EventArgs e)
        {
            var frmSettingNameColumnOfReport = new Deposit.frmHistoricalDepositReport()
            {
                Name = cbHistoricalDeposit.Name,
                Text = Properties.ResLabel.HistoricalDepositReport
            };
            ConfBtnClickForShow(frmSettingNameColumnOfReport);
        }

        private void cbMR1_CButtonClicked(object sender, EventArgs e)
        {
            var frmVaR = new Presentation.Tabs.MarketRisk.frmVaRShare()
            {
                Name = cbMR1.Name,
                Text = Properties.ResLabel.MR1
            };
            ConfBtnClickForShow(frmVaR);
        }

        private void cbMR2_CButtonClicked(object sender, EventArgs e)
        {
            var frmVaRPortfolio = new Presentation.Tabs.MarketRisk.frmVaRPortfolio2
            {
                Name = cbMR2.Name,
                Text = Properties.ResLabel.MR2
            };
            ConfBtnClickForShow(frmVaRPortfolio);
        }

        private void cbMR3_CButtonClicked(object sender, EventArgs e)
        {
            var frmBackTesting = new Presentation.Tabs.MarketRisk.frmBackTesting2
            {
                Name = cbMR3.Name,
                Text = Properties.ResLabel.MR3,
                //RightToLeft = RightToLeft.No
            };
            ConfBtnClickForShow(frmBackTesting);
        }

        private void cbMR4_CButtonClicked(object sender, EventArgs e)
        {
            var frmPortfolio = new Presentation.Tabs.MarketRisk.frmPortfolio
            {
                Name = cbMR4.Name,
                Text = Properties.ResLabel.MR4
            };
            ConfBtnClickForShow(frmPortfolio);
        }

        private void cbCurrency_CButtonClicked(object sender, EventArgs e)
        {
            var frmVarShareCurrency = new Presentation.Tabs.CurRisk.frmVarShareCurrency
            {
                Name = cbCurrency.Name,
                Text = Properties.ResLabel.Currency
            };
            ConfBtnClickForShow(frmVarShareCurrency);
        }

        private void cbCurrencyAll_CButtonClicked(object sender, EventArgs e)
        {
            var frmVarPortfolioCurrency = new Presentation.Tabs.CurRisk.frmVarPortfolioCurrency
            {
                Name = cbCurrencyAll.Name,
                Text = Properties.ResLabel.CurrencyAll
            };
            ConfBtnClickForShow(frmVarPortfolioCurrency);
        }

        private void cbLoanCalc_CButtonClicked(object sender, EventArgs e)
        {
            //var frmLoanCalc = new Presentation.Tabs.LimitManagement.frmLoanCalc
            //{
            //    Name = cbLoanCalc.Name,
            //    Text = Properties.ResLabel.LoanCalc,
            //    RightToLeft = RightToLeft.No
            //};
            //ConfBtnClickForShow(frmLoanCalc);
        }

        private void cbLimitReport_CButtonClicked(object sender, EventArgs e)
        {
            var frmLimitReport = new frmLimitReport
            {
                Name = cbLimitReport.Name,
                Text = Properties.ResLabel.LimitReport
            };
            ConfBtnClickForShow(frmLimitReport);
        }

        private void cbLimitManagement_CButtonClicked(object sender, EventArgs e)
        {
            var frmLimitManagement = new frmLimitManagement
            {
                Name = cbLimitManagement.Name,
                Text = Properties.ResLabel.LimitManagement
            };
            ConfBtnClickForShow(frmLimitManagement);
        }

        private void cbFinancialRatioModel_CButtonClicked(object sender, EventArgs e)
        {
            var fncRatioModel = new Presentation.Tabs.FinancialRatio.frmFncRatioModel
            {
                Name = cbFinancialRatioModel.Name,
                Text = Properties.ResLabel.FinancialRatioModel,
                RightToLeft = RightToLeft.No
            };
            ConfBtnClickForShow(fncRatioModel);
        }

        private void cbFinancialRatioDefine_CButtonClicked(object sender, EventArgs e)
        {
            var frmFncRatioDefination = new Presentation.Tabs.FinancialRatio.frmFncRatioDefination
            {
                Name = cbFinancialRatioDefine.Name,
                Text = Properties.ResLabel.FinancialRatioDefine
            };
            ConfBtnClickForShow(frmFncRatioDefination);
        }

        private void cbEfficientStock_CButtonClicked(object sender, EventArgs e)
        {
            //Warning Check shavad az Fxe avarde shavad
            //var frmEfficientStock = new frmEfficientStock
            //{
            //    Name = cbEfficientStock.Name,
            //    Text = Properties.ResLabel.EfficientStock
            //};
            //ConfBtnClickForShow(frmEfficientStock);
        }

        private void cbAccountsGL_CButtonClicked(object sender, EventArgs e)
        {
            var frmAccountsGl = new Presentation.Tabs.BasicData.frmAccountsGL
            {
                Name = cbAccountsGL.Name,
                Text = Properties.ResLabel.AccountsGL
            };
            ConfBtnClickForShow(frmAccountsGl);
        }

        private void cbContractType_CButtonClicked(object sender, EventArgs e)
        {
            var frmContractType = new Presentation.Tabs.BasicData.frmContractTypeUpdate
            {
                Name = cbContractType.Name,
                Text = Properties.ResLabel.ContractType
            };
            ConfBtnClickForShow(frmContractType);
        }

        private void cbBranch_CButtonClicked(object sender, EventArgs e)
        {
            var frmBranch = new Presentation.Tabs.BasicData.frmBranch
            {
                Name = cbBranch.Name,
                Text = Properties.ResLabel.Branch
            };
            ConfBtnClickForShow(frmBranch);
        }

        private void cbCounterparty_CButtonClicked(object sender, EventArgs e)
        {
            var counterparty = new Presentation.Tabs.BasicData.frmCounterparty
            {
                Name = cbCounterparty.Name,
                Text = Properties.ResLabel.Counterparty
            };
            ConfBtnClickForShow(counterparty);
        }

        private void cbAccBranch_CButtonClicked(object sender, EventArgs e)
        {
            var frmAccountsGLBranch = new Presentation.Tabs.BasicData.frmAccountsGLBranch
            {
                Name = cbAccBranch.Name,
                Text = Properties.ResLabel.AccBranch
            };
            ConfBtnClickForShow(frmAccountsGLBranch);
        }

        private void cbEventLogs_CButtonClicked(object sender, EventArgs e)
        {
            var eventLog = new Presentation.Tabs.GuidanceTableu.frmEventLog
            {
                Name = cbEventLogs.Name,
                Text = Properties.ResLabel.EventLogs
            };
            ConfBtnClickForShow(eventLog);
        }

        private void cbManagementLogs_CButtonClicked(object sender, EventArgs e)
        {
            var frmLimitManagement = new Presentation.Tabs.GuidanceTableu.frmLimitManagement
            {
                Name = cbManagementLogs.Name,
                Text = Properties.ResLabel.ManagementLogs
            };
            ConfBtnClickForShow(frmLimitManagement);
        }

        private void cbUserManagement_CButtonClicked(object sender, EventArgs e)
        {
            var frmUserMng = new Presentation.Tabs.GuidanceTableu.frmUserMng
            {
                Name = cbUserManagement.Name,
                Text = Properties.ResLabel.UserManagement
            };
            ConfBtnClickForShow(frmUserMng);
        }

        private void cbModelManagement_CButtonClicked(object sender, EventArgs e)
        {
            var frmModelManagement = new Presentation.Tabs.GuidanceTableu.frmModelManagement
            {
                Name = cbModelManagement.Name,
                Text = Properties.ResLabel.ModelManagement
            };
            ConfBtnClickForShow(frmModelManagement);
        }

        private void cbAccLvl_CButtonClicked(object sender, EventArgs e)
        {
            var frmAccessLevel = new Presentation.Tabs.GuidanceTableu.frmCreatAccessLevel
            {
                Name = cbAccLvl.Name,
                Text = Properties.ResLabel.AccLvl
            };
            ConfBtnClickForShow(frmAccessLevel);
        }

        private void cbSettingShowTitleOfColumn_CButtonClicked(object sender, EventArgs e)
        {
            var frmSettingNameColumnOfReport = new Setting.frmSettingNameColumnOfReport
            {
                Name = cbSettingShowTitleOfColumn.Name,
                Text = Properties.ResLabel.SettingShowTitleOfColumn
            };
            ConfBtnClickForShow(frmSettingNameColumnOfReport);
        }
        private void cbExit_CButtonClicked(object sender, EventArgs e)
        {
            if (Routines.ShowMessageBoxFa("آیا می خواهید از برنامه خارج شوید؟", "پرسش", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsersTableAdapter Users_TableAdapter = new UsersTableAdapter();
                Users_TableAdapter.UpdateUserLoginStatus(GlobalInfo.UserID, 0);
                this.Dispose(true);
                this.Close();
                Application.Exit();
            }
        }

        private void cbExcel_CButtonClicked(object sender, EventArgs e)
        {
            try
            {
                if (utForms.SelectedTab.Controls.Count == 0)
                    Presentation.Public.Routines.ShowErrorMessageFa("اخطار", "هیچ فرمی برای چاپ باز نیست", Presentation.Public.MyDialogButton.OK);
                else
                {
                    var control = utForms.SelectedTab.Controls[0];
                    if (!(control is BaseForm)) return;
                    var form = ((BaseForm)control);
                    if (form.Text == "تحلیل شکاف")
                    {
                        form.ExportToExcelGAP();
                    }
                    else
                        form.ExportToExcel();
                }
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowErrorMessageFa("اخطار", ex.Message, Presentation.Public.MyDialogButton.OK);
            }
        }

        private void cbPrint_CButtonClicked(object sender, EventArgs e)
        {
            try
            {
                if (utForms.SelectedTab.Controls.Count == 0)
                    Presentation.Public.Routines.ShowErrorMessageFa("اخطار", "هیچ فرمی برای چاپ باز نیست", Presentation.Public.MyDialogButton.OK);
                else
                {
                    var control = utForms.SelectedTab.Controls[0];
                    if (!(control is BaseForm)) return;
                    var form = ((BaseForm)control);
                    if (form.Text == "تحلیل شکاف")
                    {
                        form.DoPrintGAP();
                    }
                    else
                        form.DoPrint();
                }
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowErrorMessageFa("اخطار", ex.Message, Presentation.Public.MyDialogButton.OK);
            }


        }

        private void utForms_TabClosed(object sender, TabEventArgs e)
        {
            try
            {
                if (utForms.TabPages[e.Page.Index].Controls.Count != 0 && utForms.TabPages[e.Page.Index].Controls[0] is BaseForm)
                    ((BaseForm)utForms.TabPages[e.Page.Index].Controls[0]).Close();
                utForms.TabPages.RemoveAt(e.Page.Index);
                if (utForms.TabPages.Count == 0)
                {
                    cbCloseAll.Visible = false;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
            //try
            //{
            //    var control = e.Page.Controls.Cast<Control>().Where(item => item is BaseForm).FirstOrDefault();
            //    var baseForm = ((BaseForm)control);
            //    baseForm.Close();
            //}
            //catch (Exception)
            //{

            //}
        }


        private void cbCreditReportHistoric_CButtonClicked(object sender, EventArgs e)
        {
            var frmCreditReportHistoric = new Presentation.Tabs.CreditRisk.frmCreditReportHistoric
            {
                Name = cbCreditReportHistoric.Name,
                Text = Properties.ResLabel.CreditReportHistoric
            };
            ConfBtnClickForShow(frmCreditReportHistoric);
        }

        private void cbDepositBehaviourModeling_CButtonClicked(object sender, EventArgs e)
        {
            var frmdbm = new Tabs.AssetDebtManagement.frmDBM
            {
                Name = cbDepositBehaviourModeling.Name,
                Text = Properties.ResLabel.DepositBehaviourModeling,
                //RightToLeft = System.Windows.Forms.RightToLeft.Yes
            };
            ConfBtnClickForShow(frmdbm);
        }

        private void cbGapAnalysisBehaviorModeling_CButtonClicked(object sender, EventArgs e)
        {
            var frmgapbm = new Tabs.AssetDebtManagement.frmGAPBM()
            {
                Name = cbGapAnalysisBehaviorModeling.Name,
                Text = Properties.ResLabel.GapAnalysisBehaviorModeling,
            };
            ConfBtnClickForShow(frmgapbm);
        }

        private void cbMarketBehaviorModeling_CButtonClicked(object sender, EventArgs e)
        {
            var frmmbm = new Tabs.AssetDebtManagement.frmMBM
            {
                Name = cbMarketBehaviorModeling.Name,
                Text = Properties.ResLabel.MarketBehaviorModeling
            };
            ConfBtnClickForShow(frmmbm);
        }

        private void cbPD_CButtonClicked(object sender, EventArgs e)
        {
            var frmpd = new Tabs.AssetDebtManagement.frmPD
            {
                Name = cbPD.Name,
                Text = Properties.ResLabel.PD
            };
            ConfBtnClickForShow(frmpd);
        }

        private void cbAccountReport_CButtonClicked(object sender, EventArgs e)
        {
            //var frmpd = new Tabs.AssetDebtManagement.frmPD
            //{
            //    Name = cbPD.Name,
            //    Text = Properties.ResLabel.PD
            //};
            //ConfBtnClickForShow(frmpd);
            var frmAR = new Tabs.FinancialRatio.frmAccountsReport()
            {
                Name = cbPD.Name,
                Text = Properties.ResLabel.AccountReport
            };
            ConfBtnClickForShow(frmAR);
        }

        private void tabCSwart1_TabSwartClicked(object sender, EventArgs e)
        {

        }

        private void cbBranch_BaseInfo_CButtonClicked(object sender, EventArgs e)
        {
            var frmbranch = new Presentation.Tabs.BasicInfo.frmBranch()
            {
                Name = cbBranch_BaseInfo.Name,
                Text = Properties.ResLabel.Branch
            };
            ConfBtnClickForShow(frmbranch);
        }

        private void cbCounterPartyType_CButtonClicked(object sender, EventArgs e)
        {
            var frmcpt = new Presentation.Tabs.BasicInfo.frmCounterPartyType()
            {
                Name = cbCounterPartyType.Name,
                Text = Properties.ResLabel.CounterPartyType
            };
            ConfBtnClickForShow(frmcpt);
        }

        private void cbCostumerGroup_CButtonClicked(object sender, EventArgs e)
        {
            var frmcg = new Presentation.Tabs.BasicInfo.frmCustomerGroup()
            {
                Name = cbCostumerGroup.Name,
                Text = Properties.ResLabel.CostumerGroup
            };
            ConfBtnClickForShow(frmcg);
        }

        private void cbContractTypeGroups_CButtonClicked(object sender, EventArgs e)
        {
            var frmctg = new Presentation.Tabs.BasicInfo.frmContractTypeGroups()
            {
                Name = cbContractTypeGroups.Name,
                Text = Properties.ResLabel.ContractTypeGroups
            };
            ConfBtnClickForShow(frmctg);
        }

        private void cbContractMajorType_CButtonClicked(object sender, EventArgs e)
        {
            var frmcmt = new Presentation.Tabs.BasicInfo.frmContractMajorType()
            {
                Name = cbContractMajorType.Name,
                Text = Properties.ResLabel.ContractMajorType
            };
            ConfBtnClickForShow(frmcmt);
        }

        private void cbContractStatus_CButtonClicked(object sender, EventArgs e)
        {
            var frmcs = new Presentation.Tabs.BasicInfo.frmContractStatus()
            {
                Name = cbContractStatus.Name,
                Text = Properties.ResLabel.ContractStatus
            };
            ConfBtnClickForShow(frmcs);
        }

        private void cbCollatMajorType_CButtonClicked(object sender, EventArgs e)
        {
            var frmcmt = new Presentation.Tabs.BasicInfo.frmCollatMajorType()
            {
                Name = cbCollatMajorType.Name,
                Text = Properties.ResLabel.CollatMajorType
            };
            ConfBtnClickForShow(frmcmt);
        }

        private void cbcollateralType_CButtonClicked(object sender, EventArgs e)
        {
            var frmct = new Presentation.Tabs.BasicInfo.frmCollateralType()
            {
                Name = cbcollateralType.Name,
                Text = Properties.ResLabel.CollateralType
            };
            ConfBtnClickForShow(frmct);
        }

        private void cbCollateralStatus_CButtonClicked(object sender, EventArgs e)
        {
            var frmcs = new Presentation.Tabs.BasicInfo.frmCollateralStatus()
            {
                Name = cbCollateralStatus.Name,
                Text = Properties.ResLabel.CollateralStatus
            };
            ConfBtnClickForShow(frmcs);
        }

        private void cbMinimize_CButtonClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbSize_CButtonClicked(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.Size = new Size(800, 600);
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                cbSize.DefaultImage = Properties.Resources.S_Sizable_Maximazi;
                cbSize.HoverImage = Properties.Resources.S_Sizable_Maximazi_Hover;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                cbSize.DefaultImage = Properties.Resources.S_Sizable_ChangeSize;
                cbSize.HoverImage = Properties.Resources.S_Sizable_ChangeSize_Hover;
            }
        }

        private void cButton3_CButtonClicked(object sender, EventArgs e)
        {
            if (tabMain.Visible)
            {
                IsTabVisible = false;
                tabMain.Visible = false;
                pcbLogo.Visible = false;
                panel3.Visible = false;
                pcbArcBgMenu.Visible = false;

                pnlForm.Height = pnlForm.Height + tabMain.Height;
                pnlForm.Location = new Point(pnlForm.Location.X, panel1.Location.Y);
                cButton3.DefaultImage = Properties.Resources.S_ArDown;
                cButton3.HoverImage = Properties.Resources.S_ArDown_Hover;
            }
            else
            {
                IsTabVisible = true;
                tabMain.Visible = true;
                pcbLogo.Visible = true;
                panel3.Visible = true;
                pcbArcBgMenu.Visible = true;

                pnlForm.Height = pnlForm.Height - tabMain.Height;
                pnlForm.Location = new Point(pnlForm.Location.X, panel2.Location.Y);
                cButton3.DefaultImage = Properties.Resources.S_ArUp;
                cButton3.HoverImage = Properties.Resources.S_ArUp_Hover;
                tabMain.BackColor = System.Drawing.Color.FromArgb(112, 80, 42);
            }
        }

        private void tabCSwart_AssetDebtManagement_MouseHover(object sender, EventArgs e)
        {
            if (!IsTabVisible)
            {
                tabMain.Visible = true;
                pcbLogo.Visible = true;
                pcbArcBgMenu.Visible = true;
                panel3.Visible = true;
            }
        }

        private void tabCSwart_AssetDebtManagement_MouseLeave(object sender, EventArgs e)
        {
            if (!IsTabVisible)
            {
                tabMain.Visible = false;
                pcbLogo.Visible = false;
                pcbArcBgMenu.Visible = false;
                tabMain.Visible = false;
                panel3.Visible = false;
            }
        }

        private void utForms_SelectedTabChanged(object sender, TabEventArgs e)
        {
            //if (utForms.SelectedTab.Controls.Count > 0)
            //{
            //    utForms.SelectedTab.Dock = DockStyle.Fill;
            //    utForms.SelectedTab.BackColor = System.Drawing.Color.ForestGreen;
            //    utForms.SelectedTab.Controls[0].Dock = DockStyle.Fill;

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void utForms_Resize(object sender, EventArgs e)
        {
            if (utForms.SelectedTab != null && utForms.SelectedTab.Controls != null && utForms.SelectedTab.Controls.Count > 0)
            {
                var baseForm = (utForms.SelectedTab.Controls[0] as Form);
                utForms.SelectedTab.Controls.Remove(baseForm);
                baseForm.Dock = DockStyle.Fill;
                utForms.SelectedTab.Controls.Add(baseForm);
                utForms.SelectedTab.Controls.SetChildIndex(baseForm, 0);
                baseForm.Show();
            }
            //foreach (Janus.Windows.UI.Tab.UITabPage uiTab in utForms.TabPages)
            //{
            //    if (uiTab.Controls != null && uiTab.Controls.Count > 0)
            //    {
            //        var baseForm = (uiTab.Controls[0] as BaseForm);
            //        uiTab.Controls.Remove(baseForm);
            //        baseForm.Dock = DockStyle.Fill;
            //        uiTab.Controls.Add(baseForm);
            //        uiTab.Controls.SetChildIndex(baseForm, 0);
            //        baseForm.Show();
            //    }
            //}
        }

        private void utForms_ChangingSelectedTab(object sender, TabCancelEventArgs e)
        {
            if (utForms.SelectedTab != null && utForms.SelectedTab.Controls != null && utForms.SelectedTab.Controls.Count > 0)
            {
                var baseForm = (utForms.SelectedTab.Controls[0] as Form);

                if (baseForm.Width == utForms.SelectedTab.Width && baseForm.Height == utForms.SelectedTab.Height)
                    return;

                utForms.SelectedTab.Controls.Remove(baseForm);
                baseForm.Dock = DockStyle.Fill;
                utForms.SelectedTab.Controls.Add(baseForm);
                utForms.SelectedTab.Controls.SetChildIndex(baseForm, 0);
                baseForm.Show();
            }
        }

        private void tabMain_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlForm.Location.Y == panel1.Location.Y)
            {
                //pnlForm.Height = pnlForm.Height + tabMain.Height;
                //pnlForm.Location = new Point(pnlForm.Location.X, panel1.Location.Y); 
            }
        }

        private void TAT_Main_ResizeBegin(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.DoubleBuffered = true;
        }

        private void TAT_Main_ResizeEnd(object sender, EventArgs e)
        {
            this.ResumeLayout();
        }

        private void TAT_Main_Shown(object sender, EventArgs e)
        {

        }

        private void TAT_Main_Shown_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //ChangeLanguage();
            ProgressBox.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //Application. = "Comp";
            //this.Hide();
            //var frmMain2 = new TAT_Main02();
            //frmMain2.Show();
        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {
            pnlFnButtons.Visible = true;
            pnlFnButtons.Location = new Point(2, -29);
            pnlFnButtons.BringToFront();
            for (int i = -29; i < 1; i++)
            {
                pnlFnButtons.Location = new Point(1, i);
            }
            btnClosePnlFnButtons.Visible = true;
        }

        private void btnClosePnlFnButtons_Click(object sender, EventArgs e)
        {
            pnlFnButtons.Visible = false;
            pnlFnButtons.SendToBack();
            btnClosePnlFnButtons.Visible = false;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            pnlFnButtons.Visible = true;
            pnlFnButtons.Location = new Point(2, -29);
            pnlFnButtons.BringToFront();
            for (int i = -29; i < 1; i++)
            {
                pnlFnButtons.Location = new Point(1, i);
            }
            btnClosePnlFnButtons.Visible = true;
        }

        private void btnChangeUser_CButtonClicked(object sender, EventArgs e)
        {
            if (Routines.ShowMessageBoxFa("آیا می خواهید کاربر را تغییر دهید؟", "پرسش", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsersTableAdapter Users_TableAdapter = new UsersTableAdapter();
                Users_TableAdapter.UpdateUserLoginStatus(GlobalInfo.UserID, 0);
                IsRestart = true;
                Application.Restart();
            }
        }

        private InputLanguage GetFarsiLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName.ToLower() == "farsi" || lang.LayoutName.ToLower() == "persian")
                    return lang;
            }
            return null;
        }

        public void ChangeLanguage()
        {
            InputLanguage lang = GetFarsiLanguage();
            if (lang == null)
            {
                return;
            }
            InputLanguage.CurrentInputLanguage = lang;
        }

        private void cbContractType_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void cbCloseAll_Click(object sender, EventArgs e)
        {

        }

        private void cbCloseAll_ClickcbCloseAll_CButtonClicked(object sender, EventArgs e)
        {
            //if (Routines.ShowMessageBoxFa("آیا مایل به بستن تمامی پنجره ها هستید؟", "پرسش", MessageBoxButtons.YesNo,
            //                           MessageBoxIcon.Question) == DialogResult.No)
            //    return;

            //for (int i = utForms.TabPages.Count - 1 ; i >= 0 ; i--)
            //{
            //    if (utForms.TabPages[i] != null && utForms.TabPages[i].Controls.Count > 0)
            //    {
            //        if (utForms.TabPages[i].Controls.Count != 0 && utForms.TabPages[i].Controls[0] is BaseForm)
            //            ((Form)utForms.TabPages[i].Controls[0]).Close();
            //        utForms.TabPages.RemoveAt(i);
            //    }
            //}

            //cbCloseAll.Visible = false;
            //cbCloseAllExce.Visible = false;
            //contextMenuStrip1.Show();
        }

        private void cbCloseAll_MouseHover(object sender, EventArgs e)
        {
        }

        private void cbCloseAllExce_CButtonClicked(object sender, EventArgs e)
        {
            if (Routines.ShowMessageBoxFa("آیا مایل به بستن تمامی پنجره ها، به غیر از پنجره فعال هستید؟", "پرسش", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) == DialogResult.No)
                return;
            for (int i = utForms.TabPages.Count - 1; i >= 0; i--)
            {
                if (utForms.TabPages[i] != utForms.SelectedTab && utForms.TabPages[i] != null && utForms.TabPages[i].Controls.Count > 0)
                {
                    if (utForms.TabPages[i].Controls.Count != 0 && utForms.TabPages[i].Controls[0] is BaseForm)
                        ((Form)utForms.TabPages[i].Controls[0]).Close();
                    utForms.TabPages.RemoveAt(i);
                }
            }
        }

        private void tsmiCloseAll_Click(object sender, EventArgs e)
        {
            if (Routines.ShowMessageBoxFa("آیا مایل به بستن تمامی پنجره ها هستید؟", "پرسش", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) == DialogResult.No)
                return;

            for (int i = utForms.TabPages.Count - 1; i >= 0; i--)
            {
                if (utForms.TabPages[i] != null && utForms.TabPages[i].Controls.Count > 0)
                {
                    if (utForms.TabPages[i].Controls.Count != 0 && utForms.TabPages[i].Controls[0] is BaseForm)
                        ((Form)utForms.TabPages[i].Controls[0]).Close();
                    utForms.TabPages.RemoveAt(i);
                }
            }
            cbCloseAll.Visible = false;
        }

        private void tsmiCloseAllExcept_Click(object sender, EventArgs e)
        {
            if (Routines.ShowMessageBoxFa("آیا مایل به بستن تمامی پنجره ها، به جز پنجره فعال هستید؟", "پرسش", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) == DialogResult.No)
                return;
            
            for (int i = utForms.TabPages.Count - 1; i >= 0; i--)
            {
                if (utForms.TabPages[i] != null && utForms.TabPages[i].Controls.Count > 0 && utForms.TabPages[i].Name != utForms.SelectedTab.Name)
                {
                    if (utForms.TabPages[i].Controls.Count != 0 && utForms.TabPages[i].Controls[0] is BaseForm)
                        ((Form)utForms.TabPages[i].Controls[0]).Close();
                    utForms.TabPages.RemoveAt(i);
                }
            }
            cbCloseAll.Visible = false;
        }

        private void cbGuaranteeReport_CButtonClicked(object sender, EventArgs e)
        {
            var loanReport = new Loan.frmLoanReportCs
            {
                Name = cbGuaranteeReport.Name,
                Text = "گزارش ضمانتنامه ها",
                status = "Guarantee"
            };

            ConfBtnClickForShow(loanReport);


        }

        private void TAT_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsRestart && Routines.ShowMessageBoxFa("آیا می خواهید از برنامه خارج شوید؟", "پرسش", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var Users_TableAdapter = new UsersTableAdapter();
                Users_TableAdapter.UpdateUserLoginStatus(GlobalInfo.UserID, 0);
                this.Dispose(true);
                this.Close();
                Application.Exit();
            }
            else if (!IsRestart)
            {
                e.Cancel = true;
            }
        }

        private void cbMaturityReport_CButtonClicked(object sender, EventArgs e)
        {
            var frmSarresidshodeLoan = new Loan.frmSarresidshodeLoan
                                           {
                                               Name = cbMaturityReport.Name,
                                               Text = "گزارش سررسید شده",
                                           };

            ConfBtnClickForShow(frmSarresidshodeLoan);
        }

        private void cb_Loan_TasvieShode_CButtonClicked(object sender, EventArgs e)
        {
            var frmTasvieshode = new Loan.frmTasvieshode
                                           {
                                               Name = cb_Loan_TasvieShode.Name,
                                               Text = "گزارش  تسویه شده",
                                           };

            ConfBtnClickForShow(frmTasvieshode);
        }

        private void cbCity_CButtonClicked(object sender, EventArgs e)
        {
            var frmCity = new Presentation.Tabs.BasicData.frmCity
            {
                Name = cbCity.Name,
                Text = "شهر",
            };

            ConfBtnClickForShow(frmCity);
        }

        private void cbState_CButtonClicked(object sender, EventArgs e)
        {
            var frmState = new Presentation.Tabs.BasicData.frmState
            {
                Name = cbState.Name,
                Text = "استان",
            };
            ConfBtnClickForShow(frmState);
        }

        private void cBCurrencyValue_CButtonClicked(object sender, EventArgs e)
        {
            var frmCurrencyValue = new Presentation.Tabs.CurRisk.frmCurrency
            {
                Name = cBCurrencyValue.Name,
                Text = "نرخ ارز",
            };
            ConfBtnClickForShow(frmCurrencyValue);
        }

        private void cbMinRemainingDeposit_CButtonClicked(object sender, EventArgs e)
        {
            var frmMinRemainingDep = new Presentation.Deposit.frmMinRemainingDeposit
            {
                Name = cbMinRemainingDeposit.Name,
                Text = "کمینه موجودی سپرده",
            };
            ConfBtnClickForShow(frmMinRemainingDep);
        }

        private void tabMain_SelectedTabChanged(object sender, TabEventArgs e)
        {

        }

        private void cbChangePass_CButtonClicked(object sender, EventArgs e)
        {
            var frmChangePass = new Presentation.Tabs.GuidanceTableu.frmChangePassword
            {
                Name = cbChangePass.Name,
                Text = "تغییر رمز کاربری",
            };
            ConfBtnClickForShow(frmChangePass);
        }

        private void cbLoanCashFlowPayment_CButtonClicked(object sender, EventArgs e)
        {
            var frmLoanCashFlowPayment = new Presentation.Loan.frmLoanCashFlowPayment
            {
                Name = cbLoanCashFlowPayment.Name,
                Text = "گزارش سررسید اقساط",
            };
            ConfBtnClickForShow(frmLoanCashFlowPayment);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //var frmLoanCashFlowPayment = new Presentation.Loan.frmLoanCashFlowPayment
            //{
            //    Name = cbLoanCashFlowPayment.Name,
            //    Text = "گزارش سررسید اقساط",
            //};
            //ConfBtnClickForShow(frmLoanCashFlowPayment);
        }

        private void utpAssetDebtManagement_Click(object sender, EventArgs e)
        {

        }

        private void cButton2_CButtonClicked(object sender, EventArgs e)
        {
            var frmMinRemainingDep = new Presentation.Deposit.frmInputOutputDeposit
            {
                Name = cbInputOutputDeposit.Name,
                Text = "گزارش ورود و خروج منابع",
            };
            ConfBtnClickForShow(frmMinRemainingDep);
        }

        private void tabCSwart_CreditRisk_Load(object sender, EventArgs e)
        {

        }

        private void cbImportData_CButtonClicked(object sender, EventArgs e)
        {
            var frmImportData = new Presentation.Capital_Adequacy.frmImportCapitalData
            {
                Name = cbImportData.Name,
                Text = "داده های ورودی کفایت سرمایه",
            };
            ConfBtnClickForShow(frmImportData);
        }

        private void cbCreditRiskBalanced_CButtonClicked(object sender, EventArgs e)
        {
            var frmCreditRiskBalanced = new Presentation.Capital_Adequacy.frmCreditRiskBalancedAsset
            {
                Name = cbCreditRiskBalanced.Name,
                Text = "دارایی موزون به ریسک اعتباری",
            };
            ConfBtnClickForShow(frmCreditRiskBalanced);
        }

        private void cbSupervisionCapital_CButtonClicked(object sender, EventArgs e)
        {
            var frmSupervision = new Presentation.Capital_Adequacy.frmSupervisionCapital
            {
                Name = cbSupervisionCapital.Name,
                Text = "سرمایه نظارتی",
            };
            ConfBtnClickForShow(frmSupervision);
        }

        private void cbMarketRiskAsset_CButtonClicked(object sender, EventArgs e)
        {
            var frmMarketRiskBalancedAsset = new Presentation.Capital_Adequacy.frmMarketRiskAsset
            {
                Name = cbMarketRiskAsset.Name,
                Text = "دارایی موزون به ریسک بازار",
            };
            ConfBtnClickForShow(frmMarketRiskBalancedAsset);
        }

        private void cbCapitalAdequacy_CButtonClicked(object sender, EventArgs e)
        {
            var frmCapitalAdequacy = new Presentation.Capital_Adequacy.frmCapitalAdequacy
            {
                Name = cbCapitalAdequacy.Name,
                Text = "کفایت سرمایه",
            };
            ConfBtnClickForShow(frmCapitalAdequacy);
        }
    }
}
