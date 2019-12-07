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
    public class AgencyCheapestOptionsDelegate : DataReaderDelegate<IReadOnlyList<string>>
    {
        public AgencyCheapestOptionsDelegate() : base("Agency.CheapestOptions")
        {

        }

        public override IReadOnlyList<string> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<string> rows = new List<string>();

            while(reader.Read())
            {                
                rows.Add($"{reader.GetString("CityName")}, " + 
                    $"{reader.GetString("Country")} - {reader.GetString("Hotel")} " +
                    $"${reader.GetDouble("CheapestHotelPrices")} - {reader.GetString("Attraction")} " +
                    $"${reader.GetDouble("CheapestAttractionPrices")}");
            }
            return rows;
        }
    }
}
