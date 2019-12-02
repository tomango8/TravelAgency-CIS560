using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class Trips
    {
        public int TripID { get; }

        public int CustomerID { get; }

        public bool IsDeleted { get; }

        public DateTime DateCreated { get; }

        public int AgentID { get; }

        public Trips(int tripID, int customerID, bool isDeleted, DateTime dateCreated, int agentID)
        {
            TripID = tripID;
            CustomerID = customerID;
            IsDeleted = isDeleted;
            DateCreated = dateCreated;
            AgentID = agentID;
     
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            result.Append("DateCreated: " + DateCreated.Date);
            result.Append(", ");
            result.Append("TripID: " + TripID);
            result.Append(", ");
            result.Append("AgentID: " + AgentID);
            result.Append(", ");
            result.Append("CustomerID: " + CustomerID);
            result.Append(", ");
            

            if (IsDeleted)
            {
                result.Append("Deleted");
            }
            else
            {
                result.Append("Not Deleted");
            }
            return result.ToString();

        }
    }
}
