namespace Presentation.Loan
{
    partial class frmLoanCashFlowPayment
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
            this.dgvResoult = new System.Windows.Forms.DataGridView();
            this.cbShowReport = new System.Windows.Forms.Button();
            this.cGroupBox1 = new System.Windows.Forms.GroupBox();
            this.grbLocation = new System.Windows.Forms.GroupBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbStates = new System.Windows.Forms.ComboBox();
            this.fdpStartDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResoult)).BeginInit();
            this.cGroupBox1.SuspendLayout();
            this.grbLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResoult
            // 
            this.dgvResoult.ColumnHeadersHeight = 29;
            this.dgvResoult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResoult.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvResoult.Location = new System.Drawing.Point(0, 211);
            this.dgvResoult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvResoult.Name = "dgvResoult";
            this.dgvResoult.RowHeadersWidth = 51;
            this.dgvResoult.Size = new System.Drawing.Size(1045, 318);
            this.dgvResoult.TabIndex = 140;
            // 
            // cbShowReport
            // 
            this.cbShowReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShowReport.Location = new System.Drawing.Point(552, 19);
            this.cbShowReport.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbShowReport.Name = "cbShowReport";
            this.cbShowReport.Size = new System.Drawing.Size(207, 38);
            this.cbShowReport.TabIndex = 141;
            this.cbShowReport.Text = "show report";
            this.cbShowReport.Click += new System.EventHandler(this.cbShowReport_CButtonClicked);
            // 
            // cGroupBox1
            // 
            this.cGroupBox1.Controls.Add(this.grbLocation);
            this.cGroupBox1.Controls.Add(this.cbShowReport);
            this.cGroupBox1.Controls.Add(this.fdpStartDate);
            this.cGroupBox1.Controls.Add(this.label9);
            this.cGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cGroupBox1.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.cGroupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cGroupBox1.Name = "cGroupBox1";
            this.cGroupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cGroupBox1.Size = new System.Drawing.Size(1045, 211);
            this.cGroupBox1.TabIndex = 135;
            this.cGroupBox1.TabStop = false;
            this.cGroupBox1.Text = "فیلتربندی گزارش";
            // 
            // grbLocation
            // 
            this.grbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLocation.Controls.Add(this.cmbBranch);
            this.grbLocation.Controls.Add(this.cmbCity);
            this.grbLocation.Controls.Add(this.cmbStates);
            this.grbLocation.Location = new System.Drawing.Point(345, 61);
            this.grbLocation.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.grbLocation.Name = "grbLocation";
            this.grbLocation.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbLocation.Size = new System.Drawing.Size(684, 136);
            this.grbLocation.TabIndex = 142;
            this.grbLocation.TabStop = false;
            this.grbLocation.Text = "اطلاعات شعب";
            // 
            // cmbBranch
            // 
            this.cmbBranch.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbBranch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBranch.Location = new System.Drawing.Point(4, 77);
            this.cmbBranch.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBranch.Size = new System.Drawing.Size(676, 25);
            this.cmbBranch.TabIndex = 126;
            // 
            // cmbCity
            // 
            this.cmbCity.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbCity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.Location = new System.Drawing.Point(4, 52);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCity.Size = new System.Drawing.Size(676, 25);
            this.cmbCity.TabIndex = 128;
            // 
            // cmbStates
            // 
            this.cmbStates.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbStates.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStates.Location = new System.Drawing.Point(4, 27);
            this.cmbStates.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.cmbStates.Name = "cmbStates";
            this.cmbStates.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbStates.Size = new System.Drawing.Size(676, 25);
            this.cmbStates.TabIndex = 125;
            // 
            // fdpStartDate
            // 
            this.fdpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpStartDate.Font = null;
            this.fdpStartDate.Location = new System.Drawing.Point(773, 28);
            this.fdpStartDate.Name = "fdpStartDate";
            this.fdpStartDate.Size = new System.Drawing.Size(192, 22);
            this.fdpStartDate.TabIndex = 34;
            this.fdpStartDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(984, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "تاریخ";
            // 
            // frmLoanCashFlowPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 529);
            this.Controls.Add(this.dgvResoult);
            this.Controls.Add(this.cGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLoanCashFlowPayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmTasvieshode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvResoult)).EndInit();
            this.cGroupBox1.ResumeLayout(false);
            this.cGroupBox1.PerformLayout();
            this.grbLocation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResoult;
        private System.Windows.Forms.Button cbShowReport;
        private System.Windows.Forms.GroupBox cGroupBox1;
        private FarsiLibrary.Win.Controls.FADatePicker fdpStartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbLocation;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbStates;
    }
}