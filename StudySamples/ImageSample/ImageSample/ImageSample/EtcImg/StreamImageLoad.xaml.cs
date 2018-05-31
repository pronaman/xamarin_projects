using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.IO;
using System.Net;
using System.Reflection;

namespace ImageSample.EtcImg
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StreamImageLoad : ContentPage
	{
		public StreamImageLoad ()
		{
			InitializeComponent ();

            /*
#if __IOS__
            string resourceID = "ImageSample.iOS.Images.IMG_0722_512.jpg";
#elif __ANDROID__
            string resourceID = "ImageSample.Droid.Images.IMG_0722_512.jpg";
#endif
            */

            string resourceID = "ImageSample.Images.IMG_0722_512.jpg";

            if (Device.RuntimePlatform == Device.Android) { }
            else if (Device.RuntimePlatform == Device.iOS) { }

            image1.Source = ImageSource.FromStream(() =>
            {
                Assembly assembly = GetType().GetTypeInfo().Assembly;
                Stream stream = assembly.GetManifestResourceStream(resourceID);
                return stream;
            });

            // Load web bitmap.
            Uri uri = new Uri("http://developer.xamarin.com/demo/IMG_0925.JPG?width=512");
            WebRequest request = WebRequest.Create(uri);
            request.BeginGetResponse((IAsyncResult arg) =>
            {
                Stream stream = request.EndGetResponse(arg).GetResponseStream();

                ImageSource imageSource = ImageSource.FromStream(() => stream);
                Device.BeginInvokeOnMainThread(() => image2.Source = imageSource);
            }, null);
        }
    }
}