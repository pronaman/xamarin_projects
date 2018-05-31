using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindingSamples
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void BtnClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch ((string)button.StyleId)
            {
                case "DefultBind":
                    await Navigation.PushAsync(new DefultBind.BindTab());
                    break;

                case "BindMode":
                    await Navigation.PushAsync(new BindMode());
                    break;

                case "BindPath":
                    await Navigation.PushAsync(new BindPath());
                    break;

                case "BindReverse":
                    await Navigation.PushAsync(new BindReverse());
                    break;

                case "BindValue":
                    await Navigation.PushAsync(new BindValue());
                    break;

                case "BindWebView":
                    await Navigation.PushAsync(new BindWebView());
                    break;
                    
            }
        }
    }
}
