using Android.Content;
using Android.Graphics.Drawables;
using Android.Text;
using Shoes;
using Shoes.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(EntryCustom), typeof(EntryCustomRenderer))]

namespace Shoes.Droid
{
    class EntryCustomRenderer : EntryRenderer
    {
        public EntryCustomRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                this.Control.SetBackgroundDrawable(gd);
                this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);

            }

        }
    }
}