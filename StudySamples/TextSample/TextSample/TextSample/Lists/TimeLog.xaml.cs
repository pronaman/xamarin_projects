using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextSample.Lists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TimeLog : ContentPage
	{
		public TimeLog ()
		{
			InitializeComponent ();

            List<DateTime> list = new List<DateTime>();
            TimeLogList.ItemsSource = list;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                list.Add(DateTime.Now);
                return true;
            });
        }
	}
}