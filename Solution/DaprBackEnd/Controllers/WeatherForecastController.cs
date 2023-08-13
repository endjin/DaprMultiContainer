using Microsoft.AspNetCore.Mvc;

namespace DaprBackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly List<string> summaries = new()
    {
        "Freezing", 
        "Bracing",
        "Chilly",
        "Cool", 
        "Mild", 
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching"
    };

    private readonly ILogger<WeatherForecastController> logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        this.logger = logger;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        var rng = new Random();
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = summaries[rng.Next(summaries.Count)]
            })
            .ToArray();
    }
}