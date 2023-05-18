namespace Utilize.Company
{
	partial class frmLogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogo));
            this.pcbLogoCompuCo = new System.Windows.Forms.PictureBox();
            this.lblNameOfProduct = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pcbLogoCustomer = new System.Windows.Forms.PictureBox();
            this.timerWaiting = new System.Windows.Forms.Timer(this.components);
            this.lnkCompany = new System.Windows.Forms.LinkLabel();
            this.pcbTop = new System.Windows.Forms.PictureBox();
            this.lblNameOfCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCompuCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTop)).BeginInit();
            this.pcbTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbLogoCompuCo
            // 
            this.pcbLogoCompuCo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogoCompuCo.Image = global::Utilize.Properties.Resources.logo_center;
            this.pcbLogoCompuCo.Location = new System.Drawing.Point(284, 56);
            this.pcbLogoCompuCo.Name = "pcbLogoCompuCo";
            this.pcbLogoCompuCo.Size = new System.Drawing.Size(241, 227);
            this.pcbLogoCompuCo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoCompuCo.TabIndex = 0;
            this.pcbLogoCompuCo.TabStop = false;
            this.pcbLogoCompuCo.UseWaitCursor = true;
            // 
            // lblNameOfProduct
            // 
            this.lblNameOfProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblNameOfProduct.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNameOfProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.lblNameOfProduct.Location = new System.Drawing.Point(214, 9);
            this.lblNameOfProduct.Name = "lblNameOfProduct";
            this.lblNameOfProduct.Size = new System.Drawing.Size(311, 20);
            this.lblNameOfProduct.TabIndex = 2;
            this.lblNameOfProduct.Text = "Name Of Product";
            this.lblNameOfProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNameOfProduct.UseWaitCursor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.lblDate.Location = new System.Drawing.Point(14, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(122, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date Of Release";
            this.lblDate.UseWaitCursor = true;
            // 
            // pcbLogoCustomer
            // 
            this.pcbLogoCustomer.Image = global::Utilize.Properties.Resources.TAT;
            this.pcbLogoCustomer.Location = new System.Drawing.Point(12, 92);
            this.pcbLogoCustomer.Name = "pcbLogoCustomer";
            this.pcbLogoCustomer.Size = new System.Drawing.Size(266, 191);
            this.pcbLogoCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogoCustomer.TabIndex = 4;
            this.pcbLogoCustomer.TabStop = false;
            this.pcbLogoCustomer.UseWaitCursor = true;
            // 
            // timerWaiting
            // 
            this.timerWaiting.Enabled = true;
            this.timerWaiting.Interval = 1000;
            this.timerWaiting.Tick += new System.EventHandler(this.timerWaiting_Tick);
            // 
            // lnkCompany
            // 
            this.lnkCompany.AutoSize = true;
            this.lnkCompany.BackColor = System.Drawing.Color.Transparent;
            this.lnkCompany.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnkCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.lnkCompany.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkCompany.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.lnkCompany.Location = new System.Drawing.Point(387, 63);
            this.lnkCompany.Name = "lnkCompany";
            this.lnkCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lnkCompany.Size = new System.Drawing.Size(129, 26);
            this.lnkCompany.TabIndex = 5;
            this.lnkCompany.TabStop = true;
            this.lnkCompany.Tag = "http://www.compucointer.com/fa/";
            this.lnkCompany.Text = "شرکت کامپیوکو اینتر";
            this.lnkCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkCompany.UseWaitCursor = true;
            this.lnkCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCompany_LinkClicked);
            // 
            // pcbTop
            // 
            this.pcbTop.Controls.Add(this.lblNameOfProduct);
            this.pcbTop.Controls.Add(this.lblDate);
            this.pcbTop.Image = global::Utilize.Properties.Resources.TB;
            this.pcbTop.Location = new System.Drawing.Point(0, 0);
            this.pcbTop.Name = "pcbTop";
            this.pcbTop.Size = new System.Drawing.Size(537, 50);
            this.pcbTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbTop.TabIndex = 6;
            this.pcbTop.TabStop = false;
            this.pcbTop.UseWaitCursor = true;
            // 
            // lblNameOfCustomer
            // 
            this.lblNameOfCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblNameOfCustomer.Font = new System.Drawing.Font("Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNameOfCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.lblNameOfCustomer.Location = new System.Drawing.Point(12, 53);
            this.lblNameOfCustomer.Name = "lblNameOfCustomer";
            this.lblNameOfCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNameOfCustomer.Size = new System.Drawing.Size(266, 36);
            this.lblNameOfCustomer.TabIndex = 1;
            this.lblNameOfCustomer.Text = "تجربه،اعتماد،توسعه";
            this.lblNameOfCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameOfCustomer.UseWaitCursor = true;
            // 
            // frmLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 295);
            this.Controls.Add(this.lblNameOfCustomer);
            this.Controls.Add(this.lnkCompany);
            this.Controls.Add(this.pcbTop);
            this.Controls.Add(this.pcbLogoCompuCo);
            this.Controls.Add(this.pcbLogoCustomer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCompuCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTop)).EndInit();
            this.pcbTop.ResumeLayout(false);
            this.pcbTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.PictureBox pcbLogoCompuCo;
        private System.Windows.Forms.Label lblNameOfProduct;
		private System.Windows.Forms.PictureBox pcbLogoCustomer;
		private System.Windows.Forms.Timer timerWaiting;
        private System.Windows.Forms.LinkLabel lnkCompany;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pcbTop;
        private System.Windows.Forms.Label lblNameOfCustomer;
	}
}