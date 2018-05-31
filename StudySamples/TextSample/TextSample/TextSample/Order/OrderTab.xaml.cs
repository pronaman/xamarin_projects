using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextSample.Order
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderTab : TabbedPage
    {
        public OrderTab ()
        {
            Title = "Order";

            Children.Add(new OrderXaml());
            Children.Add(new OrderCode());
        }
    }
}