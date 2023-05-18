using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Infragistics.Win;
using Presentation.Public;
using MyDialogButton = Presentation.Public.MyDialogButton;

namespace Presentation.Setting
{
    public partial class frmSettingNameColumnOfReport : BaseForm
    {
        public frmSettingNameColumnOfReport()
        {
            InitializeComponent();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProgressBox.Show();
            try
            {
                foreach (DataGridViewRow item in dgvColumnOfReport.Rows)
                {
                    if (item.Cells[3].Value.ToString() != null && item.Cells[3].Value.ToString().Trim() != "")
                    {
                        int OrderBy = int.Parse(item.Cells["OrderBy"].Value.ToString().Trim());
                        if(dgvColumnOfReport.Columns["IsShowInRangeForm"].Visible)
                            new DAL.Table_DataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().UpdateSeletedColumn(item.Cells[3].Value.ToString().Trim(),OrderBy, (bool)item.Cells["IsShowInRangeForm"].Value, (long)item.Cells[0].Value);
                        else
                            new DAL.Table_DataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().UpdateSeletedColumn(item.Cells[3].Value.ToString().Trim(), OrderBy, false, (long)item.Cells[0].Value);
                    }
                    else
                    {
                        Routines.ShowErrorMessageFa("خطا", "لطفا برای سلول مربوطه مقدار وارد کنید.",
                                               Presentation.Public.MyDialogButton.OK);
                        return;
                    }

                }
                Routines.ShowMessageBoxFa("عملیات ذخیره با موفقیت انجام شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Routines.ShowErrorMessageFa( "ذخیره", ex.Message, MyDialogButton.OK);
            }

            ProgressBox.Hide();

        }       

        private void frmSettingNameColumnOfReport_Load(object sender, EventArgs e)
        {
            var reportsName =
                new DAL.GeneralDataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetData().Select(
                    item => item.NameReport.Trim()).Distinct();
            foreach (var reportName in reportsName)
            {
                cmbReport.Items.Add(new ValueListItem {DisplayText = reportName});
            }
            cmbReport.SelectedIndex = 0;
            this.Dock = DockStyle.Fill;
        }

        private void cmbReport_SelectionChanged(object sender, EventArgs e)
        {
            var reportsName =
                           new DAL.Table_DataSetTableAdapters.SelectedColumnForShowInReportTableAdapter().GetDataByGetNameReport(cmbReport.SelectedItem.ToString().Trim());

            dgvColumnOfReport.DataSource = reportsName;
            dgvColumnOfReport.Columns["NameReport"].Visible = false;
            dgvColumnOfReport.Columns["Id"].Visible = false;
            dgvColumnOfReport.Columns["NameColumn"].ReadOnly = true;
            dgvColumnOfReport.Columns["NameReport"].ReadOnly = true;
            dgvColumnOfReport.Columns["Id"].ReadOnly = true;
            dgvColumnOfReport.Columns["NameColumn"].HeaderText = "نام سرستون";
            dgvColumnOfReport.Columns["AliasName"].HeaderText = "نام مستعار";
            dgvColumnOfReport.Columns["Id"].HeaderText = "شناسه";
            dgvColumnOfReport.Columns["OrderBy"].HeaderText = "ترتیب نمایش";
            dgvColumnOfReport.Columns["IsShowInRangeForm"].Visible = false;

            if (cmbReport.SelectedItem.ToString().Equals("VDepositReport") ||
                                    cmbReport.SelectedItem.ToString().Equals("VLReport"))
            {
                dgvColumnOfReport.Columns["IsShowInRangeForm"].Visible = true;
                dgvColumnOfReport.Columns["IsShowInRangeForm"].HeaderText = "نمایش در گزارش بازه سازی";
                //dgvColumnOfReport.Columns["IsShowInRangeForm"].CellType = DataGridView
            }
        }
    }
}
