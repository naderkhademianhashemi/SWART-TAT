namespace Presentation.Tabs.GuidanceTableu
{
    partial class frmLimitManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLimitManagement));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.spcAll = new System.Windows.Forms.SplitContainer();
            this.lsvModel = new System.Windows.Forms.ListView();
            this.tsModel = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbModelNew = new System.Windows.Forms.ToolStripButton();
            this.tsbModelEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModelRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.ut = new Infragistics.Win.UltraWinTree.UltraTree();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDiagram = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).BeginInit();
            this.spcAll.Panel1.SuspendLayout();
            this.spcAll.Panel2.SuspendLayout();
            this.spcAll.SuspendLayout();
            this.tsModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ut)).BeginInit();
            this.ctxMenu.SuspendLayout();
            this.tsDiagram.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcAll
            // 
            this.spcAll.BackColor = System.Drawing.Color.Transparent;
            this.spcAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcAll.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcAll.Location = new System.Drawing.Point(0, 0);
            this.spcAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spcAll.Name = "spcAll";
            // 
            // spcAll.Panel1
            // 
            this.spcAll.Panel1.Controls.Add(this.lsvModel);
            this.spcAll.Panel1.Controls.Add(this.tsModel);
            this.spcAll.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // spcAll.Panel2
            // 
            this.spcAll.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.spcAll.Panel2.Controls.Add(this.ut);
            this.spcAll.Panel2.Controls.Add(this.tsDiagram);
            this.spcAll.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spcAll.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.spcAll_Panel2_Paint);
            this.spcAll.Size = new System.Drawing.Size(840, 695);
            this.spcAll.SplitterDistance = 245;
            this.spcAll.SplitterWidth = 6;
            this.spcAll.TabIndex = 0;
            // 
            // lsvModel
            // 
            this.lsvModel.BackColor = System.Drawing.Color.White;
            this.lsvModel.BackgroundImageTiled = true;
            this.lsvModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvModel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lsvModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.lsvModel.Location = new System.Drawing.Point(0, 25);
            this.lsvModel.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.lsvModel.MultiSelect = false;
            this.lsvModel.Name = "lsvModel";
            this.lsvModel.Size = new System.Drawing.Size(245, 670);
            this.lsvModel.TabIndex = 6;
            this.lsvModel.UseCompatibleStateImageBehavior = false;
            this.lsvModel.SelectedIndexChanged += new System.EventHandler(this.lsvModel_SelectedIndexChanged);
            // 
            // tsModel
            // 
            this.tsModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            this.tsModel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsModel.BackgroundImage")));
            this.tsModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsModel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsModel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsModel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbModelNew,
            this.tsbModelEdit,
            this.toolStripSeparator3,
            this.tsbModelRemove,
            this.toolStripSeparator2,
            this.tsbSave,
            this.tsbRefresh});
            this.tsModel.Location = new System.Drawing.Point(0, 0);
            this.tsModel.Name = "tsModel";
            this.tsModel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsModel.Size = new System.Drawing.Size(245, 25);
            this.tsModel.TabIndex = 7;
            this.tsModel.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "مدلها";
            // 
            // tsbModelNew
            // 
            this.tsbModelNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelNew.Image = global::Presentation.Properties.Resources.S_NewForm;
            this.tsbModelNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModelNew.Name = "tsbModelNew";
            this.tsbModelNew.Size = new System.Drawing.Size(23, 22);
            this.tsbModelNew.ToolTipText = "مدل جدید";
            this.tsbModelNew.Click += new System.EventHandler(this.tsbModelNew_Click);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbModelRemove
            // 
            this.tsbModelRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelRemove.Image = global::Presentation.Properties.Resources.S_Delete1;
            this.tsbModelRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModelRemove.Name = "tsbModelRemove";
            this.tsbModelRemove.Size = new System.Drawing.Size(23, 22);
            this.tsbModelRemove.Text = "toolStripButton4";
            this.tsbModelRemove.ToolTipText = "حذف مدل";
            this.tsbModelRemove.Click += new System.EventHandler(this.tsbModelRemove_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.ToolTipText = "ذخیره مدل";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
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
            // ut
            // 
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            appearance1.FontData.BoldAsString = "True";
            appearance1.FontData.Name = "B Nazanin";
            appearance1.FontData.SizeInPoints = 12F;
            appearance1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            this.ut.Appearance = appearance1;
            this.ut.ContextMenuStrip = this.ctxMenu;
            this.ut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ut.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ut.Location = new System.Drawing.Point(0, 25);
            this.ut.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ut.Name = "ut";
            this.ut.Size = new System.Drawing.Size(589, 670);
            this.ut.TabIndex = 32;
            this.ut.DoubleClick += new System.EventHandler(this.ut_DoubleClick);
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdd,
            this.miEdit,
            this.miRemove,
            this.convertToolStripMenuItem,
            this.miCollapseAll,
            this.miExpandAll});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctxMenu.Size = new System.Drawing.Size(133, 120);
            // 
            // miAdd
            // 
            this.miAdd.Image = global::Presentation.Properties.Resources.New;
            this.miAdd.Name = "miAdd";
            this.miAdd.Size = new System.Drawing.Size(132, 22);
            this.miAdd.Text = "جدید";
            this.miAdd.Click += new System.EventHandler(this.miAdd_Click);
            // 
            // miEdit
            // 
            this.miEdit.Image = global::Presentation.Properties.Resources.Edit1;
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(132, 22);
            this.miEdit.Text = "ويرايش";
            this.miEdit.Click += new System.EventHandler(this.miEdit_Click);
            // 
            // miRemove
            // 
            this.miRemove.Image = global::Presentation.Properties.Resources.Remove;
            this.miRemove.Name = "miRemove";
            this.miRemove.Size = new System.Drawing.Size(132, 22);
            this.miRemove.Text = "حذف";
            this.miRemove.Click += new System.EventHandler(this.miRemove_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(129, 6);
            // 
            // miCollapseAll
            // 
            this.miCollapseAll.Name = "miCollapseAll";
            this.miCollapseAll.Size = new System.Drawing.Size(132, 22);
            this.miCollapseAll.Text = "بستن همه";
            this.miCollapseAll.Click += new System.EventHandler(this.miCollapseAll_Click);
            // 
            // miExpandAll
            // 
            this.miExpandAll.Name = "miExpandAll";
            this.miExpandAll.Size = new System.Drawing.Size(132, 22);
            this.miExpandAll.Text = "بازكردن همه";
            this.miExpandAll.Click += new System.EventHandler(this.miExpandAll_Click);
            // 
            // tsDiagram
            // 
            this.tsDiagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            this.tsDiagram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsDiagram.BackgroundImage")));
            this.tsDiagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsDiagram.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tsDiagram.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsDiagram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.tsbNew,
            this.tsbEdit,
            this.tsbRemove});
            this.tsDiagram.Location = new System.Drawing.Point(0, 0);
            this.tsDiagram.Name = "tsDiagram";
            this.tsDiagram.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsDiagram.Size = new System.Drawing.Size(589, 25);
            this.tsDiagram.TabIndex = 31;
            this.tsDiagram.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel2.Text = "   نمودار";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::Presentation.Properties.Resources.S_Add1;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 22);
            this.tsbNew.Text = "جدید";
            this.tsbNew.ToolTipText = "جدید";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = global::Presentation.Properties.Resources.S_Edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbEdit.Text = "ویرایش";
            this.tsbEdit.ToolTipText = "ویرایش";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbRemove
            // 
            this.tsbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemove.Image = global::Presentation.Properties.Resources.S_Delete;
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(23, 22);
            this.tsbRemove.Text = "حذف";
            this.tsbRemove.ToolTipText = "حذف";
            this.tsbRemove.Click += new System.EventHandler(this.tsbRemove_Click);
            // 
            // frmLimitManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(840, 695);
            this.Controls.Add(this.spcAll);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLimitManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "  مديريت حدود   ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLimitManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmLimitManagement_Load);
            this.spcAll.Panel1.ResumeLayout(false);
            this.spcAll.Panel1.PerformLayout();
            this.spcAll.Panel2.ResumeLayout(false);
            this.spcAll.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).EndInit();
            this.spcAll.ResumeLayout(false);
            this.tsModel.ResumeLayout(false);
            this.tsModel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ut)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.tsDiagram.ResumeLayout(false);
            this.tsDiagram.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcAll;
        private System.Windows.Forms.ListView lsvModel;
        private System.Windows.Forms.ToolStrip tsDiagram;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbRemove;
        private System.Windows.Forms.ToolStrip tsModel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbModelNew;
        private System.Windows.Forms.ToolStripButton tsbModelEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbModelRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private Infragistics.Win.UltraWinTree.UltraTree ut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem miAdd;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miRemove;
        private System.Windows.Forms.ToolStripSeparator convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCollapseAll;
        private System.Windows.Forms.ToolStripMenuItem miExpandAll;
    }
}