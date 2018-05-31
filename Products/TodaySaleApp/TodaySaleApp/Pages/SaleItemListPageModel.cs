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
        private ObservableCollection<View> _saleItemList = new ObservableCollection<View>();

        public ObservableCollection<View> SaleItemList
        {
            get { return _saleItemList; }
        }


        public SaleItemListPageModel()
        {
            //_saleItemList.Add(new SaleItem());
            //_saleItemList.Add(new SaleItem());
            //_saleItemList.Add(new SaleItem());
            //_saleItemList.Add(new SaleItem());
            //_saleItemList.Add(new SaleItem());

            OnAppearing();

        }

        protected async void OnAppearing()
        {
            var images = await GetImageListAsync();
            foreach (var photo in images.Photos)
            {
                //int cellWidth = (int)Width / 2 - 10;
                var image = new Image
                {
                    Source = ImageSource.FromUri(new Uri(photo + string.Format("?width={0}&height={0}&mode=max", Device.RuntimePlatform == Device.UWP ? 120 : 240)))
                    //Source = ImageSource.FromUri(new Uri(photo + string.Format("?width={0}&height={0}&mode=max", cellWidth)))
                };

                _saleItemList.Add(image);

            }

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
