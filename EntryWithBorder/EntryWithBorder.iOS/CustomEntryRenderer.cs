using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntryWithBorder.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace EntryWithBorder.iOS
{
    public class CustomEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                // Create a custom border with square corners
                Control.BorderStyle = UITextBorderStyle.None;
                Control.Layer.CornerRadius = 0;
                Control.Layer.BorderWidth = .5f;
                Control.Layer.BorderColor = UIColor.FromRGB(200, 200, 200).CGColor;
            }
        }
    }
}