using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Shoes;
using Shoes.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(LabelCustom), typeof(LabelCustomRenderer))]
namespace Shoes.iOS
{
    class LabelCustomRenderer:LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
               
                this.Layer.CornerRadius = 100;
               Control.BackgroundColor = UIColor.LightGray;
            }
        }
    }
}