using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    public class LocationFetchCityDelegate : NonQueryDataDelegate<Cities>
    {
        public readonly int cityID;
        public readonly string cityname;
        public readonly string region;
        public readonly string country;

        public LocationFetchCityDelegate(int CityID)
            : base("Location.FetchCity")
        {
            this.cityID = CityID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("CityID", cityID);
            command.Parameters.AddWithValue("CityName", cityname);
            command.Parameters.AddWithValue("Region", region);
            command.Parameters.AddWithValue("Country", country);


            var p = command.Parameters.Add("CityID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Cities Translate(SqlCommand command)
        {
            return new Cities((int)command.Parameters["Cities"].Value, cityname, region, country);
        }

    }
}