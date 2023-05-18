using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ERMS.Logic;

//

using ERMSLib;
using Presentation.Public;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.Tabs.MarketRisk
{
    public partial class frmBackTesting2 : BaseForm
    {
        #region VAR
        private const int CTE_Stock = 0;
        private const int CTE_Forex = 1;

        private MR mr;
        PersianTools.Dates.PersianDate pFrom, pTo;
        #endregion

        public frmBackTesting2()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
        }

        private void Init()
        {
            //cmbSecurityType.AddItemsRange(new string[] { "سهام", "فاركس" });
            //cmbSecurityType.AddItemsRange(new string[] { "سهام" });

            mr = new MR();
            //cmbSecurity.DataSource = mr.GetPortfolioElements(CTE_Stock);
            //cmbSecurity.DisplayMember = "Descr";
            //cmbSecurity.ValueMember = "ID";

            cmbSecurityType.DataSource = new DAL.MR_DataSet().GetPortfolios();
            cmbSecurityType.DisplayMember = "Code";
            cmbSecurityType.ValueMember = "Id";
            cmbSecurityType.SelectedIndex = 0;


            pFrom = new PersianTools.Dates.PersianDate((DateTime)DateTime.Now);
            fdpFrom.Text = fdpTo.Text = pFrom.FormatedDate("yyyy/MM/dd");
            GeneralDataGridView = clsERMSGeneral.dgvActive;
        }

        private void frmBackTesting_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            double d, dd;

            //if (cmbSecurity.SelectedIndex == -1)
            //    return;
            cmbSecurity.SelectedIndex = 0;
            //FArsi Date
            pFrom = new PersianTools.Dates.PersianDate(int.Parse(fdpFrom.Text.Substring(0, 4)), int.Parse(fdpFrom.Text.Substring(5, 2)), int.Parse(fdpFrom.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            DateTime dtFrom = DateTime.Parse(pFrom.ToGregorian.ToString("yyyy/MM/dd"));


            pTo = new PersianTools.Dates.PersianDate(int.Parse(fdpTo.Text.Substring(0, 4)), int.Parse(fdpTo.Text.Substring(5, 2)), int.Parse(fdpTo.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            DateTime dtTo = DateTime.Parse(pTo.ToGregorian.ToString("yyyy/MM/dd"));


            //DateTime dtFrom = dtpFrom.Value;
            //DateTime dtTo = dtpTo.Value;
            double valFrom = 0, valTo = 0, valIncr = 0;

            //Presentation.Public.Routines.GetNumericValue(txtValFrom.Text, out valFrom);
            //Presentation.Public.Routines.GetNumericValue(txtValTo.Text, out valTo);
            Presentation.Public.Routines.GetNumericValue(txtIncr.Text, out valIncr);

            ////int elementID = (int)cmbSecurity.SelectedValue;

            ////CHI
            double indx = 0;
            ////DataTable dt = new DAL.MR_DataSet().RunChi(elementID, out d, out dd, valIncr, out indx);
            ////dgvChi.Columns.Clear();
            ////dgvChi.DataSource = dt;

            Helper h = new Helper();
            //h.FormatDataGridView(dgvChi);
            //dgvChi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dgvChi.Columns["Start"].DefaultCellStyle.Format = "##0.000,000";
            //dgvChi.Columns["End"].DefaultCellStyle.Format = "##0.000,000";
            //dgvChi.Columns["Mean"].DefaultCellStyle.Format = "##0.000,000";
            //dgvChi.Columns["Expected"].DefaultCellStyle.Format = "##0.000,000,000";
            //dgvChi.Columns["Actual"].DefaultCellStyle.Format = "##0.000,000,000";
            //dgvChi.Columns["Chi"].DefaultCellStyle.Format = "##0.000,000,000";

            //dgvChi.Columns["Start"].HeaderText = "شروع";
            //dgvChi.Columns["End"].HeaderText = "خاتمه";
            //dgvChi.Columns["Mean"].HeaderText = "ميانگين";
            //dgvChi.Columns["Expected"].HeaderText = "مورد انتظار";
            //dgvChi.Columns["Actual"].HeaderText = "واقعی";

            ////txtIndexChi.Text = indx.ToString("##0.000,000,000");

            ////Smirnov            
            ////dt = mr.RunSmirnov(elementID, valFrom, valTo, valIncr, out indx);
            //dgvSmirnov.Columns.Clear();
            ////dgvSmirnov.DataSource = dt;

            //h.FormatDataGridView(dgvSmirnov);
            //dgvSmirnov.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dgvSmirnov.Columns["Start"].DefaultCellStyle.Format = "##0.000,000";
            //dgvSmirnov.Columns["End"].DefaultCellStyle.Format = "##0.000,000";
            //dgvSmirnov.Columns["Mean"].DefaultCellStyle.Format = "##0.000,000";
            //dgvSmirnov.Columns["FX1"].DefaultCellStyle.Format = "##0.000,000,000";
            //dgvSmirnov.Columns["FX2"].DefaultCellStyle.Format = "##0.000,000,000";

            //dgvSmirnov.Columns["Start"].HeaderText = "شروع";
            //dgvSmirnov.Columns["End"].HeaderText = "خاتمه";
            //dgvSmirnov.Columns["Mean"].HeaderText = "ميانگين";
            //dgvSmirnov.Columns["Actual"].HeaderText = "واقعی";

            //txtIndexSmirnov.Text = indx.ToString("##0.000,000,000");


            //JB
            //mr.RunJB(elementID, out indx);
            //txtIndexJB.Text = indx.ToString("##0.000,000,000");

            dgvStock.Columns.Clear();
            dgvForex.Columns.Clear();

            dgvStock.DataSource = mr.GetPortfolioElements((int)cmbSecurityType.SelectedValue-1, true);
            dgvForex.DataSource = mr.GetPortfolioElements(CTE_Forex, true);

            //Helper h = new Helper();
            h.FormatDataGridView(dgvStock);
            h.FormatDataGridView(dgvForex);

            dgvStock.Columns["ID"].Visible = dgvForex.Columns["ID"].Visible = false;
            dgvStock.Columns["TypeID"].Visible = dgvForex.Columns["TypeID"].Visible = false;

            dgvStock.Columns["Descr"].HeaderText = "سهام";
            dgvStock.Columns.Add("JB", "Jarque-Bera");
            dgvStock.Columns.Add("Chi", "Chi-Square");
            dgvStock.Columns.Add("KS", "Kolmogro-Smmirnov");

            dgvForex.Columns["Descr"].HeaderText = "فارکس";
            dgvForex.Columns.Add("JB", "Jarque-Bera");
            dgvForex.Columns.Add("Chi", "Chi-Square");
            dgvForex.Columns.Add("KS", "Kolmogro-Smmirnov");

            //Farsi Date
            //pFrom = new PersianTools.Dates.PersianDate(int.Parse(fdpFrom.Text.Substring(0, 4)), int.Parse(fdpFrom.Text.Substring(5, 2)), int.Parse(fdpFrom.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            //DateTime dtFrom = DateTime.Parse(pFrom.ToGregorian.ToString("yyyy/MM/dd"));


            //pTo = new PersianTools.Dates.PersianDate(int.Parse(fdpTo.Text.Substring(0, 4)), int.Parse(fdpTo.Text.Substring(5, 2)), int.Parse(fdpTo.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            //DateTime dtTo = DateTime.Parse(pTo.ToGregorian.ToString("yyyy/MM/dd"));

            //
            //DateTime dtFrom = dtpFrom.Value;
            //DateTime dtTo = dtpTo.Value;
            //double valFrom = 0, valTo = 0, valIncr = 0;

            Presentation.Public.Routines.GetNumericValue(txtValFrom.Text, out valFrom);
            Presentation.Public.Routines.GetNumericValue(txtValTo.Text, out valTo);
            Presentation.Public.Routines.GetNumericValue(txtIncr.Text, out valIncr);
            //double indx = 0;
            //

            DataGridView[] dz = new DataGridView[] { dgvStock, dgvForex };


            try
            {
                ProgressBox.Show();

                //foreach (DataGridView dgv in dz)
                //{
                    foreach (DataGridViewRow dgvr in dgvStock.Rows)
                    {
                        int id = Convert.ToInt32(dgvr.Cells["ID"].Value);
                        //double d, dd;
                        indx = 1;
                        new DAL.MR_DataSet().RunChi(id,out d,out dd, valIncr, out indx);
                        dgvr.Cells["Chi"].Value = indx.ToString("##0.000,000,000");

                        indx = 2;
                        mr.RunSmirnov(id, valFrom, valTo, valIncr, out indx);
                        dgvr.Cells["KS"].Value = indx.ToString("##0.000,000,000");

                        indx = 3;
                        mr.RunJB(id, out indx);
                        dgvr.Cells["JB"].Value = indx.ToString("##0.000,000,000");
                    }
                //}
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }
        }

        private void chkStock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStock.Checked == true)
            {
                chkForex.Checked = false;
                clsERMSGeneral.dgvActive = dgvStock;
            }
        }

        private void chkForex_CheckedChanged(object sender, EventArgs e)
        {
            if (chkForex.Checked == true)
            {
                chkStock.Checked = false;
                clsERMSGeneral.dgvActive = dgvForex;
            }
        }
        public void DoPrint()
        {
            //Empty Print
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "BackTesting";
        }

        private void groupBox3_Click(object sender, EventArgs e)
        {

        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStock_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvStock.SelectedRows[0].Cells["ID"].Value);

                double indx = 1;
                double valFrom = 1;
                double valTo = 1;
                double valIncr = 1;
                Presentation.Public.Routines.GetNumericValue(txtIncr.Text, out valIncr);

                new DAL.MR_DataSet().RunChi(id, out valFrom, out valTo, valIncr, out indx);
                txtValFrom.Text = valFrom.ToString();
                txtValTo.Text = valTo.ToString();
            }
        }

        private void cmbSecurityType_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbSecurity_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
