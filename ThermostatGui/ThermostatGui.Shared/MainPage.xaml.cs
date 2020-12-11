using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ThermostatGui.Shared;
using ThermostatGui.Shared.Models;
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

namespace ThermostatGui
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly MainPageViewModel _viewModel;
        public MainPageViewModel ViewModel => _viewModel;

        public MainPage()
        {
            this.InitializeComponent();
            this.weatherSummaryFrame.Navigate(typeof(CurrentWeatherInset));
            _viewModel = new MainPageViewModel();
            DataContext = _viewModel;

        }
    }
}
