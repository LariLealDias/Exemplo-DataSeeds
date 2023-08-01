using Exemplo_DataSeeds.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exemplo_DataSeeds.Data.DataSeed
{
    public class SeedWeatherConfiguration : IEntityTypeConfiguration<WeatherForecast>
    {
        public void Configure(EntityTypeBuilder<WeatherForecast> builder)
        {
            builder.HasData(
                new WeatherForecast { Date = new DateTime(2023, 8, 1), TemperatureC = 25, Summary = "Chuvoso"},
                new WeatherForecast { Date = new DateTime(2023, 8, 2), TemperatureC = 35, Summary = "Ensolarado" },
                new WeatherForecast { Date = new DateTime(2023, 8, 3), TemperatureC = 16, Summary = "Nublado" },
                new WeatherForecast { Date = new DateTime(2023, 8, 4), TemperatureC = 33, Summary = "Ensolarado" }
            );
        }
    }
}
