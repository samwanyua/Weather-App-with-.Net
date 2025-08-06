using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherDashboard.Models;
using System;

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
            var apiKey = _configuration["OpenWeatherMap:ApiKey"];
            var lat = "-1.286389"; // Nairobi
            var lon = "36.817223";

            Console.WriteLine($"Environment: {Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}");
            Console.WriteLine($"Loaded API Key: {apiKey}");

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                return Content("API Key is missing. Please check appsettings.Development.json or user secrets.");
            }

            var url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&units=metric&appid={apiKey}";

            try
            {
                var client = _httpClientFactory.CreateClient();
                var response = await client.GetStringAsync(url);
                var weather = JsonConvert.DeserializeObject<WeatherResponse>(response);

                return View(weather);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request failed: {ex.Message}");
                return Content($"API request failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return Content($"An error occurred: {ex.Message}");
            }
        }
    }
}
