namespace Presentation.Tabs.FinancialRatio
{
    partial class frmFncGroup
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFncGroup));
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            this.lblColor = new System.Windows.Forms.Label();
            this.rdoGroup = new System.Windows.Forms.RadioButton();
            this.cmbAccountType = new Utilize.Company.CComboCox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGroupName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.cmbAccountCategory = new Utilize.Company.CComboCox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new Utilize.Company.CButton();
            this.btnCancel = new Utilize.Company.CButton();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClose = new Utilize.Company.CButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountCategory)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblColor.Location = new System.Drawing.Point(61, 43);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(47, 79);
            this.lblColor.TabIndex = 19;
            this.lblColor.Text = "رنگ";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // rdoGroup
            // 
            this.rdoGroup.AutoSize = true;
            this.rdoGroup.BackColor = System.Drawing.Color.Transparent;
            this.rdoGroup.Checked = true;
            this.rdoGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.rdoGroup.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoGroup.Location = new System.Drawing.Point(194, 3);
            this.rdoGroup.Name = "rdoGroup";
            this.rdoGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoGroup.Size = new System.Drawing.Size(48, 25);
            this.rdoGroup.TabIndex = 13;
            this.rdoGroup.TabStop = true;
            this.rdoGroup.Text = "گروه";
            this.rdoGroup.UseVisualStyleBackColor = false;
            // 
            // cmbAccountType
            // 
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            appearance1.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAccountType.Appearance = appearance1;
            this.cmbAccountType.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbAccountType.AutoSize = false;
            this.cmbAccountType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            appearance2.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAccountType.ButtonAppearance = appearance2;
            this.cmbAccountType.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbAccountType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbAccountType.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbAccountType.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.DiagonalResize;
            this.cmbAccountType.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbAccountType.HideSelection = false;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbAccountType.ItemAppearance = appearance3;
            this.cmbAccountType.Location = new System.Drawing.Point(3, 35);
            this.cmbAccountType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(175, 22);
            this.cmbAccountType.TabIndex = 18;
            this.cmbAccountType.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label3.Location = new System.Drawing.Point(217, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "نوع";
            this.label3.Visible = false;
            // 
            // txtGroupName
            // 
            appearance4.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance4.ImageBackground")));
            this.txtGroupName.Appearance = appearance4;
            this.txtGroupName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGroupName.Location = new System.Drawing.Point(3, 3);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(175, 22);
            this.txtGroupName.TabIndex = 14;
            // 
            // cmbAccountCategory
            // 
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance5.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance5.ImageBackground")));
            appearance5.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAccountCategory.Appearance = appearance5;
            this.cmbAccountCategory.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbAccountCategory.AutoSize = false;
            this.cmbAccountCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance6.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance6.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance6.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance6.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance6.ImageBackground")));
            appearance6.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAccountCategory.ButtonAppearance = appearance6;
            this.cmbAccountCategory.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbAccountCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbAccountCategory.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbAccountCategory.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.DiagonalResize;
            this.cmbAccountCategory.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbAccountCategory.HideSelection = false;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbAccountCategory.ItemAppearance = appearance7;
            this.cmbAccountCategory.Location = new System.Drawing.Point(3, 65);
            this.cmbAccountCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAccountCategory.Name = "cmbAccountCategory";
            this.cmbAccountCategory.Size = new System.Drawing.Size(175, 21);
            this.cmbAccountCategory.TabIndex = 16;
            this.cmbAccountCategory.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(211, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "طبقه";
            this.label1.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnOK.DefaultImage")));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOK.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnOK.HoverImage")));
            this.btnOK.Location = new System.Drawing.Point(104, 4);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Size = new System.Drawing.Size(67, 32);
            this.btnOK.TabIndex = 20;
            this.btnOK.Title = null;
            this.btnOK.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.DefaultImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Location = new System.Drawing.Point(29, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Size = new System.Drawing.Size(67, 32);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Title = null;
            this.btnCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(284, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 149;
            this.label2.Text = "بازه جدید  ";
            // 
            // cbClose
            // 
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(0, 0);
            this.cbClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.cbClose.Size = new System.Drawing.Size(38, 190);
            this.cbClose.TabIndex = 148;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.80952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Controls.Add(this.rdoGroup, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbAccountCategory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbAccountType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtGroupName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(110, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.84746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 90);
            this.tableLayoutPanel1.TabIndex = 150;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnOK, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(86, 142);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 40);
            this.tableLayoutPanel2.TabIndex = 151;
            // 
            // frmFncGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 190);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFncGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گروه حساب";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFncGroup_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFncGroup_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmFncGroup_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountCategory)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.RadioButton rdoGroup;
        private Utilize.Company.CComboCox cmbAccountType;
        private System.Windows.Forms.Label label3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtGroupName;
        private Utilize.Company.CComboCox cmbAccountCategory;
        private System.Windows.Forms.Label label1;
        private Utilize.Company.CButton btnOK;
        private Utilize.Company.CButton btnCancel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label2;
        private Utilize.Company.CButton cbClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}