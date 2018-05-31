using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutOptionSample.Relative
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeTab : TabbedPage
    {
        public RelativeTab ()
        {
            Title = "Relative";
            Children.Add(new RelativePage01());
            Children.Add(new RelativePage02());
        }
    }
}