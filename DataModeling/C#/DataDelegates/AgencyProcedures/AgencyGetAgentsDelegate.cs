using DataAccess;
using PersonData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataModeling
{
    internal class RetrievePersonsDataDelegate : DataReaderDelegate<IReadOnlyList<Agent>>
    {
        public RetrievePersonsDataDelegate()
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