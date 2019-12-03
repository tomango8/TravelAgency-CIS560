using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataModeling.Model;

namespace DataModeling.Connection
{
    public class TripConnection
    {
        private readonly SqlCommandExecutor executor;

        public TripConnection(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Trip CreateTrip(int tripID, int customerID, int isDeleted, string dateCreated, int agentID)
        {
            var d = new AgencySaveTripDelegate(tripID, customerID, isDeleted, dateCreated, agentID);
            return executor.ExecuteNonQuery(d);
        }

        
    }
}
