using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    public class RestaurantsGetRestaurantDelegate : DataReaderDelegate<RestaurantReservation>
    {
        private readonly int reservationID;

        public RestaurantsGetRestaurantDelegate(int reservationID)
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
                return null;

            return new RestaurantReservation(reservationID,
               reader.GetDateTime("ReservationDate"),
               reader.GetInt32("RestaurantID"),
               reader.GetDateTime("ReservationTime")
               );
        }
    }
}