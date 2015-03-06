using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;

namespace bacpac.Pages
{
    public partial class SplashScreen : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();
        int time = 0;
        public SplashScreen()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(0.33);
            timer.Tick += new EventHandler(timer1);
            timer.Start();
        }

        private void timer1(object sender, EventArgs e)
        {
            time++;

            if (time == 3)
            {
                NavigationService.Navigate(new Uri("/TripSequence/PanoramaPage1.xaml", UriKind.Relative));
            }
        }
    }
}