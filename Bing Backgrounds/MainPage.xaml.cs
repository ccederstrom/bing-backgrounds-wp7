using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Media.Imaging;

namespace Bing_Backgrounds
{
    public partial class MainPage : PhoneApplicationPage
    {
        // create class for this http://dennisdel.com/blog/how-to-get-wp7-sized-bing-wallpapers
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Uri uri = new Uri("http://appserver.m.bing.net/BackgroundImageService/TodayImageService.svc/GetTodayImage?dateOffset=0&urlEncodeHeaders=true&osName=wince&osVersion=7.10&orientation=480x800&deviceName=WP7Device&mkt=en-US&AppId=1", UriKind.Absolute);
            BackgroundImage.Source = new BitmapImage(uri);
        }
    }
}