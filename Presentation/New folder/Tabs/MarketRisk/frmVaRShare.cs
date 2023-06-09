using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ERMS.Logic;
using ERMS.Model;
//           
using ERMSLib;
using Presentation.Public;

namespace Presentation.Tabs.MarketRisk
{
    public partial class frmVaRShare : BaseForm, IPrintable
    {
        #region VAR
        private const int CTE_Stock = 0;
        private int numChanged;

        private MR mr;
        PersianTools.Dates.PersianDate pFrom;
        DataTable dtPreparedData = new DataTable();
        bool FirstPreparation = true;
        bool Prepaired = false;
        #endregion

        public frmVaRShare()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
        }

        private void Init()
        {


            mr = new MR();
            cmbSecurity.DataSource = mr.GetPortfolioElements(CTE_Stock, false);
            cmbSecurity.DisplayMember = "Descr";
            cmbSecurity.ValueMember = "ID";
            cmbSecurity.SelectedIndex = -1;

            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

            fdpFrom.SelectedDateTime = DateTime.Now;
            //fdpFrom.ResetSelectedDateTime();

            fdpTo.SelectedDateTime = DateTime.Now.AddDays(1);
            //fdpTo.ResetSelectedDateTime();
            GeneralDataGridView = dgvVar;


            //cmbSecurityType.AddItemsRange(new[] { "سهام", "فاركس" });
            //cmbSecurityType.AddItemsRange(new[] { "سهام" });
            //cmbSecurityType.SelectedIndex = -1;

            cmbSecurityType.DataSource = new DAL.MR_DataSet().GetPortfolios();
            cmbSecurityType.DisplayMember = "Code";
            cmbSecurityType.ValueMember = "Id";
            cmbSecurityType.SelectedIndex = 0;


            FillTemplates();
        }

