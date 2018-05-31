using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesSamples.Inheritance
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InheritanceTab : TabbedPage
    {
		public InheritanceTab ()
		{
            Title = "Inheritance";
            Children.Add(new InheritanceXaml());
            Children.Add(new InheritanceCode());
        }
	}
}