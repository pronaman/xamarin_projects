using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ImageSample.Web
{
	public class WebCode : ContentPage
	{
		public WebCode ()
		{
            Title = "Code";
            string uri = "http://developer.xamarin.com/demo/IMG_1415.JPG";

            Content = new Image
            {
                Source = ImageSource.FromUri(new Uri(uri)),
            };
        }
	}
}