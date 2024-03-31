using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LetsGoOutside.Infrastructure.Data.SeedDb
{
    internal class WeatherConfiguration : IEntityTypeConfiguration<Weather>
    {
        public void Configure(EntityTypeBuilder<Weather> builder)
        {
            var data = new SeedData();

            builder.HasData(new Weather[] { data.WinterWeather, data.SummerWeather, data.SpringWeather, data.AutumnWeather, data.WetWeather, data.HotWeather, data.SunnyWeather, data.SnowyWeather, data.ColdWeather, data.WindyWeather });
        }
    }
}
