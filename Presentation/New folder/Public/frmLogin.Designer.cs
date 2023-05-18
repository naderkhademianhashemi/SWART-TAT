namespace Presentation.Public
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cbCancel = new Utilize.Company.CButton();
            this.cbOK = new Utilize.Company.CButton();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnPassUser = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCancel
            // 
            this.cbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCancel.BackColor = System.Drawing.Color.Transparent;
            this.cbCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbCancel.DefaultImage")));
            this.cbCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbCancel.HoverImage")));
            this.cbCancel.Location = new System.Drawing.Point(33, 90);
            this.cbCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCancel.Name = "cbCancel";
            this.cbCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCancel.Size = new System.Drawing.Size(63, 23);
            this.cbCancel.TabIndex = 4;
            this.cbCancel.Title = null;
            this.cbCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnCancel_Click);
            // 
            // cbOK
            // 
            this.cbOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOK.BackColor = System.Drawing.Color.Transparent;
            this.cbOK.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbOK.DefaultImage")));
            this.cbOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbOK.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbOK.HoverImage")));
            this.cbOK.Location = new System.Drawing.Point(101, 90);
            this.cbOK.Name = "cbOK";
            this.cbOK.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbOK.Size = new System.Drawing.Size(63, 23);
            this.cbOK.TabIndex = 3;
            this.cbOK.Title = null;
            this.cbOK.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnLogin_Click);
            this.cbOK.Load += new System.EventHandler(this.cbOK_Load);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.AutoSize = false;
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUserName.Location = new System.Drawing.Point(34, 39);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserName.Size = new System.Drawing.Size(129, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.AutoSize = false;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword.Location = new System.Drawing.Point(34, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(129, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(35)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(173, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "نام کاربری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(35)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(175, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "رمز عبور";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Presentation.Properties.Resources.frmLogin_LogPanel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.cbOK);
            this.panel1.Controls.Add(this.cbCancel);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(481, 436);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(257, 142);
            this.panel1.MinimumSize = new System.Drawing.Size(257, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 142);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblVersion);
            this.panel2.Controls.Add(this.btnPassUser);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 599);
            this.panel2.TabIndex = 15;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblVersion.Location = new System.Drawing.Point(7, 578);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(57, 19);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "نسخه 3.1.4";
            this.lblVersion.Visible = false;
            // 
            // btnPassUser
            // 
            this.btnPassUser.Location = new System.Drawing.Point(79, 204);
            this.btnPassUser.Name = "btnPassUser";
            this.btnPassUser.Size = new System.Drawing.Size(23, 22);
            this.btnPassUser.TabIndex = 2;
            this.btnPassUser.Click += new System.EventHandler(this.btnPassUser_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(34, 565);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 25);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 599);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(952, 599);
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود کاربر  SWART";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
        //private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private Utilize.Company.CButton cbCancel;
        private Utilize.Company.CButton cbOK;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel btnPassUser;
    }
}