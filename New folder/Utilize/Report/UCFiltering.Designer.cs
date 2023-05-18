﻿namespace Utilize.Report
{
    partial class UCFiltering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFiltering));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            this.chbTitle = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnShowSelected = new Utilize.Company.CButton();
            this.btnClearSelected = new Utilize.Company.CButton();
            this.cmbSource = new Utilize.Company.CComboCox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chbTitle
            // 
            this.chbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbTitle.AutoSize = true;
            this.chbTitle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbTitle.Location = new System.Drawing.Point(436, 12);
            this.chbTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbTitle.Name = "chbTitle";
            this.chbTitle.Size = new System.Drawing.Size(59, 24);
            this.chbTitle.TabIndex = 105;
            this.chbTitle.Text = "Title";
            this.chbTitle.UseVisualStyleBackColor = true;
            this.chbTitle.CheckedChanged += new System.EventHandler(this.chbTitle_CheckedChanged);
            // 
            // btnShowSelected
            // 
            this.btnShowSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowSelected.AutoSize = true;
            this.btnShowSelected.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnShowSelected.DefaultImage")));
            this.btnShowSelected.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowSelected.Enabled = false;
            this.btnShowSelected.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowSelected.HoverImage")));
            this.btnShowSelected.Location = new System.Drawing.Point(12, 13);
            this.btnShowSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowSelected.Name = "btnShowSelected";
            this.btnShowSelected.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowSelected.Size = new System.Drawing.Size(26, 26);
            this.btnShowSelected.TabIndex = 106;
            this.btnShowSelected.Title = null;
            this.toolTip1.SetToolTip(this.btnShowSelected, "نمایش مورد انتخاب شده");
            this.btnShowSelected.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnShowSelected_Click);
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSelected.AutoSize = true;
            this.btnClearSelected.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnClearSelected.DefaultImage")));
            this.btnClearSelected.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClearSelected.Enabled = false;
            this.btnClearSelected.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClearSelected.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnClearSelected.HoverImage")));
            this.btnClearSelected.Location = new System.Drawing.Point(42, 13);
            this.btnClearSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClearSelected.Size = new System.Drawing.Size(26, 26);
            this.btnClearSelected.TabIndex = 107;
            this.btnClearSelected.Title = null;
            this.toolTip1.SetToolTip(this.btnClearSelected, "حذف مورد انتخاب شده");
            this.btnClearSelected.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnClearSelected_Click);
            // 
            // cmbSource
            // 
            this.cmbSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            appearance1.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbSource.Appearance = appearance1;
            this.cmbSource.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbSource.AutoSize = false;
            this.cmbSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance5.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance5.ImageBackground")));
            appearance5.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbSource.ButtonAppearance = appearance5;
            this.cmbSource.CheckedListSettings.CheckBoxStyle = Infragistics.Win.CheckStyle.CheckBox;
            this.cmbSource.CheckedListSettings.EditorValueSource = Infragistics.Win.EditorWithComboValueSource.CheckedItems;
            this.cmbSource.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbSource.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbSource.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbSource.Enabled = false;
            this.cmbSource.HideSelection = false;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbSource.ItemAppearance = appearance6;
            this.cmbSource.Location = new System.Drawing.Point(85, 14);
            this.cmbSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSource.MaximumSize = new System.Drawing.Size(400, 40);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(275, 21);
            this.cmbSource.TabIndex = 108;
            this.cmbSource.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.cmbSource_BeforeDropDown);
            this.cmbSource.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSource_KeyPress);
            // 
            // UCFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cmbSource);
            this.Controls.Add(this.btnShowSelected);
            this.Controls.Add(this.btnClearSelected);
            this.Controls.Add(this.chbTitle);
            this.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCFiltering";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(498, 48);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbTitle;
        private Company.CButton btnClearSelected;
        private Company.CButton btnShowSelected;
        private System.Windows.Forms.ToolTip toolTip1;
        private Company.CComboCox cmbSource;
    }
}
