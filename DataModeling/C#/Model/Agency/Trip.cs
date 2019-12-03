using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class Trip
    {
        public int TripID { get; }

        public int CustomerID { get; }

        public bool IsDeleted { get; }

        public DateTimeOffset DateCreated { get; }

        public int AgentID { get; }

        public Trip(int tripID, int customerID, bool isDeleted, DateTimeOffset dateCreated, int agentID)
        {
            TripID = tripID;
            CustomerID = customerID;
            IsDeleted = isDeleted;
            DateCreated = dateCreated;
            AgentID = agentID;
     
        }

        public Trip(int tripID, int customerID, DateTimeOffset dateCreated, int agentID)
        {
            TripID = tripID;
            CustomerID = customerID;
            DateCreated = dateCreated;
            AgentID = agentID;
            IsDeleted = false;
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
