using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    internal class AgencyRetrieveCustomerContactInfoDelegate : DataReaderDelegate<CustomerContact>
    {
        private readonly int ContactID;

        public AgencyRetrieveCustomerContactInfoDelegate(int ContactID)
           : base("Agency.RetrieveCustomerContactInfo")
        {
            this.ContactID = ContactID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ContactID", ContactID);
        }

        public override CustomerContact Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(ReservationID.ToString());

            return new CustomerContact(reader.GetString("ContactID"),
               reader.GetString("BillingAddress"),
               reader.GetString("Phone"),
               reader.GetString("Email"),
               reader.GetString("CityID")
               );
        }
    }
}