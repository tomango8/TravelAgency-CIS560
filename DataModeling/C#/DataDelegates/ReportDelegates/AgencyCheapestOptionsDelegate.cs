﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataModeling.Model;
using System.Globalization;

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
                    $"{reader.GetDouble("CheapestHotelPrices").ToString("C", CultureInfo.CurrentCulture)} - {reader.GetString("Attraction")} " +
                    $"{reader.GetDouble("CheapestAttractionPrices").ToString("C", CultureInfo.CurrentCulture)}");
            }
            return rows;
        }
    }
}
