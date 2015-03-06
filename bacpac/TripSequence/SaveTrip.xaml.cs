using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace bacpac.TripSequence
{
    public partial class SaveTrip : PhoneApplicationPage
    {
        public SaveTrip()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TripSequence/WeatherInfo.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your trip was saved successfully!");
            NavigationService.Navigate(new Uri("/AppLandingPage.xaml", UriKind.Relative));
        }
    }
}