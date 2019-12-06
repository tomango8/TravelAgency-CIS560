using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    public class RestaurantsGetRestaurantDelegate : DataReaderDelegate<Restaurant>
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

        public override Restaurant Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Restaurant(reader.GetInt32("RestaurantID"),
               reader.GetString("Name"),
               reader.GetInt32("CityID")               
               );
        }
    }
}