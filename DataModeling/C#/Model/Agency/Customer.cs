using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class Customer
    {
        public int CustomerID { get; }

        public float Budget { get;  }

        public string Name { get;  }

        public int Age { get;  }

        public string Sex { get;  }

        public int ContactID { get;  }

        public bool IsDeleted { get; }

        public Customer(int customerID,  string name, int budget, int age, string sex, int contactID, bool isDeleted)
        {
            CustomerID = customerID;
            Name = name;
            Budget = budget;          
            Age = age;
            Sex = sex;
            ContactID = contactID;
            IsDeleted = isDeleted;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("CustomerID: " + CustomerID);
            result.Append(", ");
            result.Append("Budget: " + Budget);
            result.Append(", ");
            result.Append("Name: " + Name);
            result.Append(", ");
            result.Append("Age: " + Age);
            result.Append(", ");
            result.Append("Sex: " + Sex);
            result.Append(", ");
            result.Append("ContactID: " + ContactID);
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
