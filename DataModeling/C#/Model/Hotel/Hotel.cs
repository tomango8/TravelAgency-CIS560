using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.C_.Model
{
    public class Hotel
    {
        public int HotelID { get; }

        public string CityID { get;  }
        public string Name { get;  }

        public string FullAddress { get;  }

        public Hotel(int hotelID, string cityID, string name, string fullAddress)
        {
            HotelID = hotelID;
            CityID = cityID;
            Name = name;
            FullAddress = fullAddress;
        }
        public override string ToString()
        {
            return $"HotelID: {HotelID}, CityID: {CityID}, Name: {Name}, FullAddress: {FullAddress}";

        }

    }
}
