using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.C_.Model
{
    public class RestaurantReservation
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
    }
}
