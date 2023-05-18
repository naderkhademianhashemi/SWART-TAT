namespace Presentation.Deposit
{
    partial class frmHistoricalDepositReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoricalDepositReport));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Dundas.Charting.WinControl.ChartArea chartArea1 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend1 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Legend legend2 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Series series1 = new Dundas.Charting.WinControl.Series();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.btnShowReport = new Utilize.Company.CButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYearFrom = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.tabMain = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.dgvDMReport = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstYears = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbShowSequntial = new System.Windows.Forms.RadioButton();
            this.rdbShowPartial = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chbSerries = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_Price = new System.Windows.Forms.RadioButton();
            this.rb_Count = new System.Windows.Forms.RadioButton();
            this.chart = new Dundas.Charting.WinControl.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cGroupBox1 = new Utilize.Company.CGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbOneYear = new System.Windows.Forms.RadioButton();
            this.rdbMultipleYears = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYearTo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.txtYear = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGroupBox1)).BeginInit();
            this.cGroupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).BeginInit();
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
            this.btnShowReport.Location = new System.Drawing.Point(197, 56);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowReport.Size = new System.Drawing.Size(136, 29);
            this.btnShowReport.TabIndex = 6;
            this.btnShowReport.Title = null;
            this.btnShowReport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnShowRpt_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(337, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "(به عنوان نمونه  : 1390)";
            // 
            // txtYearFrom
            // 
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            appearance1.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.txtYearFrom.Appearance = appearance1;
            this.txtYearFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            this.txtYearFrom.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.txtYearFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYearFrom.Enabled = false;
            this.txtYearFrom.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtYearFrom.Location = new System.Drawing.Point(167, 33);
            this.txtYearFrom.MaskInput = "nnnn";
            this.txtYearFrom.MaxValue = 2000;
            this.txtYearFrom.MinValue = 1300;
            this.txtYearFrom.Name = "txtYearFrom";
            this.txtYearFrom.Size = new System.Drawing.Size(54, 26);
            this.txtYearFrom.SpinButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.txtYearFrom.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.txtYearFrom.SpinIncrement = 1;
            this.txtYearFrom.TabIndex = 4;
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
            this.tabMain.Size = new System.Drawing.Size(734, 329);
            this.tabMain.TabIndex = 144;
            this.tabMain.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage1});
            this.tabMain.TabStripFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.UseThemes = false;
            this.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.dgvDMReport);
            this.uiTabPage2.Controls.Add(this.panel2);
            this.uiTabPage2.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(730, 298);
            this.uiTabPage2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "جدول";
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
            this.dgvDMReport.Size = new System.Drawing.Size(583, 298);
            this.dgvDMReport.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstYears);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(583, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 298);
            this.panel2.TabIndex = 52;
            // 
            // lstYears
            // 
            this.lstYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstYears.FormattingEnabled = true;
            this.lstYears.ItemHeight = 20;
            this.lstYears.Location = new System.Drawing.Point(0, 23);
            this.lstYears.Name = "lstYears";
            this.lstYears.Size = new System.Drawing.Size(147, 275);
            this.lstYears.TabIndex = 50;
            this.lstYears.SelectedIndexChanged += new System.EventHandler(this.lstYears_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 23);
            this.panel1.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(34, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "سال های گزارش گیری";
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
            this.label5.Location = new System.Drawing.Point(74, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "نحوه نمایش نمودار";
            // 
            // rdbShowSequntial
            // 
            this.rdbShowSequntial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbShowSequntial.AutoSize = true;
            this.rdbShowSequntial.BackColor = System.Drawing.Color.Transparent;
            this.rdbShowSequntial.Checked = true;
            this.rdbShowSequntial.Location = new System.Drawing.Point(46, 22);
            this.rdbShowSequntial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbShowSequntial.Name = "rdbShowSequntial";
            this.rdbShowSequntial.Size = new System.Drawing.Size(111, 24);
            this.rdbShowSequntial.TabIndex = 141;
            this.rdbShowSequntial.TabStop = true;
            this.rdbShowSequntial.Text = "سری زمانی سالیانه";
            this.rdbShowSequntial.UseVisualStyleBackColor = false;
            this.rdbShowSequntial.CheckedChanged += new System.EventHandler(this.rdbShowSequntial_CheckedChanged);
            // 
            // rdbShowPartial
            // 
            this.rdbShowPartial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbShowPartial.AutoSize = true;
            this.rdbShowPartial.BackColor = System.Drawing.Color.Transparent;
            this.rdbShowPartial.Location = new System.Drawing.Point(46, 44);
            this.rdbShowPartial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbShowPartial.Name = "rdbShowPartial";
            this.rdbShowPartial.Size = new System.Drawing.Size(111, 24);
            this.rdbShowPartial.TabIndex = 141;
            this.rdbShowPartial.Text = "سری زمانی ماهیانه";
            this.rdbShowPartial.UseVisualStyleBackColor = false;
            this.rdbShowPartial.CheckedChanged += new System.EventHandler(this.rdbShowSequntial_CheckedChanged);
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
            this.chbSerries.BackColor = System.Drawing.Color.White;
            this.chbSerries.CheckOnClick = true;
            this.chbSerries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbSerries.FormattingEnabled = true;
            this.chbSerries.HorizontalScrollbar = true;
            this.chbSerries.Location = new System.Drawing.Point(0, 23);
            this.chbSerries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbSerries.Name = "chbSerries";
            this.chbSerries.Size = new System.Drawing.Size(164, 190);
            this.chbSerries.TabIndex = 139;
            this.chbSerries.SelectedIndexChanged += new System.EventHandler(this.chbSerries_SelectedIndexChanged);
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
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "سال های گزارش گیری،  نام مدل";
            // 
            // rb_Price
            // 
            this.rb_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_Price.AutoSize = true;
            this.rb_Price.BackColor = System.Drawing.Color.Transparent;
            this.rb_Price.Checked = true;
            this.rb_Price.Location = new System.Drawing.Point(329, 7);
            this.rb_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Price.Name = "rb_Price";
            this.rb_Price.Size = new System.Drawing.Size(94, 24);
            this.rb_Price.TabIndex = 142;
            this.rb_Price.TabStop = true;
            this.rb_Price.Text = "مبلغ سپرده ها";
            this.rb_Price.UseVisualStyleBackColor = false;
            this.rb_Price.CheckedChanged += new System.EventHandler(this.rb_Price_CheckedChanged);
            // 
            // rb_Count
            // 
            this.rb_Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_Count.AutoSize = true;
            this.rb_Count.BackColor = System.Drawing.Color.Transparent;
            this.rb_Count.Location = new System.Drawing.Point(441, 7);
            this.rb_Count.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Count.Name = "rb_Count";
            this.rb_Count.Size = new System.Drawing.Size(97, 24);
            this.rb_Count.TabIndex = 141;
            this.rb_Count.Text = "تعداد سپرده ها";
            this.rb_Count.UseVisualStyleBackColor = false;
            this.rb_Count.CheckedChanged += new System.EventHandler(this.rb_Count_CheckedChanged);
            // 
            // chart
            // 
            this.chart.AlwaysRecreateHotregions = true;
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
            series1.PaletteCustomColors = new System.Drawing.Color[0];
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
            this.splitContainer1.Size = new System.Drawing.Size(734, 450);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 145;
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cGroupBox1.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cGroupBox1.Controls.Add(this.tableLayoutPanel1);
            this.cGroupBox1.Controls.Add(this.label1);
            this.cGroupBox1.Controls.Add(this.btnShowReport);
            this.cGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cGroupBox1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cGroupBox1.Size = new System.Drawing.Size(734, 118);
            this.cGroupBox1.TabIndex = 52;
            this.cGroupBox1.Text = "تنظیمات گزارش گیری";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.65517F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.34483F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Controls.Add(this.rdbOneYear, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdbMultipleYears, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYearTo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYearFrom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYear, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(438, 24);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(284, 61);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(284, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 61);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // rdbOneYear
            // 
            this.rdbOneYear.AutoSize = true;
            this.rdbOneYear.Checked = true;
            this.rdbOneYear.Dock = System.Windows.Forms.DockStyle.Right;
            this.rdbOneYear.Location = new System.Drawing.Point(227, 3);
            this.rdbOneYear.Name = "rdbOneYear";
            this.rdbOneYear.Size = new System.Drawing.Size(54, 24);
            this.rdbOneYear.TabIndex = 1;
            this.rdbOneYear.TabStop = true;
            this.rdbOneYear.Text = "در سال";
            this.rdbOneYear.UseVisualStyleBackColor = true;
            this.rdbOneYear.CheckedChanged += new System.EventHandler(this.rdbOneYear_CheckedChanged);
            // 
            // rdbMultipleYears
            // 
            this.rdbMultipleYears.AutoSize = true;
            this.rdbMultipleYears.Dock = System.Windows.Forms.DockStyle.Right;
            this.rdbMultipleYears.Location = new System.Drawing.Point(227, 33);
            this.rdbMultipleYears.Name = "rdbMultipleYears";
            this.rdbMultipleYears.Size = new System.Drawing.Size(54, 25);
            this.rdbMultipleYears.TabIndex = 3;
            this.rdbMultipleYears.Text = "از سال";
            this.rdbMultipleYears.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label3.Location = new System.Drawing.Point(115, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "تا سال";
            // 
            // txtYearTo
            // 
            appearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            appearance2.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.txtYearTo.Appearance = appearance2;
            this.txtYearTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            this.txtYearTo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.txtYearTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYearTo.Enabled = false;
            this.txtYearTo.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtYearTo.Location = new System.Drawing.Point(3, 33);
            this.txtYearTo.MaskInput = "nnnn";
            this.txtYearTo.MaxValue = 2000;
            this.txtYearTo.MinValue = 1300;
            this.txtYearTo.Name = "txtYearTo";
            this.txtYearTo.Size = new System.Drawing.Size(106, 26);
            this.txtYearTo.SpinButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.txtYearTo.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.txtYearTo.SpinIncrement = 1;
            this.txtYearTo.TabIndex = 5;
            // 
            // txtYear
            // 
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            appearance3.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance3.ImageBackground")));
            appearance3.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.txtYear.Appearance = appearance3;
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            this.txtYear.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.txtYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYear.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtYear.Location = new System.Drawing.Point(167, 3);
            this.txtYear.MaskInput = "nnnn";
            this.txtYear.MaxValue = 2000;
            this.txtYear.MinValue = 1300;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(54, 26);
            this.txtYear.SpinButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.txtYear.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.txtYear.SpinIncrement = 1;
            this.txtYear.TabIndex = 2;
            // 
            // frmHistoricalDepositReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHistoricalDepositReport";
            this.Text = "گزارش تاریخی سپرده ها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtYearFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMReport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cGroupBox1)).EndInit();
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Utilize.Company.CButton btnShowReport;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor txtYearFrom;
        private Janus.Windows.UI.Tab.UITab tabMain;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private System.Windows.Forms.DataGridView dgvDMReport;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private System.Windows.Forms.RadioButton rb_Price;
        private System.Windows.Forms.RadioButton rb_Count;
        private Dundas.Charting.WinControl.Chart chart;
        private System.Windows.Forms.CheckedListBox chbSerries;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor txtYearTo;
        private System.Windows.Forms.RadioButton rdbMultipleYears;
        private System.Windows.Forms.RadioButton rdbOneYear;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor txtYear;
        private Utilize.Company.CGroupBox cGroupBox1;
        private System.Windows.Forms.ListBox lstYears;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbShowSequntial;
        private System.Windows.Forms.RadioButton rdbShowPartial;
    }
}