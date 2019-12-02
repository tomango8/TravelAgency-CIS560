using PersonData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    public class CreatePersonDataDelegate : NonQueryDataDelegate<Attraction>
    {
        public readonly string name;
        public readonly string cityID;
        private readonly string attractionID;

        public CreatePersonDataDelegate(string name, string cityID)
           : base("Attractions.CreateAttraction")
        {
            this.name = name;
            this.cityID = cityID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("FirstName", name);
            command.Parameters.AddWithValue("CityID", cityID);

            var p = command.Parameters.Add("AttractionID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Attraction Translate(SqlCommand command)
        {
            return new Attraction((int)command.Parameters["AttractionID"].Value, name, cityID);
        }
    }
}