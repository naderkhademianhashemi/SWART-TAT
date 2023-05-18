namespace Presentation.Capital_Adequacy
{
    partial class frmImportCapitalData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbImport = new Utilize.Company.CButton();
            this.fdpUpdateDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvImportData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportData)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbImport);
            this.splitContainer1.Panel1.Controls.Add(this.fdpUpdateDate);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvImportData);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(784, 562);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbImport
            // 
            this.cbImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbImport.DefaultImage = global::Presentation.Properties.Resources.S_But100px;
            this.cbImport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbImport.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbImport.HoverImage = global::Presentation.Properties.Resources.S_But100px_Hover;
            this.cbImport.Location = new System.Drawing.Point(458, 9);
            this.cbImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbImport.Name = "cbImport";
            this.cbImport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbImport.Size = new System.Drawing.Size(111, 41);
            this.cbImport.TabIndex = 141;
            this.cbImport.Title = "ورود اطلاعات";
            this.cbImport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbImport_CButtonClicked);
            // 
            // fdpUpdateDate
            // 
            this.fdpUpdateDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpUpdateDate.Font = null;
            this.fdpUpdateDate.IsDefault = true;
            this.fdpUpdateDate.Location = new System.Drawing.Point(599, 16);
            this.fdpUpdateDate.Name = "fdpUpdateDate";
            this.fdpUpdateDate.Size = new System.Drawing.Size(122, 27);
            this.fdpUpdateDate.TabIndex = 139;
            this.fdpUpdateDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(734, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 24);
            this.label10.TabIndex = 140;
            this.label10.Text = "تاریخ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvImportData
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 9.75F);
            this.dgvImportData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImportData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvImportData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(228)))));
            this.dgvImportData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvImportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportData.Location = new System.Drawing.Point(0, 0);
            this.dgvImportData.MultiSelect = false;
            this.dgvImportData.Name = "dgvImportData";
            this.dgvImportData.ReadOnly = true;
            this.dgvImportData.RowHeadersVisible = false;
            this.dgvImportData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportData.Size = new System.Drawing.Size(784, 499);
            this.dgvImportData.TabIndex = 3;
            // 
            // frmImportCapitalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImportCapitalData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "داده های ورودی کفایت سرمایه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImportCapitalData_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Utilize.Company.CButton cbImport;
        private FarsiLibrary.Win.Controls.FADatePicker fdpUpdateDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvImportData;
    }
}