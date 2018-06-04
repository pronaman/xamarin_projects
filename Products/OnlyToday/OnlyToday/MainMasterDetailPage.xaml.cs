using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlyToday.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlyToday
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMasterDetailPage : MasterDetailPage
    {
        public MainMasterDetailPage()
        {
            InitializeComponent();
            xMasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MainMasterDetailPageMenuItem;
            if (item == null)
                return;

            Page page = null;
            switch (item.Id)
            {
                case MainMasterDetailPageMenuItem.MenuNames.Home:
                    page = new HomeTabbedPage();
                    break;
                case MainMasterDetailPageMenuItem.MenuNames.SignIn:
                    page = new SignInPage();
                    break;
                case MainMasterDetailPageMenuItem.MenuNames.Setting:
                    page = new SettingPage();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

           // var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;


            xDetailPage.PushAsync(page);
            //Detail = new NavigationPage(page);
            IsPresented = false;

            xMasterPage.ListView.SelectedItem = null;
        }
    }
}