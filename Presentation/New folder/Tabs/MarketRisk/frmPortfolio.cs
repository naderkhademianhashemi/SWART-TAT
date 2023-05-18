using System;
using System.Data;
using System.Windows.Forms;
using ERMS.Logic;
using ERMS.Model;
using Presentation.Public;

namespace Presentation.Tabs.MarketRisk
{
    public partial class frmPortfolio : BaseForm, IPrintable
    {
        #region VAR
        //private const int CTE_Stock = 0;
        //private const int CTE_Forex = 1;

        private MR mr;
        PersianTools.Dates.PersianDate pFrom ;  //add By soli
        #endregion

        public frmPortfolio()
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
            this.GeneralDataGridView = dgvTransaction;
            Helper h = new Helper();

            dgvPortfolio.DataSource = new DAL.MR_DataSet().GetPortfolios();
            h.FormatDataGridView(dgvPortfolio);
            dgvPortfolio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPortfolio.Columns["Id"].Visible = false;
            dgvPortfolio.Columns["Description"].Visible = false;
            dgvPortfolio.Columns["Trading"].Visible = false;
            dgvPortfolio.Columns["Branch"].Visible = false;
            dgvPortfolio.Columns["Counterparty"].Visible = false;
            dgvPortfolio.ColumnHeadersVisible = false;
        }

        private void dgvStock_CurrentCellChanged(object sender, EventArgs e)
        {
            FillTransaction();
        }

        public void FillTransaction()
{
    if (dgvStock.CurrentRow != null)
    {
        int id = (int)dgvStock.CurrentRow.Cells["ID"].Value;
        //Grid Add By soli/870413
        DataTable dt = mr.GetElementTransactions(id);
        dgvTransaction.Columns.Clear();

        //Farsi Date
        DataColumn dcolDateF = new DataColumn("DateF", typeof(String));
        dt.Columns.Add(dcolDateF);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (dt.Rows[i]["Date"].ToString() != "")
            {
                pFrom = new PersianTools.Dates.PersianDate((DateTime)dt.Rows[i]["Date"]);
                dt.Rows[i]["DateF"] = pFrom.FormatedDate("yyyy/MM/dd");

            }
        }

        dgvTransaction.DataSource = dt;
        //End Add By soli/870413
        dgvTransaction.Columns["ID"].HeaderText = "سطر";
        dgvTransaction.Columns["Description"].HeaderText = "توضيح";
        dgvTransaction.Columns["Long or Short"].HeaderText = "خريد يا فروش";
        dgvTransaction.Columns["DateF"].HeaderText = "تاریخ";
        dgvTransaction.Columns["Nominal"].HeaderText = "تعداد";
        dgvTransaction.Columns["Price"].HeaderText = "قیمت";
        dgvTransaction.Columns["Date"].Visible = false;


        dgvPosition.DataSource = mr.GetElementPosition(id);
        dgvPosition.Columns["ID"].HeaderText = "سطر";
        dgvPosition.Columns["Description"].HeaderText = "توضيح";
        dgvPosition.Columns["NumShare"].HeaderText = "تعداد سهام";
        dgvPosition.Columns["RateMean"].HeaderText = "نرخ ميانگين هر سهم";
        dgvPosition.Columns["RemainingSum"].HeaderText = "جمع مانده تمام شده";
        dgvPosition.Columns["DailyRate"].HeaderText = "نرخ روز هرسهم";
        dgvPosition.Columns["DailyValue"].HeaderText = "ارزش روز سهام";
        dgvPosition.Columns["IncDecValue"].HeaderText = "افزايش يا كاهش ارزش";
        dgvPosition.Columns["IncDecPercentile"].HeaderText = "درصد رشد يا كاهش";

        Helper h = new Helper();
        h.FormatDataGridView(dgvTransaction);
        h.FormatDataGridView(dgvPosition);
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

        private void cmbPortfolio_ValueChanged(object sender, EventArgs e)
        {
            mr = new MR();
            Helper h = new Helper();
            DataTable dt1 = mr.GetPortfolioElements((int)cmbPortfolio.Value - 1, false);
            dgvStock.DataSource = dt1;
            h.FormatDataGridView(dgvStock);
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.Columns["ID"].Visible = false;
            dgvStock.Columns["TypeID"].Visible = false;
            dgvStock.ColumnHeadersVisible = false;

        }

        private void groupBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPortfolio_CurrentCellChanged(object sender, EventArgs e)
        {
            FillStock();
        }

        private void FillPortfoli()
        {
            Helper h = new Helper();
            dgvPortfolio.DataSource = new DAL.MR_DataSet().GetPortfolios();
            h.FormatDataGridView(dgvPortfolio);
            dgvPortfolio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPortfolio.Columns["Id"].Visible = false;
            dgvPortfolio.Columns["Description"].Visible = false;
            dgvPortfolio.Columns["Trading"].Visible = false;
            dgvPortfolio.Columns["Branch"].Visible = false;
            dgvPortfolio.Columns["Counterparty"].Visible = false;
            dgvPortfolio.ColumnHeadersVisible = false;
        }

        private void FillStock()
        {
            if (dgvPortfolio.CurrentRow != null)
            {
                int id = (int)dgvPortfolio.CurrentRow.Cells["Id"].Value;
                mr = new MR();
                Helper h = new Helper();
                DataTable dt1 = mr.GetPortfolioElements(id, false);
                dgvStock.DataSource = dt1;
                h.FormatDataGridView(dgvStock);
                dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStock.Columns["ID"].Visible = false;
                dgvStock.Columns["TypeID"].Visible = false;
                dgvStock.ColumnHeadersVisible = false;
            }
        }
        private void tsbPortfolioRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPortfolio.CurrentRow != null)
            
                    if (Routines.ShowMessageBoxFa("با حذف پورتفو، تمامی سهام ها و تراکنش مربوط به آن ها نیز حذف می گردد" +
                                                    "\n" + "آیا ادامه می دهید؟", "حذف پورتفو", MessageBoxButtons.YesNo, 
                                                        MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int id = (int)dgvPortfolio.CurrentRow.Cells["Id"].Value;
                        mr.DeletePortfoli(id);
                        dgvStock.DataSource = null;
                        dgvStock.Refresh();
                        FillPortfoli();
                    }
            }
            catch (Exception ex)
            {
            }
        }

        private void tsbStockRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStock.CurrentRow != null)
                    if (Routines.ShowMessageBoxFa("با حذف سهام، تمامی تراکنش های مربوط به آن نیز حذف می گردد" +
                                                        "\n" + "آیا ادامه می دهید؟", "حذف سهام", MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int id = (int)dgvStock.CurrentRow.Cells["Id"].Value;
                        mr.DeleteStock(id);
                        dgvStock.DataSource = null;
                        dgvStock.Refresh();
                        FillStock();
                    }
            }
            catch (Exception ex)
            {
            }
        }
    }
}