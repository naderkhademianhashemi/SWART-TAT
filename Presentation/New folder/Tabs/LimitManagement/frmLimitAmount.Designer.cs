namespace Presentation.Tabs.LimitManagement
{
    partial class frmLimitAmount
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
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLimitAmount));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            this.txtAmount = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnOK = new Utilize.Company.CButton();
            this.btnCancel = new Utilize.Company.CButton();
            this.rdoAmount = new System.Windows.Forms.RadioButton();
            this.rdoGroupName = new System.Windows.Forms.RadioButton();
            this.cmbAGM = new Utilize.Company.CComboCox();
            this.rdoQuery = new System.Windows.Forms.RadioButton();
            this.cmbAmountOp = new Utilize.Company.CComboCox();
            this.cmbAGMOp = new Utilize.Company.CComboCox();
            this.cmbQueryOp = new Utilize.Company.CComboCox();
            this.nAmountPer = new System.Windows.Forms.NumericUpDown();
            this.nAGMPer = new System.Windows.Forms.NumericUpDown();
            this.nQueryPer = new System.Windows.Forms.NumericUpDown();
            this.ChkApplyAll = new System.Windows.Forms.CheckBox();
            this.btnQuery = new Utilize.Company.CButton();
            this.txtAmountQuery = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new Utilize.Company.CButton();
            this.cbClose = new Utilize.Company.CButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAmountOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAGMOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQueryOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAmountPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAGMPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQueryPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            appearance13.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance13.ImageBackground")));
            this.txtAmount.Appearance = appearance13;
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAmount.Location = new System.Drawing.Point(39, 62);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(267, 35);
            this.txtAmount.TabIndex = 17;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnOK.DefaultImage")));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnOK.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnOK.HoverImage")));
            this.btnOK.Location = new System.Drawing.Point(417, 231);
            this.btnOK.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Size = new System.Drawing.Size(133, 34);
            this.btnOK.TabIndex = 15;
            this.btnOK.Title = "تأیید";
            this.btnOK.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.DefaultImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Location = new System.Drawing.Point(135, 231);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Size = new System.Drawing.Size(133, 34);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Title = "انصراف";
            this.btnCancel.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // rdoAmount
            // 
            this.rdoAmount.AutoSize = true;
            this.rdoAmount.BackColor = System.Drawing.Color.Transparent;
            this.rdoAmount.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoAmount.Location = new System.Drawing.Point(581, 64);
            this.rdoAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoAmount.Name = "rdoAmount";
            this.rdoAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoAmount.Size = new System.Drawing.Size(64, 31);
            this.rdoAmount.TabIndex = 21;
            this.rdoAmount.TabStop = true;
            this.rdoAmount.Text = "مقدار";
            this.rdoAmount.UseVisualStyleBackColor = false;
            this.rdoAmount.CheckedChanged += new System.EventHandler(this.rdoAmount_CheckedChanged);
            // 
            // rdoGroupName
            // 
            this.rdoGroupName.AutoSize = true;
            this.rdoGroupName.BackColor = System.Drawing.Color.Transparent;
            this.rdoGroupName.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoGroupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoGroupName.Location = new System.Drawing.Point(541, 100);
            this.rdoGroupName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoGroupName.Name = "rdoGroupName";
            this.rdoGroupName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoGroupName.Size = new System.Drawing.Size(102, 31);
            this.rdoGroupName.TabIndex = 22;
            this.rdoGroupName.TabStop = true;
            this.rdoGroupName.Text = "گروه حساب";
            this.rdoGroupName.UseVisualStyleBackColor = false;
            this.rdoGroupName.CheckedChanged += new System.EventHandler(this.rdoGroupName_CheckedChanged);
            // 
            // cmbAGM
            // 
            this.cmbAGM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance1.ImageBackground")));
            appearance1.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAGM.Appearance = appearance1;
            this.cmbAGM.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbAGM.AutoSize = false;
            this.cmbAGM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            appearance2.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAGM.ButtonAppearance = appearance2;
            this.cmbAGM.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbAGM.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbAGM.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbAGM.Enabled = false;
            this.cmbAGM.HideSelection = false;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbAGM.ItemAppearance = appearance3;
            this.cmbAGM.Location = new System.Drawing.Point(39, 106);
            this.cmbAGM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAGM.Name = "cmbAGM";
            this.cmbAGM.Size = new System.Drawing.Size(267, 25);
            this.cmbAGM.TabIndex = 23;
            // 
            // rdoQuery
            // 
            this.rdoQuery.AutoSize = true;
            this.rdoQuery.BackColor = System.Drawing.Color.Transparent;
            this.rdoQuery.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.rdoQuery.Location = new System.Drawing.Point(551, 133);
            this.rdoQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoQuery.Name = "rdoQuery";
            this.rdoQuery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoQuery.Size = new System.Drawing.Size(92, 31);
            this.rdoQuery.TabIndex = 22;
            this.rdoQuery.TabStop = true;
            this.rdoQuery.Text = "پرس و جو";
            this.rdoQuery.UseVisualStyleBackColor = false;
            this.rdoQuery.Visible = false;
            this.rdoQuery.CheckedChanged += new System.EventHandler(this.rdoQuery_CheckedChanged);
            // 
            // cmbAmountOp
            // 
            this.cmbAmountOp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance4.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance4.ImageBackground")));
            appearance4.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAmountOp.Appearance = appearance4;
            this.cmbAmountOp.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbAmountOp.AutoSize = false;
            this.cmbAmountOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance5.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance5.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance5.ImageBackground")));
            appearance5.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAmountOp.ButtonAppearance = appearance5;
            this.cmbAmountOp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbAmountOp.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbAmountOp.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbAmountOp.Enabled = false;
            this.cmbAmountOp.HideSelection = false;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbAmountOp.ItemAppearance = appearance6;
            this.cmbAmountOp.Location = new System.Drawing.Point(479, 65);
            this.cmbAmountOp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAmountOp.Name = "cmbAmountOp";
            this.cmbAmountOp.Size = new System.Drawing.Size(60, 25);
            this.cmbAmountOp.TabIndex = 25;
            this.cmbAmountOp.Visible = false;
            // 
            // cmbAGMOp
            // 
            this.cmbAGMOp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance7.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance7.ImageBackground")));
            appearance7.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAGMOp.Appearance = appearance7;
            this.cmbAGMOp.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbAGMOp.AutoSize = false;
            this.cmbAGMOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance8.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance8.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance8.ImageBackground")));
            appearance8.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbAGMOp.ButtonAppearance = appearance8;
            this.cmbAGMOp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbAGMOp.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbAGMOp.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbAGMOp.Enabled = false;
            this.cmbAGMOp.HideSelection = false;
            appearance9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbAGMOp.ItemAppearance = appearance9;
            this.cmbAGMOp.Location = new System.Drawing.Point(479, 101);
            this.cmbAGMOp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAGMOp.Name = "cmbAGMOp";
            this.cmbAGMOp.Size = new System.Drawing.Size(60, 25);
            this.cmbAGMOp.TabIndex = 25;
            this.cmbAGMOp.Visible = false;
            // 
            // cmbQueryOp
            // 
            this.cmbQueryOp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance10.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance10.ImageBackground")));
            appearance10.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbQueryOp.Appearance = appearance10;
            this.cmbQueryOp.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.cmbQueryOp.AutoSize = false;
            this.cmbQueryOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance11.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance11.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance11.ImageBackground")));
            appearance11.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.cmbQueryOp.ButtonAppearance = appearance11;
            this.cmbQueryOp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cmbQueryOp.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.cmbQueryOp.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cmbQueryOp.Enabled = false;
            this.cmbQueryOp.HideSelection = false;
            appearance12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(197)))));
            appearance12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearance12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(152)))), ((int)(((byte)(102)))));
            this.cmbQueryOp.ItemAppearance = appearance12;
            this.cmbQueryOp.Location = new System.Drawing.Point(479, 133);
            this.cmbQueryOp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbQueryOp.Name = "cmbQueryOp";
            this.cmbQueryOp.Size = new System.Drawing.Size(60, 25);
            this.cmbQueryOp.TabIndex = 25;
            this.cmbQueryOp.Visible = false;
            // 
            // nAmountPer
            // 
            this.nAmountPer.Enabled = false;
            this.nAmountPer.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nAmountPer.Location = new System.Drawing.Point(321, 64);
            this.nAmountPer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nAmountPer.Name = "nAmountPer";
            this.nAmountPer.Size = new System.Drawing.Size(60, 33);
            this.nAmountPer.TabIndex = 26;
            this.nAmountPer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nAGMPer
            // 
            this.nAGMPer.Enabled = false;
            this.nAGMPer.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nAGMPer.Location = new System.Drawing.Point(321, 105);
            this.nAGMPer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nAGMPer.Name = "nAGMPer";
            this.nAGMPer.Size = new System.Drawing.Size(60, 33);
            this.nAGMPer.TabIndex = 27;
            this.nAGMPer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nQueryPer
            // 
            this.nQueryPer.Enabled = false;
            this.nQueryPer.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nQueryPer.Location = new System.Drawing.Point(321, 142);
            this.nQueryPer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nQueryPer.Name = "nQueryPer";
            this.nQueryPer.Size = new System.Drawing.Size(60, 33);
            this.nQueryPer.TabIndex = 28;
            this.nQueryPer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nQueryPer.Visible = false;
            // 
            // ChkApplyAll
            // 
            this.ChkApplyAll.AutoSize = true;
            this.ChkApplyAll.BackColor = System.Drawing.Color.Transparent;
            this.ChkApplyAll.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ChkApplyAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.ChkApplyAll.Location = new System.Drawing.Point(431, 170);
            this.ChkApplyAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChkApplyAll.Name = "ChkApplyAll";
            this.ChkApplyAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkApplyAll.Size = new System.Drawing.Size(205, 31);
            this.ChkApplyAll.TabIndex = 29;
            this.ChkApplyAll.Text = "اعمال روی گروههای هم سطح";
            this.ChkApplyAll.UseVisualStyleBackColor = false;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.Transparent;
            this.btnQuery.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnQuery.DefaultImage")));
            this.btnQuery.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnQuery.Enabled = false;
            this.btnQuery.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnQuery.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnQuery.HoverImage")));
            this.btnQuery.Location = new System.Drawing.Point(39, 139);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuery.Size = new System.Drawing.Size(100, 34);
            this.btnQuery.TabIndex = 30;
            this.btnQuery.Title = "پرس و جو";
            this.btnQuery.Visible = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtAmountQuery
            // 
            appearance14.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance14.ImageBackground")));
            this.txtAmountQuery.Appearance = appearance14;
            this.txtAmountQuery.Enabled = false;
            this.txtAmountQuery.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAmountQuery.Location = new System.Drawing.Point(157, 137);
            this.txtAmountQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmountQuery.Name = "txtAmountQuery";
            this.txtAmountQuery.Size = new System.Drawing.Size(148, 35);
            this.txtAmountQuery.TabIndex = 17;
            this.txtAmountQuery.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(259, 27);
            this.label1.TabIndex = 31;
            this.label1.Text = "                           مقدار                           ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(312, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "   درصد   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label3.Location = new System.Drawing.Point(389, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 33;
            this.label3.Text = "كوچكتر از";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label4.Location = new System.Drawing.Point(389, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(71, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "كوچكتر از";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label5.Location = new System.Drawing.Point(389, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(71, 27);
            this.label5.TabIndex = 33;
            this.label5.Text = "كوچكتر از";
            this.label5.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.DefaultImage = ((System.Drawing.Image)(resources.GetObject("btnReset.DefaultImage")));
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReset.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btnReset.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnReset.HoverImage")));
            this.btnReset.Location = new System.Drawing.Point(276, 231);
            this.btnReset.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Size = new System.Drawing.Size(133, 34);
            this.btnReset.TabIndex = 34;
            this.btnReset.Title = "پاکسازی مقادیر";
            this.btnReset.CButtonClicked += new System.EventHandler<System.EventArgs>(this.btnReset_Click);
            // 
            // cbClose
            // 
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(15, 4);
            this.cbClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(45, 32);
            this.cbClose.TabIndex = 35;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label6.Location = new System.Drawing.Point(516, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(138, 35);
            this.label6.TabIndex = 32;
            this.label6.Text = "میزان محدودیت";
            // 
            // frmLimitAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 287);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.ChkApplyAll);
            this.Controls.Add(this.nQueryPer);
            this.Controls.Add(this.nAGMPer);
            this.Controls.Add(this.nAmountPer);
            this.Controls.Add(this.cmbQueryOp);
            this.Controls.Add(this.cmbAGMOp);
            this.Controls.Add(this.cmbAmountOp);
            this.Controls.Add(this.cmbAGM);
            this.Controls.Add(this.rdoQuery);
            this.Controls.Add(this.rdoGroupName);
            this.Controls.Add(this.rdoAmount);
            this.Controls.Add(this.txtAmountQuery);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLimitAmount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مقدار محدودیت";
            this.Load += new System.EventHandler(this.frmAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAmountOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAGMOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQueryOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAmountPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAGMPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQueryPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtAmount;
        private Utilize.Company.CButton btnOK;
        private Utilize.Company.CButton btnCancel;
        public System.Windows.Forms.RadioButton rdoAmount;
        public System.Windows.Forms.RadioButton rdoGroupName;
        public Utilize.Company.CComboCox cmbAGM;
        public System.Windows.Forms.RadioButton rdoQuery;
        private Utilize.Company.CComboCox cmbAmountOp;
        private Utilize.Company.CComboCox cmbAGMOp;
        private Utilize.Company.CComboCox cmbQueryOp;
        public System.Windows.Forms.NumericUpDown nAmountPer;
        public System.Windows.Forms.NumericUpDown nAGMPer;
        public System.Windows.Forms.NumericUpDown nQueryPer;
        private System.Windows.Forms.CheckBox ChkApplyAll;
        private Utilize.Company.CButton btnQuery;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtAmountQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Utilize.Company.CButton btnReset;
        private Utilize.Company.CButton cbClose;
        private System.Windows.Forms.Label label6;
    }
}