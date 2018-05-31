using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextSample.Logins
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginTab : TabbedPage
    {
        public LoginTab ()
        {
            Title = "Login";

            Children.Add(new LoginXaml());
            Children.Add(new LoginCode());
        }
    }
}