using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    internal class AgencyGetCustomerDelegate : DataReaderDelegate<Customer>
    {
        private readonly int customerID;

        public AgencyGetCustomerDelegate(int customerID)
           : base("Restaurants.GetRestaurant")
        {
            this.customerID = customerID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("CustomerID", reservationID);
        }

        public override Customer Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(ReservationID.ToString());

            return new Customer(customerID,
               reader.GetString("Name"),
               reader.GetString("Budget"),
               reader.GetString("Age"),
               reader.GetString("Sex"),
               reader.GetString("ContactID")
               );
        }
    }
}