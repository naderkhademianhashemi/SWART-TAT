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
using ERMS.Model;


using ERMSLib;
using Presentation.Public;

namespace Presentation.Tabs.CurRisk
{
    //public partial class frmCurStressType : Presentation.Tabs.MarketRisk.frmStressType
    public partial class frmCurStressType : BaseForm
    {
        #region VAR
        PersianTools.Dates.PersianDate pFrom, pTo;
        #endregion

        public frmCurStressType()
        {
            InitializeComponent();
            pFrom = new PersianTools.Dates.PersianDate((DateTime)DateTime.Now);
            fdpFrom.Text = fdpTo.Text = pFrom.FormatedDate("yyyy/MM/dd");
        }
        private void frmCurStressType_Load(object sender, EventArgs e)
        {

        }

        public DateTime DateFrom
        {
            get {
                pFrom = new PersianTools.Dates.PersianDate(int.Parse(fdpFrom.Text.Substring(0, 4)), int.Parse(fdpFrom.Text.Substring(5, 2)), int.Parse(fdpFrom.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                DateTime dtFrom = DateTime.Parse(pFrom.ToGregorian.ToString("yyyy/MM/dd"));

                return dtFrom;
            }
        }
        public DateTime DateTo
        {
            get {

                pTo = new PersianTools.Dates.PersianDate(int.Parse(fdpTo.Text.Substring(0, 4)), int.Parse(fdpTo.Text.Substring(5, 2)), int.Parse(fdpTo.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                DateTime dtTo = DateTime.Parse(pTo.ToGregorian.ToString("yyyy/MM/dd"));

                return dtTo;
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
        public int A
        {
            get
            {
                int a = 0;
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
    }
}