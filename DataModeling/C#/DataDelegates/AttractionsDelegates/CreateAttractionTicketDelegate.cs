using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    public class CreateAttractionTicketDelegate : NonQueryDataDelegate<AttractionTicket>
    {
        public readonly int reservationID;
        public readonly int attractionID;
        public readonly System.DateTime ticketdate;
        public readonly float price;

        public CreateAttractionTicketDelegate(int reservationID, int hattractionID, System.DateTime TicketDate, float Price)
            : base("Attraction.CreateTicket")
        {
            this.reservationID = reservationID;
            this.attractionID = hattractionID;
            this.ticketdate = TicketDate;
            this.price = Price;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ReservationID", reservationID);
            command.Parameters.AddWithValue("AttractionID", attractionID);
            command.Parameters.AddWithValue("TicketDate", ticketdate);
            command.Parameters.AddWithValue("Price", price);


            var p = command.Parameters.Add("ReservationID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override AttractionTicket Translate(SqlCommand command)
        {
            return new AttractionTicket((int)command.Parameters["ReservationID"].Value, attractionID, ticketdate, price);
        }

    }
}
