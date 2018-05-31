using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventSalesUser
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserInfoPage : ContentPage
	{
        UserInfoViewModel cViewModel;

        public UserInfoPage ()
		{
			InitializeComponent ();

            // 뷰 모델을 만들어서 서로 기억을 하게 해놓고 
            // 이렇게 바인딩을 연결해서 쓰게 되면 MVVM 에서 이 페이지를 호출해서 경고문을 띄울수있다.
            cViewModel = new UserInfoViewModel();

            cViewModel.OnAlert += CViewModel_OnAlert;

            cViewModel.Init(this);

            BindingContext = cViewModel;

            // this.Parent 부모 계층을 탐색할수 있다. 근데 형변환 해서 서야하나?
        }

        private async void CViewModel_OnAlert(string txt)
        {
            await DisplayAlert("errer", txt, "OK");
        }

        public void PageChageed()
        {
            if (cViewModel != null)
            {
                cViewModel.LoginStateCheck();
            }
        }
    }
}