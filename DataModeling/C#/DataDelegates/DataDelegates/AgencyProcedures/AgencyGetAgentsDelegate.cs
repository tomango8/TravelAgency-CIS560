using DataAccess;
using PersonData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataModeling
{
    internal class AgencyGetAgentsDelegate : DataReaderDelegate<IReadOnlyList<Agent>>
    {
        public AgencyGetAgentsDelegate()
           : base("Agency.GetAgents")
        {
        }

        public override IReadOnlyList<Agent> Translate(SqlCommand command, IDataRowReader reader)
        {
            var Agents = new List<Agent>();

            while (reader.Read())
            {
                persons.Add(new Agent(
                   reader.GetInt32("AgentID"),
                   reader.GetString("Name")));
            }

            return Agents;
        }
    }
}