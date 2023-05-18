namespace Utilize.Pdf
{
    partial class SaveDataInPdf
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
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveDataInPdf));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            this.ultraGridPdfExporter = new Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter(this.components);
            this.rbtFileByColumn = new System.Windows.Forms.RadioButton();
            this.rbtFileByCountRow = new System.Windows.Forms.RadioButton();
            this.txtFileByCountRow = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.rbtAllRowInOneFile = new System.Windows.Forms.RadioButton();
            this.txtDefaultName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtFolderName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddressFolder = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cmbFileByColumn = new Utilize.Company.CComboCox();
            this.btnFolderBrowse = new Utilize.Company.CButton();
            this.btnSave = new Utilize.Company.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileByCountRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDefaultName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFileByColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGridPdfExporter
            // 
            this.ultraGridPdfExporter.EndExport += new System.EventHandler<Infragistics.Win.UltraWinGrid.DocumentExport.EndExportEventArgs>(this.ultraGridPdfExporter_EndExport);
            this.ultraGridPdfExporter.RowExporting += new System.EventHandler<Infragistics.Win.UltraWinGrid.DocumentExport.RowExportingEventArgs>(this.ultraGridPdfExporter_RowExporting);
            // 
            // rbtFileByColumn
            // 
            this.rbtFileByColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtFileByColumn.AutoSize = true;
            this.rbtFileByColumn.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtFileByColumn.Location = new System.Drawing.Point(530, 32);
            this.rbtFileByColumn.Name = "rbtFileByColumn";
            this.rbtFileByColumn.Size = new System.Drawing.Size(187, 31);
            this.rbtFileByColumn.TabIndex = 1;
            this.rbtFileByColumn.Text = "ذخیره در فایل های مختلف";
            this.rbtFileByColumn.UseVisualStyleBackColor = true;
            this.rbtFileByColumn.CheckedChanged += new System.EventHandler(this.rbtFileByColumn_CheckedChanged);
            // 
            // rbtFileByCountRow
            // 
            this.rbtFileByCountRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtFileByCountRow.AutoSize = true;
            this.rbtFileByCountRow.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtFileByCountRow.Location = new System.Drawing.Point(154, 29);
            this.rbtFileByCountRow.Name = "rbtFileByCountRow";
            this.rbtFileByCountRow.Size = new System.Drawing.Size(187, 31);
            this.rbtFileByCountRow.TabIndex = 3;
            this.rbtFileByCountRow.Text = "هر تعداد ردیف در یک فایل";
            this.rbtFileByCountRow.UseVisualStyleBackColor = true;
            this.rbtFileByCountRow.CheckedChanged += new System.EventHandler(this.rbtFileByCountRow_CheckedChanged);
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
            this.txtFileByCountRow.Location = new System.Drawing.Point(27, 26);
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
            this.txtDefaultName.Location = new System.Drawing.Point(340, 103);
            this.txtDefaultName.Name = "txtDefaultName";
            this.txtDefaultName.Size = new System.Drawing.Size(291, 26);
            this.txtDefaultName.TabIndex = 12;
            this.txtDefaultName.Text = "Report-Pdf";
            // 
            // txtFolderName
            // 
            this.txtFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.txtFolderName.Appearance = appearance1;
            this.txtFolderName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010;
            this.txtFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFolderName.Location = new System.Drawing.Point(340, 69);
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
            this.label1.Location = new System.Drawing.Point(637, 106);
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
            this.lblAddressFolder.Location = new System.Drawing.Point(637, 70);
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
            this.cmbFileByColumn.Location = new System.Drawing.Point(403, 29);
            this.cmbFileByColumn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFileByColumn.Name = "cmbFileByColumn";
            this.cmbFileByColumn.Size = new System.Drawing.Size(160, 23);
            this.cmbFileByColumn.TabIndex = 19;
            // 
            // btnFolderBrowse
            // 
            this.btnFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolderBrowse.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnFolderBrowse.DefaultImage")));
            this.btnFolderBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFolderBrowse.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFolderBrowse.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnFolderBrowse.HoverImage")));
            this.btnFolderBrowse.Location = new System.Drawing.Point(300, 70);
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
            this.btnSave.Location = new System.Drawing.Point(135, 89);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 16;
            this.btnSave.Title = "ذخیره فایل";
            this.btnSave.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnSave_Click);
            // 
            // SaveDataInPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cmbFileByColumn);
            this.Controls.Add(this.rbtAllRowInOneFile);
            this.Controls.Add(this.btnFolderBrowse);
            this.Controls.Add(this.rbtFileByCountRow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDefaultName);
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.rbtFileByColumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileByCountRow);
            this.Controls.Add(this.lblAddressFolder);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "SaveDataInPdf";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(732, 148);
            this.Load += new System.EventHandler(this.SaveDataInPdf_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SaveDataInPdf_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.txtFileByCountRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDefaultName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFileByColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter ultraGridPdfExporter;
        //private Infragistics.Win.UltraWinGrid.UltraGridDocumentExporter UltraGridDocumentExporter tableExporter = new UltraGridDocumentExporter();
        private System.Windows.Forms.RadioButton rbtFileByColumn;
        private System.Windows.Forms.RadioButton rbtFileByCountRow;
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
	}
}
