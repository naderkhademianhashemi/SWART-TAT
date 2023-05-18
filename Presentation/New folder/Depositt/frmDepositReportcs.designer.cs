using Utilize.Report;

namespace Presentation.Deposit
{
    partial class frmDepositReportcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositReportcs));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton1 = new Infragistics.Win.UltraWinEditors.EditorButton("Search");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton2 = new Infragistics.Win.UltraWinEditors.EditorButton("Search");
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton3 = new Infragistics.Win.UltraWinEditors.EditorButton("Search");
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            this.cmsReport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRemoveReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowReport_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ugbSFiltering = new Infragistics.Win.Misc.UltraGroupBox();
            this.cbCloseAll = new Utilize.Company.CButton();
            this.tabMain = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.cGroupBox2 = new Utilize.Company.CGroupBox();
            this.ucfOrganization = new Utilize.Report.UCFiltering();
            this.ucfCity = new Utilize.Report.UCFiltering();
            this.ucfState = new Utilize.Report.UCFiltering();
            this.cGroupBox1 = new Utilize.Company.CGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fdpHistoricDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.rdbDate_Historic = new System.Windows.Forms.RadioButton();
            this.rdbDate_Today = new System.Windows.Forms.RadioButton();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.ucfDepositContractStatus = new Utilize.Report.UCFiltering();
            this.ucfCurrency = new Utilize.Report.UCFiltering();
            this.pnlMaturityDate = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.fdpToMaturityDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.chbMaturityDate = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fdpFromMaturityDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.pnlStartDate = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.chbStartDate = new System.Windows.Forms.CheckBox();
            this.fdpToStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.fdpFromStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ucFilteringContractTypeCodeDep = new Utilize.Report.UCFiltering();
            this.ucfContractTypeDep = new Utilize.Report.UCFiltering();
            this.uiTabPage4 = new Janus.Windows.UI.Tab.UITabPage();
            this.chbCustCodeName = new System.Windows.Forms.CheckBox();
            this.cgbCustCodeName = new Utilize.Company.CGroupBox();
            this.chbDepNo = new System.Windows.Forms.RadioButton();
            this.txtDepNoName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtDepNo = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.chbCounterparty = new System.Windows.Forms.RadioButton();
            this.txtCounterPartyName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCounterparty = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.chbCounterpartyName = new System.Windows.Forms.RadioButton();
            this.cgbCouterpartName = new Utilize.Company.CGroupBox();
            this.txtCounterpartyNameSearch = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.rdbContains = new System.Windows.Forms.RadioButton();
            this.rdbStartsWith = new System.Windows.Forms.RadioButton();
            this.rdbEndsWith = new System.Windows.Forms.RadioButton();
            this.dgvCounterpartiesNames = new System.Windows.Forms.DataGridView();
            this.txtCounterpartyNames = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ucNationality = new Utilize.Report.UCFiltering();
            this.ucfCounterPartyType = new Utilize.Report.UCFiltering();
            this.ucfCustomerGroup = new Utilize.Report.UCFiltering();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.ucMaritalStatus = new Utilize.Report.UCFiltering();
            this.ucSokunat = new Utilize.Report.UCFiltering();
            this.ucEducation = new Utilize.Report.UCFiltering();
            this.ucSex = new Utilize.Report.UCFiltering();
            this.uiTabPage5 = new Janus.Windows.UI.Tab.UITabPage();
            this.ucEconomicPart = new Utilize.Report.UCFiltering();
            this.ucCompanyType = new Utilize.Report.UCFiltering();
            this.ucJobType = new Utilize.Report.UCFiltering();
            this.uiTabPage6 = new Janus.Windows.UI.Tab.UITabPage();
            this.checkID = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbGroupBy = new System.Windows.Forms.CheckBox();
            this.cmbGroupBy = new Utilize.Company.CComboCox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbOrderBy = new System.Windows.Forms.CheckBox();
            this.cmbOrderBy = new Utilize.Company.CComboCox();
            this.rdbDesc = new System.Windows.Forms.RadioButton();
            this.rdbAsc = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucSelectColumn = new Utilize.Report.SelectColumn();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.btnNewReport = new Utilize.Company.CButton();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnSave = new Utilize.Company.CButton();
            this.btnShowNormalReport = new Utilize.Company.CButton();
            this.ugbReports = new Infragistics.Win.Misc.UltraGroupBox();
            this.trnReport = new Infragistics.Win.UltraWinTree.UltraTree();
            this.cmsReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ugbSFiltering)).BeginInit();
            this.ugbSFiltering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGroupBox2)).BeginInit();
            this.cGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGroupBox1)).BeginInit();
            this.cGroupBox1.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            this.pnlMaturityDate.SuspendLayout();
            this.pnlStartDate.SuspendLayout();
            this.uiTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCustCodeName)).BeginInit();
            this.cgbCustCodeName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepNoName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterPartyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterparty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCouterpartName)).BeginInit();
            this.cgbCouterpartName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNameSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNames)).BeginInit();
            this.uiTabPage1.SuspendLayout();
            this.uiTabPage5.SuspendLayout();
            this.uiTabPage6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroupBy)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrderBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ugbReports)).BeginInit();
            this.ugbReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trnReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsReport
            // 
            this.cmsReport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRemoveReport,
            this.btnChart,
            this.btnShowReport_2});
            this.cmsReport.Name = "cmsReport";
            this.cmsReport.Size = new System.Drawing.Size(145, 70);
            this.cmsReport.Opening += new System.ComponentModel.CancelEventHandler(this.cmsReport_Opening);
            // 
            // btnRemoveReport
            // 
            this.btnRemoveReport.Image = global::Presentation.Properties.Resources.Close;
            this.btnRemoveReport.Name = "btnRemoveReport";
            this.btnRemoveReport.Size = new System.Drawing.Size(144, 22);
            this.btnRemoveReport.Text = " حذف";
            this.btnRemoveReport.Click += new System.EventHandler(this.btnRemoveReport_Click);
            // 
            // btnChart
            // 
            this.btnChart.Image = global::Presentation.Properties.Resources.chart;
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(144, 22);
            this.btnChart.Text = "نمودار";
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnShowReport_2
            // 
            this.btnShowReport_2.Image = global::Presentation.Properties.Resources.REPORT;
            this.btnShowReport_2.Name = "btnShowReport_2";
            this.btnShowReport_2.Size = new System.Drawing.Size(144, 22);
            this.btnShowReport_2.Text = "نمایش گزارش";
            this.btnShowReport_2.Click += new System.EventHandler(this.btnShowReport_2_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ugbReports);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer3.Size = new System.Drawing.Size(1185, 709);
            this.splitContainer3.SplitterDistance = 858;
            this.splitContainer3.TabIndex = 143;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ugbSFiltering);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(858, 709);
            this.splitContainer2.SplitterDistance = 370;
            this.splitContainer2.SplitterWidth = 7;
            this.splitContainer2.TabIndex = 142;
            // 
            // ugbSFiltering
            // 
            this.ugbSFiltering.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center;
            this.ugbSFiltering.Controls.Add(this.cbCloseAll);
            this.ugbSFiltering.Controls.Add(this.tabMain);
            this.ugbSFiltering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ugbSFiltering.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ugbSFiltering.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder;
            this.ugbSFiltering.Location = new System.Drawing.Point(0, 0);
            this.ugbSFiltering.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ugbSFiltering.Name = "ugbSFiltering";
            this.ugbSFiltering.Size = new System.Drawing.Size(858, 370);
            this.ugbSFiltering.TabIndex = 137;
            this.ugbSFiltering.Text = "تنظیمات فیلتر بندی";
            // 
            // cbCloseAll
            // 
            this.cbCloseAll.BackColor = System.Drawing.Color.Transparent;
            this.cbCloseAll.DefaultImage = global::Presentation.Properties.Resources.help;
            this.cbCloseAll.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cbCloseAll.HoverImage = global::Presentation.Properties.Resources.help_hover;
            this.cbCloseAll.Location = new System.Drawing.Point(334, 30);
            this.cbCloseAll.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.cbCloseAll.Name = "cbCloseAll";
            this.cbCloseAll.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCloseAll.Size = new System.Drawing.Size(79, 31);
            this.cbCloseAll.TabIndex = 142;
            this.cbCloseAll.Title = null;
            this.cbCloseAll.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbCloseAll_CButtonClicked);
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.tabMain.Location = new System.Drawing.Point(3, 30);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabMain.Name = "tabMain";
            this.tabMain.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabMain.Size = new System.Drawing.Size(852, 337);
            this.tabMain.TabIndex = 141;
            this.tabMain.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage3,
            this.uiTabPage4,
            this.uiTabPage1,
            this.uiTabPage5,
            this.uiTabPage6});
            this.tabMain.TabStripFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.TabStripFormatStyle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabMain.TabStripFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.tabMain.UseThemes = false;
            this.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.AutoScroll = true;
            this.uiTabPage2.Controls.Add(this.cGroupBox2);
            this.uiTabPage2.Controls.Add(this.cGroupBox1);
            this.uiTabPage2.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(848, 306);
            this.uiTabPage2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "اطلاعات زمانی/مکانی";
            // 
            // cGroupBox2
            // 
            this.cGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cGroupBox2.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cGroupBox2.Controls.Add(this.ucfOrganization);
            this.cGroupBox2.Controls.Add(this.ucfCity);
            this.cGroupBox2.Controls.Add(this.ucfState);
            this.cGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.cGroupBox2.Location = new System.Drawing.Point(0, 98);
            this.cGroupBox2.Name = "cGroupBox2";
            this.cGroupBox2.Size = new System.Drawing.Size(848, 163);
            this.cGroupBox2.TabIndex = 128;
            this.cGroupBox2.Text = "اطلاعات شعب";
            // 
            // ucfOrganization
            // 
            this.ucfOrganization.BackColor = System.Drawing.Color.Transparent;
            this.ucfOrganization.DataSource = null;
            this.ucfOrganization.DisplayMember = null;
            this.ucfOrganization.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucfOrganization.EnableShowClearSelectedItem = true;
            this.ucfOrganization.EnableShowSelectedItem = true;
            this.ucfOrganization.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfOrganization.IsPersian = false;
            this.ucfOrganization.Location = new System.Drawing.Point(3, 105);
            this.ucfOrganization.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucfOrganization.Name = "ucfOrganization";
            this.ucfOrganization.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfOrganization.Size = new System.Drawing.Size(842, 37);
            this.ucfOrganization.TabIndex = 126;
            this.ucfOrganization.Title = "شعبه";
            this.ucfOrganization.ValueMember = null;
            this.ucfOrganization.DropDownOpening += new System.EventHandler(this.ucfOrganization_DropDownOpening);
            // 
            // ucfCity
            // 
            this.ucfCity.BackColor = System.Drawing.Color.Transparent;
            this.ucfCity.DataSource = null;
            this.ucfCity.DisplayMember = null;
            this.ucfCity.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucfCity.EnableShowClearSelectedItem = true;
            this.ucfCity.EnableShowSelectedItem = true;
            this.ucfCity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfCity.IsPersian = false;
            this.ucfCity.Location = new System.Drawing.Point(3, 68);
            this.ucfCity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucfCity.Name = "ucfCity";
            this.ucfCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCity.Size = new System.Drawing.Size(842, 37);
            this.ucfCity.TabIndex = 127;
            this.ucfCity.Title = "شهر";
            this.ucfCity.ValueMember = null;
            // 
            // ucfState
            // 
            this.ucfState.BackColor = System.Drawing.Color.Transparent;
            this.ucfState.DataSource = null;
            this.ucfState.DisplayMember = null;
            this.ucfState.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucfState.EnableShowClearSelectedItem = true;
            this.ucfState.EnableShowSelectedItem = true;
            this.ucfState.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfState.IsPersian = false;
            this.ucfState.Location = new System.Drawing.Point(3, 24);
            this.ucfState.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucfState.Name = "ucfState";
            this.ucfState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfState.Size = new System.Drawing.Size(842, 44);
            this.ucfState.TabIndex = 125;
            this.ucfState.Title = "استان";
            this.ucfState.ValueMember = null;
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cGroupBox1.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cGroupBox1.Controls.Add(this.label1);
            this.cGroupBox1.Controls.Add(this.fdpHistoricDate);
            this.cGroupBox1.Controls.Add(this.rdbDate_Historic);
            this.cGroupBox1.Controls.Add(this.rdbDate_Today);
            this.cGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(848, 98);
            this.cGroupBox1.TabIndex = 128;
            this.cGroupBox1.Text = "گزارش گیری بر اساس داده های تاریخی سپرده ها";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 129;
            this.label1.Text = "تاریخ گزارش";
            // 
            // fdpHistoricDate
            // 
            this.fdpHistoricDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpHistoricDate.Location = new System.Drawing.Point(628, 38);
            this.fdpHistoricDate.Name = "fdpHistoricDate";
            this.fdpHistoricDate.Size = new System.Drawing.Size(134, 23);
            this.fdpHistoricDate.TabIndex = 128;
            this.fdpHistoricDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // rdbDate_Historic
            // 
            this.rdbDate_Historic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDate_Historic.AutoSize = true;
            this.rdbDate_Historic.Checked = true;
            this.rdbDate_Historic.Location = new System.Drawing.Point(418, 37);
            this.rdbDate_Historic.Name = "rdbDate_Historic";
            this.rdbDate_Historic.Size = new System.Drawing.Size(59, 24);
            this.rdbDate_Historic.TabIndex = 127;
            this.rdbDate_Historic.TabStop = true;
            this.rdbDate_Historic.Text = "تاریخی";
            this.rdbDate_Historic.UseVisualStyleBackColor = true;
            this.rdbDate_Historic.Visible = false;
            this.rdbDate_Historic.CheckedChanged += new System.EventHandler(this.rdbDate_Historic_CheckedChanged);
            // 
            // rdbDate_Today
            // 
            this.rdbDate_Today.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDate_Today.AutoSize = true;
            this.rdbDate_Today.Location = new System.Drawing.Point(319, 37);
            this.rdbDate_Today.Name = "rdbDate_Today";
            this.rdbDate_Today.Size = new System.Drawing.Size(50, 24);
            this.rdbDate_Today.TabIndex = 127;
            this.rdbDate_Today.Text = "امروز";
            this.rdbDate_Today.UseVisualStyleBackColor = true;
            this.rdbDate_Today.Visible = false;
            this.rdbDate_Today.CheckedChanged += new System.EventHandler(this.rdbDate_Today_CheckedChanged);
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.AutoScroll = true;
            this.uiTabPage3.Controls.Add(this.ucfDepositContractStatus);
            this.uiTabPage3.Controls.Add(this.ucfCurrency);
            this.uiTabPage3.Controls.Add(this.pnlMaturityDate);
            this.uiTabPage3.Controls.Add(this.pnlStartDate);
            this.uiTabPage3.Controls.Add(this.ucFilteringContractTypeCodeDep);
            this.uiTabPage3.Controls.Add(this.ucfContractTypeDep);
            this.uiTabPage3.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(848, 306);
            this.uiTabPage3.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "اطلاعات قرارداد";
            // 
            // ucfDepositContractStatus
            // 
            this.ucfDepositContractStatus.BackColor = System.Drawing.Color.Transparent;
            this.ucfDepositContractStatus.DataSource = null;
            this.ucfDepositContractStatus.DisplayMember = null;
            this.ucfDepositContractStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucfDepositContractStatus.EnableShowClearSelectedItem = true;
            this.ucfDepositContractStatus.EnableShowSelectedItem = true;
            this.ucfDepositContractStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfDepositContractStatus.IsPersian = false;
            this.ucfDepositContractStatus.Location = new System.Drawing.Point(0, 214);
            this.ucfDepositContractStatus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucfDepositContractStatus.Name = "ucfDepositContractStatus";
            this.ucfDepositContractStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfDepositContractStatus.Size = new System.Drawing.Size(848, 44);
            this.ucfDepositContractStatus.TabIndex = 132;
            this.ucfDepositContractStatus.Title = "وضعیت قرارداد";
            this.ucfDepositContractStatus.ValueMember = null;
            // 
            // ucfCurrency
            // 
            this.ucfCurrency.BackColor = System.Drawing.Color.Transparent;
            this.ucfCurrency.DataSource = null;
            this.ucfCurrency.DisplayMember = null;
            this.ucfCurrency.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucfCurrency.EnableShowClearSelectedItem = true;
            this.ucfCurrency.EnableShowSelectedItem = true;
            this.ucfCurrency.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfCurrency.IsPersian = false;
            this.ucfCurrency.Location = new System.Drawing.Point(0, 170);
            this.ucfCurrency.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucfCurrency.Name = "ucfCurrency";
            this.ucfCurrency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCurrency.Size = new System.Drawing.Size(848, 44);
            this.ucfCurrency.TabIndex = 128;
            this.ucfCurrency.Title = "نرخ ارز";
            this.ucfCurrency.ValueMember = null;
            // 
            // pnlMaturityDate
            // 
            this.pnlMaturityDate.BackColor = System.Drawing.Color.Transparent;
            this.pnlMaturityDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMaturityDate.Controls.Add(this.label8);
            this.pnlMaturityDate.Controls.Add(this.fdpToMaturityDate);
            this.pnlMaturityDate.Controls.Add(this.chbMaturityDate);
            this.pnlMaturityDate.Controls.Add(this.label9);
            this.pnlMaturityDate.Controls.Add(this.fdpFromMaturityDate);
            this.pnlMaturityDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMaturityDate.Location = new System.Drawing.Point(0, 131);
            this.pnlMaturityDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlMaturityDate.Name = "pnlMaturityDate";
            this.pnlMaturityDate.Size = new System.Drawing.Size(848, 39);
            this.pnlMaturityDate.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "تا";
            // 
            // fdpToMaturityDate
            // 
            this.fdpToMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpToMaturityDate.Enabled = false;
            this.fdpToMaturityDate.Location = new System.Drawing.Point(359, 6);
            this.fdpToMaturityDate.Name = "fdpToMaturityDate";
            this.fdpToMaturityDate.Size = new System.Drawing.Size(120, 23);
            this.fdpToMaturityDate.TabIndex = 34;
            this.fdpToMaturityDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // chbMaturityDate
            // 
            this.chbMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbMaturityDate.AutoSize = true;
            this.chbMaturityDate.BackColor = System.Drawing.Color.Transparent;
            this.chbMaturityDate.Location = new System.Drawing.Point(715, 0);
            this.chbMaturityDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chbMaturityDate.Name = "chbMaturityDate";
            this.chbMaturityDate.Size = new System.Drawing.Size(127, 24);
            this.chbMaturityDate.TabIndex = 114;
            this.chbMaturityDate.Text = "تاریخ سررسید سپرده";
            this.chbMaturityDate.UseVisualStyleBackColor = false;
            this.chbMaturityDate.CheckedChanged += new System.EventHandler(this.chbMaturityDate_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(638, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "از";
            // 
            // fdpFromMaturityDate
            // 
            this.fdpFromMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFromMaturityDate.Enabled = false;
            this.fdpFromMaturityDate.Location = new System.Drawing.Point(512, 6);
            this.fdpFromMaturityDate.Name = "fdpFromMaturityDate";
            this.fdpFromMaturityDate.Size = new System.Drawing.Size(120, 23);
            this.fdpFromMaturityDate.TabIndex = 32;
            this.fdpFromMaturityDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // pnlStartDate
            // 
            this.pnlStartDate.BackColor = System.Drawing.Color.Transparent;
            this.pnlStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStartDate.Controls.Add(this.label10);
            this.pnlStartDate.Controls.Add(this.chbStartDate);
            this.pnlStartDate.Controls.Add(this.fdpToStartDate);
            this.pnlStartDate.Controls.Add(this.label11);
            this.pnlStartDate.Controls.Add(this.fdpFromStartDate);
            this.pnlStartDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStartDate.Location = new System.Drawing.Point(0, 91);
            this.pnlStartDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlStartDate.Name = "pnlStartDate";
            this.pnlStartDate.Size = new System.Drawing.Size(848, 40);
            this.pnlStartDate.TabIndex = 115;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(485, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "تا";
            // 
            // chbStartDate
            // 
            this.chbStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbStartDate.AutoSize = true;
            this.chbStartDate.BackColor = System.Drawing.Color.Transparent;
            this.chbStartDate.Location = new System.Drawing.Point(726, 1);
            this.chbStartDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chbStartDate.Name = "chbStartDate";
            this.chbStartDate.Size = new System.Drawing.Size(117, 24);
            this.chbStartDate.TabIndex = 113;
            this.chbStartDate.Text = "تاریخ افتتاح سپرده";
            this.chbStartDate.UseVisualStyleBackColor = false;
            this.chbStartDate.CheckedChanged += new System.EventHandler(this.chbStartDate_CheckedChanged);
            // 
            // fdpToStartDate
            // 
            this.fdpToStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpToStartDate.Enabled = false;
            this.fdpToStartDate.Location = new System.Drawing.Point(359, 8);
            this.fdpToStartDate.Name = "fdpToStartDate";
            this.fdpToStartDate.Size = new System.Drawing.Size(120, 23);
            this.fdpToStartDate.TabIndex = 34;
            this.fdpToStartDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(638, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "از";
            // 
            // fdpFromStartDate
            // 
            this.fdpFromStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFromStartDate.Enabled = false;
            this.fdpFromStartDate.Location = new System.Drawing.Point(512, 7);
            this.fdpFromStartDate.Name = "fdpFromStartDate";
            this.fdpFromStartDate.Size = new System.Drawing.Size(120, 23);
            this.fdpFromStartDate.TabIndex = 32;
            this.fdpFromStartDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // ucFilteringContractTypeCodeDep
            // 
            this.ucFilteringContractTypeCodeDep.BackColor = System.Drawing.Color.Transparent;
            this.ucFilteringContractTypeCodeDep.DataSource = null;
            this.ucFilteringContractTypeCodeDep.DisplayMember = null;
            this.ucFilteringContractTypeCodeDep.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFilteringContractTypeCodeDep.EnableShowClearSelectedItem = true;
            this.ucFilteringContractTypeCodeDep.EnableShowSelectedItem = true;
            this.ucFilteringContractTypeCodeDep.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucFilteringContractTypeCodeDep.IsPersian = false;
            this.ucFilteringContractTypeCodeDep.Location = new System.Drawing.Point(0, 43);
            this.ucFilteringContractTypeCodeDep.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucFilteringContractTypeCodeDep.Name = "ucFilteringContractTypeCodeDep";
            this.ucFilteringContractTypeCodeDep.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucFilteringContractTypeCodeDep.Size = new System.Drawing.Size(848, 48);
            this.ucFilteringContractTypeCodeDep.TabIndex = 127;
            this.ucFilteringContractTypeCodeDep.Title = "زیرنوع قرارداد";
            this.ucFilteringContractTypeCodeDep.ValueMember = null;
            // 
            // ucfContractTypeDep
            // 
            this.ucfContractTypeDep.BackColor = System.Drawing.Color.Transparent;
            this.ucfContractTypeDep.DataSource = null;
            this.ucfContractTypeDep.DisplayMember = null;
            this.ucfContractTypeDep.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucfContractTypeDep.EnableShowClearSelectedItem = true;
            this.ucfContractTypeDep.EnableShowSelectedItem = true;
            this.ucfContractTypeDep.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfContractTypeDep.IsPersian = false;
            this.ucfContractTypeDep.Location = new System.Drawing.Point(0, 0);
            this.ucfContractTypeDep.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucfContractTypeDep.Name = "ucfContractTypeDep";
            this.ucfContractTypeDep.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfContractTypeDep.Size = new System.Drawing.Size(848, 43);
            this.ucfContractTypeDep.TabIndex = 131;
            this.ucfContractTypeDep.Title = "نوع اصلی قرارداد";
            this.ucfContractTypeDep.ValueMember = null;
            // 
            // uiTabPage4
            // 
            this.uiTabPage4.AutoScroll = true;
            this.uiTabPage4.Controls.Add(this.chbCustCodeName);
            this.uiTabPage4.Controls.Add(this.cgbCustCodeName);
            this.uiTabPage4.Controls.Add(this.txtCounterpartyNames);
            this.uiTabPage4.Controls.Add(this.ucNationality);
            this.uiTabPage4.Controls.Add(this.ucfCounterPartyType);
            this.uiTabPage4.Controls.Add(this.ucfCustomerGroup);
            this.uiTabPage4.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uiTabPage4.Name = "uiTabPage4";
            this.uiTabPage4.Size = new System.Drawing.Size(848, 306);
            this.uiTabPage4.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage4.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage4.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage4.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage4.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage4.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage4.TabStop = true;
            this.uiTabPage4.Text = "مشتری";
            // 
            // chbCustCodeName
            // 
            this.chbCustCodeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCustCodeName.AutoSize = true;
            this.chbCustCodeName.Location = new System.Drawing.Point(247, 92);
            this.chbCustCodeName.Name = "chbCustCodeName";
            this.chbCustCodeName.Size = new System.Drawing.Size(114, 24);
            this.chbCustCodeName.TabIndex = 0;
            this.chbCustCodeName.Text = "شماره / نام مشتری";
            this.chbCustCodeName.UseVisualStyleBackColor = true;
            this.chbCustCodeName.CheckedChanged += new System.EventHandler(this.chbCustCodeName_CheckedChanged);
            // 
            // cgbCustCodeName
            // 
            this.cgbCustCodeName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbCustCodeName.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbCustCodeName.Controls.Add(this.chbDepNo);
            this.cgbCustCodeName.Controls.Add(this.txtDepNoName);
            this.cgbCustCodeName.Controls.Add(this.txtDepNo);
            this.cgbCustCodeName.Controls.Add(this.chbCounterparty);
            this.cgbCustCodeName.Controls.Add(this.txtCounterPartyName);
            this.cgbCustCodeName.Controls.Add(this.txtCounterparty);
            this.cgbCustCodeName.Controls.Add(this.chbCounterpartyName);
            this.cgbCustCodeName.Controls.Add(this.cgbCouterpartName);
            this.cgbCustCodeName.Controls.Add(this.dgvCounterpartiesNames);
            this.cgbCustCodeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.cgbCustCodeName.Enabled = false;
            this.cgbCustCodeName.Location = new System.Drawing.Point(0, 104);
            this.cgbCustCodeName.Name = "cgbCustCodeName";
            this.cgbCustCodeName.Size = new System.Drawing.Size(831, 240);
            this.cgbCustCodeName.TabIndex = 141;
            // 
            // chbDepNo
            // 
            this.chbDepNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbDepNo.AutoSize = true;
            this.chbDepNo.Location = new System.Drawing.Point(742, 63);
            this.chbDepNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbDepNo.Name = "chbDepNo";
            this.chbDepNo.Size = new System.Drawing.Size(88, 24);
            this.chbDepNo.TabIndex = 142;
            this.chbDepNo.TabStop = true;
            this.chbDepNo.Text = "شماره سپرده";
            this.chbDepNo.UseVisualStyleBackColor = true;
            this.chbDepNo.CheckedChanged += new System.EventHandler(this.chbDepNo_CheckedChanged);
            // 
            // txtDepNoName
            // 
            this.txtDepNoName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.txtDepNoName.Appearance = appearance1;
            this.txtDepNoName.Location = new System.Drawing.Point(5, 61);
            this.txtDepNoName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDepNoName.Name = "txtDepNoName";
            this.txtDepNoName.ReadOnly = true;
            this.txtDepNoName.Size = new System.Drawing.Size(518, 30);
            this.txtDepNoName.TabIndex = 141;
            // 
            // txtDepNo
            // 
            this.txtDepNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            editorButton1.Appearance = appearance2;
            editorButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button;
            editorButton1.Key = "Search";
            appearance3.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance3.ImageBackground")));
            editorButton1.PressedAppearance = appearance3;
            editorButton1.Text = "جستجو";
            this.txtDepNo.ButtonsLeft.Add(editorButton1);
            this.txtDepNo.Enabled = false;
            this.txtDepNo.Location = new System.Drawing.Point(529, 60);
            this.txtDepNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDepNo.Name = "txtDepNo";
            this.txtDepNo.Size = new System.Drawing.Size(177, 30);
            this.txtDepNo.TabIndex = 140;
            this.txtDepNo.EditorButtonClick += new Infragistics.Win.UltraWinEditors.EditorButtonEventHandler(this.txtDepNo_EditorButtonClick);
            // 
            // chbCounterparty
            // 
            this.chbCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCounterparty.AutoSize = true;
            this.chbCounterparty.Location = new System.Drawing.Point(738, 25);
            this.chbCounterparty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbCounterparty.Name = "chbCounterparty";
            this.chbCounterparty.Size = new System.Drawing.Size(91, 24);
            this.chbCounterparty.TabIndex = 139;
            this.chbCounterparty.TabStop = true;
            this.chbCounterparty.Text = "شماره مشتری";
            this.chbCounterparty.UseVisualStyleBackColor = true;
            this.chbCounterparty.CheckedChanged += new System.EventHandler(this.chbCounterparty_CheckedChanged);
            // 
            // txtCounterPartyName
            // 
            this.txtCounterPartyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance4.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance4.ImageBackground")));
            this.txtCounterPartyName.Appearance = appearance4;
            this.txtCounterPartyName.Location = new System.Drawing.Point(6, 25);
            this.txtCounterPartyName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCounterPartyName.Name = "txtCounterPartyName";
            this.txtCounterPartyName.ReadOnly = true;
            this.txtCounterPartyName.Size = new System.Drawing.Size(517, 30);
            this.txtCounterPartyName.TabIndex = 15;
            // 
            // txtCounterparty
            // 
            this.txtCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance5.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance5.ImageBackground")));
            editorButton2.Appearance = appearance5;
            editorButton2.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button;
            editorButton2.Key = "Search";
            appearance6.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance6.ImageBackground")));
            editorButton2.PressedAppearance = appearance6;
            editorButton2.Text = "جستجو";
            this.txtCounterparty.ButtonsLeft.Add(editorButton2);
            this.txtCounterparty.Enabled = false;
            this.txtCounterparty.Location = new System.Drawing.Point(530, 24);
            this.txtCounterparty.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCounterparty.Name = "txtCounterparty";
            this.txtCounterparty.Size = new System.Drawing.Size(176, 30);
            this.txtCounterparty.TabIndex = 14;
            this.txtCounterparty.EditorButtonClick += new Infragistics.Win.UltraWinEditors.EditorButtonEventHandler(this.txtCounterparty_EditorButtonClick);
            // 
            // chbCounterpartyName
            // 
            this.chbCounterpartyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCounterpartyName.AutoSize = true;
            this.chbCounterpartyName.Location = new System.Drawing.Point(754, 98);
            this.chbCounterpartyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbCounterpartyName.Name = "chbCounterpartyName";
            this.chbCounterpartyName.Size = new System.Drawing.Size(75, 24);
            this.chbCounterpartyName.TabIndex = 138;
            this.chbCounterpartyName.TabStop = true;
            this.chbCounterpartyName.Text = "نام مشتری";
            this.chbCounterpartyName.UseVisualStyleBackColor = true;
            this.chbCounterpartyName.CheckedChanged += new System.EventHandler(this.chbCounterpartyName_CheckedChanged);
            // 
            // cgbCouterpartName
            // 
            this.cgbCouterpartName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cgbCouterpartName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbCouterpartName.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbCouterpartName.Controls.Add(this.txtCounterpartyNameSearch);
            this.cgbCouterpartName.Controls.Add(this.rdbContains);
            this.cgbCouterpartName.Controls.Add(this.rdbStartsWith);
            this.cgbCouterpartName.Controls.Add(this.rdbEndsWith);
            this.cgbCouterpartName.Location = new System.Drawing.Point(528, 93);
            this.cgbCouterpartName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cgbCouterpartName.Name = "cgbCouterpartName";
            this.cgbCouterpartName.Size = new System.Drawing.Size(178, 73);
            this.cgbCouterpartName.TabIndex = 137;
            // 
            // txtCounterpartyNameSearch
            // 
            this.txtCounterpartyNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            editorButton3.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button;
            editorButton3.Key = "Search";
            editorButton3.Text = "جستجو";
            this.txtCounterpartyNameSearch.ButtonsLeft.Add(editorButton3);
            this.txtCounterpartyNameSearch.Enabled = false;
            this.txtCounterpartyNameSearch.Location = new System.Drawing.Point(5, 10);
            this.txtCounterpartyNameSearch.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtCounterpartyNameSearch.Name = "txtCounterpartyNameSearch";
            this.txtCounterpartyNameSearch.Size = new System.Drawing.Size(166, 30);
            this.txtCounterpartyNameSearch.TabIndex = 14;
            this.txtCounterpartyNameSearch.EditorButtonClick += new Infragistics.Win.UltraWinEditors.EditorButtonEventHandler(this.txtCounterpartyNameSearch_EditorButtonClick);
            // 
            // rdbContains
            // 
            this.rdbContains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbContains.AutoSize = true;
            this.rdbContains.Checked = true;
            this.rdbContains.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbContains.Location = new System.Drawing.Point(126, 46);
            this.rdbContains.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbContains.Name = "rdbContains";
            this.rdbContains.Size = new System.Drawing.Size(46, 21);
            this.rdbContains.TabIndex = 132;
            this.rdbContains.TabStop = true;
            this.rdbContains.Text = "شامل";
            this.rdbContains.UseVisualStyleBackColor = true;
            // 
            // rdbStartsWith
            // 
            this.rdbStartsWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbStartsWith.AutoSize = true;
            this.rdbStartsWith.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbStartsWith.Location = new System.Drawing.Point(69, 46);
            this.rdbStartsWith.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbStartsWith.Name = "rdbStartsWith";
            this.rdbStartsWith.Size = new System.Drawing.Size(53, 21);
            this.rdbStartsWith.TabIndex = 132;
            this.rdbStartsWith.Text = "شروع با";
            this.rdbStartsWith.UseVisualStyleBackColor = true;
            // 
            // rdbEndsWith
            // 
            this.rdbEndsWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbEndsWith.AutoSize = true;
            this.rdbEndsWith.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbEndsWith.Location = new System.Drawing.Point(8, 46);
            this.rdbEndsWith.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbEndsWith.Name = "rdbEndsWith";
            this.rdbEndsWith.Size = new System.Drawing.Size(50, 21);
            this.rdbEndsWith.TabIndex = 132;
            this.rdbEndsWith.Text = "پایان با";
            this.rdbEndsWith.UseVisualStyleBackColor = true;
            // 
            // dgvCounterpartiesNames
            // 
            this.dgvCounterpartiesNames.AllowUserToAddRows = false;
            this.dgvCounterpartiesNames.AllowUserToDeleteRows = false;
            this.dgvCounterpartiesNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCounterpartiesNames.BackgroundColor = System.Drawing.Color.White;
            this.dgvCounterpartiesNames.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCounterpartiesNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCounterpartiesNames.Location = new System.Drawing.Point(6, 98);
            this.dgvCounterpartiesNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCounterpartiesNames.Name = "dgvCounterpartiesNames";
            this.dgvCounterpartiesNames.ReadOnly = true;
            this.dgvCounterpartiesNames.RowTemplate.Height = 24;
            this.dgvCounterpartiesNames.Size = new System.Drawing.Size(515, 133);
            this.dgvCounterpartiesNames.TabIndex = 136;
            // 
            // txtCounterpartyNames
            // 
            this.txtCounterpartyNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterpartyNames.Location = new System.Drawing.Point(402, 206);
            this.txtCounterpartyNames.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtCounterpartyNames.Name = "txtCounterpartyNames";
            this.txtCounterpartyNames.ReadOnly = true;
            this.txtCounterpartyNames.Size = new System.Drawing.Size(0, 30);
            this.txtCounterpartyNames.TabIndex = 140;
            this.txtCounterpartyNames.Visible = false;
            // 
            // ucNationality
            // 
            this.ucNationality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucNationality.BackColor = System.Drawing.Color.Transparent;
            this.ucNationality.DataSource = null;
            this.ucNationality.DisplayMember = null;
            this.ucNationality.EnableShowClearSelectedItem = true;
            this.ucNationality.EnableShowSelectedItem = true;
            this.ucNationality.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucNationality.IsPersian = true;
            this.ucNationality.Location = new System.Drawing.Point(32, 196);
            this.ucNationality.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucNationality.Name = "ucNationality";
            this.ucNationality.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucNationality.Size = new System.Drawing.Size(0, 42);
            this.ucNationality.TabIndex = 132;
            this.ucNationality.Title = "ملیت";
            this.ucNationality.ValueMember = null;
            this.ucNationality.Visible = false;
            // 
            // ucfCounterPartyType
            // 
            this.ucfCounterPartyType.BackColor = System.Drawing.Color.Transparent;
            this.ucfCounterPartyType.DataSource = null;
            this.ucfCounterPartyType.DisplayMember = null;
            this.ucfCounterPartyType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucfCounterPartyType.EnableShowClearSelectedItem = true;
            this.ucfCounterPartyType.EnableShowSelectedItem = true;
            this.ucfCounterPartyType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfCounterPartyType.IsPersian = false;
            this.ucfCounterPartyType.Location = new System.Drawing.Point(0, 47);
            this.ucfCounterPartyType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucfCounterPartyType.Name = "ucfCounterPartyType";
            this.ucfCounterPartyType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCounterPartyType.Size = new System.Drawing.Size(831, 57);
            this.ucfCounterPartyType.TabIndex = 129;
            this.ucfCounterPartyType.Title = "نوع مشتری";
            this.ucfCounterPartyType.ValueMember = null;
            // 
            // ucfCustomerGroup
            // 
            this.ucfCustomerGroup.BackColor = System.Drawing.Color.Transparent;
            this.ucfCustomerGroup.DataSource = null;
            this.ucfCustomerGroup.DisplayMember = null;
            this.ucfCustomerGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucfCustomerGroup.EnableShowClearSelectedItem = true;
            this.ucfCustomerGroup.EnableShowSelectedItem = true;
            this.ucfCustomerGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfCustomerGroup.IsPersian = false;
            this.ucfCustomerGroup.Location = new System.Drawing.Point(0, 0);
            this.ucfCustomerGroup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucfCustomerGroup.Name = "ucfCustomerGroup";
            this.ucfCustomerGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCustomerGroup.Size = new System.Drawing.Size(831, 47);
            this.ucfCustomerGroup.TabIndex = 130;
            this.ucfCustomerGroup.Title = "گروه مشتری";
            this.ucfCustomerGroup.ValueMember = null;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.ucMaritalStatus);
            this.uiTabPage1.Controls.Add(this.ucSokunat);
            this.uiTabPage1.Controls.Add(this.ucEducation);
            this.uiTabPage1.Controls.Add(this.ucSex);
            this.uiTabPage1.Location = new System.Drawing.Point(2, 50);
            this.uiTabPage1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(501, 401);
            this.uiTabPage1.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage1.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage1.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage1.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage1.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage1.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.TabVisible = false;
            this.uiTabPage1.Text = "مشتری حقیقی";
            // 
            // ucMaritalStatus
            // 
            this.ucMaritalStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucMaritalStatus.BackColor = System.Drawing.Color.Transparent;
            this.ucMaritalStatus.DataSource = null;
            this.ucMaritalStatus.DisplayMember = null;
            this.ucMaritalStatus.EnableShowClearSelectedItem = true;
            this.ucMaritalStatus.EnableShowSelectedItem = true;
            this.ucMaritalStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMaritalStatus.IsPersian = true;
            this.ucMaritalStatus.Location = new System.Drawing.Point(12, 150);
            this.ucMaritalStatus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucMaritalStatus.Name = "ucMaritalStatus";
            this.ucMaritalStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucMaritalStatus.Size = new System.Drawing.Size(475, 63);
            this.ucMaritalStatus.TabIndex = 143;
            this.ucMaritalStatus.Title = "وضعیت تاهل";
            this.ucMaritalStatus.ValueMember = null;
            // 
            // ucSokunat
            // 
            this.ucSokunat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSokunat.BackColor = System.Drawing.Color.Transparent;
            this.ucSokunat.DataSource = null;
            this.ucSokunat.DisplayMember = null;
            this.ucSokunat.EnableShowClearSelectedItem = true;
            this.ucSokunat.EnableShowSelectedItem = true;
            this.ucSokunat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSokunat.IsPersian = true;
            this.ucSokunat.Location = new System.Drawing.Point(12, 222);
            this.ucSokunat.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucSokunat.Name = "ucSokunat";
            this.ucSokunat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucSokunat.Size = new System.Drawing.Size(475, 63);
            this.ucSokunat.TabIndex = 142;
            this.ucSokunat.Title = "وضعیت سکونت";
            this.ucSokunat.ValueMember = null;
            // 
            // ucEducation
            // 
            this.ucEducation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucEducation.BackColor = System.Drawing.Color.Transparent;
            this.ucEducation.DataSource = null;
            this.ucEducation.DisplayMember = null;
            this.ucEducation.EnableShowClearSelectedItem = true;
            this.ucEducation.EnableShowSelectedItem = true;
            this.ucEducation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEducation.IsPersian = true;
            this.ucEducation.Location = new System.Drawing.Point(13, 77);
            this.ucEducation.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucEducation.Name = "ucEducation";
            this.ucEducation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucEducation.Size = new System.Drawing.Size(475, 63);
            this.ucEducation.TabIndex = 141;
            this.ucEducation.Title = "سطح تحصیلات";
            this.ucEducation.ValueMember = null;
            // 
            // ucSex
            // 
            this.ucSex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSex.BackColor = System.Drawing.Color.Transparent;
            this.ucSex.DataSource = null;
            this.ucSex.DisplayMember = null;
            this.ucSex.EnableShowClearSelectedItem = true;
            this.ucSex.EnableShowSelectedItem = true;
            this.ucSex.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSex.IsPersian = true;
            this.ucSex.Location = new System.Drawing.Point(12, 5);
            this.ucSex.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucSex.Name = "ucSex";
            this.ucSex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucSex.Size = new System.Drawing.Size(475, 63);
            this.ucSex.TabIndex = 140;
            this.ucSex.Title = "جنسیت";
            this.ucSex.ValueMember = null;
            // 
            // uiTabPage5
            // 
            this.uiTabPage5.Controls.Add(this.ucEconomicPart);
            this.uiTabPage5.Controls.Add(this.ucCompanyType);
            this.uiTabPage5.Controls.Add(this.ucJobType);
            this.uiTabPage5.Location = new System.Drawing.Point(2, 50);
            this.uiTabPage5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uiTabPage5.Name = "uiTabPage5";
            this.uiTabPage5.Size = new System.Drawing.Size(501, 401);
            this.uiTabPage5.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage5.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage5.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage5.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage5.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage5.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage5.TabStop = true;
            this.uiTabPage5.TabVisible = false;
            this.uiTabPage5.Text = "مشتری حقوقی";
            // 
            // ucEconomicPart
            // 
            this.ucEconomicPart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucEconomicPart.BackColor = System.Drawing.Color.Transparent;
            this.ucEconomicPart.DataSource = null;
            this.ucEconomicPart.DisplayMember = null;
            this.ucEconomicPart.EnableShowClearSelectedItem = true;
            this.ucEconomicPart.EnableShowSelectedItem = true;
            this.ucEconomicPart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEconomicPart.IsPersian = true;
            this.ucEconomicPart.Location = new System.Drawing.Point(12, 22);
            this.ucEconomicPart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucEconomicPart.Name = "ucEconomicPart";
            this.ucEconomicPart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucEconomicPart.Size = new System.Drawing.Size(475, 63);
            this.ucEconomicPart.TabIndex = 138;
            this.ucEconomicPart.Title = "بخش اقتصادی مشتری";
            this.ucEconomicPart.ValueMember = null;
            // 
            // ucCompanyType
            // 
            this.ucCompanyType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCompanyType.BackColor = System.Drawing.Color.Transparent;
            this.ucCompanyType.DataSource = null;
            this.ucCompanyType.DisplayMember = null;
            this.ucCompanyType.EnableShowClearSelectedItem = true;
            this.ucCompanyType.EnableShowSelectedItem = true;
            this.ucCompanyType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCompanyType.IsPersian = true;
            this.ucCompanyType.Location = new System.Drawing.Point(12, 95);
            this.ucCompanyType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucCompanyType.Name = "ucCompanyType";
            this.ucCompanyType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucCompanyType.Size = new System.Drawing.Size(475, 63);
            this.ucCompanyType.TabIndex = 137;
            this.ucCompanyType.Title = "نوع شرکت";
            this.ucCompanyType.ValueMember = null;
            // 
            // ucJobType
            // 
            this.ucJobType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucJobType.BackColor = System.Drawing.Color.Transparent;
            this.ucJobType.DataSource = null;
            this.ucJobType.DisplayMember = null;
            this.ucJobType.EnableShowClearSelectedItem = true;
            this.ucJobType.EnableShowSelectedItem = true;
            this.ucJobType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucJobType.IsPersian = true;
            this.ucJobType.Location = new System.Drawing.Point(12, 169);
            this.ucJobType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucJobType.Name = "ucJobType";
            this.ucJobType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucJobType.Size = new System.Drawing.Size(475, 63);
            this.ucJobType.TabIndex = 136;
            this.ucJobType.Title = "ضمینه شغلی";
            this.ucJobType.ValueMember = null;
            // 
            // uiTabPage6
            // 
            this.uiTabPage6.Controls.Add(this.checkID);
            this.uiTabPage6.Controls.Add(this.panel2);
            this.uiTabPage6.Controls.Add(this.panel1);
            this.uiTabPage6.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage6.Name = "uiTabPage6";
            this.uiTabPage6.Size = new System.Drawing.Size(848, 306);
            this.uiTabPage6.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage6.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage6.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage6.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage6.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage6.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage6.TabStop = true;
            this.uiTabPage6.Text = "تنظیمات پرس و جو";
            // 
            // checkID
            // 
            this.checkID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkID.AutoSize = true;
            this.checkID.Location = new System.Drawing.Point(609, 115);
            this.checkID.Name = "checkID";
            this.checkID.Size = new System.Drawing.Size(221, 24);
            this.checkID.TabIndex = 150;
            this.checkID.Text = "نمایش چک صحت شناسه حقیقی یا حقوقی";
            this.checkID.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chbGroupBy);
            this.panel2.Controls.Add(this.cmbGroupBy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 47);
            this.panel2.TabIndex = 149;
            this.panel2.Visible = false;
            // 
            // chbGroupBy
            // 
            this.chbGroupBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbGroupBy.AutoSize = true;
            this.chbGroupBy.Location = new System.Drawing.Point(714, 14);
            this.chbGroupBy.Name = "chbGroupBy";
            this.chbGroupBy.Size = new System.Drawing.Size(116, 24);
            this.chbGroupBy.TabIndex = 146;
            this.chbGroupBy.Text = "گروه بندی بر اساس";
            this.chbGroupBy.UseVisualStyleBackColor = true;
            // 
            // cmbGroupBy
            // 
            this.cmbGroupBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance7.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance7.ImageBackground")));
            appearance7.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbGroupBy.Appearance = appearance7;
            this.cmbGroupBy.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbGroupBy.AutoSize = false;
            this.cmbGroupBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance8.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance8.ImageBackground")));
            appearance8.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbGroupBy.ButtonAppearance = appearance8;
            this.cmbGroupBy.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbGroupBy.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbGroupBy.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.DiagonalResize;
            this.cmbGroupBy.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbGroupBy.HideSelection = false;
            appearance9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbGroupBy.ItemAppearance = appearance9;
            this.cmbGroupBy.Location = new System.Drawing.Point(486, 14);
            this.cmbGroupBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbGroupBy.Name = "cmbGroupBy";
            this.cmbGroupBy.Size = new System.Drawing.Size(218, 22);
            this.cmbGroupBy.TabIndex = 145;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbOrderBy);
            this.panel1.Controls.Add(this.cmbOrderBy);
            this.panel1.Controls.Add(this.rdbDesc);
            this.panel1.Controls.Add(this.rdbAsc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 52);
            this.panel1.TabIndex = 149;
            // 
            // chbOrderBy
            // 
            this.chbOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbOrderBy.AutoSize = true;
            this.chbOrderBy.Location = new System.Drawing.Point(710, 15);
            this.chbOrderBy.Name = "chbOrderBy";
            this.chbOrderBy.Size = new System.Drawing.Size(122, 24);
            this.chbOrderBy.TabIndex = 142;
            this.chbOrderBy.Text = "مرتب سازی بر اساس";
            this.chbOrderBy.UseVisualStyleBackColor = true;
            this.chbOrderBy.CheckedChanged += new System.EventHandler(this.chbOrderBy_CheckedChanged);
            // 
            // cmbOrderBy
            // 
            this.cmbOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance10.ImageBackground")));
            appearance10.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbOrderBy.Appearance = appearance10;
            this.cmbOrderBy.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbOrderBy.AutoSize = false;
            this.cmbOrderBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance11.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance11.ImageBackground")));
            appearance11.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbOrderBy.ButtonAppearance = appearance11;
            this.cmbOrderBy.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbOrderBy.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbOrderBy.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.DiagonalResize;
            this.cmbOrderBy.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbOrderBy.Enabled = false;
            this.cmbOrderBy.HideSelection = false;
            appearance12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbOrderBy.ItemAppearance = appearance12;
            this.cmbOrderBy.Location = new System.Drawing.Point(486, 15);
            this.cmbOrderBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOrderBy.Name = "cmbOrderBy";
            this.cmbOrderBy.Size = new System.Drawing.Size(218, 22);
            this.cmbOrderBy.TabIndex = 0;
            // 
            // rdbDesc
            // 
            this.rdbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDesc.AutoSize = true;
            this.rdbDesc.Enabled = false;
            this.rdbDesc.Location = new System.Drawing.Point(351, 14);
            this.rdbDesc.Name = "rdbDesc";
            this.rdbDesc.Size = new System.Drawing.Size(51, 24);
            this.rdbDesc.TabIndex = 144;
            this.rdbDesc.Text = "نزولی";
            this.rdbDesc.UseVisualStyleBackColor = true;
            // 
            // rdbAsc
            // 
            this.rdbAsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbAsc.AutoSize = true;
            this.rdbAsc.Checked = true;
            this.rdbAsc.Enabled = false;
            this.rdbAsc.Location = new System.Drawing.Point(406, 14);
            this.rdbAsc.Name = "rdbAsc";
            this.rdbAsc.Size = new System.Drawing.Size(61, 24);
            this.rdbAsc.TabIndex = 143;
            this.rdbAsc.TabStop = true;
            this.rdbAsc.Text = "صعودی";
            this.rdbAsc.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ucSelectColumn);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(858, 332);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 141;
            // 
            // ucSelectColumn
            // 
            this.ucSelectColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.ucSelectColumn.DataSource = null;
            this.ucSelectColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSelectColumn.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ucSelectColumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.ucSelectColumn.Location = new System.Drawing.Point(0, 0);
            this.ucSelectColumn.Margin = new System.Windows.Forms.Padding(4, 60, 4, 60);
            this.ucSelectColumn.Name = "ucSelectColumn";
            this.ucSelectColumn.NameOfDisplay = null;
            this.ucSelectColumn.NameOfValue = null;
            this.ucSelectColumn.Size = new System.Drawing.Size(858, 195);
            this.ucSelectColumn.TabIndex = 140;
            this.ucSelectColumn.Title = null;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer5.Location = new System.Drawing.Point(442, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.btnNewReport);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer5.Size = new System.Drawing.Size(416, 130);
            this.splitContainer5.SplitterDistance = 138;
            this.splitContainer5.TabIndex = 141;
            // 
            // btnNewReport
            // 
            this.btnNewReport.AutoSize = true;
            this.btnNewReport.BackColor = System.Drawing.Color.Transparent;
            this.btnNewReport.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnNewReport.DefaultImage")));
            this.btnNewReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewReport.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnNewReport.HoverImage")));
            this.btnNewReport.Location = new System.Drawing.Point(0, 0);
            this.btnNewReport.Margin = new System.Windows.Forms.Padding(3, 46, 3, 46);
            this.btnNewReport.Name = "btnNewReport";
            this.btnNewReport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewReport.Size = new System.Drawing.Size(138, 130);
            this.btnNewReport.TabIndex = 139;
            this.btnNewReport.Title = null;
            this.btnNewReport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnNewReport_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btnSave);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnShowNormalReport);
            this.splitContainer4.Size = new System.Drawing.Size(274, 130);
            this.splitContainer4.SplitterDistance = 129;
            this.splitContainer4.TabIndex = 140;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnSave.DefaultImage")));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnSave.HoverImage")));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 46, 3, 46);
            this.btnSave.Name = "btnSave";
            this.btnSave.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Size = new System.Drawing.Size(129, 130);
            this.btnSave.TabIndex = 132;
            this.btnSave.Title = null;
            this.btnSave.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnSave_Click);
            // 
            // btnShowNormalReport
            // 
            this.btnShowNormalReport.AutoSize = true;
            this.btnShowNormalReport.BackColor = System.Drawing.Color.Transparent;
            this.btnShowNormalReport.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnShowNormalReport.DefaultImage")));
            this.btnShowNormalReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowNormalReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowNormalReport.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowNormalReport.HoverImage")));
            this.btnShowNormalReport.Location = new System.Drawing.Point(0, 0);
            this.btnShowNormalReport.Margin = new System.Windows.Forms.Padding(3, 46, 3, 46);
            this.btnShowNormalReport.Name = "btnShowNormalReport";
            this.btnShowNormalReport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowNormalReport.Size = new System.Drawing.Size(141, 130);
            this.btnShowNormalReport.TabIndex = 131;
            this.btnShowNormalReport.Title = null;
            this.btnShowNormalReport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnShowNormalReport_Click);
            this.btnShowNormalReport.Load += new System.EventHandler(this.btnShowNormalReport_Load);
            // 
            // ugbReports
            // 
            this.ugbReports.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center;
            this.ugbReports.Controls.Add(this.trnReport);
            this.ugbReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ugbReports.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ugbReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.ugbReports.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder;
            this.ugbReports.Location = new System.Drawing.Point(0, 0);
            this.ugbReports.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ugbReports.Name = "ugbReports";
            this.ugbReports.Size = new System.Drawing.Size(323, 709);
            this.ugbReports.TabIndex = 136;
            this.ugbReports.Text = "گزارشات موجود";
            // 
            // trnReport
            // 
            this.trnReport.AllowAutoDragScrolling = false;
            appearance13.ImageBackground = global::Presentation.Properties.Resources.S_BGComponents_Ver;
            this.trnReport.Appearance = appearance13;
            this.trnReport.ContextMenuStrip = this.cmsReport;
            this.trnReport.DisplayStyle = Infragistics.Win.UltraWinTree.UltraTreeDisplayStyle.WindowsVista;
            this.trnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trnReport.FullRowSelect = true;
            this.trnReport.Location = new System.Drawing.Point(3, 30);
            this.trnReport.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.trnReport.Name = "trnReport";
            this.trnReport.NodeConnectorStyle = Infragistics.Win.UltraWinTree.NodeConnectorStyle.Inset;
            this.trnReport.ShowLines = false;
            this.trnReport.ShowRootLines = false;
            this.trnReport.Size = new System.Drawing.Size(317, 676);
            this.trnReport.TabIndex = 134;
            this.trnReport.ViewStyle = Infragistics.Win.UltraWinTree.ViewStyle.FreeForm;
            this.trnReport.Click += new System.EventHandler(this.trnReport_Click);
            // 
            // frmDepositReportcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(1185, 709);
            this.Controls.Add(this.splitContainer3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDepositReportcs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "گزارش سپرده ها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDepositReportcs_Load);
            this.cmsReport.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ugbSFiltering)).EndInit();
            this.ugbSFiltering.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cGroupBox2)).EndInit();
            this.cGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cGroupBox1)).EndInit();
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.uiTabPage3.ResumeLayout(false);
            this.pnlMaturityDate.ResumeLayout(false);
            this.pnlMaturityDate.PerformLayout();
            this.pnlStartDate.ResumeLayout(false);
            this.pnlStartDate.PerformLayout();
            this.uiTabPage4.ResumeLayout(false);
            this.uiTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCustCodeName)).EndInit();
            this.cgbCustCodeName.ResumeLayout(false);
            this.cgbCustCodeName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepNoName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterPartyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterparty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCouterpartName)).EndInit();
            this.cgbCouterpartName.ResumeLayout(false);
            this.cgbCouterpartName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNameSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNames)).EndInit();
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage5.ResumeLayout(false);
            this.uiTabPage6.ResumeLayout(false);
            this.uiTabPage6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroupBy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrderBy)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ugbReports)).EndInit();
            this.ugbReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trnReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterparty;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterPartyName;
        private System.Windows.Forms.CheckBox chbMaturityDate;
        private System.Windows.Forms.CheckBox chbStartDate;
        private System.Windows.Forms.Panel pnlMaturityDate;
        private System.Windows.Forms.Label label8;
        private FarsiLibrary.Win.Controls.FADatePicker fdpToMaturityDate;
        private System.Windows.Forms.Label label9;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFromMaturityDate;
        private System.Windows.Forms.Panel pnlStartDate;
        private System.Windows.Forms.Label label10;
        private FarsiLibrary.Win.Controls.FADatePicker fdpToStartDate;
        private System.Windows.Forms.Label label11;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFromStartDate;
        private UCFiltering ucfState;
        private UCFiltering ucfOrganization;
        private UCFiltering ucFilteringContractTypeCodeDep;
        private UCFiltering ucfCurrency;
        private UCFiltering ucfCounterPartyType;
        private UCFiltering ucfCustomerGroup;
        private Utilize.Company.CButton btnShowNormalReport;
        private Utilize.Company.CButton btnSave;
        private Infragistics.Win.UltraWinTree.UltraTree trnReport;
        private Infragistics.Win.Misc.UltraGroupBox ugbReports;
        private Utilize.Company.CButton btnNewReport;
        private System.Windows.Forms.ContextMenuStrip cmsReport;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveReport;
        private System.Windows.Forms.ToolStripMenuItem btnChart;
        private System.Windows.Forms.ToolStripMenuItem btnShowReport_2;
        private UCFiltering ucfContractTypeDep;
        private UCFiltering ucfDepositContractStatus;
        private Utilize.Report.SelectColumn ucSelectColumn;
        private Janus.Windows.UI.Tab.UITab tabMain;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage4;
        private Infragistics.Win.Misc.UltraGroupBox ugbSFiltering;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private UCFiltering ucMaritalStatus;
        private UCFiltering ucSokunat;
        private UCFiltering ucEducation;
        private UCFiltering ucSex;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage5;
        private UCFiltering ucEconomicPart;
        private UCFiltering ucCompanyType;
        private UCFiltering ucJobType;
        private UCFiltering ucNationality;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Utilize.Company.CGroupBox cGroupBox2;
        private Utilize.Company.CGroupBox cGroupBox1;
        private FarsiLibrary.Win.Controls.FADatePicker fdpHistoricDate;
        private System.Windows.Forms.RadioButton rdbDate_Historic;
        private System.Windows.Forms.RadioButton rdbDate_Today;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private Utilize.Company.CGroupBox cgbCouterpartName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterpartyNameSearch;
        private System.Windows.Forms.RadioButton rdbContains;
        private System.Windows.Forms.RadioButton rdbStartsWith;
        private System.Windows.Forms.RadioButton rdbEndsWith;
        private System.Windows.Forms.DataGridView dgvCounterpartiesNames;
        private System.Windows.Forms.RadioButton chbCounterparty;
        private System.Windows.Forms.RadioButton chbCounterpartyName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterpartyNames;
        private Utilize.Company.CGroupBox cgbCustCodeName;
        private System.Windows.Forms.CheckBox chbCustCodeName;
        private UCFiltering ucfCity;
        private System.Windows.Forms.RadioButton chbDepNo;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDepNoName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDepNo;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage6;
        private System.Windows.Forms.CheckBox chbOrderBy;
        private Utilize.Company.CComboCox cmbOrderBy;
        private System.Windows.Forms.RadioButton rdbAsc;
        private System.Windows.Forms.RadioButton rdbDesc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chbGroupBy;
        private Utilize.Company.CComboCox cmbGroupBy;
        private System.Windows.Forms.Panel panel1;
        private Utilize.Company.CButton cbCloseAll;
        private System.Windows.Forms.CheckBox checkID;
    }
}