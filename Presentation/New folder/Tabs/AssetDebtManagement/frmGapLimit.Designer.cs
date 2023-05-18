namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmGapLimit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGapLimit));
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.btnApply = new Utilize.Company.CButton();
            this.txtLimitdown = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLimitUp = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClose = new Utilize.Company.CButton();
            this.btCancle = new Utilize.Company.CButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimitdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimitUp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnApply.DefaultImage")));
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnApply.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnApply.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnApply.HoverImage")));
            this.btnApply.Location = new System.Drawing.Point(161, 103);
            this.btnApply.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnApply.Name = "btnApply";
            this.btnApply.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApply.Size = new System.Drawing.Size(75, 37);
            this.btnApply.TabIndex = 14;
            this.btnApply.Title = "";
            this.btnApply.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnApply_Click);
            // 
            // txtLimitdown
            // 
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            this.txtLimitdown.Appearance = appearance2;
            this.txtLimitdown.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLimitdown.Location = new System.Drawing.Point(66, 69);
            this.txtLimitdown.Name = "txtLimitdown";
            this.txtLimitdown.Size = new System.Drawing.Size(170, 30);
            this.txtLimitdown.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(240, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "حد منفی";
            // 
            // txtLimitUp
            // 
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.txtLimitUp.Appearance = appearance1;
            this.txtLimitUp.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLimitUp.Location = new System.Drawing.Point(66, 37);
            this.txtLimitUp.Name = "txtLimitUp";
            this.txtLimitUp.Size = new System.Drawing.Size(170, 30);
            this.txtLimitUp.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(240, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "حد مثبت";
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
            this.cbClose.Size = new System.Drawing.Size(29, 33);
            this.cbClose.TabIndex = 143;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // btCancle
            // 
            this.btCancle.BackColor = System.Drawing.Color.Transparent;
            this.btCancle.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btCancle.DefaultImage")));
            this.btCancle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btCancle.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btCancle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btCancle.HoverImage = ((System.Drawing.Image)(resources.GetObject("btCancle.HoverImage")));
            this.btCancle.Location = new System.Drawing.Point(90, 103);
            this.btCancle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btCancle.Name = "btCancle";
            this.btCancle.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCancle.Size = new System.Drawing.Size(75, 37);
            this.btCancle.TabIndex = 14;
            this.btCancle.Title = "";
            this.btCancle.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(214, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "حد تحلیل شکاف";
            // 
            // frmGapLimit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(325, 144);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.btCancle);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtLimitdown);
            this.Controls.Add(this.txtLimitUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGapLimit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حد تحلیل شکاف";
            this.Load += new System.EventHandler(this.frmGapLimit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLimitdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimitUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtLimitdown;
        private System.Windows.Forms.Label label2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtLimitUp;
        private System.Windows.Forms.Label label1;
        private Utilize.Company.CButton btnApply;
        private Utilize.Company.CButton cbClose;
        private Utilize.Company.CButton btCancle;
        private System.Windows.Forms.Label label3;
    }
}