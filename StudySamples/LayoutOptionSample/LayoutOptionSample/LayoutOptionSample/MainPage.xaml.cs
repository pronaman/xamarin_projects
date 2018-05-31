using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutOptionSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void BtnClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch ((string)button.StyleId)
            {
                case "Relative":
                    await Navigation.PushAsync(new Relative.RelativeTab());
                    break;

                case "Alignment":
                    await Navigation.PushAsync(new Alignment.AlignmentTab());
                    break;

                case "Expansion":
                    await Navigation.PushAsync(new Expansion.ExpansionTab());
                    break;

                case "Absolutes":
                    await Navigation.PushAsync(new Absolutes.AbsolutesTab());
                    break;

                case "Grids":
                    await Navigation.PushAsync(new Grids.GridsTab());
                    break;

                case "StackLayOuts":
                    await Navigation.PushAsync(new StackLayOuts.StackLayOutTab());
                    break;
                    
            }
        }
    }
}
