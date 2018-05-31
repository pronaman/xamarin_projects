using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextSample.Styles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StylesTabs : TabbedPage
	{
		public StylesTabs ()
		{
            Title = "StylesTabs";
            Children.Add(new BuiltInStyles());
            Children.Add(new CustomStyles());
        }
	}
}