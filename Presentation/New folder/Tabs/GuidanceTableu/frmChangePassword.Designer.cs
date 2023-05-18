namespace Presentation.Tabs.GuidanceTableu
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            this.pnl06 = new System.Windows.Forms.Panel();
            this.pnlEditPass = new DevComponents.DotNetBar.PanelEx();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new Utilize.Company.CButton();
            this.btnSave = new Utilize.Company.CButton();
            this.txtPassNewConfirm = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtPassNew = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtPassCurent = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtUserName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl06.SuspendLayout();
            this.pnlEditPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNewConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassCurent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl06
            // 
            this.pnl06.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.pnl06.Controls.Add(this.pnlEditPass);
            this.pnl06.Controls.Add(this.pictureBox1);
            this.pnl06.Location = new System.Drawing.Point(111, 103);
            this.pnl06.Name = "pnl06";
            this.pnl06.Size = new System.Drawing.Size(548, 377);
            this.pnl06.TabIndex = 14;
            // 
            // pnlEditPass
            // 
            this.pnlEditPass.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlEditPass.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlEditPass.Controls.Add(this.label4);
            this.pnlEditPass.Controls.Add(this.label3);
            this.pnlEditPass.Controls.Add(this.label2);
            this.pnlEditPass.Controls.Add(this.label1);
            this.pnlEditPass.Controls.Add(this.btnCancel);
            this.pnlEditPass.Controls.Add(this.btnSave);
            this.pnlEditPass.Controls.Add(this.txtPassNewConfirm);
            this.pnlEditPass.Controls.Add(this.txtPassNew);
            this.pnlEditPass.Controls.Add(this.txtPassCurent);
            this.pnlEditPass.Controls.Add(this.txtUserName);
            this.pnlEditPass.Location = new System.Drawing.Point(3, 3);
            this.pnlEditPass.Name = "pnlEditPass";
            this.pnlEditPass.Size = new System.Drawing.Size(416, 373);
            this.pnlEditPass.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlEditPass.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.pnlEditPass.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.pnlEditPass.Style.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEditPass.Style.BackgroundImage")));
            this.pnlEditPass.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlEditPass.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlEditPass.Style.GradientAngle = 90;
            this.pnlEditPass.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(288, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "تکرار گذرواژه جدید";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(288, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "گذرواژه جدید";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(288, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "گذرواژه فعلی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(288, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "نام کاربری";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.DefaultImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Location = new System.Drawing.Point(121, 317);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Title = "انصراف";
            this.btnCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnSave.DefaultImage")));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnSave.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnSave.HoverImage")));
            this.btnSave.Location = new System.Drawing.Point(204, 317);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Title = "ذخیره";
            this.btnSave.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnSave_ChangePass_Click);
            // 
            // txtPassNewConfirm
            // 
            this.txtPassNewConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            appearance33.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance33.ImageBackground")));
            this.txtPassNewConfirm.Appearance = appearance33;
            this.txtPassNewConfirm.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassNewConfirm.Location = new System.Drawing.Point(129, 240);
            this.txtPassNewConfirm.Name = "txtPassNewConfirm";
            this.txtPassNewConfirm.PasswordChar = '*';
            this.txtPassNewConfirm.Size = new System.Drawing.Size(153, 35);
            this.txtPassNewConfirm.TabIndex = 3;
            // 
            // txtPassNew
            // 
            this.txtPassNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.txtPassNew.Appearance = appearance1;
            this.txtPassNew.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassNew.Location = new System.Drawing.Point(129, 206);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.PasswordChar = '*';
            this.txtPassNew.Size = new System.Drawing.Size(153, 35);
            this.txtPassNew.TabIndex = 2;
            // 
            // txtPassCurent
            // 
            this.txtPassCurent.Anchor = System.Windows.Forms.AnchorStyles.None;
            appearance32.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance32.ImageBackground")));
            this.txtPassCurent.Appearance = appearance32;
            this.txtPassCurent.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassCurent.Location = new System.Drawing.Point(129, 169);
            this.txtPassCurent.Name = "txtPassCurent";
            this.txtPassCurent.PasswordChar = '*';
            this.txtPassCurent.Size = new System.Drawing.Size(153, 35);
            this.txtPassCurent.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            appearance31.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance31.ImageBackground")));
            this.txtUserName.Appearance = appearance31;
            this.txtUserName.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUserName.Location = new System.Drawing.Point(129, 133);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(153, 35);
            this.txtUserName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(401, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnl06);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت کاربران";
            this.Load += new System.EventHandler(this.frmUserMng_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmChangePassword_Paint);
            this.pnl06.ResumeLayout(false);
            this.pnlEditPass.ResumeLayout(false);
            this.pnlEditPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNewConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassCurent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnlEditPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtPassNew;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtPassCurent;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtUserName;
        private Utilize.Company.CButton btnCancel;
        private Utilize.Company.CButton btnSave;
        private System.Windows.Forms.Panel pnl06;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtPassNewConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}