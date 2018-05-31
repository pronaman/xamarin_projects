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
	public partial class AlertList : ContentPage
	{
		public AlertList ()
		{
			InitializeComponent ();
		}

        async void click_bnt_Clicked(object sender, EventArgs e)
        {
            string str = await DisplayActionSheet("선택해봅시다.", "취소", null, "이메일", "네이버", "페이스북");

            lbl_chage.Text = str;
        }

        async void click_bnt_02_Clicked(object sender, EventArgs e)
        {
            string str = await DisplayActionSheet("선택해봅시다.", "취소", "확인", "사진첩", "이메일", "아무거나?");

            lbl_chage.Text = str;
        }
    }
}