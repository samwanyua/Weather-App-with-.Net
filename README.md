#  Weather Now – Beginner’s Weather Dashboard in .NET

This is a simple beginner-friendly weather dashboard web application built using **ASP.NET Core MVC** and the **OpenWeatherMap API**. It allows users to input a city name and view real-time weather data such as temperature, humidity, and weather conditions.

##  Project Objective

As part of the Moringa AI Capstone Project, this app demonstrates how to:
- Scaffold and build a basic ASP.NET Core MVC project.
- Consume a third-party API (OpenWeatherMap) using `HttpClient`.
- Deserialize complex JSON data into strongly-typed C# models.
- Use Razor views to display dynamic weather data.
- Document and iterate using AI prompts.

---

##  Project Structure

```
Weather-App-with-.Net/
├── Controllers/
│   └── WeatherController.cs        # Handles logic to fetch and process weather data
├── Models/
│   └── WeatherResponse.cs          # C# model for OpenWeather API JSON response
├── Views/
│   └── Weather/
│       └── Index.cshtml            # Razor view for user input and displaying weather
├── wwwroot/                        # Static files (CSS, JS, images)
├── Program.cs                      # Main entry point for app
├── appsettings.json                # Configuration settings
└── README.md                       # Project documentation
```

---

##  API Used: OpenWeatherMap

We used the **One Call API** from [OpenWeather](https://openweathermap.org/api/one-call-api).

###  Sample API Response

```json
{
  "lat": 52.2297,
  "lon": 21.0122,
  "timezone": "Europe/Warsaw",
  "timezone_offset": 3600,
  "data": [
    {
      "dt": 1645888976,
      "sunrise": 1645853361,
      "sunset": 1645891727,
      "temp": 279.13,
      "feels_like": 276.44,
      "pressure": 1029,
      "humidity": 64,
      "dew_point": 272.88,
      "uvi": 0.06,
      "clouds": 0,
      "visibility": 10000,
      "wind_speed": 3.6,
      "wind_deg": 340,
      "weather": [
        {
          "id": 800,
          "main": "Clear",
          "description": "clear sky",
          "icon": "01d"
        }
      ]
    }
  ]
}
```

---

## 🧪 Minimal Working Example

- User inputs city name (e.g., "Nairobi")
- System sends a request to OpenWeather API
- Parses response and renders:
  - Temperature (`temp`)
  - Humidity (`humidity`)
  - Weather description (`description`)
  - Icon (e.g., ☀️ for clear sky)

---

## 💻 System Requirements

| Requirement      | Description                    |
|------------------|--------------------------------|
| OS               | Ubuntu 22.04 / Windows / macOS |
| SDK              | .NET SDK 8.0+                  |
| Editor           | Visual Studio Code             |
| Extensions       | C# for VS Code                 |
| API Key          | OpenWeatherMap (Free)          |

---

## ⚙️ Installation

```bash
# Clone the project
git clone https://github.com/yourusername/WeatherApp.git
cd WeatherApp

# Run the project
dotnet run
```

---

##  AI Prompt Examples Used

| Prompt | Purpose |
|--------|---------|
| “Create a new ASP.NET Core MVC project” | Project scaffolding |
| “Write a WeatherController that fetches data from OpenWeatherMap” | API integration |
| “Create C# model from this OpenWeather JSON response” | Strongly typed classes |
| “Generate a Razor view to display weather data” | View/UI creation |

---

##  Common Issues & Fixes

| Problem | Fix |
|--------|-----|
| `401 Unauthorized` | Ensure your API key is valid and added to the request URL |
| `NullReferenceException` | Check if API response is missing expected fields |
| JSON not parsing | Update model to match exact JSON structure (use `[JsonPropertyName]`) |

---

##  References

- [.NET Documentation](https://learn.microsoft.com/en-us/dotnet/)
- [OpenWeatherMap API Docs](https://openweathermap.org/api)
- [C# Model Generator](https://json2csharp.com)
- [ASP.NET Core MVC Tutorial](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview)

---

##  Author

Samuel Wanyua – Capstone project for Moringa School AI Toolkit

---

##  License

MIT License