        private void frmVaR_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnRun1_Click(object sender, EventArgs e)
        {
            if (cmbSecurity.SelectedIndex == -1)
            {
                Routines.ShowMessageBoxFa("اوراق بهادار انتخاب نشده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbSecurityType.SelectedIndex == -1)
            {
                Routines.ShowMessageBoxFa("نوع سهام انتخاب نشده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (fdpFrom.Text == "[هیج مقداری انتخاب نشده]" || fdpTo.Text == "[هیج مقداری انتخاب نشده]")
            {
                Routines.ShowMessageBoxFa("لطفا بازه زمانی را انتخاب كنيد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (fdpFrom.SelectedDateTime == fdpTo.SelectedDateTime)
            {
                Routines.ShowMessageBoxFa("بازه زمانی به درستی انتخاب نشده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nDays;
            Presentation.Public.Routines.GetNumericValue(txtNdays.Text, out nDays);
            double cl;
            Presentation.Public.Routines.GetNumericValue(txtCL.Text, out cl);
            int retEvalMethod = rdoLog.Checked ? 1 : 2;
            int elementID = (int)cmbSecurity.SelectedValue;
            int AlphaLevel = int.Parse(txtAlphaLevel.Text);
            bool MonteCarlo = chbMonteCarlo.Checked;

            double mu, sigma, vaR, RC, VaRRiskMetrics;

            mr.RunVaR1(elementID, fdpFrom.SelectedDateTime, fdpTo.SelectedDateTime, nDays,
                retEvalMethod, cl, AlphaLevel, MonteCarlo, out mu, out sigma, out vaR, out VaRRiskMetrics);
            //new DAL.MR_DataSet().RunRC(elementID, fdpFrom.SelectedDateTime, fdpTo.SelectedDateTime, nDays, retEvalMethod, cl,"1,5,3", out RC);

            txtDrift11.Text=txtDrift1.Text = mu.ToString("###,##0.####");
            txtVolatility11.Text=txtVolatility1.Text = sigma.ToString("###,##0.####");
            txtVaR11.Text = txtVaR1.Text = vaR.ToString("###,##0.####");
            txtVaR11RM.Text = txtVaR1RM.Text = VaRRiskMetrics.ToString("###,##0.####");
            //txtRC.Text = RC.ToString("###,##0.####");
            

            var dt = mr.GetVaR2Elements(elementID);
            dgvVar.Columns.Clear();

            var dcolDateF = new DataColumn("DateF", typeof(String));
            dt.Columns.Add(dcolDateF);
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Date"].ToString() != "")
                {
                    pFrom = new PersianTools.Dates.PersianDate((DateTime)dt.Rows[i]["Date"]);
                    dt.Rows[i]["DateF"] = pFrom.FormatedDate("yyyy/MM/dd");

                }
            }
            dgvVar.DataSource = dt;
            FirstPreparation = true;
            dgvVar.Columns["ID"].HeaderText = "شناسه";
            dgvVar.Columns["Row"].HeaderText = "سطر";
            dgvVar.Columns["DateF"].HeaderText = "تاریخ";
            dgvVar.Columns["Price"].HeaderText = "قيمت";
            dgvVar.Columns["Return"].HeaderText = "بازده";
            dgvVar.Columns["Monte Carlo"].HeaderText = "مونت كارلو";
            dgvVar.Columns["Date"].Visible = false;

            Helper h = new Helper();
            h.FormatDataGridView(dgvVar);
            dgvVar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvVar.SelectionMode = DataGridViewSelectionMode.CellSelect;
            
            //DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn
            //                                     {
            //                                         MinimumWidth = 1023,
            //                                         Name = "Dummy",
            //                                         HeaderText = string.Empty
            //                                     };
            //dgvVar.Columns.Add(tCol);

            dgvVar.Columns["Price"].DefaultCellStyle.Format = "###,##0.##";
            dgvVar.Columns["Return"].DefaultCellStyle.Format = "###,##0.####";
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            //btnRun1_Click(sender, e);

            if (cmbSecurity.SelectedIndex == -1)
                return;


            if (FirstPreparation)
            {
                int elementID = (int)cmbSecurity.SelectedValue;
                DataTable dt = mr.GetVaR2Elements(elementID);

                //Grid
                dgvStress.Columns.Clear();

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
                //
                dgvStress.DataSource = null;
                DataTable dt1 = new DataTable();
                dgvStress.DataSource = dt1;
                dgvStress.Columns.Clear();
                dgvStress.Refresh();
                dtPreparedData = dt.Copy();
                dgvStress.DataSource = dt;
                FirstPreparation = false;
            }
            else
            {
                dgvStress.DataSource = null;
                DataTable dt = new DataTable();
                dgvStress.DataSource = dt;
                dgvStress.Columns.Clear();
                dgvStress.Refresh();
                dgvStress.DataSource = dtPreparedData;
                dgvStress.Refresh();

                for (int i = 0; i < dgvStress.Rows.Count; i++)
                    ChangeValue(3, i);
            }

            Helper h = new Helper();
            h.FormatDataGridView(dgvStress);
            dgvStress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvStress.SelectionMode = DataGridViewSelectionMode.CellSelect;
            //DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn
            //{
            //    MinimumWidth = 1023,
            //    Name = "Dummy",
            //    HeaderText = string.Empty
            //};
            //dgvStress.Columns.Add(tCol);

            dgvStress.ReadOnly = false;
            //dgvStress.Columns["ID"].Visible = false;
            dgvStress.Columns["Price"].DefaultCellStyle.Format = "###,###.##";

            dgvStress.Columns["Return"].ReadOnly = false;

            dgvStress.Columns["ID"].HeaderText = "شناسه";
            dgvStress.Columns["Row"].HeaderText = "سطر";
            dgvStress.Columns["DateF"].HeaderText = "تاریخ";
            dgvStress.Columns["Price"].HeaderText = "قيمت";
            dgvStress.Columns["Return"].HeaderText = "بازده";
            dgvStress.Columns["Monte Carlo"].HeaderText = "مونت كارلو";
            dgvStress.Columns["Date"].Visible = false;

            dgvStress.Columns["Price"].DefaultCellStyle.Format = "###,##0.##";
            dgvStress.Columns["Return"].DefaultCellStyle.Format = "###,##0.####";

            numChanged = 0;
            lblChanged.Text = numChanged.ToString();
            Prepaired = true;

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                int rowCount = dgvStress.RowCount;
                frmStressType fx = new frmStressType("MR");
                if (fx.ShowDialog() == DialogResult.OK)
                {
                    switch (fx.ChangeType)
                    {
                        case 1:
                            break;

                        case 2:
                            Random r = new Random();
                            for (int i = 1; i <= fx.N; i++)
                            {
                                int rowIndex = r.Next(1, rowCount);

                                dgvStress.Rows[rowIndex].Cells["Price"].Style.BackColor = Color.Yellow;
                                double p = Convert.ToDouble(dgvStress.Rows[rowIndex].Cells["Price"].Value);
                                switch (fx.Formula)
                                {
                                    case 1:
                                        p = p + fx.A;
                                        break;
                                    case 2:
                                        p = p + (fx.A) * p / 100;
                                        break;
                                }
                                dgvStress.Rows[rowIndex].Cells["Price"].Value = p;
                            }
                            break;

                        case 3:
                            foreach (DataGridViewRow dgvr in dgvStress.Rows)
                            {
                                DateTime dtCell = (DateTime)dgvr.Cells["Date"].Value;
                                if (dtCell.CompareTo(fx.DateFrom) > 0 && dtCell.CompareTo(fx.DateTo) < 0)
                                {
                                    dgvr.Cells["Price"].Style.BackColor = Color.LightSteelBlue;

                                    double p = Convert.ToDouble(dgvr.Cells["Price"].Value);
                                    switch (fx.Formula)
                                    {
                                        case 1:
                                            p = p + fx.A;
                                            break;
                                        case 2:
                                            p = p + (fx.A) * p / 100;
                                            break;
                                    }
                                    dgvr.Cells["Price"].Value = p;

                                    dgvr.Cells["Price"].Style.Font = new Font(dgvr.Cells["Price"].Style.Font, FontStyle.Bold);

                                    numChanged++;
                                    lblChanged.Text = numChanged.ToString();
                                }
                            }
                            break;
                    }
                }

            }


            catch
            {
                Presentation.Public.Routines.ShowMessageBoxFa("برنامه با خطا روبرو شده است.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                FillTemplates();
            }
        }

        private void btnRun2_Click(object sender, EventArgs e)
        {
            if (!Prepaired)
            {
                Routines.ShowMessageBoxFa("ابتدا آماده سازی را انجام دهید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbSecurity.SelectedIndex == -1)
            {
                Routines.ShowMessageBoxFa("اوراق بهادار انتخاب نشده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int nDays;
            Presentation.Public.Routines.GetNumericValue(txtNdays.Text, out nDays);
            double cl;
            Presentation.Public.Routines.GetNumericValue(txtCL.Text, out cl);
            int retEvalMethod = rdoLog.Checked ? 1 : 2;
            int elementID = (int)cmbSecurity.SelectedValue;

            double mu, sigma, vaR, VaRRiskMetrics;
            mr.RunVaR2(elementID,fdpFrom.SelectedDateTime ,fdpTo.SelectedDateTime , nDays, 
                retEvalMethod, cl, out mu, out sigma, out vaR, out VaRRiskMetrics);

            txtDrift2.Text = mu.ToString("###,##0.####");
            txtVolatility2.Text = sigma.ToString("###,##0.####");
            txtVaR2.Text = vaR.ToString("###,##0.####");
            txtVaR2RM.Text = VaRRiskMetrics.ToString("###,##0.####");

            dgvStress.Columns["Price"].DefaultCellStyle.Format = "###,##0.##";
            dgvStress.Columns["Return"].DefaultCellStyle.Format = "###,##0.####";

            ShowDifference();               
            

        }
        
        /// <summary>
        /// Shows the difference between real values and test values 
        /// </summary>
        private void ShowDifference()
        {
            if (txtDrift1.Text == string.Empty || txtVolatility1.Text == string.Empty || 
                                    txtVaR1.Text == string.Empty)
            {
                return;
            }


            decimal temp1 = (decimal.Parse(txtDrift1.Text) - decimal.Parse(txtDrift2.Text));
            decimal temp2 = (decimal.Parse(txtVolatility1.Text) - decimal.Parse(txtVolatility2.Text));
            decimal temp3 = (decimal.Parse(txtVaR1.Text) - decimal.Parse(txtVaR2.Text));
            decimal temp4 = (decimal.Parse(txtVaR1RM.Text) - decimal.Parse(txtVaR2RM.Text));
            string sign = temp1 >= 0 ? "+" : "";
                            
            txtAvgDiff.Text = sign + temp1;
            
            sign = temp2 >= 0 ? "+" : "";

            txtVolatilityDiff.Text = sign + temp2;
            
            sign = temp3 >= 0 ? "+" : "";            

            txtVaRDiff.Text = sign + temp3;

            sign = temp4 >= 0 ? "+" : "";
            txtVaRDiffRM.Text = sign + temp4;    
        
        }
        
        private void dgvStress_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ChangeValue(e.ColumnIndex, e.RowIndex);
        }

        private void ChangeValue(int columnIndex, int rowIndex)
        {
            try
            {
                double val = Convert.ToDouble(dgvStress[columnIndex, rowIndex].Value);
                int id = (int)dgvStress["ID", rowIndex].Value;
                mr.ChangeReturn(id, val);


                if (dgvStress["Price", rowIndex].Style.Font == null || !dgvStress["Price", rowIndex].Style.Font.Bold)
                {
                    numChanged++;
                    lblChanged.Text = numChanged.ToString();
                }

                DataGridViewCellStyle s = new DataGridViewCellStyle(dgvStress["Price", rowIndex].Style)
                                              {Font = new Font(this.Font, FontStyle.Bold)};
                dgvStress["Price", rowIndex].Style = s;

            }
            catch { }
        }

        private void cmbSecurityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSecurityType.SelectedIndex != -1)
            {
                cmbSecurity.DataSource = mr.GetPortfolioElements(cmbSecurityType.SelectedIndex, false);
                cmbSecurity.DisplayMember = "Descr";
                cmbSecurity.ValueMember = "ID";
            }
        }

        private void chkVar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVar.Checked)
            {
                chkStress.Checked = false;
                //clsERMSGeneral.dgvActive = dgvVar;
                GeneralDataGridView = dgvVar; 
            }
        }

        private void chkStress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStress.Checked)
            {
                chkVar.Checked = false;
                clsERMSGeneral.dgvActive = dgvStress;
                GeneralDataGridView = dgvStress;
            }
        }
        
		public void DoPrint()
        {
            //empty print
        }
        
		public void DoHelp()
        {
            clsERMSGeneral.strHelp = "VaRShare";
        }

        private void FillTemplates()
        {
            DataTable dt = new DAL.SwartDataSetTableAdapters.MR_Stress_Model_NewSelectCommandTableAdapter().GetData();
            lsvModel.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                if (!dr["Model_Type"].ToString().Equals("MR"))
                    continue;
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["Model_Name"].ToString();
                lvi.Tag = dr["ID"].ToString();

                lsvModel.Items.Add(lvi);
            }
        }

        


        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            FillTemplates();
        }

        private void tsbModelNew_Click_1(object sender, EventArgs e)
        {
            var fs = new frmStressType("MR");
            fs.btnOK.Visible = fs.btnCancel.Visible = false;
            fs.ShowDialog();
            FillTemplates();
        }

        private void tsbModelEdit_Click_1(object sender, EventArgs e)
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvModel.SelectedItems[0];
                DataTable dt = new DAL.SwartDataSetTableAdapters.MR_Stress_Model_NewSelectCommandTableAdapter().GetData();
                foreach (DataRow dr in dt.Rows)
                {
                    if (lvi.Tag.Equals(dr["ID"].ToString()))
                    {
                        DateTime fromDate;
                        if (!DateTime.TryParse(dr["Start_Date"].ToString(), out fromDate))
                            fromDate = DateTime.Now;
                        DateTime toDate;
                        if (!DateTime.TryParse(dr["End_Date"].ToString(), out toDate))
                            toDate = DateTime.Now;
                        var fs = new frmStressType(Int32.Parse(dr["ID"].ToString()), Int32.Parse(dr["Model_Patern"].ToString()), Int32.Parse(dr["N"].ToString()), fromDate, toDate, dr["Model_Name"].ToString(), float.Parse(dr["Parameter_Value"].ToString()), Int32.Parse(dr["Formula_Type"].ToString()),"MR");
                        fs.ShowDialog();
                        FillTemplates();
                        break;
                    }

                }

            }
        }

