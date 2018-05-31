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
	public partial class Tap_01 : ContentPage
	{
        public Tap_01()
        {
            InitializeComponent();
        }

        async void NaviPage_Clicked(object sender, ToggledEventArgs e)
        {
            Page detailPage = new Navi01();

            bool _b = App.GlobalAppData.bNaivState;

            if (_b)
                await Navigation.PushAsync(detailPage);
            else
                await Navigation.PushModalAsync(detailPage);
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