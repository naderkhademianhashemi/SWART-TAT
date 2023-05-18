namespace Utilize.Report
{
    partial class UCSearchFiltering
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
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSearchFiltering));
            Infragistics.Win.UltraWinEditors.EditorButton editorButton1 = new Infragistics.Win.UltraWinEditors.EditorButton("Search");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            this.txtItem = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.chbItem = new System.Windows.Forms.CheckBox();
            this.txtItemMessage = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.txtItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance3.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance3.ImageBackground")));
            appearance3.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.txtItem.Appearance = appearance3;
            appearance2.Image = ((object)(resources.GetObject("appearance2.Image")));
            editorButton1.Appearance = appearance2;
            editorButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button;
            editorButton1.Key = "Search";
            appearance1.Image = ((object)(resources.GetObject("appearance1.Image")));
            appearance1.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            editorButton1.PressedAppearance = appearance1;
            editorButton1.Text = "جستجو";
            this.txtItem.ButtonsLeft.Add(editorButton1);
            this.txtItem.Enabled = false;
            this.txtItem.Location = new System.Drawing.Point(265, 9);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(184, 22);
            this.txtItem.TabIndex = 123;
            this.txtItem.EditorButtonClick += new Infragistics.Win.UltraWinEditors.EditorButtonEventHandler(this.txtItem_EditorButtonClick);
            // 
            // chbItem
            // 
            this.chbItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbItem.Location = new System.Drawing.Point(455, 8);
            this.chbItem.Name = "chbItem";
            this.chbItem.Size = new System.Drawing.Size(125, 24);
            this.chbItem.TabIndex = 125;
            this.chbItem.Text = "Title";
            this.chbItem.UseVisualStyleBackColor = true;
            this.chbItem.CheckedChanged += new System.EventHandler(this.chbItem_CheckedChanged);
            // 
            // txtItemMessage
            // 
            this.txtItemMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            appearance4.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance4.ImageBackground")));
            this.txtItemMessage.Appearance = appearance4;
            this.txtItemMessage.Location = new System.Drawing.Point(3, 10);
            this.txtItemMessage.Name = "txtItemMessage";
            this.txtItemMessage.ReadOnly = true;
            this.txtItemMessage.Size = new System.Drawing.Size(256, 22);
            this.txtItemMessage.TabIndex = 124;
            // 
            // UCSearchFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.chbItem);
            this.Controls.Add(this.txtItemMessage);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "UCSearchFiltering";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(583, 40);
            ((System.ComponentModel.ISupportInitialize)(this.txtItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtItem;
        private System.Windows.Forms.CheckBox chbItem;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtItemMessage;
    }
}
