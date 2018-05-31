using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutOptionSample.Relative
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RelativePage02 : ContentPage
	{
        double d_Width;
        double d_Height;
        double d_Xcons;
        double d_Ycons;

        public RelativePage02 ()
		{
			InitializeComponent ();

            d_Width = 1;
            d_Height = 1;
            d_Xcons = 1;
            d_Ycons = 1;
        }

        private void sld_01_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            d_Width = ((Slider)sender).Value;
            lbl_width.Text = string.Format("{0:0.000}", d_Width);

            SetBoxRelative();
        }

        private void sld_02_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            d_Height = ((Slider)sender).Value;
            lbl_Height.Text = string.Format("{0:0.000}", d_Height);

            SetBoxRelative();
        }

        private void sld_03_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            d_Xcons = ((Slider)sender).Value;
            lbl_XCon.Text = string.Format("{0:0.000}", d_Xcons);

            SetBoxRelative();
        }

        private void sld_04_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            d_Ycons = ((Slider)sender).Value;
            lbl_YCon.Text = string.Format("{0:0.000}", d_Ycons);

            SetBoxRelative();
        }

        private void SetBoxRelative()
        {
            RelativeLayout.SetWidthConstraint(chagebox, Constraint.Constant(d_Width));
            RelativeLayout.SetHeightConstraint(chagebox, Constraint.Constant(d_Height));
            RelativeLayout.SetXConstraint(chagebox, Constraint.Constant(d_Xcons));
            RelativeLayout.SetYConstraint(chagebox, Constraint.Constant(d_Ycons));
        }
    }
}