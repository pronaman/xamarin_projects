using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Navi_Etc
{
	public class Page4 : ContentPage
	{
		public Page4 ()
		{
            Button homeButton = new Button
            {
                Text = "Go Directly to Home",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            homeButton.Clicked += async (sender, args) =>
            {
                await Navigation.PopToRootAsync();
            };

            // Create Button to swap pages.
            Button swapButton = new Button
            {
                Text = "Swap 2 and 2_2",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            swapButton.Clicked += (sender, args) =>
            {
                IReadOnlyList<Page> navStack = Navigation.NavigationStack;
                Page pageC = navStack[navStack.Count - 2];
                Page existingPageB = navStack[navStack.Count - 3];
                bool isOriginal = existingPageB is Page2;
                Page newPageB = isOriginal ? (Page)new Page2_2() : new Page2();

                // Swap the pages.
                Navigation.RemovePage(existingPageB);
                Navigation.InsertPageBefore(newPageB, pageC);

                // Finished: Disable the Button.
                swapButton.IsEnabled = false;
            };

            Title = "Page 4";
            Content = new StackLayout
            {
                Children =
                {
                    homeButton,
                    swapButton
                }
            };
        }
	}
}