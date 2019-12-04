using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    public class RestaurantsGetRestaurantReservationDelegate : DataReaderDelegate<RestaurantReservation>
    {
        private readonly int restaurantID;

        public RestaurantsGetRestaurantReservationDelegate(int restaurantID)
           : base("Restaurants.GetRestaurantReservationt")
        {
            this.restaurantID = restaurantID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RestaurantID", restaurantID);
        }

        public override RestaurantReservation Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null; ;

            return new RestaurantReservation(reader.GetInt32("ReservationID"),
               reader.GetDateTime("ReservationDate"),
               restaurantID,
               reader.GetDateTime("ReservationTime"));
        }
    }
}