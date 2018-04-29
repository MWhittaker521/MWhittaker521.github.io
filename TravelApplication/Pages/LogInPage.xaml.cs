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
using TravelApplication.Models;
using TravelApplication.ViewModels;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.RegularExpressions;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TravelApplication.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LogInPage : Page
    {
        //Event Handler to handle Sign-Up Here Selection Event
        public delegate void SignUpHereEventHandler(object sender, RoutedEventArgs e);
        //Delegate method which the receiving page must listen for
        public static event SignUpHereEventHandler OnSignUpHere;
        //Event Handler to handle Log-In Success Event
        public delegate void LogInEventHandler(object sender, RoutedEventArgs e);
        //Delegate method which the receiving page must listen for
        public static event LogInEventHandler OnLogIn;
        //Event Handler to handle Log-In Success Event
        public delegate void LogInSuccessEventHandler(string uId);
        //Delegate method which the receiving page must listen for
        public static event LogInSuccessEventHandler OnLogInSuccess; 


        public LogInPage()
        {
            this.InitializeComponent();
        }
        
        private void SignUpHere_Click(object sender, RoutedEventArgs e)
        {
            //Delegates the rest of the Sign up here click event to the MainPage to load the sign-up form
            OnSignUpHere(sender, e); 
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            var uId = UserIdTextBox.Text;
            var pass = PasswordTextBox.Text;
            var users = ViewModel.GetUserData();
            var dict = ViewModel.GetDictionary();
            var userDict = ViewModel.GetUserDictionary(); 
            if (!dict.ContainsKey(uId))
            {
                DisplayNoMatchMessageBox(); 
            }
            else
            {
                var passConfirm = dict[uId];        
                if (passConfirm != pass)
                {
                    DisplayWrongPasswordMessageBox();
                }
                else
                {
                    DisplaySuccessMessageBox();
                    RoutedEventArgs newEventArgs = new RoutedEventArgs();
                    OnLogIn(userDict, newEventArgs);
                    OnLogInSuccess(uId); 
                }
            }            
        }
        private async void DisplayNoMatchMessageBox()
        {
            ContentDialog firstDialog = new ContentDialog
            {
                Title = "User Id Not Found",
                Content = "The user Id Entered does not exist. Try again",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await firstDialog.ShowAsync();
        }

        private async void DisplayWrongPasswordMessageBox()
        {
            ContentDialog wrongPasswordDialog = new ContentDialog
            {
                Title = "Password incorrect",
                Content = "The password entered for this user id is not correct. Try again",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await wrongPasswordDialog.ShowAsync();
        }

        private async void DisplaySuccessMessageBox()
        {
            ContentDialog successDialog = new ContentDialog
            {
                Title = "Logged In",
                Content = "You are Now Logged In",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await successDialog.ShowAsync();
        }

    }
}
