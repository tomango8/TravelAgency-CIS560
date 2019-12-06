using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    public class CreateReservationDelegate : NonQueryDataDelegate<Reservation>
    {
        public readonly int reservationID;
        public readonly System.DateTimeOffset datecreated;
        public bool isdeleted;
        public readonly int tripID;
        public bool carreservation;
        public bool hotelreservation;
        public bool boardingpass;
        public bool attractionticket;
        public bool restaurantreservation;

        public CreateReservationDelegate( int tripID, bool carreservation, bool hotelreservation, bool boardingpass, bool attractionticket, bool restaurantreservation)
            : base("Agency.CreateReservation")
        {
            this.tripID = tripID;
            this.isdeleted = false;
            this.carreservation = false;
            this.hotelreservation = false;
            this.boardingpass = false;
            this.attractionticket = false;
            this.restaurantreservation = false;
            

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ReservationID", reservationID);
            command.Parameters.AddWithValue("IsDeleted", isdeleted);
            command.Parameters.AddWithValue("CarReservation", carreservation);
            command.Parameters.AddWithValue("HotelReservation", hotelreservation);
            command.Parameters.AddWithValue("BoardingPass", boardingpass);
            command.Parameters.AddWithValue("AttractionTicket", attractionticket);
            command.Parameters.AddWithValue("RestaurantReservation", restaurantreservation);

            var p = command.Parameters.Add("FlightID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Reservation Translate(SqlCommand command)
        {
            return new Reservation(reservationID,datecreated, isdeleted, carreservation, hotelreservation, boardingpass, attractionticket, restaurantreservation, (int)command.Parameters["TripID"].Value);
        }

    }
}
