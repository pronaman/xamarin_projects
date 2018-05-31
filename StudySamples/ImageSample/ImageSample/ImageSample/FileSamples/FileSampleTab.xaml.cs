using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageSample.FileSamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FileSampleTab : TabbedPage
    {
        public FileSampleTab ()
        {
            InitializeComponent();

            Title = "File";

            Children.Add(new SampleXaml());
            Children.Add(new SampleCode());
        }
    }
}