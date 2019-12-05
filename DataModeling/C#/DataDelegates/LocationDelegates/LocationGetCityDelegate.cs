using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    public class LocationGetCityDelegate : DataReaderDelegate<Cities>
    {
        private readonly int cityID;
        public readonly string country;
        public readonly string region;
        public readonly string cityname;

        public LocationGetCityDelegate(int cityID)
           : base("Location.GetCities")
        {
            this.cityID = cityID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("Country", country);
            command.Parameters.AddWithValue("Region", region);
            command.Parameters.AddWithValue("CityName", cityname);
        }

        public override Cities Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Cities(cityID,
               reader.GetString("Country"),
               reader.GetString("Region"),
               reader.GetString("CityName"));
        }
    }
}