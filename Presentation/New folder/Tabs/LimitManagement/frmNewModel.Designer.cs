namespace Presentation.Tabs.LimitManagement
{
    partial class frmNewModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewModel));
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.cbClose = new Utilize.Company.CButton();
            this.btnOK = new Utilize.Company.CButton();
            this.btnCancel = new Utilize.Company.CButton();
            this.cmbLimitBase = new Utilize.Company.CComboCox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLimitBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbClose
            // 
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(4, 3);
            this.cbClose.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(40, 33);
            this.cbClose.TabIndex = 51;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnCancel_CButtonClicked);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnOK.DefaultImage")));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnOK.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnOK.HoverImage")));
            this.btnOK.Location = new System.Drawing.Point(157, 87);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Size = new System.Drawing.Size(64, 31);
            this.btnOK.TabIndex = 49;
            this.btnOK.Title = "";
            this.btnOK.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnOK_CButtonClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.DefaultImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Location = new System.Drawing.Point(85, 87);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Size = new System.Drawing.Size(64, 31);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Title = "";
            this.btnCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnCancel_CButtonClicked);
            // 
            // cmbLimitBase
            // 
            this.cmbLimitBase.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance4.ImageBackground")));
            appearance4.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbLimitBase.Appearance = appearance4;
            this.cmbLimitBase.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbLimitBase.AutoSize = false;
            this.cmbLimitBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance5.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance5.ImageBackground")));
            appearance5.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbLimitBase.ButtonAppearance = appearance5;
            this.cmbLimitBase.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbLimitBase.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbLimitBase.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbLimitBase.HideSelection = false;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbLimitBase.ItemAppearance = appearance6;
            valueListItem1.DataValue = "ValueListItem0";
            valueListItem1.DisplayText = "داخلی";
            valueListItem2.DataValue = "ValueListItem1";
            valueListItem2.DisplayText = "بانک مرکزی";
            this.cmbLimitBase.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2});
            this.cmbLimitBase.Location = new System.Drawing.Point(3, 47);
            this.cmbLimitBase.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbLimitBase.Name = "cmbLimitBase";
            this.cmbLimitBase.Size = new System.Drawing.Size(122, 23);
            this.cmbLimitBase.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(238, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "مبنای حدود";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.txtDesc.Appearance = appearance1;
            this.txtDesc.Location = new System.Drawing.Point(3, 8);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDesc.Size = new System.Drawing.Size(122, 23);
            this.txtDesc.TabIndex = 41;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblTitle.Location = new System.Drawing.Point(241, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 22);
            this.lblTitle.TabIndex = 44;
            this.lblTitle.Text = "نام مدل";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(240, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 52;
            this.label1.Text = "تعریف مدل";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtDesc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbLimitBase, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOK, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 125);
            this.tableLayoutPanel1.TabIndex = 53;
            // 
            // frmNewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(331, 186);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClose);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewModel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدل جدید";
            this.Load += new System.EventHandler(this.frmNewModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbLimitBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDesc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private Utilize.Company.CComboCox cmbLimitBase;
        private Utilize.Company.CButton btnOK;
        private Utilize.Company.CButton btnCancel;
        private Utilize.Company.CButton cbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}