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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IECSE.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MenuButton_Checked(object sender, RoutedEventArgs e)
        {
            MenuButton.IsChecked = false;
            MainSplit.IsPaneOpen = !MainSplit.IsPaneOpen;
        }

        private void HomeButton_Checked(object sender, RoutedEventArgs e)
        {
            NavigateTo(HomeGrid);
        }

        private void AccountButton_Checked(object sender, RoutedEventArgs e)
        {
            NavigateTo(AccountGrid);
        }

        private void SettingsButton_Checked(object sender, RoutedEventArgs e)
        {
            NavigateTo(SettingsGrid);
        }

        private void AboutButton_Checked(object sender, RoutedEventArgs e)
        {
            NavigateTo(AboutGrid);
        }

        void NavigateTo(Grid activeGrid)
        {
            HomeGrid.Visibility = Visibility.Collapsed;
            AccountGrid.Visibility = Visibility.Collapsed;
            SettingsGrid.Visibility = Visibility.Collapsed;
            AboutGrid.Visibility = Visibility.Collapsed;
            activeGrid.Visibility = Visibility.Visible;
        }
    }
}
