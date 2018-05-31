using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void NabiClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch ((string)button.StyleId)
            {
                case "Behaviors":
                    await Navigation.PushAsync(new Behaviors.DemoPage());
                    break;

                case "Taps":
                    await Navigation.PushAsync(new MasterDetailTaps());
                    break;
            }
        }
    }
}
