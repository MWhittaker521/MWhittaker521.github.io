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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TravelApplication.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InitialPage : Page
    {
        //Event Handler to handle Log-In Button Selection Event
        public delegate void LogInBtnEventHandler(object sender, RoutedEventArgs e);
        //Delegate method which the receiving page must listen for
        public static LogInBtnEventHandler OnLogInButtonPushed;
        //Event Handler to handle Sign-Up Button Selection Event
        public delegate void SignUpBtnEventHandler(object sender, RoutedEventArgs e);
        //Delegate method which the receiving page must listen for
        public static SignUpBtnEventHandler OnSignUpButtonPushed;
        //Event Handler to handle Guest Button Selection Event
        public delegate void GuestBtnEventHandler(object sender, RoutedEventArgs e);
        //Delegate method which the receiving page must listen for
        public static GuestBtnEventHandler OnGuestButtonPushed;

        public InitialPage()
        {
            this.InitializeComponent();
        }
        //Log-In Button Click Event
        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            OnLogInButtonPushed(sender, e); 
        }
        //Sign-Up Button Click Event
        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            OnSignUpButtonPushed(sender, e); 
        }
        //Guest Button Click Event
        private void GuestBtn_Click(object sender, RoutedEventArgs e)
        {
            OnGuestButtonPushed(sender, e); 
        }
    }
}
