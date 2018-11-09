using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shoes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppStyle : ResourceDictionary
    {
        public float SmallFont { get; set; }

        public AppStyle ()
		{
			InitializeComponent ();
            SmallFont = 80;

        }
	}
}