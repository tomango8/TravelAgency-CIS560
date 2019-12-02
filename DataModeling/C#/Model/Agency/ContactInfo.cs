using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.C_.Model
{
    public class ContactInfo
    {
        public int ContactID { get; }

        public string BillingAddress { get; }

        public string Phone { get; }

        public string Email { get; }

        public int CityID { get; }

        public ContactInfo(int contactID, string billingAddress, string phone, string email, int cityID)
        {
            ContactID = contactID;
            BillingAddress = billingAddress;
            Phone = phone;
            Email = email;
            CityID = cityID;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Contact ID: " + ContactID);
            result.Append(", ");
            result.Append("BillingAddress: " + BillingAddress);
            result.Append(", ");
            result.Append("Phone: " + Phone);
            result.Append(", ");
            result.Append("Email: " + Email);
            result.Append(", ");
            result.Append("CityID: " + CityID);

            return result.ToString();

        }


    }

}
