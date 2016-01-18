using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using NotificationsExtensions.Toasts;
using Microsoft.QueryStringDotNET;
using Windows.UI.Notifications;
using Windows.UI.Popups;
using System.Diagnostics;

namespace BackgroundAgent
{
    public sealed class Trigger : IBackgroundTask
    {

        public void Run(IBackgroundTaskInstance taskInstance)
        {
            Debug.WriteLine("Background Task Started!");
            string title = "Holy Balls Background Agent Works!";
            string content = "Shits Great Son!";
            string imageUrl = "http://community.zimbra.com/cfs-file/__key/communityserver-discussions-components-files/1589/girl-happy.JPG";

            ToastVisual visual = new ToastVisual()
            {
                TitleText = new ToastText()
                {
                    Text = title
                },

                BodyTextLine1 = new ToastText()
                {
                    Text = content
                },

                InlineImages =
                {
                    new ToastImage()
                    {
                         Source = new ToastImageSource(imageUrl)
                    }
                }
            };

            ToastContent Tcontent = new ToastContent()
            {
                Visual = visual
            };

            var toast = new ToastNotification(Tcontent.GetXml());
            toast.ExpirationTime = DateTime.Now.AddHours(1);
            toast.Tag = "1";
            toast.Group = "t1";
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }
    }
}
