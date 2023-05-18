namespace Presentation.Loan
{
    partial class frmLoanComOverdueAndCollact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanComOverdueAndCollact));
            Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem5 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem6 = new Infragistics.Win.ValueListItem();
            this.ugbReports = new System.Windows.Forms.GroupBox();
            this.trnReport = new System.Windows.Forms.TreeView();
            this.cmsReport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRemoveReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowReport_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ugbSFiltering = new System.Windows.Forms.GroupBox();
            this.tabMain = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.pnlStartDate = new System.Windows.Forms.Panel();
            this.lblToSD = new System.Windows.Forms.Label();
            this.fdpToStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.lblFromSD = new System.Windows.Forms.Label();
            this.fdpFromStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.chbStartDate = new System.Windows.Forms.CheckBox();
            this.pnlMaturityDate = new System.Windows.Forms.Panel();
            this.lblToMD = new System.Windows.Forms.Label();
            this.fdpToMaturityDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.lblFromMD = new System.Windows.Forms.Label();
            this.fdpFromMaturityDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.chbMaturityDate = new System.Windows.Forms.CheckBox();
            this.uiTabPage4 = new Janus.Windows.UI.Tab.UITabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCompareFilter = new System.Windows.Forms.ComboBox();
            this.chbCompareFilter = new System.Windows.Forms.CheckBox();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.chbCounterparty = new System.Windows.Forms.CheckBox();
            this.ucSelectColumn = new Utilize.Report.SelectColumn();
            this.btnNewReport2 = new Utilize.Company.CButton();
            this.btnSave2 = new Utilize.Company.CButton();
            this.btnShowNormalReport = new Utilize.Company.CButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ugbReports.SuspendLayout();
            this.cmsReport.SuspendLayout();
            this.ugbSFiltering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            this.pnlStartDate.SuspendLayout();
            this.pnlMaturityDate.SuspendLayout();
            this.uiTabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ugbReports
            // 
            this.ugbReports.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ugbReports.Controls.Add(this.trnReport);
            this.ugbReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ugbReports.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ugbReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.ugbReports.Location = new System.Drawing.Point(0, 0);
            this.ugbReports.Name = "ugbReports";
            this.ugbReports.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ugbReports.Size = new System.Drawing.Size(389, 457);
            this.ugbReports.TabIndex = 137;
            this.ugbReports.TabStop = false;
            this.ugbReports.Text = "گزارشات موجود";
            // 
            // trnReport
            // 
            this.trnReport.ContextMenuStrip = this.cmsReport;
            this.trnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trnReport.FullRowSelect = true;
            this.trnReport.Location = new System.Drawing.Point(3, 28);
            this.trnReport.Name = "trnReport";
            this.trnReport.ShowLines = false;
            this.trnReport.ShowRootLines = false;
            this.trnReport.Size = new System.Drawing.Size(383, 427);
            this.trnReport.TabIndex = 134;
            this.trnReport.Click += new System.EventHandler(this.trnReport_Click);
            // 
            // cmsReport
            // 
            this.cmsReport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsReport.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRemoveReport,
            this.btnChart,
            this.btnShowReport_2});
            this.cmsReport.Name = "cmsReport";
            this.cmsReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsReport.Size = new System.Drawing.Size(162, 70);
            // 
            // btnRemoveReport
            // 
            this.btnRemoveReport.Name = "btnRemoveReport";
            this.btnRemoveReport.Size = new System.Drawing.Size(161, 22);
            this.btnRemoveReport.Text = " حذف";
            this.btnRemoveReport.Click += new System.EventHandler(this.btnRemoveReport_Click);
            // 
            // btnChart
            // 
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(161, 22);
            this.btnChart.Text = "نمودار";
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnShowReport_2
            // 
            this.btnShowReport_2.Name = "btnShowReport_2";
            this.btnShowReport_2.Size = new System.Drawing.Size(161, 22);
            this.btnShowReport_2.Text = "نمایش گزارش";
            this.btnShowReport_2.Click += new System.EventHandler(this.btnShowNormalReport_Click);
            // 
            // ugbSFiltering
            // 
            this.ugbSFiltering.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ugbSFiltering.Controls.Add(this.tabMain);
            this.ugbSFiltering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ugbSFiltering.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ugbSFiltering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.ugbSFiltering.Location = new System.Drawing.Point(0, 0);
            this.ugbSFiltering.Name = "ugbSFiltering";
            this.ugbSFiltering.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ugbSFiltering.Size = new System.Drawing.Size(760, 229);
            this.ugbSFiltering.TabIndex = 138;
            this.ugbSFiltering.TabStop = false;
            this.ugbSFiltering.Text = "تنظیمات فیلتر بندی";
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.tabMain.Location = new System.Drawing.Point(3, 28);
            this.tabMain.Name = "tabMain";
            this.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabMain.Size = new System.Drawing.Size(754, 199);
            this.tabMain.TabIndex = 134;
            this.tabMain.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage3,
            this.uiTabPage4});
            this.tabMain.UseThemes = false;
            this.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.AutoScroll = true;
            this.uiTabPage2.Location = new System.Drawing.Point(2, 36);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(750, 161);
            this.uiTabPage2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "اطلاعات شعبه";
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.AutoScroll = true;
            this.uiTabPage3.Controls.Add(this.pnlStartDate);
            this.uiTabPage3.Controls.Add(this.pnlMaturityDate);
            this.uiTabPage3.Location = new System.Drawing.Point(2, 27);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(750, 176);
            this.uiTabPage3.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "اطلاعات قرارداد";
            // 
            // pnlStartDate
            // 
            this.pnlStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.pnlStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStartDate.Controls.Add(this.lblToSD);
            this.pnlStartDate.Controls.Add(this.fdpToStartDate);
            this.pnlStartDate.Controls.Add(this.lblFromSD);
            this.pnlStartDate.Controls.Add(this.fdpFromStartDate);
            this.pnlStartDate.Controls.Add(this.chbStartDate);
            this.pnlStartDate.Location = new System.Drawing.Point(3, 88);
            this.pnlStartDate.Name = "pnlStartDate";
            this.pnlStartDate.Size = new System.Drawing.Size(727, 29);
            this.pnlStartDate.TabIndex = 115;
            // 
            // lblToSD
            // 
            this.lblToSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToSD.AutoSize = true;
            this.lblToSD.Location = new System.Drawing.Point(404, 6);
            this.lblToSD.Name = "lblToSD";
            this.lblToSD.Size = new System.Drawing.Size(21, 27);
            this.lblToSD.TabIndex = 35;
            this.lblToSD.Text = "تا";
            // 
            // fdpToStartDate
            // 
            this.fdpToStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpToStartDate.Enabled = false;
            this.fdpToStartDate.Location = new System.Drawing.Point(251, 3);
            this.fdpToStartDate.Name = "fdpToStartDate";
            this.fdpToStartDate.Size = new System.Drawing.Size(150, 20);
            this.fdpToStartDate.TabIndex = 34;
            // 
            // lblFromSD
            // 
            this.lblFromSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFromSD.AutoSize = true;
            this.lblFromSD.Location = new System.Drawing.Point(579, 5);
            this.lblFromSD.Name = "lblFromSD";
            this.lblFromSD.Size = new System.Drawing.Size(21, 27);
            this.lblFromSD.TabIndex = 33;
            this.lblFromSD.Text = "از";
            // 
            // fdpFromStartDate
            // 
            this.fdpFromStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFromStartDate.Enabled = false;
            this.fdpFromStartDate.Location = new System.Drawing.Point(423, 3);
            this.fdpFromStartDate.Name = "fdpFromStartDate";
            this.fdpFromStartDate.Size = new System.Drawing.Size(150, 20);
            this.fdpFromStartDate.TabIndex = 32;
            // 
            // chbStartDate
            // 
            this.chbStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbStartDate.AutoSize = true;
            this.chbStartDate.Location = new System.Drawing.Point(551, 5);
            this.chbStartDate.Name = "chbStartDate";
            this.chbStartDate.Size = new System.Drawing.Size(171, 31);
            this.chbStartDate.TabIndex = 113;
            this.chbStartDate.Text = "تاریخ پرداخت تسهیلات";
            this.chbStartDate.UseVisualStyleBackColor = true;
            this.chbStartDate.CheckedChanged += new System.EventHandler(this.chbStartDate_CheckedChanged);
            // 
            // pnlMaturityDate
            // 
            this.pnlMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMaturityDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.pnlMaturityDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMaturityDate.Controls.Add(this.lblToMD);
            this.pnlMaturityDate.Controls.Add(this.fdpToMaturityDate);
            this.pnlMaturityDate.Controls.Add(this.lblFromMD);
            this.pnlMaturityDate.Controls.Add(this.fdpFromMaturityDate);
            this.pnlMaturityDate.Controls.Add(this.chbMaturityDate);
            this.pnlMaturityDate.Location = new System.Drawing.Point(3, 123);
            this.pnlMaturityDate.Name = "pnlMaturityDate";
            this.pnlMaturityDate.Size = new System.Drawing.Size(727, 29);
            this.pnlMaturityDate.TabIndex = 116;
            // 
            // lblToMD
            // 
            this.lblToMD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToMD.AutoSize = true;
            this.lblToMD.Location = new System.Drawing.Point(403, 7);
            this.lblToMD.Name = "lblToMD";
            this.lblToMD.Size = new System.Drawing.Size(21, 27);
            this.lblToMD.TabIndex = 35;
            this.lblToMD.Text = "تا";
            // 
            // fdpToMaturityDate
            // 
            this.fdpToMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpToMaturityDate.Enabled = false;
            this.fdpToMaturityDate.Location = new System.Drawing.Point(250, 3);
            this.fdpToMaturityDate.Name = "fdpToMaturityDate";
            this.fdpToMaturityDate.Size = new System.Drawing.Size(150, 20);
            this.fdpToMaturityDate.TabIndex = 34;
            // 
            // lblFromMD
            // 
            this.lblFromMD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFromMD.AutoSize = true;
            this.lblFromMD.Location = new System.Drawing.Point(578, 7);
            this.lblFromMD.Name = "lblFromMD";
            this.lblFromMD.Size = new System.Drawing.Size(21, 27);
            this.lblFromMD.TabIndex = 33;
            this.lblFromMD.Text = "از";
            // 
            // fdpFromMaturityDate
            // 
            this.fdpFromMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFromMaturityDate.Enabled = false;
            this.fdpFromMaturityDate.Location = new System.Drawing.Point(422, 3);
            this.fdpFromMaturityDate.Name = "fdpFromMaturityDate";
            this.fdpFromMaturityDate.Size = new System.Drawing.Size(150, 20);
            this.fdpFromMaturityDate.TabIndex = 32;
            // 
            // chbMaturityDate
            // 
            this.chbMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbMaturityDate.AutoSize = true;
            this.chbMaturityDate.Location = new System.Drawing.Point(601, 7);
            this.chbMaturityDate.Name = "chbMaturityDate";
            this.chbMaturityDate.Size = new System.Drawing.Size(121, 31);
            this.chbMaturityDate.TabIndex = 114;
            this.chbMaturityDate.Text = "تاریخ سر رسید";
            this.chbMaturityDate.UseVisualStyleBackColor = true;
            this.chbMaturityDate.CheckedChanged += new System.EventHandler(this.chbMaturityDate_CheckedChanged);
            // 
            // uiTabPage4
            // 
            this.uiTabPage4.AutoScroll = true;
            this.uiTabPage4.Controls.Add(this.panel1);
            this.uiTabPage4.Controls.Add(this.pnlCustomer);
            this.uiTabPage4.Location = new System.Drawing.Point(2, 27);
            this.uiTabPage4.Name = "uiTabPage4";
            this.uiTabPage4.Size = new System.Drawing.Size(750, 176);
            this.uiTabPage4.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage4.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage4.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage4.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage4.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage4.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage4.TabStop = true;
            this.uiTabPage4.Text = "مشتری";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbCompareFilter);
            this.panel1.Controls.Add(this.chbCompareFilter);
            this.panel1.Location = new System.Drawing.Point(4, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 29);
            this.panel1.TabIndex = 136;
            // 
            // cmbCompareFilter
            // 
            this.cmbCompareFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompareFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(196)))), ((int)(((byte)(149)))));
            this.cmbCompareFilter.Enabled = false;
            valueListItem4.DataValue = "0";
            valueListItem4.DisplayText = "بحرانی";
            valueListItem5.DataValue = "1";
            valueListItem5.DisplayText = "خطر";
            valueListItem6.DataValue = "2";
            valueListItem6.DisplayText = "عادی";
            this.cmbCompareFilter.Items.AddRange(new object[] {
            valueListItem4,
            valueListItem5,
            valueListItem6});
            this.cmbCompareFilter.Location = new System.Drawing.Point(56, 5);
            this.cmbCompareFilter.MaxDropDownItems = 20;
            this.cmbCompareFilter.Name = "cmbCompareFilter";
            this.cmbCompareFilter.Size = new System.Drawing.Size(546, 34);
            this.cmbCompareFilter.TabIndex = 137;
            // 
            // chbCompareFilter
            // 
            this.chbCompareFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCompareFilter.AutoSize = true;
            this.chbCompareFilter.Location = new System.Drawing.Point(615, 5);
            this.chbCompareFilter.Name = "chbCompareFilter";
            this.chbCompareFilter.Size = new System.Drawing.Size(123, 31);
            this.chbCompareFilter.TabIndex = 132;
            this.chbCompareFilter.Text = "وضعیت مقایسه";
            this.chbCompareFilter.UseVisualStyleBackColor = true;
            this.chbCompareFilter.CheckedChanged += new System.EventHandler(this.chbCompareFilter_CheckedChanged);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomer.Controls.Add(this.chbCounterparty);
            this.pnlCustomer.Location = new System.Drawing.Point(3, 88);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(744, 29);
            this.pnlCustomer.TabIndex = 134;
            // 
            // chbCounterparty
            // 
            this.chbCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCounterparty.AutoSize = true;
            this.chbCounterparty.Location = new System.Drawing.Point(662, 5);
            this.chbCounterparty.Name = "chbCounterparty";
            this.chbCounterparty.Size = new System.Drawing.Size(77, 31);
            this.chbCounterparty.TabIndex = 122;
            this.chbCounterparty.Text = "مشتری";
            this.chbCounterparty.UseVisualStyleBackColor = true;
            // 
            // ucSelectColumn
            // 
            this.ucSelectColumn.BackColor = System.Drawing.Color.Gray;
            this.ucSelectColumn.DataSource = null;
            this.ucSelectColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSelectColumn.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ucSelectColumn.Location = new System.Drawing.Point(0, 0);
            this.ucSelectColumn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucSelectColumn.Name = "ucSelectColumn";
            this.ucSelectColumn.NameOfDisplay = null;
            this.ucSelectColumn.NameOfValue = null;
            this.ucSelectColumn.Size = new System.Drawing.Size(760, 178);
            this.ucSelectColumn.TabIndex = 141;
            this.ucSelectColumn.Title = null;
            // 
            // btnNewReport2
            // 
            this.btnNewReport2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewReport2.AutoSize = true;
            this.btnNewReport2.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnNewReport2.DefaultImage")));
            this.btnNewReport2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNewReport2.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnNewReport2.HoverImage")));
            this.btnNewReport2.Location = new System.Drawing.Point(344, 12);
            this.btnNewReport2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewReport2.Name = "btnNewReport2";
            this.btnNewReport2.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewReport2.Size = new System.Drawing.Size(130, 26);
            this.btnNewReport2.TabIndex = 144;
            this.btnNewReport2.Title = null;
            this.btnNewReport2.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnNewReport_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave2.AutoSize = true;
            this.btnSave2.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnSave2.DefaultImage")));
            this.btnSave2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave2.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnSave2.HoverImage")));
            this.btnSave2.Location = new System.Drawing.Point(480, 12);
            this.btnSave2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave2.Size = new System.Drawing.Size(130, 26);
            this.btnSave2.TabIndex = 143;
            this.btnSave2.Title = null;
            this.btnSave2.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnSave_Click);
            // 
            // btnShowNormalReport
            // 
            this.btnShowNormalReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowNormalReport.AutoSize = true;
            this.btnShowNormalReport.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnShowNormalReport.DefaultImage")));
            this.btnShowNormalReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowNormalReport.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowNormalReport.HoverImage")));
            this.btnShowNormalReport.Location = new System.Drawing.Point(616, 12);
            this.btnShowNormalReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowNormalReport.Name = "btnShowNormalReport";
            this.btnShowNormalReport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowNormalReport.Size = new System.Drawing.Size(130, 26);
            this.btnShowNormalReport.TabIndex = 142;
            this.btnShowNormalReport.Title = null;
            this.btnShowNormalReport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnShowNormalReport_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnShowNormalReport);
            this.splitContainer1.Panel2.Controls.Add(this.btnNewReport2);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(760, 225);
            this.splitContainer1.SplitterDistance = 178;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 145;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.splitContainer2.Size = new System.Drawing.Size(760, 457);
            this.splitContainer2.SplitterDistance = 229;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 146;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.splitContainer3.Size = new System.Drawing.Size(1153, 457);
            this.splitContainer3.SplitterDistance = 760;
            this.splitContainer3.TabIndex = 147;
            // 
            // frmLoanComOverdueAndCollact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1153, 457);
            this.Controls.Add(this.splitContainer3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLoanComOverdueAndCollact";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmLoanComOverdueAndCollact";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLoanComOverdueAndCollact_Load);
            this.ugbReports.ResumeLayout(false);
            this.cmsReport.ResumeLayout(false);
            this.ugbSFiltering.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.uiTabPage3.ResumeLayout(false);
            this.pnlStartDate.ResumeLayout(false);
            this.pnlStartDate.PerformLayout();
            this.pnlMaturityDate.ResumeLayout(false);
            this.pnlMaturityDate.PerformLayout();
            this.uiTabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ugbReports;
        private System.Windows.Forms.TreeView trnReport;
        private System.Windows.Forms.GroupBox ugbSFiltering;
        private Janus.Windows.UI.Tab.UITab tabMain;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Utilize.Report.UCFiltering ucfOrganization;
        private Utilize.Report.UCFiltering ucfState;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private Utilize.Report.UCFiltering ucfContractType;
        private Utilize.Report.UCFiltering ucEconomicSector;
        private Utilize.Report.UCFiltering ucFilteringContractTypeCode;
        private Utilize.Report.UCFiltering ucContractStatus;
        private System.Windows.Forms.CheckBox chbStartDate;
        private System.Windows.Forms.Panel pnlStartDate;
        private System.Windows.Forms.Label lblToSD;
        private FarsiLibrary.Win.Controls.FADatePicker fdpToStartDate;
        private System.Windows.Forms.Label lblFromSD;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFromStartDate;
        private System.Windows.Forms.CheckBox chbMaturityDate;
        private System.Windows.Forms.Panel pnlMaturityDate;
        private System.Windows.Forms.Label lblToMD;
        private FarsiLibrary.Win.Controls.FADatePicker fdpToMaturityDate;
        private System.Windows.Forms.Label lblFromMD;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFromMaturityDate;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage4;
        private Utilize.Report.UCFiltering ucfCounterPartyType;
        private Utilize.Report.UCFiltering ucfCustomerGroup;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterparty;
        private System.Windows.Forms.CheckBox chbCounterparty;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterPartyName;
        private Utilize.Report.SelectColumn ucSelectColumn;
        private Utilize.Company.CButton btnNewReport2;
        private Utilize.Company.CButton btnSave2;
        private System.Windows.Forms.ContextMenuStrip cmsReport;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveReport;
        private System.Windows.Forms.ToolStripMenuItem btnChart;
        private System.Windows.Forms.ToolStripMenuItem btnShowReport_2;
        private System.Windows.Forms.CheckBox chbCompareFilter;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Panel panel1;
        private Utilize.Company.CButton btnShowNormalReport;
        private System.Windows.Forms.ComboBox cmbCompareFilter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Utilize.Report.UCFiltering ucfCity;
    }
}