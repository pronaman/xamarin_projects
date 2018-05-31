using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace TodaySaleApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

		    //DevExpress.Mobile.Core
		    MainPage = new MainMasterDetailPage(); //new NavigationPage(new MainTabbedPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
