using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesSamples.Applicat
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApplicatTab : TabbedPage
    {
		public ApplicatTab ()
		{
            Title = "ApplicatTab";

            Children.Add(new ApplicatXaml());
            Children.Add(new ApplicatCode());
        }
    }
}