namespace Presentation.Print
{
    partial class frmPrint
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
            this.dgvPrint = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrintPre = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrint
            // 
            this.dgvPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrint.Location = new System.Drawing.Point(24, 25);
            this.dgvPrint.Name = "dgvPrint";
            this.dgvPrint.RowHeadersWidth = 51;
            this.dgvPrint.Size = new System.Drawing.Size(637, 335);
            this.dgvPrint.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.OriginAtMargins = true;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnPrintPre
            // 
            this.btnPrintPre.Location = new System.Drawing.Point(24, 380);
            this.btnPrintPre.Name = "btnPrintPre";
            this.btnPrintPre.Size = new System.Drawing.Size(105, 29);
            this.btnPrintPre.TabIndex = 1;
            this.btnPrintPre.Text = "print preview";
            this.btnPrintPre.UseVisualStyleBackColor = true;
            this.btnPrintPre.Click += new System.EventHandler(this.btnPrintPre_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(163, 380);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(117, 29);
            this.btn_Print.TabIndex = 2;
            this.btn_Print.Text = "print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btnPrintPre);
            this.Controls.Add(this.dgvPrint);
            this.Name = "frmPrint";
            this.Text = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrint;
        private System.Windows.Forms.Button btnPrintPre;
        public System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_Print;
    }
}