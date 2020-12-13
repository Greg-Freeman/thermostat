using System;
using ThermostatGui.Shared.ViewModels;
using Windows.UI.Xaml.Data;

namespace ThermostatGui.Shared.Converters
{
    public class IconCodeToWeatherIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            WeatherSummary summary = (WeatherSummary)value;
            int id = summary.Id;
            TimeOfDay timeOfDay = summary.Icon.Contains("d") ? TimeOfDay.Day : TimeOfDay.Night;

            string filename = null;
            if (id >= 200 && id <= 232) { filename = "thunderstorm.png"; }
            else if (id >= 300 && id <= 321) { filename = "drizzle.png"; }
            else if (id == 500 || id == 520 || id == 531) { filename = "drizzle.png"; }
            else if (id == 501 || id == 521 || id == 522) { filename = "rain.png"; }
            else if (id >= 502 && id <= 504) { filename = "extreme.png"; }
            else if (id == 511) { filename = "cold.png"; }
            else if (id >= 600) { filename = "snow.png"; }
            else if (id >= 700) { filename = "atmosphere.png"; }
            else if (id == 801) { filename = $"{AppendTimeOfDay("few_clouds", timeOfDay)}.png" ; }
            else if (id == 802 || id == 803) { filename = $"{AppendTimeOfDay("broken_clounds", timeOfDay)}.png"; }
            else if (id == 804) { filename = $"overcast_clouds.png"; }
            else { filename = null; }
            return $"Assets/WeatherIcons/{filename}";
        }

            public object ConvertBack(object value, Type targetType, object parameter, string language)
            {
                throw new NotImplementedException();
            }

        private string AppendTimeOfDay(string filename,TimeOfDay timeOfDay)
        {
            return $"{filename}_{Enum.GetName(typeof(TimeOfDay), timeOfDay).ToLower()}";
        }

        private enum TimeOfDay
        {
            Day,
            Night
        }
    }
}
