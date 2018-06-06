using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OnlyToday.Models;
using WYFoundation.Mvvm;
using Xamarin.Forms;

namespace OnlyToday.Pages
{
    public class SaleItemViewModel : ViewModelBase
    {
        SaleItem _item;
        public SaleItemViewModel(SaleItem item)
        {
            _item = item;
        }

        public ImageSource ItemImage {  get { return _item.ItemImage;  } }
        public string Title {  get { return _item.Title;  } }
        public string Description {  get { return _item.Description; } }
    }

    public class SaleItemListPageModel : ViewModelBase
    {
        private ObservableCollection<SaleItemViewModel> _saleItemList = new ObservableCollection<SaleItemViewModel>();

        public ObservableCollection<SaleItemViewModel> SaleItemList
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
          OnAppearing();

            //for (var i = 0; i < 40; i++)
            //    SaleItemList.Add(i.ToString() + ".png");

            //for (var i = 0; i < 40; i++)

            //    Items.Add(i.ToString());

        }

        protected async void OnAppearing()
        {
            var images = await GetImageListAsync();

            ObservableCollection<SaleItemViewModel> saleItemList = new ObservableCollection<SaleItemViewModel>();
            int no = 1;
            foreach (var photo in images.Photos)
            {
                string path = photo + string.Format("?width={0}&height={0}&mode=max",
                    Device.RuntimePlatform == Device.UWP ? 120 : 240);
                saleItemList.Add(new SaleItemViewModel(new SaleItem
                {
                    ItemImage = ImageSource.FromUri(new Uri(path)),
                    Title = (no++).ToString(),
                    //PriceDescription = 
                    //Description = path                    
                }));

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
