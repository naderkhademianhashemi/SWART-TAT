namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmMBM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMBM));
            this.lsvModel = new System.Windows.Forms.ListView();
            this.pnlTimeBucket = new System.Windows.Forms.Panel();
            this.cmsZoom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi50 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi100 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi200 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi300 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi400 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi500 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLabelName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLabelType = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvListTB = new System.Windows.Forms.DataGridView();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsModel = new System.Windows.Forms.ToolStrip();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModelSave = new System.Windows.Forms.ToolStripButton();
            this.tsbModelRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModelEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbModelNew = new System.Windows.Forms.ToolStripButton();
            this.btnModel = new Utilize.Company.CButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.cmsZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tsModel.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvModel
            // 
            this.lsvModel.BackColor = System.Drawing.Color.Ivory;
            this.lsvModel.BackgroundImage = global::Presentation.Properties.Resources.S_BGComponents_Ver;
            this.lsvModel.BackgroundImageTiled = true;
            this.lsvModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvModel.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lsvModel.Location = new System.Drawing.Point(0, 0);
            this.lsvModel.Margin = new System.Windows.Forms.Padding(3, 133, 3, 133);
            this.lsvModel.MultiSelect = false;
            this.lsvModel.Name = "lsvModel";
            this.lsvModel.Size = new System.Drawing.Size(202, 479);
            this.lsvModel.TabIndex = 6;
            this.lsvModel.UseCompatibleStateImageBehavior = false;
            this.lsvModel.SelectedIndexChanged += new System.EventHandler(this.lsvModel_SelectedIndexChanged);
            this.lsvModel.DoubleClick += new System.EventHandler(this.lsvModel_DoubleClick);
            // 
            // pnlTimeBucket
            // 
            this.pnlTimeBucket.BackColor = System.Drawing.Color.White;
            this.pnlTimeBucket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTimeBucket.ContextMenuStrip = this.cmsZoom;
            this.pnlTimeBucket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimeBucket.Location = new System.Drawing.Point(0, 0);
            this.pnlTimeBucket.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.pnlTimeBucket.Name = "pnlTimeBucket";
            this.pnlTimeBucket.Size = new System.Drawing.Size(594, 112);
            this.pnlTimeBucket.TabIndex = 8;
            // 
            // cmsZoom
            // 
            this.cmsZoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi50,
            this.tsmi100,
            this.tsmi200,
            this.tsmi300,
            this.tsmi400,
            this.tsmi500,
            this.toolStripMenuItem1,
            this.tsmiLabel});
            this.cmsZoom.Name = "cmsZoom";
            this.cmsZoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsZoom.Size = new System.Drawing.Size(109, 164);
            // 
            // tsmi50
            // 
            this.tsmi50.CheckOnClick = true;
            this.tsmi50.Name = "tsmi50";
            this.tsmi50.Size = new System.Drawing.Size(108, 22);
            this.tsmi50.Tag = "50";
            this.tsmi50.Text = "50%";
            this.tsmi50.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // tsmi100
            // 
            this.tsmi100.Checked = true;
            this.tsmi100.CheckOnClick = true;
            this.tsmi100.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi100.Name = "tsmi100";
            this.tsmi100.Size = new System.Drawing.Size(108, 22);
            this.tsmi100.Tag = "100";
            this.tsmi100.Text = "100%";
            this.tsmi100.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // tsmi200
            // 
            this.tsmi200.CheckOnClick = true;
            this.tsmi200.Name = "tsmi200";
            this.tsmi200.Size = new System.Drawing.Size(108, 22);
            this.tsmi200.Tag = "200";
            this.tsmi200.Text = "200%";
            this.tsmi200.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // tsmi300
            // 
            this.tsmi300.CheckOnClick = true;
            this.tsmi300.Name = "tsmi300";
            this.tsmi300.Size = new System.Drawing.Size(108, 22);
            this.tsmi300.Tag = "300";
            this.tsmi300.Text = "300%";
            this.tsmi300.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // tsmi400
            // 
            this.tsmi400.CheckOnClick = true;
            this.tsmi400.Name = "tsmi400";
            this.tsmi400.Size = new System.Drawing.Size(108, 22);
            this.tsmi400.Tag = "400";
            this.tsmi400.Text = "400%";
            this.tsmi400.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // tsmi500
            // 
            this.tsmi500.CheckOnClick = true;
            this.tsmi500.Name = "tsmi500";
            this.tsmi500.Size = new System.Drawing.Size(108, 22);
            this.tsmi500.Tag = "500";
            this.tsmi500.Text = "500%";
            this.tsmi500.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(105, 6);
            // 
            // tsmiLabel
            // 
            this.tsmiLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLabelName,
            this.tsmiLabelType});
            this.tsmiLabel.Name = "tsmiLabel";
            this.tsmiLabel.Size = new System.Drawing.Size(108, 22);
            this.tsmiLabel.Text = "برچسب";
            this.tsmiLabel.Click += new System.EventHandler(this.tsmiLabel_Click);
            // 
            // tsmiLabelName
            // 
            this.tsmiLabelName.Checked = true;
            this.tsmiLabelName.CheckOnClick = true;
            this.tsmiLabelName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiLabelName.Name = "tsmiLabelName";
            this.tsmiLabelName.Size = new System.Drawing.Size(116, 22);
            this.tsmiLabelName.Text = "نام بسته";
            this.tsmiLabelName.Click += new System.EventHandler(this.tsmiLabel_Click);
            // 
            // tsmiLabelType
            // 
            this.tsmiLabelType.CheckOnClick = true;
            this.tsmiLabelType.Name = "tsmiLabelType";
            this.tsmiLabelType.Size = new System.Drawing.Size(116, 22);
            this.tsmiLabelType.Text = "نوع بسته";
            this.tsmiLabelType.Click += new System.EventHandler(this.tsmiLabel_Click);
            // 
            // dgvListTB
            // 
            this.dgvListTB.AllowUserToResizeRows = false;
            this.dgvListTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListTB.Location = new System.Drawing.Point(70, 12);
            this.dgvListTB.Margin = new System.Windows.Forms.Padding(3, 133, 3, 133);
            this.dgvListTB.MultiSelect = false;
            this.dgvListTB.Name = "dgvListTB";
            this.dgvListTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvListTB.RowHeadersWidth = 20;
            this.dgvListTB.RowTemplate.Height = 24;
            this.dgvListTB.Size = new System.Drawing.Size(98, 4);
            this.dgvListTB.TabIndex = 53;
            this.dgvListTB.Visible = false;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Margin = new System.Windows.Forms.Padding(3, 133, 3, 133);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(594, 351);
            this.dgvList.TabIndex = 54;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(29, 44);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.Visible = false;
            // 
            // tsModel
            // 
            this.tsModel.BackgroundImage = global::Presentation.Properties.Resources.S_Head;
            this.tsModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsModel.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsModel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsModel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRefresh,
            this.toolStripSeparator2,
            this.tsbModelSave,
            this.tsbModelRemove,
            this.toolStripSeparator1,
            this.tsbModelEdit,
            this.tsbModelNew});
            this.tsModel.Location = new System.Drawing.Point(0, 0);
            this.tsModel.Name = "tsModel";
            this.tsModel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsModel.Size = new System.Drawing.Size(202, 25);
            this.tsModel.TabIndex = 57;
            this.tsModel.Text = "toolStrip1";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "toolStripButton1";
            this.tsbRefresh.ToolTipText = "تازه سازی";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbModelSave
            // 
            this.tsbModelSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbModelSave.Image")));
            this.tsbModelSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModelSave.Name = "tsbModelSave";
            this.tsbModelSave.Size = new System.Drawing.Size(23, 22);
            this.tsbModelSave.Text = "Save";
            this.tsbModelSave.ToolTipText = "ذخیره مدل";
            this.tsbModelSave.Click += new System.EventHandler(this.tsbModelSave_Click);
            // 
            // tsbModelRemove
            // 
            this.tsbModelRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsbModelRemove.Image")));
            this.tsbModelRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModelRemove.Name = "tsbModelRemove";
            this.tsbModelRemove.Size = new System.Drawing.Size(23, 22);
            this.tsbModelRemove.Text = "toolStripButton4";
            this.tsbModelRemove.ToolTipText = "حذف مدل";
            this.tsbModelRemove.Click += new System.EventHandler(this.tsbModelRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbModelEdit
            // 
            this.tsbModelEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbModelEdit.Image")));
            this.tsbModelEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModelEdit.Name = "tsbModelEdit";
            this.tsbModelEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbModelEdit.Text = "toolStripButton3";
            this.tsbModelEdit.ToolTipText = "ویرایش مدل";
            this.tsbModelEdit.Click += new System.EventHandler(this.tsbModelEdit_Click);
            // 
            // tsbModelNew
            // 
            this.tsbModelNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbModelNew.Image")));
            this.tsbModelNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModelNew.Name = "tsbModelNew";
            this.tsbModelNew.Size = new System.Drawing.Size(23, 22);
            this.tsbModelNew.ToolTipText = "مدل جدید";
            this.tsbModelNew.Click += new System.EventHandler(this.tsbModelNew_Click);
            // 
            // btnModel
            // 
            this.btnModel.BackColor = System.Drawing.Color.Transparent;
            this.btnModel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnModel.DefaultImage")));
            this.btnModel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnModel.HoverImage")));
            this.btnModel.Location = new System.Drawing.Point(563, 0);
            this.btnModel.Margin = new System.Windows.Forms.Padding(3, 133, 3, 133);
            this.btnModel.Name = "btnModel";
            this.btnModel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModel.Size = new System.Drawing.Size(31, 32);
            this.btnModel.TabIndex = 58;
            this.btnModel.Title = "";
            this.btnModel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnModel_CButtonClicked);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tsModel);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lsvModel);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(202, 513);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 9;
            this.splitContainer1.TabIndex = 59;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnModel);
            this.splitContainer2.Panel1.Controls.Add(this.dgvListTB);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pnlTimeBucket);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(594, 153);
            this.splitContainer2.SplitterDistance = 32;
            this.splitContainer2.SplitterWidth = 9;
            this.splitContainer2.TabIndex = 60;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
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
            this.splitContainer3.Panel2.Controls.Add(this.dgvList);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(594, 513);
            this.splitContainer3.SplitterDistance = 153;
            this.splitContainer3.SplitterWidth = 9;
            this.splitContainer3.TabIndex = 61;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Size = new System.Drawing.Size(800, 513);
            this.splitContainer4.SplitterDistance = 202;
            this.splitContainer4.TabIndex = 62;
            // 
            // frmMBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.splitContainer4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMBM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدل رفتاری بازار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMBM_Load);
            this.cmsZoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tsModel.ResumeLayout(false);
            this.tsModel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
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
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvModel;
        private System.Windows.Forms.Panel pnlTimeBucket;
        private System.Windows.Forms.DataGridView dgvListTB;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip cmsZoom;
        private System.Windows.Forms.ToolStripMenuItem tsmi50;
        private System.Windows.Forms.ToolStripMenuItem tsmi100;
        private System.Windows.Forms.ToolStripMenuItem tsmi200;
        private System.Windows.Forms.ToolStripMenuItem tsmi300;
        private System.Windows.Forms.ToolStripMenuItem tsmi400;
        private System.Windows.Forms.ToolStripMenuItem tsmi500;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLabel;
        private System.Windows.Forms.ToolStripMenuItem tsmiLabelName;
        private System.Windows.Forms.ToolStripMenuItem tsmiLabelType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip tsModel;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbModelSave;
        private System.Windows.Forms.ToolStripButton tsbModelRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbModelEdit;
        private System.Windows.Forms.ToolStripButton tsbModelNew;
        private Utilize.Company.CButton btnModel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;



    }
}