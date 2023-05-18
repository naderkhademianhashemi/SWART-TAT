namespace Presentation.Loan
{
    partial class frmHistorCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoricalLoanReport));
            Dundas.Charting.WinControl.ChartArea chartArea1 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend1 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Legend legend2 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Series series1 = new Dundas.Charting.WinControl.Series();
            this.gbFormulaType = new System.Windows.Forms.GroupBox();
            this.cbContractStatus = new System.Windows.Forms.ComboBox();
            this.lblResoult = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chart = new Dundas.Charting.WinControl.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnFullScreenShow = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCounterparty = new System.Windows.Forms.TextBox();
            this.txtCounterPartyName = new System.Windows.Forms.TextBox();
            this.txtContractNo = new System.Windows.Forms.TextBox();
            this.txtContractName = new System.Windows.Forms.TextBox();
            this.gbStateBranch = new System.Windows.Forms.GroupBox();
            this.ucfState = new Utilize.Report.UCFilteringMini();
            this.ucfOrganization = new Utilize.Report.UCFilteringMini();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.rbStateBranch = new System.Windows.Forms.RadioButton();
            this.rbContract = new System.Windows.Forms.RadioButton();
            this.rbCounterparty = new System.Windows.Forms.RadioButton();
            this.chbSerries = new System.Windows.Forms.CheckedListBox();
            this.btnShowReport = new Utilize.Company.CButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gbFormulaType)).BeginInit();
            this.gbFormulaType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbContractStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterparty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterPartyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbStateBranch)).BeginInit();
            this.gbStateBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbSetting)).BeginInit();
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
            this.gbFormulaType.BackColor = System.Drawing.Color.Transparent;
            this.gbFormulaType.Controls.Add(this.cbContractStatus);
            this.gbFormulaType.Controls.Add(this.lblResoult);
            this.gbFormulaType.Controls.Add(this.radioButton2);
            this.gbFormulaType.Controls.Add(this.radioButton1);
            this.gbFormulaType.Controls.Add(this.label1);
            this.gbFormulaType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFormulaType.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbFormulaType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.gbFormulaType.Location = new System.Drawing.Point(0, 0);
            this.gbFormulaType.Name = "gbFormulaType";
            this.gbFormulaType.Padding = new System.Windows.Forms.Padding(3);
            this.gbFormulaType.Size = new System.Drawing.Size(380, 93);
            this.gbFormulaType.TabIndex = 129;
            this.gbFormulaType.Text = "نمودار";
            this.gbFormulaType.Visible = false;
            // 
            // cbContractStatus
            // 
            this.cbContractStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbContractStatus.AutoSize = false;
            this.cbContractStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.cbContractStatus.Location = new System.Drawing.Point(48, 15);
            this.cbContractStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbContractStatus.Name = "cbContractStatus";
            this.cbContractStatus.Size = new System.Drawing.Size(241, 17);
            this.cbContractStatus.TabIndex = 133;
            // 
            // lblResoult
            // 
            this.lblResoult.AutoSize = true;
            this.lblResoult.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResoult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblResoult.Location = new System.Drawing.Point(295, 44);
            this.lblResoult.Name = "lblResoult";
            this.lblResoult.Size = new System.Drawing.Size(59, 20);
            this.lblResoult.TabIndex = 132;
            this.lblResoult.Text = "نوع گزارش";
            this.lblResoult.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.radioButton2.Location = new System.Drawing.Point(241, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 24);
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
            this.radioButton1.Location = new System.Drawing.Point(238, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 24);
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
            this.label1.Location = new System.Drawing.Point(295, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 130;
            this.label1.Text = "وضعیت قرارداد";
            this.label1.Visible = false;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(186)))), ((int)(((byte)(145)))));
            this.chart.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.chart.BackGradientType = Dundas.Charting.WinControl.GradientType.TopBottom;
            this.chart.BorderLineColor = System.Drawing.Color.Empty;
            this.chart.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            this.chart.BorderSkin.FrameBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.chart.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue;
            this.chart.BorderSkin.FrameBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart.BorderSkin.FrameBorderWidth = 2;
            this.chart.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke;
            this.chart.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Light = Dundas.Charting.WinControl.LightStyle.Realistic;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelsAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            chartArea1.AxisX.LabelStyle.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.Size = 10D;
            chartArea1.AxisY.LabelsAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            chartArea1.AxisY.LabelStyle.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            chartArea1.AxisY.LabelStyle.Format = "##,###.##";
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea1.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 5;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            chartArea1.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            chartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            chartArea1.CursorX.UserEnabled = true;
            chartArea1.CursorX.UserSelection = true;
            chartArea1.Name = "Chart Area 1";
            chartArea1.ShadowOffset = 1;
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.ContextMenuStrip = this.contextMenuStrip1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.AutoFitText = false;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            legend1.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            legend1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            legend1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            legend1.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            legend1.Name = "Default";
            legend2.AutoFitText = false;
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            legend2.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(194)))));
            legend2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            legend2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            legend2.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            legend2.Name = "Legend1";
            legend2.ShadowOffset = 1;
            this.chart.Legends.Add(legend1);
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas;
            series1.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(131)))), ((int)(((byte)(24)))));
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(131)))), ((int)(((byte)(24)))));
            series1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            series1.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            series1.Name = "Series1";
            series1.SmartLabels.Enabled = true;
            series1.ToolTip = "#AXISLABEL #VAL";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(611, 223);
            this.chart.TabIndex = 138;
            this.chart.Text = "chart1";
            this.chart.UI.Toolbar.AllowMouseMoving = false;
            this.chart.UI.Toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(170)))), ((int)(((byte)(126)))));
            this.chart.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(188)))), ((int)(((byte)(147)))));
            this.chart.UI.Toolbar.BorderSkin.FrameBackColor = System.Drawing.Color.SteelBlue;
            this.chart.UI.Toolbar.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue;
            this.chart.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart.UI.Toolbar.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            this.chart.UI.Toolbar.Enabled = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFullScreenShow});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 32);
            // 
            // btnFullScreenShow
            // 
            this.btnFullScreenShow.Image = global::Presentation.Properties.Resources.full_screen_icon;
            this.btnFullScreenShow.Name = "btnFullScreenShow";
            this.btnFullScreenShow.Size = new System.Drawing.Size(208, 28);
            this.btnFullScreenShow.Text = "نمایش تمام صفحه گزارش";
            this.btnFullScreenShow.Click += new System.EventHandler(this.btnFullScreenChart_Click);
            // 
            // txtCounterparty
            // 
            this.txtCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterparty.Enabled = false;
            this.txtCounterparty.Location = new System.Drawing.Point(160, 125);
            this.txtCounterparty.Name = "txtCounterparty";
            this.txtCounterparty.Size = new System.Drawing.Size(137, 30);
            this.txtCounterparty.TabIndex = 134;
            // 
            // txtCounterPartyName
            // 
            this.txtCounterPartyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterPartyName.Location = new System.Drawing.Point(6, 125);
            this.txtCounterPartyName.Name = "txtCounterPartyName";
            this.txtCounterPartyName.ReadOnly = true;
            this.txtCounterPartyName.Size = new System.Drawing.Size(144, 30);
            this.txtCounterPartyName.TabIndex = 135;
            // 
            // txtContractNo
            // 
            this.txtContractNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContractNo.Enabled = false;
            this.txtContractNo.Location = new System.Drawing.Point(160, 158);
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.Size = new System.Drawing.Size(137, 30);
            this.txtContractNo.TabIndex = 137;
            // 
            // txtContractName
            // 
            this.txtContractName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContractName.Location = new System.Drawing.Point(6, 158);
            this.txtContractName.Name = "txtContractName";
            this.txtContractName.ReadOnly = true;
            this.txtContractName.Size = new System.Drawing.Size(144, 30);
            this.txtContractName.TabIndex = 138;
            // 
            // gbStateBranch
            // 
            this.gbStateBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStateBranch.BackColor = System.Drawing.Color.Transparent;
            this.gbStateBranch.Controls.Add(this.ucfState);
            this.gbStateBranch.Controls.Add(this.ucfOrganization);
            this.gbStateBranch.Location = new System.Drawing.Point(6, 12);
            this.gbStateBranch.Name = "gbStateBranch";
            this.gbStateBranch.Padding = new System.Windows.Forms.Padding(3);
            this.gbStateBranch.Size = new System.Drawing.Size(365, 101);
            this.gbStateBranch.TabIndex = 140;
            // 
            // ucfState
            // 
            this.ucfState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucfState.BackColor = System.Drawing.Color.Transparent;
            this.ucfState.DataSource = null;
            this.ucfState.DisplayMember = null;
            this.ucfState.EnableShowClearSelectedItem = true;
            this.ucfState.EnableShowSelectedItem = true;
            this.ucfState.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfState.IsPersian = false;
            this.ucfState.Location = new System.Drawing.Point(6, 10);
            this.ucfState.Name = "ucfState";
            this.ucfState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfState.Size = new System.Drawing.Size(353, 37);
            this.ucfState.TabIndex = 127;
            this.ucfState.Title = "استان";
            this.ucfState.ValueMember = null;
            this.ucfState.CheckedChanged += new System.EventHandler(this.ucfState_CheckedChanged);
            // 
            // ucfOrganization
            // 
            this.ucfOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucfOrganization.BackColor = System.Drawing.Color.Transparent;
            this.ucfOrganization.DataSource = null;
            this.ucfOrganization.DisplayMember = null;
            this.ucfOrganization.EnableShowClearSelectedItem = true;
            this.ucfOrganization.EnableShowSelectedItem = true;
            this.ucfOrganization.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucfOrganization.IsPersian = false;
            this.ucfOrganization.Location = new System.Drawing.Point(6, 53);
            this.ucfOrganization.Name = "ucfOrganization";
            this.ucfOrganization.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfOrganization.Size = new System.Drawing.Size(353, 37);
            this.ucfOrganization.TabIndex = 128;
            this.ucfOrganization.Title = "شعبه";
            this.ucfOrganization.ValueMember = null;
            this.ucfOrganization.DropDownOpening += new System.EventHandler(this.ucfOrganization_DropDownOpening);
            // 
            // gbSetting
            // 
            this.gbSetting.BackColor = System.Drawing.Color.Transparent;
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
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Padding = new System.Windows.Forms.Padding(3);
            this.gbSetting.Size = new System.Drawing.Size(400, 233);
            this.gbSetting.TabIndex = 0;
            this.gbSetting.Text = "فیلتر بندی";
            // 
            // rbStateBranch
            // 
            this.rbStateBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbStateBranch.AutoSize = true;
            this.rbStateBranch.Checked = true;
            this.rbStateBranch.Location = new System.Drawing.Point(377, 22);
            this.rbStateBranch.Name = "rbStateBranch";
            this.rbStateBranch.Size = new System.Drawing.Size(14, 13);
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
            this.rbContract.Location = new System.Drawing.Point(303, 158);
            this.rbContract.Name = "rbContract";
            this.rbContract.Size = new System.Drawing.Size(91, 24);
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
            this.rbCounterparty.Location = new System.Drawing.Point(334, 125);
            this.rbCounterparty.Name = "rbCounterparty";
            this.rbCounterparty.Size = new System.Drawing.Size(60, 24);
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
            this.chbSerries.Name = "chbSerries";
            this.chbSerries.Size = new System.Drawing.Size(169, 223);
            this.chbSerries.TabIndex = 136;
            this.chbSerries.SelectedIndexChanged += new System.EventHandler(this.chbSerries_SelectedIndexChanged);
            // 
            // btnShowReport
            // 
            this.btnShowReport.AutoSize = true;
            this.btnShowReport.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnShowReport.DefaultImage")));
            this.btnShowReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowReport.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnShowReport.HoverImage")));
            this.btnShowReport.Location = new System.Drawing.Point(12, 152);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowReport.Size = new System.Drawing.Size(141, 29);
            this.btnShowReport.TabIndex = 133;
            this.btnShowReport.Title = null;
            this.btnShowReport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnShowReport_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chbSerries);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(784, 223);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 139;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.splitContainer2.Size = new System.Drawing.Size(784, 233);
            this.splitContainer2.SplitterDistance = 400;
            this.splitContainer2.TabIndex = 140;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.splitContainer3.Size = new System.Drawing.Size(784, 459);
            this.splitContainer3.SplitterDistance = 233;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 141;
            // 
            // frmHistoricalLoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(784, 459);
            this.Controls.Add(this.splitContainer3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHistoricalLoanReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "گزارش تاریخی قردادها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gbFormulaType)).EndInit();
            this.gbFormulaType.ResumeLayout(false);
            this.gbFormulaType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbContractStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterparty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterPartyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbStateBranch)).EndInit();
            this.gbStateBranch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbSetting)).EndInit();
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
        private Dundas.Charting.WinControl.Chart chart;
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