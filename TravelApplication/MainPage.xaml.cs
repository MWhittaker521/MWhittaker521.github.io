using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TravelApplication.Controls;
using TravelApplication.Pages;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TravelApplication
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(InitialPage), null);
            //Delegate method that listens for event from AppOptionsControl
            AppOptionsControl.OnBottomMenuSelection += OnBottomMenuSelection;
            //Delegate method that listens for the SignUpHere event from the Log-in Page
            LogInPage.OnSignUpHere += OnSignUpHere;
            //Delegate method that listens for Log In Button Push event from the Initial Page. 
            InitialPage.OnLogInButtonPushed += OnLogInButtonPushed;
            //Delegate method that listens for Sign In Button Push event from the Initial Page. 
            InitialPage.OnSignUpButtonPushed += OnSignUpButtonPushed;
            //Delegate method that listens for Guest Button Push event from the Initial Page. 
            InitialPage.OnGuestButtonPushed += OnGuestButtonPushed;
            SearchPage.OnSearchButtonPushed += OnSearchButtonPushed; 
        }

        //Opens the search results in the Main Frame upon search button pushed event. 
        private void OnSearchButtonPushed(object sender, string category, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(SearchResult), e); 
        }
        //Opens the Generic search in the Main Frame upon guest button pushed event. 
        private void OnGuestButtonPushed(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(TravelPackagesPage), e); 
        }
        //Opens the sign-up in the Main Frame upon Sign-up button pushed event. 
        private void OnSignUpButtonPushed(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(SignUpPage), e); 
        }
        //Opens the Log-in page in the Main Frame upon Log-in button pushed event. 
        private void OnLogInButtonPushed(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(LogInPage), e); 
        }
        //Opens the sign-up page in the Main Frame upon sign-up link pushed event. 
        private void OnSignUpHere(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(SignUpPage), e); 
        }

        //Delegate method that receives the pageName from the AppOptionsControl and then sets the
        //Main Frame content to the correct page. 
        private void OnBottomMenuSelection(object sender, string pageName, RoutedEventArgs e)
        {
            //Sets the newPage based on the sent pageName
            string newPage = pageName; 
            if (newPage == "LogInPage")
            {
                MainFrame.Navigate(typeof(LogInPage), e); 
            }
            else if (newPage == "SignUpPage")
            {
                MainFrame.Navigate(typeof(SignUpPage), e); 
            }
            else if (newPage == "AccountOverviewPage")
            {
                MainFrame.Navigate(typeof(AccountOverviewPage), e); 
            }
            else if (newPage == "AccountPrefPage")
            {
                MainFrame.Navigate(typeof(AccountPrefPage), e); 
            }
            else if (newPage == "AboutPage")
            {
                MainFrame.Navigate(typeof(AboutPage), e); 
            }
            else if (newPage == "FAQPage")
            {
                MainFrame.Navigate(typeof(FAQPage), e); 
            }  
        }

        //Navigates back to the home page when the Main Icon is clicked
        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        { 
            MainFrame.Navigate(typeof(InitialPage), e);
        }
        //Navigates to the Travel Packages Page
        private void TravelPackagesBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(TravelPackagesPage), e);
        }
        //Navigates to the Hotels Page
        private void HotelBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(HotelsPage), e);
        }
        //Navigates to the Flights Page
        private void FeaturedBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(FeaturedDestPage), e);
        }
        //Navigates to the Search Page
        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(SearchPage), e);
        }
        //Previous button click Navigates to the last Frame history item
        private void PreviousArrow_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }                   }

        //Next Button click Navigates to the last forward frame history item. 
        private void NextArrow_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoForward)
            {
                MainFrame.GoForward(); 
            }         
        }
    }
}
