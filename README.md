#  Weather App with ASP.NET

This is a simple beginner-friendly weather dashboard web application built using **ASP.NET Core MVC** and the **OpenWeatherMap API**. It allows users to input a city name and view real-time weather data such as temperature, humidity, and weather conditions.

##  Project Objective

This app demonstrates how to:
- Scaffold and build a basic ASP.NET Core MVC project.
- Consume a third-party API (OpenWeatherMap) using `HttpClient`.
- Deserialize complex JSON data into strongly-typed C# models.
- Use Razor views to display dynamic weather data.
- Document and iterate using AI prompts.

---

##  Project Structure

```
Weather-App-with-ASP.Net/
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

##  Minimal Working Example

- User inputs city name (e.g., "Nairobi")
- System sends a request to OpenWeather API
- Parses response and renders:
  - Temperature (`temp`)
  - Humidity (`humidity`)
  - Weather description (`description`)
  - Icon (e.g., ☀️ for clear sky)

---

##  System Requirements

| Requirement      | Description                    |
|------------------|--------------------------------|
| OS               | Ubuntu 22.04 / Windows / macOS |
| SDK              | .NET SDK 8.0+                  |
| Editor           | Visual Studio Code             |
| Extensions       | C# for VS Code                 |
| API Key          | OpenWeatherMap (Free)          |

---

##  Installation

```bash
# Clone the project
git clone https://github.com/samwanyua/Weather-App-with-ASP.Net.git
cd Weather-App-with-ASP.Net
```

### Run the project

#### Clean previous builds
```
dotnet clean WeatherApp.csproj
```

#### Build the project
```
dotnet build WeatherApp.csproj
```

#### Run the project
```
dotnet run --project WeatherApp.csproj
```

##  Environment & Security

Ensure that your API keys and sensitive config files like `appsettings.json` are not committed to version control:



### Structure of appsettings.json 
Have **appsettings.json** looking like below:

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information"
    }
  },
  "AllowedHosts": "*",
  "OpenWeatherMap": {
    "ApiKey": "your_api_key" // Replace with your actual key (never commit this)
  }
}
```

---

##  AI Prompt Journal

Prompt 1: Initial Setup
```
"Generate step-by-step commands to scaffold a new ASP.NET Core MVC project using the .NET CLI on Ubuntu, and explain what each folder means in the project structure."
```

Prompt 2: API Integration

```
"Write a C# method in a .NET MVC controller that uses HttpClient to fetch current weather data from OpenWeatherMap API based on a city name. Include proper error handling and logging."
```

Prompt 3: Model Creation
```
"Create a C# class model that matches the OpenWeatherMap JSON structure for main weather data (temperature, humidity, description, icon)."
```
Prompt 4: View Layer
```
"Generate a Razor view in ASP.NET MVC that accepts a city name as input, submits the request to a controller action, and displays the temperature, humidity, description, and weather icon."
```

Prompt 5: README Generation
```
"Create a detailed README.md for a .NET MVC weather app using OpenWeather API. Include tech stack, setup, how it works, and how to contribute."
```

---

##  Common Issues & Fixes

| Problem | Fix |
|--------|-----|
| `401 Unauthorized` | Ensure your API key is valid and added to the request URL |
| `NullReferenceException` | Check if API response is missing expected fields or if you're accessing properties like `Weather[0]` without null checks |
| `JSON not parsing` | Update your model to match the exact JSON structure from the API (use `[JsonPropertyName]` or `JsonProperty`) |
| `500 Internal Server Error` | This usually means your Razor view is trying to access properties that are null or incorrectly mapped in your model. Double-check your model bindings and JSON response structure. Use `@Model?.Property` or add null guards. |


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
