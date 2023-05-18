using System.Windows.Forms;

namespace Presentation.CHART
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            Dundas.Charting.WinControl.ChartArea chartArea1 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend1 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Legend legend2 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Series series1 = new Dundas.Charting.WinControl.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChart = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAliasName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAxisY = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cAxisX = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cOperation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnConfChart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblYAxis = new System.Windows.Forms.Label();
            this.btnShowChart = new System.Windows.Forms.Button();
            this.chbSerries = new System.Windows.Forms.CheckedListBox();
            this.chartMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnFullScreenChart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.chart = new Dundas.Charting.WinControl.Chart();
            this.cmbYAxis1 = new System.Windows.Forms.ComboBox();
            this.cbClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.chartMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChart
            // 
            this.dgvChart.AllowUserToAddRows = false;
            this.dgvChart.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvChart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChart.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cName,
            this.cAliasName,
            this.cAxisY,
            this.cAxisX,
            this.cOperation});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChart.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChart.EnableHeadersVisualStyles = false;
            this.dgvChart.Location = new System.Drawing.Point(619, 4);
            this.dgvChart.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChart.Name = "dgvChart";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChart.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvChart.RowHeadersWidth = 51;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvChart.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvChart.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvChart.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvChart.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvChart.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvChart.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvChart.Size = new System.Drawing.Size(606, 226);
            this.dgvChart.TabIndex = 2;
            this.dgvChart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChart_CellClick);
            // 
            // cId
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(185)))), ((int)(((byte)(81)))));
            this.cId.DefaultCellStyle = dataGridViewCellStyle3;
            this.cId.HeaderText = "Id";
            this.cId.MinimumWidth = 6;
            this.cId.Name = "cId";
            this.cId.Visible = false;
            // 
            // cName
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(185)))), ((int)(((byte)(81)))));
            this.cName.DefaultCellStyle = dataGridViewCellStyle4;
            this.cName.HeaderText = "نام";
            this.cName.MinimumWidth = 6;
            this.cName.Name = "cName";
            // 
            // cAliasName
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(185)))), ((int)(((byte)(81)))));
            this.cAliasName.DefaultCellStyle = dataGridViewCellStyle5;
            this.cAliasName.HeaderText = "نام مستعار";
            this.cAliasName.MinimumWidth = 6;
            this.cAliasName.Name = "cAliasName";
            // 
            // cAxisY
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(185)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle6.NullValue = false;
            this.cAxisY.DefaultCellStyle = dataGridViewCellStyle6;
            this.cAxisY.HeaderText = "محورافقی";
            this.cAxisY.MinimumWidth = 6;
            this.cAxisY.Name = "cAxisY";
            this.cAxisY.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cAxisY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cAxisX
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(185)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle7.NullValue = false;
            this.cAxisX.DefaultCellStyle = dataGridViewCellStyle7;
            this.cAxisX.HeaderText = "محورعمودی";
            this.cAxisX.MinimumWidth = 6;
            this.cAxisX.Name = "cAxisX";
            // 
            // cOperation
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.cOperation.DefaultCellStyle = dataGridViewCellStyle8;
            this.cOperation.HeaderText = "عملیات";
            this.cOperation.Items.AddRange(new object[] {
            "",
            "SUM",
            "AVG",
            "COUNT",
            "MAX",
            "MIN"});
            this.cOperation.MinimumWidth = 45;
            this.cOperation.Name = "cOperation";
            // 
            // btnConfChart
            // 
            this.btnConfChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfChart.AutoSize = true;
            this.btnConfChart.BackColor = System.Drawing.Color.Transparent;
            this.btnConfChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.btnConfChart.Location = new System.Drawing.Point(1, 4);
            this.btnConfChart.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfChart.Name = "btnConfChart";
            this.btnConfChart.Size = new System.Drawing.Size(171, 32);
            this.btnConfChart.TabIndex = 3;
            this.btnConfChart.Text = "chart config";
            this.btnConfChart.UseVisualStyleBackColor = false;
            this.btnConfChart.Click += new System.EventHandler(this.btnConfChart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Size = new System.Drawing.Size(607, 226);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblYAxis
            // 
            this.lblYAxis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYAxis.AutoSize = true;
            this.lblYAxis.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblYAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblYAxis.Location = new System.Drawing.Point(255, 3);
            this.lblYAxis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYAxis.Name = "lblYAxis";
            this.lblYAxis.Size = new System.Drawing.Size(73, 27);
            this.lblYAxis.TabIndex = 6;
            this.lblYAxis.Text = "محور افقی";
            // 
            // btnShowChart
            // 
            this.btnShowChart.AutoSize = true;
            this.btnShowChart.BackColor = System.Drawing.Color.Transparent;
            this.btnShowChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.btnShowChart.Location = new System.Drawing.Point(4, 5);
            this.btnShowChart.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.Size = new System.Drawing.Size(180, 29);
            this.btnShowChart.TabIndex = 8;
            this.btnShowChart.Text = "show chart";
            this.btnShowChart.UseVisualStyleBackColor = false;
            this.btnShowChart.Click += new System.EventHandler(this.btnShowChart_Click_2);
            // 
            // chbSerries
            // 
            this.chbSerries.BackColor = System.Drawing.Color.White;
            this.chbSerries.CheckOnClick = true;
            this.chbSerries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbSerries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.chbSerries.FormattingEnabled = true;
            this.chbSerries.Location = new System.Drawing.Point(988, 4);
            this.chbSerries.Margin = new System.Windows.Forms.Padding(4);
            this.chbSerries.Name = "chbSerries";
            this.chbSerries.Size = new System.Drawing.Size(237, 314);
            this.chbSerries.TabIndex = 135;
            this.chbSerries.SelectedIndexChanged += new System.EventHandler(this.chbSerries_SelectedIndexChanged);
            // 
            // chartMenu
            // 
            this.chartMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.chartMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFullScreenChart,
            this.tsmiExit});
            this.chartMenu.Name = "chartMenu";
            this.chartMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chartMenu.Size = new System.Drawing.Size(238, 48);
            // 
            // btnFullScreenChart
            // 
            this.btnFullScreenChart.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullScreenChart.Name = "btnFullScreenChart";
            this.btnFullScreenChart.Size = new System.Drawing.Size(237, 22);
            this.btnFullScreenChart.Text = "نمایش تمام صفحه گزارش";
            this.btnFullScreenChart.Click += new System.EventHandler(this.btnFullScreenChart_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(237, 22);
            this.tsmiExit.Text = "خروج";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(227)))));
            this.chart.BackGradientEndColor = System.Drawing.Color.White;
            this.chart.BackGradientType = Dundas.Charting.WinControl.GradientType.TopBottom;
            this.chart.BorderSkin.FrameBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.chart.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue;
            this.chart.BorderSkin.FrameBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart.BorderSkin.FrameBorderWidth = 2;
            this.chart.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke;
            this.chart.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Light = Dundas.Charting.WinControl.LightStyle.Realistic;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelsAutoFit = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash;
            chartArea1.AxisX.ScrollBar.Size = 10D;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Format = "##,###.##";
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash;
            chartArea1.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 5;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.CursorX.UserEnabled = true;
            chartArea1.CursorX.UserSelection = true;
            chartArea1.Name = "Chart Area 1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.ContextMenuStrip = this.chartMenu;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.AutoFitText = false;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.Name = "Default";
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BorderColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(4, 4);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            this.chart.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas;
            series1.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(131)))), ((int)(((byte)(24)))));
            series1.BackGradientType = Dundas.Charting.WinControl.GradientType.VerticalCenter;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(131)))), ((int)(((byte)(24)))));
            series1.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            series1.Name = "Series1";
            series1.ShadowOffset = 2;
            series1.SmartLabels.Enabled = true;
            series1.ToolTip = "#AXISLABEL #VAL";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(976, 314);
            this.chart.TabIndex = 136;
            this.chart.UI.Toolbar.AllowMouseMoving = false;
            this.chart.UI.Toolbar.BackColor = System.Drawing.Color.Silver;
            this.chart.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chart.UI.Toolbar.BorderSkin.FrameBackColor = System.Drawing.Color.SteelBlue;
            this.chart.UI.Toolbar.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue;
            this.chart.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart.UI.Toolbar.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            this.chart.UI.Toolbar.Enabled = true;
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // cmbYAxis1
            // 
            this.cmbYAxis1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbYAxis1.BackColor = System.Drawing.Color.White;
            this.cmbYAxis1.Location = new System.Drawing.Point(4, 3);
            this.cmbYAxis1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbYAxis1.Name = "cmbYAxis1";
            this.cmbYAxis1.Size = new System.Drawing.Size(241, 24);
            this.cmbYAxis1.TabIndex = 143;
            // 
            // cbClose
            // 
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.Location = new System.Drawing.Point(13, 8);
            this.cbClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(65, 27);
            this.cbClose.TabIndex = 145;
            this.cbClose.Text = "exit";
            this.cbClose.UseVisualStyleBackColor = false;
            this.cbClose.Click += new System.EventHandler(this.cbClose_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.chart, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.chbSerries, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1229, 322);
            this.tableLayoutPanel2.TabIndex = 148;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.dgvChart, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1229, 310);
            this.tableLayoutPanel3.TabIndex = 149;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblYAxis);
            this.panel3.Controls.Add(this.cmbYAxis1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(889, 278);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 29);
            this.panel3.TabIndex = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfChart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(619, 237);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 35);
            this.panel1.TabIndex = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShowChart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(4, 237);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 35);
            this.panel2.TabIndex = 150;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(23, 39);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1229, 636);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.TabIndex = 150;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1272, 692);
            this.panel4.TabIndex = 151;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.cbClose);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1272, 40);
            this.panel5.TabIndex = 152;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(1107, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "نمایش گزارش";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(185)))), ((int)(((byte)(81)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(185)))), ((int)(((byte)(81)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn2.HeaderText = "نام";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 76;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(185)))), ((int)(((byte)(81)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn3.HeaderText = "نام مستعار";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 76;
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1272, 732);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmChart";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "نمودار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.chartMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
         DataGridView dgvChart;
         Button btnConfChart;
         DataGridView dataGridView1;
         Label lblYAxis;
         Button btnShowChart;
         CheckedListBox chbSerries;
         ContextMenuStrip chartMenu;
         ToolStripMenuItem btnFullScreenChart;
         ToolStripMenuItem tsmiExit;
         Dundas.Charting.WinControl.Chart chart;
         ComboBox cmbYAxis1;
         Button cbClose;
         TableLayoutPanel tableLayoutPanel2;
         TableLayoutPanel tableLayoutPanel3;
         Panel panel3;
         Panel panel1;
         Panel panel2;
         SplitContainer splitContainer1;
         Panel panel4;
         Panel panel5;
         Label label2;
         DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
         DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
         DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
         DataGridViewTextBoxColumn cId;
         DataGridViewTextBoxColumn cName;
         DataGridViewTextBoxColumn cAliasName;
         DataGridViewCheckBoxColumn cAxisY;
         DataGridViewCheckBoxColumn cAxisX;
         DataGridViewComboBoxColumn cOperation;
    }
}