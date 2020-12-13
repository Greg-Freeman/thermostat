using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ThermostatGui.Shared.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ThermostatGui.Shared.Insets
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CurrentWeatherInset : Page
    {
        private WeatherInsetViewModel _viewModel;
        public CurrentWeatherInset()
        {
            this.InitializeComponent();
            _viewModel = _viewModel ?? new WeatherInsetViewModel();
            DataContext = _viewModel;
            _viewModel.CurrentWeather = new CurrentWeather() { Temp = 100.0, };
            _viewModel.DailyWeather = new ObservableCollection<DailyWeather>()
            {
                new DailyWeather()
                {
                    Weather = new WeatherSummary()
                    {
                        Id = 200,
                        Icon = "11d"
                    }
                },
                new DailyWeather()
                {
                    Weather = new WeatherSummary()
                    {
                        Id=500,
                        Icon = "11d"
                    }
                },
                new DailyWeather()
                {
                    Weather = new WeatherSummary()
                    {
                        Id=801,
                        Icon = "11d"
                    }
                }
            };
        }
    }
}
