namespace Presentation.Tabs.RPTAssetsDebts
{
    partial class frmGapTrendingReport
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
            Dundas.Charting.WinControl.ChartArea chartArea1 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend1 = new Dundas.Charting.WinControl.Legend();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGapTrendingReport));
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkLstGap = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddChart = new Dundas.Charting.WinControl.Chart();
            this.rdoGap = new System.Windows.Forms.RadioButton();
            this.rdoAsset = new System.Windows.Forms.RadioButton();
            this.rdoDebit = new System.Windows.Forms.RadioButton();
            this.cmbTBM = new Utilize.Company.CComboCox();
            this.btnReportDisplay = new Utilize.Company.CButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbCollapseRight = new Utilize.Company.CButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTBM)).BeginInit();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "بسته هاي زماني";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "گزارشات تحليل شكاف بسته زماني انتخاب شده\r\n";
            // 
            // chkLstGap
            // 
            this.chkLstGap.BackColor = System.Drawing.Color.White;
            this.chkLstGap.CheckOnClick = true;
            this.chkLstGap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLstGap.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkLstGap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.chkLstGap.FormattingEnabled = true;
            this.chkLstGap.Location = new System.Drawing.Point(0, 0);
            this.chkLstGap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkLstGap.Name = "chkLstGap";
            this.chkLstGap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLstGap.Size = new System.Drawing.Size(232, 455);
            this.chkLstGap.TabIndex = 4;
            this.chkLstGap.SelectedValueChanged += new System.EventHandler(this.chkLstGap_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ddChart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 560);
            this.panel1.TabIndex = 5;
            // 
            // ddChart
            // 
            this.ddChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(186)))), ((int)(((byte)(145)))));
            this.ddChart.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.ddChart.BackGradientType = Dundas.Charting.WinControl.GradientType.TopBottom;
            this.ddChart.BorderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(147)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientEndColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft;
            chartArea1.Name = "Default";
            this.ddChart.ChartAreas.Add(chartArea1);
            this.ddChart.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ddChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.AutoFitText = false;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackGradientEndColor = System.Drawing.Color.Transparent;
            legend1.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft;
            legend1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            legend1.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            legend1.Name = "Default";
            this.ddChart.Legends.Add(legend1);
            this.ddChart.Location = new System.Drawing.Point(0, 0);
            this.ddChart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ddChart.Name = "ddChart";
            this.ddChart.Size = new System.Drawing.Size(564, 560);
            this.ddChart.TabIndex = 2;
            this.ddChart.UI.Toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(170)))), ((int)(((byte)(126)))));
            this.ddChart.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(147)))));
            this.ddChart.UI.Toolbar.Enabled = true;
            // 
            // rdoGap
            // 
            this.rdoGap.AutoSize = true;
            this.rdoGap.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoGap.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoGap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoGap.Location = new System.Drawing.Point(140, 3);
            this.rdoGap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoGap.Name = "rdoGap";
            this.rdoGap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoGap.Size = new System.Drawing.Size(90, 22);
            this.rdoGap.TabIndex = 7;
            this.rdoGap.TabStop = true;
            this.rdoGap.Text = "گزارش شكاف";
            this.rdoGap.UseVisualStyleBackColor = true;
            // 
            // rdoAsset
            // 
            this.rdoAsset.AutoSize = true;
            this.rdoAsset.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoAsset.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoAsset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoAsset.Location = new System.Drawing.Point(130, 31);
            this.rdoAsset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoAsset.Name = "rdoAsset";
            this.rdoAsset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoAsset.Size = new System.Drawing.Size(100, 22);
            this.rdoAsset.TabIndex = 8;
            this.rdoAsset.TabStop = true;
            this.rdoAsset.Text = "گزارش داريي ها";
            this.rdoAsset.UseVisualStyleBackColor = true;
            // 
            // rdoDebit
            // 
            this.rdoDebit.AutoSize = true;
            this.rdoDebit.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoDebit.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoDebit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoDebit.Location = new System.Drawing.Point(132, 59);
            this.rdoDebit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoDebit.Name = "rdoDebit";
            this.rdoDebit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoDebit.Size = new System.Drawing.Size(98, 22);
            this.rdoDebit.TabIndex = 9;
            this.rdoDebit.TabStop = true;
            this.rdoDebit.Text = "گزارش بدهي ها";
            this.rdoDebit.UseVisualStyleBackColor = true;
            // 
            // cmbTBM
            // 
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            appearance1.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbTBM.Appearance = appearance1;
            this.cmbTBM.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbTBM.AutoSize = false;
            this.cmbTBM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            appearance2.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Centered;
            this.cmbTBM.ButtonAppearance = appearance2;
            this.cmbTBM.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbTBM.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbTBM.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbTBM.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbTBM.HideSelection = false;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbTBM.ItemAppearance = appearance3;
            this.cmbTBM.Location = new System.Drawing.Point(18, 0);
            this.cmbTBM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbTBM.Name = "cmbTBM";
            this.cmbTBM.Size = new System.Drawing.Size(128, 22);
            this.cmbTBM.TabIndex = 10;
            this.cmbTBM.SelectionChanged += new System.EventHandler(this.cmbTBM_SelectedIndexChanged);
            // 
            // btnReportDisplay
            // 
            this.btnReportDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportDisplay.BackColor = System.Drawing.Color.Transparent;
            this.btnReportDisplay.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnReportDisplay.DefaultImage")));
            this.btnReportDisplay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReportDisplay.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReportDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnReportDisplay.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnReportDisplay.HoverImage")));
            this.btnReportDisplay.Location = new System.Drawing.Point(428, 1);
            this.btnReportDisplay.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnReportDisplay.Name = "btnReportDisplay";
            this.btnReportDisplay.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReportDisplay.Size = new System.Drawing.Size(96, 34);
            this.btnReportDisplay.TabIndex = 81;
            this.btnReportDisplay.Title = "";
            this.btnReportDisplay.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnReportDisplay_Click);
            this.btnReportDisplay.Load += new System.EventHandler(this.btnReportDisplay_Load);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbCollapseRight);
            this.splitContainer1.Panel1.Controls.Add(this.btnReportDisplay);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(564, 600);
            this.splitContainer1.SplitterDistance = 37;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 82;
            // 
            // cbCollapseRight
            // 
            this.cbCollapseRight.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbCollapseRight.DefaultImage")));
            this.cbCollapseRight.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbCollapseRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbCollapseRight.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbCollapseRight.HoverImage")));
            this.cbCollapseRight.Location = new System.Drawing.Point(532, 0);
            this.cbCollapseRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbCollapseRight.Name = "cbCollapseRight";
            this.cbCollapseRight.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCollapseRight.Size = new System.Drawing.Size(32, 37);
            this.cbCollapseRight.TabIndex = 82;
            this.cbCollapseRight.Title = null;
            this.cbCollapseRight.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbCollapseRight_CButtonClicked);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(800, 600);
            this.splitContainer2.SplitterDistance = 232;
            this.splitContainer2.TabIndex = 83;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.chkLstGap);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(232, 600);
            this.splitContainer3.SplitterDistance = 142;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rdoGap, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdoAsset, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdoDebit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(232, 142);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 22);
            this.panel2.TabIndex = 12;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.cmbTBM);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.label1);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer4.Size = new System.Drawing.Size(228, 22);
            this.splitContainer4.SplitterDistance = 146;
            this.splitContainer4.TabIndex = 11;
            // 
            // frmGapTrendingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGapTrendingReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارشات روند گیری تحلیل شکاف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGapTrendingReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTBM)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chkLstGap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoGap;
        private System.Windows.Forms.RadioButton rdoAsset;
        private System.Windows.Forms.RadioButton rdoDebit;
        private Dundas.Charting.WinControl.Chart ddChart;
        private Utilize.Company.CComboCox cmbTBM;
        private Utilize.Company.CButton btnReportDisplay;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private Utilize.Company.CButton cbCollapseRight;
        private System.Windows.Forms.SplitContainer splitContainer4;
    }
}