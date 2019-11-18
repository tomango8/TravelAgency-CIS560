using System;
using DataModeling;
using DataAccess;

namespace DataDelegates
{
    public class GetAttractionDataDelegate : DataReaderDelegate<Attraction>
    {
        private int attractionID;

        public GetAttractionDataDelegate(int attractionID) : base("Attractions.GetAttraction")
        {
            this.attractionID = attractionID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AttractionID", attractionID);
        }

        public override Attraction Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Attraction(attractionID, reader.GetString("Name"), reader.GetString("CityID"));
        }
    }
}

