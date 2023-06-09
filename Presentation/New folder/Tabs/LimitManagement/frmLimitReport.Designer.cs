namespace Presentation.Tabs.LimitManagement
{
    partial class frmLimitReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLimitReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Dundas.Charting.WinControl.ChartArea chartArea1 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend1 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Legend legend2 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Series series1 = new Dundas.Charting.WinControl.Series();
            this.spcAll = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tsModel = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModelRefresh = new System.Windows.Forms.ToolStripButton();
            this.lsvModel = new System.Windows.Forms.ListView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnModel = new Utilize.Company.CButton();
            this.tcInfo = new Janus.Windows.UI.Tab.UITab();
            this.tpDetail2 = new Janus.Windows.UI.Tab.UITabPage();
            this.dgvLimit = new System.Windows.Forms.DataGridView();
            this.tpChart2 = new Janus.Windows.UI.Tab.UITabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.chbFilterChartValues = new System.Windows.Forms.CheckBox();
            this.cgbFiltering = new Utilize.Company.CGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.rdbMore = new System.Windows.Forms.RadioButton();
            this.rdbLess = new System.Windows.Forms.RadioButton();
            this.cmbFilterValues = new Utilize.Company.CComboCox();
            this.cmbFilterLimits = new Utilize.Company.CComboCox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new Utilize.Company.CButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cGroupBox1 = new Utilize.Company.CGroupBox();
            this.chkLegend = new System.Windows.Forms.CheckBox();
            this.chkShowHideValue = new System.Windows.Forms.CheckBox();
            this.ddChart = new Dundas.Charting.WinControl.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).BeginInit();
            this.spcAll.Panel1.SuspendLayout();
            this.spcAll.Panel2.SuspendLayout();
            this.spcAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tsModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcInfo)).BeginInit();
            this.tcInfo.SuspendLayout();
            this.tpDetail2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLimit)).BeginInit();
            this.tpChart2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgbFiltering)).BeginInit();
            this.cgbFiltering.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilterValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilterLimits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGroupBox1)).BeginInit();
            this.cGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddChart)).BeginInit();
            this.SuspendLayout();
            // 
            // spcAll
            // 
            this.spcAll.BackColor = System.Drawing.Color.Transparent;
            this.spcAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcAll.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcAll.Location = new System.Drawing.Point(0, 0);
            this.spcAll.Name = "spcAll";
            // 
            // spcAll.Panel1
            // 
            this.spcAll.Panel1.Controls.Add(this.splitContainer1);
            this.spcAll.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // spcAll.Panel2
            // 
            this.spcAll.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.spcAll.Panel2.Controls.Add(this.splitContainer2);
            this.spcAll.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spcAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spcAll.Size = new System.Drawing.Size(790, 479);
            this.spcAll.SplitterDistance = 174;
            this.spcAll.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.tsModel);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lsvModel);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(174, 479);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 8;
            // 
            // tsModel
            // 
            this.tsModel.BackColor = System.Drawing.Color.Transparent;
            this.tsModel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsModel.BackgroundImage")));
            this.tsModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsModel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsModel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsModel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripSeparator5,
            this.tsbModelRefresh});
            this.tsModel.Location = new System.Drawing.Point(0, 0);
            this.tsModel.Name = "tsModel";
            this.tsModel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsModel.Size = new System.Drawing.Size(174, 25);
            this.tsModel.TabIndex = 7;
            this.tsModel.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel3.Text = "مدلها";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbModelRefresh
            // 
            this.tsbModelRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelRefresh.Image = global::Presentation.Properties.Resources.S_Refresh;
            this.tsbModelRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModelRefresh.Name = "tsbModelRefresh";
            this.tsbModelRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbModelRefresh.Text = "Save";
            this.tsbModelRefresh.ToolTipText = "تازه سازی";
            this.tsbModelRefresh.Click += new System.EventHandler(this.tsbModelRefresh_Click);
            // 
            // lsvModel
            // 
            this.lsvModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.lsvModel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lsvModel.BackgroundImage")));
            this.lsvModel.BackgroundImageTiled = true;
            this.lsvModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvModel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lsvModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.lsvModel.Location = new System.Drawing.Point(0, 0);
            this.lsvModel.MultiSelect = false;
            this.lsvModel.Name = "lsvModel";
            this.lsvModel.Size = new System.Drawing.Size(174, 447);
            this.lsvModel.TabIndex = 6;
            this.lsvModel.UseCompatibleStateImageBehavior = false;
            this.lsvModel.SelectedIndexChanged += new System.EventHandler(this.lsvModel_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnModel);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Panel1MinSize = 29;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tcInfo);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(612, 479);
            this.splitContainer2.SplitterDistance = 29;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 47;
            // 
            // btnModel
            // 
            this.btnModel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnModel.DefaultImage")));
            this.btnModel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnModel.HoverImage")));
            this.btnModel.Location = new System.Drawing.Point(583, 0);
            this.btnModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModel.Name = "btnModel";
            this.btnModel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModel.Size = new System.Drawing.Size(29, 29);
            this.btnModel.TabIndex = 46;
            this.btnModel.Title = null;
            this.btnModel.Visible = false;
            this.btnModel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnModel_CButtonClicked);
            // 
            // tcInfo
            // 
            this.tcInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            this.tcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcInfo.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            this.tcInfo.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tcInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.tcInfo.ItemSize = new System.Drawing.Size(90, 30);
            this.tcInfo.Location = new System.Drawing.Point(0, 0);
            this.tcInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tcInfo.Name = "tcInfo";
            this.tcInfo.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.tcInfo.PageBorder = Janus.Windows.UI.Tab.PageBorder.None;
            this.tcInfo.Size = new System.Drawing.Size(612, 447);
            this.tcInfo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcInfo.TabDisplay = Janus.Windows.UI.Tab.TabDisplay.Text;
            this.tcInfo.TabIndex = 45;
            this.tcInfo.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.tpDetail2,
            this.tpChart2});
            this.tcInfo.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.Transparent;
            this.tcInfo.TabsStateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tcInfo.TabsStateStyles.FormatStyle.BackgroundImage")));
            this.tcInfo.TabsStateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tcInfo.TabsStateStyles.HotFormatStyle.BackgroundImage")));
            this.tcInfo.TabsStateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tcInfo.TabsStateStyles.SelectedFormatStyle.BackgroundImage")));
            this.tcInfo.TabsStateStyles.SelectedFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tcInfo.TabStripFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tcInfo.UseThemes = false;
            // 
            // tpDetail2
            // 
            this.tpDetail2.Controls.Add(this.dgvLimit);
            this.tpDetail2.Location = new System.Drawing.Point(0, 32);
            this.tpDetail2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tpDetail2.Name = "tpDetail2";
            this.tpDetail2.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tpDetail2.Size = new System.Drawing.Size(612, 415);
            this.tpDetail2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDetail2.StateStyles.FormatStyle.BackgroundImage")));
            this.tpDetail2.StateStyles.FormatStyle.BackgroundImageDrawMode = Janus.Windows.UI.BackgroundImageDrawMode.Stretch;
            this.tpDetail2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDetail2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.tpDetail2.StateStyles.HotFormatStyle.BackgroundImageDrawMode = Janus.Windows.UI.BackgroundImageDrawMode.Stretch;
            this.tpDetail2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDetail2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.tpDetail2.StateStyles.SelectedFormatStyle.BackgroundImageDrawMode = Janus.Windows.UI.BackgroundImageDrawMode.Stretch;
            this.tpDetail2.TabStop = true;
            this.tpDetail2.Text = "جزئیات";
            // 
            // dgvLimit
            // 
            this.dgvLimit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLimit.BackgroundColor = System.Drawing.Color.White;
            this.dgvLimit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLimit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLimit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLimit.EnableHeadersVisualStyles = false;
            this.dgvLimit.Location = new System.Drawing.Point(0, 0);
            this.dgvLimit.Name = "dgvLimit";
            this.dgvLimit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvLimit.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvLimit.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.dgvLimit.Size = new System.Drawing.Size(612, 415);
            this.dgvLimit.TabIndex = 0;
            this.dgvLimit.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLimit_CellFormatting);
            this.dgvLimit.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLimit_CellMouseDown);
            this.dgvLimit.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvLimit_CellPainting);
            // 
            // tpChart2
            // 
            this.tpChart2.Controls.Add(this.splitContainer3);
            this.tpChart2.Location = new System.Drawing.Point(0, 32);
            this.tpChart2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tpChart2.Name = "tpChart2";
            this.tpChart2.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tpChart2.Size = new System.Drawing.Size(612, 415);
            this.tpChart2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpChart2.StateStyles.FormatStyle.BackgroundImage")));
            this.tpChart2.StateStyles.FormatStyle.BackgroundImageDrawMode = Janus.Windows.UI.BackgroundImageDrawMode.Center;
            this.tpChart2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpChart2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.tpChart2.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Transparent;
            this.tpChart2.StateStyles.SelectedFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.Transparent;
            this.tpChart2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpChart2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.tpChart2.TabStop = true;
            this.tpChart2.Text = "نمودار";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.chbFilterChartValues);
            this.splitContainer3.Panel1.Controls.Add(this.cgbFiltering);
            this.splitContainer3.Panel1.Controls.Add(this.cGroupBox1);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ddChart);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(612, 415);
            this.splitContainer3.SplitterDistance = 90;
            this.splitContainer3.TabIndex = 0;
            // 
            // chbFilterChartValues
            // 
            this.chbFilterChartValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbFilterChartValues.AutoSize = true;
            this.chbFilterChartValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.chbFilterChartValues.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbFilterChartValues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chbFilterChartValues.Location = new System.Drawing.Point(362, -4);
            this.chbFilterChartValues.Name = "chbFilterChartValues";
            this.chbFilterChartValues.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbFilterChartValues.Size = new System.Drawing.Size(106, 24);
            this.chbFilterChartValues.TabIndex = 3;
            this.chbFilterChartValues.Text = "فیلتربندی نمودار";
            this.chbFilterChartValues.UseVisualStyleBackColor = false;
            this.chbFilterChartValues.CheckedChanged += new System.EventHandler(this.chbFilterChartValues_CheckedChanged);
            // 
            // cgbFiltering
            // 
            this.cgbFiltering.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbFiltering.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbFiltering.Controls.Add(this.tableLayoutPanel1);
            this.cgbFiltering.Controls.Add(this.label2);
            this.cgbFiltering.Controls.Add(this.cbFilter);
            this.cgbFiltering.Controls.Add(this.label1);
            this.cgbFiltering.Dock = System.Windows.Forms.DockStyle.Right;
            this.cgbFiltering.Enabled = false;
            this.cgbFiltering.Location = new System.Drawing.Point(3, 0);
            this.cgbFiltering.Name = "cgbFiltering";
            this.cgbFiltering.Size = new System.Drawing.Size(473, 90);
            this.cgbFiltering.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbFilterLimits, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(104, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 50);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.MaximumSize = new System.Drawing.Size(283, 48);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.rdbMore);
            this.splitContainer4.Panel1.Controls.Add(this.rdbLess);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Panel1MinSize = 5;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.cmbFilterValues);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Panel2MinSize = 5;
            this.splitContainer4.Size = new System.Drawing.Size(281, 19);
            this.splitContainer4.SplitterDistance = 166;
            this.splitContainer4.TabIndex = 48;
            // 
            // rdbMore
            // 
            this.rdbMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbMore.AutoSize = true;
            this.rdbMore.Checked = true;
            this.rdbMore.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbMore.Location = new System.Drawing.Point(88, 0);
            this.rdbMore.Name = "rdbMore";
            this.rdbMore.Size = new System.Drawing.Size(78, 21);
            this.rdbMore.TabIndex = 46;
            this.rdbMore.TabStop = true;
            this.rdbMore.Text = "بزرگتر مساوی";
            this.rdbMore.UseVisualStyleBackColor = true;
            // 
            // rdbLess
            // 
            this.rdbLess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbLess.AutoSize = true;
            this.rdbLess.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbLess.Location = new System.Drawing.Point(4, -1);
            this.rdbLess.Name = "rdbLess";
            this.rdbLess.Size = new System.Drawing.Size(84, 21);
            this.rdbLess.TabIndex = 46;
            this.rdbLess.Text = "کوچکتر مساوی";
            this.rdbLess.UseVisualStyleBackColor = true;
            // 
            // cmbFilterValues
            // 
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance7.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance7.ImageBackground")));
            appearance7.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbFilterValues.Appearance = appearance7;
            this.cmbFilterValues.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbFilterValues.AutoSize = false;
            this.cmbFilterValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance8.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance8.ImageBackground")));
            appearance8.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbFilterValues.ButtonAppearance = appearance8;
            this.cmbFilterValues.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbFilterValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterValues.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbFilterValues.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbFilterValues.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbFilterValues.HideSelection = false;
            appearance9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbFilterValues.ItemAppearance = appearance9;
            this.cmbFilterValues.Location = new System.Drawing.Point(0, 0);
            this.cmbFilterValues.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFilterValues.Name = "cmbFilterValues";
            this.cmbFilterValues.Size = new System.Drawing.Size(111, 19);
            this.cmbFilterValues.TabIndex = 4;
            // 
            // cmbFilterLimits
            // 
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            appearance1.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbFilterLimits.Appearance = appearance1;
            this.cmbFilterLimits.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbFilterLimits.AutoSize = false;
            this.cmbFilterLimits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            appearance2.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbFilterLimits.ButtonAppearance = appearance2;
            this.cmbFilterLimits.CheckedListSettings.CheckBoxStyle = Infragistics.Win.CheckStyle.CheckBox;
            this.cmbFilterLimits.CheckedListSettings.EditorValueSource = Infragistics.Win.EditorWithComboValueSource.CheckedItems;
            this.cmbFilterLimits.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbFilterLimits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFilterLimits.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbFilterLimits.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbFilterLimits.HideSelection = false;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbFilterLimits.ItemAppearance = appearance3;
            this.cmbFilterLimits.Location = new System.Drawing.Point(3, 29);
            this.cmbFilterLimits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFilterLimits.MinimumSize = new System.Drawing.Size(283, 20);
            this.cmbFilterLimits.Name = "cmbFilterLimits";
            this.cmbFilterLimits.Size = new System.Drawing.Size(283, 20);
            this.cmbFilterLimits.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "بر اساس حدود";
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbFilter.DefaultImage")));
            this.cbFilter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbFilter.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbFilter.HoverImage")));
            this.cbFilter.Location = new System.Drawing.Point(1, 10);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbFilter.Size = new System.Drawing.Size(97, 34);
            this.cbFilter.TabIndex = 4;
            this.cbFilter.Title = null;
            this.cbFilter.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbFilter_CButtonClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "بر اساس مقادیر";
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cGroupBox1.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cGroupBox1.Controls.Add(this.chkLegend);
            this.cGroupBox1.Controls.Add(this.chkShowHideValue);
            this.cGroupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.cGroupBox1.Location = new System.Drawing.Point(476, 0);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(136, 90);
            this.cGroupBox1.TabIndex = 4;
            this.cGroupBox1.Text = "جزئیات نمودار";
            // 
            // chkLegend
            // 
            this.chkLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLegend.AutoSize = true;
            this.chkLegend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.chkLegend.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkLegend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chkLegend.Location = new System.Drawing.Point(39, 18);
            this.chkLegend.Name = "chkLegend";
            this.chkLegend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLegend.Size = new System.Drawing.Size(91, 24);
            this.chkLegend.TabIndex = 3;
            this.chkLegend.Text = " نمایش راهنما";
            this.chkLegend.UseVisualStyleBackColor = false;
            this.chkLegend.Click += new System.EventHandler(this.chkLegend_Click);
            // 
            // chkShowHideValue
            // 
            this.chkShowHideValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowHideValue.AutoSize = true;
            this.chkShowHideValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.chkShowHideValue.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkShowHideValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chkShowHideValue.Location = new System.Drawing.Point(40, 40);
            this.chkShowHideValue.Name = "chkShowHideValue";
            this.chkShowHideValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkShowHideValue.Size = new System.Drawing.Size(90, 24);
            this.chkShowHideValue.TabIndex = 2;
            this.chkShowHideValue.Text = " نمایش مقادیر";
            this.chkShowHideValue.UseVisualStyleBackColor = false;
            this.chkShowHideValue.Click += new System.EventHandler(this.chkShowHideValue_Click);
            // 
            // ddChart
            // 
            this.ddChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.ddChart.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(186)))), ((int)(((byte)(145)))));
            this.ddChart.BackGradientType = Dundas.Charting.WinControl.GradientType.TopBottom;
            this.ddChart.BackImageTranspColor = System.Drawing.Color.Transparent;
            this.ddChart.BorderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(147)))));
            this.ddChart.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            this.ddChart.BorderSkin.FrameBackColor = System.Drawing.Color.SteelBlue;
            this.ddChart.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue;
            this.ddChart.BorderSkin.FrameBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ddChart.BorderSkin.FrameBorderWidth = 2;
            this.ddChart.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke;
            this.ddChart.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
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
            this.ddChart.ChartAreas.Add(chartArea1);
            this.ddChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.AutoFitText = false;
            legend1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.Name = "Default";
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            legend2.BorderColor = System.Drawing.Color.LightSlateGray;
            legend2.Name = "Legend1";
            legend2.ShadowOffset = 1;
            this.ddChart.Legends.Add(legend1);
            this.ddChart.Legends.Add(legend2);
            this.ddChart.Location = new System.Drawing.Point(0, 0);
            this.ddChart.Margin = new System.Windows.Forms.Padding(3, 46, 3, 46);
            this.ddChart.Name = "ddChart";
            this.ddChart.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas;
            series1.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            series1.BackGradientType = Dundas.Charting.WinControl.GradientType.TopBottom;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Name = "Series1";
            series1.SmartLabels.Enabled = true;
            series1.ToolTip = "#AXISLABEL #VAL";
            this.ddChart.Series.Add(series1);
            this.ddChart.Size = new System.Drawing.Size(612, 321);
            this.ddChart.TabIndex = 141;
            this.ddChart.Text = "chart1";
            this.ddChart.UI.Toolbar.AllowMouseMoving = false;
            this.ddChart.UI.Toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(170)))), ((int)(((byte)(126)))));
            this.ddChart.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(147)))));
            this.ddChart.UI.Toolbar.BorderSkin.FrameBackColor = System.Drawing.Color.SteelBlue;
            this.ddChart.UI.Toolbar.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue;
            this.ddChart.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.ddChart.UI.Toolbar.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            this.ddChart.UI.Toolbar.Enabled = true;
            // 
            // frmLimitReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(790, 479);
            this.Controls.Add(this.spcAll);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLimitReport";
            this.Text = "  گزارش مدیریت حدود   ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLimitReport_Load);
            this.spcAll.Panel1.ResumeLayout(false);
            this.spcAll.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).EndInit();
            this.spcAll.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tsModel.ResumeLayout(false);
            this.tsModel.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcInfo)).EndInit();
            this.tcInfo.ResumeLayout(false);
            this.tpDetail2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLimit)).EndInit();
            this.tpChart2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cgbFiltering)).EndInit();
            this.cgbFiltering.ResumeLayout(false);
            this.cgbFiltering.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilterValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilterLimits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGroupBox1)).EndInit();
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcAll;
        private System.Windows.Forms.ListView lsvModel;
        private System.Windows.Forms.ToolStrip tsModel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbModelRefresh;
        private System.Windows.Forms.DataGridView dgvLimit;
        private System.Windows.Forms.CheckBox chkLegend;
        private System.Windows.Forms.CheckBox chkShowHideValue;
        private Janus.Windows.UI.Tab.UITab tcInfo;
        private Janus.Windows.UI.Tab.UITabPage tpDetail2;
        private Janus.Windows.UI.Tab.UITabPage tpChart2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Utilize.Company.CButton btnModel;
        private Dundas.Charting.WinControl.Chart ddChart;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Utilize.Company.CGroupBox cgbFiltering;
        private Utilize.Company.CGroupBox cGroupBox1;
        private System.Windows.Forms.CheckBox chbFilterChartValues;
        private Utilize.Company.CComboCox cmbFilterLimits;
        private Utilize.Company.CComboCox cmbFilterValues;
        private System.Windows.Forms.RadioButton rdbMore;
        private System.Windows.Forms.RadioButton rdbLess;
        private Utilize.Company.CButton cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}
