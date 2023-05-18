namespace Presentation.Print
{
    partial class frmNdrPrint
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
            this.Print = new System.Windows.Forms.Button();
            this.btnPrintPre = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrint
            // 
            this.dgvPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrint.Location = new System.Drawing.Point(23, 23);
            this.dgvPrint.Name = "dgvPrint";
            this.dgvPrint.RowHeadersWidth = 51;
            this.dgvPrint.RowTemplate.Height = 24;
            this.dgvPrint.Size = new System.Drawing.Size(631, 344);
            this.dgvPrint.TabIndex = 0;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(62, 390);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 1;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // btnPrintPre
            // 
            this.btnPrintPre.Location = new System.Drawing.Point(179, 390);
            this.btnPrintPre.Name = "btnPrintPre";
            this.btnPrintPre.Size = new System.Drawing.Size(132, 23);
            this.btnPrintPre.TabIndex = 2;
            this.btnPrintPre.Text = "Print Preview";
            this.btnPrintPre.UseVisualStyleBackColor = true;
            this.btnPrintPre.Click += new System.EventHandler(this.btnPrintPre_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmNdrPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintPre);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.dgvPrint);
            this.Name = "frmNdrPrint";
            this.Text = "frmNdrPrint";
            this.Load += new System.EventHandler(this.frmNdrPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrint;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button btnPrintPre;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}