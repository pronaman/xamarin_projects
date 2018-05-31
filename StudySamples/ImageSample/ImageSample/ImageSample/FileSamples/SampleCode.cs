using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ImageSample.FileSamples
{
	public class SampleCode : ContentPage
	{
        Label label;

        public SampleCode ()
		{
            Title = "Code";

            Image image = new Image
            {
                /*  Sharde  타입에서 사용하는 방법.
#if __IOS__
                Source = ImageSource.FromResource("ImageSample.iOS.Images.Sculpture_1200x900.jpg"),
#elif __ANDROID__
                Source = ImageSource.FromResource("ImageSample.Droid.Images.Sculpture_1200x900.jpg"),
                //Source = ImageSource.FromFile("Sculpture.jpg"),
#endif
*/
                //Source = ImageSource.FromResource("ImageSample.Images.Sculpture_1200x900.jpg"),
                Source = ImageSource.FromFile("Sculpture.jpg"),
                WidthRequest = 1200,
                HorizontalOptions = LayoutOptions.Center,
            };
            image.SizeChanged += OnImageSizeChanged;

            label = new Label
            {
                Text = "1200 x 900 Pixel Bitmap",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            Content = new StackLayout
            {
                Children = {

                    new Label { Text = "1200 x 900 Pixel Bitmap",
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.Center
                    },

                    image,

                    label,
                }
            };
        }

        void OnImageSizeChanged(object sender, EventArgs args)
        {
            Image image = (Image)sender;
            label.Text = String.Format("Rendered size = {0:F0} x {1:F0}",
                                       image.Width, image.Height);
        }
    }
}