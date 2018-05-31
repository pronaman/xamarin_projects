using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace IntegratedSamples
{
	public partial class App : Application
	{
		public App ()
		{   
            InitializeComponent();

		    var contentPage = new ContentPage();
		    MainPage = contentPage;
		    contentPage.Navigation.PushAsync(new IntegratedSamples.MainPage());

            //MainPage = new IntegratedSamples.MainPage();
            //var main = new NavigationPage();
            //main.PushAsync(new MainPage());
            //      MainPage = main;


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
