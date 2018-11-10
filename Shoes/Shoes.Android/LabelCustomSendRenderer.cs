using Android.Content;
using Android.Graphics.Drawables;
using Shoes;
using Shoes.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LabelCustomSend), typeof(LabelCustomSendRenderer))]
namespace Shoes.Droid
{
    class LabelCustomSendRenderer : LabelRenderer
    {
        public LabelCustomSendRenderer(Context context) : base(context)
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
                gd.SetColor(global::Android.Graphics.Color.Rgb(191, 182, 167));
                Control.SetBackgroundDrawable(gd);
                var dnm = (int)App.ScreenWidth / 30;
                Control.SetPaddingRelative(dnm, dnm, dnm, dnm);
            }

        }
    }
}