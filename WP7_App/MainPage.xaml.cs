using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace WP7_App
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

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
                lblResult.Text = Common.Math2.Default.Divide(float.Parse(x.Text), float.Parse(y.Text)).ToString();
            };

            System.Diagnostics.Debug.WriteLine(Common.DeviceInfo.Default.DeviceId);
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