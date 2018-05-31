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
	public partial class ListXaml : ContentPage
	{
		public ListXaml ()
		{
			InitializeComponent ();

            Array.Sort<Color>((Color[])listView.ItemsSource,
                (Color color1, Color color2) =>
                {
                    if (color1.Hue == color2.Hue)
                        return Math.Sign(color1.Luminosity - color2.Luminosity);

                    return Math.Sign(color1.Hue - color2.Hue);
                });
        }
	}
}

