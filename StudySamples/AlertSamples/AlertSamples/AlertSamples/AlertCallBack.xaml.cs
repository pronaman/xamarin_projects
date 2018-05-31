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
	public partial class AlertCallBack : ContentPage
	{
        bool result;

        public AlertCallBack ()
		{
			InitializeComponent ();
		}

        void OnButtonClicked(object sender, EventArgs args)
        {
            Task<bool> task = DisplayAlert("Simple Alert", "Decide on an option",
                                           "yes or ok", "no or cancel");
            task.ContinueWith(AlertDismissedCallback);
            label.Text = "Alert is currently displayed";
        }

        void AlertDismissedCallback(Task<bool> task)
        {
            result = task.Result;
            Device.BeginInvokeOnMainThread(DisplayResultCallback);
        }

        void DisplayResultCallback()
        {
            label.Text = String.Format("Alert {0} button was pressed",
                                       result ? "OK" : "Cancel");
        }
    }
}