using System;
using System.Data;
using System.Windows.Forms;
using Utilize.Helper;
//
using Presentation.Public;
using ProgressBox = Presentation.Public.ProgressBox;
using Janus.Windows.UI.Tab;
using System.Drawing;
using ERMS.Logic;
using ERMS.Model;

namespace Presentation.Tabs.MarketRisk
{
    public partial class frmVaRPortfolio2 : BaseForm, IPrintable
    {
        #region VAR

        private MR mr;
        PersianTools.Dates.PersianDate pFrom, pTo;
        #endregion

        public frmVaRPortfolio2()
        {
            InitializeComponent();
            ERMSLib.clsERMSGeneral.InitializeTheme(this);
        }

        private void Init()
        {
            mr = new MR();
            pFrom = new PersianTools.Dates.PersianDate(DateTime.Now);
            fdpFrom.Text = fdpTo.Text = pFrom.FormatedDate("yyyy/MM/dd");
            GeneralDataGridView = dgvSummary;


            cmbPortfolio.DataSource = new DAL.MR_DataSet().GetPortfolios();
            cmbPortfolio.DisplayMember = "Code";
            cmbPortfolio.ValueMember = "Id";
            cmbPortfolio.SelectedIndex = 0;



            var tabPage = new UITabPage("توزیع سنجی") { Key = "frmBackTesting2", Name = "frmBackTesting2", AllowClose = true };
            tabPage.StateStyles.FormatStyle.BackgroundImage = Properties.Resources.S_But300px;
            tabPage.StateStyles.SelectedFormatStyle.BackgroundImage = Properties.Resources.S_But300px_Selected;
            tabPage.StateStyles.HotFormatStyle.BackgroundImage = Properties.Resources.S_But300px_Hover;

                        
            tabPage.StateStyles.FormatStyle.Font = new Font("B Nazanin", 10, FontStyle.Bold);
            tabPage.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.FromArgb(55, 33, 11);
            tabPage.StateStyles.HotFormatStyle.Font = new Font("B Nazanin", 10, FontStyle.Bold);
            tabPage.StateStyles.HotFormatStyle.ForeColor = System.Drawing.Color.FromArgb(55, 33, 11);
            tabPage.StateStyles.SelectedFormatStyle.Font = new Font("B Nazanin", 10, FontStyle.Bold);


            var form = new Presentation.Tabs.MarketRisk.frmBackTesting2();
            form.TopLevel = false;
            tabPage.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            tabPage.AutoScroll = true;
            //form.Size = new Size(10, 10);   // tabPage.Size;
            form.WindowState = FormWindowState.Maximized;


            tabControl11.TabPages.Add(tabPage);
            form.Show();
        }
               
