using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    public class CarsGetAgencyNameDelegate : DataReaderDelegate<CarRental>
    {
        private readonly int reservationID;

        public CarsGetAgencyNameDelegate(int reservationID)
           : base("Cars.GetAgencyName")
        {
            this.reservationID = reservationID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ReservationID", reservationID);
        }

        public override CarRental Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(reservationID.ToString());

            return new CarRental(
               reader.GetInt32("CarRentalID"),
               reader.GetString("AgencyName"),
               reader.GetInt32("CityID"));
        }
    }
}