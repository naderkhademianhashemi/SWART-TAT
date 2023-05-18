namespace Presentation.Public
{
    partial class RoundBox
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
            this.picArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // picArrow
            // 
            this.picArrow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picArrow.Image = global::Presentation.Properties.Resources.S_ArrowToEnd;
            this.picArrow.Location = new System.Drawing.Point(111, 8);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(19, 24);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picArrow.TabIndex = 0;
            this.picArrow.TabStop = false;
            this.picArrow.Visible = false;
            // 
            // RoundBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picArrow);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.Name = "RoundBox";
            this.Size = new System.Drawing.Size(156, 41);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RoundBox_Paint);
            this.Enter += new System.EventHandler(this.RoundBox_Enter);
            this.Leave += new System.EventHandler(this.RoundBox_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picArrow;
    }
}
