using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSRS.Pages;
using WebSRS.Pages.Employees;
using WebSRS.Pages.Story;

namespace WebSRS.Pages
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> ops) : base(ops)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<IStory> Storyes { get; set; }
        public DbSet<Region> City { get; set; }
        public DbSet<KZClass> KZ { get; set; }

    }
}
