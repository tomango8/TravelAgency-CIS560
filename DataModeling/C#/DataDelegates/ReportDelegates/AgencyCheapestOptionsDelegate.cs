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
                //CityID, CityName, Region, Country, CheapestHotel, 
                //CheapestHotelPrice, CheapestAttraction, CheapestAttractionPrice,
                //CheapestCarModelAgency, CheapestModel, CheapestModelPrice 
                rows.Add($"{reader.GetInt32("CityID")}, {reader.GetString("CityName")}, " +
                    $"{reader.GetString("Region")}, {reader.GetString("Country")}, " +
                    $"{reader.GetString("CheapestHotel")}, {reader.GetDouble("CheapestHotelPrice")}, " +
                    $"{reader.GetString("CheapestAttraction")}, {reader.GetDouble("CheapestAttractionPrice")}, " +
                    $"{reader.GetString("CheapestCarModelAgency")}, {reader.GetString("CheapestModel")}, " +
                    $"{reader.GetDouble("CheapestModelPrice")}");
            }
            return rows;
        }
    }
}
