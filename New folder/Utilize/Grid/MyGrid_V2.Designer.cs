namespace Utilize.Grid
{
    sealed partial class MyGrid_V2
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyGrid_V2));
            this.ultraGridExcelExporter = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            this.ugd = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.cntMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowChart = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSave = new Utilize.Company.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.ugd)).BeginInit();
            this.cntMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ugd
            // 
            this.ugd.ContextMenuStrip = this.cntMain;
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(217)))), ((int)(((byte)(201)))));
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal;
            this.ugd.DisplayLayout.Appearance = appearance1;
            this.ugd.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(217)))), ((int)(((byte)(201)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.ugd.DisplayLayout.GroupByBox.Appearance = appearance7;
            appearance8.BackColor = System.Drawing.Color.Transparent;
            this.ugd.DisplayLayout.GroupByBox.BandLabelAppearance = appearance8;
            this.ugd.DisplayLayout.GroupByBox.Prompt = "برای گروه بندی ستون مورد نظر را گرفته و در این قسمت رها کنید";
            appearance9.BackColor = System.Drawing.Color.Transparent;
            this.ugd.DisplayLayout.GroupByBox.PromptAppearance = appearance9;
            this.ugd.DisplayLayout.InterBandSpacing = 10;
            this.ugd.DisplayLayout.MaxColScrollRegions = 1;
            this.ugd.DisplayLayout.MaxRowScrollRegions = 1;
            this.ugd.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ugd.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ugd.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.CopyWithHeaders;
            this.ugd.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            this.ugd.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.True;
            this.ugd.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.ugd.DisplayLayout.Override.CardAreaAppearance = appearance2;
            this.ugd.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ugd.DisplayLayout.Override.FilterOperatorDropDownItems = ((Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems)((((((((((((((Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.Equals | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.NotEquals) 
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
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.ForeColor = System.Drawing.Color.Black;
            appearance3.TextHAlignAsString = "Left";
            appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ugd.DisplayLayout.Override.HeaderAppearance = appearance3;
            this.ugd.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.ugd.DisplayLayout.Override.RowAppearance = appearance4;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ugd.DisplayLayout.Override.RowSelectorAppearance = appearance5;
            this.ugd.DisplayLayout.Override.RowSelectorWidth = 12;
            this.ugd.DisplayLayout.Override.RowSpacingBefore = 2;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.Color.Black;
            this.ugd.DisplayLayout.Override.SelectedRowAppearance = appearance6;
            this.ugd.DisplayLayout.Override.SummaryDisplayArea = ((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Top | Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Bottom)));
            this.ugd.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.ugd.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ugd.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ugd.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ugd.DisplayLayout.UseOptimizedDataResetMode = true;
            this.ugd.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ugd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ugd.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ugd.Location = new System.Drawing.Point(0, 0);
            this.ugd.Name = "ugd";
            this.ugd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ugd.Size = new System.Drawing.Size(714, 419);
            this.ugd.TabIndex = 3;
            this.ugd.BeforeSummaryDialog += new Infragistics.Win.UltraWinGrid.BeforeSummaryDialogEventHandler(this.ugd_BeforeSummaryDialog);
            this.ugd.AfterSummaryDialog += new Infragistics.Win.UltraWinGrid.AfterSummaryDialogEventHandler(this.ugd_AfterSummaryDialog);
            this.ugd.Click += new System.EventHandler(this.ugd_Click);
            // 
            // cntMain
            // 
            this.cntMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowChart});
            this.cntMain.Name = "cntMain";
            this.cntMain.Size = new System.Drawing.Size(140, 26);
            // 
            // btnShowChart
            // 
            this.btnShowChart.Image = global::Utilize.Properties.Resources.chart;
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.Size = new System.Drawing.Size(139, 22);
            this.btnShowChart.Text = "نمایش نمودار";
            this.btnShowChart.Click += new System.EventHandler(this.btnShowChart_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ugd);
            this.splitContainer1.Size = new System.Drawing.Size(714, 462);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnSave.DefaultImage")));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnSave.HoverImage")));
            this.btnSave.Location = new System.Drawing.Point(3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Size = new System.Drawing.Size(36, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Title = null;
            this.btnSave.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // MyGrid_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "MyGrid_V2";
            this.Size = new System.Drawing.Size(714, 462);
            ((System.ComponentModel.ISupportInitialize)(this.ugd)).EndInit();
            this.cntMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Utilize.Company.CButton btnSave;
		private Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter ultraGridExcelExporter;
        public Infragistics.Win.UltraWinGrid.UltraGrid ugd;
        private System.Windows.Forms.ContextMenuStrip cntMain;
        public System.Windows.Forms.ToolStripMenuItem btnShowChart;
        private System.Windows.Forms.SplitContainer splitContainer1;
	}
}
