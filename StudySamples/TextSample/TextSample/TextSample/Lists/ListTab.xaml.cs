using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextSample.Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListTab : TabbedPage
    {
        public ListTab ()
        {
            Title = "List";

            Children.Add(new ListXaml());
            Children.Add(new ListCode());
            Children.Add(new TimeLog());
            Children.Add(new ObservableLog());
            
        }
    }
}