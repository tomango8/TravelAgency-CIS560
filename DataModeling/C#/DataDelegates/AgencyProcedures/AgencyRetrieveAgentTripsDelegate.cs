///this delecate is broken
//not sure what should be the return type here 
using DataAccess;
using DataModeling.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    internal class AgencyRetrieveAgentTripsDelegate : DataReaderDelegate<List<Tuple<int, int>>>
    {
        private readonly int AgentID;

        public AgencyRetrieveAgentTripsDelegate(int AgentID)
           : base("Agency.RetrieveAgentTrips")
        {
            this.AgentID = AgentID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AgentID", AgentID);
        }

        public override List<Tuple<int, int>> Translate(SqlCommand command, IDataRowReader reader)
        {
             List<Tuple< int, int>> trips = new List<Tuple<int, int>>;

            if (!reader.Read())
                throw new RecordNotFoundException(AgentID.ToString());
            
            return new Tuple(AgentID,
               reader.GetInt32("TripID") );
        }
    }
}