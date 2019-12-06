using DataAccess;
using DataModeling.Model;
using System.Collections.Generic;
using System.Data;
using System;
using System.Data.SqlClient;

namespace DataModeling
{
    public class AgencyCreateCarRentalReservationDelegate : NonQueryDataDelegate<CarRentalReservation>
    {
        private int reservationID;
        private int carRentalID ;
        private DateTime rentalDate;
        private string model;
        private float price;

        public AgencyCreateCarRentalReservationDelegate(int reservationID, int carRentalID, DateTime rentalDate,
                                          string model, float price)
            : base(" Agency.CreateCarRentalReservation")
        {
            this.reservationID = reservationID;
            this.carRentalID =carRentalID;
            this.rentalDate = rentalDate;
            this.model= model;
            this.price = price;
    }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ReservationID", reservationID);
            command.Parameters.AddWithValue("CarRentalID", carRentalID);
            command.Parameters.AddWithValue("RentalDate", rentalDate);
            command.Parameters.AddWithValue("Model", model);
            command.Parameters.AddWithValue("Price", price);

        }

        public override CarRentalReservation Translate(SqlCommand command)
        {
            return new CarRentalReservation((int)reservationID, carRentalID, rentalDate,model,price);
        }
    }

}

