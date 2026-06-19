# Weather API

A RESTful ASP.NET Core Web API that retrieves mock weather information using multiple weather providers. The application demonstrates Clean Architecture principles, the Strategy Pattern, and the Factory Pattern.

## Features

* Current weather retrieval
* Multiple weather providers
* Strategy Pattern for provider selection
* Factory Pattern for provider resolution
* Clean Architecture
* Dependency Injection
* Unit and Integration Testing

## Technology Stack

* .NET 9
* ASP.NET Core Web API
* C#
* xUnit
* NSubstitute
* Swagger / OpenAPI

## Architecture

The solution follows Clean Architecture principles.

```text
Weather.Api
    ↓
Weather.Application
    ↓
Weather.Domain

Weather.Api
    ↓
Weather.Infrastructure
```

### Layers

#### Domain

Contains core business concepts and enums.

Examples:

* WeatherProviderType

#### Application

Contains business logic, interfaces, DTOs, and services.

Examples:

* IWeatherProvider
* IWeatherProviderFactory
* WeatherService

#### Infrastructure

Contains external integrations and implementations.

Examples:

* WeatherApiProvider
* OpenWeatherProvider
* WeatherProviderFactory

#### API

Contains controllers and application startup configuration.

Examples:

* WeatherController
* Program.cs

## Design Patterns

### Strategy Pattern

Each weather provider implements a common interface:

```csharp
public interface IWeatherProvider
{
    Task<WeatherDTO> GetWeatherAsync(string location);
}
```

Examples:

* WeatherApiProvider
* OpenWeatherProvider

### Factory Pattern

The factory selects the appropriate strategy based on the requested provider type.

```csharp
IWeatherProvider provider =
    _factory.GetProvider(providerType);
```

## Getting Started

### Prerequisites

* .NET 9 SDK
* Visual Studio 2022 or later

### Clone Repository

```bash
git clone <repository-url>
cd WeatherSolution
```

### Restore Packages

```bash
dotnet restore
```

### Run Application

```bash
dotnet run --project src/Weather.Api
```

### Swagger

Once running, browse to:

```text
https://localhost:xxxx/swagger
```

## API Endpoints

### Get Weather

```http
GET /api/weather
```

#### Query Parameters

| Parameter | Type                | Required |
| --------- | ------------------- | -------- |
| location  | string              | Yes      |
| provider  | WeatherProviderType | Yes      |

Example:

```http
GET /api/weather?location=London&provider=WeatherApi
```

Example:

```http
GET /api/weather?location=Paris&provider=OpenWeather
```

### Sample Response

```json
{
  "location": null,
  "current": {
    "tempC": 20,
    "tempF": 0,
    "isDay": 0,
    "condition": {
      "text": "Sunny",
      "icon": "//cdn.weatherapi.com/weather/64x64/day/113.png",
      "code": 1000
    },
    "windMph": 0,
    "windKph": 0,
    "windDegree": 0,
    "windDir": null,
    "pressureMb": 0,
    "pressureIn": 0,
    "humidity": 0,
    "cloud": 0,
    "feelsLikeC": 0,
    "feelsLikeF": 0,
    "windChillC": 0,
    "windChillF": 0,
    "heatIndexC": 0,
    "heatIndexF": 0,
    "visKm": 0,
    "visMiles": 0,
    "uv": 0,
    "gustMph": 0,
    "gustKph": 0,
    "willItRain": 0,
    "chanceOfRain": 0,
    "willItSnow": 0,
    "chanceOfSnow": 0
  }
}
```

## Running Tests

Run all tests:

```bash
dotnet test
```

## Project Structure

```text
src/
├── Weather.Api
├── Weather.Application
├── Weather.Domain
└── Weather.Infrastructure

tests/
└── Weather.Tests
```

## License

This project is provided for educational and demonstration purposes.
