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
using ProgressBox = Presentation.Public.ProgressBox;
using Presentation.Tabs.MarketRisk;

//soli
namespace Presentation.Tabs.CurRisk
{
    public partial class frmVarShareCurrency : BaseForm, IPrintable
    {

        #region VAR
        private int numChanged = 0;
        private CurR Cur;
        private PersianTools.Dates.PersianDate pFrom, pTo;
        private int Profile_Id;
        #endregion

        #region constructor
        public frmVarShareCurrency()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
            Profile_Id = ERMS.Model.GlobalInfo.ProfileID;
        }
        #endregion

        #region Init form
        private void frmVarShareCurrency_Load(object sender, EventArgs e)
        {
            Init();
            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

            fdpTo.SelectedDateTime = DateTime.Now;
            fdpTo.ResetSelectedDateTime();

            fdpFrom.SelectedDateTime = DateTime.Now;
            fdpFrom.ResetSelectedDateTime();
            InitGridCurrency();
            FillTemplates();
        }

        private void Init()
        {
            cmbCalculateType.AddItemsRange(new string[] { "دارايي", "بدهي", "باز" });
            //cmbCalculateType.SelectedIndex = -1;

            Cur = new CurR();
            cmbCurrency.DataSource = Cur.GetDTCurrency();
            cmbCurrency.DisplayMember = "Currency_Description";
            cmbCurrency.ValueMember = "Currency";
            cmbCurrency.SelectedIndex = -1;
            cmbCurrency.SetDefaultCurrency("ریال ایران");
            GeneralDataGridView = dgvReRat;

            //pFrom = new PersianTools.Dates.PersianDate((DateTime)DateTime.Now);
            //fdpFrom.Text = fdpTo.Text = pFrom.FormatedDate("yyyy/MM/dd");
        }
        #endregion

        #region "Currency Tab"

