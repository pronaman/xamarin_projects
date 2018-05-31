using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindingSamples
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BindWebView : ContentPage
	{
		public BindWebView ()
		{
			InitializeComponent ();
		}

        void OnEntryCompleted(object sender, EventArgs args)
        {
            webView01.Source = ((Entry)sender).Text;
        }

        void OnGoBackClicked(object sender, EventArgs args)
        {
            webView01.GoBack();
        }

        void OnGoForwardClicked(object sender, EventArgs args)
        {
            webView01.GoForward();
        }
    }
}