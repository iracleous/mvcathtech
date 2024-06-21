using Microsoft.EntityFrameworkCore;

namespace mvcathtech.Models
{
    public class EshopDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }

        public EshopDbContext()
        {
        }

        public EshopDbContext(DbContextOptions<EshopDbContext> options)
       : base(options)
        {
        }

    }
}
