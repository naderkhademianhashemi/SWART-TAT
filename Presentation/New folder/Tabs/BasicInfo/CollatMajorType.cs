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

namespace Presentation.Tabs.BasicInfo
{
    class CollatMajorType
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

        public string Collat_Major_TypeCount()
        {
            SqlConnection conn = new SqlConnection(clsERMSGeneral.connStr);
            DataSet ds = new DataSet();
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select Count(*) from Collat_Major_Type", conn);
            da.Fill(ds, "Collat_Major_Type");
            conn.Close();
            return ds.Tables["Collat_Major_Type"].Rows[0][0].ToString();
        }

        public DataTable GetCollat_Major_Type(int startIndex, int endIndex)
        {

            DataTable ds = new DAL.SwartDataSetTableAdapters.GetDT_Collat_Major_TypeTableAdapter().GetData(startIndex, endIndex);
            
            return ds;
        }
        public DataTable Collat_Major_TypeSearch(string searchIndex, string strField, string strOperator)
        {
            string str;
            switch (strField)
            {
                //case "Collat_Major_Type": str = searchIndex.Trim();
                //    break;

                case "Collat_Major_Type_Desc":
                    str = searchIndex.Trim();
                    break;
                case "Collat_Major_Type":
                    str = strField + "  " + strOperator + " " + searchIndex;
                break;

                default: str = strField + "  like '%" + searchIndex + "%' ";
                    break;
            }

            DataTable ds = new DAL.SwartDataSetTableAdapters.GetDT_Collat_Major_TypeSearchTableAdapter().GetData(str, strField.Trim());
            
            

            return ds;
        }
        public bool InsertCollat_Major_Type(int intCollat_Major_Type, string strCollat_Major_Type_Desc)
        {
            try
            {
                conn = new SqlConnection(clsERMSGeneral.connStr);
                conn.Open();
                
                int RESULT=new DAL.SwartDataSetTableAdapters.QueriesTableAdapter().Insert_Collat_Major_Type(intCollat_Major_Type,strCollat_Major_Type_Desc);


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

        public bool DeleteCollat_Major_Type(int intCollat_Major_Type)
        {
            bolDelResult = false;
            int RESULT = new DAL.SwartDataSetTableAdapters.QueriesTableAdapter().Delete_Collat_Major_Type(intCollat_Major_Type);

            if (RESULT > 0)
                bolDelResult = true;
            return bolDelResult;
        }
        public DataSet Sel_Collat_Major_Type()
        {
            conn = new SqlConnection(clsERMSGeneral.connStr);
            sqlDa = new SqlDataAdapter("select * from Collat_Major_Type ", conn.ConnectionString);
            sqlCmdBld = new SqlCommandBuilder(sqlDa);
            ds.Clear();
            sqlDa.Fill(ds);
            return ds;
        }
        public bool checkDuplicated(int intCollat_Major_Type)
        {
            using (conn = new SqlConnection(clsERMSGeneral.connStr))
            {
                bool bolDupResult = false;
                conn.Open();
                sqlDa = new SqlDataAdapter("select * from Collat_Major_Type", conn.ConnectionString);
                dtbl.Clear();
                sqlDa.Fill(dtbl);
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dtbl.Rows[i]["Collat_Major_Type"]) == intCollat_Major_Type)
                        bolDupResult = true;
                }

                return bolDupResult;
            }
        }
    }
}
