namespace Presentation.Public
{
    partial class frmChart
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
            Dundas.Charting.WinControl.ChartArea chartArea1 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend1 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Legend legend2 = new Dundas.Charting.WinControl.Legend();
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChart));
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.lblColumn = new System.Windows.Forms.Label();
            this.chart = new Dundas.Charting.WinControl.Chart();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.cbClose = new Utilize.Company.CButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColumn
            // 
            this.lblColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColumn.AutoSize = true;
            this.lblColumn.BackColor = System.Drawing.Color.Transparent;
            this.lblColumn.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblColumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblColumn.Location = new System.Drawing.Point(826, 10);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(37, 20);
            this.lblColumn.TabIndex = 138;
            this.lblColumn.Text = "نمودار";
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.chart.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(186)))), ((int)(((byte)(145)))));
            this.chart.BackGradientType = Dundas.Charting.WinControl.GradientType.TopBottom;
            this.chart.BorderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(147)))));
            this.chart.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            this.chart.BorderSkin.FrameBackColor = System.Drawing.Color.SteelBlue;
            this.chart.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue;
            this.chart.BorderSkin.FrameBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart.BorderSkin.FrameBorderWidth = 2;
            this.chart.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke;
            this.chart.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Light = Dundas.Charting.WinControl.LightStyle.Realistic;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelsAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.Size = 10D;
            chartArea1.AxisY.LabelsAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.Format = "##,###.##";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 5;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            chartArea1.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            chartArea1.BorderColor = System.Drawing.Color.LightSlateGray;
            chartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            chartArea1.CursorX.UserEnabled = true;
            chartArea1.CursorX.UserSelection = true;
            chartArea1.Name = "Chart Area 1";
            chartArea1.ShadowOffset = 1;
            this.chart.ChartAreas.Add(chartArea1);
            legend1.AutoFitText = false;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.Name = "Default";
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            legend2.BorderColor = System.Drawing.Color.LightSlateGray;
            legend2.Name = "Legend1";
            legend2.ShadowOffset = 1;
            this.chart.Legends.Add(legend1);
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas;
            series1.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            series1.BackGradientType = Dundas.Charting.WinControl.GradientType.TopBottom;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Name = "Series1";
            series1.SmartLabels.Enabled = true;
            series1.ToolTip = "#AXISLABEL #VAL";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(895, 668);
            this.chart.TabIndex = 137;
            this.chart.Text = "chart1";
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
            this.chart.UI.Commands.Add(command1);
            this.chart.UI.Commands.Add(command3);
            this.chart.UI.Commands.Add(command4);
            this.chart.UI.Commands.Add(command5);
            this.chart.UI.Commands.Add(command6);
            this.chart.UI.Commands.Add(command8);
            this.chart.UI.Commands.Add(command9);
            this.chart.UI.Toolbar.AllowMouseMoving = false;
            this.chart.UI.Toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(170)))), ((int)(((byte)(126)))));
            this.chart.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(147)))));
            this.chart.UI.Toolbar.BorderSkin.FrameBackColor = System.Drawing.Color.SteelBlue;
            this.chart.UI.Toolbar.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue;
            this.chart.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart.UI.Toolbar.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            this.chart.UI.Toolbar.Enabled = true;
            commandUIItem1.CommandName = "SaveImage";
            commandUIItem2.CommandName = "Copy";
            commandUIItem3.CommandName = "Print";
            commandUIItem4.CommandName = "PrintPreview";
            commandUIItem5.CommandName = "Separator";
            commandUIItem6.CommandName = "SelectChartGroup";
            commandUIItem7.CommandName = "Toggle3D";
            commandUIItem8.CommandName = "Separator";
            commandUIItem9.CommandName = "Properties";
            this.chart.UI.Toolbar.Items.Add(commandUIItem1);
            this.chart.UI.Toolbar.Items.Add(commandUIItem2);
            this.chart.UI.Toolbar.Items.Add(commandUIItem3);
            this.chart.UI.Toolbar.Items.Add(commandUIItem4);
            this.chart.UI.Toolbar.Items.Add(commandUIItem5);
            this.chart.UI.Toolbar.Items.Add(commandUIItem6);
            this.chart.UI.Toolbar.Items.Add(commandUIItem7);
            this.chart.UI.Toolbar.Items.Add(commandUIItem8);
            this.chart.UI.Toolbar.Items.Add(commandUIItem9);
            // 
            // cmbItem
            // 
            this.cmbItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            appearance1.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbItem.AutoSize = false;
            this.cmbItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            appearance2.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance3.BorderColor = System.Drawing.Color.Transparent;
            this.cmbItem.Location = new System.Drawing.Point(580, 7);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(230, 24);
            this.cmbItem.TabIndex = 140;
            // 
            // cbClose
            // 
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(15, 9);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(29, 28);
            this.cbClose.TabIndex = 141;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(820, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 33);
            this.label1.TabIndex = 138;
            this.label1.Text = "نمودار";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblColumn);
            this.panel1.Controls.Add(this.cmbItem);
            this.panel1.Controls.Add(this.chart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 668);
            this.panel1.TabIndex = 142;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 43);
            this.panel2.TabIndex = 142;
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChart";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "نمودار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblColumn;
        private Dundas.Charting.WinControl.Chart chart;
        private System.Windows.Forms.ComboBox cmbItem;
        private Utilize.Company.CButton cbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}