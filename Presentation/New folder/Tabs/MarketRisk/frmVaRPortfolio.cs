using System;
using System.Windows.Forms;
using ERMS.Logic;
using ERMS.Model;

//
using Presentation.Public;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.Tabs.MarketRisk
{
    public partial class frmVaRPortfolio : BaseForm, IPrintable
    {
        #region VAR
        private MR mr;
        PersianTools.Dates.PersianDate pFrom, pTo;
        #endregion

        public frmVaRPortfolio()
        {
            InitializeComponent();
            ERMSLib.clsERMSGeneral.InitializeTheme(this);
        }

        private void Init()
        {
            mr = new MR();
            pFrom = new PersianTools.Dates.PersianDate(DateTime.Now);
            fdpFrom.Text = fdpTo.Text = pFrom.FormatedDate("yyyy/MM/dd");
          
        }
               
        private void frmVaRPortfolio_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void btnRun1_Click(object sender, EventArgs e)
        {
            pFrom = new PersianTools.Dates.PersianDate(int.Parse(fdpFrom.Text.Substring(0, 4)), int.Parse(fdpFrom.Text.Substring(5, 2)), int.Parse(fdpFrom.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            var dtFrom = DateTime.Parse(pFrom.ToGregorian.ToString("yyyy/MM/dd"));

            pTo = new PersianTools.Dates.PersianDate(int.Parse(fdpTo.Text.Substring(0, 4)), int.Parse(fdpTo.Text.Substring(5, 2)), int.Parse(fdpTo.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            var dtTo = DateTime.Parse(pTo.ToGregorian.ToString("yyyy/MM/dd"));
            
            int nDays;
            Presentation.Public.Routines.GetNumericValue(txtNdays.Text, out nDays);
            double cl;
            Presentation.Public.Routines.GetNumericValue(txtCL.Text, out cl);
            int retEvalMethod = rdoLog.Checked ? 1 : 2;

            double vaR = 0;
            try
            {
                ProgressBox.Show();
                double mu;
                double sigma;
                mr.RunVaRP1(dtFrom, dtTo, nDays, retEvalMethod, cl, out mu, out sigma, out vaR);
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }

            txtVaR1.Text = vaR.ToString("###,##0.###");

            var dt = mr.GetVaRPSummary();
            dgvSummary.Columns.Clear();
            dgvSummary.DataSource = dt;

            dgvSummary.Columns["ID"].HeaderText = "كد";
            dgvSummary.Columns["Descr"].HeaderText = "شرح";
            dgvSummary.Columns["Weight"].HeaderText = "وزن";
            dgvSummary.Columns["Number of Shares"].HeaderText = "تعداد سهام";
            dgvSummary.Columns["Share Price"].HeaderText = "قيمت سهام";
            dgvSummary.Columns["Today Price"].HeaderText = "قيمت امروز";
            
            Helper h = new Helper();
            h.FormatDataGridView(dgvSummary);
            dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn
                                                 {
                                                     MinimumWidth = 1023,
                                                     Name = "Dummy",
                                                     HeaderText = string.Empty
                                                 };
            dgvSummary.Columns.Add(tCol);

            dgvSummary.Columns["ID"].Visible = false;
            
            dt = mr.GetVaRPMatrix();
            dgvMatrix.Columns.Clear();
            dgvMatrix.DataSource = dt;
            
            h.FormatDataGridView(dgvMatrix);
            dgvMatrix.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatrix.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvMatrix.RowHeadersVisible = false;
            dgvMatrix.ColumnHeadersVisible = false;
            dgvMatrix.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvMatrix.DefaultCellStyle.Format = "###,##0.####";

            dgvSummary.DefaultCellStyle.Format = "###,##0.###";

            
        
        }

        private void showDifferences()
        {
            if(txtVaR1.Text == string.Empty || txtVaR2.Text == string.Empty)
                return;
            
            decimal temp1 = decimal.Parse(txtVaR1.Text) - decimal.Parse(txtVaR2.Text);

            string sign = temp1 >= 0 ? "+" : "";

            txtDifference.Text = sign + temp1;
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            dgvSTVariance.DataSource = mr.GetVaRPSigma();

            dgvSTVariance.Columns["ID"].HeaderText = "شناسه";
            dgvSTVariance.Columns["Description"].HeaderText = "توضيح";
            
            Helper h = new Helper();
            h.FormatDataGridView(dgvSTVariance);
            dgvSTVariance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvSTVariance.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSTVariance.ReadOnly = false;
            dgvSTVariance.DefaultCellStyle.Format = "###,##0.####";

            dgvSTCorelation.DataSource = mr.GetVaRPCorel();

            dgvSTCorelation.Columns["ID"].HeaderText = "شناسه درايه ماتريس";
            dgvSTCorelation.Columns["X"].HeaderText = "سهم 1";
            dgvSTCorelation.Columns["Y"].HeaderText = "سهم 2";
            dgvSTCorelation.Columns["Corelation"].HeaderText = "همبستگي";
            dgvSTCorelation.DefaultCellStyle.Format = "###,##0.####";
                        
            h.FormatDataGridView(dgvSTCorelation);
            dgvSTCorelation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvSTCorelation.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSTCorelation.ReadOnly = false;           
        }
        private void dgvSTVariance_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ChangeValue1(e.ColumnIndex, e.RowIndex);
        }
        private void dgvSTCorelation_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ChangeValue2(e.ColumnIndex, e.RowIndex);
        }
        private void ChangeValue1(int columnIndex, int rowIndex)
        {
            try
            {
                double val = Convert.ToDouble(dgvSTVariance[columnIndex, rowIndex].Value);
                int id = (int)dgvSTVariance["ID", rowIndex].Value;
                mr.ChangeSTSigma(id, val);
            }
            catch { }
        }
        private void ChangeValue2(int columnIndex, int rowIndex)
        {
            try
            {
                double val = Convert.ToDouble(dgvSTCorelation[columnIndex, rowIndex].Value);
                int id = (int)dgvSTCorelation["ID", rowIndex].Value;
                mr.ChangeSTCorelation(id, val);
            }
            catch { }
        }
        private void btnRun2_Click(object sender, EventArgs e)
        {
            pFrom = new PersianTools.Dates.PersianDate(int.Parse(fdpFrom.Text.Substring(0, 4)), int.Parse(fdpFrom.Text.Substring(5, 2)), int.Parse(fdpFrom.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            DateTime dtFrom = DateTime.Parse(pFrom.ToGregorian.ToString("yyyy/MM/dd"));

            pTo = new PersianTools.Dates.PersianDate(int.Parse(fdpTo.Text.Substring(0, 4)), int.Parse(fdpTo.Text.Substring(5, 2)), int.Parse(fdpTo.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            DateTime dtTo = DateTime.Parse(pTo.ToGregorian.ToString("yyyy/MM/dd"));
            
            //DateTime dtFrom = dtpFrom.Value;
            //DateTime dtTo = dtpTo.Value;
            int nDays;
            Presentation.Public.Routines.GetNumericValue(txtNdays.Text, out nDays);
            double cl;
            Presentation.Public.Routines.GetNumericValue(txtCL.Text, out cl);
            int retEvalMethod = rdoLog.Checked ? 1 : 2;

            double vaR = 0;


            try
            {
                ProgressBox.Show();
                double mu;
                double sigma;
                mr.RunVaRP2(dtFrom, dtTo, nDays, retEvalMethod, cl, out mu, out sigma, out vaR);                
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }

            txtVaR2.Text = vaR.ToString("###,##0.####");
            showDifferences();
        }

        private void txtVaR2_TextChanged(object sender, EventArgs e)
        {

        }
        private void chkSTCorelation_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSTCorelation.Checked)
            {
                chkSTVariance.Checked = false;
                chkSummary.Checked = false;
                chkMatrix.Checked = false;
                ERMSLib.clsERMSGeneral.dgvActive = dgvSTCorelation;
            }
        }
        private void chkSTVariance_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSTVariance.Checked)
            {
                chkSTCorelation.Checked = false;
                chkSummary.Checked = false;
                chkMatrix.Checked = false;
                ERMSLib.clsERMSGeneral.dgvActive = dgvSTVariance;
            }
        }
        private void chkSummary_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSummary.Checked)
            {
                chkMatrix.Checked = false;
                chkSTCorelation.Checked = false;
                chkSTVariance.Checked = false;
                ERMSLib.clsERMSGeneral.dgvActive = dgvSummary;
            }
        }
        private void chkMatrix_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMatrix.Checked)
            {
                chkSummary.Checked = false;
                chkSTCorelation.Checked = false;
                chkSTVariance.Checked = false;
                ERMSLib.clsERMSGeneral.dgvActive = dgvMatrix;
            }
        }

        public void DoPrint()
        {
            //empty print
        }
        public void DoHelp()
        {
            ERMSLib.clsERMSGeneral.strHelp = "VaRPortfolio";
        }


    }
}