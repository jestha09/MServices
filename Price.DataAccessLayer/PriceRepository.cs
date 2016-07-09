using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Pricing.Models;

namespace Price.DataAccessLayer
{
    public class PriceRepository : IPriceRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["PricingDb"].ConnectionString;

        public void Insert(long holzooBookingId, string failedMessage)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(
                    "INSERT MigrationLog (HolzooBookingId, FailedMessage) VALUES (@holzooBookingId, @failedMessage)",
                    new { holzooBookingId, failedMessage });
            }
        }

        public IEnumerable<MigrationLog> Get()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<MigrationLog>("SELECT * FROM MigrationLog");
            }
        }

        public List<MigrationLog> Get(string id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<MigrationLog>("SELECT * FROM MigrationLog where Holzoobookingid = "+ id +"").ToList();
            }
        }
    }
}
