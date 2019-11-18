using System;

namespace DataModeling
{
    public class Attraction
    {
        public int AttractionID { get; }

        public string Name { get; }

        public int CityID { get; }

        public Attraction(int attractionID, string name, int cityID)
        {
            AttractionID = attractionID;
            Name = name;
            CityID = cityID;
        }
    }
}
