using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataModeling.Model;

namespace DataModeling
{
    public class CreateBoardingPassDelegate : NonQueryDataDelegate<BoardingPass>
    {
        public readonly int reservationID;
        public readonly int flightID;
        public readonly float price;

        public CreateBoardingPassDelegate(int reservationID, int flightID, float Price)
            : base("Airlines.CreateBoardingPass")
        {
            this.reservationID = reservationID;
            this.flightID = flightID;
            this.price = Price;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ReservationID", reservationID);
            command.Parameters.AddWithValue("FlightID", flightID);
            command.Parameters.AddWithValue("Price", price);


            var p = command.Parameters.Add("ReservationID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override BoardingPass Translate(SqlCommand command)
        {
            return new BoardingPass((int)command.Parameters["ReservationID"].Value, flightID, price);
        }

    }
}
