// check if it should be new Agency line 31  
using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    internal class CarsGetAgencyNameDelegate : DataReaderDelegate<Agency>
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

        public override Agency Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(reservationID.ToString());

            return new Agency(reservationID,
               reader.GetString("CarRentalID"),
               reader.GetString("AgencyName"),
               reader.GetString("CityID"));
        }
    }
}