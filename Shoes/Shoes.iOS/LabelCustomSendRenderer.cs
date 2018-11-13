using Shoes;
using Shoes.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(LabelCustomSend), typeof(LabelCustomSendRenderer))]
namespace Shoes.iOS
{
    class LabelCustomSendRenderer:LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Layer.CornerRadius = 10;
                Layer.MaskedCorners = (CoreAnimation.CACornerMask)14;
                var color = Color.FromRgb(191, 182, 167);
                Control.BackgroundColor = color.ToUIColor();
                Layer.MasksToBounds = true;
            }
        }
    }
}