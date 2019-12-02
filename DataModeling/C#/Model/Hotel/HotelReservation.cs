using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.C_.Model
{
    public class HotelReservation
    {
        public int ReservationID { get; }

        public int HotelID { get; }

        public DateTime CheckinDate { get; }

        public float Price { get; }

        public HotelReservation(int reservationID, int hotelID, DateTime checkinDate, float price)
        {
            ReservationID = reservationID;
            HotelID = hotelID;
            CheckinDate = checkinDate;
            Price = price;
        }
        public override string ToString()
        {
            return $"ReservationID: {ReservationID}, HotelID: {HotelID}, CheckinDate: {CheckinDate.Date}, Price: {Price}";

        }

    }
}
