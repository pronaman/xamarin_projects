using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesSamples.NoStyles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoStyleTab : TabbedPage
    {
        public NoStyleTab ()
        {
            Title = "NoStyle";
            Children.Add(new NoStyleXaml());
            Children.Add(new NoStyleCode());
        }
    }
}