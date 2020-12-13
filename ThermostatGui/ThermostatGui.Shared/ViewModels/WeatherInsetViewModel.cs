using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ThermostatGui.Shared.ViewModels
{
    public class WeatherInsetViewModel : ViewModelBase
    {
        private int _page = 0;
        private const int _itemsShown = 3;

        private CurrentWeather _currentWeather;
        public CurrentWeather CurrentWeather
        {
            get => _currentWeather ?? new CurrentWeather();
            set => SetProperty(ref _currentWeather, value);
        }

        private IList<DailyWeather> _dailyWeather;
        public IList<DailyWeather> DailyWeather
        {
            get
            {
                _dailyWeather = _dailyWeather ?? new ObservableCollection<DailyWeather>();
                _dailyWeather = new List<DailyWeather>(_dailyWeather.Skip(_page * _itemsShown).Take(_itemsShown));
                return _dailyWeather;
            }
            set => SetProperty(ref _dailyWeather, value);
        }
    }

    public class CurrentWeather : ViewModelBase, IEqualityComparer<CurrentWeather>
    {
        private double _temp;
        public double Temp
        {
            get => _temp;
            set => SetProperty(ref _temp, value);
        }

        public double FeelsLike { get; set; }
        public double Humidity { get; set; }
        public double Clouds { get; set; }
        public int Visibility { get; set; }
        public double WindSpeed { get; set; }
        public IList<WeatherSummary> WeatherSummary { get; set; }

        public bool Equals(CurrentWeather x, CurrentWeather y)
        {
            return x.Temp == y.Temp &&
                x.FeelsLike == y.FeelsLike &&
                x.Humidity == y.Humidity &&
                x.Clouds == y.Clouds &&
                x.Visibility == y.Visibility &&
                x.WindSpeed == y.WindSpeed &&
                x.WeatherSummary.Equals(y.WeatherSummary);
        }

        public int GetHashCode(CurrentWeather obj)
        {
            throw new NotImplementedException();
        }
    }

    public class WeatherSummary : ViewModelBase, IEquatable<WeatherSummary>
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }

        private string _icon;
        public string Icon
        {
            get => _icon;
            set => SetProperty(ref _icon, value);
        }

        public bool Equals(WeatherSummary other)
        {
            return Id == other.Id &&
                Main.Equals(other.Main) &&
                Description.Equals(other.Description) &&
                Icon.Equals(other.Icon);
        }
    }

    public class DailyWeather
    {
        public Temperature Temperature { get; set; }
        public FeelsLike FeelsLike { get; set; }
        public double Humidity { get; set; }
        public double WindSpeed { get; set; }
        public WeatherSummary Weather { get; set; }
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
