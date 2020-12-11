using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ThermostatGui.Shared.Models;

namespace ThermostatGui.Shared.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel() { }

        private double _heatSetpoint = 23;
        public double HeatSetpoint
        {
            get { return _heatSetpoint; }
            set
            {
                SetProperty(ref _heatSetpoint, value);
            }
        }

        public double _coolSetpoint = 23;
        public double CoolSetpoint
        {
            get { return _coolSetpoint; }
            set
            {
                SetProperty(ref _coolSetpoint, value);
            }
        }
    }
}
