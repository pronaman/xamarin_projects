using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabsNavisSample
{
	public partial class MainPage : ContentPage
    {
		public MainPage()
		{
            InitializeComponent();
        }

        async void OnNaviPageClicked(object sender, EventArgs args)
        {
            
            App.GlobalAppData.bNaivState = true;
            await Navigation.PushAsync(new TabMain());
        }

        async void OnModalPageClicked(object sender, EventArgs args)
        {
            App.GlobalAppData.bNaivState = false;
            await Navigation.PushModalAsync(new TabMain());
        }
        
    }
}
