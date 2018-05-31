using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlertSamples
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlertNothing : ContentPage
	{
		public AlertNothing ()
		{
			InitializeComponent ();
		}

        async void OnButtonClicked(object sender, EventArgs args)
        {
            label.Text = "Displaying alert box";
            await DisplayAlert("Simple Alert", "Click 'dismiss' to dismiss", "dismiss");
            label.Text = "Alert has been dismissed";
        }
    }
}