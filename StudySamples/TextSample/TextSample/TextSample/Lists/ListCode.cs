using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TextSample.Lists
{
	public class ListCode : ContentPage
	{
		public ListCode ()
		{
            Title = "Code";
            ListView lstView = new ListView();

            lstView.ItemsSource = new List<Color>
            {
                Color.Aqua, Color.Black, Color.Blue, Color.Fuchsia,
                Color.Gray, Color.Green, Color.Lime, Color.Maroon,
                Color.Navy, Color.Olive, Color.Pink, Color.Purple,
                Color.Red, Color.Silver, Color.Teal, Color.White, Color.Yellow
            };

            Content = new StackLayout {
                Children = {
                    lstView
                }
			};
		}
	}
}