        private void tsbModelRemove_Click_1(object sender, EventArgs e)
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("الگوی انتخاب شده، حذف خواهد شد. آیا مطمئن هستید؟", "تایید", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem lvi = lsvModel.SelectedItems[0];
                    int id = Int32.Parse( lvi.Tag.ToString());
                    new DAL.SwartDataSetTableAdapters.MR_Stress_Model_NewSelectCommandTableAdapter().Delete(id);
                }
                FillTemplates();
            }
        }


        private void tsbRun_Click_1(object sender, EventArgs e)
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvModel.SelectedItems[0];
                DataTable dt = new DAL.SwartDataSetTableAdapters.MR_Stress_Model_NewSelectCommandTableAdapter().GetData();
                foreach (DataRow dr in dt.Rows)
                {
                    if (lvi.Tag.Equals(dr["ID"].ToString()))
                    {
                        DateTime fromDate;
                        if (!DateTime.TryParse(dr["Start_Date"].ToString(), out fromDate))
                            fromDate = DateTime.Now;
                        DateTime toDate;
                        if (!DateTime.TryParse(dr["End_Date"].ToString(), out toDate))
                            toDate = DateTime.Now;

                        try
                        {
                            int rowCount = dgvStress.RowCount;
                            switch ( Int32.Parse(dr["Model_Patern"].ToString()))
                            {
                                case 1:
                                    break;

                                case 2:
                                    Random r = new Random();
                                    for (int i = 1; i <= Int32.Parse(dr["N"].ToString()); i++)
                                    {
                                        int rowIndex = r.Next(1, rowCount);

                                        dgvStress.Rows[rowIndex].Cells["Price"].Style.BackColor = Color.Yellow;
                                        double p = Convert.ToDouble(dgvStress.Rows[rowIndex].Cells["Price"].Value);
                                        switch ( Int32.Parse(dr["Formula_Type"].ToString()))
                                        {
                                            case 1:
                                                p = p + float.Parse(dr["Parameter_Value"].ToString());
                                                break;
                                            case 2:
                                                p = p + (float.Parse(dr["Parameter_Value"].ToString())) * p / 100;
                                                break;
                                        }
                                        dgvStress.Rows[rowIndex].Cells["Price"].Value = p;
                                    }
                                    break;

                                case 3:
                                    foreach (DataGridViewRow dgvr in dgvStress.Rows)
                                    {
                                        DateTime dtCell = (DateTime)dgvr.Cells["Date"].Value;
                                        if (dtCell.CompareTo(fromDate) > 0 && dtCell.CompareTo(toDate) < 0)
                                        {
                                            dgvr.Cells["Price"].Style.BackColor = Color.LightSteelBlue;

                                            double p = Convert.ToDouble(dgvr.Cells["Price"].Value);
                                            switch ( Int32.Parse(dr["Formula_Type"].ToString()))
                                            {
                                                case 1:
                                                    p = p + float.Parse(dr["Parameter_Value"].ToString());
                                                    break;
                                                case 2:
                                                    p = p + (float.Parse(dr["Parameter_Value"].ToString())) * p / 100;
                                                    break;
                                            }
                                            dgvr.Cells["Price"].Value = p;

                                            dgvr.Cells["Price"].Style.Font = new Font(dgvr.Cells["Price"].Style.Font, FontStyle.Bold);

                                            numChanged++;
                                            lblChanged.Text = numChanged.ToString();
                                        }
                                    }
                                    break;
                            }

                            Presentation.Public.Routines.ShowMessageBoxFa("الگوی انتخابی اجرا شد. برای مشاهده نتایج از دکمه اجرا استفاده کنید.", "اجرای موفق الگو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        catch
                        {
                            Presentation.Public.Routines.ShowMessageBoxFa("برنامه با خطا روبرو شده است.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        finally
                        {
                            FillTemplates();
                            
                        }
                        break;


                        //var fs = new frmStressType(Int32.Parse(dr["ID"].ToString()),, , fromDate, toDate, dr["Model_Name"].ToString(), ,);
                        //fs.ShowDialog();
                        
                    }

                }

            }


        }

        private void fdpTo_SelectedDateTimeChanged(object sender, EventArgs e)
        {

        }

    }
}