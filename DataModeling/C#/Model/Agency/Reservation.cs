using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class Reservation
    {
        public int ReservationID { get; }

        public DateTimeOffset DateCreated { get; }

        public bool IsDeleted { get; }

        public bool CarReservation { get; }

        public bool HotelReservation { get; }

        public bool BoardingPass { get; }

        public bool AttractionTicket { get; }

        public bool RestaurantReservation { get; }

        public int TripID { get; }

        public Reservation(int reservationID, DateTimeOffset dateCreated, bool isDeleted, bool carReservation, bool hotelReservation, bool boardingPass, bool attractionTicket, bool restaurantReservation, int tripID)
        {
            ReservationID = reservationID;
            DateCreated = dateCreated;
            IsDeleted = isDeleted;
            CarReservation = carReservation;
            HotelReservation = hotelReservation;
            BoardingPass = boardingPass;
            AttractionTicket = attractionTicket;
            RestaurantReservation = restaurantReservation;
            TripID = tripID;

        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("ReservationID: " + ReservationID);
            result.Append(", ");
            result.Append("DateCreated: " + DateCreated.Date);
            result.Append(", ");
            result.Append("TripID: " + TripID);
            result.Append(", ");
            if(CarReservation)
            {
                result.Append("Has Car Reservation");
            }
            else
            {
                result.Append("No Car Reservation");
            }
            result.Append(", ");
            if (HotelReservation)
            {
                result.Append("Has Hotel Reservation");
            }
            else
            {
                result.Append("No Hotel Reservation");
            }
            result.Append(", ");
            if (AttractionTicket)
            {
                result.Append("Has Attraction Ticket");
            }
            else
            {
                result.Append("No Attraction Ticket");
            }
            result.Append(", ");
            if (RestaurantReservation)
            {
                result.Append("Has Restaurant Reservation");
            }
            else
            {
                result.Append("No Restaurant Reservation");
            }
            result.Append(", ");
            if (BoardingPass)
            {
                result.Append("Has Boarding Pass");
            }
            else
            {
                result.Append("No Boarding Pass");
            }
            result.Append(", ");
            if (IsDeleted)
            {
                result.Append("Deleted");
            }
            else
            {
                result.Append("Not Deleted");
            }
            return result.ToString();

        }









    }
}
