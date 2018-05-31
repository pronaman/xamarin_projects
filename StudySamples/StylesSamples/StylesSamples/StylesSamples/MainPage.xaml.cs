using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StylesSamples
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
                case "NoStyles":
                    await Navigation.PushAsync(new NoStyles.NoStyleTab());
                    break;

                case "Explicit":
                    await Navigation.PushAsync(new Explicit.ExplicitStylesTab());
                    break;

                case "Implicit":
                    await Navigation.PushAsync(new Implicit.ImplicitTab());
                    break;

                case "Applicat":
                    await Navigation.PushAsync(new Applicat.ApplicatTab());
                    break;

                case "Inheritance":
                    await Navigation.PushAsync(new Inheritance.InheritanceTab());
                    break;

                case "DevicesStyles":
                    await Navigation.PushAsync(new DevicesStyles.DevicesStylesTab());
                    break;

                case "Hierarchy":
                    await Navigation.PushAsync(new Hierarchy.HierarchySample());
                    break;

                case "DataResources":
                    await Navigation.PushAsync(new DataResources.D_R_Tab());
                    break;
                    
            }
        }
    }
}
