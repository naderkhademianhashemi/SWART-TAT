using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Presentation.Tabs.BasicInfo
{
    class CustomerGroup
    {

		#region Fields (5) 

        private SqlDataAdapter adapter;
        private readonly SqlConnection connection;
        private readonly string conString = ERMSLib.clsERMSGeneral.connStr;
        private const string Customer_Group = "Customer_Group";
        private DataSet ds;

		#endregion Fields 

		#region Constructors (1) 

        public CustomerGroup()
        {
            connection = new SqlConnection(conString);
            connection.Open();
        }

		#endregion Constructors 

		#region Methods (6) 


		// Public Methods (4) 

        public int Count()
        {
            string query = @"SELECT COUNT(*) FROM " + Customer_Group;

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public DataSet SearchCustomerGroup(string customerGroup, string customerGroupDescription, string searchOperation,
            int startIndex, int endIndex)
        {
            string query = this.getSelectQuery(customerGroup, customerGroupDescription, searchOperation,
                startIndex, endIndex);

            adapter = new SqlDataAdapter(query, connection);

            ds = new DataSet();
            adapter.Fill(ds, Customer_Group);

            SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapter);

            comBuilder.GetInsertCommand();
            comBuilder.GetDeleteCommand();
            comBuilder.GetUpdateCommand();

            return ds;

        }

        public DataSet SearchCustomerGroup(string customerGroup, string customerGroupDescription, string searchOperator)
        {
            return this.SearchCustomerGroup(customerGroup, customerGroupDescription, searchOperator,
                int.MinValue, int.MaxValue);
        }

        public void Update()
        {

            adapter.Update(ds, Customer_Group);

        }


		// Private Methods (2) 

        private string getSelectQuery(string customerGroup, string customerGroupDescription, string searchOperator,
            int startIndex, int endIndex)
        {
            Boolean hasWhere = false;
            StringBuilder query =
                new StringBuilder(@"SELECT Customer_Group, Customer_Group_Description FROM")
                .Append(@" (SELECT row_number() OVER (ORDER BY Customer_Group) ")
                .Append(@"as num, Customer_Group, Customer_Group_Description from ")
                .Append(Customer_Group).Append(@") as tempSql");


            query.Append(@" where ");
            string op = searchOperator == string.Empty ? "=" : searchOperator;
            if (customerGroup != null)
            {
                query.Append(@" Customer_Group ").Append(op).Append(" '").Append(customerGroup).Append("'");
                hasWhere = true;
            }

            if (hasWhere)
                query.Append(" and ");

            if (customerGroupDescription != null)
            {
                query.Append(@" Customer_Group_Description like N'%").Append(customerGroupDescription).Append(@"%'");
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


		#endregion Methods 

        public bool Exist(string cutomerGroup)
        {
            string query = @"select count(*) from " + Customer_Group
                + " where customer_group = " + cutomerGroup;
            SqlCommand com = new SqlCommand(query, connection);

            int count = (int)com.ExecuteScalar();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public int childRecordCount(int Customer_Group_id)
        {
            string query = "select count(*) from counterparty where Customer_Group = " + Customer_Group_id;
            int result;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                result = (int)command.ExecuteScalar();
            }

            return result;
        }

        public void updateChildRecords(int Customer_Group_id)
        {
            string query = "update loan_contract set Customer_Group = null where Customer_Group = "
                + Customer_Group_id;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    
    }

}
