using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TodaySaleApp.Models;
using WYFoundation.Mvvm;
using Xamarin.Forms;

namespace TodaySaleApp.Pages
{
    public class SaleItemListPageModel : ViewModelBase
    {
        private ObservableCollection<string> _items = new ObservableCollection<string>();

        public ObservableCollection<string> Items
        {
            get
            {
                return _items;
            }

            set
            {
                _items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        private ObservableCollection<ImageSource> _saleItemList = new ObservableCollection<ImageSource>();

        public ObservableCollection<ImageSource> SaleItemList
        {
            get { return _saleItemList; }
            set
            {
                _saleItemList = value;
                OnPropertyChanged(nameof(SaleItemList));
            }
        }


        public SaleItemListPageModel()
        {
            //_saleItemList.Add(new SaleItem());
            //_saleItemList.Add(new SaleItem());
            //_saleItemList.Add(new SaleItem());
            //_saleItemList.Add(new SaleItem());
            //_saleItemList.Add(new SaleItem());

          OnAppearing();

            for (var i = 0; i < 40; i++)
                SaleItemList.Add(i.ToString() + ".png");

            for (var i = 0; i < 40; i++)

                Items.Add(i.ToString());

        }

        protected async void OnAppearing()
        {
            var images = await GetImageListAsync();

            ObservableCollection<ImageSource> saleItemList = new ObservableCollection<ImageSource>();
            foreach (var photo in images.Photos)
            {
                string path = photo + string.Format("?width={0}&height={0}&mode=max",
                    Device.RuntimePlatform == Device.UWP ? 120 : 240);
                saleItemList.Add(ImageSource.FromUri(new Uri(path)));

               // saleItemList.Add(path);
            }

            SaleItemList = saleItemList;

        }

        async Task<ImageList> GetImageListAsync()
        {
            var requestUri = "https://docs.xamarin.com/demo/stock.json";
            using (var client = new HttpClient())
            {
                var result = await client.GetStringAsync(requestUri);
                return JsonConvert.DeserializeObject<ImageList>(result);
            }
        }
    }
}
