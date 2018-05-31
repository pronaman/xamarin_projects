using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms.Xaml;
using Xamarin.Forms;

// https://docs.microsoft.com/ko-kr/xamarin/xamarin-forms/user-interface/images?tabs=vswin 참조
// XAML을 사용하여 부분 참조
// 쉽게 말하자면 XAML 에서는 소스를 바로 로드해서 사용 할 수 없기 때문에 이렇게 바인딩으로 연결해준다는거다.

namespace EventSalesUser
{
    [ContentProperty("Source")]
    class MyImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            return ImageSource.FromResource(Source);
        }
    }
}
