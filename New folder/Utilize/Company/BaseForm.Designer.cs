namespace Utilize.Company
{
    partial class BaseForm
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinScrollBar.ScrollBarLook scrollBarLook1 = new Infragistics.Win.UltraWinScrollBar.ScrollBarLook();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.dgvForPrint = new Infragistics.Win.UltraWinGrid.UltraGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvForPrint
            // 
            appearance2.BackColor = System.Drawing.Color.Gainsboro;
            appearance2.BackColor2 = System.Drawing.Color.Gainsboro;
            this.dgvForPrint.DisplayLayout.Appearance = appearance2;
            this.dgvForPrint.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.dgvForPrint.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(217)))), ((int)(((byte)(201)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal;
            appearance3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.dgvForPrint.DisplayLayout.GroupByBox.Appearance = appearance3;
            appearance11.BackColor = System.Drawing.Color.Transparent;
            this.dgvForPrint.DisplayLayout.GroupByBox.BandLabelAppearance = appearance11;
            this.dgvForPrint.DisplayLayout.GroupByBox.Hidden = true;
            this.dgvForPrint.DisplayLayout.GroupByBox.Prompt = "برای گروه بندی ستون مورد نظر را گرفته و در این قسمت بندازید";
            appearance1.BackColor = System.Drawing.Color.Transparent;
            this.dgvForPrint.DisplayLayout.GroupByBox.PromptAppearance = appearance1;
            this.dgvForPrint.DisplayLayout.InterBandSpacing = 10;
            this.dgvForPrint.DisplayLayout.MaxColScrollRegions = 1;
            this.dgvForPrint.DisplayLayout.MaxRowScrollRegions = 1;
            this.dgvForPrint.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.dgvForPrint.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.dgvForPrint.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.CopyWithHeaders;
            this.dgvForPrint.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            appearance4.BackColor = System.Drawing.Color.White;
            this.dgvForPrint.DisplayLayout.Override.CardAreaAppearance = appearance4;
            this.dgvForPrint.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.dgvForPrint.DisplayLayout.Override.FilterOperatorDropDownItems = ((Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems)((((((((((((((Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.Equals | Infragistics.Win.UltraWinGrid.FilterOperatorDropDownItems.NotEquals) 
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
            this.dgvForPrint.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.None;
            this.dgvForPrint.DisplayLayout.Override.FixedRowStyle = Infragistics.Win.UltraWinGrid.FixedRowStyle.Top;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(156)))), ((int)(((byte)(11)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(156)))), ((int)(((byte)(11)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance5.FontData.Name = "B Nazanin";
            appearance5.ForeColor = System.Drawing.Color.Black;
            appearance5.TextHAlignAsString = "Left";
            appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.dgvForPrint.DisplayLayout.Override.HeaderAppearance = appearance5;
            appearance6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(156)))), ((int)(((byte)(11)))));
            this.dgvForPrint.DisplayLayout.Override.RowAppearance = appearance6;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(156)))), ((int)(((byte)(11)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(156)))), ((int)(((byte)(11)))));
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.dgvForPrint.DisplayLayout.Override.RowSelectorAppearance = appearance8;
            this.dgvForPrint.DisplayLayout.Override.RowSelectorWidth = 12;
            this.dgvForPrint.DisplayLayout.Override.RowSpacingBefore = 2;
            appearance13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            appearance13.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance13.ForeColor = System.Drawing.Color.Black;
            this.dgvForPrint.DisplayLayout.Override.SelectedRowAppearance = appearance13;
            this.dgvForPrint.DisplayLayout.Override.SummaryDisplayArea = ((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Top | Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Bottom)));
            this.dgvForPrint.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.dgvForPrint.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            appearance12.BackColor = System.Drawing.Color.Gainsboro;
            appearance12.BackColor2 = System.Drawing.Color.Gainsboro;
            scrollBarLook1.Appearance = appearance12;
            this.dgvForPrint.DisplayLayout.ScrollBarLook = scrollBarLook1;
            this.dgvForPrint.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.dgvForPrint.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.dgvForPrint.DisplayLayout.UseOptimizedDataResetMode = true;
            this.dgvForPrint.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvForPrint.Location = new System.Drawing.Point(32767, 162);
            this.dgvForPrint.Margin = new System.Windows.Forms.Padding(3, 713236, 3, 713236);
            this.dgvForPrint.Name = "dgvForPrint";
            this.dgvForPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvForPrint.Size = new System.Drawing.Size(5000, 239);
            this.dgvForPrint.TabIndex = 4;
            this.dgvForPrint.Visible = false;
            // 
            // BaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dgvForPrint);
            this.Font = new System.Drawing.Font("B Nazanin", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvForPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Infragistics.Win.UltraWinGrid.UltraGrid dgvForPrint;


    }
}