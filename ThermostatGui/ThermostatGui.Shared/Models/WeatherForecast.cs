using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text;

namespace ThermostatGui.Shared.Models
{
    public class WeatherForecast
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Timezone { get; set; }

        [JsonPropertyName("timezone_offset")]
        public int TimezoneOffset { get; set; }

        public CurrentWeather Current { get; set; }
        public IList<DailyWeather> Daily { get; set; }
    }

    public class CurrentWeather
    {
        public long Dt { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
        public double Temp { get; set; }

        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }

        [JsonPropertyName("dew_point")]
        public double DewPoint { get; set; }
        public double Uvi { get; set; }
        public double Clouds { get; set; }
        public int Visibility { get; set; }

        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonPropertyName("wind_deg")]
        public int WindDeg { get; set; }

        [JsonPropertyName("weather")]
        public IList<WeatherSummary> WeatherSummary { get; set; }
        public IList<DailyWeather> Daily { get; set; }
    }

    public class WeatherSummary
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class DailyWeather
    {
        public long Dt { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }

        [JsonPropertyName("temp")]
        public Temperature Temperature { get; set; }

        [JsonPropertyName("feels_like")]
        public FeelsLike FeelsLike { get; set; }

        public double Pressure { get; set; }
        public double Humidity { get; set; }

        [JsonPropertyName("dew_point")]
        public double DewPoint { get; set; }

        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonPropertyName("wind_deg")]
        public double WindDeg { get; set; }

        public WeatherSummary Weather { get; set; }

        public double Clouds { get; set; }
        public double Pop { get; set; }
        public double Uvi { get; set; }
    }

    public class Temperature
    {
        public double Day { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double Night { get; set; }
        public double Eve { get; set; }
        public double Morn { get; set; }
    }

    public class FeelsLike
    {
        public double Day { get; set; }
        public double Night { get; set; }
        public double Eve { get; set; }
        public double Morn { get; set; }
    }
}
