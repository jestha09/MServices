using System.Collections.Generic;
using Pricing.Models;

namespace Price.DataAccessLayer
{
    public interface IPriceRepository
    {
        IEnumerable<MigrationLog> Get();
        List<MigrationLog> Get(string id);
    }
}
