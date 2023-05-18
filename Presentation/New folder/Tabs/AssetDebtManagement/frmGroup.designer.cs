namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmGroup
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
            System.Windows.Forms.Label lblCurrency;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGroup));
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            this.btnOK = new Utilize.Company.CButton();
            this.btnCancel = new Utilize.Company.CButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAccountCategory = new Utilize.Company.CComboCox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.txtGroupName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAccountType = new Utilize.Company.CComboCox();
            this.txtTitle = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.rdoTitle = new System.Windows.Forms.RadioButton();
            this.rdoGroup = new System.Windows.Forms.RadioButton();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbClose = new Utilize.Company.CButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCurrency = new Utilize.Company.CComboCox();
            lblCurrency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.BackColor = System.Drawing.Color.Transparent;
            lblCurrency.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            lblCurrency.Location = new System.Drawing.Point(369, 176);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new System.Drawing.Size(27, 27);
            lblCurrency.TabIndex = 146;
            lblCurrency.Text = "ارز";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnOK.DefaultImage")));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnOK.HoverImage")));
            this.btnOK.Location = new System.Drawing.Point(66, 2);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Size = new System.Drawing.Size(71, 34);
            this.btnOK.TabIndex = 9;
            this.btnOK.Title = null;
            this.btnOK.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnOK_Click);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.DefaultImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Location = new System.Drawing.Point(-1, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Size = new System.Drawing.Size(71, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Title = null;
            this.btnCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(355, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "طبقه";
            // 
            // cmbAccountCategory
            // 
            this.cmbAccountCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance3.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance3.ImageBackground")));
            appearance3.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAccountCategory.Appearance = appearance3;
            this.cmbAccountCategory.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbAccountCategory.AutoSize = false;
            this.cmbAccountCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance4.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance4.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance4.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance4.ImageBackground")));
            appearance4.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAccountCategory.ButtonAppearance = appearance4;
            this.cmbAccountCategory.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbAccountCategory.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbAccountCategory.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbAccountCategory.Enabled = false;
            this.cmbAccountCategory.HideSelection = false;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbAccountCategory.ItemAppearance = appearance5;
            this.cmbAccountCategory.Location = new System.Drawing.Point(163, 126);
            this.cmbAccountCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAccountCategory.Name = "cmbAccountCategory";
            this.cmbAccountCategory.Size = new System.Drawing.Size(177, 21);
            this.cmbAccountCategory.TabIndex = 5;
            // 
            // txtGroupName
            // 
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.txtGroupName.Appearance = appearance1;
            this.txtGroupName.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtGroupName.Location = new System.Drawing.Point(104, 87);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(236, 35);
            this.txtGroupName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(363, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "نوع";
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance12.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance12.ImageBackground")));
            appearance12.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAccountType.Appearance = appearance12;
            this.cmbAccountType.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbAccountType.AutoSize = false;
            this.cmbAccountType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance13.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance13.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance13.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance13.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance13.ImageBackground")));
            appearance13.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAccountType.ButtonAppearance = appearance13;
            this.cmbAccountType.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbAccountType.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbAccountType.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbAccountType.Enabled = false;
            this.cmbAccountType.HideSelection = false;
            appearance14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance14.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbAccountType.ItemAppearance = appearance14;
            this.cmbAccountType.Location = new System.Drawing.Point(163, 151);
            this.cmbAccountType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(177, 21);
            this.cmbAccountType.TabIndex = 7;
            // 
            // txtTitle
            // 
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            this.txtTitle.Appearance = appearance2;
            this.txtTitle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTitle.Location = new System.Drawing.Point(104, 50);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(236, 35);
            this.txtTitle.TabIndex = 1;
            // 
            // rdoTitle
            // 
            this.rdoTitle.AutoSize = true;
            this.rdoTitle.BackColor = System.Drawing.Color.Transparent;
            this.rdoTitle.Checked = true;
            this.rdoTitle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoTitle.Location = new System.Drawing.Point(342, 52);
            this.rdoTitle.Name = "rdoTitle";
            this.rdoTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoTitle.Size = new System.Drawing.Size(72, 31);
            this.rdoTitle.TabIndex = 0;
            this.rdoTitle.TabStop = true;
            this.rdoTitle.Text = "عنوان ";
            this.rdoTitle.UseVisualStyleBackColor = false;
            this.rdoTitle.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rdoGroup
            // 
            this.rdoGroup.AutoSize = true;
            this.rdoGroup.BackColor = System.Drawing.Color.Transparent;
            this.rdoGroup.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoGroup.Location = new System.Drawing.Point(352, 88);
            this.rdoGroup.Name = "rdoGroup";
            this.rdoGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoGroup.Size = new System.Drawing.Size(59, 31);
            this.rdoGroup.TabIndex = 2;
            this.rdoGroup.Text = "گروه";
            this.rdoGroup.UseVisualStyleBackColor = false;
            this.rdoGroup.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblColor.ForeColor = System.Drawing.Color.Black;
            this.lblColor.Location = new System.Drawing.Point(29, 50);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(55, 97);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "رنگ";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // cbClose
            // 
            this.cbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(12, 8);
            this.cbClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(30, 28);
            this.cbClose.TabIndex = 144;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(17, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 40);
            this.panel1.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(288, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "  گروههای حسابداری";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance6.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance6.ImageBackground")));
            appearance6.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbCurrency.Appearance = appearance6;
            this.cmbCurrency.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbCurrency.AutoSize = false;
            this.cmbCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance7.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance7.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance7.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance7.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance7.ImageBackground")));
            appearance7.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbCurrency.ButtonAppearance = appearance7;
            this.cmbCurrency.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbCurrency.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbCurrency.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbCurrency.Enabled = false;
            this.cmbCurrency.HideSelection = false;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbCurrency.ItemAppearance = appearance8;
            this.cmbCurrency.Location = new System.Drawing.Point(163, 177);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(177, 21);
            this.cmbCurrency.TabIndex = 147;
            // 
            // frmGroup
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 218);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(lblCurrency);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.rdoGroup);
            this.Controls.Add(this.rdoTitle);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.cmbAccountCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  گروههای حساب  ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGroup_FormClosing);
            this.Load += new System.EventHandler(this.frmGroup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGroup_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmGroup_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurrency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utilize.Company.CButton btnOK;
        private Utilize.Company.CButton btnCancel;
        private System.Windows.Forms.Label label1;
        private Utilize.Company.CComboCox cmbAccountCategory;
        private System.Windows.Forms.ColorDialog colorDialog;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtGroupName;
        private System.Windows.Forms.Label label3;
        private Utilize.Company.CComboCox cmbAccountType;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtTitle;
        private System.Windows.Forms.RadioButton rdoTitle;
        private System.Windows.Forms.RadioButton rdoGroup;
        private System.Windows.Forms.Label lblColor;
        private Utilize.Company.CButton cbClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Utilize.Company.CComboCox cmbCurrency;

    }
}