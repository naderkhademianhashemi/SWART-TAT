namespace Presentation.Tabs.CurRisk
{
    partial class frmCurStressType
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurStressType));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoType2 = new System.Windows.Forms.RadioButton();
            this.rdoType1 = new System.Windows.Forms.RadioButton();
            this.rdoType3 = new System.Windows.Forms.RadioButton();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.rdoF1 = new System.Windows.Forms.RadioButton();
            this.rdoF2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnCancel = new Utilize.Company.CButton();
            this.btnOK = new Utilize.Company.CButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fdpFrom = new FarsiLibrary.Win.Controls.FADatePicker();
            this.fdpTo = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtN = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.cbClose = new Utilize.Company.CButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(424, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "*   يك الگو را برای اختصاص دادن مقادیر بازگشتی انتخاب كنيد. بعد از اين مرحله، كلي" +
                "ه خانه هایی كه در اين محدوده هستندبه رنگ زرد درخواهند آمد: ";
            // 
            // rdoType2
            // 
            this.rdoType2.AutoSize = true;
            this.rdoType2.BackColor = System.Drawing.Color.Transparent;
            this.rdoType2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoType2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoType2.Location = new System.Drawing.Point(334, 94);
            this.rdoType2.Name = "rdoType2";
            this.rdoType2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoType2.Size = new System.Drawing.Size(98, 24);
            this.rdoType2.TabIndex = 1;
            this.rdoType2.Text = "N خانه تصادفی";
            this.rdoType2.UseVisualStyleBackColor = false;
            // 
            // rdoType1
            // 
            this.rdoType1.AutoSize = true;
            this.rdoType1.BackColor = System.Drawing.Color.Transparent;
            this.rdoType1.Checked = true;
            this.rdoType1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoType1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoType1.Location = new System.Drawing.Point(376, 74);
            this.rdoType1.Name = "rdoType1";
            this.rdoType1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoType1.Size = new System.Drawing.Size(56, 24);
            this.rdoType1.TabIndex = 7;
            this.rdoType1.TabStop = true;
            this.rdoType1.Text = "آزادانه";
            this.rdoType1.UseVisualStyleBackColor = false;
            // 
            // rdoType3
            // 
            this.rdoType3.AutoSize = true;
            this.rdoType3.BackColor = System.Drawing.Color.Transparent;
            this.rdoType3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoType3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoType3.Location = new System.Drawing.Point(189, 114);
            this.rdoType3.Name = "rdoType3";
            this.rdoType3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoType3.Size = new System.Drawing.Size(243, 24);
            this.rdoType3.TabIndex = 8;
            this.rdoType3.Text = "برای كلیه مقادیر بازگشتی در اين محدوده زمانی:";
            this.rdoType3.UseVisualStyleBackColor = false;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(189, 139);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(98, 22);
            this.dtpFrom.TabIndex = 9;
            this.dtpFrom.Value = new System.DateTime(2006, 6, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label4.Location = new System.Drawing.Point(289, 155);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "تا:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label3.Location = new System.Drawing.Point(289, 136);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "از:";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(188, 155);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(98, 22);
            this.dtpTo.TabIndex = 10;
            this.dtpTo.Value = new System.DateTime(2006, 7, 1, 0, 0, 0, 0);
            // 
            // rdoF1
            // 
            this.rdoF1.AutoSize = true;
            this.rdoF1.Checked = true;
            this.rdoF1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoF1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoF1.Location = new System.Drawing.Point(3, 6);
            this.rdoF1.Name = "rdoF1";
            this.rdoF1.Size = new System.Drawing.Size(58, 18);
            this.rdoF1.TabIndex = 13;
            this.rdoF1.TabStop = true;
            this.rdoF1.Tag = "1";
            this.rdoF1.Text = "P + a";
            this.rdoF1.UseVisualStyleBackColor = true;
            // 
            // rdoF2
            // 
            this.rdoF2.AutoSize = true;
            this.rdoF2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoF2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoF2.Location = new System.Drawing.Point(3, 26);
            this.rdoF2.Name = "rdoF2";
            this.rdoF2.Size = new System.Drawing.Size(96, 18);
            this.rdoF2.TabIndex = 19;
            this.rdoF2.Tag = "3";
            this.rdoF2.Text = "P + a% * P";
            this.rdoF2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label5.Location = new System.Drawing.Point(243, 261);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "مقدار پارامتر a:";
            // 
            // txtA
            // 
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            this.txtA.Appearance = appearance2;
            this.txtA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtA.Location = new System.Drawing.Point(158, 258);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(81, 23);
            this.txtA.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.DefaultImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Location = new System.Drawing.Point(167, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Size = new System.Drawing.Size(67, 37);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Title = null;
            this.btnCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnOK.DefaultImage")));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOK.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnOK.HoverImage")));
            this.btnOK.Location = new System.Drawing.Point(240, 281);
            this.btnOK.Name = "btnOK";
            this.btnOK.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Size = new System.Drawing.Size(67, 37);
            this.btnOK.TabIndex = 31;
            this.btnOK.Title = null;
            this.btnOK.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnOK_CButtonClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(222, 186);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "به صورت خودكار اين فرمول را اختصاص بده...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.Result;
            this.pictureBox1.Location = new System.Drawing.Point(14, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rdoF1);
            this.panel1.Controls.Add(this.rdoF2);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(155, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 50);
            this.panel1.TabIndex = 35;
            // 
            // fdpFrom
            // 
            this.fdpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFrom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fdpFrom.Location = new System.Drawing.Point(158, 136);
            this.fdpFrom.Name = "fdpFrom";
            this.fdpFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fdpFrom.Size = new System.Drawing.Size(131, 18);
            this.fdpFrom.TabIndex = 39;
            this.fdpFrom.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // fdpTo
            // 
            this.fdpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fdpTo.Location = new System.Drawing.Point(158, 156);
            this.fdpTo.Name = "fdpTo";
            this.fdpTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fdpTo.Size = new System.Drawing.Size(131, 18);
            this.fdpTo.TabIndex = 40;
            this.fdpTo.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label6.Location = new System.Drawing.Point(216, 96);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "مقدار پارامتر N:";
            // 
            // txtN
            // 
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.txtN.Appearance = appearance1;
            this.txtN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtN.Location = new System.Drawing.Point(158, 94);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(52, 23);
            this.txtN.TabIndex = 42;
            // 
            // cbClose
            // 
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(14, 4);
            this.cbClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(30, 29);
            this.cbClose.TabIndex = 45;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label7.Location = new System.Drawing.Point(376, 3);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(78, 30);
            this.label7.TabIndex = 44;
            this.label7.Text = "تغییر الگو";
            // 
            // frmCurStressType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 325);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.fdpFrom);
            this.Controls.Add(this.fdpTo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.rdoType3);
            this.Controls.Add(this.rdoType1);
            this.Controls.Add(this.rdoType2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCurStressType";
            this.Load += new System.EventHandler(this.frmCurStressType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoType2;
        private System.Windows.Forms.RadioButton rdoType1;
        private System.Windows.Forms.RadioButton rdoType3;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.RadioButton rdoF1;
        private System.Windows.Forms.RadioButton rdoF2;
        private System.Windows.Forms.Label label5;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtA;
        private Utilize.Company.CButton btnCancel;
        private Utilize.Company.CButton btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFrom;
        private FarsiLibrary.Win.Controls.FADatePicker fdpTo;
        private System.Windows.Forms.Label label6;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtN;
        private Utilize.Company.CButton cbClose;
        private System.Windows.Forms.Label label7;
    }
}