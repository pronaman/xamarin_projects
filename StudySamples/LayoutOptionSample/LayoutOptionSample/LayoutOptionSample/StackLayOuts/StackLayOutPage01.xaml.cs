using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutOptionSample.StackLayOuts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackLayOutPage01 : ContentPage
	{
        int currentState = 0;
        int maxStates = 2;

        public StackLayOutPage01 ()
		{
			InitializeComponent ();
		}

        void StackChangeButton_Clicked(object sender, EventArgs e)
        {
            currentState++;
            if (currentState > maxStates)
            {
                currentState = 0;
            }

            switch (currentState)
            {
                case 0:
                    layout.Spacing = 0;
                    StackChangeButton.Text = "Spacing : 0";
                    break;
                case 1:
                    layout.Spacing = 1;
                    StackChangeButton.Text = "Spacing : 1";
                    break;
                case 2:
                    layout.Spacing = 10;
                    StackChangeButton.Text = "Spacing : 10";
                    break;
            }
        }
    }
}