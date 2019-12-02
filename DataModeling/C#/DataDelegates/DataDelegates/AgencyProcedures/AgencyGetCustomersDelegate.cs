using DataAccess;
using PersonData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataModeling
{
    internal class RetrievePersonsDataDelegate : DataReaderDelegate<IReadOnlyList<Customer>>
    {
        public RetrievePersonsDataDelegate()
           : base("Agency.GetCustomers")
        {
        }

        public override IReadOnlyList<Customer> Translate(SqlCommand command, IDataRowReader reader)
        {
            var Customers = new List<Customer>();

            while (reader.Read())
            {
                persons.Add(new Customer(
                   reader.GetString("Name"),
                   reader.GetInt32("CustomerID")));
            }

            return Customers;
        }
    }
}