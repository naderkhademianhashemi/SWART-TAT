namespace Presentation.UI
{
    partial class frmState
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
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmState));
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.spcAll = new System.Windows.Forms.SplitContainer();
            this.cmbPages = new Utilize.Company.CComboCox();
            this.btnModel = new Utilize.Company.CButton();
            this.lblPages = new System.Windows.Forms.Label();
            this.groupBox2 = new Utilize.Company.CGroupBox();
            this.dgvState = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new Utilize.Company.CGroupBox();
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
            this.tlsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnRemove = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.txtStateName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblStateName = new System.Windows.Forms.Label();
            this.txtStateID = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblStateId = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).BeginInit();
            this.spcAll.Panel1.SuspendLayout();
            this.spcAll.Panel2.SuspendLayout();
            this.spcAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStateName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStateID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // spcAll
            // 
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
            this.spcAll.Panel1.Controls.Add(this.btnModel);
            this.spcAll.Panel1.Controls.Add(this.lblPages);
            this.spcAll.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // spcAll.Panel2
            // 
            this.spcAll.Panel2.Controls.Add(this.groupBox2);
            this.spcAll.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spcAll.Size = new System.Drawing.Size(784, 450);
            this.spcAll.SplitterDistance = 38;
            this.spcAll.TabIndex = 85;
            // 
            // cmbPages
            // 
            this.cmbPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance10.ImageBackground")));
            appearance10.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbPages.Appearance = appearance10;
            this.cmbPages.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbPages.AutoSize = false;
            this.cmbPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance11.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance11.ImageBackground")));
            appearance11.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbPages.ButtonAppearance = appearance11;
            this.cmbPages.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbPages.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbPages.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbPages.HideSelection = false;
            appearance12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbPages.ItemAppearance = appearance12;
            valueListItem3.DataValue = "ValueListItem0";
            valueListItem3.DisplayText = "داخلی";
            valueListItem4.DataValue = "ValueListItem1";
            valueListItem4.DisplayText = "بانک مرکزی";
            this.cmbPages.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem3,
            valueListItem4});
            this.cmbPages.Location = new System.Drawing.Point(605, 7);
            this.cmbPages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPages.Name = "cmbPages";
            this.cmbPages.Size = new System.Drawing.Size(116, 23);
            this.cmbPages.TabIndex = 50;
            this.cmbPages.SelectionChanged += new System.EventHandler(this.cmbPages_SelectedIndexChanged);
            // 
            // btnModel
            // 
            this.btnModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnModel.DefaultImage")));
            this.btnModel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnModel.HoverImage")));
            this.btnModel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModel.Location = new System.Drawing.Point(565, 2);
            this.btnModel.Name = "btnModel";
            this.btnModel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModel.Size = new System.Drawing.Size(31, 29);
            this.btnModel.TabIndex = 7;
            this.btnModel.Title = null;
            this.btnModel.Visible = false;
            this.btnModel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnModel_Click_1);
            // 
            // lblPages
            // 
            this.lblPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblPages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPages.Location = new System.Drawing.Point(727, 10);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(42, 20);
            this.lblPages.TabIndex = 37;
            this.lblPages.Text = "صفحه  ";
            // 
            // groupBox2
            // 
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox2.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox2.Controls.Add(this.dgvState);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 408);
            this.groupBox2.TabIndex = 38;
            // 
            // dgvState
            // 
            this.dgvState.BackgroundColor = System.Drawing.Color.White;
            this.dgvState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvState.Location = new System.Drawing.Point(3, 8);
            this.dgvState.Name = "dgvState";
            this.dgvState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvState.Size = new System.Drawing.Size(778, 397);
            this.dgvState.TabIndex = 2;
            this.dgvState.SelectionChanged += new System.EventHandler(this.dgvState_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox1.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(this.txtStateName);
            this.groupBox1.Controls.Add(this.lblStateName);
            this.groupBox1.Controls.Add(this.txtStateID);
            this.groupBox1.Controls.Add(this.lblStateId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(0, 450);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(784, 112);
            this.groupBox1.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            this.bindingNavigator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bindingNavigator1.BackgroundImage")));
            this.bindingNavigator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Font = new System.Drawing.Font("B Nazanin", 9.75F);
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
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
            this.tlsBtnSave,
            this.tlsBtnRemove,
            this.tlsBtnEdit,
            this.tlsBtnRefresh,
            this.tlsBtnSearch});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 84);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(778, 25);
            this.bindingNavigator1.TabIndex = 86;
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
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.Color.White;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(41, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(7, 23);
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
            // tlsBtnSave
            // 
            this.tlsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnSave.Image")));
            this.tlsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnSave.Name = "tlsBtnSave";
            this.tlsBtnSave.Size = new System.Drawing.Size(23, 22);
            this.tlsBtnSave.Text = "toolStripButton1";
            this.tlsBtnSave.Click += new System.EventHandler(this.tlsBtnSave_Click_1);
            // 
            // tlsBtnRemove
            // 
            this.tlsBtnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnRemove.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnRemove.Image")));
            this.tlsBtnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnRemove.Name = "tlsBtnRemove";
            this.tlsBtnRemove.Size = new System.Drawing.Size(23, 22);
            this.tlsBtnRemove.Text = "toolStripButton1";
            this.tlsBtnRemove.Click += new System.EventHandler(this.tlsBtnRemove_Click_1);
            // 
            // tlsBtnEdit
            // 
            this.tlsBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnEdit.Image")));
            this.tlsBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnEdit.Name = "tlsBtnEdit";
            this.tlsBtnEdit.Size = new System.Drawing.Size(23, 22);
            this.tlsBtnEdit.Text = "toolStripButton1";
            this.tlsBtnEdit.Click += new System.EventHandler(this.tlsBtnEdit_Click_1);
            // 
            // tlsBtnRefresh
            // 
            this.tlsBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnRefresh.Image")));
            this.tlsBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnRefresh.Name = "tlsBtnRefresh";
            this.tlsBtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.tlsBtnRefresh.Text = "toolStripButton1";
            this.tlsBtnRefresh.Click += new System.EventHandler(this.tlsBtnRefresh_Click);
            // 
            // tlsBtnSearch
            // 
            this.tlsBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnSearch.Image")));
            this.tlsBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnSearch.Name = "tlsBtnSearch";
            this.tlsBtnSearch.Size = new System.Drawing.Size(23, 22);
            this.tlsBtnSearch.Text = "toolStripButton1";
            this.tlsBtnSearch.Click += new System.EventHandler(this.tlsBtnSearch_Click);
            // 
            // txtStateName
            // 
            this.txtStateName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            this.txtStateName.Appearance = appearance2;
            this.txtStateName.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtStateName.Location = new System.Drawing.Point(530, 50);
            this.txtStateName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.Size = new System.Drawing.Size(165, 30);
            this.txtStateName.TabIndex = 9;
            // 
            // lblStateName
            // 
            this.lblStateName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStateName.AutoSize = true;
            this.lblStateName.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStateName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblStateName.Location = new System.Drawing.Point(701, 54);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(52, 20);
            this.lblStateName.TabIndex = 8;
            this.lblStateName.Text = "نام استان";
            // 
            // txtStateID
            // 
            this.txtStateID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.txtStateID.Appearance = appearance1;
            this.txtStateID.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtStateID.Location = new System.Drawing.Point(530, 17);
            this.txtStateID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStateID.Name = "txtStateID";
            this.txtStateID.Size = new System.Drawing.Size(165, 30);
            this.txtStateID.TabIndex = 3;
            this.txtStateID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStateID_KeyDown);
            this.txtStateID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStateID_KeyPress);
            this.txtStateID.MouseLeave += new System.EventHandler(this.txtStateID_MouseLeave);
            // 
            // lblStateId
            // 
            this.lblStateId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStateId.AutoSize = true;
            this.lblStateId.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStateId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblStateId.Location = new System.Drawing.Point(701, 21);
            this.lblStateId.Name = "lblStateId";
            this.lblStateId.Size = new System.Drawing.Size(52, 20);
            this.lblStateId.TabIndex = 4;
            this.lblStateId.Text = "كد استان";
            // 
            // frmState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.spcAll);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmState";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "frmState";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmState_Load);
            this.spcAll.Panel1.ResumeLayout(false);
            this.spcAll.Panel1.PerformLayout();
            this.spcAll.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).EndInit();
            this.spcAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStateName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStateID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcAll;
        private System.Windows.Forms.Label lblPages;
        private Utilize.Company.CGroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvState;
        private Utilize.Company.CGroupBox groupBox1;
        private Utilize.Company.CButton btnModel;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtStateID;
        private System.Windows.Forms.Label lblStateId;
        private System.Windows.Forms.Label lblStateName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtStateName;
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
        private System.Windows.Forms.ToolStripButton tlsBtnSave;
        private System.Windows.Forms.ToolStripButton tlsBtnRemove;
        private System.Windows.Forms.ToolStripButton tlsBtnEdit;
        private System.Windows.Forms.ToolStripButton tlsBtnRefresh;
        private System.Windows.Forms.ToolStripButton tlsBtnSearch;
    }
}