using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Presentation.Report
{
    public partial class FrmSaveExcel : Form
    {
        public FrmSaveExcel()
        {
            InitializeComponent();
        }

        public FrmSaveExcel(bool showSplitFileByColumn, bool showSplitFileByCount, bool showSplitSheetByColumn, bool showSplitSheetByCount)
        {
            InitializeComponent();
            saveDataInExcel1.ShowSplitFileByColumn = showSplitFileByColumn;
            saveDataInExcel1.ShowSplitFileByCount = showSplitFileByCount;
            saveDataInExcel1.ShowSplitSheetByColumn = showSplitSheetByColumn;
            saveDataInExcel1.ShowSplitSheetByCount = showSplitSheetByCount;
        }

        public UltraGrid SourceData;
        private void frmSaveExcel_Load(object sender, EventArgs e)
        {
            if (SourceData != null)
                saveDataInExcel1.Config(SourceData);
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveDataInExcel1_Load(object sender, EventArgs e)
        {

        }
    }
}
