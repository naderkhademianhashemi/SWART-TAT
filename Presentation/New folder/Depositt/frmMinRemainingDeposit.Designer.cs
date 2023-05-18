namespace Presentation.Deposit
{
    partial class frmMinRemainingDeposit
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
            this.dgvResoult = new Utilize.Grid.MyGrid_V2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepAvgerage = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.cbShowReport = new Utilize.Company.CButton();
            this.cGroupBox1 = new Utilize.Company.CGroupBox();
            this.cbCloseAll = new Utilize.Company.CButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCounterpartiesNames = new System.Windows.Forms.DataGridView();
            this.rbtDepNo = new System.Windows.Forms.RadioButton();
            this.rbtCounterpartyName = new System.Windows.Forms.RadioButton();
            this.cgbCouterpartName = new Utilize.Company.CGroupBox();
            this.txtCounterpartyNameSearch = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.rdbContains = new System.Windows.Forms.RadioButton();
            this.rdbStartsWith = new System.Windows.Forms.RadioButton();
            this.rdbEndsWith = new System.Windows.Forms.RadioButton();
            this.rbtCounterparty = new System.Windows.Forms.RadioButton();
            this.txtCounterparty = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCounterPartyName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCounterpartyNames = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.fdpFinishDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.txtDepNo = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.fdpStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepNoName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepAvgerage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGroupBox1)).BeginInit();
            this.cGroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCouterpartName)).BeginInit();
            this.cgbCouterpartName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNameSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterparty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterPartyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepNoName)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResoult
            // 
            this.dgvResoult.BackColor = System.Drawing.Color.Transparent;
            this.dgvResoult.DataSource = null;
            this.dgvResoult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResoult.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvResoult.Location = new System.Drawing.Point(0, 141);
            this.dgvResoult.Name = "dgvResoult";
            this.dgvResoult.ShowMenu = true;
            this.dgvResoult.Size = new System.Drawing.Size(784, 421);
            this.dgvResoult.TabIndex = 140;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDepAvgerage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.MaximumSize = new System.Drawing.Size(4784, 36);
            this.panel1.MinimumSize = new System.Drawing.Size(484, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 36);
            this.panel1.TabIndex = 142;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(355, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "(ریال)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(602, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "گردش موجودی سپرده در بازه مورد نظر";
            // 
            // txtDepAvgerage
            // 
            this.txtDepAvgerage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepAvgerage.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDepAvgerage.Location = new System.Drawing.Point(395, 3);
            this.txtDepAvgerage.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.txtDepAvgerage.Name = "txtDepAvgerage";
            this.txtDepAvgerage.ReadOnly = true;
            this.txtDepAvgerage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDepAvgerage.Size = new System.Drawing.Size(201, 30);
            this.txtDepAvgerage.TabIndex = 144;
            // 
            // cbShowReport
            // 
            this.cbShowReport.DefaultImage = global::Presentation.Properties.Resources.S_ReportB;
            this.cbShowReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbShowReport.HoverImage = global::Presentation.Properties.Resources.S_ReportB_Hover;
            this.cbShowReport.Location = new System.Drawing.Point(12, 56);
            this.cbShowReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbShowReport.Name = "cbShowReport";
            this.cbShowReport.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbShowReport.Size = new System.Drawing.Size(129, 41);
            this.cbShowReport.TabIndex = 141;
            this.cbShowReport.Title = null;
            this.cbShowReport.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbShowReport_CButtonClicked);
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cGroupBox1.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cGroupBox1.Controls.Add(this.cbCloseAll);
            this.cGroupBox1.Controls.Add(this.cbShowReport);
            this.cGroupBox1.Controls.Add(this.panel2);
            this.cGroupBox1.Controls.Add(this.fdpFinishDate);
            this.cGroupBox1.Controls.Add(this.txtDepNo);
            this.cGroupBox1.Controls.Add(this.fdpStartDate);
            this.cGroupBox1.Controls.Add(this.label2);
            this.cGroupBox1.Controls.Add(this.label1);
            this.cGroupBox1.Controls.Add(this.txtDepNoName);
            this.cGroupBox1.Controls.Add(this.label9);
            this.cGroupBox1.Controls.Add(this.txtCounterpartyNames);
            this.cGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cGroupBox1.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Size = new System.Drawing.Size(784, 105);
            this.cGroupBox1.TabIndex = 135;
            this.cGroupBox1.Text = "فیلتربندی گزارش";
            // 
            // cbCloseAll
            // 
            this.cbCloseAll.BackColor = System.Drawing.Color.Transparent;
            this.cbCloseAll.DefaultImage = global::Presentation.Properties.Resources.help;
            this.cbCloseAll.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cbCloseAll.HoverImage = global::Presentation.Properties.Resources.help_hover;
            this.cbCloseAll.Location = new System.Drawing.Point(132, 61);
            this.cbCloseAll.Margin = new System.Windows.Forms.Padding(12, 26, 12, 26);
            this.cbCloseAll.Name = "cbCloseAll";
            this.cbCloseAll.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCloseAll.Size = new System.Drawing.Size(80, 31);
            this.cbCloseAll.TabIndex = 155;
            this.cbCloseAll.Title = null;
            this.cbCloseAll.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbCloseAll_CButtonClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCounterpartiesNames);
            this.panel2.Controls.Add(this.rbtDepNo);
            this.panel2.Controls.Add(this.rbtCounterpartyName);
            this.panel2.Controls.Add(this.cgbCouterpartName);
            this.panel2.Controls.Add(this.rbtCounterparty);
            this.panel2.Controls.Add(this.txtCounterparty);
            this.panel2.Controls.Add(this.txtCounterPartyName);
            this.panel2.Location = new System.Drawing.Point(37, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 16);
            this.panel2.TabIndex = 152;
            this.panel2.Visible = false;
            // 
            // dgvCounterpartiesNames
            // 
            this.dgvCounterpartiesNames.AllowUserToAddRows = false;
            this.dgvCounterpartiesNames.AllowUserToDeleteRows = false;
            this.dgvCounterpartiesNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCounterpartiesNames.BackgroundColor = System.Drawing.Color.White;
            this.dgvCounterpartiesNames.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCounterpartiesNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCounterpartiesNames.Location = new System.Drawing.Point(0, 38);
            this.dgvCounterpartiesNames.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.dgvCounterpartiesNames.Name = "dgvCounterpartiesNames";
            this.dgvCounterpartiesNames.RowTemplate.Height = 24;
            this.dgvCounterpartiesNames.Size = new System.Drawing.Size(0, 0);
            this.dgvCounterpartiesNames.TabIndex = 147;
            // 
            // rbtDepNo
            // 
            this.rbtDepNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtDepNo.AutoSize = true;
            this.rbtDepNo.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtDepNo.Location = new System.Drawing.Point(-75, 60);
            this.rbtDepNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtDepNo.Name = "rbtDepNo";
            this.rbtDepNo.Size = new System.Drawing.Size(82, 23);
            this.rbtDepNo.TabIndex = 151;
            this.rbtDepNo.TabStop = true;
            this.rbtDepNo.Text = "شماره حساب";
            this.rbtDepNo.UseVisualStyleBackColor = true;
            this.rbtDepNo.CheckedChanged += new System.EventHandler(this.chbDepNo_CheckedChanged);
            // 
            // rbtCounterpartyName
            // 
            this.rbtCounterpartyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtCounterpartyName.AutoSize = true;
            this.rbtCounterpartyName.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtCounterpartyName.Location = new System.Drawing.Point(-64, 36);
            this.rbtCounterpartyName.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.rbtCounterpartyName.Name = "rbtCounterpartyName";
            this.rbtCounterpartyName.Size = new System.Drawing.Size(71, 23);
            this.rbtCounterpartyName.TabIndex = 145;
            this.rbtCounterpartyName.Text = "نام مشتری";
            this.rbtCounterpartyName.UseVisualStyleBackColor = true;
            this.rbtCounterpartyName.CheckedChanged += new System.EventHandler(this.chbCounterpartyName_CheckedChanged);
            // 
            // cgbCouterpartName
            // 
            this.cgbCouterpartName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cgbCouterpartName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbCouterpartName.CBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(113)))));
            this.cgbCouterpartName.Controls.Add(this.txtCounterpartyNameSearch);
            this.cgbCouterpartName.Controls.Add(this.rdbContains);
            this.cgbCouterpartName.Controls.Add(this.rdbStartsWith);
            this.cgbCouterpartName.Controls.Add(this.rdbEndsWith);
            this.cgbCouterpartName.Location = new System.Drawing.Point(-257, 30);
            this.cgbCouterpartName.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.cgbCouterpartName.Name = "cgbCouterpartName";
            this.cgbCouterpartName.Size = new System.Drawing.Size(178, 84);
            this.cgbCouterpartName.TabIndex = 146;
            // 
            // txtCounterpartyNameSearch
            // 
            this.txtCounterpartyNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterpartyNameSearch.Enabled = false;
            this.txtCounterpartyNameSearch.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCounterpartyNameSearch.Location = new System.Drawing.Point(6, 17);
            this.txtCounterpartyNameSearch.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.txtCounterpartyNameSearch.Name = "txtCounterpartyNameSearch";
            this.txtCounterpartyNameSearch.Size = new System.Drawing.Size(166, 27);
            this.txtCounterpartyNameSearch.TabIndex = 14;
            this.txtCounterpartyNameSearch.EditorButtonClick += new Infragistics.Win.UltraWinEditors.EditorButtonEventHandler(this.txtCounterpartyNameSearch_EditorButtonClick);
            // 
            // rdbContains
            // 
            this.rdbContains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbContains.AutoSize = true;
            this.rdbContains.Checked = true;
            this.rdbContains.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbContains.Location = new System.Drawing.Point(126, 59);
            this.rdbContains.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.rdbContains.Name = "rdbContains";
            this.rdbContains.Size = new System.Drawing.Size(46, 21);
            this.rdbContains.TabIndex = 132;
            this.rdbContains.TabStop = true;
            this.rdbContains.Text = "شامل";
            this.rdbContains.UseVisualStyleBackColor = true;
            // 
            // rdbStartsWith
            // 
            this.rdbStartsWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbStartsWith.AutoSize = true;
            this.rdbStartsWith.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbStartsWith.Location = new System.Drawing.Point(69, 59);
            this.rdbStartsWith.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.rdbStartsWith.Name = "rdbStartsWith";
            this.rdbStartsWith.Size = new System.Drawing.Size(53, 21);
            this.rdbStartsWith.TabIndex = 132;
            this.rdbStartsWith.Text = "شروع با";
            this.rdbStartsWith.UseVisualStyleBackColor = true;
            // 
            // rdbEndsWith
            // 
            this.rdbEndsWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbEndsWith.AutoSize = true;
            this.rdbEndsWith.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbEndsWith.Location = new System.Drawing.Point(8, 59);
            this.rdbEndsWith.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.rdbEndsWith.Name = "rdbEndsWith";
            this.rdbEndsWith.Size = new System.Drawing.Size(50, 21);
            this.rdbEndsWith.TabIndex = 132;
            this.rdbEndsWith.Text = "پایان با";
            this.rdbEndsWith.UseVisualStyleBackColor = true;
            // 
            // rbtCounterparty
            // 
            this.rbtCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtCounterparty.AutoSize = true;
            this.rbtCounterparty.Checked = true;
            this.rbtCounterparty.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtCounterparty.Location = new System.Drawing.Point(-65, 7);
            this.rbtCounterparty.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.rbtCounterparty.Name = "rbtCounterparty";
            this.rbtCounterparty.Size = new System.Drawing.Size(72, 23);
            this.rbtCounterparty.TabIndex = 142;
            this.rbtCounterparty.TabStop = true;
            this.rbtCounterparty.Text = "کد مشتری";
            this.rbtCounterparty.UseVisualStyleBackColor = true;
            this.rbtCounterparty.CheckedChanged += new System.EventHandler(this.chbCounterparty_CheckedChanged);
            // 
            // txtCounterparty
            // 
            this.txtCounterparty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterparty.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCounterparty.Location = new System.Drawing.Point(-257, 5);
            this.txtCounterparty.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.txtCounterparty.Name = "txtCounterparty";
            this.txtCounterparty.Size = new System.Drawing.Size(178, 27);
            this.txtCounterparty.TabIndex = 143;
            this.txtCounterparty.EditorButtonClick += new Infragistics.Win.UltraWinEditors.EditorButtonEventHandler(this.txtCounterparty_EditorButtonClick);
            // 
            // txtCounterPartyName
            // 
            this.txtCounterPartyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterPartyName.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCounterPartyName.Location = new System.Drawing.Point(-1, 5);
            this.txtCounterPartyName.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.txtCounterPartyName.Name = "txtCounterPartyName";
            this.txtCounterPartyName.ReadOnly = true;
            this.txtCounterPartyName.Size = new System.Drawing.Size(0, 27);
            this.txtCounterPartyName.TabIndex = 144;
            // 
            // txtCounterpartyNames
            // 
            this.txtCounterpartyNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCounterpartyNames.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCounterpartyNames.Location = new System.Drawing.Point(3, 12);
            this.txtCounterpartyNames.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.txtCounterpartyNames.Multiline = true;
            this.txtCounterpartyNames.Name = "txtCounterpartyNames";
            this.txtCounterpartyNames.ReadOnly = true;
            this.txtCounterpartyNames.Size = new System.Drawing.Size(28, 24);
            this.txtCounterpartyNames.TabIndex = 148;
            this.txtCounterpartyNames.Visible = false;
            // 
            // fdpFinishDate
            // 
            this.fdpFinishDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFinishDate.Font = null;
            this.fdpFinishDate.Location = new System.Drawing.Point(350, 24);
            this.fdpFinishDate.Name = "fdpFinishDate";
            this.fdpFinishDate.Size = new System.Drawing.Size(144, 23);
            this.fdpFinishDate.TabIndex = 35;
            this.fdpFinishDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.fdpFinishDate.SelectedDateTimeChanged += new System.EventHandler(this.fdpFinishDate_SelectedDateTimeChanged);
            // 
            // txtDepNo
            // 
            this.txtDepNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepNo.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDepNo.Location = new System.Drawing.Point(567, 56);
            this.txtDepNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDepNo.Name = "txtDepNo";
            this.txtDepNo.NullText = "شماره سپرده";
            this.txtDepNo.Size = new System.Drawing.Size(144, 30);
            this.txtDepNo.TabIndex = 149;
            this.txtDepNo.EditorButtonClick += new Infragistics.Win.UltraWinEditors.EditorButtonEventHandler(this.txtDepNo_EditorButtonClick);
            // 
            // fdpStartDate
            // 
            this.fdpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpStartDate.Font = null;
            this.fdpStartDate.Location = new System.Drawing.Point(567, 24);
            this.fdpStartDate.Name = "fdpStartDate";
            this.fdpStartDate.Size = new System.Drawing.Size(144, 23);
            this.fdpStartDate.TabIndex = 34;
            this.fdpStartDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.fdpStartDate.SelectedDateTimeChanged += new System.EventHandler(this.fdpStartDate_SelectedDateTimeChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(710, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "شماره سپرده";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(500, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "تا تاریخ";
            // 
            // txtDepNoName
            // 
            this.txtDepNoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepNoName.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDepNoName.Location = new System.Drawing.Point(214, 56);
            this.txtDepNoName.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.txtDepNoName.Name = "txtDepNoName";
            this.txtDepNoName.ReadOnly = true;
            this.txtDepNoName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDepNoName.Size = new System.Drawing.Size(344, 30);
            this.txtDepNoName.TabIndex = 144;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(730, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "از تاریخ";
            // 
            // frmMinRemainingDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dgvResoult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cGroupBox1);
            this.Name = "frmMinRemainingDeposit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmTasvieshode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepAvgerage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGroupBox1)).EndInit();
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounterpartiesNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgbCouterpartName)).EndInit();
            this.cgbCouterpartName.ResumeLayout(false);
            this.cgbCouterpartName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNameSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterparty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterPartyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounterpartyNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepNoName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Utilize.Grid.MyGrid_V2 dgvResoult;
        private Utilize.Company.CButton cbShowReport;
        private System.Windows.Forms.DataGridView dgvCounterpartiesNames;
        private Utilize.Company.CGroupBox cgbCouterpartName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterpartyNameSearch;
        private System.Windows.Forms.RadioButton rdbContains;
        private System.Windows.Forms.RadioButton rdbStartsWith;
        private System.Windows.Forms.RadioButton rdbEndsWith;
        private System.Windows.Forms.RadioButton rbtCounterpartyName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterparty;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterPartyName;
        private System.Windows.Forms.RadioButton rbtCounterparty;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCounterpartyNames;
        private System.Windows.Forms.RadioButton rbtDepNo;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDepNo;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDepNoName;
        private Utilize.Company.CGroupBox cGroupBox1;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFinishDate;
        private FarsiLibrary.Win.Controls.FADatePicker fdpStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDepAvgerage;
        private Utilize.Company.CButton cbCloseAll;
    }
}