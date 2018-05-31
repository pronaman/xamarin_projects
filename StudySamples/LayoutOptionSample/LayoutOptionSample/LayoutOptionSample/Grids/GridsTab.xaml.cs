using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutOptionSample.Grids
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridsTab : TabbedPage
    {
        public GridsTab ()
        {
            Title = "Grid";

            Children.Add(new GridPage_01());
            Children.Add(new GridPage_02());
            Children.Add(new GridPage_03());
            Children.Add(new GridPage_04());
        }
    }
}