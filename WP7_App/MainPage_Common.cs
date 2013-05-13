using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if WP8
namespace WP8_App
#else
namespace WP7_App
#endif
{
    public partial class MainPage
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
#if WP7
                lblResult.Text = Common.Math2.Default.Divide(float.Parse(x.Text), float.Parse(y.Text)).ToString();
#else
                lblResult.Text = Common.Math2.Default.Divide(this.X, this.Y).ToString();
#endif
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
