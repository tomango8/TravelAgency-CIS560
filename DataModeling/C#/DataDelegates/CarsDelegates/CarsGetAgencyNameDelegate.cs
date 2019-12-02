using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
    internal class CarsGetAgencyNameDelegate : DataReaderDelegate<Person>
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

        public override Person Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(reservationID.ToString());

            return new Person(reservationID,
               reader.GetString("CarRentalID"),
               reader.GetString("AgencyName"),
               reader.GetString("CityID"));
        }
    }
}