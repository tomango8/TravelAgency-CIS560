using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;



namespace DataModeling.C_.DataDelegates.LocationDelegates
{
    public class LocationGetCityByCityIdDelegate: DataReaderDelegate<Cities>
    {

    private readonly int cityID;
    private readonly string country;
    private readonly string region;
    private readonly string cityName;

    public LocationGetCityByCityIdDelegate(string cityName, string country, string region)
           : base("Location.GetCities")      
    {
            this.cityName = cityName;
            this.country = country;
            this.region = region;
    }

    public override void PrepareCommand(SqlCommand command)
    {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("CityID", cityID);

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
