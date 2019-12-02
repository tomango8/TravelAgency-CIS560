using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    internal class HotelsGetHotelReservationDelegate : DataReaderDelegate<HotelReservation>
    {
        private readonly int reservationId;

        public HotelsGetHotelReservationDelegate(int reservationId)
           : base("Hotels.GetHotelReservation")
        {
            this.reservationId = reservationId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ReservationID", reservationId);
        }

        public override HotelReservation Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(reservationId.ToString());

            return new HotelReservation(reservationIdre,
               reader.GetString("HotelID"),
               reader.GetString("DateOfReservation"),
               reader.GetString("Price"));
        }
    }
}