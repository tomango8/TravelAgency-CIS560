//not sure if we are suppose to prduce flight line 31
using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    internal class RetrieveFlightInfoDelegate : DataReaderDelegate<Person>
    {
        private readonly int flightId;

        public RetrieveFlightInfoDelegate(int flightId)
           : base("Airlines.RetrieveFlightInf")
        {
            this.personId = flightId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("FlightID", flightId);
        }

        public override Person Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(flightId.ToString());

            return new Flight(reader.GetString("FlightID"),
               reader.GetString("AirlineName"),
               reader.GetString("DepartureTime"),
               reader.GetString("ArrivalTime"),
               reader.GetString("DepartureTime"),
               reader.GetString("CityDepatureID"),
               reader.GetString("CityArrivalID"),
               reader.GetString("DateofFlight")
               );
        }
    }
}





