using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Navi_Etc
{
	public class Page3 : ContentPage
	{
		public Page3 ()
		{
            Button button = new Button
            {
                Text = "Go to Page 4",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Page4());
            };

            Title = "Page 3";
            Content = button;
        }
	}
}