
//not sure what should be the return type here 
using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    internal class AgencyGetCustomerDelegate : DataReaderDelegate<AgentTrip>
    {
        private readonly int AgentID;

        public AgencyGetCustomerDelegate(int AgentID)
           : base("Agency.RetrieveAgentTrips")
        {
            this.AgentID = AgentID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AgentID", AgentID);
        }

        public override AgentTrip Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(ReservationID.ToString());

            return new AgentTrip(AgentID,
               reader.GetString("TripID")
               );
        }
    }
}