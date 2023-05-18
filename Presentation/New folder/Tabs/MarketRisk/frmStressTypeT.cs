using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ERMS.Logic;
using ERMS.Model;


using ERMSLib;
using Presentation.Public;

namespace Presentation.Tabs.MarketRisk
{
    public partial class frmStressTypeT : BaseForm
    {
        #region VAR
        int templateID = 0;
        string Original_Model_Name = "";
        int Original_Model_Patern = 0;
        #endregion

        public frmStressTypeT()
        {
            InitializeComponent();
            //pFrom = new PersianTools.Dates.PersianDate((DateTime)DateTime.Now);
            fdpFrom.SelectedDateTime = fdpTo.SelectedDateTime = DateTime.Now;// pFrom.FormatedDate("yyyy/MM/dd");

        }
        public frmStressTypeT(int tID, int Type, int N, DateTime fromDate, DateTime toDate, string name, float value, int FType)
        {
            InitializeComponent();
            templateID = tID;
            Original_Model_Patern = Type;
            switch (Type)
            {
                case 1:
                    rdoType1.Checked = true;
                    break;
                case 2:
                    rdoType2.Checked = true;
                    break;
                case 3:
                    rdoType3.Checked = true;
                    break;
            }

            txtN.Text = N.ToString();

            if (fromDate != null)
            {
                //pFrom = new PersianTools.Dates.PersianDate((DateTime)fromDate);
                //fdpFrom.Text = pFrom.FormatedDate("yyyy/MM/dd");
                fdpFrom.SelectedDateTime = fromDate;
            }
            if (toDate != null)
            {
                //pTo = new PersianTools.Dates.PersianDate((DateTime)toDate);
                //fdpTo.Text = pTo.FormatedDate("yyyy/MM/dd");
                fdpTo.SelectedDateTime = toDate;

            }
            Original_Model_Name= txtTemplateName.Text = name;
            txtA.Text = value.ToString();
            switch (FType)
            {
                case 1:
                    rdoF1.Checked = true;
                    break;
                case 2:
                    rdoF2.Checked = true;
                    break;
            }
            btnCancel.Visible = btnOK.Visible = false;
        }
        private void frmStressType_Load(object sender, EventArgs e)
        {
            //GeneralDataGridView = clsERMSGeneral.dgvActive;
            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

            //fdpFrom.ResetSelectedDateTime();
            //fdpFrom.SelectedDateTime = DateTime.Now;

            //fdpTo.ResetSelectedDateTime();
            //fdpTo.SelectedDateTime = DateTime.Now.AddDays(1);

        }

        public DateTime DateFrom
        {
            get
            {
                //pFrom = new PersianTools.Dates.PersianDate(int.Parse(fdpFrom.Text.Substring(0, 4)), int.Parse(fdpFrom.Text.Substring(5, 2)), int.Parse(fdpFrom.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                //DateTime dtFrom = DateTime.Parse(pFrom.ToGregorian.ToString("yyyy/MM/dd"));

                return fdpFrom.SelectedDateTime;//dtFrom;
            }
        }
        public DateTime DateTo
        {
            get
            {

                //pTo = new PersianTools.Dates.PersianDate(int.Parse(fdpTo.Text.Substring(0, 4)), int.Parse(fdpTo.Text.Substring(5, 2)), int.Parse(fdpTo.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                //DateTime dtTo = DateTime.Parse(pTo.ToGregorian.ToString("yyyy/MM/dd"));

                return fdpTo.SelectedDateTime;//dtTo;
            }
        }
        public int N
        {
            get
            {
                int n = 0;
                Presentation.Public.Routines.GetNumericValue(txtN.Text, out n);
                return n;
            }
        }
        public double A
        {
            get
            {
                double a = 0;
                Presentation.Public.Routines.GetNumericValue(txtA.Text, out a);
                return a;
            }
        }
        public int Formula
        {
            get
            {
                int fn = 1;
                if (rdoF1.Checked) fn = 1;
                if (rdoF2.Checked) fn = 2;

                return fn;
            }
        }
        public int ChangeType
        {
            get
            {
                int cn = 1;
                if (rdoType1.Checked) cn = 1;
                if (rdoType2.Checked) cn = 2;
                if (rdoType3.Checked) cn = 3;

                return cn;
            }
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSaveTemplate_CButtonClicked(object sender, EventArgs e)
        {
            if (templateID == 0)
                new DAL.SwartDataSetTableAdapters.MR_Stress_Model_NewSelectCommandTableAdapter().Insert(txtTemplateName.Text, ChangeType.ToString(), N, DateFrom, DateTo, A, Formula);
            else
            {
                new DAL.SwartDataSetTableAdapters.MR_Stress_Model_NewSelectCommandTableAdapter().Delete(templateID);
                new DAL.SwartDataSetTableAdapters.MR_Stress_Model_NewSelectCommandTableAdapter().Insert(txtTemplateName.Text, ChangeType.ToString(), N, DateFrom, DateTo, A, Formula);
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}