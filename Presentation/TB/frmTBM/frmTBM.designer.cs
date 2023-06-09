using System.Windows.Forms;

namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmTBM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTBM));
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.miMoveLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.imlTree = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmsZoom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi50 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi100 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi200 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi300 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi400 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi500 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLabelName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLabelType = new System.Windows.Forms.ToolStripMenuItem();
            this.spcAll = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tsModel = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbModelNew = new System.Windows.Forms.ToolStripButton();
            this.tsbModelNewCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbModelEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModelRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbAutomaticCreate = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvModel = new System.Windows.Forms.ListView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tsDiagram = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbShowBaloon = new System.Windows.Forms.ToolStripButton();
            this.tsbLabel = new System.Windows.Forms.ToolStripButton();
            this.cbMdl = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTimeBucket = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnModel = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.ctxMenu.SuspendLayout();
            this.cmsZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).BeginInit();
            this.spcAll.Panel1.SuspendLayout();
            this.spcAll.Panel2.SuspendLayout();
            this.spcAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tsModel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tsDiagram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // ctxMenu
            // 
            this.ctxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdd,
            this.miEdit,
            this.miRemove,
            this.convertToolStripMenuItem,
            this.miMoveUp,
            this.miMoveLeft,
            this.toolStripMenuItem1,
            this.miCollapseAll,
            this.miExpandAll});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(159, 184);
            // 
            // miAdd
            // 
            this.miAdd.Name = "miAdd";
            this.miAdd.Size = new System.Drawing.Size(158, 24);
            this.miAdd.Text = "جدید";
            // 
            // miEdit
            // 
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(158, 24);
            this.miEdit.Text = "ويرايش";
            // 
            // miRemove
            // 
            this.miRemove.Name = "miRemove";
            this.miRemove.Size = new System.Drawing.Size(158, 24);
            this.miRemove.Text = "حذف";
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(155, 6);
            // 
            // miMoveUp
            // 
            this.miMoveUp.Name = "miMoveUp";
            this.miMoveUp.Size = new System.Drawing.Size(158, 24);
            this.miMoveUp.Text = "حركت به بالا";
            // 
            // miMoveLeft
            // 
            this.miMoveLeft.Name = "miMoveLeft";
            this.miMoveLeft.Size = new System.Drawing.Size(158, 24);
            this.miMoveLeft.Text = "حركت به چپ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
            // 
            // miCollapseAll
            // 
            this.miCollapseAll.Name = "miCollapseAll";
            this.miCollapseAll.Size = new System.Drawing.Size(158, 24);
            this.miCollapseAll.Text = "بستن همه";
            // 
            // miExpandAll
            // 
            this.miExpandAll.Name = "miExpandAll";
            this.miExpandAll.Size = new System.Drawing.Size(158, 24);
            this.miExpandAll.Text = "بازكردن همه";
            // 
            // imlTree
            // 
            this.imlTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlTree.ImageSize = new System.Drawing.Size(16, 16);
            this.imlTree.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolTip
            // 
            this.toolTip.Active = false;
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // cmsZoom
            // 
            this.cmsZoom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsZoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi50,
            this.tsmi100,
            this.tsmi200,
            this.tsmi300,
            this.tsmi400,
            this.tsmi500,
            this.toolStripSeparator4,
            this.tsmiLabel});
            this.cmsZoom.Name = "cmsZoom";
            this.cmsZoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsZoom.Size = new System.Drawing.Size(126, 192);
            // 
            // tsmi50
            // 
            this.tsmi50.CheckOnClick = true;
            this.tsmi50.Name = "tsmi50";
            this.tsmi50.Size = new System.Drawing.Size(125, 26);
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
            this.tsmi100.Size = new System.Drawing.Size(125, 26);
            this.tsmi100.Tag = "100";
            this.tsmi100.Text = "100%";
            this.tsmi100.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // tsmi200
            // 
            this.tsmi200.CheckOnClick = true;
            this.tsmi200.Name = "tsmi200";
            this.tsmi200.Size = new System.Drawing.Size(125, 26);
            this.tsmi200.Tag = "200";
            this.tsmi200.Text = "200%";
            this.tsmi200.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // tsmi300
            // 
            this.tsmi300.CheckOnClick = true;
            this.tsmi300.Name = "tsmi300";
            this.tsmi300.Size = new System.Drawing.Size(125, 26);
            this.tsmi300.Tag = "300";
            this.tsmi300.Text = "300%";
            this.tsmi300.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // tsmi400
            // 
            this.tsmi400.CheckOnClick = true;
            this.tsmi400.Name = "tsmi400";
            this.tsmi400.Size = new System.Drawing.Size(125, 26);
            this.tsmi400.Tag = "400";
            this.tsmi400.Text = "400%";
            this.tsmi400.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // tsmi500
            // 
            this.tsmi500.CheckOnClick = true;
            this.tsmi500.Name = "tsmi500";
            this.tsmi500.Size = new System.Drawing.Size(125, 26);
            this.tsmi500.Tag = "500";
            this.tsmi500.Text = "500%";
            this.tsmi500.Click += new System.EventHandler(this.tsmiZoom_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(122, 6);
            // 
            // tsmiLabel
            // 
            this.tsmiLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLabelName,
            this.tsmiLabelType});
            this.tsmiLabel.Name = "tsmiLabel";
            this.tsmiLabel.Size = new System.Drawing.Size(125, 26);
            this.tsmiLabel.Text = "برچسب";
            this.tsmiLabel.Click += new System.EventHandler(this.tsmiLabel_Click);
            // 
            // tsmiLabelName
            // 
            this.tsmiLabelName.Checked = true;
            this.tsmiLabelName.CheckOnClick = true;
            this.tsmiLabelName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiLabelName.Name = "tsmiLabelName";
            this.tsmiLabelName.Size = new System.Drawing.Size(149, 26);
            this.tsmiLabelName.Text = "نام بسته";
            this.tsmiLabelName.Click += new System.EventHandler(this.tsmiLabel_Click);
            // 
            // tsmiLabelType
            // 
            this.tsmiLabelType.CheckOnClick = true;
            this.tsmiLabelType.Name = "tsmiLabelType";
            this.tsmiLabelType.Size = new System.Drawing.Size(149, 26);
            this.tsmiLabelType.Text = "نوع بسته";
            this.tsmiLabelType.Click += new System.EventHandler(this.tsmiLabel_Click);
            // 
            // spcAll
            // 
            this.spcAll.BackColor = System.Drawing.Color.Transparent;
            this.spcAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcAll.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcAll.Location = new System.Drawing.Point(0, 0);
            this.spcAll.Name = "spcAll";
            // 
            // spcAll.Panel1
            // 
            this.spcAll.Panel1.Controls.Add(this.splitContainer3);
            this.spcAll.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // spcAll.Panel2
            // 
            this.spcAll.Panel2.AutoScroll = true;
            this.spcAll.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.spcAll.Panel2.Controls.Add(this.splitContainer2);
            this.spcAll.Panel2.Controls.Add(this.btnModel);
            this.spcAll.Panel2.Controls.Add(this.dtpDate);
            this.spcAll.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spcAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spcAll.Size = new System.Drawing.Size(1367, 664);
            this.spcAll.SplitterDistance = 234;
            this.spcAll.TabIndex = 7;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tsModel);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panel3);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(234, 664);
            this.splitContainer3.SplitterDistance = 27;
            this.splitContainer3.TabIndex = 4;
            // 
            // tsModel
            // 
            this.tsModel.AutoSize = false;
            this.tsModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsModel.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsModel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsModel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsModel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbModelNew,
            this.tsbModelNewCopy,
            this.tsbModelEdit,
            this.toolStripSeparator3,
            this.tsbModelRemove,
            this.toolStripSeparator1,
            this.tsbSave,
            this.tsbRefresh,
            this.tsbAutomaticCreate});
            this.tsModel.Location = new System.Drawing.Point(0, 0);
            this.tsModel.Name = "tsModel";
            this.tsModel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsModel.Size = new System.Drawing.Size(234, 27);
            this.tsModel.TabIndex = 1;
            this.tsModel.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 24);
            this.toolStripLabel1.Text = "مدلها";
            // 
            // tsbModelNew
            // 
            this.tsbModelNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbModelNew.Name = "tsbModelNew";
            this.tsbModelNew.Size = new System.Drawing.Size(55, 24);
            this.tsbModelNew.Text = "new";
            this.tsbModelNew.ToolTipText = "مدل جدید";
            this.tsbModelNew.Click += new System.EventHandler(this.tsbModelNew_Click);
            // 
            // tsbModelNewCopy
            // 
            this.tsbModelNewCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbModelNewCopy.Name = "tsbModelNewCopy";
            this.tsbModelNewCopy.Size = new System.Drawing.Size(62, 24);
            this.tsbModelNewCopy.Tag = "copy";
            this.tsbModelNewCopy.Text = "copy";
            this.tsbModelNewCopy.ToolTipText = "كپی مدل";
            this.tsbModelNewCopy.Click += new System.EventHandler(this.tsbModelNewCopy_Click);
            // 
            // tsbModelEdit
            // 
            this.tsbModelEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbModelEdit.Name = "tsbModelEdit";
            this.tsbModelEdit.Size = new System.Drawing.Size(51, 24);
            this.tsbModelEdit.Text = "edit";
            this.tsbModelEdit.ToolTipText = "ویرایش مدل";
            this.tsbModelEdit.Click += new System.EventHandler(this.tsbModelEdit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbModelRemove
            // 
            this.tsbModelRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbModelRemove.Name = "tsbModelRemove";
            this.tsbModelRemove.Size = new System.Drawing.Size(87, 31);
            this.tsbModelRemove.Text = "remove";
            this.tsbModelRemove.ToolTipText = "حذف مدل";
            this.tsbModelRemove.Click += new System.EventHandler(this.tsbModelRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(66, 31);
            this.tsbSave.Text = "Save";
            this.tsbSave.ToolTipText = "ذخیره مدل";
            this.tsbSave.Click += new System.EventHandler(this.tsbModelSave_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(29, 4);
            this.tsbRefresh.Text = "toolStripButton1";
            this.tsbRefresh.ToolTipText = "تازه سازی";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbAutomaticCreate
            // 
            this.tsbAutomaticCreate.BackColor = System.Drawing.Color.Transparent;
            this.tsbAutomaticCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAutomaticCreate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAutomaticCreate.Name = "tsbAutomaticCreate";
            this.tsbAutomaticCreate.Size = new System.Drawing.Size(29, 4);
            this.tsbAutomaticCreate.Text = "ساخت خودکار بسته زمانی";
            this.tsbAutomaticCreate.ToolTipText = "ساخت خودکار بسته زمانی";
            this.tsbAutomaticCreate.Click += new System.EventHandler(this.tsbAutomaticCreate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvModel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 633);
            this.panel3.TabIndex = 3;
            // 
            // lsvModel
            // 
            this.lsvModel.BackColor = System.Drawing.SystemColors.Control;
            this.lsvModel.BackgroundImageTiled = true;
            this.lsvModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvModel.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lsvModel.HideSelection = false;
            this.lsvModel.Location = new System.Drawing.Point(0, 0);
            this.lsvModel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lsvModel.MultiSelect = false;
            this.lsvModel.Name = "lsvModel";
            this.lsvModel.Size = new System.Drawing.Size(234, 633);
            this.lsvModel.TabIndex = 2;
            this.lsvModel.UseCompatibleStateImageBehavior = false;
            this.lsvModel.SelectedIndexChanged += new System.EventHandler(this.lsvModel_SelectedIndexChanged);
            this.lsvModel.DoubleClick += new System.EventHandler(this.lsvModel_DoubleClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tsDiagram);
            this.splitContainer2.Panel1.Controls.Add(this.cbMdl);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(1129, 664);
            this.splitContainer2.SplitterDistance = 27;
            this.splitContainer2.TabIndex = 42;
            // 
            // tsDiagram
            // 
            this.tsDiagram.AutoSize = false;
            this.tsDiagram.BackColor = System.Drawing.Color.White;
            this.tsDiagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsDiagram.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsDiagram.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsDiagram.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsDiagram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tsbNew,
            this.tsbEdit,
            this.tsbRemove,
            this.toolStripSeparator2,
            this.tsbMoveUp,
            this.tsbMoveDown,
            this.toolStripButton11,
            this.tsbShowBaloon,
            this.tsbLabel});
            this.tsDiagram.Location = new System.Drawing.Point(0, 0);
            this.tsDiagram.Name = "tsDiagram";
            this.tsDiagram.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsDiagram.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsDiagram.Size = new System.Drawing.Size(1051, 27);
            this.tsDiagram.TabIndex = 3;
            this.tsDiagram.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 24);
            this.toolStripLabel2.Text = "نمودار";
            // 
            // tsbNew
            // 
            this.tsbNew.BackColor = System.Drawing.Color.Transparent;
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(47, 24);
            this.tsbNew.Text = "جدید";
            this.tsbNew.ToolTipText = "جدید";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(58, 24);
            this.tsbEdit.Text = "ویرایش";
            this.tsbEdit.ToolTipText = "ویرایش";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbRemove
            // 
            this.tsbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(47, 24);
            this.tsbRemove.Text = "حذف";
            this.tsbRemove.ToolTipText = "حذف";
            this.tsbRemove.Click += new System.EventHandler(this.tsbRemove_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbMoveUp
            // 
            this.tsbMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMoveUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMoveUp.Name = "tsbMoveUp";
            this.tsbMoveUp.Size = new System.Drawing.Size(89, 24);
            this.tsbMoveUp.Text = "حركت به بالا";
            this.tsbMoveUp.Click += new System.EventHandler(this.tsbMoveUp_Click);
            // 
            // tsbMoveDown
            // 
            this.tsbMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMoveDown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMoveDown.Name = "tsbMoveDown";
            this.tsbMoveDown.Size = new System.Drawing.Size(102, 24);
            this.tsbMoveDown.Text = "حركت به پایین";
            this.tsbMoveDown.Click += new System.EventHandler(this.tsbMoveDown_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(6, 27);
            this.toolStripButton11.Visible = false;
            // 
            // tsbShowBaloon
            // 
            this.tsbShowBaloon.CheckOnClick = true;
            this.tsbShowBaloon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbShowBaloon.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsbShowBaloon.ForeColor = System.Drawing.Color.Black;
            this.tsbShowBaloon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowBaloon.Name = "tsbShowBaloon";
            this.tsbShowBaloon.Size = new System.Drawing.Size(101, 24);
            this.tsbShowBaloon.Text = "نمایش جزئیات";
            this.tsbShowBaloon.Visible = false;
            this.tsbShowBaloon.Click += new System.EventHandler(this.tsbShowBaloon_Click);
            // 
            // tsbLabel
            // 
            this.tsbLabel.CheckOnClick = true;
            this.tsbLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLabel.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsbLabel.ForeColor = System.Drawing.Color.NavajoWhite;
            this.tsbLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLabel.Name = "tsbLabel";
            this.tsbLabel.Size = new System.Drawing.Size(90, 24);
            this.tsbLabel.Text = "گروه /قرارداد";
            this.tsbLabel.ToolTipText = "گروه /قرارداد";
            this.tsbLabel.Visible = false;
            // 
            // cbMdl
            // 
            this.cbMdl.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbMdl.Location = new System.Drawing.Point(1051, 0);
            this.cbMdl.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.cbMdl.Name = "cbMdl";
            this.cbMdl.Size = new System.Drawing.Size(78, 27);
            this.cbMdl.TabIndex = 63;
            this.cbMdl.Text = "model";
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
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1129, 633);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlTimeBucket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 97);
            this.panel1.TabIndex = 39;
            // 
            // pnlTimeBucket
            // 
            this.pnlTimeBucket.AutoScroll = true;
            this.pnlTimeBucket.BackColor = System.Drawing.Color.White;
            this.pnlTimeBucket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTimeBucket.ContextMenuStrip = this.cmsZoom;
            this.pnlTimeBucket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimeBucket.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnlTimeBucket.Location = new System.Drawing.Point(0, 0);
            this.pnlTimeBucket.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlTimeBucket.Name = "pnlTimeBucket";
            this.pnlTimeBucket.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTimeBucket.Size = new System.Drawing.Size(1129, 97);
            this.pnlTimeBucket.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 532);
            this.panel2.TabIndex = 40;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeight = 29;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvList.Name = "dgvList";
            this.dgvList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1129, 532);
            this.dgvList.TabIndex = 39;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(3, 3);
            this.btnModel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(2, 3);
            this.btnModel.TabIndex = 34;
            this.btnModel.Visible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(1128, 3);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(6, 32);
            this.dtpDate.TabIndex = 37;
            this.dtpDate.Value = new System.DateTime(2007, 7, 1, 0, 0, 0, 0);
            // 
            // frmTBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1367, 664);
            this.Controls.Add(this.spcAll);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTBM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدل بسته زمانی       ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTBM_FormClosing);
            this.Load += new System.EventHandler(this.frmTimeBucket_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTBM_KeyDown);
            this.ctxMenu.ResumeLayout(false);
            this.cmsZoom.ResumeLayout(false);
            this.spcAll.Panel1.ResumeLayout(false);
            this.spcAll.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).EndInit();
            this.spcAll.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tsModel.ResumeLayout(false);
            this.tsModel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tsDiagram.ResumeLayout(false);
            this.tsDiagram.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStripLabel toolStripLabel2;
        private ContextMenuStrip ctxMenu;
        private ToolStripMenuItem miAdd;
        private ToolStripMenuItem miEdit;
        private ToolStripMenuItem miRemove;
        private ToolStripSeparator convertToolStripMenuItem;
        private ToolStripMenuItem miMoveUp;
        private ToolStripMenuItem miMoveLeft;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem miCollapseAll;
        private ToolStripMenuItem miExpandAll;
        private ToolStripButton tsbNew;
        private ToolStrip tsDiagram;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbRemove;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbMoveUp;
        private ToolStripButton tsbMoveDown;
        private ToolStripSeparator toolStripButton11;
        private ToolStripButton tsbShowBaloon;
        private ToolStripButton tsbLabel;
        private ToolStripButton tsbModelRemove;
        private ToolStripButton tsbRefresh;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbSave;
        private SplitContainer spcAll;
        private ToolStrip tsModel;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton tsbModelNew;
        private ToolStripButton tsbModelNewCopy;
        private ToolStripButton tsbModelEdit;
        private ToolStripSeparator toolStripSeparator3;
        private ListView lsvModel;
        private Button btnModel;
        private ImageList imlTree;
        private ToolTip toolTip1;
        private ToolTip toolTip;
        private Panel pnlTimeBucket;
        private DateTimePicker dtpDate;
        private ContextMenuStrip cmsZoom;
        private ToolStripMenuItem tsmi50;
        private ToolStripMenuItem tsmi100;
        private ToolStripMenuItem tsmi200;
        private ToolStripMenuItem tsmi300;
        private ToolStripMenuItem tsmi400;
        private ToolStripMenuItem tsmi500;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem tsmiLabel;
        private ToolStripMenuItem tsmiLabelName;
        private ToolStripMenuItem tsmiLabelType;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dgvList;
        private Panel panel1;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer1;
        private Button cbMdl;
        private ToolStripButton tsbAutomaticCreate;

    }
}