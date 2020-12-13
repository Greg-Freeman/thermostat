using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ThermostatGui.Shared.Controls
{
    public sealed partial class SetpointControl : UserControl
    {
        public SetpointControl()
        {
            this.InitializeComponent();
        }

        private void SetpointControl_Loaded(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public int Setpoint
        {
            get { return (int)GetValue(SetpointProperty); }
            set { SetValue(SetpointProperty, value); }
        }
        public static readonly DependencyProperty SetpointProperty = DependencyProperty.Register(
          "Setpoint", typeof(int), typeof(SetpointControl), new PropertyMetadata(23) { });

        private ICommand _incrementPressedCommand;
        public ICommand IncrementPressedCommand => _incrementPressedCommand ?? new RelayCommand(() => { Setpoint++; Debug.WriteLine("INCREMENT CLICKED"); });

        private ICommand _decrementPressedCommand;

        public ICommand DecrementPressedCommand => _decrementPressedCommand ?? new RelayCommand(() => { Setpoint--; Debug.WriteLine("DECREMENT CLICKED"); });
    }
}
