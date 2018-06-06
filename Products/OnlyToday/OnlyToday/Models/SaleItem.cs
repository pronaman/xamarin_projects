using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace OnlyToday.Models
{
    public class SaleItem
    {
        int _marketCode = 0;
        ImageSource _itemImage;
        string _title = "";
        string _description = "";
        int _originalPrice;
        int _discountPrice;


        public int MarketCode { get => _marketCode; set => _marketCode = value; }
        public ImageSource ItemImage { get => _itemImage; set => _itemImage = value; }
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public int OriginalPrice { get => _originalPrice; set => _originalPrice = value; }
        public int DiscountPrice { get => _discountPrice; set => _discountPrice = value; }
    }
}
