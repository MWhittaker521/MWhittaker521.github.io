using System;
using System.Collections.Generic;
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
            //Delegates the rest of the About Button Click to this Page
            InformationControl.OnAboutBtnClick += OnAboutBtnClick;
            //Delegates the rest of the FAQ menu Button Click to this Page
            InformationControl.OnFAQBtnClick += OnFAQBtnClick;
            //Delegates the rest of the Help menu Button Click to this Page
            InformationControl.OnHelpBtnClick += OnHelpBtnClick; 
        }
        //Loads the Help Page into the Main Frame when the Help menu button is clicked
        private void OnHelpBtnClick()
        {
            MainFrame.Navigate(typeof(HelpPage));
           
        }
        //Loads the FAQ Page into the Main Frame when the FAQ menu button is clicked
        private void OnFAQBtnClick()
        {
            MainFrame.Navigate(typeof(FAQPage));
        }
        //Loads the About Page into the Main Frame when the About menu button is clicked
        private void OnAboutBtnClick()
        {
            MainFrame.Navigate(typeof(AboutPage));
        }
    }
}
