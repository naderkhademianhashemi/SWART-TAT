namespace Presentation.Loan
{
	partial class frmTotalLoanReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTotalLoanReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbCustomerGroup = new System.Windows.Forms.CheckBox();
            this.chbEconomicSector = new System.Windows.Forms.CheckBox();
            this.chbCounterpartyType = new System.Windows.Forms.CheckBox();
            this.chbContractTypeGroups = new System.Windows.Forms.CheckBox();
            this.chbContractType = new System.Windows.Forms.CheckBox();
            this.chbMajorTypeContract = new System.Windows.Forms.CheckBox();
            this.chbTotal = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fdpFrom = new FarsiLibrary.Win.Controls.FADatePicker();
            this.fdpTo = new FarsiLibrary.Win.Controls.FADatePicker();
            this.btnSetting = new Utilize.Company.CButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMain = new Janus.Windows.UI.Tab.UITab();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbCustomerGroup);
            this.groupBox1.Controls.Add(this.chbEconomicSector);
            this.groupBox1.Controls.Add(this.chbCounterpartyType);
            this.groupBox1.Controls.Add(this.chbContractTypeGroups);
            this.groupBox1.Controls.Add(this.chbContractType);
            this.groupBox1.Controls.Add(this.chbMajorTypeContract);
            this.groupBox1.Controls.Add(this.chbTotal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3);
            this.groupBox1.Size = new System.Drawing.Size(149, 389);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "به تفکیک";
            // 
            // chbCustomerGroup
            // 
            this.chbCustomerGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCustomerGroup.AutoSize = true;
            this.chbCustomerGroup.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbCustomerGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chbCustomerGroup.Location = new System.Drawing.Point(55, 206);
            this.chbCustomerGroup.Name = "chbCustomerGroup";
            this.chbCustomerGroup.Size = new System.Drawing.Size(85, 24);
            this.chbCustomerGroup.TabIndex = 6;
            this.chbCustomerGroup.Text = "گروه مشتری";
            this.chbCustomerGroup.UseVisualStyleBackColor = true;
            this.chbCustomerGroup.CheckedChanged += new System.EventHandler(this.chbCustomerGroup_CheckedChanged);
            // 
            // chbEconomicSector
            // 
            this.chbEconomicSector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbEconomicSector.AutoSize = true;
            this.chbEconomicSector.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbEconomicSector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chbEconomicSector.Location = new System.Drawing.Point(46, 144);
            this.chbEconomicSector.Name = "chbEconomicSector";
            this.chbEconomicSector.Size = new System.Drawing.Size(94, 24);
            this.chbEconomicSector.TabIndex = 4;
            this.chbEconomicSector.Text = "بخش اقتصادی";
            this.chbEconomicSector.UseVisualStyleBackColor = true;
            this.chbEconomicSector.CheckedChanged += new System.EventHandler(this.chbEconomicSector_CheckedChanged);
            // 
            // chbCounterpartyType
            // 
            this.chbCounterpartyType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCounterpartyType.AutoSize = true;
            this.chbCounterpartyType.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbCounterpartyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chbCounterpartyType.Location = new System.Drawing.Point(60, 175);
            this.chbCounterpartyType.Name = "chbCounterpartyType";
            this.chbCounterpartyType.Size = new System.Drawing.Size(80, 24);
            this.chbCounterpartyType.TabIndex = 5;
            this.chbCounterpartyType.Text = "نوع مشتری";
            this.chbCounterpartyType.UseVisualStyleBackColor = true;
            this.chbCounterpartyType.CheckedChanged += new System.EventHandler(this.chbCounterpartyType_CheckedChanged);
            // 
            // chbContractTypeGroups
            // 
            this.chbContractTypeGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbContractTypeGroups.AutoSize = true;
            this.chbContractTypeGroups.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbContractTypeGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chbContractTypeGroups.Location = new System.Drawing.Point(36, 113);
            this.chbContractTypeGroups.Name = "chbContractTypeGroups";
            this.chbContractTypeGroups.Size = new System.Drawing.Size(104, 24);
            this.chbContractTypeGroups.TabIndex = 3;
            this.chbContractTypeGroups.Text = "نوع گروه قرارداد";
            this.chbContractTypeGroups.UseVisualStyleBackColor = true;
            this.chbContractTypeGroups.CheckedChanged += new System.EventHandler(this.chbContractTypeGroups_CheckedChanged);
            // 
            // chbContractType
            // 
            this.chbContractType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbContractType.AutoSize = true;
            this.chbContractType.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbContractType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chbContractType.Location = new System.Drawing.Point(30, 82);
            this.chbContractType.Name = "chbContractType";
            this.chbContractType.Size = new System.Drawing.Size(110, 24);
            this.chbContractType.TabIndex = 2;
            this.chbContractType.Text = "نوع اصلی قرار داد";
            this.chbContractType.UseVisualStyleBackColor = true;
            this.chbContractType.CheckedChanged += new System.EventHandler(this.chbContractType_CheckedChanged);
            // 
            // chbMajorTypeContract
            // 
            this.chbMajorTypeContract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbMajorTypeContract.AutoSize = true;
            this.chbMajorTypeContract.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbMajorTypeContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chbMajorTypeContract.Location = new System.Drawing.Point(39, 51);
            this.chbMajorTypeContract.Name = "chbMajorTypeContract";
            this.chbMajorTypeContract.Size = new System.Drawing.Size(101, 24);
            this.chbMajorTypeContract.TabIndex = 1;
            this.chbMajorTypeContract.Text = "نوع کلی قرارداد";
            this.chbMajorTypeContract.UseVisualStyleBackColor = true;
            this.chbMajorTypeContract.CheckedChanged += new System.EventHandler(this.chbMajorTypeContract_CheckedChanged);
            // 
            // chbTotal
            // 
            this.chbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbTotal.AutoSize = true;
            this.chbTotal.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chbTotal.Location = new System.Drawing.Point(57, 20);
            this.chbTotal.Name = "chbTotal";
            this.chbTotal.Size = new System.Drawing.Size(83, 24);
            this.chbTotal.TabIndex = 0;
            this.chbTotal.Text = "بر حسب کل";
            this.chbTotal.UseVisualStyleBackColor = true;
            this.chbTotal.CheckedChanged += new System.EventHandler(this.chbTotal_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fdpFrom);
            this.groupBox2.Controls.Add(this.fdpTo);
            this.groupBox2.Controls.Add(this.btnSetting);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3);
            this.groupBox2.Size = new System.Drawing.Size(784, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.Text = "تنظیمات اولیه";
            // 
            // fdpFrom
            // 
            this.fdpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFrom.Location = new System.Drawing.Point(541, 18);
            this.fdpFrom.Name = "fdpFrom";
            this.fdpFrom.Size = new System.Drawing.Size(159, 20);
            this.fdpFrom.TabIndex = 0;
            // 
            // fdpTo
            // 
            this.fdpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpTo.Location = new System.Drawing.Point(308, 18);
            this.fdpTo.Name = "fdpTo";
            this.fdpTo.Size = new System.Drawing.Size(159, 20);
            this.fdpTo.TabIndex = 1;
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.AutoSize = true;
            this.btnSetting.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.DefaultImage")));
            this.btnSetting.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSetting.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.HoverImage")));
            this.btnSetting.Location = new System.Drawing.Point(15, 15);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetting.Size = new System.Drawing.Size(130, 26);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Title = null;
            this.btnSetting.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnSetting_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(473, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "تا تاریخ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(706, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "از تاریخ";
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(170)))), ((int)(((byte)(108)))));
            this.tabMain.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.PanelFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabMain.PanelFormatStyle.BackgroundImage")));
            this.tabMain.Size = new System.Drawing.Size(631, 389);
            this.tabMain.TabIndex = 3;
            this.tabMain.UseThemes = false;
            this.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.VS2005;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(784, 389);
            this.splitContainer1.SplitterDistance = 149;
            this.splitContainer1.TabIndex = 4;
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
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(784, 459);
            this.splitContainer2.SplitterDistance = 67;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 5;
            // 
            // frmTotalLoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 459);
            this.Controls.Add(this.splitContainer2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTotalLoanReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "گزارش جامع تسهیلات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTotalLoanReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
		private Utilize.Company.CButton btnSetting;
		//private FarsiLibrary.Win.Controls.FADatePicker fdpTo;
		//private FarsiLibrary.Win.Controls.FADatePicker fdpFrom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chbTotal;
		private System.Windows.Forms.CheckBox chbMajorTypeContract;
		private System.Windows.Forms.CheckBox chbContractType;
		private System.Windows.Forms.CheckBox chbContractTypeGroups;
		private System.Windows.Forms.CheckBox chbEconomicSector;
		private System.Windows.Forms.CheckBox chbCustomerGroup;
		private System.Windows.Forms.CheckBox chbCounterpartyType;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFrom;
        private FarsiLibrary.Win.Controls.FADatePicker fdpTo;
        private Janus.Windows.UI.Tab.UITab tabMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;

	}
}