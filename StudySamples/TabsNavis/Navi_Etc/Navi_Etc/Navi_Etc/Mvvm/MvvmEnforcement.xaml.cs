using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navi_Etc
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MvvmEnforcement : ContentPage
	{
		public MvvmEnforcement ()
		{
			InitializeComponent ();
		}

        async void OnGoToButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new MvvmEnforcementModal());
        }
    }
}