        private void frmVaRPortfolio_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void btnRun1_Click(object sender, EventArgs e)
        {
            var fil = ucfPortfoy.GetFilterStructureForSql();
            fil = fil.IsNullOrEmptyByTrim() ? "" : " where "+fil;
            fil = fil.Replace("'", " ");
            pFrom = new PersianTools.Dates.PersianDate(int.Parse(fdpFrom.Text.Substring(0, 4)), int.Parse(fdpFrom.Text.Substring(5, 2)), int.Parse(fdpFrom.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            var dtFrom = DateTime.Parse(pFrom.ToGregorian.ToString("yyyy/MM/dd"));

            pTo = new PersianTools.Dates.PersianDate(int.Parse(fdpTo.Text.Substring(0, 4)), int.Parse(fdpTo.Text.Substring(5, 2)), int.Parse(fdpTo.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            var dtTo = DateTime.Parse(pTo.ToGregorian.ToString("yyyy/MM/dd"));
            
            int nDays;
            Presentation.Public.Routines.GetNumericValue(txtNdays.Text, out nDays);
            double cl;
            Presentation.Public.Routines.GetNumericValue(txtCL.Text, out cl);
            int retEvalMethod = rdoLog.Checked ? 1 : 2;
            int AlphaLevel = int.Parse(txtAlphaLevel.Text);
            bool MonteCarlo = chbMonteCarlo.Checked;

            double vaR = 0, VarRiskMetrics = 0;
            
            try
            {
                ProgressBox.Show();
                double mu;
                double sigma;
                mr.RunVaRP1(dtFrom, dtTo, nDays, retEvalMethod, cl, fil, AlphaLevel, MonteCarlo, out mu, out sigma, out vaR, out VarRiskMetrics);


            txtVaR1.Text = vaR.ToString("###,##0.###");
            txtVaR1RM.Text = VarRiskMetrics.ToString("###,##0.###");


            var dt = mr.GetVaRPSummaryByElementID(fil);
            float discriminator = 0;
            foreach (DataRow dr in dt.Rows)
            {
                discriminator += int.Parse(dr["Number of Shares"].ToString())  * int.Parse(dr["Share Price"].ToString());
            }
            foreach (DataRow dr in dt.Rows)
            {
                dr["Weight"] = (float.Parse(dr["Number of Shares"].ToString()) * float.Parse(dr["Share Price"].ToString())) / discriminator;
            }
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

            fil = fil.Replace("ElementID", "Element_ID");
            dt = mr.GetVaRPMatrixByElementID(fil);
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
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("خطا" +  "\n" + ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }
                    
        }

        private void showDifferences()
        {
            if(txtVaR1.Text == string.Empty || txtVaR2.Text == string.Empty)
                return;
            
            decimal temp1 = decimal.Parse(txtVaR1.Text) - decimal.Parse(txtVaR2.Text);
            decimal temp2 = decimal.Parse(txtVaR1RM.Text) - decimal.Parse(txtVaR2RM.Text);
            if (Math.Abs(temp1) < 1)
                temp1 = 0;
            if (Math.Abs(temp2) < 1)
                temp2 = 0;
            string sign = temp1 >= 0 ? "+" : "";
            string sign2 = temp2 >= 0 ? "+" : "";
            txtDifference.Text = sign + temp1;
            txtDifferenceRM.Text = sign2 + temp2;
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            btnRun1_Click(sender, e);

            var fil = ucfPortfoy.GetFilterStructureForSql();
            fil = fil.IsNullOrEmptyByTrim() ? "" : " where " + fil; 
            
            dgvSTVariance.DataSource = mr.GetVaRPSigmaByElementID(fil);

            dgvSTVariance.Columns["ID"].HeaderText = "شناسه";
            dgvSTVariance.Columns["Description"].HeaderText = "توضيح";
            dgvSTVariance.Columns[2].HeaderText = "σ با وزن یکسان";

            
            Helper h = new Helper();
            h.FormatDataGridView(dgvSTVariance);
            dgvSTVariance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvSTVariance.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSTVariance.ReadOnly = false;
            dgvSTVariance.DefaultCellStyle.Format = "###,##0.####";
            fil = fil.Replace("ElementID", "Element_ID");
            dgvSTCorelation.DataSource = mr.GetVaRPCorel(fil);

            dgvSTCorelation.Columns["ID"].HeaderText = "شناسه درايه ماتريس";
            dgvSTCorelation.Columns["X"].HeaderText = "سهم 1";
            dgvSTCorelation.Columns["Y"].HeaderText = "سهم 2";
            dgvSTCorelation.Columns["Corelation"].HeaderText = "همبستگي با وزن یکسان";
            dgvSTCorelation.Columns["CorelationRM"].HeaderText = "همبستگي با وزن نمایی";
            dgvSTCorelation.Columns["id1"].Visible = false;
            dgvSTCorelation.Columns["id2"].Visible = false;
            dgvSTCorelation.DefaultCellStyle.Format = "###,##0.####";
                        
            h.FormatDataGridView(dgvSTCorelation);
            dgvSTCorelation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvSTCorelation.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSTCorelation.ReadOnly = false;           
        }
        private void dgvSTVariance_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex > -1 && e.RowIndex > -1)
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
            // Update Variance
            for (int i = 0; i < dgvSTVariance.RowCount; i++)
            {
                if (dgvSTVariance[2, i].Value.ToString() == "")
                {
                    dgvSTVariance[2, i].Value = "0";

                    mr.UpdateVariancePortfolio(Convert.ToInt32(dgvSTVariance["ID", i].Value.ToString())
                        , float.Parse(dgvSTVariance[2, i].Value.ToString()), float.Parse(dgvSTVariance[3, i].Value.ToString()));
                }
                else
                {
                    mr.UpdateVariancePortfolio(Convert.ToInt32(dgvSTVariance["ID", i].Value.ToString())
                        , float.Parse(dgvSTVariance[2, i].Value.ToString()), float.Parse(dgvSTVariance[3, i].Value.ToString()));
                }
            }

            // Update Correlation
            for (int i = 0; i < dgvSTCorelation.RowCount; i++)
            {
                if (dgvSTCorelation["Corelation", i].Value.ToString() == "")
                {
                    dgvSTCorelation["Corelation", i].Value = "0";

                    mr.UpdateCorrelationPortfolio(Convert.ToInt32(dgvSTCorelation["id1", i].Value.ToString()), 
                        Convert.ToInt32(dgvSTCorelation["id2", i].Value.ToString())
                        , float.Parse(dgvSTCorelation["Corelation", i].Value.ToString())
                        , float.Parse(dgvSTCorelation["CorelationRM", i].Value.ToString()));
                }
                else
                {
                    mr.UpdateCorrelationPortfolio(Convert.ToInt32(dgvSTCorelation["id1", i].Value.ToString()),
                        Convert.ToInt32(dgvSTCorelation["id2", i].Value.ToString())
                        , float.Parse(dgvSTCorelation["Corelation", i].Value.ToString())
                        , float.Parse(dgvSTCorelation["CorelationRM", i].Value.ToString()));

                }
            }


            var fil = ucfPortfoy.GetFilterStructureForSql();
            fil = fil.IsNullOrEmptyByTrim() ? "" : " where " + fil;

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

            double vaR = 0, vaRRiskMetrics = 0;


            try
            {
                //ProgressBox.Show();
                double mu;
                double sigma;
                mr.RunVaRP2(dtFrom, dtTo, nDays, retEvalMethod, cl, fil, out mu, out sigma, out vaR, out vaRRiskMetrics);                
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //ProgressBox.Hide();
            }

            txtVaR2.Text = vaR.ToString("###,##0.####");
            txtVaR2RM.Text = vaRRiskMetrics.ToString("###,##0.####");

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
                //ERMSLib.clsERMSGeneral.dgvActive = dgvSTCorelation;
                GeneralDataGridView = dgvSTCorelation;
            }
        }
        private void chkSTVariance_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSTVariance.Checked)
            {
                chkSTCorelation.Checked = false;
                chkSummary.Checked = false;
                chkMatrix.Checked = false;
                //ERMSLib.clsERMSGeneral.dgvActive = dgvSTVariance;
                GeneralDataGridView = dgvSTVariance;
            }
        }
        private void chkSummary_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSummary.Checked)
            {
                chkMatrix.Checked = false;
                chkSTCorelation.Checked = false;
                chkSTVariance.Checked = false;
                //ERMSLib.clsERMSGeneral.dgvActive = dgvSummary;
                GeneralDataGridView = dgvSummary;
            }
        }
        private void chkMatrix_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMatrix.Checked)
            {
                chkSummary.Checked = false;
                chkSTCorelation.Checked = false;
                chkSTVariance.Checked = false;
                //ERMSLib.clsERMSGeneral.dgvActive = dgvMatrix;
                GeneralDataGridView = dgvMatrix;
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

        private void dgvSTCorelation_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e != null && e.FormattedValue != null && e.FormattedValue != "")
            {
                //var oldValue = Convert.ToDouble(dgvSTCorelation[e.ColumnIndex, e.RowIndex].Value);
                var newValue = Convert.ToDouble(e.FormattedValue);

                if (newValue > 1 || newValue < -1)
                {
                    e.Cancel = true;
                    Utilize.Routines.ShowErrorMessageFa("خطا", "مقدار ورودی باید بین -1 و 1 باشد.", Utilize.MyDialogButton.OK);
                }
            }
        }

        private void RunRC_CButtonClicked(object sender, EventArgs e)
        {
            try
            {
                Utilize.Routines.ShowProcess();

                var fil = ucfPortfoy.GetFilterStructureForSql();
                fil = fil.IsNullOrEmptyByTrim() ? "" : " where " + fil;

                pFrom = new PersianTools.Dates.PersianDate(int.Parse(fdpFrom.Text.Substring(0, 4)), int.Parse(fdpFrom.Text.Substring(5, 2)), int.Parse(fdpFrom.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                var dtFrom = DateTime.Parse(pFrom.ToGregorian.ToString("yyyy/MM/dd"));

                pTo = new PersianTools.Dates.PersianDate(int.Parse(fdpTo.Text.Substring(0, 4)), int.Parse(fdpTo.Text.Substring(5, 2)), int.Parse(fdpTo.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                var dtTo = DateTime.Parse(pTo.ToGregorian.ToString("yyyy/MM/dd"));

                int nDays;
                Presentation.Public.Routines.GetNumericValue(txtNdays.Text, out nDays);
                double cl;
                Presentation.Public.Routines.GetNumericValue(txtCL.Text, out cl);
                int retEvalMethod = rdoLog.Checked ? 1 : 2;


                string portfoys = ucfPortfoy.GetAllItems();
                if (ucfPortfoy.IsChecked())
                    portfoys = ucfPortfoy.GetSelectedItems();

                int AlphaLevel = int.Parse(txtAlphaLevel.Text);
                bool MonteCarlo = chbMonteCarlo.Checked;

                //dgvRC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dgvRC.SelectionMode = DataGridViewSelectionMode.CellSelect;
                //dgvRC.RowHeadersVisible = false;
                //dgvRC.ColumnHeadersVisible = false;
                //dgvRC.CellBorderStyle = DataGridViewCellBorderStyle.Raised;

                dgvRC.DataSource = new DAL.MR_DataSet().GetDataTableRC(cmbPortfolio.SelectedIndex, dtFrom, dtTo, nDays, retEvalMethod, cl, fil, AlphaLevel, MonteCarlo);

                Helper h = new Helper();
                h.FormatDataGridView(dgvRC);
                dgvRC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



                dgvRC.DefaultCellStyle.Format = "###,##0.000000";
            }
            catch
            {
            }
            finally
            {
                Utilize.Routines.HideProcess();
            }
        }

        private void ucFiltering1_Load(object sender, EventArgs e)
        {

        }

        private void cmbPortfolio_ValueChanged(object sender, EventArgs e)
        {
            var ds = mr.GetPortfolioElements((int)cmbPortfolio.Value-1, false);
            ds.Columns["ID"].ColumnName = "ElementID";
            ucfPortfoy.DataSource = ds;
            ucfPortfoy.DisplayMember = "Descr";
            ucfPortfoy.ValueMember = "ElementID";

        }

        private void rdbChangeCorrelation_CheckedChanged(object sender, EventArgs e)
        {
            dgvSTCorelation.ReadOnly = !rdbChangeCorrelation.Checked;
            dgvSTVariance.ReadOnly = !rdbChangeVariance.Checked;
        }

        private void dgvSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        


    }
}