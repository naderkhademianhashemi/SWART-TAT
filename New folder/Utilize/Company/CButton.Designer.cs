using System.Drawing;

namespace Utilize.Company
{
    partial class CButton
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
            this.btnCompuco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompuco
            // 
            this.btnCompuco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompuco.FlatAppearance.BorderSize = 0;
            this.btnCompuco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCompuco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCompuco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompuco.Location = new System.Drawing.Point(0, 0);
            this.btnCompuco.Name = "btnCompuco";
            this.btnCompuco.Size = new System.Drawing.Size(150, 150);
            this.btnCompuco.TabIndex = 0;
            //this.btnCompuco.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompuco.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnCompuco.UseVisualStyleBackColor = true;
            this.btnCompuco.Click += new System.EventHandler(this.btnCompuco_Click);
            this.btnCompuco.MouseEnter += new System.EventHandler(this.btnCompuco_MouseEnter);
            this.btnCompuco.MouseLeave += new System.EventHandler(this.btnCompuco_MouseLeave);
            this.btnCompuco.TextAlign = ContentAlignment.MiddleCenter;
            //this.btnCompuco.picA = ContentAlignment.MiddleCenter;
            // 
            // CButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCompuco);
            this.Name = "CButton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompuco;

    }
}
