using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void BtnClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch ((string)button.StyleId)
            {
                case "FileSamples":
                    await Navigation.PushAsync(new FileSamples.FileSampleTab());
                    break;

                case "PlatformsImgLode":
                    await Navigation.PushAsync(new EtcImg.PlatformsImgLode());
                    break;

                case "ImageTaps":
                    await Navigation.PushAsync(new EtcImg.ImageTaps());
                    break;

                case "Stream":
                    await Navigation.PushAsync(new EtcImg.StreamImageLoad());
                    break;

                case "Web":
                    await Navigation.PushAsync(new Web.WebTab());
                    break;

                case "Json":
                    await Navigation.PushAsync(new Json.JsonLoad());
                    break;
            }
        }
    }
}
