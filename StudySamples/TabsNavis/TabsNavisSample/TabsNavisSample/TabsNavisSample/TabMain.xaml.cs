using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabsNavisSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabMain : TabbedPage
    {
        public TabMain ()
		{
            Children.Add(new Tap_01());
            Children.Add(new Tap_02());
        }
        
    }
}