namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmTBDynamic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTBDynamic));
            this.lblColor = new System.Windows.Forms.Label();
            this.txtTimeBucket = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnOK = new Button();
            this.btnCancel = new Button();
            this.lblTimeBucket = new System.Windows.Forms.Label();
            this.lblBucketType = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.cbClose = new Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.fdpFrom = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.fdpTo = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblColor.Location = new System.Drawing.Point(22, 50);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(60, 90);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "رنگ بسته";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // txtTimeBucket
            // 
            this.txtTimeBucket.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTimeBucket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTimeBucket.Location = new System.Drawing.Point(66, 240);
            this.txtTimeBucket.Name = "txtTimeBucket";
            this.txtTimeBucket.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimeBucket.Size = new System.Drawing.Size(186, 33);
            this.txtTimeBucket.TabIndex = 1;
            this.txtTimeBucket.Visible = false;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLength.Location = new System.Drawing.Point(197, 140);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(88, 33);
            this.txtLength.TabIndex = 2;
            this.txtLength.Text = "1";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnOK.DefaultImage")));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnOK.HoverImage")));
            this.btnOK.Location = new System.Drawing.Point(102, 3);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Size = new System.Drawing.Size(65, 37);
            this.btnOK.TabIndex = 4;
            this.btnOK.Title = null;
            this.btnOK.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.DefaultImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Location = new System.Drawing.Point(34, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Size = new System.Drawing.Size(65, 37);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Title = null;
            this.btnCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // lblTimeBucket
            // 
            this.lblTimeBucket.AutoSize = true;
            this.lblTimeBucket.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeBucket.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTimeBucket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblTimeBucket.Location = new System.Drawing.Point(258, 245);
            this.lblTimeBucket.Name = "lblTimeBucket";
            this.lblTimeBucket.Size = new System.Drawing.Size(61, 27);
            this.lblTimeBucket.TabIndex = 7;
            this.lblTimeBucket.Text = "نام بسته";
            this.lblTimeBucket.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTimeBucket.Visible = false;
            // 
            // lblBucketType
            // 
            this.lblBucketType.AutoSize = true;
            this.lblBucketType.BackColor = System.Drawing.Color.Transparent;
            this.lblBucketType.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBucketType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblBucketType.Location = new System.Drawing.Point(292, 114);
            this.lblBucketType.Name = "lblBucketType";
            this.lblBucketType.Size = new System.Drawing.Size(66, 27);
            this.lblBucketType.TabIndex = 6;
            this.lblBucketType.Text = "نوع بسته";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.BackColor = System.Drawing.Color.Transparent;
            this.lblLength.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblLength.Location = new System.Drawing.Point(300, 144);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(38, 27);
            this.lblLength.TabIndex = 8;
            this.lblLength.Text = "طول";
            // 
            // cbClose
            // 
            this.cbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(245, 61);
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
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "بسته زمانی داینامیک";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(85, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 43);
            this.panel1.TabIndex = 145;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Location = new System.Drawing.Point(155, 50);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.fdpFrom);
            this.splitContainer9.Panel1.Controls.Add(this.label3);
            this.splitContainer9.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.fdpTo);
            this.splitContainer9.Panel2.Controls.Add(this.label4);
            this.splitContainer9.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer9.Size = new System.Drawing.Size(195, 55);
            this.splitContainer9.SplitterDistance = 25;
            this.splitContainer9.TabIndex = 146;
            // 
            // fdpFrom
            // 
            this.fdpFrom.Location = new System.Drawing.Point(-18, 7);
            this.fdpFrom.Name = "fdpFrom";
            this.fdpFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fdpFrom.Size = new System.Drawing.Size(127, 19);
            this.fdpFrom.TabIndex = 37;
            this.fdpFrom.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(115, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "تاریخ شروع";
            // 
            // fdpTo
            // 
            this.fdpTo.Location = new System.Drawing.Point(-18, 3);
            this.fdpTo.Name = "fdpTo";
            this.fdpTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fdpTo.Size = new System.Drawing.Size(127, 19);
            this.fdpTo.TabIndex = 38;
            this.fdpTo.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(121, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "تاریخ پایان";
            // 
            // frmTBDynamic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 294);
            this.Controls.Add(this.splitContainer9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.lblTimeBucket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBucketType);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtTimeBucket);
            this.Controls.Add(this.txtLength);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTBDynamic";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بسته زمانی";
            this.Load += new System.EventHandler(this.frmTimeBucketDetail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTB_KeyDown);
            this.panel1.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel1.PerformLayout();
            this.splitContainer9.Panel2.ResumeLayout(false);
            this.splitContainer9.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtTimeBucket;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.ComboBox cmbBucketType;
        private Button btnOK;
        private Button btnCancel;
        private System.Windows.Forms.Label lblTimeBucket;
        private System.Windows.Forms.Label lblBucketType;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.ColorDialog colorDialog;
        private Button cbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFrom;
        private System.Windows.Forms.Label label3;
        private FarsiLibrary.Win.Controls.FADatePicker fdpTo;
        private System.Windows.Forms.Label label4;
    }
}