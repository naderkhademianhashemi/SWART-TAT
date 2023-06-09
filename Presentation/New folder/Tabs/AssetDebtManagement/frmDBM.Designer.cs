namespace Presentation.Tabs.AssetDebtManagement
{
    partial class frmDBM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBM));
            this.tblList1 = new Janus.Windows.UI.Tab.UITab();
            this.tpL = new Janus.Windows.UI.Tab.UITabPage();
            this.tpG = new Janus.Windows.UI.Tab.UITabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tblList1)).BeginInit();
            this.tblList1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblList1
            // 
            this.tblList1.BackColor = System.Drawing.Color.Transparent;
            this.tblList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblList1.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(228)))));
            this.tblList1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tblList1.ItemSize = new System.Drawing.Size(66, 31);
            this.tblList1.Location = new System.Drawing.Point(0, 0);
            this.tblList1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tblList1.Name = "tblList1";
            this.tblList1.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.tblList1.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.tblList1.Size = new System.Drawing.Size(918, 421);
            this.tblList1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tblList1.TabIndex = 55;
            this.tblList1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.tpL,
            this.tpG});
            this.tblList1.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.Transparent;
            this.tblList1.TabsStateStyles.SelectedFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tblList1.TabStripFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(198)))), ((int)(((byte)(115)))));
            this.tblList1.UseThemes = false;
            // 
            // tpL
            // 
            this.tpL.Location = new System.Drawing.Point(1, 34);
            this.tpL.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tpL.Name = "tpL";
            this.tpL.Size = new System.Drawing.Size(916, 386);
            this.tpL.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpL.StateStyles.FormatStyle.BackgroundImage")));
            this.tpL.StateStyles.FormatStyle.BackgroundImageDrawMode = Janus.Windows.UI.BackgroundImageDrawMode.Center;
            this.tpL.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpL.StateStyles.HotFormatStyle.BackgroundImage")));
            this.tpL.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpL.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.tpL.TabStop = true;
            this.tpL.Text = "سپرده";
            // 
            // tpG
            // 
            this.tpG.Location = new System.Drawing.Point(1, 34);
            this.tpG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tpG.Name = "tpG";
            this.tpG.Size = new System.Drawing.Size(722, 478);
            this.tpG.StateStyles.FormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpG.StateStyles.FormatStyle.BackgroundImage")));
            this.tpG.StateStyles.FormatStyle.BackgroundImageDrawMode = Janus.Windows.UI.BackgroundImageDrawMode.Center;
            this.tpG.StateStyles.HotFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpG.StateStyles.HotFormatStyle.BackgroundImage")));
            this.tpG.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Transparent;
            this.tpG.StateStyles.SelectedFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.Transparent;
            this.tpG.StateStyles.SelectedFormatStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpG.StateStyles.SelectedFormatStyle.BackgroundImage")));
            this.tpG.TabStop = true;
            this.tpG.Text = "ضمانت نامه";
            // 
            // frmDBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(918, 421);
            this.Controls.Add(this.tblList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "frmDBM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "  مدل منحنی نرخ سود     ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDBM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblList1)).EndInit();
            this.tblList1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab tblList1;
        private Janus.Windows.UI.Tab.UITabPage tpL;
        private Janus.Windows.UI.Tab.UITabPage tpG;



    }
}