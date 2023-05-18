namespace Presentation.Tree_View
{
    partial class frmTree
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
            Presentation.Public.MyControls.TreeViewEx.TreeInfoEx treeInfoEx2 = new Presentation.Public.MyControls.TreeViewEx.TreeInfoEx();
            this.treeViewEx1 = new Presentation.Public.MyControls.TreeViewEx.TreeViewEx();
            this.SuspendLayout();
            // 
            // treeViewEx1
            // 
            this.treeViewEx1.Location = new System.Drawing.Point(40, 32);
            this.treeViewEx1.Name = "treeViewEx1";
            this.treeViewEx1.Size = new System.Drawing.Size(287, 276);
            this.treeViewEx1.TabIndex = 0;
            this.treeViewEx1.TreeInfoEx = treeInfoEx2;
            // 
            // frmTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeViewEx1);
            this.Name = "frmTree";
            this.Text = "frmTree";
            this.Load += new System.EventHandler(this.frmTree_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Public.MyControls.TreeViewEx.TreeViewEx treeViewEx1;
    }
}