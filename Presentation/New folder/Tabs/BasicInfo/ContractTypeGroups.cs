using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Presentation.Tabs.BasicInfo
{
    class ContractTypeGroups
    {
        private const string Contract_Type_Groups = "Contract_Type_Groups";
        private string conString = ERMSLib.clsERMSGeneral.connStr;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private SqlConnection connection;

        public ContractTypeGroups()
        {
            connection = new SqlConnection(conString);
            connection.Open();
        }
        
        private string getSelectQuery(string contractTypeGroupID, string ContractTypeGroupDesc, string searchOperator,
            int startIndex, int endIndex)
        {
            Boolean hasWhere = false;
            StringBuilder query =
                new StringBuilder(@"SELECT Contract_Type_Group_id, Contract_Type_Group_Desc FROM")
                .Append(@" (SELECT row_number() OVER (ORDER BY Contract_Type_Group_id) ")
                .Append(@"as num, Contract_Type_Group_id, Contract_Type_Group_Desc from ")
                .Append(Contract_Type_Groups).Append(@") as tempSql");


            query.Append(@" where ");
            string op = searchOperator == string.Empty ? "=" : searchOperator;
            if (contractTypeGroupID != null)
            {
                query.Append(@" Contract_Type_Group_id ").Append(op).Append("' ").Append(contractTypeGroupID).Append("'");
                hasWhere = true;
            }

            if (hasWhere)
                query.Append(" and ");
            
            if (ContractTypeGroupDesc != null)
            {
                query.Append(@" Contract_Type_Group_Desc like N'%").Append(ContractTypeGroupDesc).Append(@"%'");
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


        public DataSet SearchContractTypeGroup(string Contract_Type_Group_id, string Contract_Type_Group_Desc, 
            string searchOperator, int startIndex, int endIndex)
        {
            string query = getSelectQuery(Contract_Type_Group_id, Contract_Type_Group_Desc, searchOperator,
                startIndex, endIndex);

            adapter = new SqlDataAdapter(query, connection);
            
            ds = new DataSet();
            adapter.Fill(ds, Contract_Type_Groups);

            SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapter);

            comBuilder.GetInsertCommand();
            comBuilder.GetDeleteCommand();
            comBuilder.GetUpdateCommand();

            return ds;
        
        }

        public DataSet SearchContractTypeGroup(string status, string statusDesc, string searchOperator)
        {
            return this.SearchContractTypeGroup(status, statusDesc, searchOperator, int.MinValue, int.MaxValue);
        }

        public void Update()
        {

            adapter.Update(ds, Contract_Type_Groups);
        
        }

        public int Count()
        {
            string query = @"SELECT COUNT(*) FROM " + Contract_Type_Groups;

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public bool Exist(string contractTypeGroupId)
        {
            string query = @"select count(*) from " + Contract_Type_Groups
                + " where contract_Type_group_id = " + contractTypeGroupId;
            SqlCommand com = new SqlCommand(query, connection);

            int count = (int)com.ExecuteScalar();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public int childRecordCount(int Contract_type_group_id)
        {
            string query = "select count(*) from loan_contract where Contract_Type_Group = " + Contract_type_group_id;
            int result;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                result = (int)command.ExecuteScalar();
            }

            return result;
        }

        public void updateChildRecords(int Contract_type_group_id)
        {
            string query = "update loan_contract set Contract_Type_Group = null where Contract_Type_Group = "
                + Contract_type_group_id;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
