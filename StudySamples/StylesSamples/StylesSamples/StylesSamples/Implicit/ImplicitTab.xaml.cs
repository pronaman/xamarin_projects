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
    public partial class ImplicitTab : TabbedPage
    {
        public ImplicitTab ()
        {
            Title = "Implicit";

            Children.Add(new ImplicitXaml());
            Children.Add(new ImplicitCode());
        }
    }
}