namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmNewDBM
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
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewDBM));
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.cmbTimeBucket = new Utilize.Company.CComboCox();
            this.lblTimeBucket = new System.Windows.Forms.Label();
            this.txtDesc = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnCancel = new Utilize.Company.CButton();
            this.btnOK = new Utilize.Company.CButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbDLimit = new System.Windows.Forms.Label();
            this.tbDLimit = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.cbClose = new Utilize.Company.CButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fdpModelDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimeBucket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDLimit)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTimeBucket
            // 
            this.cmbTimeBucket.Anchor = System.Windows.Forms.AnchorStyles.Left;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance3.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance3.ImageBackground")));
            appearance3.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbTimeBucket.Appearance = appearance3;
            this.cmbTimeBucket.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbTimeBucket.AutoSize = false;
            this.cmbTimeBucket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance4.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance4.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance4.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance4.ImageBackground")));
            appearance4.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbTimeBucket.ButtonAppearance = appearance4;
            this.cmbTimeBucket.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbTimeBucket.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbTimeBucket.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbTimeBucket.HideSelection = false;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbTimeBucket.ItemAppearance = appearance5;
            this.cmbTimeBucket.Location = new System.Drawing.Point(3, 34);
            this.cmbTimeBucket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTimeBucket.Name = "cmbTimeBucket";
            this.cmbTimeBucket.Size = new System.Drawing.Size(140, 21);
            this.cmbTimeBucket.TabIndex = 51;
            // 
            // lblTimeBucket
            // 
            this.lblTimeBucket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeBucket.AutoSize = true;
            this.lblTimeBucket.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeBucket.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTimeBucket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimeBucket.Location = new System.Drawing.Point(289, 30);
            this.lblTimeBucket.Name = "lblTimeBucket";
            this.lblTimeBucket.Size = new System.Drawing.Size(58, 20);
            this.lblTimeBucket.TabIndex = 56;
            this.lblTimeBucket.Text = "بسته زمانی";
            // 
            // txtDesc
            // 
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            this.txtDesc.Appearance = appearance2;
            this.txtDesc.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDesc.Location = new System.Drawing.Point(3, 3);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(140, 30);
            this.txtDesc.TabIndex = 50;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.DefaultImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Location = new System.Drawing.Point(108, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Size = new System.Drawing.Size(64, 28);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Title = null;
            this.btnCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnCancel_CButtonClicked);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnOK.DefaultImage")));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnOK.HoverImage")));
            this.btnOK.Location = new System.Drawing.Point(178, 123);
            this.btnOK.Name = "btnOK";
            this.btnOK.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Size = new System.Drawing.Size(64, 28);
            this.btnOK.TabIndex = 53;
            this.btnOK.Title = null;
            this.btnOK.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnOK_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(310, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 20);
            this.lblTitle.TabIndex = 55;
            this.lblTitle.Text = "عنوان";
            // 
            // lbDLimit
            // 
            this.lbDLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDLimit.AutoSize = true;
            this.lbDLimit.BackColor = System.Drawing.Color.Transparent;
            this.lbDLimit.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbDLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbDLimit.Location = new System.Drawing.Point(288, 60);
            this.lbDLimit.Name = "lbDLimit";
            this.lbDLimit.Size = new System.Drawing.Size(59, 20);
            this.lbDLimit.TabIndex = 57;
            this.lbDLimit.Text = "حد مشتری";
            // 
            // tbDLimit
            // 
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.tbDLimit.Appearance = appearance1;
            this.tbDLimit.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbDLimit.Location = new System.Drawing.Point(3, 63);
            this.tbDLimit.Name = "tbDLimit";
            this.tbDLimit.Size = new System.Drawing.Size(140, 30);
            this.tbDLimit.TabIndex = 58;
            this.tbDLimit.TextChanged += new System.EventHandler(this.tbDLimit_TextChanged);
            // 
            // cbClose
            // 
            this.cbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(8, 6);
            this.cbClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(30, 30);
            this.cbClose.TabIndex = 144;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(273, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "تعریف مدل رفتار مشتری";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fdpModelDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDesc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTimeBucket, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbDLimit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbDLimit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbTimeBucket, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOK, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 154);
            this.tableLayoutPanel1.TabIndex = 145;
            // 
            // fdpModelDate
            // 
            this.fdpModelDate.Font = null;
            this.fdpModelDate.Location = new System.Drawing.Point(3, 93);
            this.fdpModelDate.Name = "fdpModelDate";
            this.fdpModelDate.Size = new System.Drawing.Size(140, 24);
            this.fdpModelDate.TabIndex = 146;
            this.fdpModelDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(292, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "تاریخ مدل";
            // 
            // frmNewDBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(433, 213);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewDBM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف مدل رفتار مشتری";
            this.Load += new System.EventHandler(this.frmNewDBM_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNewCBM_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimeBucket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDLimit)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utilize.Company.CComboCox cmbTimeBucket;
        private System.Windows.Forms.Label lblTimeBucket;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDesc;
        private Utilize.Company.CButton btnCancel;
        private Utilize.Company.CButton btnOK;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbDLimit;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor tbDLimit;
        private Utilize.Company.CButton cbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FarsiLibrary.Win.Controls.FADatePicker fdpModelDate;
        private System.Windows.Forms.Label label2;
    }
}