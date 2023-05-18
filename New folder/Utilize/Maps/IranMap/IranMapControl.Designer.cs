namespace Utilize.Maps.IranMap
{
    partial class IranMapControl
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
            this.pcbMap = new System.Windows.Forms.PictureBox();
            this.lblNameOfState = new System.Windows.Forms.Label();
            this.txtNameOfState = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMap
            // 
            this.pcbMap.Image = global::Utilize.Properties.Resources.Main;
            this.pcbMap.Location = new System.Drawing.Point(3, 1);
            this.pcbMap.Name = "pcbMap";
            this.pcbMap.Size = new System.Drawing.Size(800, 600);
            this.pcbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbMap.TabIndex = 0;
            this.pcbMap.TabStop = false;
            this.pcbMap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pcbMap_MouseDoubleClick);
            this.pcbMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbMap_MouseMove);
            // 
            // lblNameOfState
            // 
            this.lblNameOfState.AutoSize = true;
            this.lblNameOfState.Location = new System.Drawing.Point(880, 1);
            this.lblNameOfState.Name = "lblNameOfState";
            this.lblNameOfState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNameOfState.Size = new System.Drawing.Size(42, 13);
            this.lblNameOfState.TabIndex = 1;
            this.lblNameOfState.Text = "استان :";
            // 
            // txtNameOfState
            // 
            this.txtNameOfState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameOfState.Location = new System.Drawing.Point(809, 17);
            this.txtNameOfState.Name = "txtNameOfState";
            this.txtNameOfState.ReadOnly = true;
            this.txtNameOfState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNameOfState.Size = new System.Drawing.Size(110, 21);
            this.txtNameOfState.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Location = new System.Drawing.Point(809, 58);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(110, 21);
            this.txtAmount.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(880, 42);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAmount.Size = new System.Drawing.Size(32, 13);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "مقدار";
            // 
            // IranMapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtNameOfState);
            this.Controls.Add(this.lblNameOfState);
            this.Controls.Add(this.pcbMap);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximumSize = new System.Drawing.Size(925, 600);
            this.MinimumSize = new System.Drawing.Size(925, 600);
            this.Name = "IranMapControl";
            this.Size = new System.Drawing.Size(925, 600);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMap;
        private System.Windows.Forms.Label lblNameOfState;
        private System.Windows.Forms.TextBox txtNameOfState;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
    }
}
