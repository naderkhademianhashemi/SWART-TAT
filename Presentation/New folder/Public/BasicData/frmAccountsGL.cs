using System;
using System.Data;
using DAL;
//
using System.Windows.Forms;
using ERMSLib;
using Presentation.Public;
using Utilize;
using MyDialogButton = Utilize.MyDialogButton;
using Routines = Utilize.Routines;
using System.Globalization;
using System.Linq;
using ERMS.Model;

namespace Presentation.Tabs.BasicData
{
    public partial class frmAccountsGL : Form
    {
        DataTable dtAccountsGl;
        DataTable user;
        public frmAccountsGL()
        {
            InitializeComponent();
            InitializeForm();
            GeneralDataGridViewUltra = this.ugSWARTReport;
            user = new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(ERMS.Model.GlobalInfo.UserID);
            //clsERMSGeneral.InitializeTheme(this);
        }

        private void InitializeForm()
        {
            //this.bindingNavigatorSearchItem.ToolTipText = "جستجو";
            //this.bindingNavigatorReturnItem.ToolTipText = "بازگشت به حالت اول";
        }
        private void frmAccountsGL_Load(object sender, EventArgs e)
        {
             try
            {
                //ProgressBox.Show();
                //dgvAccountGL.FormatDataGridView();
                //dgvAccountGL.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                fdpStartDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate();
                //fill_AccountsGL();

            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowErrorMessageFa("خطا", ex.Message,Public.MyDialogButton.OK);
            }
            finally
            {
            }
            //ProgressBox.Hide();
        }

        private string GetFilter()
        {
            string fil = "";
            if (user.Rows.Count != 0)
            {                
                var organizationNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();
                foreach (var item in organizationNew_DataTable)
                {
                    fil += fil.Trim().Length == 0
                        ? "AND (branch_Id = " + item.Brach_Id.Trim() + " "
                                                : " OR branch_Id = " + item.Brach_Id.Trim() + "  ";

                }
                if (fil.Trim().Length > 0)
                    fil += ")";
            }            
            return fil;
        }

        private void fill_AccountsGL()
        {
            ProgressBox.Show();
            //dtAccountsGl = new DAL.SwartDataSetTableAdapters.GetDT_AccountsGLTableAdapter(). GetData(startIndex, endIndex);
            string Filter = GetFilter();

            dtAccountsGl = new DAL.AGL_DataSet().GetAccountGLBranch(fdpStartDate.SelectedDateTime, Filter, 1);
            dtAccountsGl.Columns["Accounting_Code"].Caption= "شماره حساب";
            dtAccountsGl.Columns["Accounting_Name"].Caption = "عنوان حساب";
            dtAccountsGl.Columns["Level"].Caption = "سطح";
            dtAccountsGl.Columns["Credit_Amount"].Caption = "مبلغ بستانكار";
            dtAccountsGl.Columns["Debt_Amount"].Caption = "مبلغ بدهكار";
            ugSWARTReport.DataSource = dtAccountsGl;
            ProgressBox.Hide();
        }
 

      
        public void DoPrint()
        {
            //clsERMSGeneral.dgvActive = ugSWARTReport;
        }

        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "AccountGL";
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            var frmSaveExcel = new Report.FrmSaveExcel() { SourceData = ugSWARTReport };
            frmSaveExcel.ShowDialog();
        }

        private void btnMdl_Click(object sender, EventArgs e)
        {
            if (splitContainer3.Panel2Collapsed == false)
            {
                splitContainer3.Panel2Collapsed = true;
                btnMdl.DefaultImage = Properties.Resources.S_Panleft1;
                btnMdl.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (splitContainer3.Panel2Collapsed == true)
            {
                splitContainer3.Panel2Collapsed = false;
                btnMdl.DefaultImage = Properties.Resources.S_PanRight1;
                btnMdl.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReload_CButtonClicked(object sender, EventArgs e)
        {
            fill_AccountsGL();
        }       
    }
}
