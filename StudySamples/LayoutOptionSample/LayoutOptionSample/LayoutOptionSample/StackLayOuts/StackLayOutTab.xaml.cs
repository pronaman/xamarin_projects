using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutOptionSample.StackLayOuts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayOutTab : TabbedPage
    {
        public StackLayOutTab ()
        {
            Title = "StackLayOut";

            Children.Add(new StackLayOutPage01());
            Children.Add(new StackLayOutPage02());
            Children.Add(new StackLayOutPage03());
        }
    }
}