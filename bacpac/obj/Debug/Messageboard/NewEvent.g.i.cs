﻿#pragma checksum "E:\IIT\2nd Year\MIC\Coding\bacpac\bacpac\Messageboard\NewEvent.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5CBBA0E09D345BE48E441A44CDA38313"
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


namespace bacpac.Messageboard {
    
    
    public partial class NewEvent : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox eventNameBox;
        
        internal Microsoft.Phone.Controls.DatePicker startDatePicker;
        
        internal Microsoft.Phone.Controls.DatePicker endDatePicker;
        
        internal System.Windows.Controls.Button customLocationBt;
        
        internal System.Windows.Controls.Button locateMeBt;
        
        internal System.Windows.Controls.TextBox eventDescBox;
        
        internal System.Windows.Controls.Button cancelBt;
        
        internal System.Windows.Controls.Button addBt;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/bacpac;component/Messageboard/NewEvent.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.eventNameBox = ((System.Windows.Controls.TextBox)(this.FindName("eventNameBox")));
            this.startDatePicker = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("startDatePicker")));
            this.endDatePicker = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("endDatePicker")));
            this.customLocationBt = ((System.Windows.Controls.Button)(this.FindName("customLocationBt")));
            this.locateMeBt = ((System.Windows.Controls.Button)(this.FindName("locateMeBt")));
            this.eventDescBox = ((System.Windows.Controls.TextBox)(this.FindName("eventDescBox")));
            this.cancelBt = ((System.Windows.Controls.Button)(this.FindName("cancelBt")));
            this.addBt = ((System.Windows.Controls.Button)(this.FindName("addBt")));
        }
    }
}
