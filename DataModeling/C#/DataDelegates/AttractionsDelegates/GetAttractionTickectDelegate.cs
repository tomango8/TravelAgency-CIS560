// line 31 new object
using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    public class FetchPersonDataDelegate : DataReaderDelegate<Ticket>
    {
        private readonly int reservationID;

        public FetchPersonDataDelegate(int reservationID)
           : base("Attractions.GetAttractionTicket")
        {
            this.reservationID = reservationID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ReservationID", reservationID);
        }

        public override Person Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(reservationID.ToString());

            return new Ticket(reader.GetString("ReservationID"),
               reader.GetString("AttractionID"),
               reader.GetString("TicketDate"),
               reader.GetString("Price"));
        }
    }
}