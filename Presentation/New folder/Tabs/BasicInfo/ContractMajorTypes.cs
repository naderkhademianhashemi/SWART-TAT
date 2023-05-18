using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ERMSLib;

namespace Presentation.Tabs.BasicInfo
{
    class ContractMajorTypes
    {

        private const string Contract_Major_Type = "Contract_Major_Type";
        private readonly string conString = clsERMSGeneral.connStr;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private readonly SqlConnection connection;

        public ContractMajorTypes()
        {
            connection = new SqlConnection(conString);
            connection.Open();
        }

        private string getSelectQuery(string contractMTypeId, string contractMTypeDesc,
            string searchOperator, int startIndex, int endIndex)
        {
            Boolean hasWhere = false;
            StringBuilder query =
                new StringBuilder(@"SELECT Contract_MType_id, Contract_MType_Desc FROM")
                .Append(@" (SELECT row_number() OVER (ORDER BY Contract_MType_id) ")
                .Append(@"as num, Contract_MType_id, Contract_MType_Desc from ")
                .Append(Contract_Major_Type).Append(@") as tempSql");


            string op = searchOperator == string.Empty ? "=" : searchOperator;

            query.Append(@" where ");

            if (contractMTypeId != null)
            {
                query.Append(@" Contract_MType_id ").Append(op).Append(" '").Append(contractMTypeId).Append("'");
                hasWhere = true;
            }

            if (hasWhere)
                query.Append(" and ");

            if (contractMTypeDesc != null)
            {
                query.Append(@" Contract_MType_Desc like N'%").Append(contractMTypeDesc).Append(@"%'");
                hasWhere = true;
            }


            if (hasWhere)
                query.Append(" and ");

            if (startIndex >= 0 && endIndex >= 0)
            {
                query.Append(@" num between ").Append(startIndex).Append(@" and ").Append(endIndex);
            }

            return refineQuery(query.ToString());
        }


        private string refineQuery(string inputQuery)
        {
            string returnValue = inputQuery;

            while (returnValue.EndsWith(" and "))
            {
                returnValue = returnValue.Remove(returnValue.LastIndexOf(" and "));
            }

            if (returnValue.EndsWith(" where "))
                returnValue = returnValue.Remove(returnValue.LastIndexOf(" where "));

            return returnValue;
        }


        public DataSet SearchContractMajorType(string ContractMTypeId, string ContractMTypeDesc, string searchOperator,
            int startIndex, int endIndex)
        {
            string query = getSelectQuery(ContractMTypeId, ContractMTypeDesc, searchOperator,
                startIndex, endIndex);

            adapter = new SqlDataAdapter(query, connection);

            ds = new DataSet();
            adapter.Fill(ds, Contract_Major_Type);

            SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapter);

            comBuilder.GetInsertCommand();
            comBuilder.GetDeleteCommand();
            comBuilder.GetUpdateCommand();

            return ds;

        }

        public DataSet SearchContractMajorType(string status, string statusDesc, string searchOperator)
        {
            return SearchContractMajorType(status, statusDesc, searchOperator, int.MinValue, int.MaxValue);
        }

        public void Update()
        {

            adapter.Update(ds, Contract_Major_Type);

        }


        public int Count()
        {
            string query = @"SELECT COUNT(*) FROM " + Contract_Major_Type;

            SqlCommand command = new SqlCommand(query, connection);
            return (int)command.ExecuteScalar();

        }

        public bool Exist(string contractMTypeId)
        {
            string query = @"select count(*) from " + Contract_Major_Type
                + " where contract_MType_Id = " + contractMTypeId;
            SqlCommand com = new SqlCommand(query, connection);

            int count = (int)com.ExecuteScalar();
            if (count > 0)
            {
                return true;
            }
            return false;
        }


        public int childRecordCount(int contractMTypeID)
        {
            string query = "select count(*) from loan_contract where Contract_MType = " + contractMTypeID;
            int result;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                result = (int)command.ExecuteScalar();
            }

            return result;
        }

        public void updateChildRecords(int contractMTypeID)
        {
            string query = "update loan_contract set Contract_MType = null where Contract_MType = " + contractMTypeID;
            
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
