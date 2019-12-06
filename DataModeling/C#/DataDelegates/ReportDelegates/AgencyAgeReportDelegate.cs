using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataModeling.Model;

namespace DataModeling
{
    public class AgencyAgeReportDelegate : DataReaderDelegate<IReadOnlyList<string>>
    {
        public AgencyAgeReportDelegate() : base("Agency.AgeReport")
        {

        }

        public override IReadOnlyList<string> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<string> rows = new List<string>();

            while (reader.Read())
            {
                //CityID, CityName, Region, Country, CheapestHotel, 
                //CheapestHotelPrice, CheapestAttraction, CheapestAttractionPrice,
                //CheapestCarModelAgency, CheapestModel, CheapestModelPrice 
                rows.Add($"{reader.GetString("AgeGroup")}, {reader.GetInt32("Count")}, " +
                    $"{reader.GetString("AverageBudget")}, {reader.GetString("LowestBudget")}, " +
                    $"{reader.GetString("HighestBudget")}, {reader.GetInt32("AverageAge")}, " +
                    $"{reader.GetString("TripCount")}");
            }
            return rows;
        }
    }
}
