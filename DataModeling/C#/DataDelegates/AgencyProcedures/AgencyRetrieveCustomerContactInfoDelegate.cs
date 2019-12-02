using DataAccess;
using DataModeling.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling.C_.DataDelegates.AgencyProcedures
{
    internal class AgencyRetrieveCustomerContactInfoDelegate : DataReaderDelegate<ContactInfo>
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

        public override ContactInfo Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(ReservationID.ToString());

            return new ContactInfo(reader.GetInt32("ContactID"),
               reader.GetString("BillingAddress"),
               reader.GetString("Phone"),
               reader.GetString("Email"),
               reader.GetInt32("CityID")
               );
        }
    }
}