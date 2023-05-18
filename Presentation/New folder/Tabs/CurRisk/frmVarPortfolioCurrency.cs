using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//      
using ERMSLib;
using System.Globalization;
using ERMS.Logic;
using ERMS.Model;
using Presentation.Public;

namespace Presentation.Tabs.CurRisk
{
    public partial class frmVarPortfolioCurrency : BaseForm, IPrintable
    {

        private CurR Cur;
        private MR mr;
        private bool bolFormLoad;
        PersianTools.Dates.PersianDate pFrom, pTo;
        public frmVarPortfolioCurrency()
        {
            InitializeComponent();
            Cur = new CurR();
            clsERMSGeneral.InitializeTheme(this);
        }

        private void frmVarPortfolioCurrency_Load(object sender, EventArgs e)
        {
            Init();
            initGrid();
            loadData();
          
        }
       

        private void loadData()
        {
            DataTable dtblTemp = new DataTable();
            dtblTemp = Cur.select_UserCurrency_CurR_Portfo();            
            for (int i = 0; i < dgvCurrency1.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTemp.Rows.Count; j++)
                {
                    if (dgvCurrency1["Currency", i].Value != null && dgvCurrency1["Currency", i].Value.ToString() == dtblTemp.Rows[j]["Currency"].ToString())
                    {
                        dgvCurrency1["Checked", i].Value = "1";
                        break;
                    }
                }

            }
            

        }

