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
    public partial class AddLocations : PhoneApplicationPage
    {
        public AddLocations()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TripSequence/Calendar.xaml", UriKind.Relative));
        }

        private void addToListBt_Click(object sender, RoutedEventArgs e)
        {
            locationList.Text += ((ComboBoxItem)ComboBoxMenu.SelectedItem).Content.ToString() + "\n";
        }
    }
}