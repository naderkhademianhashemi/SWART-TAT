///
/// Created By Bahramian In 87/03/11**
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
    class CollateralType
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

        public string Collateral_TypeCount()
        {
            SqlConnection conn = new SqlConnection(clsERMSGeneral.connStr);
            DataSet ds = new DataSet();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select Count(*) from Collateral_Type", conn);
            da.Fill(ds, "Collateral_Type");
            conn.Close();
            return ds.Tables["Collateral_Type"].Rows[0][0].ToString();
        }

        public DataTable GetCollateral_Type(int startIndex, int endIndex)
        {

            DataTable ds = new DAL.SwartDataSetTableAdapters.GetDT_Collateral_TypeTableAdapter().GetData(startIndex, endIndex);
            
            return ds;
        }
        public DataTable Collateral_TypeSearch(string searchIndex, string strField, string strOperator)
        {
            string str;
            switch (strField)
            {
                //case "Collateral_Type": str = searchIndex.Trim();
                //    break;

                case "Collateral_Type_Desc":
                    str = searchIndex.Trim();
                    break;

                case "Collateral_Type":
                    str = strField + "  " + strOperator + " " + searchIndex;
                    break;
                case "Collat_Major_Type_Desc":
                    str = searchIndex.Trim();
                    break;


                default: str = strField + "  like '%" + searchIndex + "%' ";
                    break;
            }

            DataTable ds = new DAL.SwartDataSetTableAdapters.GetDT_Collateral_TypeSearchTableAdapter().GetData(str, strField.Trim());
            
            return ds;
        }
        public bool InsertCollateral_Type(int intCollateral_Type, string strCollateral_Type_Desc,int intCollat_Major_Type)
        {
            try
            {
                conn = new SqlConnection(clsERMSGeneral.connStr);
                conn.Open();

                 int RESULT=new DAL.SwartDataSetTableAdapters.QueriesTableAdapter().Insert_Collateral_Type(intCollateral_Type, strCollateral_Type_Desc, intCollat_Major_Type);


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

        public bool DeleteCollateral_Type(int intCollateral_Type)
        {
            bolDelResult = false;
            int RESULT=new DAL.SwartDataSetTableAdapters.QueriesTableAdapter().Delete_Collateral_Type(intCollateral_Type);


                if (RESULT > 0)
            
                bolDelResult = true;
            return bolDelResult;
        }
        public DataSet Sel_Collateral_Type(int intCollateralMajorType)
        {
            conn = new SqlConnection(clsERMSGeneral.connStr);
            sqlDa = new SqlDataAdapter("select * from Collateral_Type " , conn.ConnectionString);
            sqlCmdBld = new SqlCommandBuilder(sqlDa);
            ds.Clear();
            sqlDa.Fill(ds);
            return ds;
        }
        public bool checkDuplicated(int intCollateral_Type)
        {
            using (conn = new SqlConnection(clsERMSGeneral.connStr))
            {
                bool bolDupResult = false;
                conn.Open();
                sqlDa = new SqlDataAdapter("select * from Collateral_Type " , conn.ConnectionString);
                dtbl.Clear();
                sqlDa.Fill(dtbl);
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dtbl.Rows[i]["Collateral_Type"]) == intCollateral_Type)
                        bolDupResult = true;
                }

                return bolDupResult;
            }
        }
      
    }
}
