using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabsNavisSample
{
	public class Navi04 : ContentPage
	{
		public Navi04 ()
		{
            Title = "Navi 4";

            Button homeButton = new Button
            {
                Text = "처음으로 가기",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            homeButton.Clicked += async (sender, args) =>
            {
                await Navigation.PopToRootAsync();
            };

            bool _b = App.GlobalAppData.bNaivState;

            if (_b)
                homeButton.IsEnabled = true;
            else
                homeButton.IsEnabled = false;

            Button swapButton = new Button
            {
                Text = "Navi2, Navi2S 와 교환",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            swapButton.Clicked += (sender, args) =>
            {
                IReadOnlyList<Page> navStack = Navigation.NavigationStack;
                Page pageC = navStack[navStack.Count - 2];
                Page existingPageB = navStack[navStack.Count - 3];
                bool isOriginal = existingPageB is Navi02;
                Page newPageB = isOriginal ? (Page)new Navi02Switch() : new Navi02();
                
                Navigation.RemovePage(existingPageB);
                Navigation.InsertPageBefore(newPageB, pageC);
                
                swapButton.IsEnabled = false;
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
                if (_b)
                    await Navigation.PopAsync();
                else
                    await Navigation.PopModalAsync();
            };

            Content = new StackLayout
            {
                Children =
                {
                    buttonback,
                    homeButton,
                    swapButton,
                }
            };
        }
	}
}