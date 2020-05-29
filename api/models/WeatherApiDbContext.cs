using Microsoft.EntityFrameworkCore;

namespace NetCoreRestMySql.models 
{
    public class WeatherApiDbContext : DbContext
    {
        public WeatherApiDbContext(DbContextOptions opt) : base(opt) {}

        public DbSet<WeatherDataPoint> WeatherDataPoint { get; set; }

    }
}