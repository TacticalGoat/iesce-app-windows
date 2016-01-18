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
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Windows.UI.Popups;

using IECSE.Sources; 

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IECSE.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            this.InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginPage));
        }

        private async void RegisterButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailBox.Text;
            string password1 = PasswordBox1.Password;
            string password2 = PasswordBox2.Password;
            string username = UsernameBox.Text;
            string mobileno = MobileBox.Text;
            string name = textBox.Text;
            string regno = RegistrationNoBox.Text;
            if(!evalEmail(email))
            {
                MessageDialog msg = new MessageDialog("Please Enter A Valid Email ID");
                await msg.ShowAsync();
                return;
            }
            if (!evalMobileNo(mobileno))
            {
                MessageDialog msg = new MessageDialog("Please Enter A Valid 10 Digit Number");
                await msg.ShowAsync();
                return;
            }
            if (!evalPassword(password1,password2))
            {
                MessageDialog msg = new MessageDialog("Passwords Do Not Match!");
                await msg.ShowAsync();
                return;
            }
            if (!evalRegno(regno))
            {
                MessageDialog msg = new MessageDialog("Please Enter A Valid Registration Number");
                await msg.ShowAsync();
                return;
            }

            var response = await WebHelper.signUpRequest(email, name, mobileno, regno, username, password1);
            switch(response.status)
            {
                case "111":
                    MessageDialog msg = new MessageDialog("Registration Successful! Log in to the App to proceed.");
                    await msg.ShowAsync();
                    this.Frame.Navigate(typeof(LoginPage));
                    break;
                default:
                    MessageDialog msg2 = new MessageDialog("Registration Failed Status Code:" + response.status);
                    await msg2.ShowAsync();
                    break;
            }
            
        }

        private bool evalEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);

        }
        private bool evalMobileNo(string mobileNo)
        {
            if (mobileNo.Length != 10)
                return false;
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(mobileNo);
        }
        private bool evalRegno(string regno)
        {
            Regex regex = new Regex(@"^\d{9}");
            return regex.IsMatch(regno);
        }
        private bool evalPassword(string x,string y)
        {
            return (x.Equals(y));
        }
    }
}
