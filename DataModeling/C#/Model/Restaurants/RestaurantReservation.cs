using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class RestaurantReservation : IReservation
    {
        public int ReservationID { get; }

        public DateTime ReservationDate { get; }

        public int RestaurantID { get; }

        public DateTime ReservationTime { get; }

        public RestaurantReservation(int reservationID, DateTime reservationDate, int restaurantID, DateTime reservationTime)
        {
            ReservationID = reservationID;
            ReservationDate = reservationDate;
            RestaurantID = restaurantID;
            ReservationTime = reservationTime;
        }
        public override string ToString()
        {
            return $"ReservationID: {ReservationID}, ReservationDate: {ReservationDate}, RestaurantID: {RestaurantID}, ReservationTime: {ReservationTime}";
        }

        public string ReservationInfo()
        {
            return $"Restaurant Reservation {ReservationID}, Restaurant {ReservationID}, {ReservationTime}, {ReservationDate}"; 
        }
    }
}
