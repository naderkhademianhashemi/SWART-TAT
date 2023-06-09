namespace Presentation.Tabs.GuidanceTableu
{
    partial class frmModelManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModelManagement));
            Presentation.Public.MyControls.TreeViewEx.TreeInfoEx treeInfoEx1 = new Presentation.Public.MyControls.TreeViewEx.TreeInfoEx();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.spcAll = new System.Windows.Forms.SplitContainer();
            this.trvUsers = new System.Windows.Forms.TreeView();
            this.tsModel = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnModel = new Utilize.Company.CButton();
            this.btnExport = new Utilize.Company.CButton();
            this.spcModels = new System.Windows.Forms.SplitContainer();
            this.trv = new Presentation.Public.MyControls.TreeViewEx.TreeViewEx();
            this.spcTbm = new System.Windows.Forms.SplitContainer();
            this.pnlTimeBucket = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).BeginInit();
            this.spcAll.Panel1.SuspendLayout();
            this.spcAll.Panel2.SuspendLayout();
            this.spcAll.SuspendLayout();
            this.tsModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcModels)).BeginInit();
            this.spcModels.Panel1.SuspendLayout();
            this.spcModels.Panel2.SuspendLayout();
            this.spcModels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcTbm)).BeginInit();
            this.spcTbm.Panel1.SuspendLayout();
            this.spcTbm.Panel2.SuspendLayout();
            this.spcTbm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // spcAll
            // 
            this.spcAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.spcAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.spcAll.Location = new System.Drawing.Point(1, 3);
            this.spcAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spcAll.Name = "spcAll";
            // 
            // spcAll.Panel1
            // 
            this.spcAll.Panel1.Controls.Add(this.trvUsers);
            this.spcAll.Panel1.Controls.Add(this.tsModel);
            this.spcAll.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // spcAll.Panel2
            // 
            this.spcAll.Panel2.Controls.Add(this.splitContainer1);
            this.spcAll.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spcAll.Size = new System.Drawing.Size(799, 627);
            this.spcAll.SplitterDistance = 163;
            this.spcAll.SplitterWidth = 5;
            this.spcAll.TabIndex = 7;
            // 
            // trvUsers
            // 
            this.trvUsers.BackColor = System.Drawing.Color.White;
            this.trvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvUsers.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.trvUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.trvUsers.Location = new System.Drawing.Point(0, 25);
            this.trvUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trvUsers.Name = "trvUsers";
            this.trvUsers.Size = new System.Drawing.Size(163, 602);
            this.trvUsers.TabIndex = 3;
            this.trvUsers.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvUsers_NodeMouseClick);
            // 
            // tsModel
            // 
            this.tsModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            this.tsModel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsModel.BackgroundImage")));
            this.tsModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsModel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsModel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsModel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.tsbRefresh});
            this.tsModel.Location = new System.Drawing.Point(0, 0);
            this.tsModel.Name = "tsModel";
            this.tsModel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsModel.Size = new System.Drawing.Size(163, 25);
            this.tsModel.TabIndex = 5;
            this.tsModel.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel1.Text = "مدلهای كاربران ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "toolStripButton1";
            this.tsbRefresh.ToolTipText = "تازه سازي";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnModel);
            this.splitContainer1.Panel1.Controls.Add(this.btnExport);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.spcModels);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(631, 627);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 35;
            // 
            // btnModel
            // 
            this.btnModel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnModel.DefaultImage")));
            this.btnModel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnModel.HoverImage")));
            this.btnModel.Location = new System.Drawing.Point(604, 0);
            this.btnModel.Name = "btnModel";
            this.btnModel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModel.Size = new System.Drawing.Size(27, 40);
            this.btnModel.TabIndex = 30;
            this.btnModel.Title = null;
            this.btnModel.Visible = false;
            this.btnModel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnModel_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnExport.DefaultImage")));
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExport.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnExport.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnExport.HoverImage")));
            this.btnExport.Location = new System.Drawing.Point(462, 5);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 60, 3, 60);
            this.btnExport.Name = "btnExport";
            this.btnExport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.Size = new System.Drawing.Size(125, 32);
            this.btnExport.TabIndex = 34;
            this.btnExport.Title = "انتقال مدل";
            this.btnExport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnExport_Click);
            // 
            // spcModels
            // 
            this.spcModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcModels.Location = new System.Drawing.Point(0, 0);
            this.spcModels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spcModels.Name = "spcModels";
            // 
            // spcModels.Panel1
            // 
            this.spcModels.Panel1.Controls.Add(this.trv);
            this.spcModels.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // spcModels.Panel2
            // 
            this.spcModels.Panel2.Controls.Add(this.spcTbm);
            this.spcModels.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spcModels.Size = new System.Drawing.Size(631, 583);
            this.spcModels.SplitterDistance = 201;
            this.spcModels.TabIndex = 31;
            // 
            // trv
            // 
            this.trv.BackColor = System.Drawing.Color.White;
            this.trv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.trv.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.trv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.trv.Location = new System.Drawing.Point(0, 0);
            this.trv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trv.Name = "trv";
            this.trv.Size = new System.Drawing.Size(201, 583);
            this.trv.TabIndex = 29;
            this.trv.TreeInfoEx = treeInfoEx1;
            // 
            // spcTbm
            // 
            this.spcTbm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcTbm.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcTbm.Location = new System.Drawing.Point(0, 0);
            this.spcTbm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spcTbm.Name = "spcTbm";
            this.spcTbm.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcTbm.Panel1
            // 
            this.spcTbm.Panel1.Controls.Add(this.pnlTimeBucket);
            this.spcTbm.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // spcTbm.Panel2
            // 
            this.spcTbm.Panel2.Controls.Add(this.dgvList);
            this.spcTbm.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spcTbm.Size = new System.Drawing.Size(426, 583);
            this.spcTbm.SplitterDistance = 109;
            this.spcTbm.SplitterWidth = 5;
            this.spcTbm.TabIndex = 0;
            // 
            // pnlTimeBucket
            // 
            this.pnlTimeBucket.AutoScroll = true;
            this.pnlTimeBucket.BackColor = System.Drawing.Color.Transparent;
            this.pnlTimeBucket.BackgroundImage = global::Presentation.Properties.Resources.S_BGComponents_Hor;
            this.pnlTimeBucket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTimeBucket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTimeBucket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimeBucket.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnlTimeBucket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.pnlTimeBucket.Location = new System.Drawing.Point(0, 0);
            this.pnlTimeBucket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTimeBucket.Name = "pnlTimeBucket";
            this.pnlTimeBucket.Size = new System.Drawing.Size(426, 109);
            this.pnlTimeBucket.TabIndex = 21;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.Size = new System.Drawing.Size(426, 469);
            this.dgvList.TabIndex = 22;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // frmModelManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(806, 645);
            this.Controls.Add(this.spcAll);
            this.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModelManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "  مدیریت مدلها   ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTemplate_Load);
            this.spcAll.Panel1.ResumeLayout(false);
            this.spcAll.Panel1.PerformLayout();
            this.spcAll.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcAll)).EndInit();
            this.spcAll.ResumeLayout(false);
            this.tsModel.ResumeLayout(false);
            this.tsModel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.spcModels.Panel1.ResumeLayout(false);
            this.spcModels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcModels)).EndInit();
            this.spcModels.ResumeLayout(false);
            this.spcTbm.Panel1.ResumeLayout(false);
            this.spcTbm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcTbm)).EndInit();
            this.spcTbm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcAll;
        private System.Windows.Forms.TreeView trvUsers;
        private Utilize.Company.CButton btnModel;
        private System.Windows.Forms.ToolStrip tsModel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.SplitContainer spcModels;
        private Presentation.Public.MyControls.TreeViewEx.TreeViewEx trv;
        private System.Windows.Forms.SplitContainer spcTbm;
        private System.Windows.Forms.Panel pnlTimeBucket;
        private System.Windows.Forms.DataGridView dgvList;
        private Utilize.Company.CButton btnExport;
        private System.Windows.Forms.SplitContainer splitContainer1;
       
    }
}