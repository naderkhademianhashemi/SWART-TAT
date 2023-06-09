namespace Presentation.Tabs.BasicData
{
    partial class frmAccountsGL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountsGL));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveExcel = new Utilize.Company.CButton();
            this.lblCheckListColumn = new System.Windows.Forms.Label();
            this.ugSWARTReport = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnMdl = new Utilize.Company.CButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.btnReload = new Utilize.Company.CButton();
            this.fdpStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugSWARTReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "csv";
            this.saveFileDialog.Filter = "txt files (*.csv)|*.csv";
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnSaveExcel.DefaultImage")));
            this.btnSaveExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveExcel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveExcel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnSaveExcel.HoverImage")));
            this.btnSaveExcel.Location = new System.Drawing.Point(0, 0);
            this.btnSaveExcel.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveExcel.Size = new System.Drawing.Size(36, 39);
            this.btnSaveExcel.TabIndex = 11;
            this.btnSaveExcel.Title = null;
            this.btnSaveExcel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnSaveExcel_Click);
            // 
            // lblCheckListColumn
            // 
            this.lblCheckListColumn.AutoSize = true;
            this.lblCheckListColumn.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckListColumn.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCheckListColumn.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCheckListColumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblCheckListColumn.Location = new System.Drawing.Point(63, 0);
            this.lblCheckListColumn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCheckListColumn.Name = "lblCheckListColumn";
            this.lblCheckListColumn.Size = new System.Drawing.Size(175, 30);
            this.lblCheckListColumn.TabIndex = 12;
            this.lblCheckListColumn.Text = "ستون های نمایش گزارش";
            // 
            // ugSWARTReport
            // 
            this.ugSWARTReport.ColumnHeadersHeight = 29;
            this.ugSWARTReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ugSWARTReport.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ugSWARTReport.Location = new System.Drawing.Point(0, 0);
            this.ugSWARTReport.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ugSWARTReport.Name = "ugSWARTReport";
            this.ugSWARTReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ugSWARTReport.RowHeadersWidth = 51;
            this.ugSWARTReport.Size = new System.Drawing.Size(594, 522);
            this.ugSWARTReport.TabIndex = 13;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.lblCheckListColumn);
            this.splitContainer1.Size = new System.Drawing.Size(238, 532);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 15;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnMdl);
            this.splitContainer2.Panel1.Controls.Add(this.btnSaveExcel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ugSWARTReport);
            this.splitContainer2.Size = new System.Drawing.Size(594, 564);
            this.splitContainer2.SplitterDistance = 39;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 16;
            // 
            // btnMdl
            // 
            this.btnMdl.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnMdl.DefaultImage")));
            this.btnMdl.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMdl.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMdl.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnMdl.HoverImage")));
            this.btnMdl.Location = new System.Drawing.Point(561, 0);
            this.btnMdl.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnMdl.Name = "btnMdl";
            this.btnMdl.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMdl.Size = new System.Drawing.Size(33, 39);
            this.btnMdl.TabIndex = 61;
            this.btnMdl.Title = null;
            this.btnMdl.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnMdl_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer3.Panel2.Controls.Add(this.pnlDate);
            this.splitContainer3.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel2_Paint);
            this.splitContainer3.Size = new System.Drawing.Size(836, 564);
            this.splitContainer3.SplitterDistance = 594;
            this.splitContainer3.TabIndex = 17;
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.btnReload);
            this.pnlDate.Controls.Add(this.fdpStartDate);
            this.pnlDate.Controls.Add(this.label2);
            this.pnlDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDate.Location = new System.Drawing.Point(0, 0);
            this.pnlDate.MaximumSize = new System.Drawing.Size(500, 32);
            this.pnlDate.MinimumSize = new System.Drawing.Size(216, 32);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(238, 32);
            this.pnlDate.TabIndex = 16;
            // 
            // btnReload
            // 
            this.btnReload.DefaultImage = null;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReload.HoverImage = null;
            this.btnReload.Location = new System.Drawing.Point(0, 0);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.Size = new System.Drawing.Size(42, 32);
            this.btnReload.TabIndex = 56;
            this.btnReload.Title = null;
            this.btnReload.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnReload_CButtonClicked);
            // 
            // fdpStartDate
            // 
            this.fdpStartDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.fdpStartDate.Font = null;
            this.fdpStartDate.Location = new System.Drawing.Point(28, 0);
            this.fdpStartDate.Name = "fdpStartDate";
            this.fdpStartDate.Size = new System.Drawing.Size(125, 32);
            this.fdpStartDate.TabIndex = 7;
            this.fdpStartDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(153, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "تاریخ گزارش";
            // 
            // frmAccountsGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(836, 564);
            this.Controls.Add(this.splitContainer3);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccountsGL";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "  دفتر كل   ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAccountsGL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugSWARTReport)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Utilize.Company.CButton btnSaveExcel;
        private System.Windows.Forms.Label lblCheckListColumn;
        private System.Windows.Forms.DataGridView ugSWARTReport;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Utilize.Company.CButton btnMdl;
        private System.Windows.Forms.Panel pnlDate;
        private FarsiLibrary.Win.Controls.FADatePicker fdpStartDate;
        private System.Windows.Forms.Label label2;
        private Utilize.Company.CButton btnReload;
    }
}
