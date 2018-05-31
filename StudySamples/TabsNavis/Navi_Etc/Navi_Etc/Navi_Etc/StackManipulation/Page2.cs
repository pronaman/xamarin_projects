using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Navi_Etc
{
	public class Page2 : ContentPage
	{
		public Page2 ()
		{
            Button button = new Button
            {
                Text = "Go to Page 3",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Page3());
            };

            Title = "Page 2";
            Content = button;
        }
	}
}