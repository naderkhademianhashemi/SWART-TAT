namespace Utilize.Company
{
    partial class TabCSwart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picTab = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTab)).BeginInit();
            this.SuspendLayout();
            // 
            // picTab
            // 
            this.picTab.Location = new System.Drawing.Point(0, 0);
            this.picTab.Name = "picTab";
            this.picTab.Size = new System.Drawing.Size(150, 150);
            this.picTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTab.TabIndex = 0;
            this.picTab.TabStop = false;
            this.picTab.Click += new System.EventHandler(this.picTab_Click);
            this.picTab.MouseEnter += new System.EventHandler(this.picTab_MouseEnter);
            this.picTab.MouseLeave += new System.EventHandler(this.picTab_MouseLeave);
            // 
            // TabCSwart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picTab);
            this.Name = "TabCSwart";
            ((System.ComponentModel.ISupportInitialize)(this.picTab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTab;
    }
}
