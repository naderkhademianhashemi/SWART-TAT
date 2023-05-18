namespace Presentation.Deposit
{
    partial class frmDepositModeling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositModeling));
            this.chbColumnsOfShow = new System.Windows.Forms.CheckedListBox();
            this.lsvModel = new System.Windows.Forms.ListView();
            this.tsModel = new System.Windows.Forms.ToolStrip();
            this.tsbModelNew = new System.Windows.Forms.ToolStripButton();
            this.tsbModelEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModelRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModelSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.ugbModel = new Utilize.Company.CGroupBox();
            this.ultraGroupBox1 = new Utilize.Company.CGroupBox();
            this.chb_AllDeposit = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tsModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ugbModel)).BeginInit();
            this.ugbModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
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
            // chbColumnsOfShow
            // 
            this.chbColumnsOfShow.BackColor = System.Drawing.Color.White;
            this.chbColumnsOfShow.CheckOnClick = true;
            this.chbColumnsOfShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbColumnsOfShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.chbColumnsOfShow.FormattingEnabled = true;
            this.chbColumnsOfShow.Location = new System.Drawing.Point(3, 24);
            this.chbColumnsOfShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbColumnsOfShow.Name = "chbColumnsOfShow";
            this.chbColumnsOfShow.Size = new System.Drawing.Size(476, 308);
            this.chbColumnsOfShow.TabIndex = 135;
            // 
            // lsvModel
            // 
            this.lsvModel.BackColor = System.Drawing.Color.White;
            this.lsvModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.lsvModel.Location = new System.Drawing.Point(3, 24);
            this.lsvModel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lsvModel.MultiSelect = false;
            this.lsvModel.Name = "lsvModel";
            this.lsvModel.RightToLeftLayout = true;
            this.lsvModel.Size = new System.Drawing.Size(237, 308);
            this.lsvModel.TabIndex = 137;
            this.lsvModel.UseCompatibleStateImageBehavior = false;
            this.lsvModel.SelectedIndexChanged += new System.EventHandler(this.lsvModel_SelectedIndexChanged);
            // 
            // tsModel
            // 
            this.tsModel.BackColor = System.Drawing.Color.Transparent;
            this.tsModel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsModel.BackgroundImage")));
            this.tsModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsModel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsModel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsModel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbModelNew,
            this.tsbModelEdit,
            this.toolStripSeparator3,
            this.tsbModelRemove,
            this.toolStripSeparator1,
            this.tsbModelSave,
            this.toolStripButton1,
            this.tsbRefresh});
            this.tsModel.Location = new System.Drawing.Point(0, 0);
            this.tsModel.Name = "tsModel";
            this.tsModel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsModel.Size = new System.Drawing.Size(243, 25);
            this.tsModel.TabIndex = 138;
            this.tsModel.Text = "toolStrip1";
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
            this.tsbModelEdit.Image = global::Presentation.Properties.Resources.S_Edit;
            this.tsbModelEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModelEdit.Name = "tsbModelEdit";
            this.tsbModelEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbModelEdit.Text = "toolStripButton3";
            this.tsbModelEdit.ToolTipText = "ویرايش مدل";
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
            this.tsbModelRemove.Image = global::Presentation.Properties.Resources.S_Delete;
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
            // tsbModelSave
            // 
            this.tsbModelSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelSave.Image = global::Presentation.Properties.Resources.S_Save;
            this.tsbModelSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModelSave.Name = "tsbModelSave";
            this.tsbModelSave.Size = new System.Drawing.Size(23, 22);
            this.tsbModelSave.Text = "Save";
            this.tsbModelSave.ToolTipText = "ذخیره مدل";
            this.tsbModelSave.Click += new System.EventHandler(this.tsbModelSave_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::Presentation.Properties.Resources.S_Refresh;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "toolStripButton2";
            this.tsbRefresh.ToolTipText = "تازه سازي";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // ugbModel
            // 
            this.ugbModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.ugbModel.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.ugbModel.Controls.Add(this.lsvModel);
            this.ugbModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ugbModel.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ugbModel.Location = new System.Drawing.Point(0, 0);
            this.ugbModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ugbModel.Name = "ugbModel";
            this.ugbModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ugbModel.Size = new System.Drawing.Size(243, 335);
            this.ugbModel.TabIndex = 141;
            this.ugbModel.Text = "مدل";
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.ultraGroupBox1.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.ultraGroupBox1.Controls.Add(this.chbColumnsOfShow);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraGroupBox1.Size = new System.Drawing.Size(482, 335);
            this.ultraGroupBox1.TabIndex = 142;
            this.ultraGroupBox1.Text = "عنوان قرارداد";
            // 
            // chb_AllDeposit
            // 
            this.chb_AllDeposit.AutoSize = true;
            this.chb_AllDeposit.Dock = System.Windows.Forms.DockStyle.Right;
            this.chb_AllDeposit.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chb_AllDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chb_AllDeposit.Location = new System.Drawing.Point(354, 0);
            this.chb_AllDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chb_AllDeposit.Name = "chb_AllDeposit";
            this.chb_AllDeposit.Size = new System.Drawing.Size(128, 25);
            this.chb_AllDeposit.TabIndex = 143;
            this.chb_AllDeposit.Text = "انتخاب تمام سپرده ها";
            this.chb_AllDeposit.UseVisualStyleBackColor = true;
            this.chb_AllDeposit.CheckedChanged += new System.EventHandler(this.chb_AllDeposit_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(729, 365);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 144;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tsModel);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ugbModel);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(243, 365);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 142;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.chb_AllDeposit);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ultraGroupBox1);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(482, 365);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 142;
            // 
            // frmDepositModeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(729, 365);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDepositModeling";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "مدل سازی نوع سپرده ها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDepositModeling_Load);
            this.tsModel.ResumeLayout(false);
            this.tsModel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ugbModel)).EndInit();
            this.ugbModel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chbColumnsOfShow;
        private System.Windows.Forms.ListView lsvModel;
        private System.Windows.Forms.ToolStrip tsModel;
        private System.Windows.Forms.ToolStripButton tsbModelEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbModelRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbModelSave;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbModelNew;
        private Utilize.Company.CGroupBox ugbModel;
        private Utilize.Company.CGroupBox ultraGroupBox1;
        private System.Windows.Forms.CheckBox chb_AllDeposit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}