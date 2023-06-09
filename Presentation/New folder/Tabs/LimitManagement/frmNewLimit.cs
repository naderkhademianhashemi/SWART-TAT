using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using ERMS.Logic;

//
using Presentation.Public;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.Tabs.LimitManagement
{
    public partial class frmNewLimit :   BaseForm
    {
        public int Color
        {
            get
            {
                return lblColor.BackColor.ToArgb();
            }
            set
            {
                lblColor.BackColor = System.Drawing.Color.FromArgb(value);
            }
        }
        string strLimitValue = string.Empty;
        public string LimitValue
        {
            get
            {
                return strLimitValue;
                //if (strLimitValue == string.Empty)
                //    return cmbLimitValue.Text;
                //else
                //    return cmbLimitValue.Text;
            }

            set
            {  strLimitValue = value; }
            //if (value != string.Empty)
            //    {
            //       cmbLimitValue.SelectedValue = value;
            //        //txtGroupTitle.Enabled = true;
            //        //rdoGroupTitle.Checked = true;
            //    }
            
        }
        string strLimit = string.Empty;
        public string Limit
        {
            get
            { return cmbLimit.Text; }
            
            set
            { strLimit = value; }           
            
        }
      
        string tbLimitBase;
        public string LimitBase
        {
            get { return tbLimitBase; }
            set { tbLimitBase = value; }
        }
     //   bool ApplyAll;
        public bool ApplyAll
        {
            get { return ChkApplyAll.Checked; }
          //  set { ApplyAll = value; }
        }
        private string strTable_Name;
        public string Table_Name
        {
            get { return strTable_Name; }
            set { strTable_Name = value; }
        }
        private string strField_Id;
        public string Field_Id
        {
            get { return strField_Id; }
            set { strField_Id = value; }
        }
        private string strOperator;
        public string Operator
        {
            get { return strOperator; }
            set { strOperator = value; }
        }

        #region VAR/CONTROLS
             
        private LM lm;
        DataTable dtTableXml;
        //private RPT rpt;
     
        #endregion

        public frmNewLimit()
        {
            InitializeComponent();
        }
        
        private void frmNewLimit_Load(object sender, EventArgs e)
        {
            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

            fdpStartDate.SelectedDateTime = DateTime.Now;
            fdpStartDate.ResetSelectedDateTime();

            fdpMaturityDate.SelectedDateTime = DateTime.Now.AddDays(1);
            fdpMaturityDate.ResetSelectedDateTime();
            lm = new LM();
            //rpt = new RPT();
            ReadXml();
            RebindLimit(tbLimitBase);
            strOperator = "=";
            grbCounterparty.Visible = false;
            grbContract.Visible = false;
            grbStartDate.Visible = false;
            grbMaturityDate.Visible = false;
            cmbOperatorStartDate.Items.Clear();
            cmbOperatorStartDate.AddItemsRange(new string[] { "بزرگتر", "كوچكتر", "كوچكتر مساوی","بزرگتر مساوِی" });

            cmbOperatorMaturityDate.Items.Clear();
            cmbOperatorMaturityDate.AddItemsRange(new string[] { "بزرگتر", "كوچكتر", "كوچكتر مساوی", "بزرگتر مساوِی" });
            cmbLimitValue.SelectedIndex = -1;
            

        }
        private void RebindLimit(string TableName)
        {
            DataTable dtLimit = lm.Get_Table_Dependency(TableName);
#warning حذف مقادیر بدون نام فارسی در فایل XML
            for (int i = dtLimit.Rows.Count - 1; i >= 0; i-- )
            {
                // Hosein_91.02.13
                // Conterparty & LoanContract movaghatan hazf shodan, bayad eslah shavad 
                if (dtLimit.Rows[i]["TABLE_NAME"].ToString().ToUpper().Equals("COLLATERAL") ||
                    dtLimit.Rows[i]["TABLE_NAME"].ToString().ToUpper().Equals("COLLATERAL_STATUS") ||
                    dtLimit.Rows[i]["TABLE_NAME"].ToString().ToUpper().Equals("CURRENCY") ||
                    dtLimit.Rows[i]["TABLE_NAME"].ToString().ToUpper().Equals("BRANCH_RANK") ||
                    dtLimit.Rows[i]["TABLE_NAME"].ToString().ToUpper().Equals("COUNTERPARTY") ||
                    dtLimit.Rows[i]["TABLE_NAME"].ToString().ToUpper().Equals("LOAN_CONTRACT") ||
                    dtLimit.Rows[i]["TABLE_NAME"].ToString().ToUpper().Equals("LOAN_GOAL") ||
                    dtLimit.Rows[i]["TABLE_NAME"].ToString().ToUpper().Equals("LOAN_USES"))
                {
                    dtLimit.Rows.Remove(dtLimit.Rows[i]);                    
                }
            }
            dtLimit.AcceptChanges();

                        try
                        {
                            //dtLimit.Rows.Cast<DataRow>().Where(row => row["TABLE_NAME"].ToString().ToUpper().Equals("COLLATERAL")).FirstOrDefault().Delete();
                            //dtLimit.AcceptChanges();
                            //dtLimit.Rows.Cast<DataRow>().Where(row => row["TABLE_NAME"].ToString().ToUpper().Equals("COLLATERAL_STATUS")).FirstOrDefault().Delete();
                            //dtLimit.AcceptChanges();
                            //dtLimit.Rows.Cast<DataRow>().Where(row => row["TABLE_NAME"].ToString().ToUpper().Equals("CURRENCY")).FirstOrDefault().Delete();
                            //dtLimit.AcceptChanges();
                            //dtLimit.Rows.Cast<DataRow>().Where(row => row["TABLE_NAME"].ToString().ToUpper().Equals("BRANCH_RANK")).FirstOrDefault().Delete();
                            //dtLimit.AcceptChanges();
                            //dtLimit.Rows.Cast<DataRow>().Where(row => row["TABLE_NAME"].ToString().ToUpper().Equals("LOADN_GOAL")).FirstOrDefault().Delete();
                            //dtLimit.AcceptChanges();
                            //dtLimit.Rows.Cast<DataRow>().Where(row => row["TABLE_NAME"].ToString().ToUpper().Equals("LOAN_USE")).FirstOrDefault().Delete();
                            //dtLimit.AcceptChanges();

                        }
                        catch (Exception)
                        {

                        }
                        finally
                        {
                            DataColumn dcol = new DataColumn("Farsi", typeof(System.String));
                            dtLimit.Columns.Add(dcol);

                            for (int i = 0; i < dtLimit.Rows.Count; i++)
                            {
                                foreach (DataRow dr in dtTableXml.Rows)
                                    if (dr["TableNameEnglish"].ToString() == dtLimit.Rows[i]["TABLE_NAME"].ToString())
                                    {
                                        dtLimit.Rows[i]["Farsi"] = dr["TableNameFarsi"];
                                        break;
                                    }
                            }

                            DataRow drStartDate = dtLimit.NewRow();
                            drStartDate["Farsi"] = "تاريخ شروع";
                            drStartDate["TABLE_NAME"] = "Start_Date";
                            dtLimit.Rows.Add(drStartDate);

                            DataRow drMaturityDate = dtLimit.NewRow();
                            drMaturityDate["Farsi"] = "تاريخ خاتمه";
                            drMaturityDate["TABLE_NAME"] = "Maturity_Date";
                            dtLimit.Rows.Add(drMaturityDate);

                            //var dataRows= dtLimit.Rows.Cast<DataRow>().Where(row => row["Farsi"] != null).ToList();
                            cmbLimit.DataSource = dtLimit;
                            cmbLimit.DisplayMember = "Farsi";
                            cmbLimit.ValueMember = "TABLE_NAME";
                            cmbLimit.SelectedIndex = -1;
                            if (strLimit != string.Empty)


                                cmbLimit.SelectedByDataValue(strLimit.Substring(0, strLimit.IndexOf(".")));
                        }

        }

        private void cmbLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
          if (cmbLimit.DataSource != null && cmbLimit.SelectedIndex != -1 && cmbLimit.SelectedValue is string)
          {
              if (cmbLimitValue.DataSource != null)
                  cmbLimitValue.DataSource = null;
              FillDest(cmbLimit.SelectedValue.ToString());
          } 
        }
        private void ReadXml()
        {
            string s = Assembly.GetExecutingAssembly().Location;
            s = s.Substring(0, s.LastIndexOf("\\")) + "\\" + "TableProperty.xml";
            DataSet dset = new DataSet();
            FileStream fstr = new FileStream(s, FileMode.Open, FileAccess.Read);
            dset.ReadXml(fstr);
            dtTableXml = dset.Tables[0];
        }
        private void FillDest(string TableName)
        {
            if (TableName != string.Empty)
            {
               switch (TableName)
                    {
                        case "Counterparty":

                             grbCounterparty.Visible = true;
                             grbContract.Visible = false;
                             grbStartDate.Visible = false;
                             grbMaturityDate.Visible = false;
                             txtCounterparty.Text = string.Empty;
                            break;

                        case "Loan_Contract":

                              grbCounterparty.Visible = false;
                              grbContract.Visible = true;
                              grbStartDate.Visible = false;
                              grbMaturityDate.Visible = false;
                              txtContract.Text = string.Empty;
                              break;

                         case "Start_Date":

                             grbStartDate.Visible = true;
                             grbMaturityDate.Visible = false;
                             grbCounterparty.Visible = false;
                             grbContract.Visible = false;
                             break;

                         case "Maturity_Date":
                             grbMaturityDate.Visible = true;
                             grbStartDate.Visible = false;
                             grbCounterparty.Visible = false;
                             grbContract.Visible = false;
                             break;

                      default : 
                                grbCounterparty.Visible = false;
                                grbContract.Visible = false;
                                grbStartDate.Visible = false;
                                grbMaturityDate.Visible = false;
                                cmbLimitValue.Visible = true;
                                pnlDetailesCombo.Visible = true;

                        string str = "TableNameEnglish like '" + TableName + "' ";
                        DataRow[] dr = dtTableXml.Select(str);


                        string strField = dr[0]["Field"].ToString();
                        string strId = dr[0]["Id"].ToString();
                        string filterexpression = "";

                        // چون مدیریت حدود تنها برای تسهیلات و ضمانت نامه هاست، 
                        // می بایست سپرده و زیر نوع آن از نوع کلی قرارداد و نوع قرارداد حذف شود
                        // که در دو قسمت زیر این کنترل انجام می شود
                        if (TableName.Equals("Contract_Major_Type"))
                        {
                            filterexpression = " where Contract_MType_id <> 4";
                        }
                        else if (TableName.Equals("Contract_Type"))
                        {
                            filterexpression = " where Contract_Type < 200000000 or Contract_Type > 300000000 ";
                        }
                        else if (TableName.Equals("Contract_type_groups"))
                        {
                            filterexpression = " where Contract_MType_id <> 4 ";
                        }
                        strTable_Name =  strId;

                        DataTable dtDest = lm.GetTable(strId, strField, TableName, filterexpression);
                        
                        DataRow drDest = dtDest.NewRow();
                        dtDest.Rows.InsertAt(drDest, 0);
                        dtDest.Rows[0][strField] = "همه";
                        cmbLimitValue.DataSource = dtDest;
                        cmbLimitValue.DisplayMember = strField;
                        cmbLimitValue.ValueMember = strId;
                        cmbLimitValue.SelectedIndex = -1;
         break;

                                
                            }



               
                      
            }
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblColor.BackColor = colorDialog.Color;
            }
        }
            
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Checked())
            {
                try
                {
                    ProgressBox.Show();

                    //  if (cmbLimit.SelectedValue == "Counterparty")

                    if (pnlDetailesCombo.Visible && cmbLimitValue.SelectedValue != null)

                    { strField_Id = cmbLimitValue.SelectedValue.ToString(); 
                      strLimitValue = cmbLimitValue.Text;
                      this.DialogResult = DialogResult.OK;
                      this.Close();
                     
                    }
                    else
                    {
                        if (grbCounterparty.Visible)
                        {
                            strTable_Name = "Counterparty.Counterparty";
                            if (rdbAll.Checked)
                            {
                                strField_Id = "-1";
                                strLimitValue = rdbAll.Text;
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            if (rdbOne.Checked)
                            {
                                if (txtCounterparty.Text != string.Empty)
                                {
                                    strField_Id = txtCounterparty.Text;
                                    strLimitValue = txtCounterparty.Text;
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }

                            }
                        }
                        if (grbContract.Visible)
                        {
                            strTable_Name = "Loan_Contract.Contract";
                            if (rdbAllContract.Checked)
                            {
                                strField_Id = "-2";
                                strLimitValue = rdbAll.Text;
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            if (rdbContract.Checked)
                            {
                                if (txtContract.Text != string.Empty)
                                {
                                    strField_Id = txtContract.Text;
                                    
                                    strLimitValue = txtContract.Text;
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }

                            }
                        }
                        if (grbStartDate.Visible)
                        {
                            strTable_Name = "Start_Date";

                            //PersianTools.Dates.PersianDate p;
                            //p = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                            //DateTime startDate = DateTime.Parse(p.ToGregorian.ToString("yyyy/MM/dd"));

                            strField_Id = fdpStartDate.SelectedDateTime.ToString("yyyy/MM/dd"); //p.ToGregorian.ToString("yyyy/MM/dd");
                          //  strOperator = cmbOperatorStartDate.Text;
                            strLimitValue = fdpStartDate.Text.ToString();//fdpStartDate.Text ;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        if (grbMaturityDate.Visible)
                        {
                            strTable_Name = "Maturity_Date";

                            //PersianTools.Dates.PersianDate p;
                            //p = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                            //DateTime startDate = DateTime.Parse(p.ToGregorian.ToString("yyyy/MM/dd"));

                            strField_Id = fdpMaturityDate.SelectedDateTime.ToString("yyyy/MM/dd"); //p.ToGregorian.ToString("yyyy/MM/dd");
                            //  strOperator = cmbOperatorStartDate.Text;
                            strLimitValue = fdpMaturityDate.SelectedDateTime.ToString("yyyy/MM/dd");//fdpStartDate.Text ;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }    
                    }

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
        }
        private bool Checked()
        {

            if (cmbLimitValue.Text == string.Empty && grbCounterparty.Visible == false && grbContract.Visible == false && grbStartDate.Visible == false && grbMaturityDate.Visible == false)
            {
                Presentation.Public.Routines.ShowMessageBoxFa("وضعيت مورد نظر را برای حدود انتخاب كنيد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return false;
            }
            return true;

        }

        private void cmbLimitValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAll.Checked)
                txtCounterparty.Text = string.Empty;
        }

        private void rdbAllContract_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAllContract.Checked)
                txtContract.Text = string.Empty;
        }

        private void cmbOperatorStartDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            strOperator = findOperator(cmbOperatorStartDate.Text);
        }
        private string findOperator(string cmbText)
        {
            switch (cmbText)
            {
                case "بزرگتر":
                    return ">";

                case "كوچكتر":
                    return "<";

                case "كوچكتر مساوی":
                    return "<=";

                case "بزرگتر مساوِی":
                    return ">=";

                default:
                    return cmbText;
            }
        
        }

        private void cmbOperatorMaturityDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            strOperator = findOperator(cmbOperatorMaturityDate.Text);
        }

        private void btnCancel_CButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbLimitValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void grbStartDate_VisibleChanged(object sender, EventArgs e)
        {
            bool visible = pnlDetailesCombo.Visible;
            pnlDetailesCombo.Visible = !visible;
        }

        private void cmbOperatorStartDate_SelectionChanged(object sender, EventArgs e)
        {
            strOperator = findOperator(cmbOperatorStartDate.Text);
        }
         

        
    }
}