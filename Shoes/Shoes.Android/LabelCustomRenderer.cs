using Android.Content;
using Android.Graphics.Drawables;
using Shoes;
using Shoes.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LabelCustom), typeof(LabelCustomRenderer))]
namespace Shoes.Droid
{
    class LabelCustomRenderer : LabelRenderer
    {
        public LabelCustomRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                float[] radi = { 0, 0, 100, 100, 100, 100, 100, 100 };
                gd.SetCornerRadii(radi);
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                gd.SetStroke(3, Android.Graphics.Color.Silver);
                Control.SetBackgroundDrawable(gd);
                var dnm = (int)App.ScreenWidth / 30;
                Control.SetPaddingRelative(dnm, dnm, dnm, dnm);
            }
        }
    }
}