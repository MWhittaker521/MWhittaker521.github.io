using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TravelApplication.Pages;
using System.Diagnostics;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TravelApplication
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SearchResult : Page
    {
         
        public SearchResult()
        {
            InitializeComponent();
            var allResults = ViewModel.GetData();
            ResultsListView.ItemsSource = allResults.OrderBy(p => p.DESTId);      
        }

        private void RankSort_Click(object sender, RoutedEventArgs e)
        {
            var allResults = ViewModel.GetData();
            ResultsListView.ItemsSource = allResults.OrderBy(p => p.DESTId);
        }

        private void PriceLHSort_Click(object sender, RoutedEventArgs e)
        {
            var travelResults = ViewModel.GetData();
            ResultsListView.ItemsSource = travelResults.OrderBy(p => p.priceLow);

        }

        private void PriceHLSort_Click(object sender, RoutedEventArgs e)
        {
            var travelResults = ViewModel.GetData();
            ResultsListView.ItemsSource = travelResults.OrderByDescending(p => p.priceHigh);
        }
    }
}
