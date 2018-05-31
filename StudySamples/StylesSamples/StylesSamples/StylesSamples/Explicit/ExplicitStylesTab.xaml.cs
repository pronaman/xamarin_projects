using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesSamples.Explicit
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExplicitStylesTab : TabbedPage
    {
		public ExplicitStylesTab ()
		{
            Title = "Explici";
            Children.Add(new ExplicitStylesXaml());
            Children.Add(new ExplicitStylesCode());
        }
	}
}