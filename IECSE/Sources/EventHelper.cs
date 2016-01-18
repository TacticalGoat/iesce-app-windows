using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IECSE.Sources
{
    public class EventHelper
    {
        public enum Months { Jan = 1, Feb, Mar, April, May, June, July, Aug, Sept, Oct, Nov, Dec };
        public static async Task<bool> FetchEvents(Months month)
        {
            try
            {
                HttpClient client = new HttpClient();
                
                string uri = "https://iecsemanipal.com/app/events.php";
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string,string>("month","12")

                });
                    var response = await client.PostAsync(uri, content);
                    response.EnsureSuccessStatusCode();
                    var resonseString = response.Content.ReadAsStringAsync().Result;
                    Debug.WriteLine(response.ToString());
                    var responseString = response.Content.ReadAsStringAsync().Result;
                    var ResponseObj = JsonConvert.DeserializeObject<EventResponse>(responseString);

                    switch (ResponseObj.status)
                    {
                        case "602":

                        case "604":
                            return false;

                        case "611":
                            foreach (Event e in ResponseObj.events)
                            {
                                App.fetchedEvents.Add(e);
                            }
                            return true;
                        default:
                            return false;
                    }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
                return false;
            }


        }
    }
}
