namespace Presentation.Tabs.BasicData
{
    partial class frmContractType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContractType));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvResoult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResoult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResoult
            // 
            this.dgvResoult.ColumnHeadersHeight = 29;
            this.dgvResoult.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvResoult.Location = new System.Drawing.Point(0, 0);
            this.dgvResoult.Name = "dgvResoult";
            this.dgvResoult.RowHeadersWidth = 51;
            this.dgvResoult.Size = new System.Drawing.Size(453, 624);
            this.dgvResoult.TabIndex = 0;
            this.dgvResoult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResoult_CellContentClick);
            // 
            // frmContractType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 624);
            this.Controls.Add(this.dgvResoult);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContractType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "نوع قرارداد    ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmContractType_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmContractType_FormClosed);
            this.Load += new System.EventHandler(this.frmContractType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResoult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgvResoult;
    }
}