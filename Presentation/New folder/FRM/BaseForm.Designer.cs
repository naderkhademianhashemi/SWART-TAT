namespace Presentation
{
    partial class BaseForm
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.ultraGridPrintDocument = new Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(this.components);
            this.ultraPrintPreviewDialog = new Infragistics.Win.Printing.UltraPrintPreviewDialog(this.components);
            this.SuspendLayout();
            // 
            // ultraGridPrintDocument
            // 
            this.ultraGridPrintDocument.DocumentName = "گزارش";
            this.ultraGridPrintDocument.Footer.TextCenter = "";
            appearance1.FontData.BoldAsString = "True";
            appearance1.FontData.Name = "B Nazanin";
            appearance1.FontData.SizeInPoints = 14F;
            this.ultraGridPrintDocument.Header.Appearance = appearance1;
            this.ultraGridPrintDocument.SaveSettings = true;
            this.ultraGridPrintDocument.SettingsKey = "frmShowReprt.ultraGridPrintDocument";
            this.ultraGridPrintDocument.PagePrinting += new Infragistics.Win.Printing.PagePrintingEventHandler(this.ultraGridPrintDocument_PagePrinting);
            // 
            // ultraPrintPreviewDialog
            // 
            this.ultraPrintPreviewDialog.Document = this.ultraGridPrintDocument;
            this.ultraPrintPreviewDialog.Name = "ultraPrintPreviewDialog1";
            this.ultraPrintPreviewDialog.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2010;
            // 
            // BaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(42)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.Configuration.IPersistComponentSettings)(this.ultraGridPrintDocument)).LoadComponentSettings();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGridPrintDocument ultraGridPrintDocument;
        private Infragistics.Win.Printing.UltraPrintPreviewDialog ultraPrintPreviewDialog;
    }
}