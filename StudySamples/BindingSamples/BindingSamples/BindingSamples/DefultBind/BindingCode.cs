using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BindingSamples.DefultBind
{
	public class BindingCode : ContentPage
	{
		public BindingCode ()
		{
            Title = "Code";

            Label label = new Label
            {
                Text = "Binding Source Demo",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            Slider slider = new Slider
            {
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            
            Binding binding = new Binding
            {
                Source = slider,
                Path = "Value"
            };
            
            label.SetBinding(Label.OpacityProperty, binding);

            Label label_opac = new Label
            {
                Text = "Opacity Binding Demo",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            Slider slider_opac = new Slider
            {
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            
            label_opac.BindingContext = slider_opac;
            
            label_opac.SetBinding(Label.OpacityProperty, "Value");

            Padding = new Thickness(10, 0);
            Content = new StackLayout
            {
                Children = { label, slider, label_opac, slider_opac }
            };
        }
	}
}