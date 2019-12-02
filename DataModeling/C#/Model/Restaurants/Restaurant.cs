using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.C_.Model
{
    public class Restaurant
    {
        public int RestaurantID { get;  }
        public string Name { get; }

        public int CityID { get; }

        public Restaurant(int restaurantID, string name, int cityID)
        {
            RestaurantID = restaurantID;
            Name = name;
            CityID = cityID;
        }
        public override string ToString()
        {
            return $"RestaurantID: {RestaurantID}, Name: {Name}, CityID: {CityID}";

        }
    }
}
