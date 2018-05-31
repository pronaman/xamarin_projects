using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Navi_Etc
{
	public class Page1 : ContentPage
	{
		public Page1 ()
		{
            Button button = new Button
            {
                Text = "Go to Page 2",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Page2());
            };

            Title = "Page 1";
            Content = button;
        }
	}
}