namespace Utilize
{
    partial class frmSQLSettingConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSQLSettingConnection));
            this.lblServer = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlUserSql = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.rdbSQLUser = new System.Windows.Forms.RadioButton();
            this.rdbWindowsUser = new System.Windows.Forms.RadioButton();
            this.cmbServerName = new System.Windows.Forms.ComboBox();
            this.lblDataBaseName = new System.Windows.Forms.Label();
            this.cmbDataBaseName = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.txtTimeout = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.btnTestConnection = new Utilize.Company.CButton();
            this.btnSave = new Utilize.Company.CButton();
            this.cbClose = new Utilize.Company.CButton();
            this.groupBox1.SuspendLayout();
            this.pnlUserSql.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.BackColor = System.Drawing.Color.Transparent;
            this.lblServer.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblServer.Location = new System.Drawing.Point(276, 52);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(51, 20);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "نام سرور ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserName.Location = new System.Drawing.Point(192, 6);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "نام کاربری";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pnlUserSql);
            this.groupBox1.Controls.Add(this.rdbSQLUser);
            this.groupBox1.Controls.Add(this.rdbWindowsUser);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.groupBox1.Location = new System.Drawing.Point(26, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنظیمات کاربر";
            // 
            // pnlUserSql
            // 
            this.pnlUserSql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserSql.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserSql.Controls.Add(this.txtPassword);
            this.pnlUserSql.Controls.Add(this.txtUserName);
            this.pnlUserSql.Controls.Add(this.lblUserName);
            this.pnlUserSql.Controls.Add(this.lblPassword);
            this.pnlUserSql.Enabled = false;
            this.pnlUserSql.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnlUserSql.Location = new System.Drawing.Point(9, 60);
            this.pnlUserSql.Name = "pnlUserSql";
            this.pnlUserSql.Size = new System.Drawing.Size(286, 60);
            this.pnlUserSql.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword.Location = new System.Drawing.Point(11, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(175, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUserName.Location = new System.Drawing.Point(11, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(175, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPassword.Location = new System.Drawing.Point(192, 32);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(49, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "رمز عبور";
            // 
            // rdbSQLUser
            // 
            this.rdbSQLUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbSQLUser.AutoSize = true;
            this.rdbSQLUser.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbSQLUser.Location = new System.Drawing.Point(140, 40);
            this.rdbSQLUser.Name = "rdbSQLUser";
            this.rdbSQLUser.Size = new System.Drawing.Size(155, 24);
            this.rdbSQLUser.TabIndex = 3;
            this.rdbSQLUser.Text = "استفاده از هویت پایگاه داده";
            this.rdbSQLUser.UseVisualStyleBackColor = true;
            // 
            // rdbWindowsUser
            // 
            this.rdbWindowsUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbWindowsUser.AutoSize = true;
            this.rdbWindowsUser.Checked = true;
            this.rdbWindowsUser.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbWindowsUser.Location = new System.Drawing.Point(159, 17);
            this.rdbWindowsUser.Name = "rdbWindowsUser";
            this.rdbWindowsUser.Size = new System.Drawing.Size(136, 24);
            this.rdbWindowsUser.TabIndex = 2;
            this.rdbWindowsUser.TabStop = true;
            this.rdbWindowsUser.Text = "استفاده از هویت ویندوز";
            this.rdbWindowsUser.UseVisualStyleBackColor = true;
            this.rdbWindowsUser.CheckedChanged += new System.EventHandler(this.rdbWindowsUser_CheckedChanged);
            // 
            // cmbServerName
            // 
            this.cmbServerName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServerName.FormattingEnabled = true;
            this.cmbServerName.Location = new System.Drawing.Point(50, 52);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbServerName.Size = new System.Drawing.Size(213, 23);
            this.cmbServerName.TabIndex = 1;
            this.cmbServerName.DropDown += new System.EventHandler(this.cmbServerName_DropDown);
            this.cmbServerName.SelectedIndexChanged += new System.EventHandler(this.cmbServerName_SelectedIndexChanged);
            // 
            // lblDataBaseName
            // 
            this.lblDataBaseName.AutoSize = true;
            this.lblDataBaseName.BackColor = System.Drawing.Color.Transparent;
            this.lblDataBaseName.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDataBaseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblDataBaseName.Location = new System.Drawing.Point(248, 249);
            this.lblDataBaseName.Name = "lblDataBaseName";
            this.lblDataBaseName.Size = new System.Drawing.Size(73, 20);
            this.lblDataBaseName.TabIndex = 5;
            this.lblDataBaseName.Text = "نام پایگاه داده";
            // 
            // cmbDataBaseName
            // 
            this.cmbDataBaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBaseName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbDataBaseName.FormattingEnabled = true;
            this.cmbDataBaseName.Location = new System.Drawing.Point(26, 247);
            this.cmbDataBaseName.Name = "cmbDataBaseName";
            this.cmbDataBaseName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDataBaseName.Size = new System.Drawing.Size(200, 23);
            this.cmbDataBaseName.TabIndex = 6;
            this.cmbDataBaseName.DropDown += new System.EventHandler(this.cmbDataBaseName_DropDown);
            this.cmbDataBaseName.SelectedIndexChanged += new System.EventHandler(this.cmbDataBaseName_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblTitle.Location = new System.Drawing.Point(138, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 30);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "تنظیمات اتصال به پایگاه داده";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Utilize.Properties.Resources.SymbolRefresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRefresh.Location = new System.Drawing.Point(21, 50);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeOut.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTimeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblTimeOut.Location = new System.Drawing.Point(228, 226);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(93, 20);
            this.lblTimeOut.TabIndex = 10;
            this.lblTimeOut.Text = "حداکثر زمان پاسخ";
            // 
            // txtTimeout
            // 
            this.txtTimeout.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.txtTimeout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTimeout.Location = new System.Drawing.Point(126, 218);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.NullText = "15";
            this.txtTimeout.PromptChar = '-';
            this.txtTimeout.Size = new System.Drawing.Size(100, 24);
            this.txtTimeout.SpinButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.txtTimeout.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.txtTimeout.SpinIncrement = 10;
            this.txtTimeout.TabIndex = 6;
            this.txtTimeout.Value = 15;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.Transparent;
            this.btnTestConnection.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnTestConnection.DefaultImage")));
            this.btnTestConnection.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTestConnection.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnTestConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnTestConnection.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnTestConnection.HoverImage")));
            this.btnTestConnection.Location = new System.Drawing.Point(67, 291);
            this.btnTestConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTestConnection.Size = new System.Drawing.Size(106, 40);
            this.btnTestConnection.TabIndex = 13;
            this.btnTestConnection.Title = "تست اتصال";
            this.btnTestConnection.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnTestConnection_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnSave.DefaultImage")));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnSave.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnSave.HoverImage")));
            this.btnSave.Location = new System.Drawing.Point(179, 291);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Size = new System.Drawing.Size(105, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.Title = "ذخیره تنظیمات";
            this.btnSave.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnSave_Click);
            // 
            // cbClose
            // 
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(9, 5);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(29, 27);
            this.cbClose.TabIndex = 148;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // frmSQLSettingConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(353, 342);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.cmbDataBaseName);
            this.Controls.Add(this.lblDataBaseName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbServerName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblServer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSQLSettingConnection";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات اتصال به پایگاه داده ها";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlUserSql.ResumeLayout(false);
            this.pnlUserSql.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlUserSql;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.RadioButton rdbSQLUser;
        private System.Windows.Forms.RadioButton rdbWindowsUser;
        private System.Windows.Forms.ComboBox cmbServerName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDataBaseName;
        private System.Windows.Forms.ComboBox cmbDataBaseName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTimeOut;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor txtTimeout;
        private Company.CButton btnTestConnection;
        private Company.CButton btnSave;
        private Company.CButton cbClose;
    }
}