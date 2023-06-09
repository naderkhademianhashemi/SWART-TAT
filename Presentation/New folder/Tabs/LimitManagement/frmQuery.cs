using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERMSLib;
using System.Data;
using System.Data.SqlClient;
using ActiveDatabaseSoftware.ActiveQueryBuilder;
using ERMS.Logic;
using ERMS.Model;

//
using Presentation.Public;

namespace Presentation.Tabs.LimitManagement
{

    public partial class frmQuery : BaseForm
    {
        #region VAR
        private LM lm;
        #endregion
         
        public frmQuery()
        {
            InitializeComponent();
            lm = new LM();
        }
        decimal vAmount_Limit;
        public decimal Amount_Limit
        {
            get
            {
                return vAmount_Limit;
            }
            set
            {
                
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string SQLString = string.Empty;
            SQLString = qblQuery.txtSQL.Text.ToString();
            SQLString = SQLString.Replace("\r\n", " ");
            DataSet ds = lm.RunSQL(SQLString);

            if (decimal.Parse(ds.Tables[0].Rows[0][0].ToString()) is decimal && ds.Tables[0].Rows.Count == 1 && ds.Tables[0].Columns.Count == 1)
            {
                vAmount_Limit = decimal.Parse(ds.Tables[0].Rows[0][0].ToString());
                this.Close();
            }
            else
            {
                Routines.ShowMessageBoxFa("صحت پرس و جوی خود را بررسی كنيد", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}