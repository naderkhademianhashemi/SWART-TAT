namespace Presentation
{
    partial class frmReportChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportChart));
            Dundas.Charting.WinControl.ChartArea chartArea1 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend1 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Legend legend2 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.LegendCellColumn legendCellColumn1 = new Dundas.Charting.WinControl.LegendCellColumn();
            Dundas.Charting.WinControl.Series series1 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.Command command1 = new Dundas.Charting.WinControl.Command();
            Dundas.Charting.WinControl.Command command2 = new Dundas.Charting.WinControl.Command();
            Dundas.Charting.WinControl.Command command3 = new Dundas.Charting.WinControl.Command();
            Dundas.Charting.WinControl.Command command4 = new Dundas.Charting.WinControl.Command();
            Dundas.Charting.WinControl.Command command5 = new Dundas.Charting.WinControl.Command();
            Dundas.Charting.WinControl.Command command6 = new Dundas.Charting.WinControl.Command();
            Dundas.Charting.WinControl.Command command7 = new Dundas.Charting.WinControl.Command();
            Dundas.Charting.WinControl.Command command8 = new Dundas.Charting.WinControl.Command();
            Dundas.Charting.WinControl.Command command9 = new Dundas.Charting.WinControl.Command();
            Dundas.Charting.WinControl.CommandUIItem commandUIItem1 = new Dundas.Charting.WinControl.CommandUIItem("SaveImage", "");
            Dundas.Charting.WinControl.CommandUIItem commandUIItem2 = new Dundas.Charting.WinControl.CommandUIItem("Copy", "");
            Dundas.Charting.WinControl.CommandUIItem commandUIItem3 = new Dundas.Charting.WinControl.CommandUIItem("Print", "");
            Dundas.Charting.WinControl.CommandUIItem commandUIItem4 = new Dundas.Charting.WinControl.CommandUIItem("PrintPreview", "");
            Dundas.Charting.WinControl.CommandUIItem commandUIItem5 = new Dundas.Charting.WinControl.CommandUIItem("Separator", "");
            Dundas.Charting.WinControl.CommandUIItem commandUIItem6 = new Dundas.Charting.WinControl.CommandUIItem("SelectChartGroup", "");
            Dundas.Charting.WinControl.CommandUIItem commandUIItem7 = new Dundas.Charting.WinControl.CommandUIItem("Toggle3D", "");
            Dundas.Charting.WinControl.CommandUIItem commandUIItem8 = new Dundas.Charting.WinControl.CommandUIItem("Separator", "");
            Dundas.Charting.WinControl.CommandUIItem commandUIItem9 = new Dundas.Charting.WinControl.CommandUIItem("Properties", "");
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.cGroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbY = new System.Windows.Forms.ComboBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.cmbReport = new System.Windows.Forms.ComboBox();
            this.btnShowChart = new Utilize.Company.CButton();
            this.lblX = new System.Windows.Forms.Label();
            this.cmbX = new System.Windows.Forms.ComboBox();
            this.CH = new Dundas.Charting.WinControl.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlSetting.SuspendLayout();
            this.cGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSetting
            // 
            this.pnlSetting.BackColor = System.Drawing.Color.Gray;
            this.pnlSetting.Controls.Add(this.cGroupBox1);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSetting.Location = new System.Drawing.Point(0, 0);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(831, 107);
            this.pnlSetting.TabIndex = 11;
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.BackColor = System.Drawing.Color.Gray;
            this.cGroupBox1.Controls.Add(this.cmbY);
            this.cGroupBox1.Controls.Add(this.lblReport);
            this.cGroupBox1.Controls.Add(this.lblY);
            this.cGroupBox1.Controls.Add(this.cmbReport);
            this.cGroupBox1.Controls.Add(this.btnShowChart);
            this.cGroupBox1.Controls.Add(this.lblX);
            this.cGroupBox1.Controls.Add(this.cmbX);
            this.cGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cGroupBox1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.cGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(831, 107);
            this.cGroupBox1.TabIndex = 15;
            this.cGroupBox1.TabStop = false;
            this.cGroupBox1.Text = "مشخصات";
            // 
            // cmbY
            // 
            this.cmbY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.cmbY.Location = new System.Drawing.Point(359, 72);
            this.cmbY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbY.Name = "cmbY";
            this.cmbY.Size = new System.Drawing.Size(378, 34);
            this.cmbY.TabIndex = 14;
            // 
            // lblReport
            // 
            this.lblReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(743, 19);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(51, 27);
            this.lblReport.TabIndex = 8;
            this.lblReport.Text = "گزارش";
            // 
            // lblY
            // 
            this.lblY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(743, 74);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(88, 27);
            this.lblY.TabIndex = 13;
            this.lblY.Text = "محور عمودی";
            // 
            // cmbReport
            // 
            this.cmbReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.cmbReport.Location = new System.Drawing.Point(359, 17);
            this.cmbReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbReport.Name = "cmbReport";
            this.cmbReport.Size = new System.Drawing.Size(378, 34);
            this.cmbReport.TabIndex = 9;
            // 
            // btnShowChart
            // 
            this.btnShowChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowChart.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnShowChart.DefaultImage")));
            this.btnShowChart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowChart.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowChart.HoverImage")));
            this.btnShowChart.Location = new System.Drawing.Point(10, 64);
            this.btnShowChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowChart.Size = new System.Drawing.Size(130, 34);
            this.btnShowChart.TabIndex = 12;
            this.btnShowChart.Title = null;
            this.btnShowChart.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnShowChart_Click);
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(743, 46);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(73, 27);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "محور افقی";
            // 
            // cmbX
            // 
            this.cmbX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.cmbX.Location = new System.Drawing.Point(359, 44);
            this.cmbX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbX.Name = "cmbX";
            this.cmbX.Size = new System.Drawing.Size(378, 34);
            this.cmbX.TabIndex = 11;
            // 
            // chart1
            // 
            this.CH.AlwaysRecreateHotregions = true;
            this.CH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(186)))), ((int)(((byte)(145)))));
            this.CH.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.CH.BackGradientType = Dundas.Charting.WinControl.GradientType.TopBottom;
            this.CH.BorderLineColor = System.Drawing.Color.LightSlateGray;
            this.CH.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            this.CH.BorderSkin.FrameBackColor = System.Drawing.Color.SteelBlue;
            this.CH.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue;
            this.CH.BorderSkin.FrameBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CH.BorderSkin.FrameBorderWidth = 2;
            this.CH.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke;
            this.CH.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Light = Dundas.Charting.WinControl.LightStyle.Realistic;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.Size = 10D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            chartArea1.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            chartArea1.BorderColor = System.Drawing.Color.LightSlateGray;
            chartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            chartArea1.CursorX.UserEnabled = true;
            chartArea1.CursorX.UserSelection = true;
            chartArea1.Name = "Chart Area 1";
            chartArea1.ShadowOffset = 1;
            this.CH.ChartAreas.Add(chartArea1);
            this.CH.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Default";
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            legend2.BorderColor = System.Drawing.Color.LightSlateGray;
            legendCellColumn1.Name = "Column1";
            legendCellColumn1.Text = "#TOTAL#LEGENDTEXT";
            legend2.CellColumns.Add(legendCellColumn1);
            legend2.Name = "Legend1";
            legend2.ShadowOffset = 1;
            this.CH.Legends.Add(legend1);
            this.CH.Legends.Add(legend2);
            this.CH.Location = new System.Drawing.Point(0, 0);
            this.CH.Name = "chart1";
            this.CH.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas;
            series1.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            series1.BackGradientType = Dundas.Charting.WinControl.GradientType.TopBottom;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Name = "Series1";
            series1.PaletteCustomColors = new System.Drawing.Color[0];
            series1.SmartLabels.Enabled = true;
            series1.ToolTip = "#AXISLABEL #VAL";
            this.CH.Series.Add(series1);
            this.CH.Size = new System.Drawing.Size(831, 414);
            this.CH.TabIndex = 10;
            this.CH.Text = "chart1";
            command1.CommandType = Dundas.Charting.WinControl.ChartCommandType.SaveGroup;
            command2.CommandType = Dundas.Charting.WinControl.ChartCommandType.SaveImage;
            command2.Description = "ذخیره عکس";
            command2.Text = "ذخیره نمودار به صورت عکس";
            command1.SubCommands.Add(command2);
            command3.CommandType = Dundas.Charting.WinControl.ChartCommandType.Copy;
            command3.Description = "کپی از نمودار";
            command3.Text = "کپی نمودار";
            command4.CommandType = Dundas.Charting.WinControl.ChartCommandType.Print;
            command4.Description = "پرینت نمودار";
            command4.Text = "پرینت...";
            command5.CommandType = Dundas.Charting.WinControl.ChartCommandType.PrintPreview;
            command5.Description = "مشاهده نمودار";
            command5.Text = "مشاهده نمودار....";
            command6.CommandType = Dundas.Charting.WinControl.ChartCommandType.Toggle3DGroup;
            command7.CommandType = Dundas.Charting.WinControl.ChartCommandType.Toggle3D;
            command7.Description = "نمایش سه بعدی";
            command7.Text = "نمایش سه بعدی";
            command6.SubCommands.Add(command7);
            command8.CommandType = Dundas.Charting.WinControl.ChartCommandType.SelectChartGroup;
            command8.Description = "انتخاب نوع نمودار";
            command8.Text = "نوع نمودار";
            command9.CommandType = Dundas.Charting.WinControl.ChartCommandType.Properties;
            command9.Description = "مشخصات";
            command9.Text = "مشخصات";
            this.CH.UI.Commands.Add(command1);
            this.CH.UI.Commands.Add(command3);
            this.CH.UI.Commands.Add(command4);
            this.CH.UI.Commands.Add(command5);
            this.CH.UI.Commands.Add(command6);
            this.CH.UI.Commands.Add(command8);
            this.CH.UI.Commands.Add(command9);
            this.CH.UI.Toolbar.AllowMouseMoving = false;
            this.CH.UI.Toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(170)))), ((int)(((byte)(126)))));
            this.CH.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(147)))));
            this.CH.UI.Toolbar.BorderSkin.FrameBackColor = System.Drawing.Color.SteelBlue;
            this.CH.UI.Toolbar.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue;
            this.CH.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Gray;
            this.CH.UI.Toolbar.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            this.CH.UI.Toolbar.Enabled = true;
            commandUIItem1.CommandName = "SaveImage";
            commandUIItem2.CommandName = "Copy";
            commandUIItem3.CommandName = "Print";
            commandUIItem4.CommandName = "PrintPreview";
            commandUIItem5.CommandName = "Separator";
            commandUIItem6.CommandName = "SelectChartGroup";
            commandUIItem7.CommandName = "Toggle3D";
            commandUIItem8.CommandName = "Separator";
            commandUIItem9.CommandName = "Properties";
            this.CH.UI.Toolbar.Items.Add(commandUIItem1);
            this.CH.UI.Toolbar.Items.Add(commandUIItem2);
            this.CH.UI.Toolbar.Items.Add(commandUIItem3);
            this.CH.UI.Toolbar.Items.Add(commandUIItem4);
            this.CH.UI.Toolbar.Items.Add(commandUIItem5);
            this.CH.UI.Toolbar.Items.Add(commandUIItem6);
            this.CH.UI.Toolbar.Items.Add(commandUIItem7);
            this.CH.UI.Toolbar.Items.Add(commandUIItem8);
            this.CH.UI.Toolbar.Items.Add(commandUIItem9);
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
            this.splitContainer1.Panel1.Controls.Add(this.pnlSetting);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CH);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(831, 525);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 12;
            // 
            // frmReportChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(831, 525);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(831, 525);
            this.Name = "frmReportChart";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "مدیریت نمودار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportChart_Load);
            this.pnlSetting.ResumeLayout(false);
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CH)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.ComboBox cmbY;
        private System.Windows.Forms.Label lblY;
        private Utilize.Company.CButton btnShowChart;
        private System.Windows.Forms.ComboBox cmbX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.ComboBox cmbReport;
        private System.Windows.Forms.Label lblReport;
        private Dundas.Charting.WinControl.Chart CH;
        private System.Windows.Forms.GroupBox cGroupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}