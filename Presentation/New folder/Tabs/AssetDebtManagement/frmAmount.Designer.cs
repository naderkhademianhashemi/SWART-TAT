namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmount));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBalance = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.cbClose = new Utilize.Company.CButton();
            this.btnOK = new Utilize.Company.CButton();
            this.btnCancel = new Utilize.Company.CButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPositive = new System.Windows.Forms.RadioButton();
            this.rbNegative = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.trkPercent = new System.Windows.Forms.TrackBar();
            this.udPercent = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPercent)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(280, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "مقدار";
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            appearance1.ImageBackground = global::Presentation.Properties.Resources.S_TextBox;
            this.txtBalance.Appearance = appearance1;
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBalance.Location = new System.Drawing.Point(48, 42);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(220, 25);
            this.txtBalance.TabIndex = 3;
            // 
            // cbClose
            // 
            this.cbClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(12, 4);
            this.cbClose.Margin = new System.Windows.Forms.Padding(4);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(30, 30);
            this.cbClose.TabIndex = 1;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnOK.DefaultImage")));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnOK.HoverImage")));
            this.btnOK.Location = new System.Drawing.Point(94, 2);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Size = new System.Drawing.Size(64, 33);
            this.btnOK.TabIndex = 1;
            this.btnOK.Title = "";
            this.btnOK.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnOK_CButtonClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.DefaultImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Location = new System.Drawing.Point(26, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Size = new System.Drawing.Size(64, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Title = "";
            this.btnCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(84, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 38);
            this.panel1.TabIndex = 16;
            // 
            // rbPositive
            // 
            this.rbPositive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbPositive.AutoSize = true;
            this.rbPositive.BackColor = System.Drawing.Color.Transparent;
            this.rbPositive.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbPositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbPositive.Location = new System.Drawing.Point(252, 114);
            this.rbPositive.Name = "rbPositive";
            this.rbPositive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbPositive.Size = new System.Drawing.Size(59, 24);
            this.rbPositive.TabIndex = 14;
            this.rbPositive.TabStop = true;
            this.rbPositive.Text = "افزایش";
            this.rbPositive.UseVisualStyleBackColor = false;
            this.rbPositive.Visible = false;
            // 
            // rbNegative
            // 
            this.rbNegative.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbNegative.AutoSize = true;
            this.rbNegative.BackColor = System.Drawing.Color.Transparent;
            this.rbNegative.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbNegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbNegative.Location = new System.Drawing.Point(181, 114);
            this.rbNegative.Name = "rbNegative";
            this.rbNegative.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbNegative.Size = new System.Drawing.Size(55, 24);
            this.rbNegative.TabIndex = 15;
            this.rbNegative.TabStop = true;
            this.rbNegative.Text = "کاهش";
            this.rbNegative.UseVisualStyleBackColor = false;
            this.rbNegative.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(230, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "درصد";
            // 
            // trkPercent
            // 
            this.trkPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trkPercent.AutoSize = false;
            this.trkPercent.BackColor = System.Drawing.Color.MistyRose;
            this.trkPercent.Location = new System.Drawing.Point(62, 5);
            this.trkPercent.Maximum = 100;
            this.trkPercent.Name = "trkPercent";
            this.trkPercent.Size = new System.Drawing.Size(158, 24);
            this.trkPercent.TabIndex = 9;
            this.trkPercent.Scroll += new System.EventHandler(this.trkPercent_Scroll);
            // 
            // udPercent
            // 
            this.udPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.udPercent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.udPercent.Location = new System.Drawing.Point(5, 6);
            this.udPercent.Name = "udPercent";
            this.udPercent.Size = new System.Drawing.Size(49, 22);
            this.udPercent.TabIndex = 0;
            this.udPercent.ValueChanged += new System.EventHandler(this.udPercent_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label3.Location = new System.Drawing.Point(283, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "مقدار";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.trkPercent);
            this.panel2.Controls.Add(this.udPercent);
            this.panel2.Location = new System.Drawing.Point(48, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 35);
            this.panel2.TabIndex = 17;
            // 
            // frmAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 190);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbPositive);
            this.Controls.Add(this.rbNegative);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAmount";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  درصد مقدار ";
            this.Load += new System.EventHandler(this.frmCaption_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAmount_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCaption_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trkPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPercent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utilize.Company.CButton btnOK;
        private Utilize.Company.CButton btnCancel;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtBalance;
        private System.Windows.Forms.Label label1;
        private Utilize.Company.CButton cbClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPositive;
        private System.Windows.Forms.RadioButton rbNegative;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TrackBar trkPercent;
        public System.Windows.Forms.NumericUpDown udPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;

    }
}