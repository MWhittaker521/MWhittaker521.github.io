﻿#pragma checksum "C:\Users\melis\source\repos\TravelApplication\MWhittaker521.github.io\TravelApplication\Pages\WeddingResultsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9B2FB414AAB6B1196AAC2A3E89654D97"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelApplication.Pages
{
    partial class WeddingResultsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.SearchResultHeaderStyle = (global::Windows.UI.Xaml.Style)(target);
                }
                break;
            case 2:
                {
                    this.WedResultsListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 3:
                {
                    this.RankSort = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 36 "..\..\..\Pages\WeddingResultsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.RankSort).Click += this.RankSort_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.PriceLHSort = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 39 "..\..\..\Pages\WeddingResultsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.PriceLHSort).Click += this.PriceLHSort_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.PriceHLSort = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 42 "..\..\..\Pages\WeddingResultsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.PriceHLSort).Click += this.PriceHLSort_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.ResultHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

