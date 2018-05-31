using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace StylesSamples.DevicesStyles
{
	public class DevicesStylesCodecs : ContentPage
	{
        public DevicesStylesCodecs()
        {
            var NewSubtitleStyle = new Style(typeof(Label))
            {
                BaseResourceKey = Device.Styles.SubtitleStyleKey,
                Setters =
                    {
                        new Setter
                        {
                            Property = Label.TextColorProperty,
                            Value = Color.Accent
                        },
                        new Setter
                        {
                            Property = Label.FontAttributesProperty,
                            Value = FontAttributes.Italic
                        }
                    }
            };

            Title = "DevicesStyles";
            Icon = "csharp.png";
            Padding = new Thickness(0, 20, 0, 0);

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "No style whatsoever", Style = (Style)null },
                    new Label { Text = "Body Style", Style = Device.Styles.BodyStyle },
                    new Label { Text = "Title Style", Style = Device.Styles.TitleStyle },
                    new Label { Text = "Subtitle Style", Style = Device.Styles.SubtitleStyle },
                    new Label { Text = "New Subtitle Style", Style = NewSubtitleStyle },
                    new Label { Text = "Caption Style", Style = Device.Styles.CaptionStyle },
                    new Label { Text = "List Item Text Style", Style = Device.Styles.ListItemTextStyle },
                    new Label { Text = "List Item Detail Text Style", Style = Device.Styles.ListItemDetailTextStyle }
                }
            };
        }
    }
}
