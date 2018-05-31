using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlertSamples
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void AlertAwait_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AlertAwait());
        }

        async void AlertCallbacks_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AlertCallBack());
        }

        async void AlertLambda_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AlertLambda());
        }

        async void AlertNothing_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AlertNothing());
        }

        async void AlertList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AlertList());
        }

        async void AlertXaml_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AlertXaml());
        }

        async void AlertCS_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AlertCS());
        }
    }
}
