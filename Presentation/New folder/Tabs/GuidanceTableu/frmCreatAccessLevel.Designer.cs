namespace Presentation.Tabs.GuidanceTableu
{
    partial class frmCreatAccessLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreatAccessLevel));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlspLbl = new System.Windows.Forms.ToolStripLabel();
            this.tsbModelNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new Utilize.Company.CGroupBox();
            this.lbxSection = new System.Windows.Forms.ListBox();
            this.groupBox2 = new Utilize.Company.CGroupBox();
            this.chbForms = new System.Windows.Forms.CheckedListBox();
            this.btnApply = new Utilize.Company.CButton();
            this.groupBox3 = new Utilize.Company.CGroupBox();
            this.lsv_AccModel = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlspLbl,
            this.tsbModelNew,
            this.tsbEdit,
            this.toolStripSeparator3,
            this.tsbRemove,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(862, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlspLbl
            // 
            this.tlspLbl.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlspLbl.Name = "tlspLbl";
            this.tlspLbl.Size = new System.Drawing.Size(83, 22);
            this.tlspLbl.Text = "سطوح دسترسي";
            this.tlspLbl.Visible = false;
            // 
            // tsbModelNew
            // 
            this.tsbModelNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbModelNew.Image")));
            this.tsbModelNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModelNew.Name = "tsbModelNew";
            this.tsbModelNew.Size = new System.Drawing.Size(23, 22);
            this.tsbModelNew.ToolTipText = " جدید";
            this.tsbModelNew.Click += new System.EventHandler(this.tsbModelNew_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbEdit.Text = "toolStripButton3";
            this.tsbEdit.ToolTipText = "ویرايش";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRemove
            // 
            this.tsbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemove.Image")));
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(23, 22);
            this.tsbRemove.Text = "toolStripButton4";
            this.tsbRemove.ToolTipText = "حذف ";
            this.tsbRemove.Click += new System.EventHandler(this.tsbRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "تازه سازي";
            this.tsbRefresh.ToolTipText = "تازه سازي";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox1.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox1.Controls.Add(this.lbxSection);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(294, 482);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.Text = "بخشهاي نرم افزار";
            // 
            // lbxSection
            // 
            this.lbxSection.BackColor = System.Drawing.Color.White;
            this.lbxSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.lbxSection.ItemHeight = 20;
            this.lbxSection.Location = new System.Drawing.Point(6, 28);
            this.lbxSection.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbxSection.Name = "lbxSection";
            this.lbxSection.Size = new System.Drawing.Size(282, 447);
            this.lbxSection.TabIndex = 139;
            this.lbxSection.SelectedIndexChanged += new System.EventHandler(this.lbxSection_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox2.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox2.Controls.Add(this.chbForms);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(275, 482);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.Text = "فرم های موجود در بخش نرم افزاری";
            // 
            // chbForms
            // 
            this.chbForms.BackColor = System.Drawing.Color.White;
            this.chbForms.CheckOnClick = true;
            this.chbForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbForms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.chbForms.FormattingEnabled = true;
            this.chbForms.Location = new System.Drawing.Point(6, 28);
            this.chbForms.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chbForms.Name = "chbForms";
            this.chbForms.Size = new System.Drawing.Size(263, 447);
            this.chbForms.TabIndex = 136;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnApply.DefaultImage")));
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnApply.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnApply.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnApply.HoverImage")));
            this.btnApply.Location = new System.Drawing.Point(0, 0);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApply.MaximumSize = new System.Drawing.Size(81, 35);
            this.btnApply.MinimumSize = new System.Drawing.Size(81, 35);
            this.btnApply.Name = "btnApply";
            this.btnApply.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApply.Size = new System.Drawing.Size(81, 35);
            this.btnApply.TabIndex = 40;
            this.btnApply.Title = "اعمال";
            this.btnApply.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnApply_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox3.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox3.Controls.Add(this.lsv_AccModel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(287, 482);
            this.groupBox3.TabIndex = 140;
            this.groupBox3.Text = "سطوح دسترسی";
            // 
            // lsv_AccModel
            // 
            this.lsv_AccModel.BackColor = System.Drawing.Color.White;
            this.lsv_AccModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_AccModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.lsv_AccModel.Location = new System.Drawing.Point(6, 28);
            this.lsv_AccModel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lsv_AccModel.MultiSelect = false;
            this.lsv_AccModel.Name = "lsv_AccModel";
            this.lsv_AccModel.RightToLeftLayout = true;
            this.lsv_AccModel.Size = new System.Drawing.Size(275, 447);
            this.lsv_AccModel.TabIndex = 138;
            this.lsv_AccModel.UseCompatibleStateImageBehavior = false;
            this.lsv_AccModel.SelectedIndexChanged += new System.EventHandler(this.lsv_AccModel_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel1MinSize = 220;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2MinSize = 220;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(572, 482);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 141;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Panel1MinSize = 220;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(862, 482);
            this.splitContainer2.SplitterDistance = 287;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 142;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 25);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnApply);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(862, 521);
            this.splitContainer3.SplitterDistance = 482;
            this.splitContainer3.TabIndex = 143;
            // 
            // frmCreatAccessLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(862, 546);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCreatAccessLevel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmCreatAccessLevel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCreatAccessLevel_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tlspLbl;
        private System.Windows.Forms.ToolStripButton tsbModelNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private Utilize.Company.CGroupBox groupBox1;
        private Utilize.Company.CGroupBox groupBox2;
        private Utilize.Company.CGroupBox groupBox3;
        private System.Windows.Forms.ListView lsv_AccModel;
        private System.Windows.Forms.CheckedListBox chbForms;
        private System.Windows.Forms.ListBox lbxSection;
        private Utilize.Company.CButton btnApply;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}