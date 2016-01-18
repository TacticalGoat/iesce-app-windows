using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Newtonsoft.Json;
using IECSE;
using System.Diagnostics;

namespace IECSE.Sources
{
    static class WebHelper
    {
        public enum Months { Jan=1,Feb,Mar,April,May,June,July, Aug, Sept, Oct, Nov, Dec };
        public static async Task<ResopnseCode> loginRequest(string username,string password)
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

                var code = JsonConvert.DeserializeObject<ResopnseCode>(responseString);

                return code;
                
            }catch(Exception e)
            {
                MessageDialog m = new MessageDialog(e.StackTrace);
                await m.ShowAsync();
                return new ResopnseCode("000");
            }
        }
        public static async Task<ResopnseCode> signUpRequest(string email,string fullName,string mobile,string regno,string username,string password)
        {
            try
            {
                HttpClient client = new HttpClient();
                string uri = "https://iecsemanipal.com/app/register.php";
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
                var code = JsonConvert.DeserializeObject<ResopnseCode>(resonseString);
                return code;
            }catch(Exception e)
            { 
                MessageDialog m = new MessageDialog(e.StackTrace);
                await m.ShowAsync();
                return new ResopnseCode("000");
            }
        }

        
    }
}
