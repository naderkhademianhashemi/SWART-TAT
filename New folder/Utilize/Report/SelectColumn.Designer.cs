namespace Utilize.Report
{
    partial class SelectColumn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectColumn));
            this.ugbSC = new Utilize.Company.CGroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSelectAll = new Utilize.Company.CButton();
            this.btnClearSelected = new Utilize.Company.CButton();
            this.chbColumnsOfShow = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ugbSC)).BeginInit();
            this.ugbSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ugbSC
            // 
            this.ugbSC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ugbSC.BackColor = System.Drawing.Color.Transparent;
            this.ugbSC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.ugbSC.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.ugbSC.Controls.Add(this.splitContainer1);
            this.ugbSC.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ugbSC.Location = new System.Drawing.Point(0, 0);
            this.ugbSC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ugbSC.Name = "ugbSC";
            this.ugbSC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ugbSC.Size = new System.Drawing.Size(440, 210);
            this.ugbSC.TabIndex = 139;
            this.ugbSC.Text = "ستون های انتخابی برای نمایش";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 26);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnClearSelected);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chbColumnsOfShow);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(434, 181);
            this.splitContainer1.SplitterDistance = 37;
            this.splitContainer1.TabIndex = 139;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.AutoSize = true;
            this.btnSelectAll.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectAll.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnSelectAll.DefaultImage")));
            this.btnSelectAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelectAll.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnSelectAll.HoverImage")));
            this.btnSelectAll.Location = new System.Drawing.Point(290, 2);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectAll.Size = new System.Drawing.Size(141, 34);
            this.btnSelectAll.TabIndex = 138;
            this.btnSelectAll.Title = null;
            this.btnSelectAll.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnSelectAll_Click);
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSelected.AutoSize = true;
            this.btnClearSelected.BackColor = System.Drawing.Color.Transparent;
            this.btnClearSelected.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnClearSelected.DefaultImage")));
            this.btnClearSelected.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClearSelected.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnClearSelected.HoverImage")));
            this.btnClearSelected.Location = new System.Drawing.Point(112, 2);
            this.btnClearSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClearSelected.Size = new System.Drawing.Size(171, 34);
            this.btnClearSelected.TabIndex = 138;
            this.btnClearSelected.Title = null;
            this.btnClearSelected.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnClearSelected_Click);
            // 
            // chbColumnsOfShow
            // 
            this.chbColumnsOfShow.BackColor = System.Drawing.Color.White;
            this.chbColumnsOfShow.CheckOnClick = true;
            this.chbColumnsOfShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbColumnsOfShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chbColumnsOfShow.FormattingEnabled = true;
            this.chbColumnsOfShow.Location = new System.Drawing.Point(0, 0);
            this.chbColumnsOfShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbColumnsOfShow.Name = "chbColumnsOfShow";
            this.chbColumnsOfShow.Size = new System.Drawing.Size(434, 140);
            this.chbColumnsOfShow.TabIndex = 134;
            // 
            // SelectColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.Controls.Add(this.ugbSC);
            this.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectColumn";
            this.Size = new System.Drawing.Size(440, 210);
            ((System.ComponentModel.ISupportInitialize)(this.ugbSC)).EndInit();
            this.ugbSC.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Utilize.Company.CGroupBox ugbSC;
        private System.Windows.Forms.CheckedListBox chbColumnsOfShow;
        private Company.CButton btnClearSelected;
        private Company.CButton btnSelectAll;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
