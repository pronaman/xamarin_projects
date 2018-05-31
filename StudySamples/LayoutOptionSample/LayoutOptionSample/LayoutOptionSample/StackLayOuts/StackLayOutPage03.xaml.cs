using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutOptionSample.StackLayOuts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackLayOutPage03 : ContentPage
	{
		public StackLayOutPage03 ()
		{
			InitializeComponent ();
		}

        async void click_HorizontalOptions(object sender, EventArgs e)
        {
            string str = await DisplayActionSheet("HorizontalOptions.", "취소", null,
                "CenterAndExpand",
                "EndAndExpand",
                "FillAndExpand",
                "StartAndExpand",
                "Center",
                "End",
                "Fill",
                "Start");

            lbl_HorizontalOptions.Text = "HorizontalOptions : " + str;

            ChageBox.HorizontalOptions = SetOptionToStr(str);
        }

        async void click_VerticalOptions(object sender, EventArgs e)
        {
            string str = await DisplayActionSheet("VerticalOptions.", "취소", null,
                "CenterAndExpand",
                "EndAndExpand",
                "FillAndExpand",
                "StartAndExpand",
                "Center",
                "End",
                "Fill",
                "Start");

            lbl_VerticalOptions.Text = "VerticalOptions : " + str;

            ChageBox.VerticalOptions = SetOptionToStr(str);
        }

        LayoutOptions SetOptionToStr(string _str)
        {
            LayoutOptions layoutOptions = LayoutOptions.Center;

            switch (_str)
            {
                case "CenterAndExpand":
                    layoutOptions = LayoutOptions.CenterAndExpand;
                    break;
                case "EndAndExpand":
                    layoutOptions = LayoutOptions.EndAndExpand;
                    break;
                case "FillAndExpand":
                    layoutOptions = LayoutOptions.FillAndExpand;
                    break;
                case "StartAndExpand":
                    layoutOptions = LayoutOptions.StartAndExpand;
                    break;
                case "Center":
                    layoutOptions = LayoutOptions.Center;
                    break;
                case "End":
                    layoutOptions = LayoutOptions.End;
                    break;
                case "Fill":
                    layoutOptions = LayoutOptions.Fill;
                    break;
                case "Start":
                    layoutOptions = LayoutOptions.Start;
                    break;
            }

            return layoutOptions;
        }
    }
}

/*
CenterAndExpand - 레이아웃을 뷰의 중심에 배치하고 레이아웃이 제공하는만큼 공간을 차지하도록 확장합니다.
EndAndExpand - 뷰를 레이아웃 끝 (맨 아래 또는 가장 오른쪽 경계)에 배치하고 펼쳐서 레이아웃이 제공하는만큼의 공간을 차지합니다.
FillAndExpand - 패딩이없고 레이아웃에서 제공하는만큼의 공간을 차지하도록 뷰를 배치합니다.
StartAndExpand - 레이아웃 시작 부분에 뷰를 배치하고 부모가 제공하는만큼의 공간을 차지합니다.
    
Center - 레이아웃 내에서 뷰의 중앙에 배치됩니다.
End - 레이아웃의 끝에 뷰를 배치합니다 (맨 아래 또는 맨 오른쪽 경계).
Fill - 패딩이 없도록보기를 배치합니다.
Start - 레이아웃 시작 부분에 뷰를 배치합니다.
 * */
