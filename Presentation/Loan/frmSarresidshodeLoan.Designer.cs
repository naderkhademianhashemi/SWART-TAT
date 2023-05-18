namespace Presentation.Loan
{
    partial class frmSarresidshodeLoan
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
            System.Windows.Forms.Label lblSelectedTime;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSarresidshodeLoan));
            this.txtCounterpartyNames = new System.Windows.Forms.TextBox();
            this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnFulScreenGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.chbCustInfo = new System.Windows.Forms.CheckBox();
            this.cbShowReport = new Utilize.Company.CButton();
            this.dgvResoult = new System.Windows.Forms.DataGridView();
            this.cgbCustomer = new System.Windows.Forms.GroupBox();
            this.dgvCounterpartiesNames = new System.Windows.Forms.DataGridView();
            this.cgbCouterpartName = new System.Windows.Forms.GroupBox();
            this.utCustomerName = new System.Windows.Forms.TextBox();
            this.rdbContains = new System.Windows.Forms.RadioButton();
            this.rdbStartsWith = new System.Windows.Forms.RadioButton();
            this.rdbEndsWith = new System.Windows.Forms.RadioButton();
            this.rbtCounterpartyName = new System.Windows.Forms.RadioButton();
            this.utCustomerCode = new System.Windows.Forms.TextBox();
            this.txtCounterPartyName = new System.Windows.Forms.TextBox();
            this.rbtCounterparty = new System.Windows.Forms.RadioButton();
            this.cgbContractInfo = new System.Windows.Forms.GroupBox();
            this.fdpSelectDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.cgbBranch = new System.Windows.Forms.GroupBox();
            this.tabMain = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.cGroupBox1 = new System.Windows.Forms.GroupBox();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage4 = new Janus.Windows.UI.Tab.UITabPage();
            this.cbCloseAll = new Utilize.Company.CButton();
            lblSelectedTime = new System.Windows.Forms.Label();
            this.cmsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResoult)).BeginInit();
            this.cgbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).BeginInit();
            this.cgbCouterpartName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.cGroupBox1.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            this.uiTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectedTime
            // 
            lblSelectedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblSelectedTime.AutoSize = true;
            lblSelectedTime.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblSelectedTime.Location = new System.Drawing.Point(980, 12);
            lblSelectedTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSelectedTime.Name = "lblSelectedTime";
            lblSelectedTime.Size = new System.Drawing.Size(39, 27);
            lblSelectedTime.TabIndex = 135;
            lblSelectedTime.Text = "زمان";
            // 
            // txtCounterpartyNames
            // 
            this.txtCounterpartyNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterpartyNames.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCounterpartyNames.Location = new System.Drawing.Point(510, 289);
            this.txtCounterpartyNames.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.txtCounterpartyNames.Name = "txtCounterpartyNames";
            this.txtCounterpartyNames.ReadOnly = true;
            this.txtCounterpartyNames.Size = new System.Drawing.Size(57, 27);
            this.txtCounterpartyNames.TabIndex = 15;
            this.txtCounterpartyNames.Visible = false;
            // 
            // cmsGrid
            // 
            this.cmsGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFulScreenGrid});
            this.cmsGrid.Name = "cmsGrid";
            this.cmsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsGrid.Size = new System.Drawing.Size(231, 36);
            // 
            // btnFulScreenGrid
            // 
            this.btnFulScreenGrid.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFulScreenGrid.Name = "btnFulScreenGrid";
            this.btnFulScreenGrid.Size = new System.Drawing.Size(230, 32);
            this.btnFulScreenGrid.Text = "نمایش تمام صفحه گزارش";
            this.btnFulScreenGrid.Click += new System.EventHandler(this.btnFulScreenGrid_Click);
            // 
            // chbCustInfo
            // 
            this.chbCustInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCustInfo.AutoSize = true;
            this.chbCustInfo.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.chbCustInfo.ForeColor = System.Drawing.Color.Black;
            this.chbCustInfo.Location = new System.Drawing.Point(893, -1);
            this.chbCustInfo.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.chbCustInfo.Name = "chbCustInfo";
            this.chbCustInfo.Size = new System.Drawing.Size(145, 31);
            this.chbCustInfo.TabIndex = 142;
            this.chbCustInfo.Text = "شماره / نام مشتری";
            this.chbCustInfo.UseVisualStyleBackColor = true;
            this.chbCustInfo.CheckedChanged += new System.EventHandler(this.chbCustInfo_CheckedChanged);
            // 
            // cbShowReport
            // 
            this.cbShowReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShowReport.DefaultImage = null;
            this.cbShowReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbShowReport.HoverImage = null;
            this.cbShowReport.Location = new System.Drawing.Point(814, 243);
            this.cbShowReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbShowReport.Name = "cbShowReport";
            this.cbShowReport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbShowReport.Size = new System.Drawing.Size(165, 32);
            this.cbShowReport.TabIndex = 140;
            this.cbShowReport.Title = null;
            this.cbShowReport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbShowReport_CButtonClicked);
            // 
            // dgvResoult
            // 
            this.dgvResoult.ColumnHeadersHeight = 29;
            this.dgvResoult.ContextMenuStrip = this.cmsGrid;
            this.dgvResoult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResoult.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvResoult.Location = new System.Drawing.Point(0, 214);
            this.dgvResoult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvResoult.Name = "dgvResoult";
            this.dgvResoult.RowHeadersWidth = 51;
            this.dgvResoult.Size = new System.Drawing.Size(1045, 315);
            this.dgvResoult.TabIndex = 139;
            // 
            // cgbCustomer
            // 
            this.cgbCustomer.Controls.Add(this.dgvCounterpartiesNames);
            this.cgbCustomer.Controls.Add(this.cgbCouterpartName);
            this.cgbCustomer.Controls.Add(this.rbtCounterpartyName);
            this.cgbCustomer.Controls.Add(this.utCustomerCode);
            this.cgbCustomer.Controls.Add(this.txtCounterPartyName);
            this.cgbCustomer.Controls.Add(this.rbtCounterparty);
            this.cgbCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cgbCustomer.Enabled = false;
            this.cgbCustomer.Location = new System.Drawing.Point(0, 0);
            this.cgbCustomer.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.cgbCustomer.Name = "cgbCustomer";
            this.cgbCustomer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cgbCustomer.Size = new System.Drawing.Size(1041, 187);
            this.cgbCustomer.TabIndex = 137;
            this.cgbCustomer.TabStop = false;
            this.cgbCustomer.Text = "اطلاعات مشتری";
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
            this.dgvCounterpartiesNames.Location = new System.Drawing.Point(8, 61);
            this.dgvCounterpartiesNames.Margin = new System.Windows.Forms.Padding(4, 11, 4, 11);
            this.dgvCounterpartiesNames.Name = "dgvCounterpartiesNames";
            this.dgvCounterpartiesNames.RowHeadersWidth = 51;
            this.dgvCounterpartiesNames.RowTemplate.Height = 24;
            this.dgvCounterpartiesNames.Size = new System.Drawing.Size(590, 111);
            this.dgvCounterpartiesNames.TabIndex = 147;
            // 
            // cgbCouterpartName
            // 
            this.cgbCouterpartName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cgbCouterpartName.Controls.Add(this.utCustomerName);
            this.cgbCouterpartName.Controls.Add(this.rdbContains);
            this.cgbCouterpartName.Controls.Add(this.rdbStartsWith);
            this.cgbCouterpartName.Controls.Add(this.rdbEndsWith);
            this.cgbCouterpartName.Location = new System.Drawing.Point(609, 54);
            this.cgbCouterpartName.Margin = new System.Windows.Forms.Padding(4, 11, 4, 11);
            this.cgbCouterpartName.Name = "cgbCouterpartName";
            this.cgbCouterpartName.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cgbCouterpartName.Size = new System.Drawing.Size(237, 79);
            this.cgbCouterpartName.TabIndex = 146;
            this.cgbCouterpartName.TabStop = false;
            // 
            // utCustomerName
            // 
            this.utCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.utCustomerName.Enabled = false;
            this.utCustomerName.Location = new System.Drawing.Point(8, 16);
            this.utCustomerName.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.utCustomerName.Name = "utCustomerName";
            this.utCustomerName.Size = new System.Drawing.Size(220, 22);
            this.utCustomerName.TabIndex = 14;
            // 
            // rdbContains
            // 
            this.rdbContains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbContains.AutoSize = true;
            this.rdbContains.Checked = true;
            this.rdbContains.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbContains.Location = new System.Drawing.Point(177, 56);
            this.rdbContains.Margin = new System.Windows.Forms.Padding(4, 11, 4, 11);
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
            this.rdbStartsWith.Location = new System.Drawing.Point(103, 56);
            this.rdbStartsWith.Margin = new System.Windows.Forms.Padding(4, 11, 4, 11);
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
            this.rdbEndsWith.Location = new System.Drawing.Point(20, 56);
            this.rdbEndsWith.Margin = new System.Windows.Forms.Padding(4, 11, 4, 11);
            this.rdbEndsWith.Name = "rdbEndsWith";
            this.rdbEndsWith.Size = new System.Drawing.Size(57, 24);
            this.rdbEndsWith.TabIndex = 132;
            this.rdbEndsWith.Text = "پایان با";
            this.rdbEndsWith.UseVisualStyleBackColor = true;
            // 
            // rbtCounterpartyName
            // 
            this.rbtCounterpartyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtCounterpartyName.AutoSize = true;
            this.rbtCounterpartyName.Location = new System.Drawing.Point(951, 61);
            this.rbtCounterpartyName.Margin = new System.Windows.Forms.Padding(4, 11, 4, 11);
            this.rbtCounterpartyName.Name = "rbtCounterpartyName";
            this.rbtCounterpartyName.Size = new System.Drawing.Size(80, 20);
            this.rbtCounterpartyName.TabIndex = 145;
            this.rbtCounterpartyName.Text = "نام مشتری";
            this.rbtCounterpartyName.UseVisualStyleBackColor = true;
            this.rbtCounterpartyName.CheckedChanged += new System.EventHandler(this.rbtCounterpartyName_CheckedChanged);
            // 
            // utCustomerCode
            // 
            this.utCustomerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.utCustomerCode.Location = new System.Drawing.Point(617, 24);
            this.utCustomerCode.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.utCustomerCode.Name = "utCustomerCode";
            this.utCustomerCode.Size = new System.Drawing.Size(220, 22);
            this.utCustomerCode.TabIndex = 143;
            // 
            // txtCounterPartyName
            // 
            this.txtCounterPartyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterPartyName.Location = new System.Drawing.Point(7, 24);
            this.txtCounterPartyName.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.txtCounterPartyName.Name = "txtCounterPartyName";
            this.txtCounterPartyName.ReadOnly = true;
            this.txtCounterPartyName.Size = new System.Drawing.Size(589, 22);
            this.txtCounterPartyName.TabIndex = 144;
            // 
            // rbtCounterparty
            // 
            this.rbtCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtCounterparty.AutoSize = true;
            this.rbtCounterparty.Checked = true;
            this.rbtCounterparty.Location = new System.Drawing.Point(933, 26);
            this.rbtCounterparty.Margin = new System.Windows.Forms.Padding(4, 11, 4, 11);
            this.rbtCounterparty.Name = "rbtCounterparty";
            this.rbtCounterparty.Size = new System.Drawing.Size(98, 20);
            this.rbtCounterparty.TabIndex = 142;
            this.rbtCounterparty.TabStop = true;
            this.rbtCounterparty.Text = "شماره مشتری";
            this.rbtCounterparty.UseVisualStyleBackColor = true;
            this.rbtCounterparty.CheckedChanged += new System.EventHandler(this.rbtCounterparty_CheckedChanged);
            // 
            // cgbContractInfo
            // 
            this.cgbContractInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cgbContractInfo.Location = new System.Drawing.Point(0, 0);
            this.cgbContractInfo.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.cgbContractInfo.Name = "cgbContractInfo";
            this.cgbContractInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cgbContractInfo.Size = new System.Drawing.Size(1041, 187);
            this.cgbContractInfo.TabIndex = 132;
            this.cgbContractInfo.TabStop = false;
            this.cgbContractInfo.Text = "اطلاعات قرارداد";
            // 
            // fdpSelectDate
            // 
            this.fdpSelectDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpSelectDate.Location = new System.Drawing.Point(678, 15);
            this.fdpSelectDate.Name = "fdpSelectDate";
            this.fdpSelectDate.Size = new System.Drawing.Size(299, 20);
            this.fdpSelectDate.TabIndex = 136;
            this.fdpSelectDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // cgbBranch
            // 
            this.cgbBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cgbBranch.Location = new System.Drawing.Point(0, 44);
            this.cgbBranch.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.cgbBranch.Name = "cgbBranch";
            this.cgbBranch.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cgbBranch.Size = new System.Drawing.Size(1041, 143);
            this.cgbBranch.TabIndex = 131;
            this.cgbBranch.TabStop = false;
            this.cgbBranch.Text = "اطلاعات شعب";
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.tabMain.Name = "tabMain";
            this.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabMain.Size = new System.Drawing.Size(1045, 214);
            this.tabMain.TabIndex = 143;
            this.tabMain.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage1,
            this.uiTabPage3,
            this.uiTabPage4});
            this.tabMain.TabsStateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabMain.TabsStateStyles.FormatStyle.BackgroundImage")));
            this.tabMain.TabStripFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.UseThemes = false;
            this.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal;
            this.tabMain.SelectedTabChanged += new Janus.Windows.UI.Tab.TabEventHandler(this.tabMain_SelectedTabChanged);
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.AutoScroll = true;
            this.uiTabPage2.Controls.Add(this.cgbBranch);
            this.uiTabPage2.Controls.Add(this.cGroupBox1);
            this.uiTabPage2.Location = new System.Drawing.Point(2, 25);
            this.uiTabPage2.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage2.Size = new System.Drawing.Size(1041, 187);
            this.uiTabPage2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "اطلاعات زمانی/مکانی";
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.Controls.Add(lblSelectedTime);
            this.cGroupBox1.Controls.Add(this.fdpSelectDate);
            this.cGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.cGroupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cGroupBox1.Size = new System.Drawing.Size(1041, 44);
            this.cGroupBox1.TabIndex = 137;
            this.cGroupBox1.TabStop = false;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Location = new System.Drawing.Point(3, 34);
            this.uiTabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(956, 308);
            this.uiTabPage1.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage1.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage1.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage1.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.TabVisible = false;
            this.uiTabPage1.Text = "اطلاعات مکانی";
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.AutoScroll = true;
            this.uiTabPage3.Controls.Add(this.cgbContractInfo);
            this.uiTabPage3.Location = new System.Drawing.Point(2, 25);
            this.uiTabPage3.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage3.Size = new System.Drawing.Size(1041, 187);
            this.uiTabPage3.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "اطلاعات قرارداد";
            // 
            // uiTabPage4
            // 
            this.uiTabPage4.AutoScroll = true;
            this.uiTabPage4.Controls.Add(this.chbCustInfo);
            this.uiTabPage4.Controls.Add(this.cgbCustomer);
            this.uiTabPage4.Location = new System.Drawing.Point(2, 25);
            this.uiTabPage4.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.uiTabPage4.Name = "uiTabPage4";
            this.uiTabPage4.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage4.Size = new System.Drawing.Size(1041, 187);
            this.uiTabPage4.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage4.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage4.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage4.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage4.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage4.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage4.TabStop = true;
            this.uiTabPage4.Text = "مشتری";
            // 
            // cbCloseAll
            // 
            this.cbCloseAll.BackColor = System.Drawing.Color.Transparent;
            this.cbCloseAll.DefaultImage = null;
            this.cbCloseAll.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cbCloseAll.HoverImage = null;
            this.cbCloseAll.Location = new System.Drawing.Point(241, 1);
            this.cbCloseAll.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.cbCloseAll.Name = "cbCloseAll";
            this.cbCloseAll.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCloseAll.Size = new System.Drawing.Size(104, 26);
            this.cbCloseAll.TabIndex = 144;
            this.cbCloseAll.Title = null;
            this.cbCloseAll.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbCloseAll_CButtonClicked);
            // 
            // frmSarresidshodeLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 529);
            this.Controls.Add(this.cbCloseAll);
            this.Controls.Add(this.cbShowReport);
            this.Controls.Add(this.dgvResoult);
            this.Controls.Add(this.tabMain);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSarresidshodeLoan";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تسهیلات سررسید شده";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.cmsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResoult)).EndInit();
            this.cgbCustomer.ResumeLayout(false);
            this.cgbCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).EndInit();
            this.cgbCouterpartName.ResumeLayout(false);
            this.cgbCouterpartName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.uiTabPage3.ResumeLayout(false);
            this.uiTabPage4.ResumeLayout(false);
            this.uiTabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cgbBranch;
        private Utilize.Report.UCFiltering ucfState;
        private Utilize.Report.UCFiltering ucfOrganization;
        private Utilize.Report.UCFiltering ucEconomicSector;
        private Utilize.Report.UCFiltering ucContractTypeCode;
        private Utilize.Report.UCFiltering ucfContractGroupType;
        private System.Windows.Forms.TextBox txtCounterpartyNames;
        private Utilize.Report.UCFiltering ucNationality;
        private Utilize.Report.UCFiltering ucfCollateralStatus;
        private Utilize.Report.UCFiltering ucfCollateralType;
        private Utilize.Report.UCFiltering ucfCollatMajorType;
        private Utilize.Report.UCFiltering ucMaritalStatus;
        private Utilize.Report.UCFiltering ucSokunat;
        private Utilize.Report.UCFiltering ucEducation;
        private Utilize.Report.UCFiltering ucSex;
        private Utilize.Report.UCFiltering ucJobType;
        private Utilize.Report.UCFiltering ucEconomicPart;
        private Utilize.Report.UCFiltering ucCompanyType;
        private System.Windows.Forms.DataGridView dgvResoult;
        private Utilize.Company.CButton cbShowReport;
        private FarsiLibrary.Win.Controls.FADatePicker fdpSelectDate;
        private System.Windows.Forms.GroupBox cgbContractInfo;
        private System.Windows.Forms.GroupBox cgbCustomer;
        private System.Windows.Forms.DataGridView dgvCounterpartiesNames;
        private System.Windows.Forms.GroupBox cgbCouterpartName;
        private System.Windows.Forms.TextBox utCustomerName;
        private System.Windows.Forms.RadioButton rdbContains;
        private System.Windows.Forms.RadioButton rdbStartsWith;
        private System.Windows.Forms.RadioButton rdbEndsWith;
        private System.Windows.Forms.RadioButton rbtCounterpartyName;
        private System.Windows.Forms.TextBox utCustomerCode;
        private System.Windows.Forms.TextBox txtCounterPartyName;
        private System.Windows.Forms.RadioButton rbtCounterparty;
        private System.Windows.Forms.CheckBox chbCustInfo;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.ToolStripMenuItem btnFulScreenGrid;
        private Janus.Windows.UI.Tab.UITab tabMain;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage4;
        private System.Windows.Forms.GroupBox cGroupBox1;
        private Utilize.Report.UCFiltering ucfCity;
        private Utilize.Company.CButton cbCloseAll;
    }
}