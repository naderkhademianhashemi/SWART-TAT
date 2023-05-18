namespace Presentation.FRM_Routine
{
    partial class frmRoutine
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
            this.btnError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnError
            // 
            this.btnError.Location = new System.Drawing.Point(76, 49);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(109, 43);
            this.btnError.TabIndex = 0;
            this.btnError.Text = "Error";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // frmRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnError);
            this.Name = "frmRoutine";
            this.Text = "frmRoutine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnError;
    }
}