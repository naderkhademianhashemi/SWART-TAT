namespace Presentation.Loan
{
    partial class frmTasvieshode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTasvieshode));
            this.chbCustCodeName = new System.Windows.Forms.CheckBox();
            this.cgbCustomer = new System.Windows.Forms.GroupBox();
            this.txtCounterpartyNames = new System.Windows.Forms.TextBox();
            this.dgvCounterpartiesNames = new System.Windows.Forms.DataGridView();
            this.cgbCouterpartName = new System.Windows.Forms.GroupBox();
            this.txtCounterpartyNameSearch = new System.Windows.Forms.TextBox();
            this.rdbContains = new System.Windows.Forms.RadioButton();
            this.rdbStartsWith = new System.Windows.Forms.RadioButton();
            this.rdbEndsWith = new System.Windows.Forms.RadioButton();
            this.rbtCounterpartyName = new System.Windows.Forms.RadioButton();
            this.txtCounterparty = new System.Windows.Forms.TextBox();
            this.txtCounterPartyName = new System.Windows.Forms.TextBox();
            this.rbtCounterparty = new System.Windows.Forms.RadioButton();
            this.cgbContract = new System.Windows.Forms.GroupBox();
            this.cgbBranch = new System.Windows.Forms.GroupBox();
            this.dgvResoult = new System.Windows.Forms.DataGridView();
            this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnFulScreenGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.cbShowReport = new Utilize.Company.CButton();
            this.tabMain = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage4 = new Janus.Windows.UI.Tab.UITabPage();
            this.cbCloseAll = new Utilize.Company.CButton();
            this.cgbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).BeginInit();
            this.cgbCouterpartName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResoult)).BeginInit();
            this.cmsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            this.uiTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbCustCodeName
            // 
            this.chbCustCodeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCustCodeName.AutoSize = true;
            this.chbCustCodeName.ForeColor = System.Drawing.Color.Black;
            this.chbCustCodeName.Location = new System.Drawing.Point(907, -2);
            this.chbCustCodeName.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.chbCustCodeName.Name = "chbCustCodeName";
            this.chbCustCodeName.Size = new System.Drawing.Size(123, 20);
            this.chbCustCodeName.TabIndex = 141;
            this.chbCustCodeName.Text = "شماره / نام مشتری";
            this.chbCustCodeName.UseVisualStyleBackColor = true;
            this.chbCustCodeName.CheckedChanged += new System.EventHandler(this.chbCustCodeName_CheckedChanged);
            // 
            // cgbCustomer
            // 
            this.cgbCustomer.Controls.Add(this.txtCounterpartyNames);
            this.cgbCustomer.Controls.Add(this.dgvCounterpartiesNames);
            this.cgbCustomer.Controls.Add(this.cgbCouterpartName);
            this.cgbCustomer.Controls.Add(this.rbtCounterpartyName);
            this.cgbCustomer.Controls.Add(this.txtCounterparty);
            this.cgbCustomer.Controls.Add(this.txtCounterPartyName);
            this.cgbCustomer.Controls.Add(this.rbtCounterparty);
            this.cgbCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cgbCustomer.Enabled = false;
            this.cgbCustomer.Location = new System.Drawing.Point(0, 0);
            this.cgbCustomer.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.cgbCustomer.Name = "cgbCustomer";
            this.cgbCustomer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cgbCustomer.Size = new System.Drawing.Size(1041, 168);
            this.cgbCustomer.TabIndex = 134;
            this.cgbCustomer.TabStop = false;
            this.cgbCustomer.Text = "اطلاعات مشتری";
            // 
            // txtCounterpartyNames
            // 
            this.txtCounterpartyNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterpartyNames.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCounterpartyNames.Location = new System.Drawing.Point(854, 86);
            this.txtCounterpartyNames.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.txtCounterpartyNames.Multiline = true;
            this.txtCounterpartyNames.Name = "txtCounterpartyNames";
            this.txtCounterpartyNames.ReadOnly = true;
            this.txtCounterpartyNames.Size = new System.Drawing.Size(177, 47);
            this.txtCounterpartyNames.TabIndex = 148;
            this.txtCounterpartyNames.Visible = false;
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
            this.dgvCounterpartiesNames.Size = new System.Drawing.Size(590, 101);
            this.dgvCounterpartiesNames.TabIndex = 147;
            // 
            // cgbCouterpartName
            // 
            this.cgbCouterpartName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cgbCouterpartName.Controls.Add(this.txtCounterpartyNameSearch);
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
            // txtCounterpartyNameSearch
            // 
            this.txtCounterpartyNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterpartyNameSearch.Enabled = false;
            this.txtCounterpartyNameSearch.Location = new System.Drawing.Point(8, 16);
            this.txtCounterpartyNameSearch.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.txtCounterpartyNameSearch.Name = "txtCounterpartyNameSearch";
            this.txtCounterpartyNameSearch.Size = new System.Drawing.Size(220, 22);
            this.txtCounterpartyNameSearch.TabIndex = 14;
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
            this.rbtCounterpartyName.CheckedChanged += new System.EventHandler(this.chbCounterpartyName_CheckedChanged);
            // 
            // txtCounterparty
            // 
            this.txtCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterparty.Location = new System.Drawing.Point(617, 24);
            this.txtCounterparty.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.txtCounterparty.Name = "txtCounterparty";
            this.txtCounterparty.Size = new System.Drawing.Size(220, 22);
            this.txtCounterparty.TabIndex = 143;
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
            this.rbtCounterparty.CheckedChanged += new System.EventHandler(this.chbCounterparty_CheckedChanged);
            // 
            // cgbContract
            // 
            this.cgbContract.Dock = System.Windows.Forms.DockStyle.Top;
            this.cgbContract.Location = new System.Drawing.Point(0, 0);
            this.cgbContract.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.cgbContract.Name = "cgbContract";
            this.cgbContract.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cgbContract.Size = new System.Drawing.Size(1041, 91);
            this.cgbContract.TabIndex = 132;
            this.cgbContract.TabStop = false;
            // 
            // cgbBranch
            // 
            this.cgbBranch.Dock = System.Windows.Forms.DockStyle.Top;
            this.cgbBranch.Location = new System.Drawing.Point(0, 0);
            this.cgbBranch.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.cgbBranch.Name = "cgbBranch";
            this.cgbBranch.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cgbBranch.Size = new System.Drawing.Size(1041, 149);
            this.cgbBranch.TabIndex = 131;
            this.cgbBranch.TabStop = false;
            // 
            // dgvResoult
            // 
            this.dgvResoult.ColumnHeadersHeight = 29;
            this.dgvResoult.ContextMenuStrip = this.cmsGrid;
            this.dgvResoult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResoult.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvResoult.Location = new System.Drawing.Point(0, 195);
            this.dgvResoult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvResoult.Name = "dgvResoult";
            this.dgvResoult.RowHeadersWidth = 51;
            this.dgvResoult.Size = new System.Drawing.Size(1045, 334);
            this.dgvResoult.TabIndex = 140;
            // 
            // cmsGrid
            // 
            this.cmsGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFulScreenGrid});
            this.cmsGrid.Name = "cmsGrid";
            this.cmsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsGrid.Size = new System.Drawing.Size(235, 36);
            // 
            // btnFulScreenGrid
            // 
            this.btnFulScreenGrid.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFulScreenGrid.Name = "btnFulScreenGrid";
            this.btnFulScreenGrid.Size = new System.Drawing.Size(234, 32);
            this.btnFulScreenGrid.Text = " نمایش تمام صفحه گزارش";
            this.btnFulScreenGrid.Click += new System.EventHandler(this.btnFulScreenGrid_Click);
            // 
            // cbShowReport
            // 
            this.cbShowReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShowReport.DefaultImage = null;
            this.cbShowReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbShowReport.HoverImage = null;
            this.cbShowReport.Location = new System.Drawing.Point(869, 198);
            this.cbShowReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbShowReport.Name = "cbShowReport";
            this.cbShowReport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbShowReport.Size = new System.Drawing.Size(165, 31);
            this.cbShowReport.TabIndex = 141;
            this.cbShowReport.Title = null;
            this.cbShowReport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbShowReport_CButtonClicked);
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
            this.tabMain.Size = new System.Drawing.Size(1045, 195);
            this.tabMain.TabIndex = 144;
            this.tabMain.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage1,
            this.uiTabPage3,
            this.uiTabPage4});
            this.tabMain.TabsStateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabMain.TabsStateStyles.FormatStyle.BackgroundImage")));
            this.tabMain.TabStripFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tabMain.UseThemes = false;
            this.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.AutoScroll = true;
            this.uiTabPage2.Controls.Add(this.cgbBranch);
            this.uiTabPage2.Location = new System.Drawing.Point(2, 25);
            this.uiTabPage2.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage2.Size = new System.Drawing.Size(1041, 168);
            this.uiTabPage2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "اطلاعات زمانی/مکانی";
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
            this.uiTabPage3.Controls.Add(this.cgbContract);
            this.uiTabPage3.Location = new System.Drawing.Point(2, 25);
            this.uiTabPage3.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage3.Size = new System.Drawing.Size(1041, 168);
            this.uiTabPage3.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.FormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.HotFormatStyle.BackgroundImage")));
            this.uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiTabPage3.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "اطلاعات قرارداد";
            // 
            // uiTabPage4
            // 
            this.uiTabPage4.AutoScroll = true;
            this.uiTabPage4.Controls.Add(this.chbCustCodeName);
            this.uiTabPage4.Controls.Add(this.cgbCustomer);
            this.uiTabPage4.Location = new System.Drawing.Point(2, 25);
            this.uiTabPage4.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.uiTabPage4.Name = "uiTabPage4";
            this.uiTabPage4.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.uiTabPage4.Size = new System.Drawing.Size(1041, 168);
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
            this.cbCloseAll.Location = new System.Drawing.Point(241, -3);
            this.cbCloseAll.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.cbCloseAll.Name = "cbCloseAll";
            this.cbCloseAll.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCloseAll.Size = new System.Drawing.Size(103, 33);
            this.cbCloseAll.TabIndex = 145;
            this.cbCloseAll.Title = null;
            this.cbCloseAll.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbCloseAll_CButtonClicked);
            // 
            // frmTasvieshode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 529);
            this.Controls.Add(this.cbCloseAll);
            this.Controls.Add(this.cbShowReport);
            this.Controls.Add(this.dgvResoult);
            this.Controls.Add(this.tabMain);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTasvieshode";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmTasvieshode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.cgbCustomer.ResumeLayout(false);
            this.cgbCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).EndInit();
            this.cgbCouterpartName.ResumeLayout(false);
            this.cgbCouterpartName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResoult)).EndInit();
            this.cmsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.uiTabPage3.ResumeLayout(false);
            this.uiTabPage4.ResumeLayout(false);
            this.uiTabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cgbContract;
        private Utilize.Report.UCFiltering ucContractType;
        private Utilize.Report.UCFiltering ucEconomicSector;
        private System.Windows.Forms.GroupBox cgbBranch;
        private Utilize.Report.UCFiltering ucfState;
        private Utilize.Report.UCFiltering ucfOrganization;
        private System.Windows.Forms.DataGridView dgvResoult;
        private Utilize.Company.CButton cbShowReport;
        private System.Windows.Forms.GroupBox cgbCustomer;
        private System.Windows.Forms.DataGridView dgvCounterpartiesNames;
        private System.Windows.Forms.GroupBox cgbCouterpartName;
        private System.Windows.Forms.TextBox txtCounterpartyNameSearch;
        private System.Windows.Forms.RadioButton rdbContains;
        private System.Windows.Forms.RadioButton rdbStartsWith;
        private System.Windows.Forms.RadioButton rdbEndsWith;
        private System.Windows.Forms.RadioButton rbtCounterpartyName;
        private System.Windows.Forms.TextBox txtCounterparty;
        private System.Windows.Forms.TextBox txtCounterPartyName;
        private System.Windows.Forms.RadioButton rbtCounterparty;
        private System.Windows.Forms.CheckBox chbCustCodeName;
        private System.Windows.Forms.TextBox txtCounterpartyNames;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.ToolStripMenuItem btnFulScreenGrid;
        private Janus.Windows.UI.Tab.UITab tabMain;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage4;
        private Utilize.Report.UCFiltering ucfCity;
        private Utilize.Company.CButton cbCloseAll;
    }
}