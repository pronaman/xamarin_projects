using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabsNavisSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Navi03Xaml : ContentPage
	{
		public Navi03Xaml ()
		{
			InitializeComponent ();
		}

        async void NaviPage_Clicked(object sender, ToggledEventArgs e)
        {
            bool _b = App.GlobalAppData.bNaivState;

            if (_b)
                await Navigation.PushAsync(new Navi04());
            else
                await Navigation.PushModalAsync(new Navi04());
        }

        async void Back_Clicked(object sender, ToggledEventArgs e)
        {
            bool _b = App.GlobalAppData.bNaivState;

            if (_b)
                await Navigation.PopAsync();
            else
                await Navigation.PopModalAsync();
        }
    }
}