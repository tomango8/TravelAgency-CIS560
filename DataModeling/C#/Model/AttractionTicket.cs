using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling
{
    public class AttractionTicket
    {
        public int ReservationID { get; }

        public int AttractionID { get; }

        public DateTime TicketDate { get; }

        public float Price { get; }

        public AttractionTicket(int reservationID, int attractionID, DateTime ticketDate, float price)
        {
            ReservationID = reservationID;
            AttractionID = attractionID;
            TicketDate = ticketDate;
            Price = price;
        }
    }
}
