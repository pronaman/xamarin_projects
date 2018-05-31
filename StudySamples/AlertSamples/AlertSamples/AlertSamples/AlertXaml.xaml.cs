using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlertSamples
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlertXaml : ContentPage
	{
		public AlertXaml ()
		{
			InitializeComponent ();
		}

        async void OnAlertSimpleClicked(object sender, EventArgs e)
        {
            await DisplayAlert("경고창", "경고창 입니다.", "OK");
        }

        async void OnAlertSelectClicked(object sender, EventArgs e)
        {
            bool isAlert = await DisplayAlert("선택 경고창", "선택하세요!!", "확인", "취소");

            if (isAlert)
            {
                lbl_text.Text = "확인 선택";
            }
            else
            {
                lbl_text.Text = "취소 선택";
            }
        }

        async void OnAlertListClicked(object sender, EventArgs e)
        {
            string str = await DisplayActionSheet("선택해봅시다.", "취소", null, "이메일", "네이버", "페이스북");

            lbl_text.Text = str;
        }
    }
}