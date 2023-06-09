using Utilize.Company;

namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmGAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGAP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Dundas.Charting.WinControl.ChartArea chartArea1 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend1 = new Dundas.Charting.WinControl.Legend();
             appearance7 = new ();
             appearance8 = new ();
             appearance9 = new ();
             appearance40 = new ();
             appearance41 = new ();
             appearance42 = new ();
             appearance4 = new ();
             appearance13 = new ();
             appearance6 = new ();
             appearance37 = new ();
             appearance38 = new ();
             appearance39 = new ();
             appearance52 = new ();
             appearance53 = new ();
             appearance54 = new ();
             appearance5 = new ();
             appearance10 = new ();
             appearance11 = new ();
             appearance16 = new ();
             appearance17 = new ();
             appearance18 = new ();
             appearance49 = new ();
             appearance50 = new ();
             appearance51 = new ();
            this.ctxGap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetail_Delayed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExport = new System.Windows.Forms.ToolStripMenuItem();
            this.imlGAP = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tcGapResoult = new Janus.Windows.UI.Tab.UITab();
            this.tpDetail2 = new Janus.Windows.UI.Tab.UITabPage();
            this.dgvGAP = new System.Windows.Forms.DataGridView();
            this.dgvGAPBM = new System.Windows.Forms.DataGridView();
            this.tpChart2 = new Janus.Windows.UI.Tab.UITabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddChart = new Dundas.Charting.WinControl.Chart();
            this.chkLegend = new System.Windows.Forms.CheckBox();
            this.chkShowHideValue = new System.Windows.Forms.CheckBox();
            this.grpParam = new Utilize.Company.CGroupBox();
            this.cbExcel = new Button();
            this.chkCurrencyMarketValue = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDesretionType = new System.Windows.Forms.Label();
            this.cmbLimitValue = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLimit = new System.Windows.Forms.ComboBox();
            this.chkDescreteGapAnalisys = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnReload = new Button();
            this.fdpStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.cmbValType = new System.Windows.Forms.ComboBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.chkIrr = new System.Windows.Forms.CheckBox();
            this.chkCounterpartyType = new System.Windows.Forms.CheckBox();
            this.chkAutoSize = new System.Windows.Forms.CheckBox();
            this.cmbPM = new System.Windows.Forms.ComboBox();
            this.cmbTBM = new System.Windows.Forms.ComboBox();
            this.cmbFSM = new System.Windows.Forms.ComboBox();
            this.btnList = new Button();
            this.btnCBM = new Button();
            this.btnTBM = new Button();
            this.btnFSM = new Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkColor = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGAPFullScr = new Button();
            this.ucfOrganization = new Utilize.Report.UCFilteringMini();
            this.rdbToday = new System.Windows.Forms.RadioButton();
            this.rdbHistoric = new System.Windows.Forms.RadioButton();
            this.tsModel = new System.Windows.Forms.ToolStrip();
            this.tsbModelNew = new System.Windows.Forms.ToolStripButton();
            this.tsbModelEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModelRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModelSave = new System.Windows.Forms.ToolStripButton();
            this.tsbfinalSave = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnModel = new Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lsvModel = new System.Windows.Forms.ListView();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ctxGap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcGapResoult)).BeginInit();
            this.tcGapResoult.SuspendLayout();
            this.tpDetail2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGAPBM)).BeginInit();
            this.tpChart2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpParam)).BeginInit();
            this.grpParam.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLimitValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbValType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFSM)).BeginInit();
            this.tsModel.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxGap
            // 
            this.ctxGap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDetail,
            this.tsmiDetail_Delayed,
            this.toolStripMenuItem1,
            this.tsmiClear,
            this.tsmiReset,
            this.tsmiPrint,
            this.tsmiExport});
            this.ctxGap.Name = "ctxGap";
            this.ctxGap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctxGap.Size = new System.Drawing.Size(160, 142);
            this.ctxGap.Opening += new System.ComponentModel.CancelEventHandler(this.ctxGap_Opening);
            // 
            // tsmiDetail
            // 
            this.tsmiDetail.Name = "tsmiDetail";
            this.tsmiDetail.Size = new System.Drawing.Size(159, 22);
            this.tsmiDetail.Text = "نمایش جزييات";
            this.tsmiDetail.Click += new System.EventHandler(this.tsmiDetail_Click);
            // 
            // tsmiDetail_Delayed
            // 
            this.tsmiDetail_Delayed.Name = "tsmiDetail_Delayed";
            this.tsmiDetail_Delayed.Size = new System.Drawing.Size(159, 22);
            this.tsmiDetail_Delayed.Text = "نمایش جزئیات معلق";
            this.tsmiDetail_Delayed.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 6);
            // 
            // tsmiClear
            // 
            this.tsmiClear.Name = "tsmiClear";
            this.tsmiClear.Size = new System.Drawing.Size(159, 22);
            this.tsmiClear.Text = "پاكسازی";
            this.tsmiClear.Visible = false;
            this.tsmiClear.Click += new System.EventHandler(this.tsmiClear_Click);
            // 
            // tsmiReset
            // 
            this.tsmiReset.Name = "tsmiReset";
            this.tsmiReset.Size = new System.Drawing.Size(159, 22);
            this.tsmiReset.Text = "حالت اوليه";
            this.tsmiReset.Visible = false;
            this.tsmiReset.Click += new System.EventHandler(this.tsmiReset_Click);
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.Size = new System.Drawing.Size(159, 22);
            this.tsmiPrint.Text = "چاپ";
            this.tsmiPrint.Visible = false;
            this.tsmiPrint.Click += new System.EventHandler(this.tsmiPrint_Click);
            // 
            // tsmiExport
            // 
            this.tsmiExport.Name = "tsmiExport";
            this.tsmiExport.Size = new System.Drawing.Size(159, 22);
            this.tsmiExport.Text = "خروجی";
            this.tsmiExport.Visible = false;
            this.tsmiExport.Click += new System.EventHandler(this.tsmiExport_Click);
            // 
            // imlGAP
            // 
            this.imlGAP.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlGAP.ImageStream")));
            this.imlGAP.TransparentColor = System.Drawing.Color.Transparent;
            this.imlGAP.Images.SetKeyName(0, "New.gif");
            this.imlGAP.Images.SetKeyName(1, "Empty.png");
            // 
            // tcGapResoult
            // 
            this.tcGapResoult.BackColor = System.Drawing.Color.White;
            this.tcGapResoult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcGapResoult.FlatBorderColor = System.Drawing.Color.White;
            this.tcGapResoult.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tcGapResoult.ItemSize = new System.Drawing.Size(66, 31);
            this.tcGapResoult.Location = new System.Drawing.Point(0, 0);
            this.tcGapResoult.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tcGapResoult.Name = "tcGapResoult";
            this.tcGapResoult.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.tcGapResoult.PageBorder = Janus.Windows.UI.Tab.PageBorder.None;
            this.tcGapResoult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tcGapResoult.Size = new System.Drawing.Size(741, 275);
            this.tcGapResoult.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcGapResoult.TabDisplay = Janus.Windows.UI.Tab.TabDisplay.Image;
            this.tcGapResoult.TabIndex = 43;
            this.tcGapResoult.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.tpDetail2,
            this.tpChart2});
            this.tcGapResoult.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.Transparent;
            this.tcGapResoult.TabsStateStyles.SelectedFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tcGapResoult.TabStripFormatStyle.BackColor = System.Drawing.Color.White;
            this.tcGapResoult.UseThemes = false;
            // 
            // tpDetail2
            // 
            this.tpDetail2.Controls.Add(this.dgvGAP);
            this.tpDetail2.Controls.Add(this.dgvGAPBM);
            this.tpDetail2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tpDetail2.Location = new System.Drawing.Point(0, 33);
            this.tpDetail2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tpDetail2.Name = "tpDetail2";
            this.tpDetail2.Size = new System.Drawing.Size(741, 242);
            this.tpDetail2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDetail2.StateStyles.FormatStyle.BackgroundImage")));
            this.tpDetail2.StateStyles.FormatStyle.BackgroundImageDrawMode = Janus.Windows.UI.BackgroundImageDrawMode.Center;
            this.tpDetail2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDetail2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.tpDetail2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDetail2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.tpDetail2.TabStop = true;
            // 
            // dgvGAP
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvGAP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGAP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGAP.BackgroundColor = System.Drawing.Color.White;
            this.dgvGAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGAP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGAP.ContextMenuStrip = this.ctxGap;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGAP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGAP.Location = new System.Drawing.Point(0, 0);
            this.dgvGAP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvGAP.Name = "dgvGAP";
            this.dgvGAP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGAP.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGAP.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvGAP.RowTemplate.Height = 24;
            this.dgvGAP.Size = new System.Drawing.Size(741, 242);
            this.dgvGAP.TabIndex = 2;
            this.dgvGAP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGAP_CellFormatting);
            this.dgvGAP.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGAP_CellMouseDown);
            this.dgvGAP.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvGAP_CellPainting);
            // 
            // dgvGAPBM
            // 
            this.dgvGAPBM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.dgvGAPBM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGAPBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGAPBM.Location = new System.Drawing.Point(8, 8);
            this.dgvGAPBM.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dgvGAPBM.Name = "dgvGAPBM";
            this.dgvGAPBM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvGAPBM.RowTemplate.Height = 24;
            this.dgvGAPBM.Size = new System.Drawing.Size(685, 385);
            this.dgvGAPBM.TabIndex = 3;
            this.dgvGAPBM.Visible = false;
            // 
            // tpChart2
            // 
            this.tpChart2.Controls.Add(this.panel1);
            this.tpChart2.Location = new System.Drawing.Point(0, 33);
            this.tpChart2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tpChart2.Name = "tpChart2";
            this.tpChart2.Size = new System.Drawing.Size(741, 242);
            this.tpChart2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpChart2.StateStyles.FormatStyle.BackgroundImage")));
            this.tpChart2.StateStyles.FormatStyle.BackgroundImageDrawMode = Janus.Windows.UI.BackgroundImageDrawMode.Center;
            this.tpChart2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpChart2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.tpChart2.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Transparent;
            this.tpChart2.StateStyles.SelectedFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.Transparent;
            this.tpChart2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpChart2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.tpChart2.TabStop = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ddChart);
            this.panel1.Controls.Add(this.chkLegend);
            this.panel1.Controls.Add(this.chkShowHideValue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 242);
            this.panel1.TabIndex = 5;
            // 
            // ddChart
            // 
            this.ddChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "Default";
            this.ddChart.ChartAreas.Add(chartArea1);
            this.ddChart.Cursor = System.Windows.Forms.Cursors.Cross;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(228)))));
            legend1.Name = "Default";
            this.ddChart.Legends.Add(legend1);
            this.ddChart.Location = new System.Drawing.Point(13, 19);
            this.ddChart.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ddChart.Name = "ddChart";
            this.ddChart.Size = new System.Drawing.Size(598, 201);
            this.ddChart.TabIndex = 4;
            this.ddChart.UI.Toolbar.BackColor = System.Drawing.Color.White;
            this.ddChart.UI.Toolbar.Enabled = true;
            // 
            // chkLegend
            // 
            this.chkLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLegend.AutoSize = true;
            this.chkLegend.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkLegend.Location = new System.Drawing.Point(638, 55);
            this.chkLegend.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.chkLegend.Name = "chkLegend";
            this.chkLegend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLegend.Size = new System.Drawing.Size(91, 24);
            this.chkLegend.TabIndex = 3;
            this.chkLegend.Text = " نمایش راهنما";
            this.chkLegend.UseVisualStyleBackColor = true;
            this.chkLegend.CheckedChanged += new System.EventHandler(this.chkLegend_CheckedChanged);
            // 
            // chkShowHideValue
            // 
            this.chkShowHideValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowHideValue.AutoSize = true;
            this.chkShowHideValue.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkShowHideValue.Location = new System.Drawing.Point(639, 19);
            this.chkShowHideValue.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.chkShowHideValue.Name = "chkShowHideValue";
            this.chkShowHideValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkShowHideValue.Size = new System.Drawing.Size(90, 24);
            this.chkShowHideValue.TabIndex = 2;
            this.chkShowHideValue.Text = " نمایش مقادیر";
            this.chkShowHideValue.UseVisualStyleBackColor = true;
            this.chkShowHideValue.CheckedChanged += new System.EventHandler(this.chkShowHideValue_CheckedChanged);
            // 
            // grpParam
            // 
            this.grpParam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.grpParam.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.grpParam.Controls.Add(this.cbExcel);
            this.grpParam.Controls.Add(this.chkCurrencyMarketValue);
            this.grpParam.Controls.Add(this.panel2);
            this.grpParam.Controls.Add(this.tableLayoutPanel1);
            this.grpParam.Controls.Add(this.chkDescreteGapAnalisys);
            this.grpParam.Controls.Add(this.chkAll);
            this.grpParam.Controls.Add(this.btnReload);
            this.grpParam.Controls.Add(this.fdpStartDate);
            this.grpParam.Controls.Add(this.dtpStartDate);
            this.grpParam.Controls.Add(this.cmbCurrency);
            this.grpParam.Controls.Add(this.cmbValType);
            this.grpParam.Controls.Add(this.cmbUnit);
            this.grpParam.Controls.Add(this.chkIrr);
            this.grpParam.Controls.Add(this.chkCounterpartyType);
            this.grpParam.Controls.Add(this.chkAutoSize);
            this.grpParam.Controls.Add(this.cmbPM);
            this.grpParam.Controls.Add(this.cmbTBM);
            this.grpParam.Controls.Add(this.cmbFSM);
            this.grpParam.Controls.Add(this.btnList);
            this.grpParam.Controls.Add(this.btnCBM);
            this.grpParam.Controls.Add(this.btnTBM);
            this.grpParam.Controls.Add(this.btnFSM);
            this.grpParam.Controls.Add(this.label7);
            this.grpParam.Controls.Add(this.label6);
            this.grpParam.Controls.Add(this.label5);
            this.grpParam.Controls.Add(this.label8);
            this.grpParam.Controls.Add(this.chkColor);
            this.grpParam.Controls.Add(this.label2);
            this.grpParam.Controls.Add(this.label1);
            this.grpParam.Controls.Add(this.btnGAPFullScr);
            this.grpParam.Controls.Add(this.ucfOrganization);
            this.grpParam.Controls.Add(this.rdbToday);
            this.grpParam.Controls.Add(this.rdbHistoric);
            this.grpParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpParam.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpParam.Location = new System.Drawing.Point(0, 0);
            this.grpParam.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.grpParam.Name = "grpParam";
            this.grpParam.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.grpParam.Size = new System.Drawing.Size(741, 184);
            this.grpParam.TabIndex = 0;
            this.grpParam.Click += new System.EventHandler(this.grpParam_Click);
            // 
            // cbExcel
            // 
            this.cbExcel.BackColor = System.Drawing.Color.Transparent;
            this.cbExcel.DefaultImage = global::Presentation.Properties.Resources.ExcelExport;
            this.cbExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbExcel.HoverImage = global::Presentation.Properties.Resources.ExcelExport_hover;
            this.cbExcel.Location = new System.Drawing.Point(36, 148);
            this.cbExcel.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.cbExcel.Name = "cbExcel";
            this.cbExcel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbExcel.Size = new System.Drawing.Size(34, 26);
            this.cbExcel.TabIndex = 138;
            this.cbExcel.Title = null;
            this.cbExcel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbExcel_CButtonClicked);
            this.cbExcel.Click += new System.EventHandler(this.cbExcel_Click);
            // 
            // chkCurrencyMarketValue
            // 
            this.chkCurrencyMarketValue.AutoSize = true;
            this.chkCurrencyMarketValue.Enabled = false;
            this.chkCurrencyMarketValue.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkCurrencyMarketValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chkCurrencyMarketValue.Location = new System.Drawing.Point(550, 143);
            this.chkCurrencyMarketValue.Name = "chkCurrencyMarketValue";
            this.chkCurrencyMarketValue.Size = new System.Drawing.Size(119, 23);
            this.chkCurrencyMarketValue.TabIndex = 135;
            this.chkCurrencyMarketValue.Text = "محاسبه با نرخ ارز بازار";
            this.chkCurrencyMarketValue.UseVisualStyleBackColor = true;
            this.chkCurrencyMarketValue.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(147, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 25);
            this.panel2.TabIndex = 133;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.62745F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.37255F));
            this.tableLayoutPanel1.Controls.Add(this.lblDesretionType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbLimitValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbLimit, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 41);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(189, 62);
            this.tableLayoutPanel1.TabIndex = 131;
            this.tableLayoutPanel1.Visible = false;
            // 
            // lblDesretionType
            // 
            this.lblDesretionType.AutoSize = true;
            this.lblDesretionType.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDesretionType.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDesretionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblDesretionType.Location = new System.Drawing.Point(138, 31);
            this.lblDesretionType.Name = "lblDesretionType";
            this.lblDesretionType.Size = new System.Drawing.Size(27, 31);
            this.lblDesretionType.TabIndex = 63;
            this.lblDesretionType.Text = "---";
            // 
            // cmbLimitValue
            // 
            this.cmbLimitValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance7.BackColor = System.Drawing.Color.White;
            appearance7.BackColor2 = System.Drawing.Color.White;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance7.BorderColor = System.Drawing.Color.Silver;
            appearance7.ImageBackground = global::Presentation.Properties.Resources.combobox1;
            appearance7.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbLimitValue.Appearance = appearance7;
            this.cmbLimitValue.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbLimitValue.AutoSize = false;
            this.cmbLimitValue.BackColor = System.Drawing.Color.White;
            appearance8.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.ImageBackground = global::Presentation.Properties.Resources.compoDown1;
            appearance8.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbLimitValue.ButtonAppearance = appearance8;
            this.cmbLimitValue.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbLimitValue.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbLimitValue.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbLimitValue.Enabled = false;
            this.cmbLimitValue.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbLimitValue.HideSelection = false;
            appearance9.BackColor = System.Drawing.Color.White;
            appearance9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance9.BorderColor = System.Drawing.Color.Silver;
            this.cmbLimitValue.ItemAppearance = appearance9;
            this.cmbLimitValue.Location = new System.Drawing.Point(3, 36);
            this.cmbLimitValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbLimitValue.Name = "cmbLimitValue";
            this.cmbLimitValue.Size = new System.Drawing.Size(129, 20);
            this.cmbLimitValue.TabIndex = 61;
            this.cmbLimitValue.SelectionChanged += new System.EventHandler(this.cmbLimitValue_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label3.Location = new System.Drawing.Point(138, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 31);
            this.label3.TabIndex = 62;
            this.label3.Text = "نوع تفکیک";
            // 
            // cmbLimit
            // 
            this.cmbLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance40.BackColor = System.Drawing.Color.White;
            appearance40.BackColor2 = System.Drawing.Color.White;
            appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance40.BorderColor = System.Drawing.Color.Silver;
            appearance40.ImageBackground = global::Presentation.Properties.Resources.combobox1;
            appearance40.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbLimit.Appearance = appearance40;
            this.cmbLimit.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbLimit.AutoSize = false;
            this.cmbLimit.BackColor = System.Drawing.Color.White;
            appearance41.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance41.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance41.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance41.ImageBackground = global::Presentation.Properties.Resources.compoDown1;
            appearance41.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbLimit.ButtonAppearance = appearance41;
            this.cmbLimit.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbLimit.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbLimit.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbLimit.Enabled = false;
            this.cmbLimit.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbLimit.HideSelection = false;
            appearance42.BackColor = System.Drawing.Color.White;
            appearance42.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance42.BorderColor = System.Drawing.Color.Silver;
            this.cmbLimit.ItemAppearance = appearance42;
            this.cmbLimit.Location = new System.Drawing.Point(3, 5);
            this.cmbLimit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbLimit.Name = "cmbLimit";
            this.cmbLimit.Size = new System.Drawing.Size(129, 21);
            this.cmbLimit.TabIndex = 0;
            this.cmbLimit.SelectionChanged += new System.EventHandler(this.cmbLimit_SelectedIndexChanged);
            // 
            // chkDescreteGapAnalisys
            // 
            this.chkDescreteGapAnalisys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDescreteGapAnalisys.AutoSize = true;
            this.chkDescreteGapAnalisys.BackColor = System.Drawing.Color.Transparent;
            this.chkDescreteGapAnalisys.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkDescreteGapAnalisys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chkDescreteGapAnalisys.Location = new System.Drawing.Point(182, 12);
            this.chkDescreteGapAnalisys.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.chkDescreteGapAnalisys.Name = "chkDescreteGapAnalisys";
            this.chkDescreteGapAnalisys.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDescreteGapAnalisys.Size = new System.Drawing.Size(128, 24);
            this.chkDescreteGapAnalisys.TabIndex = 5;
            this.chkDescreteGapAnalisys.Text = "تحلیل شکاف تفکیکی";
            this.chkDescreteGapAnalisys.UseVisualStyleBackColor = false;
            this.chkDescreteGapAnalisys.Visible = false;
            this.chkDescreteGapAnalisys.CheckedChanged += new System.EventHandler(this.chkDescreteGapAnalisys_CheckedChanged);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.BackColor = System.Drawing.Color.Transparent;
            this.chkAll.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chkAll.Location = new System.Drawing.Point(8, 92);
            this.chkAll.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.chkAll.Name = "chkAll";
            this.chkAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAll.Size = new System.Drawing.Size(46, 24);
            this.chkAll.TabIndex = 47;
            this.chkAll.Text = "همه";
            this.chkAll.UseVisualStyleBackColor = false;
            this.chkAll.Visible = false;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckStateChanged);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReload.DefaultImage = global::Presentation.Properties.Resources.S_RefreshL;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload.HoverImage = global::Presentation.Properties.Resources.S_RefreshL_hover;
            this.btnReload.Location = new System.Drawing.Point(3, 142);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.Size = new System.Drawing.Size(28, 38);
            this.btnReload.TabIndex = 55;
            this.btnReload.Title = null;
            this.btnReload.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnReload_Click);
            // 
            // fdpStartDate
            // 
            this.fdpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpStartDate.Enabled = false;
            this.fdpStartDate.Font = null;
            this.fdpStartDate.Location = new System.Drawing.Point(550, 68);
            this.fdpStartDate.Name = "fdpStartDate";
            this.fdpStartDate.Size = new System.Drawing.Size(110, 27);
            this.fdpStartDate.TabIndex = 6;
            this.fdpStartDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.CustomFormat = "dd / MM / yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(550, 42);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(84, 21);
            this.dtpStartDate.TabIndex = 131;
            this.dtpStartDate.Visible = false;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance4.BackColor = System.Drawing.Color.White;
            appearance4.BackColor2 = System.Drawing.Color.White;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance4.BorderColor = System.Drawing.Color.Silver;
            appearance4.ImageBackground = global::Presentation.Properties.Resources.combobox1;
            appearance4.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbCurrency.Appearance = appearance4;
            this.cmbCurrency.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbCurrency.AutoSize = false;
            this.cmbCurrency.BackColor = System.Drawing.Color.White;
            appearance13.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance13.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance13.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance13.ImageBackground = global::Presentation.Properties.Resources.compoDown1;
            appearance13.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbCurrency.ButtonAppearance = appearance13;
            this.cmbCurrency.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbCurrency.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbCurrency.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbCurrency.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbCurrency.HideSelection = false;
            appearance6.BackColor = System.Drawing.Color.White;
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance6.BorderColor = System.Drawing.Color.Silver;
            this.cmbCurrency.ItemAppearance = appearance6;
            this.cmbCurrency.Location = new System.Drawing.Point(550, 121);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(110, 22);
            this.cmbCurrency.TabIndex = 61;
            this.cmbCurrency.SelectionChanged += new System.EventHandler(this.cmbCurrency_SelectionChanged);
            // 
            // cmbValType
            // 
            this.cmbValType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance37.BackColor = System.Drawing.Color.White;
            appearance37.BackColor2 = System.Drawing.Color.White;
            appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance37.BorderColor = System.Drawing.Color.Silver;
            appearance37.ImageBackground = global::Presentation.Properties.Resources.combobox2;
            appearance37.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbValType.Appearance = appearance37;
            this.cmbValType.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbValType.AutoSize = false;
            this.cmbValType.BackColor = System.Drawing.Color.White;
            appearance38.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance38.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance38.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance38.ImageBackground = global::Presentation.Properties.Resources.compoDown;
            appearance38.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbValType.ButtonAppearance = appearance38;
            this.cmbValType.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbValType.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbValType.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbValType.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbValType.HideSelection = false;
            appearance39.BackColor = System.Drawing.Color.White;
            appearance39.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance39.BorderColor = System.Drawing.Color.Silver;
            this.cmbValType.ItemAppearance = appearance39;
            this.cmbValType.Location = new System.Drawing.Point(550, 97);
            this.cmbValType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbValType.Name = "cmbValType";
            this.cmbValType.Size = new System.Drawing.Size(110, 22);
            this.cmbValType.TabIndex = 61;
            // 
            // cmbUnit
            // 
            this.cmbUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance52.BackColor = System.Drawing.Color.White;
            appearance52.BackColor2 = System.Drawing.Color.White;
            appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance52.BorderColor = System.Drawing.Color.Silver;
            appearance52.ImageBackground = global::Presentation.Properties.Resources.combobox1;
            appearance52.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbUnit.Appearance = appearance52;
            this.cmbUnit.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbUnit.AutoSize = false;
            this.cmbUnit.BackColor = System.Drawing.Color.White;
            appearance53.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance53.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance53.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance53.ImageBackground = global::Presentation.Properties.Resources.compoDown1;
            appearance53.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbUnit.ButtonAppearance = appearance53;
            this.cmbUnit.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbUnit.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbUnit.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbUnit.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbUnit.HideSelection = false;
            appearance54.BackColor = System.Drawing.Color.White;
            appearance54.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance54.BorderColor = System.Drawing.Color.Silver;
            this.cmbUnit.ItemAppearance = appearance54;
            this.cmbUnit.Location = new System.Drawing.Point(241, 121);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(186, 22);
            this.cmbUnit.TabIndex = 61;
            this.cmbUnit.SelectionChanged += new System.EventHandler(this.cmbUnit_SelectedIndexChanged);
            // 
            // chkIrr
            // 
            this.chkIrr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIrr.AutoSize = true;
            this.chkIrr.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkIrr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chkIrr.Location = new System.Drawing.Point(314, 13);
            this.chkIrr.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.chkIrr.Name = "chkIrr";
            this.chkIrr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkIrr.Size = new System.Drawing.Size(109, 24);
            this.chkIrr.TabIndex = 5;
            this.chkIrr.Text = "نمایش اقلام بی اثر";
            this.chkIrr.UseVisualStyleBackColor = true;
            this.chkIrr.Visible = false;
            this.chkIrr.CheckedChanged += new System.EventHandler(this.chkIrr_CheckedChanged);
            // 
            // chkCounterpartyType
            // 
            this.chkCounterpartyType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCounterpartyType.AutoSize = true;
            this.chkCounterpartyType.Checked = true;
            this.chkCounterpartyType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCounterpartyType.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkCounterpartyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chkCounterpartyType.Location = new System.Drawing.Point(435, 12);
            this.chkCounterpartyType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.chkCounterpartyType.Name = "chkCounterpartyType";
            this.chkCounterpartyType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCounterpartyType.Size = new System.Drawing.Size(116, 24);
            this.chkCounterpartyType.TabIndex = 4;
            this.chkCounterpartyType.Text = "تفکیک نوع مشتری";
            this.chkCounterpartyType.Visible = false;
            this.chkCounterpartyType.CheckedChanged += new System.EventHandler(this.chkAutoSize_CheckedChanged);
            // 
            // chkAutoSize
            // 
            this.chkAutoSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoSize.AutoSize = true;
            this.chkAutoSize.Checked = true;
            this.chkAutoSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoSize.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkAutoSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chkAutoSize.Location = new System.Drawing.Point(557, 13);
            this.chkAutoSize.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.chkAutoSize.Name = "chkAutoSize";
            this.chkAutoSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAutoSize.Size = new System.Drawing.Size(97, 24);
            this.chkAutoSize.TabIndex = 1;
            this.chkAutoSize.Text = "اندازه اتوماتیك";
            this.chkAutoSize.CheckedChanged += new System.EventHandler(this.chkAutoSize_CheckedChanged);
            // 
            // cmbPM
            // 
            this.cmbPM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance5.BackColor = System.Drawing.Color.White;
            appearance5.BackColor2 = System.Drawing.Color.White;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance5.BorderColor = System.Drawing.Color.Silver;
            appearance5.ImageBackground = global::Presentation.Properties.Resources.combobox1;
            appearance5.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbPM.Appearance = appearance5;
            this.cmbPM.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbPM.AutoSize = false;
            this.cmbPM.BackColor = System.Drawing.Color.White;
            appearance10.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance10.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance10.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance10.ImageBackground = global::Presentation.Properties.Resources.compoDown1;
            appearance10.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbPM.ButtonAppearance = appearance10;
            this.cmbPM.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbPM.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbPM.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbPM.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbPM.HideSelection = false;
            appearance11.BackColor = System.Drawing.Color.White;
            appearance11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.cmbPM.ItemAppearance = appearance11;
            this.cmbPM.Location = new System.Drawing.Point(241, 96);
            this.cmbPM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbPM.Name = "cmbPM";
            this.cmbPM.Size = new System.Drawing.Size(186, 22);
            this.cmbPM.TabIndex = 61;
            // 
            // cmbTBM
            // 
            this.cmbTBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance16.BackColor = System.Drawing.Color.White;
            appearance16.BackColor2 = System.Drawing.Color.White;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance16.BorderColor = System.Drawing.Color.Silver;
            appearance16.ImageBackground = global::Presentation.Properties.Resources.combobox1;
            appearance16.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbTBM.Appearance = appearance16;
            this.cmbTBM.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbTBM.AutoSize = false;
            this.cmbTBM.BackColor = System.Drawing.Color.White;
            appearance17.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance17.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance17.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance17.ImageBackground = global::Presentation.Properties.Resources.compoDown;
            appearance17.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbTBM.ButtonAppearance = appearance17;
            this.cmbTBM.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbTBM.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbTBM.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbTBM.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbTBM.HideSelection = false;
            appearance18.BackColor = System.Drawing.Color.White;
            appearance18.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance18.BorderColor = System.Drawing.Color.Silver;
            this.cmbTBM.ItemAppearance = appearance18;
            this.cmbTBM.Location = new System.Drawing.Point(241, 72);
            this.cmbTBM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbTBM.Name = "cmbTBM";
            this.cmbTBM.Size = new System.Drawing.Size(186, 22);
            this.cmbTBM.TabIndex = 61;
            // 
            // cmbFSM
            // 
            this.cmbFSM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance49.BackColor = System.Drawing.Color.White;
            appearance49.BackColor2 = System.Drawing.Color.White;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance49.BorderColor = System.Drawing.Color.Silver;
            appearance49.ImageBackground = global::Presentation.Properties.Resources.combobox1;
            appearance49.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbFSM.Appearance = appearance49;
            this.cmbFSM.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbFSM.AutoSize = false;
            this.cmbFSM.BackColor = System.Drawing.Color.White;
            appearance50.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance50.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance50.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance50.ImageBackground = global::Presentation.Properties.Resources.compoDown;
            appearance50.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbFSM.ButtonAppearance = appearance50;
            this.cmbFSM.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbFSM.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbFSM.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbFSM.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbFSM.HideSelection = false;
            appearance51.BackColor = System.Drawing.Color.White;
            appearance51.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance51.BorderColor = System.Drawing.Color.Silver;
            this.cmbFSM.ItemAppearance = appearance51;
            this.cmbFSM.Location = new System.Drawing.Point(241, 46);
            this.cmbFSM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbFSM.Name = "cmbFSM";
            this.cmbFSM.Size = new System.Drawing.Size(186, 22);
            this.cmbFSM.TabIndex = 0;
            this.cmbFSM.ValueChanged += new System.EventHandler(this.cmbFSM_ValueChanged);
            // 
            // btnList
            // 
            this.btnList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnList.DefaultImage = global::Presentation.Properties.Resources.S_3dot;
            this.btnList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnList.Enabled = false;
            this.btnList.HoverImage = global::Presentation.Properties.Resources.S_3dot_Hover;
            this.btnList.Location = new System.Drawing.Point(-51, 13);
            this.btnList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnList.Name = "btnList";
            this.btnList.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnList.Size = new System.Drawing.Size(24, 22);
            this.btnList.TabIndex = 60;
            this.btnList.Title = null;
            this.btnList.Visible = false;
            this.btnList.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnList_Click);
            // 
            // btnCBM
            // 
            this.btnCBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCBM.DefaultImage = global::Presentation.Properties.Resources.S_3dot;
            this.btnCBM.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCBM.HoverImage = global::Presentation.Properties.Resources.S_3dot_Hover;
            this.btnCBM.Location = new System.Drawing.Point(-51, 40);
            this.btnCBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCBM.Name = "btnCBM";
            this.btnCBM.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCBM.Size = new System.Drawing.Size(10, 23);
            this.btnCBM.TabIndex = 59;
            this.btnCBM.Title = null;
            this.btnCBM.Visible = false;
            this.btnCBM.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnCBM_Click);
            // 
            // btnTBM
            // 
            this.btnTBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTBM.DefaultImage = global::Presentation.Properties.Resources.S_3dot;
            this.btnTBM.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTBM.HoverImage = global::Presentation.Properties.Resources.S_3dot_Hover;
            this.btnTBM.Location = new System.Drawing.Point(-35, 40);
            this.btnTBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTBM.Name = "btnTBM";
            this.btnTBM.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTBM.Size = new System.Drawing.Size(10, 23);
            this.btnTBM.TabIndex = 58;
            this.btnTBM.Title = null;
            this.btnTBM.Visible = false;
            this.btnTBM.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnTBM_Click);
            // 
            // btnFSM
            // 
            this.btnFSM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFSM.DefaultImage = global::Presentation.Properties.Resources.S_3dot;
            this.btnFSM.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFSM.HoverImage = global::Presentation.Properties.Resources.S_3dot_Hover;
            this.btnFSM.Location = new System.Drawing.Point(-51, 69);
            this.btnFSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFSM.Name = "btnFSM";
            this.btnFSM.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFSM.Size = new System.Drawing.Size(10, 23);
            this.btnFSM.TabIndex = 57;
            this.btnFSM.Title = null;
            this.btnFSM.Visible = false;
            this.btnFSM.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnFSM_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label7.Location = new System.Drawing.Point(666, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "نمایش";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label6.Location = new System.Drawing.Point(666, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "ارز";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label5.Location = new System.Drawing.Point(432, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "واحد";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label8.Location = new System.Drawing.Point(432, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "مدل پیش بینی";
            // 
            // chkColor
            // 
            this.chkColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkColor.AutoSize = true;
            this.chkColor.Checked = true;
            this.chkColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColor.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chkColor.Location = new System.Drawing.Point(-1, 16);
            this.chkColor.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.chkColor.Name = "chkColor";
            this.chkColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkColor.Size = new System.Drawing.Size(82, 23);
            this.chkColor.TabIndex = 23;
            this.chkColor.Text = "Coloring";
            this.chkColor.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(432, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "مدل بسته زمانی";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(432, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "مدل ترازنامه";
            // 
            // btnGAPFullScr
            // 
            this.btnGAPFullScr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGAPFullScr.DefaultImage = global::Presentation.Properties.Resources.S_Wide;
            this.btnGAPFullScr.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGAPFullScr.HoverImage = global::Presentation.Properties.Resources.S_Wide_hover;
            this.btnGAPFullScr.Location = new System.Drawing.Point(94, 143);
            this.btnGAPFullScr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGAPFullScr.Name = "btnGAPFullScr";
            this.btnGAPFullScr.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGAPFullScr.Size = new System.Drawing.Size(36, 40);
            this.btnGAPFullScr.TabIndex = 56;
            this.btnGAPFullScr.Title = null;
            this.btnGAPFullScr.Visible = false;
            this.btnGAPFullScr.CButtonClicked += new System.EventHandler<System.EventArgs>(this.Btn_GAP_FullScr_Click);
            // 
            // ucfOrganization
            // 
            this.ucfOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucfOrganization.BackColor = System.Drawing.Color.Transparent;
            this.ucfOrganization.DataSource = null;
            this.ucfOrganization.DisplayMember = null;
            this.ucfOrganization.Enabled = false;
            this.ucfOrganization.EnableShowClearSelectedItem = false;
            this.ucfOrganization.EnableShowSelectedItem = false;
            this.ucfOrganization.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ucfOrganization.IsPersian = false;
            this.ucfOrganization.Location = new System.Drawing.Point(-1, 107);
            this.ucfOrganization.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucfOrganization.Name = "ucfOrganization";
            this.ucfOrganization.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucfOrganization.Size = new System.Drawing.Size(224, 49);
            this.ucfOrganization.TabIndex = 130;
            this.ucfOrganization.Title = "شعبه";
            this.ucfOrganization.ValueMember = null;
            this.ucfOrganization.Visible = false;
            // 
            // rdbToday
            // 
            this.rdbToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbToday.AutoSize = true;
            this.rdbToday.Checked = true;
            this.rdbToday.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdbToday.Location = new System.Drawing.Point(660, 13);
            this.rdbToday.Name = "rdbToday";
            this.rdbToday.Size = new System.Drawing.Size(75, 27);
            this.rdbToday.TabIndex = 0;
            this.rdbToday.TabStop = true;
            this.rdbToday.Text = "شکاف روز";
            this.rdbToday.UseVisualStyleBackColor = true;
            // 
            // rdbHistoric
            // 
            this.rdbHistoric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbHistoric.AutoSize = true;
            this.rdbHistoric.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbHistoric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdbHistoric.Location = new System.Drawing.Point(640, 41);
            this.rdbHistoric.Name = "rdbHistoric";
            this.rdbHistoric.Size = new System.Drawing.Size(95, 27);
            this.rdbHistoric.TabIndex = 134;
            this.rdbHistoric.Text = "شکاف تاریخی";
            this.rdbHistoric.UseVisualStyleBackColor = true;
            this.rdbHistoric.CheckedChanged += new System.EventHandler(this.rdbHistoric_CheckedChanged);
            // 
            // tsModel
            // 
            this.tsModel.AutoSize = false;
            this.tsModel.BackColor = System.Drawing.Color.Transparent;
            this.tsModel.BackgroundImage = global::Presentation.Properties.Resources.S_Head;
            this.tsModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsModel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsModel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsModel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbModelNew,
            this.tsbModelEdit,
            this.toolStripSeparator1,
            this.tsbModelRemove,
            this.toolStripSeparator2,
            this.tsbModelSave,
            this.tsbfinalSave,
            this.tsbRefresh});
            this.tsModel.Location = new System.Drawing.Point(0, 0);
            this.tsModel.Name = "tsModel";
            this.tsModel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsModel.Size = new System.Drawing.Size(153, 29);
            this.tsModel.TabIndex = 40;
            this.tsModel.Text = "toolStrip1";
            // 
            // tsbModelNew
            // 
            this.tsbModelNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelNew.Image = global::Presentation.Properties.Resources.S_NewForm;
            this.tsbModelNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModelNew.Name = "tsbModelNew";
            this.tsbModelNew.Size = new System.Drawing.Size(23, 26);
            this.tsbModelNew.ToolTipText = "مدل جديد";
            this.tsbModelNew.Click += new System.EventHandler(this.tsbModelNew_Click);
            // 
            // tsbModelEdit
            // 
            this.tsbModelEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelEdit.Image = global::Presentation.Properties.Resources.S_EditForm;
            this.tsbModelEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModelEdit.Name = "tsbModelEdit";
            this.tsbModelEdit.Size = new System.Drawing.Size(24, 26);
            this.tsbModelEdit.Text = "toolStripButton3";
            this.tsbModelEdit.ToolTipText = "ويرايش مدل";
            this.tsbModelEdit.Click += new System.EventHandler(this.tsbModelEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbModelRemove
            // 
            this.tsbModelRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelRemove.Image = global::Presentation.Properties.Resources.S_DeleteForm;
            this.tsbModelRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModelRemove.Name = "tsbModelRemove";
            this.tsbModelRemove.Size = new System.Drawing.Size(23, 26);
            this.tsbModelRemove.Text = "toolStripButton4";
            this.tsbModelRemove.ToolTipText = "حذف مدل";
            this.tsbModelRemove.Click += new System.EventHandler(this.tsbModelRemove_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbModelSave
            // 
            this.tsbModelSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModelSave.Image = global::Presentation.Properties.Resources.S_Save;
            this.tsbModelSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModelSave.Name = "tsbModelSave";
            this.tsbModelSave.Size = new System.Drawing.Size(23, 26);
            this.tsbModelSave.Text = "Save";
            this.tsbModelSave.ToolTipText = "ذخيره مدل";
            this.tsbModelSave.Click += new System.EventHandler(this.tsbModelSave_Click);
            // 
            // tsbfinalSave
            // 
            this.tsbfinalSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbfinalSave.Image = global::Presentation.Properties.Resources.S_SaveHistory;
            this.tsbfinalSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbfinalSave.Name = "tsbfinalSave";
            this.tsbfinalSave.Size = new System.Drawing.Size(23, 26);
            this.tsbfinalSave.Text = "ذخيره نهايي";
            this.tsbfinalSave.Click += new System.EventHandler(this.tsbfinalSave_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::Presentation.Properties.Resources.S_Refresh;
            this.tsbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 26);
            this.tsbRefresh.Text = "toolStripButton1";
            this.tsbRefresh.ToolTipText = "تازه سازی";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnModel);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel1.DoubleClick += new System.EventHandler(this.splitContainer1_Panel1_DoubleClick);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpParam);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(741, 220);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnModel
            // 
            this.btnModel.BackColor = System.Drawing.Color.Transparent;
            this.btnModel.DefaultImage = global::Presentation.Properties.Resources.S_PanRight4;
            this.btnModel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModel.HoverImage = global::Presentation.Properties.Resources.S_PanRight_Hover;
            this.btnModel.Location = new System.Drawing.Point(706, 0);
            this.btnModel.Margin = new System.Windows.Forms.Padding(3, 102, 3, 102);
            this.btnModel.Name = "btnModel";
            this.btnModel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModel.Size = new System.Drawing.Size(35, 31);
            this.btnModel.TabIndex = 36;
            this.btnModel.Title = null;
            this.btnModel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnModel_CButtonClicked);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tcGapResoult);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(741, 500);
            this.splitContainer2.SplitterDistance = 220;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 45;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tsModel);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lsvModel);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(153, 500);
            this.splitContainer3.SplitterDistance = 29;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 46;
            // 
            // lsvModel
            // 
            this.lsvModel.BackColor = System.Drawing.SystemColors.Control;
            this.lsvModel.BackgroundImageTiled = true;
            this.lsvModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvModel.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lsvModel.Location = new System.Drawing.Point(0, 0);
            this.lsvModel.Margin = new System.Windows.Forms.Padding(3, 79, 3, 79);
            this.lsvModel.MultiSelect = false;
            this.lsvModel.Name = "lsvModel";
            this.lsvModel.Size = new System.Drawing.Size(153, 466);
            this.lsvModel.TabIndex = 9;
            this.lsvModel.UseCompatibleStateImageBehavior = false;
            this.lsvModel.SelectedIndexChanged += new System.EventHandler(this.lsvModel_SelectedIndexChanged);
            this.lsvModel.DoubleClick += new System.EventHandler(this.lsvModel_DoubleClick);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer4_Panel1_Paint);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Size = new System.Drawing.Size(898, 500);
            this.splitContainer4.SplitterDistance = 153;
            this.splitContainer4.TabIndex = 47;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel files|*.xlsx";
            // 
            // frmGAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(898, 500);
            this.Controls.Add(this.splitContainer4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(776, 500);
            this.Name = "frmGAP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "  تحلیل شكاف     ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGAP_FormClosing);
            this.Load += new System.EventHandler(this.frmGAP_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGAP_KeyDown);
            this.ctxGap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcGapResoult)).EndInit();
            this.tcGapResoult.ResumeLayout(false);
            this.tpDetail2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGAPBM)).EndInit();
            this.tpChart2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpParam)).EndInit();
            this.grpParam.ResumeLayout(false);
            this.grpParam.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLimitValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbValType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFSM)).EndInit();
            this.tsModel.ResumeLayout(false);
            this.tsModel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imlGAP;
        private System.Windows.Forms.ContextMenuStrip ctxGap;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClear;
        private System.Windows.Forms.ToolStripMenuItem tsmiReset;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
        private System.Windows.Forms.ToolStripMenuItem tsmiExport;
        private System.Windows.Forms.ToolTip toolTip1;
        private Janus.Windows.UI.Tab.UITab tcGapResoult;
        private Janus.Windows.UI.Tab.UITabPage tpDetail2;
        private Janus.Windows.UI.Tab.UITabPage tpChart2;
        private Dundas.Charting.WinControl.Chart ddChart;
        private System.Windows.Forms.CheckBox chkLegend;
        private System.Windows.Forms.CheckBox chkShowHideValue;
        private CGroupBox grpParam;
        private FarsiLibrary.Win.Controls.FADatePicker fdpStartDate;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAutoSize;
        private System.Windows.Forms.CheckBox chkColor;
        private System.Windows.Forms.CheckBox chkDescreteGapAnalisys;
        private System.Windows.Forms.CheckBox chkIrr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsModel;
        private System.Windows.Forms.ToolStripButton tsbModelNew;
        private System.Windows.Forms.ToolStripButton tsbModelEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbModelRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbModelSave;
        private System.Windows.Forms.ToolStripButton tsbfinalSave;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private CButton btnReload;
        private CButton btnGAPFullScr;
        private CButton btnList;
        private CButton btnCBM;
        private CButton btnTBM;
        private CButton btnFSM;
        private CComboCox cmbLimitValue;
        private CComboCox cmbLimit;
        private CComboCox cmbTBM;
        private CComboCox cmbFSM;
        private CComboCox cmbCurrency;
        private CComboCox cmbValType;
        private CComboCox cmbUnit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private CButton btnModel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListView lsvModel;
        private System.Windows.Forms.Label label3;
        private Utilize.Report.UCFilteringMini ucfOrganization;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDesretionType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvGAPBM;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetail_Delayed;
        private System.Windows.Forms.RadioButton rdbHistoric;
        private System.Windows.Forms.RadioButton rdbToday;
        private System.Windows.Forms.CheckBox chkCurrencyMarketValue;
        private CButton cbExcel;
        private System.Windows.Forms.DataGridView dgvGAP;
        private CComboCox cmbPM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkCounterpartyType;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
