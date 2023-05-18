using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ActiveDatabaseSoftware.ActiveQueryBuilder;
using ERMSLib;
using System.Data;
using System.Data.SqlClient;
using ERMS.Logic;
using ERMS.Model;
using ERMS.Data;

namespace Presentation.Tabs.LimitManagement
{
    
    public partial class QueryBuilder : UserControl
    {

        #region VAR
        private LM lm;
        private DataTable dt;
        public static string[] tbNames = {
                                         "Accounting_Groups",
                                         "Accounts_GL",
                                         "AG",
                                         "AGL_199",
                                         "Approvement_Reference",
                                         "Branch_Limit",
                                         "Branch_Rank",
                                         "Branch_Surplus",
                                         "CD_Cash_Flow",
                                         "Certificate_Of_Deposit",
                                         "Contract_Type",
                                         "Contract_Status",
                                         "Contract_Type",
                                         "Counterparty",
                                         "Counterparty_Type",
                                         "Currency",
                                         "Currency_Pair",
                                         "Customer_Group",
                                         "Deposit_Cash_Flow",
                                         "Deposit_Contract",
                                         "Economic_Sector",
                                         "GC",
                                         "Geo_State",
                                         "Loan_Cash_Flow",
                                         "Loan_Contract",
                                         "Non_Accounts",
                                         "Organization",
                                         "State",
                                         "State_IncomeGroup"
                                     };
        public static string[] PkNames ={"Group_Name",
                                        "Accounting_Code",
                                        "ID",
                                        "Accounting_Code",
                                        "ID",
                                        "App_ref",
                                        "ID",
                                        "ID",
                                        "CD",
                                        "Contract_Type",
                                        "Counterparty",
                                        "Counterparty_Type",
                                        "Currency",
                                        "ID",
                                        "Customer_Group",
                                        "ID",
                                        "Contract",
                                        "Economic_Sector",
                                        "GC_Id",
                                        "Geo_State_Id",
                                        "ID",
                                        "Contract",
                                        "Non_Accounts_Code",
                                        "Branch",
                                        "State_Id",
                                        "Income_Group_Id"
                     };
       
        #endregion

        public QueryBuilder()
        {
            InitializeComponent();
            lm = new LM();
            mssqlMetadataProvider1.Connection = new SqlConnection(clsERMSGeneral.connStr);
            qblAmount.RefreshMetadata();

            for (int i = 0; i < PkNames.GetLength(0); i++)
                ((MetadataTree)(qblAmount.Controls[4].Controls[0].Controls[0])).Nodes[0].Nodes[i].ToolTipText = "Primary key:\r\n   " + PkNames[i] + "\r\n \r\nParameter[s]:\r\n" + tbNames[i];

          
        }
        private void eventMetadataProvider1_GetTables(ActiveDatabaseSoftware.ActiveQueryBuilder.BaseMetadataProvider ASnder, ActiveDatabaseSoftware.ActiveQueryBuilder.SQLQualifiedNameList ADatabaseObjects)
        {
            for (int i = 0; i < tbNames.GetLength(0); i++)
                ADatabaseObjects.Add(tbNames[i]);
            SQLQualifiedName sqn = new SQLQualifiedName(qblAmount.SyntaxProvider);
        }
        private void plainTextSQLBuilder1_SQLUpdated(object sender, EventArgs e)
        {
            txtSQL.Text = plainTextSQLBuilder1.SQL;
        }
        private void qblAmount_Load(object sender, EventArgs e)
        {
            mssqlMetadataProvider1.Connection = new SqlConnection(clsERMSGeneral.connStr);
            qblAmount.RefreshMetadata();
        }
        private void eventMetadataProvider1_GetRelations(BaseMetadataProvider ASender, MetadataObject AObject)
        {
            dt = lm.GetRelations(AObject.FullNameStr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SQLQualifiedName sName = new SQLQualifiedName(qblAmount.SyntaxProvider);
                sName.AddIdentifier(dt.Rows[i]["Column_NAME"].ToString(), false, 0);

                MetadataRelation f = AObject.Relations.Add();

                f.KeyFields.AddField(dt.Rows[i]["Column_NAME"].ToString());
                f.ChildTable.Parse(dt.Rows[i]["REF_TABLE_NAME"].ToString());
                f.ChildFields.AddField(dt.Rows[i]["REF_COLUMN_NAME"].ToString());
            }            
        }
        private void eventMetadataProvider1_GetFields(BaseMetadataProvider ASender, MetadataObject AObject)
        {
            
            dt = lm.GetFields(AObject.FullNameStr);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SQLQualifiedName sName = new SQLQualifiedName(qblAmount.SyntaxProvider); 
                sName.AddIdentifier(dt.Rows[i]["Column_NAME"].ToString(), false, 0);

                MetadataField f = AObject.Fields.AddField(sName, System.Data.DbType.String, 1, true, true, "gsdfgsdf" + i.ToString(), "long sdfgdsfgsdg " + i.ToString(), "aaltName" + i.ToString());

            }

        }
    }
}
