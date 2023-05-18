namespace Presentation.Setting
{
    partial class frmSettingNameColumnOfReport
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
            System.Windows.Forms.Label lblReport;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingNameColumnOfReport));
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            this.dgvColumnOfReport = new System.Windows.Forms.DataGridView();
            this.btnSave = new Utilize.Company.CButton();
            this.cmbReport = new Utilize.Company.CComboCox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            lblReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnOfReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReport
            // 
            lblReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblReport.AutoSize = true;
            lblReport.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            lblReport.Location = new System.Drawing.Point(714, 8);
            lblReport.Name = "lblReport";
            lblReport.Size = new System.Drawing.Size(55, 20);
            lblReport.TabIndex = 0;
            lblReport.Text = "نام گزارش";
            // 
            // dgvColumnOfReport
            // 
            this.dgvColumnOfReport.AllowUserToAddRows = false;
            this.dgvColumnOfReport.AllowUserToDeleteRows = false;
            this.dgvColumnOfReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColumnOfReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvColumnOfReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColumnOfReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColumnOfReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColumnOfReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvColumnOfReport.EnableHeadersVisualStyles = false;
            this.dgvColumnOfReport.Location = new System.Drawing.Point(0, 0);
            this.dgvColumnOfReport.Name = "dgvColumnOfReport";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvColumnOfReport.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColumnOfReport.Size = new System.Drawing.Size(784, 376);
            this.dgvColumnOfReport.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnSave.DefaultImage")));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnSave.HoverImage")));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Size = new System.Drawing.Size(784, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Title = null;
            this.btnSave.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnSave_Click);
            // 
            // cmbReport
            // 
            this.cmbReport.AccessibleName = "";
            this.cmbReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance17.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance17.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance17.ImageBackground")));
            this.cmbReport.Appearance = appearance17;
            this.cmbReport.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbReport.AutoSize = false;
            this.cmbReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance6.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance6.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance6.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance6.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance6.ImageBackground")));
            appearance6.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Centered;
            this.cmbReport.ButtonAppearance = appearance6;
            this.cmbReport.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbReport.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbReport.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbReport.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbReport.HideSelection = false;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbReport.ItemAppearance = appearance7;
            this.cmbReport.Location = new System.Drawing.Point(393, 7);
            this.cmbReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbReport.MaxDropDownItems = 20;
            this.cmbReport.Name = "cmbReport";
            this.cmbReport.Size = new System.Drawing.Size(315, 19);
            this.cmbReport.TabIndex = 106;
            this.cmbReport.SelectionChanged += new System.EventHandler(this.cmbReport_SelectionChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(lblReport);
            this.splitContainer1.Panel1.Controls.Add(this.cmbReport);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(784, 459);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 107;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvColumnOfReport);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnSave);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(784, 418);
            this.splitContainer2.SplitterDistance = 376;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 3;
            // 
            // frmSettingNameColumnOfReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(784, 459);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSettingNameColumnOfReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت نام ستون های گزارشات";
            this.Load += new System.EventHandler(this.frmSettingNameColumnOfReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnOfReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReport)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColumnOfReport;
        private Utilize.Company.CButton btnSave;
        private Utilize.Company.CComboCox cmbReport;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}