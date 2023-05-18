using Utilize.Report;

namespace Presentation.Loan
{
    partial class frmLoanReportCs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanReportCs));
            this.cmsReport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRemoveReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowReport_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ugbSFiltering = new System.Windows.Forms.GroupBox();
            this.cbCloseAll = new Utilize.Company.CButton();
            this.tabMain = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.cGroupBox2 = new System.Windows.Forms.GroupBox();
            this.ucfOrganization = new Utilize.Report.UCFiltering();
            this.ucfCity = new Utilize.Report.UCFiltering();
            this.ucfState = new Utilize.Report.UCFiltering();
            this.cGroupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fdpHistoricDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.rdbDate_Historic = new System.Windows.Forms.RadioButton();
            this.rdbDate_Today = new System.Windows.Forms.RadioButton();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateOverdue3Coef = new System.Windows.Forms.TextBox();
            this.ucEconomicSector = new Utilize.Report.UCFiltering();
            this.ucContractStatus = new Utilize.Report.UCFiltering();
            this.pnlMaturityDate = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.fdpToMaturityDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.fdpFromMaturityDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.chbMaturityDate = new System.Windows.Forms.CheckBox();
            this.pnlStartDate = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.fdpToStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.chbStartDate = new System.Windows.Forms.CheckBox();
            this.fdpFromStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ucFilteringContractTypeCode = new Utilize.Report.UCFiltering();
            this.ucfContractType = new Utilize.Report.UCFiltering();
            this.uiTabPage4 = new Janus.Windows.UI.Tab.UITabPage();
            this.chbCustCodeName = new System.Windows.Forms.CheckBox();
            this.cgbCustCodeName = new System.Windows.Forms.GroupBox();
            this.chbDepNo = new System.Windows.Forms.RadioButton();
            this.txtDepNoName = new System.Windows.Forms.TextBox();
            this.txtDepNo = new System.Windows.Forms.TextBox();
            this.chbCounterparty1 = new System.Windows.Forms.RadioButton();
            this.txtCounterparty = new System.Windows.Forms.TextBox();
            this.txtCounterPartyName = new System.Windows.Forms.TextBox();
            this.cgbCouterpartName = new System.Windows.Forms.GroupBox();
            this.txtCounterpartyNameSearch = new System.Windows.Forms.TextBox();
            this.rdbContains = new System.Windows.Forms.RadioButton();
            this.rdbStartsWith = new System.Windows.Forms.RadioButton();
            this.rdbEndsWith = new System.Windows.Forms.RadioButton();
            this.chbCounterpartyName1 = new System.Windows.Forms.RadioButton();
            this.dgvCounterpartiesNames = new System.Windows.Forms.DataGridView();
            this.ucfCustomerGroup = new Utilize.Report.UCFiltering();
            this.ucfCounterPartyType = new Utilize.Report.UCFiltering();
            this.txtCounterpartyNames = new System.Windows.Forms.TextBox();
            this.ucNationality = new Utilize.Report.UCFiltering();
            this.utpCollat = new Janus.Windows.UI.Tab.UITabPage();
            this.ucfCollateralStatus = new Utilize.Report.UCFiltering();
            this.ucfCollateralType = new Utilize.Report.UCFiltering();
            this.ucfCollatMajorType = new Utilize.Report.UCFiltering();
            this.uiTabRealCust = new Janus.Windows.UI.Tab.UITabPage();
            this.ucMaritalStatus = new Utilize.Report.UCFiltering();
            this.ucSokunat = new Utilize.Report.UCFiltering();
            this.ucEducation = new Utilize.Report.UCFiltering();
            this.ucSex = new Utilize.Report.UCFiltering();
            this.uiTabPage5 = new Janus.Windows.UI.Tab.UITabPage();
            this.ucJobType = new Utilize.Report.UCFiltering();
            this.ucEconomicPart = new Utilize.Report.UCFiltering();
            this.ucCompanyType = new Utilize.Report.UCFiltering();
            this.uiTabPage6 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chAbis = new System.Windows.Forms.CheckBox();
            this.chbOrderBy = new System.Windows.Forms.CheckBox();
            this.cmbOrderBy = new System.Windows.Forms.ComboBox();
            this.rdbDesc = new System.Windows.Forms.RadioButton();
            this.rdbAsc = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucSelectColumn = new Utilize.Report.SelectColumn();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.btnNewReport = new Utilize.Company.CButton();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnSave = new Utilize.Company.CButton();
            this.btnShowNormalReport = new Utilize.Company.CButton();
            this.ugbReports = new System.Windows.Forms.GroupBox();
            this.trnReport = new System.Windows.Forms.TreeView();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateOverdue3Coef)).BeginInit();
            this.pnlMaturityDate.SuspendLayout();
            this.pnlStartDate.SuspendLayout();
            this.uiTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCustCodeName)).BeginInit();
            this.cgbCustCodeName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepNoName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterparty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterPartyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCouterpartName)).BeginInit();
            this.cgbCouterpartName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNameSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNames)).BeginInit();
            this.utpCollat.SuspendLayout();
            this.uiTabRealCust.SuspendLayout();
            this.uiTabPage5.SuspendLayout();
            this.uiTabPage6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.cmsReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsReport.Size = new System.Drawing.Size(145, 70);
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
            this.btnShowReport_2.Click += new System.EventHandler(this.btnShowNormalReport_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.Transparent;
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
            this.splitContainer3.Size = new System.Drawing.Size(914, 742);
            this.splitContainer3.SplitterDistance = 727;
            this.splitContainer3.TabIndex = 143;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
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
            this.splitContainer2.Size = new System.Drawing.Size(727, 742);
            this.splitContainer2.SplitterDistance = 403;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 142;
            // 
            // ugbSFiltering
            // 
            this.ugbSFiltering.Controls.Add(this.cbCloseAll);
            this.ugbSFiltering.Controls.Add(this.tabMain);
            this.ugbSFiltering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ugbSFiltering.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ugbSFiltering.Location = new System.Drawing.Point(0, 0);
            this.ugbSFiltering.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ugbSFiltering.Name = "ugbSFiltering";
            this.ugbSFiltering.Size = new System.Drawing.Size(727, 403);
            this.ugbSFiltering.TabIndex = 137;
            this.ugbSFiltering.Text = "تنظیمات فیلتر بندی";
            // 
            // cbCloseAll
            // 
            this.cbCloseAll.BackColor = System.Drawing.Color.Transparent;
            this.cbCloseAll.DefaultImage = global::Presentation.Properties.Resources.help;
            this.cbCloseAll.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cbCloseAll.HoverImage = global::Presentation.Properties.Resources.help_hover;
            this.cbCloseAll.Location = new System.Drawing.Point(3, -3);
            this.cbCloseAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbCloseAll.Name = "cbCloseAll";
            this.cbCloseAll.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCloseAll.Size = new System.Drawing.Size(84, 34);
            this.cbCloseAll.TabIndex = 135;
            this.cbCloseAll.Title = null;
            this.cbCloseAll.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbCloseAll_CButtonClicked);
            this.cbCloseAll.Load += new System.EventHandler(this.cbCloseAll_Load);
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.tabMain.Location = new System.Drawing.Point(3, 30);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabMain.Size = new System.Drawing.Size(721, 370);
            this.tabMain.TabIndex = 134;
            this.tabMain.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage1,
            this.uiTabPage3,
            this.uiTabPage4,
            this.utpCollat,
            this.uiTabRealCust,
            this.uiTabPage5,
            this.uiTabPage6});
            this.tabMain.TabsStateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabMain.TabsStateStyles.FormatStyle.BackgroundImage")));
            this.tabMain.TabStripFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.UseThemes = false;
            this.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.AutoScroll = true;
            this.uiTabPage2.Controls.Add(this.cGroupBox2);
            this.uiTabPage2.Controls.Add(this.cGroupBox1);
            this.uiTabPage2.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage2.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage2.Size = new System.Drawing.Size(717, 339);
            this.uiTabPage2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "اطلاعات زمانی/مکانی";
            // 
            // cGroupBox2
            // 
            this.cGroupBox2.Controls.Add(this.ucfOrganization);
            this.cGroupBox2.Controls.Add(this.ucfCity);
            this.cGroupBox2.Controls.Add(this.ucfState);
            this.cGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.cGroupBox2.Location = new System.Drawing.Point(0, 67);
            this.cGroupBox2.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.cGroupBox2.Name = "cGroupBox2";
            this.cGroupBox2.Size = new System.Drawing.Size(717, 166);
            this.cGroupBox2.TabIndex = 131;
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
            this.ucfOrganization.Location = new System.Drawing.Point(3, 107);
            this.ucfOrganization.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucfOrganization.Name = "ucfOrganization";
            this.ucfOrganization.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfOrganization.Size = new System.Drawing.Size(711, 55);
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
            this.ucfCity.Location = new System.Drawing.Point(3, 65);
            this.ucfCity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucfCity.Name = "ucfCity";
            this.ucfCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCity.Size = new System.Drawing.Size(711, 42);
            this.ucfCity.TabIndex = 128;
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
            this.ucfState.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucfState.Name = "ucfState";
            this.ucfState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfState.Size = new System.Drawing.Size(711, 41);
            this.ucfState.TabIndex = 125;
            this.ucfState.Title = "استان";
            this.ucfState.ValueMember = null;
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.Controls.Add(this.label2);
            this.cGroupBox1.Controls.Add(this.fdpHistoricDate);
            this.cGroupBox1.Controls.Add(this.rdbDate_Historic);
            this.cGroupBox1.Controls.Add(this.rdbDate_Today);
            this.cGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.cGroupBox1.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(717, 67);
            this.cGroupBox1.TabIndex = 129;
            this.cGroupBox1.Text = "گزارش گیری بر اساس داده های تاریخی تسهیلات";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 130;
            this.label2.Text = "تاریخ گزارش";
            // 
            // fdpHistoricDate
            // 
            this.fdpHistoricDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpHistoricDate.Location = new System.Drawing.Point(489, 31);
            this.fdpHistoricDate.Name = "fdpHistoricDate";
            this.fdpHistoricDate.Size = new System.Drawing.Size(134, 21);
            this.fdpHistoricDate.TabIndex = 128;
            this.fdpHistoricDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.fdpHistoricDate.SelectedDateTimeChanged += new System.EventHandler(this.fdpHistoricDate_SelectedDateTimeChanged);
            // 
            // rdbDate_Historic
            // 
            this.rdbDate_Historic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDate_Historic.AutoSize = true;
            this.rdbDate_Historic.Checked = true;
            this.rdbDate_Historic.Location = new System.Drawing.Point(238, 16);
            this.rdbDate_Historic.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
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
            this.rdbDate_Today.Location = new System.Drawing.Point(303, 16);
            this.rdbDate_Today.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.rdbDate_Today.Name = "rdbDate_Today";
            this.rdbDate_Today.Size = new System.Drawing.Size(50, 24);
            this.rdbDate_Today.TabIndex = 127;
            this.rdbDate_Today.Text = "امروز";
            this.rdbDate_Today.UseVisualStyleBackColor = true;
            this.rdbDate_Today.Visible = false;
            this.rdbDate_Today.CheckedChanged += new System.EventHandler(this.rdbDate_Today_CheckedChanged);
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Location = new System.Drawing.Point(2, 36);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(717, 327);
            this.uiTabPage1.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage1.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage1.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage1.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.TabVisible = false;
            this.uiTabPage1.Text = "اطلاعات مکانی";
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.AutoScroll = true;
            this.uiTabPage3.Controls.Add(this.panel1);
            this.uiTabPage3.Controls.Add(this.ucEconomicSector);
            this.uiTabPage3.Controls.Add(this.ucContractStatus);
            this.uiTabPage3.Controls.Add(this.pnlMaturityDate);
            this.uiTabPage3.Controls.Add(this.pnlStartDate);
            this.uiTabPage3.Controls.Add(this.ucFilteringContractTypeCode);
            this.uiTabPage3.Controls.Add(this.ucfContractType);
            this.uiTabPage3.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage3.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage3.Size = new System.Drawing.Size(717, 339);
            this.uiTabPage3.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "اطلاعات قرارداد";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUpdateOverdue3Coef);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 285);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 42);
            this.panel1.TabIndex = 135;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "ضریب ذخیره مشکوک الوصول";
            // 
            // txtUpdateOverdue3Coef
            // 
            this.txtUpdateOverdue3Coef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateOverdue3Coef.Location = new System.Drawing.Point(428, 3);
            this.txtUpdateOverdue3Coef.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.txtUpdateOverdue3Coef.Name = "txtUpdateOverdue3Coef";
            this.txtUpdateOverdue3Coef.Size = new System.Drawing.Size(84, 30);
            this.txtUpdateOverdue3Coef.TabIndex = 15;
            this.txtUpdateOverdue3Coef.Text = "0.5";
            // 
            // ucEconomicSector
            // 
            this.ucEconomicSector.BackColor = System.Drawing.Color.Transparent;
            this.ucEconomicSector.DataSource = null;
            this.ucEconomicSector.DisplayMember = null;
            this.ucEconomicSector.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucEconomicSector.EnableShowClearSelectedItem = true;
            this.ucEconomicSector.EnableShowSelectedItem = true;
            this.ucEconomicSector.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEconomicSector.IsPersian = false;
            this.ucEconomicSector.Location = new System.Drawing.Point(0, 230);
            this.ucEconomicSector.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucEconomicSector.Name = "ucEconomicSector";
            this.ucEconomicSector.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucEconomicSector.Size = new System.Drawing.Size(717, 55);
            this.ucEconomicSector.TabIndex = 133;
            this.ucEconomicSector.Title = "بخش اقتصادی";
            this.ucEconomicSector.ValueMember = null;
            // 
            // ucContractStatus
            // 
            this.ucContractStatus.BackColor = System.Drawing.Color.Transparent;
            this.ucContractStatus.DataSource = null;
            this.ucContractStatus.DisplayMember = null;
            this.ucContractStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucContractStatus.EnableShowClearSelectedItem = true;
            this.ucContractStatus.EnableShowSelectedItem = true;
            this.ucContractStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucContractStatus.IsPersian = false;
            this.ucContractStatus.Location = new System.Drawing.Point(0, 184);
            this.ucContractStatus.Name = "ucContractStatus";
            this.ucContractStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucContractStatus.Size = new System.Drawing.Size(717, 46);
            this.ucContractStatus.TabIndex = 134;
            this.ucContractStatus.Title = "وضعیت قرارداد";
            this.ucContractStatus.ValueMember = null;
            // 
            // pnlMaturityDate
            // 
            this.pnlMaturityDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMaturityDate.Controls.Add(this.label8);
            this.pnlMaturityDate.Controls.Add(this.fdpToMaturityDate);
            this.pnlMaturityDate.Controls.Add(this.label9);
            this.pnlMaturityDate.Controls.Add(this.fdpFromMaturityDate);
            this.pnlMaturityDate.Controls.Add(this.chbMaturityDate);
            this.pnlMaturityDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMaturityDate.Location = new System.Drawing.Point(0, 142);
            this.pnlMaturityDate.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.pnlMaturityDate.Name = "pnlMaturityDate";
            this.pnlMaturityDate.Size = new System.Drawing.Size(717, 42);
            this.pnlMaturityDate.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "تا";
            // 
            // fdpToMaturityDate
            // 
            this.fdpToMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpToMaturityDate.Enabled = false;
            this.fdpToMaturityDate.Location = new System.Drawing.Point(188, 6);
            this.fdpToMaturityDate.Name = "fdpToMaturityDate";
            this.fdpToMaturityDate.Size = new System.Drawing.Size(120, 25);
            this.fdpToMaturityDate.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "از";
            // 
            // fdpFromMaturityDate
            // 
            this.fdpFromMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFromMaturityDate.Enabled = false;
            this.fdpFromMaturityDate.Location = new System.Drawing.Point(353, 7);
            this.fdpFromMaturityDate.Name = "fdpFromMaturityDate";
            this.fdpFromMaturityDate.Size = new System.Drawing.Size(120, 25);
            this.fdpFromMaturityDate.TabIndex = 32;
            // 
            // chbMaturityDate
            // 
            this.chbMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbMaturityDate.AutoSize = true;
            this.chbMaturityDate.Location = new System.Drawing.Point(574, 5);
            this.chbMaturityDate.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.chbMaturityDate.Name = "chbMaturityDate";
            this.chbMaturityDate.Size = new System.Drawing.Size(138, 24);
            this.chbMaturityDate.TabIndex = 114;
            this.chbMaturityDate.Text = "تاریخ سررسید تسهیلات";
            this.chbMaturityDate.UseVisualStyleBackColor = true;
            this.chbMaturityDate.CheckedChanged += new System.EventHandler(this.chbMaturityDate_CheckedChanged);
            // 
            // pnlStartDate
            // 
            this.pnlStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStartDate.Controls.Add(this.label10);
            this.pnlStartDate.Controls.Add(this.fdpToStartDate);
            this.pnlStartDate.Controls.Add(this.label11);
            this.pnlStartDate.Controls.Add(this.chbStartDate);
            this.pnlStartDate.Controls.Add(this.fdpFromStartDate);
            this.pnlStartDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStartDate.Location = new System.Drawing.Point(0, 99);
            this.pnlStartDate.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.pnlStartDate.Name = "pnlStartDate";
            this.pnlStartDate.Size = new System.Drawing.Size(717, 43);
            this.pnlStartDate.TabIndex = 115;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "تا";
            // 
            // fdpToStartDate
            // 
            this.fdpToStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpToStartDate.Enabled = false;
            this.fdpToStartDate.Location = new System.Drawing.Point(186, 7);
            this.fdpToStartDate.Name = "fdpToStartDate";
            this.fdpToStartDate.Size = new System.Drawing.Size(120, 25);
            this.fdpToStartDate.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(477, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "از";
            // 
            // chbStartDate
            // 
            this.chbStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbStartDate.AutoSize = true;
            this.chbStartDate.Location = new System.Drawing.Point(578, 7);
            this.chbStartDate.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.chbStartDate.Name = "chbStartDate";
            this.chbStartDate.Size = new System.Drawing.Size(135, 24);
            this.chbStartDate.TabIndex = 113;
            this.chbStartDate.Text = "تاریخ پرداخت تسهیلات";
            this.chbStartDate.UseVisualStyleBackColor = true;
            this.chbStartDate.CheckedChanged += new System.EventHandler(this.chbStartDate_CheckedChanged);
            // 
            // fdpFromStartDate
            // 
            this.fdpFromStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFromStartDate.Enabled = false;
            this.fdpFromStartDate.Location = new System.Drawing.Point(351, 7);
            this.fdpFromStartDate.Name = "fdpFromStartDate";
            this.fdpFromStartDate.Size = new System.Drawing.Size(120, 25);
            this.fdpFromStartDate.TabIndex = 32;
            // 
            // ucFilteringContractTypeCode
            // 
            this.ucFilteringContractTypeCode.BackColor = System.Drawing.Color.Transparent;
            this.ucFilteringContractTypeCode.DataSource = null;
            this.ucFilteringContractTypeCode.DisplayMember = null;
            this.ucFilteringContractTypeCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFilteringContractTypeCode.EnableShowClearSelectedItem = true;
            this.ucFilteringContractTypeCode.EnableShowSelectedItem = true;
            this.ucFilteringContractTypeCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucFilteringContractTypeCode.IsPersian = false;
            this.ucFilteringContractTypeCode.Location = new System.Drawing.Point(0, 53);
            this.ucFilteringContractTypeCode.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucFilteringContractTypeCode.Name = "ucFilteringContractTypeCode";
            this.ucFilteringContractTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucFilteringContractTypeCode.Size = new System.Drawing.Size(717, 46);
            this.ucFilteringContractTypeCode.TabIndex = 131;
            this.ucFilteringContractTypeCode.Title = "زیرنوع قرارداد";
            this.ucFilteringContractTypeCode.ValueMember = null;
            // 
            // ucfContractType
            // 
            this.ucfContractType.BackColor = System.Drawing.Color.Transparent;
            this.ucfContractType.DataSource = null;
            this.ucfContractType.DisplayMember = null;
            this.ucfContractType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucfContractType.EnableShowClearSelectedItem = true;
            this.ucfContractType.EnableShowSelectedItem = true;
            this.ucfContractType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfContractType.IsPersian = false;
            this.ucfContractType.Location = new System.Drawing.Point(0, 0);
            this.ucfContractType.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucfContractType.Name = "ucfContractType";
            this.ucfContractType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfContractType.Size = new System.Drawing.Size(717, 53);
            this.ucfContractType.TabIndex = 127;
            this.ucfContractType.Title = "نوع اصلی قرارداد";
            this.ucfContractType.ValueMember = null;
            this.ucfContractType.Load += new System.EventHandler(this.ucfContractType_Load);
            // 
            // uiTabPage4
            // 
            this.uiTabPage4.AutoScroll = true;
            this.uiTabPage4.Controls.Add(this.chbCustCodeName);
            this.uiTabPage4.Controls.Add(this.cgbCustCodeName);
            this.uiTabPage4.Controls.Add(this.ucfCustomerGroup);
            this.uiTabPage4.Controls.Add(this.ucfCounterPartyType);
            this.uiTabPage4.Controls.Add(this.txtCounterpartyNames);
            this.uiTabPage4.Controls.Add(this.ucNationality);
            this.uiTabPage4.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage4.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.uiTabPage4.Name = "uiTabPage4";
            this.uiTabPage4.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage4.Size = new System.Drawing.Size(717, 339);
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
            this.chbCustCodeName.Location = new System.Drawing.Point(155, 83);
            this.chbCustCodeName.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.chbCustCodeName.Name = "chbCustCodeName";
            this.chbCustCodeName.Size = new System.Drawing.Size(114, 24);
            this.chbCustCodeName.TabIndex = 0;
            this.chbCustCodeName.Text = "شماره / نام مشتری";
            this.chbCustCodeName.UseVisualStyleBackColor = true;
            this.chbCustCodeName.CheckedChanged += new System.EventHandler(this.chbCustCodeName_CheckedChanged);
            // 
            // cgbCustCodeName
            // 
            this.cgbCustCodeName.Controls.Add(this.chbDepNo);
            this.cgbCustCodeName.Controls.Add(this.txtDepNoName);
            this.cgbCustCodeName.Controls.Add(this.txtDepNo);
            this.cgbCustCodeName.Controls.Add(this.chbCounterparty1);
            this.cgbCustCodeName.Controls.Add(this.txtCounterparty);
            this.cgbCustCodeName.Controls.Add(this.txtCounterPartyName);
            this.cgbCustCodeName.Controls.Add(this.cgbCouterpartName);
            this.cgbCustCodeName.Controls.Add(this.chbCounterpartyName1);
            this.cgbCustCodeName.Controls.Add(this.dgvCounterpartiesNames);
            this.cgbCustCodeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.cgbCustCodeName.Enabled = false;
            this.cgbCustCodeName.Location = new System.Drawing.Point(0, 97);
            this.cgbCustCodeName.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.cgbCustCodeName.Name = "cgbCustCodeName";
            this.cgbCustCodeName.Size = new System.Drawing.Size(700, 251);
            this.cgbCustCodeName.TabIndex = 142;
            // 
            // chbDepNo
            // 
            this.chbDepNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbDepNo.AutoSize = true;
            this.chbDepNo.Location = new System.Drawing.Point(589, 55);
            this.chbDepNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbDepNo.Name = "chbDepNo";
            this.chbDepNo.Size = new System.Drawing.Size(99, 24);
            this.chbDepNo.TabIndex = 145;
            this.chbDepNo.TabStop = true;
            this.chbDepNo.Text = "شماره تسهیلات";
            this.chbDepNo.UseVisualStyleBackColor = true;
            this.chbDepNo.CheckedChanged += new System.EventHandler(this.chbDepNo_CheckedChanged);
            // 
            // txtDepNoName
            // 
            this.txtDepNoName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepNoName.Location = new System.Drawing.Point(6, 57);
            this.txtDepNoName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDepNoName.Name = "txtDepNoName";
            this.txtDepNoName.ReadOnly = true;
            this.txtDepNoName.Size = new System.Drawing.Size(378, 30);
            this.txtDepNoName.TabIndex = 144;
            // 
            // txtDepNo
            // 
            this.txtDepNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepNo.Enabled = false;
            this.txtDepNo.Location = new System.Drawing.Point(388, 56);
            this.txtDepNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDepNo.Name = "txtDepNo";
            this.txtDepNo.Size = new System.Drawing.Size(172, 30);
            this.txtDepNo.TabIndex = 143;
            // 
            // chbCounterparty1
            // 
            this.chbCounterparty1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCounterparty1.AutoSize = true;
            this.chbCounterparty1.Location = new System.Drawing.Point(597, 22);
            this.chbCounterparty1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.chbCounterparty1.Name = "chbCounterparty1";
            this.chbCounterparty1.Size = new System.Drawing.Size(91, 24);
            this.chbCounterparty1.TabIndex = 134;
            this.chbCounterparty1.TabStop = true;
            this.chbCounterparty1.Text = "شماره مشتری";
            this.chbCounterparty1.UseVisualStyleBackColor = true;
            this.chbCounterparty1.CheckedChanged += new System.EventHandler(this.chbCounterparty1_CheckedChanged);
            // 
            // txtCounterparty
            // 
            this.txtCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterparty.Enabled = false;
            this.txtCounterparty.Location = new System.Drawing.Point(388, 18);
            this.txtCounterparty.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.txtCounterparty.Name = "txtCounterparty";
            this.txtCounterparty.Size = new System.Drawing.Size(172, 30);
            this.txtCounterparty.TabIndex = 14;
            // 
            // txtCounterPartyName
            // 
            this.txtCounterPartyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterPartyName.Location = new System.Drawing.Point(6, 18);
            this.txtCounterPartyName.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.txtCounterPartyName.Name = "txtCounterPartyName";
            this.txtCounterPartyName.ReadOnly = true;
            this.txtCounterPartyName.Size = new System.Drawing.Size(378, 30);
            this.txtCounterPartyName.TabIndex = 15;
            // 
            // cgbCouterpartName
            // 
            this.cgbCouterpartName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cgbCouterpartName.Controls.Add(this.txtCounterpartyNameSearch);
            this.cgbCouterpartName.Controls.Add(this.rdbContains);
            this.cgbCouterpartName.Controls.Add(this.rdbStartsWith);
            this.cgbCouterpartName.Controls.Add(this.rdbEndsWith);
            this.cgbCouterpartName.Location = new System.Drawing.Point(386, 89);
            this.cgbCouterpartName.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.cgbCouterpartName.Name = "cgbCouterpartName";
            this.cgbCouterpartName.Size = new System.Drawing.Size(178, 94);
            this.cgbCouterpartName.TabIndex = 135;
            // 
            // txtCounterpartyNameSearch
            // 
            this.txtCounterpartyNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterpartyNameSearch.Enabled = false;
            this.txtCounterpartyNameSearch.Location = new System.Drawing.Point(6, 17);
            this.txtCounterpartyNameSearch.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.txtCounterpartyNameSearch.Name = "txtCounterpartyNameSearch";
            this.txtCounterpartyNameSearch.Size = new System.Drawing.Size(166, 30);
            this.txtCounterpartyNameSearch.TabIndex = 14;
            // 
            // rdbContains
            // 
            this.rdbContains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbContains.AutoSize = true;
            this.rdbContains.Checked = true;
            this.rdbContains.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbContains.Location = new System.Drawing.Point(126, 59);
            this.rdbContains.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
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
            this.rdbStartsWith.Location = new System.Drawing.Point(69, 59);
            this.rdbStartsWith.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
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
            this.rdbEndsWith.Location = new System.Drawing.Point(8, 59);
            this.rdbEndsWith.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.rdbEndsWith.Name = "rdbEndsWith";
            this.rdbEndsWith.Size = new System.Drawing.Size(50, 21);
            this.rdbEndsWith.TabIndex = 132;
            this.rdbEndsWith.Text = "پایان با";
            this.rdbEndsWith.UseVisualStyleBackColor = true;
            // 
            // chbCounterpartyName1
            // 
            this.chbCounterpartyName1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCounterpartyName1.AutoSize = true;
            this.chbCounterpartyName1.Location = new System.Drawing.Point(613, 87);
            this.chbCounterpartyName1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.chbCounterpartyName1.Name = "chbCounterpartyName1";
            this.chbCounterpartyName1.Size = new System.Drawing.Size(75, 24);
            this.chbCounterpartyName1.TabIndex = 134;
            this.chbCounterpartyName1.TabStop = true;
            this.chbCounterpartyName1.Text = "نام مشتری";
            this.chbCounterpartyName1.UseVisualStyleBackColor = true;
            this.chbCounterpartyName1.CheckedChanged += new System.EventHandler(this.chbCounterpartyName1_CheckedChanged);
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
            this.dgvCounterpartiesNames.Location = new System.Drawing.Point(6, 96);
            this.dgvCounterpartiesNames.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.dgvCounterpartiesNames.Name = "dgvCounterpartiesNames";
            this.dgvCounterpartiesNames.ReadOnly = true;
            this.dgvCounterpartiesNames.RowTemplate.Height = 24;
            this.dgvCounterpartiesNames.Size = new System.Drawing.Size(378, 135);
            this.dgvCounterpartiesNames.TabIndex = 133;
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
            this.ucfCustomerGroup.Location = new System.Drawing.Point(0, 42);
            this.ucfCustomerGroup.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucfCustomerGroup.Name = "ucfCustomerGroup";
            this.ucfCustomerGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCustomerGroup.Size = new System.Drawing.Size(700, 55);
            this.ucfCustomerGroup.TabIndex = 130;
            this.ucfCustomerGroup.Title = "گروه مشتری";
            this.ucfCustomerGroup.ValueMember = null;
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
            this.ucfCounterPartyType.Location = new System.Drawing.Point(0, 0);
            this.ucfCounterPartyType.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucfCounterPartyType.Name = "ucfCounterPartyType";
            this.ucfCounterPartyType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCounterPartyType.Size = new System.Drawing.Size(700, 42);
            this.ucfCounterPartyType.TabIndex = 129;
            this.ucfCounterPartyType.Title = "نوع مشتری";
            this.ucfCounterPartyType.ValueMember = null;
            // 
            // txtCounterpartyNames
            // 
            this.txtCounterpartyNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterpartyNames.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCounterpartyNames.Location = new System.Drawing.Point(97, 278);
            this.txtCounterpartyNames.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.txtCounterpartyNames.Name = "txtCounterpartyNames";
            this.txtCounterpartyNames.ReadOnly = true;
            this.txtCounterpartyNames.Size = new System.Drawing.Size(0, 24);
            this.txtCounterpartyNames.TabIndex = 15;
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
            this.ucNationality.Location = new System.Drawing.Point(-207, -11);
            this.ucNationality.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucNationality.Name = "ucNationality";
            this.ucNationality.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucNationality.Size = new System.Drawing.Size(0, 160);
            this.ucNationality.TabIndex = 131;
            this.ucNationality.Title = "ملیت";
            this.ucNationality.ValueMember = null;
            this.ucNationality.Visible = false;
            // 
            // utpCollat
            // 
            this.utpCollat.AutoScroll = true;
            this.utpCollat.Controls.Add(this.ucfCollateralStatus);
            this.utpCollat.Controls.Add(this.ucfCollateralType);
            this.utpCollat.Controls.Add(this.ucfCollatMajorType);
            this.utpCollat.Location = new System.Drawing.Point(2, 29);
            this.utpCollat.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.utpCollat.Name = "utpCollat";
            this.utpCollat.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.utpCollat.Size = new System.Drawing.Size(717, 334);
            this.utpCollat.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("utpCollat.StateStyles.FormatStyle.BackgroundImage")));
            this.utpCollat.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("utpCollat.StateStyles.HotFormatStyle.BackgroundImage")));
            this.utpCollat.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("utpCollat.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.utpCollat.TabStop = true;
            this.utpCollat.Text = "وثایق";
            // 
            // ucfCollateralStatus
            // 
            this.ucfCollateralStatus.BackColor = System.Drawing.Color.Transparent;
            this.ucfCollateralStatus.DataSource = null;
            this.ucfCollateralStatus.DisplayMember = null;
            this.ucfCollateralStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucfCollateralStatus.EnableShowClearSelectedItem = true;
            this.ucfCollateralStatus.EnableShowSelectedItem = true;
            this.ucfCollateralStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfCollateralStatus.IsPersian = false;
            this.ucfCollateralStatus.Location = new System.Drawing.Point(0, 98);
            this.ucfCollateralStatus.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucfCollateralStatus.Name = "ucfCollateralStatus";
            this.ucfCollateralStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCollateralStatus.Size = new System.Drawing.Size(717, 48);
            this.ucfCollateralStatus.TabIndex = 128;
            this.ucfCollateralStatus.Title = "وضعیت وثیقه";
            this.ucfCollateralStatus.ValueMember = null;
            // 
            // ucfCollateralType
            // 
            this.ucfCollateralType.BackColor = System.Drawing.Color.Transparent;
            this.ucfCollateralType.DataSource = null;
            this.ucfCollateralType.DisplayMember = null;
            this.ucfCollateralType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucfCollateralType.EnableShowClearSelectedItem = true;
            this.ucfCollateralType.EnableShowSelectedItem = true;
            this.ucfCollateralType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfCollateralType.IsPersian = false;
            this.ucfCollateralType.Location = new System.Drawing.Point(0, 51);
            this.ucfCollateralType.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucfCollateralType.Name = "ucfCollateralType";
            this.ucfCollateralType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCollateralType.Size = new System.Drawing.Size(717, 47);
            this.ucfCollateralType.TabIndex = 127;
            this.ucfCollateralType.Title = "نوع وثیقه";
            this.ucfCollateralType.ValueMember = null;
            // 
            // ucfCollatMajorType
            // 
            this.ucfCollatMajorType.BackColor = System.Drawing.Color.Transparent;
            this.ucfCollatMajorType.DataSource = null;
            this.ucfCollatMajorType.DisplayMember = null;
            this.ucfCollatMajorType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucfCollatMajorType.EnableShowClearSelectedItem = true;
            this.ucfCollatMajorType.EnableShowSelectedItem = true;
            this.ucfCollatMajorType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfCollatMajorType.IsPersian = false;
            this.ucfCollatMajorType.Location = new System.Drawing.Point(0, 0);
            this.ucfCollatMajorType.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucfCollatMajorType.Name = "ucfCollatMajorType";
            this.ucfCollatMajorType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCollatMajorType.Size = new System.Drawing.Size(717, 51);
            this.ucfCollatMajorType.TabIndex = 126;
            this.ucfCollatMajorType.Title = "نوع اصلی وثیقه";
            this.ucfCollatMajorType.ValueMember = null;
            // 
            // uiTabRealCust
            // 
            this.uiTabRealCust.AutoScroll = true;
            this.uiTabRealCust.Controls.Add(this.ucMaritalStatus);
            this.uiTabRealCust.Controls.Add(this.ucSokunat);
            this.uiTabRealCust.Controls.Add(this.ucEducation);
            this.uiTabRealCust.Controls.Add(this.ucSex);
            this.uiTabRealCust.Location = new System.Drawing.Point(2, 29);
            this.uiTabRealCust.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.uiTabRealCust.Name = "uiTabRealCust";
            this.uiTabRealCust.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabRealCust.Size = new System.Drawing.Size(717, 334);
            this.uiTabRealCust.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabRealCust.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabRealCust.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabRealCust.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabRealCust.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabRealCust.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabRealCust.TabStop = true;
            this.uiTabRealCust.Text = "مشتری حقیقی";
            // 
            // ucMaritalStatus
            // 
            this.ucMaritalStatus.BackColor = System.Drawing.Color.Transparent;
            this.ucMaritalStatus.DataSource = null;
            this.ucMaritalStatus.DisplayMember = null;
            this.ucMaritalStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucMaritalStatus.EnableShowClearSelectedItem = true;
            this.ucMaritalStatus.EnableShowSelectedItem = true;
            this.ucMaritalStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMaritalStatus.IsPersian = true;
            this.ucMaritalStatus.Location = new System.Drawing.Point(0, 152);
            this.ucMaritalStatus.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucMaritalStatus.Name = "ucMaritalStatus";
            this.ucMaritalStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucMaritalStatus.Size = new System.Drawing.Size(717, 52);
            this.ucMaritalStatus.TabIndex = 135;
            this.ucMaritalStatus.Title = "وضعیت تاهل";
            this.ucMaritalStatus.ValueMember = null;
            this.ucMaritalStatus.Visible = false;
            // 
            // ucSokunat
            // 
            this.ucSokunat.BackColor = System.Drawing.Color.Transparent;
            this.ucSokunat.DataSource = null;
            this.ucSokunat.DisplayMember = null;
            this.ucSokunat.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucSokunat.EnableShowClearSelectedItem = true;
            this.ucSokunat.EnableShowSelectedItem = true;
            this.ucSokunat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSokunat.IsPersian = true;
            this.ucSokunat.Location = new System.Drawing.Point(0, 94);
            this.ucSokunat.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucSokunat.Name = "ucSokunat";
            this.ucSokunat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucSokunat.Size = new System.Drawing.Size(717, 58);
            this.ucSokunat.TabIndex = 133;
            this.ucSokunat.Title = "وضعیت سکونت";
            this.ucSokunat.ValueMember = null;
            this.ucSokunat.Visible = false;
            // 
            // ucEducation
            // 
            this.ucEducation.BackColor = System.Drawing.Color.Transparent;
            this.ucEducation.DataSource = null;
            this.ucEducation.DisplayMember = null;
            this.ucEducation.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucEducation.EnableShowClearSelectedItem = true;
            this.ucEducation.EnableShowSelectedItem = true;
            this.ucEducation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEducation.IsPersian = true;
            this.ucEducation.Location = new System.Drawing.Point(0, 48);
            this.ucEducation.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucEducation.Name = "ucEducation";
            this.ucEducation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucEducation.Size = new System.Drawing.Size(717, 46);
            this.ucEducation.TabIndex = 131;
            this.ucEducation.Title = "سطح تحصیلات";
            this.ucEducation.ValueMember = null;
            this.ucEducation.Visible = false;
            // 
            // ucSex
            // 
            this.ucSex.BackColor = System.Drawing.Color.Transparent;
            this.ucSex.DataSource = null;
            this.ucSex.DisplayMember = null;
            this.ucSex.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucSex.EnableShowClearSelectedItem = true;
            this.ucSex.EnableShowSelectedItem = true;
            this.ucSex.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSex.IsPersian = true;
            this.ucSex.Location = new System.Drawing.Point(0, 0);
            this.ucSex.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucSex.Name = "ucSex";
            this.ucSex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucSex.Size = new System.Drawing.Size(717, 48);
            this.ucSex.TabIndex = 130;
            this.ucSex.Title = "جنسیت";
            this.ucSex.ValueMember = null;
            this.ucSex.Visible = false;
            // 
            // uiTabPage5
            // 
            this.uiTabPage5.AutoScroll = true;
            this.uiTabPage5.Controls.Add(this.ucJobType);
            this.uiTabPage5.Controls.Add(this.ucEconomicPart);
            this.uiTabPage5.Controls.Add(this.ucCompanyType);
            this.uiTabPage5.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage5.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.uiTabPage5.Name = "uiTabPage5";
            this.uiTabPage5.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage5.Size = new System.Drawing.Size(717, 339);
            this.uiTabPage5.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage5.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage5.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage5.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage5.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage5.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage5.TabStop = true;
            this.uiTabPage5.Text = "مشتری حقوقی";
            // 
            // ucJobType
            // 
            this.ucJobType.BackColor = System.Drawing.Color.Transparent;
            this.ucJobType.DataSource = null;
            this.ucJobType.DisplayMember = null;
            this.ucJobType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucJobType.EnableShowClearSelectedItem = true;
            this.ucJobType.EnableShowSelectedItem = true;
            this.ucJobType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucJobType.IsPersian = true;
            this.ucJobType.Location = new System.Drawing.Point(0, 94);
            this.ucJobType.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucJobType.Name = "ucJobType";
            this.ucJobType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucJobType.Size = new System.Drawing.Size(717, 48);
            this.ucJobType.TabIndex = 131;
            this.ucJobType.Title = "زمینه شغلی";
            this.ucJobType.ValueMember = null;
            this.ucJobType.Visible = false;
            // 
            // ucEconomicPart
            // 
            this.ucEconomicPart.BackColor = System.Drawing.Color.Transparent;
            this.ucEconomicPart.DataSource = null;
            this.ucEconomicPart.DisplayMember = null;
            this.ucEconomicPart.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucEconomicPart.EnableShowClearSelectedItem = true;
            this.ucEconomicPart.EnableShowSelectedItem = true;
            this.ucEconomicPart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEconomicPart.IsPersian = true;
            this.ucEconomicPart.Location = new System.Drawing.Point(0, 47);
            this.ucEconomicPart.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucEconomicPart.Name = "ucEconomicPart";
            this.ucEconomicPart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucEconomicPart.Size = new System.Drawing.Size(717, 47);
            this.ucEconomicPart.TabIndex = 134;
            this.ucEconomicPart.Title = "بخش اقتصادی";
            this.ucEconomicPart.ValueMember = null;
            this.ucEconomicPart.Visible = false;
            // 
            // ucCompanyType
            // 
            this.ucCompanyType.BackColor = System.Drawing.Color.Transparent;
            this.ucCompanyType.DataSource = null;
            this.ucCompanyType.DisplayMember = null;
            this.ucCompanyType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucCompanyType.EnableShowClearSelectedItem = true;
            this.ucCompanyType.EnableShowSelectedItem = true;
            this.ucCompanyType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCompanyType.IsPersian = true;
            this.ucCompanyType.Location = new System.Drawing.Point(0, 0);
            this.ucCompanyType.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ucCompanyType.Name = "ucCompanyType";
            this.ucCompanyType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucCompanyType.Size = new System.Drawing.Size(717, 47);
            this.ucCompanyType.TabIndex = 133;
            this.ucCompanyType.Title = "نوع شرکت";
            this.ucCompanyType.ValueMember = null;
            this.ucCompanyType.Visible = false;
            // 
            // uiTabPage6
            // 
            this.uiTabPage6.Controls.Add(this.groupBox1);
            this.uiTabPage6.Controls.Add(this.panel2);
            this.uiTabPage6.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage6.Name = "uiTabPage6";
            this.uiTabPage6.Size = new System.Drawing.Size(717, 339);
            this.uiTabPage6.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage6.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage6.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage6.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage6.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage6.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage6.TabStop = true;
            this.uiTabPage6.Text = "تنظیمات پرس و جو";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(7, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 156);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنظیمات مربوط به انواع تسهیلات";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(530, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 24);
            this.radioButton1.TabIndex = 151;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "همه تسهیلات";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(179, 27);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(105, 24);
            this.radioButton3.TabIndex = 153;
            this.radioButton3.Text = "تسهیلات ABIS";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(363, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(118, 24);
            this.radioButton2.TabIndex = 152;
            this.radioButton2.Text = "تسهیلات بانک ایران";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chAbis);
            this.panel2.Controls.Add(this.chbOrderBy);
            this.panel2.Controls.Add(this.cmbOrderBy);
            this.panel2.Controls.Add(this.rdbDesc);
            this.panel2.Controls.Add(this.rdbAsc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 52);
            this.panel2.TabIndex = 150;
            // 
            // chAbis
            // 
            this.chAbis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chAbis.AutoSize = true;
            this.chAbis.Location = new System.Drawing.Point(3, 14);
            this.chAbis.Name = "chAbis";
            this.chAbis.Size = new System.Drawing.Size(96, 24);
            this.chAbis.TabIndex = 145;
            this.chAbis.Text = "گزارش ABIS";
            this.chAbis.UseVisualStyleBackColor = true;
            this.chAbis.Visible = false;
            // 
            // chbOrderBy
            // 
            this.chbOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbOrderBy.AutoSize = true;
            this.chbOrderBy.Location = new System.Drawing.Point(579, 15);
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
            this.cmbOrderBy.AutoSize = false;
            this.cmbOrderBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.cmbOrderBy.Enabled = false;
            this.cmbOrderBy.Location = new System.Drawing.Point(355, 15);
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
            this.rdbDesc.Location = new System.Drawing.Point(220, 14);
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
            this.rdbAsc.Location = new System.Drawing.Point(275, 14);
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
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
            this.splitContainer1.Size = new System.Drawing.Size(727, 334);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 141;
            // 
            // ucSelectColumn
            // 
            this.ucSelectColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.ucSelectColumn.DataSource = null;
            this.ucSelectColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSelectColumn.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ucSelectColumn.Location = new System.Drawing.Point(0, 0);
            this.ucSelectColumn.Margin = new System.Windows.Forms.Padding(3, 228, 3, 228);
            this.ucSelectColumn.Name = "ucSelectColumn";
            this.ucSelectColumn.NameOfDisplay = null;
            this.ucSelectColumn.NameOfValue = null;
            this.ucSelectColumn.Size = new System.Drawing.Size(727, 253);
            this.ucSelectColumn.TabIndex = 140;
            this.ucSelectColumn.Title = null;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(320, 0);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.btnNewReport);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer5.Size = new System.Drawing.Size(407, 76);
            this.splitContainer5.SplitterDistance = 137;
            this.splitContainer5.TabIndex = 140;
            // 
            // btnNewReport
            // 
            this.btnNewReport.AutoSize = true;
            this.btnNewReport.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnNewReport.DefaultImage")));
            this.btnNewReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewReport.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnNewReport.HoverImage")));
            this.btnNewReport.Location = new System.Drawing.Point(0, 0);
            this.btnNewReport.Margin = new System.Windows.Forms.Padding(3, 174, 3, 174);
            this.btnNewReport.Name = "btnNewReport";
            this.btnNewReport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewReport.Size = new System.Drawing.Size(137, 76);
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
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btnSave);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnShowNormalReport);
            this.splitContainer4.Size = new System.Drawing.Size(266, 76);
            this.splitContainer4.SplitterDistance = 131;
            this.splitContainer4.TabIndex = 140;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnSave.DefaultImage")));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnSave.HoverImage")));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 174, 3, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Size = new System.Drawing.Size(131, 76);
            this.btnSave.TabIndex = 132;
            this.btnSave.Title = null;
            this.btnSave.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnSave_Click);
            // 
            // btnShowNormalReport
            // 
            this.btnShowNormalReport.AutoSize = true;
            this.btnShowNormalReport.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnShowNormalReport.DefaultImage")));
            this.btnShowNormalReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowNormalReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowNormalReport.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowNormalReport.HoverImage")));
            this.btnShowNormalReport.Location = new System.Drawing.Point(0, 0);
            this.btnShowNormalReport.Margin = new System.Windows.Forms.Padding(3, 174, 3, 174);
            this.btnShowNormalReport.Name = "btnShowNormalReport";
            this.btnShowNormalReport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowNormalReport.Size = new System.Drawing.Size(131, 76);
            this.btnShowNormalReport.TabIndex = 131;
            this.btnShowNormalReport.Title = null;
            this.btnShowNormalReport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnShowNormalReport_Click);
            this.btnShowNormalReport.Load += new System.EventHandler(this.btnShowNormalReport_Load);
            // 
            // ugbReports
            // 
            this.ugbReports.Controls.Add(this.trnReport);
            this.ugbReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ugbReports.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ugbReports.Location = new System.Drawing.Point(0, 0);
            this.ugbReports.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.ugbReports.Name = "ugbReports";
            this.ugbReports.Size = new System.Drawing.Size(183, 742);
            this.ugbReports.TabIndex = 136;
            this.ugbReports.Text = "گزارشات موجود";
            // 
            // trnReport
            // 
            this.trnReport.ContextMenuStrip = this.cmsReport;
            this.trnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trnReport.FullRowSelect = true;
            this.trnReport.Location = new System.Drawing.Point(3, 30);
            this.trnReport.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.trnReport.Name = "trnReport";
            this.trnReport.ShowLines = false;
            this.trnReport.ShowRootLines = false;
            this.trnReport.Size = new System.Drawing.Size(177, 709);
            this.trnReport.TabIndex = 134;
            this.trnReport.Click += new System.EventHandler(this.trnReport_Click);
            // 
            // frmLoanReportCs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(914, 742);
            this.Controls.Add(this.splitContainer3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoanReportCs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "گزارش تسهیلات";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateOverdue3Coef)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterparty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterPartyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCouterpartName)).EndInit();
            this.cgbCouterpartName.ResumeLayout(false);
            this.cgbCouterpartName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNameSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNames)).EndInit();
            this.utpCollat.ResumeLayout(false);
            this.uiTabRealCust.ResumeLayout(false);
            this.uiTabPage5.ResumeLayout(false);
            this.uiTabPage6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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

        private System.Windows.Forms.TreeView trnReport;
        private System.Windows.Forms.GroupBox ugbReports;
        private System.Windows.Forms.ContextMenuStrip cmsReport;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveReport;
        private System.Windows.Forms.ToolStripMenuItem btnChart;
        private System.Windows.Forms.ToolStripMenuItem btnShowReport_2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox ugbSFiltering;
        private Janus.Windows.UI.Tab.UITab tabMain;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private System.Windows.Forms.GroupBox cGroupBox1;
        private FarsiLibrary.Win.Controls.FADatePicker fdpHistoricDate;
        private System.Windows.Forms.RadioButton rdbDate_Historic;
        private System.Windows.Forms.RadioButton rdbDate_Today;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private UCFiltering ucfContractType;
        private UCFiltering ucEconomicSector;
        private UCFiltering ucFilteringContractTypeCode;
        private System.Windows.Forms.CheckBox chbStartDate;
        private System.Windows.Forms.Panel pnlStartDate;
        private System.Windows.Forms.Label label10;
        private FarsiLibrary.Win.Controls.FADatePicker fdpToStartDate;
        private System.Windows.Forms.Label label11;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFromStartDate;
        private System.Windows.Forms.CheckBox chbMaturityDate;
        private System.Windows.Forms.Panel pnlMaturityDate;
        private System.Windows.Forms.Label label8;
        private FarsiLibrary.Win.Controls.FADatePicker fdpToMaturityDate;
        private System.Windows.Forms.Label label9;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFromMaturityDate;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage4;
        private System.Windows.Forms.CheckBox chbCustCodeName;
        private System.Windows.Forms.GroupBox cgbCustCodeName;
        private System.Windows.Forms.RadioButton chbCounterparty1;
        private System.Windows.Forms.TextBox txtCounterparty;
        private System.Windows.Forms.TextBox txtCounterPartyName;
        private System.Windows.Forms.GroupBox cgbCouterpartName;
        private System.Windows.Forms.TextBox txtCounterpartyNameSearch;
        private System.Windows.Forms.RadioButton rdbContains;
        private System.Windows.Forms.RadioButton rdbStartsWith;
        private System.Windows.Forms.RadioButton rdbEndsWith;
        private System.Windows.Forms.RadioButton chbCounterpartyName1;
        private System.Windows.Forms.DataGridView dgvCounterpartiesNames;
        private System.Windows.Forms.TextBox txtCounterpartyNames;
        private UCFiltering ucNationality;
        private UCFiltering ucfCounterPartyType;
        private UCFiltering ucfCustomerGroup;
        private Janus.Windows.UI.Tab.UITabPage utpCollat;
        private UCFiltering ucfCollateralStatus;
        private UCFiltering ucfCollateralType;
        private UCFiltering ucfCollatMajorType;
        private Janus.Windows.UI.Tab.UITabPage uiTabRealCust;
        private UCFiltering ucMaritalStatus;
        private UCFiltering ucSokunat;
        private UCFiltering ucEducation;
        private UCFiltering ucSex;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage5;
        private UCFiltering ucEconomicPart;
        private UCFiltering ucCompanyType;
        private UCFiltering ucJobType;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private SelectColumn ucSelectColumn;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private Utilize.Company.CButton btnNewReport;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private Utilize.Company.CButton btnSave;
        private Utilize.Company.CButton btnShowNormalReport;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private System.Windows.Forms.GroupBox cGroupBox2;
        private UCFiltering ucfState;
        private UCFiltering ucfOrganization;
        private UCFiltering ucContractStatus;
        private UCFiltering ucfCity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdateOverdue3Coef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton chbDepNo;
        private System.Windows.Forms.TextBox txtDepNoName;
        private System.Windows.Forms.TextBox txtDepNo;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chbOrderBy;
        private System.Windows.Forms.ComboBox cmbOrderBy;
        private System.Windows.Forms.RadioButton rdbDesc;
        private System.Windows.Forms.RadioButton rdbAsc;
        private Utilize.Company.CButton cbCloseAll;
        private System.Windows.Forms.CheckBox chAbis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}