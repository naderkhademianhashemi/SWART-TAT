namespace Presentation.Public
{
    partial class CaptionPanel
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
            this.pnlCaption = new System.Windows.Forms.Panel();
            this.grpLine = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // pnlCaption
            // 
            this.pnlCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCaption.BackColor = System.Drawing.Color.Ivory;
            this.pnlCaption.Location = new System.Drawing.Point(0, 0);
            this.pnlCaption.Name = "pnlCaption";
            this.pnlCaption.Size = new System.Drawing.Size(297, 71);
            this.pnlCaption.TabIndex = 0;
            // 
            // grpLine
            // 
            this.grpLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLine.Location = new System.Drawing.Point(-5, 66);
            this.grpLine.Name = "grpLine";
            this.grpLine.Size = new System.Drawing.Size(311, 7);
            this.grpLine.TabIndex = 1;
            this.grpLine.TabStop = false;
            // 
            // CaptionPanel
            // 
            this.Controls.Add(this.pnlCaption);
            this.Controls.Add(this.grpLine);
            this.Size = new System.Drawing.Size(297, 75);
            this.Resize += new System.EventHandler(this.CaptionPanel_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCaption;
        private System.Windows.Forms.GroupBox grpLine;
    }
}
