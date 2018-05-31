using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabsNavisSample
{
	public class Navi02Switch : ContentPage
	{
		public Navi02Switch ()
		{
            Title = "Navi 02 Switch";

            Button button = new Button
            {
                Text = "Navi 03",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += async (sender, args) =>
            {
                bool _b = App.GlobalAppData.bNaivState;

                if (_b)
                    await Navigation.PushAsync(new Navi03Xaml());
                else
                    await Navigation.PushModalAsync(new Navi03Xaml());
            };

            Button buttonback = new Button
            {
                Text = "뒤로가기",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
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