        private void initGrid()
        {
            DataTable dt = new DataTable();

            dt = Cur.GetDTCurrency();
            dt.Columns.Add("Checked");
            dgvCurrency1.DataSource = dt;
        }
        private void Init()
        {
            cmbCalculateType.AddItemsRange(new string[] { "دارايي", "بدهي","باز" });
            cmbCalculateType.SelectedIndex = -1;
            pFrom = new PersianTools.Dates.PersianDate((DateTime)DateTime.Now);
            fdpFrom.Text = fdpTo.Text = pFrom.FormatedDate("yyyy/MM/dd");
            dgvMatrix.ReadOnly = true;
            dgvSummary.ReadOnly = true;
            GeneralDataGridView = dgvSummary;
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < dgvCurrency1.Rows.Count; i++)
            {
                if (dgvCurrency1["Checked", i].Value != null && dgvCurrency1["Checked", i].Value.ToString() == "1")
                {
                    cnt = cnt + 1;
                }
                
            }
            if (cnt <= 1)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("حداقل دو ارز ميبايست در پورتفو موجود باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
           
            for (int i = 0; i < dgvCurrency1.Rows.Count ; i++)
            {
                if (dgvCurrency1["Checked", i].Value != null && dgvCurrency1["Checked", i].Value.ToString() == "1")
                {
                    if (!CheckAccountMap(int.Parse(dgvCurrency1["Currency", i].Value.ToString())))
                    {
                        Presentation.Public.Routines.ShowMessageBoxFa("لازم است حساب ارزي " + 
                                            dgvCurrency1["Currency_Description",i].Value.ToString() + " را از بخش ارزش در خطرارز " + 
                                            "  تطبيق دهيد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            save();
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
        private void save()
        {
            try
            {
                ArrayList arLst = new ArrayList();
                string strQuery = string.Empty;
                for (int i = 0; i < dgvCurrency1.Rows.Count; i++)
                {
                    if (dgvCurrency1["Checked",i].Value != null && dgvCurrency1["Checked",i].Value.ToString() == "1")
                        strQuery = strQuery + dgvCurrency1["Currency", i].Value.ToString() + ",";
                }
                strQuery = strQuery.Substring(0, strQuery.Length - 1);
                if (strQuery.Length > 0)
                {
                    Cur.Insert_UserCurrency_CurR_Portfo(strQuery);
                    Presentation.Public.Routines.ShowMessageBoxFa("تغييرات اعمال شد .", "پيام ",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exp)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("تغييرات اعمال نشد .", "خطا ",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRun1_Click(object sender, EventArgs e)
        {
            RunApplication();
        }

        private void RunApplication()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dgvMatrix.DataSource = null;
                dgvSummary.DataSource = null;
                DataTable dtbl = new DataTable();
                DataTable dtbl1 = new DataTable();

                pFrom = new PersianTools.Dates.PersianDate(int.Parse(fdpFrom.Text.Substring(0, 4)), int.Parse(fdpFrom.Text.Substring(5, 2)), int.Parse(fdpFrom.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                DateTime dtFrom = DateTime.Parse(pFrom.ToGregorian.ToString("yyyy/MM/dd"));
                pTo = new PersianTools.Dates.PersianDate(int.Parse(fdpTo.Text.Substring(0, 4)), int.Parse(fdpTo.Text.Substring(5, 2)), int.Parse(fdpTo.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                DateTime dtTo = DateTime.Parse(pTo.ToGregorian.ToString("yyyy/MM/dd"));


                double vaR = 0, VarRiskMetrics = 0;

                if (txtCL.Text != "" & txtNdays.Text != "" & cmbCalculateType.SelectedIndex != -1)
                {
                    int intVar = Convert.ToInt32(cmbCalculateType.SelectedIndex + 1);
                    Cur.Return_CurR_Run_Varp1(intVar, dtFrom, dtTo, Convert.ToInt32(txtNdays.Text), 
                                                    float.Parse(txtCL.Text), out vaR, out VarRiskMetrics);
                }
                txtVaR1.Text = vaR.ToString("###,##0.####");
                txtVaR1RM.Text = VarRiskMetrics.ToString("###,##0.####");
                dtbl = Cur.CurR_Matrix_GetDT();
                dtbl1 = Cur.LoadCurR_CurrencyInfo();
                dtbl.Columns[0].ColumnName = "همبستگي";
                dtbl.Columns[1].ColumnName = "كو واريانس";
                dtbl.Columns[2].ColumnName = "ارز اول";
                dtbl.Columns[3].ColumnName = "ارز دوم";

                dtbl1.Columns[0].ColumnName = "وزن";
                dtbl1.Columns[1].ColumnName = "نوسان";
                dtbl1.Columns[2].ColumnName = "ارزش ريالي موقعيت";
                dtbl1.Columns[3].ColumnName = "ارز اول";

                dgvMatrix.DataSource = dtbl;
                dgvSummary.DataSource = dtbl1;

                //dgvMatrix.DataSource = Cur.CurR_Matrix_GetDT();
                //dgvSummary.DataSource = Cur.LoadCurR_CurrencyInfo();
                Presentation.Public.Routines.ShowMessageBoxFa("تغييرات اعمال شد .", "پيام ",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor = Cursors.Default;
            }
            catch (Exception exp)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("تغييرات اعمال نشد .", "خطا ",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
        }

        private void btnRun2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSTVariance.RowCount; i++)
            {
                if ( dgvSTVariance[1, i].Value.ToString() == "" )
                {
                    dgvSTVariance[1, i].Value = "0";

                    Cur.Update_CurR_Matrix_St(Convert.ToDecimal(dgvSTVariance[1,i].Value.ToString())
                                                        ,Convert.ToInt32(dgvSTVariance[0,i].Value) );
                }
                else
                {
                    Cur.Update_CurR_Matrix_St(Convert.ToDecimal(dgvSTVariance[1, i].Value.ToString())
                                                        , Convert.ToInt32(dgvSTVariance[0, i].Value));}
            }

         
            pFrom = new PersianTools.Dates.PersianDate(int.Parse(fdpFrom.Text.Substring(0, 4)), int.Parse(fdpFrom.Text.Substring(5, 2)), int.Parse(fdpFrom.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            DateTime dtFrom = DateTime.Parse(pFrom.ToGregorian.ToString("yyyy/MM/dd"));
            pTo = new PersianTools.Dates.PersianDate(int.Parse(fdpTo.Text.Substring(0, 4)), int.Parse(fdpTo.Text.Substring(5, 2)), int.Parse(fdpTo.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            DateTime dtTo = DateTime.Parse(pTo.ToGregorian.ToString("yyyy/MM/dd"));
             

            double vaR = 0, VaRRiskMetrics = 0;

            if (txtCL.Text != "" & txtNdays.Text != "" & cmbCalculateType.SelectedIndex != -1)
            {
                int intVar = Convert.ToInt32(cmbCalculateType.SelectedIndex + 1);
                Cur.Return_CurR_Run_Varp1_St(intVar, dtFrom, dtTo, Convert.ToInt32(txtNdays.Text), float.Parse(txtCL.Text),
                                                                    out vaR, out VaRRiskMetrics);


            }
          
            txtVaR2.Text = vaR.ToString("###,##0.####");
            txtVaR2RM.Text = VaRRiskMetrics.ToString("###,##0.####");
            ShowDifference();



        }
        private void ShowDifference()
        {
           

                string sign;
                if (txtVaR1.Text == "")
                    txtVaR1.Text = "0";
                decimal temp3 = (decimal.Parse(txtVaR1.Text) - decimal.Parse(txtVaR2.Text));
                sign = temp3 >= 0 ? "+" : "";

                decimal temp4 = (decimal.Parse(txtVaR1RM.Text) - decimal.Parse(txtVaR2RM.Text));
                sign = temp4 >= 0 ? "+" : "";

                txtDifference.Text = sign + temp3;
                txtDifferenceRM.Text = sign + temp4;
        
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            btnRun1_Click(sender, e);

            intDgvSTDvariance();
        }

        private void intDgvSTDvariance()
        {
            DataTable dtbl = new DataTable();
            dtbl = Cur.CurR_Matrix_GetDT_St();
            dtbl.Columns[1].ColumnName = "همبستگي ";
            dtbl.Columns[2].ColumnName = "ارز اول ";
            dtbl.Columns[3].ColumnName = "ارز دوم ";
            dgvSTVariance.DataSource = dtbl;
            dgvSTVariance.Columns[0].Visible = false;
            dgvSTVariance.Columns[0].Width = 0;
            dgvSTVariance.Columns[1].ReadOnly = true;
            dgvSTVariance.Columns[2].ReadOnly = true;
            dgvSTVariance.Columns[3].ReadOnly = true;
            dgvSTVariance.RightToLeft = RightToLeft.Yes;
            dgvSTVariance.AllowUserToAddRows = false;

        }

        private void chkSummary_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSummary.Checked == true)
            {
                chkMatrix.Checked = false;
                clsERMSGeneral.dgvActive = dgvSummary;               
            }
        }
        
        public void DoPrint()
        {
            //empty print
        }

        public void DoHelp()
        {
         //   clsERMSGeneral.strHelp = "VaRShare";
        }

        private void chkMatrix_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMatrix.Checked == true)
            {
                chkSummary.Checked = false;
                clsERMSGeneral.dgvActive = dgvMatrix;
            }
        }


        private void chbChangeDGVReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            dgvSTVariance.Columns[1].ReadOnly = !chbChangeDGVReadOnly.Checked;
            if(!chbChangeDGVReadOnly.Checked)
                intDgvSTDvariance();                
        }


    }
}