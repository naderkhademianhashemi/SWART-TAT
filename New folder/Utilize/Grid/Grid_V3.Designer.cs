namespace Utilize.Grid
{
    partial class Grid_V3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.utrGroup = new Infragistics.Win.UltraWinTree.UltraTree();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.ssgReprt = new System.Windows.Forms.StatusStrip();
            this.btnSpecialReport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.ugReport = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.cmsAddGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveGroup = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utrGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugReport)).BeginInit();
            this.cmsAddGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.utrGroup);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.btnMinMax);
            this.scMain.Panel2.Controls.Add(this.ssgReprt);
            this.scMain.Panel2.Controls.Add(this.btnSpecialReport);
            this.scMain.Panel2.Controls.Add(this.btnPrint);
            this.scMain.Panel2.Controls.Add(this.btnPDF);
            this.scMain.Panel2.Controls.Add(this.btnExcel);
            this.scMain.Panel2.Controls.Add(this.ugReport);
            this.scMain.Size = new System.Drawing.Size(868, 641);
            this.scMain.SplitterDistance = 289;
            this.scMain.TabIndex = 0;
            // 
            // utrGroup
            // 
            this.utrGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.utrGroup.Location = new System.Drawing.Point(0, 0);
            this.utrGroup.Name = "utrGroup";
            this.utrGroup.Size = new System.Drawing.Size(289, 641);
            this.utrGroup.TabIndex = 0;
            this.utrGroup.ViewStyle = Infragistics.Win.UltraWinTree.ViewStyle.OutlookExpress;
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(3, 3);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(59, 23);
            this.btnMinMax.TabIndex = 11;
            this.btnMinMax.Text = "<<";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // ssgReprt
            // 
            this.ssgReprt.Location = new System.Drawing.Point(0, 619);
            this.ssgReprt.Name = "ssgReprt";
            this.ssgReprt.Size = new System.Drawing.Size(575, 22);
            this.ssgReprt.TabIndex = 10;
            this.ssgReprt.Text = "statusStrip1";
            // 
            // btnSpecialReport
            // 
            this.btnSpecialReport.Location = new System.Drawing.Point(311, 3);
            this.btnSpecialReport.Name = "btnSpecialReport";
            this.btnSpecialReport.Size = new System.Drawing.Size(75, 23);
            this.btnSpecialReport.TabIndex = 9;
            this.btnSpecialReport.Text = "Special Report";
            this.btnSpecialReport.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(230, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(149, 3);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(75, 23);
            this.btnPDF.TabIndex = 7;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(68, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // ugReport
            // 
            this.ugReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ugReport.Location = new System.Drawing.Point(3, 32);
            this.ugReport.Name = "ugReport";
            this.ugReport.Size = new System.Drawing.Size(569, 581);
            this.ugReport.TabIndex = 5;
            // 
            // cmsAddGroup
            // 
            this.cmsAddGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddGroup,
            this.btnRemoveGroup});
            this.cmsAddGroup.Name = "cmsAddGroup";
            this.cmsAddGroup.Size = new System.Drawing.Size(121, 48);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(120, 22);
            this.btnAddGroup.Text = "گروه جدید";
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(120, 22);
            this.btnRemoveGroup.Text = "حذف";
            // 
            // Grid_V3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Grid_V3";
            this.Size = new System.Drawing.Size(868, 641);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utrGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugReport)).EndInit();
            this.cmsAddGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private Infragistics.Win.UltraWinTree.UltraTree utrGroup;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.StatusStrip ssgReprt;
        private System.Windows.Forms.Button btnSpecialReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
        private Infragistics.Win.UltraWinGrid.UltraGrid ugReport;
        private System.Windows.Forms.ContextMenuStrip cmsAddGroup;
        private System.Windows.Forms.ToolStripMenuItem btnAddGroup;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveGroup;
    }
}
