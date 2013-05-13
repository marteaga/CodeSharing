﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace W8_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            btnAdd.Click += (o, e) =>
            {
                lblResult.Text = Common.Math2.Default.Add(this.X, this.Y).ToString();
            };

            btnSubtract.Click += (o, e) =>
            {
                lblResult.Text = Common.Math2.Default.Subtract(this.X, this.Y).ToString();
            };

            btnMultiply.Click += (o, e) =>
            {
                lblResult.Text = Common.Math2.Default.Multiple(this.X, this.Y).ToString();
            };

            btnDivide.Click += (o, e) =>
            {
                lblResult.Text = Common.Math2.Default.Divide(this.X, this.Y).ToString();
            };

            System.Diagnostics.Debug.WriteLine(Common.DeviceInfo.Default.DeviceId);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private int X
        {
            get
            {
                return Int32.Parse(x.Text);
            }
        }

        private int Y
        {
            get
            {
                return Int32.Parse(y.Text);
            }
        }
    }
}
