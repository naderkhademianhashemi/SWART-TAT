namespace Utilize.Excel
{
	partial class SaveDataInExcel
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
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveDataInExcel));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            this.ultraGridExcelExporter = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            this.rbtSheetByColumn = new System.Windows.Forms.RadioButton();
            this.rbtFileByColumn = new System.Windows.Forms.RadioButton();
            this.rbtSheetByCountRow = new System.Windows.Forms.RadioButton();
            this.rbtFileByCountRow = new System.Windows.Forms.RadioButton();
            this.txtSheetByCountRow = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.txtFileByCountRow = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.rbtAllRowInOneFile = new System.Windows.Forms.RadioButton();
            this.txtDefaultName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtFolderName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddressFolder = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cmbFileByColumn = new Utilize.Company.CComboCox();
            this.cmbSheetByColumn = new Utilize.Company.CComboCox();
            this.btnFolderBrowse = new Utilize.Company.CButton();
            this.btnSave = new Utilize.Company.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSheetByCountRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileByCountRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDefaultName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFileByColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSheetByColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtSheetByColumn
            // 
            this.rbtSheetByColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtSheetByColumn.AutoSize = true;
            this.rbtSheetByColumn.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtSheetByColumn.Location = new System.Drawing.Point(503, 33);
            this.rbtSheetByColumn.Name = "rbtSheetByColumn";
            this.rbtSheetByColumn.Size = new System.Drawing.Size(215, 31);
            this.rbtSheetByColumn.TabIndex = 0;
            this.rbtSheetByColumn.Text = "ذخیره در sheet های مختلف";
            this.rbtSheetByColumn.UseVisualStyleBackColor = true;
            this.rbtSheetByColumn.CheckedChanged += new System.EventHandler(this.rbtSheetByColumn_CheckedChanged);
            // 
            // rbtFileByColumn
            // 
            this.rbtFileByColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtFileByColumn.AutoSize = true;
            this.rbtFileByColumn.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtFileByColumn.Location = new System.Drawing.Point(152, 33);
            this.rbtFileByColumn.Name = "rbtFileByColumn";
            this.rbtFileByColumn.Size = new System.Drawing.Size(187, 31);
            this.rbtFileByColumn.TabIndex = 1;
            this.rbtFileByColumn.Text = "ذخیره در فایل های مختلف";
            this.rbtFileByColumn.UseVisualStyleBackColor = true;
            this.rbtFileByColumn.CheckedChanged += new System.EventHandler(this.rbtFileByColumn_CheckedChanged);
            // 
            // rbtSheetByCountRow
            // 
            this.rbtSheetByCountRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtSheetByCountRow.AutoSize = true;
            this.rbtSheetByCountRow.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtSheetByCountRow.Location = new System.Drawing.Point(503, 64);
            this.rbtSheetByCountRow.Name = "rbtSheetByCountRow";
            this.rbtSheetByCountRow.Size = new System.Drawing.Size(215, 31);
            this.rbtSheetByCountRow.TabIndex = 2;
            this.rbtSheetByCountRow.Text = "هر تعداد دریف در یک sheet";
            this.rbtSheetByCountRow.UseVisualStyleBackColor = true;
            this.rbtSheetByCountRow.CheckedChanged += new System.EventHandler(this.rbtSheetByCountRow_CheckedChanged);
            // 
            // rbtFileByCountRow
            // 
            this.rbtFileByCountRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtFileByCountRow.AutoSize = true;
            this.rbtFileByCountRow.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtFileByCountRow.Location = new System.Drawing.Point(152, 64);
            this.rbtFileByCountRow.Name = "rbtFileByCountRow";
            this.rbtFileByCountRow.Size = new System.Drawing.Size(187, 31);
            this.rbtFileByCountRow.TabIndex = 3;
            this.rbtFileByCountRow.Text = "هر تعداد ردیف در یک فایل";
            this.rbtFileByCountRow.UseVisualStyleBackColor = true;
            this.rbtFileByCountRow.CheckedChanged += new System.EventHandler(this.rbtFileByCountRow_CheckedChanged);
            // 
            // txtSheetByCountRow
            // 
            this.txtSheetByCountRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(197)))), ((int)(((byte)(151)))));
            appearance10.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(239)))), ((int)(((byte)(224)))));
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.txtSheetByCountRow.Appearance = appearance10;
            this.txtSheetByCountRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(197)))), ((int)(((byte)(151)))));
            appearance12.BackColor = System.Drawing.Color.White;
            appearance12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(114)))));
            this.txtSheetByCountRow.ButtonAppearance = appearance12;
            this.txtSheetByCountRow.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.txtSheetByCountRow.Enabled = false;
            this.txtSheetByCountRow.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSheetByCountRow.FormatProvider = new System.Globalization.CultureInfo("fa-IR");
            this.txtSheetByCountRow.Location = new System.Drawing.Point(384, 61);
            this.txtSheetByCountRow.MaskInput = "{LOC}nn,nnn,nnn";
            this.txtSheetByCountRow.Name = "txtSheetByCountRow";
            this.txtSheetByCountRow.Size = new System.Drawing.Size(160, 35);
            this.txtSheetByCountRow.SpinButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.txtSheetByCountRow.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.OnMouseEnter;
            this.txtSheetByCountRow.TabIndex = 6;
            // 
            // txtFileByCountRow
            // 
            this.txtFileByCountRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(197)))), ((int)(((byte)(151)))));
            appearance11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(239)))), ((int)(((byte)(224)))));
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.txtFileByCountRow.Appearance = appearance11;
            this.txtFileByCountRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(197)))), ((int)(((byte)(151)))));
            appearance13.BackColor = System.Drawing.Color.White;
            appearance13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(114)))));
            this.txtFileByCountRow.ButtonAppearance = appearance13;
            this.txtFileByCountRow.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.txtFileByCountRow.Enabled = false;
            this.txtFileByCountRow.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFileByCountRow.FormatProvider = new System.Globalization.CultureInfo("fa-IR");
            this.txtFileByCountRow.Location = new System.Drawing.Point(25, 61);
            this.txtFileByCountRow.MaskInput = "{LOC}nn,nnn,nnn";
            this.txtFileByCountRow.Name = "txtFileByCountRow";
            this.txtFileByCountRow.NullText = "100000";
            this.txtFileByCountRow.Size = new System.Drawing.Size(160, 35);
            this.txtFileByCountRow.SpinButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.txtFileByCountRow.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.OnMouseEnter;
            this.txtFileByCountRow.TabIndex = 7;
            this.txtFileByCountRow.Value = 100000;
            // 
            // rbtAllRowInOneFile
            // 
            this.rbtAllRowInOneFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtAllRowInOneFile.AutoSize = true;
            this.rbtAllRowInOneFile.Checked = true;
            this.rbtAllRowInOneFile.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtAllRowInOneFile.Location = new System.Drawing.Point(586, 3);
            this.rbtAllRowInOneFile.Name = "rbtAllRowInOneFile";
            this.rbtAllRowInOneFile.Size = new System.Drawing.Size(132, 31);
            this.rbtAllRowInOneFile.TabIndex = 8;
            this.rbtAllRowInOneFile.TabStop = true;
            this.rbtAllRowInOneFile.Text = "تماماً در یک فایل";
            this.rbtAllRowInOneFile.UseVisualStyleBackColor = true;
            // 
            // txtDefaultName
            // 
            this.txtDefaultName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            this.txtDefaultName.Appearance = appearance2;
            this.txtDefaultName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.txtDefaultName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDefaultName.Location = new System.Drawing.Point(331, 139);
            this.txtDefaultName.Name = "txtDefaultName";
            this.txtDefaultName.Size = new System.Drawing.Size(291, 26);
            this.txtDefaultName.TabIndex = 12;
            this.txtDefaultName.Text = "Report-Excel";
            // 
            // txtFolderName
            // 
            this.txtFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.txtFolderName.Appearance = appearance1;
            this.txtFolderName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.txtFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFolderName.Location = new System.Drawing.Point(331, 105);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.ReadOnly = true;
            this.txtFolderName.Size = new System.Drawing.Size(291, 26);
            this.txtFolderName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(628, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "نام پیش فرض :";
            // 
            // lblAddressFolder
            // 
            this.lblAddressFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddressFolder.AutoSize = true;
            this.lblAddressFolder.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAddressFolder.Location = new System.Drawing.Point(628, 106);
            this.lblAddressFolder.Name = "lblAddressFolder";
            this.lblAddressFolder.Size = new System.Drawing.Size(94, 27);
            this.lblAddressFolder.TabIndex = 9;
            this.lblAddressFolder.Text = "آدرس ذخیره :";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "مکان ذخیرۀ گزارش به صورت اکسل";
            // 
            // cmbFileByColumn
            // 
            this.cmbFileByColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance7.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance7.ImageBackground")));
            appearance7.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbFileByColumn.Appearance = appearance7;
            this.cmbFileByColumn.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbFileByColumn.AutoSize = false;
            this.cmbFileByColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance8.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance8.ImageBackground")));
            appearance8.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbFileByColumn.ButtonAppearance = appearance8;
            this.cmbFileByColumn.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbFileByColumn.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbFileByColumn.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbFileByColumn.HideSelection = false;
            appearance9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance9.BorderColor = System.Drawing.Color.Transparent;
            this.cmbFileByColumn.ItemAppearance = appearance9;
            this.cmbFileByColumn.Location = new System.Drawing.Point(25, 30);
            this.cmbFileByColumn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFileByColumn.Name = "cmbFileByColumn";
            this.cmbFileByColumn.Size = new System.Drawing.Size(160, 23);
            this.cmbFileByColumn.TabIndex = 19;
            // 
            // cmbSheetByColumn
            // 
            this.cmbSheetByColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance4.ImageBackground")));
            appearance4.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbSheetByColumn.Appearance = appearance4;
            this.cmbSheetByColumn.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbSheetByColumn.AutoSize = false;
            this.cmbSheetByColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance5.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance5.ImageBackground")));
            appearance5.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbSheetByColumn.ButtonAppearance = appearance5;
            this.cmbSheetByColumn.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbSheetByColumn.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbSheetByColumn.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbSheetByColumn.HideSelection = false;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance6.BorderColor = System.Drawing.Color.Transparent;
            this.cmbSheetByColumn.ItemAppearance = appearance6;
            this.cmbSheetByColumn.Location = new System.Drawing.Point(384, 30);
            this.cmbSheetByColumn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSheetByColumn.Name = "cmbSheetByColumn";
            this.cmbSheetByColumn.Size = new System.Drawing.Size(160, 23);
            this.cmbSheetByColumn.TabIndex = 18;
            // 
            // btnFolderBrowse
            // 
            this.btnFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolderBrowse.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnFolderBrowse.DefaultImage")));
            this.btnFolderBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFolderBrowse.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFolderBrowse.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnFolderBrowse.HoverImage")));
            this.btnFolderBrowse.Location = new System.Drawing.Point(291, 106);
            this.btnFolderBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFolderBrowse.Name = "btnFolderBrowse";
            this.btnFolderBrowse.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFolderBrowse.Size = new System.Drawing.Size(33, 20);
            this.btnFolderBrowse.TabIndex = 17;
            this.btnFolderBrowse.Title = null;
            this.btnFolderBrowse.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnFolderBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnSave.DefaultImage")));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnSave.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnSave.HoverImage")));
            this.btnSave.Location = new System.Drawing.Point(117, 138);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 16;
            this.btnSave.Title = "ذخیره فایل";
            this.btnSave.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnSave_Click);
            // 
            // SaveDataInExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbFileByColumn);
            this.Controls.Add(this.cmbSheetByColumn);
            this.Controls.Add(this.rbtAllRowInOneFile);
            this.Controls.Add(this.btnFolderBrowse);
            this.Controls.Add(this.rbtFileByCountRow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbtSheetByCountRow);
            this.Controls.Add(this.txtDefaultName);
            this.Controls.Add(this.txtSheetByCountRow);
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.rbtFileByColumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileByCountRow);
            this.Controls.Add(this.lblAddressFolder);
            this.Controls.Add(this.rbtSheetByColumn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "SaveDataInExcel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(732, 182);
            this.Load += new System.EventHandler(this.SaveDataInExcel_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SaveDataInExcel_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.txtSheetByCountRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileByCountRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDefaultName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFileByColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSheetByColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter ultraGridExcelExporter;
		private System.Windows.Forms.RadioButton rbtSheetByColumn;
		private System.Windows.Forms.RadioButton rbtFileByColumn;
		private System.Windows.Forms.RadioButton rbtSheetByCountRow;
		private System.Windows.Forms.RadioButton rbtFileByCountRow;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor txtSheetByCountRow;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor txtFileByCountRow;
        private System.Windows.Forms.RadioButton rbtAllRowInOneFile;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDefaultName;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtFolderName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblAddressFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private Company.CButton btnSave;
        private Company.CButton btnFolderBrowse;
        private Company.CComboCox cmbFileByColumn;
        private Company.CComboCox cmbSheetByColumn;
	}
}
