using System.Data.Entity;
using ProductCatalogue.Models;

namespace ProductCatalogue.DataAccessLayer
{
    public class ProductCatalogueContext: DbContext
    {

        static ProductCatalogueContext()
        {
            Database.SetInitializer<ProductCatalogueContext>(null);
        }

        public ProductCatalogueContext()
            : base("name=ProductCatalogueDb")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().
                      ToTable("tblProduct")
                          .Map<Hotel>(x => x.Requires("ProductType").HasValue("Hotel"))
                              .Map<Activity>(x => x.Requires("ProductType").HasValue("Activity")
                          );
            modelBuilder.Entity<StatusBooking>().ToTable("tblBookingStatus");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<StatusBooking> Status { get; set; }
    }
}
