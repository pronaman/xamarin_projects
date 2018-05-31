using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageSample.Web
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebTab : TabbedPage
    {
        public WebTab ()
        {
            InitializeComponent();

            Title = "WebLoad";

            Children.Add(new WebLoadXaml());
            Children.Add(new WebCode());
        }
    }
}