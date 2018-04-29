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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TravelApplication
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            this.InitializeComponent();
            var users = ViewModel.GetUserData(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var userDict = ViewModel.GetDictionary(); 
            var firstName = FirstNameTextBox.Text;
            var lastName = LastNameText.Text;
            var userID = UIDText.Text;
            var pass = NewPasswordText.Text;
            var confirmPass = ConfirmPasswordText.Text;
            if (firstName.Length < 2)
            {
                DisplayFirstMessageBox(); 
            }
            else if (lastName.Length < 2)
            {
                DisplayLastMessageBox();
            }
            else if (userID.Length < 5)
            {
                DisplayIDMessageBox();
            }
            else if (userDict.ContainsKey(userID))
            {
                DisplayExistsMessageBox(); 
            }
            else if (pass != confirmPass)
            {
                DisplayNoMatchMessageBox(); 
            }
            else
            {
                ViewModel.AddUser(firstName, lastName, userID, pass);
                DisplayCreatedMessageBox(); 
            }
        }

        private async void DisplayFirstMessageBox()
        {
            ContentDialog firstDialog = new ContentDialog
            {
                Title = "First Name Input Error",
                Content = "The First Name entered does not meet the minimum Name Requirements. Enter a name with a minimum of two characters to proceed.",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await firstDialog.ShowAsync(); 
        }

        private async void DisplayLastMessageBox()
        {
            ContentDialog lastDialog = new ContentDialog
            {
                Title = "Last Name Input Error",
                Content = "The First Name entered does not meet the minimum Name Requirements. Enter a Last name with a minimum of two characters to proceed.",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await lastDialog.ShowAsync();
        }

        private async void DisplayIDMessageBox()
        {
            ContentDialog IdDialog = new ContentDialog
            {
                Title = "User Id Length Error",
                Content = "The user id entered does not meet the minimum Requirements. Enter a user id with a minimum of six characters to proceed.",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await IdDialog.ShowAsync();
        }
        private async void DisplayExistsMessageBox()
        {
            ContentDialog existsDialog = new ContentDialog
            {
                Title = "User Id Already Exists",
                Content = "The user id entered already exists. Pick a new User id to continue",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await existsDialog.ShowAsync();
        }
        private async void DisplayNoMatchMessageBox()
        {
            ContentDialog existsDialog = new ContentDialog
            {
                Title = "Passwords do not Match",
                Content = "The Passwords do not match. Please re-enter the passwords to continue",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await existsDialog.ShowAsync();
        }

        private async void DisplayCreatedMessageBox()
        {
            ContentDialog createdDialog = new ContentDialog
            {
                Title = "User Created Successfully",
                Content = "The user has been created successfully, please return to the sign-in screen to try signing in with your new user-id and password",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await createdDialog.ShowAsync();
        }
    }
}
