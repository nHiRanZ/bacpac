using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace bacpac.Steps
{
    public partial class StepFour : PhoneApplicationPage
    {
        public StepFour()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your trip" + tripNameBox.Text + " was saved successfully!");
        }
    }
}