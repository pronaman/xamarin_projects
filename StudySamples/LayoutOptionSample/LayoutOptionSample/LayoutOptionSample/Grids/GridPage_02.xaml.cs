using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutOptionSample.Grids
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridPage_02 : ContentPage
	{
        int rowHeightValue = 1;

        public GridPage_02 ()
		{
			InitializeComponent ();
		}

        void SliderHeight_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue * 10 > rowHeightValue + .5 && rowHeightValue < 5)
            {
                rowHeightValue++;
            }

            if (e.NewValue * 10 < rowHeightValue - .5 && rowHeightValue > 1)
            {
                rowHeightValue--;
            }

            firstRow.Height = new GridLength(rowHeightValue, GridUnitType.Star);
        }
    }
}