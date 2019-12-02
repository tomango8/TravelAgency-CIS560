using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.C_.Model
{
    public class Cities
    {
        public int CityID { get; }

        public string CityName { get; }

        public string Region { get; }

        public string Country { get; }

        public Cities(int cityID, string cityName, string region, string country)
        {
            CityID = cityID;
            CityName = cityName;
            Region = region;
            Country = country;
        }
        public override string ToString()
        {
            return $"CityID: {CityID}, CityName: {CityName}, Region: {Region}, Country: {Country}";

        }
    }
}
