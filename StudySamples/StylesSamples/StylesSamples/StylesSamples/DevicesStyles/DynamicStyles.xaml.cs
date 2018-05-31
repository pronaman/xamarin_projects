using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesSamples.DevicesStyles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DynamicStyles : ContentPage
	{
		public DynamicStyles ()
		{
			InitializeComponent ();
		}

        void OnButton1Clicked(object sender, EventArgs args)
        {
            Resources["DynamicBtnStyle"] = Resources["BtnStyle01"];
        }

        void OnButton2Clicked(object sender, EventArgs args)
        {
            Resources["DynamicBtnStyle"] = Resources["BtnStyle02"];
        }

        void OnButton3Clicked(object sender, EventArgs args)
        {
            Resources["DynamicBtnStyle"] = Resources["BtnStyle03"];
        }

        void OnResetButtonClicked(object sender, EventArgs args)
        {
            Resources["DynamicBtnStyle"] = null;
        }
    }
}