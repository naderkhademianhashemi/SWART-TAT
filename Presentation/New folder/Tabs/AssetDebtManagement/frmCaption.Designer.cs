namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmCaption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaption));
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.btnOK = new Utilize.Company.CButton();
            this.txtGroupTitle = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.rdoGroupTitle = new System.Windows.Forms.RadioButton();
            this.rdoAccountGroup = new System.Windows.Forms.RadioButton();
            this.btnCancel = new Utilize.Company.CButton();
            this.lblColor = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.cbClose = new Utilize.Company.CButton();
            this.cmbGroupName = new Utilize.Company.CComboCox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroupName)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnOK.DefaultImage")));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnOK.HoverImage")));
            this.btnOK.Location = new System.Drawing.Point(95, 2);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Size = new System.Drawing.Size(65, 34);
            this.btnOK.TabIndex = 3;
            this.btnOK.Title = "";
            this.btnOK.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnOK_Click);
            // 
            // txtGroupTitle
            // 
            appearance4.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance4.ImageBackground")));
            this.txtGroupTitle.Appearance = appearance4;
            this.txtGroupTitle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtGroupTitle.Location = new System.Drawing.Point(61, 74);
            this.txtGroupTitle.Name = "txtGroupTitle";
            this.txtGroupTitle.Size = new System.Drawing.Size(469, 35);
            this.txtGroupTitle.TabIndex = 1;
            // 
            // rdoGroupTitle
            // 
            this.rdoGroupTitle.AutoSize = true;
            this.rdoGroupTitle.BackColor = System.Drawing.Color.Transparent;
            this.rdoGroupTitle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoGroupTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoGroupTitle.Location = new System.Drawing.Point(553, 81);
            this.rdoGroupTitle.Name = "rdoGroupTitle";
            this.rdoGroupTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoGroupTitle.Size = new System.Drawing.Size(79, 31);
            this.rdoGroupTitle.TabIndex = 7;
            this.rdoGroupTitle.Text = "نام گروه";
            this.rdoGroupTitle.UseVisualStyleBackColor = false;
            this.rdoGroupTitle.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rdoAccountGroup
            // 
            this.rdoAccountGroup.AutoSize = true;
            this.rdoAccountGroup.BackColor = System.Drawing.Color.Transparent;
            this.rdoAccountGroup.Checked = true;
            this.rdoAccountGroup.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoAccountGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoAccountGroup.Location = new System.Drawing.Point(530, 43);
            this.rdoAccountGroup.Name = "rdoAccountGroup";
            this.rdoAccountGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoAccountGroup.Size = new System.Drawing.Size(102, 31);
            this.rdoAccountGroup.TabIndex = 6;
            this.rdoAccountGroup.TabStop = true;
            this.rdoAccountGroup.Text = "گروه حساب";
            this.rdoAccountGroup.UseVisualStyleBackColor = false;
            this.rdoAccountGroup.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.DefaultImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Location = new System.Drawing.Point(24, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Size = new System.Drawing.Size(65, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Title = "";
            this.btnCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnCancel_Click);
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblColor.ForeColor = System.Drawing.Color.Black;
            this.lblColor.Location = new System.Drawing.Point(15, 42);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 67);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "رنگ";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // cbClose
            // 
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(12, 6);
            this.cbClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(30, 30);
            this.cbClose.TabIndex = 8;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // cmbGroupName
            // 
            this.cmbGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            appearance1.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbGroupName.Appearance = appearance1;
            this.cmbGroupName.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbGroupName.AutoSize = false;
            this.cmbGroupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            appearance2.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbGroupName.ButtonAppearance = appearance2;
            this.cmbGroupName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbGroupName.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbGroupName.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbGroupName.HideSelection = false;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbGroupName.ItemAppearance = appearance3;
            this.cmbGroupName.Location = new System.Drawing.Point(61, 46);
            this.cmbGroupName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbGroupName.Name = "cmbGroupName";
            this.cmbGroupName.Size = new System.Drawing.Size(469, 23);
            this.cmbGroupName.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(230, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 39);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label3.Location = new System.Drawing.Point(473, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "گروه حساب";
            // 
            // frmCaption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 175);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbGroupName);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtGroupTitle);
            this.Controls.Add(this.rdoGroupTitle);
            this.Controls.Add(this.rdoAccountGroup);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaption";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گروه حساب";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCaption_FormClosing);
            this.Load += new System.EventHandler(this.frmCaption_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCaption_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCaption_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroupName)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utilize.Company.CButton btnOK;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtGroupTitle;
        private System.Windows.Forms.RadioButton rdoGroupTitle;
        private System.Windows.Forms.RadioButton rdoAccountGroup;
        private Utilize.Company.CButton btnCancel;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private Utilize.Company.CButton cbClose;
        private Utilize.Company.CComboCox cmbGroupName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;

    }
}