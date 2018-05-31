using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PageProduction
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
                case "FadeIn":
                    await Navigation.PushAsync(new FadeIn());
                    break;

                case "SlideIn":
                    await Navigation.PushAsync(new SlideIn());
                    break;

                case "SwingIn":
                    await Navigation.PushAsync(new SwingIn());
                    break;
            }
        }
	}
}
