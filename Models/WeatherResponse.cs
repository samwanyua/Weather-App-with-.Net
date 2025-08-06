using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class WeatherResponse
    {
        [JsonPropertyName("main")]
        public Main Main { get; set; }

        [JsonPropertyName("weather")]
        public List<Weather> Weather { get; set; }

        [JsonPropertyName("name")]
        public string CityName { get; set; }
    }

    public class Main
    {
        [JsonPropertyName("temp")]
        public float Temp { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
    }

    public class Weather
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }
}
