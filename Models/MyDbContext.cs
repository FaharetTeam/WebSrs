using Microsoft.EntityFrameworkCore;
using WebSRS.Models;

namespace WebSRS.Contexts
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> op) : base(op)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<AboutU> AboutUs { get; set; }
        public DbSet<AboutS> AboutSite { get; set; }
    }
}
