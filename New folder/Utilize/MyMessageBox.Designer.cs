namespace Utilize
{
	public partial class MyMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMessageBox));
            this.lblMessage = new System.Windows.Forms.Label();
            this.pcbExpand = new System.Windows.Forms.PictureBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnOK = new Utilize.Company.CButton();
            this.btnCancel = new Utilize.Company.CButton();
            this.btnYes = new Utilize.Company.CButton();
            this.btnNo = new Utilize.Company.CButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbClose = new Utilize.Company.CButton();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(30, 51);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(430, 73);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcbExpand
            // 
            this.pcbExpand.BackColor = System.Drawing.Color.Transparent;
            this.pcbExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbExpand.Image = global::Utilize.Properties.Resources.XParrow_Collapse;
            this.pcbExpand.Location = new System.Drawing.Point(44, 134);
            this.pcbExpand.Name = "pcbExpand";
            this.pcbExpand.Size = new System.Drawing.Size(20, 22);
            this.pcbExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbExpand.TabIndex = 3;
            this.pcbExpand.TabStop = false;
            this.pcbExpand.Click += new System.EventHandler(this.pcbExpand_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.BackColor = System.Drawing.Color.White;
            this.lblInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInformation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(30, 173);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(430, 60);
            this.lblInformation.TabIndex = 4;
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnOK.DefaultImage")));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOK.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnOK.HoverImage")));
            this.btnOK.Location = new System.Drawing.Point(172, 130);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Size = new System.Drawing.Size(75, 37);
            this.btnOK.TabIndex = 5;
            this.btnOK.Title = "تأیید";
            this.btnOK.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.DefaultImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Location = new System.Drawing.Point(72, 130);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Size = new System.Drawing.Size(75, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Title = "انصراف";
            this.btnCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnCancel_Click);
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.BackColor = System.Drawing.Color.Transparent;
            this.btnYes.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnYes.DefaultImage")));
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnYes.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnYes.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnYes.HoverImage")));
            this.btnYes.Location = new System.Drawing.Point(356, 130);
            this.btnYes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnYes.Name = "btnYes";
            this.btnYes.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYes.Size = new System.Drawing.Size(75, 37);
            this.btnYes.TabIndex = 8;
            this.btnYes.Title = "بله";
            this.btnYes.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnNo.DefaultImage")));
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNo.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNo.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnNo.HoverImage")));
            this.btnNo.Location = new System.Drawing.Point(257, 130);
            this.btnNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnNo.Name = "btnNo";
            this.btnNo.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNo.Size = new System.Drawing.Size(75, 37);
            this.btnNo.TabIndex = 9;
            this.btnNo.Title = "خیر";
            this.btnNo.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnNo_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("B Nazanin", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblTitle.Location = new System.Drawing.Point(388, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 33);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "عنوان";
            // 
            // cbClose
            // 
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(15, 7);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(29, 27);
            this.cbClose.TabIndex = 144;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // pcbIcon
            // 
            this.pcbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pcbIcon.Image = global::Utilize.Properties.Resources.Symbol_Check;
            this.pcbIcon.Location = new System.Drawing.Point(447, 14);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(25, 25);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcon.TabIndex = 0;
            this.pcbIcon.TabStop = false;
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 242);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pcbExpand);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pcbIcon);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyMessageBox";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MyMessageBox";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MyMessageBox_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pcbExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        internal System.Windows.Forms.Label lblMessage;
		internal System.Windows.Forms.PictureBox pcbExpand;
		internal System.Windows.Forms.Label lblInformation;
		private Utilize.Company.CButton btnOK;
        private Utilize.Company.CButton btnCancel;
		private Utilize.Company.CButton btnYes;
        private Utilize.Company.CButton btnNo;
        internal System.Windows.Forms.Label lblTitle;
        private Utilize.Company.CButton cbClose;
        private System.Windows.Forms.PictureBox pcbIcon;
	}
}