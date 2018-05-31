using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesSamples.DataResources
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class D_R_Tab : TabbedPage
    {
        public D_R_Tab ()
        {
            InitializeComponent();

            Title = "D_R";

            Children.Add(new D_R_Xaml());
            Children.Add(new D_R_Code());
        }
    }
}