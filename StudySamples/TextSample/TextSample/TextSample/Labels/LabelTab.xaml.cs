using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextSample.Labels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelTab : TabbedPage
    {
        public LabelTab ()
        {
            Title = "Label";

            Children.Add(new LabelXaml());
            Children.Add(new LabelCode());
        }
    }
}