using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutOptionSample.Absolutes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Absolute_04 : ContentPage
	{
        double absBox01 = 0.5;
        double absBox02 = 1;
        double absBox03 = 0.5;
        double absBox04 = 1;

        public Absolute_04 ()
		{
			InitializeComponent ();
		}

        private void sld_01_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            absBox01 = ((Slider)sender).Value;
            lbl_01.Text = (string.Format("{0:0.000}", absBox01));

            AbsoluteLayout.SetLayoutBounds(tBoxView, new Rectangle(absBox01, absBox02, absBox03, absBox04));
        }

        private void sld_02_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            absBox02 = ((Slider)sender).Value;
            lbl_02.Text = (string.Format("{0:0.000}", absBox02));

            AbsoluteLayout.SetLayoutBounds(tBoxView, new Rectangle(absBox01, absBox02, absBox03, absBox04));
        }

        private void sld_03_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            absBox03 = ((Slider)sender).Value;
            lbl_03.Text = (string.Format("{0:0.000}", absBox03));

            AbsoluteLayout.SetLayoutBounds(tBoxView, new Rectangle(absBox01, absBox02, absBox03, absBox04));
        }

        private void sld_04_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            absBox04 = ((Slider)sender).Value;
            lbl_04.Text = (string.Format("{0:0.000}", absBox04));

            AbsoluteLayout.SetLayoutBounds(tBoxView, new Rectangle(absBox01, absBox02, absBox03, absBox04));
        }
    }
}