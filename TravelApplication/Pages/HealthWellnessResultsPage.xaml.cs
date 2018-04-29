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
using TravelApplication.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TravelApplication.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HealthWellnessResultsPage : Page
    {
        
        public HealthWellnessResultsPage()
        {
            this.InitializeComponent();
            var healthResults = ViewModel.GetHealthData();
            HealthResultsListView.ItemsSource = healthResults;
        }

        private void RankSort_Click(object sender, RoutedEventArgs e)
        {
            var healthResults = ViewModel.GetHealthData();        
            HealthResultsListView.ItemsSource = healthResults.OrderBy(p => p.rank); 
        }

        private void PriceLHSort_Click(object sender, RoutedEventArgs e)
        {
            var healthResults = ViewModel.GetHealthData();
            HealthResultsListView.ItemsSource = healthResults.OrderBy(p => p.priceLow);

        }

        private void PriceHLSort_Click(object sender, RoutedEventArgs e)
        {
            var healthResults = ViewModel.GetHealthData();
            HealthResultsListView.ItemsSource = healthResults.OrderByDescending(p => p.priceHigh); 
        }
    }
}
