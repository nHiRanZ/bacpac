﻿using System;
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
    public partial class StepTwo : PhoneApplicationPage
    {
        public StepTwo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            locationsText.Text += ((ComboBoxItem)locationsBox.SelectedItem).Content.ToString() + "\n";
        }
    }
}