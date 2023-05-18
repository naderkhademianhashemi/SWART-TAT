namespace Presentation.Loan
{
    partial class frmHistoricalLoanReport
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoricalLoanReport));
            this.gbFormulaType = new System.Windows.Forms.GroupBox();
            this.cbContractStatus = new System.Windows.Forms.ComboBox();
            this.lblResoult = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnFullScreenShow = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCounterparty = new System.Windows.Forms.TextBox();
            this.txtCounterPartyName = new System.Windows.Forms.TextBox();
            this.txtContractNo = new System.Windows.Forms.TextBox();
            this.txtContractName = new System.Windows.Forms.TextBox();
            this.gbStateBranch = new System.Windows.Forms.GroupBox();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.rbStateBranch = new System.Windows.Forms.RadioButton();
            this.rbContract = new System.Windows.Forms.RadioButton();
            this.rbCounterparty = new System.Windows.Forms.RadioButton();
            this.chbSerries = new System.Windows.Forms.CheckedListBox();
            this.btnShowReport = new Utilize.Company.CButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gbFormulaType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbSetting.SuspendLayout();
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
            // gbFormulaType
            // 
            this.gbFormulaType.BackColor = System.Drawing.Color.Gray;
            this.gbFormulaType.Controls.Add(this.cbContractStatus);
            this.gbFormulaType.Controls.Add(this.lblResoult);
            this.gbFormulaType.Controls.Add(this.radioButton2);
            this.gbFormulaType.Controls.Add(this.radioButton1);
            this.gbFormulaType.Controls.Add(this.label1);
            this.gbFormulaType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFormulaType.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbFormulaType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.gbFormulaType.Location = new System.Drawing.Point(0, 0);
            this.gbFormulaType.Margin = new System.Windows.Forms.Padding(4);
            this.gbFormulaType.Name = "gbFormulaType";
            this.gbFormulaType.Padding = new System.Windows.Forms.Padding(4);
            this.gbFormulaType.Size = new System.Drawing.Size(507, 114);
            this.gbFormulaType.TabIndex = 129;
            this.gbFormulaType.TabStop = false;
            this.gbFormulaType.Text = "نمودار";
            this.gbFormulaType.Visible = false;
            // 
            // cbContractStatus
            // 
            this.cbContractStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbContractStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.cbContractStatus.Location = new System.Drawing.Point(64, 18);
            this.cbContractStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbContractStatus.Name = "cbContractStatus";
            this.cbContractStatus.Size = new System.Drawing.Size(320, 34);
            this.cbContractStatus.TabIndex = 133;
            // 
            // lblResoult
            // 
            this.lblResoult.AutoSize = true;
            this.lblResoult.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResoult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblResoult.Location = new System.Drawing.Point(393, 54);
            this.lblResoult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResoult.Name = "lblResoult";
            this.lblResoult.Size = new System.Drawing.Size(76, 27);
            this.lblResoult.TabIndex = 132;
            this.lblResoult.Text = "نوع گزارش";
            this.lblResoult.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.radioButton2.Location = new System.Drawing.Point(321, 82);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 31);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "جمع";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.radioButton1.Location = new System.Drawing.Point(317, 52);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 31);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "تعداد";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(393, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 27);
            this.label1.TabIndex = 130;
            this.label1.Text = "وضعیت قرارداد";
            this.label1.Visible = false;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke;
            this.chart1.ContextMenuStrip = this.contextMenuStrip1;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.Name = "series 1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(816, 328);
            this.chart1.TabIndex = 138;
            this.chart1.Text = "chart1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFullScreenShow});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 38);
            // 
            // btnFullScreenShow
            // 
            this.btnFullScreenShow.Name = "btnFullScreenShow";
            this.btnFullScreenShow.Size = new System.Drawing.Size(245, 34);
            this.btnFullScreenShow.Text = "نمایش تمام صفحه گزارش";
            this.btnFullScreenShow.Click += new System.EventHandler(this.btnFullScreenChart_Click);
            // 
            // txtCounterparty
            // 
            this.txtCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterparty.Enabled = false;
            this.txtCounterparty.Location = new System.Drawing.Point(213, 154);
            this.txtCounterparty.Margin = new System.Windows.Forms.Padding(4);
            this.txtCounterparty.Name = "txtCounterparty";
            this.txtCounterparty.Size = new System.Drawing.Size(181, 33);
            this.txtCounterparty.TabIndex = 134;
            // 
            // txtCounterPartyName
            // 
            this.txtCounterPartyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterPartyName.Location = new System.Drawing.Point(8, 154);
            this.txtCounterPartyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCounterPartyName.Name = "txtCounterPartyName";
            this.txtCounterPartyName.ReadOnly = true;
            this.txtCounterPartyName.Size = new System.Drawing.Size(191, 33);
            this.txtCounterPartyName.TabIndex = 135;
            // 
            // txtContractNo
            // 
            this.txtContractNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContractNo.Enabled = false;
            this.txtContractNo.Location = new System.Drawing.Point(213, 194);
            this.txtContractNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.Size = new System.Drawing.Size(181, 33);
            this.txtContractNo.TabIndex = 137;
            // 
            // txtContractName
            // 
            this.txtContractName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContractName.Location = new System.Drawing.Point(8, 194);
            this.txtContractName.Margin = new System.Windows.Forms.Padding(4);
            this.txtContractName.Name = "txtContractName";
            this.txtContractName.ReadOnly = true;
            this.txtContractName.Size = new System.Drawing.Size(191, 33);
            this.txtContractName.TabIndex = 138;
            // 
            // gbStateBranch
            // 
            this.gbStateBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStateBranch.BackColor = System.Drawing.Color.Gray;
            this.gbStateBranch.Location = new System.Drawing.Point(8, 15);
            this.gbStateBranch.Margin = new System.Windows.Forms.Padding(4);
            this.gbStateBranch.Name = "gbStateBranch";
            this.gbStateBranch.Padding = new System.Windows.Forms.Padding(4);
            this.gbStateBranch.Size = new System.Drawing.Size(487, 124);
            this.gbStateBranch.TabIndex = 140;
            this.gbStateBranch.TabStop = false;
            // 
            // gbSetting
            // 
            this.gbSetting.BackColor = System.Drawing.Color.Gray;
            this.gbSetting.Controls.Add(this.rbStateBranch);
            this.gbSetting.Controls.Add(this.gbStateBranch);
            this.gbSetting.Controls.Add(this.rbContract);
            this.gbSetting.Controls.Add(this.rbCounterparty);
            this.gbSetting.Controls.Add(this.txtCounterPartyName);
            this.gbSetting.Controls.Add(this.txtContractNo);
            this.gbSetting.Controls.Add(this.txtCounterparty);
            this.gbSetting.Controls.Add(this.txtContractName);
            this.gbSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSetting.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.gbSetting.Location = new System.Drawing.Point(0, 0);
            this.gbSetting.Margin = new System.Windows.Forms.Padding(4);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Padding = new System.Windows.Forms.Padding(4);
            this.gbSetting.Size = new System.Drawing.Size(533, 233);
            this.gbSetting.TabIndex = 0;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "فیلتر بندی";
            // 
            // rbStateBranch
            // 
            this.rbStateBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbStateBranch.AutoSize = true;
            this.rbStateBranch.Checked = true;
            this.rbStateBranch.Location = new System.Drawing.Point(505, 27);
            this.rbStateBranch.Margin = new System.Windows.Forms.Padding(4);
            this.rbStateBranch.Name = "rbStateBranch";
            this.rbStateBranch.Size = new System.Drawing.Size(17, 16);
            this.rbStateBranch.TabIndex = 141;
            this.rbStateBranch.TabStop = true;
            this.rbStateBranch.UseVisualStyleBackColor = true;
            this.rbStateBranch.CheckedChanged += new System.EventHandler(this.rbStateBranch_CheckedChanged);
            // 
            // rbContract
            // 
            this.rbContract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbContract.AutoSize = true;
            this.rbContract.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rbContract.Location = new System.Drawing.Point(414, 194);
            this.rbContract.Margin = new System.Windows.Forms.Padding(4);
            this.rbContract.Name = "rbContract";
            this.rbContract.Size = new System.Drawing.Size(111, 31);
            this.rbContract.TabIndex = 140;
            this.rbContract.Text = "شماره قرارداد";
            this.rbContract.UseVisualStyleBackColor = true;
            this.rbContract.CheckedChanged += new System.EventHandler(this.rbStateBranch_CheckedChanged);
            // 
            // rbCounterparty
            // 
            this.rbCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCounterparty.AutoSize = true;
            this.rbCounterparty.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbCounterparty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rbCounterparty.Location = new System.Drawing.Point(449, 154);
            this.rbCounterparty.Margin = new System.Windows.Forms.Padding(4);
            this.rbCounterparty.Name = "rbCounterparty";
            this.rbCounterparty.Size = new System.Drawing.Size(76, 31);
            this.rbCounterparty.TabIndex = 139;
            this.rbCounterparty.Text = "مشتری";
            this.rbCounterparty.UseVisualStyleBackColor = true;
            this.rbCounterparty.CheckedChanged += new System.EventHandler(this.rbStateBranch_CheckedChanged);
            // 
            // chbSerries
            // 
            this.chbSerries.BackColor = System.Drawing.Color.White;
            this.chbSerries.CheckOnClick = true;
            this.chbSerries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbSerries.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbSerries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.chbSerries.FormattingEnabled = true;
            this.chbSerries.Location = new System.Drawing.Point(0, 0);
            this.chbSerries.Margin = new System.Windows.Forms.Padding(4);
            this.chbSerries.Name = "chbSerries";
            this.chbSerries.Size = new System.Drawing.Size(224, 328);
            this.chbSerries.TabIndex = 136;
            this.chbSerries.SelectedIndexChanged += new System.EventHandler(this.chbSerries_SelectedIndexChanged);
            // 
            // btnShowReport
            // 
            this.btnShowReport.AutoSize = true;
            this.btnShowReport.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnShowReport.DefaultImage")));
            this.btnShowReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowReport.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowReport.HoverImage")));
            this.btnShowReport.Location = new System.Drawing.Point(16, 187);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowReport.Size = new System.Drawing.Size(188, 36);
            this.btnShowReport.TabIndex = 133;
            this.btnShowReport.Title = null;
            this.btnShowReport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnShowReport_Click);
            this.btnShowReport.Load += new System.EventHandler(this.btnShowReport_Load);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chbSerries);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1045, 328);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 139;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbSetting);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbFormulaType);
            this.splitContainer2.Panel2.Controls.Add(this.btnShowReport);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(1045, 233);
            this.splitContainer2.SplitterDistance = 533;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 140;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(1045, 565);
            this.splitContainer3.SplitterDistance = 233;
            this.splitContainer3.TabIndex = 141;
            // 
            // frmHistoricalLoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1045, 565);
            this.Controls.Add(this.splitContainer3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmHistoricalLoanReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "گزارش تاریخی قردادها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbFormulaType.ResumeLayout(false);
            this.gbFormulaType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbSetting.ResumeLayout(false);
            this.gbSetting.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Utilize.Report.UCFilteringMini ucfOrganization;
        private Utilize.Report.UCFilteringMini ucfState;
        private System.Windows.Forms.GroupBox gbFormulaType;
        private System.Windows.Forms.GroupBox gbStateBranch;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCounterparty;
        private System.Windows.Forms.TextBox txtCounterPartyName;
        private System.Windows.Forms.TextBox txtContractNo;
        private System.Windows.Forms.TextBox txtContractName;
        private System.Windows.Forms.RadioButton rbStateBranch;
        private System.Windows.Forms.RadioButton rbContract;
        private System.Windows.Forms.RadioButton rbCounterparty;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckedListBox chbSerries;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnFullScreenShow;
        private System.Windows.Forms.Label lblResoult;
        private Utilize.Company.CButton btnShowReport;
        private System.Windows.Forms.ComboBox cbContractStatus;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}