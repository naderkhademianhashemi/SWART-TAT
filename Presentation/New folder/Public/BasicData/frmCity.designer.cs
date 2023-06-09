namespace Presentation.Tabs.BasicData
{
    partial class frmCity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCity));
            this.bngBranch = new System.Windows.Forms.BindingSource(this.components);
            this.tsbModelNew = new System.Windows.Forms.ToolStripButton();
            this.tsbModelEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbModelRemove = new System.Windows.Forms.ToolStripButton();
            this.tsbModelSave = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbPages = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvBranch = new System.Windows.Forms.DataGridView();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.bngNBranch = new System.Windows.Forms.BindingNavigator(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bngBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).BeginInit();
            this.grbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bngNBranch)).BeginInit();
            this.bngNBranch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbModelNew
            // 
            this.tsbModelNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModelNew.Name = "tsbModelNew";
            this.tsbModelNew.Size = new System.Drawing.Size(29, 22);
            this.tsbModelNew.ToolTipText = "شهر جديد";
            this.tsbModelNew.Click += new System.EventHandler(this.tsbModelNew_Click);
            // 
            // tsbModelEdit
            // 
            this.tsbModelEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModelEdit.Name = "tsbModelEdit";
            this.tsbModelEdit.Size = new System.Drawing.Size(29, 22);
            this.tsbModelEdit.Text = "toolStripButton3";
            this.tsbModelEdit.ToolTipText = "ويرايش شهر";
            this.tsbModelEdit.Click += new System.EventHandler(this.tsbModelEdit_Click);
            // 
            // tsbModelRemove
            // 
            this.tsbModelRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModelRemove.Name = "tsbModelRemove";
            this.tsbModelRemove.Size = new System.Drawing.Size(29, 22);
            this.tsbModelRemove.Text = "toolStripButton4";
            this.tsbModelRemove.ToolTipText = "حذف شهر";
            this.tsbModelRemove.Click += new System.EventHandler(this.tsbModelRemove_Click);
            // 
            // tsbModelSave
            // 
            this.tsbModelSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModelSave.Name = "tsbModelSave";
            this.tsbModelSave.Size = new System.Drawing.Size(29, 22);
            this.tsbModelSave.Text = "Save";
            this.tsbModelSave.ToolTipText = "ذخيره شهر";
            this.tsbModelSave.Click += new System.EventHandler(this.tsbModelSave_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.cmbPages);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvBranch);
            this.splitContainer1.Size = new System.Drawing.Size(784, 564);
            this.splitContainer1.SplitterDistance = 36;
            this.splitContainer1.TabIndex = 108;
            // 
            // cmbPages
            // 
            this.cmbPages.AccessibleName = "";
            this.cmbPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.cmbPages.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbPages.Location = new System.Drawing.Point(534, 8);
            this.cmbPages.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbPages.MaxDropDownItems = 20;
            this.cmbPages.Name = "cmbPages";
            this.cmbPages.Size = new System.Drawing.Size(192, 32);
            this.cmbPages.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label11.Location = new System.Drawing.Point(728, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 27);
            this.label11.TabIndex = 31;
            this.label11.Text = "صفحه";
            // 
            // dgvBranch
            // 
            this.dgvBranch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvBranch.BackgroundColor = System.Drawing.Color.White;
            this.dgvBranch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBranch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBranch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBranch.EnableHeadersVisualStyles = false;
            this.dgvBranch.Location = new System.Drawing.Point(0, 0);
            this.dgvBranch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvBranch.Name = "dgvBranch";
            this.dgvBranch.ReadOnly = true;
            this.dgvBranch.RowHeadersWidth = 60;
            this.dgvBranch.RowTemplate.Height = 24;
            this.dgvBranch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBranch.Size = new System.Drawing.Size(784, 524);
            this.dgvBranch.TabIndex = 2;
            this.dgvBranch.SelectionChanged += new System.EventHandler(this.dgvBranch_SelectionChanged);
            // 
            // grbDetails
            // 
            this.grbDetails.Controls.Add(this.cmbState);
            this.grbDetails.Controls.Add(this.bngNBranch);
            this.grbDetails.Controls.Add(this.label3);
            this.grbDetails.Controls.Add(this.txtCity_Name);
            this.grbDetails.Controls.Add(this.label1);
            this.grbDetails.Controls.Add(this.label2);
            this.grbDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbDetails.Location = new System.Drawing.Point(0, 564);
            this.grbDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDetails.Size = new System.Drawing.Size(784, 96);
            this.grbDetails.TabIndex = 28;
            this.grbDetails.TabStop = false;
            // 
            // cmbState
            // 
            this.cmbState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.cmbState.Enabled = false;
            this.cmbState.Location = new System.Drawing.Point(90, 18);
            this.cmbState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(262, 32);
            this.cmbState.TabIndex = 7;
            // 
            // bngNBranch
            // 
            this.bngNBranch.AddNewItem = null;
            this.bngNBranch.BackColor = System.Drawing.Color.Transparent;
            this.bngNBranch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bngNBranch.BackgroundImage")));
            this.bngNBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bngNBranch.CountItem = null;
            this.bngNBranch.DeleteItem = null;
            this.bngNBranch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bngNBranch.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bngNBranch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bngNBranch.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bngNBranch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbModelNew,
            this.tsbModelEdit,
            this.tsbModelRemove,
            this.tsbModelSave});
            this.bngNBranch.Location = new System.Drawing.Point(3, 67);
            this.bngNBranch.MoveFirstItem = null;
            this.bngNBranch.MoveLastItem = null;
            this.bngNBranch.MoveNextItem = null;
            this.bngNBranch.MovePreviousItem = null;
            this.bngNBranch.Name = "bngNBranch";
            this.bngNBranch.PositionItem = null;
            this.bngNBranch.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bngNBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bngNBranch.Size = new System.Drawing.Size(778, 25);
            this.bngNBranch.TabIndex = 6;
            this.bngNBranch.Text = "bindingNavigator1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(710, -605);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 30);
            this.label3.TabIndex = 31;
            this.label3.Text = "صفحه";
            // 
            // txtCity_Name
            // 
            this.txtCity_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            this.txtCity_Name.Enabled = false;
            this.txtCity_Name.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCity_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.txtCity_Name.Location = new System.Drawing.Point(433, 16);
            this.txtCity_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCity_Name.Multiline = true;
            this.txtCity_Name.Name = "txtCity_Name";
            this.txtCity_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCity_Name.Size = new System.Drawing.Size(264, 30);
            this.txtCity_Name.TabIndex = 4;
            this.txtCity_Name.TextChanged += new System.EventHandler(this.txtCity_Name_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(355, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "استان";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(703, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام شهر";
            // 
            // frmCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 660);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.grbDetails);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCity";
            this.Text = "  شعبه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bngBranch)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).EndInit();
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bngNBranch)).EndInit();
            this.bngNBranch.ResumeLayout(false);
            this.bngNBranch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvBranch;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.TextBox txtCity_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bngBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPages;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.ToolStripButton tsbModelNew;
        private System.Windows.Forms.ToolStripButton tsbModelEdit;
        private System.Windows.Forms.ToolStripButton tsbModelRemove;
        private System.Windows.Forms.ToolStripButton tsbModelSave;
        private System.Windows.Forms.BindingNavigator bngNBranch;
    }
}