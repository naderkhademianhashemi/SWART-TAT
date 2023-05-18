namespace Utilize.Report
{
    partial class frmSelectColumn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectColumn));
            this.ucSelectColumn = new Utilize.Report.SelectColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbClose = new Utilize.Company.CButton();
            this.btnOK = new Utilize.Company.CButton();
            this.btnCancel = new Utilize.Company.CButton();
            this.SuspendLayout();
            // 
            // ucSelectColumn
            // 
            this.ucSelectColumn.BackColor = System.Drawing.Color.Transparent;
            this.ucSelectColumn.DataSource = null;
            this.ucSelectColumn.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ucSelectColumn.Location = new System.Drawing.Point(14, 43);
            this.ucSelectColumn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucSelectColumn.Name = "ucSelectColumn";
            this.ucSelectColumn.NameOfDisplay = null;
            this.ucSelectColumn.NameOfValue = null;
            this.ucSelectColumn.Size = new System.Drawing.Size(519, 286);
            this.ucSelectColumn.TabIndex = 0;
            this.ucSelectColumn.Title = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("B Nazanin", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(400, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(81, 27);
            this.lblTitle.TabIndex = 150;
            this.lblTitle.Text = "لیست موارد";
            // 
            // cbClose
            // 
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(14, 8);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(29, 27);
            this.cbClose.TabIndex = 149;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnOK.DefaultImage")));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnOK.HoverImage")));
            this.btnOK.Location = new System.Drawing.Point(277, 336);
            this.btnOK.Name = "btnOK";
            this.btnOK.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Size = new System.Drawing.Size(62, 34);
            this.btnOK.TabIndex = 148;
            this.btnOK.Title = null;
            this.btnOK.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnOK_CButtonClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.DefaultImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Location = new System.Drawing.Point(209, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Size = new System.Drawing.Size(62, 34);
            this.btnCancel.TabIndex = 147;
            this.btnCancel.Title = null;
            this.btnCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // frmSelectColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 381);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ucSelectColumn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelectColumn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSelectColumn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public SelectColumn ucSelectColumn;
        private System.Windows.Forms.Label lblTitle;
        private Company.CButton cbClose;
        private Company.CButton btnOK;
        private Company.CButton btnCancel;
    }
}