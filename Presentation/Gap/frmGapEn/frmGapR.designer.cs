using System.Windows.Forms;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            Dundas.Charting.WinControl.ChartArea chartArea2 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend2 = new Dundas.Charting.WinControl.Legend();
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
            this.cbExcel = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.fdpStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.cmbValType = new System.Windows.Forms.ComboBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.chkAutoSize = new System.Windows.Forms.CheckBox();
            this.cmbPM = new System.Windows.Forms.ComboBox();
            this.cmbTBM = new System.Windows.Forms.ComboBox();
            this.cmbFSM = new System.Windows.Forms.ComboBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnCBM = new System.Windows.Forms.Button();
            this.btnTBM = new System.Windows.Forms.Button();
            this.btnFSM = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnModel = new System.Windows.Forms.Button();
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
            this.ctxGap.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.ctxGap.Size = new System.Drawing.Size(204, 154);
            this.ctxGap.Opening += new System.ComponentModel.CancelEventHandler(this.ctxGap_Opening);
            // 
            // tsmiDetail
            // 
            this.tsmiDetail.Name = "tsmiDetail";
            this.tsmiDetail.Size = new System.Drawing.Size(203, 24);
            this.tsmiDetail.Text = "نمایش جزييات";
            this.tsmiDetail.Click += new System.EventHandler(this.tsmiDetail_Click);
            // 
            // tsmiDetail_Delayed
            // 
            this.tsmiDetail_Delayed.Name = "tsmiDetail_Delayed";
            this.tsmiDetail_Delayed.Size = new System.Drawing.Size(203, 24);
            this.tsmiDetail_Delayed.Text = "نمایش جزئیات معلق";
            this.tsmiDetail_Delayed.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // tsmiClear
            // 
            this.tsmiClear.Name = "tsmiClear";
            this.tsmiClear.Size = new System.Drawing.Size(203, 24);
            this.tsmiClear.Text = "پاكسازی";
            this.tsmiClear.Visible = false;
            this.tsmiClear.Click += new System.EventHandler(this.tsmiClear_Click);
            // 
            // tsmiReset
            // 
            this.tsmiReset.Name = "tsmiReset";
            this.tsmiReset.Size = new System.Drawing.Size(203, 24);
            this.tsmiReset.Text = "حالت اوليه";
            this.tsmiReset.Visible = false;
            this.tsmiReset.Click += new System.EventHandler(this.tsmiReset_Click);
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.Size = new System.Drawing.Size(203, 24);
            this.tsmiPrint.Text = "چاپ";
            this.tsmiPrint.Visible = false;
            this.tsmiPrint.Click += new System.EventHandler(this.tsmiPrint_Click);
            // 
            // tsmiExport
            // 
            this.tsmiExport.Name = "tsmiExport";
            this.tsmiExport.Size = new System.Drawing.Size(203, 24);
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
            this.tcGapResoult.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tcGapResoult.Name = "tcGapResoult";
            this.tcGapResoult.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.tcGapResoult.PageBorder = Janus.Windows.UI.Tab.PageBorder.None;
            this.tcGapResoult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tcGapResoult.Size = new System.Drawing.Size(989, 246);
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
            this.tpDetail2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tpDetail2.Name = "tpDetail2";
            this.tpDetail2.Size = new System.Drawing.Size(989, 213);
            this.tpDetail2.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDetail2.StateStyles.FormatStyle.BackgroundImage")));
            this.tpDetail2.StateStyles.FormatStyle.BackgroundImageDrawMode = Janus.Windows.UI.BackgroundImageDrawMode.Center;
            this.tpDetail2.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDetail2.StateStyles.HotFormatStyle.BackgroundImage")));
            this.tpDetail2.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDetail2.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.tpDetail2.TabStop = true;
            // 
            // dgvGAP
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvGAP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGAP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGAP.BackgroundColor = System.Drawing.Color.White;
            this.dgvGAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGAP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGAP.ContextMenuStrip = this.ctxGap;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGAP.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvGAP.Location = new System.Drawing.Point(0, 0);
            this.dgvGAP.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGAP.Name = "dgvGAP";
            this.dgvGAP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGAP.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvGAP.RowHeadersWidth = 51;
            this.dgvGAP.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvGAP.RowTemplate.Height = 24;
            this.dgvGAP.Size = new System.Drawing.Size(660, 228);
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
            this.dgvGAPBM.Location = new System.Drawing.Point(11, 8);
            this.dgvGAPBM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvGAPBM.Name = "dgvGAPBM";
            this.dgvGAPBM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvGAPBM.RowHeadersWidth = 51;
            this.dgvGAPBM.RowTemplate.Height = 24;
            this.dgvGAPBM.Size = new System.Drawing.Size(913, 362);
            this.dgvGAPBM.TabIndex = 3;
            this.dgvGAPBM.Visible = false;
            // 
            // tpChart2
            // 
            this.tpChart2.Controls.Add(this.panel1);
            this.tpChart2.Location = new System.Drawing.Point(0, 33);
            this.tpChart2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tpChart2.Name = "tpChart2";
            this.tpChart2.Size = new System.Drawing.Size(989, 213);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 213);
            this.panel1.TabIndex = 5;
            // 
            // ddChart
            // 
            this.ddChart.AlwaysRecreateHotregions = true;
            this.ddChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "Default";
            this.ddChart.ChartAreas.Add(chartArea2);
            this.ddChart.Cursor = System.Windows.Forms.Cursors.Cross;
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(228)))));
            legend2.Name = "Default";
            this.ddChart.Legends.Add(legend2);
            this.ddChart.Location = new System.Drawing.Point(17, 18);
            this.ddChart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ddChart.Name = "ddChart";
            this.ddChart.Size = new System.Drawing.Size(798, 174);
            this.ddChart.TabIndex = 4;
            this.ddChart.UI.Toolbar.BackColor = System.Drawing.Color.White;
            this.ddChart.UI.Toolbar.Enabled = true;
            // 
            // chkLegend
            // 
            this.chkLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLegend.AutoSize = true;
            this.chkLegend.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkLegend.Location = new System.Drawing.Point(859, 52);
            this.chkLegend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chkLegend.Name = "chkLegend";
            this.chkLegend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLegend.Size = new System.Drawing.Size(114, 31);
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
            this.chkShowHideValue.Location = new System.Drawing.Point(857, 18);
            this.chkShowHideValue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chkShowHideValue.Name = "chkShowHideValue";
            this.chkShowHideValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkShowHideValue.Size = new System.Drawing.Size(116, 31);
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
            this.grpParam.Controls.Add(this.btnReload);
            this.grpParam.Controls.Add(this.fdpStartDate);
            this.grpParam.Controls.Add(this.cmbCurrency);
            this.grpParam.Controls.Add(this.cmbValType);
            this.grpParam.Controls.Add(this.cmbUnit);
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
            this.grpParam.Controls.Add(this.label2);
            this.grpParam.Controls.Add(this.label1);
            this.grpParam.Controls.Add(this.rdbToday);
            this.grpParam.Controls.Add(this.rdbHistoric);
            this.grpParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpParam.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpParam.Location = new System.Drawing.Point(0, 0);
            this.grpParam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpParam.Name = "grpParam";
            this.grpParam.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpParam.Size = new System.Drawing.Size(989, 184);
            this.grpParam.TabIndex = 0;
            this.grpParam.Click += new System.EventHandler(this.grpParam_Click);
            // 
            // cbExcel
            // 
            this.cbExcel.BackColor = System.Drawing.Color.Transparent;
            this.cbExcel.Location = new System.Drawing.Point(89, 145);
            this.cbExcel.Margin = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.cbExcel.Name = "cbExcel";
            this.cbExcel.Size = new System.Drawing.Size(82, 36);
            this.cbExcel.TabIndex = 138;
            this.cbExcel.Text = "Excel";
            this.cbExcel.UseVisualStyleBackColor = false;
            this.cbExcel.Click += new System.EventHandler(this.cbExcel_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReload.Location = new System.Drawing.Point(4, 145);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(65, 36);
            this.btnReload.TabIndex = 55;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click_1);
            // 
            // fdpStartDate
            // 
            this.fdpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpStartDate.Enabled = false;
            this.fdpStartDate.Font = null;
            this.fdpStartDate.Location = new System.Drawing.Point(734, 64);
            this.fdpStartDate.Name = "fdpStartDate";
            this.fdpStartDate.Size = new System.Drawing.Size(147, 25);
            this.fdpStartDate.TabIndex = 6;
            this.fdpStartDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.fdpStartDate.SelectedDateTimeChanged += new System.EventHandler(this.fdpStartDate_SelectedDateTimeChanged);
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCurrency.BackColor = System.Drawing.Color.White;
            this.cmbCurrency.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbCurrency.Location = new System.Drawing.Point(734, 114);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(145, 32);
            this.cmbCurrency.TabIndex = 61;
            // 
            // cmbValType
            // 
            this.cmbValType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbValType.BackColor = System.Drawing.Color.White;
            this.cmbValType.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbValType.Location = new System.Drawing.Point(734, 91);
            this.cmbValType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbValType.Name = "cmbValType";
            this.cmbValType.Size = new System.Drawing.Size(145, 32);
            this.cmbValType.TabIndex = 61;
            // 
            // cmbUnit
            // 
            this.cmbUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnit.BackColor = System.Drawing.Color.White;
            this.cmbUnit.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbUnit.Location = new System.Drawing.Point(322, 114);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(247, 32);
            this.cmbUnit.TabIndex = 61;
            // 
            // chkAutoSize
            // 
            this.chkAutoSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoSize.AutoSize = true;
            this.chkAutoSize.Checked = true;
            this.chkAutoSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoSize.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkAutoSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chkAutoSize.Location = new System.Drawing.Point(752, 12);
            this.chkAutoSize.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chkAutoSize.Name = "chkAutoSize";
            this.chkAutoSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAutoSize.Size = new System.Drawing.Size(121, 31);
            this.chkAutoSize.TabIndex = 1;
            this.chkAutoSize.Text = "اندازه اتوماتیك";
            this.chkAutoSize.CheckedChanged += new System.EventHandler(this.chkAutoSize_CheckedChanged);
            // 
            // cmbPM
            // 
            this.cmbPM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPM.BackColor = System.Drawing.Color.White;
            this.cmbPM.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbPM.Location = new System.Drawing.Point(322, 90);
            this.cmbPM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPM.Name = "cmbPM";
            this.cmbPM.Size = new System.Drawing.Size(247, 32);
            this.cmbPM.TabIndex = 61;
            // 
            // cmbTBM
            // 
            this.cmbTBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTBM.BackColor = System.Drawing.Color.White;
            this.cmbTBM.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbTBM.Location = new System.Drawing.Point(322, 68);
            this.cmbTBM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTBM.Name = "cmbTBM";
            this.cmbTBM.Size = new System.Drawing.Size(247, 32);
            this.cmbTBM.TabIndex = 61;
            // 
            // cmbFSM
            // 
            this.cmbFSM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFSM.BackColor = System.Drawing.Color.White;
            this.cmbFSM.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbFSM.Location = new System.Drawing.Point(322, 43);
            this.cmbFSM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFSM.Name = "cmbFSM";
            this.cmbFSM.Size = new System.Drawing.Size(247, 32);
            this.cmbFSM.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnList.Enabled = false;
            this.btnList.Location = new System.Drawing.Point(-67, 12);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(32, 21);
            this.btnList.TabIndex = 60;
            this.btnList.Visible = false;
            // 
            // btnCBM
            // 
            this.btnCBM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCBM.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCBM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCBM.Location = new System.Drawing.Point(-67, 38);
            this.btnCBM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCBM.Name = "btnCBM";
            this.btnCBM.Size = new System.Drawing.Size(13, 22);
            this.btnCBM.TabIndex = 59;
            this.btnCBM.Text = "CBM";
            this.btnCBM.UseVisualStyleBackColor = false;
            // 
            // btnTBM
            // 
            this.btnTBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTBM.Location = new System.Drawing.Point(-46, 38);
            this.btnTBM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnTBM.Name = "btnTBM";
            this.btnTBM.Size = new System.Drawing.Size(13, 22);
            this.btnTBM.TabIndex = 58;
            this.btnTBM.Visible = false;
            // 
            // btnFSM
            // 
            this.btnFSM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFSM.Location = new System.Drawing.Point(-67, 65);
            this.btnFSM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFSM.Name = "btnFSM";
            this.btnFSM.Size = new System.Drawing.Size(13, 22);
            this.btnFSM.TabIndex = 57;
            this.btnFSM.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label7.Location = new System.Drawing.Point(889, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 27);
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
            this.label6.Location = new System.Drawing.Point(889, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 27);
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
            this.label5.Location = new System.Drawing.Point(577, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 27);
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
            this.label8.Location = new System.Drawing.Point(577, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 27);
            this.label8.TabIndex = 11;
            this.label8.Text = "مدل پیش بینی";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(577, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "مدل بسته زمانی";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(577, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "مدل ترازنامه";
            // 
            // rdbToday
            // 
            this.rdbToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbToday.AutoSize = true;
            this.rdbToday.Checked = true;
            this.rdbToday.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdbToday.Location = new System.Drawing.Point(889, 12);
            this.rdbToday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbToday.Name = "rdbToday";
            this.rdbToday.Size = new System.Drawing.Size(92, 31);
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
            this.rdbHistoric.Location = new System.Drawing.Point(866, 39);
            this.rdbHistoric.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbHistoric.Name = "rdbHistoric";
            this.rdbHistoric.Size = new System.Drawing.Size(115, 31);
            this.rdbHistoric.TabIndex = 134;
            this.rdbHistoric.Text = "شکاف تاریخی";
            this.rdbHistoric.UseVisualStyleBackColor = true;
            this.rdbHistoric.CheckedChanged += new System.EventHandler(this.rdbHistoric_CheckedChanged);
            // 
            // tsModel
            // 
            this.tsModel.AutoSize = false;
            this.tsModel.BackColor = System.Drawing.Color.Transparent;
            this.tsModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsModel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsModel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsModel.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.tsModel.Size = new System.Drawing.Size(203, 29);
            this.tsModel.TabIndex = 40;
            this.tsModel.Text = "toolStrip1";
            // 
            // tsbModelNew
            // 
            this.tsbModelNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbModelNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModelNew.Name = "tsbModelNew";
            this.tsbModelNew.Size = new System.Drawing.Size(38, 26);
            this.tsbModelNew.Text = "New";
            this.tsbModelNew.ToolTipText = "مدل جديد";
            this.tsbModelNew.Click += new System.EventHandler(this.tsbModelNew_Click);
            // 
            // tsbModelEdit
            // 
            this.tsbModelEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbModelEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModelEdit.Name = "tsbModelEdit";
            this.tsbModelEdit.Size = new System.Drawing.Size(34, 26);
            this.tsbModelEdit.Text = "edit";
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
            this.tsbModelRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbModelRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModelRemove.Name = "tsbModelRemove";
            this.tsbModelRemove.Size = new System.Drawing.Size(29, 26);
            this.tsbModelRemove.Text = "del";
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
            this.tsbModelSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbModelSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModelSave.Name = "tsbModelSave";
            this.tsbModelSave.Size = new System.Drawing.Size(42, 26);
            this.tsbModelSave.Text = "Save";
            this.tsbModelSave.ToolTipText = "ذخيره مدل";
            this.tsbModelSave.Click += new System.EventHandler(this.tsbModelSave_Click);
            // 
            // tsbfinalSave
            // 
            this.tsbfinalSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbfinalSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbfinalSave.Name = "tsbfinalSave";
            this.tsbfinalSave.Size = new System.Drawing.Size(29, 4);
            this.tsbfinalSave.Text = "ذخيره نهايي";
            this.tsbfinalSave.Click += new System.EventHandler(this.tsbfinalSave_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(29, 4);
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer1.Size = new System.Drawing.Size(989, 220);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnModel
            // 
            this.btnModel.BackColor = System.Drawing.Color.Transparent;
            this.btnModel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModel.Location = new System.Drawing.Point(905, 0);
            this.btnModel.Margin = new System.Windows.Forms.Padding(4, 96, 4, 96);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(84, 31);
            this.btnModel.TabIndex = 36;
            this.btnModel.Text = "model";
            this.btnModel.UseVisualStyleBackColor = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer2.Size = new System.Drawing.Size(989, 471);
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
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer3.Size = new System.Drawing.Size(203, 471);
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
            this.lsvModel.HideSelection = false;
            this.lsvModel.Location = new System.Drawing.Point(0, 0);
            this.lsvModel.Margin = new System.Windows.Forms.Padding(4, 74, 4, 74);
            this.lsvModel.MultiSelect = false;
            this.lsvModel.Name = "lsvModel";
            this.lsvModel.Size = new System.Drawing.Size(203, 437);
            this.lsvModel.TabIndex = 9;
            this.lsvModel.UseCompatibleStateImageBehavior = false;
            this.lsvModel.SelectedIndexChanged += new System.EventHandler(this.lsvModel_SelectedIndexChanged);
            this.lsvModel.DoubleClick += new System.EventHandler(this.lsvModel_DoubleClick);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer4.Size = new System.Drawing.Size(1197, 471);
            this.splitContainer4.SplitterDistance = 203;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 47;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel files|*.xlsx";
            // 
            // frmGAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1197, 471);
            this.Controls.Add(this.splitContainer4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1035, 471);
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

         ImageList imlGAP;
         ContextMenuStrip ctxGap;
         ToolStripMenuItem tsmiDetail;
         ToolStripSeparator toolStripMenuItem1;
         ToolStripMenuItem tsmiClear;
         ToolStripMenuItem tsmiReset;
         ToolStripMenuItem tsmiPrint;
         ToolStripMenuItem tsmiExport;
         ToolTip toolTip1;
         Janus.Windows.UI.Tab.UITab tcGapResoult;
         Janus.Windows.UI.Tab.UITabPage tpDetail2;
         Janus.Windows.UI.Tab.UITabPage tpChart2;
         Dundas.Charting.WinControl.Chart ddChart;
         CheckBox chkLegend;
         CheckBox chkShowHideValue;
         CGroupBox grpParam;
         FarsiLibrary.Win.Controls.FADatePicker fdpStartDate;
         Label label7;
         Label label6;
         Label label5;
         CheckBox chkAutoSize;
         Label label2;
         Label label1;
         ToolStrip tsModel;
         ToolStripButton tsbModelNew;
         ToolStripButton tsbModelEdit;
         ToolStripSeparator toolStripSeparator1;
         ToolStripButton tsbModelRemove;
         ToolStripSeparator toolStripSeparator2;
         ToolStripButton tsbModelSave;
         ToolStripButton tsbfinalSave;
         ToolStripButton tsbRefresh;
         Button btnReload;
         Button btnList;
         Button btnCBM;
         Button btnTBM;
         Button btnFSM;
         ComboBox cmbTBM;
         ComboBox cmbFSM;
         ComboBox cmbCurrency;
         ComboBox cmbValType;
         ComboBox cmbUnit;
         Panel panel1;
         SplitContainer splitContainer1;
         Button btnModel;
         SplitContainer splitContainer2;
         SplitContainer splitContainer3;
         SplitContainer splitContainer4;
         ListView lsvModel;
         DataGridView dgvGAPBM;
         ToolStripMenuItem tsmiDetail_Delayed;
         RadioButton rdbHistoric;
         RadioButton rdbToday;
         Button cbExcel;
         DataGridView dgvGAP;
         ComboBox cmbPM;
         Label label8;
         SaveFileDialog saveFileDialog1;
    }
}
