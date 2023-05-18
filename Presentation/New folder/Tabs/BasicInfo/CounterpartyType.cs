using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Presentation.Tabs.BasicInfo
{
    class CounterpartyType
    {

        #region Fields (5)

        private SqlDataAdapter adapter;
        private SqlConnection connection;
        private string conString = ERMSLib.clsERMSGeneral.connStr;
        private const string Counterparty_Type = "Counterparty_Type";
        private DataSet ds;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the <see cref="CounterpartyType"/> class.
        /// </summary>
        public CounterpartyType()
        {
            connection = new SqlConnection(conString);
            connection.Open();
        }

        #endregion Constructors

        #region Methods (6)


        // Public Methods (4) 

        /// <summary>
        /// Counts this instance.
        /// </summary>
        /// <returns>Number of records in the table</returns>
        public int Count()
        {
            string query = @"SELECT COUNT(*) FROM " + Counterparty_Type;

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                return (int)command.ExecuteScalar();
            }
        }

        /// <summary>
        /// Searches the type of the counterparty.
        /// </summary>
        /// <param name="Counterparty_Type">Type of the counterparty_.</param>
        /// <param name="Counterparty_Type_Desc">The counterparty_ type_ desc.</param>
        /// <param name="startIndex">The start index.</param>
        /// <param name="endIndex">The end index.</param>
        /// <returns></returns>
        public DataSet SearchCounterpartyType(string counterpartyType, string counterpartyTypeDesc, string searchOperator,
            int startIndex, int endIndex)
        {
            string query = this.getSelectQuery(counterpartyType, counterpartyTypeDesc, searchOperator ,startIndex, endIndex);

            adapter = new SqlDataAdapter(query, connection);

            ds = new DataSet();
            adapter.Fill(ds, Counterparty_Type);

            SqlCommandBuilder comBuilder = new SqlCommandBuilder(adapter);

            comBuilder.GetInsertCommand();
            comBuilder.GetDeleteCommand();
            comBuilder.GetUpdateCommand();

            return ds;

        }

        /// <summary>
        /// Searches the type of the counterparty.
        /// </summary>
        /// <param name="Counterparty_Type">Type of the counterparty_.</param>
        /// <param name="Counterparty_Type_Desc">The counterparty_ type_ desc.</param>
        /// <returns></returns>
        public DataSet SearchCounterpartyType(string counterpartyType, string counterpartyTypeDesc, string searchOperator)
        {
            return this.SearchCounterpartyType(counterpartyType, counterpartyTypeDesc, searchOperator, int.MinValue, int.MaxValue);
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update()
        {

            adapter.Update(ds, Counterparty_Type);

        }



        // Private Methods (2) 


        /// <summary>
        /// Gets the select query.
        /// </summary>
        /// <param name="Counterparty_Type">Type of the counterparty_.</param>
        /// <param name="Counterparty_Type_Desc">The counterparty_ type_ desc.</param>
        /// <param name="startIndex">The start index.</param>
        /// <param name="endIndex">The end index.</param>
        /// <returns></returns>
        private string getSelectQuery(string counterpartyType, string counterpartyTypeDesc, string searchOperator,
            int startIndex, int endIndex)
        {
            Boolean hasWhere = false;
            StringBuilder query =
                new StringBuilder(@"SELECT Counterparty_Type, Counterparty_Type_Desc FROM")
                .Append(@" (SELECT row_number() OVER (ORDER BY Counterparty_Type) ")
                .Append(@"as num, Counterparty_Type, Counterparty_Type_Desc from ")
                .Append(Counterparty_Type).Append(@") as tempSql");


            query.Append(@" where ");
            string op = searchOperator == string.Empty ? "=" : searchOperator;
            if (counterpartyType != null)
            {
                query.Append(@" Counterparty_Type ").Append(op).Append(" '").Append(counterpartyType).Append("'");
                hasWhere = true;
            }

            if (hasWhere)
                query.Append(" and ");

            if (counterpartyTypeDesc != null)
            {
                query.Append(@" Counterparty_Type_Desc like N'%").Append(counterpartyTypeDesc).Append(@"%'");
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

        /// <summary>
        /// Refines the query.
        /// </summary>
        /// <param name="inputQuery">The input query.</param>
        /// <returns></returns>
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


        public bool Exist(string counterpartType)
        {
            string query = @"select count(*) from " + Counterparty_Type
                + " where counterparty_type = " + counterpartType;
            SqlCommand com = new SqlCommand(query, connection);

            int count = (int)com.ExecuteScalar();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public int childRecordCount(int Counterparty_Type_id)
        {
            string query = "select count(*) from counterparty where Counterparty_Type = " + Counterparty_Type_id;
            int result;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                result = (int)command.ExecuteScalar();
            }

            return result;
        }

        public void updateChildRecords(int Counterparty_Type_id)
        {
            string query = "update counterparty set Counterparty_Type = null where Counterparty_Type = "
                + Counterparty_Type_id;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
