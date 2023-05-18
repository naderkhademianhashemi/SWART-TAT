namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetail));
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnCSV = new Utilize.Company.CButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClose = new Utilize.Company.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // chkPrint
            // 
            this.chkPrint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkPrint.AutoSize = true;
            this.chkPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkPrint.Location = new System.Drawing.Point(-329, 38);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPrint.Size = new System.Drawing.Size(149, 25);
            this.chkPrint.TabIndex = 54;
            this.chkPrint.Text = "انتخاب برای چاپ";
            this.chkPrint.UseVisualStyleBackColor = true;
            this.chkPrint.CheckedChanged += new System.EventHandler(this.chkPrint_CheckedChanged);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(-342, 61);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 60;
            this.dgvList.Size = new System.Drawing.Size(126, 23);
            this.dgvList.TabIndex = 55;
            // 
            // btnCSV
            // 
            this.btnCSV.BackColor = System.Drawing.Color.Transparent;
            this.btnCSV.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCSV.DefaultImage")));
            this.btnCSV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCSV.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnCSV.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCSV.HoverImage")));
            this.btnCSV.Location = new System.Drawing.Point(114, 41);
            this.btnCSV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.PicAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCSV.Size = new System.Drawing.Size(162, 31);
            this.btnCSV.TabIndex = 58;
            this.btnCSV.Title = "خروجی اکسل";
            this.btnCSV.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnCSV_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text Files|*.txt";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(179, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 59;
            this.label1.Text = "ارسال فایل به اکسل";
            // 
            // cbClose
            // 
            this.cbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(7, 3);
            this.cbClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(30, 30);
            this.cbClose.TabIndex = 142;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 97);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.chkPrint);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetail";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات جزئی";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDetail_FormClosed);
            this.Load += new System.EventHandler(this.frmDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.DataGridView dgvList;
        private Utilize.Company.CButton btnCSV;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
        private Utilize.Company.CButton cbClose;
    }
}