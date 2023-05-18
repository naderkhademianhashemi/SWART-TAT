namespace Presentation.Tabs.RPTAssetsDebts
{
    partial class frmGapReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGapReport));
            Dundas.Charting.WinControl.ChartArea chartArea1 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend1 = new Dundas.Charting.WinControl.Legend();
            this.spcAll = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tsModel = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.lsvModel = new Utilize.Company.CListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lblGapDateRpt = new System.Windows.Forms.Label();
            this.lblgapDate = new System.Windows.Forms.Label();
            this.cbCollapseRight = new Utilize.Company.CButton();
            this.tabGapRep = new Janus.Windows.UI.Tab.UITab();
            this.tpDetail2 = new Janus.Windows.UI.Tab.UITabPage();
            this.dgvGAP = new System.Windows.Forms.DataGridView();
            this.tpChart2 = new Janus.Windows.UI.Tab.UITabPage();
            this.chkLegend = new System.Windows.Forms.CheckBox();
            this.chkShowHideValue = new System.Windows.Forms.CheckBox();
            this.ddChart = new Dundas.Charting.WinControl.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).BeginInit();
            this.spcAll.Panel1.SuspendLayout();
            this.spcAll.Panel2.SuspendLayout();
            this.spcAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tsModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabGapRep)).BeginInit();
            this.tabGapRep.SuspendLayout();
            this.tpDetail2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGAP)).BeginInit();
            this.tpChart2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddChart)).BeginInit();
            this.SuspendLayout();
            // 
            // spcAll
            // 
            this.spcAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcAll.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcAll.Location = new System.Drawing.Point(0, 0);
            this.spcAll.Name = "spcAll";
            // 
            // spcAll.Panel1
            // 
            this.spcAll.Panel1.Controls.Add(this.splitContainer2);
            this.spcAll.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spcAll.Panel1MinSize = 239;
            // 
            // spcAll.Panel2
            // 
            this.spcAll.Panel2.Controls.Add(this.splitContainer1);
            this.spcAll.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spcAll.Size = new System.Drawing.Size(800, 459);
            this.spcAll.SplitterDistance = 239;
            this.spcAll.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tsModel);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lsvModel);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(239, 459);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 1;
            // 
            // tsModel
            // 
            this.tsModel.BackColor = System.Drawing.Color.Transparent;
            this.tsModel.BackgroundImage = global::Presentation.Properties.Resources.S_Head;
            this.tsModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsModel.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsModel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsModel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tsbRefresh,
            this.tsbDelete});
            this.tsModel.Location = new System.Drawing.Point(0, 0);
            this.tsModel.Name = "tsModel";
            this.tsModel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsModel.Size = new System.Drawing.Size(239, 25);
            this.tsModel.TabIndex = 6;
            this.tsModel.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "مدلها";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "toolStripButton1";
            this.tsbRefresh.ToolTipText = "تازه سازی";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::Presentation.Properties.Resources.S_Delete;
            this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.ToolTipText = "حذف";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // lsvModel
            // 
            this.lsvModel.BackColor = System.Drawing.Color.White;
            this.lsvModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvModel.Location = new System.Drawing.Point(0, 0);
            this.lsvModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvModel.Name = "lsvModel";
            this.lsvModel.Size = new System.Drawing.Size(239, 430);
            this.lsvModel.TabIndex = 7;
            this.lsvModel.UseCompatibleStateImageBehavior = false;
            this.lsvModel.SelectedIndexChanged += new System.EventHandler(this.lsvModel_SelectedIndexChanged);
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel1.Controls.Add(this.cbCollapseRight);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabGapRep);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(557, 459);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 53;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lblGapDateRpt);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lblgapDate);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(526, 25);
            this.splitContainer3.SplitterDistance = 157;
            this.splitContainer3.TabIndex = 9;
            // 
            // lblGapDateRpt
            // 
            this.lblGapDateRpt.AutoSize = true;
            this.lblGapDateRpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGapDateRpt.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblGapDateRpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblGapDateRpt.Location = new System.Drawing.Point(0, 0);
            this.lblGapDateRpt.Name = "lblGapDateRpt";
            this.lblGapDateRpt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGapDateRpt.Size = new System.Drawing.Size(154, 20);
            this.lblGapDateRpt.TabIndex = 6;
            this.lblGapDateRpt.Text = ": گزارش تحليل شكاف در تاريخ ";
            this.lblGapDateRpt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblgapDate
            // 
            this.lblgapDate.AutoSize = true;
            this.lblgapDate.BackColor = System.Drawing.Color.Transparent;
            this.lblgapDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblgapDate.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblgapDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblgapDate.Location = new System.Drawing.Point(329, 0);
            this.lblgapDate.Name = "lblgapDate";
            this.lblgapDate.Size = new System.Drawing.Size(36, 20);
            this.lblgapDate.TabIndex = 7;
            this.lblgapDate.Text = ".........";
            // 
            // cbCollapseRight
            // 
            this.cbCollapseRight.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbCollapseRight.DefaultImage")));
            this.cbCollapseRight.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbCollapseRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbCollapseRight.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbCollapseRight.HoverImage")));
            this.cbCollapseRight.Location = new System.Drawing.Point(526, 0);
            this.cbCollapseRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCollapseRight.Name = "cbCollapseRight";
            this.cbCollapseRight.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCollapseRight.Size = new System.Drawing.Size(31, 25);
            this.cbCollapseRight.TabIndex = 8;
            this.cbCollapseRight.Title = null;
            this.cbCollapseRight.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbCollapseRight_CButtonClicked);
            // 
            // tabGapRep
            // 
            this.tabGapRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(228)))));
            this.tabGapRep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGapRep.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(228)))));
            this.tabGapRep.ItemSize = new System.Drawing.Size(66, 31);
            this.tabGapRep.Location = new System.Drawing.Point(0, 0);
            this.tabGapRep.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabGapRep.Name = "tabGapRep";
            this.tabGapRep.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabGapRep.PageBorder = Janus.Windows.UI.Tab.PageBorder.None;
            this.tabGapRep.PanelFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(215)))), ((int)(((byte)(170)))));
            this.tabGapRep.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Horizontal;
            this.tabGapRep.Size = new System.Drawing.Size(557, 431);
            this.tabGapRep.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabGapRep.TabDisplay = Janus.Windows.UI.Tab.TabDisplay.Image;
            this.tabGapRep.TabIndex = 52;
            this.tabGapRep.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.tpDetail2,
            this.tpChart2});
            this.tabGapRep.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.Transparent;
            this.tabGapRep.TabsStateStyles.SelectedFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabGapRep.TabStripFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabGapRep.UseThemes = false;
            // 
            // tpDetail2
            // 
            this.tpDetail2.Controls.Add(this.dgvGAP);
            this.tpDetail2.Location = new System.Drawing.Point(0, 33);
            this.tpDetail2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tpDetail2.Name = "tpDetail2";
            this.tpDetail2.Size = new System.Drawing.Size(557, 398);
            this.tpDetail2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDetail2.StateStyles.FormatStyle.BackgroundImage")));
            this.tpDetail2.StateStyles.FormatStyle.BackgroundImageDrawMode = Janus.Windows.UI.BackgroundImageDrawMode.Center;
            this.tpDetail2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDetail2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.tpDetail2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDetail2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.tpDetail2.TabStop = true;
            // 
            // dgvGAP
            // 
            this.dgvGAP.BackgroundColor = System.Drawing.Color.White;
            this.dgvGAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGAP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.dgvGAP.Location = new System.Drawing.Point(0, 0);
            this.dgvGAP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvGAP.Name = "dgvGAP";
            this.dgvGAP.Size = new System.Drawing.Size(557, 398);
            this.dgvGAP.TabIndex = 3;
            // 
            // tpChart2
            // 
            this.tpChart2.Controls.Add(this.chkLegend);
            this.tpChart2.Controls.Add(this.chkShowHideValue);
            this.tpChart2.Controls.Add(this.ddChart);
            this.tpChart2.Location = new System.Drawing.Point(0, 33);
            this.tpChart2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tpChart2.Name = "tpChart2";
            this.tpChart2.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tpChart2.Size = new System.Drawing.Size(557, 398);
            this.tpChart2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpChart2.StateStyles.FormatStyle.BackgroundImage")));
            this.tpChart2.StateStyles.FormatStyle.BackgroundImageDrawMode = Janus.Windows.UI.BackgroundImageDrawMode.Center;
            this.tpChart2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpChart2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.tpChart2.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Transparent;
            this.tpChart2.StateStyles.SelectedFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.Transparent;
            this.tpChart2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpChart2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.tpChart2.TabStop = true;
            // 
            // chkLegend
            // 
            this.chkLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLegend.AutoSize = true;
            this.chkLegend.BackColor = System.Drawing.Color.Transparent;
            this.chkLegend.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkLegend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chkLegend.Location = new System.Drawing.Point(326, 8);
            this.chkLegend.Name = "chkLegend";
            this.chkLegend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLegend.Size = new System.Drawing.Size(91, 24);
            this.chkLegend.TabIndex = 9;
            this.chkLegend.Text = " نمایش راهنما";
            this.chkLegend.UseVisualStyleBackColor = false;
            this.chkLegend.CheckedChanged += new System.EventHandler(this.chkLegend_CheckedChanged);
            // 
            // chkShowHideValue
            // 
            this.chkShowHideValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowHideValue.AutoSize = true;
            this.chkShowHideValue.BackColor = System.Drawing.Color.Transparent;
            this.chkShowHideValue.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkShowHideValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chkShowHideValue.Location = new System.Drawing.Point(454, 8);
            this.chkShowHideValue.Name = "chkShowHideValue";
            this.chkShowHideValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkShowHideValue.Size = new System.Drawing.Size(90, 24);
            this.chkShowHideValue.TabIndex = 8;
            this.chkShowHideValue.Text = " نمایش مقادیر";
            this.chkShowHideValue.UseVisualStyleBackColor = false;
            this.chkShowHideValue.CheckedChanged += new System.EventHandler(this.chkShowHideValue_CheckedChanged);
            // 
            // ddChart
            // 
            this.ddChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(186)))), ((int)(((byte)(145)))));
            this.ddChart.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.ddChart.BackGradientType = Dundas.Charting.WinControl.GradientType.TopBottom;
            this.ddChart.BorderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(146)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "Default";
            this.ddChart.ChartAreas.Add(chartArea1);
            this.ddChart.Cursor = System.Windows.Forms.Cursors.Cross;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Default";
            this.ddChart.Legends.Add(legend1);
            this.ddChart.Location = new System.Drawing.Point(3, 34);
            this.ddChart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ddChart.Name = "ddChart";
            this.ddChart.Size = new System.Drawing.Size(554, 359);
            this.ddChart.TabIndex = 5;
            this.ddChart.UI.Toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(170)))), ((int)(((byte)(126)))));
            this.ddChart.UI.Toolbar.Enabled = true;
            // 
            // frmGapReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.spcAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGapReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmGapReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGapReport_Load);
            this.Shown += new System.EventHandler(this.frmGapReport_Shown);
            this.spcAll.Panel1.ResumeLayout(false);
            this.spcAll.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).EndInit();
            this.spcAll.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tsModel.ResumeLayout(false);
            this.tsModel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabGapRep)).EndInit();
            this.tabGapRep.ResumeLayout(false);
            this.tpDetail2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGAP)).EndInit();
            this.tpChart2.ResumeLayout(false);
            this.tpChart2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcAll;
        private System.Windows.Forms.ToolStrip tsModel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.Label lblgapDate;
        private System.Windows.Forms.Label lblGapDateRpt;
        private Utilize.Company.CListView lsvModel;
        private Janus.Windows.UI.Tab.UITab tabGapRep;
        private Janus.Windows.UI.Tab.UITabPage tpDetail2;
        private Janus.Windows.UI.Tab.UITabPage tpChart2;
        private System.Windows.Forms.DataGridView dgvGAP;
        private Dundas.Charting.WinControl.Chart ddChart;
        private System.Windows.Forms.CheckBox chkLegend;
        private System.Windows.Forms.CheckBox chkShowHideValue;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Utilize.Company.CButton cbCollapseRight;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}