namespace Presentation.Tabs.BasicInfo
{
    partial class frmCollateralStatus
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCollateralStatus));
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.spcAll = new System.Windows.Forms.SplitContainer();
            this.cmbPages = new Utilize.Company.CComboCox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvCollateral_Status = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new Utilize.Company.CGroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorReturnItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSearchItem = new System.Windows.Forms.ToolStripButton();
            this.btnModel = new Utilize.Company.CButton();
            this.txtCollat_Stat_Desc = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCollat_Stat = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).BeginInit();
            this.spcAll.Panel1.SuspendLayout();
            this.spcAll.Panel2.SuspendLayout();
            this.spcAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollateral_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCollat_Stat_Desc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCollat_Stat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // spcAll
            // 
            this.spcAll.BackColor = System.Drawing.Color.Transparent;
            this.spcAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcAll.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcAll.IsSplitterFixed = true;
            this.spcAll.Location = new System.Drawing.Point(0, 0);
            this.spcAll.Name = "spcAll";
            this.spcAll.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcAll.Panel1
            // 
            this.spcAll.Panel1.Controls.Add(this.cmbPages);
            this.spcAll.Panel1.Controls.Add(this.label11);
            // 
            // spcAll.Panel2
            // 
            this.spcAll.Panel2.Controls.Add(this.dgvCollateral_Status);
            this.spcAll.Size = new System.Drawing.Size(819, 401);
            this.spcAll.SplitterDistance = 35;
            this.spcAll.TabIndex = 45;
            // 
            // cmbPages
            // 
            this.cmbPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            appearance2.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbPages.Appearance = appearance2;
            this.cmbPages.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbPages.AutoSize = false;
            this.cmbPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance3.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance3.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance3.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance3.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance3.ImageBackground")));
            appearance3.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbPages.ButtonAppearance = appearance3;
            this.cmbPages.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbPages.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbPages.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbPages.HideSelection = false;
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbPages.ItemAppearance = appearance4;
            this.cmbPages.Location = new System.Drawing.Point(616, 6);
            this.cmbPages.Margin = new System.Windows.Forms.Padding(3, 46, 3, 46);
            this.cmbPages.Name = "cmbPages";
            this.cmbPages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbPages.Size = new System.Drawing.Size(141, 23);
            this.cmbPages.TabIndex = 4;
            this.cmbPages.SelectionChanged += new System.EventHandler(this.cmbPages_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label11.Location = new System.Drawing.Point(763, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "صفحه  ";
            // 
            // dgvCollateral_Status
            // 
            this.dgvCollateral_Status.AllowUserToAddRows = false;
            this.dgvCollateral_Status.AllowUserToDeleteRows = false;
            this.dgvCollateral_Status.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCollateral_Status.BackgroundColor = System.Drawing.Color.White;
            this.dgvCollateral_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCollateral_Status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollateral_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCollateral_Status.Location = new System.Drawing.Point(0, 0);
            this.dgvCollateral_Status.Margin = new System.Windows.Forms.Padding(3, 46, 3, 46);
            this.dgvCollateral_Status.Name = "dgvCollateral_Status";
            this.dgvCollateral_Status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCollateral_Status.RowHeadersWidth = 60;
            this.dgvCollateral_Status.Size = new System.Drawing.Size(819, 362);
            this.dgvCollateral_Status.TabIndex = 11;
            this.dgvCollateral_Status.SelectionChanged += new System.EventHandler(this.dgvCollateral_Status_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox2.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox2.Controls.Add(this.bindingNavigator1);
            this.groupBox2.Controls.Add(this.btnModel);
            this.groupBox2.Controls.Add(this.txtCollat_Stat_Desc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCollat_Stat);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 401);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(819, 138);
            this.groupBox2.TabIndex = 1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bindingNavigator1.BackgroundImage")));
            this.bindingNavigator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorEditItem,
            this.bindingNavigatorReturnItem,
            this.bindingNavigatorSearchItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(6, 106);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bindingNavigator1.Size = new System.Drawing.Size(807, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "تعداد كل";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "وضعيت جاري";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorSaveItem.Text = "toolStripButton1";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "toolStripButton1";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEditItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEditItem.Image")));
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorEditItem.Text = "toolStripButton1";
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.bindingNavigatorEditItem_Click);
            // 
            // bindingNavigatorReturnItem
            // 
            this.bindingNavigatorReturnItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorReturnItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorReturnItem.Image")));
            this.bindingNavigatorReturnItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorReturnItem.Name = "bindingNavigatorReturnItem";
            this.bindingNavigatorReturnItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorReturnItem.Text = "toolStripButton1";
            this.bindingNavigatorReturnItem.Click += new System.EventHandler(this.bindingNavigatorReturnItem_Click);
            // 
            // bindingNavigatorSearchItem
            // 
            this.bindingNavigatorSearchItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSearchItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSearchItem.Image")));
            this.bindingNavigatorSearchItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSearchItem.Name = "bindingNavigatorSearchItem";
            this.bindingNavigatorSearchItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorSearchItem.Text = "toolStripButton2";
            this.bindingNavigatorSearchItem.Click += new System.EventHandler(this.bindingNavigatorSearchItem_Click);
            // 
            // btnModel
            // 
            this.btnModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnModel.DefaultImage")));
            this.btnModel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnModel.HoverImage")));
            this.btnModel.Location = new System.Drawing.Point(776, 65);
            this.btnModel.Name = "btnModel";
            this.btnModel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModel.Size = new System.Drawing.Size(34, 30);
            this.btnModel.TabIndex = 2;
            this.btnModel.Title = null;
            this.btnModel.Visible = false;
            this.btnModel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnModel_Click);
            // 
            // txtCollat_Stat_Desc
            // 
            this.txtCollat_Stat_Desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance5.BackColor = System.Drawing.Color.White;
            appearance5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(147)))));
            this.txtCollat_Stat_Desc.Appearance = appearance5;
            this.txtCollat_Stat_Desc.BackColor = System.Drawing.Color.White;
            this.txtCollat_Stat_Desc.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCollat_Stat_Desc.Location = new System.Drawing.Point(12, 21);
            this.txtCollat_Stat_Desc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCollat_Stat_Desc.Multiline = true;
            this.txtCollat_Stat_Desc.Name = "txtCollat_Stat_Desc";
            this.txtCollat_Stat_Desc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCollat_Stat_Desc.Size = new System.Drawing.Size(432, 67);
            this.txtCollat_Stat_Desc.TabIndex = 1;
            this.txtCollat_Stat_Desc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCollat_Stat_Desc_KeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label8.Location = new System.Drawing.Point(711, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "وضعيت وثيقه";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(450, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "شرح وضعيت وثيقه";
            // 
            // txtCollat_Stat
            // 
            this.txtCollat_Stat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.txtCollat_Stat.Appearance = appearance1;
            this.txtCollat_Stat.BackColor = System.Drawing.SystemColors.Window;
            this.txtCollat_Stat.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCollat_Stat.Location = new System.Drawing.Point(569, 20);
            this.txtCollat_Stat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCollat_Stat.Name = "txtCollat_Stat";
            this.txtCollat_Stat.ReadOnly = true;
            this.txtCollat_Stat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCollat_Stat.Size = new System.Drawing.Size(136, 30);
            this.txtCollat_Stat.TabIndex = 0;
            this.txtCollat_Stat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCollat_Stat_KeyDown);
            this.txtCollat_Stat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCollat_Stat_KeyPress);
            this.txtCollat_Stat.MouseLeave += new System.EventHandler(this.txtCollat_Stat_MouseLeave);
            // 
            // frmCollateralStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(819, 539);
            this.Controls.Add(this.spcAll);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCollateralStatus";
            this.Text = "وضعیت وثیقه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCollateralStatus_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCollateralStatus_KeyDown);
            this.spcAll.Panel1.ResumeLayout(false);
            this.spcAll.Panel1.PerformLayout();
            this.spcAll.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).EndInit();
            this.spcAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollateral_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCollat_Stat_Desc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCollat_Stat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcAll;
        private System.Windows.Forms.DataGridView dgvCollateral_Status;
        private Utilize.Company.CGroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCollat_Stat;
        private System.Windows.Forms.Label label11;
        private Utilize.Company.CComboCox cmbPages;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private Utilize.Company.CButton btnModel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorReturnItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearchItem;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCollat_Stat_Desc;
    }
}