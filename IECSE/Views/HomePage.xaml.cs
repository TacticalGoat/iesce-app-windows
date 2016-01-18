using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using BackgroundAgent;
using Windows.UI.Popups;
using System.Diagnostics;
using IECSE.Sources;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Shapes;
using Windows.UI;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IECSE.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
            fetchEvents();
           // this.Loaded += onComplete;
        }

        private void onComplete(object sender,RoutedEventArgs e)
        {
            //RegisterBackgroundTask();
            //fetchEvents();

        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void StuffButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StuffPage));
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingsPage));
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AboutPage));
        }
        private async void RegisterBackgroundTask()
        {
            var taskRegisterd = false;
            var taskName = "BackgroundAgent1";
            var entryPoint = "BackgroundAgent.Trigger";
            foreach(var task in BackgroundTaskRegistration.AllTasks)
            {
                if(task.Value.Name == taskName)
                {
                    taskRegisterd = true;
                    task.Value.Unregister(true);
                    break;
                }
            }

            taskRegisterd = false;
            if(!taskRegisterd)
            {
                var builder = new BackgroundTaskBuilder();

                builder.Name = taskName;
                builder.TaskEntryPoint = entryPoint;
                var mtrigger = new MaintenanceTrigger(16, false);
                builder.SetTrigger(mtrigger);

                var status = await BackgroundExecutionManager.RequestAccessAsync();
                switch(status)
                {
                    case BackgroundAccessStatus.Unspecified:
                        
                    case BackgroundAccessStatus.Denied:
                                            Debug.WriteLine("Access Denied!");
                        break;

                    default:
                        Debug.WriteLine("Fucking Unregister Task Idiot!");
                        break;
                }
                BackgroundTaskRegistration task = builder.Register();
                var msgbox = new MessageDialog("Background Task Registered");
                await msgbox.ShowAsync();
            }
        
            UpdateLayout();
        }
        private async void fetchEvents()
        {
            FetchingProgressRing.Visibility = Visibility.Visible;
            var result = await EventHelper.FetchEvents(EventHelper.Months.Dec);
            if (result) 
            {
                foreach(Event e in App.fetchedEvents)
                {
                    var childstack = new StackPanel();
                    BitmapImage imageSource;
                    try
                    {
                        imageSource = new BitmapImage(new Uri(e.imageURL));
                    }catch(Exception f)
                    {
                        imageSource = new BitmapImage(new Uri("https://qph.is.quoracdn.net/main-thumb-t-349203-200-iysjqstfpmvmozcumxwqpazwgasfsieo.jpeg"));
                    }

                    if(imageSource == null)
                    {
                        imageSource = new BitmapImage(new Uri("https://qph.is.quoracdn.net/main-thumb-t-349203-200-iysjqstfpmvmozcumxwqpazwgasfsieo.jpeg"));
                    }
                    var image = new Image();
                    image.Source = imageSource;
                    image.MaxHeight = 150;
                    image.Stretch = Stretch.Fill;
                    var titleBlock = new TextBlock();
                    titleBlock.Text = e.name;
                    titleBlock.Style = (Style)Application.Current.Resources["SubtitleTextBlockStyle"];
                    var descBlock = new TextBlock();
                    descBlock = new TextBlock();
                    descBlock.Style = (Style)Application.Current.Resources["BodyTextBlockStyle"];
                    descBlock.Text = e.description;
                    Rectangle r = new Rectangle();
                    r.Height = 2;
                    r.Fill = new SolidColorBrush(Colors.White);
                    r.Width = 50;
                    r.HorizontalAlignment = HorizontalAlignment.Center;
                    r.Margin = new Thickness(5);
                    childstack.BorderThickness = new Thickness(5); 
                    childstack.Children.Add(titleBlock);
                    childstack.Children.Add(image);
                    childstack.Children.Add(descBlock);
                    childstack.Children.Add(r);

                    EventsMainStack.Children.Add(childstack);
                }
                FetchingProgressRing.Visibility = Visibility.Collapsed;

            }

            else
            {
                UnableToFetchEvents.Visibility = Visibility.Visible;
            }
        }

        private void GetEventsButton_Click(object sender, RoutedEventArgs e)
        {
            fetchEvents();
        }
    }
}
