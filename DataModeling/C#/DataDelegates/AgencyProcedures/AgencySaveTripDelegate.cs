using PersonData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace DataModeling
{
    internal class AgencySaveTripDelegate : DataDelegate
    {
        private readonly int TripID;
        private readonly int CustomerID;
        private readonly int IsDeleted; //ut can create problem
        private readonly string DateCreated;
        private readonly int AgentID;


        public AgencySaveTripDelegate(int TripID, int CustomerID, int IsDeleted, string DateCreated, int AgentID)
           : base("Agency.SaveTrip")
        {
            this.TripID = TripID;
            this.CustomerID = CustomerID;
            this.IsDeleted = IsDeleted;
            this.DateCreated = DateCreated;
            this.AgentID = AgentID;

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