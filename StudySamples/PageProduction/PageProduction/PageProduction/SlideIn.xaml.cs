﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageProduction
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SlideIn : ContentPage
	{
		public SlideIn ()
		{
			InitializeComponent ();
		}

        async protected override void OnAppearing()
        {
            base.OnAppearing();

            double offset = 1000;

            foreach (View view in stackLayout.Children)
            {
                view.TranslationX = offset;
                offset *= -1;
            }

            foreach (View view in stackLayout.Children)
            {
                await Task.WhenAny(view.TranslateTo(0, 0, 1000, Easing.SpringOut),
                                   Task.Delay(100));
            }
        }
    }
}