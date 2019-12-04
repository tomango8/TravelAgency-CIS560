using DataAccess;
using DataModeling.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    
    public class AgencyCreateAgentDelegate : NonQueryDataDelegate<Agent>
    {
        public readonly string name;
        public readonly float salary;
        private readonly bool isDeleted;

        public AgencyCreateAgentDelegate(string name, float salary, bool isDeleted)
            : base("Agency.CreateAgent")
        {
            this.name = name;
            this.salary = salary;
            this.isDeleted = isDeleted;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Salary", salary);
            command.Parameters.AddWithValue("IsDeleted", isDeleted);

            var p = command.Parameters.Add("AgentID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Agent Translate(SqlCommand command)
        {
            return new Agent((int)command.Parameters["AgentID"].Value, name, salary, isDeleted);
        }
    }

    
}
