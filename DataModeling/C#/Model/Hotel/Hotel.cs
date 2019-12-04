using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class Hotel
    {
        public int HotelID { get; }

        public int CityID { get;  }
        public string Name { get;  }

        public string FullAddress { get;  }

        public Hotel(int hotelID, int cityID, string name, string fullAddress)
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
