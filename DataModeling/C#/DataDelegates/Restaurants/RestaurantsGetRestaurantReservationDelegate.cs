using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    internal class HotelsGetHotelDelegate : DataReaderDelegate<Restaurant>
    {
        private readonly int restaurantID;

        public HotelsGetHotelDelegate(int restaurantID)
           : base("Restaurants.GetRestaurantReservationt")
        {
            this.restaurantID = restaurantID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RestaurantID", restaurantID);
        }

        public override Restaurant Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(hotelID.ToString());

            return new Restaurant(reader.GetString("RestaurantID"),
               reader.GetString("Name"),
               reader.GetString("CityID"));
        }
    }
}