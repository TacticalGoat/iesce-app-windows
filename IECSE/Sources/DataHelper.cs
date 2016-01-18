using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Globalization.DateTimeFormatting;

namespace IECSE.Sources
{
    public static class DataHelper
    {
        public static ApplicationDataContainer settings = Windows.Storage.ApplicationData.Current.LocalSettings;
        public static StorageFolder localStorage = Windows.Storage.ApplicationData.Current.LocalFolder;
        public static void createSettings()
        {
            settings.Values["IsFirstRun"] = "False";
            settings.Values["IsLoggedIn"] = "True";
            settings.Values["Username"] = "abcde";
        }
        
    }
}
