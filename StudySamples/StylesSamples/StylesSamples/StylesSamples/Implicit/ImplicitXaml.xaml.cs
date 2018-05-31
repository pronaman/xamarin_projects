using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesSamples.Implicit
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImplicitXaml : ContentPage
	{
		public ImplicitXaml ()
		{
			InitializeComponent ();
		}
	}
}