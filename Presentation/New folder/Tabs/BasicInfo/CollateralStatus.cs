///
/// Created By Bahramian In 87/03/12**
///
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ERMSLib;
using System.Data.Common;

//using Microsoft.Practices.EnterpriseLibrary.Data;
//using Microsoft.Practices.EnterpriseLibrary.Data.Configuration;

namespace Presentation.Tabs.BasicInfo
{
    class CollateralStatus
    {
        #region Variables
        public SqlConnection conn;
        private bool bolResult;
        private SqlDataAdapter sqlDa;
        private SqlCommandBuilder sqlCmdBld;
        private DataSet ds = new DataSet();
        private DataTable dtbl = new DataTable();
        public int intRowID;
        bool bolDelResult;
        #endregion

        public string Collateral_StatusCount()
        {
            SqlConnection conn = new SqlConnection(clsERMSGeneral.connStr);
            DataSet ds = new DataSet();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select Count(*) from Collateral_Status", conn);
            da.Fill(ds, "Collateral_Status");
            conn.Close();
            return ds.Tables["Collateral_Status"].Rows[0][0].ToString();
        }

        public DataTable GetCollateral_Status(int startIndex, int endIndex)
        {
            DataTable ds = new DAL.SwartDataSetTableAdapters.GetDT_Collateral_StatusTableAdapter().GetData(startIndex, endIndex);
            
            
            return ds;
        }
        public DataTable Collateral_StatusSearch(string searchIndex, string strField, string strOperator)
        {
            string str;
            switch (strField)
            {
                //case "Collateral_Status": str = searchIndex.Trim();
                //    break;

                case "Collat_Stat_Desc":
                    str = searchIndex.Trim();
                    break;
                case "Collat_Stat":
                    str = strField + "  " + strOperator + " " + searchIndex;
                    break;

                default: str = strField + "  like '%" + searchIndex + "%' ";
                    break;
            }
            DataTable ds = new DAL.SwartDataSetTableAdapters.GetDT_Collateral_StatusSearchTableAdapter().GetData(str, strField.Trim());
            
            return ds;
        }
        public bool InsertCollateral_Status(int intCollateral_Stat, string strCollateral_Stat_Desc)
        {
            try
            {
                conn = new SqlConnection(clsERMSGeneral.connStr);
                conn.Open();
                int RESULT=new DAL.SwartDataSetTableAdapters.QueriesTableAdapter().Insert_Collateral_Status(intCollateral_Stat, strCollateral_Stat_Desc);


                if (RESULT > 0)
                
                    bolResult = true;
                //intRowID = (int)cmd.Parameters["@Return_Value"].Value;
            }
            catch
            {
                bolResult = false;
            }
            return bolResult;
        }

        public bool DeleteCollateral_Status(int intCollateral_Stat)
        {
            bolDelResult = false;
            int RESULT=new DAL.SwartDataSetTableAdapters.QueriesTableAdapter().Delete_Collateral_Status(intCollateral_Stat);


                if (RESULT > 0)
            
                bolDelResult = true;
            return bolDelResult;
        }
        public DataSet Sel_Collateral_Status()
        {
            conn = new SqlConnection(clsERMSGeneral.connStr);
            sqlDa = new SqlDataAdapter("select * from Collateral_Status ", conn.ConnectionString);
            sqlCmdBld = new SqlCommandBuilder(sqlDa);
            ds.Clear();
            sqlDa.Fill(ds);
            return ds;
        }
        public bool checkDuplicated(int intCollateral_Stat)
        {
            using (conn = new SqlConnection(clsERMSGeneral.connStr))
            {
                bool bolDupResult = false;
                conn.Open();
                sqlDa = new SqlDataAdapter("select * from Collateral_Status", conn.ConnectionString);
                dtbl.Clear();
                sqlDa.Fill(dtbl);
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dtbl.Rows[i]["Collat_Stat"]) == intCollateral_Stat)
                        bolDupResult = true;
                }

                return bolDupResult;
            }
        }
    }
}
