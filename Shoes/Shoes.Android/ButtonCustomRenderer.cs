using Android.Content;
using Shoes;
using Shoes.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(ButtonCustom), typeof(ButtonCustomRenderer))]
namespace Shoes.Droid
{
    class ButtonCustomRenderer : ButtonRenderer
    {
        public ButtonCustomRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            var button = this.Control;
            button.SetAllCaps(false);
        }
    }
}