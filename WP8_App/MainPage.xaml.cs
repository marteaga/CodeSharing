using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WP8_App.Resources;

namespace WP8_App
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
                lblResult.Text = Common.Math2.Default.Divide(this.X, this.Y).ToString();
            };

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
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

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}