using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class Agent
    {

        public int AgentID { get; }

        public string Name { get; }

        public double Salary { get; }

        public bool IsDeleted { get; }

        public Agent(int aID, string name, double salary, bool isDeleted)
        {
            AgentID = aID;
            Name = name;
            Salary = salary;
            IsDeleted = isDeleted;
        }

        public Agent(int aID, string name, double salary)
        {
            AgentID = aID;
            Name = name;
            Salary = salary;
            IsDeleted = false;
        }

        public string AgentSimpleInfo
        {
            get
            {
                return AgentID + ", " + Name;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("AgentID: " + AgentID);
            result.Append(", ");
            result.Append("Name: " + Name);
            result.Append(", ");
            result.Append("Salary: " + Salary);
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
