using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace DataModeling
{
    internal class AgencySaveTripDelegate : DataDelegate
    {
        private readonly int tripID;
        private readonly int customerID;
        private readonly int isDeleted; //ut can create problem
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

            command.Parameters.AddWithValue("TripID", TripID);
            command.Parameters.AddWithValue("CustomerID", CustomerID);
            command.Parameters.AddWithValue("IsDeleted", IsDeleted);
            command.Parameters.AddWithValue("DateCreated", DateCreated);
            command.Parameters.AddWithValue("AgentID", AgentID);

        }
    }
}