namespace Presentation.Capital_Adequacy
{
    partial class frmMarketRiskAsset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarketRiskAsset));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbConfirm = new Utilize.Company.CButton();
            this.cbStart = new Utilize.Company.CButton();
            this.label1 = new System.Windows.Forms.Label();
            this.fdpDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.tabMain = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPortfolio = new Utilize.Company.CComboCox();
            this.dgvRisk = new System.Windows.Forms.DataGridView();
            this.uiTabPage5 = new Janus.Windows.UI.Tab.UITabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFSM = new Utilize.Company.CComboCox();
            this.dgvArz = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPortfolio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisk)).BeginInit();
            this.uiTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFSM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArz)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbConfirm);
            this.splitContainer1.Panel1.Controls.Add(this.cbStart);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.fdpDate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
            this.splitContainer1.Size = new System.Drawing.Size(918, 497);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbConfirm
            // 
            this.cbConfirm.DefaultImage = global::Presentation.Properties.Resources.S_But100px;
            this.cbConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbConfirm.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbConfirm.ForeColor = System.Drawing.Color.Black;
            this.cbConfirm.HoverImage = global::Presentation.Properties.Resources.S_But100px_Hover;
            this.cbConfirm.Location = new System.Drawing.Point(15, 19);
            this.cbConfirm.Margin = new System.Windows.Forms.Padding(15, 21, 15, 21);
            this.cbConfirm.Name = "cbConfirm";
            this.cbConfirm.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbConfirm.Size = new System.Drawing.Size(111, 40);
            this.cbConfirm.TabIndex = 156;
            this.cbConfirm.Title = "ذخیره مجموع مبالغ";
            this.cbConfirm.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbConfirm_CButtonClicked);
            // 
            // cbStart
            // 
            this.cbStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStart.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbStart.DefaultImage")));
            this.cbStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbStart.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbStart.HoverImage")));
            this.cbStart.Location = new System.Drawing.Point(639, 19);
            this.cbStart.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.cbStart.Name = "cbStart";
            this.cbStart.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbStart.Size = new System.Drawing.Size(83, 40);
            this.cbStart.TabIndex = 155;
            this.cbStart.Title = "";
            this.cbStart.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbStart_CButtonClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(874, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 154;
            this.label1.Text = "تاریخ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fdpDate
            // 
            this.fdpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpDate.Font = null;
            this.fdpDate.IsDefault = true;
            this.fdpDate.Location = new System.Drawing.Point(733, 25);
            this.fdpDate.Name = "fdpDate";
            this.fdpDate.Size = new System.Drawing.Size(130, 27);
            this.fdpDate.TabIndex = 153;
            this.fdpDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Enabled = false;
            this.tabMain.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 32, 4, 32);
            this.tabMain.Name = "tabMain";
            this.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabMain.Size = new System.Drawing.Size(918, 414);
            this.tabMain.TabIndex = 143;
            this.tabMain.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage5});
            this.tabMain.TabsStateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabMain.TabsStateStyles.FormatStyle.BackgroundImage")));
            this.tabMain.TabStripFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.UseThemes = false;
            this.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.splitContainer2);
            this.uiTabPage1.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.uiTabPage1.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(914, 383);
            this.uiTabPage1.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage1.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage1.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage1.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "2-17";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.cmbPortfolio);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvRisk);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(914, 383);
            this.splitContainer2.SplitterDistance = 83;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(823, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 150;
            this.label3.Text = "انتخاب پرتفوی";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(689, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 24);
            this.label2.TabIndex = 149;
            this.label2.Text = "سرمایه مورد نیاز برای پوشش ریسک عام";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPortfolio
            // 
            this.cmbPortfolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            appearance1.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbPortfolio.Appearance = appearance1;
            this.cmbPortfolio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbPortfolio.AutoSize = false;
            this.cmbPortfolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            appearance2.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbPortfolio.ButtonAppearance = appearance2;
            this.cmbPortfolio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbPortfolio.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbPortfolio.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.DiagonalResize;
            this.cmbPortfolio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbPortfolio.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbPortfolio.HideSelection = false;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbPortfolio.ItemAppearance = appearance3;
            this.cmbPortfolio.Location = new System.Drawing.Point(628, 44);
            this.cmbPortfolio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPortfolio.Name = "cmbFSM";
            this.cmbPortfolio.Size = new System.Drawing.Size(187, 26);
            this.cmbPortfolio.TabIndex = 0;
            this.cmbPortfolio.SelectionChanged += new System.EventHandler(this.cmbPortfolio_SelectionChanged);
            // 
            // dgvRisk
            // 
            this.dgvRisk.AllowUserToAddRows = false;
            this.dgvRisk.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 9.75F);
            this.dgvRisk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRisk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRisk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(228)))));
            this.dgvRisk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRisk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRisk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRisk.EnableHeadersVisualStyles = false;
            this.dgvRisk.Location = new System.Drawing.Point(0, 0);
            this.dgvRisk.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRisk.MultiSelect = false;
            this.dgvRisk.Name = "dgvRisk";
            this.dgvRisk.ReadOnly = true;
            this.dgvRisk.RowHeadersVisible = false;
            this.dgvRisk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRisk.Size = new System.Drawing.Size(914, 295);
            this.dgvRisk.TabIndex = 9;
            this.dgvRisk.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRisk_CellEndEdit);
            // 
            // uiTabPage5
            // 
            this.uiTabPage5.Controls.Add(this.splitContainer4);
            this.uiTabPage5.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.uiTabPage5.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.uiTabPage5.Name = "uiTabPage5";
            this.uiTabPage5.Size = new System.Drawing.Size(914, 383);
            this.uiTabPage5.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage5.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage5.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage5.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage5.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage5.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage5.TabStop = true;
            this.uiTabPage5.Text = "ماده 18";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label6);
            this.splitContainer4.Panel1.Controls.Add(this.label7);
            this.splitContainer4.Panel1.Controls.Add(this.cmbFSM);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dgvArz);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Size = new System.Drawing.Size(914, 383);
            this.splitContainer4.SplitterDistance = 83;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(839, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 149;
            this.label6.Text = "مدل ترازنامه";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label7.Location = new System.Drawing.Point(640, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 24);
            this.label7.TabIndex = 148;
            this.label7.Text = "سرمایه مورد نیاز برای پوشش ریسک بازار نرخ ارز";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFSM
            // 
            this.cmbFSM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance4.ImageBackground")));
            appearance4.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbFSM.Appearance = appearance4;
            this.cmbFSM.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbFSM.AutoSize = false;
            this.cmbFSM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance5.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance5.ImageBackground")));
            appearance5.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbFSM.ButtonAppearance = appearance5;
            this.cmbFSM.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbFSM.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbFSM.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.DiagonalResize;
            this.cmbFSM.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbFSM.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbFSM.HideSelection = false;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbFSM.ItemAppearance = appearance6;
            this.cmbFSM.Location = new System.Drawing.Point(563, 44);
            this.cmbFSM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFSM.Name = "cmbFSM";
            this.cmbFSM.Size = new System.Drawing.Size(267, 26);
            this.cmbFSM.TabIndex = 0;
            this.cmbFSM.SelectionChanged += new System.EventHandler(this.cmbFSM_SelectionChanged);
            // 
            // dgvArz
            // 
            this.dgvArz.AllowUserToAddRows = false;
            this.dgvArz.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 9.75F);
            this.dgvArz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArz.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(228)))));
            this.dgvArz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArz.EnableHeadersVisualStyles = false;
            this.dgvArz.Location = new System.Drawing.Point(0, 0);
            this.dgvArz.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArz.MultiSelect = false;
            this.dgvArz.Name = "dgvArz";
            this.dgvArz.ReadOnly = true;
            this.dgvArz.RowHeadersVisible = false;
            this.dgvArz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvArz.Size = new System.Drawing.Size(914, 295);
            this.dgvArz.TabIndex = 10;
            // 
            // frmMarketRiskAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(918, 497);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMarketRiskAsset";
            this.ShowIcon = false;
            this.Text = "دارایی موزون به ریسک بازار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCapitalAdecuacy_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPortfolio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisk)).EndInit();
            this.uiTabPage5.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFSM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Utilize.Company.CButton cbStart;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker fdpDate;
        private Utilize.Company.CButton cbConfirm;
        private Janus.Windows.UI.Tab.UITab tabMain;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Utilize.Company.CComboCox cmbPortfolio;
        private System.Windows.Forms.DataGridView dgvRisk;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage5;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Utilize.Company.CComboCox cmbFSM;
        private System.Windows.Forms.DataGridView dgvArz;
    }
}