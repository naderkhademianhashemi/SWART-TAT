namespace Presentation.Capital_Adequacy
{
    partial class frmCapitalAdequacy
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbCalculate = new Utilize.Company.CButton();
            this.fdpDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.cgbRiskBalancedAsset = new Utilize.Company.CGroupBox();
            this.lblRiskAsset = new System.Windows.Forms.Label();
            this.lblOpAsset = new System.Windows.Forms.Label();
            this.lblMarketAsset = new System.Windows.Forms.Label();
            this.lblCreditAsset = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cgbSupervisionCapital = new Utilize.Company.CGroupBox();
            this.lblSCapital = new System.Windows.Forms.Label();
            this.lblLayer2 = new System.Windows.Forms.Label();
            this.lbllayer1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cgbCapitalAdequacy = new Utilize.Company.CGroupBox();
            this.lblCapitalAdequacy = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.cgbRiskBalancedAsset)).BeginInit();
            this.cgbRiskBalancedAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgbSupervisionCapital)).BeginInit();
            this.cgbSupervisionCapital.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCapitalAdequacy)).BeginInit();
            this.cgbCapitalAdequacy.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbCalculate);
            this.splitContainer1.Panel1.Controls.Add(this.fdpDate);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(918, 497);
            this.splitContainer1.SplitterDistance = 62;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbCalculate
            // 
            this.cbCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCalculate.DefaultImage = global::Presentation.Properties.Resources.S_But100px;
            this.cbCalculate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbCalculate.ForeColor = System.Drawing.Color.Black;
            this.cbCalculate.HoverImage = global::Presentation.Properties.Resources.S_But100px_Hover;
            this.cbCalculate.Location = new System.Drawing.Point(575, 12);
            this.cbCalculate.Margin = new System.Windows.Forms.Padding(11, 18, 11, 18);
            this.cbCalculate.Name = "cbCalculate";
            this.cbCalculate.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCalculate.Size = new System.Drawing.Size(107, 38);
            this.cbCalculate.TabIndex = 153;
            this.cbCalculate.Title = "محاسبه کفایت سرمایه";
            this.cbCalculate.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbCalculate_CButtonClicked);
            // 
            // fdpDate
            // 
            this.fdpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpDate.Font = null;
            this.fdpDate.IsDefault = true;
            this.fdpDate.Location = new System.Drawing.Point(718, 18);
            this.fdpDate.Name = "fdpDate";
            this.fdpDate.Size = new System.Drawing.Size(130, 27);
            this.fdpDate.TabIndex = 150;
            this.fdpDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(864, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاریخ";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.cgbCapitalAdequacy);
            this.splitContainer2.Size = new System.Drawing.Size(918, 431);
            this.splitContainer2.SplitterDistance = 226;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.cgbRiskBalancedAsset);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.cgbSupervisionCapital);
            this.splitContainer3.Size = new System.Drawing.Size(918, 226);
            this.splitContainer3.SplitterDistance = 510;
            this.splitContainer3.TabIndex = 0;
            // 
            // cgbRiskBalancedAsset
            // 
            this.cgbRiskBalancedAsset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbRiskBalancedAsset.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbRiskBalancedAsset.Controls.Add(this.lblRiskAsset);
            this.cgbRiskBalancedAsset.Controls.Add(this.lblOpAsset);
            this.cgbRiskBalancedAsset.Controls.Add(this.lblMarketAsset);
            this.cgbRiskBalancedAsset.Controls.Add(this.lblCreditAsset);
            this.cgbRiskBalancedAsset.Controls.Add(this.label8);
            this.cgbRiskBalancedAsset.Controls.Add(this.label5);
            this.cgbRiskBalancedAsset.Controls.Add(this.label6);
            this.cgbRiskBalancedAsset.Controls.Add(this.label7);
            this.cgbRiskBalancedAsset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cgbRiskBalancedAsset.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cgbRiskBalancedAsset.Location = new System.Drawing.Point(0, 0);
            this.cgbRiskBalancedAsset.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.cgbRiskBalancedAsset.Name = "cgbRiskBalancedAsset";
            this.cgbRiskBalancedAsset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cgbRiskBalancedAsset.Size = new System.Drawing.Size(510, 226);
            this.cgbRiskBalancedAsset.TabIndex = 133;
            this.cgbRiskBalancedAsset.Text = "دارایی های موزون شده به ریسک";
            // 
            // lblRiskAsset
            // 
            this.lblRiskAsset.AutoSize = true;
            this.lblRiskAsset.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRiskAsset.Location = new System.Drawing.Point(39, 143);
            this.lblRiskAsset.Name = "lblRiskAsset";
            this.lblRiskAsset.Size = new System.Drawing.Size(17, 24);
            this.lblRiskAsset.TabIndex = 9;
            this.lblRiskAsset.Text = "-";
            // 
            // lblOpAsset
            // 
            this.lblOpAsset.AutoSize = true;
            this.lblOpAsset.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblOpAsset.Location = new System.Drawing.Point(39, 106);
            this.lblOpAsset.Name = "lblOpAsset";
            this.lblOpAsset.Size = new System.Drawing.Size(17, 24);
            this.lblOpAsset.TabIndex = 8;
            this.lblOpAsset.Text = "-";
            // 
            // lblMarketAsset
            // 
            this.lblMarketAsset.AutoSize = true;
            this.lblMarketAsset.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMarketAsset.Location = new System.Drawing.Point(39, 72);
            this.lblMarketAsset.Name = "lblMarketAsset";
            this.lblMarketAsset.Size = new System.Drawing.Size(17, 24);
            this.lblMarketAsset.TabIndex = 7;
            this.lblMarketAsset.Text = "-";
            // 
            // lblCreditAsset
            // 
            this.lblCreditAsset.AutoSize = true;
            this.lblCreditAsset.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCreditAsset.Location = new System.Drawing.Point(39, 38);
            this.lblCreditAsset.Name = "lblCreditAsset";
            this.lblCreditAsset.Size = new System.Drawing.Size(17, 24);
            this.lblCreditAsset.TabIndex = 6;
            this.lblCreditAsset.Text = "-";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(298, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "دارایی های موزون به ریسک عملیاتی: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(451, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "مجموع: ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(318, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "دارایی های موزون به ریسک بازار: ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(300, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "دارایی های موزون به ریسک اعتباری: ";
            // 
            // cgbSupervisionCapital
            // 
            this.cgbSupervisionCapital.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbSupervisionCapital.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbSupervisionCapital.Controls.Add(this.lblSCapital);
            this.cgbSupervisionCapital.Controls.Add(this.lblLayer2);
            this.cgbSupervisionCapital.Controls.Add(this.lbllayer1);
            this.cgbSupervisionCapital.Controls.Add(this.label2);
            this.cgbSupervisionCapital.Controls.Add(this.label3);
            this.cgbSupervisionCapital.Controls.Add(this.label4);
            this.cgbSupervisionCapital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cgbSupervisionCapital.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cgbSupervisionCapital.Location = new System.Drawing.Point(0, 0);
            this.cgbSupervisionCapital.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.cgbSupervisionCapital.Name = "cgbSupervisionCapital";
            this.cgbSupervisionCapital.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cgbSupervisionCapital.Size = new System.Drawing.Size(404, 226);
            this.cgbSupervisionCapital.TabIndex = 134;
            this.cgbSupervisionCapital.Text = "سرمایه نظارتی";
            // 
            // lblSCapital
            // 
            this.lblSCapital.AutoSize = true;
            this.lblSCapital.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSCapital.Location = new System.Drawing.Point(24, 106);
            this.lblSCapital.Name = "lblSCapital";
            this.lblSCapital.Size = new System.Drawing.Size(17, 24);
            this.lblSCapital.TabIndex = 5;
            this.lblSCapital.Text = "-";
            // 
            // lblLayer2
            // 
            this.lblLayer2.AutoSize = true;
            this.lblLayer2.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLayer2.Location = new System.Drawing.Point(24, 72);
            this.lblLayer2.Name = "lblLayer2";
            this.lblLayer2.Size = new System.Drawing.Size(17, 24);
            this.lblLayer2.TabIndex = 4;
            this.lblLayer2.Text = "-";
            // 
            // lbllayer1
            // 
            this.lbllayer1.AutoSize = true;
            this.lbllayer1.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbllayer1.Location = new System.Drawing.Point(24, 38);
            this.lbllayer1.Name = "lbllayer1";
            this.lbllayer1.Size = new System.Drawing.Size(17, 24);
            this.lbllayer1.TabIndex = 3;
            this.lbllayer1.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(345, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "مجموع: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(314, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "سرمایه لایه 2: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(316, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "سرمایه لایه 1: ";
            // 
            // cgbCapitalAdequacy
            // 
            this.cgbCapitalAdequacy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbCapitalAdequacy.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbCapitalAdequacy.Controls.Add(this.lblCapitalAdequacy);
            this.cgbCapitalAdequacy.Controls.Add(this.label12);
            this.cgbCapitalAdequacy.Controls.Add(this.label11);
            this.cgbCapitalAdequacy.Controls.Add(this.label10);
            this.cgbCapitalAdequacy.Controls.Add(this.label9);
            this.cgbCapitalAdequacy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cgbCapitalAdequacy.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cgbCapitalAdequacy.Location = new System.Drawing.Point(0, 0);
            this.cgbCapitalAdequacy.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.cgbCapitalAdequacy.Name = "cgbCapitalAdequacy";
            this.cgbCapitalAdequacy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cgbCapitalAdequacy.Size = new System.Drawing.Size(918, 201);
            this.cgbCapitalAdequacy.TabIndex = 132;
            this.cgbCapitalAdequacy.Text = "نسبت کفایت سرمایه";
            // 
            // lblCapitalAdequacy
            // 
            this.lblCapitalAdequacy.AutoSize = true;
            this.lblCapitalAdequacy.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCapitalAdequacy.Location = new System.Drawing.Point(463, 105);
            this.lblCapitalAdequacy.Name = "lblCapitalAdequacy";
            this.lblCapitalAdequacy.Size = new System.Drawing.Size(17, 24);
            this.lblCapitalAdequacy.TabIndex = 10;
            this.lblCapitalAdequacy.Text = "-";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(696, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 33);
            this.label12.TabIndex = 4;
            this.label12.Text = "=";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(738, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "کل دارایی های موزون به ریسک";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(722, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "__________________";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(777, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "سرمایه نظارتی";
            // 
            // frmCapitalAdequacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(918, 497);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCapitalAdequacy";
            this.ShowIcon = false;
            this.Text = "کفایت سرمایه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCapitalAdequacy_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.cgbRiskBalancedAsset)).EndInit();
            this.cgbRiskBalancedAsset.ResumeLayout(false);
            this.cgbRiskBalancedAsset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgbSupervisionCapital)).EndInit();
            this.cgbSupervisionCapital.ResumeLayout(false);
            this.cgbSupervisionCapital.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCapitalAdequacy)).EndInit();
            this.cgbCapitalAdequacy.ResumeLayout(false);
            this.cgbCapitalAdequacy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker fdpDate;
        private Utilize.Company.CButton cbCalculate;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Utilize.Company.CGroupBox cgbCapitalAdequacy;
        private System.Windows.Forms.Label lblCapitalAdequacy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Utilize.Company.CGroupBox cgbSupervisionCapital;
        private System.Windows.Forms.Label lblSCapital;
        private System.Windows.Forms.Label lblLayer2;
        private System.Windows.Forms.Label lbllayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Utilize.Company.CGroupBox cgbRiskBalancedAsset;
        private System.Windows.Forms.Label lblRiskAsset;
        private System.Windows.Forms.Label lblOpAsset;
        private System.Windows.Forms.Label lblMarketAsset;
        private System.Windows.Forms.Label lblCreditAsset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}