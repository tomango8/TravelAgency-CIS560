using System;
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
                rows.Add($"{reader.GetString("AgeGroup")}, {reader.GetInt32("Count")}, " +
                    $"{reader.GetDouble("AverageBudget").ToString("C", CultureInfo.CurrentCulture)}, " +
                    $"${reader.GetDouble("LowestBudget").ToString("C", CultureInfo.CurrentCulture)}, " +
                    $"${reader.GetDouble("HighestBudget").ToString("C", CultureInfo.CurrentCulture)}, " +
                    $"{reader.GetInt32("AverageAge")}, " +
                    $"{reader.GetInt32("TripCount")}");
            }
            return rows;
        }
    }
}
