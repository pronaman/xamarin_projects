using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutOptionSample.Absolutes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsolutesTab : TabbedPage
    {
        public AbsolutesTab ()
        {
            Title = "AbsoluteSample";

            Children.Add(new Absolute_01());
            Children.Add(new Absolute_02());
            Children.Add(new Absolute_03());
            Children.Add(new Absolute_04());

        }
    }
}