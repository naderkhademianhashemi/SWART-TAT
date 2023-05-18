namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlist));
            this.chklstLimit = new System.Windows.Forms.CheckedListBox();
            this.btnClose = new Utilize.Company.CButton();
            this.cbClose = new Utilize.Company.CButton();
            this.btnCancel = new Utilize.Company.CButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chklstLimit
            // 
            this.chklstLimit.BackColor = System.Drawing.Color.White;
            this.chklstLimit.CheckOnClick = true;
            this.chklstLimit.ColumnWidth = 250;
            this.chklstLimit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chklstLimit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chklstLimit.FormattingEnabled = true;
            this.chklstLimit.Location = new System.Drawing.Point(23, 53);
            this.chklstLimit.Name = "chklstLimit";
            this.chklstLimit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chklstLimit.Size = new System.Drawing.Size(595, 308);
            this.chklstLimit.Sorted = true;
            this.chklstLimit.TabIndex = 0;
            this.chklstLimit.SelectedIndexChanged += new System.EventHandler(this.chklstLimit_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnClose.DefaultImage")));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnClose.HoverImage")));
            this.btnClose.Location = new System.Drawing.Point(324, 368);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Size = new System.Drawing.Size(64, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Title = "";
            this.btnClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnClose_Click);
            // 
            // cbClose
            // 
            this.cbClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(14, 7);
            this.cbClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(35, 32);
            this.cbClose.TabIndex = 145;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.DefaultImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Location = new System.Drawing.Point(253, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Size = new System.Drawing.Size(64, 37);
            this.btnCancel.TabIndex = 146;
            this.btnCancel.Title = null;
            this.btnCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnCancel_CButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(544, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 147;
            this.label1.Text = "نوع تفکیک";
            // 
            // frmlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chklstLimit);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlist";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmlist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstLimit;
        private Utilize.Company.CButton btnClose;
        private Utilize.Company.CButton cbClose;
        private Utilize.Company.CButton btnCancel;
        private System.Windows.Forms.Label label1;
    }
}