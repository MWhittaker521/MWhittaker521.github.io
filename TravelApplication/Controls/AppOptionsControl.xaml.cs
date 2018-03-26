using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace TravelApplication.Controls
{
    public sealed partial class AppOptionsControl : UserControl
    {
        //Event Handler to handle Menu Selection Events
        public delegate void TopMenuEventHandler(object sender, string pageName, RoutedEventArgs e);
        //Delegate method which the receiving page must listen for
        public static TopMenuEventHandler OnBottomMenuSelection; 
        //Variable to store selection choice
        public string page; 
        public AppOptionsControl()
        {
            this.InitializeComponent();
        }
        //Log-In Button Click Event sets page variable to LogInPage and kicks off delegate event
        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs newArgs = new RoutedEventArgs(); 
            page = "LogInPage";
            OnBottomMenuSelection(sender, page, newArgs); 
        }
        //Sign-Up Button Click Event sets page variable to SignUpPage and kicks off delegate event
        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            page = "SignUpPage";
            RoutedEventArgs newArgs = new RoutedEventArgs();
            OnBottomMenuSelection(sender, page, newArgs);
        }
        //Account Overview Button Click Event sets page variable to AccountOverviewPage and kicks off delegate event
        private void ActOverview_Click(object sender, RoutedEventArgs e)
        {
            page = "AccountOverviewPage";
            RoutedEventArgs newArgs = new RoutedEventArgs();
            OnBottomMenuSelection(sender, page, newArgs);
        }
        //Account Preferences Button Click Event sets page variable to AccountPrefPage and kicks off delegate event
        private void ActPreferences_Click(object sender, RoutedEventArgs e)
        {
            page = "AccountPrefPage";
            RoutedEventArgs newArgs = new RoutedEventArgs();
            OnBottomMenuSelection(sender, page, newArgs);
        }
        //About Button Click Event sets page variable to AboutPage and kicks off delegate event
        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
            page = "AboutPage";
            RoutedEventArgs newArgs = new RoutedEventArgs();
            OnBottomMenuSelection(sender, page, newArgs);
        }
        //FAQ Button Click Event sets page variable to FAQPage and kicks off delegate event
        private void FAQ_Click(object sender, RoutedEventArgs e)
        {
            page = "FAQPage.xaml";
            RoutedEventArgs newArgs = new RoutedEventArgs();
            OnBottomMenuSelection(sender, page, newArgs);
        }
    }
}
