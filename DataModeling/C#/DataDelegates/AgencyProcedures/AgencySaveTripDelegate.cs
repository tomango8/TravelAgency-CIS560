using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace DataModeling
{
    public class AgencySaveTripDelegate : DataDelegate
    {
        private readonly int tripID;
        private readonly int customerID;
        private readonly int isDeleted;
        private readonly string dateCreated;
        private readonly int agentID;


        public AgencySaveTripDelegate(int tripID, int customerID, int isDeleted, string dateCreated, int agentID)
           : base("Agency.SaveTrip")
        {
            this.tripID = tripID;
            this.customerID = customerID;
            this.isDeleted = isDeleted;
            this.dateCreated = dateCreated;
            this.agentID = agentID;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("TripID", tripID);
            command.Parameters.AddWithValue("CustomerID", customerID);
            command.Parameters.AddWithValue("IsDeleted", isDeleted);
            command.Parameters.AddWithValue("DateCreated", dateCreated);
            command.Parameters.AddWithValue("AgentID", agentID);

        }
    }
}