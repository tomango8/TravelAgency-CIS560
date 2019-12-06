using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    public class CreateFlightDelegate : NonQueryDataDelegate<Flight>
    {
        public readonly int flightID;
        public readonly string airlinename;
        public readonly System.DateTime departuretime;
        public readonly System.DateTime arrivaltime;
        public readonly int citydepartureID;
        public readonly int cityarrivalID;
        public readonly System.DateTime date;

        public CreateFlightDelegate(int FlightID)
            : base("Airlines.CreateFlight")
        {
            this.flightID = FlightID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("FlightID", flightID);
            command.Parameters.AddWithValue("AirlineName", airlinename);
            command.Parameters.AddWithValue("DepartureTime", departuretime);
            command.Parameters.AddWithValue("ArrivalTime", arrivaltime);
            command.Parameters.AddWithValue("CityDepartureID", citydepartureID);
            command.Parameters.AddWithValue("CityArrivalID", cityarrivalID);            

            var p = command.Parameters.Add("FlightID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Flight Translate(SqlCommand command)
        {
            return new Flight((int)command.Parameters["FlightID"].Value, airlinename, departuretime, arrivaltime, citydepartureID, cityarrivalID);
        }

    }
}
