using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navi_Etc
{
	public partial class MainPage : ContentPage
	{
        App app = (App)Application.Current;

        public MainPage()
		{
			InitializeComponent();
		}

        async void NabiClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch ((string)button.StyleId)
            {
                case "SinglePageNavigation":
                    app.nNaviStackCount = App.Current.MainPage.Navigation.NavigationStack.Count;
                    await Navigation.PushAsync(new SinglePageNavigation());
                    break;

                case "MvvmEnforcement":
                    await Navigation.PushAsync(new MvvmEnforcement());
                    break;

                case "StackManipulation":
                    await Navigation.PushAsync(new Page1());
                    break;
            }
        }
    }
}
