using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TextSample
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
                case "Styles":
                    await Navigation.PushAsync(new Styles.StylesTabs());
                    break;

                case "Editor":
                    await Navigation.PushAsync(new Editors.EditorTab());
                    break;

                case "Entry":
                    await Navigation.PushAsync(new Entrys.EntryTabs());
                    break;

                case "Label":
                    await Navigation.PushAsync(new Labels.LabelTab());
                    break;

                case "List":
                    await Navigation.PushAsync(new Lists.ListTab());
                    break;

                case "Login":
                    await Navigation.PushAsync(new Logins.LoginTab());
                    break;

                case "Order":
                    await Navigation.PushAsync(new Order.OrderTab());
                    break;
            }
        }
    }
}
