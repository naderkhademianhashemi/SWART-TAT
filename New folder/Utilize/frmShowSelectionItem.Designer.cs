namespace Utilize
{
    partial class frmShowSelectionItem
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
            this.treeSelectedItem = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeSelectedItem
            // 
            this.treeSelectedItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSelectedItem.Location = new System.Drawing.Point(0, 0);
            this.treeSelectedItem.Name = "treeSelectedItem";
            this.treeSelectedItem.Size = new System.Drawing.Size(451, 482);
            this.treeSelectedItem.TabIndex = 0;
            // 
            // frmShowSelectionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 482);
            this.Controls.Add(this.treeSelectedItem);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowSelectionItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmShowSelectionItem";
            this.Load += new System.EventHandler(this.frmShowSelectionItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeSelectedItem;

    }
}