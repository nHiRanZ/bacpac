﻿#pragma checksum "E:\IIT\2nd Year\MIC\Coding\bacpac\bacpac\TripSequence\AddLocations.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C13D377A8F79FFCBC5147C776F62BAC6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace bacpac.TripSequence {
    
    
    public partial class AddLocations : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ComboBox ComboBoxMenu;
        
        internal System.Windows.Controls.Button addToListBt;
        
        internal System.Windows.Controls.TextBlock locationList;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/bacpac;component/TripSequence/AddLocations.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.ComboBoxMenu = ((System.Windows.Controls.ComboBox)(this.FindName("ComboBoxMenu")));
            this.addToListBt = ((System.Windows.Controls.Button)(this.FindName("addToListBt")));
            this.locationList = ((System.Windows.Controls.TextBlock)(this.FindName("locationList")));
        }
    }
}

