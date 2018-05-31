using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Navi_Etc
{
	public partial class App : Application
	{
        public int nNaviStackCount;

		public App ()
		{
			InitializeComponent();

            nNaviStackCount = 0;
            
            MainPage = new NavigationPage(new Navi_Etc.MainPage());
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
