namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmPDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDL));
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lsvModel = new System.Windows.Forms.ListView();
            this.tsModel = new System.Windows.Forms.ToolStrip();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModelSave = new System.Windows.Forms.ToolStripButton();
            this.tsbModelRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModelEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbModelNew = new System.Windows.Forms.ToolStripButton();
            this.tbOpenPD = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnImport = new Utilize.Company.CButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ctbId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctbPD_Model_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctbContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctbContract_PD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnModel = new Utilize.Company.CButton();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.cbCollapseLeft = new Utilize.Company.CButton();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.chbColumnsOfExcel = new System.Windows.Forms.CheckedListBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tsModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpenPD)).BeginInit();
            this.cmsZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
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
            this.lsvModel.Margin = new System.Windows.Forms.Padding(3, 2550, 3, 2550);
            this.lsvModel.MultiSelect = false;
            this.lsvModel.Name = "lsvModel";
            this.lsvModel.Size = new System.Drawing.Size(181, 487);
            this.lsvModel.TabIndex = 7;
            this.lsvModel.UseCompatibleStateImageBehavior = false;
            this.lsvModel.SelectedIndexChanged += new System.EventHandler(this.lsvModel_SelectedIndexChanged);
            this.lsvModel.DoubleClick += new System.EventHandler(this.lsvModel_DoubleClick);
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
            this.tsModel.Size = new System.Drawing.Size(181, 25);
            this.tsModel.TabIndex = 58;
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
            this.tsbModelNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsbModelNew.Size = new System.Drawing.Size(23, 22);
            this.tsbModelNew.ToolTipText = "مدل جدید";
            this.tsbModelNew.Click += new System.EventHandler(this.tsbModelNew_Click);
            // 
            // tbOpenPD
            // 
            this.tbOpenPD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance7.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance7.ImageBackground")));
            this.tbOpenPD.Appearance = appearance7;
            this.tbOpenPD.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbOpenPD.Location = new System.Drawing.Point(12, 3);
            this.tbOpenPD.Margin = new System.Windows.Forms.Padding(3, 133, 3, 133);
            this.tbOpenPD.Name = "tbOpenPD";
            this.tbOpenPD.Size = new System.Drawing.Size(422, 30);
            this.tbOpenPD.TabIndex = 60;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnImport.DefaultImage")));
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImport.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnImport.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnImport.HoverImage")));
            this.btnImport.Location = new System.Drawing.Point(440, 5);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2550, 3, 2550);
            this.btnImport.Name = "btnImport";
            this.btnImport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImport.Size = new System.Drawing.Size(143, 28);
            this.btnImport.TabIndex = 61;
            this.btnImport.Title = "ورود فایل احتمال نکول";
            this.btnImport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnImport_Click);
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
            this.cmsZoom.Size = new System.Drawing.Size(103, 164);
            // 
            // tsmi50
            // 
            this.tsmi50.CheckOnClick = true;
            this.tsmi50.Name = "tsmi50";
            this.tsmi50.Size = new System.Drawing.Size(102, 22);
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
            this.tsmi100.Size = new System.Drawing.Size(102, 22);
            this.tsmi100.Tag = "100";
            this.tsmi100.Text = "100%";
            this.tsmi100.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // tsmi200
            // 
            this.tsmi200.CheckOnClick = true;
            this.tsmi200.Name = "tsmi200";
            this.tsmi200.Size = new System.Drawing.Size(102, 22);
            this.tsmi200.Tag = "200";
            this.tsmi200.Text = "200%";
            this.tsmi200.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // tsmi300
            // 
            this.tsmi300.CheckOnClick = true;
            this.tsmi300.Name = "tsmi300";
            this.tsmi300.Size = new System.Drawing.Size(102, 22);
            this.tsmi300.Tag = "300";
            this.tsmi300.Text = "300%";
            this.tsmi300.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // tsmi400
            // 
            this.tsmi400.CheckOnClick = true;
            this.tsmi400.Name = "tsmi400";
            this.tsmi400.Size = new System.Drawing.Size(102, 22);
            this.tsmi400.Tag = "400";
            this.tsmi400.Text = "400%";
            this.tsmi400.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // tsmi500
            // 
            this.tsmi500.CheckOnClick = true;
            this.tsmi500.Name = "tsmi500";
            this.tsmi500.Size = new System.Drawing.Size(102, 22);
            this.tsmi500.Tag = "500";
            this.tsmi500.Text = "500%";
            this.tsmi500.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 6);
            // 
            // tsmiLabel
            // 
            this.tsmiLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLabelName,
            this.tsmiLabelType});
            this.tsmiLabel.Name = "tsmiLabel";
            this.tsmiLabel.Size = new System.Drawing.Size(102, 22);
            this.tsmiLabel.Text = "Label";
            this.tsmiLabel.Click += new System.EventHandler(this.tsmiLabel_Click);
            // 
            // tsmiLabelName
            // 
            this.tsmiLabelName.Checked = true;
            this.tsmiLabelName.CheckOnClick = true;
            this.tsmiLabelName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiLabelName.Name = "tsmiLabelName";
            this.tsmiLabelName.Size = new System.Drawing.Size(145, 22);
            this.tsmiLabelName.Text = "Bucket Name";
            // 
            // tsmiLabelType
            // 
            this.tsmiLabelType.CheckOnClick = true;
            this.tsmiLabelType.Name = "tsmiLabelType";
            this.tsmiLabelType.Size = new System.Drawing.Size(145, 22);
            this.tsmiLabelType.Text = "Bucket Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 845);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 133, 3, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(112, 2995);
            this.dataGridView1.TabIndex = 63;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeight = 27;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctbId,
            this.ctbPD_Model_Id,
            this.ctbContract,
            this.ctbContract_PD});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Margin = new System.Windows.Forms.Padding(3, 133, 3, 133);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(615, 452);
            this.dgvList.TabIndex = 64;
            this.dgvList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellValueChanged);
            // 
            // ctbId
            // 
            this.ctbId.DataPropertyName = "Id";
            this.ctbId.HeaderText = "Id";
            this.ctbId.Name = "ctbId";
            this.ctbId.ReadOnly = true;
            this.ctbId.Visible = false;
            // 
            // ctbPD_Model_Id
            // 
            this.ctbPD_Model_Id.HeaderText = "شماره مدل";
            this.ctbPD_Model_Id.Name = "ctbPD_Model_Id";
            this.ctbPD_Model_Id.ReadOnly = true;
            this.ctbPD_Model_Id.Visible = false;
            // 
            // ctbContract
            // 
            this.ctbContract.DataPropertyName = "Contract";
            this.ctbContract.HeaderText = "شماره قرارداد";
            this.ctbContract.Name = "ctbContract";
            this.ctbContract.ReadOnly = true;
            // 
            // ctbContract_PD
            // 
            this.ctbContract_PD.DataPropertyName = "Contract_PD";
            this.ctbContract_PD.HeaderText = "احتمال نکول";
            this.ctbContract_PD.Name = "ctbContract_PD";
            this.ctbContract_PD.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 133, 3, 133);
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
            this.splitContainer1.Size = new System.Drawing.Size(181, 513);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 65;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 133, 3, 133);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnModel);
            this.splitContainer2.Panel1.Controls.Add(this.btnImport);
            this.splitContainer2.Panel1.Controls.Add(this.tbOpenPD);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(615, 513);
            this.splitContainer2.SplitterDistance = 34;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 66;
            // 
            // btnModel
            // 
            this.btnModel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnModel.DefaultImage")));
            this.btnModel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnModel.HoverImage")));
            this.btnModel.Location = new System.Drawing.Point(589, 0);
            this.btnModel.Margin = new System.Windows.Forms.Padding(3, 174, 3, 174);
            this.btnModel.Name = "btnModel";
            this.btnModel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModel.Size = new System.Drawing.Size(26, 34);
            this.btnModel.TabIndex = 62;
            this.btnModel.Title = null;
            this.btnModel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnModel_Click_1);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer5);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer4.Panel2Collapsed = true;
            this.splitContainer4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer4.Size = new System.Drawing.Size(615, 478);
            this.splitContainer4.SplitterDistance = 440;
            this.splitContainer4.TabIndex = 67;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.cbCollapseLeft);
            this.splitContainer5.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.dgvList);
            this.splitContainer5.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer5.Size = new System.Drawing.Size(615, 478);
            this.splitContainer5.SplitterDistance = 25;
            this.splitContainer5.SplitterWidth = 1;
            this.splitContainer5.TabIndex = 66;
            // 
            // cbCollapseLeft
            // 
            this.cbCollapseLeft.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbCollapseLeft.DefaultImage")));
            this.cbCollapseLeft.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbCollapseLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbCollapseLeft.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbCollapseLeft.HoverImage")));
            this.cbCollapseLeft.Location = new System.Drawing.Point(589, 0);
            this.cbCollapseLeft.Margin = new System.Windows.Forms.Padding(3, 174, 3, 174);
            this.cbCollapseLeft.Name = "cbCollapseLeft";
            this.cbCollapseLeft.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCollapseLeft.Size = new System.Drawing.Size(26, 25);
            this.cbCollapseLeft.TabIndex = 65;
            this.cbCollapseLeft.Title = null;
            this.cbCollapseLeft.Visible = false;
            this.cbCollapseLeft.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbCollapseLeft_CButtonClicked);
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer6.Panel1.BackgroundImage")));
            this.splitContainer6.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer6.Panel1.Controls.Add(this.label1);
            this.splitContainer6.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.chbColumnsOfExcel);
            this.splitContainer6.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer6.Size = new System.Drawing.Size(96, 100);
            this.splitContainer6.SplitterDistance = 26;
            this.splitContainer6.SplitterWidth = 1;
            this.splitContainer6.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(-44, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 66;
            this.label1.Text = "انتخاب ستون جهت ایجاد سناریو";
            // 
            // chbColumnsOfExcel
            // 
            this.chbColumnsOfExcel.BackColor = System.Drawing.Color.White;
            this.chbColumnsOfExcel.CheckOnClick = true;
            this.chbColumnsOfExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbColumnsOfExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chbColumnsOfExcel.FormattingEnabled = true;
            this.chbColumnsOfExcel.Location = new System.Drawing.Point(0, 0);
            this.chbColumnsOfExcel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chbColumnsOfExcel.Name = "chbColumnsOfExcel";
            this.chbColumnsOfExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbColumnsOfExcel.Size = new System.Drawing.Size(96, 73);
            this.chbColumnsOfExcel.TabIndex = 135;
            this.chbColumnsOfExcel.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chbColumnsOfExcel_ItemCheck);
            this.chbColumnsOfExcel.SelectedIndexChanged += new System.EventHandler(this.chbColumnsOfExcel_SelectedIndexChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(800, 513);
            this.splitContainer3.SplitterDistance = 181;
            this.splitContainer3.TabIndex = 67;
            // 
            // frmPDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.splitContainer3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPDL";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmPD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPD_Load);
            this.tsModel.ResumeLayout(false);
            this.tsModel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpenPD)).EndInit();
            this.cmsZoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvModel;
        private System.Windows.Forms.ToolStrip tsModel;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbModelSave;
        private System.Windows.Forms.ToolStripButton tsbModelRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbModelEdit;
        private System.Windows.Forms.ToolStripButton tsbModelNew;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor tbOpenPD;
        private Utilize.Company.CButton btnImport;
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
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctbPD_Model_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctbContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctbContract_PD;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Utilize.Company.CButton btnModel;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private Utilize.Company.CButton cbCollapseLeft;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chbColumnsOfExcel;


    }
}