using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Presentation.Tabs.BasicInfo
{
    class ContractStatus
    {
        private const string Contract_Status = "Contract_Status";
        private string conString = ERMSLib.clsERMSGeneral.connStr;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private SqlConnection connection;

        public ContractStatus()
        {
            connection = new SqlConnection(conString);
            connection.Open();
        }

        private string getSelectQuery(string status, string statusDesc, 
            int startIndex, int endIndex)
        {
            Boolean hasWhere = false;
            StringBuilder query =
                new StringBuilder(@"SELECT status, status_desc FROM")
                .Append(@" (SELECT row_number() OVER (ORDER BY status) ")
                .Append(@"as num, status, status_desc from ")
                .Append(Contract_Status).Append(@") as tempSql");


            query.Append(@" where ");

            if (status != null)
            {
                query.Append(@" status like N'%").Append(status).Append("%'");
                hasWhere = true;
            }

            if (hasWhere)
                query.Append(" and ");

            if (statusDesc != null)
            {
                query.Append(@" status_desc like N'%").Append(statusDesc).Append(@"%'");
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


        public DataSet SearchContractStatus(string status, string statusDesc, int startIndex, int endIndex)
        {
            string query = getSelectQuery(status, statusDesc, startIndex, endIndex);

            adapter = new SqlDataAdapter(query, connection);

            ds = new DataSet();
            adapter.Fill(ds, Contract_Status);

            SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapter);

            comBuilder.GetInsertCommand();
            comBuilder.GetDeleteCommand();
            comBuilder.GetUpdateCommand();

            return ds;

        }

        public DataSet SearchContractStatus(string status, string statusDesc)
        {
            return SearchContractStatus(status, statusDesc,  int.MinValue, int.MaxValue);
        }

        public void Update()
        {

            adapter.Update(ds, Contract_Status);

        }


        public int Count()
        {
            string query = @"SELECT COUNT(*) FROM " + Contract_Status;

            SqlCommand command = new SqlCommand(query, connection);
            return (int)command.ExecuteScalar();

        }


        internal bool Exist(string status)
        {
            string query = @"select count(*) from " + Contract_Status
                + " where status = '" + status + "'";
            SqlCommand com = new SqlCommand(query, connection);

            int count = (int)com.ExecuteScalar();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public int childRecordCount(string status)
        {
            string query = "select count(*) from loan_contract where status = '" + status.Trim() + "'";
            int result;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                result = (int)command.ExecuteScalar();
            }

            return result;
        }

        public void updateChildRecords(string status)
        {
            string query = "update loan_contract set status = null where status = '" + status.Trim() + "'";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    
    }
}
