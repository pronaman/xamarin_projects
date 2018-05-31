using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AlertSamples
{
	public class AlertCS : ContentPage
	{
        Label lbl_text;

        public AlertCS ()
		{
            Title = "Code";

            lbl_text = new Label
            {
                Text = "경고창 예제",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            Button button = new Button
            {
                Text = "경고창 버튼",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            button.Clicked += OnAlertSimpleClicked;

            Button button_02 = new Button
            {
                Text = "확인 취소 경고창",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            button_02.Clicked += OnAlertSelectClicked;

            Button button_03 = new Button
            {
                Text = "선택 경고창",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            button_03.Clicked += OnAlertListClicked;

            Content = new StackLayout
            {
                Children = { lbl_text, button, button_02, button_03 }
            };
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