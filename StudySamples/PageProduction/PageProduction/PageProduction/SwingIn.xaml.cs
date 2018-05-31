using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageProduction
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SwingIn : ContentPage
	{
        public SwingIn()
        {
            InitializeComponent();
        }

            async protected override void OnAppearing()
        {
            base.OnAppearing();

            stackLayout.AnchorX = 0;
            stackLayout.RotationY = 180;
            await stackLayout.RotateYTo(0, 1000, Easing.CubicOut);
            stackLayout.AnchorX = 0.5;
        }
    }
}