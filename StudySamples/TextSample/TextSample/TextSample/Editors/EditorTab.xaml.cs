using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextSample.Editors
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditorTab : TabbedPage
	{
		public EditorTab ()
		{
            Title = "EditorTabs";
            Children.Add(new EditorXaml());
            Children.Add(new EditorCode());
        }
	}
}