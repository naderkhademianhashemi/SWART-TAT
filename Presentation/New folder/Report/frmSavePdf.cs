using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;


namespace Presentation.Report
{
    public partial class frmSavePdf : Form
    {
        public frmSavePdf()
        {
            InitializeComponent();
        }

        public frmSavePdf(bool showSplitFileByColumn, bool showSplitFileByCount)
        {
            InitializeComponent();
            saveDataInpdf.ShowSplitFileByColumn = showSplitFileByColumn;
            saveDataInpdf.ShowSplitFileByCount = showSplitFileByCount;
            //saveDataInpdf.ShowSplitSheetByColumn = showSplitSheetByColumn;
            //saveDataInpdf.ShowSplitSheetByCount = showSplitSheetByCount;
        }

        public UltraGrid SourceData;
        private void frmSaveExcel_Load(object sender, EventArgs e)
        {
            if (SourceData != null)
                saveDataInpdf.Config(SourceData);
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
