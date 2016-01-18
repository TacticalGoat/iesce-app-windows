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
using IECSE.Sources;
using Windows.UI.Popups;
using Newtonsoft.Json;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IECSE.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
            if(!DataHelper.settings.Values.ContainsKey("IsLoggedIn"))
            {
                DataHelper.createSettings();
            }            
            this.Loaded += PageLoaded;
        }

        private void PageLoaded(object sender,RoutedEventArgs e)
        {
            if ((string)DataHelper.settings.Values["IsLoggedIn"] == "True")
            {
                this.Frame.Navigate(typeof(HomePage));
            }
        }

        private  void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void forgotPasswordButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SignUpPage));
        }

        private async void loginButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage));
            string username = userNameBox.Text;
            string password = passwordBox.Password;
            var response = await WebHelper.loginRequest(username, password);
            switch (response.status)
            {
                case "111":
                    this.Frame.Navigate(typeof(HomePage));
                    break;

                default:
                    MessageDialog msg = new MessageDialog("Login Invalid Resopne:"+response.status);
                    await msg.ShowAsync();
                    break;
            }
        }

        private void userNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
