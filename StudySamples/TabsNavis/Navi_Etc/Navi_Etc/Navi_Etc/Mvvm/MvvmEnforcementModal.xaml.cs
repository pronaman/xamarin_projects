using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navi_Etc
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MvvmEnforcementModal : ContentPage
	{
		public MvvmEnforcementModal ()
		{
			InitializeComponent ();

            MvvmLittleViewModal viewModel = new MvvmLittleViewModal();
            BindingContext = viewModel;

            // Populate Picker Items list.
            foreach (string language in viewModel.Languages)
            {
                picker.Items.Add(language);
            }
        }

        protected override bool OnBackButtonPressed()
        {
            MvvmLittleViewModal viewModel = (MvvmLittleViewModal)BindingContext;
            return viewModel.IsValid ? base.OnBackButtonPressed() : true;
        }

        async void OnDoneButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}