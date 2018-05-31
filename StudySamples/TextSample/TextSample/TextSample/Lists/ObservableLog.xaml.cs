using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

namespace TextSample.Lists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ObservableLog : ContentPage
	{
		public ObservableLog ()
		{
			InitializeComponent ();

            //using System.Collections.ObjectModel;
            ObservableCollection<DateTime> list = new ObservableCollection<DateTime>();
            ObservableLogList.ItemsSource = list;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                list.Add(DateTime.Now);
                return true;
            });
        }
	}
}