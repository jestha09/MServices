using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Price.DataAccessLayer;
using Pricing.Models;

namespace PricingService.Controllers
{
    /// <summary>
    /// Price of a given product
    /// </summary>
    public class PriceController : ApiController
    {
        private readonly PriceRepository _priceRepository = new PriceRepository();

        public List<MigrationLog> Get()
        {
            var allUrlKeyValues = ControllerContext.Request.GetQueryNameValuePairs();
            var id = allUrlKeyValues.SingleOrDefault(x => x.Key == "BookingId").Value;
            
            if (id != null)
            {
                return _priceRepository.Get(id);
            }
            return _priceRepository.Get().ToList();
        }
    }
}
