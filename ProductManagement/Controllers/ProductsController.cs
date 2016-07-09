using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using ProductCatalogue.DataAccessLayer;
using ProductCatalogue.Models;

namespace ProductManagementService.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly ProductCatalogueContext _productDal = new ProductCatalogueContext();//Resolved from Unity container instead



        [HttpGet]
        public List<StatusBooking> GetStatusResult()
        {
            return _productDal.Status.ToList();
        }

        public async Task<List<StatusBooking>> GetStatus()
        {
            return await _productDal.Status.ToListAsync();
        }

    }
}
