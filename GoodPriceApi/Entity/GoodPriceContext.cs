using Microsoft.EntityFrameworkCore;

namespace GoodPriceApi.Entity
{


    public class GoodPriceContext : DbContext
    {
        public GoodPriceContext()
        {

        }

        public GoodPriceContext(DbContextOptions<GoodPriceContext> options)
            : base(options)
        {

        }

        public DbSet<Good> Goods { get; set; }
    }
}
