using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Diagnostics;

namespace Navi_Etc
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SinglePageNavigation : ContentPage
	{
        static int count = 0;
        static bool firstPageAppeared = false;
        static readonly string separator = new string('-', 20);

        public SinglePageNavigation ()
		{
			InitializeComponent ();

            Title = "Page " + count++;
        }

        async void OnGoToModelessClicked(object sender, EventArgs args)
        {
            SinglePageNavigation newPage = new SinglePageNavigation();
            Debug.WriteLine(separator);
            Debug.WriteLine("Calling PushAsync from {0} to {1}", this, newPage);
            await Navigation.PushAsync(newPage);
            Debug.WriteLine("PushAsync completed");

            // Display the page stack information on this page.
            newPage.DisplayInfo();
        }

        async void OnGoToModalClicked(object sender, EventArgs args)
        {
            SinglePageNavigation newPage = new SinglePageNavigation();
            Debug.WriteLine(separator);
            Debug.WriteLine("Calling PushModalAsync from {0} to {1}", this, newPage);
            await Navigation.PushModalAsync(newPage);
            Debug.WriteLine("PushModalAsync completed");

            // Display the page stack information on this page.
            newPage.DisplayInfo();
        }

        async void OnGoBackModelessClicked(object sender, EventArgs args)
        {
            Debug.WriteLine(separator);
            Debug.WriteLine("Calling PopAsync from {0}", this);
            Page page = await Navigation.PopAsync();
            Debug.WriteLine("PopAsync completed and returned {0}", page);

            // Display the page stack information on the page being returned to.
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((SinglePageNavigation)navPage.CurrentPage).DisplayInfo();
        }

        async void OnGoBackModalClicked(object sender, EventArgs args)
        {
            Debug.WriteLine(separator);
            Debug.WriteLine("Calling PopModalAsync from {0}", this);
            Page page = await Navigation.PopModalAsync();
            Debug.WriteLine("PopModalAsync completed and returned {0}", page);

            // Display the page stack information on the page being returned to.
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((SinglePageNavigation)navPage.CurrentPage).DisplayInfo();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("{0} OnAppearing", Title);

            if (!firstPageAppeared)
            {
                DisplayInfo();
                firstPageAppeared = true;
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Debug.WriteLine("{0} OnDisappearing", Title);
        }

        // Identify each instance by its Title.
        public override string ToString()
        {
            return Title;
        }

        public void DisplayInfo()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;

            currentPageLabel.Text = String.Format("NavigationPage.CurrentPage = {0}",
                                                  navPage.CurrentPage);
            
            IReadOnlyList<Page> navStack = navPage.Navigation.NavigationStack;
            IReadOnlyList<Page> modStack = navPage.Navigation.ModalStack;
            
            int modelessCount = navStack.Count;
            int modalCount = modStack.Count;
            
            modelessStackLabel.Text = String.Format("NavigationStack has {0} page{1}{2}",
                                                    modelessCount,
                                                    modelessCount == 1 ? "" : "s",
                                                    ShowStack(navStack));

            modalStackLabel.Text = String.Format("ModalStack has {0} page{1}{2}",
                                                 modalCount,
                                                 modalCount == 1 ? "" : "s",
                                                 ShowStack(modStack));
            
            bool noModals = modalCount == 0 || (modalCount == 1 && modStack[0] is NavigationPage);

            App app = (App)Application.Current;
            modelessCount -= app.nNaviStackCount;

            modelessGoToButton.IsEnabled = noModals;
            modelessBackButton.IsEnabled = modelessCount > 1 && noModals;
            modalBackButton.IsEnabled = !noModals;
        }

        string ShowStack(IReadOnlyList<Page> pageStack)
        {
            if (pageStack.Count == 0)
                return "";

            StringBuilder builder = new StringBuilder();

            foreach (Page page in pageStack)
            {
                builder.Append(builder.Length == 0 ? " (" : ", ");
                builder.Append(StripNamespace(page));
            }

            builder.Append(")");
            return builder.ToString();
        }

        string StripNamespace(Page page)
        {
            string pageString = page.ToString();

            if (pageString.Contains("."))
                pageString = pageString.Substring(pageString.LastIndexOf('.') + 1);

            return pageString;
        }
    }
}