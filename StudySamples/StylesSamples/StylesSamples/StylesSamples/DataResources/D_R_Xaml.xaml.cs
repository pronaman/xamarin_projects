using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesSamples.DataResources
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class D_R_Xaml : ContentPage
	{
		public D_R_Xaml ()
		{
			InitializeComponent ();

            Device.StartTimer(TimeSpan.FromSeconds(1),
                () =>
                {
                    Resources["currentDateTime"] = DateTime.Now.ToString();
                    return true;
                });
        }
	}
}