using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    internal class HotelsGetHotelDelegate : DataReaderDelegate<RestaurantReservation>
    {
        private readonly int reservationID;

        public HotelsGetHotelDelegate(int reservationID)
           : base("Restaurants.GetRestaurant")
        {
            this.reservationID = reservationID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ReservationID", reservationID);
        }

        public override RestaurantReservation Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(ReservationID.ToString());

            return new RestaurantReservation(reader.GetString("ReservationID"),
               reader.GetString("ReservationDate"),
               reader.GetString("RestaurantID"),
               reader.GetString("ReservationTime")
               );
        }
    }
}