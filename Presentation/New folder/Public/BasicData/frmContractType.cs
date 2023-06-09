using System;
using System.Data;
using System.Windows.Forms;
using ERMS.Model;
//
using Infragistics.Win.UltraWinGrid;
using Presentation.Public;
using MyDialogButton = Utilize.MyDialogButton;
using Routines = Utilize.Routines;

namespace Presentation.Tabs.BasicData
{
    public partial class frmContractType : Form
    {

        public frmContractType()
        {
            InitializeComponent();
            dgvResoult.eventSaveReportExcelClick += new EventHandler(dgvResoult_eventSaveReportExcelClick);
            GeneralDataGridViewUltra = dgvResoult.ugd;
        }

        static void dgvResoult_eventSaveReportExcelClick(object sender, EventArgs e)
        {
            var excel=new Report.FrmSaveExcel {SourceData = (UltraGrid) sender};
            excel.ShowDialog();
        }

        private void frmContractType_Load(object sender, EventArgs e)
        {

            
            try
            {
                //ProgressBox.Show();
            var datatable =
                new DAL.Table_DataSetTableAdapters.Contract_TypeTableAdapter().GetData();

            datatable.Contract_Type_DescriptionColumn.Caption = "توضیحات";
            datatable.Contract_TypeColumn.Caption = "شماره حساب";
            datatable.Contract_LDColumn.Caption = "نوع حساب";
            var rowCollection=datatable.Select(
                item =>
                new
                    {
                        item.Contract_Type,
                        item.Contract_Type_Description,
                        type = item.Contract_LD == 1 ? "تسهیلات" : "سپرده ها"
                    });
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("شماره حساب") { Caption = "شماره حساب" });
            dataTable.Columns.Add(new DataColumn("توضیحات") { Caption = "توضیحات" });
            dataTable.Columns.Add(new DataColumn("نوع حساب") { Caption = "نوع حساب" });

            foreach (var row in rowCollection)
            {
                var newRow=dataTable.NewRow();
                newRow[0] = row.Contract_Type;
                newRow[1] = row.Contract_Type_Description;
                newRow[2] = row.type;
                dataTable.Rows.Add(newRow);
            }

                dgvResoult.DataSource = dataTable;

            }
            catch (Exception exception)
            {
                Presentation.Public.Routines.ShowErrorMessageFa("خطا", "خطا در جمع آوری داده ها رخ داده است", exception.Message,
                                                    Public.MyDialogButton.OK);
            }
            finally
            {
            }

            //ProgressBox.Hide();   

        }

        public void DoPrint()
        {
            //clsERMSGeneral.dgvActive = dgvResoult;
        }
        public void DoHelp()
        {
            //clsERMSGeneral.strHelp = "ContractType";
        }

        private void frmContractType_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmContractType_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Dispose();
        }

        private void dgvResoult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}