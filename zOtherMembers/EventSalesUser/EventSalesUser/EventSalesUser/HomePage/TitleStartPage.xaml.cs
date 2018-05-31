using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventSalesUser
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TitleStartPage : ContentPage
	{
		public TitleStartPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await TestAsync();
        }

        async Task TestAsync()
        {
            xStackPage.Opacity = 0;
            bool bEnd = await xStackPage.FadeTo(1, 1000);

            await Task.Delay(1500);

            App.sApp.HomeTabPageOn();
        }
    }
}