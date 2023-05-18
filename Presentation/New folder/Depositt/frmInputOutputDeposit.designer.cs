namespace Presentation.Deposit
{
    partial class frmInputOutputDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInputOutputDeposit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Dundas.Charting.WinControl.ChartArea chartArea1 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend1 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Legend legend2 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Series series1 = new Dundas.Charting.WinControl.Series();
            this.btnShowReport = new Utilize.Company.CButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cGroupBox1 = new Utilize.Company.CGroupBox();
            this.grbLocation = new Utilize.Company.CGroupBox();
            this.cmbBranch = new Utilize.Report.UCFiltering();
            this.cmbCity = new Utilize.Report.UCFiltering();
            this.cmbStates = new Utilize.Report.UCFiltering();
            this.fdpFrom = new FarsiLibrary.Win.Controls.FADatePicker();
            this.fdpTo = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMain = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.dgvResoult = new Utilize.Grid.MyGrid_V2();
            this.dgvDMReport = new System.Windows.Forms.DataGridView();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.dgvResoult1 = new Utilize.Grid.MyGrid_V2();
            this.uiTabPage4 = new Janus.Windows.UI.Tab.UITabPage();
            this.dgvResoult2 = new Utilize.Grid.MyGrid_V2();
            this.chart = new Dundas.Charting.WinControl.Chart();
            this.rb_Count = new System.Windows.Forms.RadioButton();
            this.rb_Price = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbShowSequntial = new System.Windows.Forms.RadioButton();
            this.rdbShowPartial = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chbSerries = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGroupBox1)).BeginInit();
            this.cGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbLocation)).BeginInit();
            this.grbLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMReport)).BeginInit();
            this.uiTabPage3.SuspendLayout();
            this.uiTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowReport
            // 
            this.btnShowReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowReport.AutoSize = true;
            this.btnShowReport.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnShowReport.DefaultImage")));
            this.btnShowReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowReport.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShowReport.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowReport.HoverImage")));
            this.btnShowReport.Location = new System.Drawing.Point(159, 25);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowReport.Size = new System.Drawing.Size(136, 29);
            this.btnShowReport.TabIndex = 6;
            this.btnShowReport.Title = null;
            this.btnShowReport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnShowRpt_Click);
            this.btnShowReport.Load += new System.EventHandler(this.btnShowReport_Load);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cGroupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
            this.splitContainer1.Size = new System.Drawing.Size(837, 601);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 145;
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cGroupBox1.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cGroupBox1.Controls.Add(this.grbLocation);
            this.cGroupBox1.Controls.Add(this.fdpFrom);
            this.cGroupBox1.Controls.Add(this.fdpTo);
            this.cGroupBox1.Controls.Add(this.label2);
            this.cGroupBox1.Controls.Add(this.label1);
            this.cGroupBox1.Controls.Add(this.btnShowReport);
            this.cGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cGroupBox1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cGroupBox1.Size = new System.Drawing.Size(837, 219);
            this.cGroupBox1.TabIndex = 52;
            this.cGroupBox1.Text = "تنظیمات گزارش گیری";
            // 
            // grbLocation
            // 
            this.grbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.grbLocation.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.grbLocation.Controls.Add(this.cmbBranch);
            this.grbLocation.Controls.Add(this.cmbCity);
            this.grbLocation.Controls.Add(this.cmbStates);
            this.grbLocation.Location = new System.Drawing.Point(297, 61);
            this.grbLocation.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.grbLocation.Name = "grbLocation";
            this.grbLocation.Size = new System.Drawing.Size(513, 148);
            this.grbLocation.TabIndex = 143;
            this.grbLocation.Text = "اطلاعات شعب";
            // 
            // cmbBranch
            // 
            this.cmbBranch.BackColor = System.Drawing.Color.Transparent;
            this.cmbBranch.DataSource = null;
            this.cmbBranch.DisplayMember = null;
            this.cmbBranch.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbBranch.EnableShowClearSelectedItem = true;
            this.cmbBranch.EnableShowSelectedItem = true;
            this.cmbBranch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBranch.IsPersian = false;
            this.cmbBranch.Location = new System.Drawing.Point(3, 107);
            this.cmbBranch.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBranch.Size = new System.Drawing.Size(507, 55);
            this.cmbBranch.TabIndex = 126;
            this.cmbBranch.Title = "شعبه";
            this.cmbBranch.ValueMember = null;
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.Transparent;
            this.cmbCity.DataSource = null;
            this.cmbCity.DisplayMember = null;
            this.cmbCity.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbCity.EnableShowClearSelectedItem = true;
            this.cmbCity.EnableShowSelectedItem = true;
            this.cmbCity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.IsPersian = false;
            this.cmbCity.Location = new System.Drawing.Point(3, 65);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCity.Size = new System.Drawing.Size(507, 42);
            this.cmbCity.TabIndex = 128;
            this.cmbCity.Title = "شهر";
            this.cmbCity.ValueMember = null;
            // 
            // cmbStates
            // 
            this.cmbStates.BackColor = System.Drawing.Color.Transparent;
            this.cmbStates.DataSource = null;
            this.cmbStates.DisplayMember = null;
            this.cmbStates.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbStates.EnableShowClearSelectedItem = true;
            this.cmbStates.EnableShowSelectedItem = true;
            this.cmbStates.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStates.IsPersian = false;
            this.cmbStates.Location = new System.Drawing.Point(3, 24);
            this.cmbStates.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.cmbStates.Name = "cmbStates";
            this.cmbStates.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbStates.Size = new System.Drawing.Size(507, 41);
            this.cmbStates.TabIndex = 125;
            this.cmbStates.Title = "استان";
            this.cmbStates.ValueMember = null;
            // 
            // fdpFrom
            // 
            this.fdpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFrom.Location = new System.Drawing.Point(595, 25);
            this.fdpFrom.Name = "fdpFrom";
            this.fdpFrom.Size = new System.Drawing.Size(159, 20);
            this.fdpFrom.TabIndex = 7;
            // 
            // fdpTo
            // 
            this.fdpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpTo.Location = new System.Drawing.Point(362, 25);
            this.fdpTo.Name = "fdpTo";
            this.fdpTo.Size = new System.Drawing.Size(159, 20);
            this.fdpTo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(527, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "تا تاریخ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(760, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "از تاریخ";
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.tabMain.ItemSize = new System.Drawing.Size(38, 120);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabMain.Size = new System.Drawing.Size(837, 379);
            this.tabMain.TabIndex = 144;
            this.tabMain.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage3,
            this.uiTabPage4});
            this.tabMain.TabStripFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.UseThemes = false;
            this.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.dgvResoult);
            this.uiTabPage2.Controls.Add(this.dgvDMReport);
            this.uiTabPage2.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(833, 348);
            this.uiTabPage2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "ورود و خروج";
            // 
            // dgvResoult
            // 
            this.dgvResoult.BackColor = System.Drawing.Color.Transparent;
            this.dgvResoult.DataSource = null;
            this.dgvResoult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResoult.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvResoult.Location = new System.Drawing.Point(0, 0);
            this.dgvResoult.Name = "dgvResoult";
            this.dgvResoult.ShowMenu = true;
            this.dgvResoult.Size = new System.Drawing.Size(833, 348);
            this.dgvResoult.TabIndex = 141;
            // 
            // dgvDMReport
            // 
            this.dgvDMReport.AllowUserToAddRows = false;
            this.dgvDMReport.AllowUserToDeleteRows = false;
            this.dgvDMReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDMReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDMReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMReport.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDMReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDMReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDMReport.Location = new System.Drawing.Point(0, 0);
            this.dgvDMReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDMReport.Name = "dgvDMReport";
            this.dgvDMReport.ReadOnly = true;
            this.dgvDMReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDMReport.RowHeadersVisible = false;
            this.dgvDMReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDMReport.Size = new System.Drawing.Size(833, 348);
            this.dgvDMReport.TabIndex = 49;
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.Controls.Add(this.dgvResoult1);
            this.uiTabPage3.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(833, 348);
            this.uiTabPage3.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "ورود منابع";
            // 
            // dgvResoult1
            // 
            this.dgvResoult1.BackColor = System.Drawing.Color.Transparent;
            this.dgvResoult1.DataSource = null;
            this.dgvResoult1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResoult1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvResoult1.Location = new System.Drawing.Point(0, 0);
            this.dgvResoult1.Name = "dgvResoult1";
            this.dgvResoult1.ShowMenu = true;
            this.dgvResoult1.Size = new System.Drawing.Size(833, 348);
            this.dgvResoult1.TabIndex = 141;
            // 
            // uiTabPage4
            // 
            this.uiTabPage4.Controls.Add(this.dgvResoult2);
            this.uiTabPage4.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage4.Name = "uiTabPage4";
            this.uiTabPage4.Size = new System.Drawing.Size(833, 348);
            this.uiTabPage4.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage4.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage4.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage4.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage4.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage4.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage4.TabStop = true;
            this.uiTabPage4.Text = "خروج منابع";
            // 
            // dgvResoult2
            // 
            this.dgvResoult2.BackColor = System.Drawing.Color.Transparent;
            this.dgvResoult2.DataSource = null;
            this.dgvResoult2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResoult2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvResoult2.Location = new System.Drawing.Point(0, 0);
            this.dgvResoult2.Name = "dgvResoult2";
            this.dgvResoult2.ShowMenu = true;
            this.dgvResoult2.Size = new System.Drawing.Size(833, 348);
            this.dgvResoult2.TabIndex = 141;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(186)))), ((int)(((byte)(145)))));
            this.chart.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.chart.BackGradientType = Dundas.Charting.WinControl.GradientType.TopBottom;
            this.chart.BorderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(147)))));
            this.chart.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            this.chart.BorderSkin.FrameBackColor = System.Drawing.Color.SteelBlue;
            this.chart.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue;
            this.chart.BorderSkin.FrameBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart.BorderSkin.FrameBorderWidth = 2;
            this.chart.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke;
            this.chart.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Light = Dundas.Charting.WinControl.LightStyle.Realistic;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelsAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.Size = 10D;
            chartArea1.AxisY.LabelsAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.Format = "##,###.##";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 5;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            chartArea1.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            chartArea1.BorderColor = System.Drawing.Color.LightSlateGray;
            chartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            chartArea1.CursorX.UserEnabled = true;
            chartArea1.CursorX.UserSelection = true;
            chartArea1.Name = "Chart Area 1";
            chartArea1.ShadowOffset = 1;
            this.chart.ChartAreas.Add(chartArea1);
            legend1.AutoFitText = false;
            legend1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.Name = "Default";
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            legend2.BorderColor = System.Drawing.Color.LightSlateGray;
            legend2.Name = "Legend1";
            legend2.ShadowOffset = 1;
            this.chart.Legends.Add(legend1);
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(9, 34);
            this.chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart.Name = "chart";
            this.chart.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas;
            series1.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            series1.BackGradientType = Dundas.Charting.WinControl.GradientType.TopBottom;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Name = "Series1";
            series1.SmartLabels.Enabled = true;
            series1.ToolTip = "#AXISLABEL #VAL";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(548, 256);
            this.chart.TabIndex = 140;
            this.chart.Text = "chart1";
            this.chart.UI.Toolbar.AllowMouseMoving = false;
            this.chart.UI.Toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(170)))), ((int)(((byte)(126)))));
            this.chart.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(147)))));
            this.chart.UI.Toolbar.BorderSkin.FrameBackColor = System.Drawing.Color.SteelBlue;
            this.chart.UI.Toolbar.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue;
            this.chart.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart.UI.Toolbar.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            this.chart.UI.Toolbar.Enabled = true;
            // 
            // rb_Count
            // 
            this.rb_Count.Location = new System.Drawing.Point(0, 0);
            this.rb_Count.Name = "rb_Count";
            this.rb_Count.Size = new System.Drawing.Size(104, 24);
            this.rb_Count.TabIndex = 146;
            // 
            // rb_Price
            // 
            this.rb_Price.Location = new System.Drawing.Point(0, 0);
            this.rb_Price.Name = "rb_Price";
            this.rb_Price.Size = new System.Drawing.Size(104, 24);
            this.rb_Price.TabIndex = 145;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(563, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel5);
            this.splitContainer2.Panel1.Controls.Add(this.rdbShowSequntial);
            this.splitContainer2.Panel1.Controls.Add(this.rdbShowPartial);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel3);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(167, 298);
            this.splitContainer2.SplitterDistance = 86;
            this.splitContainer2.TabIndex = 144;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.MaximumSize = new System.Drawing.Size(166, 23);
            this.panel5.MinimumSize = new System.Drawing.Size(166, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(166, 23);
            this.panel5.TabIndex = 141;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(76, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "نحوه نمایش نمودار";
            // 
            // rdbShowSequntial
            // 
            this.rdbShowSequntial.Location = new System.Drawing.Point(0, 0);
            this.rdbShowSequntial.Name = "rdbShowSequntial";
            this.rdbShowSequntial.Size = new System.Drawing.Size(104, 24);
            this.rdbShowSequntial.TabIndex = 142;
            // 
            // rdbShowPartial
            // 
            this.rdbShowPartial.Location = new System.Drawing.Point(0, 0);
            this.rdbShowPartial.Name = "rdbShowPartial";
            this.rdbShowPartial.Size = new System.Drawing.Size(104, 24);
            this.rdbShowPartial.TabIndex = 143;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chbSerries);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 215);
            this.panel3.TabIndex = 143;
            // 
            // chbSerries
            // 
            this.chbSerries.Location = new System.Drawing.Point(0, 0);
            this.chbSerries.Name = "chbSerries";
            this.chbSerries.Size = new System.Drawing.Size(120, 94);
            this.chbSerries.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.MaximumSize = new System.Drawing.Size(166, 23);
            this.panel4.MinimumSize = new System.Drawing.Size(166, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 23);
            this.panel4.TabIndex = 140;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "سال های گزارش گیری،  نام مدل";
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.splitContainer2);
            this.uiTabPage1.Controls.Add(this.rb_Price);
            this.uiTabPage1.Controls.Add(this.rb_Count);
            this.uiTabPage1.Controls.Add(this.chart);
            this.uiTabPage1.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(730, 298);
            this.uiTabPage1.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage1.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage1.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage1.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage1.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage1.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "نمودار";
            // 
            // frmInputOutputDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(837, 601);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInputOutputDeposit";
            this.Text = "گزارش تاریخی سپرده ها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cGroupBox1)).EndInit();
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbLocation)).EndInit();
            this.grbLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMReport)).EndInit();
            this.uiTabPage3.ResumeLayout(false);
            this.uiTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.uiTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Utilize.Company.CButton btnShowReport;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Utilize.Company.CGroupBox cGroupBox1;
        private Janus.Windows.UI.Tab.UITab tabMain;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private System.Windows.Forms.DataGridView dgvDMReport;
        private Dundas.Charting.WinControl.Chart chart;
        private System.Windows.Forms.RadioButton rb_Count;
        private System.Windows.Forms.RadioButton rb_Price;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbShowSequntial;
        private System.Windows.Forms.RadioButton rdbShowPartial;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox chbSerries;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFrom;
        private FarsiLibrary.Win.Controls.FADatePicker fdpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage4;
        private Utilize.Company.CGroupBox grbLocation;
        private Utilize.Report.UCFiltering cmbBranch;
        private Utilize.Report.UCFiltering cmbCity;
        private Utilize.Report.UCFiltering cmbStates;
        private Utilize.Grid.MyGrid_V2 dgvResoult;
        private Utilize.Grid.MyGrid_V2 dgvResoult1;
        private Utilize.Grid.MyGrid_V2 dgvResoult2;
    }
}