using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterDetailTaps : MasterDetailPage
    {
		public MasterDetailTaps ()
		{
			InitializeComponent ();

            IsGestureEnabled = false;
        }

        public override bool ShouldShowToolbarButton()
        {
            return false;
        }

        void OnMasterTapped(object sender, EventArgs args)
        {
            try
            {
                IsPresented = false;
            }
            catch
            {
            }
        }

        void OnDetailTapped(object sender, EventArgs args)
        {
            IsPresented = true;
        }
    }
}