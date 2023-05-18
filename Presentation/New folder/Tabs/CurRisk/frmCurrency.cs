using System;
using System.Data;
using System.Windows.Forms;
using ERMS.Logic;
using ERMS.Model;
using Presentation.Public;

namespace Presentation.Tabs.CurRisk
{
    public partial class frmCurrency : BaseForm, IPrintable
    {
        #region VAR
        //private const int CTE_Stock = 0;
        //private const int CTE_Forex = 1;

        private CurR cur;
        PersianTools.Dates.PersianDate pFrom ;  //add By soli
        #endregion

        public frmCurrency()
        {
            InitializeComponent();
            ERMSLib.clsERMSGeneral.InitializeTheme(this);
        }
        private void frmPortfolio_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            cur = new CurR();
            this.GeneralDataGridView = dgvTransaction;
            Helper h = new Helper();

            dgvCurrency.DataSource = new CurR().GetDTCurrency();
            h.FormatDataGridView(dgvCurrency);
            dgvCurrency.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCurrency.Columns["Currency_Description"].HeaderText = "ارز";
            dgvCurrency.Columns["Currency"].Visible = false;
        }

        private void dgvStock_CurrentCellChanged(object sender, EventArgs e)
        {
            FillTransaction();
        }

        public void FillTransaction()
        {
            if (dgvCurrency.CurrentRow != null)
            {
                int id = (int)dgvCurrency.CurrentRow.Cells["Currency"].Value;
                //Grid Add By soli/870413
                DataTable dt = cur.GetDTCurrencyPair_ByID(id);
                dgvTransaction.Columns.Clear();                
                dgvTransaction.DataSource = dt;

                Helper h = new Helper();
                h.FormatDataGridView(dgvTransaction);
            }
}
        public void DoPrint()
        {
            ERMSLib.clsERMSGeneral.dgvActive = dgvTransaction;
        }
        public void DoHelp()
        {
            ERMSLib.clsERMSGeneral.strHelp = "Portfo";
        }

        private void dgvForex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        //private void dgvPortfolio_CurrentCellChanged(object sender, EventArgs e)
        //{
        //    FillStock();
        //}

        //private void FillPortfoli()
        //{
        //    Helper h = new Helper();
        //    dgvPortfolio.DataSource = new DAL.MR_DataSet().GetPortfolios();
        //    h.FormatDataGridView(dgvPortfolio);
        //    dgvPortfolio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dgvPortfolio.Columns["Id"].Visible = false;
        //    dgvPortfolio.Columns["Description"].Visible = false;
        //    dgvPortfolio.Columns["Trading"].Visible = false;
        //    dgvPortfolio.Columns["Branch"].Visible = false;
        //    dgvPortfolio.Columns["Counterparty"].Visible = false;
        //    dgvPortfolio.ColumnHeadersVisible = false;
        //}

        //private void FillStock()
        //{
        //    if (dgvPortfolio.CurrentRow != null)
        //    {
        //        int id = (int)dgvPortfolio.CurrentRow.Cells["Id"].Value;
        //        mr = new MR();
        //        Helper h = new Helper();
        //        DataTable dt1 = mr.GetPortfolioElements(id, false);
        //        dgvCurrency.DataSource = dt1;
        //        h.FormatDataGridView(dgvCurrency);
        //        dgvCurrency.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //        dgvCurrency.Columns["ID"].Visible = false;
        //        dgvCurrency.Columns["TypeID"].Visible = false;
        //        dgvCurrency.ColumnHeadersVisible = false;
        //    }
        //}

        //private void tsbPortfolioRemove_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (dgvPortfolio.CurrentRow != null)
            
        //            if (Routines.ShowMessageBoxFa("با حذف پورتفو، تمامی سهام ها و تراکنش مربوط به آن ها نیز حذف می گردد" +
        //                                            "\n" + "آیا ادامه می دهید؟", "حذف پورتفو", MessageBoxButtons.YesNo, 
        //                                                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
        //            {
        //                int id = (int)dgvPortfolio.CurrentRow.Cells["Id"].Value;
        //                mr.DeletePortfoli(id);
        //                dgvCurrency.DataSource = null;
        //                dgvCurrency.Refresh();
        //                FillPortfoli();
        //            }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}

        //private void tsbStockRemove_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (dgvCurrency.CurrentRow != null)
        //            if (Routines.ShowMessageBoxFa("با حذف سهام، تمامی تراکنش های مربوط به آن نیز حذف می گردد" +
        //                                                "\n" + "آیا ادامه می دهید؟", "حذف سهام", MessageBoxButtons.YesNo,
        //                                                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
        //            {
        //                int id = (int)dgvCurrency.CurrentRow.Cells["Id"].Value;
        //                mr.DeleteStock(id);
        //                dgvCurrency.DataSource = null;
        //                dgvCurrency.Refresh();
        //                FillStock();
        //            }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}
    }
}