namespace Presentation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Infragistics.Win.UltraWinEditors.EditorButton editorButton1 = new Infragistics.Win.UltraWinEditors.EditorButton("Search");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton2 = new Infragistics.Win.UltraWinEditors.EditorButton("Search");
            this.tabMain = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.ucfOrganization = new Utilize.Report.UCFiltering();
            this.ucfState = new Utilize.Report.UCFiltering();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
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
            this.fdpFromStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.chbStartDate = new System.Windows.Forms.CheckBox();
            this.ucFilteringContractTypeCode = new Utilize.Report.UCFiltering();
            this.ucfContractType = new Utilize.Report.UCFiltering();
            this.uiTabPage4 = new Janus.Windows.UI.Tab.UITabPage();
            this.chbCustCodeName = new System.Windows.Forms.CheckBox();
            this.cgbCustCodeName = new Utilize.Company.CGroupBox();
            this.txtCounterparty = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.chbCounterparty = new System.Windows.Forms.RadioButton();
            this.txtCounterPartyName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.chbCounterpartyName = new System.Windows.Forms.RadioButton();
            this.cgbCouterpartName = new Utilize.Company.CGroupBox();
            this.txtCounterpartyNameSearch = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.rdbContains = new System.Windows.Forms.RadioButton();
            this.rdbStartsWith = new System.Windows.Forms.RadioButton();
            this.rdbEndsWith = new System.Windows.Forms.RadioButton();
            this.dgvCounterpartiesNames = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucfCounterPartyType = new Utilize.Report.UCFiltering();
            this.ucfCustomerGroup = new Utilize.Report.UCFiltering();
            this.txtCounterpartyNames = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utpCollat = new Janus.Windows.UI.Tab.UITabPage();
            this.ucfCollateralStatus = new Utilize.Report.UCFiltering();
            this.ucfCollateralType = new Utilize.Report.UCFiltering();
            this.ucfCollatMajorType = new Utilize.Report.UCFiltering();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            this.pnlMaturityDate.SuspendLayout();
            this.pnlStartDate.SuspendLayout();
            this.uiTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCustCodeName)).BeginInit();
            this.cgbCustCodeName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterparty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterPartyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCouterpartName)).BeginInit();
            this.cgbCouterpartName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNameSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNames)).BeginInit();
            this.utpCollat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabMain.Size = new System.Drawing.Size(652, 485);
            this.tabMain.TabIndex = 135;
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
            this.uiTabPage2.Controls.Add(this.ucfOrganization);
            this.uiTabPage2.Controls.Add(this.ucfState);
            this.uiTabPage2.Location = new System.Drawing.Point(2, 36);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage2.Size = new System.Drawing.Size(648, 447);
            this.uiTabPage2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.PressedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.PressedFormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "اطلاعات شعبه";
            // 
            // ucfOrganization
            // 
            this.ucfOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucfOrganization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.ucfOrganization.DataSource = null;
            this.ucfOrganization.DisplayMember = null;
            this.ucfOrganization.EnableShowClearSelectedItem = true;
            this.ucfOrganization.EnableShowSelectedItem = true;
            this.ucfOrganization.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfOrganization.IsPersian = false;
            this.ucfOrganization.Location = new System.Drawing.Point(3, 46);
            this.ucfOrganization.Name = "ucfOrganization";
            this.ucfOrganization.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfOrganization.Size = new System.Drawing.Size(642, 37);
            this.ucfOrganization.TabIndex = 126;
            this.ucfOrganization.Title = "شعبه";
            this.ucfOrganization.ValueMember = null;
            // 
            // ucfState
            // 
            this.ucfState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucfState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.ucfState.DataSource = null;
            this.ucfState.DisplayMember = null;
            this.ucfState.EnableShowClearSelectedItem = true;
            this.ucfState.EnableShowSelectedItem = true;
            this.ucfState.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfState.IsPersian = false;
            this.ucfState.Location = new System.Drawing.Point(3, 3);
            this.ucfState.Name = "ucfState";
            this.ucfState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfState.Size = new System.Drawing.Size(642, 37);
            this.ucfState.TabIndex = 125;
            this.ucfState.Title = "استان";
            this.ucfState.ValueMember = null;
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.AutoScroll = true;
            this.uiTabPage3.Controls.Add(this.ucEconomicSector);
            this.uiTabPage3.Controls.Add(this.ucContractStatus);
            this.uiTabPage3.Controls.Add(this.pnlMaturityDate);
            this.uiTabPage3.Controls.Add(this.pnlStartDate);
            this.uiTabPage3.Controls.Add(this.ucFilteringContractTypeCode);
            this.uiTabPage3.Controls.Add(this.ucfContractType);
            this.uiTabPage3.Location = new System.Drawing.Point(2, 36);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage3.Size = new System.Drawing.Size(648, 447);
            this.uiTabPage3.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "اطلاعات قرارداد";
            // 
            // ucEconomicSector
            // 
            this.ucEconomicSector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.ucEconomicSector.DataSource = null;
            this.ucEconomicSector.DisplayMember = null;
            this.ucEconomicSector.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucEconomicSector.EnableShowClearSelectedItem = true;
            this.ucEconomicSector.EnableShowSelectedItem = true;
            this.ucEconomicSector.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEconomicSector.IsPersian = false;
            this.ucEconomicSector.Location = new System.Drawing.Point(0, 224);
            this.ucEconomicSector.Name = "ucEconomicSector";
            this.ucEconomicSector.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucEconomicSector.Size = new System.Drawing.Size(648, 46);
            this.ucEconomicSector.TabIndex = 133;
            this.ucEconomicSector.Title = "بخش اقتصادی";
            this.ucEconomicSector.ValueMember = null;
            // 
            // ucContractStatus
            // 
            this.ucContractStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.ucContractStatus.DataSource = null;
            this.ucContractStatus.DisplayMember = null;
            this.ucContractStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucContractStatus.EnableShowClearSelectedItem = true;
            this.ucContractStatus.EnableShowSelectedItem = true;
            this.ucContractStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucContractStatus.IsPersian = false;
            this.ucContractStatus.Location = new System.Drawing.Point(0, 179);
            this.ucContractStatus.Name = "ucContractStatus";
            this.ucContractStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucContractStatus.Size = new System.Drawing.Size(648, 45);
            this.ucContractStatus.TabIndex = 132;
            this.ucContractStatus.Title = "وضعیت قرارداد";
            this.ucContractStatus.ValueMember = null;
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
            this.pnlMaturityDate.Location = new System.Drawing.Point(0, 138);
            this.pnlMaturityDate.Name = "pnlMaturityDate";
            this.pnlMaturityDate.Size = new System.Drawing.Size(648, 41);
            this.pnlMaturityDate.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 27);
            this.label8.TabIndex = 35;
            this.label8.Text = "تا";
            // 
            // fdpToMaturityDate
            // 
            this.fdpToMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpToMaturityDate.Enabled = false;
            this.fdpToMaturityDate.Location = new System.Drawing.Point(107, 7);
            this.fdpToMaturityDate.Name = "fdpToMaturityDate";
            this.fdpToMaturityDate.Size = new System.Drawing.Size(146, 25);
            this.fdpToMaturityDate.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 27);
            this.label9.TabIndex = 33;
            this.label9.Text = "از";
            // 
            // fdpFromMaturityDate
            // 
            this.fdpFromMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFromMaturityDate.Enabled = false;
            this.fdpFromMaturityDate.Location = new System.Drawing.Point(298, 9);
            this.fdpFromMaturityDate.Name = "fdpFromMaturityDate";
            this.fdpFromMaturityDate.Size = new System.Drawing.Size(146, 25);
            this.fdpFromMaturityDate.TabIndex = 32;
            // 
            // chbMaturityDate
            // 
            this.chbMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbMaturityDate.AutoSize = true;
            this.chbMaturityDate.Location = new System.Drawing.Point(523, 5);
            this.chbMaturityDate.Name = "chbMaturityDate";
            this.chbMaturityDate.Size = new System.Drawing.Size(121, 31);
            this.chbMaturityDate.TabIndex = 114;
            this.chbMaturityDate.Text = "تاریخ سر رسید";
            this.chbMaturityDate.UseVisualStyleBackColor = true;
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
            this.pnlStartDate.Location = new System.Drawing.Point(0, 97);
            this.pnlStartDate.Name = "pnlStartDate";
            this.pnlStartDate.Size = new System.Drawing.Size(648, 41);
            this.pnlStartDate.TabIndex = 115;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 27);
            this.label10.TabIndex = 35;
            this.label10.Text = "تا";
            // 
            // fdpToStartDate
            // 
            this.fdpToStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpToStartDate.Enabled = false;
            this.fdpToStartDate.Location = new System.Drawing.Point(106, 6);
            this.fdpToStartDate.Name = "fdpToStartDate";
            this.fdpToStartDate.Size = new System.Drawing.Size(146, 25);
            this.fdpToStartDate.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 27);
            this.label11.TabIndex = 33;
            this.label11.Text = "از";
            // 
            // fdpFromStartDate
            // 
            this.fdpFromStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFromStartDate.Enabled = false;
            this.fdpFromStartDate.Location = new System.Drawing.Point(297, 7);
            this.fdpFromStartDate.Name = "fdpFromStartDate";
            this.fdpFromStartDate.Size = new System.Drawing.Size(146, 25);
            this.fdpFromStartDate.TabIndex = 32;
            // 
            // chbStartDate
            // 
            this.chbStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbStartDate.AutoSize = true;
            this.chbStartDate.Location = new System.Drawing.Point(472, 5);
            this.chbStartDate.Name = "chbStartDate";
            this.chbStartDate.Size = new System.Drawing.Size(171, 31);
            this.chbStartDate.TabIndex = 113;
            this.chbStartDate.Text = "تاریخ پرداخت تسهیلات";
            this.chbStartDate.UseVisualStyleBackColor = true;
            // 
            // ucFilteringContractTypeCode
            // 
            this.ucFilteringContractTypeCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.ucFilteringContractTypeCode.DataSource = null;
            this.ucFilteringContractTypeCode.DisplayMember = null;
            this.ucFilteringContractTypeCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFilteringContractTypeCode.EnableShowClearSelectedItem = true;
            this.ucFilteringContractTypeCode.EnableShowSelectedItem = true;
            this.ucFilteringContractTypeCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucFilteringContractTypeCode.IsPersian = false;
            this.ucFilteringContractTypeCode.Location = new System.Drawing.Point(0, 48);
            this.ucFilteringContractTypeCode.Name = "ucFilteringContractTypeCode";
            this.ucFilteringContractTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucFilteringContractTypeCode.Size = new System.Drawing.Size(648, 49);
            this.ucFilteringContractTypeCode.TabIndex = 131;
            this.ucFilteringContractTypeCode.Title = "نوع قرارداد";
            this.ucFilteringContractTypeCode.ValueMember = null;
            // 
            // ucfContractType
            // 
            this.ucfContractType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.ucfContractType.DataSource = null;
            this.ucfContractType.DisplayMember = null;
            this.ucfContractType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucfContractType.EnableShowClearSelectedItem = true;
            this.ucfContractType.EnableShowSelectedItem = true;
            this.ucfContractType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfContractType.IsPersian = false;
            this.ucfContractType.Location = new System.Drawing.Point(0, 0);
            this.ucfContractType.Name = "ucfContractType";
            this.ucfContractType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfContractType.Size = new System.Drawing.Size(648, 48);
            this.ucfContractType.TabIndex = 127;
            this.ucfContractType.Title = "نوع اصلی قرار داد";
            this.ucfContractType.ValueMember = null;
            // 
            // uiTabPage4
            // 
            this.uiTabPage4.AutoScroll = true;
            this.uiTabPage4.Controls.Add(this.chbCustCodeName);
            this.uiTabPage4.Controls.Add(this.cgbCustCodeName);
            this.uiTabPage4.Controls.Add(this.panel1);
            this.uiTabPage4.Controls.Add(this.ucfCounterPartyType);
            this.uiTabPage4.Controls.Add(this.ucfCustomerGroup);
            this.uiTabPage4.Controls.Add(this.txtCounterpartyNames);
            this.uiTabPage4.Location = new System.Drawing.Point(2, 36);
            this.uiTabPage4.Name = "uiTabPage4";
            this.uiTabPage4.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage4.Size = new System.Drawing.Size(648, 447);
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
            this.chbCustCodeName.Location = new System.Drawing.Point(521, 103);
            this.chbCustCodeName.Name = "chbCustCodeName";
            this.chbCustCodeName.Size = new System.Drawing.Size(125, 31);
            this.chbCustCodeName.TabIndex = 142;
            this.chbCustCodeName.Text = "کد / نام مشتری";
            this.chbCustCodeName.UseVisualStyleBackColor = true;
            // 
            // cgbCustCodeName
            // 
            this.cgbCustCodeName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbCustCodeName.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbCustCodeName.Controls.Add(this.txtCounterparty);
            this.cgbCustCodeName.Controls.Add(this.chbCounterparty);
            this.cgbCustCodeName.Controls.Add(this.txtCounterPartyName);
            this.cgbCustCodeName.Controls.Add(this.chbCounterpartyName);
            this.cgbCustCodeName.Controls.Add(this.cgbCouterpartName);
            this.cgbCustCodeName.Controls.Add(this.dgvCounterpartiesNames);
            this.cgbCustCodeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cgbCustCodeName.Enabled = false;
            this.cgbCustCodeName.Location = new System.Drawing.Point(0, 114);
            this.cgbCustCodeName.Name = "cgbCustCodeName";
            this.cgbCustCodeName.Size = new System.Drawing.Size(648, 333);
            this.cgbCustCodeName.TabIndex = 143;
            // 
            // txtCounterparty
            // 
            this.txtCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            editorButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button;
            editorButton1.Key = "Search";
            editorButton1.Text = "جستجو";
            this.txtCounterparty.ButtonsLeft.Add(editorButton1);
            this.txtCounterparty.Enabled = false;
            this.txtCounterparty.Location = new System.Drawing.Point(356, 23);
            this.txtCounterparty.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtCounterparty.Name = "txtCounterparty";
            this.txtCounterparty.Size = new System.Drawing.Size(185, 35);
            this.txtCounterparty.TabIndex = 14;
            // 
            // chbCounterparty
            // 
            this.chbCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCounterparty.AutoSize = true;
            this.chbCounterparty.Location = new System.Drawing.Point(551, 25);
            this.chbCounterparty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbCounterparty.Name = "chbCounterparty";
            this.chbCounterparty.Size = new System.Drawing.Size(95, 31);
            this.chbCounterparty.TabIndex = 139;
            this.chbCounterparty.TabStop = true;
            this.chbCounterparty.Text = "کد مشتری";
            this.chbCounterparty.UseVisualStyleBackColor = true;
            // 
            // txtCounterPartyName
            // 
            this.txtCounterPartyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor = System.Drawing.Color.White;
            appearance1.BackColor2 = System.Drawing.Color.White;
            this.txtCounterPartyName.Appearance = appearance1;
            this.txtCounterPartyName.BackColor = System.Drawing.Color.White;
            this.txtCounterPartyName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.txtCounterPartyName.Location = new System.Drawing.Point(6, 24);
            this.txtCounterPartyName.Name = "txtCounterPartyName";
            this.txtCounterPartyName.ReadOnly = true;
            this.txtCounterPartyName.Size = new System.Drawing.Size(338, 35);
            this.txtCounterPartyName.TabIndex = 15;
            // 
            // chbCounterpartyName
            // 
            this.chbCounterpartyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCounterpartyName.AutoSize = true;
            this.chbCounterpartyName.Location = new System.Drawing.Point(551, 63);
            this.chbCounterpartyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbCounterpartyName.Name = "chbCounterpartyName";
            this.chbCounterpartyName.Size = new System.Drawing.Size(96, 31);
            this.chbCounterpartyName.TabIndex = 138;
            this.chbCounterpartyName.TabStop = true;
            this.chbCounterpartyName.Text = "نام مشتری";
            this.chbCounterpartyName.UseVisualStyleBackColor = true;
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
            this.cgbCouterpartName.Location = new System.Drawing.Point(350, 58);
            this.cgbCouterpartName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cgbCouterpartName.Name = "cgbCouterpartName";
            this.cgbCouterpartName.Size = new System.Drawing.Size(198, 73);
            this.cgbCouterpartName.TabIndex = 137;
            // 
            // txtCounterpartyNameSearch
            // 
            this.txtCounterpartyNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            editorButton2.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button;
            editorButton2.Key = "Search";
            editorButton2.Text = "جستجو";
            this.txtCounterpartyNameSearch.ButtonsLeft.Add(editorButton2);
            this.txtCounterpartyNameSearch.Enabled = false;
            this.txtCounterpartyNameSearch.Location = new System.Drawing.Point(6, 10);
            this.txtCounterpartyNameSearch.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtCounterpartyNameSearch.Name = "txtCounterpartyNameSearch";
            this.txtCounterpartyNameSearch.Size = new System.Drawing.Size(185, 35);
            this.txtCounterpartyNameSearch.TabIndex = 14;
            // 
            // rdbContains
            // 
            this.rdbContains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbContains.AutoSize = true;
            this.rdbContains.Checked = true;
            this.rdbContains.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbContains.Location = new System.Drawing.Point(138, 46);
            this.rdbContains.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbContains.Name = "rdbContains";
            this.rdbContains.Size = new System.Drawing.Size(54, 25);
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
            this.rdbStartsWith.Location = new System.Drawing.Point(80, 46);
            this.rdbStartsWith.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbStartsWith.Name = "rdbStartsWith";
            this.rdbStartsWith.Size = new System.Drawing.Size(62, 25);
            this.rdbStartsWith.TabIndex = 132;
            this.rdbStartsWith.Text = "شروع با";
            this.rdbStartsWith.UseVisualStyleBackColor = true;
            // 
            // rdbEndsWith
            // 
            this.rdbEndsWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbEndsWith.AutoSize = true;
            this.rdbEndsWith.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbEndsWith.Location = new System.Drawing.Point(19, 46);
            this.rdbEndsWith.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbEndsWith.Name = "rdbEndsWith";
            this.rdbEndsWith.Size = new System.Drawing.Size(59, 25);
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
            this.dgvCounterpartiesNames.Location = new System.Drawing.Point(6, 62);
            this.dgvCounterpartiesNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCounterpartiesNames.Name = "dgvCounterpartiesNames";
            this.dgvCounterpartiesNames.RowTemplate.Height = 24;
            this.dgvCounterpartiesNames.Size = new System.Drawing.Size(338, 265);
            this.dgvCounterpartiesNames.TabIndex = 136;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.panel1.Location = new System.Drawing.Point(190, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 38);
            this.panel1.TabIndex = 131;
            this.panel1.Visible = false;
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
            this.ucfCounterPartyType.Location = new System.Drawing.Point(0, 49);
            this.ucfCounterPartyType.Name = "ucfCounterPartyType";
            this.ucfCounterPartyType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCounterPartyType.Size = new System.Drawing.Size(648, 65);
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
            this.ucfCustomerGroup.Name = "ucfCustomerGroup";
            this.ucfCustomerGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCustomerGroup.Size = new System.Drawing.Size(648, 49);
            this.ucfCustomerGroup.TabIndex = 130;
            this.ucfCustomerGroup.Title = "گروه مشتری";
            this.ucfCustomerGroup.ValueMember = null;
            // 
            // txtCounterpartyNames
            // 
            this.txtCounterpartyNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterpartyNames.Location = new System.Drawing.Point(288, 243);
            this.txtCounterpartyNames.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtCounterpartyNames.Name = "txtCounterpartyNames";
            this.txtCounterpartyNames.ReadOnly = true;
            this.txtCounterpartyNames.Size = new System.Drawing.Size(90, 35);
            this.txtCounterpartyNames.TabIndex = 144;
            this.txtCounterpartyNames.Visible = false;
            // 
            // utpCollat
            // 
            this.utpCollat.AutoScroll = true;
            this.utpCollat.Controls.Add(this.ucfCollateralStatus);
            this.utpCollat.Controls.Add(this.ucfCollateralType);
            this.utpCollat.Controls.Add(this.ucfCollatMajorType);
            this.utpCollat.Location = new System.Drawing.Point(2, 36);
            this.utpCollat.Name = "utpCollat";
            this.utpCollat.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.utpCollat.Size = new System.Drawing.Size(648, 447);
            this.utpCollat.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("utpCollat.StateStyles.FormatStyle.BackgroundImage")));
            this.utpCollat.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("utpCollat.StateStyles.HotFormatStyle.BackgroundImage")));
            this.utpCollat.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("utpCollat.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.utpCollat.TabStop = true;
            this.utpCollat.Text = "وثایق";
            // 
            // ucfCollateralStatus
            // 
            this.ucfCollateralStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucfCollateralStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.ucfCollateralStatus.DataSource = null;
            this.ucfCollateralStatus.DisplayMember = null;
            this.ucfCollateralStatus.EnableShowClearSelectedItem = true;
            this.ucfCollateralStatus.EnableShowSelectedItem = true;
            this.ucfCollateralStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfCollateralStatus.IsPersian = false;
            this.ucfCollateralStatus.Location = new System.Drawing.Point(3, 89);
            this.ucfCollateralStatus.Name = "ucfCollateralStatus";
            this.ucfCollateralStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCollateralStatus.Size = new System.Drawing.Size(642, 37);
            this.ucfCollateralStatus.TabIndex = 128;
            this.ucfCollateralStatus.Title = "وضعیت وثیقه";
            this.ucfCollateralStatus.ValueMember = null;
            // 
            // ucfCollateralType
            // 
            this.ucfCollateralType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucfCollateralType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.ucfCollateralType.DataSource = null;
            this.ucfCollateralType.DisplayMember = null;
            this.ucfCollateralType.EnableShowClearSelectedItem = true;
            this.ucfCollateralType.EnableShowSelectedItem = true;
            this.ucfCollateralType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfCollateralType.IsPersian = false;
            this.ucfCollateralType.Location = new System.Drawing.Point(3, 46);
            this.ucfCollateralType.Name = "ucfCollateralType";
            this.ucfCollateralType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCollateralType.Size = new System.Drawing.Size(642, 37);
            this.ucfCollateralType.TabIndex = 127;
            this.ucfCollateralType.Title = "نوع وثیقه";
            this.ucfCollateralType.ValueMember = null;
            // 
            // ucfCollatMajorType
            // 
            this.ucfCollatMajorType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucfCollatMajorType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.ucfCollatMajorType.DataSource = null;
            this.ucfCollatMajorType.DisplayMember = null;
            this.ucfCollatMajorType.EnableShowClearSelectedItem = true;
            this.ucfCollatMajorType.EnableShowSelectedItem = true;
            this.ucfCollatMajorType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfCollatMajorType.IsPersian = false;
            this.ucfCollatMajorType.Location = new System.Drawing.Point(3, 3);
            this.ucfCollatMajorType.Name = "ucfCollatMajorType";
            this.ucfCollatMajorType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfCollatMajorType.Size = new System.Drawing.Size(642, 37);
            this.ucfCollatMajorType.TabIndex = 126;
            this.ucfCollatMajorType.Title = "نوع اصلی وثیقه";
            this.ucfCollatMajorType.ValueMember = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 485);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterparty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterPartyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCouterpartName)).EndInit();
            this.cgbCouterpartName.ResumeLayout(false);
            this.cgbCouterpartName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNameSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNames)).EndInit();
            this.utpCollat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab tabMain;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Utilize.Report.UCFiltering ucfOrganization;
        private Utilize.Report.UCFiltering ucfState;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private Utilize.Report.UCFiltering ucEconomicSector;
        private Utilize.Report.UCFiltering ucContractStatus;
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
        private Utilize.Report.UCFiltering ucFilteringContractTypeCode;
        private Utilize.Report.UCFiltering ucfContractType;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage4;
        private System.Windows.Forms.CheckBox chbCustCodeName;
        private Utilize.Company.CGroupBox cgbCustCodeName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterparty;
        private System.Windows.Forms.RadioButton chbCounterparty;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterPartyName;
        private System.Windows.Forms.RadioButton chbCounterpartyName;
        private Utilize.Company.CGroupBox cgbCouterpartName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterpartyNameSearch;
        private System.Windows.Forms.RadioButton rdbContains;
        private System.Windows.Forms.RadioButton rdbStartsWith;
        private System.Windows.Forms.RadioButton rdbEndsWith;
        private System.Windows.Forms.DataGridView dgvCounterpartiesNames;
        private System.Windows.Forms.Panel panel1;
        private Utilize.Report.UCFiltering ucfCounterPartyType;
        private Utilize.Report.UCFiltering ucfCustomerGroup;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterpartyNames;
        private Janus.Windows.UI.Tab.UITabPage utpCollat;
        private Utilize.Report.UCFiltering ucfCollateralStatus;
        private Utilize.Report.UCFiltering ucfCollateralType;
        private Utilize.Report.UCFiltering ucfCollatMajorType;
    }
}