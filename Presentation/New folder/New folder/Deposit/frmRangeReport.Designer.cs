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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRangeReport));
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.cmsTreeRange = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRemoveRange = new System.Windows.Forms.ToolStripMenuItem();
            this.ugpDocument = new Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(this.components);
            this.ugeExporter = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            this.grvResoultOfReport = new Infragistics.Win.UltraWinGrid.UltraGrid();
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
            this.grbSetting = new Utilize.Company.CGroupBox();
            this.cmbBaseRange = new Utilize.Company.CComboCox();
            this.cmbReport = new Utilize.Company.CComboCox();
            this.btnShow = new Utilize.Company.CButton();
            this.lblBaseRange = new System.Windows.Forms.Label();
            this.lblNameReport = new System.Windows.Forms.Label();
            this.ugeDocument = new Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cmsTreeRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvResoultOfReport)).BeginInit();
            this.ssRangeReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsGridResoult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbSetting)).BeginInit();
            this.grbSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaseRange)).BeginInit();
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
            // cmsTreeRange
            // 
            this.cmsTreeRange.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsTreeRange.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRemoveRange});
            this.cmsTreeRange.Name = "contextMenuStrip1";
            this.cmsTreeRange.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsTreeRange.Size = new System.Drawing.Size(100, 26);
            // 
            // btnRemoveRange
            // 
            this.btnRemoveRange.Image = global::Presentation.Properties.Resources.Close;
            this.btnRemoveRange.Name = "btnRemoveRange";
            this.btnRemoveRange.Size = new System.Drawing.Size(99, 22);
            this.btnRemoveRange.Text = "حذف";
            this.btnRemoveRange.ToolTipText = "حذف رنج انتخابی";
            this.btnRemoveRange.Click += new System.EventHandler(this.btnRemoveRange_Click);
            // 
            // grvResoultOfReport
            // 
            appearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(217)))), ((int)(((byte)(201)))));
            appearance2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal;
            this.grvResoultOfReport.DisplayLayout.Appearance = appearance2;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(217)))), ((int)(((byte)(201)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            appearance3.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.grvResoultOfReport.DisplayLayout.GroupByBox.Appearance = appearance3;
            this.grvResoultOfReport.DisplayLayout.GroupByBox.Prompt = "برای گروه بندی ستون مورد نظر را گرفته و در این قسمت بندازید";
            appearance1.BackColor = System.Drawing.Color.Transparent;
            this.grvResoultOfReport.DisplayLayout.GroupByBox.PromptAppearance = appearance1;
            this.grvResoultOfReport.DisplayLayout.InterBandSpacing = 10;
            this.grvResoultOfReport.DisplayLayout.MaxColScrollRegions = 1;
            this.grvResoultOfReport.DisplayLayout.MaxRowScrollRegions = 1;
            this.grvResoultOfReport.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.grvResoultOfReport.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.grvResoultOfReport.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.CopyWithHeaders;
            this.grvResoultOfReport.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            this.grvResoultOfReport.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.True;
            this.grvResoultOfReport.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.grvResoultOfReport.DisplayLayout.Override.CardAreaAppearance = appearance4;
            this.grvResoultOfReport.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.grvResoultOfReport.DisplayLayout.Override.FilterOperatorDropDownItems = ((Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems)((((((((((((((Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.Equals | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.NotEquals)
                        | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.LessThan)
                        | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.LessThanOrEqualTo)
                        | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.GreaterThan)
                        | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.GreaterThanOrEqualTo)
                        | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.Like)
                        | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.NotLike)
                        | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.StartsWith)
                        | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.DoesNotStartWith)
                        | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.EndsWith)
                        | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.DoesNotEndWith)
                        | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.Contains)
                        | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.DoesNotContain)));
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance5.ForeColor = System.Drawing.Color.Black;
            appearance5.TextHAlignAsString = "Left";
            appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.grvResoultOfReport.DisplayLayout.Override.HeaderAppearance = appearance5;
            this.grvResoultOfReport.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.grvResoultOfReport.DisplayLayout.Override.RowAppearance = appearance6;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.grvResoultOfReport.DisplayLayout.Override.RowSelectorAppearance = appearance8;
            this.grvResoultOfReport.DisplayLayout.Override.RowSelectorWidth = 12;
            this.grvResoultOfReport.DisplayLayout.Override.RowSpacingBefore = 2;
            appearance13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            appearance13.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance13.ForeColor = System.Drawing.Color.Black;
            this.grvResoultOfReport.DisplayLayout.Override.SelectedRowAppearance = appearance13;
            this.grvResoultOfReport.DisplayLayout.Override.SummaryDisplayArea = ((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Top | Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Bottom)));
            this.grvResoultOfReport.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.grvResoultOfReport.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.grvResoultOfReport.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.grvResoultOfReport.DisplayLayout.UseOptimizedDataResetMode = true;
            this.grvResoultOfReport.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.grvResoultOfReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvResoultOfReport.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grvResoultOfReport.Location = new System.Drawing.Point(0, 0);
            this.grvResoultOfReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvResoultOfReport.Name = "grvResoultOfReport";
            this.grvResoultOfReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grvResoultOfReport.Size = new System.Drawing.Size(567, 302);
            this.grvResoultOfReport.TabIndex = 8;
            // 
            // ssRangeReport
            // 
            this.ssRangeReport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssRangeReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssLblStatus,
            this.toolStripStatusLabel3,
            this.tspReprtBar});
            this.ssRangeReport.Location = new System.Drawing.Point(0, 434);
            this.ssRangeReport.Name = "ssRangeReport";
            this.ssRangeReport.ShowItemToolTips = true;
            this.ssRangeReport.Size = new System.Drawing.Size(800, 25);
            this.ssRangeReport.TabIndex = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel1.Text = "وضعیت :";
            // 
            // tssLblStatus
            // 
            this.tssLblStatus.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tssLblStatus.Name = "tssLblStatus";
            this.tssLblStatus.Size = new System.Drawing.Size(368, 20);
            this.tssLblStatus.Spring = true;
            this.tssLblStatus.Text = "آماده برای گزارش گیری";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(368, 20);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "|";
            // 
            // tspReprtBar
            // 
            this.tspReprtBar.Name = "tspReprtBar";
            this.tspReprtBar.Size = new System.Drawing.Size(100, 19);
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
            this.tsGridResoult.Location = new System.Drawing.Point(0, 302);
            this.tsGridResoult.Name = "tsGridResoult";
            this.tsGridResoult.SelectedTab = this.bbtButton;
            this.tsGridResoult.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.tsGridResoult.Size = new System.Drawing.Size(567, 46);
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
            this.tvnRange.BackColor = System.Drawing.Color.White;
            this.tvnRange.ContextMenuStrip = this.cmsTreeRange;
            this.tvnRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvnRange.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tvnRange.FullRowSelect = true;
            this.tvnRange.Location = new System.Drawing.Point(0, 0);
            this.tvnRange.Name = "tvnRange";
            this.tvnRange.ShowLines = false;
            this.tvnRange.ShowNodeToolTips = true;
            this.tvnRange.ShowPlusMinus = false;
            this.tvnRange.ShowRootLines = false;
            this.tvnRange.Size = new System.Drawing.Size(229, 348);
            this.tvnRange.TabIndex = 1;
            this.tvnRange.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvnRange_NodeMouseClick);
            // 
            // grbSetting
            // 
            this.grbSetting.BackColor = System.Drawing.Color.Transparent;
            this.grbSetting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.grbSetting.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.grbSetting.Controls.Add(this.cmbBaseRange);
            this.grbSetting.Controls.Add(this.cmbReport);
            this.grbSetting.Controls.Add(this.btnShow);
            this.grbSetting.Controls.Add(this.lblBaseRange);
            this.grbSetting.Controls.Add(this.lblNameReport);
            this.grbSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbSetting.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grbSetting.Location = new System.Drawing.Point(0, 0);
            this.grbSetting.Name = "grbSetting";
            this.grbSetting.Padding = new System.Windows.Forms.Padding(3);
            this.grbSetting.Size = new System.Drawing.Size(800, 83);
            this.grbSetting.TabIndex = 0;
            this.grbSetting.Text = "تنظیمات اولیه";
            // 
            // cmbBaseRange
            // 
            this.cmbBaseRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance11.BorderColor = System.Drawing.Color.Transparent;
            appearance11.BorderColor2 = System.Drawing.Color.Transparent;
            appearance11.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance11.ImageBackground")));
            appearance11.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbBaseRange.Appearance = appearance11;
            this.cmbBaseRange.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbBaseRange.AutoSize = false;
            this.cmbBaseRange.BorderStyle = Infragistics.Win.UIElementBorderStyle.None;
            appearance12.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance12.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance12.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance12.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance12.ImageBackground")));
            appearance12.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Centered;
            this.cmbBaseRange.ButtonAppearance = appearance12;
            this.cmbBaseRange.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbBaseRange.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbBaseRange.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbBaseRange.HideSelection = false;
            appearance14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(188)))), ((int)(((byte)(124)))));
            appearance14.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(225)))), ((int)(((byte)(176)))));
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance14.BorderColor = System.Drawing.Color.Transparent;
            this.cmbBaseRange.ItemAppearance = appearance14;
            this.cmbBaseRange.Location = new System.Drawing.Point(452, 37);
            this.cmbBaseRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBaseRange.MaxDropDownItems = 20;
            this.cmbBaseRange.Name = "cmbBaseRange";
            this.cmbBaseRange.Size = new System.Drawing.Size(250, 18);
            this.cmbBaseRange.TabIndex = 106;
            // 
            // cmbReport
            // 
            this.cmbReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(229)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance7.BorderColor = System.Drawing.Color.Transparent;
            appearance7.BorderColor2 = System.Drawing.Color.Transparent;
            appearance7.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance7.ImageBackground")));
            appearance7.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbReport.Appearance = appearance7;
            this.cmbReport.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbReport.AutoSize = false;
            this.cmbReport.BorderStyle = Infragistics.Win.UIElementBorderStyle.None;
            appearance9.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance9.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance9.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance9.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance9.ImageBackground")));
            appearance9.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Centered;
            this.cmbReport.ButtonAppearance = appearance9;
            this.cmbReport.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbReport.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbReport.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbReport.HideSelection = false;
            appearance10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(188)))), ((int)(((byte)(124)))));
            appearance10.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(225)))), ((int)(((byte)(176)))));
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance10.BorderColor = System.Drawing.Color.Transparent;
            this.cmbReport.ItemAppearance = appearance10;
            this.cmbReport.Location = new System.Drawing.Point(452, 17);
            this.cmbReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbReport.MaxDropDownItems = 20;
            this.cmbReport.Name = "cmbReport";
            this.cmbReport.Size = new System.Drawing.Size(250, 18);
            this.cmbReport.TabIndex = 105;
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnShow.DefaultImage")));
            this.btnShow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShow.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShow.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnShow.HoverImage")));
            this.btnShow.Location = new System.Drawing.Point(9, 33);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShow.Size = new System.Drawing.Size(92, 26);
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
            this.lblBaseRange.Location = new System.Drawing.Point(705, 38);
            this.lblBaseRange.Name = "lblBaseRange";
            this.lblBaseRange.Size = new System.Drawing.Size(83, 20);
            this.lblBaseRange.TabIndex = 1;
            this.lblBaseRange.Text = "پایه تقسیم بندی";
            // 
            // lblNameReport
            // 
            this.lblNameReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameReport.AutoSize = true;
            this.lblNameReport.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNameReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblNameReport.Location = new System.Drawing.Point(733, 18);
            this.lblNameReport.Name = "lblNameReport";
            this.lblNameReport.Size = new System.Drawing.Size(55, 20);
            this.lblNameReport.TabIndex = 0;
            this.lblNameReport.Text = "نام گزارش";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 348);
            this.splitContainer1.SplitterDistance = 567;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.splitContainer2.Size = new System.Drawing.Size(800, 434);
            this.splitContainer2.SplitterDistance = 83;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 10;
            // 
            // frmRangeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.ssRangeReport);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRangeReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "گزارش رنج بندی - سپرده ها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRangeReport_FormClosing);
            this.Load += new System.EventHandler(this.frmRangeReport_Load);
            this.cmsTreeRange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvResoultOfReport)).EndInit();
            this.ssRangeReport.ResumeLayout(false);
            this.ssRangeReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsGridResoult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbSetting)).EndInit();
            this.grbSetting.ResumeLayout(false);
            this.grbSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaseRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReport)).EndInit();
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

        private Utilize.Company.CGroupBox grbSetting;
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
        private Utilize.Company.CComboCox cmbBaseRange;
        private Utilize.Company.CComboCox cmbReport;
        private Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter ugeDocument;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}