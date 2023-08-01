using Exemplo_DataSeeds.Model;
using Microsoft.EntityFrameworkCore;

namespace Exemplo_DataSeeds.Data
{
    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> opts) : base(opts)
        {
            
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}
