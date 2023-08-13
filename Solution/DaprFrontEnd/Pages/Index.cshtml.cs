using Dapr.Client;

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DaprFrontEnd.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DaprClient daprClient;

        public IndexModel(DaprClient daprClient)
        {
            this.daprClient = daprClient ?? throw new ArgumentNullException(nameof(daprClient));
        }

        public async Task OnGet()
        {
            var forecasts = await daprClient.InvokeMethodAsync<IEnumerable<WeatherForecast>>(
                HttpMethod.Get,
                "daprbackend",
                "weatherforecast");

            ViewData["WeatherForecastData"] = forecasts;
        }
    }
}