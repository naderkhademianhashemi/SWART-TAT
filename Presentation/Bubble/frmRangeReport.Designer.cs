using System.Windows.Forms;

namespace Presentation.Deposit
{
    partial class frmRangeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRangeReport));
            this.cmsTreeRange = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRemoveRange = new System.Windows.Forms.ToolStripMenuItem();
            this.ssRangeReport = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspReprtBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsGridResoult = new DevComponents.DotNetBar.BubbleBar();
            this.bbtButton = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.btnToXML = new DevComponents.DotNetBar.BubbleButton();
            this.btnSaveExcell = new DevComponents.DotNetBar.BubbleButton();
            this.btnPrint = new DevComponents.DotNetBar.BubbleButton();
            this.tvnRange = new System.Windows.Forms.TreeView();
            this.grbSetting = new System.Windows.Forms.GroupBox();
            this.cmbBaseRange = new System.Windows.Forms.ComboBox();
            this.cmbReport = new System.Windows.Forms.ComboBox();
            this.btnShow = new Utilize.Company.CButton();
            this.lblBaseRange = new System.Windows.Forms.Label();
            this.lblNameReport = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cmsTreeRange.SuspendLayout();
            this.ssRangeReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsGridResoult)).BeginInit();
            this.grbSetting.SuspendLayout();
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
            // cmsTreeRange
            // 
            this.cmsTreeRange.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsTreeRange.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTreeRange.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRemoveRange});
            this.cmsTreeRange.Name = "contextMenuStrip1";
            this.cmsTreeRange.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsTreeRange.Size = new System.Drawing.Size(108, 26);
            // 
            // btnRemoveRange
            // 
            this.btnRemoveRange.Name = "btnRemoveRange";
            this.btnRemoveRange.Size = new System.Drawing.Size(107, 22);
            this.btnRemoveRange.Text = "حذف";
            this.btnRemoveRange.ToolTipText = "حذف رنج انتخابی";
            this.btnRemoveRange.Click += new System.EventHandler(this.btnRemoveRange_Click);
            // 
            // ssRangeReport
            // 
            this.ssRangeReport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssRangeReport.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssRangeReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssLblStatus,
            this.toolStripStatusLabel3,
            this.tspReprtBar});
            this.ssRangeReport.Location = new System.Drawing.Point(0, 532);
            this.ssRangeReport.Name = "ssRangeReport";
            this.ssRangeReport.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.ssRangeReport.ShowItemToolTips = true;
            this.ssRangeReport.Size = new System.Drawing.Size(1067, 33);
            this.ssRangeReport.TabIndex = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 27);
            this.toolStripStatusLabel1.Text = "وضعیت :";
            // 
            // tssLblStatus
            // 
            this.tssLblStatus.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tssLblStatus.Name = "tssLblStatus";
            this.tssLblStatus.Size = new System.Drawing.Size(492, 27);
            this.tssLblStatus.Spring = true;
            this.tssLblStatus.Text = "آماده برای گزارش گیری";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(492, 27);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "|";
            // 
            // tspReprtBar
            // 
            this.tspReprtBar.Name = "tspReprtBar";
            this.tspReprtBar.Size = new System.Drawing.Size(133, 25);
            this.tspReprtBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.tspReprtBar.Visible = false;
            // 
            // tsGridResoult
            // 
            this.tsGridResoult.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.tsGridResoult.AntiAlias = true;
            this.tsGridResoult.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.tsGridResoult.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.tsGridResoult.BackgroundStyle.Class = "";
            this.tsGridResoult.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.tsGridResoult.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(222)))), ((int)(((byte)(193)))));
            this.tsGridResoult.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.tsGridResoult.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.tsGridResoult.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tsGridResoult.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.tsGridResoult.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.tsGridResoult.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.tsGridResoult.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.tsGridResoult.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.tsGridResoult.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.tsGridResoult.ButtonBackAreaStyle.Class = "";
            this.tsGridResoult.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tsGridResoult.ButtonBackAreaStyle.PaddingBottom = 3;
            this.tsGridResoult.ButtonBackAreaStyle.PaddingLeft = 3;
            this.tsGridResoult.ButtonBackAreaStyle.PaddingRight = 3;
            this.tsGridResoult.ButtonBackAreaStyle.PaddingTop = 3;
            this.tsGridResoult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsGridResoult.ImageSizeNormal = new System.Drawing.Size(24, 24);
            this.tsGridResoult.Location = new System.Drawing.Point(0, 388);
            this.tsGridResoult.Margin = new System.Windows.Forms.Padding(4);
            this.tsGridResoult.Name = "tsGridResoult";
            this.tsGridResoult.SelectedTab = this.bbtButton;
            this.tsGridResoult.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.tsGridResoult.Size = new System.Drawing.Size(756, 57);
            this.tsGridResoult.TabIndex = 4;
            this.tsGridResoult.Tabs.Add(this.bbtButton);
            this.tsGridResoult.TooltipFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bbtButton
            // 
            this.bbtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(242)))), ((int)(((byte)(226)))));
            this.bbtButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(209)))), ((int)(((byte)(153)))));
            this.bbtButton.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.btnToXML,
            this.btnSaveExcell,
            this.btnPrint});
            this.bbtButton.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bbtButton.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bbtButton.Name = "bbtButton";
            this.bbtButton.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Tan;
            this.bbtButton.Text = "گزینه ها";
            this.bbtButton.TextColor = System.Drawing.Color.Black;
            // 
            // btnToXML
            // 
            this.btnToXML.Image = ((System.Drawing.Image)(resources.GetObject("btnToXML.Image")));
            this.btnToXML.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnToXML.ImageLarge")));
            this.btnToXML.Name = "btnToXML";
            this.btnToXML.Tag = "خروجی XML";
            this.btnToXML.TagString = "خروجی XML";
            this.btnToXML.TooltipText = "خروجی XML";
            this.btnToXML.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnToXML_Click);
            // 
            // btnSaveExcell
            // 
            this.btnSaveExcell.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveExcell.Image")));
            this.btnSaveExcell.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnSaveExcell.ImageLarge")));
            this.btnSaveExcell.Name = "btnSaveExcell";
            this.btnSaveExcell.Tag = "خروجی اکسل";
            this.btnSaveExcell.TagString = "خروجی اکسل";
            this.btnSaveExcell.TooltipText = "خروجی اکسل";
            this.btnSaveExcell.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnSaveExcell_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageLarge")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Tag = "پرینت گزارش";
            this.btnPrint.TagString = "پرینت گزارش";
            this.btnPrint.TooltipText = "پرینت گزارش";
            this.btnPrint.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnPrint_Click);
            // 
            // tvnRange
            // 
            this.tvnRange.BackColor = System.Drawing.Color.MistyRose;
            this.tvnRange.ContextMenuStrip = this.cmsTreeRange;
            this.tvnRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvnRange.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tvnRange.FullRowSelect = true;
            this.tvnRange.Location = new System.Drawing.Point(0, 0);
            this.tvnRange.Margin = new System.Windows.Forms.Padding(4);
            this.tvnRange.Name = "tvnRange";
            this.tvnRange.ShowLines = false;
            this.tvnRange.ShowNodeToolTips = true;
            this.tvnRange.ShowPlusMinus = false;
            this.tvnRange.ShowRootLines = false;
            this.tvnRange.Size = new System.Drawing.Size(306, 445);
            this.tvnRange.TabIndex = 1;
            this.tvnRange.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvnRange_NodeMouseClick);
            // 
            // grbSetting
            // 
            this.grbSetting.BackColor = System.Drawing.Color.Silver;
            this.grbSetting.Controls.Add(this.cmbBaseRange);
            this.grbSetting.Controls.Add(this.cmbReport);
            this.grbSetting.Controls.Add(this.btnShow);
            this.grbSetting.Controls.Add(this.lblBaseRange);
            this.grbSetting.Controls.Add(this.lblNameReport);
            this.grbSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbSetting.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grbSetting.Location = new System.Drawing.Point(0, 0);
            this.grbSetting.Margin = new System.Windows.Forms.Padding(4);
            this.grbSetting.Name = "grbSetting";
            this.grbSetting.Padding = new System.Windows.Forms.Padding(4);
            this.grbSetting.Size = new System.Drawing.Size(1067, 83);
            this.grbSetting.TabIndex = 0;
            this.grbSetting.TabStop = false;
            this.grbSetting.Text = "تنظیمات اولیه";
            // 
            // cmbBaseRange
            // 
            this.cmbBaseRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBaseRange.Location = new System.Drawing.Point(603, 46);
            this.cmbBaseRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBaseRange.MaxDropDownItems = 20;
            this.cmbBaseRange.Name = "cmbBaseRange";
            this.cmbBaseRange.Size = new System.Drawing.Size(332, 34);
            this.cmbBaseRange.TabIndex = 106;
            // 
            // cmbReport
            // 
            this.cmbReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReport.Location = new System.Drawing.Point(603, 21);
            this.cmbReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbReport.MaxDropDownItems = 20;
            this.cmbReport.Name = "cmbReport";
            this.cmbReport.Size = new System.Drawing.Size(332, 34);
            this.cmbReport.TabIndex = 105;
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnShow.DefaultImage")));
            this.btnShow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShow.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShow.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnShow.HoverImage")));
            this.btnShow.Location = new System.Drawing.Point(12, 41);
            this.btnShow.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnShow.Name = "btnShow";
            this.btnShow.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShow.Size = new System.Drawing.Size(123, 32);
            this.btnShow.TabIndex = 1;
            this.btnShow.Title = null;
            this.btnShow.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnShow_Click);
            // 
            // lblBaseRange
            // 
            this.lblBaseRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBaseRange.AutoSize = true;
            this.lblBaseRange.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBaseRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblBaseRange.Location = new System.Drawing.Point(940, 47);
            this.lblBaseRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseRange.Name = "lblBaseRange";
            this.lblBaseRange.Size = new System.Drawing.Size(109, 27);
            this.lblBaseRange.TabIndex = 1;
            this.lblBaseRange.Text = "پایه تقسیم بندی";
            // 
            // lblNameReport
            // 
            this.lblNameReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameReport.AutoSize = true;
            this.lblNameReport.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNameReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblNameReport.Location = new System.Drawing.Point(977, 22);
            this.lblNameReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameReport.Name = "lblNameReport";
            this.lblNameReport.Size = new System.Drawing.Size(71, 27);
            this.lblNameReport.TabIndex = 0;
            this.lblNameReport.Text = "نام گزارش";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.tsGridResoult);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tvnRange);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1067, 445);
            this.splitContainer1.SplitterDistance = 756;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grbSetting);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(1067, 532);
            this.splitContainer2.SplitterDistance = 83;
            this.splitContainer2.TabIndex = 10;
            // 
            // frmRangeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 565);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.ssRangeReport);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmRangeReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "گزارش رنج بندی - سپرده ها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRangeReport_FormClosing);
            this.Load += new System.EventHandler(this.frmRangeReport_Load);
            this.cmsTreeRange.ResumeLayout(false);
            this.ssRangeReport.ResumeLayout(false);
            this.ssRangeReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsGridResoult)).EndInit();
            this.grbSetting.ResumeLayout(false);
            this.grbSetting.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grbSetting;
        private System.Windows.Forms.Label lblBaseRange;
        private System.Windows.Forms.Label lblNameReport;
        private Utilize.Company.CButton btnShow;
        private System.Windows.Forms.TreeView tvnRange;
        private Infragistics.Win.UltraWinGrid.UltraGridPrintDocument ugpDocument;
        private DevComponents.DotNetBar.BubbleBar tsGridResoult;
        private DevComponents.DotNetBar.BubbleBarTab bbtButton;
        private DevComponents.DotNetBar.BubbleButton btnSaveExcell;
        private DevComponents.DotNetBar.BubbleButton btnPrint;
        private DevComponents.DotNetBar.BubbleButton btnToXML;
        private Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter ugeExporter;
        private System.Windows.Forms.StatusStrip ssRangeReport;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssLblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripProgressBar tspReprtBar;
        private System.Windows.Forms.ContextMenuStrip cmsTreeRange;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveRange;
        private Infragistics.Win.UltraWinGrid.UltraGrid grvResoultOfReport;
        private ComboBox cmbBaseRange;
        private ComboBox cmbReport;
        private Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter ugeDocument;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}