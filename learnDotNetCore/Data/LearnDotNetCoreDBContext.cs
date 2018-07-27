using learnDotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace learnDotNetCore.Data
{
    public class LearnDotNetCoreDBContext : DbContext
    {
        public LearnDotNetCoreDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
