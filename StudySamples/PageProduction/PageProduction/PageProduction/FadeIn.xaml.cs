using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageProduction
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FadeIn : ContentPage
	{
		public FadeIn ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            

            stackLayout.Opacity = 0;
            stackLayout.FadeTo(1, 3000);
        }
    }
}