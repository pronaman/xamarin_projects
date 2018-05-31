using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodaySaleApp.Pages
{
    class ImageList
    {
        public List<string> Photos = null;
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SaleItemListPage : ContentView
	{
		public SaleItemListPage ()
		{
            
			InitializeComponent ();

            BindingContext = new SaleItemListPageModel();

            //OnAppearing();
        }
    }
}