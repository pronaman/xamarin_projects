using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindingSamples.DefultBind
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindTab : TabbedPage
    {
        public BindTab ()
        {
            InitializeComponent();

            Children.Add(new BindingXaml());
            Children.Add(new BindingCode());
        }
    }
}