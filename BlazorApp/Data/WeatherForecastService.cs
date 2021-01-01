using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            var results= Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            }).ToArray();

            // Relational Pattern matching >, <, <=, >=
            // Logical Pattern matching and, or & not
            
            foreach (var rec in results)
            {
                rec.Summary = rec.TemperatureF switch
                {
                    < 0 => "Well Below freezing",
                    >=0 and <32 =>"Freezing",
                    //32 and 212 =>"Exactly Freezing or Boiling",
                    32 or 212 => "Exactly Freezing or Boiling",
                    //32 => "Exactly Freezing",
                    >32 and <65 => "Cool",
                    >=65 and <85 =>"Warm",
                    >= 85 => "Hot"
                    //_ => "Unknown classification"
                };
            }
            return Task.FromResult(results);
        }
    }
}
