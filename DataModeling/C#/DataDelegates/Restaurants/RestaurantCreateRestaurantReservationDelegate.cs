using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;
using System;
namespace DataModeling
{
    public class RestaurantCreateRestaurantReservationDelegate : NonQueryDataDelegate<RestaurantReservation>
    {
        public readonly int reservationID;
        public readonly int restaurantID;
        public readonly DateTime date;


        public RestaurantCreateRestaurantReservationDelegate(int reservationID, int restaurantID,DateTime date)
            : base("Restaurant.CreateRestaurantReservation")
        {
            this.reservationID = reservationID;
            this.restaurantID = restaurantID;
            this.date = date;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);


            command.Parameters.AddWithValue("ReservationID", reservationID);
            command.Parameters.AddWithValue("ReservationDate", date);
            command.Parameters.AddWithValue("RestaurantID", restaurantID);

            
        }

        public override RestaurantReservation Translate(SqlCommand command)
        {
            return new RestaurantReservation(reservationID,date,restaurantID);
        }

    }
}
