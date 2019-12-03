using DataAccess;
using DataModeling.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling.C_.DataDelegates.AgencyProcedures
{
    internal class AgencyRetrieveAgentTripsDelegate : DataReaderDelegate<Customer>
    {
        private readonly int customerID;

        public AgencyRetrieveAgentTripsDelegate(int customerID)
           : base("Agency.GetCustomer")
        {
            this.customerID = customerID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("CustomerID", customerID);
        }

        public override Customer Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(customerID.ToString());

            return new Customer(customerID,
                reader.GetString("Name"),
               reader.GetInt32("Budget"),
               reader.GetInt32("Age"),
               reader.GetString("Sex"),
               reader.GetInt32("ContactID"),
               reader.GetValue<bool>("IsDeleted")
               ); ;
        }
    }
}