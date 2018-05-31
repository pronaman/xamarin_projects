using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EventSalesUser
{
	public partial class App : Application
	{
        public static App sApp;

        public UserStateClass UserState = new UserStateClass();

        public App ()
		{
			InitializeComponent();

            if(sApp == null )
            {
                sApp = this;
            }

            UserState.Init();

            // 타이틀 메뉴를 보여주고~~
            MainPage = new EventSalesUser.TitleStartPage();

            // 이건 탭바와 탭바텍스트 글자 색을 바꾸기 위한거.
            //Background color
            //MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Black);

            //Title color
            //MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.White);
        }

        public void HomeTabPageOn()
        {
            // 타이틀 메뉴 끝나고 나서 실제 메인 페이지 들어가는거.
            MainPage = new NavigationPage(new EventSalesUser.HomeTabbedPage());
        }

        public async void MsgView(string _title, string _str)
        {
            // 모든 Page 에서 메세지 박스를 출력하기 위함. APP은 최상의 ROOT 라서 다 가능.
            await MainPage.DisplayAlert(_title, _str, "확인");
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
