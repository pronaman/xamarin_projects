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
	public partial class Tap_02 : ContentPage
	{
		public Tap_02 ()
		{
			InitializeComponent ();

            bool _b = App.GlobalAppData.bNaivState;
            NaviBtn.IsEnabled = _b;
        }

        async void OnNaviBack_01_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NaviBack01());
        }

        async void OnNaviBack_02_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new NaviBack02());
        }

        async void OnBackPageClicked(object sender, ToggledEventArgs e)
        {
            bool _b = App.GlobalAppData.bNaivState;

            if (_b)
            {
                await Navigation.PopAsync();
            }
            else
            {
                await Navigation.PopModalAsync();
            }
        }
    }
}