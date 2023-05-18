namespace Presentation
{
	partial class frmShowReport
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rpvReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnExpand = new System.Windows.Forms.Button();
            this.trnIndexOfReport = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.timerWaiting = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trnIndexOfReport)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTitle);
            this.splitContainer1.Panel1.Controls.Add(this.lblTitle);
            this.splitContainer1.Panel1.Controls.Add(this.rpvReport);
            this.splitContainer1.Panel1.Controls.Add(this.btnExpand);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.trnIndexOfReport);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(853, 499);
            this.splitContainer1.SplitterDistance = 641;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Location = new System.Drawing.Point(105, 16);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(448, 24);
            this.txtTitle.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(559, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 17);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "عنوان گزارش :";
            // 
            // rpvReport
            // 
            this.rpvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvReport.Location = new System.Drawing.Point(4, 56);
            this.rpvReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rpvReport.Name = "rpvReport";
            this.rpvReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rpvReport.ShowBackButton = false;
            this.rpvReport.ShowContextMenu = false;
            this.rpvReport.ShowDocumentMapButton = false;
            this.rpvReport.ShowFindControls = false;
            this.rpvReport.Size = new System.Drawing.Size(634, 430);
            this.rpvReport.TabIndex = 6;
            // 
            // btnExpand
            // 
            this.btnExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpand.Location = new System.Drawing.Point(3, 4);
            this.btnExpand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(61, 44);
            this.btnExpand.TabIndex = 10;
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // trnIndexOfReport
            // 
            this.trnIndexOfReport.AllowDrop = true;
            this.trnIndexOfReport.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.trnIndexOfReport.BackgroundStyle.Class = "TreeBorderKey";
            this.trnIndexOfReport.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.trnIndexOfReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trnIndexOfReport.DragDropEnabled = false;
            this.trnIndexOfReport.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.trnIndexOfReport.Location = new System.Drawing.Point(0, 0);
            this.trnIndexOfReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trnIndexOfReport.MultiNodeDragCountVisible = false;
            this.trnIndexOfReport.MultiNodeDragDropAllowed = false;
            this.trnIndexOfReport.MultiSelectRule = DevComponents.AdvTree.eMultiSelectRule.AnyNode;
            this.trnIndexOfReport.Name = "trnIndexOfReport";
            this.trnIndexOfReport.NodesConnector = this.nodeConnector1;
            this.trnIndexOfReport.NodeStyle = this.elementStyle1;
            this.trnIndexOfReport.PathSeparator = ";";
            this.trnIndexOfReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trnIndexOfReport.Size = new System.Drawing.Size(208, 499);
            this.trnIndexOfReport.Styles.Add(this.elementStyle1);
            this.trnIndexOfReport.TabIndex = 8;
            this.trnIndexOfReport.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.trnIndexOfReport_NodeClick);
            // 
            // elementStyle1
            // 
            this.elementStyle1.Class = "";
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // timerWaiting
            // 
            this.timerWaiting.Interval = 1000;
            this.timerWaiting.Tick += new System.EventHandler(this.timerWaiting_Tick);
            // 
            // frmShowReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 499);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "نمایش گزارش";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShowReport_FormClosing);
            this.Load += new System.EventHandler(this.frmShowReport_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trnIndexOfReport)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label lblTitle;
		private Microsoft.Reporting.WinForms.ReportViewer rpvReport;
		private System.Windows.Forms.Button btnExpand;
		private DevComponents.AdvTree.AdvTree trnIndexOfReport;
		private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.Timer timerWaiting;

	}
}