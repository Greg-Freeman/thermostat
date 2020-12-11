using System;
using System.Collections.Generic;
using System.Text;
using ThermostatGui.Shared.Models;
using Windows.UI.Xaml.Data;

namespace ThermostatGui.Shared.Converters
{
    public class DegreesStringFormatConverter :IValueConverter
    {
        private const string FahrenheitUnitText = "&#x0B;F";
        private const string CelciusUnitText = "&#x0B;C";

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            TemperatureUnits units = (TemperatureUnits)parameter;
            int temperature = (int) value;
            string text = CelciusUnitText;
            
            if (units == TemperatureUnits.Fahrenheit) 
            {
                temperature = (temperature * 9 / 5) + 32;
                text = FahrenheitUnitText;
            }
            return $"{temperature:N0} {text}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
