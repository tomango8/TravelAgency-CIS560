using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    internal class HotelsGetHotelDelegate : DataReaderDelegate<Hotel>
    {
        private readonly int hotelID;

        public HotelsGetHotelDelegate(int hotelID)
           : base("Hotels.GetHotel")
        {
            this.hotelID = hotelID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("HotelID", hotelID);
        }

        public override Hotel Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(hotelID.ToString());

            return new Hotel(hotelID,
               reader.GetString("Name"),
               reader.GetString("CityID"),
               reader.GetString("FullAddress"),
               reader.GetString("Hotel"));
        }
    }
}