using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class Flight
    {
        public int FlightID { get;  }

        public string AirlineName { get; }

        public DateTime DepartureTime { get; }

        public TimeSpan ArrivalTime { get; }

        public int CityDepartureID { get; }

        public int CityArrivalID { get; }

        public DateTime Date { get; }

        public Flight(int flightID, string airlineName, DateTime departureTime, TimeSpan arrivalTime, int cityDepartureID, int cityArrivalID, DateTime date)
        {
            FlightID = flightID;
            AirlineName = airlineName;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            CityDepartureID = cityDepartureID;
            CityArrivalID = cityArrivalID;
            Date = date;
        }

        public override string ToString()
        {
            return $"FlightID: {FlightID}, AirlineName: {AirlineName}, DepartureTime: {DepartureTime}, ArrivalTime: {ArrivalTime}, CityDepartureID: {CityArrivalID}, CityArrivalID: {CityArrivalID}, Date: {Date.Date}";
        }
    }
}
