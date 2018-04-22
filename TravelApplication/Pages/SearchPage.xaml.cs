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
using TravelApplication.Models;
using TravelApplication.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TravelApplication.Pages

{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SearchPage : Page
    {
        private string destCategory;
        //Event Handler to let the main page know of the search button click 
        public delegate void SearchEventHandler(object sender, string category, RoutedEventArgs e);
        //Delegate method which the receiving page must listen for
        public static SearchEventHandler OnSearchButtonPushed;

        public string queryString;
        public SearchPage()
        {
            this.InitializeComponent();
            MainPage.SetDataContext += SetDataContext; 
        }
        
        public void SetDataContext(TravelPack pack)
        {
            this.DataContext = pack; 
        }
       
        /// <summary>
        /// Changes the destination category when the Health/Wellness Radio Button is selected. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HealthWellness_Click(object sender, RoutedEventArgs e)
        {
            destCategory = "healthwell"; 
        }
        /// <summary>
        /// Changes the destination category when the Family Radio Button is selected. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Family_Click(object sender, RoutedEventArgs e)
        {
            destCategory = "fam";
        }
        /// <summary>
        /// Changes the destination category when the Adventure Radio Button is selected. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Adventure_Click(object sender, RoutedEventArgs e)
        {
            destCategory = "adv";
        }
        /// <summary>
        /// Changes the destination category when the Cruise Radio Button is selected. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cruise_Click(object sender, RoutedEventArgs e)
        {
            destCategory = "cruise";
        }
        /// <summary>
        /// Changes the destination category when the Destination Wedding Radio Button is selected. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DestinationWedding_Click(object sender, RoutedEventArgs e)
        {
            destCategory = "wedding";
        }
        /// <summary>
        /// Search button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartSearchBtn_Click(object sender, RoutedEventArgs e)
        {
            //Delegates the rest of the method to the pages listening for the event. 
            OnSearchButtonPushed(sender, destCategory, e); 
        }

    }
}
