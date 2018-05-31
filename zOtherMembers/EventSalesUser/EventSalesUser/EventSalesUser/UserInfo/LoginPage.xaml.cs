using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Net.Http;

namespace EventSalesUser
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        HttpClient loginclient = new HttpClient();

        bool bSend = false;

        UserInfoViewModel userInfoViewModel;

        public LoginPage (UserInfoViewModel _userInfoViewModel)
		{
			InitializeComponent ();

            userInfoViewModel = _userInfoViewModel;

            loadingOverlay.IsVisible = false;
            bSend = false;
        }

        void OnPassWordToggled(object sender, ToggledEventArgs args)
        {
            passwordEntry.IsPassword = args.Value;
        }

        async void OnBtnBackPage(object sender, ToggledEventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        async void LoginSend(object sender, ToggledEventArgs args)
        {
            if (bSend )
            {
                return;
            }

            bSend = true;
            btnLogin.IsEnabled = !bSend;

            string page = "http://leftcrasher.azurewebsites.net/user/signin";

            try
            {
                loadingOverlay.IsVisible = true;
                waiting.IsRunning = true;

                HttpResponseMessage response = await loginclient.GetAsync(page);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);

                App.sApp.UserState.str_json = responseBody;

                loadingOverlay.IsVisible = false;
                waiting.IsRunning = false;

                App.sApp.UserState.BLogin = true;

                userInfoViewModel.ChageState();

                await Navigation.PopModalAsync();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            loginclient.Dispose();

            bSend = false;
            btnLogin.IsEnabled = !bSend;
        }
    }
}