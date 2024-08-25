using Microsoft.EntityFrameworkCore;
using PostgreSQLCafe.Entities;

namespace PostgreSQLCafe.Context
{
    public class CafeContext: DbContext
    {
        public CafeContext(DbContextOptions<CafeContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
