namespace Utilize
{
    partial class frmIranMap
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
            this.picMap = new System.Windows.Forms.PictureBox();
            this.iranMapControl1 = new Utilize.Maps.IranMap.IranMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.SuspendLayout();
            // 
            // picMap
            // 
            this.picMap.Location = new System.Drawing.Point(0, 0);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(61, 47);
            this.picMap.TabIndex = 0;
            this.picMap.TabStop = false;
            // 
            // iranMapControl1
            // 
            this.iranMapControl1.DataTable = null;
            this.iranMapControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.iranMapControl1.IsShowDetails = true;
            this.iranMapControl1.Location = new System.Drawing.Point(78, 12);
            this.iranMapControl1.MaximumSize = new System.Drawing.Size(925, 600);
            this.iranMapControl1.MinimumSize = new System.Drawing.Size(925, 600);
            this.iranMapControl1.Name = "iranMapControl1";
            this.iranMapControl1.Size = new System.Drawing.Size(925, 600);
            this.iranMapControl1.TabIndex = 1;
            // 
            // frmIranMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 665);
            this.Controls.Add(this.iranMapControl1);
            this.Controls.Add(this.picMap);
            this.Name = "frmIranMap";
            this.Text = "frmIranMap";
            this.Load += new System.EventHandler(this.frmIranMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMap;
        private Maps.IranMap.IranMapControl iranMapControl1;
    }
}