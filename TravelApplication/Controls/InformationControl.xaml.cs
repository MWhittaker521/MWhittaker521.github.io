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
    public sealed partial class InformationControl : UserControl
    {
        //Event Handler to handle the About Button Click 
        public delegate void AboutButtonClickHandler(); 
        //Delegate Method that the receiving page must listen for. 
        public static AboutButtonClickHandler OnAboutBtnClick;

        //Event Handler to handle the Travel FAQs Button Click 
        public delegate void FAQButtonClickHandler();
        //Delegate Method that the receiving page must listen for. 
        public static FAQButtonClickHandler OnFAQBtnClick;

        //Event Handler to handle the Help Button Click 
        public delegate void HelpButtonClickHandler();
        //Delegate Method that the receiving page must listen for. 
        public static HelpButtonClickHandler OnHelpBtnClick;

        public InformationControl()
        {
            this.InitializeComponent();
        }
        //About Button Click Event which the MainPage listens for
        private void AboutFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            OnAboutBtnClick(); 
        }
        //Travel FAQ Click Event which the MainPage listens for
        private void TravelFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            OnFAQBtnClick(); 
        }
        //Help Button Click Event which the MainPage listens for
        private void HelpFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            OnHelpBtnClick(); 
        }
    }
}
