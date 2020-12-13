﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Data;

namespace ThermostatGui.Shared.Converters
{
    public class ButtonWidthToCornerRadiusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return ((double)value) / 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
