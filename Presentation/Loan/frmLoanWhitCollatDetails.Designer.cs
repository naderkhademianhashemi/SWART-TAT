using Utilize.Report;

namespace Presentation.Loan
{
    partial class frmLoanWhitCollatDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanWhitCollatDetails));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ugbSFiltering = new System.Windows.Forms.GroupBox();
            this.cbCloseAll = new Utilize.Company.CButton();
            this.tabMain = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.cGroupBox2 = new System.Windows.Forms.GroupBox();
            this.cGroupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fdpHistoricDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
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
            this.fdpFromStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.chbStartDate = new System.Windows.Forms.CheckBox();
            this.uiTabPage4 = new Janus.Windows.UI.Tab.UITabPage();
            this.chbCustCodeName = new System.Windows.Forms.CheckBox();
            this.cgbCustCodeName = new System.Windows.Forms.GroupBox();
            this.chbCounterparty = new System.Windows.Forms.RadioButton();
            this.txtCounterPartyName = new System.Windows.Forms.TextBox();
            this.chbCounterpartyName = new System.Windows.Forms.RadioButton();
            this.cgbCouterpartName = new System.Windows.Forms.GroupBox();
            this.rdbContains = new System.Windows.Forms.RadioButton();
            this.rdbStartsWith = new System.Windows.Forms.RadioButton();
            this.rdbEndsWith = new System.Windows.Forms.RadioButton();
            this.txtCounterpartyNameSearch = new System.Windows.Forms.TextBox();
            this.dgvCounterpartiesNames = new System.Windows.Forms.DataGridView();
            this.txtCounterparty = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCounterpartyNames = new System.Windows.Forms.TextBox();
            this.utpCollat = new Janus.Windows.UI.Tab.UITabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucSselectColumn = new Utilize.Report.SelectColumn();
            this.btnShowNormalReport = new Utilize.Company.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.ugbSFiltering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.cGroupBox1.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            this.pnlMaturityDate.SuspendLayout();
            this.pnlStartDate.SuspendLayout();
            this.uiTabPage4.SuspendLayout();
            this.cgbCustCodeName.SuspendLayout();
            this.cgbCouterpartName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ugbSFiltering);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(1045, 628);
            this.splitContainer2.SplitterDistance = 311;
            this.splitContainer2.TabIndex = 144;
            // 
            // ugbSFiltering
            // 
            this.ugbSFiltering.Controls.Add(this.cbCloseAll);
            this.ugbSFiltering.Controls.Add(this.tabMain);
            this.ugbSFiltering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ugbSFiltering.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ugbSFiltering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.ugbSFiltering.Location = new System.Drawing.Point(0, 0);
            this.ugbSFiltering.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ugbSFiltering.Name = "ugbSFiltering";
            this.ugbSFiltering.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ugbSFiltering.Size = new System.Drawing.Size(1045, 311);
            this.ugbSFiltering.TabIndex = 138;
            this.ugbSFiltering.TabStop = false;
            this.ugbSFiltering.Text = "تنظیمات فیلتر بندی";
            // 
            // cbCloseAll
            // 
            this.cbCloseAll.BackColor = System.Drawing.Color.Transparent;
            this.cbCloseAll.DefaultImage = null;
            this.cbCloseAll.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cbCloseAll.HoverImage = null;
            this.cbCloseAll.Location = new System.Drawing.Point(364, 23);
            this.cbCloseAll.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cbCloseAll.Name = "cbCloseAll";
            this.cbCloseAll.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCloseAll.Size = new System.Drawing.Size(103, 26);
            this.cbCloseAll.TabIndex = 145;
            this.cbCloseAll.Title = null;
            this.cbCloseAll.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbCloseAll_CButtonClicked);
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.tabMain.Location = new System.Drawing.Point(4, 29);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabMain.Size = new System.Drawing.Size(1037, 279);
            this.tabMain.TabIndex = 136;
            this.tabMain.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage3,
            this.uiTabPage4,
            this.utpCollat});
            this.tabMain.UseThemes = false;
            this.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.AutoScroll = true;
            this.uiTabPage2.Controls.Add(this.cGroupBox2);
            this.uiTabPage2.Controls.Add(this.cGroupBox1);
            this.uiTabPage2.Location = new System.Drawing.Point(2, 36);
            this.uiTabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage2.Size = new System.Drawing.Size(1033, 241);
            this.uiTabPage2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.PressedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.PressedFormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "اطلاعات زمانی/مکانی";
            // 
            // cGroupBox2
            // 
            this.cGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.cGroupBox2.Location = new System.Drawing.Point(0, 66);
            this.cGroupBox2.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.cGroupBox2.Name = "cGroupBox2";
            this.cGroupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cGroupBox2.Size = new System.Drawing.Size(1033, 168);
            this.cGroupBox2.TabIndex = 131;
            this.cGroupBox2.TabStop = false;
            this.cGroupBox2.Text = "اطلاعات شعب";
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.Controls.Add(this.label1);
            this.cGroupBox1.Controls.Add(this.fdpHistoricDate);
            this.cGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.cGroupBox1.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cGroupBox1.Size = new System.Drawing.Size(1033, 66);
            this.cGroupBox1.TabIndex = 130;
            this.cGroupBox1.TabStop = false;
            this.cGroupBox1.Text = "اطلاعات زمانی";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(968, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 27);
            this.label1.TabIndex = 129;
            this.label1.Text = "تاریخ";
            // 
            // fdpHistoricDate
            // 
            this.fdpHistoricDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpHistoricDate.Location = new System.Drawing.Point(761, 31);
            this.fdpHistoricDate.Name = "fdpHistoricDate";
            this.fdpHistoricDate.Size = new System.Drawing.Size(179, 20);
            this.fdpHistoricDate.TabIndex = 128;
            this.fdpHistoricDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.AutoScroll = true;
            this.uiTabPage3.Controls.Add(this.pnlMaturityDate);
            this.uiTabPage3.Controls.Add(this.pnlStartDate);
            this.uiTabPage3.Location = new System.Drawing.Point(2, 36);
            this.uiTabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage3.Size = new System.Drawing.Size(1033, 241);
            this.uiTabPage3.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "اطلاعات قرارداد";
            // 
            // pnlMaturityDate
            // 
            this.pnlMaturityDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.pnlMaturityDate.Controls.Add(this.label8);
            this.pnlMaturityDate.Controls.Add(this.fdpToMaturityDate);
            this.pnlMaturityDate.Controls.Add(this.label9);
            this.pnlMaturityDate.Controls.Add(this.fdpFromMaturityDate);
            this.pnlMaturityDate.Controls.Add(this.chbMaturityDate);
            this.pnlMaturityDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMaturityDate.Location = new System.Drawing.Point(0, 39);
            this.pnlMaturityDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMaturityDate.Name = "pnlMaturityDate";
            this.pnlMaturityDate.Size = new System.Drawing.Size(1033, 39);
            this.pnlMaturityDate.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 27);
            this.label8.TabIndex = 35;
            this.label8.Text = "تا";
            // 
            // fdpToMaturityDate
            // 
            this.fdpToMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpToMaturityDate.Enabled = false;
            this.fdpToMaturityDate.Location = new System.Drawing.Point(312, 7);
            this.fdpToMaturityDate.Name = "fdpToMaturityDate";
            this.fdpToMaturityDate.Size = new System.Drawing.Size(195, 24);
            this.fdpToMaturityDate.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(764, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 27);
            this.label9.TabIndex = 33;
            this.label9.Text = "از";
            // 
            // fdpFromMaturityDate
            // 
            this.fdpFromMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFromMaturityDate.Enabled = false;
            this.fdpFromMaturityDate.Location = new System.Drawing.Point(566, 8);
            this.fdpFromMaturityDate.Name = "fdpFromMaturityDate";
            this.fdpFromMaturityDate.Size = new System.Drawing.Size(195, 24);
            this.fdpFromMaturityDate.TabIndex = 32;
            // 
            // chbMaturityDate
            // 
            this.chbMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbMaturityDate.AutoSize = true;
            this.chbMaturityDate.Location = new System.Drawing.Point(852, 5);
            this.chbMaturityDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chbMaturityDate.Name = "chbMaturityDate";
            this.chbMaturityDate.Size = new System.Drawing.Size(175, 31);
            this.chbMaturityDate.TabIndex = 114;
            this.chbMaturityDate.Text = "تاریخ سررسید تسهیلات";
            this.chbMaturityDate.UseVisualStyleBackColor = true;
            this.chbMaturityDate.CheckedChanged += new System.EventHandler(this.chbMaturityDate_CheckedChanged);
            // 
            // pnlStartDate
            // 
            this.pnlStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.pnlStartDate.Controls.Add(this.label10);
            this.pnlStartDate.Controls.Add(this.fdpToStartDate);
            this.pnlStartDate.Controls.Add(this.label11);
            this.pnlStartDate.Controls.Add(this.fdpFromStartDate);
            this.pnlStartDate.Controls.Add(this.chbStartDate);
            this.pnlStartDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStartDate.Location = new System.Drawing.Point(0, 0);
            this.pnlStartDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlStartDate.Name = "pnlStartDate";
            this.pnlStartDate.Size = new System.Drawing.Size(1033, 39);
            this.pnlStartDate.TabIndex = 115;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(509, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 27);
            this.label10.TabIndex = 35;
            this.label10.Text = "تا";
            // 
            // fdpToStartDate
            // 
            this.fdpToStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpToStartDate.Enabled = false;
            this.fdpToStartDate.Location = new System.Drawing.Point(310, 6);
            this.fdpToStartDate.Name = "fdpToStartDate";
            this.fdpToStartDate.Size = new System.Drawing.Size(195, 24);
            this.fdpToStartDate.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(762, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 27);
            this.label11.TabIndex = 33;
            this.label11.Text = "از";
            // 
            // fdpFromStartDate
            // 
            this.fdpFromStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFromStartDate.Enabled = false;
            this.fdpFromStartDate.Location = new System.Drawing.Point(565, 7);
            this.fdpFromStartDate.Name = "fdpFromStartDate";
            this.fdpFromStartDate.Size = new System.Drawing.Size(195, 24);
            this.fdpFromStartDate.TabIndex = 32;
            // 
            // chbStartDate
            // 
            this.chbStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbStartDate.AutoSize = true;
            this.chbStartDate.Location = new System.Drawing.Point(855, 5);
            this.chbStartDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chbStartDate.Name = "chbStartDate";
            this.chbStartDate.Size = new System.Drawing.Size(171, 31);
            this.chbStartDate.TabIndex = 113;
            this.chbStartDate.Text = "تاریخ پرداخت تسهیلات";
            this.chbStartDate.UseVisualStyleBackColor = true;
            this.chbStartDate.CheckedChanged += new System.EventHandler(this.chbStartDate_CheckedChanged);
            // 
            // uiTabPage4
            // 
            this.uiTabPage4.AutoScroll = true;
            this.uiTabPage4.Controls.Add(this.chbCustCodeName);
            this.uiTabPage4.Controls.Add(this.cgbCustCodeName);
            this.uiTabPage4.Controls.Add(this.panel1);
            this.uiTabPage4.Controls.Add(this.txtCounterpartyNames);
            this.uiTabPage4.Location = new System.Drawing.Point(2, 36);
            this.uiTabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uiTabPage4.Name = "uiTabPage4";
            this.uiTabPage4.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage4.Size = new System.Drawing.Size(1033, 241);
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
            this.chbCustCodeName.Location = new System.Drawing.Point(854, 92);
            this.chbCustCodeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chbCustCodeName.Name = "chbCustCodeName";
            this.chbCustCodeName.Size = new System.Drawing.Size(145, 31);
            this.chbCustCodeName.TabIndex = 142;
            this.chbCustCodeName.Text = "شماره / نام مشتری";
            this.chbCustCodeName.UseVisualStyleBackColor = true;
            this.chbCustCodeName.CheckedChanged += new System.EventHandler(this.chbCustCodeName_CheckedChanged);
            // 
            // cgbCustCodeName
            // 
            this.cgbCustCodeName.Controls.Add(this.chbCounterparty);
            this.cgbCustCodeName.Controls.Add(this.txtCounterPartyName);
            this.cgbCustCodeName.Controls.Add(this.chbCounterpartyName);
            this.cgbCustCodeName.Controls.Add(this.cgbCouterpartName);
            this.cgbCustCodeName.Controls.Add(this.dgvCounterpartiesNames);
            this.cgbCustCodeName.Controls.Add(this.txtCounterparty);
            this.cgbCustCodeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.cgbCustCodeName.Enabled = false;
            this.cgbCustCodeName.Location = new System.Drawing.Point(0, 0);
            this.cgbCustCodeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cgbCustCodeName.Name = "cgbCustCodeName";
            this.cgbCustCodeName.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cgbCustCodeName.Size = new System.Drawing.Size(1012, 150);
            this.cgbCustCodeName.TabIndex = 143;
            this.cgbCustCodeName.TabStop = false;
            // 
            // chbCounterparty
            // 
            this.chbCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCounterparty.AutoSize = true;
            this.chbCounterparty.Location = new System.Drawing.Point(894, 24);
            this.chbCounterparty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbCounterparty.Name = "chbCounterparty";
            this.chbCounterparty.Size = new System.Drawing.Size(115, 31);
            this.chbCounterparty.TabIndex = 139;
            this.chbCounterparty.TabStop = true;
            this.chbCounterparty.Text = "شماره مشتری";
            this.chbCounterparty.UseVisualStyleBackColor = true;
            this.chbCounterparty.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtCounterPartyName
            // 
            this.txtCounterPartyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterPartyName.Location = new System.Drawing.Point(8, 23);
            this.txtCounterPartyName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCounterPartyName.Name = "txtCounterPartyName";
            this.txtCounterPartyName.ReadOnly = true;
            this.txtCounterPartyName.Size = new System.Drawing.Size(571, 33);
            this.txtCounterPartyName.TabIndex = 15;
            // 
            // chbCounterpartyName
            // 
            this.chbCounterpartyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCounterpartyName.AutoSize = true;
            this.chbCounterpartyName.Location = new System.Drawing.Point(915, 59);
            this.chbCounterpartyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbCounterpartyName.Name = "chbCounterpartyName";
            this.chbCounterpartyName.Size = new System.Drawing.Size(96, 31);
            this.chbCounterpartyName.TabIndex = 138;
            this.chbCounterpartyName.TabStop = true;
            this.chbCounterpartyName.Text = "نام مشتری";
            this.chbCounterpartyName.UseVisualStyleBackColor = true;
            this.chbCounterpartyName.CheckedChanged += new System.EventHandler(this.chbCounterpartyName_CheckedChanged);
            // 
            // cgbCouterpartName
            // 
            this.cgbCouterpartName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cgbCouterpartName.Controls.Add(this.rdbContains);
            this.cgbCouterpartName.Controls.Add(this.rdbStartsWith);
            this.cgbCouterpartName.Controls.Add(this.rdbEndsWith);
            this.cgbCouterpartName.Controls.Add(this.txtCounterpartyNameSearch);
            this.cgbCouterpartName.Location = new System.Drawing.Point(587, 55);
            this.cgbCouterpartName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cgbCouterpartName.Name = "cgbCouterpartName";
            this.cgbCouterpartName.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cgbCouterpartName.Size = new System.Drawing.Size(264, 69);
            this.cgbCouterpartName.TabIndex = 137;
            this.cgbCouterpartName.TabStop = false;
            // 
            // rdbContains
            // 
            this.rdbContains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbContains.AutoSize = true;
            this.rdbContains.Checked = true;
            this.rdbContains.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbContains.Location = new System.Drawing.Point(204, 43);
            this.rdbContains.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbContains.Name = "rdbContains";
            this.rdbContains.Size = new System.Drawing.Size(52, 24);
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
            this.rdbStartsWith.Location = new System.Drawing.Point(129, 43);
            this.rdbStartsWith.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbStartsWith.Name = "rdbStartsWith";
            this.rdbStartsWith.Size = new System.Drawing.Size(60, 24);
            this.rdbStartsWith.TabIndex = 132;
            this.rdbStartsWith.Text = "شروع با";
            this.rdbStartsWith.UseVisualStyleBackColor = true;
            // 
            // rdbEndsWith
            // 
            this.rdbEndsWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbEndsWith.AutoSize = true;
            this.rdbEndsWith.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbEndsWith.Location = new System.Drawing.Point(47, 43);
            this.rdbEndsWith.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbEndsWith.Name = "rdbEndsWith";
            this.rdbEndsWith.Size = new System.Drawing.Size(57, 24);
            this.rdbEndsWith.TabIndex = 132;
            this.rdbEndsWith.Text = "پایان با";
            this.rdbEndsWith.UseVisualStyleBackColor = true;
            // 
            // txtCounterpartyNameSearch
            // 
            this.txtCounterpartyNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterpartyNameSearch.Enabled = false;
            this.txtCounterpartyNameSearch.Location = new System.Drawing.Point(8, 9);
            this.txtCounterpartyNameSearch.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.txtCounterpartyNameSearch.Name = "txtCounterpartyNameSearch";
            this.txtCounterpartyNameSearch.Size = new System.Drawing.Size(245, 33);
            this.txtCounterpartyNameSearch.TabIndex = 14;
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
            this.dgvCounterpartiesNames.Location = new System.Drawing.Point(8, 58);
            this.dgvCounterpartiesNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCounterpartiesNames.Name = "dgvCounterpartiesNames";
            this.dgvCounterpartiesNames.ReadOnly = true;
            this.dgvCounterpartiesNames.RowHeadersWidth = 51;
            this.dgvCounterpartiesNames.RowTemplate.Height = 24;
            this.dgvCounterpartiesNames.Size = new System.Drawing.Size(572, 86);
            this.dgvCounterpartiesNames.TabIndex = 136;
            // 
            // txtCounterparty
            // 
            this.txtCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterparty.Enabled = false;
            this.txtCounterparty.Location = new System.Drawing.Point(595, 22);
            this.txtCounterparty.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.txtCounterparty.Name = "txtCounterparty";
            this.txtCounterparty.Size = new System.Drawing.Size(245, 33);
            this.txtCounterparty.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.panel1.Location = new System.Drawing.Point(253, 221);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 36);
            this.panel1.TabIndex = 131;
            this.panel1.Visible = false;
            // 
            // txtCounterpartyNames
            // 
            this.txtCounterpartyNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterpartyNames.Location = new System.Drawing.Point(384, 229);
            this.txtCounterpartyNames.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtCounterpartyNames.Name = "txtCounterpartyNames";
            this.txtCounterpartyNames.ReadOnly = true;
            this.txtCounterpartyNames.Size = new System.Drawing.Size(1, 33);
            this.txtCounterpartyNames.TabIndex = 144;
            this.txtCounterpartyNames.Visible = false;
            // 
            // utpCollat
            // 
            this.utpCollat.AutoScroll = true;
            this.utpCollat.Location = new System.Drawing.Point(2, 36);
            this.utpCollat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.utpCollat.Name = "utpCollat";
            this.utpCollat.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.utpCollat.Size = new System.Drawing.Size(1033, 241);
            this.utpCollat.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("utpCollat.StateStyles.FormatStyle.BackgroundImage")));
            this.utpCollat.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("utpCollat.StateStyles.HotFormatStyle.BackgroundImage")));
            this.utpCollat.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("utpCollat.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.utpCollat.TabStop = true;
            this.utpCollat.Text = "وثایق";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ucSselectColumn);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnShowNormalReport);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1045, 313);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 143;
            // 
            // ucSselectColumn
            // 
            this.ucSselectColumn.BackColor = System.Drawing.Color.Black;
            this.ucSselectColumn.DataSource = null;
            this.ucSselectColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSselectColumn.Font = new System.Drawing.Font("B Sorkhpust", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ucSselectColumn.Location = new System.Drawing.Point(0, 0);
            this.ucSselectColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucSselectColumn.Name = "ucSselectColumn";
            this.ucSselectColumn.NameOfDisplay = null;
            this.ucSselectColumn.NameOfValue = null;
            this.ucSselectColumn.Size = new System.Drawing.Size(1045, 280);
            this.ucSselectColumn.TabIndex = 141;
            this.ucSselectColumn.Title = null;
            // 
            // btnShowNormalReport
            // 
            this.btnShowNormalReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowNormalReport.AutoSize = true;
            this.btnShowNormalReport.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnShowNormalReport.DefaultImage")));
            this.btnShowNormalReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowNormalReport.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowNormalReport.HoverImage")));
            this.btnShowNormalReport.Location = new System.Drawing.Point(861, 4);
            this.btnShowNormalReport.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnShowNormalReport.Name = "btnShowNormalReport";
            this.btnShowNormalReport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowNormalReport.Size = new System.Drawing.Size(180, 34);
            this.btnShowNormalReport.TabIndex = 142;
            this.btnShowNormalReport.Title = null;
            this.btnShowNormalReport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnShowNormalReport_Click);
            this.btnShowNormalReport.Load += new System.EventHandler(this.btnShowNormalReport_Load);
            // 
            // frmLoanWhitCollatDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1045, 628);
            this.Controls.Add(this.splitContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmLoanWhitCollatDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارش تسهیلات به همراه جزئیات وثایق";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLoanWhitCollatDetails_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ugbSFiltering.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.uiTabPage3.ResumeLayout(false);
            this.pnlMaturityDate.ResumeLayout(false);
            this.pnlMaturityDate.PerformLayout();
            this.pnlStartDate.ResumeLayout(false);
            this.pnlStartDate.PerformLayout();
            this.uiTabPage4.ResumeLayout(false);
            this.uiTabPage4.PerformLayout();
            this.cgbCustCodeName.ResumeLayout(false);
            this.cgbCustCodeName.PerformLayout();
            this.cgbCouterpartName.ResumeLayout(false);
            this.cgbCouterpartName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ugbSFiltering;
        private Utilize.Report.SelectColumn ucSselectColumn;
        private Utilize.Company.CButton btnShowNormalReport;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Janus.Windows.UI.Tab.UITab tabMain;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private UCFiltering ucfOrganization;
        private UCFiltering ucfState;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private UCFiltering ucEconomicSector;
        private UCFiltering ucContractStatus;
        private System.Windows.Forms.Panel pnlMaturityDate;
        private System.Windows.Forms.Label label8;
        private FarsiLibrary.Win.Controls.FADatePicker fdpToMaturityDate;
        private System.Windows.Forms.Label label9;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFromMaturityDate;
        private System.Windows.Forms.CheckBox chbMaturityDate;
        private System.Windows.Forms.Panel pnlStartDate;
        private System.Windows.Forms.Label label10;
        private FarsiLibrary.Win.Controls.FADatePicker fdpToStartDate;
        private System.Windows.Forms.Label label11;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFromStartDate;
        private System.Windows.Forms.CheckBox chbStartDate;
        private UCFiltering ucFilteringContractTypeCode;
        private UCFiltering ucfContractType;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage4;
        private System.Windows.Forms.CheckBox chbCustCodeName;
        private System.Windows.Forms.GroupBox cgbCustCodeName;
        private System.Windows.Forms.RadioButton chbCounterparty;
        private System.Windows.Forms.TextBox txtCounterPartyName;
        private System.Windows.Forms.RadioButton chbCounterpartyName;
        private System.Windows.Forms.GroupBox cgbCouterpartName;
        private System.Windows.Forms.RadioButton rdbContains;
        private System.Windows.Forms.RadioButton rdbStartsWith;
        private System.Windows.Forms.RadioButton rdbEndsWith;
        private System.Windows.Forms.DataGridView dgvCounterpartiesNames;
        private System.Windows.Forms.Panel panel1;
        private UCFiltering ucfCounterPartyType;
        private UCFiltering ucfCustomerGroup;
        private System.Windows.Forms.TextBox txtCounterpartyNames;
        private Janus.Windows.UI.Tab.UITabPage utpCollat;
        private UCFiltering ucfCollateralStatus;
        private UCFiltering ucfCollateralType;
        private UCFiltering ucfCollatMajorType;
        private System.Windows.Forms.GroupBox cGroupBox2;
        private System.Windows.Forms.GroupBox cGroupBox1;
        private FarsiLibrary.Win.Controls.FADatePicker fdpHistoricDate;
        private System.Windows.Forms.Label label1;
        private UCFiltering ucfCity;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Utilize.Company.CButton cbCloseAll;
        private System.Windows.Forms.TextBox txtCounterparty;
        private System.Windows.Forms.TextBox txtCounterpartyNameSearch;
    }
}