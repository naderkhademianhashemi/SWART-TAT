namespace Presentation.UI
{
    partial class frmEconomicSector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEconomicSector));
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.spcAll = new System.Windows.Forms.SplitContainer();
            this.cmbPages = new Utilize.Company.CComboCox();
            this.btnModel = new Utilize.Company.CButton();
            this.lblPages = new System.Windows.Forms.Label();
            this.groupBox2 = new Utilize.Company.CGroupBox();
            this.dgvEconomicSector = new System.Windows.Forms.DataGridView();
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
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.TXTEcoSec = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEcoSec = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).BeginInit();
            this.spcAll.Panel1.SuspendLayout();
            this.spcAll.Panel2.SuspendLayout();
            this.spcAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEconomicSector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXTEcoSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // spcAll
            // 
            this.spcAll.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.spcAll, "spcAll");
            this.spcAll.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcAll.Name = "spcAll";
            // 
            // spcAll.Panel1
            // 
            this.spcAll.Panel1.Controls.Add(this.cmbPages);
            this.spcAll.Panel1.Controls.Add(this.btnModel);
            this.spcAll.Panel1.Controls.Add(this.lblPages);
            resources.ApplyResources(this.spcAll.Panel1, "spcAll.Panel1");
            // 
            // spcAll.Panel2
            // 
            this.spcAll.Panel2.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.spcAll.Panel2, "spcAll.Panel2");
            // 
            // cmbPages
            // 
            resources.ApplyResources(this.cmbPages, "cmbPages");
            appearance10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance10.ImageBackground")));
            appearance10.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            resources.ApplyResources(appearance10.FontData, "appearance10.FontData");
            resources.ApplyResources(appearance10, "appearance10");
            appearance10.ForceApplyResources = "FontData|";
            this.cmbPages.Appearance = appearance10;
            this.cmbPages.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance11.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance11.ImageBackground")));
            appearance11.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            resources.ApplyResources(appearance11.FontData, "appearance11.FontData");
            resources.ApplyResources(appearance11, "appearance11");
            appearance11.ForceApplyResources = "FontData|";
            this.cmbPages.ButtonAppearance = appearance11;
            this.cmbPages.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbPages.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbPages.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbPages.HideSelection = false;
            appearance12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            resources.ApplyResources(appearance12.FontData, "appearance12.FontData");
            resources.ApplyResources(appearance12, "appearance12");
            appearance12.ForceApplyResources = "FontData|";
            this.cmbPages.ItemAppearance = appearance12;
            valueListItem3.DataValue = "ValueListItem0";
            resources.ApplyResources(valueListItem3, "valueListItem3");
            valueListItem3.ForceApplyResources = "";
            valueListItem4.DataValue = "ValueListItem1";
            resources.ApplyResources(valueListItem4, "valueListItem4");
            valueListItem4.ForceApplyResources = "";
            this.cmbPages.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem3,
            valueListItem4});
            this.cmbPages.Name = "cmbPages";
            this.cmbPages.SelectionChanged += new System.EventHandler(this.cmbPages_SelectedIndexChanged);
            // 
            // btnModel
            // 
            resources.ApplyResources(this.btnModel, "btnModel");
            this.btnModel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnModel.DefaultImage")));
            this.btnModel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnModel.HoverImage")));
            this.btnModel.Name = "btnModel";
            this.btnModel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModel.Title = null;
            this.btnModel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnModel_Click);
            // 
            // lblPages
            // 
            resources.ApplyResources(this.lblPages, "lblPages");
            this.lblPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblPages.Name = "lblPages";
            // 
            // groupBox2
            // 
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox2.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox2.Controls.Add(this.dgvEconomicSector);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            // 
            // dgvEconomicSector
            // 
            this.dgvEconomicSector.BackgroundColor = System.Drawing.Color.White;
            this.dgvEconomicSector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEconomicSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvEconomicSector, "dgvEconomicSector");
            this.dgvEconomicSector.Name = "dgvEconomicSector";
            this.dgvEconomicSector.ShowRowErrors = false;
            this.dgvEconomicSector.SelectionChanged += new System.EventHandler(this.dgvEconomicSector_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox1.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(this.rtxt);
            this.groupBox1.Controls.Add(this.TXTEcoSec);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblEcoSec);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            resources.ApplyResources(this.bindingNavigator1, "bindingNavigator1");
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
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
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.Color.White;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // tlsBtnSave
            // 
            this.tlsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tlsBtnSave, "tlsBtnSave");
            this.tlsBtnSave.Name = "tlsBtnSave";
            this.tlsBtnSave.Click += new System.EventHandler(this.tlsBtnSave_Click);
            // 
            // tlsBtnRemove
            // 
            this.tlsBtnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tlsBtnRemove, "tlsBtnRemove");
            this.tlsBtnRemove.Name = "tlsBtnRemove";
            this.tlsBtnRemove.Click += new System.EventHandler(this.tlsBtnRemove_Click);
            // 
            // tlsBtnEdit
            // 
            this.tlsBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tlsBtnEdit, "tlsBtnEdit");
            this.tlsBtnEdit.Name = "tlsBtnEdit";
            this.tlsBtnEdit.Click += new System.EventHandler(this.tlsBtnEdit_Click);
            // 
            // tlsBtnRefresh
            // 
            this.tlsBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tlsBtnRefresh, "tlsBtnRefresh");
            this.tlsBtnRefresh.Name = "tlsBtnRefresh";
            this.tlsBtnRefresh.Click += new System.EventHandler(this.tlsBtnRefresh_Click);
            // 
            // tlsBtnSearch
            // 
            this.tlsBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tlsBtnSearch, "tlsBtnSearch");
            this.tlsBtnSearch.Name = "tlsBtnSearch";
            this.tlsBtnSearch.Click += new System.EventHandler(this.tlsBtnSearch_Click);
            // 
            // rtxt
            // 
            resources.ApplyResources(this.rtxt, "rtxt");
            this.rtxt.Name = "rtxt";
            this.rtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxt_KeyDown);
            this.rtxt.MouseLeave += new System.EventHandler(this.rtxt_MouseLeave);
            // 
            // TXTEcoSec
            // 
            resources.ApplyResources(this.TXTEcoSec, "TXTEcoSec");
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            resources.ApplyResources(appearance1.FontData, "appearance1.FontData");
            resources.ApplyResources(appearance1, "appearance1");
            appearance1.ForceApplyResources = "FontData|";
            this.TXTEcoSec.Appearance = appearance1;
            this.TXTEcoSec.Name = "TXTEcoSec";
            this.TXTEcoSec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTEcoSec_KeyDown);
            this.TXTEcoSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTEcoSec_KeyPress);
            this.TXTEcoSec.MouseLeave += new System.EventHandler(this.TXTEcoSec_MouseLeave);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Name = "label2";
            // 
            // lblEcoSec
            // 
            resources.ApplyResources(this.lblEcoSec, "lblEcoSec");
            this.lblEcoSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblEcoSec.Name = "lblEcoSec";
            // 
            // frmEconomicSector
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.spcAll);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEconomicSector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEconomicSector_Load);
            this.spcAll.Panel1.ResumeLayout(false);
            this.spcAll.Panel1.PerformLayout();
            this.spcAll.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).EndInit();
            this.spcAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEconomicSector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXTEcoSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcAll;
        private System.Windows.Forms.DataGridView dgvEconomicSector;
        private System.Windows.Forms.Label lblPages;
        private Utilize.Company.CGroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEcoSec;
        private System.Windows.Forms.RichTextBox rtxt;
        private Utilize.Company.CButton btnModel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Utilize.Company.CGroupBox groupBox2;
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
        private Infragistics.Win.UltraWinEditors.UltraTextEditor TXTEcoSec;
    }
}