//line 31 new objwct modify line 26 
using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
    internal class CarsGetCarReservationInfo : DataReaderDelegate<ReservationInfo>
    {
        private readonly int reservationID;

        public CarsGetCarReservationInfo(int ReservationID)
           : base("Cars.GetCarReservationInfo")
        {
            this.reservationID = ReservationID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ReservationID", reservationID);
        }

        public override ReservationInfo Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(reservationID.ToString());

            return new ReservationInfo(reader.GetString("ReservationID"),
               reader.GetString("CarRentalID"),
               reader.GetString("RentalDate"),
               reader.GetString("Model"),
               reader.GetString("Price")
               );
        }
    }
}