        private void InitGridCurrency()
        {
            //DataGridViewComboBoxColumn dgvcb = (DataGridViewComboBoxColumn)dgvCurrency1.Columns["GroupName"];
            //AGM ag = new AGM();

            //DataTable dtAL = new DataTable();
            //dtAL.Columns.Add("AL");
            //dtAL.Columns.Add("AL_Value");
            //DataRow dr;
            //dr = dtAL.NewRow();
            //dr["AL"] = " ";
            //dr["AL_Value"] = 0;
            //dtAL.Rows.Add(dr);
            //DataRow dr1;
            //dr1 = dtAL.NewRow();
            //dr1["AL"] = "دارائی";
            //dr1["AL_Value"] = 1;
            //dtAL.Rows.Add(dr1);
            //DataRow dr2;
            //dr2 = dtAL.NewRow();
            //dr2["AL"] = "بدهی";
            //dr2["AL_Value"] = 2;
            //dtAL.Rows.Add(dr2);

            //((DataGridViewComboBoxColumn)dgvCurrency1.Columns["AL"]).DataSource = dtAL;
            //((DataGridViewComboBoxColumn)dgvCurrency1.Columns["AL"]).DisplayMember = "AL_Value";
            //((DataGridViewComboBoxColumn)dgvCurrency1.Columns["AL"]).ValueMember = "AL_Value";

            //DataTable dt = Cur.GetDTCurrency();
            //DataTable dtblTemp = new DataTable();
            //dtblTemp = Cur.LoadGroup_Name_Curr_Account_Map();

            //dt.Columns.Add("GroupName");

            //if (dtblTemp.Rows.Count > 0)
            //{
            //    for (int j = 0; j < dt.Rows.Count; j++)
            //    {
            //        for (int i = 0; i < dtblTemp.Rows.Count; i++)
            //        {
            //            if (dt.Rows[j][0] != null && dt.Rows[j][0].ToString() == dtblTemp.Rows[i][1].ToString())
            //            {
            //                dt.Rows[j]["GroupName"] = dtblTemp.Rows[i][0].ToString();
            //                break;
            //            }
            //        }
            //    }
            //}
            //dgvCurrency1.DataSource = dt;

            //if(dgvCurrency1.Columns.Count > 0)
            //{
            //    dgvCurrency1.Columns[0].Visible = false;
            //    dgvCurrency1.Columns[1].HeaderText = "نام ارز";
            //    dgvCurrency1.Columns[2].HeaderText = "گروه حساب";
            //}

            //dgvCurrency1.Columns[1].Width = 250;
            //dgvCurrency1.Columns[2].Width = 250;

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow dr in (dgvCurrency1.DataSource as DataTable).Rows)
                    if ((Int32)dr["AL_Credit"] == 1 && (Int32)dr["AL_Debit"] == 1)
                    {
                        Routines.ShowMessageBoxFa("یک حساب را نمی توان به دو نوع محاسبه تخصیص داد", "خطا",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else if ((Int32)dr["Selected"] == 1 &&
                                ((Int32)dr["AL_Credit"] == 0 && (Int32)dr["AL_Debit"] == 0))
                    {
                        Routines.ShowMessageBoxFa("نوع محاسبه برای یکی از حساب های انتخابی مشخص نشده است", "خطا",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                Cur.DeleteCurr_Account_Map((int)cmbCurrency.SelectedValue);

                foreach (DataRow dr in (dgvCurrency1.DataSource as DataTable).Rows)
                    if ((Int32)dr["AL_Credit"] == 1)
                    {
                        Cur.InsertCurr_Account_Map
                            (int.Parse(dr["Accounting_Code"].ToString()), 1, (Int32)dr["Selected"]);
                    }
                    else if ((Int32)dr["AL_Debit"] == 1)
                    {
                        Cur.InsertCurr_Account_Map
                            (int.Parse(dr["Accounting_Code"].ToString()), 2, (Int32)dr["Selected"]);
                    }

                //for (int i = 0; i < dgvCurrency1.RowCount; ++i)
                //    if (dgvCurrency1[2, i].Value != null && dgvCurrency1[2, i].Value.ToString() != "")
                //        Cur.InsertCurr_Account_Map(int.Parse(dgvCurrency1[0, i].Value.ToString()),
                //             dgvCurrency1[2, i].Value.ToString());
                //Cursor = Cursors.Default;
                Presentation.Public.Routines.ShowMessageBoxFa("تغییرات با موفقیت اعمال شد", "پیغام",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                Cursor = Cursors.Default;
                Presentation.Public.Routines.ShowMessageBoxFa("تغییرات اعمال نشد", "پیغام",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //try
            //{
            //    Cursor = Cursors.WaitCursor;
            //    Cur.DeleteCurr_Account_Map();
            //    for (int i = 0; i < dgvCurrency1.RowCount; ++i)
            //        if (dgvCurrency1[2, i].Value != null && dgvCurrency1[2, i].Value.ToString() != "")
            //            Cur.InsertCurr_Account_Map(int.Parse(dgvCurrency1[0,i].Value.ToString()),
            //                 dgvCurrency1[2, i].Value.ToString());
            //    Cursor = Cursors.Default;
            //    Presentation.Public.Routines.ShowMessageBoxFa("تغییرات با موفقیت اعمال شد", "پیغام",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception exp)
            //{
            //    Cursor = Cursors.Default;
            //    Presentation.Public.Routines.ShowMessageBoxFa("تغییرات اعمال نشد", "پیغام",
            //MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        #endregion

        #region "reRet Tab"
        private void btnRun1_Click(object sender, EventArgs e)
        {
            if (cmbCurrency.SelectedIndex == -1)
            {
                Routines.ShowMessageBoxFa("لطفا نوع ارز را انتخاب كنيد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCalculateType.SelectedIndex == -1)
            {
                Routines.ShowMessageBoxFa("لطفا نوع محاسبه را انتخاب كنيد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string text = fdpFrom.Text;
            string textto = fdpTo.Text;
            if (fdpFrom.Text == "[هیج مقداری انتخاب نشده]" || fdpTo.Text == "[هیج مقداری انتخاب نشده]")
            {
                Routines.ShowMessageBoxFa("لطفا بازه زمانی را انتخاب كنيد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nDays = 1;
            Routines.GetNumericValue(txtNdays.Text, out nDays);
            double cl = 1;
            Routines.GetNumericValue(txtCL.Text, out cl);
            int Account_Type = (int)cmbCalculateType.SelectedIndex + 1;
            int CurrencyID = (int)cmbCurrency.SelectedValue;

            double mu = 0, sigma = 0, vaR = 0, VaRRiskMatrics = 0;

            //if (!CheckAccountMap(CurrencyID))
            //{
            //    Routines.ShowMessageBoxFa("لطفا حساب ارزي ارز انتخاب شده را تطبيق دهيد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //Grid
            try
            {
                ProgressBox.Show();
                DataTable dt = Cur.RunCurR_VaR1(CurrencyID, Account_Type, fdpFrom.SelectedDateTime, fdpTo.SelectedDateTime,
                                                          nDays, cl, out mu, out sigma, out vaR, out VaRRiskMatrics);
                dgvReRat.Columns.Clear();


                //Farsi Date
                DataColumn dcolDateF = new DataColumn("DateF", typeof(System.String));
                dt.Columns.Add(dcolDateF);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Date"].ToString() != "")
                    {
                        var dateTime = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(dt.Rows[i]["Date"].ToString()).ToString("yyyy/MM/dd");
                        dt.Rows[i]["DateF"] = dateTime;
                    }
                }
                //

                dgvReRat.DataSource = dt;
                dgvReRat.Columns["DateF"].HeaderText = "تاریخ";
                dgvReRat.Columns["Price"].HeaderText = "نرخ تسعير";
                dgvReRat.Columns["RE_RAT"].HeaderText = "بازده ارز";
                //dgvRERAT.Columns["Currency"].HeaderText = "ارز";
                dgvReRat.Columns["Currency"].Visible = false;
                dgvReRat.Columns["Date"].Visible = false;

                Helper h = new Helper();
                h.FormatDataGridView(dgvReRat);
                dgvReRat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                //DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
                //tCol.MinimumWidth = 523;
                //tCol.Name = "Dummy";
                //tCol.HeaderText = string.Empty;
                //dgvReRat.Columns.Add(tCol);

                dgvReRat.Columns["Price"].DefaultCellStyle.Format = "###,##0.##";
                dgvReRat.Columns["RE_RAT"].DefaultCellStyle.Format = "###,##0.####";

                txtMU.Text = mu.ToString("###,##0.####");
                txtSigma.Text = sigma.ToString("###,##0.####");
                txtVaR.Text = vaR.ToString("###,##0.####");
                txtVaRRM.Text = VaRRiskMatrics.ToString("###,##0.####");

                txtDrift1.Text = txtMU.Text;
                txtVolatility1.Text = txtSigma.Text;
                txtVaR1.Text = txtVaR.Text;
                txtVaR1RM.Text = txtVaRRM.Text;
            }
            catch (Exception ex)
            {
                //MsgBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Routines.ShowMessageBoxFa("برنامه با خطا روبرو شده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }
        }


        private bool CheckAccountMap(int Currency_Id)
        {
            bool flag = false;
            DataTable dt = Cur.LoadGroup_Name_Curr_Account_Map();

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Currency"].ToString() == Currency_Id.ToString())
                {
                    flag = true;
                    break;
                }
            }
            return flag;

        }
        private void chkVar_CheckedChanged(object sender, EventArgs e)
        {

            if (chkVar.Checked == true)
            {
                chkStress.Checked = false;
                DoPrintReRat();

            }
        }
        public void DoPrintReRat()
        {
            try
            {
                DataGridView dgv = new DataGridView();
                dgv.DataSource = null;

                foreach (DataGridViewColumn c1 in dgvReRat.Columns)
                {
                    DataGridViewColumn c2 = (DataGridViewColumn)c1.Clone();
                    dgv.Columns.Add(c2);
                }

                int i = 0;
                foreach (DataGridViewRow dgvr in dgvReRat.Rows)
                {
                    DataGridViewRow r = (DataGridViewRow)dgvr.Clone();
                    i = 0;
                    foreach (DataGridViewCell cell in dgvr.Cells)
                    {

                        r.Cells[i].Value = cell.Value;
                        i++;
                    }
                    dgv.Rows.Add(r);
                }

                dgv.Columns["DateF"].HeaderText = "تاریخ";
                dgv.Columns["Price"].HeaderText = "نرخ تسعير";
                dgv.Columns["RE_RAT"].HeaderText = "بازده ارز";


                clsERMSGeneral.dgvActive = dgv;
            }
            catch
            {
                Routines.ShowMessageBoxFa("هیچ لیستی وجود ندارد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Stress Tab"

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            btnRun1_Click(sender, e);

            if (dgvReRat.RowCount == 0)
            {
                Routines.ShowMessageBoxFa("لطفا محاسبات ارزش در خطر را انجام دهيد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string text = fdpFrom.Text;
            string textto = fdpTo.Text;
            int nDays = 1;
            Routines.GetNumericValue(txtNdays.Text, out nDays);
            double cl = 1;
            Routines.GetNumericValue(txtCL.Text, out cl);
            int Account_Type = (int)cmbCalculateType.SelectedIndex + 1;
            int CurrencyID = (int)cmbCurrency.SelectedValue;

            double mu = 0, sigma = 0, vaR = 0, VaRRiskMatrics = 0;

            DataTable dt = Cur.GetCurR_St_PriceReport(Profile_Id);

            //Grid
            dgvStress.Columns.Clear();

            //Farsi Date
            DataColumn dcolDateF = new DataColumn("DateF", typeof(System.String));
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

            dgvStress.DataSource = dt;

            Helper h = new Helper();
            h.FormatDataGridView(dgvStress);
            dgvStress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvStress.ReadOnly = false;
            dgvStress.Columns["Price"].DefaultCellStyle.Format = "###,###.##";
            dgvStress.Columns["ReRat"].ReadOnly = false;
            dgvStress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dgvStress.Columns["Id"].HeaderText = "Id";
            dgvStress.Columns["DateF"].HeaderText = "تاریخ";
            dgvStress.Columns["Price"].HeaderText = "نرخ تسعير";
            dgvStress.Columns["ReRat"].HeaderText = "بازده";
            dgvStress.Columns["Date"].Visible = false;
            dgvStress.Columns["Id"].Visible = false;
            dgvStress.Columns["Price"].DefaultCellStyle.Format = "###,##0.##";
            dgvStress.Columns["ReRat"].DefaultCellStyle.Format = "###,##0.####";
            numChanged = 0;
            lblChanged.Text = numChanged.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int rowCount = dgvStress.RowCount;

            frmStressType fx = new frmStressType("CurR");
            fx.gbSaveTemplate.Visible = false;
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

        private void btnRun2_Click(object sender, EventArgs e)
        {
            //Farsi Date
            if (cmbCurrency.SelectedIndex == -1)
            {
                Routines.ShowMessageBoxFa("لطفا نوع ارز را انتخاب كنيد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbCalculateType.SelectedIndex == -1)
            {
                Routines.ShowMessageBoxFa("لطفا نوع محاسبه را انتخاب كنيد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvReRat.DataSource == null)
            {
                Routines.ShowMessageBoxFa("لطفا محاسبات ارزش در خطر را انجام دهيد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            //pFrom = new PersianTools.Dates.PersianDate(int.Parse(fdpFrom.Text.Substring(0, 4)), int.Parse(fdpFrom.Text.Substring(5, 2)), int.Parse(fdpFrom.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            //DateTime dtFrom = DateTime.Parse(pFrom.ToGregorian.ToString("yyyy/MM/dd"));


            //pTo = new PersianTools.Dates.PersianDate(int.Parse(fdpTo.Text.Substring(0, 4)), int.Parse(fdpTo.Text.Substring(5, 2)), int.Parse(fdpTo.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            //DateTime dtTo = DateTime.Parse(pTo.ToGregorian.ToString("yyyy/MM/dd"));


            int nDays = 1;
            Routines.GetNumericValue(txtNdays.Text, out nDays);
            double cl = 1;
            Routines.GetNumericValue(txtCL.Text, out cl);
            int currencyID = (int)cmbCurrency.SelectedValue;
            int Account_Type = (int)cmbCalculateType.SelectedIndex + 1;

            double mu = 0, sigma = 0, vaR = 0, vaRRiskMetrics = 0;
            Cur.RunStress(currencyID, Profile_Id, Account_Type, fdpFrom.SelectedDateTime, fdpTo.SelectedDateTime,
                                    nDays, cl, out mu, out sigma, out vaR, out vaRRiskMetrics);

            txtDrift2.Text = mu.ToString("###,##0.####");
            txtVolatility2.Text = sigma.ToString("###,##0.####");
            txtVaR2.Text = vaR.ToString("###,##0.####");
            txtVaR2RM.Text = vaRRiskMetrics.ToString("###,##0.####");

            dgvStress.Columns["Price"].DefaultCellStyle.Format = "###,##0.##";
            //dgvStress.Columns["Return"].DefaultCellStyle.Format = "###,##0.##";

            ShowDifference();

        }

        #endregion

        #region other Methods

        public void DoPrint()
        {
            //empty print
        }

        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "VaRShare";
        }

        /// <summary>
        /// Shows the difference between real values and test values 
        /// </summary>
        private void ShowDifference()
        {
            if (txtDrift1.Text == string.Empty || txtVolatility1.Text == string.Empty || txtVaR1.Text == string.Empty)
            {
                return;
            }


            string sign;

            decimal temp1 = (decimal.Parse(txtDrift1.Text) - decimal.Parse(txtDrift2.Text));
            decimal temp2 = (decimal.Parse(txtVolatility1.Text) - decimal.Parse(txtVolatility2.Text));
            decimal temp3 = (decimal.Parse(txtVaR1.Text) - decimal.Parse(txtVaR2.Text));
            decimal temp4 = (decimal.Parse(txtVaR1RM.Text) - decimal.Parse(txtVaR2RM.Text));

            sign = temp1 >= 0 ? "+" : "";
            txtAvgDiff.Text = sign + temp1;

            sign = temp2 >= 0 ? "+" : "";
            txtVolatilityDiff.Text = sign + temp2;

            sign = temp3 >= 0 ? "+" : "";
            txtVaRDiff.Text = sign + temp3;

            sign = temp4 >= 0 ? "+" : "";
            txtVaRDiffRM.Text = sign + temp4;
        }

        private void ChangeValue(int columnIndex, int rowIndex)
        {
            try
            {
                double val = Convert.ToDouble(dgvStress[columnIndex, rowIndex].Value);
                int id = (int)dgvStress["Id", rowIndex].Value;
                Cur.ChangeReturn(id, val);


                if (dgvStress["Price", rowIndex].Style.Font == null || !dgvStress["Price", rowIndex].Style.Font.Bold)
                {
                    numChanged++;
                    lblChanged.Text = numChanged.ToString();
                }

                DataGridViewCellStyle s = new DataGridViewCellStyle(dgvStress["Price", rowIndex].Style);
                s.Font = new Font(this.Font, FontStyle.Bold);
                dgvStress["Price", rowIndex].Style = s;

            }
            catch { }
        }
        #endregion

        #region dgvStress events
        private void dgvStress_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ChangeValue(e.ColumnIndex, e.RowIndex);
        }
        #endregion

        #region checkbox
        private void chkStress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStress.Checked == true)
            {
                chkVar.Checked = false;
                DoPrintStress();
                //clsERMSGeneral.dgvActive = dgvStress;

            }
        }

        public void DoPrintStress()
        {
            DataGridView dgv = new DataGridView();
            dgv.DataSource = null;

            foreach (DataGridViewColumn c1 in dgvStress.Columns)
            {
                DataGridViewColumn c2 = (DataGridViewColumn)c1.Clone();
                dgv.Columns.Add(c2);
            }

            int i = 0;
            foreach (DataGridViewRow dgvr in dgvStress.Rows)
            {
                DataGridViewRow r = (DataGridViewRow)dgvr.Clone();
                i = 0;
                foreach (DataGridViewCell cell in dgvr.Cells)
                {

                    r.Cells[i].Value = cell.Value;
                    i++;
                }
                dgv.Rows.Add(r);
            }

            dgv.Columns["DateF"].HeaderText = "تاریخ";
            dgv.Columns["Price"].HeaderText = "نرخ تسعير";
            dgv.Columns["ReRat"].HeaderText = "بازده ارز";


            clsERMSGeneral.dgvActive = dgv;
        }
        #endregion

        private void cmbCalculateType_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void chkListAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCurrency_SelectionChanged(object sender, EventArgs e)
        {
            if (cmbCurrency.SelectedValue == null || (int)cmbCurrency.SelectedValue < 1)
                return;

            InitGridCurrency();

            DataTable dtAccountsGL = new DataTable();
            dtAccountsGL = Cur.Select_AccountsGL_Currency((int)cmbCurrency.SelectedValue);


            DataTable dtAccountsGL_Map = new DataTable();
            dtAccountsGL_Map = Cur.Select_AccountsGL_Cur_Map((Int32)cmbCurrency.SelectedValue);

            //dgvCurrency1.BeginEdit(true);
            foreach (DataRow dr in dtAccountsGL_Map.Rows)
                foreach (DataRow dgRows in dtAccountsGL.Rows)
                    if ((String)dgRows["Accounting_Code"] == (String)dr["Accounting_Code"])
                    {
                        if ((Int32)dr["Selected"] == 1)
                        {
                            dgRows["Selected"] = 1;
                        }
                        if ((Int32)dr["AL"] == 1)
                            dgRows["AL_Credit"] = 1;
                        else if ((Int32)dr["AL"] == 2)
                            dgRows["AL_Debit"] = 1;

                    }

            dgvCurrency1.DataSource = dtAccountsGL;

            //dgvCurrency1.BeginEdit(true);
            //foreach (DataRow dr in dtAccountsGL_Map.Rows)
            //    foreach (DataGridViewRow dgRows in dgvCurrency1.Rows)
            //        if ((String)dgRows.Cells["Accounting_Code"].Value == (String)dr["Accounting_Code"])
            //        {
            //            if ((Int32)dr["Selected"] == 1)                        
            //                {
            //                    dgRows.Cells["Selected"].Value = 1;
            //                }
            //            if ((Int32)dr["AL"] == 1)
            //                ((DataGridViewComboBoxCell)dgRows.Cells["AL"]).Value = 1;
            //            else
            //                ((DataGridViewComboBoxCell)dgRows.Cells["AL"]).Value = 2;

            //        }
            //dgvCurrency1.EndEdit();
            //dgvCurrency1.Refresh();
            //dgvCurrency1.Update();
        }

        private void dgvCurrency1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCurrency1_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            MessageBox.Show(e.ColumnIndex + "");
        }
        private void FillTemplates()
        {
            DataTable dt = new DAL.SwartDataSetTableAdapters.MR_Stress_Model_NewSelectCommandTableAdapter().GetData();
            lsvModel.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                if (!dr["Model_Type"].ToString().Equals("CurR"))
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

        private void tsbModelNew_Click(object sender, EventArgs e)
        {
            var fs = new frmStressType("CurR");
            fs.btnOK.Visible = fs.btnCancel.Visible = false;
            fs.ShowDialog();
            FillTemplates();
        }

        private void tsbModelEdit_Click(object sender, EventArgs e)
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
                        var fs = new frmStressType(Int32.Parse(dr["ID"].ToString()), Int32.Parse(dr["Model_Patern"].ToString()), Int32.Parse(dr["N"].ToString()), fromDate, toDate, dr["Model_Name"].ToString(), float.Parse(dr["Parameter_Value"].ToString()), Int32.Parse(dr["Formula_Type"].ToString()), "CurR");
                        fs.ShowDialog();
                        FillTemplates();
                        break;
                    }

                }

            }
        }

        private void tsbModelRemove_Click(object sender, EventArgs e)
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                if (Presentation.Public.Routines.ShowMessageBoxFa("الگوی انتخاب شده، حذف خواهد شد. آیا مطمئن هستید؟", "تایید", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem lvi = lsvModel.SelectedItems[0];
                    int id = Int32.Parse(lvi.Tag.ToString());
                    new DAL.SwartDataSetTableAdapters.MR_Stress_Model_NewSelectCommandTableAdapter().Delete(id);
                }
                FillTemplates();
            }
        }

        private void tsbRun_Click(object sender, EventArgs e)
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

                            //frmStressType fx = new frmStressType("CurR");
                            //fx.gbSaveTemplate.Visible = false;
                            //if (fx.ShowDialog() == DialogResult.OK)
                            {
                                switch (Int32.Parse(dr["Model_Patern"].ToString()))
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
                                            switch (Int32.Parse(dr["Formula_Type"].ToString()))
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
                                                switch (Int32.Parse(dr["Formula_Type"].ToString()))
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
    }
}