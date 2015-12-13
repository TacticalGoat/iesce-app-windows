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
            string username = userNameBox.Text;
            string password = passwordBox.Password;
            string response = await WebHelper.loginRequest(username, password);
            string code = response.Substring(11, 3);
            switch (code)
            {
                case "111":
                    this.Frame.Navigate(typeof(HomePage));
                    break;

                default:
                    MessageDialog msg = new MessageDialog("Login Invalid Resopne:"+code);
                    await msg.ShowAsync();
                    break;
            }
        }

        private void userNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
