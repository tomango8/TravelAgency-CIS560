using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.C_.Model
{
    public class CarRental
    {
        public int CarRentalID { get; }

        public string AgencyName { get; }

        public int CityID { get; }

        public CarRental(int carRentalID, string agencyName, int cityID)
        {
            CarRentalID = carRentalID;
            AgencyName = agencyName;
            CityID = cityID;
        }
        public override string ToString()
        {
            return $"CarRentalID: {CarRentalID}, AgencyName: {AgencyName}, CityID: {CityID}";

        }

    }
}
