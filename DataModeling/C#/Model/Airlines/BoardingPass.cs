using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.C_.Model
{
    public class BoardingPass
    {
        public int ReservationID { get; }

        public int FlightID { get; }

        public float Price { get;  }

        public BoardingPass(int reservationID, int flightID, float price)
        {
            ReservationID = reservationID;
            Price = price;
            FlightID = flightID;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("ReservationID: " + ReservationID);
            result.Append(", ");
            result.Append("FlightID: " + FlightID);
            result.Append(", ");
            result.Append("Price: " + Price);

            return result.ToString();
        }



        }
    }
