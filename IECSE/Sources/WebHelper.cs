using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace IECSE.Sources
{
    static class WebHelper
    {
        public static async Task<string> loginRequest(string username,string password)
        {
            try {
                HttpClient client = new HttpClient();
                string uri = "http://iecsemanipal.com/app/login.php";
                var content = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string,string>("username",username),
                new KeyValuePair<string, string>("password", password)
                });

                var response = await client.PostAsync(uri, content);

                var responseString = response.Content.ReadAsStringAsync().Result;
                return responseString;
            }catch(Exception e)
            {
                MessageDialog m = new MessageDialog(e.StackTrace);
                await m.ShowAsync();
                return "NULL";
            }
        }
        public static async Task<string> signUpRequest(string email,string fullName,string mobile,string regno,string username,string password)
        {
            try
            {
                HttpClient client = new HttpClient();
                string uri = "http://iecsemanipal.com/app/register.php";
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string,string>("username",username),
                    new KeyValuePair<string,string>("password",username),
                    new KeyValuePair<string,string>("email",email),
                    new KeyValuePair<string,string>("mobile",mobile),
                    new KeyValuePair<string,string>("registrationNumber",regno),
                    new KeyValuePair<string,string>("name",fullName)
                });
                var response = await client.PostAsync(uri, content);
                var resonseString = response.Content.ReadAsStringAsync().Result;
                return resonseString.Substring(11,3); 
            }catch(Exception e)
            { 
                MessageDialog m = new MessageDialog(e.StackTrace);
                await m.ShowAsync();
                return "000";
            }
        }
    }
}
