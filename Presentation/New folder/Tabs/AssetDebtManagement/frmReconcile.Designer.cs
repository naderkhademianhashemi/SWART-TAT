using Janus.Windows.EditControls;

namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmReconcile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReconcile));
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpOption = new Janus.Windows.EditControls.UIGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fdpStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.cbProcess = new Utilize.Company.CButton();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.rdbCurrentLoan = new System.Windows.Forms.RadioButton();
            this.rdbDeposite = new System.Windows.Forms.RadioButton();
            this.rdbOverdue1 = new System.Windows.Forms.RadioButton();
            this.rdbOverdue2 = new System.Windows.Forms.RadioButton();
            this.rdbOverdue3 = new System.Windows.Forms.RadioButton();
            this.rdbLG = new System.Windows.Forms.RadioButton();
            this.rdbCollateral = new System.Windows.Forms.RadioButton();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.chkEnablePaging = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPageSize = new Utilize.Company.CComboCox();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.cmbPage = new Utilize.Company.CComboCox();
            this.btnPrevPage = new Utilize.Company.CButton();
            this.btnNextPage = new Utilize.Company.CButton();
            this.uiView = new Janus.Windows.EditControls.UIGroupBox();
            this.rdoGTzero = new System.Windows.Forms.RadioButton();
            this.rdoEQzero = new System.Windows.Forms.RadioButton();
            this.rdoLTzero = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoNonEQzero = new System.Windows.Forms.RadioButton();
            this.dspProgress = new Presentation.Public.SpinningProgress();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.cbMap = new Utilize.Company.CButton();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabMain = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtCounterpartyNames = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ucNationality = new Utilize.Report.UCFiltering();
            ((System.ComponentModel.ISupportInitialize)(this.grpOption)).BeginInit();
            this.grpOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiView)).BeginInit();
            this.uiView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNames)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOption
            // 
            this.grpOption.BackColor = System.Drawing.Color.Transparent;
            this.grpOption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(196)))), ((int)(((byte)(149)))));
            this.grpOption.Controls.Add(this.label1);
            this.grpOption.Controls.Add(this.fdpStartDate);
            this.grpOption.Controls.Add(this.cbProcess);
            this.grpOption.Controls.Add(this.uiGroupBox1);
            this.grpOption.Controls.Add(this.uiGroupBox2);
            this.grpOption.Controls.Add(this.uiView);
            this.grpOption.Controls.Add(this.dspProgress);
            this.grpOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOption.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpOption.Location = new System.Drawing.Point(0, 0);
            this.grpOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOption.Name = "grpOption";
            this.grpOption.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpOption.Size = new System.Drawing.Size(914, 183);
            this.grpOption.TabIndex = 11;
            this.grpOption.Text = "انتخابها";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(792, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 113;
            this.label1.Text = "تاریخ مورد نظر";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fdpStartDate
            // 
            this.fdpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpStartDate.Font = null;
            this.fdpStartDate.Location = new System.Drawing.Point(656, 19);
            this.fdpStartDate.Name = "fdpStartDate";
            this.fdpStartDate.Size = new System.Drawing.Size(130, 27);
            this.fdpStartDate.TabIndex = 112;
            this.fdpStartDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // cbProcess
            // 
            this.cbProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProcess.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbProcess.DefaultImage")));
            this.cbProcess.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbProcess.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbProcess.HoverImage")));
            this.cbProcess.Location = new System.Drawing.Point(73, 59);
            this.cbProcess.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cbProcess.Name = "cbProcess";
            this.cbProcess.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbProcess.Size = new System.Drawing.Size(62, 34);
            this.cbProcess.TabIndex = 23;
            this.cbProcess.Title = null;
            this.cbProcess.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnProcess_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(196)))), ((int)(((byte)(149)))));
            this.uiGroupBox1.Controls.Add(this.rdbCurrentLoan);
            this.uiGroupBox1.Controls.Add(this.rdbDeposite);
            this.uiGroupBox1.Controls.Add(this.rdbOverdue1);
            this.uiGroupBox1.Controls.Add(this.rdbOverdue2);
            this.uiGroupBox1.Controls.Add(this.rdbOverdue3);
            this.uiGroupBox1.Controls.Add(this.rdbLG);
            this.uiGroupBox1.Controls.Add(this.rdbCollateral);
            this.uiGroupBox1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.uiGroupBox1.Location = new System.Drawing.Point(367, 49);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(533, 129);
            this.uiGroupBox1.TabIndex = 22;
            this.uiGroupBox1.Text = "گزارش";
            // 
            // rdbCurrentLoan
            // 
            this.rdbCurrentLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbCurrentLoan.AutoSize = true;
            this.rdbCurrentLoan.Checked = true;
            this.rdbCurrentLoan.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbCurrentLoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdbCurrentLoan.Location = new System.Drawing.Point(402, 22);
            this.rdbCurrentLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbCurrentLoan.Name = "rdbCurrentLoan";
            this.rdbCurrentLoan.Size = new System.Drawing.Size(125, 21);
            this.rdbCurrentLoan.TabIndex = 17;
            this.rdbCurrentLoan.TabStop = true;
            this.rdbCurrentLoan.Text = "تسهیلات در سرفصل جاری";
            this.rdbCurrentLoan.UseVisualStyleBackColor = true;
            this.rdbCurrentLoan.CheckedChanged += new System.EventHandler(this.Filter_CheckChanged);
            // 
            // rdbDeposite
            // 
            this.rdbDeposite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDeposite.AutoSize = true;
            this.rdbDeposite.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbDeposite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdbDeposite.Location = new System.Drawing.Point(98, 22);
            this.rdbDeposite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDeposite.Name = "rdbDeposite";
            this.rdbDeposite.Size = new System.Drawing.Size(152, 21);
            this.rdbDeposite.TabIndex = 18;
            this.rdbDeposite.Text = "جدول چک صحت اطلاعات سپرده";
            this.rdbDeposite.UseVisualStyleBackColor = true;
            this.rdbDeposite.CheckedChanged += new System.EventHandler(this.Filter_CheckChanged);
            // 
            // rdbOverdue1
            // 
            this.rdbOverdue1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbOverdue1.AutoSize = true;
            this.rdbOverdue1.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbOverdue1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdbOverdue1.Location = new System.Drawing.Point(361, 47);
            this.rdbOverdue1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbOverdue1.Name = "rdbOverdue1";
            this.rdbOverdue1.Size = new System.Drawing.Size(166, 21);
            this.rdbOverdue1.TabIndex = 20;
            this.rdbOverdue1.Text = "تسهیلات در سرفصل سررسید گذشته";
            this.rdbOverdue1.UseVisualStyleBackColor = true;
            this.rdbOverdue1.CheckedChanged += new System.EventHandler(this.Filter_CheckChanged);
            // 
            // rdbOverdue2
            // 
            this.rdbOverdue2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbOverdue2.AutoSize = true;
            this.rdbOverdue2.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbOverdue2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdbOverdue2.Location = new System.Drawing.Point(402, 71);
            this.rdbOverdue2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbOverdue2.Name = "rdbOverdue2";
            this.rdbOverdue2.Size = new System.Drawing.Size(125, 21);
            this.rdbOverdue2.TabIndex = 21;
            this.rdbOverdue2.Text = "تسهیلات در سرفصل معوق";
            this.rdbOverdue2.UseVisualStyleBackColor = true;
            this.rdbOverdue2.CheckedChanged += new System.EventHandler(this.Filter_CheckChanged);
            // 
            // rdbOverdue3
            // 
            this.rdbOverdue3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbOverdue3.AutoSize = true;
            this.rdbOverdue3.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbOverdue3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdbOverdue3.Location = new System.Drawing.Point(360, 95);
            this.rdbOverdue3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbOverdue3.Name = "rdbOverdue3";
            this.rdbOverdue3.Size = new System.Drawing.Size(167, 21);
            this.rdbOverdue3.TabIndex = 19;
            this.rdbOverdue3.Text = "تسهیلات در سرفصل مشکوک الوصول";
            this.rdbOverdue3.UseVisualStyleBackColor = true;
            this.rdbOverdue3.CheckedChanged += new System.EventHandler(this.Filter_CheckChanged);
            // 
            // rdbLG
            // 
            this.rdbLG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbLG.AutoSize = true;
            this.rdbLG.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbLG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdbLG.Location = new System.Drawing.Point(86, 47);
            this.rdbLG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbLG.Name = "rdbLG";
            this.rdbLG.Size = new System.Drawing.Size(164, 21);
            this.rdbLG.TabIndex = 18;
            this.rdbLG.Text = "جدول چک صحت اطلاعات ضمانتنامه";
            this.rdbLG.UseVisualStyleBackColor = true;
            this.rdbLG.CheckedChanged += new System.EventHandler(this.Filter_CheckChanged);
            // 
            // rdbCollateral
            // 
            this.rdbCollateral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbCollateral.AutoSize = true;
            this.rdbCollateral.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbCollateral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdbCollateral.Location = new System.Drawing.Point(102, 71);
            this.rdbCollateral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbCollateral.Name = "rdbCollateral";
            this.rdbCollateral.Size = new System.Drawing.Size(148, 21);
            this.rdbCollateral.TabIndex = 18;
            this.rdbCollateral.Text = "جدول چک صحت اطلاعات وثایق";
            this.rdbCollateral.UseVisualStyleBackColor = true;
            this.rdbCollateral.CheckedChanged += new System.EventHandler(this.Filter_CheckChanged);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(196)))), ((int)(((byte)(149)))));
            this.uiGroupBox2.Controls.Add(this.chkEnablePaging);
            this.uiGroupBox2.Controls.Add(this.label2);
            this.uiGroupBox2.Controls.Add(this.cmbPageSize);
            this.uiGroupBox2.Controls.Add(this.lblPageSize);
            this.uiGroupBox2.Controls.Add(this.cmbPage);
            this.uiGroupBox2.Controls.Add(this.btnPrevPage);
            this.uiGroupBox2.Controls.Add(this.btnNextPage);
            this.uiGroupBox2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.uiGroupBox2.Location = new System.Drawing.Point(10, 19);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(52, 48);
            this.uiGroupBox2.TabIndex = 22;
            this.uiGroupBox2.Text = "تنظیمات نمایش";
            this.uiGroupBox2.Visible = false;
            // 
            // chkEnablePaging
            // 
            this.chkEnablePaging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnablePaging.AutoSize = true;
            this.chkEnablePaging.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkEnablePaging.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chkEnablePaging.Location = new System.Drawing.Point(-65, 23);
            this.chkEnablePaging.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEnablePaging.Name = "chkEnablePaging";
            this.chkEnablePaging.Size = new System.Drawing.Size(111, 24);
            this.chkEnablePaging.TabIndex = 13;
            this.chkEnablePaging.Text = "راه اندازی صفحات";
            this.chkEnablePaging.UseVisualStyleBackColor = true;
            this.chkEnablePaging.CheckedChanged += new System.EventHandler(this.chkEnablePaging_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(-13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "صفحه ها";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPageSize
            // 
            this.cmbPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance10.ImageBackground")));
            appearance10.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbPageSize.Appearance = appearance10;
            this.cmbPageSize.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbPageSize.AutoSize = false;
            this.cmbPageSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance11.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance11.ImageBackground")));
            appearance11.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbPageSize.ButtonAppearance = appearance11;
            this.cmbPageSize.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbPageSize.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbPageSize.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbPageSize.HideSelection = false;
            appearance12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbPageSize.ItemAppearance = appearance12;
            this.cmbPageSize.Location = new System.Drawing.Point(-160, 89);
            this.cmbPageSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPageSize.Name = "cmbPageSize";
            this.cmbPageSize.Size = new System.Drawing.Size(123, 22);
            this.cmbPageSize.TabIndex = 111;
            this.cmbPageSize.SelectionChanged += new System.EventHandler(this.cmbPageSize_SelectedIndexChanged);
            // 
            // lblPageSize
            // 
            this.lblPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.BackColor = System.Drawing.Color.Transparent;
            this.lblPageSize.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPageSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblPageSize.Location = new System.Drawing.Point(-31, 91);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(64, 20);
            this.lblPageSize.TabIndex = 19;
            this.lblPageSize.Text = "اندازه صفحه";
            this.lblPageSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPage
            // 
            this.cmbPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            appearance1.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbPage.Appearance = appearance1;
            this.cmbPage.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbPage.AutoSize = false;
            this.cmbPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            appearance2.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbPage.ButtonAppearance = appearance2;
            this.cmbPage.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbPage.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbPage.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbPage.HideSelection = false;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbPage.ItemAppearance = appearance3;
            this.cmbPage.Location = new System.Drawing.Point(-135, 61);
            this.cmbPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPage.Name = "cmbPage";
            this.cmbPage.Size = new System.Drawing.Size(76, 22);
            this.cmbPage.TabIndex = 110;
            this.cmbPage.SelectionChanged += new System.EventHandler(this.cmbPage_SelectedIndexChanged);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevPage.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnPrevPage.DefaultImage")));
            this.btnPrevPage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrevPage.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnPrevPage.HoverImage")));
            this.btnPrevPage.Location = new System.Drawing.Point(-57, 61);
            this.btnPrevPage.Margin = new System.Windows.Forms.Padding(14, 20, 14, 20);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrevPage.Size = new System.Drawing.Size(20, 20);
            this.btnPrevPage.TabIndex = 107;
            this.btnPrevPage.Title = null;
            this.btnPrevPage.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnNextPage.DefaultImage")));
            this.btnNextPage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNextPage.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnNextPage.HoverImage")));
            this.btnNextPage.Location = new System.Drawing.Point(-160, 61);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(24, 40, 24, 40);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNextPage.Size = new System.Drawing.Size(20, 20);
            this.btnNextPage.TabIndex = 108;
            this.btnNextPage.Title = null;
            this.btnNextPage.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnNextPage_Click);
            // 
            // uiView
            // 
            this.uiView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(196)))), ((int)(((byte)(149)))));
            this.uiView.Controls.Add(this.rdoGTzero);
            this.uiView.Controls.Add(this.rdoEQzero);
            this.uiView.Controls.Add(this.rdoLTzero);
            this.uiView.Controls.Add(this.rdoAll);
            this.uiView.Controls.Add(this.rdoNonEQzero);
            this.uiView.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.uiView.Location = new System.Drawing.Point(144, 40);
            this.uiView.Name = "uiView";
            this.uiView.Size = new System.Drawing.Size(217, 135);
            this.uiView.TabIndex = 22;
            this.uiView.Text = "نما";
            // 
            // rdoGTzero
            // 
            this.rdoGTzero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoGTzero.AutoSize = true;
            this.rdoGTzero.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoGTzero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoGTzero.Location = new System.Drawing.Point(145, 79);
            this.rdoGTzero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoGTzero.Name = "rdoGTzero";
            this.rdoGTzero.Size = new System.Drawing.Size(63, 21);
            this.rdoGTzero.TabIndex = 21;
            this.rdoGTzero.TabStop = true;
            this.rdoGTzero.Text = "نتیجه > 0";
            this.rdoGTzero.UseVisualStyleBackColor = true;
            this.rdoGTzero.CheckedChanged += new System.EventHandler(this.Filter_CheckChanged);
            // 
            // rdoEQzero
            // 
            this.rdoEQzero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoEQzero.AutoSize = true;
            this.rdoEQzero.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoEQzero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoEQzero.Location = new System.Drawing.Point(38, 46);
            this.rdoEQzero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoEQzero.Name = "rdoEQzero";
            this.rdoEQzero.Size = new System.Drawing.Size(73, 21);
            this.rdoEQzero.TabIndex = 18;
            this.rdoEQzero.TabStop = true;
            this.rdoEQzero.Text = "نتیجه = 0      ";
            this.rdoEQzero.UseVisualStyleBackColor = true;
            this.rdoEQzero.CheckedChanged += new System.EventHandler(this.Filter_CheckChanged);
            // 
            // rdoLTzero
            // 
            this.rdoLTzero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoLTzero.AutoSize = true;
            this.rdoLTzero.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoLTzero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoLTzero.Location = new System.Drawing.Point(145, 49);
            this.rdoLTzero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoLTzero.Name = "rdoLTzero";
            this.rdoLTzero.Size = new System.Drawing.Size(63, 21);
            this.rdoLTzero.TabIndex = 20;
            this.rdoLTzero.TabStop = true;
            this.rdoLTzero.Text = "نتیجه < 0";
            this.rdoLTzero.UseVisualStyleBackColor = true;
            this.rdoLTzero.CheckedChanged += new System.EventHandler(this.Filter_CheckChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoAll.AutoSize = true;
            this.rdoAll.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoAll.Location = new System.Drawing.Point(159, 19);
            this.rdoAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(49, 21);
            this.rdoAll.TabIndex = 17;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "همه    ";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.Filter_CheckChanged);
            // 
            // rdoNonEQzero
            // 
            this.rdoNonEQzero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoNonEQzero.AutoSize = true;
            this.rdoNonEQzero.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoNonEQzero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoNonEQzero.Location = new System.Drawing.Point(31, 75);
            this.rdoNonEQzero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNonEQzero.Name = "rdoNonEQzero";
            this.rdoNonEQzero.Size = new System.Drawing.Size(80, 21);
            this.rdoNonEQzero.TabIndex = 19;
            this.rdoNonEQzero.TabStop = true;
            this.rdoNonEQzero.Text = "نتیجه <>0      ";
            this.rdoNonEQzero.UseVisualStyleBackColor = true;
            this.rdoNonEQzero.CheckedChanged += new System.EventHandler(this.Filter_CheckChanged);
            // 
            // dspProgress
            // 
            this.dspProgress.ActiveSegmentColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dspProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dspProgress.AutoIncrement = false;
            this.dspProgress.AutoIncrementFrequency = 1000D;
            this.dspProgress.Location = new System.Drawing.Point(84, 110);
            this.dspProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dspProgress.Name = "dspProgress";
            this.dspProgress.Size = new System.Drawing.Size(40, 46);
            this.dspProgress.TabIndex = 21;
            this.dspProgress.TransistionSegment = 1;
            this.dspProgress.TransistionSegmentColour = System.Drawing.Color.Maroon;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(206)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(914, 283);
            this.dgvList.TabIndex = 10;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text Files|*.txt";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvList);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(914, 283);
            this.pnlGrid.TabIndex = 13;
            // 
            // cbMap
            // 
            this.cbMap.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbMap.DefaultImage")));
            this.cbMap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbMap.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbMap.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbMap.HoverImage")));
            this.cbMap.Location = new System.Drawing.Point(773, 0);
            this.cbMap.Margin = new System.Windows.Forms.Padding(2);
            this.cbMap.Name = "cbMap";
            this.cbMap.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbMap.Size = new System.Drawing.Size(141, 44);
            this.cbMap.TabIndex = 14;
            this.cbMap.Title = null;
            this.cbMap.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnMap_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButton.Location = new System.Drawing.Point(5, 3);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(140, 37);
            this.pnlButton.TabIndex = 15;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 183);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlGrid);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlButton);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(914, 283);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 16;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabMain.Size = new System.Drawing.Size(918, 497);
            this.tabMain.TabIndex = 135;
            this.tabMain.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage1,
            this.uiTabPage3});
            this.tabMain.TabsStateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabMain.TabsStateStyles.FormatStyle.BackgroundImage")));
            this.tabMain.TabStripFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.UseThemes = false;
            this.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.AutoScroll = true;
            this.uiTabPage2.Controls.Add(this.splitContainer1);
            this.uiTabPage2.Controls.Add(this.grpOption);
            this.uiTabPage2.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage2.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage2.Size = new System.Drawing.Size(914, 466);
            this.uiTabPage2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "مقایسه تطبیقی";
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
            this.uiTabPage3.Controls.Add(this.splitContainer2);
            this.uiTabPage3.Location = new System.Drawing.Point(2, 29);
            this.uiTabPage3.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage3.Size = new System.Drawing.Size(914, 466);
            this.uiTabPage3.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "تعریف مطابق سازی";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cbMap);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(914, 466);
            this.splitContainer2.SplitterDistance = 44;
            this.splitContainer2.TabIndex = 15;
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
            this.txtCounterpartyNames.Size = new System.Drawing.Size(62, 24);
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
            this.ucNationality.Size = new System.Drawing.Size(62, 160);
            this.ucNationality.TabIndex = 131;
            this.ucNationality.Title = "ملیت";
            this.ucNationality.ValueMember = null;
            this.ucNationality.Visible = false;
            // 
            // frmReconcile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(918, 497);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReconcile";
            this.ShowIcon = false;
            this.Text = " تطبیق   ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReconcile_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReconcile_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grpOption)).EndInit();
            this.grpOption.ResumeLayout(false);
            this.grpOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiView)).EndInit();
            this.uiView.ResumeLayout(false);
            this.uiView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.uiTabPage3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private Janus.Windows.EditControls.UIGroupBox grpOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEnablePaging;
        private System.Windows.Forms.RadioButton rdoNonEQzero;
        private System.Windows.Forms.RadioButton rdoEQzero;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.Label lblPageSize;
        private Presentation.Public.SpinningProgress dspProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RadioButton rdoGTzero;
        private System.Windows.Forms.RadioButton rdoLTzero;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlGrid;
        private Utilize.Company.CButton cbMap;
        private System.Windows.Forms.Panel pnlButton;
        private Janus.Windows.EditControls.UIGroupBox uiView;
        private Utilize.Company.CButton cbProcess;
        private Utilize.Company.CButton btnPrevPage;
        private Utilize.Company.CButton btnNextPage;
        private Utilize.Company.CComboCox cmbPageSize;
        private Utilize.Company.CComboCox cmbPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker fdpStartDate;
        private Janus.Windows.UI.Tab.UITab tabMain;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterpartyNames;
        private Utilize.Report.UCFiltering ucNationality;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private UIGroupBox uiGroupBox1;
        private System.Windows.Forms.RadioButton rdbOverdue2;
        private System.Windows.Forms.RadioButton rdbCollateral;
        private System.Windows.Forms.RadioButton rdbOverdue1;
        private System.Windows.Forms.RadioButton rdbCurrentLoan;
        private System.Windows.Forms.RadioButton rdbOverdue3;
        private UIGroupBox uiGroupBox2;
        private System.Windows.Forms.RadioButton rdbLG;
        private System.Windows.Forms.RadioButton rdbDeposite;
    }
}