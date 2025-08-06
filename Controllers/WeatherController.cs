using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherDashboard.Models;

namespace WeatherDashboard.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherController(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var apiKey = _configuration["OpenWeather:ApiKey"];
            var lat = "-1.286389"; // Nairobi
            var lon = "36.817223";
            var url = $"https://api.openweathermap.org/data/3.0/onecall?lat={lat}&lon={lon}&exclude=minutely,hourly,alerts&units=metric&appid={apiKey}";

            var client = _httpClientFactory.CreateClient();
            var response = await client.GetStringAsync(url);
            var weather = JsonConvert.DeserializeObject<WeatherResponse>(response);

            return View(weather);
        }
    }
}