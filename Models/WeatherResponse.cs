using System.Collections.Generic;

namespace WeatherDashboard.Models
{
    public class WeatherResponse
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Timezone { get; set; }
        public int Timezone_Offset { get; set; }
        public CurrentWeather Current { get; set; }
        public List<DailyWeather> Daily { get; set; }
    }

    public class CurrentWeather
    {
        public double Temp { get; set; }
        public double Feels_Like { get; set; }
        public int Humidity { get; set; }

        public double Wind_Speed { get; set; }  
        public int Clouds { get; set; }        

        public List<WeatherInfo> Weather { get; set; }
    }

    public class DailyWeather
    {
        public long Dt { get; set; }
        public TempInfo Temp { get; set; }
        public List<WeatherInfo> Weather { get; set; }
    }

    public class TempInfo
    {
        public double Min { get; set; }
        public double Max { get; set; }
    }

    public class WeatherInfo
    {
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
