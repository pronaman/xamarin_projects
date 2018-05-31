using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesSamples.DevicesStyles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DevicesStylesTab : TabbedPage
    {
		public DevicesStylesTab ()
		{
            Title = "DevicesStylesTab";
            Children.Add(new DevicesStylesXaml());
            Children.Add(new DevicesStylesCodecs());
            Children.Add(new DynamicStyles());
            
        }
	}
}