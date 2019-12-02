using PersonData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace DataModeling
{
    internal class AgencySaveCustomerContactInfoDelegate : DataDelegate
    {
        private readonly int ContactID;
        private readonly string BillingAddress;
        private readonly int Phone;
        private readonly string Email;
        private readonly int CityID;
       

        public AgencySaveCustomerContactInfoDelegate(int ContactID, string BillingAddress, int Phone, string Email, int CityID)
           : base("Agency.SaveCustomerContactInfo")
        {
            this.ContactID = ContactID;
            this.BillingAddress = BillingAddress;
            this.Phone = Phone;
            this.Email = Email;
            this.CityID = CityID;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ContactID", ContactID);
            command.Parameters.AddWithValue("BillingAddress", BillingAddress);
            command.Parameters.AddWithValue("Phone", Phone);
            command.Parameters.AddWithValue("CityID", CityID);
           
        }
    }
}