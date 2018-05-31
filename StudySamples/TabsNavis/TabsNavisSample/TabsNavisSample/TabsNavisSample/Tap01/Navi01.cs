using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabsNavisSample
{
	public class Navi01 : ContentPage
	{
		public Navi01 ()
		{
            Title = "Navi 01";

            Button button = new Button
            {
                Text = "Navi02",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            button.Clicked += async (sender, args) =>
            {
                bool _b = App.GlobalAppData.bNaivState;

                if (_b)
                    await Navigation.PushAsync(new Navi02());
                else
                    await Navigation.PushModalAsync(new Navi02());
            };

            Button buttonback = new Button
            {
                Text = "뒤로가기",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            buttonback.Clicked += async (sender, args) =>
            {
                bool _b = App.GlobalAppData.bNaivState;

                if (_b)
                    await Navigation.PopAsync();
                else
                    await Navigation.PopModalAsync();
                
            };

            
            Content = new StackLayout
            {
                Children =
                {
                    button,
                    buttonback
                }
            };
        }
	}
}