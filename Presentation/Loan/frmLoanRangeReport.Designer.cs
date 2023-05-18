namespace Presentation.Loan
{
    partial class frmLoanRangeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanRangeReport));
            this.grbSetting = new System.Windows.Forms.GroupBox();
            this.cbCloseAll = new Utilize.Company.CButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.lblNameReport = new System.Windows.Forms.Label();
            this.cmbReport = new System.Windows.Forms.ComboBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBaseRange = new System.Windows.Forms.ComboBox();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.btnShow = new Utilize.Company.CButton();
            this.tvnRange = new System.Windows.Forms.TreeView();
            this.cmsTreeRange = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRemoveRange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGridResoult = new DevComponents.DotNetBar.BubbleBar();
            this.bbtButton = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.btnToXML = new DevComponents.DotNetBar.BubbleButton();
            this.btnSaveExcell = new DevComponents.DotNetBar.BubbleButton();
            this.btnPrint = new DevComponents.DotNetBar.BubbleButton();
            this.ssRangeReport = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspReprtBar = new System.Windows.Forms.ToolStripProgressBar();
            this.grvResoultOfReport = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grbSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.cmsTreeRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsGridResoult)).BeginInit();
            this.ssRangeReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvResoultOfReport)).BeginInit();
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
            // grbSetting
            // 
            this.grbSetting.BackColor = System.Drawing.Color.Transparent;
            this.grbSetting.Controls.Add(this.cbCloseAll);
            this.grbSetting.Controls.Add(this.splitContainer3);
            this.grbSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbSetting.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grbSetting.Location = new System.Drawing.Point(0, 0);
            this.grbSetting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbSetting.Name = "grbSetting";
            this.grbSetting.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbSetting.Size = new System.Drawing.Size(1067, 97);
            this.grbSetting.TabIndex = 0;
            this.grbSetting.TabStop = false;
            this.grbSetting.Text = "تنظیمات اولیه";
            // 
            // cbCloseAll
            // 
            this.cbCloseAll.BackColor = System.Drawing.Color.Transparent;
            this.cbCloseAll.DefaultImage = null;
            this.cbCloseAll.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cbCloseAll.HoverImage = null;
            this.cbCloseAll.Location = new System.Drawing.Point(4, 2);
            this.cbCloseAll.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.cbCloseAll.Name = "cbCloseAll";
            this.cbCloseAll.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCloseAll.Size = new System.Drawing.Size(104, 40);
            this.cbCloseAll.TabIndex = 142;
            this.cbCloseAll.Title = null;
            this.cbCloseAll.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbCloseAll_CButtonClicked);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(8, 25);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer3.MaximumSize = new System.Drawing.Size(1051, 45);
            this.splitContainer3.MinimumSize = new System.Drawing.Size(1051, 45);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(1051, 45);
            this.splitContainer3.SplitterDistance = 425;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 4;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer5);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Panel1MinSize = 21;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Panel2MinSize = 21;
            this.splitContainer4.Size = new System.Drawing.Size(425, 45);
            this.splitContainer4.SplitterDistance = 22;
            this.splitContainer4.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.lblNameReport);
            this.splitContainer5.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.cmbReport);
            this.splitContainer5.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer5.Size = new System.Drawing.Size(567, 21);
            this.splitContainer5.SplitterDistance = 128;
            this.splitContainer5.SplitterWidth = 5;
            this.splitContainer5.TabIndex = 1;
            // 
            // lblNameReport
            // 
            this.lblNameReport.AutoSize = true;
            this.lblNameReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNameReport.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNameReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblNameReport.Location = new System.Drawing.Point(57, 0);
            this.lblNameReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameReport.Name = "lblNameReport";
            this.lblNameReport.Size = new System.Drawing.Size(71, 27);
            this.lblNameReport.TabIndex = 0;
            this.lblNameReport.Text = "نام گزارش";
            this.lblNameReport.Click += new System.EventHandler(this.lblNameReport_Click);
            // 
            // cmbReport
            // 
            this.cmbReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.cmbReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbReport.Location = new System.Drawing.Point(0, 0);
            this.cmbReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbReport.MaximumSize = new System.Drawing.Size(432, 0);
            this.cmbReport.Name = "cmbReport";
            this.cmbReport.Size = new System.Drawing.Size(432, 34);
            this.cmbReport.TabIndex = 0;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.label1);
            this.splitContainer6.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.cmbBaseRange);
            this.splitContainer6.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer6.Size = new System.Drawing.Size(567, 21);
            this.splitContainer6.SplitterDistance = 128;
            this.splitContainer6.SplitterWidth = 5;
            this.splitContainer6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(19, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "پایه تقسیم بندی";
            // 
            // cmbBaseRange
            // 
            this.cmbBaseRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.cmbBaseRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBaseRange.Location = new System.Drawing.Point(0, 0);
            this.cmbBaseRange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBaseRange.MaximumSize = new System.Drawing.Size(432, 0);
            this.cmbBaseRange.Name = "cmbBaseRange";
            this.cmbBaseRange.Size = new System.Drawing.Size(432, 34);
            this.cmbBaseRange.TabIndex = 1;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer7.IsSplitterFixed = true;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.btnShow);
            this.splitContainer7.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer7.Size = new System.Drawing.Size(621, 45);
            this.splitContainer7.SplitterDistance = 99;
            this.splitContainer7.SplitterWidth = 5;
            this.splitContainer7.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnShow.DefaultImage")));
            this.btnShow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShow.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShow.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnShow.HoverImage")));
            this.btnShow.Location = new System.Drawing.Point(0, 0);
            this.btnShow.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShow.Size = new System.Drawing.Size(99, 45);
            this.btnShow.TabIndex = 2;
            this.btnShow.Title = null;
            this.btnShow.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnShow_Click);
            // 
            // tvnRange
            // 
            this.tvnRange.BackColor = System.Drawing.Color.White;
            this.tvnRange.ContextMenuStrip = this.cmsTreeRange;
            this.tvnRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvnRange.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tvnRange.FullRowSelect = true;
            this.tvnRange.Location = new System.Drawing.Point(0, 0);
            this.tvnRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tvnRange.Name = "tvnRange";
            this.tvnRange.ShowLines = false;
            this.tvnRange.ShowNodeToolTips = true;
            this.tvnRange.ShowPlusMinus = false;
            this.tvnRange.ShowRootLines = false;
            this.tvnRange.Size = new System.Drawing.Size(277, 319);
            this.tvnRange.TabIndex = 1;
            this.tvnRange.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvnRange_NodeMouseClick);
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
            // tsGridResoult
            // 
            this.tsGridResoult.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.tsGridResoult.AntiAlias = true;
            this.tsGridResoult.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.tsGridResoult.BackgroundStyle.Class = "";
            this.tsGridResoult.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.tsGridResoult.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
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
            this.tsGridResoult.Font = new System.Drawing.Font("B Nazanin", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsGridResoult.ImageSizeNormal = new System.Drawing.Size(24, 24);
            this.tsGridResoult.Location = new System.Drawing.Point(0, 270);
            this.tsGridResoult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tsGridResoult.MouseOverTabColors.BorderColor = System.Drawing.Color.Moccasin;
            this.tsGridResoult.Name = "tsGridResoult";
            this.tsGridResoult.SelectedTab = this.bbtButton;
            this.tsGridResoult.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.tsGridResoult.Size = new System.Drawing.Size(785, 49);
            this.tsGridResoult.TabIndex = 4;
            this.tsGridResoult.Tabs.Add(this.bbtButton);
            this.tsGridResoult.TooltipFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsGridResoult.TooltipOutlineColor = System.Drawing.Color.Transparent;
            this.tsGridResoult.TooltipTextColor = System.Drawing.Color.Black;
            // 
            // bbtButton
            // 
            this.bbtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.bbtButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.bbtButton.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.btnToXML,
            this.btnSaveExcell,
            this.btnPrint});
            this.bbtButton.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bbtButton.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bbtButton.Name = "bbtButton";
            this.bbtButton.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Yellow;
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
            // ssRangeReport
            // 
            this.ssRangeReport.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ssRangeReport.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssRangeReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssLblStatus,
            this.toolStripStatusLabel3,
            this.tspReprtBar});
            this.ssRangeReport.Location = new System.Drawing.Point(0, 419);
            this.ssRangeReport.Name = "ssRangeReport";
            this.ssRangeReport.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.ssRangeReport.ShowItemToolTips = true;
            this.ssRangeReport.Size = new System.Drawing.Size(1067, 33);
            this.ssRangeReport.TabIndex = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 27);
            this.toolStripStatusLabel1.Text = "وضعیت :";
            // 
            // tssLblStatus
            // 
            this.tssLblStatus.Name = "tssLblStatus";
            this.tssLblStatus.Size = new System.Drawing.Size(405, 27);
            this.tssLblStatus.Spring = true;
            this.tssLblStatus.Text = "آماده برای گزارش گیری";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(405, 27);
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
            // grvResoultOfReport
            // 
            this.grvResoultOfReport.ColumnHeadersHeight = 29;
            this.grvResoultOfReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvResoultOfReport.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grvResoultOfReport.Location = new System.Drawing.Point(0, 0);
            this.grvResoultOfReport.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grvResoultOfReport.Name = "grvResoultOfReport";
            this.grvResoultOfReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grvResoultOfReport.RowHeadersWidth = 51;
            this.grvResoultOfReport.Size = new System.Drawing.Size(785, 270);
            this.grvResoultOfReport.TabIndex = 9;
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
            this.splitContainer1.Panel1.Controls.Add(this.grvResoultOfReport);
            this.splitContainer1.Panel1.Controls.Add(this.tsGridResoult);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tvnRange);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1067, 319);
            this.splitContainer1.SplitterDistance = 785;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 10;
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
            this.splitContainer2.Size = new System.Drawing.Size(1067, 419);
            this.splitContainer2.SplitterDistance = 97;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 11;
            // 
            // frmLoanRangeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 452);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.ssRangeReport);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmLoanRangeReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "گزارش رنج بندی - تسهیلات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoanRangeReport_FormClosing);
            this.Load += new System.EventHandler(this.frmRangeReport_Load);
            this.grbSetting.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.cmsTreeRange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tsGridResoult)).EndInit();
            this.ssRangeReport.ResumeLayout(false);
            this.ssRangeReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvResoultOfReport)).EndInit();
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

        private System.Windows.Forms.GroupBox grbSetting;
        private System.Windows.Forms.Label lblNameReport;
        private Utilize.Company.CButton btnShow;
        private System.Windows.Forms.TreeView tvnRange;
        private DevComponents.DotNetBar.BubbleBar tsGridResoult;
        private DevComponents.DotNetBar.BubbleBarTab bbtButton;
        private DevComponents.DotNetBar.BubbleButton btnSaveExcell;
        private DevComponents.DotNetBar.BubbleButton btnPrint;
        private DevComponents.DotNetBar.BubbleButton btnToXML;
        private System.Windows.Forms.StatusStrip ssRangeReport;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssLblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripProgressBar tspReprtBar;
        private System.Windows.Forms.ContextMenuStrip cmsTreeRange;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveRange;
        private System.Windows.Forms.DataGridView grvResoultOfReport;
        private System.Windows.Forms.ComboBox cmbBaseRange;
        private System.Windows.Forms.ComboBox cmbReport;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private Utilize.Company.CButton cbCloseAll;
    }
}